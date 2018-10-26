Imports System.IO
Imports DbConnect

Public Class frmAgregarDeduccion
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarDeduccion = Nothing
#Region "Variables"
    Public ncuotaAnterior As Integer
    Public Cargado As Boolean = False
    Dim detEmpleados As New VB.SysContab.EmpleadosDetails()
    Dim inicio, final As Date
    Dim Tipo As Integer
    Dim txtAporte As Double = 0 'rmpr se agrego para suplir el txt retirado para hacer espacio a las deducciones x hora o x dia
    Dim Origen As String = ""
    Dim MonedaBase As String = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE
    Dim MonedaAnterior As String = ""
    Dim EmpleadoAnterior As String = ""
    Friend WithEvents dVista As New DevExpress.XtraGrid.Views.Grid.GridView
#End Region
#Region "Calaches"
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbempleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents VistaEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgDetalleDeduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDetalleDeduccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblMantenimiento As System.Windows.Forms.Label
    Friend WithEvents chkMantenimiento As System.Windows.Forms.CheckBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblDiasHoras As System.Windows.Forms.Label
    Friend WithEvents txtDiasHoras As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNotas As System.Windows.Forms.Button
    Friend WithEvents cmdBorrarNota As System.Windows.Forms.Button
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtcomentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkDeducir As System.Windows.Forms.CheckBox
#End Region


    Public Shared Function Instance() As frmAgregarDeduccion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarDeduccion()
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
    Friend WithEvents DatosEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtptm_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpptm_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtptm_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtptm_Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtptm_Valorcuota As System.Windows.Forms.TextBox
    Friend WithEvents NUDptm_NCuotas As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtptm_monto As System.Windows.Forms.TextBox
    Friend WithEvents ckbptm_CtaFija As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkNREgular As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.DatosEmpleados = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkDeducir = New System.Windows.Forms.CheckBox()
        Me.cbempleado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.VistaEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtptm_Codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtptm_Fecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpptm_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtptm_monto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtptm_Saldo = New System.Windows.Forms.TextBox()
        Me.NUDptm_NCuotas = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcomentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMantenimiento = New System.Windows.Forms.Label()
        Me.chkMantenimiento = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkNREgular = New System.Windows.Forms.CheckBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTDeduccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblDiasHoras = New System.Windows.Forms.Label()
        Me.txtDiasHoras = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ckbptm_CtaFija = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtptm_Valorcuota = New System.Windows.Forms.TextBox()
        Me.dgDetalleDeduccion = New DevExpress.XtraGrid.GridControl()
        Me.VDetalleDeduccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdNotas = New System.Windows.Forms.Button()
        Me.cmdBorrarNota = New System.Windows.Forms.Button()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DatosEmpleados.SuspendLayout()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUDptm_NCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtcomentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDetalleDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDetalleDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 56)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 30
        Me.cmdAceptar.Text = "Aceptar"
        '
        'DatosEmpleados
        '
        Me.DatosEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DatosEmpleados.Controls.Add(Me.Label13)
        Me.DatosEmpleados.Controls.Add(Me.chkDeducir)
        Me.DatosEmpleados.Controls.Add(Me.cbempleado)
        Me.DatosEmpleados.Controls.Add(Me.Label21)
        Me.DatosEmpleados.Controls.Add(Me.Label16)
        Me.DatosEmpleados.Controls.Add(Me.TextBox12)
        Me.DatosEmpleados.Controls.Add(Me.Label1)
        Me.DatosEmpleados.Controls.Add(Me.txtptm_Codigo)
        Me.DatosEmpleados.Controls.Add(Me.Label2)
        Me.DatosEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosEmpleados.ForeColor = System.Drawing.Color.Maroon
        Me.DatosEmpleados.Location = New System.Drawing.Point(16, 5)
        Me.DatosEmpleados.Name = "DatosEmpleados"
        Me.DatosEmpleados.Size = New System.Drawing.Size(840, 51)
        Me.DatosEmpleados.TabIndex = 0
        Me.DatosEmpleados.TabStop = False
        Me.DatosEmpleados.Text = "DATOS GENERALES DEL EMPLEADO"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(733, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 19)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Deducir?"
        '
        'chkDeducir
        '
        Me.chkDeducir.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chkDeducir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeducir.Location = New System.Drawing.Point(812, 16)
        Me.chkDeducir.Name = "chkDeducir"
        Me.chkDeducir.Size = New System.Drawing.Size(20, 24)
        Me.chkDeducir.TabIndex = 172
        Me.chkDeducir.UseVisualStyleBackColor = False
        '
        'cbempleado
        '
        Me.cbempleado.EditValue = ""
        Me.cbempleado.Enabled = False
        Me.cbempleado.Location = New System.Drawing.Point(78, 18)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbempleado.Properties.NullText = ""
        Me.cbempleado.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cbempleado.Properties.PopupSizeable = False
        Me.cbempleado.Properties.ShowFooter = False
        Me.cbempleado.Properties.View = Me.VistaEmpleado
        Me.cbempleado.Size = New System.Drawing.Size(415, 20)
        Me.cbempleado.TabIndex = 165
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
        'txtptm_Codigo
        '
        Me.txtptm_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_Codigo.Enabled = False
        Me.txtptm_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_Codigo.Location = New System.Drawing.Point(639, 15)
        Me.txtptm_Codigo.MaxLength = 6
        Me.txtptm_Codigo.Name = "txtptm_Codigo"
        Me.txtptm_Codigo.Size = New System.Drawing.Size(88, 20)
        Me.txtptm_Codigo.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(537, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "#Deducción:"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(8, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(144, 24)
        Me.Label33.TabIndex = 146
        Me.Label33.Text = "Tipo de Deducción:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(872, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 246)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(530, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Fecha:"
        '
        'txtptm_Fecha
        '
        Me.txtptm_Fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_Fecha.Enabled = False
        Me.txtptm_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_Fecha.Location = New System.Drawing.Point(712, 16)
        Me.txtptm_Fecha.MaxLength = 15
        Me.txtptm_Fecha.Name = "txtptm_Fecha"
        Me.txtptm_Fecha.Size = New System.Drawing.Size(112, 20)
        Me.txtptm_Fecha.TabIndex = 149
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(530, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Iniciar Deduccion el:"
        '
        'dtpptm_FechaInicio
        '
        Me.dtpptm_FechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpptm_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpptm_FechaInicio.Location = New System.Drawing.Point(712, 38)
        Me.dtpptm_FechaInicio.Name = "dtpptm_FechaInicio"
        Me.dtpptm_FechaInicio.Size = New System.Drawing.Size(112, 20)
        Me.dtpptm_FechaInicio.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Monto:"
        '
        'txtptm_monto
        '
        Me.txtptm_monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_monto.Location = New System.Drawing.Point(141, 16)
        Me.txtptm_monto.MaxLength = 15
        Me.txtptm_monto.Name = "txtptm_monto"
        Me.txtptm_monto.Size = New System.Drawing.Size(88, 20)
        Me.txtptm_monto.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(647, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Saldo:"
        '
        'txtptm_Saldo
        '
        Me.txtptm_Saldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_Saldo.Enabled = False
        Me.txtptm_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_Saldo.Location = New System.Drawing.Point(736, 47)
        Me.txtptm_Saldo.MaxLength = 15
        Me.txtptm_Saldo.Name = "txtptm_Saldo"
        Me.txtptm_Saldo.Size = New System.Drawing.Size(88, 20)
        Me.txtptm_Saldo.TabIndex = 156
        '
        'NUDptm_NCuotas
        '
        Me.NUDptm_NCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDptm_NCuotas.Location = New System.Drawing.Point(533, 48)
        Me.NUDptm_NCuotas.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUDptm_NCuotas.Name = "NUDptm_NCuotas"
        Me.NUDptm_NCuotas.Size = New System.Drawing.Size(56, 20)
        Me.NUDptm_NCuotas.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(437, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "#Cuotas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtcomentarios)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblMantenimiento)
        Me.GroupBox1.Controls.Add(Me.chkMantenimiento)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.chkNREgular)
        Me.GroupBox1.Controls.Add(Me.cbMoneda)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpptm_FechaInicio)
        Me.GroupBox1.Controls.Add(Me.txtptm_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.cbTDeduccion)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 124)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        '
        'txtcomentarios
        '
        Me.txtcomentarios.Location = New System.Drawing.Point(151, 65)
        Me.txtcomentarios.Name = "txtcomentarios"
        Me.txtcomentarios.Size = New System.Drawing.Size(374, 50)
        Me.txtcomentarios.TabIndex = 178
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "Comentarios:"
        '
        'lblMantenimiento
        '
        Me.lblMantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lblMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMantenimiento.Location = New System.Drawing.Point(713, 64)
        Me.lblMantenimiento.Name = "lblMantenimiento"
        Me.lblMantenimiento.Size = New System.Drawing.Size(90, 19)
        Me.lblMantenimiento.TabIndex = 175
        Me.lblMantenimiento.Text = "Mtto Valor?"
        '
        'chkMantenimiento
        '
        Me.chkMantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chkMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMantenimiento.Location = New System.Drawing.Point(812, 59)
        Me.chkMantenimiento.Name = "chkMantenimiento"
        Me.chkMantenimiento.Size = New System.Drawing.Size(20, 24)
        Me.chkMantenimiento.TabIndex = 174
        Me.chkMantenimiento.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(676, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 24)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Nomina Regular:"
        '
        'chkNREgular
        '
        Me.chkNREgular.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chkNREgular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNREgular.Location = New System.Drawing.Point(812, 85)
        Me.chkNREgular.Name = "chkNREgular"
        Me.chkNREgular.Size = New System.Drawing.Size(16, 24)
        Me.chkNREgular.TabIndex = 170
        Me.chkNREgular.UseVisualStyleBackColor = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.ItemHeight = 15
        Me.cbMoneda.Location = New System.Drawing.Point(151, 35)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(326, 23)
        Me.cbMoneda.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 24)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "Moneda:"
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.EditValue = ""
        Me.cbTDeduccion.Location = New System.Drawing.Point(151, 13)
        Me.cbTDeduccion.Name = "cbTDeduccion"
        Me.cbTDeduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Properties.NullText = ""
        Me.cbTDeduccion.Size = New System.Drawing.Size(326, 20)
        Me.cbTDeduccion.TabIndex = 176
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lblValor)
        Me.GroupBox4.Controls.Add(Me.txtValor)
        Me.GroupBox4.Controls.Add(Me.lblDiasHoras)
        Me.GroupBox4.Controls.Add(Me.txtDiasHoras)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.ckbptm_CtaFija)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtptm_Valorcuota)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtptm_monto)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtptm_Saldo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.NUDptm_NCuotas)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 177)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 73)
        Me.GroupBox4.TabIndex = 161
        Me.GroupBox4.TabStop = False
        '
        'lblValor
        '
        Me.lblValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblValor.Location = New System.Drawing.Point(268, 41)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(67, 24)
        Me.lblValor.TabIndex = 169
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(341, 40)
        Me.txtValor.MaxLength = 15
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 20)
        Me.txtValor.TabIndex = 168
        '
        'lblDiasHoras
        '
        Me.lblDiasHoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lblDiasHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasHoras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDiasHoras.Location = New System.Drawing.Point(8, 40)
        Me.lblDiasHoras.Name = "lblDiasHoras"
        Me.lblDiasHoras.Size = New System.Drawing.Size(118, 24)
        Me.lblDiasHoras.TabIndex = 167
        Me.lblDiasHoras.Text = "Dias / Horas:"
        '
        'txtDiasHoras
        '
        Me.txtDiasHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasHoras.Location = New System.Drawing.Point(141, 40)
        Me.txtDiasHoras.MaxLength = 15
        Me.txtDiasHoras.Name = "txtDiasHoras"
        Me.txtDiasHoras.Size = New System.Drawing.Size(88, 20)
        Me.txtDiasHoras.TabIndex = 166
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(437, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 163
        Me.Label10.Text = "Cuota Fija:"
        '
        'ckbptm_CtaFija
        '
        Me.ckbptm_CtaFija.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ckbptm_CtaFija.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbptm_CtaFija.Location = New System.Drawing.Point(533, 15)
        Me.ckbptm_CtaFija.Name = "ckbptm_CtaFija"
        Me.ckbptm_CtaFija.Size = New System.Drawing.Size(16, 24)
        Me.ckbptm_CtaFija.TabIndex = 162
        Me.ckbptm_CtaFija.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(609, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 24)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "Valor Cuota:"
        '
        'txtptm_Valorcuota
        '
        Me.txtptm_Valorcuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptm_Valorcuota.Enabled = False
        Me.txtptm_Valorcuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptm_Valorcuota.Location = New System.Drawing.Point(736, 16)
        Me.txtptm_Valorcuota.MaxLength = 15
        Me.txtptm_Valorcuota.Name = "txtptm_Valorcuota"
        Me.txtptm_Valorcuota.Size = New System.Drawing.Size(88, 20)
        Me.txtptm_Valorcuota.TabIndex = 160
        '
        'dgDetalleDeduccion
        '
        Me.dgDetalleDeduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalleDeduccion.Location = New System.Drawing.Point(16, 256)
        Me.dgDetalleDeduccion.MainView = Me.VDetalleDeduccion
        Me.dgDetalleDeduccion.Name = "dgDetalleDeduccion"
        Me.dgDetalleDeduccion.Size = New System.Drawing.Size(840, 253)
        Me.dgDetalleDeduccion.TabIndex = 164
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdNotas)
        Me.GroupBox3.Controls.Add(Me.cmdBorrarNota)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(872, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 253)
        Me.GroupBox3.TabIndex = 166
        Me.GroupBox3.TabStop = False
        '
        'cmdNotas
        '
        Me.cmdNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotas.ForeColor = System.Drawing.Color.Black
        Me.cmdNotas.Location = New System.Drawing.Point(16, 20)
        Me.cmdNotas.Name = "cmdNotas"
        Me.cmdNotas.Size = New System.Drawing.Size(72, 34)
        Me.cmdNotas.TabIndex = 33
        Me.cmdNotas.Text = "Agregar Notas"
        '
        'cmdBorrarNota
        '
        Me.cmdBorrarNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarNota.ForeColor = System.Drawing.Color.Black
        Me.cmdBorrarNota.Location = New System.Drawing.Point(16, 75)
        Me.cmdBorrarNota.Name = "cmdBorrarNota"
        Me.cmdBorrarNota.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrarNota.TabIndex = 32
        Me.cmdBorrarNota.Text = "Borrar Nota"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'frmAgregarDeduccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 514)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgDetalleDeduccion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DatosEmpleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgregarDeduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DatosEmpleados.ResumeLayout(False)
        Me.DatosEmpleados.PerformLayout()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NUDptm_NCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtcomentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgDetalleDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDetalleDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarDeduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim detDeduccion As New VB.SysContab.DeduccionDetails()

        Me.cbTDeduccion.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTDeduccion.Properties.ValueMember = "Codigo"
        Me.cbTDeduccion.Properties.DisplayMember = "Descripcion"

        cbMoneda.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMoneda.ValueMember = "Codigo"
        cbMoneda.DisplayMember = "Descripcion"

        Me.cbempleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.VistaEmpleado.Columns("Codigo").Width = 100
        Me.VistaEmpleado.Columns("Nombre").Width = 250
        Me.cbempleado.Properties.DisplayMember = "Nombre"
        Me.cbempleado.Properties.ValueMember = "Codigo"

        Me.NUDptm_NCuotas.Minimum = 1

        'Me.txtAporte.Text = 0.0 'rmpr se quito para hacer espacio a las deducciones x hora o x dia
        Me.ncuotaAnterior = 0
        Me.chkNREgular.Checked = True

        VB.SysContab.PeriodoNominaDB.GetListFechaMinima_Nominas(inicio, final)

        Me.chkMantenimiento.Visible = Mantenimiento_Deduccion
        Me.lblMantenimiento.Visible = Mantenimiento_Deduccion

        If Nuevo = "NO" Then



            detDeduccion = VB.SysContab.DeduccionDB.GetDetails(Registro)
            detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(detDeduccion.Empleado)

            Me.Text = "Editar Deducción de Empleado"

            Me.cbempleado.EditValue = detDeduccion.Empleado
            Me.cbempleado.Enabled = False

            Me.cbMoneda.SelectedValue = detDeduccion.Moneda
            Me.txtcomentarios.EditValue = detDeduccion.Comentarios
            Me.txtptm_Codigo.Text = detDeduccion.Codigo
            Me.cbTDeduccion.EditValue = detDeduccion.TipoDeduccion
            'Tipo = Me.VTDeduccion.GetRow(Me.cbTDeduccion.Properties.GetIndexByKeyValue(Me.cbTDeduccion.EditValue))("Tipo")
            Tipo = Me.cbTDeduccion.GetColumnValue("Tipo")
            Me.dtpptm_FechaInicio.Value = detDeduccion.FInicio
            Me.txtptm_Fecha.Text = detDeduccion.Fecha
            Me.txtptm_monto.Text = detDeduccion.Monto
            Me.txtptm_Valorcuota.Text = detDeduccion.ValorCuota
            Me.txtptm_Saldo.Text = detDeduccion.Saldo
            Me.NUDptm_NCuotas.Value = detDeduccion.NCuotas
            Me.ncuotaAnterior = detDeduccion.NCuotas
            Me.ckbptm_CtaFija.Checked = detDeduccion.CuotaFija
            Me.chkNREgular.Checked = detDeduccion.NRegular
            Me.chkDeducir.Checked = detDeduccion.Deducir

            'buscar el detalle de cuotas deducidas en nomina
            Me.dgDetalleDeduccion.DataSource = VB.SysContab.DetalleDeduccionDB.GetList(Me.txtptm_Codigo.Text).Tables("DetalleDeduccion")
            If Me.VDetalleDeduccion.DataRowCount > 0 Then
                Me.GroupBox1.Enabled = False
                Me.GroupBox4.Enabled = False
            Else
                Me.GroupBox1.Enabled = True
                Me.GroupBox4.Enabled = True

            End If
            Select Case VB.SysContab.TipoDeduccionDB.GetDetails(Me.cbTDeduccion.EditValue).Tipo
                Case 3
                    Me.NUDptm_NCuotas.Maximum = 1000
                    Me.NUDptm_NCuotas.Enabled = True

                    Me.lblDiasHoras.Visible = False
                    Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False

                    Me.txtptm_monto.Enabled = True
                    Me.txtDiasHoras.Enabled = False
                    Me.ckbptm_CtaFija.Enabled = False
                Case 5, 6, 7

                    Me.NUDptm_NCuotas.Maximum = 1
                    Me.NUDptm_NCuotas.Enabled = False
                    Me.lblDiasHoras.Visible = True
                    Me.lblValor.Visible = True
                    Me.txtDiasHoras.Visible = True
                    Me.txtValor.Visible = True

                    Me.txtptm_monto.Enabled = False
                    Me.txtDiasHoras.Enabled = True
                    Me.ckbptm_CtaFija.Enabled = False
                Case Else

                    Me.NUDptm_NCuotas.Maximum = 1
                    Me.NUDptm_NCuotas.Enabled = False
                    Me.lblDiasHoras.Visible = False
                    Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False

                    Me.txtptm_monto.Enabled = True
                    Me.txtDiasHoras.Enabled = False
                    Me.ckbptm_CtaFija.Enabled = IIf(VB.SysContab.TipoDeduccionDB.GetDetails(Me.cbTDeduccion.EditValue).Tipo = 2, True, False)
            End Select
            Me.chkDeducir.Enabled = True
            Me.chkMantenimiento.Checked = detDeduccion.Mantenimiento
            Me.txtDiasHoras.Text = detDeduccion.DiaHora
            Me.txtValor.Text = detDeduccion.Valor
        Else
            Me.Text = "Agregar Deducción de Empleado"

            'Me.txtCodigo.Text = Empleados.GetListNvo
            Me.cbempleado.Enabled = True
            Me.txtptm_Codigo.Text = VB.SysContab.DeduccionDB.GetListCodigoNvo()

            'Me.cbTDeduccion.SelectedValue = detDeduccion.TipoDeduccion
            Me.dtpptm_FechaInicio.Value = Today
            Me.txtptm_Fecha.Text = Today
            Me.txtptm_monto.Text = 0.0
            Me.txtptm_Valorcuota.Text = 0.0
            Me.txtptm_Saldo.Text = 0.0
            Me.NUDptm_NCuotas.Value = 1
            Me.ckbptm_CtaFija.Checked = False
            Me.chkDeducir.Checked = True
            Me.chkDeducir.Enabled = False
            Me.chkMantenimiento.Checked = False
            Me.txtValor.Text = Me.detEmpleados.SalarioxDia
            Me.txtcomentarios.EditValue = ""

        End If
        Cargado = True
        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim nvoCodigo As String = ""
        'Me.cbTDeduccion.GetFocusedRowCellValue("Unico")
        If CDbl(Me.txtptm_monto.Text) = 0 Then
            MsgBox("Digite un monto a deducir", MsgBoxStyle.Exclamation, "Sts-Nomina")
            Exit Sub
        End If
        Dim deducciones As New VB.SysContab.DeduccionDB()
        If Nuevo = "SI" Then
            VB.SysContab.DeduccionDB.Additem(Me.txtptm_Codigo.Text, Me.cbempleado.EditValue, Me.txtptm_Fecha.Text, Me.dtpptm_FechaInicio.Value, _
                Me.txtptm_monto.Text, Me.txtptm_Saldo.Text, Me.NUDptm_NCuotas.Text, Me.txtptm_Valorcuota.Text, Me.txtAporte, _
                Me.cbTDeduccion.EditValue, Me.chkDeducir.Checked, Me.ckbptm_CtaFija.Checked, False, Me.cbMoneda.SelectedValue, _
                Me.cbTDeduccion.GetColumnValue("Unico"), _
                Me.chkNREgular.Checked, Me.chkMantenimiento.Checked, Me.txtDiasHoras.Text, Me.txtValor.Text, nvoCodigo, Me.TXTCOMENTARIOS.EDITVALUE)
        Else
            VB.SysContab.DeduccionDB.Update(Me.txtptm_Codigo.Text, Me.cbempleado.EditValue, Me.txtptm_Fecha.Text, Me.dtpptm_FechaInicio.Value, _
                Me.txtptm_monto.Text, Me.txtptm_Saldo.Text, Me.NUDptm_NCuotas.Text, Me.txtptm_Valorcuota.Text, Me.txtAporte, _
                Me.cbTDeduccion.EditValue, Me.chkDeducir.Checked, Me.ckbptm_CtaFija.Checked, False, Me.cbMoneda.SelectedValue, _
                Me.cbTDeduccion.GetColumnValue("Unico"), _
                Me.chkNREgular.Checked, Me.chkMantenimiento.Checked, Me.txtDiasHoras.Text, Me.txtValor.Text, Me.TXTCOMENTARIOS.EDITVALUE)
        End If
        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.OkOnly)
        Me.Close()

    End Sub

    Private Sub txtptm_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtptm_monto.TextChanged
        'If Nuevo = "SI" Then
        Me.txtptm_Saldo.Text = Me.txtptm_monto.Text
        Me.txtptm_Valorcuota.Text = Math.Round(IIf(Me.txtptm_monto.Text = "", 0, Me.txtptm_monto.Text) / Me.NUDptm_NCuotas.Value, 2)
        'End If
    End Sub

    Private Sub NUDptm_NCuotas_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NUDptm_NCuotas.ValueChanged
        Me.txtptm_Valorcuota.Text = Math.Round(IIf(Me.txtptm_monto.Text = "", 0, Me.txtptm_monto.Text) / Me.NUDptm_NCuotas.Value, 2)
    End Sub

    Private Sub ckbptm_CtaFija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbptm_CtaFija.CheckedChanged
        If Me.ckbptm_CtaFija.Checked Then
            Me.NUDptm_NCuotas.Enabled = False
        Else
            Me.NUDptm_NCuotas.Enabled = True
        End If
    End Sub

    Private Sub cbempleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbempleado.Validating
        If Cargado Then
            If Me.cbempleado.EditValue Is DBNull.Value Or Me.cbempleado.EditValue = "" Then
                Exit Sub
            End If
            detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(Me.cbempleado.EditValue)

        End If
    End Sub

    Private Sub cbTDeduccion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTDeduccion.EditValueChanged
        If Cargado Then
            Tipo = Me.cbTDeduccion.GetColumnValue("Tipo") ' Me.vTDeduccion.GetRow(Me.cbTDeduccion.Properties.GetIndexByKeyValue(Me.cbTDeduccion.EditValue))("Tipo")
            Select Case Tipo
                Case 3
                    Me.NUDptm_NCuotas.Maximum = 1000
                    Me.NUDptm_NCuotas.Enabled = True
                    Me.lblDiasHoras.Visible = False
                    Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False
                    Me.txtDiasHoras.Text = "0.00"
                    Me.txtValor.Text = "0.00"
                    Me.txtptm_monto.Text = "0.00"
                    Me.txtptm_monto.Enabled = True
                    Me.ckbptm_CtaFija.Enabled = False
                Case 5, 6, 7
                    Me.NUDptm_NCuotas.Maximum = 1
                    Me.NUDptm_NCuotas.Enabled = False
                    Me.lblDiasHoras.Visible = True
                    Me.lblValor.Visible = True
                    Me.txtDiasHoras.Visible = True
                    Me.txtValor.Visible = True
                    Me.txtptm_monto.Enabled = False

                    Dim TC As Double
                    TC = VB.SysContab.Tasa_CambioDB.TasaCambioDia(Me.dtpptm_FechaInicio.Value.Day, _
                        Me.dtpptm_FechaInicio.Value.Month, _
                        Me.dtpptm_FechaInicio.Value.Year, _
                        Me.cbMoneda.SelectedValue, _
                        detEmpleados.Moneda)

                    'If Me.txtDiasHoras.Text <> "0.00" And IsNumeric(Me.txtDiasHoras.Text) And IsNumeric(Me.txtValor.Text) Then
                    If Tipo = 5 Then
                        Me.txtValor.Text = detEmpleados.SalarioxDia
                    ElseIf Tipo = 6 Then
                        Me.txtValor.Text = detEmpleados.SalarioxHora
                    ElseIf Tipo = 7 Then
                        Me.txtValor.Text = Me.cbTDeduccion.GetColumnValue("Tipo") 'Me.vTDeduccion.GetRow(Me.cbTDeduccion.Properties.GetIndexByKeyValue(Me.cbTDeduccion.EditValue))("Tipo")
                    End If
                    Me.txtValor.Text = Math.Round(CDbl(Me.txtValor.Text) * TC, 2)
                    'End If
                    Me.txtptm_monto.Text = Math.Round(CDbl(Me.txtDiasHoras.Text) * CDbl(Me.txtValor.Text), 2)

                    Me.ckbptm_CtaFija.Enabled = False
                Case Else
                    Me.NUDptm_NCuotas.Maximum = 1
                    Me.NUDptm_NCuotas.Enabled = False
                    Me.lblDiasHoras.Visible = False
                    Me.lblValor.Visible = False
                    Me.txtDiasHoras.Visible = False
                    Me.txtValor.Visible = False
                    Me.txtDiasHoras.Text = "0.0"
                    Me.txtValor.Text = "0.0"
                    Me.txtptm_monto.Text = "0.00"
                    Me.txtptm_monto.Enabled = True
                    Me.ckbptm_CtaFija.Enabled = IIf(Tipo = 2, True, False)
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
            TC = VB.SysContab.Tasa_CambioDB.TasaCambioDia(Me.dtpptm_FechaInicio.Value.Day, _
                Me.dtpptm_FechaInicio.Value.Month, _
                Me.dtpptm_FechaInicio.Value.Year, _
                Me.cbMoneda.SelectedValue, _
                detEmpleados.Moneda)

            If Me.txtDiasHoras.Text <> "0.00" And IsNumeric(Me.txtDiasHoras.Text) And IsNumeric(Me.txtValor.Text) Then
                If Tipo = 5 Then
                    Me.txtValor.Text = detEmpleados.SalarioxDia
                ElseIf Tipo = 6 Then
                    Me.txtValor.Text = detEmpleados.SalarioxHora
                ElseIf Tipo = 7 Then
                    Me.txtValor.Text = Me.cbTDeduccion.GetColumnValue("Tipo") 'Me.VTDeduccion.GetRow(Me.cbTDeduccion.Properties.GetIndexByKeyValue(Me.cbTDeduccion.EditValue))("Tipo")
                Else
                    Me.txtValor.Text = "0.00"
                End If
                Me.txtValor.Text = Math.Round(CDbl(Me.txtValor.Text) * TC, 2)
            End If
            Me.txtptm_monto.Text = Math.Round(CDbl(Me.txtDiasHoras.Text) * CDbl(Me.txtValor.Text), 2)
        End If
    End Sub

    Private Sub cmdNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotas.Click
        Dim f As New frmAgregarDeduccion_Cancelar
        f.Codigo = Me.txtptm_Codigo.Text
        f.ShowDialog()

        Me.CargarDetalle()
    End Sub
    Public Sub CargarDetalle()
        'buscar el detalle de cuotas deducidas en nomina
        Me.dgDetalleDeduccion.DataSource = VB.SysContab.DetalleDeduccionDB.GetList(Me.txtptm_Codigo.Text).Tables("DetalleDeduccion")
        If Me.VDetalleDeduccion.DataRowCount > 0 Then
            Me.GroupBox1.Enabled = False
            Me.GroupBox4.Enabled = False
        Else
            Me.GroupBox1.Enabled = True
            Me.GroupBox4.Enabled = True

        End If
        Me.VDetalleDeduccion.Columns("Codigo").Visible = False
        Me.txtptm_Saldo.Text = VB.SysContab.DeduccionDB.GetDetails(Registro).Saldo

    End Sub

    Private Sub cmdBorrarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrarNota.Click
        If Me.VDetalleDeduccion.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.VDetalleDeduccion.GetFocusedRowCellValue("Codigo")(0) = "N" Then
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Nota", SqlDbType.Int, 5, ParameterDirection.Input, _
                Me.VDetalleDeduccion.GetFocusedRowCellValue("Codigo").substring(1, Me.VDetalleDeduccion.GetFocusedRowCellValue("Codigo").length - 1))
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.EjecutarComando("_Deduccion_Nota_Delete")
            v = Nothing
            Me.CargarDetalle()
        End If
    End Sub
    Private Sub VDetalleDeduccion_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles VDetalleDeduccion.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dVista Is Nothing Then
                dVista.Columns("Codigo").Visible = False

            End If
        End If
    End Sub
End Class
