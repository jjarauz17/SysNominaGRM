<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConstancias
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTS = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgConstancias = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTS_1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.cbTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgConstancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTS_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tipo de Solicitud:"
        '
        'cbTS
        '
        Me.cbTS.Location = New System.Drawing.Point(99, 25)
        Me.cbTS.Name = "cbTS"
        Me.cbTS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Agregar Nuevo Tipo de Solicitud", Nothing, Nothing, False)})
        Me.cbTS.Properties.NullText = ""
        Me.cbTS.Size = New System.Drawing.Size(366, 20)
        Me.cbTS.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdEditar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(6, 19)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "&Nuevo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(372, 19)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(87, 19)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEditar.TabIndex = 0
        Me.cmdEditar.Text = "&Editar"
        '
        'dgConstancias
        '
        Me.dgConstancias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConstancias.Location = New System.Drawing.Point(12, 63)
        Me.dgConstancias.MainView = Me.vLista
        Me.dgConstancias.Name = "dgConstancias"
        Me.dgConstancias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTS_1})
        Me.dgConstancias.Size = New System.Drawing.Size(453, 211)
        Me.dgConstancias.TabIndex = 4
        Me.dgConstancias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgConstancias
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsSelection.MultiSelect = True
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cbTS_1
        '
        Me.cbTS_1.AutoHeight = False
        Me.cbTS_1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTS_1.Name = "cbTS_1"
        '
        'frmConstancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 340)
        Me.Controls.Add(Me.dgConstancias)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbTS)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmConstancias"
        Me.Text = "Mantenimiento de Constancias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cbTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgConstancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTS_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgConstancias As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTS_1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
