<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeriados
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
        Me.dgFeriados = New DevExpress.XtraGrid.GridControl()
        Me.VFeriados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFeriados
        '
        Me.dgFeriados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFeriados.Location = New System.Drawing.Point(11, 12)
        Me.dgFeriados.MainView = Me.VFeriados
        Me.dgFeriados.Name = "dgFeriados"
        Me.dgFeriados.Size = New System.Drawing.Size(400, 188)
        Me.dgFeriados.TabIndex = 14
        Me.dgFeriados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VFeriados})
        '
        'VFeriados
        '
        Me.VFeriados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VFeriados.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFeriados.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VFeriados.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.Empty.Options.UseBackColor = True
        Me.VFeriados.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VFeriados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VFeriados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VFeriados.Appearance.EvenRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VFeriados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VFeriados.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFeriados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VFeriados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VFeriados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VFeriados.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFeriados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VFeriados.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VFeriados.Appearance.GroupRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupRow.Options.UseFont = True
        Me.VFeriados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VFeriados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VFeriados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VFeriados.Appearance.HorzLine.Options.UseBackColor = True
        Me.VFeriados.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.OddRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VFeriados.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VFeriados.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VFeriados.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.Preview.Options.UseBackColor = True
        Me.VFeriados.Appearance.Preview.Options.UseFont = True
        Me.VFeriados.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.Row.Options.UseBackColor = True
        Me.VFeriados.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFeriados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VFeriados.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VFeriados.Appearance.VertLine.Options.UseBackColor = True
        Me.VFeriados.GridControl = Me.dgFeriados
        Me.VFeriados.Name = "VFeriados"
        Me.VFeriados.OptionsBehavior.Editable = False
        Me.VFeriados.OptionsSelection.MultiSelect = True
        Me.VFeriados.OptionsView.EnableAppearanceEvenRow = True
        Me.VFeriados.OptionsView.EnableAppearanceOddRow = True
        Me.VFeriados.OptionsView.ShowAutoFilterRow = True
        Me.VFeriados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VFeriados.OptionsView.ShowFooter = True
        Me.VFeriados.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 48)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(322, 16)
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
        'frmFeriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 266)
        Me.Controls.Add(Me.dgFeriados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFeriados"
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgFeriados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VFeriados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
