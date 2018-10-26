Imports System.Collections

Public Class Colilla
    Public Periodo As String
    Public TPeriodo As String
    Public Departamento As String
    Public Area As String
    Public Empleado As String
    Private DTotal As Double
    Private _Area As String

    Private Sub Colilla_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        _Area = Me.DataSource.rows(0)("Area")
    End Sub

    Private Sub Colilla_DataSourceRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()
        Empleado = Fila.Item("emp_codigo")

        Dim Variables As New ArrayList
        Dim Datos As New ArrayList

        Variables.Clear()
        Datos.Clear()
        Variables.Add("Empresa")
        Variables.Add("Periodo")
        Variables.Add("TPeriodo")
        Variables.Add("Empleado")
        Variables.Add("Departamento")
        Variables.Add("Area")
        Variables.Add("Tipo")
        Datos.Add(EmpresaActual)
        Datos.Add(Periodo)
        Datos.Add(TPeriodo)
        Datos.Add(Empleado)
        Datos.Add(Departamento)
        Datos.Add(Area)
        Datos.Add(1)

        Dim RepI As New RptDetalleColillaI
        RepI.DataSource = VB.SysContab.FuncionesDB.ProcedureParameters(Datos, Variables, "_Colilla_Detalle")
        SubRptDetalleI.ReportSource = RepI

        Variables.Clear()
        Datos.Clear()
        Variables.Add("Empresa")
        Variables.Add("Periodo")
        Variables.Add("TPeriodo")
        Variables.Add("Empleado")
        Variables.Add("Departamento")
        Variables.Add("Area")
        Variables.Add("Tipo")
        Datos.Add(EmpresaActual)
        Datos.Add(Periodo)
        Datos.Add(TPeriodo)
        Datos.Add(Empleado)
        Datos.Add(Departamento)
        Datos.Add(Area)
        Datos.Add(2)

        Dim RepD As New RptDetalleColillaD
        RepD.DataSource = VB.SysContab.FuncionesDB.ProcedureParameters(Datos, Variables, "_Colilla_Detalle")
        SubRptDetalleD.ReportSource = RepD

        DTotal += IsNull(RepI.TotalI.Text, 0)
        DTotal -= IsNull(RepD.TotalD.Text, 0)
    End Sub

    Private Sub GroupFooter1_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.AfterPrint
        Total.Text = Format(DTotal, "n2")
    End Sub

    'Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
    '    Dim Fila As DataRowView = GetCurrentRow()

    '    If _Area <> Fila.Item("Area") Then
    '        GroupHeader1.BackColor = Color.AliceBlue
    '    Else
    '        GroupHeader1.BackColor = Color.Cornsilk
    '    End If
    '    _Area = Fila.Item("Area")
    'End Sub
End Class