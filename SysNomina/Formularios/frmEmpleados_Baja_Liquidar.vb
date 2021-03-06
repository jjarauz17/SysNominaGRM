Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmEmpleados_Baja_Liquidar
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmEmpleados_Baja_Liquidar = Nothing

    Public Shared Function Instance() As frmEmpleados_Baja_Liquidar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEmpleados_Baja_Liquidar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdLiquidar As System.Windows.Forms.Button
    Friend WithEvents cmdCalculos As System.Windows.Forms.Button
    Friend WithEvents cmdReImprimir As System.Windows.Forms.Button
    Friend WithEvents dgBajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents Liquidados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cbCausa As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnGenerarPago As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdExportar = New System.Windows.Forms.Button
        Me.chkselector = New System.Windows.Forms.CheckBox
        Me.btnGenerarPago = New System.Windows.Forms.Button
        Me.cmdReImprimir = New System.Windows.Forms.Button
        Me.cmdCalculos = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdLiquidar = New System.Windows.Forms.Button
        Me.dgBajas = New DevExpress.XtraGrid.GridControl
        Me.Liquidados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbCausa = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Liquidados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdExportar)
        Me.GroupBox1.Controls.Add(Me.chkselector)
        Me.GroupBox1.Controls.Add(Me.btnGenerarPago)
        Me.GroupBox1.Controls.Add(Me.cmdReImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdCalculos)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdLiquidar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExportar.Location = New System.Drawing.Point(682, 16)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(104, 24)
        Me.cmdExportar.TabIndex = 14
        Me.cmdExportar.Text = "Exportar Datos"
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkselector.AutoSize = True
        Me.chkselector.Location = New System.Drawing.Point(792, 16)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(147, 17)
        Me.chkselector.TabIndex = 13
        Me.chkselector.Text = "&Mostrar Selector de datos"
        Me.chkselector.UseVisualStyleBackColor = True
        '
        'btnGenerarPago
        '
        Me.btnGenerarPago.Location = New System.Drawing.Point(344, 16)
        Me.btnGenerarPago.Name = "btnGenerarPago"
        Me.btnGenerarPago.Size = New System.Drawing.Size(104, 24)
        Me.btnGenerarPago.TabIndex = 9
        Me.btnGenerarPago.Text = "Generar Pago"
        '
        'cmdReImprimir
        '
        Me.cmdReImprimir.Location = New System.Drawing.Point(232, 16)
        Me.cmdReImprimir.Name = "cmdReImprimir"
        Me.cmdReImprimir.Size = New System.Drawing.Size(104, 24)
        Me.cmdReImprimir.TabIndex = 8
        Me.cmdReImprimir.Text = "Re - Imprimir"
        '
        'cmdCalculos
        '
        Me.cmdCalculos.Location = New System.Drawing.Point(8, 16)
        Me.cmdCalculos.Name = "cmdCalculos"
        Me.cmdCalculos.Size = New System.Drawing.Size(104, 24)
        Me.cmdCalculos.TabIndex = 7
        Me.cmdCalculos.Text = "Generar C�lculos"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(456, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdLiquidar
        '
        Me.cmdLiquidar.Location = New System.Drawing.Point(120, 16)
        Me.cmdLiquidar.Name = "cmdLiquidar"
        Me.cmdLiquidar.Size = New System.Drawing.Size(104, 24)
        Me.cmdLiquidar.TabIndex = 1
        Me.cmdLiquidar.Text = "Liquidar"
        '
        'dgBajas
        '
        Me.dgBajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgBajas.EmbeddedNavigator.Name = ""
        Me.dgBajas.Location = New System.Drawing.Point(8, 64)
        Me.dgBajas.MainView = Me.Liquidados
        Me.dgBajas.Name = "dgBajas"
        Me.dgBajas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCausa})
        Me.dgBajas.Size = New System.Drawing.Size(952, 466)
        Me.dgBajas.TabIndex = 12
        Me.dgBajas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Liquidados})
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
        Me.Liquidados.GridControl = Me.dgBajas
        Me.Liquidados.Name = "Liquidados"
        Me.Liquidados.OptionsBehavior.Editable = False
        Me.Liquidados.OptionsSelection.MultiSelect = True
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
        'frmEmpleados_Baja_Liquidar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 542)
        Me.Controls.Add(Me.dgBajas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmpleados_Baja_Liquidar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgBajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Liquidados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Baja As New VB.SysContab.Empleado_BajaDB()
    Dim DBaja As New VB.SysContab.Empleado_Baja()
    Dim r As New VB.SysContab.RutinasNomina()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Dim dEmpleado As New VB.SysContab.EmpleadosDetails()
    Dim Empleado As New VB.SysContab.EmpleadosDB()
    Dim Liquidacion As New VB.SysContab.LiquidacionDB()

    Private Sub frmEmpleados_Baja_Liquidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargardatos("1", "0", "1", "0")
        Me.Text = "Liquidaci�n de Empleados con Baja Aprobada"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Cargardatos(ByVal Revisado As String, ByVal DRevisado As String, _
        ByVal Aprobado As String, ByVal DAprobado As String)

        VB.SysContab.RutinasNomina.CambiarEstilo(Me)


        ds = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "%")
        dgBajas.DataSource = Baja.GetList(True, Revisado, DRevisado, Aprobado, DAprobado, "%").Tables("Empleado_baja")
        Me.Liquidados.PopulateColumns()
        'Me.Liquidados.Columns("Causa").ColumnEdit = Me.cbCausa
        Me.Liquidados.Columns("Causa").Caption = "Pagar Indemnizaci�n"

        For i As Integer = 0 To Me.Liquidados.Columns.Count - 1
            Me.Liquidados.Columns(i).Visible = False
        Next
        Me.Liquidados.Columns(0).Visible = True
        Me.Liquidados.Columns(0).Width = 60
        Me.Liquidados.Columns(0).VisibleIndex = 0

        Me.Liquidados.Columns(1).Visible = True
        Me.Liquidados.Columns(1).Width = 210
        Me.Liquidados.Columns(1).VisibleIndex = 1

        Me.Liquidados.Columns(4).Visible = True
        Me.Liquidados.Columns(4).Width = 120
        Me.Liquidados.Columns(4).VisibleIndex = 3

        Me.Liquidados.Columns(8).Visible = True
        Me.Liquidados.Columns(8).Width = 80
        Me.Liquidados.Columns(8).VisibleIndex = 4

        Me.Liquidados.Columns(12).Visible = True
        Me.Liquidados.Columns(12).Width = 80
        Me.Liquidados.Columns(12).VisibleIndex = 5

        Me.Liquidados.Columns(13).Visible = True
        Me.Liquidados.Columns(13).Width = 80
        Me.Liquidados.Columns(13).VisibleIndex = 6

        Me.Liquidados.Columns(2).Visible = True
        Me.Liquidados.Columns(2).Width = 80
        Me.Liquidados.Columns(2).VisibleIndex = 7

    End Sub

    Private Sub cmdCalculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculos.Click

        If Me.Liquidados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        dEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"))

        If dEmpleado.Liquidado Then
            MsgBox("Este empleado ya ha sido liquidado con anterioridad", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        Dim dempresa As New VB.SysContab.EmpresasDetails()
        dempresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        Dim liquidacion As New VB.SysContab.LiquidacionDB()
        DBaja = Baja.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"), dEmpleado.Fecha_FinContrato)

        Dim DS As New DataSet()

        If Not liquidacion.Additem(Me.Liquidados.GetFocusedRowCellValue("Codigo"), dEmpleado.Fecha_FinContrato, dEmpleado.Departamento, dempresa.MONEDABASE, DBaja.FormaPago, False) Then
            XtraMsg("Hubo problemas en la generacion de los calculos de la liquidacion, contacte al administrador del sistema", MessageBoxIcon.Warning)
            Exit Sub
        Else
            Imprimir(True)
        End If

    End Sub

    Private Sub Imprimir(ByVal Prueba As Boolean)
        If Prueba Then XtraMsg("Los Calculos se han generado con exito!")
        If Not Prueba Then XtraMsg("Liquidaci�n exitosa!")

        'If crystal Then

        '    Dim fReportes As New frmReportes()
        '    'Dim reporte As New rptLiquidacion()
        '    Dim Reporte As New Object
        '    Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        '    If Not File.Exists(Application.StartupPath & "\reportes\rptLiquidacion.rpt") Then
        '        MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptLiquidacion.rpt")
        '        Exit Sub
        '    End If

        '    Reporte.load(Application.StartupPath & "\reportes\rptLiquidacion.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        '    Dim dsdet As New DataSet

        '    ds = Liquidacion.GetListReporte_Encabezado(Me.Liquidados.GetFocusedRowCellValue("Codigo"), False)
        '    If ds.Tables(0).Rows.Count = 0 Then
        '        MsgBox("No se encontro Encabezado de la Liquidacion, revise con el administrador", MsgBoxStyle.Critical, "SysNomina")
        '        Exit Sub
        '    End If

        '    dsdet = Liquidacion.GetListReporte_Detalle(Me.Liquidados.GetFocusedRowCellValue("Codigo"), ds.Tables(0).Rows(0)("liq_codigo"))
        '    Dim dt As New DataTable
        '    dt = Liquidacion.Liquidacion_Memoria(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
        '    dt.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionMem.xml", XmlWriteMode.WriteSchema)


        '    ds.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml", XmlWriteMode.WriteSchema)
        '    dsdet.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionDet.xml", XmlWriteMode.WriteSchema)

        '    Reporte.Database.Tables("VLiquidacionEnc").Location = Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml"
        '    Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        '    Reporte.Subreports("Detalle").Database.Tables("VLiquidacion_Det").Location = Application.StartupPath & "\exportfiles\rLiquidacionDet.xml"
        '    Reporte.Subreports("Memoria de Calculo").Database.Tables("Memoria").Location = Application.StartupPath & "\exportfiles\rLiquidacionMem.xml"

        '    fReportes.crvReportes.ReportSource = Reporte
        '    fReportes.ShowDialog()
        '    fReportes.Dispose()

        'Else

        '    XtraMsg("Los Calculos se han generado con exito!")

        '    'Dim rpt As New Liquidacion
        '    'Dim dsdet As New DataSet

        '    'ds = Liquidacion.GetListReporte_Encabezado(Me.Liquidados.GetFocusedRowCellValue("Codigo"), False)
        '    'If ds.Tables(0).Rows.Count = 0 Then
        '    '    MsgBox("No se encontro Encabezado de la Liquidacion, revise con el administrador", MsgBoxStyle.Critical, "SysNomina")
        '    '    Exit Sub
        '    'End If


        '    'dsdet = Liquidacion.GetListReporte_Detalle(Me.Liquidados.GetFocusedRowCellValue("Codigo"), ds.Tables(0).Rows(0)("liq_codigo"))
        '    'ds.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml", XmlWriteMode.WriteSchema)
        '    'dsdet.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionDet.xml", XmlWriteMode.WriteSchema)

        '    'rpt.Detalle = dsdet
        '    'rpt.DataSource = ds
        '    'rpt.ShowPreview()

        '    'If MsgBox("Desea ver la memoria de c�lculo de las prestaciones?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    '    Dim rptm As New LiquidacionMem

        '    '    Dim dt As New DataTable
        '    '    dt = Liquidacion.Liquidacion_Memoria(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
        '    '    dt.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionMem.xml", XmlWriteMode.WriteSchema)


        '    '    rptm.DataSource = ds
        '    '    rptm.dt = dt
        '    '    rptm.ShowPreview()
        'End If

        'End If
    End Sub
    Private Sub cmdLiquidar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLiquidar.Click

        If Me.Liquidados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        dEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
        If dEmpleado.Liquidado Then
            MsgBox("Este empleado ya ha sido liquidado con anterioridad", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        Dim dempresa As New VB.SysContab.EmpresasDetails()
        dempresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        Dim liquidacion As New VB.SysContab.LiquidacionDB()
        DBaja = Baja.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"), dEmpleado.Fecha_FinContrato)
        Dim ds As New DataSet()
        If Not liquidacion.Additem(Me.Liquidados.GetFocusedRowCellValue("Codigo"), dEmpleado.Fecha_FinContrato, dEmpleado.Departamento, dempresa.MONEDABASE, DBaja.FormaPago, True) Then
            MsgBox("Hubo problemas en la generacion de los calculos de la liquidacion, contacte al administrador del sistema", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        Else

            'Dim fReportes As New frmReportes()
            'Dim reporte As New rptLiquidacion()
            'Dim dsdet As New DataSet


            'ds = liquidacion.GetListReporte_Encabezado(Me.Liquidados.GetFocusedRowCellValue("Codigo"), True)
            'If ds.Tables(0).Rows.Count = 0 Then
            '    MsgBox("No se encontro Encabezado de la Liquidacion, revise con el administrador", MsgBoxStyle.Critical, "SysNomina")
            '    Exit Sub
            'End If

            'dsdet = liquidacion.GetListReporte_Detalle(Me.Liquidados.GetFocusedRowCellValue("Codigo"), ds.Tables(0).Rows(0)("liq_codigo"))
            'Dim dt As New DataTable
            'dt = liquidacion.Liquidacion_Memoria(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
            'dt.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionMem.xml", XmlWriteMode.WriteSchema)

            'ds.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml", XmlWriteMode.WriteSchema)
            'dsdet.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionDet.xml", XmlWriteMode.WriteSchema)

            'reporte.Database.Tables("VLiquidacionEnc").Location = Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml"
            'reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

            'reporte.Subreports("Detalle").Database.Tables("VLiquidacion_Det").Location = Application.StartupPath & "\exportfiles\rLiquidacionDet.xml"
            'reporte.Subreports("Memoria de Calculo").Database.Tables("Memoria").Location = Application.StartupPath & "\exportfiles\rLiquidacionMem.xml"
            'fReportes.crvReportes.ReportSource = reporte
            'fReportes.ShowDialog()
            'fReportes.Dispose()
            Imprimir(False)
        End If
    End Sub

    Private Sub cmdReImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReImprimir.Click

        If Me.Liquidados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        dEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
        If Not dEmpleado.Liquidado Then
            MsgBox("Este empleado no ha sido liquidado, use la opci�n de Calculos", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        Dim liquidacion As New VB.SysContab.LiquidacionDB()
        DBaja = Baja.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"), dEmpleado.Fecha_FinContrato)
        Dim ds As New DataSet()

        Dim fReportes As New frmReportes()
        'Dim reporte As New rptLiquidacion()
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptLiquidacion.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptLiquidacion.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptLiquidacion.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim dsdet As New DataSet


        ds = liquidacion.GetListReporte_Encabezado(Me.Liquidados.GetFocusedRowCellValue("Codigo"), True)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("No se encontro Encabezado de la Liquidacion, revise con el administrador", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        dsdet = liquidacion.GetListReporte_Detalle(Me.Liquidados.GetFocusedRowCellValue("Codigo"), ds.Tables(0).Rows(0)("liq_codigo"))

        Dim dt As New DataTable
        dt = liquidacion.Liquidacion_Memoria(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
        dt.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionMem.xml", XmlWriteMode.WriteSchema)


        ds.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml", XmlWriteMode.WriteSchema)
        dsdet.WriteXml(Application.StartupPath & "\exportfiles\rLiquidacionDet.xml", XmlWriteMode.WriteSchema)

        Reporte.Database.Tables("VLiquidacionEnc").Location = Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        Reporte.Subreports("Detalle").Database.Tables("VLiquidacion_Det").Location = Application.StartupPath & "\exportfiles\rLiquidacionDet.xml"
        Reporte.Subreports("Memoria de Calculo").Database.Tables("Memoria").Location = Application.StartupPath & "\exportfiles\rLiquidacionMem.xml"

        fReportes.crvReportes.ReportSource = Reporte
        fReportes.ShowDialog()

        ''Imprimir la Memoria de CAlculo
        'If MsgBox("Desea imprimir la memoria de calculo de prestaciones?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    'Dim reporteM As New rptMemoriaLiq
        '    Dim reporteM As New Object
        '    reporteM = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        '    If Not File.Exists(Application.StartupPath & "\reportes\rptMemoriaLiq.rpt") Then
        '        MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptMemoriaLiq.rpt")
        '        Exit Sub
        '    End If

        '    reporteM.load(Application.StartupPath & "\reportes\rptMemoriaLiq.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        '    reporteM.Database.Tables("VLiquidacionEnc").Location = Application.StartupPath & "\exportfiles\rLiquidacionEnc.xml"
        '    reporteM.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
        '    reporteM.Database.Tables("Memoria").Location = Application.StartupPath & "\exportfiles\rLiquidacionMem.xml"
        '    fReportes.crvReportes.ReportSource = reporteM
        '    fReportes.ShowDialog()
        'End If
        fReportes.Dispose()

    End Sub

    Private Sub btnGenerarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarPago.Click

        Dim ds As New DataSet()
        Dim FPagoLiq As String
        Dim cLiquidacion As String
        Dim dLiq As New VB.SysContab.LiquidacionDetails()
        ds = Liquidacion.GetListReporte_Encabezado(Me.Liquidados.GetFocusedRowCellValue("Codigo"), True)
        cLiquidacion = ds.Tables(0).Rows(0)("liq_CODIGO")

        dLiq = Liquidacion.GetDetails(cLiquidacion)
        If dLiq.Cancelada Then
            MsgBox("Esta liquidaci�n ya fue pagada", MsgBoxStyle.Critical, "Sys-Nomina")
            Exit Sub
        End If
        FPagoLiq = "K"
        Dim formulario As New frmLiquidacion_FormaPago()
        formulario.ShowDialog()
        FPagoLiq = formulario.FormaPagoLiquidacion
        formulario.Dispose()
        If FPagoLiq = "K" Then
            Liquidacion.Update_FormaPago(Me.Liquidados.GetFocusedRowCellValue("Codigo"), FPagoLiq, False)
        Else
            Liquidacion.Update_FormaPago(Me.Liquidados.GetFocusedRowCellValue("Codigo"), FPagoLiq, False)
            dEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Me.Liquidados.GetFocusedRowCellValue("Codigo"))
            ConsecutivoBac_Planilla = "00000"
            Dim f As New frmConsecutivoBac_Planilla()

            f.txtConsecutivo.Text = "00000"
            f.frmDesde = dEmpleado.Fecha_FinContrato
            f.frmHasta = DateAdd(DateInterval.Day, 10, CDate(dEmpleado.Fecha_FinContrato))
            f.ShowDialog()

            ds.Tables.Clear()
            ds = Liquidacion.BcoBac(cLiquidacion, ConsecutivoBac_Planilla, FechaPagoPlanilla)

            If VB.SysContab.RutinasNomina.ExportarTXT_Banco(ds.Tables(0), _
                Microsoft.VisualBasic.Left(Me.Liquidados.GetFocusedRowCellValue("Codigo"), 1) & Microsoft.VisualBasic.Right(Me.Liquidados.GetFocusedRowCellValue("Codigo"), 8), cLiquidacion) Then
                Liquidacion.Update_FormaPago(Me.Liquidados.GetFocusedRowCellValue("Codigo"), FPagoLiq, True)
                MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        End If


    End Sub

    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then Me.Liquidados.ColumnsCustomization() Else Me.Liquidados.DestroyCustomization()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(dgBajas)
    End Sub
End Class
