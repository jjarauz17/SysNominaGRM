Public Class frmAgregarPeriodoFiscal

#Region "Variables"
    Public Modo As Boolean = False 'Falso, es agregar
    Public ID As Integer = 0
    Dim t As Integer = 0
#End Region
    Private Sub frmAgregarPeriodoFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Modo Then
            'Agregando
            Dim desde, hasta As Date
            VB.SysContab.PeriodosDB.Fechas(desde, hasta, RH_ConfiguracionesDB.Detalles().Calendario)
            Me.dtpDesde.EditValue = desde
            Me.dtpHasta.EditValue = hasta
            Me.txtDescripcion.Text = ""
            If desde < hasta Then
                Me.dtpDesde.Enabled = False
                Me.dtpHasta.Enabled = False
            Else
                Me.dtpDesde.Enabled = True
                Me.dtpHasta.Enabled = True
            End If
            desde = Nothing
            hasta = Nothing

        Else
            'Modificando
            Dim detalles As New VB.SysContab.PeriodoDetails
            detalles = VB.SysContab.PeriodosDB.GetDetails(ID)
            Me.dtpDesde.EditValue = detalles.Inicio
            Me.dtpHasta.EditValue = detalles.Final
            Me.txtDescripcion.Text = detalles.Descripcion
            Me.dtpDesde.Enabled = False
            Me.dtpHasta.Enabled = False
            Me.gcDatos.DataSource = VB.SysContab.PeriodosDB.GetList_Detalle(ID)
            Me.vLista.Columns("per_detalle").Caption = "Consecutivo"
            Me.vLista.Columns("empr_codigo").Visible = False
            Me.vLista.Columns("per_ID").Visible = False
            Me.vLista.Columns("per_inicio").Caption = "Fecha Inicio"
            Me.vLista.Columns("per_final").Caption = "Fecha Final"
            Me.vLista.Columns("ID_Tabla").Caption = "ID Tabla de IR"
            Me.vLista.BestFitColumns()


        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Modo = False Then 'Agregando
            VB.SysContab.PeriodosDB.Agregar(Me.dtpDesde.EditValue, Me.dtpHasta.EditValue, Me.txtDescripcion.Text, t)
        Else
            VB.SysContab.PeriodosDB.Actualizar(ID, Me.dtpDesde.EditValue, Me.dtpHasta.EditValue, Me.txtDescripcion.Text)
            For i As Integer = 0 To Me.vLista.DataRowCount - 1
                VB.SysContab.PeriodosDB.Detalle_Actualizar(Me.vLista.GetRowCellValue(i, "per_detalle"), Me.vLista.GetRowCellValue(i, "ID_Tabla"))
            Next
        End If
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.vLista.FocusedRowHandle >= 0 Then

            Tabla_IR.Dispose()
            Tabla_IR.Abrir(t)
            Me.vLista.SetFocusedRowCellValue("ID_Tabla", t)
        End If
    End Sub
End Class