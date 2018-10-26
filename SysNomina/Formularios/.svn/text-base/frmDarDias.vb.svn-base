Public Class frmDarDias
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmDarDias = Nothing
    Public Shared Function Instance() As frmDarDias
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDarDias()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Public Shared Todos As Boolean

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MC As System.Windows.Forms.MonthCalendar
    Friend WithEvents cbParteDia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.MC = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbParteDia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCancelar, Me.cmdAceptar})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(480, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 232)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 48)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 16)
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
        Me.etDescripcion.Size = New System.Drawing.Size(560, 20)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MC
        '
        Me.MC.Location = New System.Drawing.Point(216, 64)
        Me.MC.Name = "MC"
        Me.MC.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Seleccione Rango de Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.MC, Me.cbParteDia})
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 232)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'cbParteDia
        '
        Me.cbParteDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParteDia.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cbParteDia.Items.AddRange(New Object() {"TODO EL DIA", "MEDIO DIA -AM", "MEDIO DIA -PM"})
        Me.cbParteDia.Location = New System.Drawing.Point(216, 24)
        Me.cbParteDia.Name = "cbParteDia"
        Me.cbParteDia.Size = New System.Drawing.Size(168, 24)
        Me.cbParteDia.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Parte Dia:"
        '
        'frmDarDias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(616, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etDescripcion, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmDarDias"
        Me.Text = "Dias Concedidos al Personal a Cuenta de Vacaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDarDias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Periodo As New VB.SysContab.PeriodoNominaDetails()

        Dim r As New VB.SysContab.RutinasNomina()
        Dim Empleado As New VB.SysContab.EmpleadosDetails(), Emp As New VB.SysContab.EmpleadosDB()
        VB.SysContab.RutinasNomina.CambiarEstilo(Me)

        Periodo = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)

        Me.MC.MinDate = Periodo.FInicio
        Me.MC.MaxDate = Periodo.FFinal
        Me.MC.MaxSelectionCount = DateDiff(DateInterval.Day, Periodo.FInicio, Periodo.FFinal) + 1

        Me.Text = "Dias Concedidos al Personal a Cuenta de Vacaciones"
        If Registro <> "Vacio" Then
            If Not frmDarDias.Todos Then
                Me.etDescripcion.Text = "Para: " + Empleado.Nombre
            Else
                Me.etDescripcion.Text = "Para: Todo el Personal"
            End If
        Else
            Me.etDescripcion.Text = ""
        End If

        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Permisos As New VB.SysContab.PermisosDB()
        Dim Fecha As DateTime
        Dim i, ParteDia As Integer

        Select Case Trim(Me.cbParteDia.Text).ToUpper
            Case "TODO EL DIA"
                ParteDia = 0
            Case "MEDIO DIA -AM"
                ParteDia = 1
            Case "MEDIO DIA -PM"
                ParteDia = 2
        End Select
        For i = 0 To (DateDiff(DateInterval.Day, Me.MC.SelectionStart, Me.MC.SelectionEnd)) '- 1
            Fecha = DateAdd(DateInterval.Day, i, Me.MC.SelectionStart)
            If Registro <> "Vacio" Then 'No Hay empleados en el grid
                If frmDarDias.Todos Then
                    'Borrar los permisos existentes permisos existentes
                    VB.SysContab.PermisosDB.Delete_Dia(Fecha, Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), frmDarDias.Todos, "", ParteDia)
                    VB.SysContab.PermisosDB.Add_Dia(Fecha, Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), frmDarDias.Todos, "", ParteDia)
                Else
                    'Borrar los permisos existentes permisos existentes
                    VB.SysContab.PermisosDB.Delete_Dia(Fecha, Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), frmDarDias.Todos, Registro, ParteDia)
                    VB.SysContab.PermisosDB.Add_Dia(Fecha, Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), frmDarDias.Todos, Registro, ParteDia)
                End If
            Else
                MsgBox("No hay empleados a quien asignar los Días", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next
        MsgBox("Registros Generados Satisfactoriamente", MsgBoxStyle.OKOnly)
    End Sub

End Class
