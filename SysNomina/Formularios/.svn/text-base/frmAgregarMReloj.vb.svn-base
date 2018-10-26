Imports System
'Imports iTextSharp
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAgregarMReloj
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarMReloj = Nothing

    Public Shared Function Instance() As frmAgregarMReloj
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarMReloj()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim WithEvents EmpleadoNombre As DataGridTextBoxCombo.DataGridComboBoxColumn
    Dim WithEvents EmpleadoCodigo As DataGridTextBoxCombo.DataGridComboBoxColumn
    Dim LFecha As DateTime
    Dim Departamento As String
    Private WithEvents myDataSet As DataSet
    Private WithEvents myTable As DataTable
    Dim ds As DataSet
    Dim Creado As Boolean
    Dim lRegistro As Integer

    Dim Periodo As New VB.SysContab.PeriodoNominaDetails()
    Dim reloj As New VB.SysContab.RegEntSalDB()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMReloj As System.Windows.Forms.DataGrid
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMReloj = New System.Windows.Forms.DataGrid()
        Me.CBDepartamento = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMReloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdActualizar})
        Me.GroupBox1.Location = New System.Drawing.Point(848, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 408)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 40)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(16, 16)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(72, 24)
        Me.cmdActualizar.TabIndex = 1
        Me.cmdActualizar.Text = "Actualizar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Departamento:"
        '
        'dgMReloj
        '
        Me.dgMReloj.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMReloj.DataMember = ""
        Me.dgMReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMReloj.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMReloj.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMReloj.Location = New System.Drawing.Point(8, 80)
        Me.dgMReloj.Name = "dgMReloj"
        Me.dgMReloj.ReadOnly = True
        Me.dgMReloj.Size = New System.Drawing.Size(824, 408)
        Me.dgMReloj.TabIndex = 8
        '
        'CBDepartamento
        '
        Me.CBDepartamento.Location = New System.Drawing.Point(112, 32)
        Me.CBDepartamento.Name = "CBDepartamento"
        Me.CBDepartamento.Size = New System.Drawing.Size(368, 21)
        Me.CBDepartamento.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(112, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(144, 20)
        Me.dtpFecha.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fecha:"
        '
        'frmAgregarMReloj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(968, 542)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.dtpFecha, Me.CBDepartamento, Me.GroupBox1, Me.Label1, Me.dgMReloj})
        Me.Name = "frmAgregarMReloj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgMReloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarMReloj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim HExtras As New VB.SysContab.HorasExtrasDB()

        CBDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        CBDepartamento.ValueMember = "Codigo"
        CBDepartamento.DisplayMember = "Nombre"
        CBDepartamento.SelectedValue = "0"

        Departamento = "%"
        Periodo = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)
        LFecha = Periodo.FInicio

        Dim lds As New VB.SysContab.PeriodoNominaDetails()
        lds = VB.SysContab.PeriodoNominaDB.GetListBuscarFInicio(CDate(Format(DateAdd(DateInterval.Day, -1, Periodo.FInicio), "dd/MM/yyyy")), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1))
        If Not (lds.Codigo Is Nothing Or lds.Codigo = "") Then
            Me.dtpFecha.MinDate = lds.FInicio
        Else
            Me.dtpFecha.MinDate = Periodo.FInicio
        End If
        Me.dtpFecha.MaxDate = Periodo.FFinal

        'Me.dtpFecha.Value = LFecha

        ds = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha)
        MakeDataSet()
        AddCustomDataTableStyle()
        'If reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("RegEntSal").Rows.Count >= 1 Then
        '    'myDataSet.Tables("regentsal").Clear()
        '    myTable.Clear()
        '    'myDataSet = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha)
        '    myTable = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("RegEntSal")
        'Else
        '    'myDataSet.Tables("regentsal").Clear()
        '    myTable.Clear()
        'End If

        dgMReloj.SetDataBinding(myDataSet, "myTable")
        dgMReloj.ReadOnly = False
        dgMReloj.CaptionText = "Información de Entradas y Salidas de Empleado"
        lRegistro = 0
        dgMReloj.CurrentRowIndex = 0

        Me.Text = "Información de Entradas y Salidas de Empleado"

        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub


    Private Sub MakeDataSet()

        myDataSet = New DataSet("myDataset")
        myTable = New DataTable("myTable")

        'Dim lDs As DataSet
        'Dim lTable As DataTable

        ' Create a DataSet.
        ' = New DataSet("lds")

        'lTable = New DataTable("RegEntSal")

        ' Create two columns, and add them to the first table.

        Dim cCodEmpleado As DataColumn
        cCodEmpleado = New DataColumn("cEmpleado")

        Dim cNomEmpleado As DataColumn
        cNomEmpleado = New DataColumn("nEmpleado")

        Dim cHEntrada As DataColumn
        cHEntrada = New DataColumn("HEntrada")
        cHEntrada.DataType = System.Type.GetType("System.DateTime")

        Dim cHSalida As DataColumn
        cHSalida = New DataColumn("HSalida")
        cHSalida.DataType = System.Type.GetType("System.DateTime")

        Dim Cargado As DataColumn
        Cargado = New DataColumn("Cargado")
        Cargado.DataType = System.Type.GetType("System.Boolean")

        '      Dim cCodigoTemporal As DataColumn
        '     cCodigoTemporal = New DataColumn("CodigoTemporal")

        myTable.Columns.Add(cCodEmpleado)
        myTable.Columns.Add(cNomEmpleado)
        myTable.Columns.Add(cHEntrada)
        myTable.Columns.Add(cHSalida)
        myTable.Columns.Add(Cargado)
        '    lTable.Columns.Add(cCodigoTemporal)


        myDataSet.Tables.Add(myTable)
        Creado = True

        ' Si tiene datos
        If ds.Tables("RegEntSal").Rows.Count >= 1 Then
            Dim myRow As DataRow
            Dim i As Integer = 0

            Do While (i < ds.Tables("RegEntSal").Rows.Count)
                myRow = myTable.NewRow
                myRow("cEmpleado") = ds.Tables("RegEntSal").Rows(i).Item("cEmpleado")
                ' Add the row to the Customers table.
                myTable.Rows.Add(myRow)
                i = (i + 1)
            Loop

            Dim j As Integer

            For j = 0 To ds.Tables("RegEntSal").Rows.Count - 1

                myTable.Rows(j)("nEmpleado") = ds.Tables("RegEntSal").Rows(j).Item("nEmpleado")
                myTable.Rows(j)("HEntrada") = ds.Tables("RegEntSal").Rows(j).Item("HEntrada")
                myTable.Rows(j)("HSalida") = ds.Tables("RegEntSal").Rows(j).Item("HSalida")
                myTable.Rows(j)("Cargado") = True
            Next
        End If



    End Sub

    Private Sub AddCustomDataTableStyle()

        Dim Empleados As New VB.SysContab.EmpleadosDB()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "myTable"
        ' Set other properties (optional step)
        'ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0
        Dim i As Integer



        'Dim EmpleadoCodigo As DataGridComboBoxColumn
        EmpleadoCodigo = New DataGridTextBoxCombo.DataGridComboBoxColumn(New DataGridTextBoxCombo.ComboValueChanged(AddressOf cMyComboValueChanged))
        EmpleadoCodigo.MappingName = "cEmpleado"
        EmpleadoCodigo.HeaderText = "Código"
        EmpleadoCodigo.Width = 100
        EmpleadoCodigo.ReadOnly = False

        ts1.GridColumnStyles.Add(EmpleadoCodigo)
        ts1.PreferredRowHeight = (EmpleadoCodigo.ColumnComboBox.Height + 3)

        EmpleadoCodigo.NullText = ""

        Dim alDS As New DataSet()
        alDS = VB.SysContab.EmpleadosDB.GetListDepto(Departamento)

        For i = 0 To alDS.Tables("Empleados").Rows.Count - 1
            EmpleadoCodigo.ColumnComboBox.Items.Add(alDS.Tables("Empleados").Rows(i).Item("Codigo"))
        Next

        EmpleadoCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

        EmpleadoCodigo.ColumnComboBox.SelectedValue = -1

        colCount = (colCount + 1)


        'Dim EmpleadoNombre As DataGridComboBoxColumn
        EmpleadoNombre = New DataGridTextBoxCombo.DataGridComboBoxColumn(New DataGridTextBoxCombo.ComboValueChanged(AddressOf nMyComboValueChanged))
        EmpleadoNombre.MappingName = "nEmpleado"
        EmpleadoNombre.HeaderText = "Nombre"
        EmpleadoNombre.Width = 300
        EmpleadoNombre.ReadOnly = True

        ts1.GridColumnStyles.Add(EmpleadoNombre)
        ts1.PreferredRowHeight = (EmpleadoNombre.ColumnComboBox.Height + 3)

        EmpleadoNombre.NullText = ""
        For i = 0 To alDS.Tables("Empleados").Rows.Count - 1 'Empleados.GetListDepto(Departamento).Tables("Empleados").Rows.Count - 1
            EmpleadoNombre.ColumnComboBox.Items.Add(alDS.Tables("Empleados").Rows(i).Item("Nombre"))
        Next
        EmpleadoNombre.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
        EmpleadoNombre.ColumnComboBox.SelectedValue = -1

        colCount = (colCount + 1)

        'Dim HEntrada As DataGridColumnStyle
        Dim HEntrada As New DataGridTextBoxColumn()
        HEntrada.MappingName = "HEntrada"
        HEntrada.HeaderText = "Hora Entrada"

        HEntrada.Width = 100
        HEntrada.Alignment = HorizontalAlignment.Left
        HEntrada.Format = "hh:mm tt"
        HEntrada.ReadOnly = False
        ts1.GridColumnStyles.Add(HEntrada)
        colCount = (colCount + 1)
        HEntrada.NullText = ""

        'Dim HSalida As DataGridColumnStyle
        Dim HSalida As New DataGridTextBoxColumn()
        HSalida.MappingName = "HSalida"
        'from dataset table
        HSalida.HeaderText = "Hora Salida"
        HSalida.Width = 100
        HSalida.Alignment = HorizontalAlignment.Left
        HSalida.Format = "hh:mm tt"
        HSalida.ReadOnly = False
        ts1.GridColumnStyles.Add(HSalida)
        colCount = (colCount + 1)
        HSalida.NullText = ""


        '        Dim CodigoTemporal As DataGridTextBoxColumn
        '       CodigoTemporal = New DataGridTextBoxColumn()
        '      CodigoTemporal.MappingName = "CodigoTemporal"
        '     CodigoTemporal.HeaderText = "CodigoTemporal"
        '    CodigoTemporal.Width = 0
        '   CodigoTemporal.Alignment = HorizontalAlignment.Left
        '  CodigoTemporal.ReadOnly = True
        ' ts1.GridColumnStyles.Add(CodigoTemporal)
        'colCount = (colCount + 1)
        '
        '       CodigoTemporal.NullText = ""


        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        ts1.AllowSorting = False
        ts1.HeaderFont = Me.dgMReloj.HeaderFont

        Me.dgMReloj.CaptionVisible = False

        Me.dgMReloj.TableStyles.Clear()
        Me.dgMReloj.TableStyles.Add(ts1)

    End Sub

    Public Sub cMyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)

        Try
            If Indice >= 0 Then

                If myTable.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = myTable.NewRow
                    myTable.Rows.Add(newRow1)

                    myTable.Rows(rowChanging)("cEmpleado") = EmpleadoCodigo.ColumnComboBox.Items.Item(Indice)
                    myTable.Rows(rowChanging)("nEmpleado") = EmpleadoNombre.ColumnComboBox.Items.Item(Indice)
                    myTable.Rows(rowChanging)("HEntrada") = Format(Now, "hh:mm tt")
                    myTable.Rows(rowChanging)("HSalida") = Format(Now, "hh:mm tt")
                    myTable.Rows(rowChanging)("Cargado") = False

                Else

                    'If myTable.Rows(rowChanging)("Cargado") Then
                    '    MsgBox("No se puede cambiar al Empleado", MsgBoxStyle.OKOnly)
                    '    EmpleadoCodigo.ColumnComboBox.SelectedValue = myTable.Rows(rowChanging)("cEmpleado")
                    '    Exit Try
                    'End If
                    myTable.Rows(rowChanging)("cEmpleado") = EmpleadoCodigo.ColumnComboBox.Items.Item(Indice)
                    myTable.Rows(rowChanging)("nEmpleado") = EmpleadoNombre.ColumnComboBox.Items.Item(Indice)

                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboValueChanged")

        End Try

    End Sub

    Public Sub nMyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)


    End Sub

    Private Sub CBDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CBDepartamento.Validating

        'Dim reloj As New VB.SysContab.RegEntSalDB()

        LFecha = CDate(Format(Me.dtpFecha.Value, "dd/MM/yyyy"))
        Departamento = IIf(Me.CBDepartamento.SelectedValue = "0", "%", Me.CBDepartamento.SelectedValue)

        ds = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha)
        MakeDataSet()
        AddCustomDataTableStyle()
        dgMReloj.SetDataBinding(myDataSet, "myTable")
        dgMReloj.ReadOnly = False

        'If Creado Then
        '    If reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("RegEntSal").Rows.Count >= 1 Then
        '        'myDataSet.Tables("RegEntSal").Clear()
        '        myTable.Clear()
        '        myTable = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("regEntSal")
        '    Else
        '        'myDataSet.Tables("RegEntSal").Clear()
        '        myTable.Clear()
        '    End If

        '    dgMReloj.SetDataBinding(myDataSet, "RegEntSal")
        '    dgMReloj.ReadOnly = False

        '    AddCustomDataTableStyle()
        'End If
        dgMReloj.CaptionText = "Información de Entradas y Salidas de Empleado"
        Me.Text = "Información de Entradas y Salidas de Empleado"
        Me.Refresh()


    End Sub



    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged


        'If dtpFecha.Value < Periodo.FInicio Or dtpFecha.Value > Periodo.FFinal Then
        '    MsgBox("La Fecha seleccionada esta fuera del rango del periodo de trabajo", MsgBoxStyle.OKOnly, "Error de Fecha")
        '    dtpFecha.Value = Periodo.FInicio
        '    Exit Sub
        'End If


        LFecha = CDate(Format(Me.dtpFecha.Value, "dd/MM/yyyy"))
        Departamento = IIf(Me.CBDepartamento.SelectedValue = "0" Or Me.CBDepartamento.SelectedValue Is Nothing, "%", Me.CBDepartamento.SelectedValue)
        ds = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha)
        MakeDataSet()
        AddCustomDataTableStyle()
        dgMReloj.SetDataBinding(myDataSet, "myTable")
        dgMReloj.ReadOnly = False

        'If Creado Then
        '    If reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("RegEntSal").Rows.Count >= 1 Then
        '        'myDataSet.Tables("RegEntSal").Clear()
        '        myTable.Clear()
        '        myTable = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha).Tables("Regentsal")
        '    Else
        '        'myDataSet.Tables("RegEntSal").Clear()
        '        myTable.Clear()
        '    End If

        '    'Tabla = ds.Tables("RegEntSal")
        '    dgMReloj.SetDataBinding(myDataSet, "RegEntSal")
        '    dgMReloj.ReadOnly = False


        '    AddCustomDataTableStyle()
        'End If
        dgMReloj.CaptionText = "Información de Entradas y Salidas de Empleado"
        Me.Text = "Información de Entradas y Salidas de Empleado"
        Me.Refresh()
    End Sub


    Private Sub cmdActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click

        Dim i As Integer
        Dim reg As New VB.SysContab.RegEntSalDB()
        Dim hent, hsal As DateTime



        ' MEJOR BORRAR TODO Y AGREGAR LO QUE TENGA MYtable
        'borrar todo
        reg.DeleteFecha(CDate(Format(Me.dtpFecha.Value, "dd/MM/yyyy")), Departamento)

        'agregar todo

        For i = 0 To myTable.Rows.Count - 1

            If Not (myTable.Rows(i)("cempleado") Is DBNull.Value) And myTable.Rows(i)("cempleado") <> "" Then
                hent = Format(Me.dtpFecha.Value, "dd/MM/yyyy") & " " & Format(myDataSet.Tables("myTable").Rows(i).Item("HEntrada"), "hh:mm tt")
                hsal = Format(Me.dtpFecha.Value, "dd/MM/yyyy") & " " & Format(myDataSet.Tables("myTable").Rows(i).Item("HSalida"), "hh:mm tt")


                reg.Additem(myDataSet.Tables("myTable").Rows(i).Item("cEmpleado"), _
                             CDate(Format(Me.dtpFecha.Value, "dd/MM/yyyy")), _
                             hent, _
                             hsal, QuincenaTrabajo)
            End If
        Next


        MsgBox("Registros Actualizados Satisfactoriamente", MsgBoxStyle.OKOnly)


    End Sub




    Private Sub CBDepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBDepartamento.SelectedIndexChanged

        If IsNumeric(Me.CBDepartamento.SelectedValue) Then

            LFecha = CDate(Format(Me.dtpFecha.Value, "dd/MM/yyyy"))
            Departamento = IIf(Me.CBDepartamento.SelectedValue = "0", "%", Me.CBDepartamento.SelectedValue)

            ds = reloj.GetListMarcadasDeptoFecha(Departamento, LFecha)
            MakeDataSet()
            AddCustomDataTableStyle()
            dgMReloj.SetDataBinding(myDataSet, "myTable")
            dgMReloj.ReadOnly = False

            dgMReloj.CaptionText = "Información de Entradas y Salidas de Empleado"
            Me.Text = "Información de Entradas y Salidas de Empleado"
            Me.Refresh()

        End If
    End Sub
End Class
