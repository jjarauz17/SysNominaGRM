Imports System.IO
Public Class frmFeriados
    Private Sub frmFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
        Me.Text = "Mantenimiento de Feriados"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cargar()
        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")
        Me.VFeriados.PopulateColumns()
        Me.VFeriados.Columns(0).Width = 50
        Me.VFeriados.Columns(1).Width = 50
        Me.VFeriados.Columns(2).Width = 250

        Me.VFeriados.Columns("_Dia").Caption = "Dia"
        Me.VFeriados.Columns("_Mes").Caption = "Mes"
        Me.VFeriados.Columns("_Descripcion").Caption = "Descripción"


        If Me.VFeriados.DataRowCount <> 0 Then
            Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarFeriados = frmAgregarFeriados.Instance
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()


    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VFeriados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarFeriados = frmAgregarFeriados.Instance
        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Registro que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.ShowDialog()

        Me.cargar()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VFeriados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim Feriados As New VB.SysContab.FeriadosDB()

        If MsgBox("Esta seguro que dese borrar el Feriado: " & _
            Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes"), _
            MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        VB.SysContab.FeriadosDB.delete(Me.VFeriados.GetFocusedRowCellValue("_Mes"), _
            Me.VFeriados.GetFocusedRowCellValue("_Dia"))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")
        If Me.VFeriados.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
        End If

    End Sub

    Private Sub VFeriados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VFeriados.FocusedRowChanged
        Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
    End Sub
End Class