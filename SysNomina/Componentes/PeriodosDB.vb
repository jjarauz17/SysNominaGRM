Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect


Namespace VB.SysContab

    Public Class PeriodoDetails
        Public ID As String
        Public Descripcion As String
        Public Inicio As DateTime
        Public Final As DateTime
        Public Activo As Boolean
        Public Accion As Boolean
        Public Estado As Boolean
        Public Actual As Integer
    End Class

    Public Class PeriodosDB
        Public Shared Sub Detalle_Actualizar(ByVal per_detalle As Integer, ByVal id_tabla As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("per_detalle", SqlDbType.Int, 5, ParameterDirection.Input, per_detalle)
            v.AddParameter("id_tabla", SqlDbType.Int, 5, ParameterDirection.Input, id_tabla)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_DetalleUpdate")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
            End Try
        End Sub

        Public Shared Sub Fechas(ByRef Desde As Date, ByRef Hasta As Date, ByVal Calendario As Boolean)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Inicio", SqlDbType.SmallDateTime, 5, ParameterDirection.Output, Now.Date)
            v.AddParameter("Final", SqlDbType.SmallDateTime, 5, ParameterDirection.Output, Now.Date)
            v.AddParameter("Calendario", SqlDbType.Bit, 5, ParameterDirection.Input, Calendario)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_Fechas")
                Desde = v.GetParameter("Inicio").Valor
                Hasta = v.GetParameter("Final").Valor
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
                Desde = Now.Date
                Hasta = Now.Date
            End Try
        End Sub

        Public Shared Function Cuenta_PeriodosNomina(ByVal ID As Integer) As Integer
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            v.AddParameter("Cuenta", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_ContarPlanillas")
                Return v.GetParameter("Cuenta").Valor
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
                Return 1
            End Try
        End Function

        Public Shared Function GetList() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_PeriodoFiscal_GetList", "AFiscal")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
                Return New DataTable
            End Try
        End Function

        Public Shared Function GetList_Detalle(ByVal Periodo As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Per_ID", SqlDbType.Int, 5, ParameterDirection.Input, Periodo)
            Try
                Return v.EjecutarComando("RH_PFDetalle_Listar", "AFiscal_Detalle")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
                Return New DataTable
            End Try
        End Function

        Public Shared Sub Borrar(ByVal ID As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_Delete")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
            End Try

        End Sub

        Public Shared Sub Agregar(ByVal Desde As Date, ByVal Hasta As Date, ByVal Descripcion As String, IDtabla As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Per_inicio", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Desde)
            v.AddParameter("Per_final", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Hasta)
            v.AddParameter("Per_descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Descripcion)
            v.AddParameter("IDTabla", SqlDbType.Int, 5, ParameterDirection.Input, IDtabla)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_Add")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
            End Try

        End Sub

        Public Shared Sub Actualizar(ByVal ID As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Descripcion As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            v.AddParameter("Per_inicio", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Desde)
            v.AddParameter("Per_final", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Hasta)
            v.AddParameter("Per_descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Descripcion)
            Try
                v.EjecutarComando("_RH_PeriodoFiscal_Update")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts.Nomina")
            End Try

        End Sub
        Public Shared Function Activo(ByVal Fecha As Date) As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_PeriodoActivo_Fecha", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Valor As New SqlParameter("@Valor", SqlDbType.NVarChar, 60)
            _Valor.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(_Valor)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            If _Valor.Value.ToString = "" Or _Valor.Value Is DBNull.Value Then
                Return 0
            Else
                Return _Valor.Value.ToString
            End If

        End Function



        Public Shared Function GetDetails(ByVal Periodo As String) As PeriodoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet
            Dim Details As New PeriodoDetails

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("RH_GetListPeriodosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsHorario, "Periodo")

            If dsHorario.Tables("Periodo").Rows.Count = 1 Then
                Details.ID = dsHorario.Tables("Periodo").Rows(0).Item("per_id").ToString
                Details.Descripcion = dsHorario.Tables("Periodo").Rows(0).Item("Per_Descripcion").ToString
                Details.Inicio = dsHorario.Tables("Periodo").Rows(0).Item("Per_Inicio").ToString
                Details.Final = dsHorario.Tables("Periodo").Rows(0).Item("per_Final").ToString
                Details.Activo = dsHorario.Tables("Periodo").Rows(0).Item("per_activo").ToString
                Details.Accion = dsHorario.Tables("Periodo").Rows(0).Item("per_accion").ToString
                Details.Estado = dsHorario.Tables("Periodo").Rows(0).Item("Per_Estado").ToString
                Details.Actual = dsHorario.Tables("Periodo").Rows(0).Item("Per_Actual")
            Else
                Details.Descripcion = ""
            End If

            Return Details

        End Function

    End Class
End Namespace