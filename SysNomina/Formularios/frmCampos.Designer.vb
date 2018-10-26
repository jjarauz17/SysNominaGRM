<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgCampos = New DevExpress.XtraGrid.GridControl
        Me.vCampos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDatos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCampos
        '
        Me.dgCampos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCampos.EmbeddedNavigator.Name = ""
        Me.dgCampos.Location = New System.Drawing.Point(12, 12)
        Me.dgCampos.MainView = Me.vCampos
        Me.dgCampos.Name = "dgCampos"
        Me.dgCampos.Size = New System.Drawing.Size(523, 283)
        Me.dgCampos.TabIndex = 0
        Me.dgCampos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vCampos})
        '
        'vCampos
        '
        Me.vCampos.GridControl = Me.dgCampos
        Me.vCampos.Name = "vCampos"
        Me.vCampos.OptionsBehavior.Editable = False
        Me.vCampos.OptionsView.ShowAutoFilterRow = True
        Me.vCampos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vCampos.OptionsView.ShowFooter = True
        Me.vCampos.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdDatos)
        Me.GroupBox1.Controls.Add(Me.cmdEditar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(168, 19)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBorrar.TabIndex = 4
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(442, 19)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        '
        'cmdDatos
        '
        Me.cmdDatos.Location = New System.Drawing.Point(249, 19)
        Me.cmdDatos.Name = "cmdDatos"
        Me.cmdDatos.Size = New System.Drawing.Size(75, 23)
        Me.cmdDatos.TabIndex = 2
        Me.cmdDatos.Text = "Datos"
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(87, 19)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEditar.TabIndex = 1
        Me.cmdEditar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(6, 19)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmCampos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 367)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgCampos)
        Me.Name = "frmCampos"
        Me.Text = "Campos Dinámicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCampos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCampos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDatos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
End Class
