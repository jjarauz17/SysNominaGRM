Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab
    Public Class RelojDB

        Public Function GetList_HESemana(ByVal semana As DateTime, ByVal TPeriodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'se deja la nueva funcion, pero debo de unificarlas segun el tipo de origen Reloj o Asistencias
            DBCommand = New SqlDataAdapter("_GetList_RelojHE_A", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Semana", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = semana
            pIdent3.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.Fill(dsFicha, "HESEmana")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function GetList_Marcadas(ByVal Desde As DateTime, ByVal Hasta As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_Marcadas", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@hasta", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.Fill(dsFicha, "Marcadas")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function GetList_BuscarRegistro(ByVal Empleado As String, _
               ByVal Fecha As DateTime, ByVal Entrada As String, ByVal Salida As String) As Boolean

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_BuscarRegistro", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Entrada", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Encontrado", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Entrada
            pIdent5.Value = Salida
            pIdent6.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return pIdent6.Value
        End Function
       
        Public Function GetList_UltimoReloj(ByVal Empleado As String, _
               ByVal Fecha As DateTime) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_UltimoReloj", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Consecutivo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = 0
            pIdent4.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)



            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return pIdent4.Value
        End Function

        Public Function GetList_UltimoDomingoProcesado(ByVal Quincena As String, ByVal IncluirReloj As Boolean) As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_UltimoDomingoProcesado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Quincena", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Domingo", SqlDbType.NVarChar, 10)
            Dim pIdent4 As New SqlParameter("@IncluirReloj", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Quincena
            pIdent3.Direction = ParameterDirection.Output
            pIdent4.Value = IncluirReloj

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return IIf(pIdent3.Value Is DBNull.Value, "", pIdent3.Value)

        End Function

        Public Function GetList_DomingoInicioQuincena(ByVal Quincena As String) As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_DomingoInicioQuincena", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Quincena", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Domingo", SqlDbType.NVarChar, 10)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Quincena
            pIdent3.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pIdent3.Value

        End Function


        Public Sub Aplicar_Reloj(ByVal Empleado As String, _
                      ByVal Semana As DateTime, ByVal TPeriodo As String)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Semana", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Semana)
            v.AddParameter("Tperiodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)

            Try
                v.EjecutarComando("_Reloj_Aplicar_A")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Additem(ByVal Empleado As String, _
               ByVal Consecutivo As Integer, _
               ByVal Fecha As DateTime, _
               ByVal Cedula As String, _
               ByVal Entrada As String, _
               ByVal Salida As String, _
               ByVal Horas As Double, _
               ByVal Quincena As String, _
               ByVal Procesado As Boolean, _
               ByVal HExtra As Double)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Reloj_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Consecutivo", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Entrada", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Horas", SqlDbType.Float)
            'Dim pIdent9 As New SqlParameter("@Categoria", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Quincena", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Procesado", SqlDbType.Bit)
            Dim pIdent12 As New SqlParameter("@HExtra", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Consecutivo
            pIdent5.Value = Cedula
            pIdent6.Value = Entrada
            pIdent7.Value = Salida
            pIdent8.Value = Horas
            'pIdent9.Value = Categoria
            pIdent10.Value = Quincena
            pIdent11.Value = Procesado
            pIdent12.Value = HExtra

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            'DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub UpdateItem(ByVal Empleado As String, _
                       ByVal Consecutivo As Integer, _
                       ByVal Fecha As DateTime, _
                       ByVal Cedula As String, _
                       ByVal Entrada As String, _
                       ByVal Salida As String, _
                       ByVal Horas As Double, _
                       ByVal Quincena As String, _
                       ByVal Procesado As Boolean, _
                       ByVal HExtra As Double)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Reloj_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Consecutivo", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Entrada", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Horas", SqlDbType.Float)
            'Dim pIdent9 As New SqlParameter("@Categoria", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Quincena", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Procesado", SqlDbType.Bit)
            Dim pIdent12 As New SqlParameter("@HExtra", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Consecutivo
            pIdent5.Value = Cedula
            pIdent6.Value = Entrada
            pIdent7.Value = Salida
            pIdent8.Value = Horas
            'pIdent9.Value = Categoria
            pIdent10.Value = Quincena
            pIdent11.Value = Procesado
            pIdent12.Value = HExtra

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            'DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub DeleteItem(ByVal Empleado As String, _
               ByVal Consecutivo As Integer, _
               ByVal Fecha As DateTime)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Reloj_Delete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Consecutivo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Consecutivo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub Asistencias_Importar_Reloj(ByVal Quincena As String, ByVal Undo As Boolean)

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Asistencias_Importar_Reloj", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Quincena", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Undo", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Quincena
            pIdent6.Value = Undo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            'Try
            'Se asigna conexion al comando y se abre conexion 
            'DBConn.Open()
            DBCommand.SelectCommand.Connection = DBConnexion
            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            'DBConn.Close()
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try


        End Sub
    End Class
End Namespace