Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab


    Public Class MunicipiosDB

        Public Shared Function GetList(ByVal Departamento As String) As DataTable
            Dim v As New DbConnect.Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Departamento", SqlDbType.Int, 5, ParameterDirection.Input, Departamento)

            Try
                Return v.EjecutarComando("_RH_MUNICIPIOS", "Municipios")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try


        End Function

    End Class

End Namespace
