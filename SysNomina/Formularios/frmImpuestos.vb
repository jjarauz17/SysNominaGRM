Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmImpuestos
    Private cargado As Boolean = False
    Private Sub frmImpuestos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cbAfiscal.DataSource = VB.SysContab.PeriodoNominaDB.GetListAFiscal(True)
        Me.cbAfiscal.ValueMember = "Per_ID"
        Me.cbAfiscal.DisplayMember = "Descripcion"

        Me.cbDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        Me.cbDepartamento.ValueMember = "Codigo"
        Me.cbDepartamento.DisplayMember = "Nombre"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.cbEmpleados.DisplayMember = "Nombre"
        Me.cbEmpleados.ValueMember = "Codigo"

        Me.cbmeses.DataSource = VB.SysContab.EmpleadosDB.GetListAfiscal_Meses(Me.cbAfiscal.SelectedValue)
        Me.cbmeses.DisplayMember = "Descripcion"
        Me.cbmeses.ValueMember = "Mes"

        Me.chkDetallado.EditValue = True
        cargado = True

    End Sub

    Private Sub cmdIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIR.Click
        Dim ds As New DataTable
        ds = VB.SysContab.EmpleadosDB.GetListAfiscal_Reporte(IIf(Me.rbEmpleado.Checked, Me.cbEmpleados.SelectedValue, "%"), _
            IIf(Me.cbAfiscal.Text Is DBNull.Value Or Me.cbAfiscal.Text = "", "0", Me.cbAfiscal.SelectedValue), _
            Me.cbDepartamento.SelectedValue, Me.chkDetallado.EditValue, Me.cbmeses.SelectedValue)
        ds.WriteXml(Application.StartupPath & "\Empleados_Afiscal.xml", XmlWriteMode.WriteSchema)


        Dim documento As New rptECIR
        documento.txtNombreEmpresa.Text = NombreEmpresaActual
        documento.txtAFiscal.Text = "Año Fiscal:" & Me.cbAfiscal.SelectedText
        documento.DataSource = ds
        documento.Detail.Visible = Me.chkDetallado.EditValue
        documento.ghEmpleado.Visible = Me.chkDetallado.EditValue
        'documento.ghIDTabla.Visible = Me.chkDetallado.EditValue
        documento.ghMes.Visible = Me.chkDetallado.EditValue
        documento.gfMes.Visible = Me.chkDetallado.EditValue
        'documento.gfIDTabla.Visible = Me.chkDetallado.EditValue
        documento.txttotalEmpl.Visible = Me.chkDetallado.EditValue
        documento.txtEmpl.Visible = Not Me.chkDetallado.EditValue
        documento.ReportHeader.Visible = Not Me.chkDetallado.EditValue
        documento.ShowPreview()

        'Dim visor As New frmReportes
        ''Dim Reporte As New rptEstadoCuenta_IR
        'Dim Reporte As New Object
        'Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'If Not File.Exists(Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt") Then
        '    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt")
        '    Exit Sub
        'End If

        'Reporte.load(Application.StartupPath & "\reportes\rptEstadoCuenta_IR.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        'Reporte.Database.Tables("AFiscal").Location = Application.StartupPath & "\empleados_afiscal.xml"
        'Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
        'visor.crvReportes.ReportSource = Reporte
        'visor.ShowDialog()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.cbDepartamento.SelectedValue = "%"
        Me.cbDepartamento.Visible = False

        Me.cbEmpleados.SelectedItem = 0
        Me.cbEmpleados.Visible = False

    End Sub

    Private Sub rbDepartamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDepartamento.CheckedChanged
        Me.cbDepartamento.SelectedValue = "%"
        Me.cbDepartamento.Visible = True

        Me.cbEmpleados.SelectedItem = 0
        Me.cbEmpleados.Visible = False
    End Sub

    Private Sub rbEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmpleado.CheckedChanged
        Me.cbDepartamento.SelectedValue = "%"
        Me.cbDepartamento.Visible = False

        Me.cbEmpleados.SelectedValue = Registro
        Me.cbEmpleados.Visible = True

    End Sub


    Private Sub cbAfiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfiscal.SelectedIndexChanged
        If cargado Then
            Me.cbmeses.DataSource = VB.SysContab.EmpleadosDB.GetListAfiscal_Meses(Me.cbAfiscal.SelectedValue)
            Me.cbmeses.DisplayMember = "Descripcion"
            Me.cbmeses.ValueMember = "Mes"
        End If
    End Sub
End Class