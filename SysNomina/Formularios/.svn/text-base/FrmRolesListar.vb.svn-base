Public Class FrmRolesListar
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As FrmRolesListar = Nothing

    Public Shared Function Instance() As FrmRolesListar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRolesListar()
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
    Friend WithEvents cmdEstadoCuenta As System.Windows.Forms.Button
    Friend WithEvents cmdAcumulado As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents dgRoles As DevExpress.XtraGrid.GridControl
    Friend WithEvents vRoles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdEstadoCuenta = New System.Windows.Forms.Button
        Me.cmdAcumulado = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
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
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmdEstadoCuenta)
        Me.GroupBox2.Controls.Add(Me.cmdAcumulado)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 205)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "&Nuevo"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(8, 112)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(96, 32)
        Me.cmdEstadoCuenta.TabIndex = 35
        Me.cmdEstadoCuenta.Text = "&Borrar"
        Me.cmdEstadoCuenta.UseVisualStyleBackColor = False
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Location = New System.Drawing.Point(8, 160)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(96, 32)
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        Me.cmdAcumulado.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 64)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 30)
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Editar"
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
        Me.dgRoles.Size = New System.Drawing.Size(400, 200)
        Me.dgRoles.TabIndex = 41
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
        'FrmRolesListar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 220)
        Me.Controls.Add(Me.dgRoles)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmRolesListar"
        Me.Text = "Lista de Roles"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Origen As Integer '1 = Seguridad de Inicio, 2 = Desde el Menu Herramientas

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub

    Private Sub FrmRolesListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgRoles.DataSource = VB.SysContab.SeguridadDB.GetLisRoles().Tables("Tabla")

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim F As FrmRolesEditar = FrmRolesEditar.Instance
        F.lblRolID.Text = Me.vRoles.GetFocusedRowCellValue("Rol")
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim F As FrmRolesAgregar = FrmRolesAgregar.Instance
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        If MsgBox("Esta Seguro que desea Borrar este Rol", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Try
                VB.SysContab.SeguridadDB.RolesBorrar(Me.vRoles.GetFocusedRowCellValue("Rol"))
                dgRoles.DataSource = VB.SysContab.SeguridadDB.GetLisRoles().Tables("Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class
