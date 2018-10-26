Imports System.Data.SqlClient
Public Class frmPagoVacaciones
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmPagoVacaciones = Nothing
    Public Shared Function Instance() As frmPagoVacaciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPagoVacaciones()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rgUltimo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents NDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Public Shared Todos As Boolean
    Public Shared Cantidad As Decimal
    Public Shared Datos As DataTable

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.MCDesde = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.NDias = New DevExpress.XtraEditors.SpinEdit
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rgUltimo = New DevExpress.XtraEditors.RadioGroup
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ckbSobreGiro = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MCHasta = New System.Windows.Forms.MonthCalendar
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.rgUltimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(528, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 320)
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
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(24, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(608, 20)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.Text = "PAGO DE VACACIONES"
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
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NDias)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 320)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Dias a Pagar:"
        Me.Label3.Visible = False
        '
        'NDias
        '
        Me.NDias.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NDias.Location = New System.Drawing.Point(130, 110)
        Me.NDias.Name = "NDias"
        Me.NDias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NDias.Properties.Appearance.Options.UseFont = True
        Me.NDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.NDias.Properties.EditFormat.FormatString = "n0"
        Me.NDias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NDias.Properties.Mask.EditMask = "n2"
        Me.NDias.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NDias.Size = New System.Drawing.Size(65, 20)
        Me.NDias.TabIndex = 132
        Me.NDias.ToolTip = "Si es 0, se pagaran todas las que tiene disponible el empleado"
        Me.NDias.ToolTipTitle = "Sts.Nomina"
        Me.NDias.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rgUltimo)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(488, 48)
        Me.GroupBox5.TabIndex = 131
        Me.GroupBox5.TabStop = False
        '
        'rgUltimo
        '
        Me.rgUltimo.Location = New System.Drawing.Point(13, 16)
        Me.rgUltimo.Name = "rgUltimo"
        Me.rgUltimo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.rgUltimo.Properties.Appearance.Options.UseBackColor = True
        Me.rgUltimo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Salario Promedio"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Ultimo Salario")})
        Me.rgUltimo.Size = New System.Drawing.Size(449, 25)
        Me.rgUltimo.TabIndex = 0
        Me.rgUltimo.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckbSobreGiro)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 48)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'ckbSobreGiro
        '
        Me.ckbSobreGiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbSobreGiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbSobreGiro.Location = New System.Drawing.Point(16, 16)
        Me.ckbSobreGiro.Name = "ckbSobreGiro"
        Me.ckbSobreGiro.Size = New System.Drawing.Size(304, 24)
        Me.ckbSobreGiro.TabIndex = 128
        Me.ckbSobreGiro.Text = "Generar Ajustes por Sobregiro?"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.MCHasta)
        Me.GroupBox4.Controls.Add(Me.MCDesde)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 129)
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
        'frmPagoVacaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 432)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPagoVacaciones"
        Me.Text = "Dias Concedidos al Personal a Cuenta de Vacaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.rgUltimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPagoVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Emp As New VB.SysContab.EmpresasDB()
        Dim r As New VB.SysContab.RutinasNomina()
        Dim Empleado As New VB.SysContab.EmpleadosDetails()
        Dim Empl As New VB.SysContab.EmpleadosDB()
        Dim pn As New VB.SysContab.PeriodoNominaDetails()
        Dim pndb As New VB.SysContab.PeriodoNominaDB()
        Dim ds As New DataSet()

        VB.SysContab.RutinasNomina.CambiarEstilo(Me)
        Me.rgUltimo.EditValue = True
        'ds = Emp.GetListFechasVacaciones
        pn = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)
        'ds.Tables("Empresas").Rows(0)("Desde")
        If Not IsNothing(pn.FInicio) Then

            Me.MCDesde.SelectionStart = pn.FInicio 'ds.Tables("Empresas").Rows(0)("Desde")
            Me.MCDesde.SelectionEnd = pn.FInicio 'ds.Tables("Empresas").Rows(0)("Desde")
            Me.MCDesde.MaxSelectionCount = 1

            Me.MCDesde.MinDate = pn.FInicio 'ds.Tables("Empresas").Rows(0)("Desde")
            Me.MCDesde.MaxDate = pn.FFinal  'ds.Tables("Empresas").Rows(0)("Hasta")

            Me.MCHasta.SelectionStart = pn.FFinal  'ds.Tables("Empresas").Rows(0)("Hasta")
            Me.MCHasta.SelectionEnd = pn.FFinal  'ds.Tables("Empresas").Rows(0)("Hasta")
            Me.MCHasta.MaxSelectionCount = 1

            Me.MCHasta.MinDate = pn.FInicio 'ds.Tables("Empresas").Rows(0)("Desde")
            Me.MCHasta.MaxDate = pn.FFinal  'ds.Tables("Empresas").Rows(0)("Hasta")


        End If

        Me.Text = "Pago de Vacaciones al Personal"
        If Registro Is Nothing Then
            Empleado = VB.SysContab.EmpleadosDB.GetDetails("")
        Else
            Empleado = VB.SysContab.EmpleadosDB.GetDetails(Registro)
        End If

        If Registro <> "Vacio" Then
            If Not frmPagoVacaciones.Todos Then
                Me.etDescripcion.Text = "Pago de Vacaciones Para: " + Empleado.Nombre + "- Dias: " + frmPagoVacaciones.Cantidad.ToString
            Else
                Me.etDescripcion.Text = "Pago de Vacaciones Para: Todo el Personal"
            End If
        Else
            Me.etDescripcion.Text = ""
        End If
        Me.MCDesde.Enabled = False
        Me.rgUltimo.EditValue = 0
        If Todos = True Then
            Me.NDias.Visible = False
        Else : Me.NDias.Visible = True
        End If
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As New VB.SysContab.VacacionesDB()
        Dim P As New VB.SysContab.PermisosDB()

        Dim Empresa As New VB.SysContab.EmpresasDB()
        Dim ds As New DataSet  ', Desde, Hasta As String
        Dim i As Integer

        'Desde = Str(Year(Me.MCDesde.SelectionStart)) + DatePart(DateInterval.Month, Me.MCDesde.SelectionStart)
        'Hasta = DatePart(DateInterval.Year, Me.MCHasta.SelectionStart) + DatePart(DateInterval.Month, Me.MCHasta.SelectionStart)

        If (frmPagoVacaciones.Todos And Microsoft.VisualBasic.Left(QuincenaTrabajo, 1) <> "V") Then
            MsgBox("No se puede generar una pago de vacaciones para todo el personal si el periodo no corresponde a ese tipo de nomina", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim ultimo As Boolean

        ultimo = Me.rgUltimo.EditValue

        If frmPagoVacaciones.Todos Then
            ds = V.GetList("", Me.MCDesde.SelectionStart, Me.MCHasta.SelectionStart, frmPagoVacaciones.Todos, _
                QuincenaTrabajo.Substring(1, 8), QuincenaTrabajo.Substring(0, 1), _
                ultimo, Me.NDias.Value)
        Else
            If Registro = "Vacio" Then
                MsgBox("No hay registros para generar las vacaciones", MsgBoxStyle.OkOnly)
                Exit Sub
            Else
                ds = V.GetList(Registro, Me.MCDesde.SelectionStart, Me.MCHasta.SelectionStart, 0, _
                Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                ultimo, Me.NDias.Value)
            End If
        End If

        DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
        DBConnexion.Open()
        transaccion = DBConnexion.BeginTransaction
        Dim rregistro() As DataRow
        Try
            'Procesar los registros
            For i = 0 To ds.Tables("Vacaciones").Rows.Count - 1
                If ds.Tables("Vacaciones").Rows(i)("APagar") > 0 Then

                    rregistro = Datos.Select("Codigo = '" + ds.Tables("Vacaciones").Rows(i)("Codigo") + "'")
                    If rregistro.GetUpperBound(0) = 0 Then
                        'Agregar el registro en la tabla de Vacaciones
                        'V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                        '    Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
                        '    Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                        '    ds.Tables("Vacaciones").Rows(i)("Desde"), _
                        '    ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                        '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
                        '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                        '    Math.Round(ds.Tables("Vacaciones").Rows(i)("VDias"), 2), _
                        '    Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2), _
                        '    Math.Round(ds.Tables("Vacaciones").Rows(i)("VAPagar"), 2), True)

                        'rregistro(0)("A Pagar")
                        If rregistro(0)("A Pagar") > 0 Then
                            V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                                                       Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
                                                       Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                                                       ds.Tables("Vacaciones").Rows(i)("Desde"), _
                                                       ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                                                       Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
                                                       Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                                                       Math.Round(ds.Tables("Vacaciones").Rows(i)("VDias"), 2), _
                                                       Math.Round(rregistro(0)("A Pagar"), 2), _
                                                       Math.Round(Math.Round(rregistro(0)("A Pagar"), 2) * rregistro(0)("ValorDia"), 2), True)


                            'Aplicar los Permisos a Cuenta de Vacaciones del periodo
                            VB.SysContab.PermisosDB.AplicarVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                                ds.Tables("Vacaciones").Rows(i)("Desde"), _
                                ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                                "V")
                            'Actualizar Acumulados de Vacaciones en la tabla empleados
                            'VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2))
                            VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            Math.Round(rregistro(0)("A Pagar"), 2))
                        End If

                    End If
                Else
                    'hacer las transacciones para cobrar los sobregiros de vacaciones
                    If Me.ckbSobreGiro.Checked Then
                        rregistro = Datos.Select("Codigo = '" + ds.Tables("Vacaciones").Rows(i)("Codigo") + "'")
                        If rregistro.GetUpperBound(0) = 0 Then
                            'Agregar el registro en la tabla de Vacaciones
                            'V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                            '    Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
                            '    Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                            '    ds.Tables("Vacaciones").Rows(i)("Desde"), _
                            '    ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("vDias"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("VAPagar"), 2), True)

                            V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                                Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
                                Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                                ds.Tables("Vacaciones").Rows(i)("Desde"), _
                                ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                                Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("vDias"), 2), _
                            Math.Round(rregistro(0)("A Pagar"), 2), _
                            Math.Round(Math.Round(rregistro(0)("A Pagar"), 2) * rregistro(0)("ValorDia"), 2), True)

                            'Aplicar los Permisos a Cuenta de Vacaciones del periodo
                            VB.SysContab.PermisosDB.AplicarVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                                ds.Tables("Vacaciones").Rows(i)("Desde"), _
                                ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                                "V")
                            'Actualizar Acumulados de Vacaciones en la tabla empleados
                            'VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            'Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2))

                            VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
                           Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                           Math.Round(rregistro(0)("A Pagar"), 2))
                        End If

                    Else
                        'Agregar el registro en la tabla de Vacaciones
                        V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                            Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
                            Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
                            ds.Tables("Vacaciones").Rows(i)("Desde"), _
                            ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                            Math.Round(ds.Tables("Vacaciones").Rows(i)("vDias"), 2), _
                            0, 0, True)

                        'Aplicar los Permisos a Cuenta de Vacaciones del periodo
                        VB.SysContab.PermisosDB.AplicarVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
                            ds.Tables("Vacaciones").Rows(i)("Desde"), _
                            ds.Tables("Vacaciones").Rows(i)("Hasta"), _
                            "V")
                        'Actualizar Acumulados de Vacaciones en la tabla empleados
                        VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
                        Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
                        0)
                    End If
                End If


            Next
            If frmPagoVacaciones.Todos Then
                Empresa.UpdateVacaciones(EmpresaActual, Format(Me.MCHasta.SelectionStart, "yyyyMM")) '.Year.ToString & Me.MCHasta.SelectionStart.Month.ToString)
            End If
        Catch ex As Exception
            transaccion.Rollback()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        transaccion.Commit()
        DBConnexion.Close()

        MsgBox("Registro(s) guardatos satisfactoriamente", MsgBoxStyle.Information, "Sts.Nomina")
        Me.Close()
        ''Original de Almori
        'Try
        '    'Procesar los registros
        '    For i = 0 To ds.Rows.Count - 1
        '        'If ds.Rows(i)("APagar") > 0 Then
        '        If ds.Rows(i)("Disponibles") > 0 Then
        '            'Agregar el registro en la tabla de Vacaciones
        '            V.AddVacaciones(ds.Rows(i)("Codigo"), _
        '                Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
        '                Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
        '                ds.Rows(i)("Desde"), _
        '                ds.Rows(i)("Hasta"), _
        '                Math.Round(ds.Rows(i)("Disponibles"), 2) + Math.Round(ds.Rows(i)("Dias Descansados"), 2), _
        '                Math.Round(ds.Rows(i)("Dias Descansados"), 2), _
        '                Math.Round(Math.Round(ds.Rows(i)("Dias Descansados"), 2) * ds.Rows(i)("ValorDia"), 2), _
        '                Math.Round(ds.Rows(i)("Disponibles"), 2), _
        '                Math.Round(Math.Round(ds.Rows(i)("Disponibles"), 2) * ds.Rows(i)("ValorDia"), 2))
        '            'Math.Round(ds.Rows(i)("Acumulado"), 2), _
        '            'Math.Round(ds.Rows(i)("Dias"), 2), _
        '            'Math.Round(ds.Rows(i)("VDias"), 2), _
        '            'Math.Round(ds.Rows(i)("APagar"), 2), _
        '            'Math.Round(ds.Rows(i)("VAPagar"), 2))

        '            'Aplicar los Permisos a Cuenta de Vacaciones del periodo
        '            VB.SysContab.PermisosDB.AplicarVacaciones(ds.Rows(i)("Codigo"), _
        '                ds.Rows(i)("Desde"), _
        '                ds.Rows(i)("Hasta"), _
        '                "V")
        '            'Actualizar Acumulados de Vacaciones en la tabla empleados
        '            'VB.SysContab.EmpleadosDB.UpdateVac(ds.Rows(i)("codigo"), _
        '            'Math.Round(ds.Rows(i)("Dias"), 2), _
        '            'Math.Round(ds.Rows(i)("APagar"), 2))
        '            VB.SysContab.EmpleadosDB.UpdateVac(ds.Rows(i)("codigo"), _
        '                0, _
        '                Math.Round(ds.Rows(i)("Disponibles"), 2))
        '        Else
        '            ''hacer las transacciones para cobrar los sobregiros de vacaciones
        '            'If Me.ckbSobreGiro.Checked Then

        '            '    'Agregar el registro en la tabla de Vacaciones
        '            '    V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
        '            '        Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
        '            '        Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Desde"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Hasta"), _
        '            '        Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("vDias"), 2), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("VAPagar"), 2))

        '            '    'Aplicar los Permisos a Cuenta de Vacaciones del periodo
        '            '    VB.SysContab.PermisosDB.AplicarVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Desde"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Hasta"), _
        '            '        "V")
        '            '    'Actualizar Acumulados de Vacaciones en la tabla empleados
        '            '    VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("APagar"), 2))
        '            'Else
        '            '    'Agregar el registro en la tabla de Vacaciones
        '            '    V.AddVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
        '            '        Microsoft.VisualBasic.Right(QuincenaTrabajo, 8), _
        '            '        Microsoft.VisualBasic.Left(QuincenaTrabajo, 1), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Desde"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Hasta"), _
        '            '        Math.Round(ds.Tables("Vacaciones").Rows(i)("Acumulado"), 2), _
        '            '        Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
        '            '        Math.Round(ds.Tables("Vacaciones").Rows(i)("vDias"), 2), _
        '            '        0, 0)

        '            '    'Aplicar los Permisos a Cuenta de Vacaciones del periodo
        '            '    VB.SysContab.PermisosDB.AplicarVacaciones(ds.Tables("Vacaciones").Rows(i)("Codigo"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Desde"), _
        '            '        ds.Tables("Vacaciones").Rows(i)("Hasta"), _
        '            '        "V")
        '            '    'Actualizar Acumulados de Vacaciones en la tabla empleados
        '            '    VB.SysContab.EmpleadosDB.UpdateVac(ds.Tables("Vacaciones").Rows(i)("codigo"), _
        '            '    Math.Round(ds.Tables("Vacaciones").Rows(i)("Dias"), 2), _
        '            '    0)
        '            'End If
        '        End If


        '    Next
        '    If frmPagoVacaciones.Todos Then
        '        Empresa.UpdateVacaciones(EmpresaActual, Format(Me.MCHasta.SelectionStart, "yyyyMM")) '.Year.ToString & Me.MCHasta.SelectionStart.Month.ToString)
        '    End If
        '    transaccion.Commit()
        '    DBConnexion.Close()
        'Catch ex As Exception
        '    transaccion.Rollback()
        '    MsgBox(ex.Message)
        'End Try

        'MsgBox("Registros Generados Satisfactoriamente", MsgBoxStyle.OKOnly)
    End Sub

    Private Sub MCDesde_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCDesde.DateSelected
        Me.MCHasta.MinDate = Me.MCDesde.SelectionStart  ' en teoria deberia ser solo un dia seleccionado
        If Me.MCHasta.SelectionStart < Me.MCDesde.SelectionStart Then
            Me.MCHasta.SelectionStart = Me.MCDesde.SelectionStart
        End If
    End Sub
End Class
