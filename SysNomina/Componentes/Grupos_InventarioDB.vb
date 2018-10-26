Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Grupos_InventarioDetails
        Public Codigo As String
        Public Nombre As String
        Public Nivel As String
        Public Total As String
        Public Tipo As String

    End Class

    Public Class Grupos_InventarioDB

        Public Function GetListComisionLinea(ByVal Vendedor As String, ByVal Linea As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVendedorLineas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pLinea.Value = Linea
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "VENDEDOR_LINEA")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            DBConn.Close()

            Return dsFicha

            'If dsFicha.Tables("VENDEDOR_LINEA").Rows.Count = 0 Then
            '    Return False
            'Else
            '    Return True

            'End If

        End Function

        'Public Function DeleteVendedorLinea(ByVal Vendedor As String, ByVal Linea As String) As String

        '    Dim DBConn As SqlConnection

        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
        '    'Dim Conn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
        '    Dim cmd As New SqlCommand("_DeleteVendedorLinea", DBConn)

        '    cmd.CommandType = CommandType.StoredProcedure

        '    cmd.Parameters.Add("@Vendedor", Vendedor)
        '    cmd.Parameters.Add("@Linea", Linea)
        '    cmd.Parameters.Add("@Empresa", EmpresaActual)
        '    Try
        '        DBConn.Open()
        '        cmd.ExecuteNonQuery()
        '        DBConn.Close()
        '        Return 1

        '    Catch
        '        Return String.Empty
        '    End Try

        'End Function

        Public Function GetListVendedorLineas(ByVal Vendedor As String, ByVal Linea As String) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVendedorLineas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pLinea.Value = Linea
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "VENDEDOR_LINEA")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            DBConn.Close()

            'Return dsFicha
            If dsFicha.Tables("VENDEDOR_LINEA").Rows.Count = 0 Then
                Return False
            Else
                Return True

            End If

        End Function

        Public Sub AddLineaVendedor(ByVal Vendedor As String, ByVal Linea As String, ByVal Comision As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO VENDEDOR_LINEA(Vendedor, Linea, Comision, Empresa) " & _
                        "Values(" & "'" & Vendedor & "','" & Linea & "','" & Comision & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub UpdateComision(ByVal Vendedor As String, ByVal Linea As String, ByVal Comision As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.RutinasNomina.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE VENDEDOR_LINEA SET Comision = " & Comision & " WHERE Vendedor_Linea.Vendedor = '" & Vendedor & "' AND Vendedor_Linea.Linea = '" & Linea & "' AND Empresa = '" & EmpresaActual & "'"

            'WHERE Vendedor_Linea.Vendedor = @Vendedor
            'AND Vendedor_Linea.Linea = @Linea
            'AND Vendedor_Linea.Empresa = @Empresa

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListGruposInventarioReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Grupos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String, ByVal Tipo As String) As Grupos_InventarioDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsGrupo As New DataSet()
            Dim Details As New Grupos_InventarioDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Grupos_Inventario WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsGrupo, "Grupos_Inventario")

            If dsGrupo.Tables("Grupos_Inventario").Rows.Count = 1 Then
                Details.Codigo = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("CODIGO_GRUPO")
                Details.Nombre = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Nombre")
                'Details.Nivel = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Nivel")

                'If dsGrupo.Tables("Grupos").Rows(0).Item("Total") Is DBNull.Value Then
                '    Details.Total = ""
                'Else
                '    Details.Total = dsGrupo.Tables("Grupos").Rows(0).Item("Total")
                'End If

                Details.Tipo = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Tipo")
            End If

            Return Details

        End Function

        Public Function GetList(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, NOMBRE From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "' ORDER BY Codigo_Grupo", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'cd = "Select CODIGO_GRUPO, NOMBRE From Grupos_Inventario WHERE Tipo = '" & Tipo & "' AND Nombre Like '%" & Filtro & "%' ORDER BY Codigo_Grupo"

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, NOMBRE From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Nombre Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' AND CODIGO_GRUPO <> 0 ORDER BY CODIGO_GRUPO", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, NOMBRE From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY NOMBRE", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'Try
            'DBConn = New OleDbConnection("server=HP18599821974;" _
            '                        & "Initial Catalog=Inscripcion;" _
            '                        & "User Id=sa;" _
            '                        & "Password=enter;")

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, Nombre From Grupos_Inventario WHERE Tipo = '" & Tipo & "' AND CODIGO_GRUPO ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Inventario")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub delete(ByVal Codigo As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.RutinasNomina.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Grupos_Inventario WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Codigo_Grupo As String, ByVal Nombre As String, ByVal Tipo As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Grupos_Inventario(CODIGO_GRUPO, NOMBRE, TIPO, EMPRESA) " & _
                        "Values(" & "'" & Codigo_Grupo & "','" & Nombre & "','" & Tipo & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.RutinasNomina.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Grupos_Inventario SET Nombre = '" & Nombre & "' WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

    End Class

End Namespace
