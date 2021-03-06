﻿Imports DbConnect
Public Class RH_AntiguedadDetails
    Public Años As Integer
    Public Porcentaje As Decimal
End Class
Public Class rh_antiguedadDB
    Public Shared Function Get_List() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_RH_Antiguedad_List", "Antiguedad")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Shared Sub Add(ByVal Años As Integer, ByVal Porcentaje As Decimal, ByVal Accion As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("anios", SqlDbType.Int, 5, ParameterDirection.Input, Años)
        v.AddParameter("porcentaje", SqlDbType.Float, 5, ParameterDirection.Input, Porcentaje)
        v.AddParameter("accion", SqlDbType.Int, 5, ParameterDirection.Input, Accion)
        Try
            v.EjecutarComando("_RH_Antiguedad_Add", "Antiguedad")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
