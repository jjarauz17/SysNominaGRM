Imports System.IO
Public Class frmTipoDeduccion
    Private Sub frmTipoDeduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargar()
        Me.Text = "Mantenimiento de Tipo de Deducciones"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Public Sub cargar()
        dgTDeduccion.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.VTipo.Columns("Tipo").Visible = False
        If Me.VTipo.DataRowCount <> 0 Then
            Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarTDeduccion = frmAgregarTDeduccion.Instance
        Dim TDeduccion As New VB.SysContab.TipoDeduccionDB()
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VTipo.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")

        Dim f As frmAgregarTDeduccion = frmAgregarTDeduccion.Instance
        Nuevo = "NO"
        If Not VB.SysContab.TipoDeduccionDB.GetDetails(Registro).Editable Then
            MsgBox("Este Tipo de Deduccion No es Editable. " & vbCrLf & _
                   "Es parte de la configuarción del Sistema." & vbCrLf & _
                   "Solamente podra editar los prefijos/sufijos contables", MsgBoxStyle.Information)
        Else
        End If
        f.ShowDialog()
        Me.cargar()

    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VTipo.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
        If Not VB.SysContab.TipoDeduccionDB.GetDetails(Registro).Borrable Then
            MsgBox("Este Tipo de Deduccion No es Borrable. Es parte de la configuarción del Sistema", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Esta Seguro de borrar este registro?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            VB.SysContab.TipoDeduccionDB.Delete(Registro)
        End If
        Me.cargar()
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub


    Private Sub VTipo_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VTipo.FocusedRowChanged
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
    End Sub
End Class