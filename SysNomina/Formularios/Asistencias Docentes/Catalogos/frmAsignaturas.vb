Imports System.IO
Public Class frmAsignaturas
    Public Respuesta As String = "0"
    Private myStream As Stream = Nothing
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAsignaturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Private Sub Cargar()
        Me.dgAsignaturas.DataSource = Catalogos.EDU_Asignatura(0)
        Me.dgAsignaturas.DataSource.columns("id").defaultvalue = 0

        Me.cbTipoIngreso.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        Me.cbTipoIngreso.DisplayMember = "Descripcion"
        Me.cbTipoIngreso.ValueMember = "Codigo"

        Me.cbgastos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Rubros(False)
        Me.cbgastos.DisplayMember = "Nombre"
        Me.cbgastos.ValueMember = "Rubro"
        Me.cbgastos.PopulateViewColumns()
        For i As Integer = 0 To Me.vListaGastos.Columns.Count - 1
            If Not (Me.vListaGastos.Columns(i).FieldName = "Rubro" Or Me.vListaGastos.Columns(i).FieldName = "Nombre") Then
                Me.vListaGastos.Columns(i).Visible = False
            End If
        Next
        Me.vListaGastos.Columns("Rubro").Caption = "Rubro"
        Me.vListaGastos.Columns("Nombre").Caption = "Descripcion"

        Me.vlista.BestFitColumns()
        Me.vlista.Columns("id").Visible = False
        Me.vlista.Columns("empr_codigo").Visible = False
        Me.vlista.Columns("tdi_codigo").Caption = "Tipo Ingreso"
        Me.vlista.Columns("tdi_codigo").ColumnEdit = Me.cbTipoIngreso
        Me.vlista.Columns("rub_gasto").ColumnEdit = Me.cbGastos
        Me.vlista.Columns("id_asignatura").Caption = "ID_Asignatura"
        Me.vlista.Columns("desc_asignatura").Caption = "Asignatura"
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempdt As DataTable
        Dim ID As Integer

        ''EDU_Facultad
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgAsignaturas.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Asignatura_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_asignatura"), tempdt.Rows(i)("tdi_codigo"), tempdt.Rows(i)("desc_asignatura"), _
                    tempdt.Rows(i)("rub_gasto"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgAsignaturas.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Asignatura_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_asignatura"), tempdt.Rows(i)("tdi_codigo"), tempdt.Rows(i)("desc_asignatura"), _
                                             tempdt.Rows(i)("rub_gasto"))
            Next

        End If
        'Los  agregados
        tempdt = Me.dgAsignaturas.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                If tempdt.Rows(i)("id") Is DBNull.Value Then ID = 0 Else ID = tempdt.Rows(i)("id")
                Catalogos.EDU_Asignatura_Add(ID, tempdt.Rows(i)("id_asignatura"), tempdt.Rows(i)("tdi_codigo"), tempdt.Rows(i)("desc_asignatura"), tempdt.Rows(i)("rub_gasto"))
                ID = 0
            Next

        End If
        Me.Cargar()
    End Sub

    Private Sub vLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vlista.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim t As New frmOrigen(Me)
        t.ShowDialog()
        t.Dispose()
        If Me.Respuesta = 2 Then 'webservice
            Dim ws As New EDU_Asistencias.Service1SoapClient
            Dim dt As DataTable
            ADORNOS.ShowSplash()
            Try
                dt = ws.asignaturas()
                For i As Integer = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i)("cod_asignatura") Is DBNull.Value And Not dt.Rows(i)("asignatura") Is DBNull.Value Then
                        Catalogos.EDU_Asignatura_Add(0, dt.Rows(i)("cod_asignatura"), "", dt.Rows(i)("asignatura"), 0, False, True)
                    End If
                Next
                Me.Cargar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ADORNOS.HideSplash()
        ElseIf Me.Respuesta = 1 Then
            'Leer un archivo
            Dim narchivo As String
            myStream = Nothing
            Me.OFD.InitialDirectory = Application.StartupPath()

            Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
            Me.OFD.FilterIndex = 1
            Me.OFD.RestoreDirectory = True

            If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    myStream = Me.OFD.OpenFile()
                Catch Ex As Exception
                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                    Exit Sub
                Finally
                    If Not IsNothing(myStream) Then
                        narchivo = Me.OFD.FileName
                        Dim xmlds As DataSet
                        xmlds = New DataSet()
                        If VB.SysContab.DocumentosDB.Leer_Archivo(narchivo, xmlds) = -1 Then
                            MsgBox("Error al cargar el archivo")
                        End If
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "id_asignatura" Then
                            MsgBox("La primer columna del archivo a importar debe ser el ID de Asignatura (id_asignatura)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "asignatura" Then
                            MsgBox("La segunda columna del archivo a importar debe ser e Nombre de Asignatura (asignatura)")
                            GoTo salir
                        End If
                        Me.dgAsignaturas.DataSource = Nothing
                        Me.vlista.Columns.Clear()
                        xmlds.Tables(0).Columns.Add("id", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("id").DefaultValue = 0
                        xmlds.Tables(0).Columns("asignatura").ColumnName = "desc_asignatura"

                        xmlds.Tables(0).Columns.Add("tdi_codigo", Type.GetType("System.String"))
                        xmlds.Tables(0).Columns("tdi_codigo").DefaultValue = ""

                        xmlds.Tables(0).Columns.Add("empr_codigo", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("empr_codigo").DefaultValue = EmpresaActual

                        xmlds.Tables(0).Columns.Add("rub_gasto", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("rub_gasto").DefaultValue = 0

                        Me.dgAsignaturas.DataSource = xmlds.Tables(0)
                        Me.vlista.Columns("id").Visible = False
                        Me.vlista.Columns("empr_codigo").Visible = False
                        Me.vlista.Columns("id_asignatura").Caption = "ID_Asignatura"
                        Me.vlista.Columns("desc_asignatura").Caption = "Asignatura"
                        Me.vlista.Columns("tdi_codigo").Caption = "Tipo de Ingreso"
                        Me.vlista.Columns("rub_gasto").Caption = "Rubro de Gasto"

salir:              End If
                End Try
            End If
            If IsNothing(myStream) Then
                Exit Sub
            End If
        End If
    End Sub
End Class