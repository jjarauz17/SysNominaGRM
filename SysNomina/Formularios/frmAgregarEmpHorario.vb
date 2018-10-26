Imports System.IO

Public Class frmAgregarEmpHorario
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarEmpHorario = Nothing

    Public Shared Function Instance() As frmAgregarEmpHorario
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarEmpHorario()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim HNuevo As String
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox
    Friend WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents CBHorario As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CBDomingo As System.Windows.Forms.ComboBox
    Friend WithEvents CBLunes As System.Windows.Forms.ComboBox
    Friend WithEvents CBMartes As System.Windows.Forms.ComboBox
    Friend WithEvents CBMiercoles As System.Windows.Forms.ComboBox
    Friend WithEvents CBJueves As System.Windows.Forms.ComboBox
    Friend WithEvents CBViernes As System.Windows.Forms.ComboBox
    Friend WithEvents CBSabado As System.Windows.Forms.ComboBox
    Friend WithEvents DTPEntDomingo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalDomingo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntLunes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalLunes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntMartes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalMartes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntMiercoles As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalMiercoles As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntJueves As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalJueves As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntViernes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalViernes As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEntSabado As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSalSabado As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CBHorario = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CBSabado = New System.Windows.Forms.ComboBox()
        Me.DTPEntSabado = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalSabado = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CBViernes = New System.Windows.Forms.ComboBox()
        Me.DTPEntViernes = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalViernes = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBJueves = New System.Windows.Forms.ComboBox()
        Me.DTPEntJueves = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalJueves = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBMiercoles = New System.Windows.Forms.ComboBox()
        Me.DTPEntMiercoles = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalMiercoles = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBMartes = New System.Windows.Forms.ComboBox()
        Me.DTPEntMartes = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalMartes = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBLunes = New System.Windows.Forms.ComboBox()
        Me.DTPEntLunes = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalLunes = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBDomingo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPEntDomingo = New System.Windows.Forms.DateTimePicker()
        Me.DTPSalDomingo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.etDescripcion})
        Me.GroupBox7.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(656, 32)
        Me.GroupBox7.TabIndex = 122
        Me.GroupBox7.TabStop = False
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(0, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(656, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 48)
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.txtNombre, Me.Label1, Me.txtCodigo})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(656, 72)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS GENERALES"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Yellow
        Me.txtNombre.Location = New System.Drawing.Point(88, 40)
        Me.txtNombre.MaxLength = 80
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(552, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Yellow
        Me.txtCodigo.Location = New System.Drawing.Point(88, 16)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.CBHorario, Me.Label42, Me.Label19, Me.Label14, Me.dtpHoraEntrada, Me.dtpHoraSalida, Me.txtTotalHoras, Me.Label20})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(16, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(656, 80)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "HORARIO"
        '
        'CBHorario
        '
        Me.CBHorario.Enabled = False
        Me.CBHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHorario.ImeMode = System.Windows.Forms.ImeMode.On
        Me.CBHorario.ItemHeight = 15
        Me.CBHorario.Location = New System.Drawing.Point(80, 24)
        Me.CBHorario.Name = "CBHorario"
        Me.CBHorario.Size = New System.Drawing.Size(108, 23)
        Me.CBHorario.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label42.Location = New System.Drawing.Point(8, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 24)
        Me.Label42.TabIndex = 76
        Me.Label42.Text = "Horario:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label19.Location = New System.Drawing.Point(240, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 24)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Salida:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Entrada:"
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Checked = False
        Me.dtpHoraEntrada.Enabled = False
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.ImeMode = System.Windows.Forms.ImeMode.On
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(80, 48)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(108, 21)
        Me.dtpHoraEntrada.TabIndex = 21
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Enabled = False
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.ImeMode = System.Windows.Forms.ImeMode.On
        Me.dtpHoraSalida.Location = New System.Drawing.Point(304, 48)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(108, 21)
        Me.dtpHoraSalida.TabIndex = 22
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Enabled = False
        Me.txtTotalHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoras.Location = New System.Drawing.Point(304, 24)
        Me.txtTotalHoras.MaxLength = 10
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.ReadOnly = True
        Me.txtTotalHoras.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalHoras.TabIndex = 23
        Me.txtTotalHoras.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label20.Enabled = False
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label20.Location = New System.Drawing.Point(240, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 24)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Horas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCancelar, Me.cmdAceptar})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(680, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 432)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label24, Me.CBSabado, Me.DTPEntSabado, Me.DTPSalSabado, Me.Label21, Me.CBViernes, Me.DTPEntViernes, Me.DTPSalViernes, Me.Label16, Me.CBJueves, Me.DTPEntJueves, Me.DTPSalJueves, Me.Label12, Me.CBMiercoles, Me.DTPEntMiercoles, Me.DTPSalMiercoles, Me.Label9, Me.CBMartes, Me.DTPEntMartes, Me.DTPSalMartes, Me.Label2, Me.CBLunes, Me.DTPEntLunes, Me.DTPSalLunes, Me.Label6, Me.CBDomingo, Me.Label3, Me.Label5, Me.DTPEntDomingo, Me.DTPSalDomingo})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 240)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario Semanal"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 192)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 24)
        Me.Label24.TabIndex = 113
        Me.Label24.Text = "Sábado:"
        '
        'CBSabado
        '
        Me.CBSabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSabado.ItemHeight = 15
        Me.CBSabado.Location = New System.Drawing.Point(88, 192)
        Me.CBSabado.Name = "CBSabado"
        Me.CBSabado.Size = New System.Drawing.Size(136, 23)
        Me.CBSabado.TabIndex = 108
        '
        'DTPEntSabado
        '
        Me.DTPEntSabado.Checked = False
        Me.DTPEntSabado.Enabled = False
        Me.DTPEntSabado.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntSabado.Location = New System.Drawing.Point(256, 192)
        Me.DTPEntSabado.Name = "DTPEntSabado"
        Me.DTPEntSabado.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntSabado.TabIndex = 109
        '
        'DTPSalSabado
        '
        Me.DTPSalSabado.Enabled = False
        Me.DTPSalSabado.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalSabado.Location = New System.Drawing.Point(400, 192)
        Me.DTPSalSabado.Name = "DTPSalSabado"
        Me.DTPSalSabado.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalSabado.TabIndex = 110
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 24)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Viernes:"
        '
        'CBViernes
        '
        Me.CBViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBViernes.ItemHeight = 15
        Me.CBViernes.Location = New System.Drawing.Point(88, 168)
        Me.CBViernes.Name = "CBViernes"
        Me.CBViernes.Size = New System.Drawing.Size(136, 23)
        Me.CBViernes.TabIndex = 102
        '
        'DTPEntViernes
        '
        Me.DTPEntViernes.Checked = False
        Me.DTPEntViernes.Enabled = False
        Me.DTPEntViernes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntViernes.Location = New System.Drawing.Point(256, 168)
        Me.DTPEntViernes.Name = "DTPEntViernes"
        Me.DTPEntViernes.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntViernes.TabIndex = 103
        '
        'DTPSalViernes
        '
        Me.DTPSalViernes.Enabled = False
        Me.DTPSalViernes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalViernes.Location = New System.Drawing.Point(400, 168)
        Me.DTPSalViernes.Name = "DTPSalViernes"
        Me.DTPSalViernes.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalViernes.TabIndex = 104
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 24)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "Jueves:"
        '
        'CBJueves
        '
        Me.CBJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBJueves.ItemHeight = 15
        Me.CBJueves.Location = New System.Drawing.Point(88, 144)
        Me.CBJueves.Name = "CBJueves"
        Me.CBJueves.Size = New System.Drawing.Size(136, 23)
        Me.CBJueves.TabIndex = 96
        '
        'DTPEntJueves
        '
        Me.DTPEntJueves.Checked = False
        Me.DTPEntJueves.Enabled = False
        Me.DTPEntJueves.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntJueves.Location = New System.Drawing.Point(256, 144)
        Me.DTPEntJueves.Name = "DTPEntJueves"
        Me.DTPEntJueves.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntJueves.TabIndex = 97
        '
        'DTPSalJueves
        '
        Me.DTPSalJueves.Enabled = False
        Me.DTPSalJueves.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalJueves.Location = New System.Drawing.Point(400, 144)
        Me.DTPSalJueves.Name = "DTPSalJueves"
        Me.DTPSalJueves.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalJueves.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 24)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Miércoles:"
        '
        'CBMiercoles
        '
        Me.CBMiercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMiercoles.ItemHeight = 15
        Me.CBMiercoles.Location = New System.Drawing.Point(88, 120)
        Me.CBMiercoles.Name = "CBMiercoles"
        Me.CBMiercoles.Size = New System.Drawing.Size(136, 23)
        Me.CBMiercoles.TabIndex = 90
        '
        'DTPEntMiercoles
        '
        Me.DTPEntMiercoles.Checked = False
        Me.DTPEntMiercoles.Enabled = False
        Me.DTPEntMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntMiercoles.Location = New System.Drawing.Point(256, 120)
        Me.DTPEntMiercoles.Name = "DTPEntMiercoles"
        Me.DTPEntMiercoles.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntMiercoles.TabIndex = 91
        '
        'DTPSalMiercoles
        '
        Me.DTPSalMiercoles.Enabled = False
        Me.DTPSalMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalMiercoles.Location = New System.Drawing.Point(400, 120)
        Me.DTPSalMiercoles.Name = "DTPSalMiercoles"
        Me.DTPSalMiercoles.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalMiercoles.TabIndex = 92
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Martes:"
        '
        'CBMartes
        '
        Me.CBMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMartes.ItemHeight = 15
        Me.CBMartes.Location = New System.Drawing.Point(88, 96)
        Me.CBMartes.Name = "CBMartes"
        Me.CBMartes.Size = New System.Drawing.Size(136, 23)
        Me.CBMartes.TabIndex = 84
        '
        'DTPEntMartes
        '
        Me.DTPEntMartes.Checked = False
        Me.DTPEntMartes.Enabled = False
        Me.DTPEntMartes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntMartes.Location = New System.Drawing.Point(256, 96)
        Me.DTPEntMartes.Name = "DTPEntMartes"
        Me.DTPEntMartes.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntMartes.TabIndex = 85
        '
        'DTPSalMartes
        '
        Me.DTPSalMartes.Enabled = False
        Me.DTPSalMartes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalMartes.Location = New System.Drawing.Point(400, 96)
        Me.DTPSalMartes.Name = "DTPSalMartes"
        Me.DTPSalMartes.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalMartes.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Lunes:"
        '
        'CBLunes
        '
        Me.CBLunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLunes.ItemHeight = 15
        Me.CBLunes.Location = New System.Drawing.Point(88, 72)
        Me.CBLunes.Name = "CBLunes"
        Me.CBLunes.Size = New System.Drawing.Size(136, 23)
        Me.CBLunes.TabIndex = 78
        '
        'DTPEntLunes
        '
        Me.DTPEntLunes.Checked = False
        Me.DTPEntLunes.Enabled = False
        Me.DTPEntLunes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntLunes.Location = New System.Drawing.Point(256, 72)
        Me.DTPEntLunes.Name = "DTPEntLunes"
        Me.DTPEntLunes.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntLunes.TabIndex = 79
        '
        'DTPSalLunes
        '
        Me.DTPSalLunes.Enabled = False
        Me.DTPSalLunes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalLunes.Location = New System.Drawing.Point(400, 72)
        Me.DTPSalLunes.Name = "DTPSalLunes"
        Me.DTPSalLunes.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalLunes.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Domingo:"
        '
        'CBDomingo
        '
        Me.CBDomingo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDomingo.ItemHeight = 15
        Me.CBDomingo.Location = New System.Drawing.Point(88, 48)
        Me.CBDomingo.Name = "CBDomingo"
        Me.CBDomingo.Size = New System.Drawing.Size(136, 23)
        Me.CBDomingo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Salida:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Entrada:"
        '
        'DTPEntDomingo
        '
        Me.DTPEntDomingo.Checked = False
        Me.DTPEntDomingo.Enabled = False
        Me.DTPEntDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEntDomingo.Location = New System.Drawing.Point(256, 48)
        Me.DTPEntDomingo.Name = "DTPEntDomingo"
        Me.DTPEntDomingo.Size = New System.Drawing.Size(112, 21)
        Me.DTPEntDomingo.TabIndex = 21
        '
        'DTPSalDomingo
        '
        Me.DTPSalDomingo.Enabled = False
        Me.DTPSalDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPSalDomingo.Location = New System.Drawing.Point(400, 48)
        Me.DTPSalDomingo.Name = "DTPSalDomingo"
        Me.DTPSalDomingo.Size = New System.Drawing.Size(108, 21)
        Me.DTPSalDomingo.TabIndex = 22
        '
        'frmAgregarEmpHorario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(808, 462)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.GroupBox3, Me.GroupBox2, Me.GroupBox4, Me.GroupBox7})
        Me.Name = "frmAgregarEmpHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarEmpHorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim h As New VB.SysContab.HorarioDB()
        Dim Empleados As New VB.SysContab.EmpleadosDB()
        Dim detHorario As New VB.SysContab.HorarioDetails()

        Dim EmpHorario As New VB.SysContab.EmpHorarioDB()


        Dim r As New VB.SysContab.RutinasNomina()



        Me.etDescripcion.Text = "Editar Horario Semanal".ToUpper
        Me.Text = "Editar Horario Semanal"

        CBHorario.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        CBHorario.ValueMember = "Codigo"
        CBHorario.DisplayMember = "Descripcion"

        Dim Detalles As VB.SysContab.EmpleadosDetails = VB.SysContab.EmpleadosDB.GetDetails(Registro)
        Dim DetallesEmpHorario As VB.SysContab.EmpHorarioDetails = EmpHorario.GetDetails(Registro)

        Me.txtCodigo.Text = Detalles.Codigo
        Me.txtNombre.Text = Detalles.PNombre + " " + Detalles.SNombre + " " + Detalles.PApellido + " " + Detalles.SApellido

        Me.CBHorario.SelectedValue = Detalles.Horario

        detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)

        Me.dtpHoraEntrada.Value = detHorario.entrada
        Me.dtpHoraSalida.Value = detHorario.salida

        Me.CBDomingo.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBDomingo.ValueMember = "Codigo"
        Me.CBDomingo.DisplayMember = "Descripcion"

        Me.CBLunes.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBLunes.ValueMember = "Codigo"
        Me.CBLunes.DisplayMember = "Descripcion"

        Me.CBMartes.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBMartes.ValueMember = "Codigo"
        Me.CBMartes.DisplayMember = "Descripcion"

        Me.CBMiercoles.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBMiercoles.ValueMember = "Codigo"
        Me.CBMiercoles.DisplayMember = "Descripcion"

        Me.CBJueves.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBJueves.ValueMember = "Codigo"
        Me.CBJueves.DisplayMember = "Descripcion"

        Me.CBViernes.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBViernes.ValueMember = "Codigo"
        Me.CBViernes.DisplayMember = "Descripcion"

        Me.CBSabado.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        Me.CBSabado.ValueMember = "Codigo"
        Me.CBSabado.DisplayMember = "Descripcion"

        If DetallesEmpHorario.Empleado = Nothing Then
            HNuevo = "S"
            'Domingo
            Me.CBDomingo.SelectedValue = "000" 'Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails("000")
            Me.DTPEntDomingo.Visible = False
            Me.DTPSalDomingo.Visible = False
            'Lunes
            Me.CBLunes.SelectedValue = Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)
            Me.DTPEntLunes.Value = detHorario.entrada
            Me.DTPSalLunes.Value = detHorario.salida
            'Martes
            Me.CBMartes.SelectedValue = Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)
            Me.DTPEntMartes.Value = detHorario.entrada
            Me.DTPSalMartes.Value = detHorario.salida
            'Miercoles
            Me.CBMiercoles.SelectedValue = Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)
            Me.DTPEntMiercoles.Value = detHorario.entrada
            Me.DTPSalMiercoles.Value = detHorario.salida
            'Jueves
            Me.CBJueves.SelectedValue = Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)
            Me.DTPEntJueves.Value = detHorario.entrada
            Me.DTPSalJueves.Value = detHorario.salida
            'Viernes
            Me.CBViernes.SelectedValue = Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails(Detalles.Horario)
            Me.DTPEntViernes.Value = detHorario.entrada
            Me.DTPSalViernes.Value = detHorario.salida
            'Sabado
            Me.CBSabado.SelectedValue = "000" 'Detalles.Horario
            detHorario = VB.SysContab.HorarioDB.GetDetails("000")
            Me.DTPEntSabado.Visible = False
            Me.DTPSalSabado.Visible = False

        Else
            HNuevo = "N"
            ' El empleado tiene asignado un horario semanal
            'Domingo
            Me.CBDomingo.SelectedValue = DetallesEmpHorario.Domingo
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Domingo)
            Me.DTPEntDomingo.Value = detHorario.entrada
            Me.DTPSalDomingo.Value = detHorario.salida
            'If CBDomingo.SelectedValue <> "000" Then
            'Me.DTPEntDomingo.Visible = True
            'Me.DTPSalDomingo.Visible = True
            'Else
            '    Me.DTPEntDomingo.Visible = False
            '    Me.DTPSalDomingo.Visible = False
            'End If
            'Lunes
            Me.CBLunes.SelectedValue = DetallesEmpHorario.Lunes
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Lunes)
            Me.DTPEntLunes.Value = detHorario.entrada
            Me.DTPSalLunes.Value = detHorario.salida
            'If CBLunes.SelectedValue <> "000" Then
            'Me.DTPEntLunes.Visible = True
            'Me.DTPSalLunes.Visible = True
            'Else
            '    Me.DTPEntLunes.Visible = False
            '    Me.DTPSalLunes.Visible = False
            'End If
            'Martes
            Me.CBMartes.SelectedValue = DetallesEmpHorario.Martes
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Martes)
            Me.DTPEntMartes.Value = detHorario.entrada
            Me.DTPSalMartes.Value = detHorario.salida
            'If CBMartes.SelectedValue <> "000" Then
            'Me.DTPEntMartes.Visible = True
            'Me.DTPSalMartes.Visible = True
            'Else
            '    Me.DTPEntMartes.Visible = False
            '    Me.DTPSalMartes.Visible = False
            'End If
            'Miercoles
            Me.CBMiercoles.SelectedValue = DetallesEmpHorario.Miercoles
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Miercoles)
            Me.DTPEntMiercoles.Value = detHorario.entrada
            Me.DTPSalMiercoles.Value = detHorario.salida
            'If CBMiercoles.SelectedValue <> "000" Then
            'Me.DTPEntMiercoles.Visible = True
            'Me.DTPSalMiercoles.Visible = True
            'Else
            '    Me.DTPEntMiercoles.Visible = False
            '    Me.DTPSalMiercoles.Visible = False
            'End If
            'Jueves
            Me.CBJueves.SelectedValue = DetallesEmpHorario.Jueves
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Jueves)
            Me.DTPEntJueves.Value = detHorario.entrada
            Me.DTPSalJueves.Value = detHorario.salida
            'If CBJueves.SelectedValue <> "000" Then
            'Me.DTPEntJueves.Visible = True
            'Me.DTPSalJueves.Visible = True
            'Else
            '    Me.DTPEntJueves.Visible = False
            '    Me.DTPSalJueves.Visible = False
            'End If
            'Viernes
            Me.CBViernes.SelectedValue = DetallesEmpHorario.Viernes
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Viernes)
            Me.DTPEntViernes.Value = detHorario.entrada
            Me.DTPSalViernes.Value = detHorario.salida
            'If CBViernes.SelectedValue <> "000" Then
            'Me.DTPEntViernes.Visible = True
            'Me.DTPSalViernes.Visible = True
            'Else
            '    Me.DTPEntViernes.Visible = False
            '    Me.DTPSalViernes.Visible = False
            'End If
            'Sabado
            Me.CBSabado.SelectedValue = DetallesEmpHorario.Sabado
            detHorario = VB.SysContab.HorarioDB.GetDetails(DetallesEmpHorario.Sabado)
            Me.DTPEntSabado.Value = detHorario.entrada
            Me.DTPSalSabado.Value = detHorario.salida
            'If CBSabado.SelectedValue <> "000" Then
            'Me.DTPEntSabado.Visible = True
            'Me.DTPSalSabado.Visible = True
            'Else
            '    Me.DTPEntSabado.Visible = False
            '    Me.DTPSalSabado.Visible = False
            'End If

        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim EmpHorario As New VB.SysContab.EmpHorarioDB()
        Dim r As New VB.SysContab.RutinasNomina()

        If HNuevo = "S" Then
            EmpHorario.AddItem(Me.txtCodigo.Text, Me.CBDomingo.SelectedValue, Me.CBLunes.SelectedValue, Me.CBMartes.SelectedValue, _
                    Me.CBMiercoles.SelectedValue, Me.CBJueves.SelectedValue, Me.CBViernes.SelectedValue, Me.CBSabado.SelectedValue)
            MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            VB.SysContab.RutinasNomina.LimpiarControles(GroupBox1)
            VB.SysContab.RutinasNomina.LimpiarControles(GroupBox3)
            VB.SysContab.RutinasNomina.LimpiarControles(GroupBox4)
        Else
            EmpHorario.Update(Me.txtCodigo.Text, Me.CBDomingo.SelectedValue, Me.CBLunes.SelectedValue, Me.CBMartes.SelectedValue, _
                    Me.CBMiercoles.SelectedValue, Me.CBJueves.SelectedValue, Me.CBViernes.SelectedValue, Me.CBSabado.SelectedValue)
            MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub



End Class
