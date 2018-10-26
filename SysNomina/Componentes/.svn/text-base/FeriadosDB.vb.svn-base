Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class FeriadoDetails
        Public Mes As String
        Public Dia As String
        Public Descripcion As String
        Public FormaPago As String
        Public Feriado As Boolean
        Public MedioDia As Boolean
        Public Activo As Boolean
        Public Editable As Boolean
    End Class

    Public Class FeriadosDB

        
        Public Function GetDetails(ByVal Mes As String, ByVal Dia As String) As FeriadoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New FeriadoDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFeriadosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Dia
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsHorario, "Feriados")

            If dsHorario.Tables("Feriados").Rows.Count = 1 Then

                Details.Mes = dsHorario.Tables("Feriados").Rows(0).Item("fer_mes")
                Details.Dia = dsHorario.Tables("Feriados").Rows(0).Item("fer_dia")
                Details.Descripcion = dsHorario.Tables("Feriados").Rows(0).Item("fer_descripcion")
                Details.FormaPago = dsHorario.Tables("Feriados").Rows(0).Item("fer_formapago")
                Details.Feriado = dsHorario.Tables("Feriados").Rows(0).Item("fer_feriado")
                Details.MedioDia = dsHorario.Tables("Feriados").Rows(0).Item("fer_MedioDia")
                Details.Activo = dsHorario.Tables("Feriados").Rows(0).Item("fer_Activo")
                Details.Editable = dsHorario.Tables("Feriados").Rows(0).Item("fer_Editable")

            End If
            
            Return Details

        End Function

        Public Shared Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFeriados", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            DBCommand.Fill(dsFicha, "Feriados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListds(ByVal Periodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFeriadosDS", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            pIdent.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent1.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            DBCommand.Fill(Ds, "myTable")

            DBConn.Close()
            Return ds
        End Function


        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFeriadosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pIdent.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent1.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            DBCommand.Fill(dsFicha, "Feriados")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Shared Sub delete(ByVal Mes As String, ByVal Dia As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FeriadosDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Dia
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Mes As String, ByVal Dia As String, _
                ByVal Descripcion As String, ByVal FormaPago As String, _
                ByVal Feriado As Boolean, ByVal MedioDia As Boolean, _
                ByVal Activo As Boolean, ByVal Editable As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FeriadosAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@MedioDia", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Activo", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Editable", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Dia
            pIdent3.Value = Descripcion
            pIdent4.Value = FormaPago
            pIdent5.Value = Feriado
            pIdent6.Value = MedioDia
            pIdent7.Value = Activo
            pIdent8.Value = Editable
            pIdent9.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub



        Public Sub Update(ByVal Mes As String, ByVal Dia As String, _
                ByVal Descripcion As String, ByVal FormaPago As String, _
                ByVal Feriado As Boolean, ByVal MedioDia As Boolean, _
                ByVal Activo As Boolean, ByVal Editable As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FeriadosUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Feriado", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@MedioDia", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Activo", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Editable", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Dia
            pIdent3.Value = Descripcion
            pIdent4.Value = FormaPago
            pIdent5.Value = Feriado
            pIdent6.Value = MedioDia
            pIdent7.Value = Activo
            pIdent8.Value = Editable
            pIdent9.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

    End Class

End Namespace
