Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports DbConnect

Namespace VB.SysContab

    Public Class EmpleadosDetails
        Public Codigo As String
        Public Nombre As String
        Public PNombre As String
        Public SNombre As String
        Public PApellido As String
        Public SApellido As String
        Public DepartamentoC As String
        Public Municipio As String
        Public Direccion As String
        Public Telefono As String
        Public Celular As String
        Public Email As String
        Public Fecha_Nacimiento As String
        Public Nivel_Academico As Integer
        Public Profesion As String
        Public Sexo As String
        Public Inss As String
        Public Ruc As String
        Public Cedula As String
        Public Fecha_Ingreso As String
        Public Fecha_FinContrato As String
        Public Contrato As String
        Public Departamento As String
        Public Area As String
        Public Cargo As String
        Public Funcion As String
        Public Horario As String
        Public Salario As String
        Public Estado As String
        Public Duracion As String
        'Public Correo As String
        Public Moneda As String
        Public FormaPago As String  'Quincena, Semanal, Mensual, Destajo
        Public AcumVac As String    'Acumulado de Vacaciones
        Public Ahorro As String     'Acumulado de Ahorro
        Public Ahorro_Emp As String 'Acumulado de Aporte de empresa al Ahorro
        Public HExtra As String     'Si el empleado tiene derecho a horas extras
        Public VTransporte As String    'Viatico de transporte que se le paga al empleado
        Public Foto As String
        Public Firma As String
        Public Liquidado As Boolean
        Public PagarCon As String
        Public Contacto As String
        Public Tel_Contacto As String
        Public UserName As String
        Public Invitados As Integer
        Public AcumulaPrestaciones As Boolean
        Public RegimenINSS As String
        Public Pais As Integer
        Public HastaContrato As String
        Public SalarioxDia As Double
        Public SalarioxHora As Double
        Public Localidad As Integer

        Public Banco As Integer
        Public Identificador As String
        Public Departamento_Murohs As Integer
        Public SalarioFijo As Boolean = True

        Public Organigrama As Integer

        Public Activo As Boolean
        Public Antiguedad As Boolean

    End Class

    Public Class Empleados_Subsidios_Details
        Public Empresa As Integer
        Public Empleado As String
        Public Comida As Boolean
        Public Gaseosa As Boolean
    End Class
    
    Public Class EmpleadosDB

        Public Shared Function Empleado_Constancia(Empresa As Integer, ByVal Empleado As String, Texto As String, NombreFirma As String, CargoFirma As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("EmpresaActual", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("texto", SqlDbType.NVarChar, 500, ParameterDirection.Input, Texto)
            v.AddParameter("nombrefirma", SqlDbType.NVarChar, 100, ParameterDirection.Input, NombreFirma)
            v.AddParameter("cargofirma", SqlDbType.NVarChar, 100, ParameterDirection.Input, CargoFirma)
            Try
                Return v.EjecutarComando("_RH_Constancia", "Constancia")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub Empleado_ActualizarSalario(ByVal Empleado As String, ByVal Salario As Double)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("salario", SqlDbType.Money, 8, ParameterDirection.Input, Salario)
            Try
                v.EjecutarComando("_RH_Actualizar_Salario")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

        Public Shared Function Empleados_SalarioMinimo() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_Empleados_Salario")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function GetFormaPagoEmpleados() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("rh_GetFormaPagoEmpleados")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            v = Nothing
        End Function

        Public Shared Function RH_Contratos(ByVal Empleado As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Try
                Return v.EjecutarComando("_RH_ContratosList")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            v = Nothing
        End Function
        Public Shared Function RH_TipoContrato() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            Try
                Return v.EjecutarComando("_RH_TiposContrato")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            v = Nothing
        End Function


        Public Shared Function Organigrama_Detalle(ByVal Empleado As String, ByVal Organigrama As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("organigrama", SqlDbType.Int, 5, ParameterDirection.Input, Organigrama)
            Try
                Return v.EjecutarComando("_rh_organigrama_empleado_getlist")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            v = Nothing
        End Function


        Public Shared Function Lista_Combo(ByVal Activo As String) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Activos", SqlDbType.NVarChar, 8, ParameterDirection.Input, Activo)

            Try
                Return v.EjecutarComando("_RH_EmpleadosCombo", "Tablas")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try


        End Function


        Public Shared Function RH_EA_Combo() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_EA_Combo", "Empleados")
                v = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            Return Nothing
            v = Nothing
        End Function
        Public Shared Function DisponibilidadLogin(ByVal Empleado As String, ByVal Login As String) As Integer
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpleadoLogin_Disponibilidad", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pEmpleado.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)

            Dim pLogin As New SqlParameter("@Login", SqlDbType.NVarChar)
            pLogin.Value = Login
            DBCommand.SelectCommand.Parameters.Add(pLogin)

            Dim pEncontrado As New SqlParameter("@Encontrados", SqlDbType.Int)
            pEncontrado.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pEncontrado)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()


            Return pEncontrado.Value

        End Function

        Public Shared Sub AddEmpleadosTemp(ByVal Envio As String, ByVal Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String, _
               ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String, _
               ByVal Fecha_Nacimiento As String, _
               ByVal Nivel_Academico As Integer, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String, _
               ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, _
               ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, _
               ByVal Horario As String, ByVal Salario As String, _
               ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As Boolean, _
               ByVal tArea As String, _
               ByVal PagarCon As String, ByVal Contacto As String, ByVal TelContacto As String, _
               ByVal Acumulaprestaciones As Boolean, ByVal RegimenINSS As String, _
               ByVal SysAsistencia As Boolean, ByVal SysNomina As String)


            Dim DBCommand As SqlDataAdapter

            VB.SysContab.Conexion.AbrirConexion()

            DBCommand = New SqlDataAdapter("_Empleado_TempAdd", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent44 As New SqlParameter("@Envio", SqlDbType.NVarChar, 12)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@PNombre", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@SNombre", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@PApellido", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@SApellido", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Departamentoc", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@FNacimiento", SqlDbType.DateTime)
            Dim pIdent14 As New SqlParameter("@NAcademico", SqlDbType.Int)
            Dim pIdent15 As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Sexo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Inss", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@FIngreso", SqlDbType.DateTime)
            Dim pIdent23 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent34 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent24 As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pIdent25 As New SqlParameter("@Funcion", SqlDbType.NVarChar)
            Dim pIdent26 As New SqlParameter("@Horario", SqlDbType.NVarChar)
            Dim pIdent27 As New SqlParameter("@Salario", SqlDbType.Float)
            Dim pIdent30 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent31 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent32 As New SqlParameter("@HExtra", SqlDbType.Bit)
            Dim pIdent37 As New SqlParameter("@PagarCon", SqlDbType.NVarChar)
            Dim pIdent38 As New SqlParameter("@Contacto", SqlDbType.NVarChar)
            Dim pIdent39 As New SqlParameter("@TelContacto", SqlDbType.NVarChar)
            Dim pIdent42 As New SqlParameter("@AcumulaPrestaciones", SqlDbType.Bit)
            Dim pIdent43 As New SqlParameter("@RegimenINSS", SqlDbType.NVarChar)
            Dim pIdent45 As New SqlParameter("@sysAsistencia", SqlDbType.Bit)
            Dim pIdent46 As New SqlParameter("@sysNomina", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = PNombre
            pIdent4.Value = SNombre
            pIdent5.Value = PApellido
            pIdent6.Value = SApellido
            pIdent7.Value = DepartamentoC
            pIdent8.Value = Municipio
            pIdent9.Value = Direccion
            pIdent13.Value = Fecha_Nacimiento
            pIdent14.Value = Nivel_Academico
            pIdent15.Value = Profesion
            pIdent16.Value = Sexo
            pIdent17.Value = Inss
            pIdent18.Value = Ruc
            pIdent19.Value = Cedula
            pIdent20.Value = Fecha_Ingreso
            pIdent23.Value = Departamento
            pIdent24.Value = Cargo
            pIdent25.Value = Funcion
            pIdent26.Value = Horario
            pIdent27.Value = Salario
            pIdent30.Value = Moneda
            pIdent31.Value = FormaPago
            pIdent32.Value = HExtra
            pIdent34.Value = tArea
            pIdent37.Value = PagarCon
            pIdent38.Value = Contacto
            pIdent39.Value = TelContacto
            pIdent42.Value = Acumulaprestaciones
            pIdent43.Value = RegimenINSS
            pIdent44.Value = Envio
            pIdent45.Value = SysAsistencia
            pIdent46.Value = SysNomina


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)
            DBCommand.SelectCommand.Parameters.Add(pIdent24)
            DBCommand.SelectCommand.Parameters.Add(pIdent25)
            DBCommand.SelectCommand.Parameters.Add(pIdent26)
            DBCommand.SelectCommand.Parameters.Add(pIdent27)
            DBCommand.SelectCommand.Parameters.Add(pIdent30)
            DBCommand.SelectCommand.Parameters.Add(pIdent31)
            DBCommand.SelectCommand.Parameters.Add(pIdent32)
            DBCommand.SelectCommand.Parameters.Add(pIdent34)
            DBCommand.SelectCommand.Parameters.Add(pIdent37)
            DBCommand.SelectCommand.Parameters.Add(pIdent38)
            DBCommand.SelectCommand.Parameters.Add(pIdent39)
            DBCommand.SelectCommand.Parameters.Add(pIdent42)
            DBCommand.SelectCommand.Parameters.Add(pIdent43)
            DBCommand.SelectCommand.Parameters.Add(pIdent44)
            DBCommand.SelectCommand.Parameters.Add(pIdent45)
            DBCommand.SelectCommand.Parameters.Add(pIdent46)


            Try
                DBCommand.SelectCommand.Connection = DBConnexion
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Function GetList_Empleados_Exportar() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleados_Exportar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetList_MCS(ByVal Empleado As String, ByVal Fecha As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MCS_EmpleadoDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pCargo As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pDepartamento.Value = Empleado
            pCargo.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()


            Return dsFicha.Tables("Empleados").Rows(0).Item("CODIGO")


        End Function

        Public Shared Function GeneradorReportes(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, ByVal Nivel As String, ByVal Profesion As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesEmpleados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.Int)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.Int)
            Dim pFuncion As New SqlParameter("@Funcion", SqlDbType.Int)
            Dim pNivel As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pProfesion As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pFuncion.Value = Funcion
            pNivel.Value = Nivel
            pProfesion.Value = Profesion
            pOrden.Value = Orden
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pFuncion)
            DBCommand.SelectCommand.Parameters.Add(pNivel)
            DBCommand.SelectCommand.Parameters.Add(pProfesion)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GeneradorReportesGeneral(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, ByVal Nivel As String, ByVal Profesion As String, ByVal Tipo As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesEmpleadosGeneral", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.Int)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.Int)
            Dim pFuncion As New SqlParameter("@Funcion", SqlDbType.Int)
            Dim pNivel As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pProfesion As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pFuncion.Value = Funcion
            pNivel.Value = Nivel
            pProfesion.Value = Profesion
            pTipo.Value = Tipo
            pOrden.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pFuncion)
            DBCommand.SelectCommand.Parameters.Add(pNivel)
            DBCommand.SelectCommand.Parameters.Add(pProfesion)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pOrden)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetailsSubsidios(ByVal Codigo As String) As Empleados_Subsidios_Details

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpleados As New DataSet()
            Dim Details As New Empleados_Subsidios_Details()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_Empleados_Subsidios_Get", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpleados, "subsidios")

            DBConn.Close()

            If dsEmpleados.Tables("subsidios").Rows.Count >= 1 Then
                Details.Empleado = dsEmpleados.Tables("subsidios").Rows(0).Item("emp_codigo")
                Details.Empresa = dsEmpleados.Tables("subsidios").Rows(0).Item("empr_codigo")
                Dim i As Integer = 0
                For i = 0 To dsEmpleados.Tables("subsidios").Rows.Count - 1
                    If dsEmpleados.Tables("subsidios").Rows(i).Item("mcs_Articulo") = 1 Then
                        Details.Comida = True
                    End If
                    If dsEmpleados.Tables("subsidios").Rows(i).Item("mcs_Articulo") = 2 Then
                        Details.Gaseosa = True
                    End If

                Next
            End If

            Return Details

        End Function

        Public Shared Function GetMCSMaximos(ByVal Empleado As String, ByVal Tipo_Sesion As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 4, ParameterDirection.Input, Empleado)
            v.AddParameter("TipoSesion", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo_Sesion)
            Try
                Return v.EjecutarComando("_Empleados_MCS_Maximos", "MCSMaximos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Shared Sub MCS_Maximos_AddUpdate(ByVal Empleado As String, ByVal Tipo_Sesion As String, _
            ByVal Empleados As Integer, ByVal Invitados As Integer)
            'Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            'v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'v.AddParameter("Empleado", SqlDbType.NVarChar, 4, ParameterDirection.Input, Empleado.Substring(4, 4))
            'v.AddParameter("TipoSesion", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo_Sesion)
            'v.AddParameter("MaxEmpleado", SqlDbType.Int, 5, ParameterDirection.Input, Empleados)
            'v.AddParameter("MaxInvitados", SqlDbType.Int, 5, ParameterDirection.Input, Invitados)
            'Try
            '    Return v.EjecutarComando("_Empleados_MCS_Maximos_AddUpdate")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return Nothing
            'End Try


            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_Empleados_MCS_Maximos_AddUpdate", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TipoSesion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@MaxEmpleado", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@MaxInvitados", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado.Substring(4, 4)
            pIdent3.Value = Tipo_Sesion
            pIdent4.Value = Empleados
            pIdent5.Value = Invitados

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Sub

        Public Shared Sub Cuentas_Update(ByVal Empleado As String, ByVal Cuenta As Integer, _
           ByVal Identificador As String)
            'Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            'v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.txtCodigo.Text)
            'v.AddParameter("Cuenta", SqlDbType.Int, 5, ParameterDirection.Input, Me.cbBancos.EditValue)
            'v.AddParameter("Identificador", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.txtIdCuenta.Text)
            'v.EjecutarComando("_Empleados_Cuentas_Update")
            'v = Nothing
            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_Empleados_Cuentas_Update", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Cuenta", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@Identificador", SqlDbType.NVarChar)



            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Cuenta
            pIdent4.Value = Identificador


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Sub
        Public Shared Sub Cuentas_Delete(ByVal Empleado As String)
            'Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            'v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Me.txtCodigo.Text)
            'v.EjecutarComando("_Empleados_Cuentas_Delete")
            'v = Nothing
            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_Empleados_Cuentas_Delete", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Sub

        Public Shared Function GetDetails(ByVal Codigo As String) As EmpleadosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpleados As New DataSet()
            Dim Details As New EmpleadosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' DBCommand = New SqlDataAdapter("SELECT * FROM Empleados WHERE CODIGO_EMPLEADO = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListEmpleadosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'DBCommand.Fill(dsEmpleados, "Empleados")

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpleados, "EMPLEADOS")

            DBConn.Close()


            If dsEmpleados.Tables("Empleados").Rows.Count = 1 Then
                Details.Codigo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Codigo").ToString
                Details.Nombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Nombre")
                Details.PNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PNombre").ToString
                Details.SNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SNombre").ToString
                Details.PApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PApellido").ToString
                Details.SApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SApellido").ToString
                Details.DepartamentoC = dsEmpleados.Tables("Empleados").Rows(0).Item("DepC_codigo").ToString
                Details.Municipio = dsEmpleados.Tables("Empleados").Rows(0).Item("Mun_codigo").ToString
                Details.Direccion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Direccion").ToString
                Details.Telefono = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Telefono").ToString
                Details.Celular = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Celular").ToString
                Details.Email = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Email").ToString
                Details.Fecha_Nacimiento = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FNac").ToString
                Details.Nivel_Academico = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_NAcademico").ToString
                Details.Profesion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Profesion").ToString
                Details.Sexo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Sexo").ToString
                Details.Inss = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Inss").ToString
                Details.Ruc = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ruc").ToString
                Details.Cedula = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Cedula").ToString
                Details.Fecha_Ingreso = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FIngreso").ToString
                Details.Fecha_FinContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FfinContrato").ToString
                Details.Contrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Contrato").ToString
                Details.Departamento = dsEmpleados.Tables("Empleados").Rows(0).Item("Dep_codigo").ToString
                Details.Area = dsEmpleados.Tables("Empleados").Rows(0).Item("are_codigo").ToString
                Details.Cargo = dsEmpleados.Tables("Empleados").Rows(0).Item("Cgo_codigo").ToString
                Details.Funcion = dsEmpleados.Tables("Empleados").Rows(0).Item("Fun_codigo").ToString
                Details.Horario = dsEmpleados.Tables("Empleados").Rows(0).Item("Hor_Codigo").ToString
                Details.Salario = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Salario").ToString
                Details.Estado = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Estado").ToString
                Details.Duracion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Duracion").ToString
                Details.Moneda = dsEmpleados.Tables("Empleados").Rows(0).Item("Mon_codigo").ToString
                Details.FormaPago = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_formaPago").ToString
                Details.AcumVac = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_AcumVac").ToString
                Details.Ahorro = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro").ToString
                Details.Ahorro_Emp = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro_emp").ToString
                Details.HExtra = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_HExtra").ToString
                Details.VTransporte = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Vtransporte").ToString
                Details.Foto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_foto")
                Details.Firma = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_firma")
                Details.Liquidado = dsEmpleados.Tables("Empleados").Rows(0).Item("liquidado")
                Details.PagarCon = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_pago")
                Details.Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_contacto")
                Details.Tel_Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_telcontacto")
                Details.UserName = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_login")
                Details.Invitados = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_invitados")
                Details.AcumulaPrestaciones = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_acumulaprestaciones")
                Details.RegimenINSS = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_regimenINSS")
                Details.Pais = dsEmpleados.Tables("Empleados").Rows(0).Item("Pais_ID")
                Details.HastaContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_hastacontrato").ToString
                Details.SalarioxDia = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxDia")
                Details.SalarioxHora = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxHora")
                Details.Localidad = dsEmpleados.Tables("Empleados").Rows(0).Item("loc_codigo")
                Details.Banco = dsEmpleados.Tables("Empleados").Rows(0).Item("Banco")
                Details.Identificador = IIf(dsEmpleados.Tables("Empleados").Rows(0).Item("Identificador") Is DBNull.Value, "", dsEmpleados.Tables("Empleados").Rows(0).Item("Identificador"))
                Details.Departamento_Murohs = dsEmpleados.Tables("Empleados").Rows(0).Item("depm_codigo")
                Details.SalarioFijo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_salariofijo")
                Details.Organigrama = dsEmpleados.Tables("Empleados").Rows(0).Item("org_codigo")
                Details.Activo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_activo")
                Details.Antiguedad = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_antiguedad")
            End If


            Return Details

        End Function

        Public Shared Function GetDetails_inss(ByVal Codigo As String) As EmpleadosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpleados As New DataSet()
            Dim Details As New EmpleadosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleados_INSS", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'DBCommand.Fill(dsEmpleados, "Empleados")

            Dim pIdent As New SqlParameter("@InSS", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpleados, "EMPLEADOS")

            DBConn.Close()


            If dsEmpleados.Tables("Empleados").Rows.Count = 1 Then
                Details.Codigo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Codigo").ToString
                Details.Nombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Nombre")
                Details.PNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PNombre").ToString
                Details.SNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SNombre").ToString
                Details.PApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PApellido").ToString
                Details.SApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SApellido").ToString
                Details.DepartamentoC = dsEmpleados.Tables("Empleados").Rows(0).Item("DepC_codigo").ToString
                Details.Municipio = dsEmpleados.Tables("Empleados").Rows(0).Item("Mun_codigo").ToString
                Details.Direccion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Direccion").ToString
                Details.Telefono = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Telefono").ToString
                Details.Celular = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Celular").ToString
                Details.Email = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Email").ToString
                Details.Fecha_Nacimiento = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FNac").ToString
                Details.Nivel_Academico = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_NAcademico").ToString
                Details.Profesion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Profesion").ToString
                Details.Sexo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Sexo").ToString
                Details.Inss = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Inss").ToString
                Details.Ruc = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ruc").ToString
                Details.Cedula = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Cedula").ToString
                Details.Fecha_Ingreso = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FIngreso").ToString
                Details.Fecha_FinContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FfinContrato").ToString
                Details.Contrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Contrato").ToString
                Details.Departamento = dsEmpleados.Tables("Empleados").Rows(0).Item("Dep_codigo").ToString
                Details.Area = dsEmpleados.Tables("Empleados").Rows(0).Item("are_codigo").ToString
                Details.Cargo = dsEmpleados.Tables("Empleados").Rows(0).Item("Cgo_codigo").ToString
                Details.Funcion = dsEmpleados.Tables("Empleados").Rows(0).Item("Fun_codigo").ToString
                Details.Horario = dsEmpleados.Tables("Empleados").Rows(0).Item("Hor_Codigo").ToString
                Details.Salario = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Salario").ToString
                Details.Estado = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Estado").ToString
                Details.Duracion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Duracion").ToString
                Details.Moneda = dsEmpleados.Tables("Empleados").Rows(0).Item("Mon_codigo").ToString
                Details.FormaPago = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_formaPago").ToString
                Details.AcumVac = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_AcumVac").ToString
                Details.Ahorro = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro").ToString
                Details.Ahorro_Emp = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro_emp").ToString
                Details.HExtra = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_HExtra").ToString
                Details.VTransporte = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Vtransporte").ToString
                Details.Foto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_foto")
                Details.Firma = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_firma")
                Details.Liquidado = dsEmpleados.Tables("Empleados").Rows(0).Item("liquidado")
                Details.PagarCon = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_pago")
                Details.Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_contacto")
                Details.Tel_Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_telcontacto")
                Details.UserName = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_login")
                Details.Invitados = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_invitados")
                Details.AcumulaPrestaciones = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_acumulaprestaciones")
                Details.RegimenINSS = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_regimenINSS")
                Details.Pais = dsEmpleados.Tables("Empleados").Rows(0).Item("Pais_ID")
                Details.HastaContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_hastacontrato")
                Details.SalarioxDia = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxDia")
                Details.SalarioxHora = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxHora")
                Details.Localidad = dsEmpleados.Tables("Empleados").Rows(0).Item("loc_codigo")
                Details.Departamento_Murohs = dsEmpleados.Tables("Empleados").Rows(0).Item("depm_codigo")
                Details.SalarioFijo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_salariofijo")
                Details.Organigrama = dsEmpleados.Tables("Empleados").Rows(0).Item("org_codigo")
                Details.Activo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_activo")
                Details.Antiguedad = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_antiguedad")

            End If

            Return Details

        End Function

        Public Shared Function GetDetails_cedula(ByVal Codigo As String) As EmpleadosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpleados As New DataSet()
            Dim Details As New EmpleadosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleados_Cedula", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpleados, "EMPLEADOS")

            DBConn.Close()


            If dsEmpleados.Tables("Empleados").Rows.Count = 1 Then
                Details.Codigo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Codigo").ToString
                Details.Nombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Nombre")
                Details.PNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PNombre").ToString
                Details.SNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SNombre").ToString
                Details.PApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PApellido").ToString
                Details.SApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SApellido").ToString
                Details.DepartamentoC = dsEmpleados.Tables("Empleados").Rows(0).Item("DepC_codigo").ToString
                Details.Municipio = dsEmpleados.Tables("Empleados").Rows(0).Item("Mun_codigo").ToString
                Details.Direccion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Direccion").ToString
                Details.Telefono = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Telefono").ToString
                Details.Celular = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Celular").ToString
                Details.Email = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Email").ToString
                Details.Fecha_Nacimiento = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FNac").ToString
                Details.Nivel_Academico = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_NAcademico").ToString
                Details.Profesion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Profesion").ToString
                Details.Sexo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Sexo").ToString
                Details.Inss = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Inss").ToString
                Details.Ruc = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ruc").ToString
                Details.Cedula = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Cedula").ToString
                Details.Fecha_Ingreso = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FIngreso").ToString
                Details.Fecha_FinContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FfinContrato").ToString
                Details.Contrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Contrato").ToString
                Details.Departamento = dsEmpleados.Tables("Empleados").Rows(0).Item("Dep_codigo").ToString
                Details.Area = dsEmpleados.Tables("Empleados").Rows(0).Item("are_codigo").ToString
                Details.Cargo = dsEmpleados.Tables("Empleados").Rows(0).Item("Cgo_codigo").ToString
                Details.Funcion = dsEmpleados.Tables("Empleados").Rows(0).Item("Fun_codigo").ToString
                Details.Horario = dsEmpleados.Tables("Empleados").Rows(0).Item("Hor_Codigo").ToString
                Details.Salario = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Salario").ToString
                Details.Estado = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Estado").ToString
                Details.Duracion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Duracion").ToString
                Details.Moneda = dsEmpleados.Tables("Empleados").Rows(0).Item("Mon_codigo").ToString
                Details.FormaPago = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_formaPago").ToString
                Details.AcumVac = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_AcumVac").ToString
                Details.Ahorro = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro").ToString
                Details.Ahorro_Emp = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro_emp").ToString
                Details.HExtra = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_HExtra").ToString
                Details.VTransporte = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Vtransporte").ToString
                Details.Foto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_foto")
                Details.Firma = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_firma")
                Details.Liquidado = dsEmpleados.Tables("Empleados").Rows(0).Item("liquidado")
                Details.PagarCon = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_pago")
                Details.Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_contacto")
                Details.Tel_Contacto = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_telcontacto")
                Details.UserName = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_login")
                Details.Invitados = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_invitados")
                Details.AcumulaPrestaciones = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_acumulaprestaciones")
                Details.RegimenINSS = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_regimenINSS")
                Details.Pais = dsEmpleados.Tables("Empleados").Rows(0).Item("Pais_ID")
                Details.HastaContrato = IIf(dsEmpleados.Tables("Empleados").Rows(0).Item("emp_hastacontrato") Is DBNull.Value, "", dsEmpleados.Tables("Empleados").Rows(0).Item("emp_hastacontrato"))
                Details.SalarioxDia = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxDia")
                Details.SalarioxHora = dsEmpleados.Tables("Empleados").Rows(0).Item("SalarioxHora")
                Details.Localidad = dsEmpleados.Tables("Empleados").Rows(0).Item("loc_codigo")
                Details.Departamento_Murohs = dsEmpleados.Tables("Empleados").Rows(0).Item("depm_codigo")
                Details.SalarioFijo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_salariofijo")
                Details.Organigrama = dsEmpleados.Tables("Empleados").Rows(0).Item("org_codigo")
                Details.Activo = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_activo")
                Details.Antiguedad = dsEmpleados.Tables("Empleados").Rows(0).Item("emp_antiguedad")

            End If

            Return Details

        End Function

        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetCatalogoEmpleados(ByVal estatus As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("estatus", SqlDbType.Int, 5, ParameterDirection.Input, estatus)

            Try
                Return v.EjecutarComando("_GetCatalogoEmpleados", "Catalogo")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function GetLists() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleados", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListVacaciones(ByVal Al As Date, Optional ByVal Empleado As String = "%") As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("al", SqlDbType.SmallDateTime, 15, ParameterDirection.Input, Al)
            Try
                Return v.EjecutarComando("_getlistEmpleadosVacaciones", "Empleados")
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Shared Function GetPermisosPendientes(ByVal Empleado As String, ByVal TipoPermiso As Integer) As Double
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("tPermiso", SqlDbType.Int, 5, ParameterDirection.Input, TipoPermiso)
            v.AddParameter("Permisos", SqlDbType.Float, 10, ParameterDirection.Output, 0)
            Try
                v.EjecutarComando("_RH_GetPermisosPendientes")
                Return v.GetParameter("Permisos").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try

        End Function


        Public Shared Function GetListAfiscal(ByVal Empleado As String, ByVal AFiscal As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadoAFiscal", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@AFiscal", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            pident.Value = Empleado
            pIdent3.Value = AFiscal
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "AFiscal")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function GetListAfiscal_Reporte(ByVal Empleado As String, _
             ByVal AFiscal As Integer, ByVal Departamento As String, _
             ByVal Detallado As Boolean, ByVal Mes As String) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("AFiscal", SqlDbType.Int, 5, ParameterDirection.Input, AFiscal)
            v.AddParameter("Departamento", SqlDbType.NVarChar, 4, ParameterDirection.Input, Departamento)
            v.AddParameter("Detallado", SqlDbType.Bit, 1, ParameterDirection.Input, Detallado)
            v.AddParameter("Mes", SqlDbType.NVarChar, 6, ParameterDirection.Input, Mes)

            Return v.EjecutarComando("_getlistEmpleadoAFiscal_Reporte", "AFiscal")

        End Function

        Public Shared Function GetListAfiscal_Meses(ByVal AFiscal As Integer) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("AFiscal", SqlDbType.Int, 5, ParameterDirection.Input, AFiscal)

            Try
                Return v.EjecutarComando("_RH_Afiscal_Meses", "Meses")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function GetListDepto(ByVal Depto As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadoDpto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Depto", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Depto
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListDepto(ByVal Depto As String, ByVal a As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadoDpto_Grid", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Depto", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Depto
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscar() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Return v.EjecutarComando("_GetListEmpleadoBuscar", "Empleados")
            v = Nothing
        End Function

        Public Shared Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCombo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub delete(ByVal Codigo As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpleadoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Shared Function Additem(ByRef Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String, _
                ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String, _
                ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal Fecha_Nacimiento As String, _
                ByVal Nivel_Academico As Integer, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String, _
                ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, ByVal Fecha_FinContrato As String, _
                ByVal Contrato As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, _
                ByVal Horario As String, ByVal Salario As String, ByVal Estado As String, _
                ByVal Duracion As String, ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As String, _
                ByVal VTransporte As String, ByVal tArea As String, ByVal Foto As String, ByVal Firma As String, _
                ByVal PagarCon As String, ByVal Contacto As String, ByVal TelContacto As String, ByVal UserName As String, _
                ByVal Invitados As Integer, ByVal Acumulaprestaciones As Boolean, ByVal RegimenINSS As String, _
                ByVal Pais_ID As Integer, ByVal HastaContrato As Date, ByVal Localidad As Integer, _
                ByVal Departamento_Murohs As Integer, ByVal Cuenta As Integer, ByVal Identificador As String, _
                ByVal SalarioFijo As Boolean, ByVal Organigrama As Integer, ByVal Activo As Boolean, _
                ByVal Antiguedad As Boolean, ByVal Area As String) As Boolean


            Dim DBCommand As SqlDataAdapter
            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoAdd", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@PNombre", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@SNombre", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@PApellido", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@SApellido", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Departamentoc", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Celular", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@FNacimiento", SqlDbType.DateTime)
            Dim pIdent14 As New SqlParameter("@NAcademico", SqlDbType.Int)
            Dim pIdent15 As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Sexo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Inss", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@FIngreso", SqlDbType.DateTime)
            'Dim pIdent21 As New SqlParameter("@FfinContrato", SqlDbType.DateTime)
            Dim pIdent22 As New SqlParameter("@Contrato", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent24 As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pIdent25 As New SqlParameter("@Funcion", SqlDbType.NVarChar)
            Dim pIdent26 As New SqlParameter("@Horario", SqlDbType.NVarChar)
            Dim pIdent27 As New SqlParameter("@Salario", SqlDbType.Float)
            Dim pIdent28 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent29 As New SqlParameter("@Duracion", SqlDbType.Float)
            Dim pIdent30 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent31 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent32 As New SqlParameter("@HExtra", SqlDbType.NVarChar)
            Dim pIdent33 As New SqlParameter("@VTransporte", SqlDbType.Float)
            Dim pIdent34 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent35 As New SqlParameter("@Foto", SqlDbType.NVarChar)
            Dim pIdent36 As New SqlParameter("@Firma", SqlDbType.NVarChar)
            Dim pIdent37 As New SqlParameter("@PagarCon", SqlDbType.NVarChar)
            Dim pIdent38 As New SqlParameter("@Contacto", SqlDbType.NVarChar)
            Dim pIdent39 As New SqlParameter("@TelContacto", SqlDbType.NVarChar)
            Dim pIdent40 As New SqlParameter("@UserName", SqlDbType.NVarChar)
            Dim pIdent41 As New SqlParameter("@Invitados", SqlDbType.Int)
            Dim pIdent42 As New SqlParameter("@AcumulaPrestaciones", SqlDbType.Bit)
            Dim pIdent43 As New SqlParameter("@RegimenINSS", SqlDbType.NVarChar)
            Dim pais As New SqlParameter("@Pais_ID", SqlDbType.Int)
            Dim _HastaContrato As New SqlParameter("@HastaContrato", SqlDbType.SmallDateTime)
            Dim _Localidad As New SqlParameter("@Localidad", SqlDbType.Int)
            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.Int)
            Dim _Identificador As New SqlParameter("@Identificador", SqlDbType.NVarChar)
            Dim _SalarioFijo As New SqlParameter("@SalarioFijo", SqlDbType.Bit)
            _SalarioFijo.Value = SalarioFijo
            DBCommand.SelectCommand.Parameters.Add(_SalarioFijo)

            Dim _Organigrama As New SqlParameter("@Organigrama", SqlDbType.Int)
            _Organigrama.Value = Organigrama
            DBCommand.SelectCommand.Parameters.Add(_Organigrama)

            Dim _Activo As New SqlParameter("@emp_activo", SqlDbType.Bit)
            _Activo.Value = Activo
            DBCommand.SelectCommand.Parameters.Add(_Activo)

            Dim _Antiguedad As New SqlParameter("@emp_antiguedad", SqlDbType.Bit)
            _Antiguedad.Value = Antiguedad
            DBCommand.SelectCommand.Parameters.Add(_Antiguedad)

            pIdent.Value = EmpresaActual
            pIdent2.Direction = ParameterDirection.InputOutput
            pIdent2.Value = Codigo
            pIdent3.Value = PNombre
            pIdent4.Value = SNombre
            pIdent5.Value = PApellido
            pIdent6.Value = SApellido
            pIdent7.Value = DepartamentoC
            pIdent8.Value = Municipio
            pIdent9.Value = Direccion
            pIdent10.Value = Telefono
            pIdent11.Value = Celular
            pIdent12.Value = Email
            pIdent13.Value = Fecha_Nacimiento
            pIdent14.Value = Nivel_Academico
            pIdent15.Value = Profesion
            pIdent16.Value = Sexo
            pIdent17.Value = Inss
            pIdent18.Value = Ruc
            pIdent19.Value = Cedula
            pIdent20.Value = Fecha_Ingreso
            'pIdent21.Value = Fecha_FinContrato
            pIdent22.Value = Contrato
            pIdent23.Value = IIf(Departamento Is Nothing, "", Departamento)
            pIdent24.Value = IIf(Cargo Is Nothing, "", Cargo)
            pIdent25.Value = IIf(Funcion Is Nothing, "", Funcion)
            pIdent26.Value = Horario
            pIdent27.Value = Salario
            pIdent28.Value = Estado
            pIdent29.Value = Duracion
            pIdent30.Value = Moneda
            pIdent31.Value = FormaPago
            pIdent32.Value = HExtra
            pIdent33.Value = VTransporte
            'If tArea Is Nothing Then
            '    tArea = ""
            '    pIdent34.Value = tArea
            'Else
            '    If tArea.Length = 2 Then
            '        pIdent34.Value = tArea
            '    Else
            '        pIdent34.Value = tArea.Substring(5, 3)
            '    End If
            'End If
            pIdent34.Value = Area
            pIdent35.Value = Foto
            pIdent36.Value = Firma
            pIdent37.Value = PagarCon
            pIdent38.Value = Contacto
            pIdent39.Value = TelContacto
            pIdent40.Value = UserName
            pIdent41.Value = Invitados
            pIdent42.Value = Acumulaprestaciones
            pIdent43.Value = RegimenINSS
            pais.Value = Pais_ID
            _HastaContrato.Value = HastaContrato
            _Localidad.Value = Localidad
            _Cuenta.Value = Cuenta
            _Identificador.Value = Identificador


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
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            'DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)
            DBCommand.SelectCommand.Parameters.Add(pIdent24)
            DBCommand.SelectCommand.Parameters.Add(pIdent25)
            DBCommand.SelectCommand.Parameters.Add(pIdent26)
            DBCommand.SelectCommand.Parameters.Add(pIdent27)
            DBCommand.SelectCommand.Parameters.Add(pIdent28)
            DBCommand.SelectCommand.Parameters.Add(pIdent29)
            DBCommand.SelectCommand.Parameters.Add(pIdent30)
            DBCommand.SelectCommand.Parameters.Add(pIdent31)
            DBCommand.SelectCommand.Parameters.Add(pIdent32)
            DBCommand.SelectCommand.Parameters.Add(pIdent33)
            DBCommand.SelectCommand.Parameters.Add(pIdent34)
            DBCommand.SelectCommand.Parameters.Add(pIdent35)
            DBCommand.SelectCommand.Parameters.Add(pIdent36)
            DBCommand.SelectCommand.Parameters.Add(pIdent37)
            DBCommand.SelectCommand.Parameters.Add(pIdent38)
            DBCommand.SelectCommand.Parameters.Add(pIdent39)
            DBCommand.SelectCommand.Parameters.Add(pIdent40)
            DBCommand.SelectCommand.Parameters.Add(pIdent41)
            DBCommand.SelectCommand.Parameters.Add(pIdent42)
            DBCommand.SelectCommand.Parameters.Add(pIdent43)
            DBCommand.SelectCommand.Parameters.Add(pais)
            DBCommand.SelectCommand.Parameters.Add(_HastaContrato)
            DBCommand.SelectCommand.Parameters.Add(_Localidad)
            Dim _DepartamentoMurohs As New SqlParameter("@DepMurohs", SqlDbType.Int)
            _DepartamentoMurohs.Value = Departamento_Murohs
            DBCommand.SelectCommand.Parameters.Add(_DepartamentoMurohs)
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)
            DBCommand.SelectCommand.Parameters.Add(_Identificador)

            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                Codigo = pIdent2.Value
                'transaccion.Commit()
                'DBConnexion.Close()
                Return True
            Catch ex As Exception
                'transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try


        End Function

        Public Shared Sub AddSubsidio(ByVal Codigo As String, ByVal Articulo As Integer)

            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_Empleados_Subsidios_Add", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Articulo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Articulo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Sub

        Public Shared Sub DeleteSubsidio(ByVal Codigo As String, ByVal Articulo As Integer)

            Dim DBCommand As SqlDataAdapter
            DBCommand = New SqlDataAdapter("_Empleados_Subsidios_Delete", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Articulo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Articulo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String, _
                ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String, _
                ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal Fecha_Nacimiento As String, _
                ByVal Nivel_Academico As Integer, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String, _
                ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, ByVal Fecha_FinContrato As String, _
                ByVal Contrato As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, _
                ByVal Horario As String, ByVal Salario As String, ByVal Estado As String, _
                ByVal Duracion As String, ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As String, _
                ByVal VTransporte As String, ByVal DeptoArea As String, ByVal pFoto As String, ByVal pfirma As String, _
                ByVal PagarCon As String, ByVal Contacto As String, ByVal TelContacto As String, ByVal UserName As String, _
                ByVal Invitados As Integer, ByVal AcumulaPrestaciones As Boolean, ByVal RegimenINSS As String, _
                ByVal Pais_ID As Integer, ByVal HastaContrato As Date, ByVal Localidad As Integer, ByVal Departamento_Murohs As Integer, _
                ByVal Cuenta As Integer, ByVal Identificador As String, ByVal SalarioFijo As Boolean, ByVal Organigrama As Integer, _
                ByVal Activo As Boolean, ByVal Antiguedad As Boolean, ByVal Area As String)


            Dim DBCommand As SqlDataAdapter

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdate", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@PNombre", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@SNombre", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@PApellido", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@SApellido", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Departamentoc", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Celular", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@FNacimiento", SqlDbType.DateTime)
            Dim pIdent14 As New SqlParameter("@NAcademico", SqlDbType.Int)
            Dim pIdent15 As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Sexo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Inss", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@FIngreso", SqlDbType.DateTime)
            'Dim pIdent21 As New SqlParameter("@FfinContrato", SqlDbType.DateTime)
            Dim pIdent22 As New SqlParameter("@Contrato", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent24 As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pIdent25 As New SqlParameter("@Funcion", SqlDbType.NVarChar)
            Dim pIdent26 As New SqlParameter("@Horario", SqlDbType.NVarChar)
            Dim pIdent27 As New SqlParameter("@Salario", SqlDbType.Float)
            Dim pIdent28 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent29 As New SqlParameter("@Duracion", SqlDbType.Float)
            Dim pIdent30 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent31 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent32 As New SqlParameter("@HExtra", SqlDbType.NVarChar)
            Dim pIdent33 As New SqlParameter("@VTransporte", SqlDbType.Float)
            Dim pIdent34 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent35 As New SqlParameter("@Foto", SqlDbType.NVarChar)
            Dim pIdent36 As New SqlParameter("@Firma", SqlDbType.NVarChar)
            Dim pIdent37 As New SqlParameter("@PagarCon", SqlDbType.NVarChar)
            Dim pIdent38 As New SqlParameter("@Contacto", SqlDbType.NVarChar)
            Dim pIdent39 As New SqlParameter("@TelContacto", SqlDbType.NVarChar)
            Dim pIdent40 As New SqlParameter("@UserName", SqlDbType.NVarChar)
            Dim pIdent41 As New SqlParameter("@Invitados", SqlDbType.Int)
            Dim pIdent42 As New SqlParameter("@AcumulaPrestaciones", SqlDbType.Bit)
            Dim pIdent43 As New SqlParameter("@RegimenINSS", SqlDbType.NVarChar)
            Dim pais As New SqlParameter("@Pais_ID", SqlDbType.Int)
            Dim _HastaContrato As New SqlParameter("@HastaContrato", SqlDbType.SmallDateTime)
            Dim _Localidad As New SqlParameter("@Localidad", SqlDbType.Int)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.Int)
            Dim _Identificador As New SqlParameter("@Identificador", SqlDbType.NVarChar)

            Dim _SalarioFijo As New SqlParameter("@SalarioFijo", SqlDbType.Bit)
            _SalarioFijo.Value = SalarioFijo
            DBCommand.SelectCommand.Parameters.Add(_SalarioFijo)

            Dim _Organigrama As New SqlParameter("@Organigrama", SqlDbType.Int)
            _Organigrama.Value = Organigrama
            DBCommand.SelectCommand.Parameters.Add(_Organigrama)


            Dim _Activo As New SqlParameter("@emp_activo", SqlDbType.Bit)
            _Activo.Value = Activo
            DBCommand.SelectCommand.Parameters.Add(_Activo)

            Dim _Antiguedad As New SqlParameter("@emp_antiguedad", SqlDbType.Bit)
            _Antiguedad.Value = Antiguedad
            DBCommand.SelectCommand.Parameters.Add(_Antiguedad)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = PNombre
            pIdent4.Value = SNombre
            pIdent5.Value = PApellido
            pIdent6.Value = SApellido
            pIdent7.Value = DepartamentoC
            pIdent8.Value = Municipio
            pIdent9.Value = Direccion
            pIdent10.Value = Telefono
            pIdent11.Value = Celular
            pIdent12.Value = Email
            pIdent13.Value = Fecha_Nacimiento
            pIdent14.Value = Nivel_Academico
            pIdent15.Value = Profesion
            pIdent16.Value = Sexo
            pIdent17.Value = Inss
            pIdent18.Value = Ruc
            pIdent19.Value = Cedula
            pIdent20.Value = Fecha_Ingreso
            ' pIdent21.Value = Fecha_FinContrato
            pIdent22.Value = Contrato
            pIdent23.Value = Departamento
            pIdent24.Value = Cargo
            pIdent25.Value = Funcion
            pIdent26.Value = Horario
            pIdent27.Value = Salario
            pIdent28.Value = Estado
            pIdent29.Value = Duracion
            pIdent30.Value = Moneda
            pIdent31.Value = FormaPago
            pIdent32.Value = HExtra
            pIdent33.Value = VTransporte
            'pIdent34.Value = DeptoArea.Substring(5, DeptoArea.Length - 5)
            pIdent34.Value = Area
            pIdent35.Value = pFoto
            pIdent36.Value = pfirma
            pIdent37.Value = PagarCon
            pIdent38.Value = Contacto
            pIdent39.Value = TelContacto
            pIdent40.Value = UserName
            pIdent41.Value = Invitados
            pIdent42.Value = AcumulaPrestaciones
            pIdent43.Value = RegimenINSS
            pais.Value = Pais_ID
            _HastaContrato.Value = HastaContrato
            _Localidad.Value = Localidad
            _Cuenta.Value = Cuenta
            _Identificador.Value = Identificador

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
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            'DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)
            DBCommand.SelectCommand.Parameters.Add(pIdent24)
            DBCommand.SelectCommand.Parameters.Add(pIdent25)
            DBCommand.SelectCommand.Parameters.Add(pIdent26)
            DBCommand.SelectCommand.Parameters.Add(pIdent27)
            DBCommand.SelectCommand.Parameters.Add(pIdent28)
            DBCommand.SelectCommand.Parameters.Add(pIdent29)
            DBCommand.SelectCommand.Parameters.Add(pIdent30)
            DBCommand.SelectCommand.Parameters.Add(pIdent31)
            DBCommand.SelectCommand.Parameters.Add(pIdent32)
            DBCommand.SelectCommand.Parameters.Add(pIdent33)
            DBCommand.SelectCommand.Parameters.Add(pIdent34)
            DBCommand.SelectCommand.Parameters.Add(pIdent35)
            DBCommand.SelectCommand.Parameters.Add(pIdent36)
            DBCommand.SelectCommand.Parameters.Add(pIdent37)
            DBCommand.SelectCommand.Parameters.Add(pIdent38)
            DBCommand.SelectCommand.Parameters.Add(pIdent39)
            DBCommand.SelectCommand.Parameters.Add(pIdent40)
            DBCommand.SelectCommand.Parameters.Add(pIdent41)
            DBCommand.SelectCommand.Parameters.Add(pIdent42)
            DBCommand.SelectCommand.Parameters.Add(pIdent43)
            DBCommand.SelectCommand.Parameters.Add(pais)
            DBCommand.SelectCommand.Parameters.Add(_HastaContrato)
            DBCommand.SelectCommand.Parameters.Add(_Localidad)
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)
            DBCommand.SelectCommand.Parameters.Add(_Identificador)

            Dim _DepartamentoMurohs As New SqlParameter("@DepMurohs", SqlDbType.Int)
            _DepartamentoMurohs.Value = Departamento_Murohs
            DBCommand.SelectCommand.Parameters.Add(_DepartamentoMurohs)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()


        End Sub

        Public Shared Sub UpdateFinContrato(ByVal Codigo As String, ByVal Fecha As Date, ByVal Undo As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_FinDeContratoUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Undo", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha
            pIdent4.Value = Undo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
        End Sub

        Public Shared Sub UpdateVac(ByVal Codigo As String, _
                ByVal Dias As Double, ByVal APagar As Double)

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateVacaciones", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Dias", SqlDbType.Float)
            Dim pIdent4 As New SqlParameter("@APagar", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Dias
            pIdent4.Value = APagar

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

            'Try
            '    'Se asigna conexion al comando y se abre conexion 
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End Sub

        Public Shared Sub UpdateHorario(ByVal Empleado As String, ByVal Horario As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_EmpleadoUpdateHorario ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Horario", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Horario

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

        End Sub

        Public Shared Sub UpdateAguinaldo(ByVal TPeriodo As String, ByVal Undo As Boolean)  ', _
            'ByVal Dias As Long)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateAguinaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Undo", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = TPeriodo
            pIdent3.Value = Undo

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

        End Sub

        Public Shared Sub UpdateAguinaldo_Decrease(ByVal Empleado As String, _
            ByVal Dias As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateAguinaldo_Decrease", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Dias", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Dias

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

        End Sub

        Public Shared Function GetListContratosporVencer() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetContratosporFinalizar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

    End Class

End Namespace
