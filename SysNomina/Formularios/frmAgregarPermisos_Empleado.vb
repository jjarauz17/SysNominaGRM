Imports DbConnect

Public Class frmAgregarPermisos_Empleado

#Region "Variables"
    Dim Ultima_Nomina_Procesada As New VB.SysContab.PeriodoNominaDetails
    Dim vDT As New DataTable
    Dim Vacaciones_Disponibles As Double
    Dim Rangos As New DataTable
#End Region

    Private Sub frmAgregarPermisos_Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbEmpleados.Properties.DataSource = VB.SysContab.EmpleadosDB.RH_EA_Combo
        Me.cbEmpleados.Properties.DisplayMember = "Nombre"
        Me.cbEmpleados.Properties.ValueMember = "Codigo"
        Me.Calendario.Enabled = False
        Rangos.Columns.Add("Desde", System.Type.GetType("System.DateTime"))
        Rangos.Columns.Add("Hasta", System.Type.GetType("System.DateTime"))

        Me.cbTipo.Properties.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables("TiposPermisos")
        Me.cbTipo.Properties.ValueMember = "Codigo"
        Me.cbTipo.Properties.DisplayMember = "Descripcion"
        Me.cbTipo.EditValue = 2

        Me.Calendario.DateTime = Today.Date
    End Sub


    'Private Sub cbDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Me.cbDesde.Text <> "08:00 A.M." And Me.cbDesde.Text <> "12:00 P.M." Then
    '        Me.cbDesde.SelectedIndex = 0
    '    End If
    'End Sub


    Private Sub Calendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendario.Click
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0
seguir: For i = j To Calendario.Selection.Count - 1
            If Math.Round(Me.Vacaciones_Disponibles, 0) > k Then
                If Calendario.Selection(i) < Now.Date Then
                    Calendario.Selection.RemoveAt(i)
                    j = i
                    GoTo seguir
                End If
                If Calendario.Selection(i).DayOfWeek = DayOfWeek.Sunday Then
                    Calendario.Selection.RemoveAt(i)
                    j = i
                    GoTo seguir
                End If
                If VB.SysContab.PermisosDB.Disponibilidad(Calendario.Selection(i)) = False Then
                    Calendario.Selection.RemoveAt(i)
                    j = i
                    GoTo seguir
                End If
                k += 1
            Else
                Calendario.Selection.RemoveAt(i)
                j = i
                GoTo seguir
            End If
        Next
    End Sub

    Private Sub cbEmpleados_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmpleados.EditValueChanged
        Me.Calendario.Selection.Clear()
        If Me.cbEmpleados.EditValue = "%" Then
            Me.Calendario.Enabled = False
            Me.txtDisponibles.Text = ""
            Exit Sub
        Else
            'Buscar detalle de ultimo periodo de nomina procesado segun la forma de pago del empleado
            Dim u As String
            u = VB.SysContab.PeriodoNominaDB.Ultima_Nomina_Procesada(VB.SysContab.EmpleadosDB.GetDetails(Me.cbEmpleados.EditValue).FormaPago)
            Me.Ultima_Nomina_Procesada = VB.SysContab.PeriodoNominaDB.GetDetails(u)
            'Buscar los dias disponibles del empleado
            Me.vDT = VB.SysContab.EmpleadosDB.GetListVacaciones(Me.Ultima_Nomina_Procesada.FFinal, Me.cbEmpleados.EditValue)
            Me.Vacaciones_Disponibles = Me.vDT.Rows(0)("Disponibles") / 1 ' antes era 1.4, pero hay documentacion entregada por Tania RH, que indica que no hay factores
            Me.Calendario.Enabled = True
            Me.txtDisponibles.Text = Me.Vacaciones_Disponibles
            Me.txtAutorizados.Text = VB.SysContab.EmpleadosDB.GetPermisosPendientes(Me.cbEmpleados.EditValue, 2)
            Me.Vacaciones_Disponibles = Me.Vacaciones_Disponibles - CDbl(Me.txtAutorizados.Text)
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        Dim PeriodoDetails As New VB.SysContab.PeriodoNominaDetails()
        PeriodoDetails = VB.SysContab.PeriodoNominaDB.GetListBuscarFInicio(Me.Calendario.Selection(0), _
            VB.SysContab.EmpleadosDB.GetDetails(Me.cbEmpleados.EditValue).FormaPago)
        If PeriodoDetails.Codigo Is Nothing Then
            MsgBox("No existe Periodo de Nomina que abarque el periodo del permiso", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim a As DataRow
        Dim Codigo As String
        a = Rangos.NewRow
        a(0) = CDate(Format(Me.Calendario.Selection(0), "d") & " " & Format(CDate("08:00 A.M."), "hh:mm tt"))
        a(1) = CDate(Format(Me.Calendario.Selection(0), "d") & " " & Format(CDate("05:00 P.M."), "hh:mm tt"))
        For i As Integer = 1 To Me.Calendario.Selection.Count - 1
            If DateDiff(DateInterval.Day, a(1).date, Me.Calendario.Selection(i).Date) = 1 Then
                a(1) = CDate(Format(Me.Calendario.Selection(i), "d") & " " & Format(CDate("05:00 P.M."), "hh:mm tt"))
            Else
                Rangos.Rows.Add(a)
                a = Rangos.NewRow
                a(0) = CDate(Format(Me.Calendario.Selection(i), "d") & " " & Format(CDate("08:00 A.M."), "hh:mm tt"))
                a(1) = CDate(Format(Me.Calendario.Selection(i), "d") & " " & Format(CDate("05:00 P.M."), "hh:mm tt"))
            End If
        Next
        Rangos.Rows.Add(a)

        For i As Integer = 0 To Rangos.Rows.Count - 1
            Codigo = VB.SysContab.PermisosDB.GetListCodigoNvo()
            VB.SysContab.PermisosDB.Additem_RH(Codigo, _
            Me.cbEmpleados.EditValue, _
            Rangos.Rows(i)(0), _
            Rangos.Rows(i)(1), _
            Me.cbTipo.EditValue, _
            VB.SysContab.EmpleadosDB.GetDetails(Me.cbEmpleados.EditValue).FormaPago, _
            PeriodoDetails.Codigo)
        Next
    End Sub

End Class