﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFunciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dgFunciones = New DevExpress.XtraGrid.GridControl()
        Me.VFunciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 48)
        Me.GroupBox1.TabIndex = 14
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
        'dgFunciones
        '
        Me.dgFunciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFunciones.Location = New System.Drawing.Point(5, 12)
        Me.dgFunciones.MainView = Me.VFunciones
        Me.dgFunciones.Name = "dgFunciones"
        Me.dgFunciones.Size = New System.Drawing.Size(588, 211)
        Me.dgFunciones.TabIndex = 15
        Me.dgFunciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VFunciones})
        '
        'VFunciones
        '
        Me.VFunciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VFunciones.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFunciones.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VFunciones.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.Empty.Options.UseBackColor = True
        Me.VFunciones.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VFunciones.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VFunciones.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VFunciones.Appearance.EvenRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VFunciones.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VFunciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFunciones.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VFunciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VFunciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VFunciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFunciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VFunciones.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VFunciones.Appearance.GroupRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupRow.Options.UseFont = True
        Me.VFunciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VFunciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VFunciones.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VFunciones.Appearance.HorzLine.Options.UseBackColor = True
        Me.VFunciones.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.OddRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VFunciones.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VFunciones.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VFunciones.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.Preview.Options.UseBackColor = True
        Me.VFunciones.Appearance.Preview.Options.UseFont = True
        Me.VFunciones.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.Row.Options.UseBackColor = True
        Me.VFunciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFunciones.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VFunciones.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VFunciones.Appearance.VertLine.Options.UseBackColor = True
        Me.VFunciones.GridControl = Me.dgFunciones
        Me.VFunciones.Name = "VFunciones"
        Me.VFunciones.OptionsBehavior.Editable = False
        Me.VFunciones.OptionsSelection.MultiSelect = True
        Me.VFunciones.OptionsView.EnableAppearanceEvenRow = True
        Me.VFunciones.OptionsView.EnableAppearanceOddRow = True
        Me.VFunciones.OptionsView.ShowAutoFilterRow = True
        Me.VFunciones.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VFunciones.OptionsView.ShowFooter = True
        Me.VFunciones.OptionsView.ShowGroupPanel = False
        '
        'frmFunciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 289)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFunciones)
        Me.Name = "frmFunciones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dgFunciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents VFunciones As DevExpress.XtraGrid.Views.Grid.GridView
End Class
