Imports DbConnect

Public Class frmDeduccion_Pagos

    Private Sub frmDeduccion_Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTDeduccion.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTDeduccion.Properties.DisplayMember = "Descripcion"
        Me.cbTDeduccion.Properties.ValueMember = "Codigo"

        Me.cbFormaPago.EditValue = "QUINCENAL"

    End Sub

    Private Sub cargar()
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("TipoDeduccion", SqlDbType.NVarChar, 3, ParameterDirection.Input, Me.cbTDeduccion.EditValue)
        v.AddParameter("FormaPago", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.cbFormaPago.EditValue)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Hasta", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, _
            VB.SysContab.PeriodoNominaDB.GetDetails(VB.SysContab.PeriodoNominaDB.Ultima_Nomina_Procesada("Q")).FFinal)
        Try
            Me.dgLista.DataSource = v.EjecutarComando("_RH_Exportar_a_Pagos", "Datos")

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.dgLista.DataSource = Nothing
        End Try


        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.cbTipoDeduccion.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTipoDeduccion.ValueMember = "Codigo"
        Me.cbTipoDeduccion.DisplayMember = "Descripcion"

        cbMonedas.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMonedas.ValueMember = "Codigo"
        cbMonedas.DisplayMember = "Descripcion"

        Me.vLista.Columns("Empleado").ColumnEdit = Me.cbEmpleados
        Me.vLista.Columns("Tipo Deduccion").ColumnEdit = Me.cbTipoDeduccion
        Me.vLista.Columns("Moneda").ColumnEdit = Me.cbMonedas
        Me.vLista.BestFitColumns()

    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim dt As New DataTable("Pagos")

        'dt.Columns.Add("Cedula", System.Type.GetType("System.String"))
        'dt.Columns.Add("Liquidado", System.Type.GetType("System.Int32"))
        'dt.Columns.Add("Monto", System.Type.GetType("System.Decimal"))

        dt.Columns.Add("Nombre", System.Type.GetType("System.String"))
        dt.Columns.Add("Codigo", System.Type.GetType("System.String"))
        dt.Columns.Add("Monto", System.Type.GetType("System.Decimal"))

        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            Dim fila As DataRow = dt.NewRow
            'fila("Cedula") = Me.vLista.GetRowCellValue(i, "Cedula")
            'fila("Liquidado") = Me.vLista.GetRowCellValue(i, "Liquidado")
            'fila("Monto") = Me.vLista.GetRowCellValue(i, "Saldo$")

            fila("Nombre") = Me.vLista.GetRowCellValue(i, "Nombre")
            fila("Codigo") = Me.vLista.GetRowCellValue(i, "Codigo")
            fila("Monto") = Me.vLista.GetRowCellValue(i, "Saldo$")


            dt.Rows.Add(fila)
            fila = Nothing
        Next
        
        Me.SFD.InitialDirectory = Application.StartupPath()
        Me.SFD.Filter = "XML Files (*.xml)|*.xml"
        Me.SFD.FilterIndex = 1
        Me.SFD.RestoreDirectory = True
        Me.SFD.FileName = Application.StartupPath() & "\exportfiles\pagos.xml"
        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                dt.WriteXml(Me.SFD.FileName) ', XmlWriteMode.WriteSchema)
            Catch Ex As Exception
                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally

            End Try
        End If


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbTDeduccion_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTDeduccion.EditValueChanged
        Me.cargar()
    End Sub
End Class