﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacaciones
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
        Me.cmdD = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.spDias = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpAl = New DevExpress.XtraEditors.DateEdit()
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.VEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckbTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdMasDatos = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.cmdPagos = New System.Windows.Forms.Button()
        Me.cmdDias = New System.Windows.Forms.Button()
        Me.cmdFeriados = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.spDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdD
        '
        Me.cmdD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdD.Location = New System.Drawing.Point(353, 11)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(43, 23)
        Me.cmdD.TabIndex = 26
        Me.cmdD.Text = "OK"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(202, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Aplicar a Todos:"
        '
        'spDias
        '
        Me.spDias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spDias.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spDias.Location = New System.Drawing.Point(285, 14)
        Me.spDias.Name = "spDias"
        Me.spDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spDias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spDias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spDias.Properties.IsFloatValue = False
        Me.spDias.Properties.Mask.EditMask = "N00"
        Me.spDias.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.spDias.Size = New System.Drawing.Size(62, 20)
        Me.spDias.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(402, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Al:"
        '
        'dtpAl
        '
        Me.dtpAl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAl.EditValue = Nothing
        Me.dtpAl.Location = New System.Drawing.Point(421, 14)
        Me.dtpAl.Name = "dtpAl"
        Me.dtpAl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpAl.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpAl.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpAl.Properties.Mask.EditMask = "dd/MM/yy"
        Me.dtpAl.Size = New System.Drawing.Size(100, 20)
        Me.dtpAl.TabIndex = 22
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.Location = New System.Drawing.Point(9, 40)
        Me.dgEmpleados.MainView = Me.VEmpleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(512, 218)
        Me.dgEmpleados.TabIndex = 21
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VEmpleados})
        '
        'VEmpleados
        '
        Me.VEmpleados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VEmpleados.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VEmpleados.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VEmpleados.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.Empty.Options.UseBackColor = True
        Me.VEmpleados.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VEmpleados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VEmpleados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VEmpleados.Appearance.EvenRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VEmpleados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VEmpleados.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VEmpleados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEmpleados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VEmpleados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VEmpleados.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VEmpleados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VEmpleados.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VEmpleados.Appearance.GroupRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupRow.Options.UseFont = True
        Me.VEmpleados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VEmpleados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VEmpleados.Appearance.HorzLine.Options.UseBackColor = True
        Me.VEmpleados.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.OddRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VEmpleados.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VEmpleados.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VEmpleados.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.Preview.Options.UseBackColor = True
        Me.VEmpleados.Appearance.Preview.Options.UseFont = True
        Me.VEmpleados.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.Row.Options.UseBackColor = True
        Me.VEmpleados.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VEmpleados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VEmpleados.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VEmpleados.Appearance.VertLine.Options.UseBackColor = True
        Me.VEmpleados.GridControl = Me.dgEmpleados
        Me.VEmpleados.Name = "VEmpleados"
        Me.VEmpleados.OptionsSelection.MultiSelect = True
        Me.VEmpleados.OptionsView.EnableAppearanceEvenRow = True
        Me.VEmpleados.OptionsView.EnableAppearanceOddRow = True
        Me.VEmpleados.OptionsView.ShowAutoFilterRow = True
        Me.VEmpleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VEmpleados.OptionsView.ShowFooter = True
        Me.VEmpleados.OptionsView.ShowGroupPanel = False
        '
        'ckbTodos
        '
        Me.ckbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbTodos.Location = New System.Drawing.Point(9, 10)
        Me.ckbTodos.Name = "ckbTodos"
        Me.ckbTodos.Size = New System.Drawing.Size(72, 24)
        Me.ckbTodos.TabIndex = 20
        Me.ckbTodos.Text = "Todos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdMasDatos)
        Me.GroupBox1.Controls.Add(Me.cmdExportar)
        Me.GroupBox1.Controls.Add(Me.cmdPagos)
        Me.GroupBox1.Controls.Add(Me.cmdDias)
        Me.GroupBox1.Controls.Add(Me.cmdFeriados)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 81)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(8, 46)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(104, 24)
        Me.cmdImprimir.TabIndex = 12
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdMasDatos
        '
        Me.cmdMasDatos.Location = New System.Drawing.Point(8, 16)
        Me.cmdMasDatos.Name = "cmdMasDatos"
        Me.cmdMasDatos.Size = New System.Drawing.Size(104, 24)
        Me.cmdMasDatos.TabIndex = 11
        Me.cmdMasDatos.Text = "Ver Mas Datos"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(118, 46)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(104, 24)
        Me.cmdExportar.TabIndex = 10
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdPagos
        '
        Me.cmdPagos.Location = New System.Drawing.Point(228, 16)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(104, 24)
        Me.cmdPagos.TabIndex = 9
        Me.cmdPagos.Text = "Pago Vacaciones"
        '
        'cmdDias
        '
        Me.cmdDias.Location = New System.Drawing.Point(118, 16)
        Me.cmdDias.Name = "cmdDias"
        Me.cmdDias.Size = New System.Drawing.Size(104, 24)
        Me.cmdDias.TabIndex = 8
        Me.cmdDias.Text = "Otorgar Dias"
        '
        'cmdFeriados
        '
        Me.cmdFeriados.Location = New System.Drawing.Point(402, 16)
        Me.cmdFeriados.Name = "cmdFeriados"
        Me.cmdFeriados.Size = New System.Drawing.Size(104, 24)
        Me.cmdFeriados.TabIndex = 7
        Me.cmdFeriados.Text = "Feriados"
        Me.cmdFeriados.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(402, 46)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'frmVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdD)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.spDias)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dtpAl)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.ckbTodos)
        Me.Name = "frmVacaciones"
        Me.Text = "Vacaciones"
        CType(Me.spDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpAl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdMasDatos As System.Windows.Forms.Button
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdPagos As System.Windows.Forms.Button
    Friend WithEvents cmdDias As System.Windows.Forms.Button
    Friend WithEvents cmdFeriados As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
