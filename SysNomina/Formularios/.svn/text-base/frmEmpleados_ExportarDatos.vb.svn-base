Public Class frmEmpleados_ExportarDatos
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmEmpleados_ExportarDatos = Nothing

    Public Shared Function Instance() As frmEmpleados_ExportarDatos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEmpleados_ExportarDatos()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function


End Class