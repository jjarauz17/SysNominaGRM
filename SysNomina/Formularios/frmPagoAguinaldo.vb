Imports System.IO
Imports System.Data.SqlClient

Public Class frmPagoAguinaldo
    Inherits System.Windows.Forms.Form

    Dim rAguinaldo As New VB.SysContab.AguinaldoDB()

    Friend WithEvents chkDetalle As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.TextEdit

    Private Shared ChildInstance As frmPagoAguinaldo = Nothing
    Public Shared Function Instance() As frmPagoAguinaldo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPagoAguinaldo()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Public Shared Todos As Boolean
    Dim ProximoMes As String

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
    Friend WithEvents MCDesde As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MCHasta As System.Windows.Forms.MonthCalendar
    Friend WithEvents ckbSobreGiro As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents cmdReporte As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbSobreGiro = New System.Windows.Forms.CheckBox()
        Me.chkDetalle = New System.Windows.Forms.CheckBox()
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.MCDesde = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConcepto = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MCHasta = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ckbSobreGiro)
        Me.GroupBox2.Controls.Add(Me.chkDetalle)
        Me.GroupBox2.Controls.Add(Me.cmdReporte)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(660, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 344)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'ckbSobreGiro
        '
        Me.ckbSobreGiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbSobreGiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbSobreGiro.Location = New System.Drawing.Point(8, 192)
        Me.ckbSobreGiro.Name = "ckbSobreGiro"
        Me.ckbSobreGiro.Size = New System.Drawing.Size(95, 24)
        Me.ckbSobreGiro.TabIndex = 128
        Me.ckbSobreGiro.Text = "Generar Ajustes por Sobregiro?"
        Me.ckbSobreGiro.Visible = False
        '
        'chkDetalle
        '
        Me.chkDetalle.AutoSize = True
        Me.chkDetalle.Location = New System.Drawing.Point(6, 118)
        Me.chkDetalle.Name = "chkDetalle"
        Me.chkDetalle.Size = New System.Drawing.Size(97, 19)
        Me.chkDetalle.TabIndex = 31
        Me.chkDetalle.Text = "Ver Detalle"
        Me.chkDetalle.UseVisualStyleBackColor = True
        '
        'cmdReporte
        '
        Me.cmdReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporte.ForeColor = System.Drawing.Color.Black
        Me.cmdReporte.Location = New System.Drawing.Point(8, 24)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(96, 24)
        Me.cmdReporte.TabIndex = 30
        Me.cmdReporte.Text = "Reporte"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 88)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 56)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 24)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Generar Pago"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(24, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(616, 20)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.Text = "PAGO DE AGUINALDO"
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MCDesde
        '
        Me.MCDesde.Location = New System.Drawing.Point(64, 16)
        Me.MCDesde.Name = "MCDesde"
        Me.MCDesde.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Desde:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 344)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Mensaje:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(112, 248)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(384, 80)
        Me.txtComentarios.TabIndex = 137
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtConcepto)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 48)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(119, 19)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.MaxLength = 50
        Me.txtConcepto.Size = New System.Drawing.Size(356, 20)
        Me.txtConcepto.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.MCHasta)
        Me.GroupBox4.Controls.Add(Me.MCDesde)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 176)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(248, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Hasta:"
        '
        'MCHasta
        '
        Me.MCHasta.Location = New System.Drawing.Point(304, 16)
        Me.MCHasta.Name = "MCHasta"
        Me.MCHasta.TabIndex = 126
        '
        'frmPagoAguinaldo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 465)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPagoAguinaldo"
        Me.Text = "Dias Concedidos al Personal a Cuenta de Vacaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPagoAguinaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Empresa As New VB.SysContab.EmpresasDetails()
        Dim Empleado As New VB.SysContab.EmpleadosDetails()
        Dim DDesde, DHasta As DateTime



        Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        ProximoMes = IIf(Val(Microsoft.VisualBasic.Right(Empresa.UMESPAGOAGU, 2)) + 1 = 13, _
                    Trim(Str(Val(Microsoft.VisualBasic.Left(Empresa.UMESPAGOAGU, 4)) + 1)) + "01", _
                    Trim(Str(Val(Microsoft.VisualBasic.Left(Empresa.UMESPAGOAGU, 4)))) + Trim(Str(Val(Microsoft.VisualBasic.Right(Empresa.UMESPAGOAGU, 2)) + 1)))

        If Microsoft.VisualBasic.Right(ProximoMes, 2) <> Empresa.MESPAGOAGUINALDO Then
            'el pago del aguinaldo anterior no corresponde al periodo..
            XtraMsg("Hay un error en la fecha del ultimo pago de aguinaldo, consultar con el administrador", MsgBoxStyle.Critical)
            Me.Close()
        End If

        DDesde = CDate("01/" + Microsoft.VisualBasic.Right(ProximoMes, 2) + "/" + Microsoft.VisualBasic.Left(ProximoMes, 4))
        DHasta = CDate(Trim(Str(Meses(Val(Microsoft.VisualBasic.Right(ProximoMes, 2)) - 2))) + Str(Val(Microsoft.VisualBasic.Right(ProximoMes, 2)) - 1) + "/" + Str(Val(Microsoft.VisualBasic.Left(ProximoMes, 4) + 1)))

        Me.MCDesde.SelectionStart = DDesde
        Me.MCDesde.SelectionEnd = DDesde
        Me.MCDesde.MaxSelectionCount = 1


        Me.MCHasta.SelectionStart = DHasta
        Me.MCHasta.SelectionEnd = DHasta
        Me.MCHasta.MaxSelectionCount = 1



        Me.Text = "Pago de Aguinaldo al Personal"

        Me.MCDesde.Enabled = False
        Me.MCHasta.Enabled = False
        Me.chkDetalle.Checked = False
        Me.txtConcepto.Text = "Aguinaldo del Periodo " & Me.MCDesde.SelectionStart.Date & " - " & Me.MCHasta.SelectionStart.Date
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim Codigo As String
        Dim FechaInicio, FechaFinal As Date
        Dim Periodo As Integer
        Periodo = VB.SysContab.PeriodosDB.Activo(Me.MCHasta.SelectionStart.Date)
        FechaInicio = VB.SysContab.PeriodosDB.GetDetails(Periodo).Inicio
        FechaFinal = VB.SysContab.PeriodosDB.GetDetails(Periodo).Final
        Dim Moneda As String

        Moneda = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE

        'Dim FInicio, Ffinal As Date

        Dim cAFiscal As Int16
        cAFiscal = VB.SysContab.PeriodosDB.Activo(Me.MCHasta.SelectionStart.Date)

        Dim AFiscal As String
        Codigo = Microsoft.VisualBasic.Right(Me.MCHasta.SelectionStart.Date.ToShortDateString, 4) & _
                 Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 1, Me.MCHasta.SelectionStart.Date).ToShortDateString, 4, 2) + "01"
        If Me.MCHasta.SelectionStart.Date >= FechaInicio And _
            Me.MCHasta.SelectionStart.Date <= FechaFinal Then

            AFiscal = DatePart(DateInterval.Year, FechaInicio) & "-" & _
                    DatePart(DateInterval.Year, FechaFinal)
        Else
            MsgBox("Esta intentando generar Aguinaldo que esta fuera del año fiscal actual de la empresa", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Me.txtConcepto.Text.Length < 25 Then
            MsgBox("Por favor digite un concepto de pago de aguinaldo mas largo que 25 caracteres")
            Exit Sub
        End If

        VB.SysContab.PeriodoNominaDB.Additem(Codigo, Me.txtConcepto.Text, _
            Me.MCDesde.SelectionStart, Me.MCHasta.SelectionStart, "A", _
            AFiscal, VB.SysContab.RutinasNomina.BuscarSabados(Me.MCDesde.SelectionStart, Me.MCHasta.SelectionStart), _
            Me.txtComentarios.Text, "P", -1, False, cAFiscal, Today.Date, Today.Date, Me.MCHasta.SelectionStart.AddDays(10))

        'Tomar todos los empleados activos y procesar su aguinaldo
        Dim NvoCodigo As String
        Dim ds As DataSet, i As Integer, dsAguinaldo As DataSet

        ds = VB.SysContab.EmpleadosDB.GetLists()
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)("emp_ffincontrato") Is DBNull.Value Then
                    NvoCodigo = VB.SysContab.IngresoDB.GetListCodigoNvo()
                    dsAguinaldo = rAguinaldo.GetList(ds.Tables(0).Rows(i)("emp_codigo"), "A", False)
                    If Not (dsAguinaldo Is Nothing) And dsAguinaldo.Tables(0).Rows.Count > 0 Then
                        'ds.Tables(0).Rows(i)("mon_codigo"), _
                        VB.SysContab.IngresoDB.IngresoAguinaldo(NvoCodigo, ds.Tables(0).Rows(i)("emp_codigo"), Now, Now, _
                            dsAguinaldo.Tables(0).Rows(0)("emp_acumaguinaldo"), dsAguinaldo.Tables(0).Rows(0)("VAguinaldo"), "010", True, Moneda, _
                            True, Codigo, "A")
                        VB.SysContab.EmpleadosDB.UpdateAguinaldo_Decrease(ds.Tables(0).Rows(i)("emp_codigo"), dsAguinaldo.Tables(0).Rows(0)("Emp_acumaguinaldo"))
                    End If
                End If
            Next
        End If

        'Generar la Planilla de Aguinaldo
        VB.SysContab.PlanillaDB.Additem(Codigo, "A", False)
        VB.SysContab.PlanillaDDB.AddDI(Codigo, "A", False)
        VB.SysContab.PlanillaDDB.AddDD(Codigo, "A", False)
        VB.SysContab.PlanillaDB.Update_IR_INSS(Codigo, "A")
        VB.SysContab.EmpresasDB.UpdateAguinaldo(EmpresaActual, Me.MCHasta.SelectionStart.Year.ToString & Me.MCHasta.SelectionStart.Month.ToString)
        XtraMsg("Registros Generados Satisfactoriamente")

        'actualizar el periodo de nomina de aguinaldo generado
        VB.SysContab.PeriodoNominaDB.Procesado(Codigo, "A", Now, False)
    End Sub

    'Private Sub MCDesde_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCDesde.DateSelected
    '    Me.MCHasta.MinDate = Me.MCDesde.SelectionStart  ' en teoria deberia ser solo un dia seleccionado
    '    If Me.MCHasta.SelectionStart < Me.MCDesde.SelectionStart Then
    '        Me.MCHasta.SelectionStart = Me.MCDesde.SelectionStart
    '    End If
    'End Sub

    Private Sub cmdReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporte.Click
        ShowSplash("Generando Reporte...")


        Dim fReportes As New frmReportes()
        Dim dsAguinaldo As New DataSet()
        Dim dt As New DataTable

        'Dim Reporte As New rptAcumuladoAguinaldo()
        'Dim Reporte As New Object
        'Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptAcumuladoAguinaldo.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptAcumuladoAguinaldo.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptAcumuladoAguinaldo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Aguinaldo As New VB.SysContab.AguinaldoDB

        dsAguinaldo = Aguinaldo.GetList("%", "A", Me.chkDetalle.Checked)
        dsAguinaldo.WriteXml(Application.StartupPath & "\exportfiles\rAcumuladoAguinaldo.xml", XmlWriteMode.WriteSchema)
        dsAguinaldo.Dispose()
        dt = VB.SysContab.AguinaldoDB.GetListDetalle("%", Me.MCHasta.SelectionStart.Date, Me.MCHasta.SelectionStart.Date)

        If dt Is Nothing Then
            HideSplash()
            Exit Sub
        Else
            dt.WriteXml(Application.StartupPath & "\exportfiles\rAcumuladoAguinaldo_Detalle.xml", XmlWriteMode.WriteSchema)
            dt.Dispose()
        End If

        Reporte.Database.Tables("AcumuladoAguinaldo").Location = Application.StartupPath & "\exportfiles\rAcumuladoAguinaldo.xml"
        Reporte.Database.Tables("Detalle").Location = Application.StartupPath & "\exportfiles\rAcumuladoAguinaldo_Detalle.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        ' frmReportesCR.crvReportes.ReportSource = Reporte
        fReportes.crvReportes.ReportSource = Reporte
        fReportes.crvReportes.Zoom(91)
        fReportes.Show()
        '
        HideSplash()
    End Sub
End Class
