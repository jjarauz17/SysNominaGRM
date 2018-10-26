<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanelSolicitudes
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TPConstancias = New DevExpress.XtraTab.XtraTabPage()
        Me.chkPreview = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbImpresoras = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEntregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimirConstancias = New DevExpress.XtraEditors.SimpleButton()
        Me.dgSolicitudes = New DevExpress.XtraGrid.GridControl()
        Me.vSolicitudes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTS_1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TPPermisos = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdNuevoPermiso = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dgPermisos = New DevExpress.XtraGrid.GridControl()
        Me.vPermisos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TPConstancias.SuspendLayout()
        CType(Me.chkPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbImpresoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTS_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPPermisos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TPConstancias
        Me.XtraTabControl1.Size = New System.Drawing.Size(617, 477)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TPConstancias, Me.TPPermisos})
        '
        'TPConstancias
        '
        Me.TPConstancias.Controls.Add(Me.chkPreview)
        Me.TPConstancias.Controls.Add(Me.LabelControl3)
        Me.TPConstancias.Controls.Add(Me.cbImpresoras)
        Me.TPConstancias.Controls.Add(Me.LabelControl1)
        Me.TPConstancias.Controls.Add(Me.cbEstado)
        Me.TPConstancias.Controls.Add(Me.GroupBox1)
        Me.TPConstancias.Controls.Add(Me.dgSolicitudes)
        Me.TPConstancias.Name = "TPConstancias"
        Me.TPConstancias.Size = New System.Drawing.Size(611, 449)
        Me.TPConstancias.Text = "Constancias"
        '
        'chkPreview
        '
        Me.chkPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPreview.Location = New System.Drawing.Point(524, 28)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.Properties.Caption = "Vista Previa"
        Me.chkPreview.Size = New System.Drawing.Size(81, 19)
        Me.chkPreview.TabIndex = 12
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Impresoras:"
        '
        'cbImpresoras
        '
        Me.cbImpresoras.Location = New System.Drawing.Point(71, 34)
        Me.cbImpresoras.Name = "cbImpresoras"
        Me.cbImpresoras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbImpresoras.Size = New System.Drawing.Size(337, 20)
        Me.cbImpresoras.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.Location = New System.Drawing.Point(71, 11)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEstado.Properties.Items.AddRange(New Object() {"Todos", "Anulados", "Pendientes", "Revisados", "Solucionados", "Entregados"})
        Me.cbEstado.Size = New System.Drawing.Size(164, 20)
        Me.cbEstado.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.cmdEntregar)
        Me.GroupBox1.Controls.Add(Me.cmdAnular)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimirConstancias)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 398)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 45)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(429, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Crear Solicitud"
        '
        'cmdEntregar
        '
        Me.cmdEntregar.Location = New System.Drawing.Point(168, 16)
        Me.cmdEntregar.Name = "cmdEntregar"
        Me.cmdEntregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEntregar.TabIndex = 4
        Me.cmdEntregar.Text = "&Entregar"
        '
        'cmdAnular
        '
        Me.cmdAnular.Location = New System.Drawing.Point(6, 16)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnular.TabIndex = 3
        Me.cmdAnular.Text = "&Anular"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(521, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimirConstancias
        '
        Me.cmdImprimirConstancias.Location = New System.Drawing.Point(87, 16)
        Me.cmdImprimirConstancias.Name = "cmdImprimirConstancias"
        Me.cmdImprimirConstancias.Size = New System.Drawing.Size(75, 23)
        Me.cmdImprimirConstancias.TabIndex = 1
        Me.cmdImprimirConstancias.Text = "&Imprimir"
        '
        'dgSolicitudes
        '
        Me.dgSolicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSolicitudes.Location = New System.Drawing.Point(3, 53)
        Me.dgSolicitudes.MainView = Me.vSolicitudes
        Me.dgSolicitudes.Name = "dgSolicitudes"
        Me.dgSolicitudes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTS_1, Me.cbEmpleados})
        Me.dgSolicitudes.Size = New System.Drawing.Size(602, 347)
        Me.dgSolicitudes.TabIndex = 0
        Me.dgSolicitudes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vSolicitudes})
        '
        'vSolicitudes
        '
        Me.vSolicitudes.GridControl = Me.dgSolicitudes
        Me.vSolicitudes.Name = "vSolicitudes"
        Me.vSolicitudes.OptionsView.ShowAutoFilterRow = True
        Me.vSolicitudes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vSolicitudes.OptionsView.ShowFooter = True
        Me.vSolicitudes.OptionsView.ShowGroupPanel = False
        '
        'cbTS_1
        '
        Me.cbTS_1.AutoHeight = False
        Me.cbTS_1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTS_1.Name = "cbTS_1"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Name = "cbEmpleados"
        '
        'TPPermisos
        '
        Me.TPPermisos.Controls.Add(Me.GroupBox2)
        Me.TPPermisos.Controls.Add(Me.LabelControl2)
        Me.TPPermisos.Controls.Add(Me.dgPermisos)
        Me.TPPermisos.Controls.Add(Me.ComboBoxEdit1)
        Me.TPPermisos.Name = "TPPermisos"
        Me.TPPermisos.PageVisible = False
        Me.TPPermisos.Size = New System.Drawing.Size(611, 449)
        Me.TPPermisos.Text = "Permisos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdNuevoPermiso)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 398)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 45)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'cmdNuevoPermiso
        '
        Me.cmdNuevoPermiso.Location = New System.Drawing.Point(6, 16)
        Me.cmdNuevoPermiso.Name = "cmdNuevoPermiso"
        Me.cmdNuevoPermiso.Size = New System.Drawing.Size(87, 23)
        Me.cmdNuevoPermiso.TabIndex = 0
        Me.cmdNuevoPermiso.Text = "&Nuevo Permiso"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Estado:"
        '
        'dgPermisos
        '
        Me.dgPermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPermisos.Location = New System.Drawing.Point(3, 53)
        Me.dgPermisos.MainView = Me.vPermisos
        Me.dgPermisos.Name = "dgPermisos"
        Me.dgPermisos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.dgPermisos.Size = New System.Drawing.Size(602, 347)
        Me.dgPermisos.TabIndex = 0
        Me.dgPermisos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vPermisos})
        '
        'vPermisos
        '
        Me.vPermisos.GridControl = Me.dgPermisos
        Me.vPermisos.Name = "vPermisos"
        Me.vPermisos.OptionsView.ShowAutoFilterRow = True
        Me.vPermisos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vPermisos.OptionsView.ShowFooter = True
        Me.vPermisos.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(71, 11)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Todos", "Anulados", "Pendientes", "Revisados", "Solucionados", "Entregados"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(164, 20)
        Me.ComboBoxEdit1.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(337, 16)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(86, 23)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Permisos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(429, 16)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(86, 23)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Crear Solicitud"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(168, 16)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 4
        Me.SimpleButton5.Text = "&Entregar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(6, 16)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 3
        Me.SimpleButton6.Text = "&Anular"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton7.Location = New System.Drawing.Point(521, 16)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton7.TabIndex = 2
        Me.SimpleButton7.Text = "&Salir"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Location = New System.Drawing.Point(87, 16)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton8.TabIndex = 1
        Me.SimpleButton8.Text = "&Imprimir"
        '
        'frmPanelSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 501)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmPanelSolicitudes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TPConstancias.ResumeLayout(False)
        Me.TPConstancias.PerformLayout()
        CType(Me.chkPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbImpresoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTS_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPPermisos.ResumeLayout(False)
        Me.TPPermisos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TPConstancias As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgSolicitudes As DevExpress.XtraGrid.GridControl
    Friend WithEvents vSolicitudes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTS_1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimirConstancias As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdEntregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbImpresoras As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkPreview As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TPPermisos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dgPermisos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vPermisos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNuevoPermiso As DevExpress.XtraEditors.SimpleButton
End Class
