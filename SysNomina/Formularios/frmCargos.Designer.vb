﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargos
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
        Me.dgCargos = New DevExpress.XtraGrid.GridControl()
        Me.vCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCargos
        '
        Me.dgCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCargos.Location = New System.Drawing.Point(12, 12)
        Me.dgCargos.MainView = Me.vCargos
        Me.dgCargos.Name = "dgCargos"
        Me.dgCargos.Size = New System.Drawing.Size(612, 261)
        Me.dgCargos.TabIndex = 15
        Me.dgCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vCargos})
        '
        'vCargos
        '
        Me.vCargos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vCargos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vCargos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.vCargos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.Empty.Options.UseBackColor = True
        Me.vCargos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.vCargos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.vCargos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.vCargos.Appearance.EvenRow.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.vCargos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vCargos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.vCargos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vCargos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vCargos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vCargos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vCargos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupButton.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.vCargos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vCargos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vCargos.Appearance.GroupRow.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupRow.Options.UseFont = True
        Me.vCargos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vCargos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.vCargos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vCargos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.vCargos.Appearance.HorzLine.Options.UseBackColor = True
        Me.vCargos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vCargos.Appearance.OddRow.Options.UseBackColor = True
        Me.vCargos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.vCargos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.vCargos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.vCargos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.Preview.Options.UseBackColor = True
        Me.vCargos.Appearance.Preview.Options.UseFont = True
        Me.vCargos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vCargos.Appearance.Row.Options.UseBackColor = True
        Me.vCargos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vCargos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vCargos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.vCargos.Appearance.VertLine.Options.UseBackColor = True
        Me.vCargos.GridControl = Me.dgCargos
        Me.vCargos.Name = "vCargos"
        Me.vCargos.OptionsBehavior.Editable = False
        Me.vCargos.OptionsSelection.MultiSelect = True
        Me.vCargos.OptionsView.EnableAppearanceEvenRow = True
        Me.vCargos.OptionsView.EnableAppearanceOddRow = True
        Me.vCargos.OptionsView.ShowAutoFilterRow = True
        Me.vCargos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vCargos.OptionsView.ShowFooter = True
        Me.vCargos.OptionsView.ShowGroupPanel = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 48)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Location = New System.Drawing.Point(456, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(534, 16)
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
        'frmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 329)
        Me.Controls.Add(Me.dgCargos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCargos"
        CType(Me.dgCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
