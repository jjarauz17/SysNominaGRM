Imports System.IO
Imports DevExpress.Spreadsheet
Public Class frmAsistencias
    Public Respuesta As String = "0"
    Private myStream As Stream = Nothing
    Private archivo As New Workbook
    Dim Tabla As DataTable, Errores As DataTable
    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim t As New frmOrigen(Me)
        t.ShowDialog()
        t.Dispose()
        If Me.Respuesta = 2 Then 'webservice
            Dim ws As New EDU_Asistencias.Service1SoapClient
            Dim dt As DataTable
            ADORNOS.ShowSplash()
            Try
                dt = ws.HorasDocente(Me.deDesde.EditValue, Me.deHasta.EditValue)
                dt.Columns("Horas").ColumnName = "horas"
                dt.Columns("Turno").ColumnName = "turno"
                dt.Columns("Asignatura").ColumnName = "asignatura"
                dt.Columns("nom_docente").ColumnName = "docente"
                dt.Columns("facultades").ColumnName = "facultad"
                dt.Columns("carreras").ColumnName = "carrera"



                Dim column0 As DataColumn = New DataColumn
                column0.DataType = System.Type.GetType("System.Decimal")
                column0.AllowDBNull = False
                column0.Caption = "Horas Importadas"
                column0.ColumnName = "horas_importadas"
                column0.DefaultValue = 0.0
                dt.Columns.Add(column0)

                Dim column As DataColumn = New DataColumn
                column.DataType = System.Type.GetType("System.Boolean")
                column.AllowDBNull = False
                column.Caption = "Importar"
                column.ColumnName = "Importar"
                column.DefaultValue = False
                dt.Columns.Add(column)

                dt.Columns("horas").SetOrdinal(dt.Columns.Count - 2)

                Me.dgAsistencias.DataSource = Nothing
                Me.vLista.Columns.Clear()
                Me.dgAsistencias.DataSource = dt
                For i As Integer = 0 To Me.vLista.DataRowCount - 1
                    Me.vLista.SetRowCellValue(i, "horas_importadas", Math.Round(Me.vLista.GetRowCellValue(i, "horas"), 4))
                    Me.vLista.SetRowCellValue(i, "horas", Math.Round(Me.vLista.GetRowCellValue(i, "horas"), 4))
                Next

                Me.vLista.Columns("horas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vLista.Columns("horas").SummaryItem.DisplayFormat = "{0:n2}"

                Me.vLista.Columns("horas_importadas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vLista.Columns("horas_importadas").SummaryItem.DisplayFormat = "{0:n2}"

                For i As Integer = 0 To Me.vLista.Columns.Count - 3
                    Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
                    Me.vLista.Columns(i).OptionsColumn.AllowEdit = False
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
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "cod_turno" Then
                            MsgBox("La primer columna del archivo a importar debe ser el Codigo de Turno (cod_turno)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "turno" Then
                            MsgBox("La segunda columna del archivo a importar debe ser el nombre del Turno (Turno)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "cod_docente" Then
                            MsgBox("La tercer columna del archivo a importar debe ser el Codigo del Docente (cod_docente)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(3).ColumnName.ToLower <> "nom_docente" Then
                            MsgBox("La cuarta columna del archivo a importar debe ser el Nombre del Docente (nom_docente)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(4).ColumnName.ToLower <> "cedula" Then
                            MsgBox("La quinta columna del archivo a importar debe ser la Cedula  (cedula)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(5).ColumnName.ToLower <> "cod_asignatura" Then
                            MsgBox("La sexta columna del archivo a importar debe ser el Codigo de la Asignatura (cod_asignatura)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(6).ColumnName.ToLower <> "asignatura" Then
                            MsgBox("La septima columna del archivo a importar debe ser el nombre de la Asignatura (Asignatura)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(7).ColumnName.ToLower <> "cod_facultad" Then
                            MsgBox("La octava columna del archivo a importar debe ser el codigo de la facultad (cod_facultad)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(8).ColumnName.ToLower <> "facultades" Then
                            MsgBox("La novena columna del archivo a importar debe ser el nombre de la facultad (facultades)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(9).ColumnName.ToLower <> "horas" Then
                            MsgBox("La decima columna del archivo a importar debe ser la cantidad de horas (horas)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(10).ColumnName.ToLower <> "cod_carrera" Then
                            MsgBox("La undecima columna del archivo a importar debe ser el codigo de la Carrera (cod_carrera)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(11).ColumnName.ToLower <> "carreras" Then
                            MsgBox("La duodecima columna del archivo a importar debe ser el nombre de la Carrera (carreras)")
                            GoTo salir
                        End If

                        Me.dgAsistencias.DataSource = Nothing
                        Me.vLista.Columns.Clear()

                        xmlds.Tables(0).Columns("Horas").ColumnName = "horas"
                        xmlds.Tables(0).Columns("Turno").ColumnName = "turno"
                        xmlds.Tables(0).Columns("Asignatura").ColumnName = "asignatura"
                        xmlds.Tables(0).Columns("nom_docente").ColumnName = "docente"
                        xmlds.Tables(0).Columns("facultades").ColumnName = "facultad"
                        xmlds.Tables(0).Columns("carreras").ColumnName = "carrera"



                        Dim column0 As DataColumn = New DataColumn
                        column0.DataType = System.Type.GetType("System.Decimal")
                        column0.AllowDBNull = False
                        column0.Caption = "Horas Importadas"
                        column0.ColumnName = "horas_importadas"
                        column0.DefaultValue = 0.0
                        xmlds.Tables(0).Columns.Add(column0)

                        Dim column As DataColumn = New DataColumn
                        column.DataType = System.Type.GetType("System.Boolean")
                        column.AllowDBNull = False
                        column.Caption = "Importar"
                        column.ColumnName = "Importar"
                        column.DefaultValue = False
                        xmlds.Tables(0).Columns.Add(column)

                        xmlds.Tables(0).Columns("horas").SetOrdinal(xmlds.Tables(0).Columns.Count - 2)

                        Me.dgAsistencias.DataSource = Nothing
                        Me.vLista.Columns.Clear()
                        Me.dgAsistencias.DataSource = xmlds.Tables(0)
                        Dim x As Decimal
                        For i As Integer = 0 To Me.vLista.DataRowCount - 1
                            x = Me.vLista.GetRowCellValue(i, "horas")
                            Me.vLista.SetRowCellValue(i, "horas_importadas", Math.Round(x, 4))
                            Me.vLista.SetRowCellValue(i, "horas", Math.Round(x, 4))
                        Next

                        Me.vLista.Columns("horas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.vLista.Columns("horas").SummaryItem.DisplayFormat = "{0:n2}"

                        Me.vLista.Columns("horas_importadas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.vLista.Columns("horas_importadas").SummaryItem.DisplayFormat = "{0:n2}"

                        For i As Integer = 0 To Me.vLista.Columns.Count - 3
                            Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
                            Me.vLista.Columns(i).OptionsColumn.AllowEdit = False
                        Next


salir:              End If
                End Try
            End If
            If IsNothing(myStream) Then
                Exit Sub
            End If

        End If

    End Sub

    Private Sub CrearTabla()
        Tabla = New DataTable
        'cod_docente, nom_docente, cedula, cod_asignatura, desc_asignatura, cod_carrera, desc_carrera, cod_facultad, desc_facultad, horas
        Tabla.Columns.Add("cod_docente", Type.GetType("System.String"))
        Tabla.Columns.Add("docente", Type.GetType("System.String"))
        Tabla.Columns.Add("cedula", Type.GetType("System.String"))
        Tabla.Columns.Add("cod_asignatura", Type.GetType("System.String"))
        Tabla.Columns.Add("asignatura", Type.GetType("System.String"))
        Tabla.Columns.Add("cod_carrera", Type.GetType("System.String"))
        Tabla.Columns.Add("carrera", Type.GetType("System.String"))
        Tabla.Columns.Add("cod_facultad", Type.GetType("System.String"))
        Tabla.Columns.Add("facultad", Type.GetType("System.String"))
        Tabla.Columns.Add("horas", Type.GetType("System.Decimal"))
        Tabla.Columns.Add("horas_importadas", Type.GetType("System.Decimal"))
        Tabla.Columns.Add("fecha", Type.GetType("System.String"))
        Tabla.Columns.Add("cod_turno", Type.GetType("System.String"))
        Tabla.Columns.Add("turno", Type.GetType("System.String"))
        Tabla.Columns.Add("Importar", Type.GetType("System.Boolean"))

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAsistencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar2()
        CrearTabla()
        cargar()
    End Sub
    Private Sub Cargar2()
        Me.dgResumen.DataSource = Catalogos.EDU_AsistenciasResumen(QuincenaTrabajo)
        For i As Integer = 0 To Me.vResumen.Columns.Count - 2
            Me.vResumen.Columns(i).OptionsColumn.ReadOnly = True
        Next

        Me.vResumen.Columns("Total Horas Originales").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vResumen.Columns("Total Horas Originales").SummaryItem.DisplayFormat = "{0:n2}"


        Me.vResumen.Columns("Total Horas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vResumen.Columns("Total Horas").SummaryItem.DisplayFormat = "{0:n2}"

    End Sub
    Private Sub cargar()


        Me.deDesde.EditValue = Today
        Me.deHasta.EditValue = Today

        Me.dgAsistencias.DataSource = Tabla
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.cmdGuardar.Text = "&Limpiar" Then
            Me.CrearTabla()
            Me.cargar()
            Me.cmdGuardar.Text = "&Guardar"
            Me.lcActualizar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.cmdSalir.Enabled = True
            Me.cmdImportar.Enabled = True
        Else
            If Me.vLista.DataRowCount = 0 Then
                MsgBox("No hay nada que importar")
                Exit Sub
            End If
            If QuincenaTrabajo = "" Then
                MsgBox("No se ha seleccionado un Periodo de Nomina de Trabajo", vbCritical, "Sts.Nomina")
                Exit Sub
            End If
            If Me.deDesde.EditValue Is Nothing Then
                MsgBox("Seleccione una fecha inicial")
                Exit Sub
            End If
            If Me.deDesde.EditValue Is DBNull.Value Then
                MsgBox("Seleccione una fecha inicial")
                Exit Sub
            End If
            If Me.deHasta.EditValue Is Nothing Then
                MsgBox("Seleccione una fecha final")
                Exit Sub
            End If
            If Me.deHasta.EditValue Is DBNull.Value Then
                MsgBox("Seleccione una fecha final")
                Exit Sub
            End If

            If MsgBox("Se borraran los registros de asistencias del rango seleccionado. Esta seguro?", vbYesNo) = vbYes Then
                ADORNOS.ShowSplash()
                '1) Borrar los registros importados
                Catalogos.EDU_Asistencias_Borrar(deDesde.EditValue, deHasta.EditValue, "%")
                '2) Importar la informacion
                Errores = Me.dgAsistencias.DataSource.clone
                Dim nRow As DataRow
                For i As Integer = 0 To Me.vLista.DataRowCount - 1
                    If Me.vLista.GetRowCellValue(i, "Importar") = True Then
                        If validar(Me.vLista.GetRowCellValue(i, "cod_turno"), Me.vLista.GetRowCellValue(i, "turno"), _
                                   Me.vLista.GetRowCellValue(i, "cod_carrera"), Me.vLista.GetRowCellValue(i, "carrera"), _
                                Me.vLista.GetRowCellValue(i, "cod_facultad"), Me.vLista.GetRowCellValue(i, "facultad"), _
                                Me.vLista.GetRowCellValue(i, "cod_asignatura"), Me.vLista.GetRowCellValue(i, "asignatura"), _
                                Me.vLista.GetRowCellValue(i, "cod_docente"), Me.vLista.GetRowCellValue(i, "docente"), _
                                Me.vLista.GetRowCellValue(i, "cedula"), Me.vLista.GetRowCellValue(i, "horas")) Then

                            Catalogos.EDU_Asistencias_Add(0, Me.deDesde.EditValue, Me.deHasta.EditValue, _
                                Me.vLista.GetRowCellValue(i, "cod_turno"), Me.vLista.GetRowCellValue(i, "turno"), _
                                Me.vLista.GetRowCellValue(i, "cod_carrera"), Me.vLista.GetRowCellValue(i, "carrera"), _
                                Me.vLista.GetRowCellValue(i, "cod_facultad"), Me.vLista.GetRowCellValue(i, "facultad"), _
                                Me.vLista.GetRowCellValue(i, "cod_asignatura"), Me.vLista.GetRowCellValue(i, "asignatura"), _
                                Me.vLista.GetRowCellValue(i, "horas"), Me.vLista.GetRowCellValue(i, "cod_docente"), _
                                Me.vLista.GetRowCellValue(i, "docente"), Me.vLista.GetRowCellValue(i, "cedula"), _
                                QuincenaTrabajo, Me.vLista.GetRowCellValue(i, "horas_importadas"))
                        Else
                            nRow = Errores.NewRow
                            nRow("cod_turno") = Me.vLista.GetRowCellValue(i, "cod_turno")
                            nRow("turno") = Me.vLista.GetRowCellValue(i, "turno")
                            nRow("cod_facultad") = Me.vLista.GetRowCellValue(i, "cod_facultad")
                            nRow("facultad") = Me.vLista.GetRowCellValue(i, "facultad")
                            nRow("cod_carrera") = Me.vLista.GetRowCellValue(i, "cod_carrera")
                            nRow("carrera") = Me.vLista.GetRowCellValue(i, "carrera")
                            nRow("cod_asignatura") = Me.vLista.GetRowCellValue(i, "cod_asignatura")
                            nRow("asignatura") = Me.vLista.GetRowCellValue(i, "asignatura")
                            nRow("cod_docente") = Me.vLista.GetRowCellValue(i, "cod_docente")
                            nRow("docente") = Me.vLista.GetRowCellValue(i, "docente")
                            nRow("cedula") = Me.vLista.GetRowCellValue(i, "cedula")
                            nRow("horas") = Me.vLista.GetRowCellValue(i, "horas")
                            nRow("horas_importadas") = Me.vLista.GetRowCellValue(i, "horas_importadas")
                            Errores.Rows.Add(nRow)
                        End If
                    End If
                Next
                Dim dt As DataTable
                dt = Me.dgAsistencias.DataSource
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Dim hojas As Integer = archivo.Worksheets.Count - 1
                        For i As Integer = 1 To hojas
                            archivo.Worksheets.RemoveAt(0)
                        Next
                        archivo.Worksheets.Add("Hoja")
                        archivo.Worksheets.RemoveAt(0)
                        archivo.Worksheets(0).Name = "Asistencia Docentes"
                        archivo.Worksheets.Item(0).Import(dt, True, 0, 0)
                        Using myStream As New MemoryStream '( Application.StartupPath & "\tmp.xlsx", FileMode.Create, FileAccess.ReadWrite)
                            archivo.SaveDocument(myStream, DevExpress.Spreadsheet.DocumentFormat.Xls)
                            Dim fArchivo(myStream.Length) As Byte
                            myStream.Read(fArchivo, 0, myStream.Length)
                            Catalogos.EDU_BitacoraArchivos(fArchivo, Respuesta - 1)
                            myStream.Close()
                        End Using
                    End If
                End If
                ADORNOS.HideSplash()
                If Errores.Rows.Count > 0 Then
                    Me.vLista.Columns.Clear()
                    Me.dgAsistencias.DataSource = Errores
                    Me.cmdGuardar.Text = "&Limpiar"
                    Me.cmdImportar.Enabled = False
                    Me.cmdSalir.Enabled = False
                    MsgBox("Se encontraron errores en la informacion suministrada. Estos registros no se importaron", MsgBoxStyle.Critical, "Sts.Nomina")
                End If
            End If
        End If

        Cargar2()
    End Sub

    Private Function validar(cod_turno As Object, turno As Object, cod_carrera As Object, carrera As Object, _
                             cod_facultad As Object, facultad As Object, cod_asignatura As Object, asignatura As Object, _
                             cod_docente As Object, docente As Object, _
                             cedula As Object, horas As Object) As Boolean
        If cod_turno Is DBNull.Value Then
            Return False
        End If
        If cod_turno Is Nothing Then
            Return False
        End If
        If turno Is DBNull.Value Then
            Return False
        End If
        If turno Is Nothing Then
            Return False
        End If
        If cod_carrera Is DBNull.Value Then
            Return False
        End If
        If cod_carrera Is Nothing Then
            Return False
        End If
        If carrera Is DBNull.Value Then
            Return False
        End If
        If carrera Is Nothing Then
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
        If cod_facultad Is DBNull.Value Then
            Return False
        End If
        If cod_facultad Is Nothing Then
            Return False
        End If
        If facultad Is DBNull.Value Then
            Return False
        End If
        If facultad Is Nothing Then
            Return False
        End If
        If cod_docente Is DBNull.Value Then
            Return False
        End If
        If cod_docente Is Nothing Then
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
        If horas < 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub cmdVerRegistros_Click(sender As Object, e As EventArgs) Handles cmdVerRegistros.Click
        Me.dgAsistencias.DataSource = Nothing
        Me.vLista.Columns.Clear()
        Me.dgAsistencias.DataSource = Catalogos.EDU_Asistencias_Listar(Me.deDesde.EditValue, Me.deHasta.EditValue)
        For i As Integer = 0 To Me.vLista.Columns.Count - 1
            If Me.vLista.Columns(i).FieldName <> "horas" Then
                Me.vLista.Columns(i).OptionsColumn.ReadOnly = True
            End If
        Next
        Me.cmdGuardar.Text = "&Limpiar"
        Me.lcActualizar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Me.cmdImportar.Enabled = False
        Me.cmdSalir.Enabled = False
        'Me.vLista.OptionsBehavior.ReadOnly = True
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            Me.vLista.SetRowCellValue(i, "Importar", Me.chkTodos.EditValue)
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.vResumen.DataRowCount = 0 Then
            MsgBox("No hay registros de asistencias para esta quincena")
            Exit Sub
        End If

        For i As Integer = 0 To Me.vResumen.DataRowCount - 1
            If Me.vResumen.GetRowCellValue(i, "Limpiar") = True Then
                Catalogos.EDU_Asistencias_Borrar(Me.vResumen.GetRowCellValue(i, "Desde"), Me.vResumen.GetRowCellValue(i, "Hasta"), Me.vResumen.GetRowCellValue(i, "Cod_Turno"))
            End If
        Next
        Cargar2()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ADORNOS.ShowSplash()
        For i As Integer = 0 To vLista.DataRowCount - 1
            Catalogos.EDU_Asistencias_ActualizarHoras(Me.vLista.GetRowCellValue(i, "id"), Me.vLista.GetRowCellValue(i, "horas"))
        Next
        ADORNOS.HideSplash()
    End Sub
End Class