Imports Clases
Imports DevExpress.XtraEditors

Public Class FrmLogin

    Private vUsuario As UsuariosCLS

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
        End
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        Cadena = New Conection(txtUsuario.Text, Contraseña.Text)

        If Cadena.Test Then
            vUsuario = New UsuariosCLS
            Dim DT As DataTable = vUsuario.UserData
            If DT.Rows.Count = 0 Then
                XtraMsg("Usuario no registrado para este modulo", MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Global.StS.Nomina.Usuario = Me.txtUsuario.Text

            Usuario = Me.txtUsuario.Text
            Cadena.Tipo = DT.Rows(0)("Tipo")
            Cadena.Rol = DT.Rows(0)("IdRol")
            'Cadena.Ruta = DT.Rows(0)("Ruta")

            txtUsuario.Dispose()

            Dim se As New frmSeleccionarEmpresa
            se.ShowDialog()
            DialogResult = Windows.Forms.DialogResult.OK

            Close()

            RecordarUsuario()
        Else
            XtraMessageBox.Show("Error : Verifique usuario y contraseña", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ingreso a Sts.Nomina v3.01"
        If GetSetting("Simtesis", "SysNomina2014", "Skin") <> Nothing Then DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(GetSetting("Simtesis", "SysNomina2014", "Skin"))

        'Recordar Usuario
        If GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin") <> Nothing Then
            txtUsuario.Text = Decrypt((GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin"))).ToString
            Contraseña.Text = Decrypt((GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave"))).ToString
            CheckEdit1.CheckState = (GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck"))
        End If
    End Sub

    Private Sub Configurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configurar.Click
        FrmConfiguracionServer.Dispose()
        FrmConfiguracionServer.ShowDialog()
    End Sub


    Sub RecordarUsuario()
        If Me.CheckEdit1.CheckState = CheckState.Checked Then
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin", Encrypt(txtUsuario.Text))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave", Encrypt(Contraseña.Text))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck", CheckEdit1.CheckState)
        Else
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin", Encrypt(""))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave", Encrypt(""))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck", False)
        End If
    End Sub
End Class