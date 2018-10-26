Imports System.IO

Public Class frmAgregarIngreso
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarIngreso = Nothing

#Region "Variables"
    'Public Unico As Boolean
    Dim inicio, final As Date
    Dim detIngreso As New VB.SysContab.IngresoDetails()
    Dim Tipo As Integer
    Dim Doble As Boolean
    Dim Cargado As Boolean = False
    Dim detEmpleados As New VB.SysContab.EmpleadosDetails()
#End Region
#Region "Calaches"
    Friend WithEvents cbempleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents VistaEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgDetalleIngreso As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDetalleIngreso As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasHoras As System.Windows.Forms.TextBox
    Friend WithEvents txtMonedaPago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTIngreso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents frmAgregarIngresoConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcDias As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcValor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents meComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lcdetalle As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
#End Region

    Public Shared Function Instance() As frmAgregarIngreso
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarIngreso()
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtptm_monto As System.Windows.Forms.TextBox
    Friend WithEvents txting_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents txting_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents dtping_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkNREgular As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtMonedaPago = New DevExpress.XtraEditors.TextEdit()
        Me.cbempleado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.VistaEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txting_Codigo = New System.Windows.Forms.TextBox()
        Me.txting_Fecha = New System.Windows.Forms.TextBox()
        Me.dtping_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtptm_monto = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDiasHoras = New System.Windows.Forms.TextBox()
        Me.chkNREgular = New System.Windows.Forms.CheckBox()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.cbTIngreso = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgDetalleIngreso = New DevExpress.XtraGrid.GridControl()
        Me.VDetalleIngreso = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.frmAgregarIngresoConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcDias = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcValor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.meComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcdetalle = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.txtMonedaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDetalleIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarIngresoConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarIngresoConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(778, 442)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(71, 28)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(699, 442)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 30
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtMonedaPago
        '
        Me.txtMonedaPago.Enabled = False
        Me.txtMonedaPago.Location = New System.Drawing.Point(100, 36)
        Me.txtMonedaPago.Name = "txtMonedaPago"
        Me.txtMonedaPago.Size = New System.Drawing.Size(326, 20)
        Me.txtMonedaPago.StyleController = Me.frmAgregarIngresoConvertedLayout
        Me.txtMonedaPago.TabIndex = 167
        '
        'cbempleado
        '
        Me.cbempleado.EditValue = ""
        Me.cbempleado.Location = New System.Drawing.Point(100, 12)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbempleado.Properties.NullText = ""
        Me.cbempleado.Properties.PopupFormSize = New System.Drawing.Size(600, 0)
        Me.cbempleado.Properties.PopupSizeable = False
        Me.cbempleado.Properties.ShowFooter = False
        Me.cbempleado.Properties.View = Me.VistaEmpleado
        Me.cbempleado.Size = New System.Drawing.Size(326, 20)
        Me.cbempleado.StyleController = Me.frmAgregarIngresoConvertedLayout
        Me.cbempleado.TabIndex = 166
        '
        'VistaEmpleado
        '
        Me.VistaEmpleado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.Empty.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.VistaEmpleado.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.EvenRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.EvenRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.FixedLine.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VistaEmpleado.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseFont = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.VistaEmpleado.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.HorzLine.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VistaEmpleado.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.OddRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.OddRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.VistaEmpleado.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.VistaEmpleado.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.Preview.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.Preview.Options.UseFont = True
        Me.VistaEmpleado.Appearance.Preview.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VistaEmpleado.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.Row.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.Row.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VistaEmpleado.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.SelectedRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.SelectedRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.TopNewRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.VertLine.Options.UseBackColor = True
        Me.VistaEmpleado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Nombre})
        Me.VistaEmpleado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.VistaEmpleado.Name = "VistaEmpleado"
        Me.VistaEmpleado.OptionsBehavior.Editable = False
        Me.VistaEmpleado.OptionsCustomization.AllowColumnMoving = False
        Me.VistaEmpleado.OptionsCustomization.AllowColumnResizing = False
        Me.VistaEmpleado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaEmpleado.OptionsView.EnableAppearanceEvenRow = True
        Me.VistaEmpleado.OptionsView.EnableAppearanceOddRow = True
        Me.VistaEmpleado.OptionsView.ShowAutoFilterRow = True
        Me.VistaEmpleado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VistaEmpleado.OptionsView.ShowGroupPanel = False
        '
        'Codigo
        '
        Me.Codigo.Caption = "Código"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        '
        'txting_Codigo
        '
        Me.txting_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txting_Codigo.Enabled = False
        Me.txting_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txting_Codigo.Location = New System.Drawing.Point(112, 72)
        Me.txting_Codigo.MaxLength = 6
        Me.txting_Codigo.Name = "txting_Codigo"
        Me.txting_Codigo.Size = New System.Drawing.Size(248, 20)
        Me.txting_Codigo.TabIndex = 147
        '
        'txting_Fecha
        '
        Me.txting_Fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txting_Fecha.Enabled = False
        Me.txting_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txting_Fecha.Location = New System.Drawing.Point(729, 12)
        Me.txting_Fecha.MaxLength = 15
        Me.txting_Fecha.Name = "txting_Fecha"
        Me.txting_Fecha.Size = New System.Drawing.Size(120, 20)
        Me.txting_Fecha.TabIndex = 149
        '
        'dtping_FechaInicio
        '
        Me.dtping_FechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtping_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtping_FechaInicio.Location = New System.Drawing.Point(112, 169)
        Me.dtping_FechaInicio.Name = "dtping_FechaInicio"
        Me.dtping_FechaInicio.Size = New System.Drawing.Size(248, 20)
        Me.dtping_FechaInicio.TabIndex = 153
        '
        'txtptm_monto
        '
        Me.txtptm_monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_monto.Location = New System.Drawing.Point(639, 72)
        Me.txtptm_monto.MaxLength = 15
        Me.txtptm_monto.Name = "txtptm_monto"
        Me.txtptm_monto.Size = New System.Drawing.Size(198, 20)
        Me.txtptm_monto.TabIndex = 154
        '
        'txtValor
        '
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(639, 120)
        Me.txtValor.MaxLength = 15
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(198, 20)
        Me.txtValor.TabIndex = 172
        '
        'txtDiasHoras
        '
        Me.txtDiasHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasHoras.Location = New System.Drawing.Point(639, 96)
        Me.txtDiasHoras.MaxLength = 15
        Me.txtDiasHoras.Name = "txtDiasHoras"
        Me.txtDiasHoras.Size = New System.Drawing.Size(198, 20)
        Me.txtDiasHoras.TabIndex = 170
        '
        'chkNREgular
        '
        Me.chkNREgular.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chkNREgular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNREgular.Location = New System.Drawing.Point(112, 145)
        Me.chkNREgular.Name = "chkNREgular"
        Me.chkNREgular.Size = New System.Drawing.Size(248, 20)
        Me.chkNREgular.TabIndex = 168
        Me.chkNREgular.UseVisualStyleBackColor = False
        '
        'chkCancelado
        '
        Me.chkCancelado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chkCancelado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCancelado.Location = New System.Drawing.Point(729, 36)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(120, 20)
        Me.chkCancelado.TabIndex = 166
        Me.chkCancelado.UseVisualStyleBackColor = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.ItemHeight = 15
        Me.cbMoneda.Location = New System.Drawing.Point(112, 96)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(248, 23)
        Me.cbMoneda.TabIndex = 164
        '
        'cbTIngreso
        '
        Me.cbTIngreso.EditValue = ""
        Me.cbTIngreso.Location = New System.Drawing.Point(112, 121)
        Me.cbTIngreso.Name = "cbTIngreso"
        Me.cbTIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTIngreso.Properties.NullText = ""
        Me.cbTIngreso.Properties.PopupSizeable = False
        Me.cbTIngreso.Properties.PopupWidth = 600
        Me.cbTIngreso.Properties.ShowFooter = False
        Me.cbTIngreso.Size = New System.Drawing.Size(248, 20)
        Me.cbTIngreso.StyleController = Me.frmAgregarIngresoConvertedLayout
        Me.cbTIngreso.TabIndex = 167
        '
        'dgDetalleIngreso
        '
        Me.dgDetalleIngreso.Location = New System.Drawing.Point(12, 205)
        Me.dgDetalleIngreso.MainView = Me.VDetalleIngreso
        Me.dgDetalleIngreso.Name = "dgDetalleIngreso"
        Me.dgDetalleIngreso.Size = New System.Drawing.Size(837, 233)
        Me.dgDetalleIngreso.TabIndex = 161
        Me.dgDetalleIngreso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDetalleIngreso})
        '
        'VDetalleIngreso
        '
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VDetalleIngreso.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDetalleIngreso.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VDetalleIngreso.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalleIngreso.Appearance.Empty.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VDetalleIngreso.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VDetalleIngreso.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VDetalleIngreso.Appearance.EvenRow.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VDetalleIngreso.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VDetalleIngreso.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalleIngreso.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VDetalleIngreso.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDetalleIngreso.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VDetalleIngreso.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VDetalleIngreso.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VDetalleIngreso.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VDetalleIngreso.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VDetalleIngreso.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VDetalleIngreso.Appearance.GroupButton.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VDetalleIngreso.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VDetalleIngreso.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDetalleIngreso.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VDetalleIngreso.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VDetalleIngreso.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VDetalleIngreso.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VDetalleIngreso.Appearance.GroupRow.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.GroupRow.Options.UseFont = True
        Me.VDetalleIngreso.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDetalleIngreso.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VDetalleIngreso.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VDetalleIngreso.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VDetalleIngreso.Appearance.HorzLine.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VDetalleIngreso.Appearance.OddRow.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VDetalleIngreso.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VDetalleIngreso.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VDetalleIngreso.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalleIngreso.Appearance.Preview.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.Preview.Options.UseFont = True
        Me.VDetalleIngreso.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VDetalleIngreso.Appearance.Row.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDetalleIngreso.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VDetalleIngreso.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VDetalleIngreso.Appearance.VertLine.Options.UseBackColor = True
        Me.VDetalleIngreso.GridControl = Me.dgDetalleIngreso
        Me.VDetalleIngreso.Name = "VDetalleIngreso"
        Me.VDetalleIngreso.OptionsBehavior.Editable = False
        Me.VDetalleIngreso.OptionsView.EnableAppearanceEvenRow = True
        Me.VDetalleIngreso.OptionsView.EnableAppearanceOddRow = True
        Me.VDetalleIngreso.OptionsView.ShowAutoFilterRow = True
        Me.VDetalleIngreso.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDetalleIngreso.OptionsView.ShowFooter = True
        Me.VDetalleIngreso.OptionsView.ShowGroupPanel = False
        '
        'frmAgregarIngresoConvertedLayout
        '
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.meComentarios)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.dtping_FechaInicio)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.chkNREgular)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txtDiasHoras)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.cbempleado)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txtptm_monto)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.chkCancelado)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txtMonedaPago)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.cbMoneda)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.cbTIngreso)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txting_Fecha)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txting_Codigo)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.txtValor)
        Me.frmAgregarIngresoConvertedLayout.Controls.Add(Me.dgDetalleIngreso)
        Me.frmAgregarIngresoConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarIngresoConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarIngresoConvertedLayout.Name = "frmAgregarIngresoConvertedLayout"
        Me.frmAgregarIngresoConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1035, 187, 250, 350)
        Me.frmAgregarIngresoConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarIngresoConvertedLayout.Size = New System.Drawing.Size(861, 482)
        Me.frmAgregarIngresoConvertedLayout.TabIndex = 174
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.LayoutControlItem8, Me.lcdetalle})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(861, 482)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdAceptar
        Me.LayoutControlItem1.CustomizationFormText = "Valor:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(687, 430)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(79, 32)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(79, 32)
        Me.LayoutControlItem1.Name = "cmdAceptaritem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(79, 32)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Valor:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtping_FechaInicio
        Me.LayoutControlItem2.CustomizationFormText = "Iniciar Ingreso el:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem2.Name = "dtping_FechaInicioitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Iniciar Ingreso el:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkNREgular
        Me.LayoutControlItem3.CustomizationFormText = "Nomina Regular:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem3.Name = "chkNREgularitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Nomina Regular:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtMonedaPago
        Me.LayoutControlItem4.CustomizationFormText = "Moneda de Pago:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem4.Name = "txtMonedaPagoitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Moneda de Pago:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 13)
        '
        'lcDias
        '
        Me.lcDias.Control = Me.txtDiasHoras
        Me.lcDias.CustomizationFormText = "Dias / Horas:"
        Me.lcDias.Location = New System.Drawing.Point(527, 24)
        Me.lcDias.MaxSize = New System.Drawing.Size(290, 24)
        Me.lcDias.MinSize = New System.Drawing.Size(290, 24)
        Me.lcDias.Name = "lcDias"
        Me.lcDias.Size = New System.Drawing.Size(290, 24)
        Me.lcDias.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcDias.Text = "Dias / Horas:"
        Me.lcDias.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbempleado
        Me.LayoutControlItem6.CustomizationFormText = "Código:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem6.Name = "cbempleadoitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(418, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Código:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtptm_monto
        Me.LayoutControlItem7.CustomizationFormText = "Monto:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(527, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem7.Name = "txtptm_montoitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Monto:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkCancelado
        Me.LayoutControlItem8.CustomizationFormText = "Cancelado:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(629, 24)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem8.Name = "chkCanceladoitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Cancelado:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMoneda
        Me.LayoutControlItem9.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(340, 25)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(340, 25)
        Me.LayoutControlItem9.Name = "cbMonedaitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(340, 25)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Moneda:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbTIngreso
        Me.LayoutControlItem10.CustomizationFormText = "Tipo de Ingreso:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem10.Name = "cbTIngresoitem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Tipo de Ingreso:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txting_Fecha
        Me.LayoutControlItem11.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(629, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem11.Name = "txting_Fechaitem"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Fecha:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txting_Codigo
        Me.LayoutControlItem12.CustomizationFormText = "#Ingreso:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem12.Name = "txting_Codigoitem"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "#Ingreso:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdCancelar
        Me.LayoutControlItem13.CustomizationFormText = "cmdCancelaritem"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(766, 430)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(75, 32)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(75, 32)
        Me.LayoutControlItem13.Name = "cmdCancelaritem"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(75, 32)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "cmdCancelaritem"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextToControlDistance = 0
        Me.LayoutControlItem13.TextVisible = False
        '
        'lcValor
        '
        Me.lcValor.Control = Me.txtValor
        Me.lcValor.CustomizationFormText = "Valor:"
        Me.lcValor.Location = New System.Drawing.Point(527, 48)
        Me.lcValor.MaxSize = New System.Drawing.Size(290, 24)
        Me.lcValor.MinSize = New System.Drawing.Size(290, 24)
        Me.lcValor.Name = "lcValor"
        Me.lcValor.Size = New System.Drawing.Size(290, 24)
        Me.lcValor.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcValor.Text = "Valor:"
        Me.lcValor.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.dgDetalleIngreso
        Me.LayoutControlItem15.CustomizationFormText = "dgDetalleIngresoitem"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlItem15.Name = "dgDetalleIngresoitem"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(841, 237)
        Me.LayoutControlItem15.Text = "dgDetalleIngresoitem"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(418, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(211, 48)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(340, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(187, 72)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 430)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(687, 32)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(340, 72)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(43, 49)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'meComentarios
        '
        Me.meComentarios.Location = New System.Drawing.Point(495, 144)
        Me.meComentarios.Name = "meComentarios"
        Me.meComentarios.Size = New System.Drawing.Size(342, 45)
        Me.meComentarios.StyleController = Me.frmAgregarIngresoConvertedLayout
        Me.meComentarios.TabIndex = 173
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.meComentarios
        Me.LayoutControlItem16.CustomizationFormText = "Comentarios:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(383, 72)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(434, 49)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(434, 49)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(434, 49)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Comentarios:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(84, 13)
        '
        'lcdetalle
        '
        Me.lcdetalle.CustomizationFormText = "lcdetalle"
        Me.lcdetalle.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.EmptySpaceItem4, Me.LayoutControlItem16, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.lcDias, Me.lcValor})
        Me.lcdetalle.Location = New System.Drawing.Point(0, 48)
        Me.lcdetalle.Name = "lcdetalle"
        Me.lcdetalle.Size = New System.Drawing.Size(841, 145)
        Me.lcdetalle.Text = "lcdetalle"
        Me.lcdetalle.TextVisible = False
        '
        'frmAgregarIngreso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 482)
        Me.Controls.Add(Me.frmAgregarIngresoConvertedLayout)
        Me.Name = "frmAgregarIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtMonedaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDetalleIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarIngresoConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarIngresoConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbTIngreso.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        'Me.VTIngresos.PopulateColumns()
        'Me.VTIngresos.Columns("Descripcion").Width = 100
        'Me.VTIngresos.Columns("TipoMovimiento").Visible = False
        'Me.VTIngresos.Columns("Codigo").Visible = False
        'Me.VTIngresos.Columns("Unico").Visible = False
        'Me.VTIngresos.Columns("Tipo").Visible = False

        Me.cbTIngreso.Properties.ValueMember = "Codigo"
        Me.cbTIngreso.Properties.DisplayMember = "Descripcion"

        cbMoneda.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMoneda.ValueMember = "Codigo"
        cbMoneda.DisplayMember = "Descripcion"

        Me.cbempleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.VistaEmpleado.Columns("Codigo").Width = 100
        Me.VistaEmpleado.Columns("Nombre").Width = 250
        Me.cbempleado.Properties.DisplayMember = "Nombre"
        Me.cbempleado.Properties.ValueMember = "Codigo"


        Me.chkNREgular.Checked = True
        Me.meComentarios.EditValue = ""

        VB.SysContab.PeriodoNominaDB.GetListFechaMinima_Nominas(inicio, final)

        If Nuevo = "NO" Then

            detIngreso = VB.SysContab.IngresoDB.GetDetails(Registro)
            detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(detIngreso.Empleado)
            Me.Text = "Editar Ingreso de Empleado"

            Me.cbempleado.EditValue = detIngreso.Empleado
            Me.cbempleado.Enabled = False

            Me.txtMonedaPago.Text = VB.SysContab.MonedaDB.GetDetails(detEmpleados.Moneda).Descripcion
            Me.cbMoneda.SelectedValue = detIngreso.Moneda

            Me.txting_Codigo.Text = detIngreso.Codigo
            Me.cbTIngreso.EditValue = detIngreso.TipoIngreso
            Me.dtping_FechaInicio.Value = detIngreso.FInicio
            Me.txting_Fecha.Text = detIngreso.Fecha
            Me.txtptm_monto.Text = detIngreso.Monto
            Me.txtValor.Text = detIngreso.Valor
            Me.txtDiasHoras.Text = detIngreso.DiaHora
            Me.chkCancelado.Checked = detIngreso.Cancelado
            Me.chkCancelado.Enabled = True
            Me.chkNREgular.Checked = detIngreso.NRegular
            Me.meComentarios.EditValue = detIngreso.Comentarios

            'buscar el detalle de cuotas en nomina
            Me.dgDetalleIngreso.DataSource = VB.SysContab.DetalleIngresoDB.GetList(Me.txting_Codigo.Text).Tables("DetalleIngreso")

            If Me.VDetalleIngreso.DataRowCount <> 0 Then
                If detIngreso.Cancelado And detIngreso.Unico Then
                    Me.chkCancelado.Enabled = False
                Else
                    Me.chkCancelado.Enabled = True
                End If
            End If
            Tipo = VB.SysContab.TipoIngresoDB.GetDetails(Me.cbTIngreso.EditValue).Tipo
            Doble = VB.SysContab.TipoIngresoDB.GetDetails(Me.cbTIngreso.EditValue).Doble
            Select Case Tipo
                Case 3
                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'Me.lblDiasHoras.Visible = False
                    'Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False

                    Me.txtptm_monto.Enabled = True
                    Me.txtDiasHoras.Enabled = False

                Case 5, 6, 7

                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'Me.lblDiasHoras.Visible = True
                    'Me.lblValor.Visible = True
                    Me.txtDiasHoras.Visible = True
                    Me.txtValor.Visible = True

                    Me.txtptm_monto.Enabled = False
                    Me.txtDiasHoras.Enabled = True

                Case Else
                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'Me.lblDiasHoras.Visible = False
                    'Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False

                    Me.txtptm_monto.Enabled = True
                    Me.txtDiasHoras.Enabled = False

            End Select
        Else
            Me.Text = "Agregar Ingreso de Empleado"

            Me.cbempleado.EditValue = ""
            Me.cbempleado.Enabled = True
            Me.txting_Codigo.Text = VB.SysContab.IngresoDB.GetListCodigoNvo()
            Me.chkCancelado.Checked = False
            Me.chkCancelado.Enabled = False

            Me.dtping_FechaInicio.Value = Now.Date
            Me.txting_Fecha.Text = Now.Date
            Me.txtptm_monto.Text = "0.00"
            Me.txtValor.Text = "0.00"
            Me.txtDiasHoras.Text = "0.00"


        End If
        Me.lcdetalle.Enabled = Not Me.chkCancelado.Checked
        'Me.gbDetalle.Enabled = Not Me.chkCancelado.Checked

        Cargado = True
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.cbempleado.EditValue = "" Or Me.cbempleado.EditValue Is DBNull.Value Then
            MsgBox("Seleccione el empleado por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.txtptm_monto.Text = "" Or Me.txtptm_monto.Text = "0" Then
            MsgBox("Digite el monto por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbTIngreso.EditValue = "" Or Me.cbTIngreso.EditValue Is DBNull.Value Then
            MsgBox("Seleccione el tipo de Ingreso por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        'Me.VTIngresos.GetFocusedRowCellValue("Unico"), _
        If Nuevo = "SI" Then
            VB.SysContab.IngresoDB.Additem(Me.txting_Codigo.Text, Me.cbempleado.EditValue, Me.txting_Fecha.Text, Me.dtping_FechaInicio.Value, _
                Me.txtptm_monto.Text, Me.cbTIngreso.EditValue, Me.chkCancelado.Checked, Me.cbMoneda.SelectedValue, _
                Me.cbTIngreso.GetColumnValue("Unico"), _
                Me.chkNREgular.Checked, False, Me.txtDiasHoras.Text, Me.txtValor.Text, Me.meComentarios.EditValue)
        Else
            VB.SysContab.IngresoDB.Update(Me.txting_Codigo.Text, Me.cbempleado.EditValue, Me.txting_Fecha.Text, Me.dtping_FechaInicio.Value, _
                Me.txtptm_monto.Text, Me.cbTIngreso.EditValue, Me.chkCancelado.Checked, Me.cbMoneda.SelectedValue, _
                Me.cbTIngreso.GetColumnValue("Unico"), _
                Me.chkNREgular.Checked, False, Me.txtDiasHoras.Text, Me.txtValor.Text, Me.meComentarios.EditValue)
        End If
        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.OkOnly)
        Me.Close()

    End Sub



    Private Sub cbempleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbempleado.Validating
        If Not Me.cbempleado.EditValue = "" Then
            detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(Me.cbempleado.EditValue)
            Me.txtMonedaPago.Text = VB.SysContab.MonedaDB.GetDetails(detEmpleados.Moneda).Descripcion
        End If
    End Sub
    Private Sub cbTIngreso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTIngreso.EditValueChanged
        If Cargado Then
            Tipo = Me.cbTIngreso.GetColumnValue("Tipo") 'Me.VTIngresos.GetRow(Me.cbTIngreso.Properties.GetIndexByKeyValue(Me.cbTIngreso.EditValue))("Tipo")
            Doble = Me.cbTIngreso.GetColumnValue("Doble") 'Me.VTIngresos.GetRow(Me.cbTIngreso.Properties.GetIndexByKeyValue(Me.cbTIngreso.EditValue))("Doble")
            Select Case Tipo
                Case 3
                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'Me.lblDiasHoras.Visible = False
                    'Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False
                    Me.txtDiasHoras.Text = "0.00"
                    Me.txtValor.Text = "0.00"
                    Me.txtptm_monto.Text = "0.00"
                    Me.txtptm_monto.Enabled = True

                Case 5, 6, 7
                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'Me.lblDiasHoras.Visible = True
                    'Me.lblValor.Visible = True
                    Me.txtDiasHoras.Visible = True
                    Me.txtValor.Visible = True
                    Me.txtptm_monto.Enabled = False

                    Dim TC As Double
                    TC = VB.SysContab.Tasa_CambioDB.TasaCambioDia(Me.dtping_FechaInicio.Value.Day, _
                        Me.dtping_FechaInicio.Value.Month, _
                        Me.dtping_FechaInicio.Value.Year, _
                        Me.cbMoneda.SelectedValue, _
                        detEmpleados.Moneda)

                    'If Me.txtDiasHoras.Text <> "0.00" And IsNumeric(Me.txtDiasHoras.Text) And IsNumeric(Me.txtValor.Text) Then
                    If Tipo = 5 Then
                        Me.txtValor.Text = detEmpleados.SalarioxDia
                    ElseIf Tipo = 6 Then
                        Me.txtValor.Text = detEmpleados.SalarioxHora
                    ElseIf Tipo = 7 Then
                        Me.txtValor.Text = Me.cbTIngreso.GetColumnValue("Factor") ' Me.VTIngresos.GetRow(Me.cbTIngreso.Properties.GetIndexByKeyValue(Me.cbTIngreso.EditValue))("Factor")
                    End If
                    Me.txtValor.Text = Math.Round(CDbl(Me.txtValor.Text) * TC * IIf(Doble = True, 2, 1), 2)
                    'End If
                    Me.txtptm_monto.Text = Math.Round(CDbl(Me.txtDiasHoras.Text) * CDbl(Me.txtValor.Text), 2)


                Case Else
                    Me.lcDias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Me.lcValor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'Me.lblDiasHoras.Visible = False
                    'Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False
                    Me.txtDiasHoras.Text = "0.0"
                    Me.txtValor.Text = "0.0"
                    Me.txtptm_monto.Text = "0.00"
                    Me.txtptm_monto.Enabled = True

            End Select
        End If

    End Sub

    Private Sub txtDiasHoras_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiasHoras.TextChanged
        If Cargado Then
            If Me.txtDiasHoras.Text <> "0.00" And IsNumeric(Me.txtDiasHoras.Text) And IsNumeric(Me.txtValor.Text) Then
                Me.txtptm_monto.Text = Math.Round(CDbl(Me.txtDiasHoras.Text) * CDbl(Me.txtValor.Text), 2)
            End If
        End If
    End Sub

    Private Sub cbMoneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMoneda.SelectedValueChanged
        If Cargado Then
            Dim TC As Double
            TC = VB.SysContab.Tasa_CambioDB.TasaCambioDia(Me.dtping_FechaInicio.Value.Day, _
                Me.dtping_FechaInicio.Value.Month, _
                Me.dtping_FechaInicio.Value.Year, _
                Me.cbMoneda.SelectedValue, _
                detEmpleados.Moneda)

            If Me.txtDiasHoras.Text <> "0.00" And IsNumeric(Me.txtDiasHoras.Text) And IsNumeric(Me.txtValor.Text) Then
                If Tipo = 5 Then
                    Me.txtValor.Text = detEmpleados.SalarioxDia
                ElseIf Tipo = 6 Then
                    Me.txtValor.Text = detEmpleados.SalarioxHora
                ElseIf Tipo = 7 Then
                    Me.txtValor.Text = Me.cbTIngreso.GetColumnValue("Tipo") 'Me.VTIngresos.GetRow(Me.cbTIngreso.Properties.GetIndexByKeyValue(Me.cbTIngreso.EditValue))("Tipo")
                Else
                    Me.txtValor.Text = "0.00"
                End If
                Me.txtValor.Text = Math.Round(CDbl(Me.txtValor.Text) * TC * IIf(Doble = True, 2, 1), 2)
            End If
            Me.txtptm_monto.Text = Math.Round(CDbl(Me.txtDiasHoras.Text) * CDbl(Me.txtValor.Text), 2)
        End If
    End Sub
  
End Class
