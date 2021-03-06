Public Class frmPlantillaDetalle
#Region "Variables"
    Public TRubro As String = "%"
    Public Rubro As String = "%"
    Public Empleado As String = "%"
#End Region


    Private Sub frmPlantillaDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbDebitos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.cbDebitos.DisplayMember = "Nombre"
        Me.cbDebitos.ValueMember = "Cuenta"

        Me.cbCreditos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.cbCreditos.DisplayMember = "Nombre"
        Me.cbCreditos.ValueMember = "Cuenta"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.Lista_Combo("0")
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.cbRubros.DataSource = VB.SysNomina.TMovDB.GetList("%")
        Me.cbRubros.DisplayMember = "Descripcion"
        Me.cbRubros.ValueMember = "Codigo"

        Me.dgPlantillaDetalle.DataSource = VB.SysContab.RH_OrganigramaDB.PlantillaDetalle(Empleado, TRubro, Rubro)
        Me.vLista.Columns("empr_codigo").Visible = False
        Me.vLista.Columns("emp_codigo").Caption = "Empleado"
        Me.vLista.Columns("emp_codigo").ColumnEdit = Me.cbEmpleados
        Me.vLista.Columns("TRCodigo").Caption = "Tipo Rubro"
        Me.vLista.Columns("TRCodigo").ColumnEdit = Me.cbRubros
        Me.vLista.Columns("TRCodigo").Visible = False
        Me.vLista.Columns("rub_tipo").Visible = False
        Me.vLista.Columns("rub_codigo").Visible = False

        Me.vLista.Columns("rub_cuentaDebito").Caption = "Cuenta Debito"
        Me.vLista.Columns("rub_cuentaDebito").ColumnEdit = Me.cbDebitos

        Me.vLista.Columns("rub_cuentaCredito").Caption = "Cuenta Credito"
        Me.vLista.Columns("rub_cuentaCredito").ColumnEdit = Me.cbCreditos
        Me.vLista.Columns("activo").Caption = "�Activo?"

        If Me.TRubro = "I" Then
            Me.vLista.Columns("rub_cuentaCredito").Visible = False
        ElseIf Me.TRubro = "D" Then
            Me.vLista.Columns("rub_cuentaDebito").Visible = False
        End If
        Me.vLista.BestFitColumns()
    End Sub

    Private Sub dgPlantillaDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPlantillaDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub vLista_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vLista.CellValueChanged
        If e.Column.FieldName = "emp_codigo" Then
            Me.vLista.Columns("rub_cuentaDebito").OptionsColumn.ReadOnly = False
            Me.vLista.Columns("rub_cuentaCredito").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vLista_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vLista.InitNewRow
        Me.vLista.Columns("rub_cuentaDebito").OptionsColumn.ReadOnly = True
        Me.vLista.Columns("rub_cuentaCredito").OptionsColumn.ReadOnly = True

    End Sub
    Dim clone As DataView
    Private Sub vLista_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.ShownEditor
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Vista = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If Vista.FocusedColumn.FieldName = "id_valor" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("id") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone.RowFilter = "[emp_codigo]= " & row("emp_codigo").ToString
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub vLista_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    Private Sub vCampos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "emp_codigo" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.dgPlantillaDetalle.DataSource.Compute("Count(emp_codigo)", "emp_codigo = '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                    If e.Value Is Nothing Then Exit Sub
                End If
            End If
        End If
     
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim tempDt As DataTable

        tempDt = Nothing
        'Los Deleted
        tempDt = Me.dgPlantillaDetalle.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.RH_OrganigramaDB.PlantillaDetalle_Add(tempDt.Rows(i)("emp_codigo"), _
                Me.TRubro, Rubro, tempDt.Rows(i)("rub_cuentaDebito").ToString, tempDt.Rows(i)("rub_cuentaCredito").ToString, _
                False)
            Next

        End If

        'Los Modificiados 
        tempDt = Me.dgPlantillaDetalle.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.RH_OrganigramaDB.PlantillaDetalle_Add(tempDt.Rows(i)("emp_codigo"), _
                Me.TRubro, Rubro, tempDt.Rows(i)("rub_cuentaDebito").ToString, tempDt.Rows(i)("rub_cuentaCredito").ToString, _
                tempDt.Rows(i)("activo"))
            Next

        End If
        'Los  agregados
        tempDt = Me.dgPlantillaDetalle.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.RH_OrganigramaDB.PlantillaDetalle_Add(tempDt.Rows(i)("emp_codigo"), _
                Me.TRubro, Rubro, tempDt.Rows(i)("rub_cuentaDebito").ToString, tempDt.Rows(i)("rub_cuentaCredito").ToString, _
                tempDt.Rows(i)("activo"))
            Next

        End If

        Me.Close()
    End Sub
End Class