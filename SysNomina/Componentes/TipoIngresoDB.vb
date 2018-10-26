Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect
Imports DevExpress.XtraEditors

Namespace VB.SysContab

    Public Class TipoIngresoDetails
        Public Empresa As String
        Public Codigo As String
        Public Descripcion As String
        Public Tipo As String
        Public Editable As Boolean
        Public Borrable As Boolean
        Public Gravable As Boolean
        Public GINSS As Boolean
        Public CtaContable As String
        'Agregado el 2 de Abril 2008, para los calculos de vacaciones y aguinaldo
        Public Aguinaldo As Boolean
        Public Vacaciones As Boolean
        Public Valor_Fijo As Boolean
        Public Indemnizacion As Boolean
        Public Doble As Boolean
        Public Prefijo_Detalle As String
        Public Sufijo_CCosto As String
        Public Factor As Decimal
    End Class

    Public Class TipoIngresoDB

        Public Shared Sub Llenar_SLookUpEdit(ByRef Objeto As DevExpress.XtraEditors.SearchLookUpEdit, Mostrar As String, Valor As String, Mensaje As String)
            objeto.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("").Tables(0)
            objeto.Properties.DisplayMember = Mostrar
            objeto.Properties.ValueMember = Valor
            Objeto.Properties.NullText = Mensaje
            Objeto.Properties.ShowFooter = False

            Objeto.Properties.PopulateViewColumns()


            For i As Integer = 0 To Objeto.Properties.View.Columns.Count - 1
                If Objeto.Properties.View.Columns.Item(i).FieldName <> Objeto.Properties.DisplayMember Then Objeto.Properties.View.Columns.Item(i).Visible = False
            Next

        End Sub
        Public Shared Function Deduccion_Afecta(ByVal tIngreso As String, ByVal tDeduccion As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, tIngreso)
            v.AddParameter("tde_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, tDeduccion)
            Try
                Return v.EjecutarComando("_RH_TipoDeduccion_Detalle_List", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub Deduccion_Afecta_ADD(ByVal tIngreso As String, ByVal tDeduccion As String, ByVal Activo As Boolean)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, tIngreso)
            v.AddParameter("tde_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, tDeduccion)
            v.AddParameter("activo", SqlDbType.Bit, 4, ParameterDirection.Input, Activo)
            Try
                v.EjecutarComando("_RH_tipodeduccion_detalle_Add")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

        Public Shared Function GetDetails(ByVal Codigo As String) As TipoIngresoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New TipoIngresoDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            If dsFicha.Tables("TipoIngreso").Rows.Count = 1 Then

                Details.Empresa = dsFicha.Tables("TipoIngreso").Rows(0).Item("empr_codigo")
                Details.Codigo = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_codigo")
                Details.Descripcion = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_descripcion")
                Details.Tipo = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdm_codigo")
                Details.Borrable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_borrable")
                Details.Editable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_editable")
                Details.Gravable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_gravable")
                Details.GINSS = dsFicha.Tables("TIPOINGRESO").Rows(0).Item("TDI_GRAVINSS")
                Details.CtaContable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_ctacontable")
                Details.Aguinaldo = dsFicha.Tables("TipoIngreso").Rows(0).Item("Aguinaldo")
                Details.Vacaciones = dsFicha.Tables("TipoIngreso").Rows(0).Item("Vacaciones")
                Details.Valor_Fijo = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_ValorFijo")
                Details.Indemnizacion = dsFicha.Tables("TipoIngreso").Rows(0).Item("Indemnizacion")
                Details.Doble = dsFicha.Tables("TipoIngreso").Rows(0).Item("Doble")
                Details.Prefijo_Detalle = dsFicha.Tables("TipoIngreso").Rows(0).Item("Prefijo_Detalle")
                Details.Sufijo_CCosto = dsFicha.Tables("TipoIngreso").Rows(0).Item("Sufijo_CCosto")
                Details.Factor = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_factor")
            End If

            Return Details

        End Function

        Public Shared Function GetList(ByVal Filtro As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngreso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Filtro", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscar(ByVal Filtro As String) As DataSet

            'Revisar los datos de busqueda y donde se utilizan.
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            If dsFicha.Tables("TipoIngreso").Rows(0).Item("CODIGO") Is DBNull.Value Then
                Return "001"
            Else
                Return dsFicha.Tables("TipoIngreso").Rows(0).Item("CODIGO")
            End If


        End Function

        Public Shared Sub delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoIngresoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

        End Sub

        Public Shared Sub Additem(ByVal Codigo As String, ByVal Descripcion As String, ByVal Tipo As String, _
            ByVal Editable As Boolean, ByVal Borrable As Boolean, ByVal Gravable As Boolean, _
            ByVal GINSS As Boolean, ByVal Cuenta As String, ByVal Aguinaldo As Boolean, _
            ByVal Vacaciones As Boolean, ByVal ValorFijo As Boolean, ByVal Indemnizacion As Boolean, _
            ByVal Prefijo_Detalle As String, ByVal Sufijo_CCosto As String, ByVal Factor As Decimal)

            Dim V As New Connect(VB.SysContab.Conexion.AbrirConexion())
            V.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            V.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            V.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            V.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            V.AddParameter("Editable", SqlDbType.Bit, 1, ParameterDirection.Input, Editable)
            V.AddParameter("Borrable", SqlDbType.Bit, 1, ParameterDirection.Input, Borrable)
            V.AddParameter("Gravable", SqlDbType.Bit, 1, ParameterDirection.Input, Gravable)
            V.AddParameter("GINSS", SqlDbType.Bit, 1, ParameterDirection.Input, GINSS)
            V.AddParameter("CtaContable", SqlDbType.NVarChar, 64, ParameterDirection.Input, Cuenta)
            V.AddParameter("Aguinaldo", SqlDbType.Bit, 1, ParameterDirection.Input, Aguinaldo)
            V.AddParameter("Vacaciones", SqlDbType.Bit, 1, ParameterDirection.Input, Vacaciones)
            V.AddParameter("ValorFijo", SqlDbType.Bit, 1, ParameterDirection.Input, ValorFijo)
            V.AddParameter("Indemnizacion", SqlDbType.Bit, 1, ParameterDirection.Input, Indemnizacion)

            V.AddParameter("Prefijo_Detalle", SqlDbType.NVarChar, 64, ParameterDirection.Input, Prefijo_Detalle)
            V.AddParameter("Sufijo_CCosto", SqlDbType.NVarChar, 64, ParameterDirection.Input, Sufijo_CCosto)
            V.AddParameter("Factor", SqlDbType.Float, 64, ParameterDirection.Input, Factor)


            Try
                V.EjecutarComando("_TipoIngresoAdd")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            V = Nothing
        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal Descripcion As String, ByVal Tipo As String, _
            ByVal Gravable As Boolean, ByVal GINSS As Boolean, ByVal Cuenta As String, _
            ByVal Aguinaldo As Boolean, ByVal Vacaciones As Boolean, ByVal ValorFijo As Boolean, ByVal indemnizacion As Boolean, _
            ByVal Prefijo_Detalle As String, ByVal Sufijo_CCosto As String, ByVal Factor As Decimal)

            Dim V As New Connect(VB.SysContab.Conexion.AbrirConexion())
            V.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            V.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            V.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            V.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            V.AddParameter("Gravable", SqlDbType.Bit, 1, ParameterDirection.Input, Gravable)
            V.AddParameter("GINSS", SqlDbType.Bit, 1, ParameterDirection.Input, GINSS)
            V.AddParameter("CtaContable", SqlDbType.NVarChar, 64, ParameterDirection.Input, Cuenta)
            V.AddParameter("Aguinaldo", SqlDbType.Bit, 1, ParameterDirection.Input, Aguinaldo)
            V.AddParameter("Vacaciones", SqlDbType.Bit, 1, ParameterDirection.Input, Vacaciones)
            V.AddParameter("ValorFijo", SqlDbType.Bit, 1, ParameterDirection.Input, ValorFijo)
            V.AddParameter("Indemnizacion", SqlDbType.Bit, 1, ParameterDirection.Input, indemnizacion)

            V.AddParameter("Prefijo_Detalle", SqlDbType.NVarChar, 64, ParameterDirection.Input, Prefijo_Detalle)
            V.AddParameter("Sufijo_CCosto", SqlDbType.NVarChar, 64, ParameterDirection.Input, Sufijo_CCosto)
            V.AddParameter("Factor", SqlDbType.Float, 64, ParameterDirection.Input, Factor)
            Try
                V.EjecutarComando("_TipoIngresoUpdate")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            V = Nothing

        End Sub

    End Class

End Namespace
