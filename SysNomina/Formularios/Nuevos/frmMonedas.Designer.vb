﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonedas
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
        Me.dgMonedas = New DevExpress.XtraGrid.GridControl()
        Me.VMonedas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMonedas
        '
        Me.dgMonedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMonedas.Location = New System.Drawing.Point(12, 12)
        Me.dgMonedas.MainView = Me.VMonedas
        Me.dgMonedas.Name = "dgMonedas"
        Me.dgMonedas.Size = New System.Drawing.Size(480, 181)
        Me.dgMonedas.TabIndex = 14
        Me.dgMonedas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VMonedas})
        '
        'VMonedas
        '
        Me.VMonedas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VMonedas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VMonedas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VMonedas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.Empty.Options.UseBackColor = True
        Me.VMonedas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VMonedas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VMonedas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VMonedas.Appearance.EvenRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VMonedas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VMonedas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VMonedas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VMonedas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMonedas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VMonedas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VMonedas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VMonedas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VMonedas.Appearance.GroupRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupRow.Options.UseFont = True
        Me.VMonedas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VMonedas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VMonedas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VMonedas.Appearance.HorzLine.Options.UseBackColor = True
        Me.VMonedas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.OddRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VMonedas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VMonedas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VMonedas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.Preview.Options.UseBackColor = True
        Me.VMonedas.Appearance.Preview.Options.UseFont = True
        Me.VMonedas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.Row.Options.UseBackColor = True
        Me.VMonedas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VMonedas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VMonedas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VMonedas.Appearance.VertLine.Options.UseBackColor = True
        Me.VMonedas.GridControl = Me.dgMonedas
        Me.VMonedas.Name = "VMonedas"
        Me.VMonedas.OptionsBehavior.Editable = False
        Me.VMonedas.OptionsSelection.MultiSelect = True
        Me.VMonedas.OptionsView.EnableAppearanceEvenRow = True
        Me.VMonedas.OptionsView.EnableAppearanceOddRow = True
        Me.VMonedas.OptionsView.ShowAutoFilterRow = True
        Me.VMonedas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VMonedas.OptionsView.ShowFooter = True
        Me.VMonedas.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 48)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(402, 18)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 18)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(86, 18)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 18)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 259)
        Me.Controls.Add(Me.dgMonedas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMonedas"
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMonedas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VMonedas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
