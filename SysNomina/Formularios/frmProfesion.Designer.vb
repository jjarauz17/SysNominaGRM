<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfesion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dgProfesion = New DevExpress.XtraGrid.GridControl()
        Me.VProfesion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 48)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Location = New System.Drawing.Point(432, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(510, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(86, 16)
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
        'dgProfesion
        '
        Me.dgProfesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProfesion.Location = New System.Drawing.Point(12, 12)
        Me.dgProfesion.MainView = Me.VProfesion
        Me.dgProfesion.Name = "dgProfesion"
        Me.dgProfesion.Size = New System.Drawing.Size(588, 251)
        Me.dgProfesion.TabIndex = 13
        Me.dgProfesion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VProfesion})
        '
        'VProfesion
        '
        Me.VProfesion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VProfesion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VProfesion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VProfesion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VProfesion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VProfesion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VProfesion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VProfesion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VProfesion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VProfesion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VProfesion.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VProfesion.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VProfesion.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VProfesion.Appearance.Empty.Options.UseBackColor = True
        Me.VProfesion.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VProfesion.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VProfesion.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VProfesion.Appearance.EvenRow.Options.UseBackColor = True
        Me.VProfesion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VProfesion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VProfesion.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VProfesion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VProfesion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VProfesion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VProfesion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VProfesion.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VProfesion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VProfesion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VProfesion.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VProfesion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VProfesion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VProfesion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VProfesion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VProfesion.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VProfesion.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VProfesion.Appearance.GroupButton.Options.UseBackColor = True
        Me.VProfesion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VProfesion.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VProfesion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VProfesion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VProfesion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VProfesion.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VProfesion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VProfesion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VProfesion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VProfesion.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VProfesion.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VProfesion.Appearance.GroupRow.Options.UseBackColor = True
        Me.VProfesion.Appearance.GroupRow.Options.UseFont = True
        Me.VProfesion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VProfesion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VProfesion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VProfesion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VProfesion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VProfesion.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VProfesion.Appearance.HorzLine.Options.UseBackColor = True
        Me.VProfesion.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VProfesion.Appearance.OddRow.Options.UseBackColor = True
        Me.VProfesion.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VProfesion.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VProfesion.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VProfesion.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VProfesion.Appearance.Preview.Options.UseBackColor = True
        Me.VProfesion.Appearance.Preview.Options.UseFont = True
        Me.VProfesion.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VProfesion.Appearance.Row.Options.UseBackColor = True
        Me.VProfesion.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VProfesion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VProfesion.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VProfesion.Appearance.VertLine.Options.UseBackColor = True
        Me.VProfesion.GridControl = Me.dgProfesion
        Me.VProfesion.Name = "VProfesion"
        Me.VProfesion.OptionsBehavior.Editable = False
        Me.VProfesion.OptionsSelection.MultiSelect = True
        Me.VProfesion.OptionsView.EnableAppearanceEvenRow = True
        Me.VProfesion.OptionsView.EnableAppearanceOddRow = True
        Me.VProfesion.OptionsView.ShowAutoFilterRow = True
        Me.VProfesion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VProfesion.OptionsView.ShowFooter = True
        Me.VProfesion.OptionsView.ShowGroupPanel = False
        '
        'frmProfesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 330)
        Me.Controls.Add(Me.dgProfesion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmProfesion"
        Me.Text = "Profesiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgProfesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VProfesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dgProfesion As DevExpress.XtraGrid.GridControl
    Friend WithEvents VProfesion As DevExpress.XtraGrid.Views.Grid.GridView
End Class
