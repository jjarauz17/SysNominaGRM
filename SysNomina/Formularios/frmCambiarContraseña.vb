Public Class frmCambiarContraseña
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConfirmar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCambiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCambiarContraseña))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtAnterior = New DevExpress.XtraEditors.TextEdit
        Me.txtPass = New DevExpress.XtraEditors.TextEdit
        Me.txtConfirmar = New DevExpress.XtraEditors.TextEdit
        Me.btnCambiar = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtAnterior)
        Me.GroupControl1.Controls.Add(Me.txtPass)
        Me.GroupControl1.Controls.Add(Me.txtConfirmar)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(424, 128)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(104, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Contraseña Actual:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Location = New System.Drawing.Point(104, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nueva Contraseña:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Location = New System.Drawing.Point(88, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(128, 16)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Confirmar Contraseña:"
        '
        'txtAnterior
        '
        Me.txtAnterior.Location = New System.Drawing.Point(224, 24)
        Me.txtAnterior.Name = "txtAnterior"
        '
        'txtAnterior.Properties
        '
        Me.txtAnterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnterior.Properties.Appearance.Options.UseFont = True
        Me.txtAnterior.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtAnterior.Size = New System.Drawing.Size(184, 22)
        Me.txtAnterior.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(224, 56)
        Me.txtPass.Name = "txtPass"
        '
        'txtPass.Properties
        '
        Me.txtPass.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(184, 20)
        Me.txtPass.TabIndex = 1
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(224, 88)
        Me.txtConfirmar.Name = "txtConfirmar"
        '
        'txtConfirmar.Properties
        '
        Me.txtConfirmar.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(184, 20)
        Me.txtConfirmar.TabIndex = 2
        '
        'btnCambiar
        '
        Me.btnCambiar.Image = CType(resources.GetObject("btnCambiar.Image"), System.Drawing.Image)
        Me.btnCambiar.Location = New System.Drawing.Point(208, 144)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(96, 34)
        Me.btnCambiar.TabIndex = 0
        Me.btnCambiar.Text = "&Cambiar"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(312, 144)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 34)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "&Regresar"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(8, 32)
        Me.PictureEdit1.Name = "PictureEdit1"
        '
        'PictureEdit1.Properties
        '
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(80, 72)
        Me.PictureEdit1.TabIndex = 3
        '
        'frmCambiarContraseña
        '
        Me.AcceptButton = Me.btnCambiar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(442, 188)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarContraseña"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIAR CONTRASEÑA"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCambiarContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupControl1.Text = "USUARIO ACTUAL: " & Login
        Me.txtAnterior.Focus()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Dim dt As DataTable = ObtieneDatos("SELECT * FROM Usuarios u WHERE u.Usr_Login = '" & Login & "'")
        Dim UsrId As Integer = dt.Rows.Item(0)("Usr_Id")

        If dt.Rows.Count = 0 Then
            MsgBox("Usuario: " & Login & " No Encontrado, Consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, "Info...")
            Exit Sub
        End If

        If Not dt.Rows.Item(0)("Usr_Password").ToString.Equals(Me.txtAnterior.Text.Trim) Then
            MsgBox("La Contraseña Anterior es Diferente.", MsgBoxStyle.Information)
            Me.txtAnterior.Focus()
            Me.txtAnterior.SelectAll()
            Exit Sub
        End If

        If Me.txtConfirmar.Text.Trim.Length = 0 Or Me.txtPass.Text.Trim.Length = 0 Then
            MsgBox("Complete la Información.", MsgBoxStyle.Information)
            Me.txtConfirmar.Focus()
            Me.txtConfirmar.SelectAll()
            Exit Sub
        End If

        If Not Me.txtPass.Text.Trim.Equals(Me.txtConfirmar.Text.Trim) Then
            MsgBox("Las Contraseñas Son diferentes.", MsgBoxStyle.Information)
            Me.txtPass.Focus()
            Me.txtPass.SelectAll()
            Exit Sub
        End If

        Datos.Add(Login)
        Datos.Add(Me.txtAnterior.Text)
        Datos.Add(Me.txtPass.Text)
        Variables.Add("@User")
        Variables.Add("@Old")
        Variables.Add("@Pass")

        If ProcedureSave(Datos, Variables, "SPChangePass") Then
            'MsgBox("Contraseña cambiada", MsgBoxStyle.OKOnly)
            MsgBox("La Contraseña ha sido Cambiada con Exito, los cambios surgirán Efecto en le próximo inicio de sesión", MsgBoxStyle.Information)
            Password = Me.txtPass.Text
        Else
            MsgBox("Error al Cambiar la contraseña, Intente nuevamente", MsgBoxStyle.Critical)
        End If

        'If Not _
        '    GuardaDatos("UPDATE Usuarios SET Usr_Password = '" & Me.txtPass.Text.Trim & "' WHERE Usr_Id = " & UsrId) Then
        '    MsgBox("ERROR : La Operación No se ha podido Completar, Consulte con el Administrador del Sistema")
        '    Exit Sub
        'End If


        Me.Close()
    End Sub

   
End Class

