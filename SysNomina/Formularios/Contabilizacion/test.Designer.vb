<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Arbol = New DevExpress.XtraTreeList.TreeList()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.checkedit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arbol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Arbol)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(575, 262)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(575, 262)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'Arbol
        '
        Me.Arbol.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Arbol.Appearance.Empty.Options.UseBackColor = True
        Me.Arbol.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Arbol.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.Arbol.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Arbol.Appearance.EvenRow.Options.UseBackColor = True
        Me.Arbol.Appearance.EvenRow.Options.UseFont = True
        Me.Arbol.Appearance.EvenRow.Options.UseForeColor = True
        Me.Arbol.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Arbol.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Arbol.Appearance.FocusedCell.Options.UseFont = True
        Me.Arbol.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Arbol.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.Arbol.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Arbol.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Arbol.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Arbol.Appearance.FocusedRow.Options.UseFont = True
        Me.Arbol.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Arbol.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Arbol.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Arbol.Appearance.FooterPanel.Options.UseFont = True
        Me.Arbol.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Arbol.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.GroupButton.Options.UseBackColor = True
        Me.Arbol.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Arbol.Appearance.GroupButton.Options.UseForeColor = True
        Me.Arbol.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Arbol.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Arbol.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Arbol.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Arbol.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Arbol.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Arbol.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Arbol.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Arbol.Appearance.HeaderPanel.Options.UseFont = True
        Me.Arbol.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Arbol.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.Arbol.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Arbol.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Arbol.Appearance.HideSelectionRow.Options.UseFont = True
        Me.Arbol.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Arbol.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.HorzLine.Options.UseBackColor = True
        Me.Arbol.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Arbol.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.Arbol.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Arbol.Appearance.OddRow.Options.UseBackColor = True
        Me.Arbol.Appearance.OddRow.Options.UseFont = True
        Me.Arbol.Appearance.OddRow.Options.UseForeColor = True
        Me.Arbol.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.Arbol.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.Preview.ForeColor = System.Drawing.Color.Navy
        Me.Arbol.Appearance.Preview.Options.UseBackColor = True
        Me.Arbol.Appearance.Preview.Options.UseFont = True
        Me.Arbol.Appearance.Preview.Options.UseForeColor = True
        Me.Arbol.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Arbol.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Arbol.Appearance.Row.Options.UseBackColor = True
        Me.Arbol.Appearance.Row.Options.UseFont = True
        Me.Arbol.Appearance.Row.Options.UseForeColor = True
        Me.Arbol.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Arbol.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Arbol.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Arbol.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Arbol.Appearance.SelectedRow.Options.UseFont = True
        Me.Arbol.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Arbol.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Arbol.Appearance.TreeLine.Options.UseBackColor = True
        Me.Arbol.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.Arbol.Appearance.VertLine.Options.UseBackColor = True
        Me.Arbol.Location = New System.Drawing.Point(12, 12)
        Me.Arbol.Name = "Arbol"
        Me.Arbol.OptionsSelection.MultiSelect = True
        Me.Arbol.OptionsSelection.UseIndicatorForSelection = True
        Me.Arbol.OptionsView.EnableAppearanceEvenRow = True
        Me.Arbol.OptionsView.EnableAppearanceOddRow = True
        Me.Arbol.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.checkedit})
        Me.Arbol.Size = New System.Drawing.Size(551, 238)
        Me.Arbol.TabIndex = 10
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("emp_codigo", "Name3", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", 200, "Name4")})
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.NullText = "[Sin valor]"
        Me.cbEmpleados.ShowFooter = False
        Me.cbEmpleados.ShowHeader = False
        '
        'checkedit
        '
        Me.checkedit.AutoHeight = False
        Me.checkedit.Caption = "Check"
        Me.checkedit.Name = "checkedit"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Arbol
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(555, 242)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 262)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arbol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Arbol As DevExpress.XtraTreeList.TreeList
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents checkedit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
