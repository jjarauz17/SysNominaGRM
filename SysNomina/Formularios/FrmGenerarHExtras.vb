Imports DbConnect
Public Class frmGenerarHExtras
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmGenerarHExtras = Nothing
    Dim Periodo As New VB.SysContab.PeriodoNominaDetails()
    Dim Reloj As New VB.SysContab.RelojDB()
    Dim FInicio, FFinal As Date
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public Shared Function Instance() As frmGenerarHExtras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGenerarHExtras()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPHasta As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.DTPHasta)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtpDesde)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 88)
        Me.GroupBox4.TabIndex = 119
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Horas Extras"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(216, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Hasta:"
        '
        'DTPHasta
        '
        Me.DTPHasta.Checked = False
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(288, 24)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(112, 21)
        Me.DTPHasta.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Desde:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Checked = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(80, 24)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(112, 21)
        Me.dtpDesde.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 40)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(386, 10)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(11, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Generar"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(24, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(464, 20)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(89, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Deshacer"
        '
        'frmGenerarHExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 190)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmGenerarHExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Horas Extras"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGenerarHExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Periodo = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)

        Dim lds As New VB.SysContab.PeriodoNominaDetails()
        lds = VB.SysContab.PeriodoNominaDB.GetListBuscarFInicio(CDate(Format(DateAdd(DateInterval.Day, -1, Periodo.FInicio), "dd/MM/yyyy")), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1))
        If QuincenaTrabajo.Substring(0, 1) = "D" Then
            FInicio = Periodo.FInicio
            FFinal = Periodo.FFinal
        Else
            FInicio = CDate(Reloj.GetList_UltimoDomingoProcesado(QuincenaTrabajo, False))
            FFinal = CDate(Reloj.GetList_DomingoInicioQuincena(QuincenaTrabajo))
        End If


        Me.dtpDesde.MinDate = FInicio
        Me.dtpDesde.MaxDate = FInicio
        Me.DTPHasta.MinDate = DateAdd(DateInterval.Day, 0, FFinal)
        Me.DTPHasta.MaxDate = DateAdd(DateInterval.Day, 0, FFinal)

        Me.Refresh()

    End Sub









    '    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
    '        'Dim MarcaReloj As New VB.SysContab.MarcaRelojDB()
    '        'Dim MarcaRelojDetail As VB.SysContab.MarcaRelojDetails
    '        Dim RegEntSal As New VB.SysContab.RegEntSalDB()
    '        'Dim RegEntSalDetail As VB.SysContab.RegEntSalDetails


    '        Dim EmpleadoHorario As New VB.SysContab.EmpHorarioDB()
    '        Dim EmpHorarioDetail As VB.SysContab.EmpHorarioDetails

    '        Dim Horario As New VB.SysContab.HorarioDB()
    '        Dim HorarioDetail As VB.SysContab.HorarioDetails

    '        Dim HorasExtras As New VB.SysContab.HorasExtrasDB()
    '        Dim HExtrasDetail As New VB.SysContab.HorasExtrasDetails()

    '        Dim ListaEntradas As DataSet

    '        Dim iFecha As DateTime, i As Integer, Horas, HorasEfectivas As Double ', HSalida As DateTime
    '        Dim cEmpleado As String


    '        'Restringir la creacion de horas extras, para los periodos que aun no han tenido planilla generada.

    '        'buscar por cada empleado la forma de pago, para ver como se van a generar las horas extras,
    '        'el campo de hex_quincena realmente llevara el identificador del perido de pago segun las formas de pago activas.

    '        'QuincenaTrabajo = Format(Me.dtpDesde.Value, "yyyy") & Format(Me.dtpDesde.Value, "MM") & _
    '        '   IIf(Me.dtpDesde.Value <= CDate("15/" & Format(Me.dtpDesde.Value, "MM") & "/" & Format(Me.dtpDesde.Value, "yyyy")), "01", "02")

    '        'Borrar primero los registros de la quincena, por si es un reproceso.
    '        HorasExtras.DeleteQuincena(QuincenaTrabajo)
    '        'Calculas las horas extras por dia del empleado. Se agrega un registro si no esta ya en la tabla de horas extras, 
    '        'si ya existe, sumar a la cantidad ya existente.
    '        iFecha = CDate(Format(Me.dtpDesde.Value, "dd/MM/yyyy"))
    '        Do While iFecha <= Me.DTPHasta.Value

    '            ''Obtener las Entradas del dia en proceso
    '            'Registro de Entradas y Salidas de la Fecha
    '            ListaEntradas = RegEntSal.GetListFecha(iFecha, QuincenaTrabajo) 'MarcaReloj.GetListFechaEntrada(iFecha)
    '            i = 0
    '            Do While i < ListaEntradas.Tables("RegEntSal").Rows.Count

    '                cEmpleado = ListaEntradas.Tables("RegEntSal").Rows(i).Item("emp_codigo")
    '                'If cEmpleado = "00000104" Then
    '                '    Dim a As Integer
    '                '    a = 1
    '                'End If
    '                If ListaEntradas.Tables("RegEntSal").Rows(i).Item("Liquidado") Then GoTo EndOfLoop

    '                If Not (ListaEntradas.Tables("RegEntSal").Rows(i).Item("emp_ffincontrato") Is DBNull.Value) Then
    '                    If CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hent"), "dd/MM/yyyy")) > ListaEntradas.Tables("RegEntSal").Rows(i).Item("emp_ffincontrato") Then GoTo EndOfLoop
    '                End If

    '                'Buscar la salida
    '                'MarcaRelojDetail = MarcaReloj.GetDetails(ListaEntradas.Tables("MarcaReloj").Rows(i).Item("emp_codigo"), iFecha, "S")
    '                'RegEntSalDetail = RegEntSal.GetDetails(cEmpleado, iFecha)

    '                'Si tiene marcada de salida
    '                'If MarcaRelojDetail.Empleado <> Nothing Then

    '                'Buscar el horario del empleado
    '                EmpHorarioDetail = EmpleadoHorario.GetDetails(cEmpleado)
    '                If EmpHorarioDetail.Empleado <> Nothing Then
    '                    Select Case Weekday(iFecha)
    '                        Case 1 'Domingo
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Domingo)
    '                        Case 2 'Lunes
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Lunes)
    '                        Case 3 'Martes
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Martes)
    '                        Case 4 'Miercoles
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Miercoles)
    '                        Case 5 'Jueves
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Jueves)
    '                        Case 6 'Viernes
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Viernes)
    '                        Case 7 'Sabado
    '                            HorarioDetail = Horario.GetDetails(EmpHorarioDetail.Sabado)
    '                    End Select
    '                    If HorarioDetail.Codigo = "000" Then 'OFF
    '                        'Si trabajo en dia que tenia libre, se toma todo el periodo como horas extras.
    '                        'Horas = Math.Round(DateDiff(DateInterval.Minute, CDate(Format(CDate(ListaEntradas.Tables("MarcaReloj").Rows(i).Item("mrj_fechahora")), "hh:mm tt")), CDate(Format(CDate(MarcaRelojDetail.DiaHora), "hh:mm tt"))) / 60, 2)
    '                        Horas = Math.Round(DateDiff(DateInterval.Minute, CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hent"), "hh:mm tt")), CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hsal"), "hh:mm tt"))) / 60, 2)

    '                    Else
    '                        ' Restar a la hora de salida real la hora de salida definida por el horario
    '                        'Horas = Math.Round(DateDiff(DateInterval.Minute, CDate(Format(CDate(HorarioDetail.salida), "hh:mm tt")), CDate(Format(CDate(MarcaRelojDetail.DiaHora), "hh:mm tt"))) / 60, 2)
    '                        HorasEfectivas = Math.Round(DateDiff(DateInterval.Minute, CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hent"), "hh:mm tt")), CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hsal"), "hh:mm tt"))) / 60, 2)
    '                        Horas = Math.Round(DateDiff(DateInterval.Minute, CDate(Format(CDate(HorarioDetail.salida), "hh:mm tt")), CDate(Format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_hsal"), "hh:mm tt"))) / 60, 2)
    '                    End If
    '                    If Horas > 0 Then
    '                        ' Tiene horas extras
    '                        'Ver si ya tiene registro en HExtras
    '                        HExtrasDetail = HorasExtras.GetDetails(cEmpleado, QuincenaTrabajo)
    '                        If HExtrasDetail.Empleado = Nothing Then
    '                            HorasExtras.AddItem(cEmpleado, QuincenaTrabajo, Horas, CDate(Format(Me.dtpDesde.Value, "dd/MM/yyyy")), CDate(Format(Me.DTPHasta.Value, "dd/MM/yyyy")))
    '                            RegEntSal.Aplicar(cEmpleado, iFecha)
    '                        Else
    '                            HorasExtras.UpdateSuma(cEmpleado, QuincenaTrabajo, Horas)
    '                            RegEntSal.Aplicar(cEmpleado, iFecha)
    '                        End If
    '                    Else

    '                        ' Salio antes de tiempo
    '                        'Ver si ya tiene registro en HExtras
    '                        HExtrasDetail = HorasExtras.GetDetails(cEmpleado, QuincenaTrabajo)
    '                        If HExtrasDetail.Empleado = Nothing Then
    '                            HorasExtras.AddItem(cEmpleado, QuincenaTrabajo, HorasEfectivas, CDate(Format(Me.dtpDesde.Value, "dd/MM/yyyy")), CDate(Format(Me.DTPHasta.Value, "dd/MM/yyyy")))
    '                            RegEntSal.Aplicar(cEmpleado, iFecha)
    '                        Else
    '                            HorasExtras.UpdateSuma(cEmpleado, QuincenaTrabajo, HorasEfectivas)
    '                            RegEntSal.Aplicar(cEmpleado, iFecha)
    '                        End If
    '                    End If 'format(ListaEntradas.Tables("RegEntSal").Rows(i).Item("res_fecha"), "hh:mm tt")
    '                End If

    '                'End If
    'EndOfLoop:      i = i + 1
    '            Loop

    '            iFecha = DateAdd(DateInterval.Day, 1, iFecha)
    '        Loop
    '        MsgBox("Las horas extras fueron generadas.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Generaci�n exitosa")
    '        'seria bueno poner aca una instruccion para enviar a cada jefe de area un mensaje por correo para que revisen las horas
    '        'extras.

    '        Me.Close()
    '    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Periodo.Procesado = True Then
            MsgBox("No se pueden generar horas extras para un periodo ya procesado", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim Semana As Date
        Dim i As Integer
        Dim lDS As New DataSet()
        Dim HExtrasDetail As New VB.SysContab.HorasExtrasDetails()

        Semana = FInicio 'Ya sabemos que es domingo de inicio
        Do While Semana <= DateAdd(DateInterval.Day, -1, FFinal)
            Dim r As Integer = DatePart(DateInterval.Weekday, Semana)
            lDS.Clear()
            lDS = Reloj.GetList_HESemana(Semana, Periodo.Tipo)
            For i = 0 To lDS.Tables(0).Rows.Count - 1
                'Ver si ya tiene registro en HExtras
                HExtrasDetail = VB.SysContab.HorasExtrasDB.GetDetails(lDS.Tables(0).Rows(i)("emp_codigo"), QuincenaTrabajo)
                If HExtrasDetail.Empleado = Nothing Then
                    'se quito esta linea por el cambio de tabla del reloj a asistencias, para el tipo destajo
                    'IIf(Microsoft.VisualBasic.Left(QuincenaTrabajo, 1) = "D", lDS.Tables(0).Rows(i)("he2"), lDS.Tables(0).Rows(i)("he")), _
                    VB.SysContab.HorasExtrasDB.Additem(lDS.Tables(0).Rows(i)("emp_codigo"), _
                        QuincenaTrabajo, _
                        lDS.Tables(0).Rows(i)("he"), _
                        FInicio, _
                        IIf(Periodo.Tipo = "D", FFinal, DateAdd(DateInterval.Day, -1, FFinal)))
                    Reloj.Aplicar_Reloj(lDS.Tables(0).Rows(i)("emp_codigo"), Semana, Periodo.Tipo)
                Else
                    VB.SysContab.HorasExtrasDB.UpdateSuma(lDS.Tables(0).Rows(i)("emp_codigo"), _
                        QuincenaTrabajo, _
                        lDS.Tables(0).Rows(i)("he"))
                    Reloj.Aplicar_Reloj(lDS.Tables(0).Rows(i)("emp_codigo"), Semana, Periodo.Tipo)
                End If
            Next

            'La siguiente semana
            Semana = DateAdd(DateInterval.Day, 7, Semana)
        Loop

        MsgBox("Horas extras generadas", MsgBoxStyle.Information, "SysNomina")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Periodo.Procesado = True Then
            MsgBox("No se puede deshacer las horas extras de un periodo procesado", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("hex_quincena", SqlDbType.NVarChar, 9, ParameterDirection.Input, Periodo.Tipo & Periodo.Codigo)
        Try
            v.EjecutarComando("_HorasExtras_Undo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        v = Nothing
    End Sub
End Class
