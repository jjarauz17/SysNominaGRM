Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab


    Public Class DepartamentosCDB

        Public Shared Function GetList() As DataTable
            Dim v As New DbConnect.Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Try
                Return v.EjecutarComando("_RH_DepartamentosC", "DepartamentosC")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

    End Class

End Namespace

