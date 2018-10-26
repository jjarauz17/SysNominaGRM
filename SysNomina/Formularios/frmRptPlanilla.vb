Imports System.IO
Public Class frmRptPlanilla
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmRptPlanilla = Nothing

    Public Shared Function Instance() As frmRptPlanilla
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptPlanilla()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbAfiscal As System.Windows.Forms.ComboBox
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
    Friend WithEvents btnConsolidado As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtAFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents btnJournal As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbListado As System.Windows.Forms.RadioButton
    Friend WithEvents rbInteractivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbNominas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents rbAgrupado As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnJournal = New System.Windows.Forms.Button
        Me.btnConsolidado = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.cbAfiscal = New System.Windows.Forms.ComboBox
        Me.GBMes = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.rbtAFiscal = New System.Windows.Forms.RadioButton
        Me.rbtMes = New System.Windows.Forms.RadioButton
        Me.rbtPeriodo = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbPeriodo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbListado = New System.Windows.Forms.RadioButton
        Me.rbInteractivo = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.rbAgrupado = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbNominas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbEmpleados = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDepartamento = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbRubro = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnJournal)
        Me.GroupBox1.Controls.Add(Me.btnConsolidado)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(672, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 320)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'btnJournal
        '
        Me.btnJournal.Location = New System.Drawing.Point(8, 80)
        Me.btnJournal.Name = "btnJournal"
        Me.btnJournal.Size = New System.Drawing.Size(112, 32)
        Me.btnJournal.TabIndex = 9
        Me.btnJournal.Text = "Journal"
        '
        'btnConsolidado
        '
        Me.btnConsolidado.Location = New System.Drawing.Point(8, 40)
        Me.btnConsolidado.Name = "btnConsolidado"
        Me.btnConsolidado.Size = New System.Drawing.Size(112, 42)
        Me.btnConsolidado.TabIndex = 8
        Me.btnConsolidado.Text = "Consolidado x Rubro"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(8, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 24)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Resumen"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 272)
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
        Me.Label44.Location = New System.Drawing.Point(16, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 24)
        Me.Label44.TabIndex = 124
        Me.Label44.Text = "Año Fiscal:"
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
        Me.GBMes.Controls.Add(Me.Label5)
        Me.GBMes.Controls.Add(Me.rbtAFiscal)
        Me.GBMes.Controls.Add(Me.rbtMes)
        Me.GBMes.Controls.Add(Me.rbtPeriodo)
        Me.GBMes.Controls.Add(Me.Label1)
        Me.GBMes.Controls.Add(Me.cbPeriodo)
        Me.GBMes.Controls.Add(Me.Label7)
        Me.GBMes.Controls.Add(Me.cbMes)
        Me.GBMes.Location = New System.Drawing.Point(32, 112)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(352, 89)
        Me.GBMes.TabIndex = 126
        Me.GBMes.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Año Fiscal"
        '
        'rbtAFiscal
        '
        Me.rbtAFiscal.Location = New System.Drawing.Point(16, 56)
        Me.rbtAFiscal.Name = "rbtAFiscal"
        Me.rbtAFiscal.Size = New System.Drawing.Size(16, 24)
        Me.rbtAFiscal.TabIndex = 124
        Me.rbtAFiscal.Text = "RadioButton2"
        '
        'rbtMes
        '
        Me.rbtMes.Location = New System.Drawing.Point(16, 32)
        Me.rbtMes.Name = "rbtMes"
        Me.rbtMes.Size = New System.Drawing.Size(16, 24)
        Me.rbtMes.TabIndex = 123
        Me.rbtMes.Text = "RadioButton2"
        '
        'rbtPeriodo
        '
        Me.rbtPeriodo.Location = New System.Drawing.Point(16, 8)
        Me.rbtPeriodo.Name = "rbtPeriodo"
        Me.rbtPeriodo.Size = New System.Drawing.Size(16, 24)
        Me.rbtPeriodo.TabIndex = 122
        Me.rbtPeriodo.Text = "RadioButton1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Período:"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(120, 8)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(216, 21)
        Me.cbPeriodo.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(48, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(120, 32)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(216, 23)
        Me.cbMes.TabIndex = 119
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbListado)
        Me.GroupBox4.Controls.Add(Me.rbInteractivo)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        '
        'rbListado
        '
        Me.rbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbListado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbListado.Location = New System.Drawing.Point(8, 36)
        Me.rbListado.Name = "rbListado"
        Me.rbListado.Size = New System.Drawing.Size(144, 24)
        Me.rbListado.TabIndex = 125
        Me.rbListado.Text = "Listado"
        '
        'rbInteractivo
        '
        Me.rbInteractivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbInteractivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbInteractivo.Location = New System.Drawing.Point(8, 12)
        Me.rbInteractivo.Name = "rbInteractivo"
        Me.rbInteractivo.Size = New System.Drawing.Size(144, 24)
        Me.rbInteractivo.TabIndex = 124
        Me.rbInteractivo.Text = "Interactivo"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.rbAgrupado)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Controls.Add(Me.cbNominas)
        Me.GroupBox7.Location = New System.Drawing.Point(384, 112)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(280, 144)
        Me.GroupBox7.TabIndex = 127
        Me.GroupBox7.TabStop = False
        '
        'rbAgrupado
        '
        Me.rbAgrupado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbAgrupado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAgrupado.Location = New System.Drawing.Point(16, 112)
        Me.rbAgrupado.Name = "rbAgrupado"
        Me.rbAgrupado.Size = New System.Drawing.Size(152, 24)
        Me.rbAgrupado.TabIndex = 129
        Me.rbAgrupado.Text = "Agrupado"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Nóminas"
        '
        'cbNominas
        '
        Me.cbNominas.Items.AddRange(New Object() {"REGULARES", "EXTRAS", "TODAS"})
        Me.cbNominas.Location = New System.Drawing.Point(112, 88)
        Me.cbNominas.Name = "cbNominas"
        Me.cbNominas.Size = New System.Drawing.Size(160, 21)
        Me.cbNominas.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 48)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(328, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.cbAfiscal)
        Me.GroupBox2.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 80)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbLocalidad)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbEmpleados)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbDepartamento)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 96)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Empleado:"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Location = New System.Drawing.Point(135, 62)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(416, 21)
        Me.cbEmpleados.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Departamento:"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.Location = New System.Drawing.Point(135, 38)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(416, 21)
        Me.cbDepartamento.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.cbRubro)
        Me.GroupBox5.Location = New System.Drawing.Point(32, 203)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 53)
        Me.GroupBox5.TabIndex = 129
        Me.GroupBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(20, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 24)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Localidad:"
        '
        'cbLocalidad
        '
        Me.cbLocalidad.Location = New System.Drawing.Point(135, 13)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(416, 21)
        Me.cbLocalidad.TabIndex = 129
        '
        'frmRptPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 365)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GBMes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmRptPlanilla"
        Me.Text = "Reportes Planilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As DataSet
    Dim tabla As DataTable
    Dim dplanilla As New VB.SysContab.PlanillaDDB()
    Dim D As New VB.SysContab.DepartamentosDB()
    Dim emp As New VB.SysContab.EmpleadosDB()
    Dim r As New VB.SysContab.RutinasNomina()
    Dim Periodo As String, TPeriodo As String
    Dim fReportes As New frmReportes()

    Private Sub frmVerPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            Me.cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
            Me.cbMonedaCambio.ValueMember = "MonedaCambio"
            Me.cbMonedaCambio.DisplayMember = "Nombre"

            Me.cbAfiscal.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
            Me.cbAfiscal.ValueMember = "Per_ID"
            Me.cbAfiscal.DisplayMember = "Descripcion"

            Me.cbPeriodo.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbPeriodo.ValueMember = "Per_codigo"
            Me.cbPeriodo.DisplayMember = "Per_descripcion"

            Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes.ValueMember = "Mes"
            Me.cbMes.DisplayMember = "Descripcion"

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

            Me.rbtPeriodo.Checked = True
            Me.rbInteractivo.Checked = True

            Me.Refresh()
        Catch ex As Exception
            MsgBox("No existe nomina para presentar, pro favor procese primero una nomina", MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbAfiscal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAfiscal.SelectedValueChanged
        If IsNumeric(Me.cbAfiscal.SelectedValue) Or TypeName(Me.cbAfiscal.SelectedValue).ToLower = "string" Then
            Me.cbPeriodo.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(Me.cbAfiscal.SelectedValue).Tables("PeriodoNomina_Afiscal")
            Me.cbPeriodo.ValueMember = "Per_codigo"
            Me.cbPeriodo.DisplayMember = "Per_descripcion"

            Me.cbMes.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscarMes(Me.cbAfiscal.SelectedValue).Tables("Meses_Afiscal")
            Me.cbMes.ValueMember = "Mes"
            Me.cbMes.DisplayMember = "Descripcion"

            If Not IsNothing(Registro) Then
                Me.cbPeriodo.SelectedValue = Registro
            End If
        End If
    End Sub


    Private Sub rbtPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPeriodo.CheckedChanged

        Me.cbMes.Enabled = Not Me.rbtPeriodo.Checked
        Me.cbPeriodo.Enabled = Me.rbtPeriodo.Checked
        Me.cbMes.SelectedValue = IIf(Me.rbtPeriodo.Checked, "", Me.cbMes.SelectedValue)
        If IsNumeric(Me.cbPeriodo.SelectedValue) Then
            Me.cbPeriodo.SelectedValue = IIf(Not Me.rbtPeriodo.Checked, "", Me.cbPeriodo.SelectedValue)
        End If


    End Sub



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Dim reporte As New rptPlanilla_Depto_Empleado()
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanilla_Depto_Empleado.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanilla_Depto_Empleado.rpt")
            Exit Sub
        End If
        Reporte.load(Application.StartupPath & "\reportes\rptPlanilla_Depto_Empleado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        'Dim reporteL As New rptPlanilla_Depto_EmpleadoL()
        Dim reporteL As New Object
        reporteL = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL.rpt")
            Exit Sub
        End If
        reporteL.load(Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'Dim reporteL_P As New rptPlanilla_Depto_EmpleadoL_P()
        Dim reporteL_P As New Object
        reporteL_P = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL_P.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL_P.rpt")
            Exit Sub
        End If
        reporteL_P.load(Application.StartupPath & "\reportes\rptPlanilla_Depto_EmpleadoL_P.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Periodo = Microsoft.VisualBasic.Right(Me.cbPeriodo.SelectedValue, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Me.cbPeriodo.SelectedValue, 1)


        If Me.cbPeriodo.SelectedValue = "" And Me.cbMes.SelectedValue = "" And Me.rbtAFiscal.Checked = False Then
            MsgBox("Seleccione el Mes o Periodo de Nomina a imprimir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)

        lds.Dispose()


        If Me.rbInteractivo.Checked Then

            ds = VB.SysContab.PlanillaDB.Depto_Mes(IIf(Me.rbtAFiscal.Checked, "%" + Me.cbAfiscal.SelectedValue, Me.cbAfiscal.SelectedValue), _
            IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), _
            IIf(Periodo = "", "%", Periodo), IIf(TPeriodo = "", "%", TPeriodo), _
            Me.cbMonedaCambio.SelectedValue, _
            Me.cbDepartamento.SelectedValue, _
            Me.cbEmpleados.SelectedValue, "Planilla_Depto_Empleado", "T")

            ds.WriteXml(Application.StartupPath & "\PDE.xml", XmlWriteMode.WriteSchema)

            Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
            Reporte.Database.Tables("_GetListPlanilla_Depto_Empleado;1").Location = Application.StartupPath & "\PDE.xml"

            fReportes.crvReportes.ReportSource = Reporte

        Else
            If Me.rbAgrupado.Checked Then

                ds = VB.SysContab.PlanillaDB.Depto_Mes(IIf(Me.rbtAFiscal.Checked, "%" + Me.cbAfiscal.SelectedValue, Me.cbAfiscal.SelectedValue), _
                            IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), _
                            IIf(Periodo = "", "%", Periodo), IIf(TPeriodo = "", "%", TPeriodo), _
                            Me.cbMonedaCambio.SelectedValue, _
                            Me.cbDepartamento.SelectedValue, _
                            Me.cbEmpleados.SelectedValue, "Planilla_Depto_Empleado", _
                            Microsoft.VisualBasic.Left(IIf(Me.cbNominas.SelectedItem Is Nothing, "TODAS", Me.cbNominas.SelectedItem), 1))
                ds.WriteXml(Application.StartupPath & "\PDE_L.xml", XmlWriteMode.WriteSchema)

                reporteL.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
                reporteL.Database.Tables("_GetListPlanilla_Depto_Empleado;1").Location = Application.StartupPath & "\PDE_L.xml"

                fReportes.crvReportes.ReportSource = reporteL
            Else
                ds = VB.SysContab.PlanillaDB.Depto_Mes(IIf(Me.rbtAFiscal.Checked, "%" + Me.cbAfiscal.SelectedValue, Me.cbAfiscal.SelectedValue), _
                            IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), _
                            IIf(Periodo = "", "%", Periodo), IIf(TPeriodo = "", "%", TPeriodo), _
                            Me.cbMonedaCambio.SelectedValue, _
                            Me.cbDepartamento.SelectedValue, _
                            Me.cbEmpleados.SelectedValue, "Planilla_Depto_Empleado", _
                            Microsoft.VisualBasic.Left(IIf(Me.cbNominas.SelectedItem Is Nothing, "TODAS", Me.cbNominas.SelectedItem), 1))
                ds.WriteXml(Application.StartupPath & "\PDE_L_P.xml", XmlWriteMode.WriteSchema)

                reporteL_P.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
                reporteL_P.Database.Tables("_GetListPlanilla_Depto_Empleado;1").Location = Application.StartupPath & "\PDE_L_P.xml"

                fReportes.crvReportes.ReportSource = reporteL_P
            End If


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


    Private Sub btnConsolidado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolidado.Click
        'Dim reporte As New rptPlanillaConsolidado()
        Dim reporte As New Object
        reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not File.Exists(Application.StartupPath & "\reportes\rptPlanillaConsolidado.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptPlanillaConsolidado.rpt")
            Exit Sub
        End If
        reporte.load(Application.StartupPath & "\reportes\rptPlanillaConsolidado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Periodo = Microsoft.VisualBasic.Right(Me.cbPeriodo.SelectedValue, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Me.cbPeriodo.SelectedValue, 1)

        If Me.cbMes.SelectedValue = "" And Me.cbPeriodo.SelectedValue = "" And Me.rbtAFiscal.Checked = False Then
            MsgBox("Seleccione Mes o Periodo de Nomina a imprimir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ds = VB.SysContab.PlanillaDB.Consolidado(IIf(Me.rbtAFiscal.Checked, "%" + Me.cbAfiscal.SelectedValue, _
            Me.cbAfiscal.SelectedValue), IIf(Periodo = "", "%", Periodo), IIf(TPeriodo = "", "%", TPeriodo), _
            IIf(Me.cbMes.SelectedValue = "", "%", Me.cbMes.SelectedValue), Me.cbMonedaCambio.SelectedValue, _
            Me.cbDepartamento.SelectedValue, Me.cbEmpleados.SelectedValue, Me.cbRubro.SelectedValue, _
            IIf(Me.cbLocalidad.SelectedValue Is Nothing Or Me.cbLocalidad.SelectedValue Is DBNull.Value, 0, Me.cbLocalidad.SelectedValue), False)
        ds.WriteXml(Application.StartupPath & "\Consolidado.xml", XmlWriteMode.WriteSchema)
        'reporte.SetDataSource(ds)
        reporte.Database.Tables(0).Location = Application.StartupPath & "\Consolidado.xml"
        fReportes.crvReportes.ReportSource = reporte
        fReportes.ShowDialog()


    End Sub

    Private Sub rbtAFiscal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAFiscal.CheckedChanged

        Me.cbMes.Enabled = Not Me.rbtAFiscal.Checked
        Me.cbPeriodo.Enabled = Not Me.rbtAFiscal.Checked
        Me.cbMes.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbMes.SelectedValue)
        Me.cbPeriodo.SelectedValue = IIf(Me.rbtAFiscal.Checked, "", Me.cbPeriodo.SelectedValue)
    End Sub

    Private Sub rbtMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMes.CheckedChanged

        Me.cbMes.Enabled = Me.rbtMes.Checked
        Me.cbPeriodo.Enabled = Not Me.rbtMes.Checked
        Me.cbMes.SelectedValue = IIf(Me.rbtMes.Checked, "", Me.cbMes.SelectedValue)
        Me.cbPeriodo.SelectedValue = IIf(Not Me.rbtMes.Checked, "", Me.cbPeriodo.SelectedValue)

    End Sub

    Private Sub btnJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJournal.Click

        'Dim reporte As New rptJournalNomina()
        Dim reporte As Object
        reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptJournalNomina.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptJournalNomina.rpt")
            Exit Sub
        End If
        reporte.load(Application.StartupPath & "\reportes\rptJournalNomina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Periodo = Microsoft.VisualBasic.Right(Me.cbPeriodo.SelectedValue, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Me.cbPeriodo.SelectedValue, 1)

        If Me.cbMes.SelectedValue <> "" Or Me.rbtAFiscal.Checked = True Then
            MsgBox("Seleccione solamente Periodo de Nomina para imprimir el Journal", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Me.cbPeriodo.SelectedValue = "" Then
            MsgBox("Seleccione el Periodo de Nomina para imprimir el Journal", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim myDataset As New DataSet()
        Dim i As Integer = 0

        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "D", "_getJournal_aguinaldo", "Tabla")
        myDataset.Tables.Add(ds.Tables("tabla").Clone)
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "C", "_getJournal_aguinaldo", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "", "_getJournal_apagar", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "C", "_getJournal_Deducciones", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "D", "_getJournal_indemnizacion", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "C", "_getJournal_indemnizacion", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "D", "_getJournal_Neutrales", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "C", "_getJournal_Neutrales", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "", "_getJournal_salario", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "D", "_getJournal_vacaciones", "Tabla")
        Llenar(ds, myDataset)
        ds = VB.SysContab.PlanillaDB.GetListPlanilla_Journal(Periodo, TPeriodo, Me.cbMonedaCambio.SelectedValue, "C", "_getJournal_vacaciones", "Tabla")
        Llenar(ds, myDataset)
        ds.WriteXml(Application.StartupPath & "\exportfiles\journal.xml", XmlWriteMode.WriteSchema)

        'reporte.SetDataSource(myDataset)
        reporte.Database.Tables(0).Location = Application.StartupPath & "\exportfiles\journal.xml"
        fReportes.crvReportes.ReportSource = reporte
        fReportes.ShowDialog()
    End Sub

    Private Sub Llenar(ByVal DS As DataSet, ByRef Destino As DataSet)
        Dim i As Integer = 0
        Dim nrow As DataRow

        For i = 0 To DS.Tables("Tabla").Rows.Count - 1
            nrow = Destino.Tables("Tabla").NewRow
            nrow.ItemArray = DS.Tables("tabla").Rows(i).ItemArray
            Destino.Tables("Tabla").Rows.Add(nrow)
        Next

    End Sub
End Class
