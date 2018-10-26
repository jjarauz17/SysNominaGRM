Imports DbConnect
Public Class frmAprobacionRevision_Nomina

    Private Sub frmAprobacionRevision_Nomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cargar()
    End Sub

    Public Sub cargar()
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Me.dgLista.DataSource = v.EjecutarComando("_GetListPlanillas_Rev_Apr", "NominasPendientes")
        v = Nothing

    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRevisar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Me.vLista.GetFocusedRowCellValue("Aprobado") = True Then
            MsgBox("Nomina ya Aprobada")
            Exit Sub
        ElseIf Me.vLista.GetFocusedRowCellValue("Revisado") = True Then
            'MsgBox("Nomina ya Revisada")
            'Exit Sub
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Codigo"))
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Tipo"))
            v.AddParameter("Revisar", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            v.EjecutarComando("_PN_Revisar")
            v = Nothing

        Else
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Codigo"))
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Tipo"))
            v.AddParameter("Revisar", SqlDbType.Bit, 1, ParameterDirection.Input, True)
            v.EjecutarComando("_PN_Revisar")
            v = Nothing
        End If
        'End If
        Me.cargar()
    End Sub

    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAprobar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Me.vLista.GetFocusedRowCellValue("Aprobado") = True Then
            'MsgBox("Nomina ya Aprobada")
            'Exit Sub
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Codigo"))
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Tipo"))
            v.AddParameter("Aprobar", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            v.EjecutarComando("_PN_Aprobar")
            v = Nothing
        Else
            If Me.vLista.GetFocusedRowCellValue("Revisado") = False Then
                MsgBox("Nomina no ha sido revisada")
                Exit Sub
            Else
                Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
                v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Codigo"))
                v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.vLista.GetFocusedRowCellValue("Tipo"))
                v.AddParameter("Aprobar", SqlDbType.Bit, 1, ParameterDirection.Input, True)
                v.EjecutarComando("_PN_Aprobar")
                v = Nothing
            End If
        End If
        Me.cargar()
    End Sub
End Class