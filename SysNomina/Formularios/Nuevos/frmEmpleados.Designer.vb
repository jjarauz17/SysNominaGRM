﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.Empleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPagos = New System.Windows.Forms.Button()
        Me.cmdCodigosBarra = New System.Windows.Forms.Button()
        Me.cmdHeadCount = New System.Windows.Forms.Button()
        Me.cmdIR = New System.Windows.Forms.Button()
        Me.cmdExpDatos = New System.Windows.Forms.Button()
        Me.bHorarios = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.chkselector = New System.Windows.Forms.CheckBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.bExportar = New System.Windows.Forms.Button()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 30)
        Me.dgEmpleados.MainView = Me.Empleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(849, 337)
        Me.dgEmpleados.TabIndex = 19
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Empleados})
        '
        'Empleados
        '
        Me.Empleados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Empleados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Empleados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Empleados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Empleados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Empleados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Empleados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.Empleados.Appearance.Empty.Options.UseBackColor = True
        Me.Empleados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Empleados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.EvenRow.Options.UseBackColor = True
        Me.Empleados.Appearance.EvenRow.Options.UseForeColor = True
        Me.Empleados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Empleados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Empleados.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Empleados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.Empleados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Empleados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Empleados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Empleados.Appearance.FixedLine.Options.UseBackColor = True
        Me.Empleados.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Empleados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Empleados.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Empleados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Empleados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Empleados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Empleados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Empleados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Empleados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Empleados.Appearance.FooterPanel.Options.UseFont = True
        Me.Empleados.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Empleados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.GroupButton.Options.UseBackColor = True
        Me.Empleados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Empleados.Appearance.GroupButton.Options.UseForeColor = True
        Me.Empleados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Empleados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Empleados.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Empleados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.Empleados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Empleados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Empleados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.GroupRow.Options.UseBackColor = True
        Me.Empleados.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Empleados.Appearance.GroupRow.Options.UseForeColor = True
        Me.Empleados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Empleados.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Empleados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Empleados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Empleados.Appearance.HeaderPanel.Options.UseFont = True
        Me.Empleados.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Empleados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Empleados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Empleados.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Empleados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Empleados.Appearance.HorzLine.Options.UseBackColor = True
        Me.Empleados.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Empleados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.OddRow.Options.UseBackColor = True
        Me.Empleados.Appearance.OddRow.Options.UseForeColor = True
        Me.Empleados.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Empleados.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.Empleados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Empleados.Appearance.Preview.Options.UseBackColor = True
        Me.Empleados.Appearance.Preview.Options.UseFont = True
        Me.Empleados.Appearance.Preview.Options.UseForeColor = True
        Me.Empleados.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Empleados.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Appearance.Row.Options.UseBackColor = True
        Me.Empleados.Appearance.Row.Options.UseForeColor = True
        Me.Empleados.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.Empleados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Empleados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Empleados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Empleados.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Empleados.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Empleados.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.Empleados.Appearance.TopNewRow.Options.UseBackColor = True
        Me.Empleados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Empleados.Appearance.VertLine.Options.UseBackColor = True
        Me.Empleados.GridControl = Me.dgEmpleados
        Me.Empleados.Name = "Empleados"
        Me.Empleados.OptionsBehavior.Editable = False
        Me.Empleados.OptionsSelection.MultiSelect = True
        Me.Empleados.OptionsView.EnableAppearanceEvenRow = True
        Me.Empleados.OptionsView.EnableAppearanceOddRow = True
        Me.Empleados.OptionsView.ShowAutoFilterRow = True
        Me.Empleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Empleados.OptionsView.ShowFooter = True
        Me.Empleados.OptionsView.ShowGroupedColumns = True
        Me.Empleados.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.bExportar)
        Me.GroupBox1.Controls.Add(Me.cmdPagos)
        Me.GroupBox1.Controls.Add(Me.cmdCodigosBarra)
        Me.GroupBox1.Controls.Add(Me.cmdHeadCount)
        Me.GroupBox1.Controls.Add(Me.cmdIR)
        Me.GroupBox1.Controls.Add(Me.cmdExpDatos)
        Me.GroupBox1.Controls.Add(Me.bHorarios)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 48)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'cmdPagos
        '
        Me.cmdPagos.Location = New System.Drawing.Point(640, 15)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(33, 24)
        Me.cmdPagos.TabIndex = 20
        Me.cmdPagos.Text = "Catalogo"
        Me.cmdPagos.Visible = False
        '
        'cmdCodigosBarra
        '
        Me.cmdCodigosBarra.Location = New System.Drawing.Point(562, 15)
        Me.cmdCodigosBarra.Name = "cmdCodigosBarra"
        Me.cmdCodigosBarra.Size = New System.Drawing.Size(72, 24)
        Me.cmdCodigosBarra.TabIndex = 19
        Me.cmdCodigosBarra.Text = "&Cód. Barra"
        '
        'cmdHeadCount
        '
        Me.cmdHeadCount.Location = New System.Drawing.Point(411, 15)
        Me.cmdHeadCount.Name = "cmdHeadCount"
        Me.cmdHeadCount.Size = New System.Drawing.Size(67, 24)
        Me.cmdHeadCount.TabIndex = 18
        Me.cmdHeadCount.Text = "E/&S"
        '
        'cmdIR
        '
        Me.cmdIR.Location = New System.Drawing.Point(484, 15)
        Me.cmdIR.Name = "cmdIR"
        Me.cmdIR.Size = New System.Drawing.Size(72, 24)
        Me.cmdIR.TabIndex = 16
        Me.cmdIR.Text = "&Impuestos"
        '
        'cmdExpDatos
        '
        Me.cmdExpDatos.Location = New System.Drawing.Point(338, 15)
        Me.cmdExpDatos.Name = "cmdExpDatos"
        Me.cmdExpDatos.Size = New System.Drawing.Size(67, 24)
        Me.cmdExpDatos.TabIndex = 8
        Me.cmdExpDatos.Text = "E&xp. Datos"
        '
        'bHorarios
        '
        Me.bHorarios.Location = New System.Drawing.Point(206, 15)
        Me.bHorarios.Name = "bHorarios"
        Me.bHorarios.Size = New System.Drawing.Size(60, 24)
        Me.bHorarios.TabIndex = 7
        Me.bHorarios.Text = "&Horarios"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(783, 15)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(60, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(140, 15)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(60, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(272, 15)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(60, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(74, 15)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(60, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 15)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(60, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkselector.AutoSize = True
        Me.chkselector.Location = New System.Drawing.Point(711, 7)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(150, 17)
        Me.chkselector.TabIndex = 20
        Me.chkselector.Text = "&Mostrar Selector de datos"
        Me.chkselector.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(12, 7)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(55, 17)
        Me.chkTodos.TabIndex = 21
        Me.chkTodos.Text = "&Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Location = New System.Drawing.Point(699, 15)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(78, 24)
        Me.bExportar.TabIndex = 21
        Me.bExportar.Text = "&Exportar"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 433)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkselector)
        Me.Controls.Add(Me.chkTodos)
        Me.Name = "frmEmpleados"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents Empleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPagos As System.Windows.Forms.Button
    Friend WithEvents cmdCodigosBarra As System.Windows.Forms.Button
    Friend WithEvents cmdHeadCount As System.Windows.Forms.Button
    Friend WithEvents cmdIR As System.Windows.Forms.Button
    Friend WithEvents cmdExpDatos As System.Windows.Forms.Button
    Friend WithEvents bHorarios As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents bExportar As System.Windows.Forms.Button

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgEmpleados, "Listado de Empleados")
    End Sub
End Class
