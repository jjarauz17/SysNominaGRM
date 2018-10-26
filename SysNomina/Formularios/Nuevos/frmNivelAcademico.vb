Public Class frmNivelAcademico 
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmNivelAcademico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar()
    End Sub

    Private Sub cargar()
        Me.dgDatos.DataSource = NivelAcademicoDB.List(0)
        Me.vLista.Columns("id").OptionsColumn.AllowFocus = False
        Me.vLista.Columns("id").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("id").Caption = "ID"
        Me.vLista.Columns("descripcion").Caption = "Descripcion"
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempDt As New DataTable
        'Los Deleted
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("id") Is DBNull.Value Then
                    NivelAcademicoDB.Delete(tempDt.Rows(i)("id"))
                End If
            Next

        End If

        'Los Modificados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("id") Is DBNull.Value Then
                    NivelAcademicoDB.ADD(tempDt.Rows(i)("id"), _
                                    tempDt.Rows(i)("descripcion"))
                End If
            Next

        End If

        'Los agregados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If tempDt.Rows(i)("id") Is DBNull.Value Then
                    NivelAcademicoDB.ADD(0, _
                                    tempDt.Rows(i)("descripcion"))
                End If
            Next

        End If
        Me.cargar()
    End Sub


    Private Sub dgDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub
End Class