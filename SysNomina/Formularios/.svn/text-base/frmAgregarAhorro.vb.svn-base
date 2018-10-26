Imports System.IO

Public Class frmAgregarAhorro
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarAhorro = Nothing

    Public Shared Function Instance() As frmAgregarAhorro
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarAhorro()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#Region "Variables"
    Dim ods As DataTable
    Dim inicio, final As Date
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Liquidado] = False and [Tiene Ahorro] = False and FechaFin is null")
    Dim Iniciado As Boolean = False
    Dim detEmpleados As New VB.SysContab.EmpleadosDetails()
#End Region

#Region "Calaches"
    Friend WithEvents dtptah_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbForma_pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbempleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents VistaEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Liquidado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TieneAhorro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents dgDetalleDeduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDetalleDeduccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbTransferencia As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTrasladoEmpresa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelarTransferencia As System.Windows.Forms.Button
    Friend WithEvents cmdGuardarTransferencia As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTrasladoEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents cmdEmailAhorro As System.Windows.Forms.Button
    Friend WithEvents btnECAhorro As System.Windows.Forms.Button
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
#End Region



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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaPago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTAhorro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttah_cuota As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cbMonedaAhorro As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmpleado_D As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa_D As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbDisponibleRetiros As System.Windows.Forms.GroupBox
    Friend WithEvents btnRetiros As System.Windows.Forms.Button
    Friend WithEvents gbRetiros As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardarRetiro As System.Windows.Forms.Button
    Friend WithEvents cmdCancelarRetiro As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRetiroEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtRetiroEmpleado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbempleado = New DevExpress.XtraEditors.GridLookUpEdit
        Me.VistaEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Liquidado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TieneAhorro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbMonedaPago = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.cbTAhorro = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTransferencia = New System.Windows.Forms.Button
        Me.btnRetiros = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtptah_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbDisponibleRetiros = New System.Windows.Forms.GroupBox
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmpresa_D = New System.Windows.Forms.TextBox
        Me.txtEmpleado_D = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbMonedaAhorro = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttah_cuota = New System.Windows.Forms.TextBox
        Me.gbRetiros = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbForma_pago = New System.Windows.Forms.ComboBox
        Me.dtpFechaRetiro = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdCancelarRetiro = New System.Windows.Forms.Button
        Me.cmdGuardarRetiro = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRetiroEmpresa = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRetiroEmpleado = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.gbTransferencia = New System.Windows.Forms.GroupBox
        Me.dtpTrasladoEmpresa = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdCancelarTransferencia = New System.Windows.Forms.Button
        Me.cmdGuardarTransferencia = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTrasladoEmpresa = New System.Windows.Forms.TextBox
        Me.dgDetalleDeduccion = New DevExpress.XtraGrid.GridControl
        Me.VDetalleDeduccion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdEmailAhorro = New System.Windows.Forms.Button
        Me.btnECAhorro = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDisponibleRetiros.SuspendLayout()
        CType(Me.txtFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRetiros.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbTransferencia.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgDetalleDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDetalleDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 200)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 24)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 24)
        Me.cmdAceptar.TabIndex = 30
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbempleado)
        Me.GroupBox3.Controls.Add(Me.cbMonedaPago)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 72)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS GENERALES DEL EMPLEADO"
        '
        'cbempleado
        '
        Me.cbempleado.EditValue = ""
        Me.cbempleado.Location = New System.Drawing.Point(135, 20)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbempleado.Properties.NullText = ""
        Me.cbempleado.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cbempleado.Properties.PopupSizeable = False
        Me.cbempleado.Properties.ShowFooter = False
        Me.cbempleado.Properties.View = Me.VistaEmpleado
        Me.cbempleado.Size = New System.Drawing.Size(415, 20)
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
        Me.VistaEmpleado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Nombre, Me.Liquidado, Me.TieneAhorro})
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
        'Liquidado
        '
        Me.Liquidado.Caption = "Liquidado"
        Me.Liquidado.FieldName = "Liquidado"
        Me.Liquidado.Name = "Liquidado"
        '
        'TieneAhorro
        '
        Me.TieneAhorro.Caption = "Tiene Ahorro"
        Me.TieneAhorro.FieldName = "Tiene Ahorro"
        Me.TieneAhorro.Name = "TieneAhorro"
        '
        'cbMonedaPago
        '
        Me.cbMonedaPago.Enabled = False
        Me.cbMonedaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaPago.ItemHeight = 15
        Me.cbMonedaPago.Location = New System.Drawing.Point(136, 43)
        Me.cbMonedaPago.Name = "cbMonedaPago"
        Me.cbMonedaPago.Size = New System.Drawing.Size(414, 23)
        Me.cbMonedaPago.TabIndex = 21
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(8, 43)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(136, 24)
        Me.Label43.TabIndex = 163
        Me.Label43.Text = "Moneda de Pago:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(272, 440)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(336, 24)
        Me.Label21.TabIndex = 77
        Me.Label21.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(24, 440)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 24)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Cuenta Contable:"
        Me.Label16.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(160, 440)
        Me.TextBox12.MaxLength = 16
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(88, 20)
        Me.TextBox12.TabIndex = 72
        Me.TextBox12.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Código:"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(8, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(136, 24)
        Me.Label33.TabIndex = 146
        Me.Label33.Text = "Tipo de Ahorro:"
        '
        'cbTAhorro
        '
        Me.cbTAhorro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTAhorro.Location = New System.Drawing.Point(136, 16)
        Me.cbTAhorro.Name = "cbTAhorro"
        Me.cbTAhorro.Size = New System.Drawing.Size(264, 23)
        Me.cbTAhorro.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdEmailAhorro)
        Me.GroupBox2.Controls.Add(Me.btnECAhorro)
        Me.GroupBox2.Controls.Add(Me.btnTransferencia)
        Me.GroupBox2.Controls.Add(Me.btnRetiros)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(868, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 755)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btnTransferencia
        '
        Me.btnTransferencia.Enabled = False
        Me.btnTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTransferencia.ForeColor = System.Drawing.Color.Black
        Me.btnTransferencia.Location = New System.Drawing.Point(8, 110)
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.Size = New System.Drawing.Size(96, 24)
        Me.btnTransferencia.TabIndex = 35
        Me.btnTransferencia.Text = "Transf. Empresa"
        '
        'btnRetiros
        '
        Me.btnRetiros.Enabled = False
        Me.btnRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRetiros.ForeColor = System.Drawing.Color.Black
        Me.btnRetiros.Location = New System.Drawing.Point(8, 80)
        Me.btnRetiros.Name = "btnRetiros"
        Me.btnRetiros.Size = New System.Drawing.Size(96, 24)
        Me.btnRetiros.TabIndex = 34
        Me.btnRetiros.Text = "Realizar Retiro"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdImprimir.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Location = New System.Drawing.Point(8, 48)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 24)
        Me.cmdImprimir.TabIndex = 33
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtptah_fecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.gbDisponibleRetiros)
        Me.GroupBox1.Controls.Add(Me.cbMonedaAhorro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txttah_cuota)
        Me.GroupBox1.Controls.Add(Me.cbTAhorro)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 120)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        '
        'dtptah_fecha
        '
        Me.dtptah_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptah_fecha.Location = New System.Drawing.Point(547, 38)
        Me.dtptah_fecha.Name = "dtptah_fecha"
        Me.dtptah_fecha.Size = New System.Drawing.Size(141, 20)
        Me.dtptah_fecha.TabIndex = 168
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(406, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 24)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Ahorrar desde:"
        '
        'gbDisponibleRetiros
        '
        Me.gbDisponibleRetiros.Controls.Add(Me.txtFecha)
        Me.gbDisponibleRetiros.Controls.Add(Me.Label7)
        Me.gbDisponibleRetiros.Controls.Add(Me.Label6)
        Me.gbDisponibleRetiros.Controls.Add(Me.txtEmpresa_D)
        Me.gbDisponibleRetiros.Controls.Add(Me.txtEmpleado_D)
        Me.gbDisponibleRetiros.Controls.Add(Me.Label5)
        Me.gbDisponibleRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gbDisponibleRetiros.Location = New System.Drawing.Point(8, 64)
        Me.gbDisponibleRetiros.Name = "gbDisponibleRetiros"
        Me.gbDisponibleRetiros.Size = New System.Drawing.Size(824, 48)
        Me.gbDisponibleRetiros.TabIndex = 166
        Me.gbDisponibleRetiros.TabStop = False
        Me.gbDisponibleRetiros.Text = "Disponible Para Retiros"
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Location = New System.Drawing.Point(631, 15)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFecha.Size = New System.Drawing.Size(135, 20)
        Me.txtFecha.TabIndex = 156
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(536, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "A partir de:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(248, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Aporte Empresa:"
        '
        'txtEmpresa_D
        '
        Me.txtEmpresa_D.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa_D.Enabled = False
        Me.txtEmpresa_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa_D.Location = New System.Drawing.Point(379, 16)
        Me.txtEmpresa_D.MaxLength = 8
        Me.txtEmpresa_D.Name = "txtEmpresa_D"
        Me.txtEmpresa_D.Size = New System.Drawing.Size(88, 20)
        Me.txtEmpresa_D.TabIndex = 151
        '
        'txtEmpleado_D
        '
        Me.txtEmpleado_D.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpleado_D.Enabled = False
        Me.txtEmpleado_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado_D.Location = New System.Drawing.Point(136, 16)
        Me.txtEmpleado_D.MaxLength = 8
        Me.txtEmpleado_D.Name = "txtEmpleado_D"
        Me.txtEmpleado_D.Size = New System.Drawing.Size(88, 20)
        Me.txtEmpleado_D.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Ahorro Empleado:"
        '
        'cbMonedaAhorro
        '
        Me.cbMonedaAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaAhorro.ItemHeight = 15
        Me.cbMonedaAhorro.Location = New System.Drawing.Point(547, 13)
        Me.cbMonedaAhorro.Name = "cbMonedaAhorro"
        Me.cbMonedaAhorro.Size = New System.Drawing.Size(141, 23)
        Me.cbMonedaAhorro.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(406, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Moneda de Ahorro:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(723, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Activo:"
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(800, 10)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(24, 24)
        Me.chkActivo.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Cuota:"
        '
        'txttah_cuota
        '
        Me.txttah_cuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttah_cuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttah_cuota.Location = New System.Drawing.Point(136, 39)
        Me.txttah_cuota.MaxLength = 8
        Me.txttah_cuota.Name = "txttah_cuota"
        Me.txttah_cuota.Size = New System.Drawing.Size(88, 20)
        Me.txttah_cuota.TabIndex = 147
        '
        'gbRetiros
        '
        Me.gbRetiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRetiros.Controls.Add(Me.Label13)
        Me.gbRetiros.Controls.Add(Me.cbForma_pago)
        Me.gbRetiros.Controls.Add(Me.dtpFechaRetiro)
        Me.gbRetiros.Controls.Add(Me.Label12)
        Me.gbRetiros.Controls.Add(Me.GroupBox4)
        Me.gbRetiros.Controls.Add(Me.Label10)
        Me.gbRetiros.Controls.Add(Me.txtRetiroEmpresa)
        Me.gbRetiros.Controls.Add(Me.Label11)
        Me.gbRetiros.Controls.Add(Me.txtRetiroEmpleado)
        Me.gbRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gbRetiros.Location = New System.Drawing.Point(3, 207)
        Me.gbRetiros.Name = "gbRetiros"
        Me.gbRetiros.Size = New System.Drawing.Size(840, 102)
        Me.gbRetiros.TabIndex = 163
        Me.gbRetiros.TabStop = False
        Me.gbRetiros.Text = "Retiros:"
        Me.gbRetiros.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(352, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Forma Pago:"
        '
        'cbForma_pago
        '
        Me.cbForma_pago.FormattingEnabled = True
        Me.cbForma_pago.Items.AddRange(New Object() {"Nomina", "Cheque"})
        Me.cbForma_pago.Location = New System.Drawing.Point(460, 40)
        Me.cbForma_pago.Name = "cbForma_pago"
        Me.cbForma_pago.Size = New System.Drawing.Size(141, 24)
        Me.cbForma_pago.TabIndex = 171
        '
        'dtpFechaRetiro
        '
        Me.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRetiro.Location = New System.Drawing.Point(460, 16)
        Me.dtpFechaRetiro.Name = "dtpFechaRetiro"
        Me.dtpFechaRetiro.Size = New System.Drawing.Size(141, 22)
        Me.dtpFechaRetiro.TabIndex = 170
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(355, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Fecha:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdCancelarRetiro)
        Me.GroupBox4.Controls.Add(Me.cmdGuardarRetiro)
        Me.GroupBox4.Location = New System.Drawing.Point(704, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(128, 84)
        Me.GroupBox4.TabIndex = 161
        Me.GroupBox4.TabStop = False
        '
        'cmdCancelarRetiro
        '
        Me.cmdCancelarRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelarRetiro.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelarRetiro.Location = New System.Drawing.Point(8, 48)
        Me.cmdCancelarRetiro.Name = "cmdCancelarRetiro"
        Me.cmdCancelarRetiro.Size = New System.Drawing.Size(112, 24)
        Me.cmdCancelarRetiro.TabIndex = 160
        Me.cmdCancelarRetiro.Text = "Cancelar"
        '
        'cmdGuardarRetiro
        '
        Me.cmdGuardarRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardarRetiro.ForeColor = System.Drawing.Color.Black
        Me.cmdGuardarRetiro.Location = New System.Drawing.Point(8, 16)
        Me.cmdGuardarRetiro.Name = "cmdGuardarRetiro"
        Me.cmdGuardarRetiro.Size = New System.Drawing.Size(112, 24)
        Me.cmdGuardarRetiro.TabIndex = 159
        Me.cmdGuardarRetiro.Text = "Guardar"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 24)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Retirar Fondo Empresa:"
        '
        'txtRetiroEmpresa
        '
        Me.txtRetiroEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRetiroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetiroEmpresa.Location = New System.Drawing.Point(216, 42)
        Me.txtRetiroEmpresa.MaxLength = 8
        Me.txtRetiroEmpresa.Name = "txtRetiroEmpresa"
        Me.txtRetiroEmpresa.Size = New System.Drawing.Size(88, 20)
        Me.txtRetiroEmpresa.TabIndex = 157
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 24)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Retirar Fondo Empleado:"
        '
        'txtRetiroEmpleado
        '
        Me.txtRetiroEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRetiroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetiroEmpleado.Location = New System.Drawing.Point(216, 18)
        Me.txtRetiroEmpleado.MaxLength = 8
        Me.txtRetiroEmpleado.Name = "txtRetiroEmpleado"
        Me.txtRetiroEmpleado.Size = New System.Drawing.Size(88, 20)
        Me.txtRetiroEmpleado.TabIndex = 155
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.gbRetiros)
        Me.FlowLayoutPanel1.Controls.Add(Me.gbTransferencia)
        Me.FlowLayoutPanel1.Controls.Add(Me.dgDetalleDeduccion)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(856, 755)
        Me.FlowLayoutPanel1.TabIndex = 165
        '
        'gbTransferencia
        '
        Me.gbTransferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTransferencia.Controls.Add(Me.dtpTrasladoEmpresa)
        Me.gbTransferencia.Controls.Add(Me.Label14)
        Me.gbTransferencia.Controls.Add(Me.GroupBox6)
        Me.gbTransferencia.Controls.Add(Me.Label15)
        Me.gbTransferencia.Controls.Add(Me.txtTrasladoEmpresa)
        Me.gbTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gbTransferencia.Location = New System.Drawing.Point(3, 315)
        Me.gbTransferencia.Name = "gbTransferencia"
        Me.gbTransferencia.Size = New System.Drawing.Size(840, 102)
        Me.gbTransferencia.TabIndex = 165
        Me.gbTransferencia.TabStop = False
        Me.gbTransferencia.Text = "Transferencia de Empresa a Empleado"
        Me.gbTransferencia.Visible = False
        '
        'dtpTrasladoEmpresa
        '
        Me.dtpTrasladoEmpresa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTrasladoEmpresa.Location = New System.Drawing.Point(460, 16)
        Me.dtpTrasladoEmpresa.Name = "dtpTrasladoEmpresa"
        Me.dtpTrasladoEmpresa.Size = New System.Drawing.Size(141, 22)
        Me.dtpTrasladoEmpresa.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(355, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 20)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Fecha:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdCancelarTransferencia)
        Me.GroupBox6.Controls.Add(Me.cmdGuardarTransferencia)
        Me.GroupBox6.Location = New System.Drawing.Point(704, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(128, 84)
        Me.GroupBox6.TabIndex = 161
        Me.GroupBox6.TabStop = False
        '
        'cmdCancelarTransferencia
        '
        Me.cmdCancelarTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelarTransferencia.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelarTransferencia.Location = New System.Drawing.Point(8, 48)
        Me.cmdCancelarTransferencia.Name = "cmdCancelarTransferencia"
        Me.cmdCancelarTransferencia.Size = New System.Drawing.Size(112, 24)
        Me.cmdCancelarTransferencia.TabIndex = 160
        Me.cmdCancelarTransferencia.Text = "Cancelar"
        '
        'cmdGuardarTransferencia
        '
        Me.cmdGuardarTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardarTransferencia.ForeColor = System.Drawing.Color.Black
        Me.cmdGuardarTransferencia.Location = New System.Drawing.Point(8, 16)
        Me.cmdGuardarTransferencia.Name = "cmdGuardarTransferencia"
        Me.cmdGuardarTransferencia.Size = New System.Drawing.Size(112, 24)
        Me.cmdGuardarTransferencia.TabIndex = 159
        Me.cmdGuardarTransferencia.Text = "Guardar"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 24)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "Retirar Fondo Empresa:"
        '
        'txtTrasladoEmpresa
        '
        Me.txtTrasladoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTrasladoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrasladoEmpresa.Location = New System.Drawing.Point(216, 24)
        Me.txtTrasladoEmpresa.MaxLength = 8
        Me.txtTrasladoEmpresa.Name = "txtTrasladoEmpresa"
        Me.txtTrasladoEmpresa.Size = New System.Drawing.Size(88, 20)
        Me.txtTrasladoEmpresa.TabIndex = 157
        '
        'dgDetalleDeduccion
        '
        Me.dgDetalleDeduccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalleDeduccion.EmbeddedNavigator.Name = ""
        Me.dgDetalleDeduccion.Location = New System.Drawing.Point(3, 423)
        Me.dgDetalleDeduccion.MainView = Me.VDetalleDeduccion
        Me.dgDetalleDeduccion.Name = "dgDetalleDeduccion"
        Me.dgDetalleDeduccion.Size = New System.Drawing.Size(840, 317)
        Me.dgDetalleDeduccion.TabIndex = 165
        Me.dgDetalleDeduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDetalleDeduccion})
        '
        'VDetalleDeduccion
        '
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.Empty.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.EvenRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.EvenRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FixedLine.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.FooterPanel.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupButton.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.GroupButton.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.GroupFooter.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.GroupRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.GroupRow.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.GroupRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VDetalleDeduccion.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.HorzLine.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.OddRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.OddRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.VDetalleDeduccion.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.Preview.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.Preview.Options.UseFont = True
        Me.VDetalleDeduccion.Appearance.Preview.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.VDetalleDeduccion.Appearance.Row.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.Row.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.SelectedRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.SelectedRow.Options.UseForeColor = True
        Me.VDetalleDeduccion.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.VDetalleDeduccion.Appearance.TopNewRow.Options.UseBackColor = True
        Me.VDetalleDeduccion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VDetalleDeduccion.Appearance.VertLine.Options.UseBackColor = True
        Me.VDetalleDeduccion.GridControl = Me.dgDetalleDeduccion
        Me.VDetalleDeduccion.Name = "VDetalleDeduccion"
        Me.VDetalleDeduccion.OptionsBehavior.Editable = False
        Me.VDetalleDeduccion.OptionsView.EnableAppearanceEvenRow = True
        Me.VDetalleDeduccion.OptionsView.EnableAppearanceOddRow = True
        Me.VDetalleDeduccion.OptionsView.ShowAutoFilterRow = True
        Me.VDetalleDeduccion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDetalleDeduccion.OptionsView.ShowFooter = True
        Me.VDetalleDeduccion.OptionsView.ShowGroupPanel = False
        '
        'cmdEmailAhorro
        '
        Me.cmdEmailAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailAhorro.ForeColor = System.Drawing.Color.Black
        Me.cmdEmailAhorro.Location = New System.Drawing.Point(8, 140)
        Me.cmdEmailAhorro.Name = "cmdEmailAhorro"
        Me.cmdEmailAhorro.Size = New System.Drawing.Size(96, 24)
        Me.cmdEmailAhorro.TabIndex = 184
        Me.cmdEmailAhorro.Text = "Enviar E Cuenta"
        '
        'btnECAhorro
        '
        Me.btnECAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnECAhorro.ForeColor = System.Drawing.Color.Black
        Me.btnECAhorro.Location = New System.Drawing.Point(8, 170)
        Me.btnECAhorro.Name = "btnECAhorro"
        Me.btnECAhorro.Size = New System.Drawing.Size(96, 24)
        Me.btnECAhorro.TabIndex = 183
        Me.btnECAhorro.Text = "Estado Cuenta"
        '
        'frmAgregarAhorro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 799)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgregarAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDisponibleRetiros.ResumeLayout(False)
        Me.gbDisponibleRetiros.PerformLayout()
        CType(Me.txtFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRetiros.ResumeLayout(False)
        Me.gbRetiros.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gbTransferencia.ResumeLayout(False)
        Me.gbTransferencia.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgDetalleDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDetalleDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarAhorro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim detahorro As New VB.SysContab.Empleado_AhorroDetailDB()

        Me.cbempleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.VistaEmpleado.Columns("Codigo").Width = 100
        Me.VistaEmpleado.Columns("Nombre").Width = 250
        Me.cbempleado.Properties.DisplayMember = "Nombre"
        Me.cbempleado.Properties.ValueMember = "Codigo"


        Me.cbTAhorro.DataSource = VB.SysContab.TipoAhorroDB.GetListTipoAhorro().Tables("TipoAhorro")
        Me.cbTAhorro.ValueMember = "Codigo"
        Me.cbTAhorro.DisplayMember = "Descripcion"

        cbMonedaPago.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMonedaPago.ValueMember = "Codigo"
        cbMonedaPago.DisplayMember = "Descripcion"

        cbMonedaAhorro.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMonedaAhorro.ValueMember = "Codigo"
        cbMonedaAhorro.DisplayMember = "Descripcion"

        VB.SysContab.PeriodoNominaDB.GetListFechaMinima_Nominas(inicio, final)

        Me.txtFecha.EditValue = inicio

        If Nuevo = "NO" Then

            Me.VistaEmpleado.Columns("Liquidado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")

            detahorro = VB.SysContab.Empleado_AhorroDB.GetDetailsEmpleado_Ahorro(Registro.Substring(0, 8))
            detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(detahorro.Empleado)

            Me.Text = "Editar Ahorro de Empleado"
            Me.cbempleado.EditValue = detahorro.Empleado
            Me.cbempleado.Enabled = False
            Me.cbMonedaPago.SelectedValue = detEmpleados.Moneda
            Me.cbMonedaAhorro.SelectedValue = detahorro.Moneda
            Me.dtptah_fecha.Value = detahorro.Desde
            Me.dtptah_fecha.Enabled = False
            Me.cbTAhorro.SelectedValue = detahorro.TipoAhorro
            Me.txttah_cuota.Text = detahorro.Cuota
            Me.chkActivo.Checked = detahorro.Activo

            Cargar()

            Me.cmdEmailAhorro.Enabled = True
            Me.btnECAhorro.Enabled = True
            Me.cmdImprimir.Enabled = True
        Else
            Me.VistaEmpleado.Columns("Liquidado").FilterInfo = Filtro

            Me.Text = "Agregar Ahorro de Empleado"
            Me.cbempleado.Enabled = True
            Me.txttah_cuota.Text = "0.00"
            Me.dtptah_fecha.Value = Now
            Me.dtptah_fecha.Enabled = True
            Me.cmdEmailAhorro.Enabled = True
            Me.btnECAhorro.Enabled = True
            Me.cmdImprimir.Enabled = False

        End If
        Iniciado = True
        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.txttah_cuota.Text <= 0.0 Then
            MsgBox("La cuota de ahorro no puede ser menor o igual a cero", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If
        If Nuevo = "SI" Then
            VB.SysContab.Empleado_AhorroDB.Add(Me.cbempleado.EditValue, Me.cbTAhorro.SelectedValue, Me.txttah_cuota.Text, Me.dtptah_fecha.Value, Me.cbMonedaAhorro.SelectedValue)
        Else
            VB.SysContab.Empleado_AhorroDB.Update(Me.cbempleado.EditValue, Me.cbTAhorro.SelectedValue, Me.txttah_cuota.Text, _
                Me.chkActivo.Checked, Me.dtptah_fecha.Value, Me.cbMonedaAhorro.SelectedValue)
        End If
        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.OkOnly)
        Me.Close()

    End Sub

    Private Sub cbTahorro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTAhorro.SelectedIndexChanged
        If IsNumeric(Me.cbTAhorro.SelectedValue) Then
            If Microsoft.VisualBasic.Left(Me.cbTAhorro.SelectedText, 1) = "C" Then
                Me.txttah_cuota.MaxLength = 8
            Else
                Me.txttah_cuota.MaxLength = 4
            End If
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim Reporte As New ReporteAhorro()
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\ReporteAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\ReporteAhorro.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\ReporteAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim Lds As DataSet

        Lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        Lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)

        VB.SysContab.Empleado_AhorroDB.ImprimirEmpleado_Ahorro(Me.cbempleado.EditValue).WriteXml(Application.StartupPath & "\Ahorro.xml", XmlWriteMode.WriteSchema)
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
        Reporte.Database.Tables("ReporteAhorro").Location = Application.StartupPath & "\Ahorro.xml"

        fReportes.crvReportes.ReportSource = Reporte
        fReportes.ShowDialog()
        Lds.Dispose()
        Reporte.Dispose()

    End Sub

    Private Sub btnRetiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiros.Click

        If QuincenaTrabajo Is Nothing Or QuincenaTrabajo = "" Then
            MsgBox("Debe seleccionar primero un Periodo de Trabajo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Me.txtRetiroEmpleado.Text = 0.0
        Me.dtpFechaRetiro.Value = Today
        Me.cbForma_pago.SelectedValue = "NOMINA"
        Me.txtRetiroEmpresa.Text = 0.0
        Me.gbRetiros.Visible = True
        Me.btnTransferencia.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.cmdImprimir.Enabled = False
        Me.cmdCancelar.Enabled = False
    End Sub

    Private Sub cmdCancelarRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarRetiro.Click
        Me.gbRetiros.Visible = False
        Me.gbTransferencia.Visible = False
        Me.cmdAceptar.Enabled = True
        Me.cmdImprimir.Enabled = True
        Me.cmdCancelar.Enabled = True
        Me.Cargar()
    End Sub

    Private Sub cmdGuardarRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarRetiro.Click

        If IsNumeric(Me.txtRetiroEmpleado.Text) Then
            If CDbl(Me.txtRetiroEmpleado.Text) < 0 Then
                MsgBox("El retiro del monto de Empleado no puede ser un valor negativo", MsgBoxStyle.Critical, "SysNomina")
                Exit Sub
            End If
        End If

        If IsNumeric(Me.txtRetiroEmpresa.Text) Then
            If CDbl(Me.txtRetiroEmpresa.Text) < 0 Then
                MsgBox("El retiro del monto de Empresa no puede ser un valor negativo", MsgBoxStyle.Critical, "SysNomina")
                Exit Sub
            End If
        End If

        If Me.cbForma_pago.SelectedItem Is Nothing Then
            MsgBox("Debe seleccionar una forma de pago para el retiro", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        If VB.SysContab.Empleado_AhorroDB.Retiro(Me.cbempleado.EditValue, Me.txtRetiroEmpleado.Text, Me.txtRetiroEmpresa.Text, _
            QuincenaTrabajo.Substring(1, 8), _
            QuincenaTrabajo.Substring(0, 1), _
            ods.Rows(0)("tdi_empleado"), ods.Rows(0)("tdi_empresa"), _
            ods.Rows(0)("mon_codigo"), Me.dtpFechaRetiro.Value, Me.cbForma_pago.SelectedItem.ToString.Substring(0, 1)) = False Then
            MsgBox("No se pudo agregar el retiro de ahorro del empleado", MsgBoxStyle.Critical)

        End If
        Me.gbRetiros.Visible = False
        Me.cmdAceptar.Enabled = True
        Me.cmdImprimir.Enabled = True
        Me.cmdCancelar.Enabled = True
        Cargar()
    End Sub
    Private Sub Cargar()
        'buscar el detalle de cuotas deducidas en nomina por ahorro
        Me.dgDetalleDeduccion.DataSource = VB.SysContab.Empleado_AhorroDB.GetListEmpleado_Ahorro(Me.cbempleado.EditValue)

        ods = VB.SysContab.Empleado_AhorroDB.GetListAhorro_Disponible(Me.cbempleado.EditValue)
        If Not (ods Is Nothing) And ods.Rows.Count > 0 Then
            Me.txtEmpleado_D.Text = Math.Round(ods.Rows(0)("Empleado"), 2).ToString
            Me.txtEmpresa_D.Text = Math.Round(ods.Rows(0)("Empresa"), 2).ToString
            Me.txtFecha.EditValue = DateAdd(DateInterval.Year, 1, ods.Rows(0)("FechaInicio"))
            If CDate(Me.txtFecha.EditValue) <= Date.Today Then
                Me.btnRetiros.Enabled = True
                Me.btnTransferencia.Enabled = True
            End If
        Else
            Me.txtEmpleado_D.Text = 0.0
            Me.txtEmpresa_D.Text = 0.0
            Me.txtFecha.EditValue = Today.Date

        End If
    End Sub

    Private Sub cbempleado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbempleado.EditValueChanged
        If Iniciado Then
            Dim detEmpleado As New VB.SysContab.EmpleadosDetails()
            detEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Me.cbempleado.EditValue)
            If detEmpleado.Liquidado Then
                MsgBox("El empleado esta liquidado, no puede ingresar movimientos para él", MsgBoxStyle.Critical, "SysNomina")
                Exit Sub
            End If
            If detEmpleado.Fecha_FinContrato <> "" Then
                MsgBox("El empleado esta dado de baja, no se puede ingresar movimientos de ahorro", MsgBoxStyle.Critical, "SysNomina")
                Exit Sub
            End If
            Me.cbMonedaPago.SelectedValue = detEmpleado.Moneda
            Me.txtFecha.EditValue = inicio
            Me.txtFecha.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarTransferencia.Click
        Me.gbRetiros.Visible = False
        Me.gbTransferencia.Visible = False
        Me.cmdAceptar.Enabled = True
        Me.cmdImprimir.Enabled = True
        Me.cmdCancelar.Enabled = True
        Me.Cargar()
    End Sub

    Private Sub btnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferencia.Click

        If QuincenaTrabajo Is Nothing Or QuincenaTrabajo = "" Then
            MsgBox("Debe seleccionar primero un Periodo de Trabajo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Me.txtTrasladoEmpresa.Text = 0.0
        Me.dtpTrasladoEmpresa.Value = Today
        Me.gbTransferencia.Visible = True
        Me.cmdAceptar.Enabled = False
        Me.cmdImprimir.Enabled = False
        Me.btnRetiros.Enabled = False
        Me.cmdCancelar.Enabled = False
    End Sub

    Private Sub cmdGuardarTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarTransferencia.Click
        If IsNumeric(Me.txtTrasladoEmpresa.Text) Then
            If CDbl(Me.txtTrasladoEmpresa.Text) < 0 Then
                MsgBox("El monto a trasladar no puede ser negativo", MsgBoxStyle.Critical, "SysNomina")
                Exit Sub
            End If
        End If


        If VB.SysContab.Empleado_AhorroDB.Transferencia(Me.cbempleado.EditValue, _
            Me.txtTrasladoEmpresa.Text, _
            QuincenaTrabajo.Substring(1, 8), _
            QuincenaTrabajo.Substring(0, 1), _
            ods.Rows(0)("tdi_empleado"), ods.Rows(0)("tdi_empresa"), _
            ods.Rows(0)("mon_codigo"), Me.dtpFechaRetiro.Value) = False Then
            MsgBox("No se pudo agregar el retiro de ahorro del empleado", MsgBoxStyle.Critical)

        End If
        Me.gbRetiros.Visible = False
        Me.gbTransferencia.Visible = False
        Me.cmdAceptar.Enabled = True
        Me.cmdImprimir.Enabled = True
        Me.cmdCancelar.Enabled = True
        Cargar()
    End Sub

    Private Sub cmdEmailAhorro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmailAhorro.Click

        'Dim rColilla As New rptECAhorro()
        Dim rColilla As New Object
        rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECAhorro.rpt")
            Exit Sub
        End If

        rColilla.load(Application.StartupPath & "\reportes\rptECAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet

        lds = VB.SysContab.Empleado_AhorroDB.GetListReporteEcAhorro(Registro.Substring(0, 8))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECAhorro.xml", XmlWriteMode.WriteSchema)
        rColilla.Database.Tables("vAhorro").Location = Application.StartupPath & "\exportfiles\ECAhorro.xml"
        rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"


        Dim crExportOptions As CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim fname As String

        If Me.detEmpleados.Email <> "" And Not (Me.detEmpleados.Email Is DBNull.Value) Then

            fname = Application.StartupPath() & "\exportfiles\Ahorro_" & Registro.Substring(0, 8) & ".pdf"
            crDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions()
            crDiskFileDestinationOptions.DiskFileName = fname
            crExportOptions = rColilla.ExportOptions
            With crExportOptions
                .DestinationOptions = crDiskFileDestinationOptions
                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            End With
            rColilla.Export()
            VB.SysContab.Email.Enviar_Mail_Outlook(Me.detEmpleados.Email, "Estado de Cuenta de Ahorro", _
                "Sírvase revisar el estado de Cuenta de Ahorro en archivo Adjunto", fname)

        End If
    End Sub

    Private Sub btnECAhorro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnECAhorro.Click
        Dim fReportes As New frmReportes()
        'Dim rColilla As New rptECAhorro()
        Dim rColilla As New Object
        rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECAhorro.rpt")
            Exit Sub
        End If

        rColilla.load(Application.StartupPath & "\reportes\rptECAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet

        lds = VB.SysContab.Empleado_AhorroDB.GetListReporteEcAhorro(Registro.Substring(0, 8))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECAhorro.xml", XmlWriteMode.WriteSchema)
        rColilla.Database.Tables("vAhorro").Location = Application.StartupPath & "\exportfiles\ECAhorro.xml"
        rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        fReportes.crvReportes.ReportSource = rColilla

        fReportes.ShowDialog()
    End Sub
End Class
