

Public Class frmAprobacionEmpleados_BajaEditar
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAprobacionEmpleados_BajaEditar = Nothing

    Public Shared Function Instance() As frmAprobacionEmpleados_BajaEditar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAprobacionEmpleados_BajaEditar()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDenegada As System.Windows.Forms.RadioButton
    Friend WithEvents rbAprobada As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents rbJ As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRazonBaja As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAprobacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRevision As System.Windows.Forms.TextBox
    Friend WithEvents chkRevisionDenegada As System.Windows.Forms.CheckBox
    Friend WithEvents chkIndemnizacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkInd As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCausas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkRevisionAprobada As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAprobacion = New System.Windows.Forms.TextBox
        Me.rbDenegada = New System.Windows.Forms.RadioButton
        Me.rbAprobada = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkInd = New System.Windows.Forms.CheckBox
        Me.chkIndemnizacion = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtRevision = New System.Windows.Forms.TextBox
        Me.chkRevisionDenegada = New System.Windows.Forms.CheckBox
        Me.chkRevisionAprobada = New System.Windows.Forms.CheckBox
        Me.txtRazonIngreso = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbA = New System.Windows.Forms.RadioButton
        Me.rbJ = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRazonBaja = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpFechaBaja = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbCausas = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbCausas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 385)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 199)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAprobacion)
        Me.GroupBox2.Controls.Add(Me.rbDenegada)
        Me.GroupBox2.Controls.Add(Me.rbAprobada)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(784, 157)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'txtAprobacion
        '
        Me.txtAprobacion.Location = New System.Drawing.Point(6, 60)
        Me.txtAprobacion.Multiline = True
        Me.txtAprobacion.Name = "txtAprobacion"
        Me.txtAprobacion.Size = New System.Drawing.Size(760, 83)
        Me.txtAprobacion.TabIndex = 143
        '
        'rbDenegada
        '
        Me.rbDenegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDenegada.Location = New System.Drawing.Point(150, 10)
        Me.rbDenegada.Name = "rbDenegada"
        Me.rbDenegada.Size = New System.Drawing.Size(144, 24)
        Me.rbDenegada.TabIndex = 3
        Me.rbDenegada.Text = "Denegada"
        '
        'rbAprobada
        '
        Me.rbAprobada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAprobada.Location = New System.Drawing.Point(6, 10)
        Me.rbAprobada.Name = "rbAprobada"
        Me.rbAprobada.Size = New System.Drawing.Size(144, 24)
        Me.rbAprobada.TabIndex = 2
        Me.rbAprobada.Text = "Aprobada"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Razón:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(408, 172)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(328, 172)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbCausas)
        Me.GroupBox3.Controls.Add(Me.chkInd)
        Me.GroupBox3.Controls.Add(Me.chkIndemnizacion)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.txtRazonIngreso)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtRazonBaja)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dtpFechaBaja)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(8, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 390)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'chkInd
        '
        Me.chkInd.AutoSize = True
        Me.chkInd.Location = New System.Drawing.Point(158, 134)
        Me.chkInd.Name = "chkInd"
        Me.chkInd.Size = New System.Drawing.Size(125, 17)
        Me.chkInd.TabIndex = 144
        Me.chkInd.Text = "Pagar Indemnizacion"
        Me.chkInd.UseVisualStyleBackColor = True
        '
        'chkIndemnizacion
        '
        Me.chkIndemnizacion.AutoSize = True
        Me.chkIndemnizacion.Location = New System.Drawing.Point(639, 16)
        Me.chkIndemnizacion.Name = "chkIndemnizacion"
        Me.chkIndemnizacion.Size = New System.Drawing.Size(153, 17)
        Me.chkIndemnizacion.TabIndex = 142
        Me.chkIndemnizacion.Text = "Pagar Indem. Prop < 1 año"
        Me.chkIndemnizacion.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtRevision)
        Me.GroupBox5.Controls.Add(Me.chkRevisionDenegada)
        Me.GroupBox5.Controls.Add(Me.chkRevisionAprobada)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 309)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(768, 72)
        Me.GroupBox5.TabIndex = 143
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Revisión"
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
        Me.chkRevisionDenegada.Size = New System.Drawing.Size(106, 24)
        Me.chkRevisionDenegada.TabIndex = 141
        Me.chkRevisionDenegada.Text = "Denegada"
        '
        'chkRevisionAprobada
        '
        Me.chkRevisionAprobada.Enabled = False
        Me.chkRevisionAprobada.Location = New System.Drawing.Point(8, 16)
        Me.chkRevisionAprobada.Name = "chkRevisionAprobada"
        Me.chkRevisionAprobada.Size = New System.Drawing.Size(106, 24)
        Me.chkRevisionAprobada.TabIndex = 140
        Me.chkRevisionAprobada.Text = "Aprobada"
        '
        'txtRazonIngreso
        '
        Me.txtRazonIngreso.Location = New System.Drawing.Point(160, 237)
        Me.txtRazonIngreso.Multiline = True
        Me.txtRazonIngreso.Name = "txtRazonIngreso"
        Me.txtRazonIngreso.Size = New System.Drawing.Size(632, 72)
        Me.txtRazonIngreso.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Razón Ingreso:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbA)
        Me.GroupBox4.Controls.Add(Me.rbJ)
        Me.GroupBox4.Location = New System.Drawing.Point(160, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 72)
        Me.GroupBox4.TabIndex = 138
        Me.GroupBox4.TabStop = False
        '
        'rbA
        '
        Me.rbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbA.Location = New System.Drawing.Point(16, 40)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(211, 24)
        Me.rbA.TabIndex = 1
        Me.rbA.Text = "Liquidación Independiente"
        '
        'rbJ
        '
        Me.rbJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJ.Location = New System.Drawing.Point(16, 16)
        Me.rbJ.Name = "rbJ"
        Me.rbJ.Size = New System.Drawing.Size(224, 24)
        Me.rbJ.TabIndex = 0
        Me.rbJ.Text = "Liquidación (Nómina Incluida)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 157)
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Razón Baja:"
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(398, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Motivo:"
        '
        'cbCausas
        '
        Me.cbCausas.Location = New System.Drawing.Point(532, 132)
        Me.cbCausas.Name = "cbCausas"
        Me.cbCausas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCausas.Properties.NullText = "[Seleccion Causa de Baja de Empleado]"
        Me.cbCausas.Size = New System.Drawing.Size(260, 20)
        Me.cbCausas.TabIndex = 145
        '
        'frmAprobacionEmpleados_BajaEditar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 589)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAprobacionEmpleados_BajaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.cbCausas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DBaja As New VB.SysContab.Empleado_Baja()
    Dim Baja As New VB.SysContab.Empleado_BajaDB()
    Public CodEmpleado As String
    Public dFecha As Date

    Private Sub frmAgregararea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBaja = Baja.GetDetails(Me.CodEmpleado, Me.dFecha)

        Me.cbCausas.Properties.DataSource = VB.SysContab.LiquidacionDB.Liquidacion_Causas("0", "F")
        Me.cbCausas.Properties.DisplayMember = "descripcion"
        Me.cbCausas.Properties.ValueMember = "id"

        If Not IsNothing(DBaja.Empleado) Then

            Me.dtpFechaBaja.Value = DBaja.Fecha_Baja
            Me.rbAprobada.Checked = DBaja.Aprobado
            Me.rbDenegada.Checked = DBaja.Aprobado_Denegado
            Me.txtRevision.Text = DBaja.Razon_Aprobado.Trim
            Me.chkInd.Checked = DBaja.Causa
            Me.cbCausas.EditValue = DBaja.Motivo

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
            Me.chkIndemnizacion.Checked = DBaja.Indemnizacion
        End If


        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    'Private Sub frmAgregararea_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    '    Dim Areas As New VB.SysContab.AreaDB()
    '    Dim r As New VB.SysContab.RutinasNomina()
    '    Dim Tabla As New DataTable()
    '    Dim ds As New DataSet()
    '    Dim d As frmAreas = d.Instance

    '   VB.SysContab.RutinasNomina.CambiarEstilo(Me)

    '    ds = Areas.GetList()

    '    d.dgAreas.DataSource = Areas.GetList().Tables("Areas").DefaultView
    '    Tabla = ds.Tables("Areas")

    '   VB.SysContab.RutinasNomina.FormatGenerico(d.dgAreas, Tabla)

    '    If ds.Tables("Areas").Rows.Count <> 0 Then
    '        Registro = d.dgAreas.Item(0, 0)
    '        Registro1 = d.dgAreas.Item(0, 2)
    '    Else
    '        Registro = "Vacio"
    '        Registro1 = "Vacio"
    '    End If


    'End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        VB.SysContab.Empleado_BajaDB.Aprobacion(Me.CodEmpleado, Me.dFecha, Me.txtRevision.Text, Me.rbAprobada.Checked, _
        Me.rbDenegada.Checked, Me.chkIndemnizacion.Checked)
        Me.Close()
    End Sub
End Class
