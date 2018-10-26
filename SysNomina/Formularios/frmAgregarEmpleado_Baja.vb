
Public Class frmAgregarEmpleado_Baja
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarEmpleado_Baja = Nothing

    Public Shared Function Instance() As frmAgregarEmpleado_Baja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarEmpleado_Baja()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Public cEmpleado As String
    Public codEmpleado As String
    Dim DBaja As New VB.SysContab.Empleado_Baja()
    Dim Baja As New VB.SysContab.Empleado_BajaDB()
    Friend WithEvents chkIndemnizacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkInd As System.Windows.Forms.CheckBox
    Friend WithEvents cbCausas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Dim Empleado As New VB.SysContab.EmpleadosDB()

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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonBaja As System.Windows.Forms.TextBox
    Friend WithEvents rbJ As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRazonIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents chkRevisionAprobada As System.Windows.Forms.CheckBox
    Friend WithEvents chkRevisionDenegada As System.Windows.Forms.CheckBox
    Friend WithEvents chkAprobacionDenegada As System.Windows.Forms.CheckBox
    Friend WithEvents chkAprobacionAprobada As System.Windows.Forms.CheckBox
    Friend WithEvents txtRevision As System.Windows.Forms.TextBox
    Friend WithEvents txtAprobacion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCausas = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkInd = New System.Windows.Forms.CheckBox()
        Me.chkIndemnizacion = New System.Windows.Forms.CheckBox()
        Me.txtRazonIngreso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbJ = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRazonBaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRevision = New System.Windows.Forms.TextBox()
        Me.chkRevisionDenegada = New System.Windows.Forms.CheckBox()
        Me.chkRevisionAprobada = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtAprobacion = New System.Windows.Forms.TextBox()
        Me.chkAprobacionDenegada = New System.Windows.Forms.CheckBox()
        Me.chkAprobacionAprobada = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbCausas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 20)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Fecha Efectiva Baja:"
        '
        'dtpFechaBaja
        '
        Me.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBaja.Location = New System.Drawing.Point(160, 16)
        Me.dtpFechaBaja.Name = "dtpFechaBaja"
        Me.dtpFechaBaja.Size = New System.Drawing.Size(152, 20)
        Me.dtpFechaBaja.TabIndex = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbCausas)
        Me.GroupBox1.Controls.Add(Me.chkInd)
        Me.GroupBox1.Controls.Add(Me.chkIndemnizacion)
        Me.GroupBox1.Controls.Add(Me.txtRazonIngreso)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRazonBaja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dtpFechaBaja)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 320)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(398, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Motivo:"
        '
        'cbCausas
        '
        Me.cbCausas.Location = New System.Drawing.Point(532, 138)
        Me.cbCausas.Name = "cbCausas"
        Me.cbCausas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCausas.Properties.NullText = "[Seleccion Causa de Baja de Empleado]"
        Me.cbCausas.Size = New System.Drawing.Size(260, 20)
        Me.cbCausas.TabIndex = 143
        '
        'chkInd
        '
        Me.chkInd.AutoSize = True
        Me.chkInd.Location = New System.Drawing.Point(160, 140)
        Me.chkInd.Name = "chkInd"
        Me.chkInd.Size = New System.Drawing.Size(144, 17)
        Me.chkInd.TabIndex = 142
        Me.chkInd.Text = "Pagar Indemnización"
        Me.chkInd.UseVisualStyleBackColor = True
        '
        'chkIndemnizacion
        '
        Me.chkIndemnizacion.AutoSize = True
        Me.chkIndemnizacion.Location = New System.Drawing.Point(614, 19)
        Me.chkIndemnizacion.Name = "chkIndemnizacion"
        Me.chkIndemnizacion.Size = New System.Drawing.Size(178, 17)
        Me.chkIndemnizacion.TabIndex = 141
        Me.chkIndemnizacion.Text = "Pagar Indem. Prop < 1 año"
        Me.chkIndemnizacion.UseVisualStyleBackColor = True
        '
        'txtRazonIngreso
        '
        Me.txtRazonIngreso.Location = New System.Drawing.Point(160, 243)
        Me.txtRazonIngreso.Multiline = True
        Me.txtRazonIngreso.Name = "txtRazonIngreso"
        Me.txtRazonIngreso.Size = New System.Drawing.Size(632, 72)
        Me.txtRazonIngreso.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 32)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Documentos de Soporte:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbA)
        Me.GroupBox2.Controls.Add(Me.rbJ)
        Me.GroupBox2.Location = New System.Drawing.Point(160, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 72)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        '
        'rbA
        '
        Me.rbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbA.Location = New System.Drawing.Point(16, 40)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(315, 24)
        Me.rbA.TabIndex = 1
        Me.rbA.Text = "Liquidación Independiente"
        '
        'rbJ
        '
        Me.rbJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJ.Location = New System.Drawing.Point(16, 16)
        Me.rbJ.Name = "rbJ"
        Me.rbJ.Size = New System.Drawing.Size(305, 24)
        Me.rbJ.TabIndex = 0
        Me.rbJ.Text = "Liquidación (Nómina Incluida)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Forma Pago:"
        '
        'txtRazonBaja
        '
        Me.txtRazonBaja.Location = New System.Drawing.Point(160, 48)
        Me.txtRazonBaja.Multiline = True
        Me.txtRazonBaja.Name = "txtRazonBaja"
        Me.txtRazonBaja.Size = New System.Drawing.Size(632, 72)
        Me.txtRazonBaja.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Razón Baja:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 200)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRevision)
        Me.GroupBox4.Controls.Add(Me.chkRevisionDenegada)
        Me.GroupBox4.Controls.Add(Me.chkRevisionAprobada)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 72)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Revisión"
        '
        'txtRevision
        '
        Me.txtRevision.Enabled = False
        Me.txtRevision.Location = New System.Drawing.Point(176, 16)
        Me.txtRevision.Multiline = True
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(584, 48)
        Me.txtRevision.TabIndex = 142
        '
        'chkRevisionDenegada
        '
        Me.chkRevisionDenegada.Enabled = False
        Me.chkRevisionDenegada.Location = New System.Drawing.Point(8, 40)
        Me.chkRevisionDenegada.Name = "chkRevisionDenegada"
        Me.chkRevisionDenegada.Size = New System.Drawing.Size(112, 24)
        Me.chkRevisionDenegada.TabIndex = 141
        Me.chkRevisionDenegada.Text = "Denegada"
        '
        'chkRevisionAprobada
        '
        Me.chkRevisionAprobada.Enabled = False
        Me.chkRevisionAprobada.Location = New System.Drawing.Point(8, 16)
        Me.chkRevisionAprobada.Name = "chkRevisionAprobada"
        Me.chkRevisionAprobada.Size = New System.Drawing.Size(112, 24)
        Me.chkRevisionAprobada.TabIndex = 140
        Me.chkRevisionAprobada.Text = "Aprobada"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Estado:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtAprobacion)
        Me.GroupBox5.Controls.Add(Me.chkAprobacionDenegada)
        Me.GroupBox5.Controls.Add(Me.chkAprobacionAprobada)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(768, 72)
        Me.GroupBox5.TabIndex = 143
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Aprobación"
        '
        'txtAprobacion
        '
        Me.txtAprobacion.Enabled = False
        Me.txtAprobacion.Location = New System.Drawing.Point(176, 16)
        Me.txtAprobacion.Multiline = True
        Me.txtAprobacion.Name = "txtAprobacion"
        Me.txtAprobacion.Size = New System.Drawing.Size(584, 48)
        Me.txtAprobacion.TabIndex = 142
        '
        'chkAprobacionDenegada
        '
        Me.chkAprobacionDenegada.Enabled = False
        Me.chkAprobacionDenegada.Location = New System.Drawing.Point(8, 40)
        Me.chkAprobacionDenegada.Name = "chkAprobacionDenegada"
        Me.chkAprobacionDenegada.Size = New System.Drawing.Size(112, 24)
        Me.chkAprobacionDenegada.TabIndex = 141
        Me.chkAprobacionDenegada.Text = "Denegada"
        '
        'chkAprobacionAprobada
        '
        Me.chkAprobacionAprobada.Enabled = False
        Me.chkAprobacionAprobada.Location = New System.Drawing.Point(8, 16)
        Me.chkAprobacionAprobada.Name = "chkAprobacionAprobada"
        Me.chkAprobacionAprobada.Size = New System.Drawing.Size(112, 24)
        Me.chkAprobacionAprobada.TabIndex = 140
        Me.chkAprobacionAprobada.Text = "Aprobada"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.cmdGuardar)
        Me.GroupBox6.Location = New System.Drawing.Point(820, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(104, 526)
        Me.GroupBox6.TabIndex = 75
        Me.GroupBox6.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(8, 16)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(88, 32)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        '
        'frmAgregarEmpleado_Baja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(928, 542)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAgregarEmpleado_Baja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbCausas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarEmpleado_Baja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Baja de Empleado: " & Me.cEmpleado
        Me.dtpFechaBaja.MinDate = DateAdd(DateInterval.Day, -15, CDate("01/" & Format(Now.Date, "MM/yyyy")))
        DBaja = Baja.GetDetails_last(Me.codEmpleado)

        Me.cbCausas.Properties.DataSource = VB.SysContab.LiquidacionDB.Liquidacion_Causas("0", "F")
        Me.cbCausas.Properties.DisplayMember = "descripcion"
        Me.cbCausas.Properties.ValueMember = "id"

        If IsNothing(DBaja.Empleado) Then
            Me.dtpFechaBaja.Value = Now.Date
        Else
            Me.chkIndemnizacion.Checked = DBaja.Indemnizacion
            Me.dtpFechaBaja.Value = DBaja.Fecha_Baja
            Me.txtRazonBaja.Text = DBaja.Razon_Baja
            If DBaja.FormaPago = "J" Then
                Me.rbJ.Checked = True
            Else
                Me.rbA.Checked = True
            End If
            Me.txtRazonIngreso.Text = DBaja.Razon_Ingreso

            Me.chkRevisionAprobada.Checked = DBaja.Revisado
            Me.chkRevisionDenegada.Checked = DBaja.Revisado_Denegado
            Me.txtRevision.Text = DBaja.Razon_Revisado.Trim
            Me.chkInd.Checked = DBaja.Causa
            Me.chkAprobacionAprobada.Checked = DBaja.Aprobado
            Me.chkAprobacionDenegada.Checked = DBaja.Aprobado_Denegado
            Me.txtAprobacion.Text = DBaja.Razon_Aprobado.Trim
            Me.cbCausas.EditValue = DBaja.Causa

            If DBaja.Aprobado = True Then
                Me.dtpFechaBaja.Enabled = False
                Me.txtRazonBaja.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.txtRazonIngreso.Enabled = False
            Else
                Me.dtpFechaBaja.Enabled = True
                Me.txtRazonBaja.Enabled = True
                Me.GroupBox2.Enabled = True
                Me.txtRazonIngreso.Enabled = True

            End If

        End If

        Me.Refresh()
    End Sub



    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If IsNothing(DBaja.Empleado) Then
            If MsgBox("Esta seguro de dar de Baja a este empleado?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SysNomina") = MsgBoxResult.Yes Then
                VB.SysContab.Empleado_BajaDB.Additem(Me.codEmpleado, Me.dtpFechaBaja.Value.Date, _
                    Me.txtRazonBaja.Text, IIf(Me.rbA.Checked, "A", "J"), _
                    Me.txtRazonIngreso.Text, Me.chkIndemnizacion.Checked, _
                    Me.chkInd.Checked, Me.cbCausas.EditValue)
                'Empleado.UpdateFinContrato(Me.txtCodigo.Text, Fecha, False)
            End If
        ElseIf DBaja.Fecha_Liquidacion Is DBNull.Value Or IsNothing(DBaja.Fecha_Liquidacion) Or DBaja.Fecha_Liquidacion = "" Then
            'If MsgBox("Este Empleado esta dado de Baja, desea restaurarlo en la Nomina?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SysNomina") = MsgBoxResult.Yes Then
            '    Baja.Delete(Me.codEmpleado, Me.dtpFechaBaja.Value.Date)
            '    'Empleado.UpdateFinContrato(Me.txtCodigo.Text, Fecha, True)
            'End If
            Baja.UpdateItem(Me.codEmpleado, Me.dtpFechaBaja.Value.Date, _
                Me.txtRazonBaja.Text, IIf(Me.rbA.Checked, "A", "J"), _
                Me.txtRazonIngreso.Text, Me.chkIndemnizacion.Checked, _
                Me.chkInd.Checked, Me.cbCausas.EditValue)
        Else
            MsgBox("Este empleado ya tiene generada su liquidación", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
