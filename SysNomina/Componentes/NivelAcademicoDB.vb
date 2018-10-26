Imports DbConnect

Public Class NivelAcademicoDB
    Public Shared Function List(ByVal id As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        Try
            Return v.EjecutarComando("_RH_NivelAcademico_List", "IR")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub ADD(ByVal id As Integer, ByVal Descripcion As String)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)

        Try
            v.EjecutarComando("_RH_NivelAcademico_Add")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub Delete(ByVal id As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)

        Try
            v.EjecutarComando("_RH_NivelAcademico_Delete")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
