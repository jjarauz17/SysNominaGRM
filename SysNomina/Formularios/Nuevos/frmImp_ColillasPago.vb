Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.Collections

Public Class frmImp_ColillasPago

#Region "Variables"
    Public Planilla As String = "%"
#End Region
    Private Sub frmImp_ColillasPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

        Me.cbPlanillas.EditValue = Me.Planilla

        Me.cbLocalidad.Properties.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
        Me.cbLocalidad.Properties.ValueMember = "Area"
        Me.cbLocalidad.Properties.DisplayMember = "Descripcion"

        'Antes era x Sucursal
        'Me.cbLocalidad.Properties.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        'Me.cbLocalidad.Properties.DisplayMember = "Descripcion"
        'Me.cbLocalidad.Properties.ValueMember = "Codigo"
        Me.cbLocalidad.EditValue = 0

        Me.txtCodigo.EditValue = "%"

        If Planilla <> "%" Then
            Me.LCIPlanilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            Me.LCIPlanilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.cbPlanillas.EditValue = VB.SysContab.PeriodoNominaDB.PeriodoNomina_UltimaProcesada()
        End If
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim Variables As New ArrayList
        Dim Datos As New ArrayList

        Dim Departamento As String, Area As String
        If Me.cbLocalidad.EditValue Is Nothing Then
            Departamento = "%"
            Area = "%"
        ElseIf Me.cbLocalidad.EditValue Is DBNull.Value Then
            Departamento = "%"
            Area = "%"
        Else
            Departamento = Me.cbLocalidad.GetSelectedDataRow("dep_codigo")
            Area = Me.cbLocalidad.GetSelectedDataRow("are_codigo")
        End If

        Variables.Clear()
        Datos.Clear()
        Variables.Add("Empresa")
        Variables.Add("Periodo")
        Variables.Add("TPeriodo")
        Variables.Add("Empleado")
        Variables.Add("Departamento")
        Variables.Add("Area")
        Variables.Add("Orden")
        Variables.Add("Desde")
        Variables.Add("Hasta")
        Datos.Add(EmpresaActual)
        Datos.Add(Me.cbPlanillas.EditValue.ToString.Substring(1, 8))
        Datos.Add(Me.cbPlanillas.EditValue.ToString.Substring(0, 1))
        Datos.Add(Me.txtCodigo.EditValue)
        Datos.Add(Departamento)
        Datos.Add(Area)
        Datos.Add("A")
        Datos.Add(Me.Desde.EditValue)
        Datos.Add(Me.Hasta.EditValue)

        Dim DT As New DataTable("Encabezado")
        DT = VB.SysContab.FuncionesDB.ProcedureParameters(Datos, Variables, "_Colilla_Encabezado")
        DT.TableName = "Encabezado"
        DT.WriteXml(Application.StartupPath & "\exportfiles\Enc.xml")
        Dim rpt As New Colilla
        rpt.Periodo = Me.cbPlanillas.EditValue.ToString.Substring(1, 8)
        rpt.TPeriodo = Me.cbPlanillas.EditValue.ToString.Substring(0, 1)
        rpt.Departamento = Departamento
        rpt.Area = Area
        rpt.NombreEmpresa.Text = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).Nombre
        rpt.PeriodoNomina.Text = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).FInicio.ToShortDateString & "-" & _
                VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).FFinal.ToShortDateString & "-" & _
                VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).Descripcion
        rpt.DataSource = DT
        rpt.ShowPreview()


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        Dim dt As New VB.SysContab.EmpleadosDetails

        dt = VB.SysContab.EmpleadosDB.GetDetails(Me.txtCodigo.EditValue)
        If Not dt Is Nothing Then
            Me.TextEdit1.EditValue = dt.Nombre
        Else : Me.TextEdit1.EditValue = ""
        End If
    End Sub
End Class