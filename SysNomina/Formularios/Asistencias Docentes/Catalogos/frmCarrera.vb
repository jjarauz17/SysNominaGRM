Imports System.IO
Public Class frmCarrera
    Public Respuesta As String = "0"
    Private myStream As Stream = Nothing
    Private Sub frmCarrera_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cargar()
    End Sub

    Private Sub Cargar()
        Me.cbFacultad.DataSource = Catalogos.EDU_Facultad(0)
        Me.cbFacultad.ValueMember = "id_facultad"
        Me.cbFacultad.DisplayMember = "desc_facultad"

        Me.cbCCosto.DataSource = VB.SysContab.RH_OrganigramaDB.Listar()
        Me.cbCCosto.DisplayMember = "org_descripcion"
        Me.cbCCosto.ValueMember = "org_codigo"
        Me.cbCCosto.PopulateViewColumns()
        For i As Integer = 0 To Me.vListaCCosto.Columns.Count - 1
            If Not (Me.vListaCCosto.Columns(i).FieldName = "org_codigo" Or Me.vListaCCosto.Columns(i).FieldName = "org_descripcion") Then
                Me.vListaCCosto.Columns(i).Visible = False
            End If
        Next
        Me.vListaCCosto.Columns("org_codigo").Caption = "CCosto"
        Me.vListaCCosto.Columns("org_descripcion").Caption = "Descripcion"
        Me.vLista.Columns.Clear()
        Me.dgCarreras.DataSource = Catalogos.EDU_Carrera(0)
        Me.dgCarreras.DataSource.columns("id").defaultvalue = 0
        Me.vLista.PopulateColumns()
        Me.vLista.BestFitColumns()

        Me.vLista.Columns("id").Visible = False
        Me.vLista.Columns("id_facultad").ColumnEdit = Me.cbFacultad
        Me.vLista.Columns("org_codigo").ColumnEdit = Me.cbCCosto
        Me.vLista.Columns("id_carrera").Caption = "ID_Carrera"
        Me.vLista.Columns("id_facultad").Caption = "ID_Facultad"
        Me.vLista.Columns("desc_carrera").Caption = "Carrera"
        Me.vLista.Columns("org_codigo").Caption = "Centro Costo"
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempdt As DataTable
        Dim ID As Integer
        ''EDU_Carrera
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgCarreras.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Carrera_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_carrera"), _
                                          tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_carrera"), tempdt.Rows(i)("org_codigo"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgCarreras.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Carrera_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_carrera"), _
                                          tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_carrera"), tempdt.Rows(i)("org_codigo"))
            Next

        End If
        'Los  agregados
        tempdt = Me.dgCarreras.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                If tempdt.Rows(i)("id") Is DBNull.Value Then ID = 0 Else ID = tempdt.Rows(i)("id")
                Catalogos.EDU_Carrera_Add(ID, tempdt.Rows(i)("id_carrera"), _
                                          tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_carrera"), tempdt.Rows(i)("org_codigo"))
                ID = 0
            Next

        End If
        Me.Cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub vLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLista.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub vLista_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vLista.ValidateRow
        If sender.focusedcolumn.fieldname = "id_carrera" Then
            If Not e.Row("id_carrera") Is Nothing Then
                If e.Row("id_carrera") Is DBNull.Value Then
                    MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                ElseIf e.Row("id_carrera") = "" Then
                    MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    Dim c As Integer
                    c = Me.dgCarreras.DataSource.Compute("Count(id_carrera)", "id_carrera = '" & e.Row("id_carrera") & "'")
                    If c >= 1 Then
                        MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                        e.Valid = False
                    Else
                        e.Valid = True
                        If e.Row("id_carrera") Is Nothing Then Exit Sub

                    End If
                End If
            Else
                MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                e.Valid = False
            End If
        End If
        If sender.focusedcolumn.fieldname = "desc_carrera" Then
            If e.Row("desc_carrera") Is Nothing Then
                MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                e.Valid = False
            ElseIf e.Row("desc_carrera") Is DBNull.Value Then
                MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                e.Valid = False
            ElseIf e.Row("desc_carrera") = "" Then
                MsgBox("Digite el codigo de Carrera por favor", MsgBoxStyle.Exclamation, "Sts.Nomina")
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub vLista_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "id_facultad" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el campo FACULTAD", , "Sts.Nomina")
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim t As New frmOrigen(Me)
        t.ShowDialog()
        t.Dispose()
        If Me.Respuesta = 2 Then 'webservice
            Dim ws As New EDU_Asistencias.Service1SoapClient
            Dim dt As DataTable
            ADORNOS.ShowSplash()
            Try
                dt = ws.carreras
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Catalogos.EDU_Carrera_Add(0, dt.Rows(i)("cod_carrera"), dt.Rows(i)("cod_facultad"), dt.Rows(i)("carrera"), False)
                    Next
                End If
                'Me.dgCarreras.DataSource = Nothing
                'Me.vLista.Columns.Clear()
                'Me.dgCarreras.DataSource = dt

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
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "cod_facultad" Then
                            MsgBox("La primer columna del archivo a importar debe ser el Codigo de la Facultad (cod_facultad)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "cod_carrera" Then
                            MsgBox("La segunda columna del archivo a importar debe ser el Codigo de la Carrera (cod_carrera)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "carrera" Then
                            MsgBox("La segunda columna del archivo a importar debe ser el Nombre de la Carrera (carrera)")
                            GoTo salir
                        End If

                        Me.dgCarreras.DataSource = Nothing
                        Me.vLista.Columns.Clear()
                        xmlds.Tables(0).Columns.Add("id", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("id").DefaultValue = 0
                        xmlds.Tables(0).Columns("cod_carrera").ColumnName = "id_carrera"
                        xmlds.Tables(0).Columns("cod_facultad").ColumnName = "id_facultad"
                        xmlds.Tables(0).Columns("carrera").ColumnName = "desc_carrera"

                        Me.dgCarreras.DataSource = xmlds.Tables(0)
                        Me.vLista.Columns("id").Visible = False
                        Me.vLista.Columns("id_facultad").ColumnEdit = Me.cbFacultad
                        Me.vLista.Columns("id_carrera").Caption = "ID_Carrera"
                        Me.vLista.Columns("id_facultad").Caption = "ID_Facultad"
                        Me.vLista.Columns("desc_carrera").Caption = "Carrera"

salir:              End If
                End Try
            End If
            If IsNothing(myStream) Then
                Exit Sub
            End If

        End If
        Me.Cargar()
    End Sub
End Class