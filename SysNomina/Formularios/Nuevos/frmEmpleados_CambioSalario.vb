Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Public Class frmEmpleados_CambioSalario

    Private Sub frmEmpleados_CambioSalario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
        If QuincenaTrabajo = "" Then
            Me.chkSalarioMinimo.EditValue = False
            Me.chkSalarioMinimo.Enabled = False
        Else
            Me.chkSalarioMinimo.Enabled = False
        End If
        Dim styleCondition As StyleFormatCondition = New StyleFormatCondition()
        vlista.FormatConditions.Add(styleCondition)
        styleCondition.Column = vlista.Columns("Cambiar")
        styleCondition.ApplyToRow = True
        styleCondition.Condition = FormatConditionEnum.Equal
        styleCondition.Value1 = True
        styleCondition.Appearance.BackColor = Color.FromArgb(128, 255, 128)
        styleCondition.Appearance.Font = New Font(vlista.Appearance.Row.Font, FontStyle.Bold)
        styleCondition.Appearance.ForeColor = Color.FromArgb(64, 64, 64)


    End Sub

    Private Sub cargar()
        Me.dgDatos.DataSource = VB.SysContab.EmpleadosDB.Empleados_SalarioMinimo()
        For i As Integer = 0 To Me.vlista.Columns.Count - 3
            Me.vlista.Columns(i).OptionsColumn.ReadOnly = True
            Me.vlista.Columns(i).OptionsColumn.AllowFocus = False
        Next
        Me.vlista.Columns("Area").Visible = False
        Me.vlista.Columns("Area").OptionsColumn.ShowInCustomizationForm = True

        Me.vlista.Columns("fIngreso").Visible = False
        Me.vlista.Columns("fIngreso").Caption = "Fecha Ingreso"
        Me.vlista.Columns("fIngreso").OptionsColumn.ShowInCustomizationForm = True

        Me.vlista.BestFitColumns()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        For i As Integer = 0 To Me.vlista.DataRowCount - 1
            If Me.vlista.GetRowCellValue(i, "Cambiar") = True Then
                Me.vlista.SetRowCellValue(i, "Nuevo Salario", Me.CalcEdit1.EditValue)
                Me.vlista.SetRowCellValue(i, "Cambiar", True)
            End If            
        Next

    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        For i As Integer = 0 To Me.vlista.DataRowCount - 1
            If Me.vlista.GetRowCellValue(i, "Cambiar") = True Then
                VB.SysContab.EmpleadosDB.Empleado_ActualizarSalario( _
                    Me.vlista.GetRowCellValue(i, "Codigo"), _
                    Me.vlista.GetRowCellValue(i, "Nuevo Salario"))
            End If
        Next

        'If Me.chkSalarioMinimo.EditValue = True Then
        '    VB.SysContab.PeriodoNominaDB.PeriodoNomina_ActualizarSalarioMinimo(Me.CalcEdit1.EditValue, QuincenaTrabajo)
        'End If

        Me.cargar()

    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        For i As Integer = 0 To Me.vlista.DataRowCount - 1
            Me.vlista.SetRowCellValue(i, "Cambiar", Me.chkTodos.EditValue)
        Next
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then Me.vLista.ColumnsCustomization() Else Me.vLista.DestroyCustomization()
    End Sub
End Class