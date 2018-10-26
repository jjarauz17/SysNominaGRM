Public Class FrmUsuariosListar
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As FrmUsuariosListar = Nothing

    Public Shared Function Instance() As FrmUsuariosListar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmUsuariosListar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents dgRoles As DevExpress.XtraGrid.GridControl
    Friend WithEvents vRoles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.dgRoles = New DevExpress.XtraGrid.GridControl
        Me.vRoles = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Controls.Add(Me.cmdBorrar)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 217)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 30)
        Me.cmdNuevo.TabIndex = 37
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdBorrar.Location = New System.Drawing.Point(8, 112)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(96, 32)
        Me.cmdBorrar.TabIndex = 35
        Me.cmdBorrar.Text = "&Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(8, 160)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(96, 32)
        Me.cmdSalir.TabIndex = 36
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(8, 64)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(96, 30)
        Me.cmdModificar.TabIndex = 34
        Me.cmdModificar.Text = "&Editar"
        '
        'dgRoles
        '
        Me.dgRoles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRoles.EmbeddedNavigator.Name = ""
        Me.dgRoles.Location = New System.Drawing.Point(12, 12)
        Me.dgRoles.MainView = Me.vRoles
        Me.dgRoles.Name = "dgRoles"
        Me.dgRoles.Size = New System.Drawing.Size(400, 212)
        Me.dgRoles.TabIndex = 43
        Me.dgRoles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vRoles})
        '
        'vRoles
        '
        Me.vRoles.GridControl = Me.dgRoles
        Me.vRoles.Name = "vRoles"
        Me.vRoles.OptionsBehavior.Editable = False
        Me.vRoles.OptionsView.ShowAutoFilterRow = True
        Me.vRoles.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vRoles.OptionsView.ShowFooter = True
        Me.vRoles.OptionsView.ShowGroupPanel = False
        '
        'FrmUsuariosListar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 234)
        Me.Controls.Add(Me.dgRoles)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmUsuariosListar"
        Me.Text = "Listado de Usuarios"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Origen As Integer '1 = Seguridad de Inicio, 2 = Desde el Menu Herramientas

    Private Sub FrmUsuariosListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgRoles.DataSource = VB.SysContab.SeguridadDB.GetUsuariosList().Tables("Tabla")

        '*********************************
        Me.cmdNuevo.Enabled = False
        Me.cmdModificar.Enabled = False

        Me.cmdBorrar.Enabled = False

        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '*********************************
    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As FrmUsuarios = FrmUsuarios.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        'Dim f As FrmUsuariosEditar = FrmUsuariosEditar.Instance
        'f.lblUserID.Text = Me.vRoles.GetFocusedRowCellValue("Usuario") 'dgRoles.Item(dgRoles.CurrentRowIndex, 0)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        frmEditarUsuarios.Dispose()
        frmEditarUsuarios.txtUsuario = Me.vRoles.GetFocusedRowCellValue("Usuario")
        frmEditarUsuarios.MdiParent = Me.MdiParent
        frmEditarUsuarios.Show()
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If MsgBox("Esta Seguro que desea Borrar este Usuario", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Try
                VB.SysContab.SeguridadDB.UsuariosBorrar(Me.vRoles.GetFocusedRowCellValue("Usuario"))
                dgRoles.DataSource = VB.SysContab.SeguridadDB.GetUsuariosList().Tables("Tabla")
            Catch ex As Exception

            End Try

        End If

    End Sub

   
End Class
