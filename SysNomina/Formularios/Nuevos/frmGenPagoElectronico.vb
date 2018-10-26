Public Class frmGenPagoElectronico 

#Region "Variables"
    Public Periodo, TPeriodo As String
    Public PN As New VB.SysContab.PeriodoNominaDetails()
    Public Per As New VB.SysContab.PeriodoNominaDB()
    Dim Empresa As New VB.SysContab.EmpresasDetails
    Dim Iniciado As Boolean = False
#End Region

    Private Sub frmGenPagoElectronico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AutoScroll = True
        Me.Bancos.DataSource = VB.SysContab.Catalogo_BancosDB.CatalogoBancos(True).Tables(0)
        If vLista.DataRowCount = 0 Then
            Me.cmdExportar.Enabled = False
        Else
            Me.cmdExportar.Enabled = True
        End If

        Me.vLista.Columns("Codigo").Visible = False
        Me.vLista.Columns("Cuenta").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Nombre").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Siglas").Visible = False
        Me.vLista.Columns("CPlanilla").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Formato").Visible = False
        Me.vLista.Columns("Funcion").Visible = False


        Me.Iniciado = True
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If
        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1") = 0 Then
            MsgBox("No hay bancos seleccionados para generar el archivo de pago de planilla", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If

        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1 and Consecutivo = ''") <> 0 Then
            MsgBox("Hay consecutivos de archivos de planilla en blanco", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If
        If Me.Bancos.DataSource.Compute("Count(Generar)", "Generar = 1 and CPlanilla = ''") <> 0 Then
            MsgBox("Hay codigos de servicio de planilla en blanco", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If
        Dim dPN As New VB.SysContab.PeriodoNominaDetails

        dPN = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo & Periodo)

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
                        Me.SFD.FileName = Application.StartupPath & "\exportfiles\PLA_BAC_DEL_" & dPN.FInicio.Day.ToString.PadLeft(2, "0") & _
                            "_AL_" & dPN.FFinal.Day.ToString.PadLeft(2, "0") & "_DE_" & dPN.FFinal.Month.ToString.PadLeft(2, "0") & _
                            "_AÑO_" & dPN.FFinal.Year.ToString & ".prn"
                        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Try
                                If VB.SysContab.RutinasNomina.ExportarTXT_Banco(ds.Tables(0), Me.SFD.FileName, Longitud_Linea_Archivos.BAC) Then
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

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class