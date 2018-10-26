Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace VB.SysContab
    Public Class SysAsistenciasDB
        Public Shared Function LeerDatos(ByVal Campos As String, ByVal Tabla As String, ByVal Condicion As String) As DataSet
            Dim lds As New DataSet
            Dim DBCommand As SqlDataAdapter
            Dim DBConn As New SqlConnection

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Read", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCampos As New SqlParameter("@Campos", SqlDbType.NVarChar, 1000)
            pCampos.Value = Campos
            DBCommand.SelectCommand.Parameters.Add(pCampos)

            Dim pTabla As New SqlParameter("@Tabla", SqlDbType.NVarChar, 2500)
            pTabla.Value = Tabla
            DBCommand.SelectCommand.Parameters.Add(pTabla)

            Dim pCondicion As New SqlParameter("@Condicion", SqlDbType.NVarChar, 1000)
            pCondicion.Value = Condicion
            DBCommand.SelectCommand.Parameters.Add(pCondicion)

            Dim psentencia As New SqlParameter("@tsentencia", SqlDbType.NVarChar, 4000)
            psentencia.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(psentencia)

            Try
                DBConn.Open()
                DBCommand.Fill(lds, "Datos")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return lds
        End Function

        Public Shared Sub Update_Empleado_Temp(ByVal CodigoSysAsistencias As String, ByVal Envio As String, ByVal CodigoSysNomina As String, _
                ByVal Estado As String)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Empleados_Temp_Actualizar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Estado", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent3.Value = Envio
            pIdent4.Value = CodigoSysNomina
            pIdent5.Value = Estado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()


        End Sub

        Public Shared Sub Update_P_Empleado(ByVal Envio As String)

            Dim DBCommand As SqlDataAdapter

            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()
            transaccion = DBConnexion.BeginTransaction

            DBCommand = New SqlDataAdapter("_Envios_P_Empleado", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)

            pIdent.Value = EmpresaActual
            pIdent3.Value = Envio

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

            VB.SysContab.Rutinas.okTransaccion()

        End Sub

        Public Shared Function Buscar_Empleado_Temp(ByVal CodigoSysAsistencias As String, ByVal Envio As String, _
            ByVal CodigoSysNomina As String) As Integer

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Empleados_Temp_Buscar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Encontrado", SqlDbType.Int)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent3.Value = Envio
            pIdent4.Value = CodigoSysNomina
            pIdent5.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            Return pIdent5.Value

        End Function

        Public Shared Function Buscar_Asistencias_Temp(ByVal CodigoSysAsistencias As String, ByVal Envio As String, _
           ByVal CodigoSysNomina As String, ByVal Fecha As Date) As Integer

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Empleados_Asistencias_Buscar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Encontrado", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent3.Value = Envio
            pIdent4.Value = CodigoSysNomina
            pIdent5.Direction = ParameterDirection.Output
            pIdent6.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            Return pIdent5.Value

        End Function

        Public Shared Function Buscar_Latas_Temp(ByVal CodigoSysAsistencias As String, ByVal Envio As String, _
       ByVal CodigoSysNomina As String, ByVal Fecha As Date) As Integer

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Empleados_Latas_Buscar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Encontrado", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent3.Value = Envio
            pIdent4.Value = CodigoSysNomina
            pIdent5.Direction = ParameterDirection.Output
            pIdent6.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            Return pIdent5.Value

        End Function

        Public Shared Function Buscar_Asistencias(ByVal CodigoSysAsistencias As String, _
          ByVal CodigoSysNomina As String, ByVal Fecha As Date) As Integer

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Asistencias_Buscar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Encontrado", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent4.Value = CodigoSysNomina
            pIdent5.Direction = ParameterDirection.Output
            pIdent6.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            Return pIdent5.Value

        End Function
        Public Shared Function Buscar_Latas(ByVal CodigoSysAsistencias As String, _
      ByVal CodigoSysNomina As String, ByVal Fecha As Date) As Integer

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_FCS_Latas_Buscar", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CodigoSysAsistencias", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@CodigoSysNomina", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Encontrado", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = CodigoSysAsistencias
            pIdent4.Value = CodigoSysNomina
            pIdent5.Direction = ParameterDirection.Output
            pIdent6.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()
            Return pIdent5.Value

        End Function

        Public Shared Sub AddAsistenciasTemp(ByVal Lenvio As String, ByVal Empleado As String, _
            ByVal Fecha As Date, ByVal Presencia As Boolean, _
            ByVal HoraEntrada As String, ByVal HoraSalida As String, _
            ByVal MitadDia As Boolean, ByVal Feriado As Boolean, _
            ByVal ExtrasSimples As Double, ByVal ExtrasDobles As Double, ByVal Estado As String)

            Dim DBCommand As SqlDataAdapter

            VB.SysContab.Conexion.AbrirConexion()

            DBCommand = New SqlDataAdapter("_Asistencias_TempAdd", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Presencia", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@HoraEntrada", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@HoraSalida", SqlDbType.DateTime)
            Dim pIdent7 As New SqlParameter("@MitadDia", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@ExtrasSimples", SqlDbType.Float)
            Dim pIdent10 As New SqlParameter("@ExtrasDobles", SqlDbType.Float)
            Dim pIdent11 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent12 As New SqlParameter("@estado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Presencia
            If HoraEntrada Is DBNull.Value Or HoraEntrada = "" Then
                pIdent5.Value = DBNull.Value
            Else
                pIdent5.Value = CDate(HoraEntrada)
            End If
            If HoraSalida Is DBNull.Value Or HoraSalida = "" Then
                pIdent6.Value = DBNull.Value
            Else
                pIdent6.Value = CDate(HoraSalida)
            End If

            pIdent7.Value = MitadDia
            pIdent8.Value = Feriado
            pIdent9.Value = ExtrasSimples
            pIdent10.Value = ExtrasDobles
            pIdent11.Value = Lenvio
            pIdent12.Value = Estado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)


            Try

                DBCommand.SelectCommand.Connection = DBConnexion
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub AddLatasTemp(ByVal LEnvio As String, ByVal Empleado As String, _
          ByVal Fecha As Date, ByVal Presencia As Boolean, ByVal Feriado As Boolean, _
          ByVal Latas As Double, ByVal Estado As String)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_FCS_latas_TempAdd", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Presencia", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@Latas", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent8 As New SqlParameter("@Estado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Presencia
            pIdent5.Value = Latas
            pIdent6.Value = LEnvio
            pIdent7.Value = Feriado
            pIdent8.Value = Estado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Try
                DBCommand.SelectCommand.Connection = DBConnexion
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub AddAsistencias(ByVal Empleado As String, _
            ByVal Fecha As Date, ByVal Presencia As Boolean, _
            ByVal HoraEntrada As String, ByVal HoraSalida As String, _
            ByVal MitadDia As Boolean, ByVal Feriado As Boolean, _
            ByVal ExtrasSimples As Double, ByVal ExtrasDobles As Double)

            Dim DBCommand As SqlDataAdapter

            VB.SysContab.Conexion.AbrirConexion()

            DBCommand = New SqlDataAdapter("_Asistencias_Add", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Presencia", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@HoraEntrada", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@HoraSalida", SqlDbType.DateTime)
            Dim pIdent7 As New SqlParameter("@MitadDia", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@ExtrasSimples", SqlDbType.Float)
            Dim pIdent10 As New SqlParameter("@ExtrasDobles", SqlDbType.Float)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Presencia
            If HoraEntrada Is DBNull.Value Or HoraEntrada = "" Then
                pIdent5.Value = DBNull.Value
            Else
                pIdent5.Value = CDate(HoraEntrada)
            End If
            If HoraSalida Is DBNull.Value Or HoraSalida = "" Then
                pIdent6.Value = DBNull.Value
            Else
                pIdent6.Value = CDate(HoraSalida)
            End If

            pIdent7.Value = MitadDia
            pIdent8.Value = Feriado
            pIdent9.Value = ExtrasSimples
            pIdent10.Value = ExtrasDobles

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)


            Try

                DBCommand.SelectCommand.Connection = DBConnexion
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub AddLatas(ByVal Empleado As String, _
            ByVal Fecha As Date, ByVal Presencia As Boolean, _
            ByVal Feriado As Boolean, ByVal Latas As Double, _
            ByVal Estado As String)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_FCS_Latas_Add", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Presencia", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@Latas", SqlDbType.Float)
            Dim pIdent8 As New SqlParameter("@Estado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Presencia
            pIdent5.Value = Latas
            pIdent7.Value = Feriado
            pIdent8.Value = Estado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Try
                DBCommand.SelectCommand.Connection = DBConnexion
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Function Get_Asistencias(ByVal Desde As Date, ByVal Hasta As Date) As DataSet

            Dim DBCommand As SqlDataAdapter
            Dim Dbconn As SqlConnection

            Dbconn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Asistencias_Get_Listado", Dbconn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            Try
                Dim lds As New DataSet
                Dbconn.Open()
                DBCommand.Fill(lds, "Asistencias")
                Dbconn.Close()
                Return lds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Shared Function Get_Latas(ByVal Desde As Date, ByVal Hasta As Date) As DataSet

            Dim DBCommand As SqlDataAdapter
            Dim Dbconn As SqlConnection
            Dim lds As New DataSet

            Dbconn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FCS_Latas_Get_Listado", Dbconn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            Try

                Dbconn.Open()
                DBCommand.Fill(lds, "Latas")
                Dbconn.Close()
                Return lds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class
End Namespace