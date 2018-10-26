Imports System.IO
Public Class frmReportesEmpleados
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmReportesEmpleados = Nothing

    Public Shared Function Instance() As frmReportesEmpleados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesEmpleados()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    'Dim rEmpleados As New rptEmpleados()
    Dim rEmpleados As Object
    Friend WithEvents rbConstancia As System.Windows.Forms.RadioButton
    Friend WithEvents txtGerenteRecursosHumanos As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    'Dim rEmpleadosUbicacion As New rptEmpleadosUbicacion()
    Dim rEmpleadosUbicacion As Object

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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlfabetico As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCargos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFunciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbContrato As System.Windows.Forms.RadioButton
    Friend WithEvents rbFijos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents rbRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents cbProfesion As System.Windows.Forms.ComboBox
    Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUbicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbGenerales As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbCodigo = New System.Windows.Forms.RadioButton
        Me.rbAlfabetico = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbEmpleados = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbProfesion = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbNivel = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCargos = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbFunciones = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbRegistro = New System.Windows.Forms.RadioButton
        Me.rbContrato = New System.Windows.Forms.RadioButton
        Me.rbFijos = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbArchivo = New System.Windows.Forms.RadioButton
        Me.rbImpresora = New System.Windows.Forms.RadioButton
        Me.rbPantalla = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtGerenteRecursosHumanos = New System.Windows.Forms.TextBox
        Me.rbConstancia = New System.Windows.Forms.RadioButton
        Me.rbUbicacion = New System.Windows.Forms.RadioButton
        Me.rbGenerales = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.rbCodigo)
        Me.GroupBox6.Controls.Add(Me.rbAlfabetico)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(434, 296)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 152)
        Me.GroupBox6.TabIndex = 151
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ORDEN"
        '
        'rbCodigo
        '
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 64)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 32)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.Text = "Código"
        '
        'rbAlfabetico
        '
        Me.rbAlfabetico.Checked = True
        Me.rbAlfabetico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlfabetico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAlfabetico.Location = New System.Drawing.Point(16, 24)
        Me.rbAlfabetico.Name = "rbAlfabetico"
        Me.rbAlfabetico.Size = New System.Drawing.Size(112, 32)
        Me.rbAlfabetico.TabIndex = 0
        Me.rbAlfabetico.TabStop = True
        Me.rbAlfabetico.Text = "Alfabético"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cbEmpleados)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cbProfesion)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cbNivel)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cbCargos)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cbFunciones)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbDepartamentos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(256, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 264)
        Me.GroupBox4.TabIndex = 150
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Empleado"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleados.Location = New System.Drawing.Point(136, 24)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(304, 23)
        Me.cbEmpleados.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Profesión"
        '
        'cbProfesion
        '
        Me.cbProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProfesion.Location = New System.Drawing.Point(136, 224)
        Me.cbProfesion.Name = "cbProfesion"
        Me.cbProfesion.Size = New System.Drawing.Size(304, 23)
        Me.cbProfesion.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Nivel Académico"
        '
        'cbNivel
        '
        Me.cbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNivel.Location = New System.Drawing.Point(136, 184)
        Me.cbNivel.Name = "cbNivel"
        Me.cbNivel.Size = New System.Drawing.Size(304, 23)
        Me.cbNivel.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Cargo"
        '
        'cbCargos
        '
        Me.cbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargos.Location = New System.Drawing.Point(136, 104)
        Me.cbCargos.Name = "cbCargos"
        Me.cbCargos.Size = New System.Drawing.Size(304, 23)
        Me.cbCargos.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Función"
        '
        'cbFunciones
        '
        Me.cbFunciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFunciones.Location = New System.Drawing.Point(136, 144)
        Me.cbFunciones.Name = "cbFunciones"
        Me.cbFunciones.Size = New System.Drawing.Size(304, 23)
        Me.cbFunciones.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Departamento"
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Location = New System.Drawing.Point(136, 64)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Size = New System.Drawing.Size(304, 23)
        Me.cbDepartamentos.TabIndex = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 472)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 40)
        Me.GroupBox3.TabIndex = 149
        Me.GroupBox3.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(104, 10)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.rbRegistro)
        Me.GroupBox2.Controls.Add(Me.rbContrato)
        Me.GroupBox2.Controls.Add(Me.rbFijos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 152)
        Me.GroupBox2.TabIndex = 148
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ORIGEN"
        '
        'rbRegistro
        '
        Me.rbRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbRegistro.Location = New System.Drawing.Point(16, 104)
        Me.rbRegistro.Name = "rbRegistro"
        Me.rbRegistro.Size = New System.Drawing.Size(112, 32)
        Me.rbRegistro.TabIndex = 139
        Me.rbRegistro.Text = "Registro"
        '
        'rbContrato
        '
        Me.rbContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbContrato.Location = New System.Drawing.Point(16, 64)
        Me.rbContrato.Name = "rbContrato"
        Me.rbContrato.Size = New System.Drawing.Size(112, 32)
        Me.rbContrato.TabIndex = 3
        Me.rbContrato.Text = "Contrato"
        '
        'rbFijos
        '
        Me.rbFijos.Checked = True
        Me.rbFijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFijos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbFijos.Location = New System.Drawing.Point(16, 24)
        Me.rbFijos.Name = "rbFijos"
        Me.rbFijos.Size = New System.Drawing.Size(112, 32)
        Me.rbFijos.TabIndex = 0
        Me.rbFijos.TabStop = True
        Me.rbFijos.Text = "Fijos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(576, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 152)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbArchivo.Location = New System.Drawing.Point(16, 104)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(112, 32)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbImpresora.Location = New System.Drawing.Point(16, 64)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(112, 32)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 24)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(112, 32)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.txtGerenteRecursosHumanos)
        Me.GroupBox5.Controls.Add(Me.rbConstancia)
        Me.GroupBox5.Controls.Add(Me.rbUbicacion)
        Me.GroupBox5.Controls.Add(Me.rbGenerales)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(24, 176)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(224, 176)
        Me.GroupBox5.TabIndex = 152
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TIPO DE REPORTE"
        '
        'txtGerenteRecursosHumanos
        '
        Me.txtGerenteRecursosHumanos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGerenteRecursosHumanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerenteRecursosHumanos.Location = New System.Drawing.Point(30, 140)
        Me.txtGerenteRecursosHumanos.Name = "txtGerenteRecursosHumanos"
        Me.txtGerenteRecursosHumanos.Size = New System.Drawing.Size(179, 20)
        Me.txtGerenteRecursosHumanos.TabIndex = 153
        Me.txtGerenteRecursosHumanos.Visible = False
        '
        'rbConstancia
        '
        Me.rbConstancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConstancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbConstancia.Location = New System.Drawing.Point(16, 102)
        Me.rbConstancia.Name = "rbConstancia"
        Me.rbConstancia.Size = New System.Drawing.Size(176, 32)
        Me.rbConstancia.TabIndex = 4
        Me.rbConstancia.Text = "Constancia Salarial"
        Me.rbConstancia.Visible = False
        '
        'rbUbicacion
        '
        Me.rbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUbicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbUbicacion.Location = New System.Drawing.Point(16, 64)
        Me.rbUbicacion.Name = "rbUbicacion"
        Me.rbUbicacion.Size = New System.Drawing.Size(112, 32)
        Me.rbUbicacion.TabIndex = 3
        Me.rbUbicacion.Text = "Ubicación"
        '
        'rbGenerales
        '
        Me.rbGenerales.Checked = True
        Me.rbGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGenerales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbGenerales.Location = New System.Drawing.Point(16, 24)
        Me.rbGenerales.Name = "rbGenerales"
        Me.rbGenerales.Size = New System.Drawing.Size(176, 32)
        Me.rbGenerales.TabIndex = 0
        Me.rbGenerales.TabStop = True
        Me.rbGenerales.Text = "Datos Generales"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "Aceptar"
        Me.Button1.Visible = False
        '
        'frmReportesEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 550)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesEmpleados"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Empleado As New VB.SysContab.EmpleadosDB()
        Dim Departamento As New VB.SysContab.DepartamentosDB()
        Dim Cargo As New VB.SysContab.CargosDB()
        Dim r As New VB.SysContab.RutinasNomina()

        rEmpleados = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptEmpleados.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptEmpleados.rpt")
            Exit Sub
        End If

        rEmpleados.load(Application.StartupPath & "\reportes\rptEmpleados.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        rEmpleadosUbicacion = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptEmpleadosUbicacion.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptEmpleadosUbicacion.rpt")
            Exit Sub
        End If

        rEmpleadosUbicacion.load(Application.StartupPath & "\reportes\rptEmpleadosUbicacion.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'rEmpleados.Load()
        'rEmpleadosUbicacion.Load()



        cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEmpleados.ValueMember = "Codigo"
        cbEmpleados.DisplayMember = "Nombre"
        cbEmpleados.SelectedValue = 0

        cbDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("DEPARTAMENTOS")
        cbDepartamentos.ValueMember = "Codigo"
        cbDepartamentos.DisplayMember = "Nombre"
        cbDepartamentos.SelectedValue = -1

        cbCargos.DataSource = VB.SysContab.CargosDB.GetListBuscarCombo("%").Tables("CARGOS")
        cbCargos.ValueMember = "Codigo"
        cbCargos.DisplayMember = "Nombre"
        cbCargos.SelectedValue = 0

        cbFunciones.DataSource = VB.SysContab.FuncionesDB.GetListBuscarCombo("%").Tables("FUNCIONES")
        cbFunciones.ValueMember = "Codigo"
        cbFunciones.DisplayMember = "Nombre"
        cbFunciones.SelectedValue = 0
        '      
        Me.Refresh()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()
        Dim Tipo As String
        Dim Ordenar As String = ""

        If rbFijos.Checked = True Then
            Tipo = "F"
        ElseIf rbContrato.Checked = True Then
            Tipo = "C"
        Else
            Tipo = "R"
        End If

        If rbAlfabetico.Checked = True Then
            Ordenar = "2"
        ElseIf rbCodigo.Checked = True Then
            Ordenar = "1"

        End If

        'rEmpleados.SetDataSource(Empleados.GeneradorReportes(1, 1, 1, 1, 1, 1, 1))
        If rbGenerales.Checked = True Then
            rEmpleados.SetDataSource(VB.SysContab.EmpleadosDB.GeneradorReportesGeneral(cbEmpleados.SelectedValue, cbDepartamentos.SelectedValue, cbCargos.SelectedValue, cbFunciones.SelectedValue, cbNivel.Text, cbProfesion.Text, Tipo, Ordenar))
            fReportes.crvReportes.ReportSource = rEmpleados
        ElseIf Me.rbUbicacion.Checked = True Then

            rEmpleadosUbicacion.SetDataSource(VB.SysContab.EmpleadosDB.GeneradorReportes(cbEmpleados.SelectedValue, cbDepartamentos.SelectedValue, cbCargos.SelectedValue, cbFunciones.SelectedValue, cbNivel.Text, cbProfesion.Text, Ordenar))
            fReportes.crvReportes.ReportSource = rEmpleadosUbicacion
        ElseIf Me.rbConstancia.Checked = True Then
            If Me.cbEmpleados.SelectedValue = "" Then
                MsgBox("Seleccione un empleado", MsgBoxStyle.Exclamation, "STS.Nomina")
                Exit Sub
            End If
            ImprimeDiseño(1)
            Dim Rep As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(Application.StartupPath & "\Reporte.repx", True)
            Dim Forma As New FrmManejadorReporte
            Dim Texto As String = ""
            Texto = "Se extiende la presente para los fines que estime conveniente en la ciudad de " & _
                    ObtieneData("Select ciudad as Ciudad from Empresas Where codigo = " & EmpresaActual.ToString).Rows(0)("Ciudad")
            Texto = Texto & " a los " & Funciones.Letras(Now.Day, False) & " del mes del año " & Format(Now.Date, "MMMM") & " del " & Funciones.Letras(Now.Year, False).Trim
            Texto = Texto.Substring(0, Texto.Length - 4) & "."

            Forma.PrintControl1.PrintingSystem = Rep.PrintingSystem

            Rep.XmlDataPath = Application.StartupPath & "\logoempresa.xml"

            Rep.DataSource = ObtieneData("Select E.nombre as Empresa, ve.nombre as Nombre, ve.emp_fingreso as Ingreso, " & _
                    "c.cgo_nombre as Cargo,  m.mon_simbolo + ' ' +cast(ve.emp_salario as nvarchar) as Salario, a.are_descripcion as Area, " & _
                    "'" & Texto & "' as Texto, '" & Me.txtGerenteRecursosHumanos.Text & "' as NombreGerente " & _
                    "from empresas e inner join vEmpleados ve on e.codigo = ve.empr_codigo inner join Cargos C on " & _
                    "ve.empr_codigo = c.empr_codigo and ve.cgo_codigo = c.cgo_codigo inner join Areas A on " & _
                    "ve.empr_codigo = a.empr_codigo and ve.are_codigo = a.are_codigo and " & _
                    "ve.dep_codigo = a.dep_codigo inner join monedas m on ve.empr_codigo = m.empr_codigo and " & _
                    "ve.mon_codigo = m.mon_codigo where e.codigo = " & EmpresaActual & _
                    "and ve.emp_codigo = '" & Me.cbEmpleados.SelectedValue & "'")

            Rep.CreateDocument()

            'Forma.MdiParent = Me
            Forma.Show()
            Forma.WindowState = FormWindowState.Maximized
            Forma = Nothing
            Rep = Nothing
            Exit Sub
        Else
            Exit Sub
        End If

        If rbPantalla.Checked = True Then
            fReportes.ShowDialog()

        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()

        Else
            fReportes.crvReportes.ExportReport()

        End If

        'fReportes.ShowDialog()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim forma As New FrmConfiguraReporte
        forma.Tipo = 1
        forma.ShowDialog()
    End Sub
End Class
