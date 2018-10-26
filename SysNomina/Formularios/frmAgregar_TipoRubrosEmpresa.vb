Public Class frmAgregar_TipoRubrosEmpresa
#Region "Variables"
    Dim detalles As New VB.SysContab.RubrosEmpresaDetails
#End Region
    Private Sub frmAgregar_TipoRubrosEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCodigo.Enabled = False
        If Nuevo = "SI" Then
            Me.txtCodigo.Text = VB.SysContab.RubrosEmpresaDB.GetList_Nuevo()
        Else

            detalles = VB.SysContab.RubrosEmpresaDB.GetDetails(Registro)
            txtCodigo.Text = detalles.Codigo
            txtNombre.Text = detalles.Descripcion
            Factor.EditValue = detalles.Factor
            chkContabilizar.Checked = detalles.Contabilizar

            If detalles.Sistema = False Then
                Me.Ingresos.Visible = True
                Me.Ingresos.DataSource = VB.SysContab.RubrosEmpresaDB.GetList_Detalle(Me.txtCodigo.Text)
                Me.vLista.Columns("Empresa").Visible = False
                Me.vLista.Columns("Tipo Rubro").Visible = False
                Me.vLista.Columns("Tipo Ingreso").Visible = False
                Me.vLista.Columns("Descripcion").OptionsColumn.ReadOnly = True
            Else
                Me.Ingresos.Visible = False
            End If
        End If
    End Sub

    Private Sub frmAgregar_TipoRubrosEmpresa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim d As New frmTiposRubrosEmpresa

        d.cargar()
        d = Nothing
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Nuevo = "SI" Then
            VB.SysContab.RubrosEmpresaDB.AddItem(Me.txtNombre.Text, Me.Factor.EditValue, IIf(chkContabilizar.Checked, 1, 0))
        Else
            VB.SysContab.RubrosEmpresaDB.UpdateItem(Me.txtCodigo.Text, Me.txtNombre.Text, Me.Factor.EditValue, IIf(chkContabilizar.Checked, 1, 0))
        End If

        If detalles.Sistema = False Then
            For i As Integer = 0 To Me.vLista.DataRowCount - 1
                VB.SysContab.RubrosEmpresaDB.TRE_TI_Detalle(Me.txtCodigo.Text, _
                    Me.vLista.GetRowCellValue(i, "Tipo Ingreso"), _
                    Me.vLista.GetRowCellValue(i, "Calcular"))
            Next
        End If

        Me.Close()
    End Sub
End Class