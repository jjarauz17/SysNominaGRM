<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidad
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
        Me.dgLocalidades = New DevExpress.XtraGrid.GridControl()
        Me.VLocalidades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgLocalidades
        '
        Me.dgLocalidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLocalidades.Location = New System.Drawing.Point(12, 12)
        Me.dgLocalidades.MainView = Me.VLocalidades
        Me.dgLocalidades.Name = "dgLocalidades"
        Me.dgLocalidades.Size = New System.Drawing.Size(400, 200)
        Me.dgLocalidades.TabIndex = 0
        Me.dgLocalidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VLocalidades})
        '
        'VLocalidades
        '
        Me.VLocalidades.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VLocalidades.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VLocalidades.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VLocalidades.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VLocalidades.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VLocalidades.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VLocalidades.Appearance.Empty.Options.UseBackColor = True
        Me.VLocalidades.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VLocalidades.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VLocalidades.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VLocalidades.Appearance.EvenRow.Options.UseBackColor = True
        Me.VLocalidades.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VLocalidades.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VLocalidades.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VLocalidades.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VLocalidades.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VLocalidades.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VLocalidades.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VLocalidades.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VLocalidades.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VLocalidades.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VLocalidades.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VLocalidades.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VLocalidades.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VLocalidades.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VLocalidades.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VLocalidades.Appearance.GroupButton.Options.UseBackColor = True
        Me.VLocalidades.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VLocalidades.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VLocalidades.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VLocalidades.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VLocalidades.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VLocalidades.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VLocalidades.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VLocalidades.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VLocalidades.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VLocalidades.Appearance.GroupRow.Options.UseBackColor = True
        Me.VLocalidades.Appearance.GroupRow.Options.UseFont = True
        Me.VLocalidades.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VLocalidades.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VLocalidades.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VLocalidades.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VLocalidades.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VLocalidades.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VLocalidades.Appearance.HorzLine.Options.UseBackColor = True
        Me.VLocalidades.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VLocalidades.Appearance.OddRow.Options.UseBackColor = True
        Me.VLocalidades.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VLocalidades.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VLocalidades.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VLocalidades.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VLocalidades.Appearance.Preview.Options.UseBackColor = True
        Me.VLocalidades.Appearance.Preview.Options.UseFont = True
        Me.VLocalidades.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VLocalidades.Appearance.Row.Options.UseBackColor = True
        Me.VLocalidades.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VLocalidades.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VLocalidades.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VLocalidades.Appearance.VertLine.Options.UseBackColor = True
        Me.VLocalidades.GridControl = Me.dgLocalidades
        Me.VLocalidades.Name = "VLocalidades"
        Me.VLocalidades.OptionsBehavior.Editable = False
        Me.VLocalidades.OptionsSelection.MultiSelect = True
        Me.VLocalidades.OptionsView.EnableAppearanceEvenRow = True
        Me.VLocalidades.OptionsView.EnableAppearanceOddRow = True
        Me.VLocalidades.OptionsView.ShowAutoFilterRow = True
        Me.VLocalidades.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VLocalidades.OptionsView.ShowFooter = True
        Me.VLocalidades.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdEditar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(319, 19)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(168, 19)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBorrar.TabIndex = 2
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(87, 19)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEditar.TabIndex = 1
        Me.cmdEditar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(6, 19)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgLocalidades)
        Me.Name = "frmLocalidad"
        Me.Text = "Sucursales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLocalidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents VLocalidades As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
End Class
