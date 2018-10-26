Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmConfiguracionServer

    Private Tested As Boolean = False

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        If Not Tested Then
            XtraMessageBox.Show("La prueba de conexion no ha sido verificada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        SaveSetting("Simtesis", "SysNomina2014", "BaseDatos", Base.Text)
        SaveSetting("Simtesis", "SysNomina2014", "Server", Servidor.Text)
        Close()
    End Sub

    Private Sub FrmConfiguracionServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Base.Text = GetSetting("Simtesis", "SysNomina2014", "BaseDatos")
        Servidor.Text = GetSetting("Simtesis", "SysNomina2014", "Server")
    End Sub

    Private Sub Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        Dim Con As New SqlConnection
        Con.ConnectionString = "Server = " & Servidor.Text & ";User Id=" & Usuario.Text & ";Password = " & Contrasena.Text & ";Initial Catalog = " & Base.Text
        Try
            Con.Open()
            Tested = True
            XtraMessageBox.Show("La prueba de conexion ha sido satisfactoria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Con.Close()
        Catch ex As Exception
            Tested = False
            XtraMessageBox.Show("La prueba de conexion no ha sido satisfactoria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class