<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoIngreso
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
        Me.dgTIngreso = New DevExpress.XtraGrid.GridControl
        Me.VTipo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        CType(Me.dgTIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTIngreso
        '
        Me.dgTIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTIngreso.Location = New System.Drawing.Point(12, 12)
        Me.dgTIngreso.MainView = Me.VTipo
        Me.dgTIngreso.Name = "dgTIngreso"
        Me.dgTIngreso.Size = New System.Drawing.Size(474, 210)
        Me.dgTIngreso.TabIndex = 14
        Me.dgTIngreso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VTipo})
        '
        'VTipo
        '
        Me.VTipo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VTipo.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VTipo.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VTipo.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.Empty.Options.UseBackColor = True
        Me.VTipo.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VTipo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VTipo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VTipo.Appearance.EvenRow.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VTipo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VTipo.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VTipo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VTipo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VTipo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VTipo.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VTipo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupButton.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VTipo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VTipo.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VTipo.Appearance.GroupRow.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupRow.Options.UseFont = True
        Me.VTipo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VTipo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VTipo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VTipo.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VTipo.Appearance.HorzLine.Options.UseBackColor = True
        Me.VTipo.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VTipo.Appearance.OddRow.Options.UseBackColor = True
        Me.VTipo.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VTipo.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VTipo.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VTipo.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.Preview.Options.UseBackColor = True
        Me.VTipo.Appearance.Preview.Options.UseFont = True
        Me.VTipo.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VTipo.Appearance.Row.Options.UseBackColor = True
        Me.VTipo.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VTipo.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VTipo.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VTipo.Appearance.VertLine.Options.UseBackColor = True
        Me.VTipo.GridControl = Me.dgTIngreso
        Me.VTipo.Name = "VTipo"
        Me.VTipo.OptionsBehavior.Editable = False
        Me.VTipo.OptionsView.EnableAppearanceEvenRow = True
        Me.VTipo.OptionsView.EnableAppearanceOddRow = True
        Me.VTipo.OptionsView.ShowAutoFilterRow = True
        Me.VTipo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VTipo.OptionsView.ShowFooter = True
        Me.VTipo.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 48)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(392, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
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
        'frmTipoIngreso_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 288)
        Me.Controls.Add(Me.dgTIngreso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTipoIngreso_"
        CType(Me.dgTIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTIngreso As DevExpress.XtraGrid.GridControl
    Friend WithEvents VTipo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
