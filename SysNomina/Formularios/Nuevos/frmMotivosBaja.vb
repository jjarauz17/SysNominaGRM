Public Class frmMotivosBaja 

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        'Guardar Tabla TipoSubsidio
        Dim tempdt As DataTable
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgMotivos.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                VB.SysContab.LiquidacionDB.Liquidacion_Causas_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("Descripcion"), tempdt.Rows(i)("Vacaciones"), _
                    tempdt.Rows(i)("Aguinaldo"), tempdt.Rows(i)("Indemnizacion"), tempdt.Rows(i)("Tipo_contrato"), 1)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgMotivos.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                VB.SysContab.LiquidacionDB.Liquidacion_Causas_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("Descripcion"), tempdt.Rows(i)("Vacaciones"), _
                    tempdt.Rows(i)("Aguinaldo"), tempdt.Rows(i)("Indemnizacion"), tempdt.Rows(i)("Tipo_contrato"), 0)
            Next

        End If
        'Los  agregados
        tempdt = Me.dgMotivos.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                VB.SysContab.LiquidacionDB.Liquidacion_Causas_Add(0, tempdt.Rows(i)("Descripcion"), tempdt.Rows(i)("Vacaciones"), _
                tempdt.Rows(i)("Aguinaldo"), tempdt.Rows(i)("Indemnizacion"), tempdt.Rows(i)("Tipo_contrato"), 0)

            Next

        End If
        cargar()
    End Sub

    Private Sub frmMotivosBaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()
    End Sub
    Private Sub cargar()

        Me.cbContratos.DataSource = VB.SysContab.EmpleadosDB.RH_TipoContrato
        Me.cbContratos.DisplayMember = "Descripcion"
        Me.cbContratos.ValueMember = "Tipo"

        Me.dgMotivos.DataSource = VB.SysContab.LiquidacionDB.Liquidacion_Causas(0, "%")
        For i As Integer = 0 To Me.vlista.Columns.Count - 1
            Me.vlista.Columns(i).OptionsColumn.AllowEdit = IIf(i = 0, False, True)
            Me.vlista.Columns(i).OptionsColumn.AllowFocus = IIf(i = 0, False, True)
        Next

        Me.vlista.Columns("Tipo_contrato").ColumnEdit = Me.cbContratos
    End Sub
    Private Sub dgMotivos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgMotivos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vlista.DeleteRow(Me.vlista.FocusedRowHandle)
        End If
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub


    Private Sub vlista_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vlista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "Descripcion" Then
            e.Valid = Not e.Value Is Nothing
        End If
        If sender.focusedcolumn.fieldname = "Aguinaldo" Then
            e.Valid = Not e.Value Is Nothing
        End If
        If sender.focusedcolumn.fieldname = "Indemnizacion" Then
            e.Valid = Not e.Value Is Nothing
        End If
        If sender.focusedcolumn.fieldname = "Vacaciones" Then
            e.Valid = Not e.Value Is Nothing
        End If
        If sender.focusedcolumn.fieldname = "Tipo_contrato" Then
            e.Valid = Not e.Value Is Nothing
        End If
    End Sub
End Class