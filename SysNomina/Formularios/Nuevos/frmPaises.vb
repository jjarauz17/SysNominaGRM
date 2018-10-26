Public Class frmPaises 

    Private Sub frmPaises_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Private Sub Cargar()
        Me.dgPaises.DataSource = VB.SysContab.PaisesDB.GetList(True).Tables(0)
        Me.vLista.PopulateColumns()
        Me.vLista.Columns("Codigo").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("Codigo").OptionsColumn.AllowFocus = False
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim tempDt As New DataTable
        'Los Deleted
        tempDt = Me.dgPaises.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("Codigo") Is DBNull.Value Then
                    VB.SysContab.PaisesDB.Delete(tempDt.Rows(i)("Codigo"))
                End If
            Next

        End If

        'Los Modificados
        tempDt = Me.dgPaises.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("Codigo") Is DBNull.Value Then
                    VB.SysContab.PaisesDB.Update(tempDt.Rows(i)("Codigo"), _
                                    tempDt.Rows(i)("Nombre"))
                End If
            Next

        End If

        'Los agregados
        tempDt = Me.dgPaises.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If tempDt.Rows(i)("Codigo") Is DBNull.Value Then
                    VB.SysContab.PaisesDB.AddItem(0, _
                                    tempDt.Rows(i)("Nombre"))
                End If
            Next

        End If

        Cargar()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub dgPaises_KeyDown(sender As Object, e As KeyEventArgs) Handles dgPaises.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub
End Class