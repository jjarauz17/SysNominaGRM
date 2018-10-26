Public Class frmBancos 

    Private Sub Cargar()
        Me.cbSIB.DataSource = RH_Bancos.GetListSIB()
        Me.cbSIB.DisplayMember = "Nombre"
        Me.cbSIB.ValueMember = "Codigo"

        Me.dgDatos.DataSource = RH_Bancos.GetList(0)
        Me.vLista.Columns("bco_SIB").ColumnEdit = Me.cbSIB
        Me.vLista.Columns("bco_codigo").OptionsColumn.AllowFocus = False
        Me.vLista.Columns("bco_codigo").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("empr_codigo").Visible = False
    End Sub

    Private Sub frmBancos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Cargar()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    

    Private Sub dgDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim tempDt As New DataTable
        'Los Deleted
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("bco_codigo") Is DBNull.Value Then
                    RH_Bancos.Add(tempDt.Rows(i)("bco_codigo"), tempDt.Rows(i)("bco_descripcion"), _
                                  tempDt.Rows(i)("bco_SIB"), tempDt.Rows(i)("bco_cuentacontable"), True, _
                                  tempDt.Rows(i)("bco_codplanilla"), tempDt.Rows(i)("bco_consecutivo"))
                End If
            Next

        End If

        'Los Modificados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("bco_codigo") Is DBNull.Value Then
                    RH_Bancos.Add(tempDt.Rows(i)("bco_codigo"), tempDt.Rows(i)("bco_descripcion"), _
                                  tempDt.Rows(i)("bco_SIB"), tempDt.Rows(i)("bco_cuentacontable"), False, _
                                  tempDt.Rows(i)("bco_codplanilla"), tempDt.Rows(i)("bco_consecutivo"))
                End If
            Next

        End If

        'Los agregados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If tempDt.Rows(i)("bco_codigo") Is DBNull.Value Then
                    RH_Bancos.Add(0, tempDt.Rows(i)("bco_descripcion"), _
                                  tempDt.Rows(i)("bco_SIB"), IsNull(tempDt.Rows(i)("bco_cuentacontable"), ""), False, _
                                  tempDt.Rows(i)("bco_codplanilla"), tempDt.Rows(i)("bco_consecutivo"))
                End If
            Next

        End If

        Cargar()
    End Sub

    Private Sub cmdFormato_Click(sender As Object, e As EventArgs) Handles cmdFormato.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay nada que asignar")
            Exit Sub
        End If
        frmBancos_Formato.Dispose()
        frmBancos_Formato.Abrir(Me.vLista.GetFocusedRowCellValue("bco_codigo"))
    End Sub
End Class