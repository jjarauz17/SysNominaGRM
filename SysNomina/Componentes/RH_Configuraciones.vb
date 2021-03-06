﻿Imports DbConnect

Public Class RH_Configuraciones
    Public ID As Integer
    Public Vacaciones_Descansadas As Boolean
    Public Carencia As Integer
    Public Asumir_Subsidio As Boolean
    Public Gen_redondeos As Boolean
    Public Gen_Sobregiros As Boolean
    Public Calendario As Boolean
End Class

Public Class RH_ConfiguracionesDB

    Public Shared Function Get_List(ByVal ID As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)

        Try
            Return v.EjecutarComando("_RH_Configuracion_List")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function RH_VerificaServidores(ByVal modulo As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Modulo", SqlDbType.Int, 5, ParameterDirection.Input, modulo)

        Try
            Return v.EjecutarComando("_RH_VerificarServidores", "Servidores")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Detalles() As RH_Configuraciones
        Dim dt As New DataTable
        dt = Get_List(0)
        If dt.Rows.Count = 0 Then
            Return Nothing
        Else
            Dim d As New RH_Configuraciones
            d.ID = dt.Rows(0)("id")
            d.Vacaciones_Descansadas = dt.Rows(0)("contab_vacdescansadas")
            d.Carencia = dt.Rows(0)("Carencia")
            d.Asumir_Subsidio = dt.Rows(0)("emp_asumesubsidio")
            d.Gen_redondeos = dt.Rows(0)("gen_redondeos")
            d.Gen_Sobregiros = dt.Rows(0)("gen_sobregiros")
            d.Calendario = dt.Rows(0)("pf_calendario")
            Return d
        End If
    End Function

    Public Shared Sub ADD(ByVal ContabilizarVacaciones As Boolean, ByVal PagarSubsidio As Boolean, ByVal Carencia As Integer, _
                          ByVal Accion As Integer, ByVal GenRedondeos As Boolean, ByVal GenSobregiros As Boolean, ByVal PFCalendario As Boolean)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("contabVacaciones", SqlDbType.Int, 5, ParameterDirection.Input, ContabilizarVacaciones)
        v.AddParameter("carencia", SqlDbType.Int, 5, ParameterDirection.Input, Carencia)
        v.AddParameter("PagarSubsidio", SqlDbType.Bit, 5, ParameterDirection.Input, PagarSubsidio)
        v.AddParameter("GenRedondeos", SqlDbType.Bit, 5, ParameterDirection.Input, GenRedondeos)
        v.AddParameter("GenSobregiros", SqlDbType.Bit, 5, ParameterDirection.Input, GenSobregiros)
        v.AddParameter("PFCalendario", SqlDbType.Bit, 5, ParameterDirection.Input, PFCalendario)
        v.AddParameter("Accion", SqlDbType.Int, 5, ParameterDirection.Input, Accion)

        Try
            v.EjecutarComando("_RH_Configuraciones_Add")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
