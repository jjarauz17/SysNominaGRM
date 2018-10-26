Imports DbConnect

Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class EmpresasDetails
        Public Codigo As String
        Public Nombre As String
        Public Ciudad As String
        Public Pais As String
        Public Telefono As String
        Public Contador As String
        Public Mes As String
        Public Anio As String
        Public Fecha_Cierre As String
        Public Fecha_InicioAF As Date
        Public Fecha_CierreAF As Date
        Public Mayor As String
        Public SC01 As String
        Public SC02 As String
        Public SC03 As String
        Public SC04 As String
        Public SC05 As String
        Public SC06 As String
        Public SC07 As String
        Public SC08 As String
        Public SC09 As String
        Public MONEDABASE As String
        Public MONEDASALARIO As String
        Public UMESPAGOVAC As String
        Public UMESPAGOAGU As String
        Public MESPAGOAGUINALDO As String
        Public Representante As String
        Public CedulaRepresentante As String
        Public Espacio As Boolean
        Public CantidadMarcaReloj As Integer
        Public Decimales As String
        Public MCS As Boolean

        Public INSS As Integer
    End Class

    Public Class EmpresasDB

        Public Shared Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function GetLogoEmpresa(ByVal Buscar As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetLogoEmpresa", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(Empresa)

            'Agregar la imagen
            Dim Archivo As String
            Archivo = ""
            Try
                DBCommand.Fill(dsFicha, "_GetLogoEmpresa")
                If dsFicha.Tables(0).Rows.Count = 1 Then
                    Archivo = Application.StartupPath & "\" & dsFicha.Tables(0).Rows(0)("logo")
                End If
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
            End Try
            Return Archivo
        End Function
        Public Shared Function GetLogoEmpresa(Optional ByVal E As Integer = 0) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim i As Integer

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetLogoEmpresa", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Empresa.Value = IIf(E = 0, EmpresaActual, E)
            DBCommand.SelectCommand.Parameters.Add(Empresa)

            'Agregar la imagen
            Dim Archivo As String, oImagen As Image
            Dim ms As New MemoryStream()
            Dim arrImage() As Byte

            Try
                DBCommand.Fill(dsFicha, "_GetLogoEmpresa")
                dsFicha.Tables("_GetlogoEmpresa").Columns.Add("LogoPic", System.Type.GetType("System.Byte[]"))
                For i = 0 To dsFicha.Tables(0).Rows.Count - 1
                    Archivo = Application.StartupPath & "\" & dsFicha.Tables(0).Rows(i)("logo")
                    If Not File.Exists(Archivo) Then
                        GoTo seguir
                    End If
                    oImagen = New Bitmap(Archivo)
                    oImagen.Save(ms, oImagen.RawFormat)
                    arrImage = ms.GetBuffer
                    dsFicha.Tables(0).Rows(i)("logoPic") = arrImage
seguir:         Next
                DBConn.Close()
                dsFicha.Tables(0).Columns.Remove("logo")
                dsFicha.Tables(0).Columns.Item("logopic").ColumnName = "logo"
                Return dsFicha
                Exit Function
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
                Return Nothing
            End Try
        End Function

        Public Shared Function EmpresasXUsuarios(ByVal Usuario As String, ByVal Grid As Boolean) As DataTable
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_EmpresasXUsuarios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.NVarChar)
            _Usuario.Value = Usuario
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            Dim _Grid As New SqlParameter("@Grid", SqlDbType.Bit)
            _Grid.Value = Grid
            DBCommand.SelectCommand.Parameters.Add(_Grid)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha.Tables(0)
        End Function

        Public Function EmpresasXUsuarios(ByVal Usuario As String, ByVal Password As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresasXUsuarios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@UsrLogin", SqlDbType.NVarChar)
            Dim _Password As New SqlParameter("@UsrPassword", SqlDbType.NVarChar)

            _Usuario.Value = Usuario
            _Password.Value = Password

            DBCommand.SelectCommand.Parameters.Add(_Usuario)
            DBCommand.SelectCommand.Parameters.Add(_Password)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpresasReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Codigo As String) As EmpresasDetails
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsEmpresas As New DataSet()
            'Dim Details As New EmpresasDetails()


            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            'DBCommand = New SqlDataAdapter("SELECT * FROM Empresas WHERE Codigo = '" & Codigo & "'", DBConn)
            'DBCommand.Fill(dsEmpresas, "Empresas")
            Dim dt As New DataTable, details As New EmpresasDetails
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            Try
                dt = v.EjecutarComando("_RH_empresa_details", "Tabla")
            Catch ex As Exception
                dt = Nothing
            End Try
            If dt Is Nothing Then
                Return Nothing
            Else
                If dt.Rows.Count = 1 Then
                    details.Codigo = dt.Rows(0).Item("Codigo")
                    details.Nombre = dt.Rows(0).Item("Nombre")
                    details.Ciudad = dt.Rows(0).Item("Ciudad")
                    details.Pais = dt.Rows(0).Item("Pais")
                    details.Telefono = dt.Rows(0).Item("Telefono")
                    details.Contador = dt.Rows(0).Item("Contador")
                    details.Mes = dt.Rows(0).Item("Mes")
                    details.Anio = dt.Rows(0).Item("Anio")
                    'Details.Fecha_Cierre = dsEmpresas.Tables("Empresas").Rows(0).Item("Fecha_Cierreaf")
                    details.Mayor = dt.Rows(0).Item("Mayor")
                    details.SC01 = dt.Rows(0).Item("SC01")
                    details.SC02 = dt.Rows(0).Item("SC02")
                    details.SC03 = dt.Rows(0).Item("SC03")
                    details.SC04 = dt.Rows(0).Item("SC04")
                    details.SC05 = dt.Rows(0).Item("SC05")
                    details.SC06 = dt.Rows(0).Item("SC06")
                    details.SC07 = dt.Rows(0).Item("SC07")
                    details.SC08 = dt.Rows(0).Item("SC08")
                    details.SC09 = dt.Rows(0).Item("SC09")
                    details.Fecha_InicioAF = dt.Rows(0).Item("Fecha_InicioAF")
                    details.Fecha_CierreAF = dt.Rows(0).Item("Fecha_CierreAF")
                    details.MONEDABASE = dt.Rows(0).Item("emp_monedabase")
                    details.MONEDASALARIO = dt.Rows(0).Item("emp_monedasalario")
                    details.UMESPAGOVAC = IIf(dt.Rows(0).Item("empr_umpv") Is DBNull.Value, "", dt.Rows(0).Item("empr_umpv"))
                    details.UMESPAGOAGU = IIf(dt.Rows(0).Item("empr_umpa") Is DBNull.Value, "", dt.Rows(0).Item("empr_umpa"))
                    details.MESPAGOAGUINALDO = dt.Rows(0).Item("empr_mpa")
                    details.Representante = dt.Rows(0).Item("representante")
                    details.CedulaRepresentante = dt.Rows(0).Item("rep_cedula")
                    details.Espacio = dt.Rows(0).Item("espacio")
                    details.CantidadMarcaReloj = dt.Rows(0).Item("cant_marca_reloj")
                    details.Decimales = dt.Rows(0).Item("Decimales").ToString
                    details.MCS = dt.Rows(0).Item("emp_mcs").ToString
                    details.INSS = dt.Rows(0)("empr_INSS")
                End If
            End If
            Return details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Ciudad, Pais, Contador, Telefono FROM EMPRESAS", DBConn)
            DBCommand.Fill(dsFicha, "EMPRESAS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListFechasVacaciones() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFechasVacaciones", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "Empresas")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Nothing
        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            Try
                DBConn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Ciudad, Pais, Contador, Telefono FROM EMPRESAS WHERE Nombre Like '%" & Filtro & "%'", DBConn)
            DBCommand.Fill(dsFicha, "EMPRESAS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM EMPRESAS WHERE Codigo = '" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Nombre As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As String, _
                                ByVal Contador As String, ByVal Mes As String, ByVal Anio As String, ByVal Fecha_Cierre As String, _
                                ByVal Mayor As String, ByVal SC01 As String, ByVal SC02 As String, ByVal SC03 As String, ByVal SC04 As String, _
                                ByVal SC05 As String, ByVal SC06 As String, ByVal SC07 As String, ByVal SC08 As String, ByVal SC09 As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO EMPRESAS(Nombre, Ciudad, Pais, Telefono, Contador, Mes, Anio, Fecha_Cierre, Mayor, SC01, SC02, SC03, SC04, SC05, SC06, SC07, SC08, SC09) " & _
                        "Values(" & "'" & Nombre & "','" & Ciudad & "','" & Pais & "','" & Telefono & "','" & Contador & "','" & Mes & "','" & Anio & "','" & Fecha_Cierre & "','" & Mayor & "','" & SC01 & "','" & SC02 & "','" & SC03 & "','" & SC04 & "','" & SC05 & "','" & SC06 & "','" & SC07 & "','" & SC08 & "','" & SC09 & "')"
            'Try
            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try

        End Sub

        Public Sub Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As String, _
                                ByVal Contador As String, ByVal Mes As String, ByVal Anio As String, ByVal Fecha_Cierre As String, _
                                ByVal Mayor As String, ByVal SC01 As String, ByVal SC02 As String, ByVal SC03 As String, ByVal SC04 As String, _
                                ByVal SC05 As String, ByVal SC06 As String, ByVal SC07 As String, ByVal SC08 As String, ByVal SC09 As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE EMPRESAS SET Nombre = '" & Nombre & "', " & _
                  "Ciudad = '" & Ciudad & "', " & _
                  "Pais = '" & Pais & "', " & _
                  "Telefono = '" & Telefono & "', " & _
                  "Contador = '" & Contador & "', " & _
                  "Mes = '" & Mes & "', " & _
                  "Anio = '" & Anio & "', " & _
                  "Fecha_Cierre = '" & Fecha_Cierre & "', " & _
                  "Mayor = '" & Mayor & "', " & _
                  "SC01 = '" & SC01 & "', " & _
                  "SC02 = '" & SC02 & "', " & _
                  "SC03 = '" & SC03 & "', " & _
                  "SC04 = '" & SC04 & "', " & _
                  "SC05 = '" & SC05 & "', " & _
                  "SC06 = '" & SC06 & "', " & _
                  "SC07 = '" & SC07 & "', " & _
                  "SC08 = '" & SC08 & "', " & _
                  "SC09 = '" & SC09 & "' " & _
                  "WHERE Codigo = '" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub UpdateVacaciones(ByVal Empresa As String, ByVal UMPV As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresaUpdateVacaciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@UMPV", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent3.Value = UMPV


            DBCommand.SelectCommand.Parameters.Add(pIdent)
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

        Public Shared Sub UpdateAguinaldo(ByVal Empresa As String, ByVal UMPA As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresaUpdateAguinaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@UMPA", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent3.Value = UMPA


            DBCommand.SelectCommand.Parameters.Add(pIdent)
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

        Public Function Inicio() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Inicio", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            'pIdent.Value = Filtro
            'pIdent2.Value = Empresa
            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function
    End Class

End Namespace
