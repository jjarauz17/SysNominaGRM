Imports System.IO
Public Class frmActivoEmpleado
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmActivoEmpleado = Nothing

    Public Shared Function Instance() As frmActivoEmpleado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmActivoEmpleado()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgActivosEmpleados As System.Windows.Forms.DataGrid
    Friend WithEvents etNombreEmpleado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.etNombreEmpleado = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgActivosEmpleados = New System.Windows.Forms.DataGrid()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgActivosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.etNombreEmpleado, Me.etDescripcion})
        Me.GroupBox7.Location = New System.Drawing.Point(40, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(656, 32)
        Me.GroupBox7.TabIndex = 118
        Me.GroupBox7.TabStop = False
        '
        'etNombreEmpleado
        '
        Me.etNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombreEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.etNombreEmpleado.Location = New System.Drawing.Point(184, 8)
        Me.etNombreEmpleado.Name = "etNombreEmpleado"
        Me.etNombreEmpleado.Size = New System.Drawing.Size(472, 20)
        Me.etNombreEmpleado.TabIndex = 114
        Me.etNombreEmpleado.Text = "EMPLEADO"
        Me.etNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.etDescripcion.Text = "ACTIVOS DEL EMPLEADO:"
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAyuda, Me.cmdSalir, Me.cmdImprimir, Me.cmdBorrar})
        Me.GroupBox1.Location = New System.Drawing.Point(40, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 48)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(208, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 5
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(304, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(16, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 3
        Me.cmdBorrar.Text = "Borrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgActivosEmpleados})
        Me.GroupBox2.Location = New System.Drawing.Point(40, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 400)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        '
        'dgActivosEmpleados
        '
        Me.dgActivosEmpleados.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivosEmpleados.DataMember = ""
        Me.dgActivosEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivosEmpleados.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivosEmpleados.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgActivosEmpleados.Location = New System.Drawing.Point(16, 16)
        Me.dgActivosEmpleados.Name = "dgActivosEmpleados"
        Me.dgActivosEmpleados.ReadOnly = True
        Me.dgActivosEmpleados.Size = New System.Drawing.Size(632, 360)
        Me.dgActivosEmpleados.TabIndex = 7
        '
        'frmActivoEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(848, 542)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox7, Me.GroupBox1, Me.GroupBox2})
        Me.Name = "frmActivoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgActivosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub frmActivoEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
        Dim ds As DataSet

        Dim Tabla As DataTable



        ds = Activos_Fijos.GetListActivoEmpleado(Registro)

        dgActivosEmpleados.DataSource = ds.Tables("Activo_Fijos").DefaultView 'Activos_Fijos.GetListActivoEmpleado(Registro).Tables("Activo_Fijos").DefaultView
        Tabla = ds.Tables("Activo_Fijos")

        VB.SysContab.RutinasNomina.FormatGenerico(dgActivosEmpleados, Tabla)


        If ds.Tables("Activo_fijos").Rows.Count > 0 Then
            etNombreEmpleado.Text = ds.Tables("Activo_Fijos").Rows(0).Item("NOMBRE")
        End If

        dgActivosEmpleados.CaptionText = "Activos del Empleado"

        Me.Refresh()

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rActivosEmpleado As New rptActivosEmpleados()
        Dim rActivosEmpleado As Object
        rActivosEmpleado = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptActivosEmpleados.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptActivosEmpleados.rpt")
            Exit Sub
        End If

        rActivosEmpleado.load(Application.StartupPath & "\reportes\rptActivosEmpleados.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim ActivosEmpleado As New VB.SysContab.Activo_FijosDB()
        Dim r As New VB.SysContab.RutinasNomina()

        rActivosEmpleado.SetDataSource(ActivosEmpleado.GetListReporte(Registro))
        fReportes.crvReportes.ReportSource = rActivosEmpleado
        fReportes.ShowDialog()

    End Sub
End Class
