<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.dgDepartamentos = New DevExpress.XtraGrid.GridControl
        Me.VDepartamentos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        CType(Me.dgDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDepartamentos
        '
        Me.dgDepartamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDepartamentos.Location = New System.Drawing.Point(12, 12)
        Me.dgDepartamentos.MainView = Me.VDepartamentos
        Me.dgDepartamentos.Name = "dgDepartamentos"
        Me.dgDepartamentos.Size = New System.Drawing.Size(622, 261)
        Me.dgDepartamentos.TabIndex = 11
        Me.dgDepartamentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDepartamentos})
        '
        'VDepartamentos
        '
        Me.VDepartamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VDepartamentos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VDepartamentos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDepartamentos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VDepartamentos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDepartamentos.Appearance.Empty.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VDepartamentos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VDepartamentos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VDepartamentos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VDepartamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VDepartamentos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDepartamentos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VDepartamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDepartamentos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VDepartamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VDepartamentos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VDepartamentos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VDepartamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VDepartamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VDepartamentos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VDepartamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VDepartamentos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDepartamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VDepartamentos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VDepartamentos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VDepartamentos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VDepartamentos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.GroupRow.Options.UseFont = True
        Me.VDepartamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDepartamentos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VDepartamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VDepartamentos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VDepartamentos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VDepartamentos.Appearance.OddRow.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VDepartamentos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VDepartamentos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VDepartamentos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDepartamentos.Appearance.Preview.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.Preview.Options.UseFont = True
        Me.VDepartamentos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VDepartamentos.Appearance.Row.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDepartamentos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VDepartamentos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VDepartamentos.Appearance.VertLine.Options.UseBackColor = True
        Me.VDepartamentos.GridControl = Me.dgDepartamentos
        Me.VDepartamentos.Name = "VDepartamentos"
        Me.VDepartamentos.OptionsBehavior.Editable = False
        Me.VDepartamentos.OptionsView.EnableAppearanceEvenRow = True
        Me.VDepartamentos.OptionsView.EnableAppearanceOddRow = True
        Me.VDepartamentos.OptionsView.ShowAutoFilterRow = True
        Me.VDepartamentos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDepartamentos.OptionsView.ShowFooter = True
        Me.VDepartamentos.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 48)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(544, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(104, 16)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmDepartamentos_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 339)
        Me.Controls.Add(Me.dgDepartamentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDepartamentos_"
        CType(Me.dgDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDepartamentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDepartamentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
