Imports System.IO
Public Class frmFunciones

    Private Sub frmFunciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cargar()
        Me.Text = "Mantenimiento de Funciones"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cargar()
        dgFunciones.DataSource = VB.SysContab.FuncionesDB.GetList().Tables("Funciones")

        If Me.VFunciones.DataRowCount <> 0 Then
            Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarFuncion = frmAgregarFuncion.Instance
        Nuevo = "SI"
        z.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VFunciones.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        Dim f As frmAgregarFuncion = frmAgregarFuncion.Instance
        Nuevo = "NO"
        f.Show()

    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VFunciones.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar la Función: " & _
            Me.VFunciones.GetFocusedRowCellValue("Codigo") & " - " & _
            Me.VFunciones.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.FuncionesDB.delete(Me.VFunciones.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try
        dgFunciones.DataSource = VB.SysContab.FuncionesDB.GetList().Tables("Funciones")
        If Me.VFunciones.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        End If



    End Sub

    Private Sub VFunciones_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VFunciones.FocusedRowChanged
        Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
    End Sub
End Class