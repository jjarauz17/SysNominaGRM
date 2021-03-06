Imports System.IO
Imports System.Data.SqlClient
Imports DbConnect

Public Class frmAgregarEmpleado
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarEmpleado = Nothing

    Public Shared Function Instance() As frmAgregarEmpleado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarEmpleado()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function


#Region "Variables"

    Dim LoginAnterior As String
    Dim Duracion As String
    Dim sAFiscal As String

    Dim tArea As String
    Public archivoFoto, archivoFirma As String
    Public QImagen As String

    Dim Emp_UltimaFechaPago As Date
    Dim Detalles As VB.SysContab.EmpleadosDetails
    Dim DetalleSubsidios As New VB.SysContab.Empleados_Subsidios_Details
    Dim dtValores As New DataTable
    Dim cargado As Boolean = False
    Dim Organigrama As Integer = 0
    Dim TPOrgCargado As Boolean = False
    Dim Grabando As Boolean = False
#End Region

#Region "Calaches del Formualrio"
    Friend WithEvents TPPlanillas As System.Windows.Forms.TabPage
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbAfiscal As System.Windows.Forms.ComboBox
    Friend WithEvents TPDatosLaborales As System.Windows.Forms.TabPage
    Friend WithEvents gbFirma As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Firma As System.Windows.Forms.PictureBox
    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents CBHorario As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents BHorario As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gbSalario As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents CBFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSalarioDiario As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDeduccionInss As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtInatec As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtTransporte As System.Windows.Forms.TextBox
    Friend WithEvents gbContacto As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtNombreContacto As System.Windows.Forms.TextBox
    Friend WithEvents gbDatosLaborales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbElectronico As System.Windows.Forms.RadioButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtAcumVac As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTiempoTrabajar As System.Windows.Forms.TextBox
    Friend WithEvents txtbaja As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents TPDatosGenerales As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInss As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents cbProfesion As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cbMunicipios As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Fotografia As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cbRegimenINSS As System.Windows.Forms.ComboBox
    Friend WithEvents RbHExtra As System.Windows.Forms.CheckBox
    Friend WithEvents rbAcumulaPrestaciones As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cbPais As System.Windows.Forms.ComboBox
    Friend WithEvents gbAfiscal As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents TPOtros As System.Windows.Forms.TabPage
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents dtpHastaContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgAFiscal As DevExpress.XtraGrid.GridControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents cmdDisponibilidadLogin As System.Windows.Forms.Button
    Friend WithEvents TPMovimientos As System.Windows.Forms.TabPage
    Friend WithEvents dgMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamentoMurohs As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgCamposDinamicos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCampos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCampo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MCS As System.Windows.Forms.TabPage
    Friend WithEvents gbMcs As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGaseosa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkComida As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgMCSMaximos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vMCSMaximos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTipoSesion As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Tipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Invitados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbValores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkSalarioFijo As System.Windows.Forms.CheckBox
    Friend WithEvents cbMonedaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tbOrganigrama As System.Windows.Forms.TabPage
    Friend WithEvents dgOrganigramaD As DevExpress.XtraGrid.GridControl
    Friend WithEvents vListaOrganigrama As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbOrganigramaD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spFactor As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Treelist1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkBonificar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTipoContrato As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TPContratos As System.Windows.Forms.TabPage
    Friend WithEvents dgContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdLiquidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkAntiguedad As System.Windows.Forms.CheckBox
    Friend WithEvents cbFuncion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vFuncion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCargo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbArea As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vAreas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbDepartamento As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vDepartamento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbLocalidad As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vLocalidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbNivelAcademico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents are_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VAfiscal As DevExpress.XtraGrid.Views.Grid.GridView
