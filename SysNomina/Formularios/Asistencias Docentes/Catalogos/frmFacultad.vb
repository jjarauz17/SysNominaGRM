Imports System.IO
Public Class frmFacultad
    Public Respuesta As String = "0"
    Private mystream As Stream = Nothing
    Private Sub frmFacultad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cargar()
    End Sub

    Private Sub Cargar()
        Me.dgFacultad.DataSource = Catalogos.EDU_Facultad(0)
        Me.dgFacultad.DataSource.columns("id").defaultvalue = 0
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("id").Visible = False
        Me.vLista.Columns("id_facultad").Caption = "ID_Externo"
        Me.vLista.Columns("desc_facultad").Caption = "Descripcion"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempdt As DataTable
        Dim ID As Integer

        ''EDU_Facultad
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgFacultad.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Facultad_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_facultad"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgFacultad.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Facultad_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_facultad"))
            Next

        End If
        'Los  agregados
        tempdt = Me.dgFacultad.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                If tempdt.Rows(i)("id") Is DBNull.Value Then ID = 0 Else ID = tempdt.Rows(i)("id")
                Catalogos.EDU_Facultad_Add(ID, tempdt.Rows(i)("id_facultad"), tempdt.Rows(i)("desc_facultad"))
            Next

        End If
        Me.Cargar()
    End Sub

    Private Sub vLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLista.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
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
                dt = ws.facultades()
                For i As Integer = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i)("cod_facultad") Is DBNull.Value And Not dt.Rows(i)("facultad") Is DBNull.Value Then
                        Catalogos.EDU_Facultad_Add(0, dt.Rows(i)("cod_facultad"), dt.Rows(i)("facultad"), False, True)
                    End If

                Next
                Me.Cargar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ADORNOS.HideSplash()
        ElseIf Me.Respuesta = 1 Then
            'Leer un archivo
            Dim narchivo As String
            mystream = Nothing
            Me.OFD.InitialDirectory = Application.StartupPath()

            Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
            Me.OFD.FilterIndex = 1
            Me.OFD.RestoreDirectory = True

            If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    mystream = Me.OFD.OpenFile()
                Catch Ex As Exception
                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                    Exit Sub
                Finally
                    If Not IsNothing(mystream) Then
                        narchivo = Me.OFD.FileName
                        Dim xmlds As DataSet
                        xmlds = New DataSet()
                        If VB.SysContab.DocumentosDB.Leer_Archivo(narchivo, xmlds) = -1 Then
                            MsgBox("Error al cargar el archivo")
                        End If
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "cod_facultad" Then
                            MsgBox("La primer columna del archivo a importar debe ser el Codigo de la Facultad (cod_facultad)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "facultad" Then
                            MsgBox("La segunda columna del archivo a importar debe ser el Nombre de la Facultad (facultad)")
                            GoTo salir
                        End If

                        Me.dgFacultad.DataSource = Nothing
                        Me.vLista.Columns.Clear()
                        xmlds.Tables(0).Columns.Add("id", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("id").DefaultValue = 0
                        xmlds.Tables(0).Columns("cod_facultad").ColumnName = "id_facultad"
                        xmlds.Tables(0).Columns("facultad").ColumnName = "desc_facultad"

                        Me.dgFacultad.DataSource = xmlds.Tables(0)
                        Me.vLista.Columns("id").Visible = False
                        Me.vLista.Columns("id_facultad").Caption = "ID_Facultad"
                        Me.vLista.Columns("desc_facultad").Caption = "Facultad"

salir:              End If
                End Try
            End If
            If IsNothing(mystream) Then
                Exit Sub
            End If
        End If

    End Sub
End Class