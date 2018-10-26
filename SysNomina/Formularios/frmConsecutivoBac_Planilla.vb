Public Class frmConsecutivoBac_Planilla
    Inherits System.Windows.Forms.Form
    Public frmDesde As Date, frmHasta As Date

    'Private Shared ChildInstance As frmConsecutivoBac_Planilla = Nothing

    'Public Shared Function Instance() As frmConsecutivoBac_Planilla
    '    If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
    '        ChildInstance = New frmConsecutivoBac_Planilla()
    '    End If
    '    ChildInstance.BringToFront()

    '    Return ChildInstance
    'End Function


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConsecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAPagar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAPagar = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Digite # Consecutivo:"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsecutivo.Location = New System.Drawing.Point(160, 40)
        Me.txtConsecutivo.MaxLength = 5
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Size = New System.Drawing.Size(120, 20)
        Me.txtConsecutivo.TabIndex = 125
        Me.txtConsecutivo.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "A pagar el dia:"
        '
        'dtpAPagar
        '
        Me.dtpAPagar.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpAPagar.Location = New System.Drawing.Point(160, 72)
        Me.dtpAPagar.Name = "dtpAPagar"
        Me.dtpAPagar.Size = New System.Drawing.Size(136, 20)
        Me.dtpAPagar.TabIndex = 127
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(208, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 128
        Me.Button1.Text = "Salir"
        '
        'frmConsecutivoBac_Planilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(338, 175)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.dtpAPagar, Me.Label2, Me.txtConsecutivo, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConsecutivoBac_Planilla"
        Me.Text = "Consecutivo Planilla Electrónica BAC"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtConsecutivo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsecutivo.Enter
        If Len(Me.txtConsecutivo.Text) < 5 Then
            MsgBox("El Codigo consecutivo definido para el banco debe ser de 5 caracteres de longitud")
            Exit Sub
        End If
        ConsecutivoBac_Planilla = Me.txtConsecutivo.Text
        FechaPagoPlanilla = Me.dtpAPagar.Value

    End Sub

    Private Sub frmConsecutivoBac_Planilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtConsecutivo.Text = ConsecutivoBac_Planilla
        Me.dtpAPagar.Value = Me.frmHasta
        Me.Refresh()
    End Sub


    Private Sub frmConsecutivoBac_Planilla_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ConsecutivoBac_Planilla = Me.txtConsecutivo.Text
        FechaPagoPlanilla = Me.dtpAPagar.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
