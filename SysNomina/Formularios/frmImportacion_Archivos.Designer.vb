<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportacion_Archivos
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
        Me.dgLista = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTipo_Archivo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cbTipo_Movimiento = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbMonedas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo_Archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo_Movimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLista
        '
        Me.dgLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLista.Location = New System.Drawing.Point(12, 12)
        Me.dgLista.MainView = Me.vLista
        Me.dgLista.Name = "dgLista"
        Me.dgLista.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTipo_Archivo, Me.cbTipo_Movimiento, Me.cbMonedas})
        Me.dgLista.Size = New System.Drawing.Size(400, 200)
        Me.dgLista.TabIndex = 0
        Me.dgLista.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgLista
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cbTipo_Archivo
        '
        Me.cbTipo_Archivo.AutoHeight = False
        Me.cbTipo_Archivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo_Archivo.Items.AddRange(New Object() {"INGRESOS", "DEDUCCIONES", "MARCADAS DE RELOJ", "TASA DE CAMBIO", "ASISTENCIA EPPA"})
        Me.cbTipo_Archivo.Name = "cbTipo_Archivo"
        '
        'cbTipo_Movimiento
        '
        Me.cbTipo_Movimiento.AutoHeight = False
        Me.cbTipo_Movimiento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo_Movimiento.Name = "cbTipo_Movimiento"
        Me.cbTipo_Movimiento.NullText = ""
        '
        'cbMonedas
        '
        Me.cbMonedas.AutoHeight = False
        Me.cbMonedas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.NullText = ""
        '
        'cmdVer
        '
        Me.cmdVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVer.Location = New System.Drawing.Point(12, 224)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(75, 23)
        Me.cmdVer.TabIndex = 1
        Me.cmdVer.Text = "Ver Archivo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(337, 224)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        '
        'frmImportacion_Archivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 259)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.dgLista)
        Me.Name = "frmImportacion_Archivos"
        Me.Text = "Listado de Archivos Importados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo_Archivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo_Movimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLista As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTipo_Archivo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbTipo_Movimiento As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbMonedas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
End Class
