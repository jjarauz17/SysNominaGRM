Imports System.IO

Public Class frmContratos
    Public Respuesta As String = "0"
    Private myStream As Stream = Nothing
    Private Moneda As String = ""

    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cbTurnos.Properties.DataSource = Catalogos.EDU_Turno(0)
        Me.cbTurnos.Properties.DisplayMember = "desc_turno"
        Me.cbTurnos.Properties.ValueMember = "id_turno"

        Me.cbMonedas.DataSource = VB.SysContab.MonedaDB.GetList().Tables(0)
        Me.cbMonedas.DisplayMember = "Descripcion"
        Me.cbMonedas.ValueMember = "Codigo"

        Limpiar()

    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        Dim ddt As DataTable
        ddt = Catalogos.EDU_Configuraciones()
        If ddt.Rows.Count >= 1 Then Moneda = ddt.Rows(0)("mon_contratos") Else Moneda = ""
        Me.cmdImportar.Enabled = Not (Moneda = "")
        Me.cmdGuardar.Enabled = Not (Moneda = "")

        Me.dgContratos.DataSource = Nothing
        Me.vLista.Columns.Clear()

        Me.cmdGuardar.Text = "&Guardar"
    End Sub
    Private Sub cmdImportar_Click(sender As Object, e As EventArgs) Handles cmdImportar.Click
        If Me.cbTurnos.EditValue Is Nothing Then
            MsgBox("Seleccione un turno por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbTurnos.EditValue Is DBNull.Value Then
            MsgBox("Seleccione un turno por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim t As New frmOrigen(Me)
        t.ShowDialog()
        t.Dispose()
        If Me.Respuesta = 2 Then 'webservice
            Dim ws As New EDU_Asistencias.Service1SoapClient
            Dim dt As DataTable
            ADORNOS.ShowSplash()
            Try
                dt = ws.ValorHora(Me.cbTurnos.EditValue)

                Dim cMoneda As DataColumn = New DataColumn
                cMoneda.DataType = System.Type.GetType("System.String")
                cMoneda.AllowDBNull = False
                cMoneda.Caption = "Moneda"
                cMoneda.ColumnName = "moneda"
                cMoneda.DefaultValue = Moneda
                dt.Columns.Add(cMoneda)

                Dim column As DataColumn = New DataColumn
                column.DataType = System.Type.GetType("System.Boolean")
                column.AllowDBNull = False
                column.Caption = "Importar"
                column.ColumnName = "Importar"
                column.DefaultValue = False
                dt.Columns.Add(column)

                Me.dgContratos.DataSource = Nothing
                Me.vLista.Columns.Clear()
                Me.dgContratos.DataSource = dt
                Me.vLista.Columns("moneda").ColumnEdit = Me.cbMonedas
                For i As Integer = 0 To Me.vLista.Columns.Count - 3
                    Me.vLista.Columns(i).OptionsColumn.AllowEdit = False
                    Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ADORNOS.HideSplash()
        ElseIf Me.Respuesta = 1 Then
            'Leer un archivo
            Dim narchivo As String
            myStream = Nothing
            Me.OFD.InitialDirectory = Application.StartupPath()

            Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
            Me.OFD.FilterIndex = 1
            Me.OFD.RestoreDirectory = True

            If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    myStream = Me.OFD.OpenFile()
                Catch Ex As Exception
                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                    Exit Sub
                Finally
                    If Not IsNothing(myStream) Then
                        narchivo = Me.OFD.FileName
                        Dim xmlds As DataSet
                        xmlds = New DataSet()
                        If VB.SysContab.DocumentosDB.Leer_Archivo(narchivo, xmlds) = -1 Then
                            MsgBox("Error al cargar el archivo")
                        End If
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "cedula" Then
                            MsgBox("La primer columna del archivo a importar debe ser la Cedula (Cedula)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "docente" Then
                            MsgBox("La segunda columna del archivo a importar debe ser el nombre del Docente (Docente)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "cod_asignatura" Then
                            MsgBox("La tercer columna del archivo a importar debe ser el Codigo de la Asignatura (cod_asignatura)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(3).ColumnName.ToLower <> "asignatura" Then
                            MsgBox("La cuarta columna del archivo a importar debe ser el Nombre de la Asignatura (asignatura)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(4).ColumnName.ToLower <> "cod_turno" Then
                            MsgBox("La quinta columna del archivo a importar debe ser el Codigo del Turno (cod_turno)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(5).ColumnName.ToLower <> "turno" Then
                            MsgBox("La sexta columna del archivo a importar debe ser el Nombre del Turno (turno)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(6).ColumnName.ToLower <> "desde" Then
                            MsgBox("La septima columna del archivo a importar debe ser el inicio del contrato (desde)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(7).ColumnName.ToLower <> "hasta" Then
                            MsgBox("La octava columna del archivo a importar debe ser el fin del contrato (hasta)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(8).ColumnName.ToLower <> "valor_hora" Then
                            MsgBox("La novema columna del archivo a importar debe ser el valor por hora (valor_hora)")
                            GoTo salir
                        End If

                        Me.dgContratos.DataSource = Nothing
                        Me.vLista.Columns.Clear()
                        Dim cMoneda As DataColumn = New DataColumn
                        cMoneda.DataType = System.Type.GetType("System.String")
                        cMoneda.AllowDBNull = False
                        cMoneda.Caption = "Moneda"
                        cMoneda.ColumnName = "moneda"
                        cMoneda.DefaultValue = Moneda
                        xmlds.Tables(0).Columns.Add(cMoneda)

                        'xmlds.Tables(0).Columns.Add("moneda", Type.GetType("System.String"))
                        'xmlds.Tables(0).Columns("moneda").DefaultValue = Moneda

                        xmlds.Tables(0).Columns.Add("Importar", Type.GetType("System.Boolean"))
                        xmlds.Tables(0).Columns("Importar").DefaultValue = False

                        Me.dgContratos.DataSource = xmlds.Tables(0)
                        Me.vLista.Columns("moneda").ColumnEdit = Me.cbMonedas
                        Me.vLista.Columns("moneda").Caption = "Moneda"
                        For i As Integer = 0 To Me.vLista.Columns.Count - 3
                            Me.vLista.Columns(i).OptionsColumn.AllowEdit = False
                            Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
                        Next

salir:              End If
                End Try
            End If
            If IsNothing(myStream) Then
                Exit Sub
            End If

        End If
    End Sub


    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            Me.vLista.SetRowCellValue(i, "Importar", Me.chkTodos.EditValue)
        Next
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If Me.cmdGuardar.Text = "&Guardar" Then
            Dim tErrores As DataTable
            tErrores = Me.dgContratos.DataSource.clone
            Dim tRegistro As DataRow
            For i As Integer = 0 To Me.vLista.DataRowCount - 1
                If Me.vLista.GetRowCellValue(i, "Importar") = True Then
                    If validar(Me.vLista.GetRowCellValue(i, "cod_asignatura"), Me.vLista.GetRowCellValue(i, "asignatura"), _
                            Me.vLista.GetRowCellValue(i, "Cedula"), Me.vLista.GetRowCellValue(i, "Docente"), _
                            Me.vLista.GetRowCellValue(i, "valor_hora"), Me.vLista.GetRowCellValue(i, "moneda")) Then

                        Catalogos.EDU_Contratos_Add(0, Me.vLista.GetRowCellValue(i, "Cedula"), Me.vLista.GetRowCellValue(i, "Docente"), _
                            Me.vLista.GetRowCellValue(i, "cod_asignatura"), Me.vLista.GetRowCellValue(i, "asignatura"), Me.vLista.GetRowCellValue(i, "cod_turno"), _
                            Me.vLista.GetRowCellValue(i, "turno"), Me.vLista.GetRowCellValue(i, "desde"), Me.vLista.GetRowCellValue(i, "hasta"), _
                            Me.vLista.GetRowCellValue(i, "valor_hora"), Me.vLista.GetRowCellValue(i, "moneda"))

                    Else
                        If validar(Me.vLista.GetRowCellValue(i, "Codigo"), Me.vLista.GetRowCellValue(i, "Asignatura"), _
                            Me.vLista.GetRowCellValue(i, "Cedula"), Me.vLista.GetRowCellValue(i, "Docente"), _
                            Me.vLista.GetRowCellValue(i, "Valor Hora"), Me.vLista.GetRowCellValue(i, "moneda")) Then

                            Catalogos.EDU_Contratos_Add(0, Me.vLista.GetRowCellValue(i, "Cedula"), Me.vLista.GetRowCellValue(i, "Docente"), _
                                Me.vLista.GetRowCellValue(i, "Codigo"), Me.vLista.GetRowCellValue(i, "Asignatura"), Me.vLista.GetRowCellValue(i, "Codigo1"), _
                                Me.vLista.GetRowCellValue(i, "Turno"), Me.vLista.GetRowCellValue(i, "De"), Me.vLista.GetRowCellValue(i, "Hasta"), _
                                Me.vLista.GetRowCellValue(i, "Valor Hora"), Me.vLista.GetRowCellValue(i, "moneda"))
                        Else
                            tRegistro = tErrores.NewRow
                            For j As Integer = 0 To tErrores.Columns.Count - 1
                                tRegistro(j) = Me.vLista.GetRow(i).row.itemarray(j)
                            Next
                            tErrores.Rows.Add(tRegistro)
                        End If
                    End If
                End If
            Next

            If tErrores.Rows.Count > 0 Then
                MsgBox("Se detectaron errores en los datos a importar", MsgBoxStyle.Critical, "Sts.Nomina")
                Me.dgContratos.DataSource = Nothing
                Me.vLista.Columns.Clear()
                Me.dgContratos.DataSource = tErrores
                Me.cmdGuardar.Text = "&Limpiar"
            End If
        Else
            Limpiar()

        End If
    End Sub
    Private Function validar(cod_asignatura As Object, asignatura As Object, _
                             cedula As Object, docente As Object, valor_hora As Object, Moneda As Object) As Boolean

        If Moneda Is DBNull.Value Then
            Return False
        End If
        If Moneda Is Nothing Then
            Return False
        End If
        If cod_asignatura Is DBNull.Value Then
            Return False
        End If
        If cod_asignatura Is Nothing Then
            Return False
        End If
        If asignatura Is DBNull.Value Then
            Return False
        End If
        If asignatura Is Nothing Then
            Return False
        End If
        If docente Is DBNull.Value Then
            Return False
        End If
        If docente Is Nothing Then
            Return False
        End If
        If cedula Is DBNull.Value Then
            Return False
        End If
        If cedula Is Nothing Then
            Return False
        End If
        If valor_hora Is DBNull.Value Then
            Return False
        End If
        If valor_hora <= 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub cmdVerRegistros_Click(sender As Object, e As EventArgs) Handles cmdVerRegistros.Click
        Me.cmdGuardar.Text = "&Limpiar"
        If Me.cbTurnos.EditValue Is Nothing Then
            MsgBox("Seleccione un turno por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbTurnos.EditValue Is DBNull.Value Then
            MsgBox("Seleccione un turno por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Me.dgContratos.DataSource = Catalogos.EDU_Contratos_List(Me.cbTurnos.EditValue, "0")
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("moneda").ColumnEdit = Me.cbMonedas
        For i As Integer = 0 To Me.vLista.Columns.Count - 3
            Me.vLista.Columns(i).OptionsColumn.AllowEdit = False
            Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
        Next
    End Sub
End Class