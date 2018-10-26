Imports DbConnect
Public Class frmAgregarTS

#Region "Variables"
    Public Agregar As Boolean = True
    Public Nombre As String = ""
    Public Email As Boolean = False
#End Region
    Private Sub frmAgregarTS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Agregar Then
            Me.txtNombre.Text = ""
            Me.chkEmail.Checked = False
        Else
            Me.txtNombre.Text = Me.Nombre
            Me.chkEmail.Checked = Me.Email
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Nombre", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.txtNombre.Text)
        v.AddParameter("email", SqlDbType.Bit, 1, ParameterDirection.Input, Me.chkEmail.Checked)
        Try
            v.EjecutarComando("RH_tipo_Solicitud_ADD")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
End Class