Imports System.IO
Public Class frmTipoIngreso
#Region "Variables"
    Private Shared ChildInstance As frmTipoIngreso = Nothing
    Public Unico As String
#End Region
    Private Sub frmTipoIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cargar()
        Me.Text = "Mantenimiento de Tipo de Ingresos"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub
    Public Sub cargar()
        dgTIngreso.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
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
        Dim f As frmAgregarTIngreso = frmAgregarTIngreso.Instance
        Dim TIngreso As New VB.SysContab.TipoIngresoDB()
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
        Dim f As frmAgregarTIngreso = frmAgregarTIngreso.Instance
        Nuevo = "NO"

        If Not VB.SysContab.TipoIngresoDB.GetDetails(Registro).Editable Then
            MsgBox("Este Tipo de Ingreso No es Editable. " & vbCrLf & _
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

        If Not VB.SysContab.TipoIngresoDB.GetDetails(Registro).Borrable Then
            MsgBox("Este Tipo de Ingreso No es Borrable. Es parte de la configuarción del Sistema", MsgBoxStyle.Information)
            Exit Sub
        End If
        VB.SysContab.TipoIngresoDB.delete(Registro)
        Me.cargar()
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub


    Private Sub VTipo_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VTipo.FocusedRowChanged
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
    End Sub
End Class