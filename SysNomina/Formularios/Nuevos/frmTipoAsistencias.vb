Public Class frmTipoAsistencias 

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

    End Sub

    Private Sub frmTipoAsistencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dgTiposAsistencias.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("asi_codigo").Caption = "Codigo"
        Me.vLista.Columns("asi_descripcion").Caption = "Descripcion"
        Me.vLista.Columns("asi_memo").Caption = "Detalle"
    End Sub
End Class