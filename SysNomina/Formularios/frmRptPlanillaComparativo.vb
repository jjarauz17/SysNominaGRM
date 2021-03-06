Imports System.IO
Public Class frmRptPlanillaComparativo
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmRptPlanillaComparativo = Nothing

    Public Shared Function Instance() As frmRptPlanillaComparativo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptPlanillaComparativo()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents rbtMes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtAFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbtAfiscal2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMes2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPeriodo2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbperiodo2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbMes2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAfiscal As System.Windows.Forms.ComboBox
    Friend WithEvents cbAfiscal2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents rbDetallado As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbAfiscal = New System.Windows.Forms.ComboBox()
        Me.GBMes = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtAFiscal = New System.Windows.Forms.RadioButton()
        Me.rbtMes = New System.Windows.Forms.RadioButton()
        Me.rbtPeriodo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbAfiscal2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbtAfiscal2 = New System.Windows.Forms.RadioButton()
        Me.rbtMes2 = New System.Windows.Forms.RadioButton()
        Me.rbtPeriodo2 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbperiodo2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMes2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.rbDetallado = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(8, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(896, 20)
        Me.etDescripcion.TabIndex = 114
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnImprimir, Me.cmdSalir})
        Me.GroupBox1.Location = New System.Drawing.Point(776, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 400)
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
        Me.cmdSalir.Location = New System.Drawing.Point(8, 368)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label44.Location = New System.Drawing.Point(16, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 24)
        Me.Label44.TabIndex = 124
        Me.Label44.Text = "A�o Fiscal:"
        '
        'cbAfiscal
        '
        Me.cbAfiscal.Location = New System.Drawing.Point(120, 24)
        Me.cbAfiscal.Name = "cbAfiscal"
        Me.cbAfiscal.Size = New System.Drawing.Size(216, 21)
        Me.cbAfiscal.TabIndex = 123
        '
        'GBMes
        '
        Me.GBMes.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.rbtAFiscal, Me.rbtMes, Me.rbtPeriodo, Me.Label1, Me.cbPeriodo, Me.Label7, Me.cbMes})
        Me.GBMes.Location = New System.Drawing.Point(32, 160)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(344, 96)
        Me.GBMes.TabIndex = 126
        Me.GBMes.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "A�o Fiscal"
        '
        'rbtAFiscal
        '
        Me.rbtAFiscal.Location = New System.Drawing.Point(16, 64)
        Me.rbtAFiscal.Name = "rbtAFiscal"
        Me.rbtAFiscal.Size = New System.Drawing.Size(16, 24)
        Me.rbtAFiscal.TabIndex = 124
        Me.rbtAFiscal.Text = "RadioButton2"
        '
        'rbtMes
        '
        Me.rbtMes.Location = New System.Drawing.Point(16, 40)
        Me.rbtMes.Name = "rbtMes"
        Me.rbtMes.Size = New System.Drawing.Size(16, 24)
        Me.rbtMes.TabIndex = 123
        Me.rbtMes.Text = "RadioButton2"
        '
        'rbtPeriodo
        '
        Me.rbtPeriodo.Location = New System.Drawing.Point(16, 16)
        Me.rbtPeriodo.Name = "rbtPeriodo"
        Me.rbtPeriodo.Size = New System.Drawing.Size(16, 24)
        Me.rbtPeriodo.TabIndex = 122
        Me.rbtPeriodo.Text = "RadioButton1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Per�odo:"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(120, 16)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(216, 21)
        Me.cbPeriodo.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(120, 40)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(216, 23)
        Me.cbMes.TabIndex = 119
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.cbMonedaCambio})
        Me.GroupBox7.Location = New System.Drawing.Point(32, 104)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(736, 56)
        Me.GroupBox7.TabIndex = 127
        Me.GroupBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
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
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.cbAfiscal2, Me.Label44, Me.cbAfiscal})
        Me.GroupBox2.Location = New System.Drawing.Point(32, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 64)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(352, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 24)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "vs"
        '
        'cbAfiscal2
        '
        Me.cbAfiscal2.Location = New System.Drawing.Point(392, 24)
        Me.cbAfiscal2.Name = "cbAfiscal2"
        Me.cbAfiscal2.Size = New System.Drawing.Size(216, 21)
        Me.cbAfiscal2.TabIndex = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.cbEmpleados, Me.Label2, Me.cbDepartamento})
        Me.GroupBox3.Location = New System.Drawing.Point(32, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 96)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Empleado:"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Location = New System.Drawing.Point(120, 56)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(416, 21)
        Me.cbEmpleados.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Departamento:"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.Location = New System.Drawing.Point(120, 24)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(216, 21)
        Me.cbDepartamento.TabIndex = 123
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(384, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "vs"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label10, Me.rbtAfiscal2, Me.rbtMes2, Me.rbtPeriodo2, Me.Label11, Me.cbperiodo2, Me.Label12, Me.cbMes2})
        Me.GroupBox4.Location = New System.Drawing.Point(424, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 96)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 24)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "A�o Fiscal"
        '
        'rbtAfiscal2
        '
        Me.rbtAfiscal2.Enabled = False
        Me.rbtAfiscal2.Location = New System.Drawing.Point(16, 64)
        Me.rbtAfiscal2.Name = "rbtAfiscal2"
        Me.rbtAfiscal2.Size = New System.Drawing.Size(16, 24)
        Me.rbtAfiscal2.TabIndex = 124
        Me.rbtAfiscal2.Text = "RadioButton2"
        '
        'rbtMes2
        '
        Me.rbtMes2.Enabled = False
        Me.rbtMes2.Location = New System.Drawing.Point(16, 40)
        Me.rbtMes2.Name = "rbtMes2"
        Me.rbtMes2.Size = New System.Drawing.Size(16, 24)
        Me.rbtMes2.TabIndex = 123
        Me.rbtMes2.Text = "RadioButton2"
        '
        'rbtPeriodo2
        '
        Me.rbtPeriodo2.Enabled = False
        Me.rbtPeriodo2.Location = New System.Drawing.Point(16, 16)
        Me.rbtPeriodo2.Name = "rbtPeriodo2"
        Me.rbtPeriodo2.Size = New System.Drawing.Size(16, 24)
        Me.rbtPeriodo2.TabIndex = 122
        Me.rbtPeriodo2.Text = "RadioButton1"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Per�odo:"
        '
        'cbperiodo2
        '
        Me.cbperiodo2.Location = New System.Drawing.Point(120, 16)
        Me.cbperiodo2.Name = "cbperiodo2"
        Me.cbperiodo2.Size = New System.Drawing.Size(216, 21)
        Me.cbperiodo2.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Mes:"
        '
        'cbMes2
        '
        Me.cbMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes2.Location = New System.Drawing.Point(120, 40)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Size = New System.Drawing.Size(216, 23)
        Me.cbMes2.TabIndex = 119
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbDetallado, Me.Label6, Me.cbRubro})
        Me.GroupBox5.Location = New System.Drawing.Point(32, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(736, 80)
        Me.GroupBox5.TabIndex = 130
        Me.GroupBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Rubro:"
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(120, 32)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(216, 21)
        Me.cbRubro.TabIndex = 122
        '
        'rbDetallado
        '
        Me.rbDetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbDetallado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbDetallado.Location = New System.Drawing.Point(400, 32)
        Me.rbDetallado.Name = "rbDetallado"
        Me.rbDetallado.Size = New System.Drawing.Size(152, 24)
        Me.rbDetallado.TabIndex = 130
        Me.rbDetallado.Text = "Detallado"
        '
        'frmRptPlanillaComparativo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(912, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox5, Me.GroupBox2, Me.GroupBox7, Me.GBMes, Me.GroupBox1, Me.etDescripcion, Me.GroupBox3, Me.Label9, Me.GroupBox4})
        Me.Name = "frmRptPlanillaComparativo"
        Me.Text = "Comparativo de Planillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet
    Dim tabla As DataTable
    Dim dplanilla As New VB.SysContab.PlanillaDDB()
    'Dim PeriodoNomina As New VB.SysContab.PeriodoNominaDB()
    Dim D As New VB.SysContab.DepartamentosDB()
    Dim emp As New VB.SysContab.EmpleadosDB()
    Dim Periodo, Periodo2 As String, TPeriodo, TPeriodo2 As String
    Dim fReportes As New frmReportes()

    Private Sub frmVerPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        Me.cbMonedaCambio.ValueMember = "MonedaCambio"
        Me.cbMonedaCambio.DisplayMember = "Nombre"


        Me.cbAfiscal.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
        Me.cbAfiscal.ValueMember = "Per_ID"
        Me.cbAfiscal.DisplayMember = "Descripcion"

        Me.cbAfiscal2.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
        Me.cbAfiscal2.ValueMember = "Per_ID"
        Me.cbAfiscal2.DisplayMember = "Descripcion"

        Me.cbPeriodo.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
        Me.cbPeriodo.ValueMember = "Per_codigo"
        Me.cbPeriodo.DisplayMember = "Per_descripcion"

        Me.cbperiodo2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal2.SelectedValue).Tables("PeriodoNomina_Afiscal")
        Me.cbperiodo2.ValueMember = "Per_codigo"
        Me.cbperiodo2.DisplayMember = "Per_descripcion"

        Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
        Me.cbMes.ValueMember = "Mes"
        Me.cbMes.DisplayMember = "Descripcion"

        Me.cbMes2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal2.SelectedValue).Tables("Meses_Afiscal")
        Me.cbMes2.ValueMember = "Mes"
        Me.cbMes2.DisplayMember = "Descripcion"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListDepto("%").Tables("Empleados")
        Me.cbEmpleados.ValueMember = "Codigo"
        Me.cbEmpleados.DisplayMember = "Nombre"

        Me.cbDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        Me.cbDepartamento.ValueMember = "Codigo"
        Me.cbDepartamento.DisplayMember = "Nombre"

        Me.cbRubro.DataSource = VB.SysContab.PlanillaDB.Rubros_Planilla().Tables("Rubros")
        Me.cbRubro.ValueMember = "rub_codigo"
        Me.cbRubro.DisplayMember = "rub_descripcion"

        Me.rbtPeriodo.Checked = True
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub




    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cbAfiscal_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfiscal.SelectedValueChanged
        If IsNumeric(Me.cbAfiscal.SelectedValue) Or TypeName(Me.cbAfiscal.SelectedValue).ToLower = "string" Then
            Me.cbPeriodo.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbPeriodo.ValueMember = "Per_codigo"
            Me.cbPeriodo.DisplayMember = "Per_descripcion"

            Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes.ValueMember = "Mes"
            Me.cbMes.DisplayMember = "Descripcion"

         
            'Me.cbPeriodo.SelectedValue = Registro
        End If

        If IsNumeric(Me.cbAfiscal2.SelectedValue) Or TypeName(Me.cbAfiscal2.SelectedValue).ToLower = "string" Then

            Me.cbperiodo2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal2.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbperiodo2.ValueMember = "Per_codigo"
            Me.cbperiodo2.DisplayMember = "Per_descripcion"

            Me.cbMes2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal2.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes2.ValueMember = "Mes"
            Me.cbMes2.DisplayMember = "Descripcion"
            'Me.cbPeriodo.SelectedValue = Registro
        End If
    End Sub

    Private Sub cbAfiscal2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfiscal2.SelectedValueChanged

        If IsNumeric(Me.cbAfiscal2.SelectedValue) Or TypeName(Me.cbAfiscal2.SelectedValue).ToLower = "string" Then
            Me.cbperiodo2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal2.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbperiodo2.ValueMember = "Per_codigo"
            Me.cbperiodo2.DisplayMember = "Per_descripcion"

            Me.cbMes2.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal2.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes2.ValueMember = "Mes"
            Me.cbMes2.DisplayMember = "Descripcion"
            'Me.cbPeriodo.SelectedValue = Registro
        End If
    End Sub

    Private Sub rbtPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPeriodo.CheckedChanged

        Me.cbMes.Enabled = Not Me.rbtPeriodo.Checked
        Me.cbPeriodo.Enabled = Me.rbtPeriodo.Checked
        Me.cbMes2.Enabled = Not Me.rbtPeriodo.Checked
        Me.cbperiodo2.Enabled = Me.rbtPeriodo.Checked

        Me.cbMes.SelectedValue = IIf(Me.rbtPeriodo.Checked, "", Me.cbMes.SelectedValue)
        If IsNumeric(Me.cbPeriodo.SelectedValue) Then
            Me.cbPeriodo.SelectedValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.SelectedValue)
        End If

        '        Me.cbPeriodo.SelectedValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.SelectedValue)
        Me.cbMes2.SelectedValue = IIf(Me.rbtPeriodo.Checked, "", Me.cbMes.SelectedValue)
        If IsNumeric(Me.cbperiodo2.SelectedValue) Then
            Me.cbperiodo2.SelectedValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.SelectedValue)
        End If

        '       Me.cbperiodo2.SelectedValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.SelectedValue)

        Me.rbtPeriodo2.Checked = Me.rbtPeriodo.Checked

    End Sub



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Dim reporte As New rptPlanillaConsolidado_Comparativo()
        Dim reporte As New Object
        reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo.rpt")
            Exit Sub
        End If
        reporte.load(Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'Dim reporteD As New rptPlanillaConsolidado_Comparativo_Detallado()
        Dim reporteD As New Object
        reporteD = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo_Detallado.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo_Detallado.rpt")
            Exit Sub
        End If
        reporteD.load(Application.StartupPath & "\reportes\rptPlanillaConsolidado_Comparativo_Detallado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim DS1 As New DataSet(), DS2 As New DataSet()

        Periodo = Microsoft.VisualBasic.Right(Me.cbPeriodo.SelectedValue, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Me.cbPeriodo.SelectedValue, 1)

        Periodo2 = Microsoft.VisualBasic.Right(Me.cbperiodo2.SelectedValue, 8)
        TPeriodo2 = Microsoft.VisualBasic.Left(Me.cbperiodo2.SelectedValue, 1)

        If Me.cbPeriodo.SelectedValue = "" And Me.cbMes.SelectedValue = "" And Me.rbtAFiscal.Checked = False Then
            MsgBox("Seleccione el Mes o Periodo de Nomina a imprimir", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
            Exit Sub
        End If


        If Me.cbperiodo2.SelectedValue = "" And Me.cbMes2.SelectedValue = "" And Me.rbtAfiscal2.Checked = False Then
            MsgBox("Seleccione el Mes o Periodo de Nomina a comparar ", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If Me.rbDetallado.Checked Then
            ds = VB.SysContab.PlanillaDB.Consolidado_Comparativo_Detallado(Me.cbRubro.SelectedValue, _
                               Me.cbAfiscal.SelectedValue, _
                               IIf(Periodo = "", "%", Periodo), _
                               IIf(TPeriodo = "", "%", TPeriodo), _
                               IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), _
                               Me.cbMonedaCambio.SelectedValue, _
                               Me.cbDepartamento.SelectedValue, _
                               Me.cbEmpleados.SelectedValue, _
                               Me.cbAfiscal2.SelectedValue, _
                               IIf(Periodo2 = "", "%", Periodo2), _
                               IIf(TPeriodo2 = "", "%", TPeriodo2), _
                               IIf(Me.cbMes2.SelectedValue = "", "%", Me.cbMes2.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\exportfiles\CCD.xml", XmlWriteMode.WriteSchema)
            reporteD.Database.Tables(0).Location = Application.StartupPath & "\exportfiles\CCD.xml"
            fReportes.crvReportes.ReportSource = reporteD
        Else
            ds = VB.SysContab.PlanillaDB.Consolidado_Comparativo_Encabezado(Me.cbRubro.SelectedValue, _
                                Me.cbAfiscal.SelectedValue, _
                                IIf(Periodo = "", "%", Periodo), _
                                IIf(TPeriodo = "", "%", TPeriodo), _
                                IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), _
                                Me.cbMonedaCambio.SelectedValue, _
                                Me.cbDepartamento.SelectedValue, _
                                Me.cbEmpleados.SelectedValue, _
                                Me.cbAfiscal2.SelectedValue, _
                                IIf(Periodo2 = "", "%", Periodo2), _
                                IIf(TPeriodo2 = "", "%", TPeriodo2), _
                                IIf(Me.cbMes2.SelectedValue = "", "%", Me.cbMes2.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\exportfiles\CCE.xml", XmlWriteMode.WriteSchema)
            reporte.Database.Tables(0).Location = Application.StartupPath & "\exportfiles\CCE.xml"
            fReportes.crvReportes.ReportSource = reporte
        End If


        fReportes.ShowDialog()

    End Sub

    Private Sub cbDepartamento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.SelectedValueChanged
        If IsNumeric(Me.cbDepartamento.SelectedValue) Then
            Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListDepto(Me.cbDepartamento.SelectedValue).Tables("Empleados")
            Me.cbEmpleados.ValueMember = "Codigo"
            Me.cbEmpleados.DisplayMember = "Nombre"
        End If
    End Sub




    Private Sub rbtAFiscal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAFiscal.CheckedChanged

        Me.cbMes.Enabled = Not Me.rbtAFiscal.Checked
        Me.cbPeriodo.Enabled = Not Me.rbtAFiscal.Checked
        Me.cbMes2.Enabled = Not Me.rbtAFiscal.Checked
        Me.cbperiodo2.Enabled = Not Me.rbtAFiscal.Checked

        Me.cbMes.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbMes.SelectedValue)
        Me.cbPeriodo.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbPeriodo.SelectedValue)
        Me.cbMes2.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbMes.SelectedValue)
        Me.cbperiodo2.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbPeriodo.SelectedValue)

        Me.rbtAfiscal2.Checked = Me.rbtAFiscal.Checked
    End Sub

    Private Sub rbtMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMes.CheckedChanged

        Me.cbMes.Enabled = Me.rbtMes.Checked
        Me.cbPeriodo.Enabled = Not Me.rbtMes.Checked
        Me.cbMes2.Enabled = Me.rbtMes.Checked
        Me.cbperiodo2.Enabled = Not Me.rbtMes.Checked

        Me.cbMes.SelectedValue = IIf(Me.rbtMes.Checked, "", Me.cbMes.SelectedValue)
        Me.cbPeriodo.SelectedValue = IIf(Not Me.rbtMes.Checked, "", Me.cbPeriodo.SelectedValue)
        Me.cbMes2.SelectedValue = IIf(Me.rbtMes.Checked, "", Me.cbMes.SelectedValue)
        Me.cbperiodo2.SelectedValue = IIf(Not Me.rbtMes.Checked, "", Me.cbPeriodo.SelectedValue)

        Me.rbtMes2.Checked = Me.rbtMes.Checked

    End Sub



End Class
