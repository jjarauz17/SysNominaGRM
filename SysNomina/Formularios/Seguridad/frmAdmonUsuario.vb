Imports Clases
Imports DevExpress.XtraEditors
Imports System.Collections

Public Class frmAdmonUsuario

    Private Nuevo As Boolean = False
    Private Rol As RolesCLS
    Private Usuario As UsuariosCLS
    Private vista As New DevExpress.XtraGrid.Views.Grid.GridView
    Private Id As Integer = 0
    Private Funciona As New Functions

    Private Sub FrmCatalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rol = New RolesCLS
        Rol.FillCombo(Roles)
        Rol.Dispose()
        Usuario = New UsuariosCLS
        Usuario.Load(Id)
        GetData()
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        Nuevo = True
        Usuario = New UsuariosCLS
        Usuario.Load(0)

        txtnombre.Text = ""
        txtlogin.Text = ""
        txtcargo.Text = ""
        Roles.EditValue = 0
        Id = 0

        'Empresas
        Me.dgEmpresas.DataSource = VB.SysContab.EmpresasDB.EmpresasXUsuarios("", True)
        Me.vempresas.Columns("Codigo").Visible = False


        CmdGuardar.Enabled = True
        cmdeditar.Enabled = False
        txtlogin.Enabled = True
        txtcargo.Enabled = True
        Roles.Enabled = True
        txtnombre.Enabled = True
        txtnombre.Focus()
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        If Trim(txtnombre.Text) = Nothing Or Trim(txtlogin.Text) = Nothing Or Funcion.IsNull(Roles.EditValue, 0) = 0 Then Exit Sub

        Usuario.Login = txtlogin.Text
        Usuario.Cargo = txtcargo.Text
        Usuario.Nombre = txtnombre.Text
        Usuario.IdRol = Roles.EditValue
        If Usuario.Save Then
            'Guardar las empresas
            For i As Integer = 0 To vempresas.DataRowCount - 1
                Usuario.Save_Empresa(vempresas.GetRowCellValue(i, "Codigo"), vempresas.GetRowCellValue(i, "Asignada"))
            Next
            GetData()
            cmdnuevo_Click(sender, e)
            txtnombre.Enabled = False
            txtlogin.Enabled = False
            txtcargo.Enabled = False
            Roles.Enabled = False
            Nuevo = True
            Id = 0
            'Empresas
            Me.dgEmpresas.DataSource = VB.SysContab.EmpresasDB.EmpresasXUsuarios("", True)
            Me.vempresas.Columns("Codigo").Visible = False
            Usuario.Load(Id)
        End If
    End Sub

    Private Sub GetData()

        GridDetalle.DataSource = Usuario.List 'ObtieneData("SELECT IdUsuario AS Codigo,Nombre,Login,IdRol,Cargo FROM RCT_Usuarios ORDER BY Nombre")
        GridView1.PopulateColumns()
        GridView1.Columns("Codigo").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("Codigo").Visible = False
        GridView1.Columns("IdRol").Visible = False
        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next
    End Sub

    Private Sub GridDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDetalle.Click
        Dim fila As DataRow
        vista = GridDetalle.MainView
        For Each i As Integer In vista.GetSelectedRows
            If i >= 0 Then
                fila = vista.GetDataRow(i)
                txtnombre.Text = fila.Item("Nombre").ToString
                txtlogin.Text = fila.Item("Login").ToString
                txtcargo.Text = fila.Item("Cargo").ToString
                Roles.EditValue = fila.Item("IdRol")
                Id = fila.Item("Codigo")
                Usuario.Load(Id)

                CArgarempresas(fila.Item("Login").ToString)
                cmdeditar.Enabled = True
            End If
        Next
    End Sub

    Private Sub CArgarempresas(ByVal Login As String)
        'Empresas
        Me.dgEmpresas.DataSource = VB.SysContab.EmpresasDB.EmpresasXUsuarios(Login, True)
        Me.vempresas.Columns("Codigo").Visible = False
        For i As Integer = 0 To vempresas.DataRowCount - 2

        Next
    End Sub
    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeditar.Click
        CmdGuardar.Enabled = True
        txtnombre.Enabled = True
        txtcargo.Enabled = True
        Roles.Enabled = True
        Nuevo = False
    End Sub

End Class