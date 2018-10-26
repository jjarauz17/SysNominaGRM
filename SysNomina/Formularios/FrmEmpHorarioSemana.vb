Public Class frmEmpHorarioSemana
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmEmpHorarioSemana = Nothing

    Public Shared Function Instance() As frmEmpHorarioSemana
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEmpHorarioSemana()
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpSemana As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpSemana = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.dtpSemana})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 120)
        Me.GroupBox4.TabIndex = 119
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "HORARIO"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 24)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Inicio de Semana"
        '
        'dtpSemana
        '
        Me.dtpSemana.Checked = False
        Me.dtpSemana.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSemana.Location = New System.Drawing.Point(168, 24)
        Me.dtpSemana.Name = "dtpSemana"
        Me.dtpSemana.Size = New System.Drawing.Size(112, 21)
        Me.dtpSemana.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCancelar, Me.cmdAceptar})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(164, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 40)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(96, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(24, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(464, 20)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEmpHorarioSemana
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(512, 206)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etDescripcion, Me.GroupBox2, Me.GroupBox4})
        Me.Name = "frmEmpHorarioSemana"
        Me.Text = "Generar Horarios de la Semana"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEmpHorarioSemana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpSemana.Value = IIf(Weekday(Today) = 1, Today, DateAdd(DateInterval.Day, -(Weekday(Today) - 1), Today))

        Me.Refresh()

    End Sub







    Private Sub dtpSemana_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSemana.ValueChanged
        Dim DomingoActual As Date, DomingoSeleccionado As Date

        DomingoActual = IIf(Weekday(Today) = 1, Today, DateAdd(DateInterval.Day, -(Weekday(Today) - 1), Today))
        DomingoSeleccionado = IIf(Weekday(dtpSemana.Value) = 1, dtpSemana.Value, DateAdd(DateInterval.Day, -(Weekday(dtpSemana.Value) - 1), dtpSemana.Value))

        If DomingoSeleccionado < DomingoActual Then
            MsgBox("No se pueden generar los horarios de una semana anterior a la actual", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Error de Inicio de Semana")
            dtpSemana.Value = DomingoActual
            Return
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim EmpHorarioSemana As New VB.SysContab.EmpHorarioSemanaDB()
        Dim EmpHorario As New VB.SysContab.EmpHorarioDB()
        'Dim dsHSemana As DataSet
        Dim dsHorario As DataSet

        Dim detalles As VB.SysContab.EmpHorarioDetails
        Dim detHSemana As VB.SysContab.EmpHorarioSemanaDetails

        Dim i As Integer
        dsHorario = EmpHorario.GetList


        i = 0
        Do While i < dsHorario.Tables("EmpHorario").Rows.Count
            'dsHSemana = EmpHorarioSemana.GetListEmpleado(dsHorario.Tables("EmpHorario").Rows(i).Item("Codigo"), Me.dtpSemana.Value)
            detHSemana = EmpHorarioSemana.GetDetails(dsHorario.Tables("Emphorario").Rows(i).Item("Codigo"), Me.dtpSemana.Value)
            If detHSemana.Semana <> Nothing Then 'dsHSemana.Tables("EmpHorarioSemana").Rows.Count <> 0 Then 'Tiene horario asignado en la semana
                detalles = EmpHorario.GetDetails(dsHorario.Tables("EmpHorario").Rows(i).Item("Codigo"))
                EmpHorarioSemana.Update(detalles.Empleado, Me.dtpSemana.Value, detalles.Domingo, detalles.Lunes, detalles.Martes, detalles.Miercoles, detalles.Jueves, detalles.Viernes, detalles.Sabado)
            Else
                detalles = EmpHorario.GetDetails(dsHorario.Tables("EmpHorario").Rows(i).Item("Codigo"))
                EmpHorarioSemana.AddItem(detalles.Empleado, Me.dtpSemana.Value, detalles.Domingo, detalles.Lunes, detalles.Martes, detalles.Miercoles, detalles.Jueves, detalles.Viernes, detalles.Sabado)

            End If
            i = i + 1
        Loop

        MsgBox("El horario semanal ha sido creado", MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class
