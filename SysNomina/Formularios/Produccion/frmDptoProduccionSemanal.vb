Public Class frmDptoProduccionSemanal


    Private Sub frmDptoProduccionSemanal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Cargar()

    End Sub


    Private Sub Cargar()
        Me.cbAreas.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
        Me.cbAreas.ValueMember = "Area"
        Me.cbAreas.DisplayMember = "Descripcion"

        Me.Areas.DataSource = VB.SysContab.AreaDB.RH_Prod_Area(0)
        For i As Integer = 0 To Me.vLista.Columns.Count - 1
            If Me.vLista.Columns(i).FieldName = "area" Or _
                Me.vLista.Columns(i).FieldName = "min_produccion" Or _
                Me.vLista.Columns(i).FieldName = "max_produccion" Then
                Me.vLista.Columns(i).Visible = True
            Else
                Me.vLista.Columns(i).Visible = False
            End If

        Next

        Me.vLista.Columns("area").Visible = True
        Me.vLista.Columns("area").Caption = "Area"

        Me.vLista.Columns("min_produccion").Visible = True
        Me.vLista.Columns("min_produccion").ColumnEdit = Me.minimo
        Me.vLista.Columns("min_produccion").Caption = "Minimo Produccion"

        Me.vLista.Columns("max_produccion").Visible = True
        Me.vLista.Columns("max_produccion").ColumnEdit = Me.maximo
        Me.vLista.Columns("max_produccion").Caption = "Maximo Produccion"

        Me.vLista.Columns("area").ColumnEdit = Me.cbAreas

    End Sub


    Private Sub vCampos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vLista.CellValueChanged
        If e.Column.FieldName = "area" Then
            Me.vLista.Columns("min_produccion").OptionsColumn.ReadOnly = False
            Me.vLista.Columns("max_produccion").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vCampos_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vLista.InitNewRow
        Me.vLista.Columns("min_produccion").OptionsColumn.ReadOnly = True
        Me.vLista.Columns("max_produccion").OptionsColumn.ReadOnly = True
    End Sub

    Dim clone As DataView
    Private Sub vCampos_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.ShownEditor
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Vista = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If Vista.FocusedColumn.FieldName = "vLista" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("area") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone.RowFilter = "[area]= " & row("area").ToString
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub vCampos_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub vCampos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "area" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.Areas.DataSource.Compute("Count(area)", "area = '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                    If e.Value Is Nothing Then Exit Sub
                    'dtValores.DefaultView.RowFilter = "id = " & "'" & e.Value & "'"
                End If
            End If
        End If
        If sender.focusedcolumn.fieldname = "min_produccion" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            ElseIf e.Value <= 0 Then
                MsgBox("No se puede dejar un valor negativo para este campo", , "Sts.Nomina")
                e.Valid = False
            End If
        End If

        If sender.focusedcolumn.fieldname = "max_produccion" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            ElseIf e.Value <= 0 Then
                MsgBox("No se puede dejar un valor negativo para este campo", , "Sts.Nomina")
                e.Valid = False
            End If
        End If


    End Sub
    Private Sub areas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Areas.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempDt As DataTable
        tempDt = Nothing
        'Los Deleted
        tempDt = Me.Areas.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.AreaDB.RH_Prod_Area_Del(tempDt.Rows(i)("id"))
            Next

        End If

        'Los Modificiados Modificados
        tempDt = Me.Areas.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.AreaDB.RH_Prod_Area_Add(tempDt.Rows(i)("id"), _
                    tempDt.Rows(i)("empr_codigo"), _
                    tempDt.Rows(i)("dep_codigo"), _
                    tempDt.Rows(i)("are_codigo"), _
                    tempDt.Rows(i)("min_produccion"), _
                    tempDt.Rows(i)("max_produccion"))
            Next

        End If
        'Los  agregados
        tempDt = Me.Areas.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                VB.SysContab.AreaDB.RH_Prod_Area_Add(0, _
                   EmpresaActual, _
                   Me.cbAreas.GetDataSourceRowByKeyValue(tempDt.Rows(i)("area"))("dep_codigo"), _
                   Me.cbAreas.GetDataSourceRowByKeyValue(tempDt.Rows(i)("area"))("are_codigo"), _
                   tempDt.Rows(i)("min_produccion"), _
                   tempDt.Rows(i)("max_produccion"))

                'tempDt.Rows(i)("area").ToString.Substring(0, 4), _
                'tempDt.Rows(i)("area").ToString.Substring(5, 3), _
            Next

        End If
        Me.Close()
    End Sub
End Class