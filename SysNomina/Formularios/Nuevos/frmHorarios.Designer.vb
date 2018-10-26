<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarios
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
        Me.dgHorarios = New DevExpress.XtraGrid.GridControl()
        Me.VHorarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgHorarios
        '
        Me.dgHorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgHorarios.Location = New System.Drawing.Point(12, 12)
        Me.dgHorarios.MainView = Me.VHorarios
        Me.dgHorarios.Name = "dgHorarios"
        Me.dgHorarios.Size = New System.Drawing.Size(485, 260)
        Me.dgHorarios.TabIndex = 14
        Me.dgHorarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VHorarios})
        '
        'VHorarios
        '
        Me.VHorarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VHorarios.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorarios.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VHorarios.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.Empty.Options.UseBackColor = True
        Me.VHorarios.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VHorarios.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VHorarios.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VHorarios.Appearance.EvenRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VHorarios.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VHorarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorarios.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VHorarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VHorarios.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VHorarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VHorarios.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VHorarios.Appearance.GroupRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupRow.Options.UseFont = True
        Me.VHorarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VHorarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VHorarios.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VHorarios.Appearance.HorzLine.Options.UseBackColor = True
        Me.VHorarios.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.OddRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VHorarios.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VHorarios.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VHorarios.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.Preview.Options.UseBackColor = True
        Me.VHorarios.Appearance.Preview.Options.UseFont = True
        Me.VHorarios.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.Row.Options.UseBackColor = True
        Me.VHorarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorarios.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VHorarios.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VHorarios.Appearance.VertLine.Options.UseBackColor = True
        Me.VHorarios.GridControl = Me.dgHorarios
        Me.VHorarios.Name = "VHorarios"
        Me.VHorarios.OptionsBehavior.Editable = False
        Me.VHorarios.OptionsSelection.MultiSelect = True
        Me.VHorarios.OptionsView.EnableAppearanceEvenRow = True
        Me.VHorarios.OptionsView.EnableAppearanceOddRow = True
        Me.VHorarios.OptionsView.ShowAutoFilterRow = True
        Me.VHorarios.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VHorarios.OptionsView.ShowFooter = True
        Me.VHorarios.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 51)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(407, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 26)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmHorarios
        '
        Me.ClientSize = New System.Drawing.Size(509, 330)
        Me.Controls.Add(Me.dgHorarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHorarios"
        CType(Me.dgHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgHorarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents VHorarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
