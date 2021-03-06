
Public Class frmRptPlanillaConsolidado
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmRptPlanillaConsolidado = Nothing

    Public Shared Function Instance() As frmRptPlanillaConsolidado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptPlanillaConsolidado()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbAfiscal As System.Windows.Forms.ComboBox
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents rbtPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents chkCD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.cbAfiscal = New System.Windows.Forms.ComboBox
        Me.GBMes = New System.Windows.Forms.GroupBox
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.rbtMes = New System.Windows.Forms.RadioButton
        Me.rbtPeriodo = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbEmpleados = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDepartamento = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbRubro = New System.Windows.Forms.ComboBox
        Me.chkCD = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox1.SuspendLayout()
        Me.GBMes.SuspendLayout()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.chkCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(8, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(808, 20)
        Me.etDescripcion.TabIndex = 114
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Per�odo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(672, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 336)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(8, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 24)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 42)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(19, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(101, 24)
        Me.Label44.TabIndex = 124
        Me.Label44.Text = "A�o Fiscal:"
        '
        'cbAfiscal
        '
        Me.cbAfiscal.Location = New System.Drawing.Point(139, 16)
        Me.cbAfiscal.Name = "cbAfiscal"
        Me.cbAfiscal.Size = New System.Drawing.Size(216, 21)
        Me.cbAfiscal.TabIndex = 123
        '
        'GBMes
        '
        Me.GBMes.Controls.Add(Me.cbPeriodo)
        Me.GBMes.Controls.Add(Me.rbtMes)
        Me.GBMes.Controls.Add(Me.rbtPeriodo)
        Me.GBMes.Controls.Add(Me.Label1)
        Me.GBMes.Controls.Add(Me.Label7)
        Me.GBMes.Controls.Add(Me.cbMes)
        Me.GBMes.Location = New System.Drawing.Point(19, 43)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(586, 68)
        Me.GBMes.TabIndex = 126
        Me.GBMes.TabStop = False
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(120, 16)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.NullText = ""
        Me.cbPeriodo.Size = New System.Drawing.Size(406, 20)
        Me.cbPeriodo.TabIndex = 118
        '
        'rbtMes
        '
        Me.rbtMes.Location = New System.Drawing.Point(16, 40)
        Me.rbtMes.Name = "rbtMes"
        Me.rbtMes.Size = New System.Drawing.Size(16, 24)
        Me.rbtMes.TabIndex = 117
        Me.rbtMes.Text = "RadioButton2"
        '
        'rbtPeriodo
        '
        Me.rbtPeriodo.Location = New System.Drawing.Point(16, 16)
        Me.rbtPeriodo.Name = "rbtPeriodo"
        Me.rbtPeriodo.Size = New System.Drawing.Size(16, 24)
        Me.rbtPeriodo.TabIndex = 116
        Me.rbtPeriodo.Text = "RadioButton1"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(41, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(120, 40)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(406, 23)
        Me.cbMes.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox7.Location = New System.Drawing.Point(32, 172)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(624, 56)
        Me.GroupBox7.TabIndex = 127
        Me.GroupBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 24)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(416, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCD)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.cbAfiscal)
        Me.GroupBox2.Controls.Add(Me.GBMes)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 118)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbLocalidad)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbEmpleados)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbDepartamento)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(624, 96)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 24)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Localidad:"
        '
        'cbLocalidad
        '
        Me.cbLocalidad.Location = New System.Drawing.Point(120, 15)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(416, 21)
        Me.cbLocalidad.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Empleado:"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Location = New System.Drawing.Point(120, 64)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(416, 21)
        Me.cbEmpleados.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Departamento:"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.Location = New System.Drawing.Point(120, 39)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(416, 21)
        Me.cbDepartamento.TabIndex = 123
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.cbRubro)
        Me.GroupBox5.Location = New System.Drawing.Point(32, 234)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(624, 53)
        Me.GroupBox5.TabIndex = 130
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Rubro:"
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(120, 21)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(216, 21)
        Me.cbRubro.TabIndex = 127
        '
        'chkCD
        '
        Me.chkCD.Location = New System.Drawing.Point(484, 18)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Properties.Caption = "Campos Din�micos?"
        Me.chkCD.Size = New System.Drawing.Size(121, 19)
        Me.chkCD.TabIndex = 127
        '
        'frmRptPlanillaConsolidado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 396)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmRptPlanillaConsolidado"
        Me.Text = "Reporte Consolidado de Planilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.chkCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Tasa As New VB.SysContab.Tasa_CambioDB()

    Private Sub frmVerPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        Me.cbMonedaCambio.ValueMember = "MonedaCambio"
        Me.cbMonedaCambio.DisplayMember = "Nombre"

        Me.cbAfiscal.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
        Me.cbAfiscal.ValueMember = "Per_ID"
        Me.cbAfiscal.DisplayMember = "Descripcion"
        Me.cbAfiscal.SelectedValue = Me.cbAfiscal.Items(Me.cbAfiscal.Items.Count - 1).row("Per_ID")

        Me.cbPeriodo.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
        Me.cbPeriodo.Properties.ValueMember = "Per_codigo"
        Me.cbPeriodo.Properties.DisplayMember = "Per_descripcion"

        Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
        Me.cbMes.ValueMember = "Mes"
        Me.cbMes.DisplayMember = "Descripcion"

        Me.cbPeriodo.EditValue = Registro
        Me.cbMes.SelectedValue = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(Registro, 7), 6)
        Me.rbtPeriodo.Checked = True

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListDepto("%").Tables("Empleados")
        Me.cbEmpleados.ValueMember = "Codigo"
        Me.cbEmpleados.DisplayMember = "Nombre"

        Me.cbLocalidad.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        Me.cbLocalidad.ValueMember = "Codigo"
        Me.cbLocalidad.DisplayMember = "Descripcion"

        Me.cbDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        Me.cbDepartamento.ValueMember = "Codigo"
        Me.cbDepartamento.DisplayMember = "Nombre"

        Me.cbRubro.DataSource = VB.SysContab.PlanillaDB.Rubros_Planilla().Tables("Rubros")
        Me.cbRubro.ValueMember = "rub_codigo"
        Me.cbRubro.DisplayMember = "rub_descripcion"

        Me.chkCD.Checked = True

        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cbAfiscal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAfiscal.SelectedValueChanged
        If IsNumeric(Me.cbAfiscal.SelectedValue) Or TypeName(Me.cbAfiscal.SelectedValue).ToLower = "string" Then
            Me.cbPeriodo.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbPeriodo.Properties.ValueMember = "Per_codigo"
            Me.cbPeriodo.Properties.DisplayMember = "Per_descripcion"

            Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes.ValueMember = "Mes"
            Me.cbMes.DisplayMember = "Descripcion"


            Me.cbPeriodo.EditValue = Registro
        End If
    End Sub


    Private Sub rbtPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPeriodo.CheckedChanged

        Me.cbMes.Enabled = Not Me.rbtPeriodo.Checked
        Me.cbPeriodo.Enabled = Me.rbtPeriodo.Checked
        Me.cbMes.SelectedValue = IIf(Me.rbtPeriodo.Checked, "", Me.cbMes.SelectedValue)
        If IsNumeric(Me.cbPeriodo.EditValue) Then
            Me.cbPeriodo.EditValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.EditValue)
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Me.cbMes.SelectedValue = "" And Me.cbPeriodo.EditValue = "" Then
            If Me.cbAfiscal.SelectedValue = 0 And Me.cbPeriodo.EditValue = "" Then
                MsgBox("Seleccione Mes o Periodo de Nomina a imprimir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        End If
        Dim rubro As String
        If Me.cbRubro.SelectedValue Is Nothing Then
            rubro = "%"
        Else
            If Me.cbRubro.SelectedValue Is DBNull.Value Then
                rubro = "%"
            Else
                rubro = Me.cbRubro.SelectedValue
            End If
        End If
        
        Dim lds, ds As DataSet

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)

        ds = VB.SysContab.PlanillaDB.Consolidado(Me.cbAfiscal.SelectedValue, Periodo, TPeriodo, _
            IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), Me.cbMonedaCambio.SelectedValue, _
            Me.cbDepartamento.SelectedValue, Me.cbEmpleados.SelectedValue, rubro, _
            IIf(Me.cbLocalidad.SelectedValue Is Nothing Or Me.cbLocalidad.SelectedValue Is DBNull.Value, 0, Me.cbLocalidad.SelectedValue), _
            Me.chkCD.Checked)
        ds.WriteXml(Application.StartupPath & "\ConPla.xml", XmlWriteMode.WriteSchema)
        Dim f As New frmGridDatos
        f.Text = "Consolidado de Planillas " & IIf(rbtMes.Checked = True, " del mes de ", " del periodo ") & _
        IIf(rbtMes.Checked = True, Me.cbMes.Text, Me.cbPeriodo.Text)
        f.Origen = ds
        f.ShowDialog()
        lds = Nothing
        ds = Nothing
        Me.Close()
        
    End Sub

    Private Sub cbDepartamento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.SelectedValueChanged
        If IsNumeric(Me.cbDepartamento.SelectedValue) Then
            Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListDepto(Me.cbDepartamento.SelectedValue).Tables("Empleados")
            Me.cbEmpleados.ValueMember = "Codigo"
            Me.cbEmpleados.DisplayMember = "Nombre"
        End If
    End Sub

    'Private Sub cbPeriodo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodoOLD.SelectedIndexChanged

    '    If TypeName(Me.cbPeriodoOLD.SelectedValue) = "String" Then
    '        Registro = Me.cbPeriodoOLD.SelectedValue
    '    End If

    'End Sub

    Private Sub cbPeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodo.EditValueChanged
        If TypeName(Me.cbPeriodo.EditValue) = "String" Then
            Registro = Me.cbPeriodo.EditValue
        End If
    End Sub
End Class