#End Region

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdActivos As System.Windows.Forms.Button
    Friend WithEvents cmdBaja As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdBaja = New System.Windows.Forms.Button()
        Me.cmdActivos = New System.Windows.Forms.Button()
        Me.TPPlanillas = New System.Windows.Forms.TabPage()
        Me.gbAfiscal = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkselector = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgAFiscal = New DevExpress.XtraGrid.GridControl()
        Me.VAfiscal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbAfiscal = New System.Windows.Forms.ComboBox()
        Me.TPDatosLaborales = New System.Windows.Forms.TabPage()
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.cbBancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.RbEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbElectronico = New System.Windows.Forms.RadioButton()
        Me.CBHorario = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.BHorario = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbSalario = New System.Windows.Forms.GroupBox()
        Me.chkAntiguedad = New System.Windows.Forms.CheckBox()
        Me.cbMonedaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkSalarioFijo = New System.Windows.Forms.CheckBox()
        Me.rbAcumulaPrestaciones = New System.Windows.Forms.CheckBox()
        Me.RbHExtra = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.CBFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.txtSalarioDiario = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtDeduccionInss = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtInatec = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtTransporte = New System.Windows.Forms.TextBox()
        Me.gbDatosLaborales = New System.Windows.Forms.GroupBox()
        Me.cbFuncion = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vFuncion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCargo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbArea = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vAreas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.are_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbDepartamento = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vDepartamento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbLocalidad = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vLocalidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkBonificar = New DevExpress.XtraEditors.CheckEdit()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.dtpHastaContrato = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoContrato = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtAcumVac = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTiempoTrabajar = New System.Windows.Forms.TextBox()
        Me.txtbaja = New System.Windows.Forms.TextBox()
        Me.dtpFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.gbFirma = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbDepartamentoMurohs = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdDisponibilidadLogin = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Firma = New System.Windows.Forms.PictureBox()
        Me.gbContacto = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTelefonoContacto = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNombreContacto = New System.Windows.Forms.TextBox()
        Me.TPDatosGenerales = New System.Windows.Forms.TabPage()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtInss = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cbRegimenINSS = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.cbNivelAcademico = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbProfesion = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbMunicipios = New System.Windows.Forms.ComboBox()
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSNombre = New System.Windows.Forms.TextBox()
        Me.txtSApellido = New System.Windows.Forms.TextBox()
        Me.txtPNombre = New System.Windows.Forms.TextBox()
        Me.txtPApellido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Fotografia = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TPOtros = New System.Windows.Forms.TabPage()
        Me.TPMovimientos = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.VMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdcBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgCamposDinamicos = New DevExpress.XtraGrid.GridControl()
        Me.vCampos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCampo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbValores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MCS = New System.Windows.Forms.TabPage()
        Me.gbMcs = New System.Windows.Forms.GroupBox()
        Me.dgMCSMaximos = New DevExpress.XtraGrid.GridControl()
        Me.vMCSMaximos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Tipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbTipoSesion = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Invitados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkGaseosa = New DevExpress.XtraEditors.CheckEdit()
        Me.chkComida = New DevExpress.XtraEditors.CheckEdit()
        Me.tbOrganigrama = New System.Windows.Forms.TabPage()
        Me.dgOrganigramaD = New DevExpress.XtraGrid.GridControl()
        Me.vListaOrganigrama = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbOrganigramaD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.spFactor = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Treelist1 = New DevExpress.XtraTreeList.TreeList()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TPContratos = New System.Windows.Forms.TabPage()
        Me.cmdLiquidar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgContratos = New DevExpress.XtraGrid.GridControl()
        Me.vContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2.SuspendLayout()
        Me.TPPlanillas.SuspendLayout()
        Me.gbAfiscal.SuspendLayout()
        CType(Me.dgAFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VAfiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDatosLaborales.SuspendLayout()
        Me.gbHorario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.gbSalario.SuspendLayout()
        CType(Me.cbMonedaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.gbDatosLaborales.SuspendLayout()
        CType(Me.cbFuncion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLocalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.chkBonificar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFirma.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Firma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbContacto.SuspendLayout()
        Me.TPDatosGenerales.SuspendLayout()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.cbNivelAcademico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.Fotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TPOtros.SuspendLayout()
        Me.TPMovimientos.SuspendLayout()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgCamposDinamicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCampo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MCS.SuspendLayout()
        Me.gbMcs.SuspendLayout()
        CType(Me.dgMCSMaximos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vMCSMaximos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.chkGaseosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOrganigrama.SuspendLayout()
        CType(Me.dgOrganigramaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vListaOrganigrama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrganigramaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Treelist1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPContratos.SuspendLayout()
        CType(Me.dgContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 110)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 30
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdBaja)
        Me.GroupBox2.Controls.Add(Me.cmdActivos)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(885, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(101, 542)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'cmdBaja
        '
        Me.cmdBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBaja.ForeColor = System.Drawing.Color.Black
        Me.cmdBaja.Location = New System.Drawing.Point(16, 80)
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(72, 24)
        Me.cmdBaja.TabIndex = 33
        Me.cmdBaja.Text = "Baja"
        '
        'cmdActivos
        '
        Me.cmdActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActivos.ForeColor = System.Drawing.Color.Black
        Me.cmdActivos.Location = New System.Drawing.Point(16, 48)
        Me.cmdActivos.Name = "cmdActivos"
        Me.cmdActivos.Size = New System.Drawing.Size(72, 24)
        Me.cmdActivos.TabIndex = 31
        Me.cmdActivos.Text = "Activos"
        '
        'TPPlanillas
        '
        Me.TPPlanillas.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPPlanillas.Controls.Add(Me.gbAfiscal)
        Me.TPPlanillas.Location = New System.Drawing.Point(4, 25)
        Me.TPPlanillas.Name = "TPPlanillas"
        Me.TPPlanillas.Size = New System.Drawing.Size(855, 513)
        Me.TPPlanillas.TabIndex = 2
        Me.TPPlanillas.Text = "Registros del A�o Fiscal"
        Me.TPPlanillas.UseVisualStyleBackColor = True
        '
        'gbAfiscal
        '
        Me.gbAfiscal.Controls.Add(Me.Button2)
        Me.gbAfiscal.Controls.Add(Me.chkselector)
        Me.gbAfiscal.Controls.Add(Me.Button1)
        Me.gbAfiscal.Controls.Add(Me.dgAFiscal)
        Me.gbAfiscal.Controls.Add(Me.Label44)
        Me.gbAfiscal.Controls.Add(Me.cbAfiscal)
        Me.gbAfiscal.Location = New System.Drawing.Point(-3, 0)
        Me.gbAfiscal.Name = "gbAfiscal"
        Me.gbAfiscal.Size = New System.Drawing.Size(858, 520)
        Me.gbAfiscal.TabIndex = 87
        Me.gbAfiscal.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(501, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 24)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = "Reporte IR"
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkselector.AutoSize = True
        Me.chkselector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkselector.Location = New System.Drawing.Point(613, 39)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(147, 17)
        Me.chkselector.TabIndex = 89
        Me.chkselector.Text = "&Mostrar Selector de datos"
        Me.chkselector.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(775, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "&Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgAFiscal
        '
        Me.dgAFiscal.Location = New System.Drawing.Point(5, 77)
        Me.dgAFiscal.MainView = Me.VAfiscal
        Me.dgAFiscal.Name = "dgAFiscal"
        Me.dgAFiscal.Size = New System.Drawing.Size(845, 425)
        Me.dgAFiscal.TabIndex = 87
        Me.dgAFiscal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VAfiscal})
        '
        'VAfiscal
        '
        Me.VAfiscal.GridControl = Me.dgAFiscal
        Me.VAfiscal.Name = "VAfiscal"
        Me.VAfiscal.OptionsBehavior.Editable = False
        Me.VAfiscal.OptionsSelection.MultiSelect = True
        Me.VAfiscal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VAfiscal.OptionsView.ShowFooter = True
        Me.VAfiscal.OptionsView.ShowGroupPanel = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(6, 32)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 24)
        Me.Label44.TabIndex = 86
        Me.Label44.Text = "A�o Fiscal:"
        '
        'cbAfiscal
        '
        Me.cbAfiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAfiscal.Location = New System.Drawing.Point(100, 32)
        Me.cbAfiscal.Name = "cbAfiscal"
        Me.cbAfiscal.Size = New System.Drawing.Size(184, 24)
        Me.cbAfiscal.TabIndex = 1
        '
        'TPDatosLaborales
        '
        Me.TPDatosLaborales.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPDatosLaborales.Controls.Add(Me.gbHorario)
        Me.TPDatosLaborales.Controls.Add(Me.gbSalario)
        Me.TPDatosLaborales.Controls.Add(Me.gbDatosLaborales)
        Me.TPDatosLaborales.Location = New System.Drawing.Point(4, 25)
        Me.TPDatosLaborales.Name = "TPDatosLaborales"
        Me.TPDatosLaborales.Size = New System.Drawing.Size(855, 513)
        Me.TPDatosLaborales.TabIndex = 1
        Me.TPDatosLaborales.Text = "Datos Laborales"
        Me.TPDatosLaborales.UseVisualStyleBackColor = True
        '
        'gbHorario
        '
        Me.gbHorario.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbHorario.Controls.Add(Me.GroupBox1)
        Me.gbHorario.Controls.Add(Me.CBHorario)
        Me.gbHorario.Controls.Add(Me.Label42)
        Me.gbHorario.Controls.Add(Me.GroupBox14)
        Me.gbHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorario.ForeColor = System.Drawing.Color.Maroon
        Me.gbHorario.Location = New System.Drawing.Point(475, 3)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(357, 342)
        Me.gbHorario.TabIndex = 3
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "HORARIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.cbBancos)
        Me.GroupBox1.Controls.Add(Me.RbEfectivo)
        Me.GroupBox1.Controls.Add(Me.rbElectronico)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 123)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagar con:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(23, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 23)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Cuenta/ID:"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(162, 43)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(172, 20)
        Me.txtIdCuenta.TabIndex = 3
        Me.txtIdCuenta.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.Location = New System.Drawing.Point(162, 21)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Properties.NullText = ""
        Me.cbBancos.Size = New System.Drawing.Size(172, 20)
        Me.cbBancos.TabIndex = 2
        Me.cbBancos.Visible = False
        '
        'RbEfectivo
        '
        Me.RbEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbEfectivo.Location = New System.Drawing.Point(8, 69)
        Me.RbEfectivo.Name = "RbEfectivo"
        Me.RbEfectivo.Size = New System.Drawing.Size(169, 19)
        Me.RbEfectivo.TabIndex = 1
        Me.RbEfectivo.Text = "Pago Efectivo / Chk"
        '
        'rbElectronico
        '
        Me.rbElectronico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbElectronico.Location = New System.Drawing.Point(8, 24)
        Me.rbElectronico.Name = "rbElectronico"
        Me.rbElectronico.Size = New System.Drawing.Size(136, 24)
        Me.rbElectronico.TabIndex = 0
        Me.rbElectronico.Text = "Env�o Electr�nico"
        '
        'CBHorario
        '
        Me.CBHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHorario.ItemHeight = 15
        Me.CBHorario.Location = New System.Drawing.Point(90, 16)
        Me.CBHorario.Name = "CBHorario"
        Me.CBHorario.Size = New System.Drawing.Size(136, 23)
        Me.CBHorario.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(8, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(69, 21)
        Me.Label42.TabIndex = 76
        Me.Label42.Text = "Horario:"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.dtpHoraEntrada)
        Me.GroupBox14.Controls.Add(Me.dtpHoraSalida)
        Me.GroupBox14.Controls.Add(Me.BHorario)
        Me.GroupBox14.Controls.Add(Me.Label19)
        Me.GroupBox14.Controls.Add(Me.Label14)
        Me.GroupBox14.Controls.Add(Me.txtTotalHoras)
        Me.GroupBox14.Controls.Add(Me.Label20)
        Me.GroupBox14.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox14.TabIndex = 78
        Me.GroupBox14.TabStop = False
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Checked = False
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(82, 13)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(112, 21)
        Me.dtpHoraEntrada.TabIndex = 21
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(82, 37)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(112, 21)
        Me.dtpHoraSalida.TabIndex = 22
        '
        'BHorario
        '
        Me.BHorario.Location = New System.Drawing.Point(234, 37)
        Me.BHorario.Name = "BHorario"
        Me.BHorario.Size = New System.Drawing.Size(72, 24)
        Me.BHorario.TabIndex = 77
        Me.BHorario.Text = "Definir"
        Me.BHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(10, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 24)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Salida:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(10, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Entrada:"
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoras.Location = New System.Drawing.Point(266, 13)
        Me.txtTotalHoras.MaxLength = 10
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.ReadOnly = True
        Me.txtTotalHoras.Size = New System.Drawing.Size(40, 20)
        Me.txtTotalHoras.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(194, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 24)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Horas:"
        '
        'gbSalario
        '
        Me.gbSalario.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbSalario.Controls.Add(Me.chkAntiguedad)
        Me.gbSalario.Controls.Add(Me.cbMonedaPago)
        Me.gbSalario.Controls.Add(Me.chkSalarioFijo)
        Me.gbSalario.Controls.Add(Me.rbAcumulaPrestaciones)
        Me.gbSalario.Controls.Add(Me.RbHExtra)
        Me.gbSalario.Controls.Add(Me.Label25)
        Me.gbSalario.Controls.Add(Me.txtSalario)
        Me.gbSalario.Controls.Add(Me.CBFormaPago)
        Me.gbSalario.Controls.Add(Me.Label37)
        Me.gbSalario.Controls.Add(Me.Label43)
        Me.gbSalario.Controls.Add(Me.GroupBox15)
        Me.gbSalario.Controls.Add(Me.Label41)
        Me.gbSalario.Controls.Add(Me.txtTransporte)
        Me.gbSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalario.ForeColor = System.Drawing.Color.Maroon
        Me.gbSalario.Location = New System.Drawing.Point(0, 344)
        Me.gbSalario.Name = "gbSalario"
        Me.gbSalario.Size = New System.Drawing.Size(832, 166)
        Me.gbSalario.TabIndex = 4
        Me.gbSalario.TabStop = False
        Me.gbSalario.Text = "SALARIO"
        '
        'chkAntiguedad
        '
        Me.chkAntiguedad.AutoSize = True
        Me.chkAntiguedad.Location = New System.Drawing.Point(314, 98)
        Me.chkAntiguedad.Name = "chkAntiguedad"
        Me.chkAntiguedad.Size = New System.Drawing.Size(98, 19)
        Me.chkAntiguedad.TabIndex = 190
        Me.chkAntiguedad.Text = "Antiguedad"
        Me.chkAntiguedad.UseVisualStyleBackColor = True
        '
        'cbMonedaPago
        '
        Me.cbMonedaPago.Location = New System.Drawing.Point(120, 60)
        Me.cbMonedaPago.Name = "cbMonedaPago"
        Me.cbMonedaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 200, "Name2")})
        Me.cbMonedaPago.Properties.NullText = ""
        Me.cbMonedaPago.Properties.ShowFooter = False
        Me.cbMonedaPago.Properties.ShowHeader = False
        Me.cbMonedaPago.Size = New System.Drawing.Size(144, 20)
        Me.cbMonedaPago.TabIndex = 189
        '
        'chkSalarioFijo
        '
        Me.chkSalarioFijo.AutoSize = True
        Me.chkSalarioFijo.Location = New System.Drawing.Point(314, 73)
        Me.chkSalarioFijo.Name = "chkSalarioFijo"
        Me.chkSalarioFijo.Size = New System.Drawing.Size(100, 19)
        Me.chkSalarioFijo.TabIndex = 188
        Me.chkSalarioFijo.Text = "Salario Fijo"
        Me.chkSalarioFijo.UseVisualStyleBackColor = True
        '
        'rbAcumulaPrestaciones
        '
        Me.rbAcumulaPrestaciones.AutoSize = True
        Me.rbAcumulaPrestaciones.Location = New System.Drawing.Point(314, 24)
        Me.rbAcumulaPrestaciones.Name = "rbAcumulaPrestaciones"
        Me.rbAcumulaPrestaciones.Size = New System.Drawing.Size(195, 19)
        Me.rbAcumulaPrestaciones.TabIndex = 185
        Me.rbAcumulaPrestaciones.Text = "Prestaciones Acumulables"
        Me.rbAcumulaPrestaciones.UseVisualStyleBackColor = True
        '
        'RbHExtra
        '
        Me.RbHExtra.AutoSize = True
        Me.RbHExtra.Location = New System.Drawing.Point(314, 47)
        Me.RbHExtra.Name = "RbHExtra"
        Me.RbHExtra.Size = New System.Drawing.Size(108, 19)
        Me.RbHExtra.TabIndex = 186
        Me.RbHExtra.Text = "Horas Extras"
        Me.RbHExtra.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(8, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 20)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Salario:"
        '
        'txtSalario
        '
        Me.txtSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalario.Location = New System.Drawing.Point(120, 88)
        Me.txtSalario.MaxLength = 10
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(144, 20)
        Me.txtSalario.TabIndex = 0
        '
        'CBFormaPago
        '
        Me.CBFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFormaPago.ItemHeight = 15
        Me.CBFormaPago.Items.AddRange(New Object() {"SEMANAL", "CATORCENAL", "QUINCENAL", "MENSUAL", "DESTAJO", "UNIDAD DE TRABAJO(CORTE)"})
        Me.CBFormaPago.Location = New System.Drawing.Point(120, 24)
        Me.CBFormaPago.Name = "CBFormaPago"
        Me.CBFormaPago.Size = New System.Drawing.Size(144, 23)
        Me.CBFormaPago.TabIndex = 166
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(8, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(120, 24)
        Me.Label37.TabIndex = 174
        Me.Label37.Text = "Forma de Pago:"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(8, 56)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 24)
        Me.Label43.TabIndex = 179
        Me.Label43.Text = "Moneda:"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.txtSalarioDiario)
        Me.GroupBox15.Controls.Add(Me.Label29)
        Me.GroupBox15.Controls.Add(Me.txtDeduccionInss)
        Me.GroupBox15.Controls.Add(Me.Label30)
        Me.GroupBox15.Controls.Add(Me.txtInatec)
        Me.GroupBox15.Controls.Add(Me.Label24)
        Me.GroupBox15.Location = New System.Drawing.Point(536, 8)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(264, 96)
        Me.GroupBox15.TabIndex = 180
        Me.GroupBox15.TabStop = False
        '
        'txtSalarioDiario
        '
        Me.txtSalarioDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalarioDiario.Location = New System.Drawing.Point(112, 16)
        Me.txtSalarioDiario.MaxLength = 10
        Me.txtSalarioDiario.Name = "txtSalarioDiario"
        Me.txtSalarioDiario.ReadOnly = True
        Me.txtSalarioDiario.Size = New System.Drawing.Size(96, 20)
        Me.txtSalarioDiario.TabIndex = 25
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(8, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 24)
        Me.Label29.TabIndex = 75
        Me.Label29.Text = "Inss:"
        '
        'txtDeduccionInss
        '
        Me.txtDeduccionInss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduccionInss.Location = New System.Drawing.Point(112, 40)
        Me.txtDeduccionInss.MaxLength = 10
        Me.txtDeduccionInss.Name = "txtDeduccionInss"
        Me.txtDeduccionInss.ReadOnly = True
        Me.txtDeduccionInss.Size = New System.Drawing.Size(96, 20)
        Me.txtDeduccionInss.TabIndex = 26
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(8, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 24)
        Me.Label30.TabIndex = 77
        Me.Label30.Text = "Inatec:"
        '
        'txtInatec
        '
        Me.txtInatec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInatec.Location = New System.Drawing.Point(112, 64)
        Me.txtInatec.MaxLength = 10
        Me.txtInatec.Name = "txtInatec"
        Me.txtInatec.ReadOnly = True
        Me.txtInatec.Size = New System.Drawing.Size(96, 20)
        Me.txtInatec.TabIndex = 27
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 24)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "Salario x d�a:"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(555, 107)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(98, 20)
        Me.Label41.TabIndex = 178
        Me.Label41.Text = "Transporte:"
        Me.Label41.Visible = False
        '
        'txtTransporte
        '
        Me.txtTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporte.Location = New System.Drawing.Point(656, 106)
        Me.txtTransporte.MaxLength = 10
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Size = New System.Drawing.Size(88, 20)
        Me.txtTransporte.TabIndex = 170
        Me.txtTransporte.Visible = False
        '
        'gbDatosLaborales
        '
        Me.gbDatosLaborales.Controls.Add(Me.cbFuncion)
        Me.gbDatosLaborales.Controls.Add(Me.cbCargo)
        Me.gbDatosLaborales.Controls.Add(Me.cbArea)
        Me.gbDatosLaborales.Controls.Add(Me.cbDepartamento)
        Me.gbDatosLaborales.Controls.Add(Me.cbLocalidad)
        Me.gbDatosLaborales.Controls.Add(Me.Label53)
        Me.gbDatosLaborales.Controls.Add(Me.Label48)
        Me.gbDatosLaborales.Controls.Add(Me.Label16)
        Me.gbDatosLaborales.Controls.Add(Me.GroupBox8)
        Me.gbDatosLaborales.Controls.Add(Me.Label9)
        Me.gbDatosLaborales.Controls.Add(Me.Label2)
        Me.gbDatosLaborales.Controls.Add(Me.Label3)
        Me.gbDatosLaborales.Controls.Add(Me.Label38)
        Me.gbDatosLaborales.Controls.Add(Me.txtAcumVac)
        Me.gbDatosLaborales.Controls.Add(Me.Label18)
        Me.gbDatosLaborales.Controls.Add(Me.txtTiempoTrabajar)
        Me.gbDatosLaborales.Controls.Add(Me.txtbaja)
        Me.gbDatosLaborales.Controls.Add(Me.dtpFechaBaja)
        Me.gbDatosLaborales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosLaborales.ForeColor = System.Drawing.Color.Maroon
        Me.gbDatosLaborales.Location = New System.Drawing.Point(0, 3)
        Me.gbDatosLaborales.Name = "gbDatosLaborales"
        Me.gbDatosLaborales.Size = New System.Drawing.Size(477, 342)
        Me.gbDatosLaborales.TabIndex = 1
        Me.gbDatosLaborales.TabStop = False
        Me.gbDatosLaborales.Text = "DATOS LABORALES"
        '
        'cbFuncion
        '
        Me.cbFuncion.EditValue = "[Seleccione Departamento]"
        Me.cbFuncion.Location = New System.Drawing.Point(120, 311)
        Me.cbFuncion.Name = "cbFuncion"
        Me.cbFuncion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFuncion.Properties.NullText = "[Seleccione Funcion]"
        Me.cbFuncion.Properties.View = Me.vFuncion
        Me.cbFuncion.Size = New System.Drawing.Size(349, 20)
        Me.cbFuncion.TabIndex = 192
        '
        'vFuncion
        '
        Me.vFuncion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vFuncion.Name = "vFuncion"
        Me.vFuncion.OptionsBehavior.Editable = False
        Me.vFuncion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vFuncion.OptionsView.ShowAutoFilterRow = True
        Me.vFuncion.OptionsView.ShowGroupPanel = False
        '
        'cbCargo
        '
        Me.cbCargo.EditValue = "[Seleccione Departamento]"
        Me.cbCargo.Location = New System.Drawing.Point(120, 287)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCargo.Properties.NullText = "[Seleccione Cargo]"
        Me.cbCargo.Properties.View = Me.vCargos
        Me.cbCargo.Size = New System.Drawing.Size(349, 20)
        Me.cbCargo.TabIndex = 191
        '
        'vCargos
        '
        Me.vCargos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCargos.Name = "vCargos"
        Me.vCargos.OptionsBehavior.Editable = False
        Me.vCargos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCargos.OptionsView.ShowAutoFilterRow = True
        Me.vCargos.OptionsView.ShowGroupPanel = False
        '
        'cbArea
        '
        Me.cbArea.EditValue = "[Seleccione Departamento]"
        Me.cbArea.Location = New System.Drawing.Point(120, 263)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbArea.Properties.NullText = "[Seleccione Area]"
        Me.cbArea.Properties.View = Me.vAreas
        Me.cbArea.Size = New System.Drawing.Size(349, 20)
        Me.cbArea.TabIndex = 190
        '
        'vAreas
        '
        Me.vAreas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.are_codigo})
        Me.vAreas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vAreas.Name = "vAreas"
        Me.vAreas.OptionsBehavior.Editable = False
        Me.vAreas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vAreas.OptionsView.ShowAutoFilterRow = True
        Me.vAreas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.FieldName = "Area"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Area"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'are_codigo
        '
        Me.are_codigo.Caption = "Are Codigo"
        Me.are_codigo.FieldName = "are_codigo"
        Me.are_codigo.Name = "are_codigo"
        Me.are_codigo.Visible = True
        Me.are_codigo.VisibleIndex = 2
        '
        'cbDepartamento
        '
        Me.cbDepartamento.EditValue = "[Seleccione Departamento]"
        Me.cbDepartamento.Location = New System.Drawing.Point(120, 240)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamento.Properties.NullText = "[Seleccione Departamento]"
        Me.cbDepartamento.Properties.View = Me.vDepartamento
        Me.cbDepartamento.Size = New System.Drawing.Size(349, 20)
        Me.cbDepartamento.TabIndex = 189
        '
        'vDepartamento
        '
        Me.vDepartamento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vDepartamento.Name = "vDepartamento"
        Me.vDepartamento.OptionsBehavior.Editable = False
        Me.vDepartamento.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vDepartamento.OptionsView.ShowAutoFilterRow = True
        Me.vDepartamento.OptionsView.ShowGroupPanel = False
        '
        'cbLocalidad
        '
        Me.cbLocalidad.Location = New System.Drawing.Point(120, 217)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLocalidad.Properties.NullText = "[Seleccione una Localidad/Sucursal]"
        Me.cbLocalidad.Properties.View = Me.vLocalidad
        Me.cbLocalidad.Size = New System.Drawing.Size(349, 20)
        Me.cbLocalidad.TabIndex = 188
        '
        'vLocalidad
        '
        Me.vLocalidad.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.vLocalidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vLocalidad.Name = "vLocalidad"
        Me.vLocalidad.OptionsBehavior.Editable = False
        Me.vLocalidad.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vLocalidad.OptionsView.ShowAutoFilterRow = True
        Me.vLocalidad.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Codigo"
        Me.GridColumn9.FieldName = "Codigo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Descripcion"
        Me.GridColumn10.FieldName = "Descripcion"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(8, 213)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(112, 24)
        Me.Label53.TabIndex = 182
        Me.Label53.Text = "Localidad"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(6, 139)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(104, 16)
        Me.Label48.TabIndex = 179
        Me.Label48.Text = "Fecha Baja:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(8, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 24)
        Me.Label16.TabIndex = 177
        Me.Label16.Text = "Area"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.chkBonificar)
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.dtpHastaContrato)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox8.Controls.Add(Me.cbTipoContrato)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(11, 24)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(460, 108)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tipo de Registro/Contrato"
        '
        'chkBonificar
        '
        Me.chkBonificar.Location = New System.Drawing.Point(6, 82)
        Me.chkBonificar.Name = "chkBonificar"
        Me.chkBonificar.Properties.Caption = "Cerrar Contrato"
        Me.chkBonificar.Size = New System.Drawing.Size(170, 19)
        Me.chkBonificar.TabIndex = 182
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(300, 61)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(112, 16)
        Me.Label51.TabIndex = 176
        Me.Label51.Text = "Hasta:"
        '
        'dtpHastaContrato
        '
        Me.dtpHastaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaContrato.Location = New System.Drawing.Point(303, 80)
        Me.dtpHastaContrato.Name = "dtpHastaContrato"
        Me.dtpHastaContrato.Size = New System.Drawing.Size(111, 21)
        Me.dtpHastaContrato.TabIndex = 175
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(300, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "Desde:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(303, 32)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(123, 21)
        Me.dtpFechaIngreso.TabIndex = 173
        '
        'cbTipoContrato
        '
        Me.cbTipoContrato.Location = New System.Drawing.Point(9, 33)
        Me.cbTipoContrato.Name = "cbTipoContrato"
        Me.cbTipoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoContrato.Properties.NullText = ""
        Me.cbTipoContrato.Properties.PopupSizeable = False
        Me.cbTipoContrato.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbTipoContrato.Size = New System.Drawing.Size(264, 20)
        Me.cbTipoContrato.TabIndex = 183
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Funci�n:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Cargo:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Departamento:"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(6, 187)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(144, 20)
        Me.Label38.TabIndex = 175
        Me.Label38.Text = "Acum. Vacaciones:"
        '
        'txtAcumVac
        '
        Me.txtAcumVac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcumVac.Location = New System.Drawing.Point(166, 187)
        Me.txtAcumVac.MaxLength = 10
        Me.txtAcumVac.Name = "txtAcumVac"
        Me.txtAcumVac.ReadOnly = True
        Me.txtAcumVac.Size = New System.Drawing.Size(144, 20)
        Me.txtAcumVac.TabIndex = 171
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(6, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 16)
        Me.Label18.TabIndex = 173
        Me.Label18.Text = "Tiempo de Trabajar:"
        '
        'txtTiempoTrabajar
        '
        Me.txtTiempoTrabajar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoTrabajar.Location = New System.Drawing.Point(166, 163)
        Me.txtTiempoTrabajar.MaxLength = 10
        Me.txtTiempoTrabajar.Name = "txtTiempoTrabajar"
        Me.txtTiempoTrabajar.ReadOnly = True
        Me.txtTiempoTrabajar.Size = New System.Drawing.Size(144, 20)
        Me.txtTiempoTrabajar.TabIndex = 165
        '
        'txtbaja
        '
        Me.txtbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaja.Location = New System.Drawing.Point(166, 138)
        Me.txtbaja.MaxLength = 10
        Me.txtbaja.Name = "txtbaja"
        Me.txtbaja.ReadOnly = True
        Me.txtbaja.Size = New System.Drawing.Size(144, 20)
        Me.txtbaja.TabIndex = 180
        '
        'dtpFechaBaja
        '
        Me.dtpFechaBaja.Enabled = False
        Me.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBaja.Location = New System.Drawing.Point(166, 138)
        Me.dtpFechaBaja.Name = "dtpFechaBaja"
        Me.dtpFechaBaja.Size = New System.Drawing.Size(144, 21)
        Me.dtpFechaBaja.TabIndex = 178
        '
        'gbFirma
        '
        Me.gbFirma.Controls.Add(Me.GroupBox5)
        Me.gbFirma.Controls.Add(Me.GroupBox3)
        Me.gbFirma.Controls.Add(Me.Label47)
        Me.gbFirma.Controls.Add(Me.Firma)
        Me.gbFirma.Location = New System.Drawing.Point(3, 59)
        Me.gbFirma.Name = "gbFirma"
        Me.gbFirma.Size = New System.Drawing.Size(829, 451)
        Me.gbFirma.TabIndex = 5
        Me.gbFirma.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.cbDepartamentoMurohs)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 204)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(812, 72)
        Me.GroupBox5.TabIndex = 120
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Nomina Murohs"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(16, 28)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(112, 24)
        Me.Label39.TabIndex = 121
        Me.Label39.Text = "Departamento:"
        '
        'cbDepartamentoMurohs
        '
        Me.cbDepartamentoMurohs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamentoMurohs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentoMurohs.ItemHeight = 15
        Me.cbDepartamentoMurohs.Location = New System.Drawing.Point(128, 28)
        Me.cbDepartamentoMurohs.Name = "cbDepartamentoMurohs"
        Me.cbDepartamentoMurohs.Size = New System.Drawing.Size(312, 23)
        Me.cbDepartamentoMurohs.TabIndex = 120
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdDisponibilidadLogin)
        Me.GroupBox3.Controls.Add(Me.txtUserName)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(812, 72)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nomina Web"
        '
        'cmdDisponibilidadLogin
        '
        Me.cmdDisponibilidadLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisponibilidadLogin.ForeColor = System.Drawing.Color.Black
        Me.cmdDisponibilidadLogin.Location = New System.Drawing.Point(361, 24)
        Me.cmdDisponibilidadLogin.Name = "cmdDisponibilidadLogin"
        Me.cmdDisponibilidadLogin.Size = New System.Drawing.Size(162, 24)
        Me.cmdDisponibilidadLogin.TabIndex = 119
        Me.cmdDisponibilidadLogin.Text = "Revisar Disponibilidad"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(104, 24)
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(224, 20)
        Me.txtUserName.TabIndex = 117
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(16, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(80, 24)
        Me.Label49.TabIndex = 118
        Me.Label49.Text = "User Name:"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(8, 24)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(72, 24)
        Me.Label47.TabIndex = 116
        Me.Label47.Text = "Firma:"
        '
        'Firma
        '
        Me.Firma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Firma.Location = New System.Drawing.Point(96, 16)
        Me.Firma.Name = "Firma"
        Me.Firma.Size = New System.Drawing.Size(216, 72)
        Me.Firma.TabIndex = 115
        Me.Firma.TabStop = False
        '
        'gbContacto
        '
        Me.gbContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbContacto.Controls.Add(Me.Label23)
        Me.gbContacto.Controls.Add(Me.txtTelefonoContacto)
        Me.gbContacto.Controls.Add(Me.Label26)
        Me.gbContacto.Controls.Add(Me.txtNombreContacto)
        Me.gbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContacto.ForeColor = System.Drawing.Color.Maroon
        Me.gbContacto.Location = New System.Drawing.Point(3, 3)
        Me.gbContacto.Name = "gbContacto"
        Me.gbContacto.Size = New System.Drawing.Size(829, 56)
        Me.gbContacto.TabIndex = 2
        Me.gbContacto.TabStop = False
        Me.gbContacto.Text = "CONTACTO DE EMERGENCIA"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(472, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 24)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Tel�fono:"
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(560, 24)
        Me.txtTelefonoContacto.MaxLength = 10
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(232, 20)
        Me.txtTelefonoContacto.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(8, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 24)
        Me.Label26.TabIndex = 71
        Me.Label26.Text = "Nombre:"
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreContacto.Location = New System.Drawing.Point(96, 24)
        Me.txtNombreContacto.MaxLength = 50
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(232, 20)
        Me.txtNombreContacto.TabIndex = 0
        '
        'TPDatosGenerales
        '
        Me.TPDatosGenerales.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPDatosGenerales.Controls.Add(Me.gbDatosGenerales)
        Me.TPDatosGenerales.Location = New System.Drawing.Point(4, 25)
        Me.TPDatosGenerales.Name = "TPDatosGenerales"
        Me.TPDatosGenerales.Size = New System.Drawing.Size(855, 513)
        Me.TPDatosGenerales.TabIndex = 0
        Me.TPDatosGenerales.Text = "Datos Personales"
        Me.TPDatosGenerales.UseVisualStyleBackColor = True
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox12)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox13)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox11)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox10)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox9)
        Me.gbDatosGenerales.Controls.Add(Me.Fotografia)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Maroon
        Me.gbDatosGenerales.Location = New System.Drawing.Point(0, 3)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(855, 533)
        Me.gbDatosGenerales.TabIndex = 0
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "DATOS GENERALES"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtInss)
        Me.GroupBox12.Controls.Add(Me.Label52)
        Me.GroupBox12.Controls.Add(Me.cbRegimenINSS)
        Me.GroupBox12.Controls.Add(Me.Label13)
        Me.GroupBox12.Controls.Add(Me.txtCedula)
        Me.GroupBox12.Controls.Add(Me.Label15)
        Me.GroupBox12.Controls.Add(Me.txtRuc)
        Me.GroupBox12.Controls.Add(Me.Label10)
        Me.GroupBox12.Controls.Add(Me.Label12)
        Me.GroupBox12.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox12.Controls.Add(Me.Label11)
        Me.GroupBox12.Controls.Add(Me.txtEdad)
        Me.GroupBox12.Controls.Add(Me.Label31)
        Me.GroupBox12.Controls.Add(Me.cbSexo)
        Me.GroupBox12.Controls.Add(Me.Label17)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 331)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(776, 96)
        Me.GroupBox12.TabIndex = 167
        Me.GroupBox12.TabStop = False
        '
        'txtInss
        '
        Me.txtInss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInss.Location = New System.Drawing.Point(619, 16)
        Me.txtInss.MaxLength = 10
        Me.txtInss.Name = "txtInss"
        Me.txtInss.Size = New System.Drawing.Size(151, 20)
        Me.txtInss.TabIndex = 2
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(538, 38)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(74, 24)
        Me.Label52.TabIndex = 117
        Me.Label52.Text = "Regimen:"
        '
        'cbRegimenINSS
        '
        Me.cbRegimenINSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegimenINSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRegimenINSS.ItemHeight = 15
        Me.cbRegimenINSS.Location = New System.Drawing.Point(619, 39)
        Me.cbRegimenINSS.Name = "cbRegimenINSS"
        Me.cbRegimenINSS.Size = New System.Drawing.Size(152, 23)
        Me.cbRegimenINSS.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 24)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "C�dula:"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(120, 16)
        Me.txtCedula.MaxLength = 14
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(152, 20)
        Me.txtCedula.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(280, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 24)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "RUC:"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(360, 16)
        Me.txtRuc.MaxLength = 16
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(176, 20)
        Me.txtRuc.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(538, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 24)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "No. INSS:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Fecha Nac.:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(120, 41)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(152, 21)
        Me.dtpFechaNacimiento.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(280, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Edad:"
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(360, 42)
        Me.txtEdad.MaxLength = 10
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(72, 20)
        Me.txtEdad.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(432, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 24)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "A�os."
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ItemHeight = 15
        Me.cbSexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbSexo.Location = New System.Drawing.Point(120, 68)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(152, 23)
        Me.cbSexo.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(8, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 24)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Sexo:"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.cbNivelAcademico)
        Me.GroupBox13.Controls.Add(Me.cbProfesion)
        Me.GroupBox13.Controls.Add(Me.Label28)
        Me.GroupBox13.Controls.Add(Me.Label27)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 433)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(776, 45)
        Me.GroupBox13.TabIndex = 168
        Me.GroupBox13.TabStop = False
        '
        'cbNivelAcademico
        '
        Me.cbNivelAcademico.Location = New System.Drawing.Point(135, 13)
        Me.cbNivelAcademico.Name = "cbNivelAcademico"
        Me.cbNivelAcademico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbNivelAcademico.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripcion")})
        Me.cbNivelAcademico.Properties.NullText = "[Seleccione]"
        Me.cbNivelAcademico.Size = New System.Drawing.Size(169, 20)
        Me.cbNivelAcademico.TabIndex = 113
        '
        'cbProfesion
        '
        Me.cbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProfesion.ItemHeight = 15
        Me.cbProfesion.Location = New System.Drawing.Point(390, 16)
        Me.cbProfesion.Name = "cbProfesion"
        Me.cbProfesion.Size = New System.Drawing.Size(320, 23)
        Me.cbProfesion.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(304, 13)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 24)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "Profesi�n:"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(8, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(130, 23)
        Me.Label27.TabIndex = 110
        Me.Label27.Text = "Nivel Acad�mico:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label5)
        Me.GroupBox11.Controls.Add(Me.txtCelular)
        Me.GroupBox11.Controls.Add(Me.txtTelefono)
        Me.GroupBox11.Controls.Add(Me.Label22)
        Me.GroupBox11.Controls.Add(Me.txtEmail)
        Me.GroupBox11.Controls.Add(Me.Label6)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 259)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(776, 66)
        Me.GroupBox11.TabIndex = 166
        Me.GroupBox11.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(280, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Celular:"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(352, 17)
        Me.txtCelular.MaxLength = 50
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(152, 20)
        Me.txtCelular.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(120, 17)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefono.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(8, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 20)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "E-Mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(120, 41)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(384, 20)
        Me.txtEmail.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Tel�fono:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label40)
        Me.GroupBox10.Controls.Add(Me.cbPais)
        Me.GroupBox10.Controls.Add(Me.Label4)
        Me.GroupBox10.Controls.Add(Me.txtDireccion)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.cbMunicipios)
        Me.GroupBox10.Controls.Add(Me.cbDepartamentos)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 130)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(776, 123)
        Me.GroupBox10.TabIndex = 165
        Me.GroupBox10.TabStop = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(8, 59)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 24)
        Me.Label40.TabIndex = 148
        Me.Label40.Text = "Pais:"
        '
        'cbPais
        '
        Me.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPais.Location = New System.Drawing.Point(120, 60)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(264, 23)
        Me.cbPais.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Direcci�n:"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(120, 16)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(632, 40)
        Me.txtDireccion.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(408, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 24)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Municipio:"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(8, 87)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 24)
        Me.Label33.TabIndex = 146
        Me.Label33.Text = "Departamento:"
        '
        'cbMunicipios
        '
        Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipios.Location = New System.Drawing.Point(488, 88)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Size = New System.Drawing.Size(264, 23)
        Me.cbMunicipios.TabIndex = 2
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Location = New System.Drawing.Point(120, 88)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Size = New System.Drawing.Size(264, 23)
        Me.cbDepartamentos.TabIndex = 1
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtCodigo)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.txtSNombre)
        Me.GroupBox9.Controls.Add(Me.txtSApellido)
        Me.GroupBox9.Controls.Add(Me.txtPNombre)
        Me.GroupBox9.Controls.Add(Me.txtPApellido)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(632, 104)
        Me.GroupBox9.TabIndex = 164
        Me.GroupBox9.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(104, 16)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "C�digo:"
        '
        'txtSNombre
        '
        Me.txtSNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNombre.Location = New System.Drawing.Point(416, 40)
        Me.txtSNombre.MaxLength = 20
        Me.txtSNombre.Name = "txtSNombre"
        Me.txtSNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtSNombre.TabIndex = 2
        '
        'txtSApellido
        '
        Me.txtSApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApellido.Location = New System.Drawing.Point(416, 64)
        Me.txtSApellido.MaxLength = 20
        Me.txtSApellido.Name = "txtSApellido"
        Me.txtSApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtSApellido.TabIndex = 4
        '
        'txtPNombre
        '
        Me.txtPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNombre.Location = New System.Drawing.Point(104, 40)
        Me.txtPNombre.MaxLength = 20
        Me.txtPNombre.Name = "txtPNombre"
        Me.txtPNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtPNombre.TabIndex = 1
        '
        'txtPApellido
        '
        Me.txtPApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApellido.Location = New System.Drawing.Point(104, 64)
        Me.txtPApellido.MaxLength = 20
        Me.txtPApellido.Name = "txtPApellido"
        Me.txtPApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtPApellido.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "1er. Nombre:"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(8, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 24)
        Me.Label36.TabIndex = 151
        Me.Label36.Text = "1er. Apellido:"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(312, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 24)
        Me.Label34.TabIndex = 149
        Me.Label34.Text = "2do. Nombre:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(312, 64)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 24)
        Me.Label35.TabIndex = 153
        Me.Label35.Text = "2do. Apellido:"
        '
        'Fotografia
        '
        Me.Fotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fotografia.Location = New System.Drawing.Point(674, 20)
        Me.Fotografia.Name = "Fotografia"
        Me.Fotografia.Size = New System.Drawing.Size(104, 104)
        Me.Fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fotografia.TabIndex = 114
        Me.Fotografia.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TPDatosGenerales)
        Me.TabControl.Controls.Add(Me.TPDatosLaborales)
        Me.TabControl.Controls.Add(Me.TPOtros)
        Me.TabControl.Controls.Add(Me.TPPlanillas)
        Me.TabControl.Controls.Add(Me.TPMovimientos)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.MCS)
        Me.TabControl.Controls.Add(Me.tbOrganigrama)
        Me.TabControl.Controls.Add(Me.TPContratos)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(16, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(863, 542)
        Me.TabControl.TabIndex = 164
        '
        'TPOtros
        '
        Me.TPOtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPOtros.Controls.Add(Me.gbFirma)
        Me.TPOtros.Controls.Add(Me.gbContacto)
        Me.TPOtros.Location = New System.Drawing.Point(4, 25)
        Me.TPOtros.Name = "TPOtros"
        Me.TPOtros.Size = New System.Drawing.Size(855, 513)
        Me.TPOtros.TabIndex = 5
        Me.TPOtros.Text = "Otros Datos"
        Me.TPOtros.UseVisualStyleBackColor = True
        '
        'TPMovimientos
        '
        Me.TPMovimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPMovimientos.Controls.Add(Me.Button3)
        Me.TPMovimientos.Controls.Add(Me.dgMovimientos)
        Me.TPMovimientos.Location = New System.Drawing.Point(4, 25)
        Me.TPMovimientos.Name = "TPMovimientos"
        Me.TPMovimientos.Size = New System.Drawing.Size(855, 513)
        Me.TPMovimientos.TabIndex = 4
        Me.TPMovimientos.Text = "Movimientos"
        Me.TPMovimientos.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button3.Location = New System.Drawing.Point(767, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "&Exportar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgMovimientos
        '
        Me.dgMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMovimientos.Location = New System.Drawing.Point(17, 40)
        Me.dgMovimientos.MainView = Me.VMovimientos
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.Size = New System.Drawing.Size(835, 470)
        Me.dgMovimientos.TabIndex = 0
        Me.dgMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VMovimientos})
        '
        'VMovimientos
        '
        Me.VMovimientos.GridControl = Me.dgMovimientos
        Me.VMovimientos.Name = "VMovimientos"
        Me.VMovimientos.OptionsView.ShowAutoFilterRow = True
        Me.VMovimientos.OptionsView.ShowFooter = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(855, 513)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Campos Din�micos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.cmdcBorrar)
        Me.GroupBox6.Controls.Add(Me.cmdCAgregar)
        Me.GroupBox6.Controls.Add(Me.dgCamposDinamicos)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(849, 507)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'cmdcBorrar
        '
        Me.cmdcBorrar.Location = New System.Drawing.Point(87, 478)
        Me.cmdcBorrar.Name = "cmdcBorrar"
        Me.cmdcBorrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcBorrar.TabIndex = 2
        Me.cmdcBorrar.Text = "Borrar"
        Me.cmdcBorrar.Visible = False
        '
        'cmdCAgregar
        '
        Me.cmdCAgregar.Location = New System.Drawing.Point(6, 478)
        Me.cmdCAgregar.Name = "cmdCAgregar"
        Me.cmdCAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCAgregar.TabIndex = 1
        Me.cmdCAgregar.Text = "Agregar"
        Me.cmdCAgregar.Visible = False
        '
        'dgCamposDinamicos
        '
        Me.dgCamposDinamicos.Location = New System.Drawing.Point(0, 11)
        Me.dgCamposDinamicos.MainView = Me.vCampos
        Me.dgCamposDinamicos.Name = "dgCamposDinamicos"
        Me.dgCamposDinamicos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCampo, Me.cbValores})
        Me.dgCamposDinamicos.Size = New System.Drawing.Size(843, 428)
        Me.dgCamposDinamicos.TabIndex = 0
        Me.dgCamposDinamicos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vCampos})
        '
        'vCampos
        '
        Me.vCampos.GridControl = Me.dgCamposDinamicos
        Me.vCampos.Name = "vCampos"
        Me.vCampos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vCampos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vCampos.OptionsView.ShowFooter = True
        Me.vCampos.OptionsView.ShowGroupPanel = False
        '
        'cbCampo
        '
        Me.cbCampo.AutoHeight = False
        Me.cbCampo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCampo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre_campo", 50, "Descripcion")})
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.NullText = ""
        '
        'cbValores
        '
        Me.cbValores.AutoHeight = False
        Me.cbValores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbValores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valor", 50, "Name2")})
        Me.cbValores.Name = "cbValores"
        Me.cbValores.NullText = ""
        '
        'MCS
        '
        Me.MCS.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MCS.Controls.Add(Me.gbMcs)
        Me.MCS.Location = New System.Drawing.Point(4, 25)
        Me.MCS.Name = "MCS"
        Me.MCS.Size = New System.Drawing.Size(855, 513)
        Me.MCS.TabIndex = 7
        Me.MCS.Text = "MCS"
        '
        'gbMcs
        '
        Me.gbMcs.Controls.Add(Me.dgMCSMaximos)
        Me.gbMcs.Controls.Add(Me.GroupBox4)
        Me.gbMcs.Location = New System.Drawing.Point(12, 14)
        Me.gbMcs.Name = "gbMcs"
        Me.gbMcs.Size = New System.Drawing.Size(840, 483)
        Me.gbMcs.TabIndex = 80
        Me.gbMcs.TabStop = False
        Me.gbMcs.Text = "Meal Control System (MCS)"
        '
        'dgMCSMaximos
        '
        Me.dgMCSMaximos.Location = New System.Drawing.Point(8, 131)
        Me.dgMCSMaximos.MainView = Me.vMCSMaximos
        Me.dgMCSMaximos.Name = "dgMCSMaximos"
        Me.dgMCSMaximos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTipoSesion})
        Me.dgMCSMaximos.Size = New System.Drawing.Size(826, 328)
        Me.dgMCSMaximos.TabIndex = 185
        Me.dgMCSMaximos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vMCSMaximos})
        '
        'vMCSMaximos
        '
        Me.vMCSMaximos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Tipo, Me.Empleado, Me.Invitados})
        Me.vMCSMaximos.GridControl = Me.dgMCSMaximos
        Me.vMCSMaximos.Name = "vMCSMaximos"
        Me.vMCSMaximos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vMCSMaximos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vMCSMaximos.OptionsView.ShowFooter = True
        Me.vMCSMaximos.OptionsView.ShowGroupPanel = False
        '
        'Tipo
        '
        Me.Tipo.Caption = "Tipo"
        Me.Tipo.ColumnEdit = Me.cbTipoSesion
        Me.Tipo.FieldName = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Visible = True
        Me.Tipo.VisibleIndex = 0
        '
        'cbTipoSesion
        '
        Me.cbTipoSesion.AutoHeight = False
        Me.cbTipoSesion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoSesion.Items.AddRange(New Object() {"Desayuno", "Almuerzo", "Cena"})
        Me.cbTipoSesion.Name = "cbTipoSesion"
        '
        'Empleado
        '
        Me.Empleado.Caption = "M�x Comida Empleado"
        Me.Empleado.FieldName = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Visible = True
        Me.Empleado.VisibleIndex = 1
        '
        'Invitados
        '
        Me.Invitados.Caption = "M�x. Comida Invitados"
        Me.Invitados.FieldName = "Invitados"
        Me.Invitados.Name = "Invitados"
        Me.Invitados.Visible = True
        Me.Invitados.VisibleIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkGaseosa)
        Me.GroupBox4.Controls.Add(Me.chkComida)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 74)
        Me.GroupBox4.TabIndex = 184
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Subsidio Total:"
        '
        'chkGaseosa
        '
        Me.chkGaseosa.Location = New System.Drawing.Point(17, 45)
        Me.chkGaseosa.Name = "chkGaseosa"
        Me.chkGaseosa.Properties.Caption = "Gaseosa"
        Me.chkGaseosa.Size = New System.Drawing.Size(108, 19)
        Me.chkGaseosa.TabIndex = 1
        '
        'chkComida
        '
        Me.chkComida.Location = New System.Drawing.Point(17, 20)
        Me.chkComida.Name = "chkComida"
        Me.chkComida.Properties.Caption = "Comida"
        Me.chkComida.Size = New System.Drawing.Size(108, 19)
        Me.chkComida.TabIndex = 0
        '
        'tbOrganigrama
        '
        Me.tbOrganigrama.Controls.Add(Me.dgOrganigramaD)
        Me.tbOrganigrama.Controls.Add(Me.LabelControl1)
        Me.tbOrganigrama.Controls.Add(Me.Treelist1)
        Me.tbOrganigrama.Location = New System.Drawing.Point(4, 25)
        Me.tbOrganigrama.Name = "tbOrganigrama"
        Me.tbOrganigrama.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOrganigrama.Size = New System.Drawing.Size(855, 513)
        Me.tbOrganigrama.TabIndex = 8
        Me.tbOrganigrama.Text = "Organigrama"
        Me.tbOrganigrama.UseVisualStyleBackColor = True
        '
        'dgOrganigramaD
        '
        Me.dgOrganigramaD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOrganigramaD.Location = New System.Drawing.Point(3, 242)
        Me.dgOrganigramaD.MainView = Me.vListaOrganigrama
        Me.dgOrganigramaD.Name = "dgOrganigramaD"
        Me.dgOrganigramaD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbOrganigramaD, Me.spFactor})
        Me.dgOrganigramaD.Size = New System.Drawing.Size(846, 200)
        Me.dgOrganigramaD.TabIndex = 19
        Me.dgOrganigramaD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vListaOrganigrama})
        '
        'vListaOrganigrama
        '
        Me.vListaOrganigrama.GridControl = Me.dgOrganigramaD
        Me.vListaOrganigrama.Name = "vListaOrganigrama"
        Me.vListaOrganigrama.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vListaOrganigrama.OptionsView.ShowAutoFilterRow = True
        Me.vListaOrganigrama.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vListaOrganigrama.OptionsView.ShowFooter = True
        Me.vListaOrganigrama.OptionsView.ShowGroupPanel = False
        '
        'cbOrganigramaD
        '
        Me.cbOrganigramaD.AutoHeight = False
        Me.cbOrganigramaD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrganigramaD.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("org_descripcion", 200, "Descripcion")})
        Me.cbOrganigramaD.Name = "cbOrganigramaD"
        Me.cbOrganigramaD.NullText = "[Seleccione el Centro de Costo]"
        '
        'spFactor
        '
        Me.spFactor.AutoHeight = False
        Me.spFactor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spFactor.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.spFactor.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spFactor.Name = "spFactor"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(168, 16)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Centro de Costo Principal:"
        '
        'Treelist1
        '
        Me.Treelist1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Treelist1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Treelist1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Treelist1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treelist1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Treelist1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Treelist1.Appearance.FocusedRow.Options.UseFont = True
        Me.Treelist1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Treelist1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Treelist1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Treelist1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treelist1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Treelist1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Treelist1.Appearance.SelectedRow.Options.UseFont = True
        Me.Treelist1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Treelist1.Location = New System.Drawing.Point(3, 23)
        Me.Treelist1.Name = "Treelist1"
        Me.Treelist1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados})
        Me.Treelist1.Size = New System.Drawing.Size(846, 181)
        Me.Treelist1.TabIndex = 17
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", 200, "Nombre")})
        Me.cbEmpleados.Name = "cbEmpleados"
        '
        'TPContratos
        '
        Me.TPContratos.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPContratos.Controls.Add(Me.cmdLiquidar)
        Me.TPContratos.Controls.Add(Me.dgContratos)
        Me.TPContratos.Location = New System.Drawing.Point(4, 25)
        Me.TPContratos.Name = "TPContratos"
        Me.TPContratos.Padding = New System.Windows.Forms.Padding(3)
        Me.TPContratos.Size = New System.Drawing.Size(855, 513)
        Me.TPContratos.TabIndex = 9
        Me.TPContratos.Text = "Contratos"
        '
        'cmdLiquidar
        '
        Me.cmdLiquidar.Location = New System.Drawing.Point(7, 484)
        Me.cmdLiquidar.Name = "cmdLiquidar"
        Me.cmdLiquidar.Size = New System.Drawing.Size(116, 23)
        Me.cmdLiquidar.TabIndex = 1
        Me.cmdLiquidar.Text = "Generar Liquidacion"
        '
        'dgContratos
        '
        Me.dgContratos.Location = New System.Drawing.Point(7, 23)
        Me.dgContratos.MainView = Me.vContratos
        Me.dgContratos.Name = "dgContratos"
        Me.dgContratos.Size = New System.Drawing.Size(842, 444)
        Me.dgContratos.TabIndex = 0
        Me.dgContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vContratos})
        '
        'vContratos
        '
        Me.vContratos.GridControl = Me.dgContratos
        Me.vContratos.Name = "vContratos"
        Me.vContratos.OptionsBehavior.ReadOnly = True
        Me.vContratos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vContratos.OptionsView.ShowFooter = True
        Me.vContratos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Codigo"
        Me.GridColumn3.FieldName = "Codigo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Departamento"
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Codigo"
        Me.GridColumn5.FieldName = "Codigo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripcion"
        Me.GridColumn6.FieldName = "Descripcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Codigo"
        Me.GridColumn7.FieldName = "Codigo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cargo"
        Me.GridColumn8.FieldName = "Nombre"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'frmAgregarEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "frmAgregarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.TPPlanillas.ResumeLayout(False)
        Me.gbAfiscal.ResumeLayout(False)
        Me.gbAfiscal.PerformLayout()
        CType(Me.dgAFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VAfiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDatosLaborales.ResumeLayout(False)
        Me.gbHorario.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.gbSalario.ResumeLayout(False)
        Me.gbSalario.PerformLayout()
        CType(Me.cbMonedaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.gbDatosLaborales.ResumeLayout(False)
        Me.gbDatosLaborales.PerformLayout()
        CType(Me.cbFuncion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLocalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.chkBonificar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFirma.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Firma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbContacto.ResumeLayout(False)
        Me.gbContacto.PerformLayout()
        Me.TPDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.cbNivelAcademico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.Fotografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TPOtros.ResumeLayout(False)
        Me.TPMovimientos.ResumeLayout(False)
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgCamposDinamicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCampo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbValores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MCS.ResumeLayout(False)
        Me.gbMcs.ResumeLayout(False)
        CType(Me.dgMCSMaximos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vMCSMaximos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.chkGaseosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOrganigrama.ResumeLayout(False)
        Me.tbOrganigrama.PerformLayout()
        CType(Me.dgOrganigramaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vListaOrganigrama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrganigramaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Treelist1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPContratos.ResumeLayout(False)
        CType(Me.dgContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Empresa As VB.SysContab.EmpresasDetails
        Dim detHorario As New VB.SysContab.HorarioDetails()
        Try

            dtValores = VB.SysContab.CamposDB.GetDatos(0)

            Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
            sAFiscal = VB.SysContab.PeriodosDB.Activo(Now.Date) ''DatePart(DateInterval.Year, Empresa.Fecha_InicioAF.Date) & "-" & DatePart(DateInterval.Year, Empresa.Fecha_CierreAF.Date)

            Me.cbNivelAcademico.Properties.DataSource = NivelAcademicoDB.List(0)
            Me.cbNivelAcademico.Properties.DisplayMember = "descripcion"
            Me.cbNivelAcademico.Properties.ValueMember = "id"

            Me.cbOrganigramaD.DataSource = VB.SysContab.RH_OrganigramaDB.Listar()
            Me.cbOrganigramaD.DisplayMember = "org_descripcion"
            Me.cbOrganigramaD.ValueMember = "org_codigo"

            CBHorario.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
            CBHorario.ValueMember = "Codigo"
            CBHorario.DisplayMember = "Descripcion"

            Me.cbAfiscal.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
            Me.cbAfiscal.ValueMember = "Per_ID"
            Me.cbAfiscal.DisplayMember = "Descripcion"

            cbMonedaPago.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
            cbMonedaPago.Properties.ValueMember = "Codigo"
            cbMonedaPago.Properties.DisplayMember = "Descripcion"

            Me.cbRegimenINSS.DataSource = RegimenINSSDB.GetList("%").Tables("RegimenINSS")
            Me.cbRegimenINSS.ValueMember = "reg_codigo"
            Me.cbRegimenINSS.DisplayMember = "reg_descripcion"

            Me.cbProfesion.DataSource = VB.SysContab.ProfesionDB.GetList().Tables("Profesion")
            Me.cbProfesion.ValueMember = "Codigo"
            Me.cbProfesion.DisplayMember = "Descripcion"

            cbLocalidad.Properties.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
            cbLocalidad.Properties.ValueMember = "Codigo"
            cbLocalidad.Properties.DisplayMember = "Descripcion"

            cbDepartamentos.DataSource = VB.SysContab.DepartamentosCDB.GetList()
            cbDepartamentos.ValueMember = "Codigo"
            cbDepartamentos.DisplayMember = "Nombre"


            cbDepartamentoMurohs.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo_Murohs()
            cbDepartamentoMurohs.ValueMember = "Codigo"
            cbDepartamentoMurohs.DisplayMember = "Nombre"

            Me.cbArea.Properties.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
            Me.cbArea.Properties.ValueMember = "Area"
            Me.cbArea.Properties.DisplayMember = "Descripcion"

            Me.cbDepartamento.Properties.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
            Me.cbDepartamento.Properties.ValueMember = "Codigo"
            Me.cbDepartamento.Properties.DisplayMember = "Nombre"

            cbCargo.Properties.DataSource = VB.SysContab.CargosDB.GetListBuscarCombo("%").Tables("Cargos")
            cbCargo.Properties.ValueMember = "Codigo"
            cbCargo.Properties.DisplayMember = "Nombre"

            cbFuncion.Properties.DataSource = VB.SysContab.FuncionesDB.GetListBuscarCombo("%").Tables("Funciones")
            cbFuncion.Properties.ValueMember = "Codigo"
            cbFuncion.Properties.DisplayMember = "Nombre"

            Me.cbPais.DataSource = VB.SysContab.PaisesDB.GetList(True).Tables(0)
            Me.cbPais.DisplayMember = "Nombre"
            Me.cbPais.ValueMember = "Codigo"

            Me.cbTipoContrato.Properties.DataSource = VB.SysContab.EmpleadosDB.RH_TipoContrato
            Me.cbTipoContrato.Properties.DisplayMember = "Descripcion"
            Me.cbTipoContrato.Properties.ValueMember = "Tipo"


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Me.cbBancos.Properties.DataSource = v.EjecutarComando("_GetBancos_Nomina", "Bancos")
            Me.cbBancos.Properties.ValueMember = "Codigo"
            Me.cbBancos.Properties.DisplayMember = "Nombre"
            Me.cbBancos.Properties.PopulateColumns()
            'Me.cbBancos.Properties.Columns("Codigo").Visible = False


            Me.txtTransporte.Text = 0.0
            Me.txtCodigo.BackColor = Color.White
            Me.txtCodigo.ForeColor = Color.Black
            Me.Fotografia.Image = Nothing
            Me.Firma.Image = Nothing
            Me.archivoFirma = ""
            Me.archivoFoto = ""

            Me.gbMcs.Visible = Empresa.MCS

            ''Campos Dinamicos
            Me.cbCampo.DataSource = VB.SysContab.CamposDB.GetList()
            Me.cbCampo.DisplayMember = "nombre_campo"
            Me.cbCampo.ValueMember = "id"

            Me.cbValores.DataSource = dtValores
            Me.cbValores.DisplayMember = "valor"
            Me.cbValores.ValueMember = "id_valor"

            Me.chkBonificar.EditValue = False

            If Nuevo = "NO" Then

                Me.dgContratos.DataSource = VB.SysContab.EmpleadosDB.RH_Contratos(Registro)
                Me.vContratos.PopulateColumns()

                Me.dgOrganigramaD.DataSource = VB.SysContab.EmpleadosDB.Organigrama_Detalle(Registro, 0)
                If Not Me.dgOrganigramaD.DataSource Is Nothing Then
                    Me.vListaOrganigrama.Columns("id_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("org_codigo").Caption = "Centro de Costo"
                    Me.vListaOrganigrama.Columns("org_codigo").ColumnEdit = Me.cbOrganigramaD
                    Me.vListaOrganigrama.Columns("emp_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("empr_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("porcentaje").Caption = "Porcentaje"
                    Me.vListaOrganigrama.Columns("porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Me.vListaOrganigrama.Columns("porcentaje").DisplayFormat.FormatString = "n2"
                    Me.vListaOrganigrama.Columns("porcentaje").ColumnEdit = spFactor
                    Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.DisplayFormat = "{0:n2}"
                    Me.vListaOrganigrama.BestFitColumns()
                End If

                Me.dgMovimientos.DataSource = VB.SysContab.PlanillaDB.Consolidado(Registro, Empresa.MONEDABASE).Tables(0).DefaultView
                Me.VMovimientos.OptionsView.ShowGroupedColumns = False
                If Not Me.VMovimientos Is Nothing Then
                    Me.VMovimientos.Columns("Mes").Group()
                    Me.VMovimientos.Columns("PeriodoNomina").Group()

                    Me.VMovimientos.Columns("Ingresos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Me.VMovimientos.Columns("Ingresos").DisplayFormat.FormatString = "n2"
                    Me.VMovimientos.Columns("Ingresos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.VMovimientos.Columns("Ingresos").SummaryItem.DisplayFormat = "{0:n2}"

                    Me.VMovimientos.Columns("Deducciones").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Me.VMovimientos.Columns("Deducciones").DisplayFormat.FormatString = "n2"
                    Me.VMovimientos.Columns("Deducciones").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.VMovimientos.Columns("Deducciones").SummaryItem.DisplayFormat = "{0:n2}"

                End If

                Dim MaxNomina As String = IIf(Me.dgMovimientos.DataSource.table.dataset.tables(0).compute("Max(PeriodoNomina)", "periodonomina not like 'V%' and periodonomina not like 'A%'") Is DBNull.Value, "", Me.dgMovimientos.DataSource.table.dataset.tables(0).compute("Max(PeriodoNomina)", "periodonomina not like 'V%' and periodonomina not like 'A%'"))

                Me.Emp_UltimaFechaPago = VB.SysContab.PeriodoNominaDB.GetDetails(MaxNomina).FFinal

                'Tomar el a�o fiscal actual de la empresa
                Me.dgAFiscal.DataSource = VB.SysContab.EmpleadosDB.GetListAfiscal(Me.txtCodigo.Text, IIf(Me.cbAfiscal.SelectedText Is DBNull.Value Or Me.cbAfiscal.SelectedText = "", sAFiscal, Me.cbAfiscal.SelectedText)).Tables("AFiscal")
                Me.VAfiscal.PopulateColumns()
                Me.VAfiscal.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
                Me.VAfiscal.OptionsSelection.MultiSelect = True
                Me.VAfiscal.Columns("Salario Basico").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("INSS Laboral").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("Ingreso Gravable INSS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("Ingreso Gravable IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("Ingresos Totales").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.VAfiscal.Columns("INSS Patronal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric


                Me.VAfiscal.Columns("Salario Basico").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("IR").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("INSS Laboral").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("Ingreso Gravable INSS").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("Ingreso Gravable IR").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("Ingresos Totales").DisplayFormat.FormatString = "n2"
                Me.VAfiscal.Columns("INSS Patronal").DisplayFormat.FormatString = "n2"

                Me.VAfiscal.Columns("Salario Basico").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("Salario Basico").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("IR").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("INSS Laboral").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("INSS Laboral").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("Ingreso Gravable INSS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("Ingreso Gravable INSS").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("Ingreso Gravable IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("Ingreso Gravable IR").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("Ingresos Totales").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("Ingresos Totales").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("INSS Patronal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.VAfiscal.Columns("INSS Patronal").SummaryItem.DisplayFormat = "{0:n2}"
                Me.VAfiscal.Columns("Fecha").Visible = False
                Me.VAfiscal.BestFitColumns()

                Me.cbAfiscal.SelectedText = DatePart(DateInterval.Year, Empresa.Fecha_InicioAF.Date) & "-" & DatePart(DateInterval.Year, Empresa.Fecha_CierreAF.Date)

                Me.BHorario.Enabled = True
                Me.Text = "Editar Empleado"

                Detalles = VB.SysContab.EmpleadosDB.GetDetails(Registro)

                Me.Organigrama = Detalles.Organigrama
                Me.chkAntiguedad.Checked = Detalles.Antiguedad

                Me.cbBancos.EditValue = Detalles.Banco
                Me.txtIdCuenta.Text = Detalles.Identificador
                Me.chkSalarioFijo.Checked = Detalles.SalarioFijo
                LoginAnterior = Detalles.UserName

                DetalleSubsidios = VB.SysContab.EmpleadosDB.GetDetailsSubsidios(Registro)
                Me.chkComida.Checked = DetalleSubsidios.Comida
                Me.chkGaseosa.Checked = DetalleSubsidios.Gaseosa
                Me.cbRegimenINSS.SelectedValue = Detalles.RegimenINSS
                Me.cbPais.SelectedValue = Detalles.Pais

                Me.Fotografia.Invalidate()
                If Not (Detalles.Foto Is Nothing) And Not (Detalles.Foto Is DBNull.Value) And LTrim(RTrim(Detalles.Foto)) <> "" Then
                    If File.Exists(Application.StartupPath & Detalles.Foto) Then
                        Me.Fotografia.Image = New Bitmap(Application.StartupPath & Detalles.Foto)
                    Else
                        MsgBox("No existe el archivo de la fotografia del empleado")
                    End If
                End If

                Me.Firma.Invalidate()
                If Not (Detalles.Firma Is Nothing) And Not (Detalles.Firma Is DBNull.Value) And LTrim(RTrim(Detalles.Firma)) <> "" Then
                    If File.Exists(Detalles.Firma) Then
                        Me.Firma.Image = New Bitmap(Detalles.Firma)
                    Else
                        MsgBox("No existe el archivo: " & Detalles.Firma, MsgBoxStyle.Critical)
                    End If
                End If

                Me.archivoFirma = Detalles.Firma
                Me.archivoFoto = Detalles.Foto
                Me.txtCodigo.Text = Detalles.Codigo
                Me.txtPNombre.Text = Detalles.PNombre
                Me.txtSNombre.Text = Detalles.SNombre
                Me.txtPApellido.Text = Detalles.PApellido
                Me.txtSApellido.Text = Detalles.SApellido

                Me.cargarcamposdinamicos()

                Me.CBHorario.SelectedValue = Detalles.Horario
                Me.cbLocalidad.EditValue = Detalles.Localidad
                Me.cbDepartamentos.SelectedValue = Detalles.DepartamentoC
                Me.cbDepartamentoMurohs.SelectedValue = Detalles.Departamento_Murohs

                Me.cbMunicipios.DataSource = VB.SysContab.MunicipiosDB.GetList(cbDepartamentos.SelectedValue.ToString)
                Me.cbMunicipios.ValueMember = "Codigo"
                Me.cbMunicipios.DisplayMember = "Nombre"

                Me.cbMunicipios.SelectedValue = Detalles.Municipio

                Me.txtDireccion.Text = Detalles.Direccion
                Me.txtTelefono.Text = Detalles.Telefono
                Me.txtCelular.Text = Detalles.Celular
                Me.txtEmail.Text = Detalles.Email

                Me.dtpFechaNacimiento.Text = Detalles.Fecha_Nacimiento
                Me.cbNivelAcademico.EditValue = Detalles.Nivel_Academico
                Me.cbProfesion.SelectedValue = Detalles.Profesion

                Me.cbSexo.Text = IIf(Detalles.Sexo = "F", "FEMENINO", "MASCULINO")
                'Me.cbSexo.Text = Detalles.Sexo
                Me.txtInss.Text = Detalles.Inss
                Me.txtRuc.Text = Detalles.Ruc
                Me.txtCedula.Text = Detalles.Cedula
                Me.dtpFechaIngreso.Text = Detalles.Fecha_Ingreso

                If Detalles.FormaPago.ToUpper = "Q" Then
                    Me.CBFormaPago.Text = "QUINCENAL"
                ElseIf Detalles.FormaPago.ToUpper = "S" Then
                    Me.CBFormaPago.Text = "SEMANAL"
                ElseIf Detalles.FormaPago.ToUpper = "M" Then
                    Me.CBFormaPago.Text = "MENSUAL"
                ElseIf Detalles.FormaPago.ToUpper = "D" Then
                    Me.CBFormaPago.Text = "DESTAJO"
                ElseIf Detalles.FormaPago.ToUpper = "C" Then
                    Me.CBFormaPago.Text = "CATORCENAL"
                ElseIf Detalles.FormaPago.ToUpper = "U" Then
                    Me.CBFormaPago.Text = "UNIDAD DE TRABAJO(CORTE)"
                Else
                    Me.CBFormaPago.Text = ""
                End If


                Me.rbElectronico.Checked = IIf(Detalles.PagarCon = "E", True, False)
                Me.RbEfectivo.Checked = IIf(Detalles.PagarCon = "E", False, True)

                Me.txtNombreContacto.Text = Detalles.Contacto
                Me.txtTelefonoContacto.Text = Detalles.Tel_Contacto
                Me.txtUserName.Text = Detalles.UserName

                Me.txtAcumVac.Text = Detalles.AcumVac

                Me.cbDepartamento.EditValue = Detalles.Departamento

                cbArea.Properties.DataSource = VB.SysContab.AreaDB.GetListDepto(Me.cbDepartamento.EditValue).Tables("Areas")
                cbArea.Properties.ValueMember = "Area"
                cbArea.Properties.DisplayMember = "Descripcion"

                Me.cbArea.EditValue = Detalles.Departamento & "-" & Detalles.Area
                tArea = Me.cbArea.EditValue
                Me.cbCargo.EditValue = Detalles.Cargo
                Me.cbFuncion.EditValue = Detalles.Funcion

                detHorario = VB.SysContab.HorarioDB.GetDetails(CBHorario.SelectedValue)
                Me.dtpHoraEntrada.Value = detHorario.entrada
                Me.dtpHoraSalida.Value = detHorario.salida

                Me.txtSalario.Text = Detalles.Salario
                Me.cbTipoContrato.EditValue = Detalles.Estado
                If Detalles.Estado = "C" Then
                    Me.dtpHastaContrato.Visible = True
                    Me.dtpHastaContrato.Value = IIf(Detalles.HastaContrato = "", Now.Date, Detalles.HastaContrato)
                    Me.dtpHastaContrato.MinDate = IIf(Detalles.HastaContrato < Me.Emp_UltimaFechaPago, Detalles.HastaContrato, Me.Emp_UltimaFechaPago)
                ElseIf Detalles.Estado = "F" Then
                    Me.dtpHastaContrato.Visible = False
                ElseIf Detalles.Estado = "D" Then
                    Me.dtpHastaContrato.Visible = True
                    Me.dtpHastaContrato.Value = IIf(Detalles.HastaContrato = "", Now.Date, Detalles.HastaContrato)
                    Me.dtpHastaContrato.MinDate = IIf(Detalles.HastaContrato < Me.Emp_UltimaFechaPago, Detalles.HastaContrato, Me.Emp_UltimaFechaPago)
                Else
                    ''Registro
                End If


                'If Me.dgMovimientos.DataSource.table.rows.count = 0 Then
                '    Me.rbContrato.Enabled = True
                '    Me.rbFijo.Enabled = True
                '    Me.rbRegistro.Enabled = True
                'Else
                '    Me.rbContrato.Enabled = False
                '    Me.rbFijo.Enabled = False
                '    Me.rbRegistro.Enabled = False

                'End If

                Me.dtpFechaBaja.Value = IIf(Detalles.Fecha_FinContrato = "", Now.Date, Detalles.Fecha_FinContrato)
                Me.txtbaja.Visible = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.dtpFechaBaja.Visible = Not Me.txtbaja.Visible
                Duracion = Detalles.Duracion

                Me.txtSalarioDiario.Text = Detalles.Salario / 30
                Me.txtSalarioDiario.Text = Math.Round(Detalles.Salario / 30, 2)
                Me.txtDeduccionInss.Text = Math.Round(Detalles.Salario * 0.0625, 2)
                Me.txtInatec.Text = Math.Round(Detalles.Salario * 0.02, 2)
                Me.cbMonedaPago.EditValue = Detalles.Moneda
                Me.txtTransporte.Text = Detalles.VTransporte
                Me.rbAcumulaPrestaciones.Checked = Detalles.AcumulaPrestaciones

                Me.RbHExtra.Checked = Detalles.HExtra

                'Me.txtTotalHoras.Text = DateDiff(DateInterval.Minute, CDate(Detalles.Hora_Entrada), CDate(Detalles.Hora_Salida), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) / 60
                'Dim imagen As Image
                If File.Exists(Application.StartupPath & "\Fotos\" & Detalles.Codigo & ".jpg") Then
                    Fotografia.Image = Image.FromFile(Application.StartupPath & "\Fotos\" & Detalles.Codigo & ".jpg")
                End If

                'Deshabilitar si el empleado esta dado de baja
                Me.txtCodigo.Enabled = False
                'Me.txtSalario.Enabled = IIf(loginDet.Role = RolEdicionSalario, True, False)
                'Me.cbMonedaPago.Enabled = IIf(loginDet.Role = RolEdicionSalario, True, False)

                Me.dgMCSMaximos.DataSource = VB.SysContab.EmpleadosDB.GetMCSMaximos(Detalles.Codigo.Substring(4, 4), "%")
                Me.vMCSMaximos.BestFitColumns()

                'Deshabilitar los siguientes campos cuando tenga la autorizacion de Contabilidad
                'Me.CBFormaPago.Enabled = IIf(loginDet.Role = "2", True, False)
                'Me.cbMonedaPago.Enabled = IIf(loginDet.Role = "2", True, False)
                'Me.txtCedula.Enabled = IIf(loginDet.Role = "2", True, False)
                'Me.txtInss.Enabled = IIf(loginDet.Role = "2", True, False)
                'Me.txtRuc.Enabled = IIf(loginDet.Role = "2", True, False)
                'Me.cbRegimenINSS.Enabled = IIf(loginDet.Role = "2", True, False)

                'Me.gbAfiscal.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)

                Me.gbContacto.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                'Me.gbDatosGenerales.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.gbDatosLaborales.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.gbFirma.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.gbHorario.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.gbSalario.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.cmdAceptar.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
                Me.cmdActivos.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)
7:              Me.cmdBaja.Enabled = IIf(Detalles.Fecha_FinContrato = "", True, False)

            Else
                Me.Text = "Agregar Empleado"
                For i As Integer = 0 To Me.Controls.Count - 1
                    If Me.Controls(i).Name.Substring(0, 3) = "txt" Then
                        Me.Controls(i).Text = ""
                    End If
                Next
                Me.txtSalario.Text = "0"
                Me.txtAcumVac.Text = "0"
                Me.txtTransporte.Text = "0"
                Me.txtNombreContacto.Text = ""
                Me.txtTelefonoContacto.Text = ""
                Me.txtUserName.Text = ""
                Me.rbAcumulaPrestaciones.Checked = True
                Me.cbRegimenINSS.SelectedIndex = 0
                Me.txtCodigo.Text = VB.SysContab.EmpleadosDB.GetListNvo
                detHorario = VB.SysContab.HorarioDB.GetDetails(CBHorario.SelectedValue)
                Me.dtpHoraEntrada.Value = IIf(detHorario.entrada Is Nothing, Now, detHorario.entrada)
                Me.dtpHoraSalida.Value = IIf(detHorario.salida Is Nothing, Now, detHorario.salida)
                Me.BHorario.Enabled = False
                Me.txtCodigo.Enabled = True
                Me.cbDepartamento.EditValue = "%"
                Me.cbArea.EditValue = "%"
                Me.cbFuncion.EditValue = ""
                Me.cbCargo.EditValue = ""
                Me.dgMCSMaximos.DataSource = VB.SysContab.EmpleadosDB.GetMCSMaximos("%", "%")
                Me.vMCSMaximos.BestFitColumns()
                Me.cargarcamposdinamicos()
                Me.chkAntiguedad.Checked = False
                Me.chkBonificar.EditValue = False

                Me.dgOrganigramaD.DataSource = VB.SysContab.EmpleadosDB.Organigrama_Detalle("0", 0)
                If Not Me.dgOrganigramaD.DataSource Is Nothing Then
                    Me.vListaOrganigrama.Columns("id_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("org_codigo").Caption = "Centro de Costo"
                    Me.vListaOrganigrama.Columns("org_codigo").ColumnEdit = Me.cbOrganigramaD
                    Me.vListaOrganigrama.Columns("emp_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("empr_codigo").Visible = False
                    Me.vListaOrganigrama.Columns("porcentaje").Caption = "Porcentaje"
                    Me.vListaOrganigrama.Columns("porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Me.vListaOrganigrama.Columns("porcentaje").DisplayFormat.FormatString = "n2"
                    Me.vListaOrganigrama.Columns("porcentaje").ColumnEdit = spFactor
                    Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.DisplayFormat = "{0:n2}"
                    Me.vListaOrganigrama.BestFitColumns()
                End If

            End If
            cargado = True
            'VB.SysContab.Rutinas.UsuariosAcciones(Me, "frmEmpleados")
            Me.cmdAceptar.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.EditValueChanged
        If IsNumeric(Me.cbDepartamento.EditValue) Then
            Dim area As New VB.SysContab.AreaDB()
            cbArea.Properties.DataSource = VB.SysContab.AreaDB.GetListDepto(Me.cbDepartamento.EditValue).Tables("Areas")
            cbArea.Properties.ValueMember = "Area"
            cbArea.Properties.DisplayMember = "Descripcion"
            tArea = Me.cbArea.EditValue
        End If
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Estado As String, tSexo As String
        Dim tformapago As String, tHExtra As String
        Dim SalarioProyectado As Decimal, SalarioPorDia As Decimal

        tArea = Me.cbArea.EditValue

        If Not Me.Treelist1.DataSource Is Nothing Then
            Me.Organigrama = Me.Treelist1.FocusedNode.GetValue("org_codigo")
        End If

        If Me.Organigrama = 0 Then
            MsgBox("Por favor asignele un Centro de Costo al empleado", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Me.vListaOrganigrama.DataRowCount = 0 Then
            MsgBox("Por favor asignele un Centro de Costo al empleado, con su respectivo porcentaje", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Estado = Me.cbTipoContrato.EditValue

        Select Case Me.CBFormaPago.Text.ToUpper
            Case "QUINCENAL"
                tformapago = "Q"
                SalarioPorDia = Me.txtSalario.Text / 15
            Case "SEMANAL"
                tformapago = "S"
                SalarioPorDia = Me.txtSalario.Text / 7
            Case "MENSUAL"
                tformapago = "M"
                SalarioPorDia = Me.txtSalario.Text / 30
            Case "CATORCENAL"
                tformapago = "C"
                SalarioPorDia = Me.txtSalario.Text / 14 'Verificar el salario por dia en esta opcion
            Case "DESTAJO"
                tformapago = "D"
                SalarioPorDia = Me.txtSalario.Text 'Verificar el salario por dia en esta opcion
            Case "UNIDAD DE TRABAJO(CORTE)"
                tformapago = "U"
                SalarioPorDia = 0
            Case Else
                tformapago = ""
        End Select

        If Me.txtPNombre.Text = "" Or Me.txtPApellido.Text = "" Then
            MsgBox("Al menos debe digitarse el primer nombre y el primer apellido", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.txtDireccion.Text = "" Then
            MsgBox("La Direccion no se ha digitado, favor tomar nota", MsgBoxStyle.Information, "Sts.Nomina")
        End If
        If Me.cbTipoContrato.EditValue Is Nothing Then
            MsgBox("Seleccione el Tipo de Contrato", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.cbTipoContrato.EditValue Is DBNull.Value Then
            MsgBox("Seleccione el Tipo de Contrato", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.cbLocalidad.EditValue Is Nothing Or Me.cbLocalidad.EditValue = 0 Then
            MsgBox("Seleccione la Localidad por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbDepartamento.EditValue Is Nothing Then
            MsgBox("Seleccione el Departamento por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbArea.EditValue Is Nothing Then
            MsgBox("Seleccione el Area por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbCargo.EditValue Is Nothing Then
            MsgBox("Seleccione el Cargo por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbFuncion.EditValue Is Nothing Then
            MsgBox("Seleccione la Funci�n por favor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If tformapago = "" Then
            MsgBox("Seleccione una forma de pago por favor", MsgBoxStyle.Critical, "STS-Nomina")
            Exit Sub
        End If
        If CDbl(Me.txtSalario.Text) < 0 Then
            MsgBox("Salario Inv�lido", MsgBoxStyle.Critical, "STS-Nomina")
            Exit Sub
        End If
        If Me.cbLocalidad.EditValue Is Nothing Or Me.cbLocalidad.EditValue Is DBNull.Value Then
            MsgBox("Seleccione una Localidad", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.txtCedula.Text = "" Or Me.txtCedula.Text.Length <= 4 Then
            MsgBox("Digite el numero de Cedula", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.txtInss.Text = "" Then
            MsgBox("El n�mero de INSS no se ha digitado, por favor tomar nota, " & vbCrLf & _
                "porque debe actualizarlo antes de la proxima entrega de los datos al INSS.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sts.Nomina")
        End If
        If Me.txtRuc.Text = "" Then
            MsgBox("El n�mero de RUC no se ha digitado, por favor tomar nota, " & vbCrLf & _
                "para mantener los datos de los empleados actualizados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sts.Nomina")
        End If
        If Me.txtCedula.Text.Length = 14 Then 'Cedula Nica
            Try
                If IsDate(New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2))) Then

                    If Me.dtpFechaNacimiento.Value.Date <> New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2)) Then
                        MsgBox("La Fecha de Nacimiento no corresponde a lo descrito en la cedula: " & Me.txtCedula.Text, MsgBoxStyle.Exclamation, "Sts.Nomina")
                        Exit Sub
                    End If
                Else
                    MsgBox("El codigo de cedula no tiene un formato reconocido para la fecha", MsgBoxStyle.Critical, "Sts.Nomina")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("El formato de fecha en la cedula no es reconocido como dato valido")
                Exit Sub
            End Try
        End If
        If Me.txtCedula.Text.Length = 14 Then 'Cedula Nica
            Try
                If IsDate(New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2))) Then
                    If Year(Now.Date) - Year(New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2))) < 14 Then
                        MsgBox("El empleado no puede ser menor a 14 a�os", MsgBoxStyle.Exclamation, "Sts.Nomina")
                        Exit Sub
                    End If
                Else
                    MsgBox("El codigo de cedula no tiene un formato reconocido para la fecha", MsgBoxStyle.Critical, "Sts.Nomina")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("El formato de fecha en la cedula no es reconocido como dato valido")
                Exit Sub

            End Try
        End If
        Select Case Me.cbSexo.Text.ToUpper
            Case "FEMENINO"
                tSexo = "F"
            Case Else
                tSexo = "M"
        End Select

        If RbHExtra.Checked = True Then
            tHExtra = "1"
        Else
            tHExtra = "0"
        End If

        If Me.rbElectronico.Checked Then
            If Me.cbBancos.EditValue = 0 Then
                MsgBox("Debe seleccionar una cuenta de banco para hacer el pago efectivo al empleado", MsgBoxStyle.Critical, "Sts.Nomina")
                Exit Sub
                If Me.txtIdCuenta.Text = "" Then
                    MsgBox("Debe ingresar el identificador (Cedula o Cuenta Bancaria) para crear el archivo electronico del banco", MsgBoxStyle.Critical, "Sts.Nomina")
                    Exit Sub
                Else
                    If Me.txtIdCuenta.Text <> Me.txtCedula.Text Then
                        If MsgBox("Esta seguro de que el identificador para el archivo electronico corresponde a la cuenta bancaria del empleado?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "STs.Nomina") = MsgBoxResult.Yes Then
                            GoTo continuar
                        End If
                    End If
                End If
            End If
        End If

        If Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.SummaryValue <> 100 And Me.vListaOrganigrama.DataRowCount <> 0 Then
            MsgBox("La distribucion de los rubros de empleado debe sumar el 100% en todos los centros de costo")
            Exit Sub
        End If


        DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
        DBConnexion.Open()
        transaccion = DBConnexion.BeginTransaction

continuar: Try


            If Nuevo = "SI" Then
                If VB.SysContab.EmpleadosDB.Additem(txtCodigo.Text, _
                        txtPNombre.Text, _
                        txtSNombre.Text, _
                        txtPApellido.Text, _
                        txtSApellido.Text, _
                        cbDepartamentos.SelectedValue, _
                        cbMunicipios.SelectedValue, _
                        txtDireccion.Text, _
                        txtTelefono.Text, _
                        txtCelular.Text, _
                        txtEmail.Text, _
                        dtpFechaNacimiento.Value.Date, _
                        cbNivelAcademico.EditValue, _
                        cbProfesion.SelectedValue, _
                        tSexo, _
                        txtInss.Text, _
                        txtRuc.Text, _
                        txtCedula.Text, _
                        dtpFechaIngreso.Value.Date, _
                        "Vacio", _
                        "01", _
                        cbDepartamento.EditValue, _
                        cbCargo.EditValue, _
                        cbFuncion.EditValue, _
                        CBHorario.SelectedValue, _
                        txtSalario.Text, _
                        Estado, _
                        IIf(Estado = "C", DateDiff(DateInterval.Month, Me.dtpHastaContrato.Value.Date, Me.dtpFechaIngreso.Value.Date), 0), _
                        Me.cbMonedaPago.EditValue, _
                        tformapago, _
                        tHExtra, _
                        txtTransporte.Text, _
                        tArea, _
                        Me.archivoFoto, _
                        Me.archivoFirma, _
                        IIf(Me.rbElectronico.Checked, "E", "C"), _
                        Me.txtNombreContacto.Text, _
                        Me.txtTelefonoContacto.Text, _
                        Me.txtUserName.Text, _
                        0, _
                        Me.rbAcumulaPrestaciones.Checked, _
                        Me.cbRegimenINSS.SelectedValue, _
                        Me.cbPais.SelectedValue, _
                        Me.dtpHastaContrato.Value.Date, _
                        Me.cbLocalidad.EditValue, _
                        Me.cbDepartamentoMurohs.SelectedValue, _
                        Me.cbBancos.EditValue, _
                        Me.txtIdCuenta.Text, _
                        Me.chkSalarioFijo.Checked, Me.Organigrama, True, _
                        Me.chkAntiguedad.Checked, Me.cbArea.GetSelectedDataRow("are_codigo")) = False Then
                    MsgBox("Complete la informacion", MsgBoxStyle.Critical)
                    transaccion.Rollback()
                    Exit Sub
                End If

                'Agregar los subsidios de comida
                If Me.chkComida.Checked Then
                    VB.SysContab.EmpleadosDB.AddSubsidio(txtCodigo.Text, 1)
                End If

                'Agregar los subsidios de gaseosa
                If Me.chkGaseosa.Checked Then
                    VB.SysContab.EmpleadosDB.AddSubsidio(txtCodigo.Text, 2)
                End If
                'Ya lo inclui en el procedure de EmpleadoADD y UPDATE
                'If Me.rbElectronico.Checked Then
                '    Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
                '    v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                '    v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.txtCodigo.Text)
                '    v.AddParameter("Cuenta", SqlDbType.Int, 5, ParameterDirection.Input, Me.cbBancos.EditValue)
                '    v.AddParameter("Identificador", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.txtIdCuenta.Text)
                '    v.EjecutarComando("_Empleados_Cuentas_Add")
                '    v = Nothing
                'End If

                'Dim Sabados As Integer, cSabados As String
                'Sabados = VB.SysContab.RutinasNomina.BuscarSabados(Me.dtpFechaIngreso.Value, _
                '    New Date(Now.Year, Now.Month, Meses(Now.Month - 1)))
                'Select Case Sabados
                '    Case 1
                '        cSabados = "10000"
                '    Case 2
                '        cSabados = "11000"
                '    Case 3
                '        cSabados = "11100"
                '    Case 4
                '        cSabados = "11110"
                '    Case Else
                '        cSabados = "11111"

                'End Select
                If DateDiff(DateInterval.Day, Me.dtpFechaIngreso.Value, _
                    New Date(Now.Year, Now.Month, Meses(Now.Month - 1))) > Meses(Now.Month - 1) Then
                    SalarioProyectado = DateDiff(DateInterval.Day, Me.dtpFechaIngreso.Value, _
                    New Date(Now.Year, Now.Month, Meses(Now.Month - 1))) * (SalarioPorDia * 30)
                Else
                    SalarioProyectado = DateDiff(DateInterval.Day, Me.dtpFechaIngreso.Value, _
                   New Date(Now.Year, Now.Month, Meses(Now.Month - 1))) * SalarioPorDia
                End If

                'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbAhorro1)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbAhorro2)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbAhorro3)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbContacto)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbDatosLaborales)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbFirma)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbHorario)
                'VB.SysContab.RutinasNomina.LimpiarControles(gbSalario)

                'Me.cmdAceptar.Enabled = True
                'Me.cmdActivos.Enabled = True
                'Me.cmdBaja.Enabled = True

            Else
                If Me.chkBonificar.Checked Then
                    'Bonificar al empleado
                    RH_Empleados_Light.Bonificar_Empleado( _
                        Me.txtCodigo.Text, DateAdd(DateInterval.Day, -1, Me.dtpFechaIngreso.Value), _
                       Detalles.Fecha_Ingreso, Me.txtSalario.Text, Me.Organigrama, Me.cbCargo.EditValue)
                End If

                VB.SysContab.EmpleadosDB.Update(txtCodigo.Text, _
                    txtPNombre.Text, _
                    txtSNombre.Text, _
                    txtPApellido.Text, _
                    txtSApellido.Text, _
                    cbDepartamentos.SelectedValue, _
                    cbMunicipios.SelectedValue, _
                    txtDireccion.Text, _
                    txtTelefono.Text, _
                    txtCelular.Text, _
                    txtEmail.Text, _
                    dtpFechaNacimiento.Value.Date, _
                    cbNivelAcademico.EditValue, _
                    cbProfesion.SelectedValue, _
                    tSexo, _
                    txtInss.Text, _
                    txtRuc.Text, _
                    txtCedula.Text, _
                    dtpFechaIngreso.Value.Date, _
                    "Vacio", _
                    "01", _
                    cbDepartamento.EditValue, _
                    cbCargo.EditValue, _
                    cbFuncion.EditValue, _
                    CBHorario.SelectedValue, _
                    txtSalario.Text, _
                    Estado, _
                    IIf(Estado = "C", DateDiff(DateInterval.Month, Me.dtpHastaContrato.Value.Date, Me.dtpFechaIngreso.Value.Date), 0), _
                    Me.cbMonedaPago.EditValue, _
                    tformapago, _
                    tHExtra, _
                    txtTransporte.Text, _
                    tArea, _
                    Me.archivoFoto, _
                    Me.archivoFirma, _
                    IIf(Me.rbElectronico.Checked, "E", "C"), _
                    Me.txtNombreContacto.Text, _
                    Me.txtTelefonoContacto.Text, _
                    Me.txtUserName.Text, _
                    0, _
                    Me.rbAcumulaPrestaciones.Checked, _
                    Me.cbRegimenINSS.SelectedValue, _
                    Me.cbPais.SelectedValue, _
                    Me.dtpHastaContrato.Value.Date, _
                    Me.cbLocalidad.EditValue, _
                    Me.cbDepartamentoMurohs.SelectedValue, _
                    Me.cbBancos.EditValue, _
                    Me.txtIdCuenta.Text, _
                    Me.chkSalarioFijo.Checked, Me.Organigrama, Detalles.Activo, _
                    Me.chkAntiguedad.Checked, Me.cbArea.GetSelectedDataRow("are_codigo"))

                'Comida
                If DetalleSubsidios.Comida = False Then
                    If Me.chkComida.Checked Then
                        VB.SysContab.EmpleadosDB.AddSubsidio(txtCodigo.Text, 1)
                    End If
                Else
                    If Not Me.chkComida.Checked Then
                        VB.SysContab.EmpleadosDB.DeleteSubsidio(txtCodigo.Text, 1)
                    End If
                End If

                'Gaseosa
                If DetalleSubsidios.Gaseosa = False Then
                    If Me.chkGaseosa.Checked Then
                        VB.SysContab.EmpleadosDB.AddSubsidio(txtCodigo.Text, 2)
                    End If
                Else
                    If Not Me.chkGaseosa.Checked Then
                        VB.SysContab.EmpleadosDB.DeleteSubsidio(txtCodigo.Text, 2)
                    End If
                End If
                'Ya lo inclui en el procedure de EmpleadoADD y UPDATE
                'If Me.rbElectronico.Checked Then
                '    VB.SysContab.EmpleadosDB.Cuentas_Update(txtCodigo.Text, Me.cbBancos.EditValue, Me.txtIdCuenta.Text)
                'Else
                '    VB.SysContab.EmpleadosDB.Cuentas_Delete(txtCodigo.Text)
                'End If
            End If

            ''CAMPOS DINAMICOS
            Dim tempDt As New DataTable
            'Los Deleted
            tempDt = Me.dgCamposDinamicos.DataSource.getchanges(DataRowState.Deleted)
            If Not tempDt Is Nothing Then
                tempDt.RejectChanges()
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    If Not tempDt.Rows(i)("id_valor") Is DBNull.Value Then
                        VB.SysContab.CamposDB.DatosEmpleados_ADDDEL(Me.txtCodigo.Text, _
                            tempDt.Rows(i)("id_valor"), 1)
                    End If
                Next

            End If

            'Los Modificados
            tempDt = Me.dgCamposDinamicos.DataSource.getchanges(DataRowState.Modified)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    If Not tempDt.Rows(i)("id_valor") Is DBNull.Value Then
                        VB.SysContab.CamposDB.DatosEmpleados_ADDDEL(Me.txtCodigo.Text, _
                            tempDt.Rows(i)("id_valor"), 2)
                    End If
                Next

            End If

            'Los agregados
            tempDt = Me.dgCamposDinamicos.DataSource.getchanges(DataRowState.Added)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    If Not tempDt.Rows(i)("id_valor") Is DBNull.Value Then
                        VB.SysContab.CamposDB.DatosEmpleados_ADDDEL(Me.txtCodigo.Text, _
                            tempDt.Rows(i)("id_valor"), 0)
                    End If
                Next

            End If
            ''MCS
            tempDt = Nothing
            'Los MCSMaximos Deleted
            tempDt = Me.dgMCSMaximos.DataSource.getchanges(DataRowState.Deleted)
            If Not tempDt Is Nothing Then
                tempDt.RejectChanges()
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.EmpleadosDB.MCS_Maximos_AddUpdate( _
                    txtCodigo.Text, _
                    tempDt.Rows(i)("trn_tipo"), _
                    0, _
                    0)
                Next

            End If

            'Los MCSMaximos Modificados
            tempDt = Me.dgMCSMaximos.DataSource.getchanges(DataRowState.Modified)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.EmpleadosDB.MCS_Maximos_AddUpdate( _
                    txtCodigo.Text, _
                    tempDt.Rows(i)("trn_tipo"), _
                    tempDt.Rows(i)("Empleado"), _
                    tempDt.Rows(i)("Invitados"))
                Next

            End If
            'Los MCSMaximos agregados
            tempDt = Me.dgMCSMaximos.DataSource.getchanges(DataRowState.Added)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.EmpleadosDB.MCS_Maximos_AddUpdate( _
                    txtCodigo.Text, _
                    tempDt.Rows(i)("Tipo").ToString.Substring(0, 1), _
                    tempDt.Rows(i)("Empleado"), _
                    tempDt.Rows(i)("Invitados"))
                Next

            End If

            ''RH_Organigrama Detalle
            tempDt = Nothing
            'Los Deleted
            tempDt = Me.dgOrganigramaD.DataSource.getchanges(DataRowState.Deleted)
            If Not tempDt Is Nothing Then
                tempDt.RejectChanges()
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.RH_OrganigramaDB.Organigrama_Detalle_Borrar(tempDt.Rows(i)("org_codigo"), Me.txtCodigo.Text)
                Next

            End If

            'Los Modificiados Modificados
            tempDt = Me.dgOrganigramaD.DataSource.getchanges(DataRowState.Modified)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.RH_OrganigramaDB.Organigrama_Detalle(tempDt.Rows(i)("org_codigo"), Me.txtCodigo.Text, tempDt.Rows(i)("porcentaje"))
                Next

            End If
            'Los  agregados
            tempDt = Me.dgOrganigramaD.DataSource.getchanges(DataRowState.Added)
            If Not tempDt Is Nothing Then
                For i As Integer = 0 To tempDt.Rows.Count - 1
                    VB.SysContab.RH_OrganigramaDB.Organigrama_Detalle(tempDt.Rows(i)("org_codigo"), Me.txtCodigo.Text, tempDt.Rows(i)("porcentaje"))
                Next

            End If

            transaccion.Commit()
            DBConnexion.Close()

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox(ex.Message)

            Exit Sub
        End Try

        Me.Close()
    End Sub

    Private Sub dtpHoraSalida_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraSalida.Leave
        'txtTotalHoras.Text = DateDiff(DateInterval.Hour, CDate(dtpHoraEntrada.Text), CDate(dtpHoraSalida.Text), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
        txtTotalHoras.Text = DateDiff(DateInterval.Minute, CDate(dtpHoraEntrada.Text), CDate(dtpHoraSalida.Text), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) / 60

    End Sub

    Private Sub txtSalario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalario.Leave
        If txtSalario.Text = "" Then
            txtSalarioDiario.Text = 0
            txtDeduccionInss.Text = 0
        Else

            txtSalarioDiario.Text = Math.Round(txtSalario.Text / 30, 2)
            txtDeduccionInss.Text = Math.Round(txtSalario.Text * 0.0625, 2)
        End If
    End Sub

    Private Sub dtpHoraEntrada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraEntrada.Leave
        txtTotalHoras.Text = DateDiff(DateInterval.Minute, CDate(dtpHoraEntrada.Text), CDate(dtpHoraSalida.Text), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) / 60

    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        If Trim(txtCodigo.Text) <> "" And Nuevo = "SI" Then
            If VB.SysContab.EmpleadosDB.GetListCodigo(txtCodigo.Text).Tables("EMPLEADOS").Rows.Count <> 0 Then
                MsgBox("C�digo de Empleado ya existe", MsgBoxStyle.Information)
                txtCodigo.Focus()
                txtCodigo.SelectAll()
            End If
            txtCodigo.Text = txtCodigo.Text.PadLeft(8, "0")
        End If
    End Sub


    Private Sub cmdActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActivos.Click
        Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
        Dim ds As DataSet

        Dim f As frmActivoEmpleado = frmActivoEmpleado.Instance

        ds = Activos_Fijos.GetListActivoEmpleado(Registro)

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cbDepartamentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamentos.SelectedIndexChanged

        If IsNumeric(cbDepartamentos.SelectedValue) Then
            cbMunicipios.DataSource = VB.SysContab.MunicipiosDB.GetList(cbDepartamentos.SelectedValue.ToString)
            cbMunicipios.ValueMember = "Codigo"
            cbMunicipios.DisplayMember = "Nombre"
            If IsNumeric(Me.cbMunicipios.SelectedValue) And Not (Detalles Is Nothing) Then
                cbMunicipios.SelectedValue = Detalles.Municipio
            End If
        End If
    End Sub

    Private Sub BHorario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BHorario.Click
        ' Abrir el formulario de asignacion de Horarios, por default tomar el horario seleccionado en esta 
        ' pantalla y pegarlo a todos los dias de la semana, de Lunes a Viernes

        Dim f As frmAgregarEmpHorario = frmAgregarEmpHorario.Instance

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cbAfiscal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAfiscal.SelectedIndexChanged
        If cargado Then
            Me.dgAFiscal.DataSource = VB.SysContab.EmpleadosDB.GetListAfiscal(Me.txtCodigo.Text, IIf(Me.cbAfiscal.Text Is DBNull.Value Or Me.cbAfiscal.Text = "", sAFiscal, Me.cbAfiscal.SelectedValue)).Tables("AFiscal")
        End If
    End Sub

    'Private Sub cbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If IsNumeric(Me.cbDepartamento.SelectedValue) Then
    '        Dim area As New VB.SysContab.AreaDB()
    '        cbArea.DataSource = VB.SysContab.AreaDB.GetListDepto(Me.cbDepartamento.SelectedValue).Tables("Areas")
    '        cbArea.ValueMember = "Area"
    '        cbArea.DisplayMember = "Descripcion"
    '        tArea = Me.cbArea.SelectedValue
    '    End If
    'End Sub

    Private Sub Fotografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fotografia.DoubleClick

        Dim forma As New frmExplorador()
        Me.QImagen = "Foto"
        forma.ShowDialog()

    End Sub

    Private Sub Firma_DblClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Firma.DoubleClick

        Dim forma As New frmExplorador()
        Me.QImagen = "Firma"
        forma.ShowDialog()

    End Sub

    Private Sub btnECAhorro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fReportes As New frmReportes()
        'Dim rColilla As New rptECAhorro()
        Dim rColilla As New Object
        rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECAhorro.rpt")
            Exit Sub
        End If

        rColilla.load(Application.StartupPath & "\reportes\rptECAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet

        lds = VB.SysContab.Empleado_AhorroDB.GetListReporteEcAhorro(Me.txtCodigo.Text)
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECAhorro.xml", XmlWriteMode.WriteSchema)
        rColilla.Database.Tables("vAhorro").Location = Application.StartupPath & "\exportfiles\ECAhorro.xml"
        rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        fReportes.crvReportes.ReportSource = rColilla

        fReportes.ShowDialog()
    End Sub

    Private Sub cmdBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaja.Click

        frmEmpleado_FechaBaja.Dispose()
        frmEmpleado_FechaBaja.Codigo = Me.txtCodigo.Text
        frmEmpleado_FechaBaja.ShowDialog()

        'Dim f As frmAgregarEmpleado_Baja = frmAgregarEmpleado_Baja.Instance
        'f.cEmpleado = Me.txtCodigo.Text & "-" & Me.txtPNombre.Text.ToString.Trim & " " & _
        '    Me.txtSNombre.Text.ToString.Trim & " " & _
        '    Me.txtPApellido.Text.ToString.Trim & " " & _
        '    Me.txtSApellido.Text.ToString.Trim
        'f.codEmpleado = Me.txtCodigo.Text
        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub dtpFechaNacimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaNacimiento.Validating
        If Now.Date.Month > DatePart(DateInterval.Month, dtpFechaNacimiento.Value) Then
            txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date)
        ElseIf Now.Date.Month = DatePart(DateInterval.Month, dtpFechaNacimiento.Value) Then
            If Now.Date.Day < DatePart(DateInterval.Day, dtpFechaNacimiento.Value) Then
                txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date) - 1
            Else
                txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date)
            End If
        Else
            txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date) - 1
        End If

        If Me.txtCedula.Text.Length = 14 Then 'Cedula Nica
            If Me.dtpFechaNacimiento.Value.Date <> New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2)) Then
                MsgBox("La Fecha de Nacimiento no corresponde a lo descrito en la cedula: " & Me.txtCedula.Text, MsgBoxStyle.Exclamation, "Sts.Nomina")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dtpFechaNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaNacimiento.ValueChanged
        'If Now.Date.Month > DatePart(DateInterval.Month, dtpFechaNacimiento.Value) Then
        '    txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date)
        'ElseIf Now.Date.Month = DatePart(DateInterval.Month, dtpFechaNacimiento.Value) Then
        '    If Now.Date.Day < DatePart(DateInterval.Day, dtpFechaNacimiento.Value) Then
        '        txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date) - 1
        '    Else
        '        txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date)
        '    End If
        'Else
        '    txtEdad.Text = DateDiff(DateInterval.Year, dtpFechaNacimiento.Value, Now.Date) - 1
        'End If

        'If Me.txtCedula.Text.Length = 14 Then 'Cedula Nica
        '    If Me.dtpFechaNacimiento.Value <> New Date(1900 + Me.txtCedula.Text.Substring(7, 2), Me.txtCedula.Text.Substring(5, 2), Me.txtCedula.Text.Substring(3, 2)) Then
        '        MsgBox("La Fecha de Nacimiento no corresponde a lo descrito en la cedula: " & Me.txtCedula.Text, MsgBoxStyle.Exclamation, "Sts.Nomina")
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub cmdEmailAhorro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim rColilla As New rptECAhorro()
        Dim rColilla As New Object
        rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECAhorro.rpt")
            Exit Sub
        End If

        rColilla.load(Application.StartupPath & "\reportes\rptECAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet

        lds = VB.SysContab.Empleado_AhorroDB.GetListReporteEcAhorro(Me.txtCodigo.Text)
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECAhorro.xml", XmlWriteMode.WriteSchema)
        rColilla.Database.Tables("vAhorro").Location = Application.StartupPath & "\exportfiles\ECAhorro.xml"
        rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"


        Dim crExportOptions As CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim fname As String

        If Me.txtEmail.Text.Trim <> "" And Not (Me.txtEmail.Text Is DBNull.Value) Then

            fname = Application.StartupPath() & "\exportfiles\Ahorro_" & Me.txtCodigo.Text & ".pdf"
            crDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions()
            crDiskFileDestinationOptions.DiskFileName = fname
            crExportOptions = rColilla.ExportOptions
            With crExportOptions
                .DestinationOptions = crDiskFileDestinationOptions
                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            End With
            rColilla.Export()
            VB.SysContab.Email.Enviar_Mail_Outlook(Me.txtEmail.Text, "Estado de Cuenta de Ahorro", _
                "S�rvase revisar el estado de Cuenta de Ahorro en archivo Adjunto", fname)

        End If
    End Sub

    Private Sub VAfiscal_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles VAfiscal.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer

        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat

    End Sub

    'Private Function Enviar_Mail(ByVal Direccion As String, ByVal Path_Archivo As String) As Boolean
    '    Dim correo As New System.Net.Mail.MailMessage("alberto.nunez@almori.com", Direccion)

    '    correo.Attachments.Clear()
    '    correo.Attachments.Add(New System.Net.Mail.Attachment(Path_Archivo))
    '    ' El asunto
    '    correo.Subject = "Estado de Cuenta de Ahorro "
    '    ' El cuerpo o texto del mensaje
    '    correo.Body = "S�rvase revisar el estado de Cuenta de Ahorro en archivo adjunto "
    '    ' El formato del mensaje (texto o html)
    '    correo.IsBodyHtml = True
    '    ' La prioridad (baja, normal o alta)
    '    correo.Priority = System.Net.Mail.MailPriority.Normal
    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient
    '    ClienteCorreo.Host = IP_SMTP
    '    Try
    '        ClienteCorreo.Send(correo)
    '        Return True
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message)
    '        Return False
    '    End Try



    'End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.dgAFiscal)
    End Sub

    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then Me.VAfiscal.ColumnsCustomization() Else Me.VAfiscal.DestroyCustomization()
    End Sub

    Private Sub cmdDisponibilidadLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisponibilidadLogin.Click
        If VB.SysContab.EmpleadosDB.DisponibilidadLogin(Me.txtCodigo.Text, Me.txtUserName.Text) <> 0 Then
            MsgBox("Este login ya le pertenece a otro empleado", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Me.txtUserName.Text = LoginAnterior
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ds As New DataTable
        ds = VB.SysContab.EmpleadosDB.GetListAfiscal_Reporte(Me.txtCodigo.Text, _
            IIf(Me.cbAfiscal.Text Is DBNull.Value Or Me.cbAfiscal.Text = "", sAFiscal, Me.cbAfiscal.SelectedValue), _
            "%", True, "%")
        ds.WriteXml(Application.StartupPath & "\exportfiles\Empleados_Afiscal.xml", XmlWriteMode.WriteSchema)

        'Dim documento As New rptECIR
        'documento.DataSource = ds
        'documento.ShowPreview()
        Dim visor As New frmReportes
        'Dim Reporte As New rptEstadoCuenta_IR
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Reporte.Database.Tables("Afiscal").Location = Application.StartupPath & "\exportfiles\empleados_afiscal.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()
    End Sub

    Private Sub rbElectronico_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbElectronico.CheckedChanged
        Me.cbBancos.Visible = Me.rbElectronico.Checked
        Me.txtIdCuenta.Visible = Me.rbElectronico.Checked
    End Sub

    Private Sub RbEfectivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbEfectivo.CheckedChanged
        Me.cbBancos.Visible = Me.rbElectronico.Checked
        Me.txtIdCuenta.Visible = Me.rbElectronico.Checked
    End Sub

    Sub cargarcamposdinamicos()
        ''Campos Dinamicos
        Me.dgCamposDinamicos.DataSource = VB.SysContab.CamposDB.GetDatos_Empleados(txtCodigo.Text)
        Me.vCampos.Columns("id").ColumnEdit = Me.cbCampo
        Me.vCampos.Columns("id_valor").ColumnEdit = Me.cbValores
        Me.vCampos.Columns("id").Caption = "Campo"
        Me.vCampos.Columns("id_valor").Caption = "Campo"
        Me.vCampos.Columns("valor").Visible = False
        Me.vCampos.BestFitColumns()

    End Sub
    Private Sub cmdcBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcBorrar.Click
        If Me.vCampos.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        VB.SysContab.CamposDB.DatosEmpleados_ADDDEL(Me.txtCodigo.Text, Me.vCampos.GetFocusedRowCellValue("id_valor"), 1)
        Me.cargarcamposdinamicos()
    End Sub

    Private Sub cmdCAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCAgregar.Click
        Dim f As New frmCamposEmpleados_EmpleadosAgregar
        f.Empleado = Me.txtCodigo.Text
        f.ShowDialog()
        'Me.cargarcamposdinamicos()
    End Sub


    Private Sub vMCSMaximos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vMCSMaximos.FocusedRowChanged
        If Not Me.dgMCSMaximos.DataSource Is Nothing Then
            If e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
                Me.vMCSMaximos.Columns("Tipo").OptionsColumn.ReadOnly = False
            Else
                Me.vMCSMaximos.Columns("Tipo").OptionsColumn.ReadOnly = True
            End If

        End If
    End Sub

    Private Sub vMCSMaximos_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vMCSMaximos.InitNewRow
        Me.vMCSMaximos.Columns("Tipo").OptionsColumn.ReadOnly = False
    End Sub


    Private Sub dgMCSMaximos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgMCSMaximos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vMCSMaximos.DeleteRow(Me.vMCSMaximos.FocusedRowHandle)
        End If

    End Sub

    Private Sub vMCSMaximos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vMCSMaximos.ValidatingEditor
        If sender.focusedcolumn.fieldname = "Tipo" Then
            Dim c As Integer
            c = Me.dgMCSMaximos.DataSource.Compute("Count(Tipo)", "Tipo = '" & e.Value & "'")
            If c >= 1 Then
                MsgBox("Ya existe ese Tipo de Sesion en la tabla", MsgBoxStyle.Exclamation, "Sts.Nomina")
                e.Valid = False
            Else
                e.Valid = True
                If e.Value Is Nothing Then Exit Sub
                Me.vMCSMaximos.SetFocusedRowCellValue(Me.vMCSMaximos.Columns("trn_tipo"), e.Value.ToString.Substring(0, 1))
            End If

        End If
    End Sub


    Private Sub dgCamposDinamicos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCamposDinamicos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vCampos.DeleteRow(Me.vCampos.FocusedRowHandle)
        End If
    End Sub

    Private Sub vCampos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vCampos.CellValueChanged
        If e.Column.FieldName = "id" Then
            Me.vCampos.Columns("id_valor").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vCampos_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vCampos.InitNewRow
        Me.vCampos.Columns("id_valor").OptionsColumn.ReadOnly = True
    End Sub

    'Private Sub vCampos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vCampos.KeyDown
    '    If e.KeyCode = Keys.Delete Then
    '        Me.vCampos.DeleteRow(Me.vCampos.FocusedRowHandle)
    '    End If
    'End Sub
    Dim clone As DataView
    Private Sub vCampos_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vCampos.ShownEditor
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Vista = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If Vista.FocusedColumn.FieldName = "id_valor" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("id") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone.RowFilter = "[id]= " & row("id").ToString
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub vCampos_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vCampos.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    'Private Sub vCampos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vCampos.ValidateRow
    '    If e.Valid = True Then
    '        dtValores.DefaultView.RowFilter = ""
    '    End If
    'End Sub


    Private Sub vCampos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vCampos.ValidatingEditor
        If sender.focusedcolumn.fieldname = "id" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.dgCamposDinamicos.DataSource.Compute("Count(Id)", "Id = '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                    If e.Value Is Nothing Then Exit Sub
                    'dtValores.DefaultView.RowFilter = "id = " & "'" & e.Value & "'"
                End If
            End If
        End If
        If sender.focusedcolumn.fieldname = "id_valor" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            End If
        End If
    End Sub

    Dim clone2 As DataView
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.dgMovimientos)
    End Sub

    Private Sub tbOrganigrama_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOrganigrama.Enter
        If Me.TPOrgCargado = False Then
            'Cargar el Organigrama
            Me.cargar_Organigrama()
            If Me.Organigrama <> 0 Then
                Me.TreeList1.FocusedNode = Me.TreeList1.FindNodeByFieldValue("org_codigo", Me.Organigrama)
            End If
            Me.TPOrgCargado = True
        End If
    End Sub


    Private Sub tbOrganigrama_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOrganigrama.GotFocus
        If Me.TPOrgCargado = False Then
            'Cargar el Organigrama
            Me.cargar_Organigrama()
            If Me.Organigrama <> 0 Then
                Me.TreeList1.FocusedNode = Me.TreeList1.FindNodeByFieldValue("org_codigo", Me.Organigrama)
            End If
            Me.TPOrgCargado = True
        End If
    End Sub

    Private Sub cargar_Organigrama()

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.Lista_Combo("0")
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.TreeList1.DataSource = VB.SysContab.RH_OrganigramaDB.Listar()
        Me.TreeList1.KeyFieldName = "org_codigo"
        Me.TreeList1.ParentFieldName = "org_padre"
        Me.TreeList1.BestFitColumns()
        Me.TreeList1.Columns("org_sufijo").Visible = False
        Me.TreeList1.Columns("empr_codigo").Visible = False
        Me.TreeList1.Columns("emp_codigo").ColumnEdit = Me.cbEmpleados
        Me.TreeList1.Columns("org_nivel").Visible = False
        Me.TreeList1.Columns("org_activo").Visible = False
        Me.TreeList1.Columns("org_path").Visible = False
        Me.TreeList1.Columns("org_descripcion").Caption = "Centro de Costo"
        Me.TreeList1.Columns("emp_codigo").Caption = "Encargado"
        Me.TreeList1.Columns("org_email").Caption = "Email"

        Me.TreeList1.ExpandAll()
        Me.TreeList1.FocusedNode = Me.TreeList1.FindNodeByFieldValue("org_codigo", Me.Organigrama)


    End Sub

    Private Sub TreeList1_AfterFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles Treelist1.AfterFocusNode
        Me.Organigrama = Me.TreeList1.FocusedNode.GetValue("org_codigo")
    End Sub

    Private Sub vListaOrganigrama_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vListaOrganigrama.HiddenEditor
        If Not clone2 Is Nothing Then
            clone2.Dispose()
            clone2 = Nothing
        End If
    End Sub

    Private Sub vListaOrganigrama_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vListaOrganigrama.ShownEditor
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Vista = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If Vista.FocusedColumn.FieldName = "org_codigo" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("id_codigo") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone2 = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone2.RowFilter = "[org_codigo]= " & row("org_codigo").ToString
            edit.Properties.DataSource = clone2
        End If
    End Sub

    Private Sub vListaOrganigrama_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vListaOrganigrama.ValidatingEditor
        If sender.focusedcolumn.fieldname = "org_codigo" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.dgOrganigramaD.DataSource.Compute("Count(org_codigo)", "org_codigo = '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                    If e.Value Is Nothing Then Exit Sub
                End If
            End If
        End If
        If sender.focusedcolumn.fieldname = "porcentaje" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            Else
                If Not Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.SummaryValue Is Nothing Then
                    If Me.vListaOrganigrama.Columns("porcentaje").SummaryItem.SummaryValue + IIf(Me.Grabando = True, e.Value, 0) > 100 Then
                        MsgBox("No puede asignar distribuci�n por centro de costo mayor al 100%")
                        e.Valid = False
                    End If
                End If
            End If
            Me.Grabando = False
        End If

    End Sub

    Private Sub dgOrganigramaD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgOrganigramaD.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vListaOrganigrama.DeleteRow(Me.vListaOrganigrama.FocusedRowHandle)
        End If
    End Sub

    Private Sub vListaOrganigrama_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vListaOrganigrama.CellValueChanged
        If e.Column.FieldName = "org_codigo" Then
            Me.vListaOrganigrama.Columns("porcentaje").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vListaOrganigrama_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vListaOrganigrama.InitNewRow
        Me.vListaOrganigrama.Columns("porcentaje").OptionsColumn.ReadOnly = True
        Me.Grabando = True
    End Sub
    
    Private Sub cbTipoContrato_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoContrato.EditValueChanged
        If Me.cbTipoContrato.EditValue = "C" Then
            Me.Label51.Visible = True
            Me.dtpHastaContrato.Visible = True
        ElseIf Me.cbTipoContrato.EditValue = "F" Then
            Me.Label51.Visible = False
            Me.dtpHastaContrato.Visible = False
        ElseIf Me.cbTipoContrato.EditValue = "D" Then
            Me.Label51.Visible = True
            Me.dtpHastaContrato.Visible = True
        Else
            Me.Label51.Visible = False
            Me.dtpHastaContrato.Visible = False
        End If
    End Sub
    Private Sub rbContrato_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpHastaContrato.Visible = True
    End Sub

    Private Sub rbFijo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpHastaContrato.Visible = False
    End Sub

    Private Sub rbRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpHastaContrato.Visible = False
    End Sub

    
End Class
