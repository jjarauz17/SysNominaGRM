Public Class frmGenPagoNominaElectronica

    Private Shared ChildInstance As frmGenPagoNominaElectronica = Nothing
    Public Shared Function Instance() As frmGenPagoNominaElectronica
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGenPagoNominaElectronica()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Public Periodo, TPeriodo As String
    Public PN As New VB.SysContab.PeriodoNominaDetails()
    Public Per As New VB.SysContab.PeriodoNominaDB()
    Dim Empresa As New VB.SysContab.EmpresasDetails
    Dim Iniciado As Boolean = False
#End Region


    Private Sub frmGenPagoNominaElectronica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Bancos.DataSource = VB.SysContab.Catalogo_BancosDB.CatalogoBancos(True).Tables(0)
        '
        If vLista.DataRowCount = 0 Then
            cmdGenerar.Enabled = False
        Else
            cmdGenerar.Enabled = True
        End If

        Me.vLista.Columns("Codigo").Visible = False
        Me.vLista.Columns("Cuenta").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Nombre").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Siglas").Visible = False
        Me.vLista.Columns("CPlanilla").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Formato").Visible = False
        Me.vLista.Columns("Funcion").Visible = False

        'If tabla.Rows.Count > 0 Then
        '    Me.txtConsecutivo.Text = (CDbl(IIf(Me.GCCuentasBancos.Item(Me.GCCuentasBancos.CurrentRowIndex, 4) = "", 0, Me.GCCuentasBancos.Item(Me.GCCuentasBancos.CurrentRowIndex, 4))) + 1).ToString.PadLeft(5, "0")
        '    PN = VB.SysContab.PeriodoNominaDB.GetDetails(Me.TPeriodo & Me.Periodo)
        '    If PN.Tipo <> "A" And PN.Tipo <> "V" Then
        '        Me.dtpAPagar.Value = PN.FFinal
        '    Else
        '        Me.dtpAPagar.Value = Today.Date
        '    End If
        '    Me.cmdGenerar.Enabled = True
        'Else
        '    Me.txtConsecutivo.Text = "00001"
        '    Me.dtpAPagar.Value = Today
        '    Me.cmdGenerar.Enabled = False
        'End If

        Me.Iniciado = True
    End Sub

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        If Me.vLista.DataRowCount = 0 Then
            XtraMsg("No hay registros en la lista")
            Exit Sub
        End If

        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1") = 0 Then
            XtraMsg("No hay bancos seleccionados para generar el archivo de pago de planilla")
            Exit Sub
        End If

        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1 and Consecutivo = ''") <> 0 Then
            XtraMsg("Hay consecutivos de archivos de planilla en blanco", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1 and CPlanilla = ''") <> 0 Then
            MsgBox("Hay codigos de servicio de planilla en blanco", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If

        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            If Me.vLista.GetRowCellValue(i, "Generar") = True Then
                If Me.vLista.GetRowCellValue(i, "Consecutivo") <> "" Then
                    Dim ds As New DataSet
                    ' BAC
                    If Me.vLista.GetRowCellValue(i, "Funcion") = "BcoBac" Then
                        ds = VB.SysContab.PlanillaDB.BcoBac(Periodo, TPeriodo, _
                            Me.vLista.GetRowCellValue(i, "Consecutivo"), _
                            Me.vLista.GetRowCellValue(i, "A Pagar el dia"), _
                            Me.vLista.GetRowCellValue(i, "CPlanilla"), _
                            Me.vLista.GetRowCellValue(i, "Codigo"))

                        Me.SFD.InitialDirectory = Application.StartupPath()

                        Me.SFD.Filter = "PRN Files (*.prn)|*.prn|Text Files (*.txt)|*.txt"
                        Me.SFD.FilterIndex = 1
                        Me.SFD.RestoreDirectory = True
                        Me.SFD.FileName = Application.StartupPath & "\exportfiles\PE_" & Me.vLista.GetRowCellValue(i, "CPlanilla") & ".prn"
                        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Try
                                If VB.SysContab.RutinasNomina.ExportarTXT(ds.Tables(0), Me.SFD.FileName, Longitud_Linea_Archivos.BAC) Then
                                    Per.Update_Servicio(Periodo, TPeriodo, _
                                        Me.vLista.GetRowCellValue(i, "CPlanilla"), _
                                        Me.vLista.GetRowCellValue(i, "Consecutivo"), _
                                        Me.vLista.GetRowCellValue(i, "Codigo"))

                                    XtraMsg("Archivo generado satisfactoriamente")
                                Else
                                    XtraMsg("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MessageBoxIcon.Warning)
                                End If
                            Catch Ex As Exception
                                XtraMsg("No se puede escribir el archivo. Error original: " & Ex.Message, MessageBoxIcon.Error)
                                Exit Sub
                            Finally

                            End Try
                        End If


                    End If
                    ' Banpro
                    If Me.vLista.GetRowCellValue(i, "Funcion") = "BcoBanpro" Then
                        ds = VB.SysContab.PlanillaDB.BcoBanpro(Periodo, TPeriodo)

                        Me.SFD.InitialDirectory = Application.StartupPath()

                        Me.SFD.Filter = "PRN Files (*.prn)|*.prn|Text Files (*.txt)|*.txt"
                        Me.SFD.FilterIndex = 1
                        Me.SFD.RestoreDirectory = True
                        Me.SFD.FileName = Application.StartupPath & "\exportfiles\Banpro_" & TPeriodo & Periodo & ".prn"
                        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Try
                                If VB.SysContab.RutinasNomina.ExportarTXT_Tab(ds.Tables(0), Me.SFD.FileName) Then
                                    Per.Update_Servicio(Periodo, TPeriodo, _
                                        Me.vLista.GetRowCellValue(i, "CPlanilla"), _
                                        Me.vLista.GetRowCellValue(i, "Consecutivo"), _
                                        Me.vLista.GetRowCellValue(i, "Codigo"))

                                    MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                                Else
                                    MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                                End If
                            Catch Ex As Exception
                                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                                Exit Sub
                            Finally

                            End Try
                        End If


                    End If
                    'BANCENTRO
                    If Me.vLista.GetRowCellValue(i, "Funcion") = "BcoBancentro" Then
                        ds = VB.SysContab.PlanillaDB.BcoBancentro(Periodo, TPeriodo, _
                            Me.vLista.GetRowCellValue(i, "Consecutivo"), _
                            Me.vLista.GetRowCellValue(i, "A Pagar el dia"), _
                            Me.vLista.GetRowCellValue(i, "CPlanilla"), _
                            Me.vLista.GetRowCellValue(i, "Codigo"))

                        Me.SFD.InitialDirectory = Application.StartupPath()

                        Me.SFD.Filter = "PRN Files (*.prn)|*.prn|Text Files (*.txt)|*.txt"
                        Me.SFD.FilterIndex = 1
                        Me.SFD.RestoreDirectory = True
                        Me.SFD.FileName = Application.StartupPath & "\exportfiles\PE_" & Me.vLista.GetRowCellValue(i, "CPlanilla") & ".prn"
                        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Try
                                If VB.SysContab.RutinasNomina.ExportarTXT(ds.Tables(0), Me.SFD.FileName, Longitud_Linea_Archivos.BAC) Then
                                    Per.Update_Servicio(Periodo, TPeriodo, _
                                       Me.vLista.GetRowCellValue(i, "CPlanilla"), _
                                       Me.vLista.GetRowCellValue(i, "Consecutivo"), _
                                       Me.vLista.GetRowCellValue(i, "Cuenta"))
                                    MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                                Else
                                    MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                                End If
                            Catch Ex As Exception
                                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                                Exit Sub
                            Finally

                            End Try
                        End If

                    End If
                End If
            End If
        Next



    End Sub
    Private Sub txtConsecutivo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsecutivo.Enter
        If Len(Me.txtConsecutivo.Text) < 5 Then
            MsgBox("El Codigo consecutivo definido para el banco debe ser de 5 caracteres de longitud")
            Me.txtConsecutivo.Text.PadLeft(5, "0")
            Exit Sub
        End If
    End Sub

    Private Sub GCCuentasBancos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.txtConsecutivo.Text = (CDbl(Me.GCCuentasBancos.Item(Me.GCCuentasBancos.CurrentRowIndex, 4)) + 1).ToString.PadLeft(5, "0")
        'PN = VB.SysContab.PeriodoNominaDB.GetDetails(Me.TPeriodo & Me.Periodo)
        'If PN.Tipo <> "A" And PN.Tipo <> "V" Then
        '    Me.dtpAPagar.Value = PN.FFinal
        'Else
        '    Me.dtpAPagar.Value = Today.Date
        'End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub vLista_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vLista.CellValueChanged
        If Me.Iniciado = True Then
            If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1") = 0 Then
                Me.cmdGenerar.Enabled = False
            Else
                Me.cmdGenerar.Enabled = True
            End If
        End If
    End Sub

    

    Private Sub vLista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vLista.FocusedRowChanged
        If Me.Iniciado = True Then
            If Me.vLista.GetFocusedRowCellValue("Formato") = 2 Then
                Me.vLista.Columns("Consecutivo").OptionsColumn.AllowEdit = False
            Else
                Me.vLista.Columns("Consecutivo").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub
End Class