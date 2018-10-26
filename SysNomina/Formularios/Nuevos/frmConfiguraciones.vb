Public Class frmConfiguraciones 
    Private Crear_Registro As Boolean = False
    Private Tabla As Integer = 0
    Private Sub frmConfiguraciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dFecha.EditValue = Now
        'Cargar rh_configuraciones
        Cargar_Configuraciones()

        'Cargar rh_regimenINSS
        Cargar_INSS()

        'Cargar rh_IR
        Cargar_IR()

        'Cargar rh_tiposubsidio
        Cargar_TipoSubsidio()
    End Sub
    Private Sub Cargar_TipoSubsidio()
        Me.cbtdi_emp.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        Me.cbtdi_emp.ValueMember = "Codigo"
        Me.cbtdi_emp.DisplayMember = "Descripcion"

        Me.cbtdi_empr.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        Me.cbtdi_empr.ValueMember = "Codigo"
        Me.cbtdi_empr.DisplayMember = "Descripcion"


        Me.dgTipoSubsidio.DataSource = RH_TipoSubsidio.RH_GetList(0)
        If Not Me.dgTipoSubsidio.DataSource Is Nothing Then
            Me.vTipoSubsidio.Columns(0).OptionsColumn.AllowEdit = False
            Me.vTipoSubsidio.Columns(0).OptionsColumn.AllowFocus = False

            Me.vTipoSubsidio.Columns("tds_descripcion").Caption = "Descripcion"
            Me.vTipoSubsidio.Columns("emp_porcentaje").Caption = "Porcentaje paga el INSS"
            Me.vTipoSubsidio.Columns("tdi_emp").Caption = "Rubro Ingreso pagado por INSS"
            Me.vTipoSubsidio.Columns("tdi_emp").ColumnEdit = Me.cbtdi_emp
            Me.vTipoSubsidio.Columns("empr_porcentaje").Caption = "Porcentaje paga Empresa"
            Me.vTipoSubsidio.Columns("tdi_empr").Caption = "Rubro Ingreso pagado por Empresa"
            Me.vTipoSubsidio.Columns("tdi_empr").ColumnEdit = Me.cbtdi_empr
            Me.vTipoSubsidio.Columns("empr_codigo").Visible = False

        End If
    End Sub

    Private Sub Cargar_Configuraciones()
        Dim d As RH_Configuraciones
        d = RH_ConfiguracionesDB.Detalles()
        If d Is Nothing Then
            Me.Crear_Registro = MsgBox("No hay registro de configuracion, desea crearlo?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.Yes
        Else
            Me.chk_contabVacaciones.EditValue = d.Vacaciones_Descansadas
            Me.chkPagarSubsidio.EditValue = d.Asumir_Subsidio
            Me.CalcEdit1.EditValue = d.Carencia
            Me.chk_GenRedondeos.EditValue = d.Gen_redondeos
            Me.chk_GenSobregiros.EditValue = d.Gen_Sobregiros
            Me.chk_PFCalendario.EditValue = d.Calendario
        End If
    End Sub
    Private Sub Cargar_INSS()
        Me.dgINSS.DataSource = RegimenINSSDB.GetList(0)
        If Not Me.dgINSS.DataSource Is Nothing Then
            Me.vINSS.Columns("reg_codigo").Caption = "ID"
            Me.vINSS.Columns("reg_codigo").Visible = False
            Me.vINSS.Columns("reg_descripcion").Caption = "Descripcion"
            Me.vINSS.Columns("reg_insslaboral").Caption = "Porcentaje Laboral"
            Me.vINSS.Columns("reg_insslaboral").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vINSS.Columns("reg_insslaboral").DisplayFormat.FormatString = "n2"
            Me.vINSS.Columns("reg_insspatronal").Caption = "Porcentaje Patronal"
            Me.vINSS.Columns("reg_insspatronal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vINSS.Columns("reg_insspatronal").DisplayFormat.FormatString = "n2"
            Me.vINSS.Columns("reg_minimo").Caption = "Minimo"
            Me.vINSS.Columns("reg_minimo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vINSS.Columns("reg_minimo").DisplayFormat.FormatString = "n2"
            Me.vINSS.Columns("reg_maximo").Caption = "Maximo"
            Me.vINSS.Columns("reg_maximo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vINSS.Columns("reg_maximo").DisplayFormat.FormatString = "n2"
        End If
    End Sub
    Private Sub Cargar_IR()

        Me.cbTipoIR.DataSource = RH_IR.Tipo
        Me.cbTipoIR.DisplayMember = "descripcion"
        Me.cbTipoIR.ValueMember = "codigo"

        Me.dgIR.DataSource = RH_IR.List(0, dFecha.EditValue, Tabla)
        If Not Me.dgIR.DataSource Is Nothing Then
            Me.vIR.Columns("ID").Visible = False
            Me.vIR.Columns("ir_codigo").Caption = "ID"
            Me.vIR.Columns("ir_codigo").Visible = False
            Me.vIR.Columns("ir_desde").Caption = "Desde C$"
            Me.vIR.Columns("ir_desde").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vIR.Columns("ir_desde").DisplayFormat.FormatString = "n2"
            Me.vIR.Columns("ir_hasta").Caption = "Hasta C$"
            Me.vIR.Columns("ir_hasta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vIR.Columns("ir_hasta").DisplayFormat.FormatString = "n2"
            Me.vIR.Columns("ir_tipo").Caption = "Tipo Impuesto"
            Me.vIR.Columns("ir_tipo").ColumnEdit = Me.cbTipoIR
            Me.vIR.Columns("ir_porcentaje").Caption = "Porcentaje"
            Me.vIR.Columns("ir_porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vIR.Columns("ir_porcentaje").DisplayFormat.FormatString = "n2"
            Me.vIR.Columns("ir_base").Caption = "Base Imponible"
            Me.vIR.Columns("ir_base").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vIR.Columns("ir_base").DisplayFormat.FormatString = "n2"
            Me.vIR.Columns("ir_exceso").Caption = "Exceso"
            Me.vIR.Columns("ir_exceso").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vIR.Columns("ir_exceso").DisplayFormat.FormatString = "n2"

        End If
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar_C.Click
        'Guardar Configuraciones
        RH_ConfiguracionesDB.ADD(Me.chk_contabVacaciones.EditValue, Me.chkPagarSubsidio.EditValue, Me.CalcEdit1.EditValue, _
                                 Crear_Registro, Me.chk_GenRedondeos.EditValue, Me.chk_GenSobregiros.EditValue, _
                                 Me.chk_PFCalendario.EditValue)
    End Sub

    Private Sub cmdGuardar_I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar_I.Click
        'Guardar Tabla INSS
        Dim tempdt As DataTable
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgINSS.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RegimenINSSDB.ADD(tempdt.Rows(i)("reg_codigo"), tempdt.Rows(i)("reg_descripcion"), _
                    tempdt.Rows(i)("reg_insslaboral"), tempdt.Rows(i)("reg_insspatronal"), tempdt.Rows(i)("reg_minimo"), _
                    tempdt.Rows(i)("reg_maximo"), tempdt.Rows(i)("reg_subsidioINSS"), tempdt.Rows(i)("reg_patronal"), tempdt.Rows(i)("reg_nominaINSS"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgINSS.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RegimenINSSDB.ADD(tempdt.Rows(i)("reg_codigo"), tempdt.Rows(i)("reg_descripcion"), _
                    tempdt.Rows(i)("reg_insslaboral"), tempdt.Rows(i)("reg_insspatronal"), tempdt.Rows(i)("reg_minimo"), _
                    tempdt.Rows(i)("reg_maximo"), tempdt.Rows(i)("reg_subsidioINSS"), tempdt.Rows(i)("reg_patronal"), tempdt.Rows(i)("reg_nominaINSS"), False)
            Next

        End If
        'Los  agregados
        tempdt = Me.dgINSS.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RegimenINSSDB.ADD(0, tempdt.Rows(i)("reg_descripcion"), _
                    tempdt.Rows(i)("reg_insslaboral"), tempdt.Rows(i)("reg_insspatronal"), tempdt.Rows(i)("reg_minimo"), _
                    tempdt.Rows(i)("reg_maximo"), tempdt.Rows(i)("reg_subsidioINSS"), tempdt.Rows(i)("reg_patronal"), tempdt.Rows(i)("reg_nominaINSS"), False)
            Next

        End If
        Me.Cargar_INSS()
    End Sub

    Private Sub cmdGuardar_IR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar_IR.Click
        'Guardar Tabla IR
        Dim tempdt As DataTable
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgIR.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_IR.ADD(tempdt.Rows(i)("ir_codigo"), tempdt.Rows(i)("ir_desde"), _
                    tempdt.Rows(i)("ir_hasta"), tempdt.Rows(i)("ir_tipo"), tempdt.Rows(i)("ir_porcentaje"), _
                    tempdt.Rows(i)("ir_base"), tempdt.Rows(i)("ir_exceso"), _
                    If(tempdt.Rows(i)("ir_codigo") = 0, Tabla, tempdt.Rows(i)("ir_codigo")), _
                    True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgIR.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_IR.ADD(tempdt.Rows(i)("ir_codigo"), tempdt.Rows(i)("ir_desde"), _
                    tempdt.Rows(i)("ir_hasta"), tempdt.Rows(i)("ir_tipo"), tempdt.Rows(i)("ir_porcentaje"), _
                    tempdt.Rows(i)("ir_base"), tempdt.Rows(i)("ir_exceso"), _
                    If(tempdt.Rows(i)("ir_codigo") = 0, Tabla, tempdt.Rows(i)("ir_codigo")), _
                    False)
            Next

        End If
        'Los  agregados
        tempdt = Me.dgIR.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_IR.ADD(0, tempdt.Rows(i)("ir_desde"), _
                        tempdt.Rows(i)("ir_hasta"), tempdt.Rows(i)("ir_tipo"), tempdt.Rows(i)("ir_porcentaje"), _
                        tempdt.Rows(i)("ir_base"), tempdt.Rows(i)("ir_exceso"), _
                    If(IsNull(tempdt.Rows(i)("ir_codigo"), 0) = 0, Tabla, tempdt.Rows(i)("ir_codigo")), _
                    False)
            Next

        End If
        Me.Cargar_INSS()
    End Sub

    Private Sub vINSS_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vINSS.ValidatingEditor
        If sender.focusedcolumn.fieldname = "reg_insslaboral" Then
            If Not e.Value Is Nothing Then
                If e.Value = "" Then
                    MsgBox("El porcentaje de INSS Laboral debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                ElseIf e.Value <= 0 Then
                    MsgBox("El porcentaje de INSS Laboral debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If

        If sender.focusedcolumn.fieldname = "reg_insspatronal" Then
            If Not e.Value Is Nothing Then
                If e.Value <= 0 Then
                    MsgBox("El porcentaje de INSS Patronal debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If

        If sender.focusedcolumn.fieldname = "reg_descripcion" Then
            If Not e.Value Is Nothing Then
                If e.Value = "" Then
                    MsgBox("Digite la descripcion por favor", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If

        If sender.focusedcolumn.fieldname = "reg_minimo" Then
            If Not e.Value Is Nothing Then
                If e.Value <= 0 Then
                    MsgBox("El Salario Minimo debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "reg_maximo" Then
            If Not e.Value Is Nothing Then
                If e.Value <= 0 Then
                    MsgBox("El Salario Maximo debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If

    End Sub

    Private Sub dgINSS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgINSS.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vINSS.DeleteRow(Me.vINSS.FocusedRowHandle)
        End If
    End Sub

    Private Sub vINSS_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vINSS.CellValueChanged
        If e.Column.FieldName = "reg_descripcion" Then
            Me.vINSS.Columns("reg_insslaboral").OptionsColumn.ReadOnly = False
            Me.vINSS.Columns("reg_insspatronal").OptionsColumn.ReadOnly = False
            Me.vINSS.Columns("reg_minimo").OptionsColumn.ReadOnly = False
            Me.vINSS.Columns("reg_maximo").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vINSS_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vINSS.InitNewRow
        Me.vINSS.Columns("reg_insslaboral").OptionsColumn.ReadOnly = True
        Me.vINSS.Columns("reg_insspatronal").OptionsColumn.ReadOnly = True
        Me.vINSS.Columns("reg_minimo").OptionsColumn.ReadOnly = True
        Me.vINSS.Columns("reg_maximo").OptionsColumn.ReadOnly = True
    End Sub


    ''''''''''''''''
    Private Sub vIR_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vIR.ValidatingEditor
        If sender.focusedcolumn.fieldname = "ir_desde" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("La Columna DESDE debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "ir_hasta" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("La Columna HASTA debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "ir_tipo" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("Seleccion el Tipo de IR por favor", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "ir_porcentaje" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("La Columna de Porcentaje debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "ir_base" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("La Columba de BASE IMPONIBLE debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If
        If sender.focusedcolumn.fieldname = "ir_exceso" Then
            If Not e.Value Is Nothing Then
                If e.Value < 0 Then
                    MsgBox("La Columba de EXCESO debe ser un numero positivo", , " StS.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                End If
                If e.Value Is Nothing Then Exit Sub
            End If
        End If

    End Sub

    Private Sub dgIR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIR.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vIR.DeleteRow(Me.vIR.FocusedRowHandle)
        End If
    End Sub

    Private Sub vIR_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vIR.CellValueChanged
        If e.Column.FieldName = "ir_desde" Then
            Me.vIR.Columns("ir_hasta").OptionsColumn.ReadOnly = False
            Me.vIR.Columns("ir_tipo").OptionsColumn.ReadOnly = False
            Me.vIR.Columns("ir_porcentaje").OptionsColumn.ReadOnly = False
            Me.vIR.Columns("ir_base").OptionsColumn.ReadOnly = False
            Me.vIR.Columns("ir_exceso").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vIR_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vIR.InitNewRow
        Me.vIR.Columns("ir_hasta").OptionsColumn.ReadOnly = True
        Me.vIR.Columns("ir_tipo").OptionsColumn.ReadOnly = True
        Me.vIR.Columns("ir_porcentaje").OptionsColumn.ReadOnly = True
        Me.vIR.Columns("ir_base").OptionsColumn.ReadOnly = True
        Me.vIR.Columns("ir_exceso").OptionsColumn.ReadOnly = True

    End Sub


    Private Sub dFecha_EditValueChanged(sender As Object, e As EventArgs) Handles dFecha.EditValueChanged

    End Sub

    Private Sub TSGuardar_Click(sender As Object, e As EventArgs) Handles TSGuardar.Click

        'Guardar Tabla TipoSubsidio
        Dim tempdt As DataTable
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgTipoSubsidio.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_TipoSubsidio.RH_TipoSubsidioADD(tempdt.Rows(i)("id"), tempdt.Rows(i)("tds_descripcion"), _
                    tempdt.Rows(i)("emp_porcentaje"), tempdt.Rows(i)("tdi_emp"), tempdt.Rows(i)("empr_porcentaje"), _
                    tempdt.Rows(i)("tdi_empr"), tempdt.Rows(i)("empr_codigo"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgTipoSubsidio.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_TipoSubsidio.RH_TipoSubsidioADD(tempdt.Rows(i)("id"), tempdt.Rows(i)("tds_descripcion"), _
                    tempdt.Rows(i)("emp_porcentaje"), tempdt.Rows(i)("tdi_emp"), tempdt.Rows(i)("empr_porcentaje"), _
                    tempdt.Rows(i)("tdi_empr"), tempdt.Rows(i)("empr_codigo"), False)
            Next

        End If
        'Los  agregados
        tempdt = Me.dgTipoSubsidio.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                RH_TipoSubsidio.RH_TipoSubsidioADD(0, tempdt.Rows(i)("tds_descripcion"), _
                    tempdt.Rows(i)("emp_porcentaje"), tempdt.Rows(i)("tdi_emp"), tempdt.Rows(i)("empr_porcentaje"), _
                    tempdt.Rows(i)("tdi_empr"), EmpresaActual, False)
            Next

        End If
        Me.Cargar_TipoSubsidio()
    End Sub
End Class