Imports DbConnect

Public Class frmConstancias

#Region "Variables"
    Public Shared Cerrar As Boolean = False
    Public Shared Descripcion As String
    Public Shared Departamento As String
#End Region

    Private Sub frmConstancias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cargarTS()
        cargarLista()

    End Sub

    Private Sub cbTS_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbTS.ButtonClick
        If e.Button.Index = 1 Then
            Dim nuevo As New frmAgregarTS
            nuevo.Agregar = True
            nuevo.ShowDialog()
            cargarTS()
        End If
    End Sub
    Sub cargarLista()
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Me.dgConstancias.DataSource = v.EjecutarComando("_Get_RH_Constancias", "Constancias")
            Me.vLista.PopulateColumns()

            Dim a As New Connect(VB.SysContab.Conexion.AbrirConexion)
            Try
                Me.cbTS_1.DataSource = a.EjecutarComando("_Get_TS", "Tipo_Solicitud")
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            a = Nothing
            Me.cbTS_1.PopulateColumns()
            Me.cbTS_1.DisplayMember = "Descripcion"
            Me.cbTS_1.ValueMember = "Codigo"
            Me.cbTS_1.Columns("Mail").Visible = False
            Me.vLista.Columns("Departamento").Visible = False
            Me.vLista.Columns("Tipo Constancia").ColumnEdit = Me.cbTS_1

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        v = Nothing
    End Sub
    Sub cargarTS()
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Me.cbTS.Properties.DataSource = v.EjecutarComando("_Get_TS", "Tipo_Solicitud")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        v = Nothing
        Me.cbTS.Properties.PopulateColumns()
        Me.cbTS.Properties.DisplayMember = "Descripcion"
        Me.cbTS.Properties.ValueMember = "Codigo"
        Me.cbTS.Properties.Columns("Mail").Visible = False
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim detalles As New frmDetalleConstancia
        If Me.vLista.GetFocusedRowCellValue("Departamento") = "0" Then
            detalles.Firma = "0"
        Else
            detalles.Firma = Me.vLista.GetFocusedRowCellValue("Departamento")
        End If
        detalles.Descripcion = Me.vLista.GetFocusedRowCellValue("Descripcion")
        detalles.ShowDialog()
        If frmConstancias.Cerrar = True Then
            Exit Sub
        End If

        Dim forma As New FrmConfiguraReporte
        forma.Agregar = 1
        forma.Constancia = Me.vLista.GetFocusedRowCellValue("Codigo")
        forma.Tipo = Me.vLista.GetFocusedRowCellValue("Tipo Constancia")
        forma.Departamento = frmConstancias.Departamento
        forma.Descripcion = frmConstancias.Descripcion 'InputBox("Digite la descripcion de la constancia", "Constancias", Me.vLista.GetFocusedRowCellValue("Descripcion"))
        forma.ShowDialog()
        Me.cargarTS()
        Me.cargarLista()
    End Sub
    'Private _Tipo As Integer
    'Private _Agregar As Integer
    'Private _Constancia As Integer
    'Private _Descripcion As String

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        If Me.cbTS.EditValue Is Nothing Then
            MsgBox("Seleccione el tipo de Constancia", MsgBoxStyle.Critical, "Sts.nomina")
            Exit Sub
        End If
        Dim detalles As New frmDetalleConstancia
        detalles.ShowDialog()
        If frmConstancias.Cerrar = True Then
            Exit Sub
        End If
        Dim forma As New FrmConfiguraReporte
        forma.Agregar = 0
        forma.Tipo = Me.cbTS.EditValue
        forma.departamento = frmConstancias.Departamento
        forma.Descripcion = frmConstancias.Descripcion 'InputBox("Digite la descripcion de la constancia", "Constancias", "")
        forma.ShowDialog()
        Me.cargarTS()
        Me.cargarLista()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class