<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeduccion_Pagos
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
        Me.dgLista = New DevExpress.XtraGrid.GridControl
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbTipoDeduccion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbMonedas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cmdExportar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbTDeduccion = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cbFormaPago = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLista
        '
        Me.dgLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLista.EmbeddedNavigator.Name = ""
        Me.dgLista.Location = New System.Drawing.Point(12, 57)
        Me.dgLista.MainView = Me.vLista
        Me.dgLista.Name = "dgLista"
        Me.dgLista.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.cbTipoDeduccion, Me.cbMonedas})
        Me.dgLista.Size = New System.Drawing.Size(399, 189)
        Me.dgLista.TabIndex = 0
        Me.dgLista.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgLista
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 150)})
        Me.cbEmpleados.Name = "cbEmpleados"
        '
        'cbTipoDeduccion
        '
        Me.cbTipoDeduccion.AutoHeight = False
        Me.cbTipoDeduccion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoDeduccion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 150)})
        Me.cbTipoDeduccion.Name = "cbTipoDeduccion"
        '
        'cbMonedas
        '
        Me.cbMonedas.AutoHeight = False
        Me.cbMonedas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moneda", "Moneda", 150)})
        Me.cbMonedas.Name = "cbMonedas"
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExportar.Location = New System.Drawing.Point(12, 252)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdExportar.TabIndex = 1
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(336, 252)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Tipo Deducción:"
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.Location = New System.Drawing.Point(94, 9)
        Me.cbTDeduccion.Name = "cbTDeduccion"
        Me.cbTDeduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cbTDeduccion.Properties.NullText = ""
        Me.cbTDeduccion.Size = New System.Drawing.Size(309, 20)
        Me.cbTDeduccion.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Forma de Pago:"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(94, 35)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.Items.AddRange(New Object() {"QUINCENAL"})
        Me.cbFormaPago.Size = New System.Drawing.Size(183, 20)
        Me.cbFormaPago.TabIndex = 6
        '
        'frmDeduccion_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 283)
        Me.Controls.Add(Me.cbFormaPago)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbTDeduccion)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.dgLista)
        Me.Name = "frmDeduccion_Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar a P@go$"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgLista As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbTipoDeduccion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbMonedas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.ComboBoxEdit
End Class
