Imports System.IO

Public Class frmVacaciones
#Region "Variables"
    Dim bMasDatos As Boolean = False
    Friend WithEvents dVista As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dDVista As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTiposPermisos As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim lds, lds2 As New DataSet
    Dim cargado As Boolean = False
#End Region

    Private Sub frmVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Empleados As New VB.SysContab.EmpleadosDB()
        Me.dtpAl.EditValue = Now.Date

        Me.Cargar()
        Me.cargado = True
        Me.Text = "Vacaciones de Empleados"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        If QuincenaTrabajo = "" Then
            Me.cmdDias.Enabled = False
            Me.cmdFeriados.Enabled = False
            Me.cmdPagos.Enabled = False
        End If
        Me.Refresh()

    End Sub
    Public Sub Cargar()

        lds = New DataSet
        lds.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(Me.dtpAl.DateTime.Date)) 'Esta es la lista de empleados
        lds2 = VB.SysContab.PermisosDB.GetList("%", True, True, Me.dtpAl.DateTime.Date) 'Esta funcion devuelve dos tablas
        lds.Tables.Add(lds2.Tables(0).Copy) 'Copio la tabla 1 (Permisos) en el dataset lds 
        lds.Tables.Add(lds2.Tables(1).Copy) 'Copio la tabla 2 (Detalle de Permisos) en el dataset lds 
        lds2.Dispose()
        'Agrego la relacion Empleado Permisos
        Try
            lds.Relations.Add("Permisos", _
                       lds.Tables("Empleados").Columns("Codigo"), _
                       lds.Tables("Permisos").Columns("Empleado"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            'Agrego la relacion Permisos - Detalle Permisos
            lds.Relations.Add("PermisosDetalles", _
                        lds.Tables("Permisos").Columns("Codigo"), _
                        lds.Tables("PermisosDetalles").Columns("Codigo"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        dgEmpleados.DataSource = lds.Tables("Empleados")
        Me.VEmpleados.Columns("Departamento").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Departamento").Visible = False
        Me.VEmpleados.Columns("Direccion").Visible = False
        Me.VEmpleados.Columns("Telefono").Visible = False
        'Me.VEmpleados.Columns("Codigo").Width = 80
        'Me.VEmpleados.Columns("Nombre").Width = 250
        'Me.VEmpleados.Columns("Vacaciones").Width = 100
        'Me.VEmpleados.Columns("Dias Solicitados").Width = 100
        'Me.VEmpleados.Columns("Dias Procesados").Width = 100
        'Me.VEmpleados.Columns("Disponibles").Width = 100
        'Me.VEmpleados.Columns("Salario Promedio").Width = 100
        Me.VEmpleados.Columns("Salario Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Salario Promedio").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Salario Promedio").Visible = False
        Me.VEmpleados.Columns("Salario Promedio").OptionsColumn.ShowInCustomizationForm = True

        Me.VEmpleados.Columns("Vacaciones").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Vacaciones").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Pendientes de Acumular").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Pendientes de Acumular").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Solicitados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Solicitados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Procesados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Procesados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Sexto Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Sexto Dia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Septimo Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Septimo Dia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Descansados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Descansados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Vac. Pagadas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Vac. Pagadas").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Disponibles").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Disponibles").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("ValorDia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("ValorDia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("A Pagar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("A Pagar").DisplayFormat.FormatString = "n2"


        Me.VEmpleados.Columns("Desde").Visible = False
        Me.VEmpleados.Columns("Desde").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Hasta").Visible = False
        Me.VEmpleados.Columns("Hasta").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Fin de Periodo").Visible = False
        Me.VEmpleados.Columns("Fin de Periodo").OptionsColumn.ShowInCustomizationForm = True


        If Me.VEmpleados.DataRowCount <> 0 Then
            Registro = Me.VEmpleados.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
        Me.cbTiposPermisos.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables(0)
        Me.cbTiposPermisos.DisplayMember = "Descripcion"
        Me.cbTiposPermisos.ValueMember = "Codigo"

        For i As Integer = 0 To Me.VEmpleados.Columns.Count - 2
            Me.VEmpleados.Columns(i).OptionsColumn.ReadOnly = True
            Me.VEmpleados.Columns(i).OptionsColumn.AllowFocus = False
        Next

        Me.VEmpleados.BestFitColumns()

    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    'Private Sub cmdFeriados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFeriados.Click
    '    Dim forma As frmDarFeriados = frmDarFeriados.Instance
    '    frmDarFeriados.Todos = Me.ckbTodos.Checked
    '    forma.ShowDialog()
    'End Sub

    Private Sub cmdDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDias.Click
        Dim forma As frmDarDias = frmDarDias.Instance
        frmDarDias.Todos = Me.ckbTodos.Checked
        forma.ShowDialog()
    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        If Me.ckbTodos.Checked Then
            If Me.VEmpleados.ActiveFilterString <> "" Then
                Dim llds As New DataSet
                llds = lds.Clone

                Dim a, b, c As DataRow()
                a = lds.Tables("Empleados").Select(Me.VEmpleados.ActiveFilterString)
                For i As Integer = 0 To a.GetUpperBound(0)
                    llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                    b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                    For j As Integer = 0 To b.GetUpperBound(0)
                        llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                        c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                        For k As Integer = 0 To c.GetUpperBound(0)
                            llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                        Next
                    Next
                Next

                Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
                frmPagoVacaciones.Todos = Me.ckbTodos.Checked
                frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("Disponibles"))
                frmPagoVacaciones.Datos = llds.Tables("Empleados")
                forma.ShowDialog()
            Else
                Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
                frmPagoVacaciones.Todos = Me.ckbTodos.Checked
                frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("Disponibles"))
                frmPagoVacaciones.Datos = Me.VEmpleados.DataSource.table
                forma.ShowDialog()
            End If
        Else

            Dim llds As New DataSet
            llds = lds.Clone

            Dim a, b, c As DataRow()
            a = lds.Tables("Empleados").Select("[Codigo]='" & Me.VEmpleados.GetFocusedRowCellValue("Codigo") & "'")
            For i As Integer = 0 To a.GetUpperBound(0)
                llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                For j As Integer = 0 To b.GetUpperBound(0)
                    llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                    c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                    For k As Integer = 0 To c.GetUpperBound(0)
                        llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                    Next
                Next
            Next

            Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
            frmPagoVacaciones.Todos = Me.ckbTodos.Checked
            frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("A Pagar"))
            frmPagoVacaciones.Datos = llds.Tables("Empleados")
            forma.ShowDialog()

        End If

    End Sub

    Private Sub VEmpleados_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VEmpleados.CellValueChanged
        ''se lo quite a xerox, configurar mas tarde
        'If e.Column.FieldName = "A Pagar" Then
        '    If Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") < 0 And Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") <> 0 Then
        '        Me.VEmpleados.SetRowCellValue(e.RowHandle, "A Pagar", 0)
        '    ElseIf Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") <= e.Value And Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") <> Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") And Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") <> 0 Then
        '        Me.VEmpleados.SetRowCellValue(e.RowHandle, "A Pagar", Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles"))
        '    End If
        'End If
    End Sub



    Private Sub VEmpleados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VEmpleados.FocusedRowChanged
        Registro = Me.VEmpleados.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.dgEmpleados)
    End Sub

    Private Sub cmdMasDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMasDatos.Click
        If Me.bMasDatos = False Then
            Me.VEmpleados.ColumnsCustomization()
            Me.bMasDatos = True
        Else
            Me.VEmpleados.DestroyCustomization()
            Me.bMasDatos = False
        End If
    End Sub

    Private Sub VEmpleados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VEmpleados.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub


    Private Sub VEmpleados_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles VEmpleados.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dVista Is Nothing Then
                dVista.Columns("Codigo").Width = 100
                dVista.Columns("Codigo").OptionsColumn.ReadOnly = True

                dVista.Columns("Empleado").Visible = False

                dVista.Columns("HoraInicio").Width = 150
                dVista.Columns("HoraInicio").OptionsColumn.ReadOnly = True
                dVista.Columns("HoraInicio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dVista.Columns("HoraInicio").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"


                dVista.Columns("HoraFinal").Width = 150
                dVista.Columns("HoraFinal").OptionsColumn.ReadOnly = True
                dVista.Columns("HoraFinal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dVista.Columns("HoraFinal").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"

                dVista.Columns("Tipo").Width = 150
                dVista.Columns("Tipo").OptionsColumn.ReadOnly = True
                dVista.Columns("Tipo").ColumnEdit = Me.cbTiposPermisos

                dVista.Columns("Aplicado").Width = 80
                dVista.Columns("Aplicado").OptionsColumn.ReadOnly = True

                dVista.Columns("Periodo").Visible = False

                dVista.Columns("Dias Solicitados").Width = 80
                dVista.Columns("Dias Solicitados").OptionsColumn.ReadOnly = True
                dVista.Columns("Dias Solicitados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dVista.Columns("Dias Solicitados").DisplayFormat.FormatString = "n2"

                dVista.Columns("Dias Procesados").Width = 80
                dVista.Columns("Dias Procesados").OptionsColumn.ReadOnly = True
                dVista.Columns("Dias Procesados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dVista.Columns("Dias Procesados").DisplayFormat.FormatString = "n2"

            End If
        End If
    End Sub

    Private Sub dVista_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles dVista.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dDVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dDVista Is Nothing Then
                dDVista.Columns("Codigo").Width = 100
                dDVista.Columns("Codigo").OptionsColumn.ReadOnly = True

                dDVista.Columns("Periodo").Width = 100
                dDVista.Columns("Periodo").OptionsColumn.ReadOnly = True

                dDVista.Columns("Aplicado").Width = 100
                dDVista.Columns("Aplicado").OptionsColumn.ReadOnly = True

                dDVista.Columns("Cantidad").Width = 80
                dDVista.Columns("Cantidad").OptionsColumn.ReadOnly = True
                dDVista.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Cantidad").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Sexto Dia").Width = 80
                dDVista.Columns("Sexto Dia").OptionsColumn.ReadOnly = True
                dDVista.Columns("Sexto Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Sexto Dia").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Septimo Dia").Width = 80
                dDVista.Columns("Septimo Dia").OptionsColumn.ReadOnly = True
                dDVista.Columns("Septimo Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Septimo Dia").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Hasta").Width = 150
                dDVista.Columns("Hasta").OptionsColumn.ReadOnly = True
                dDVista.Columns("Hasta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dDVista.Columns("Hasta").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"

            End If
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If Me.ckbTodos.Checked Then
            If Me.VEmpleados.ActiveFilterString = "" Then
                lds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
                Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

                Dim visor As New frmReportes
                'Dim reporte As New rptVacaciones
                Dim reporte As Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                    Exit Sub
                End If
                reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

                visor.crvReportes.ReportSource = reporte
                visor.ShowDialog()
            Else
                Dim llds As New DataSet
                llds = lds.Clone

                Dim a, b, c As DataRow()
                a = lds.Tables("Empleados").Select(Me.VEmpleados.ActiveFilterString)
                For i As Integer = 0 To a.GetUpperBound(0)
                    llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                    b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                    For j As Integer = 0 To b.GetUpperBound(0)
                        llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                        c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                        For k As Integer = 0 To c.GetUpperBound(0)
                            llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                        Next
                    Next
                Next

                llds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
                Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

                Dim visor As New frmReportes
                'Dim reporte As New rptVacaciones
                Dim reporte As Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                    Exit Sub
                End If
                reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

                visor.crvReportes.ReportSource = reporte
                visor.ShowDialog()

            End If
        Else
            Dim ds, ds2 As New DataSet
            ds.Clear()
            ds.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(Me.dtpAl.EditValue, Me.VEmpleados.GetFocusedRowCellValue("Codigo")))
            ds2 = VB.SysContab.PermisosDB.GetList(Me.VEmpleados.GetFocusedRowCellValue("Codigo"), True, True, Me.dtpAl.DateTime.Date)
            ds.Tables.Add(ds2.Tables(0).Copy)
            ds.Tables.Add(ds2.Tables(1).Copy)
            ds2.Dispose()
            ds.Relations.Add("Permisos", _
                ds.Tables("Empleados").Columns("Codigo"), _
                ds.Tables("Permisos").Columns("Empleado"))
            ds.Relations.Add("PermisosDetalles", _
                        ds.Tables("Permisos").Columns("Codigo"), _
                        ds.Tables("PermisosDetalles").Columns("Codigo"))
            ds2 = Nothing
            ds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
            Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

            Dim visor As New frmReportes
            'Dim reporte As New rptVacaciones
            Dim reporte As Object
            reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

            If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                Exit Sub
            End If
            reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

            visor.crvReportes.ReportSource = reporte
            visor.ShowDialog()
        End If

    End Sub

    Private Sub dtpAl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpAl.EditValueChanged
        If Me.cargado = True Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdD.Click
        For i As Integer = 0 To Me.VEmpleados.DataRowCount - 1
            If Me.VEmpleados.GetRowCellValue(i, "Disponibles") < 0 Then
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", 0)
            ElseIf Me.VEmpleados.GetRowCellValue(i, "Disponibles") <= Me.spDias.EditValue Then
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", Me.VEmpleados.GetRowCellValue(i, "Disponibles"))
            Else
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", Me.spDias.EditValue)
            End If

        Next
    End Sub

End Class