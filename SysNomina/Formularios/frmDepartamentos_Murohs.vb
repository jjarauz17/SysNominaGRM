Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmDepartamentos_Murohs
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmDepartamentos_Murohs = Nothing

    Public Shared Function Instance() As frmDepartamentos_Murohs
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDepartamentos_Murohs()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function


    Private Sub frmDepartamentos_Murohs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListGrid_Murohs()
        Me.VDepartamentos.Columns("Codigo").Visible = False
        If Me.VDepartamentos.DataRowCount <> 0 Then
            Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Mantenimiento de Departamentos"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarDepartamento_Murohs = frmAgregarDepartamento_Murohs.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VDepartamentos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        Dim f As frmAgregarDepartamento_Murohs = frmAgregarDepartamento_Murohs.Instance

        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Departamento que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.MdiParent = Me.MdiParent
        f.Show()

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
            VB.SysContab.DepartamentosDB.Delete_Murohs(Me.VDepartamentos.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dgDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListGrid_Murohs
        If Me.VDepartamentos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
        End If

    End Sub


    

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        'Dim fReportes As New frmReportes()
        'Dim rDepartamentos As New rptDepartamentos()
        'Dim Ds As New DataSet
        'Ds = VB.SysContab.DepartamentosDB.GetListReporte("%", EmpresaActual)
        'Ds.WriteXml(Application.StartupPath & "\exportfiles\rDepartamentos.xml", XmlWriteMode.WriteSchema)

        'rDepartamentos.Database.Tables("Departamentos").Location = Application.StartupPath & "\exportfiles\rDepartamentos.xml"
        'rDepartamentos.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
        'fReportes.crvReportes.ReportSource = rDepartamentos
        'fReportes.ShowDialog()
    End Sub

    Private Sub VDepartamentos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VDepartamentos.FocusedRowChanged
        Registro = Me.VDepartamentos.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
