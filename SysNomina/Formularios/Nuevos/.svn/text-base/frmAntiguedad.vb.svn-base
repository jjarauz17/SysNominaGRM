Public Class frmAntiguedad 

    Private Grabando As Boolean = False
    Private Sub frmAntiguedad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub

    Private Sub cargar()
        Me.dgDatos.DataSource = rh_antiguedadDB.Get_List
        Me.vLista.Columns("Años").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Años").DisplayFormat.FormatString = "n0"

        Me.vLista.Columns("Porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Porcentaje").DisplayFormat.FormatString = "n2"


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub vlista_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "Años" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.dgDatos.DataSource.Compute("Count(Años)", "Años= '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    If e.Value <= 0 Then
                        MsgBox("Los años deben ser numeros enteros positivos", , " StS.Nomina")
                        e.Valid = False
                    Else
                        e.Valid = True
                    End If

                    If e.Value Is Nothing Then Exit Sub
                End If
            End If
        End If
        If sender.focusedcolumn.fieldname = "Porcentaje" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            Else
                If Not Me.vLista.Columns("Porcentaje").SummaryItem.SummaryValue Is Nothing Then
                    If Me.vLista.Columns("Porcentaje").SummaryItem.SummaryValue + IIf(Me.Grabando = True, e.Value, 0) < 0 Then
                        MsgBox("No puede asignar % menor que cero")
                        e.Valid = False
                    End If
                Else
                    e.Valid = True
                End If
            End If
            Me.Grabando = False
        End If

    End Sub

    Private Sub dgDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub vLista_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vLista.CellValueChanged
        If e.Column.FieldName = "Años" Then
            Me.vLista.Columns("Porcentaje").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vLista_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vLista.InitNewRow
        Me.vLista.Columns("Porcentaje").OptionsColumn.ReadOnly = True
        Me.Grabando = True
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempdt As DataTable

        ''RH_Antiguedad Detalle
        tempDt = Nothing
        'Los Deleted
        tempdt = Me.dgDatos.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                rh_antiguedadDB.Add(tempdt.Rows(i)("Años"), tempdt.Rows(i)("Porcentaje"), 2)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgDatos.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                rh_antiguedadDB.Add(tempdt.Rows(i)("Años"), tempdt.Rows(i)("Porcentaje"), 1)
            Next

        End If
        'Los  agregados
        tempdt = Me.dgDatos.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                rh_antiguedadDB.Add(tempdt.Rows(i)("Años"), tempdt.Rows(i)("Porcentaje"), 0)
            Next

        End If
    End Sub
End Class