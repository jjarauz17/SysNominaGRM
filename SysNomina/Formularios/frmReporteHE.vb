Imports System.IO
Public Class frmReporteHE
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmReporteHE = Nothing

    Public Shared Function Instance() As frmReporteHE
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReporteHE()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    'Dim rEmpleados As New rptEmpleados()
    Dim rEmpleados As Object
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbPNomina As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPNomina = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.cbPNomina, Me.Label6, Me.cbEmpleados, Me.Label3, Me.cbArea, Me.Label1, Me.cbDepartamentos, Me.cbMonedaCambio, Me.Label4})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 224)
        Me.GroupBox4.TabIndex = 150
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Periodo Nómina"
        '
        'cbPNomina
        '
        Me.cbPNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPNomina.ItemHeight = 15
        Me.cbPNomina.Location = New System.Drawing.Point(136, 144)
        Me.cbPNomina.Name = "cbPNomina"
        Me.cbPNomina.Size = New System.Drawing.Size(304, 23)
        Me.cbPNomina.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Area"
        '
        'cbArea
        '
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArea.ItemHeight = 15
        Me.cbArea.Location = New System.Drawing.Point(136, 104)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(304, 23)
        Me.cbArea.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
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
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdAceptar})
        Me.GroupBox3.Location = New System.Drawing.Point(136, 240)
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
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(136, 176)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(304, 23)
        Me.cbMonedaCambio.TabIndex = 151
        '
        'frmReporteHE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(504, 325)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.GroupBox3})
        Me.Name = "frmReporteHE"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        cbPNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        cbPNomina.ValueMember = "per_codigo"
        cbPNomina.DisplayMember = "per_descripcion"
        cbPNomina.SelectedValue = 0

        cbArea.DataSource = VB.SysContab.AreaDB.GetList().Tables(0)
        cbArea.ValueMember = "Area"
        cbArea.DisplayMember = "Descripcion"
        cbArea.SelectedValue = 0

        Me.cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        Me.cbMonedaCambio.ValueMember = "MonedaCambio"
        Me.cbMonedaCambio.DisplayMember = "Nombre"

        Me.Refresh()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()
        'Dim RHE As New rptHorasExtras()
        Dim RHE As Object
        RHE = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptHorasExtras.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptHorasExtras.rpt")
            Exit Sub
        End If

        RHE.load(Application.StartupPath & "\reportes\rptHorasExtras.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Ds As New DataSet

        Ds = VB.SysContab.HorasExtrasDB.GetListReporte(Me.cbEmpleados.SelectedValue, Me.cbPNomina.SelectedValue, Me.cbDepartamentos.SelectedValue, Me.cbArea.SelectedValue, Me.cbMonedaCambio.SelectedValue)
        Ds.WriteXml(Application.StartupPath & "\exportfiles\rHorasExtras.xml", XmlWriteMode.WriteSchema)

        RHE.Database.Tables("HorasExtras").Location = Application.StartupPath & "\exportfiles\rHorasExtras.xml"
        RHE.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        fReportes.crvReportes.ReportSource = RHE
        fReportes.ShowDialog()


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

End Class
