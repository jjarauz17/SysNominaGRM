Imports DbConnect

Public Class db_Esquemas

    '' Private Conn As Connect
    '' Private Cadena As String = cl_CadenaConexion.CadenaConexion

    Public Shared Function Guardar(Control As String, Descripcion As String, XmlFile As String, Inicial As Integer) As Boolean
        Dim Conn As New DbConnect.Connect(VB.SysContab.Conexion.AbrirConexion())
        ''
        ''Dim Arch As New IO.FileInfo(My.Application.Info.DirectoryPath & "\XML\xml_" & RolesDetalles.Rows(i)("Nombre") & ".xml")
        Dim Arch As New IO.FileInfo(XmlFile)

        If IO.File.Exists(Arch.FullName) Then
            Conn.RemoveParameters()
            Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
            Conn.AddParameter("Descripcion", SqlDbType.NVarChar, 512, ParameterDirection.Input, Descripcion)
            Conn.AddParameter("Data", SqlDbType.VarBinary, 0, ParameterDirection.Input, XMLToDBFile(Arch.FullName))
            Conn.AddParameter("Inicial", SqlDbType.Int, 4, ParameterDirection.Input, Inicial)

            Conn.EjecutarComando("sp_guardar_esquema")
        End If
    End Function


    Public Function ValidarEsquema() As Boolean

    End Function

    Public Shared Function GetEsquema(Control As String, Inicial As Integer) As DataTable
        Dim Conn As New DbConnect.Connect(VB.SysContab.Conexion.AbrirConexion())

        Try
            Conn.RemoveParameters()
            Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
            Conn.AddParameter("Inicial", SqlDbType.Int, 4, ParameterDirection.Input, Inicial)

            Return Conn.EjecutarComando("sp_sel_esquema")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

End Class
