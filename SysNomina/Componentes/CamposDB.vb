Imports DbConnect
Imports System.Data.SqlClient


Namespace VB.SysContab

    Public Class CamposDetails
        Public ID As Integer
        Public Nombre As String
        Public Tipo As String
        Public Longitud As Integer
    End Class
    Public Class CamposDB


        Public Shared Function GetList() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_GetListCampos", "Campos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function GetList(ByVal Empleado As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Try
                Return v.EjecutarComando("_RH_GetListCampos_Disponibles", "Campos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function GetDetails(ByVal ID As Integer) As CamposDetails
            Dim Detalles As New CamposDetails
            Dim t As New DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            Try
                t = v.EjecutarComando("_RH_GetDetailsCampos", "Campos")
                If t.Rows.Count = 1 Then
                    Detalles.ID = t.Rows(0)("ID")
                    Detalles.Longitud = t.Rows(0)("long_campo")
                    Detalles.Nombre = t.Rows(0)("nombre_campo")
                    Detalles.Tipo = t.Rows(0)("tipo_campo")
                End If
                Return Detalles
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function Add(ByVal Nombre As String, ByVal Tipo As String, ByVal Longitud As Integer) As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Nombre", SqlDbType.NVarChar, 50, ParameterDirection.Input, Nombre)
            v.AddParameter("Tipo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Tipo)
            v.AddParameter("Longitud", SqlDbType.Int, 5, ParameterDirection.Input, Longitud)
            Try
                v.EjecutarComando("_RH_CamposEmpleados_Add")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Shared Function Delete(ByVal ID As Integer) As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            v.AddParameter("Borrado", SqlDbType.Bit, 1, ParameterDirection.Output, False)
            Try
                v.EjecutarComando("_RH_CamposEmpleados_Delete")
                Return v.GetParameter("Borrado").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Shared Function GetDatos(ByVal ID As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            Try
                Return v.EjecutarComando("_RH_GetCamposDatos", "Datos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function DatosAdd(ByVal ID As Integer, ByVal Valor As String, _
            Optional ByVal ID_Valor As Integer = 0) As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID_valor", SqlDbType.Int, 5, ParameterDirection.InputOutput, ID_Valor)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            v.AddParameter("Valor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Valor)
            Try
                v.EjecutarComando("_RH_CamposEmpleados_Datos")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Shared Function DatosDelete(ByVal ID_Valor As Integer) As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID_valor", SqlDbType.Int, 5, ParameterDirection.Input, ID_Valor)
            Try
                v.EjecutarComando("_RH_campos_empleados_datosDelete")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Shared Function GetDatos_Empleados(ByVal Empleado As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Try
                Return v.EjecutarComando("_RH_CamposEmpleados_Empleados_List", "Datos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function DatosEmpleados_ADDDEL(ByVal Empleado As String, ByVal ID_Campo_Valor As Integer, _
            ByVal Accion As Integer) As Boolean
            'Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            'v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            'v.AddParameter("ID_campo_valor", SqlDbType.Int, 5, ParameterDirection.Input, ID_Campo_Valor)
            'v.AddParameter("ADDDEL", SqlDbType.Int, 5, ParameterDirection.Input, Accion)
            'Try
            '    v.EjecutarComando("_RH_camposempleados_empleados_ADDDEL")
            '    Return True
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return False
            'End Try
            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_RH_camposempleados_empleados_ADDDEL", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@ID_campo_valor", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@ADDDEL", SqlDbType.Int)



            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = ID_Campo_Valor
            pIdent4.Value = Accion


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Function
    End Class

End Namespace

