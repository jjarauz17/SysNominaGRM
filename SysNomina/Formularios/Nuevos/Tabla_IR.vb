Public Class Tabla_IR 
    Private _tabla As Integer = 0
    Public Sub Abrir(ByRef cTabla As Integer)
        _tabla = cTabla
        Me.ShowDialog()
        cTabla = _tabla
    End Sub
    Private Sub Tabla_IR_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.GridControl1.DataSource = RH_IR.Tablas
        Me.vTablas.OptionsBehavior.Editable = False

        If Me.GridControl1.DataSource.rows.count = 0 Then
            Me.GridControl2.DataSource = RH_IR.List(0, Now, 0)
        Else
            Me.GridControl2.DataSource = RH_IR.List(0, Now, Me.GridControl1.DataSource.rows(0)("ID"))
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    
    Private Sub vTablas_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles vTablas.RowClick
        If Me.GridControl1.DataSource.rows.count = 0 Then
            Me.GridControl2.DataSource = RH_IR.List(0, Now, 0)
        Else
            Me.GridControl2.DataSource = RH_IR.List(0, Now, Me.vTablas.GetFocusedRowCellValue("ID"))
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.vTablas.FocusedRowHandle >= 0 Then
            Me._tabla = Me.vTablas.GetFocusedRowCellValue("ID")
        End If
        Me.Close()
    End Sub
End Class