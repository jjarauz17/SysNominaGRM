
Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmRevisionEmpleados_Baja
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmRevisionEmpleados_Baja = Nothing

    Public Shared Function Instance() As frmRevisionEmpleados_Baja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRevisionEmpleados_Baja()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents Empleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents cbCausa As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdRevisar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkselector = New System.Windows.Forms.CheckBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdRevisar = New System.Windows.Forms.Button
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl
        Me.Empleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbCausa = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkselector)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdRevisar)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkselector.AutoSize = True
        Me.chkselector.Location = New System.Drawing.Point(801, 16)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(147, 17)
        Me.chkselector.TabIndex = 15
        Me.chkselector.Text = "&Mostrar Selector de datos"
        Me.chkselector.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(88, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdRevisar
        '
        Me.cmdRevisar.Location = New System.Drawing.Point(8, 16)
        Me.cmdRevisar.Name = "cmdRevisar"
        Me.cmdRevisar.Size = New System.Drawing.Size(72, 24)
        Me.cmdRevisar.TabIndex = 1
        Me.cmdRevisar.Text = "Revisar"
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.EmbeddedNavigator.Name = ""
        Me.dgEmpleados.Location = New System.Drawing.Point(5, 55)
        Me.dgEmpleados.MainView = Me.Empleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCausa})
        Me.dgEmpleados.Size = New System.Drawing.Size(952, 486)
        Me.dgEmpleados.TabIndex = 14
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
        Me.Empleados.OptionsView.EnableAppearanceEvenRow = True
        Me.Empleados.OptionsView.EnableAppearanceOddRow = True
        Me.Empleados.OptionsView.ShowAutoFilterRow = True
        Me.Empleados.OptionsView.ShowFooter = True
        Me.Empleados.OptionsView.ShowGroupPanel = False
        '
        'cbCausa
        '
        Me.cbCausa.AutoHeight = False
        Me.cbCausa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCausa.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripcion", 200)})
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.NullText = "[ Seleccione ]"
        '
        'frmRevisionEmpleados_Baja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 544)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRevisionEmpleados_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Baja As New VB.SysContab.Empleado_BajaDB()
    Dim DBaja As New VB.SysContab.Empleado_Baja()
    Dim ds As DataSet

    Private Sub frmRevisionEmpleados_Baja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargardatos("%", "%", "0", "0")
        Me.Text = "Revisión de Baja de Empleados"
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub


    Private Sub cmdRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRevisar.Click

        If Me.Empleados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        DBaja = Baja.GetDetails(Me.Empleados.GetFocusedRowCellValue("Codigo"), _
            Me.Empleados.GetFocusedRowCellValue("Fecha de Baja"))
        If DBaja.Aprobado Or DBaja.Aprobado_Denegado Then
            MsgBox("No se puede Aprobar la Revision de una baja de empleado que ha sido Aprobada para Liquidación", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        Dim f As frmRevisionEmpleados_BajaEditar = frmRevisionEmpleados_BajaEditar.Instance
        f.CodEmpleado = Me.Empleados.GetFocusedRowCellValue("Codigo")
        f.dFecha = Me.Empleados.GetFocusedRowCellValue("Fecha de Baja")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub Cargardatos(ByVal Revisado As String, ByVal DRevisado As String, _
        ByVal Aprobado As String, ByVal DAprobado As String)

        Me.cbCausa.DataSource = VB.SysContab.CausasDespidoDB.Lista(0, "%")
        Me.cbCausa.DisplayMember = "descripcion"
        Me.cbCausa.ValueMember = "id"


        ds = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "0")
        dgEmpleados.DataSource = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "0").Tables("Empleado_baja")
        Me.Empleados.PopulateColumns()
        'Me.Empleados.Columns("Causa").ColumnEdit = Me.cbCausa
        Me.Empleados.Columns("Causa").Caption = "Pagar Indemnizacion"
        For i As Integer = 0 To Me.Empleados.Columns.Count - 1
            Me.Empleados.Columns(i).Visible = False
        Next
        Me.Empleados.Columns(0).Visible = True
        Me.Empleados.Columns(0).Width = 60
        Me.Empleados.Columns(0).VisibleIndex = 0

        Me.Empleados.Columns(1).Visible = True
        Me.Empleados.Columns(1).Width = 210
        Me.Empleados.Columns(1).VisibleIndex = 1

        Me.Empleados.Columns(4).Visible = True
        Me.Empleados.Columns(4).Width = 120
        Me.Empleados.Columns(4).VisibleIndex = 3


    End Sub


    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then Me.Empleados.ColumnsCustomization() Else Me.Empleados.DestroyCustomization()
    End Sub

End Class
