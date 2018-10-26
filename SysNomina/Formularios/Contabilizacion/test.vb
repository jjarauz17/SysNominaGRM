Public Class test 

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = VB.SysContab.RH_OrganigramaDB.RH_Organigrama_Importar()

        Arbol.DataSource = dt
        Arbol.KeyFieldName = "idsubcentro"
        Arbol.ParentFieldName = "padre"
        Arbol.BestFitColumns()
        'Arbol.Refresh()
    End Sub
End Class