Public Class frmAgregarProfesion
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarProfesion = Nothing

    Public Shared Function Instance() As frmAgregarProfesion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarProfesion()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Private Sub frmAgregarProfesion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Nuevo.ToUpper = "SI" Then
            Me.txtCodigo.Visible = False
            Me.lblCodigo.Visible = False
            Me.txtNombre.Text = ""
        Else
            Me.txtCodigo.Visible = True
            Me.lblCodigo.Visible = True
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Nuevo.ToUpper = "SI" Then
            VB.SysContab.ProfesionDB.Add(Me.txtNombre.Text)
        Else
            VB.SysContab.ProfesionDB.Update(Me.txtCodigo.Text, Me.txtNombre.Text)
        End If
        Me.Close()
        Dim lf As frmProfesion = frmProfesion.Instance
        lf.cargar()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class