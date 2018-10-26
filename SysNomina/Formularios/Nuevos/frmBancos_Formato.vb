Public Class frmBancos_Formato 
    Private _Banco As Integer = 0
    Public Sub Abrir(ByRef Banco As Integer)
        _Banco = Banco
        Me.ShowDialog()
        Banco = _Banco
    End Sub
    Private Sub frmBancos_Formato_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()

    End Sub
    Private Sub cargar()

        Me.cbMuestras.DataSource = RH_Bancos.GetList_Muestras(0)
        Me.cbMuestras.DisplayMember = "id_muestra"
        Me.cbMuestras.ValueMember = "id_muestra"

        Me.dgDatos.DataSource = RH_Bancos.GetList_Formatos(0, _Banco)
        Me.vLista.Columns("id").OptionsColumn.AllowEdit = False
        Me.vLista.Columns("id").OptionsColumn.AllowFocus = False
        Me.vLista.Columns("bco_codigo").Visible = False
        Me.vLista.Columns("id_muestra").ColumnEdit = Me.cbMuestras
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim tempDt As New DataTable
        'Los Deleted
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Deleted)
        If Not tempDt Is Nothing Then
            tempDt.RejectChanges()
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("id") Is DBNull.Value Then
                    RH_Bancos.AddFormato(tempDt.Rows(i)("id"), tempDt.Rows(i)("bco_codigo"), tempDt.Rows(i)("id_muestra"), True)
                End If
            Next

        End If

        'Los Modificados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Modified)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("id") Is DBNull.Value Then
                    RH_Bancos.AddFormato(tempDt.Rows(i)("id"), tempDt.Rows(i)("bco_codigo"), tempDt.Rows(i)("id_muestra"), False)
                End If
            Next

        End If

        'Los agregados
        tempDt = Me.dgDatos.DataSource.getchanges(DataRowState.Added)
        If Not tempDt Is Nothing Then
            For i As Integer = 0 To tempDt.Rows.Count - 1
                If Not tempDt.Rows(i)("id_muestra") Is DBNull.Value Then
                    RH_Bancos.AddFormato(0, _Banco, tempDt.Rows(i)("id_muestra"), False)
                End If
            Next

        End If

        cargar()
    End Sub

    Private Sub cbMuestras_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbMuestras.ButtonClick
        If e.Button.Index = 1 Then
            MsgBox("Aun no se han cargado los archivos de muestra")
            Exit Sub
        End If
    End Sub
End Class