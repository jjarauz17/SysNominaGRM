﻿Imports DbConnect

Namespace VB.SysNomina

    Public Class TMOVDetails
        Public Empresa As Integer
        Public ID As Integer
        Public Tipo As String 'I:ngreso; E:greso; P:ermiso
        Public Codigo As String 'Codigo de SysNomina
        Public Referencia As Integer 'Codigo referencia a Usar en la Pantalla de Movimientos Unificados
        Public Descripcion As String

    End Class
    Public Class TMovDB
        Public Shared Function GetList() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_TMov_GetList", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function

        Public Shared Function GetList(ByVal Tipo As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            Try
                Return v.EjecutarComando("_RH_TMov_GetListCombo", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function

        Public Shared Function GetDetails(ByVal Id As Integer) As TMOVDetails
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, Id)
            Try
                Dim dt As DataTable = v.EjecutarComando("_RH_TMov_GetDetails", "Lista")
                If dt.Rows.Count <> 0 Then
                    Dim detalle As New TMOVDetails
                    detalle.ID = dt.Rows(0)("id")
                    detalle.Empresa = dt.Rows(0)("empr_codigo")
                    detalle.Tipo = dt.Rows(0)("tipo")
                    detalle.Codigo = dt.Rows(0)("codigo")
                    detalle.Referencia = dt.Rows(0)("referencia")
                    detalle.Descripcion = dt.Rows(0)("descripcion")
                    Return detalle
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            Return Nothing
        End Function
        Public Shared Sub Agregar(ByVal Tipo As String, ByVal Codigo As String, ByVal Referencia As Integer, ByVal Descripcion As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            v.AddParameter("Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Referencia)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            Try
                v.EjecutarComando("_RH_TMov_Agregar")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Public Shared Sub Borrar(ByVal id As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, id)
            Try
                v.EjecutarComando("_RH_TMov_Borrar")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Namespace
