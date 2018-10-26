Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmDepartamentos

    Private Sub frmDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
        Me.Text = "Mantenimiento de Departamentos"
        Me.Refresh()

    End Sub
    Private Sub cargar()
        dgDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListGrid().Tables("Departamentos")
        Me.VDepartamentos.Columns("Codigo").Visible = False
        If Me.VDepartamentos.DataRowCount <> 0 Then
            Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarDepartamento = frmAgregarDepartamento.Instance
        Nuevo = "SI"
        z.WindowState = FormWindowState.Normal
        z.StartPosition = FormStartPosition.CenterParent
        z.ShowDialog()
        Me.cargar()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VDepartamentos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        Dim f As frmAgregarDepartamento = frmAgregarDepartamento.Instance
        Dim Departamentos As New VB.SysContab.DepartamentosDB()

        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Departamento que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowDialog()
        Me.cargar()


    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VDepartamentos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")

        If MsgBox("Esta seguro que dese borrar el Departamento: " & _
            Me.VDepartamentos.GetFocusedRowCellValue("Codigo") & " - " & _
            Me.VDepartamentos.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.DepartamentosDB.Delete(Me.VDepartamentos.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dgDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListGrid().Tables("Departamentos")
        If Me.VDepartamentos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        End If

    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim R As New xtraDepartamentos
        Dim Ds As New DataSet
        Ds = VB.SysContab.DepartamentosDB.GetListReporte("%", EmpresaActual)
        R.txtEmpresa.Text = NombreEmpresaActual
        R.DataSource = Ds.Tables(0)
        R.ShowPreview()

    End Sub

    Private Sub VDepartamentos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VDepartamentos.FocusedRowChanged
        Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub VDepartamentos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VDepartamentos.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub
End Class