Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAprobacionEmpleados_Baja
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAprobacionEmpleados_Baja = Nothing

    Public Shared Function Instance() As frmAprobacionEmpleados_Baja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAprobacionEmpleados_Baja()
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
    Friend WithEvents Liquidados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents cbCausa As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdRevisar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkselector = New System.Windows.Forms.CheckBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdRevisar = New System.Windows.Forms.Button
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl
        Me.Liquidados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbCausa = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Liquidados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
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
        Me.chkselector.TabIndex = 14
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
        Me.cmdRevisar.Text = "Aprobar"
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.EmbeddedNavigator.Name = ""
        Me.dgEmpleados.Location = New System.Drawing.Point(8, 66)
        Me.dgEmpleados.MainView = Me.Liquidados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCausa})
        Me.dgEmpleados.Size = New System.Drawing.Size(952, 464)
        Me.dgEmpleados.TabIndex = 13
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Liquidados})
        '
        'Liquidados
        '
        Me.Liquidados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Liquidados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Liquidados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Liquidados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Liquidados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Liquidados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Liquidados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.Liquidados.Appearance.Empty.Options.UseBackColor = True
        Me.Liquidados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Liquidados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.EvenRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.EvenRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Liquidados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Liquidados.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Liquidados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.Liquidados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Liquidados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Liquidados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Liquidados.Appearance.FixedLine.Options.UseBackColor = True
        Me.Liquidados.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Liquidados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Liquidados.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Liquidados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Liquidados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Liquidados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Liquidados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Liquidados.Appearance.FooterPanel.Options.UseFont = True
        Me.Liquidados.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Liquidados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.GroupButton.Options.UseBackColor = True
        Me.Liquidados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Liquidados.Appearance.GroupButton.Options.UseForeColor = True
        Me.Liquidados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Liquidados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Liquidados.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Liquidados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.Liquidados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Liquidados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Liquidados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.GroupRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Liquidados.Appearance.GroupRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Liquidados.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Liquidados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Liquidados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Liquidados.Appearance.HeaderPanel.Options.UseFont = True
        Me.Liquidados.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Liquidados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Liquidados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Liquidados.Appearance.HorzLine.Options.UseBackColor = True
        Me.Liquidados.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Liquidados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.OddRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.OddRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Liquidados.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.Liquidados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Liquidados.Appearance.Preview.Options.UseBackColor = True
        Me.Liquidados.Appearance.Preview.Options.UseFont = True
        Me.Liquidados.Appearance.Preview.Options.UseForeColor = True
        Me.Liquidados.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Liquidados.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Liquidados.Appearance.Row.Options.UseBackColor = True
        Me.Liquidados.Appearance.Row.Options.UseForeColor = True
        Me.Liquidados.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.Liquidados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Liquidados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Liquidados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Liquidados.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Liquidados.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.Liquidados.Appearance.TopNewRow.Options.UseBackColor = True
        Me.Liquidados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Liquidados.Appearance.VertLine.Options.UseBackColor = True
        Me.Liquidados.GridControl = Me.dgEmpleados
        Me.Liquidados.Name = "Liquidados"
        Me.Liquidados.OptionsBehavior.Editable = False
        Me.Liquidados.OptionsView.EnableAppearanceEvenRow = True
        Me.Liquidados.OptionsView.EnableAppearanceOddRow = True
        Me.Liquidados.OptionsView.ShowAutoFilterRow = True
        Me.Liquidados.OptionsView.ShowFooter = True
        Me.Liquidados.OptionsView.ShowGroupPanel = False
        '
        'cbCausa
        '
        Me.cbCausa.AutoHeight = False
        Me.cbCausa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCausa.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripcion", 200)})
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.NullText = "[ Seleccione ]"
        '
        'frmAprobacionEmpleados_Baja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 542)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAprobacionEmpleados_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Liquidados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Baja As New VB.SysContab.Empleado_BajaDB()
    Dim DBaja As New VB.SysContab.Empleado_Baja()
    Dim ds As DataSet

    Private Sub frmRevisionEmpleados_Baja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargardatos("1", "0", "%", "%")
        Me.Text = "Aprobación de Baja de Empleados"
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub


    Private Sub cmdRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRevisar.Click

        If Me.Liquidados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        DBaja = Baja.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"), _
             Me.Liquidados.GetFocusedRowCellValue("Fecha de Baja"))
        If DBaja.Fecha_Liquidacion Is DBNull.Value Then
            MsgBox("No se puede Aprobar una baja de empleado que ha sido Liquidada", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        Dim f As frmAprobacionEmpleados_BajaEditar = frmAprobacionEmpleados_BajaEditar.Instance
        f.CodEmpleado = Me.Liquidados.GetFocusedRowCellValue("Codigo")
        f.dFecha = Me.Liquidados.GetFocusedRowCellValue("Fecha de Baja")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub Cargardatos(ByVal Revisado As String, ByVal DRevisado As String, _
        ByVal Aprobado As String, ByVal DAprobado As String)

       
        ds = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "0")
        dgEmpleados.DataSource = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "0").Tables("Empleado_baja")
        Me.Liquidados.PopulateColumns()
        ' Me.Liquidados.Columns("Causa").ColumnEdit = Me.cbCausa
        Me.Liquidados.Columns("Causa").Caption = "Pagar Indemnizacion"

        For i As Integer = 0 To Me.Liquidados.Columns.Count - 1
            Me.Liquidados.Columns(i).Visible = False
        Next
        Me.Liquidados.Columns(0).Visible = True
        Me.Liquidados.Columns(0).Width = 60
        Me.Liquidados.Columns(0).VisibleIndex = 0

        Me.Liquidados.Columns(1).Visible = True
        Me.Liquidados.Columns(1).Width = 210
        Me.Liquidados.Columns(1).VisibleIndex = 1

        'Me.Liquidados.Columns(3).Visible = True
        'Me.Liquidados.Columns(3).Width = 210
        'Me.Liquidados.Columns(3).VisibleIndex = 2

        Me.Liquidados.Columns(4).Visible = True
        Me.Liquidados.Columns(4).Width = 120
        Me.Liquidados.Columns(4).VisibleIndex = 3

        Me.Liquidados.Columns(5).Visible = True
        Me.Liquidados.Columns(5).Width = 80
        Me.Liquidados.Columns(5).VisibleIndex = 4
        
    End Sub

    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then Me.Liquidados.ColumnsCustomization() Else Me.Liquidados.DestroyCustomization()
    End Sub
   
End Class
