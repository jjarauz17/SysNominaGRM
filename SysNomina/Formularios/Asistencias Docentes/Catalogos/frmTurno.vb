Imports System.IO
Imports DevExpress.Spreadsheet
Public Class frmTurno
    Public Respuesta As String = "0"
    Private dt_Importado As DataTable
    Private myStream As Stream = Nothing
    Private archivo As New Workbook
    Private Sub frmTurno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cargar()
    End Sub

    Private Sub Cargar()
        Me.cbCatalogo.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.cbCatalogo.DisplayMember = "Nombre"
        Me.cbCatalogo.ValueMember = "Cuenta"

        Me.cbTipoIngreso.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        Me.cbTipoIngreso.DisplayMember = "Descripcion"
        Me.cbTipoIngreso.ValueMember = "Codigo"


        dt_Importado = Nothing
        Me.vLista.Columns.Clear()
        Me.dgTurno.DataSource = Catalogos.EDU_Turno(0)
        Me.dgTurno.DataSource.columns("id").defaultvalue = 0
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("id").Visible = False
        Me.vLista.Columns("empr_codigo").Visible = False
        Me.vLista.Columns("id_turno").Caption = "ID_Externo"
        Me.vLista.Columns("desc_turno").Caption = "Descripcion"
        Me.vLista.Columns("cta_contable").Caption = "Cuenta Contable"
        Me.vLista.Columns("cta_contable").ColumnEdit = Me.cbCatalogo
        Me.vLista.Columns("tdi_codigo").ColumnEdit = Me.cbTipoIngreso
        Me.vLista.Columns("tdi_codigo").Caption = "Tipo de Ingreso"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim tempdt As DataTable
        Dim ID As Integer, Cta As String = ""
        ''EDU_Turno
        tempdt = Nothing
        'Los Deleted
        tempdt = Me.dgTurno.DataSource.getchanges(DataRowState.Deleted)
        If Not tempdt Is Nothing Then
            tempdt.RejectChanges()
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Turno_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_turno"), tempdt.Rows(i)("desc_turno"), tempdt.Rows(i)("cta_contable"), tempdt.Rows(i)("tdi_codigo"), True)
            Next

        End If

        'Los Modificiados Modificados
        tempdt = Me.dgTurno.DataSource.getchanges(DataRowState.Modified)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                Catalogos.EDU_Turno_Add(tempdt.Rows(i)("id"), tempdt.Rows(i)("id_turno"), tempdt.Rows(i)("desc_turno"), tempdt.Rows(i)("cta_contable"), tempdt.Rows(i)("tdi_codigo"))
            Next

        End If
        'Los  agregados
        tempdt = Me.dgTurno.DataSource.getchanges(DataRowState.Added)
        If Not tempdt Is Nothing Then
            For i As Integer = 0 To tempdt.Rows.Count - 1
                If tempdt.Rows(i)("id") Is DBNull.Value Then ID = 0 Else ID = tempdt.Rows(i)("id")
                If tempdt.Rows(i)("cta_contable") Is DBNull.Value Then Cta = "" Else Cta = tempdt.Rows(i)("cta_contable")
                Catalogos.EDU_Turno_Add(ID, tempdt.Rows(i)("id_turno"), tempdt.Rows(i)("desc_turno"), Cta, tempdt.Rows(i)("tdi_codigo"))
            Next
        End If
        Me.Cargar()
    End Sub

    Private Sub vLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLista.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim t As New frmOrigen(Me)
        t.ShowDialog()
        t.Dispose()
        Dim g As Boolean = True
        If Me.Respuesta = 2 Then 'webservice
            Dim ws As New EDU_Asistencias.Service1SoapClient
            ADORNOS.ShowSplash()
            Try
                dt_Importado = ws.turnos
                If Not dt_Importado Is Nothing Then
                    If dt_Importado.Rows.Count > 0 Then
                        'Dim hojas As Integer = archivo.Worksheets.Count - 1
                        'For i As Integer = 1 To hojas
                        '    archivo.Worksheets.RemoveAt(0)
                        'Next
                        'archivo.Worksheets.Add("Hoja")
                        'archivo.Worksheets.RemoveAt(0)
                        'archivo.Worksheets(0).Name = "Turnos"
                        'archivo.Worksheets.Item(0).Import(dt_Importado, True, 0, 0)
                        'Using myStream As New MemoryStream '( Application.StartupPath & "\tmp.xlsx", FileMode.Create, FileAccess.ReadWrite)
                        '    archivo.SaveDocument(myStream, DevExpress.Spreadsheet.DocumentFormat.Xls)
                        '    Dim fArchivo(myStream.Length) As Byte
                        '    myStream.Read(fArchivo, 0, myStream.Length)
                        '    Catalogos.EDU_BitacoraArchivos(fArchivo, Respuesta - 1)
                        '    myStream.Close()
                        'End Using
                    End If
                End If
                'Procesar los registros
                For i As Integer = 0 To dt_Importado.Rows.Count - 1
                    If Not dt_Importado.Rows(i)("cod_turno") Is DBNull.Value And Not dt_Importado.Rows(i)("turno") Is DBNull.Value Then
                        Catalogos.EDU_Turno_Add(0, dt_Importado.Rows(i)("cod_turno"), dt_Importado.Rows(i)("turno"), "", False, True)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                g = False
            End Try
            Cargar()
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
                    myStream = Nothing
                    myStream = Me.OFD.OpenFile()
                Catch Ex As Exception
                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                    g = False
                    Exit Sub
                Finally
                    If Not IsNothing(myStream) Then
                        narchivo = Me.OFD.FileName
                        Dim xmlds As DataSet
                        xmlds = New DataSet()
                        If VB.SysContab.DocumentosDB.Leer_Archivo(narchivo, xmlds) = -1 Then
                            MsgBox("Error al cargar el archivo")
                        End If
                        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "cod_turno" Then
                            MsgBox("La primer columna del archivo a importar debe ser el ID del TURNO (cod_turno)")
                            GoTo salir
                        End If
                        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "turno" Then
                            MsgBox("La segunda columna del archivo a importar debe ser la descripcion del TURNO (turno)")
                            GoTo salir
                        End If
                        Me.dgTurno.DataSource = Nothing
                        Me.vLista.Columns.Clear()
                        xmlds.Tables(0).Columns.Add("id", Type.GetType("System.Decimal"))
                        xmlds.Tables(0).Columns("id").DefaultValue = 0

                        xmlds.Tables(0).Columns.Add("cta_contable", Type.GetType("System.String"))
                        xmlds.Tables(0).Columns("cta_contable").DefaultValue = ""

                        xmlds.Tables(0).Columns("cod_turno").ColumnName = "id_turno"
                        xmlds.Tables(0).Columns("turno").ColumnName = "desc_turno"

                        Me.dgTurno.DataSource = xmlds.Tables(0)

                        Me.vLista.Columns("id").Visible = False
                        Me.vLista.Columns("cta_contable").Visible = False
                        Me.vLista.Columns("id_turno").Caption = "ID_Externo"
                        Me.vLista.Columns("desc_turno").Caption = "Descripcion"

salir:              End If
                    If Not IsNothing(myStream) Then
                        Dim fArchivo(myStream.Length) As Byte
                        myStream.Read(fArchivo, 0, myStream.Length)
                        Catalogos.EDU_BitacoraArchivos(fArchivo, Respuesta - 1)
                        myStream.Close()
                    End If

                End Try
            End If

        End If
        
    End Sub
End Class