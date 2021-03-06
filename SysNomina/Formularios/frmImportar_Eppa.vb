Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient

Public Class frmImportar_Eppa
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmImportar_Eppa = Nothing
    Friend WithEvents cbEmpleado As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Public Shared Function Instance() As frmImportar_Eppa
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmImportar_Eppa()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private Tabla As String = ""
    Private TablaExportar As String = ""
    Private Checado As Boolean

    Private Sub frmImportar_Eppa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbDatosDe.SelectedIndex = 0

        Me.Envio.Properties.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*", "Envios", " procesado = 0 ").Tables(0)
        Me.Envio.Properties.ValueMember = "envio"
        Me.Envio.Properties.DisplayMember = "envio"
        Checado = False
        


    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub Envio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Envio.EditValueChanged
        Me.LlenarDatos(sender)
    End Sub

    Private Sub Envio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Envio.Validated
        Me.LlenarDatos(sender)
    End Sub
    
    Private Sub cbDatosDe_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDatosDe.EditValueChanged
        LlenarDatos(sender)
    End Sub
    Private Sub Filtro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Filtro.EditValueChanged
        LlenarDatos(sender)
    End Sub


    Private Sub LlenarDatos(ByVal sender As Object)

        Dim Filtro As String = " envio = " & Me.Envio.EditValue

        If Me.cbDatosDe.SelectedItem.Substring(0, 1) = "D" Then
            Select Case Me.Filtro.SelectedItem
                Case "Empleados Nuevos"
                    Filtro = Filtro & " and emp_sysAsistencias = 1 and estado = 'P' and emp_codigo_sysNomina = ''"
                Case "--Ninguno--"
                    Filtro = " envio = " & Me.Envio.EditValue
                Case "Empleados Registrados-Actualizacion de Datos"
                    Filtro = Filtro & " and estado = 'P' and emp_codigo_sysNomina <> ''"
                Case Else
            End Select
        End If
        If Me.cbDatosDe.SelectedItem.Substring(0, 1) = "A" Then
            Filtro = Filtro & " and estado = 'P' "
        End If

        If Not (Me.Envio.EditValue Is Nothing) Then
            If Me.Envio.Properties.DataSource.rows.count > 0 Then
                If Me.Envio.GetColumnValue("Archivo") = False Then
                    If Me.cbDatosDe.SelectedItem.Substring(0, 1) = "A" Then
                        Tabla = "Asistencias"
                        Me.gcDatos.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*, cast(0 as bit) as Importar,  cast(0 as bit) as Denegar", "asistencias_temp", Filtro).Tables(0)
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "B" Then
                        Tabla = "Bajas"
                        Me.gcDatos.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*, cast(0 as bit) as Importar,  cast(0 as bit) as Denegar", "Empleado_baja_temp", Filtro).Tables(0)
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "C" Then
                        Tabla = "Corte"
                        Me.gcDatos.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*, cast(0 as bit) as Importar,  cast(0 as bit) as Denegar", "FCS_Latas_Temp", Filtro).Tables(0)
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "D" Then
                        Tabla = "Datos Empleados"
                        Me.gcDatos.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*, cast(0 as bit) as Importar,  cast(0 as bit) as Denegar ", "Empleados_Temp", Filtro).Tables(0)
                    End If
                    Me.Datos.PopulateColumns()
                    Estilo(Me.Datos)

                Else
                    If Me.cbDatosDe.SelectedItem.Substring(0, 1) = "A" Then
                        Tabla = "Asistencias"
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "B" Then
                        Tabla = "Bajas"
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "C" Then
                        Tabla = "Corte"
                    ElseIf Me.cbDatosDe.SelectedItem.Substring(0, 1) = "D" Then
                        Tabla = "Datos Empleados"
                    End If

                    If Me.Envio.GetColumnValue("P_empleados") = False And Tabla <> "Datos Empleados" Then
                        MsgBox("A�n no se han importado los datos de empleados para este envio", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If

                    If sender.name.tolower = "filtro" And Not (Me.gcDatos.DataSource Is Nothing) Then
                        Me.gcDatos.DataSource.DefaultView.RowFilter = Filtro '"emp_sysAsistencias = 1 and estado = 'P' and emp_codigo_sysNomina = ''"
                    Else

                        Dim myStream As Stream = Nothing
                        Dim xmlds As New DataSet
                        Dim xmlds2 As New DataSet

                        Me.OFD.InitialDirectory = Application.StartupPath()
                        Me.OFD.Filter = "XML Files (*.xml)|*.xml"
                        Me.OFD.FilterIndex = 1
                        Me.OFD.RestoreDirectory = True

                        If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Try
                                myStream = Me.OFD.OpenFile()
                            Catch Ex As Exception
                                MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                                Exit Sub
                            Finally
                                ' Check this again, since we need to make sure we didn't throw an exception on open.
                                If Not IsNothing(myStream) Then
                                    myStream.Close()
                                    xmlds2.ReadXml(Me.OFD.FileName)
                                    xmlds.ReadXml(Me.OFD.FileName)
                                    If xmlds2.Tables(0).Rows.Count = 0 Then
                                        MsgBox("No hay registros procesables en el archivo")
                                    Else
                                        If xmlds2.Tables(0).Rows(0)("envio") <> Me.Envio.EditValue Then
                                            MsgBox("Este archivo no corresponde al env�o seleccionado", MsgBoxStyle.Critical, "SysNomina")
                                        Else
                                            xmlds.Tables(0).Columns.Add("Importar", GetType(System.Boolean))
                                            xmlds.Tables(0).Columns.Add("Denegar", GetType(System.Boolean))
                                            'Verificar si ya se importaron datos anteriormente de este archivo
                                            'Si no existe el registro se agrega
                                            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                                            DBConnexion.Open()
                                            transaccion = DBConnexion.BeginTransaction
                                            'xmlds = xmlds2.Clone()
                                            'Dim i As Integer
                                            'If Tabla = "Datos Empleados" Then
                                            '    'Buscar en la tabla de empleados
                                            '    For i = 0 To xmlds2.Tables(0).Rows.Count - 1
                                            '        If VB.SysContab.SysAsistenciasDB.Buscar_Empleado_Temp( _
                                            '            xmlds2.Tables(0).Rows(i)("emp_codigo").trim, _
                                            '            xmlds2.Tables(0).Rows(i)("envio"), _
                                            '            "") = 0 Then
                                            '            xmlds.Tables(0).Rows.Add(xmlds2.Tables(0).Rows(i).ItemArray)
                                            '        End If
                                            '    Next
                                            '    xmlds2.Clear()
                                            'End If

                                            'If Tabla = "Asistencias" Then
                                            '    'Buscar en la tabla de Asistencias
                                            '    For i = 0 To xmlds2.Tables(0).Rows.Count - 1
                                            '        If VB.SysContab.SysAsistenciasDB.Buscar_Asistencias_Temp( _
                                            '            xmlds2.Tables(0).Rows(i)("emp_codigo").trim, _
                                            '            xmlds2.Tables(0).Rows(i)("envio"), _
                                            '            "", xmlds2.Tables(0).Rows(i)("Fecha")) = 0 Then
                                            '            xmlds.Tables(0).Rows.Add(xmlds2.Tables(0).Rows(i).ItemArray)
                                            '        End If
                                            '    Next
                                            '    xmlds2.Clear()
                                            'End If


                                            'If Tabla = "Corte" Then
                                            '    'Buscar en la tabla de Corte
                                            '    For i = 0 To xmlds2.Tables(0).Rows.Count - 1
                                            '        If VB.SysContab.SysAsistenciasDB.Buscar_Latas_Temp( _
                                            '            xmlds2.Tables(0).Rows(i)("emp_codigo").trim, _
                                            '            xmlds2.Tables(0).Rows(i)("envio"), _
                                            '            "", xmlds2.Tables(0).Rows(i)("Fecha")) = 0 Then
                                            '            xmlds.Tables(0).Rows.Add(xmlds2.Tables(0).Rows(i).ItemArray)
                                            '        End If
                                            '    Next
                                            '    xmlds2.Clear()
                                            'End If


                                            DBConnexion.Close()
                                            Me.gcDatos.DataSource = xmlds.Tables(0)
                                            Me.Datos.PopulateColumns()
                                            Estilo(Me.Datos)

                                        End If

                                    End If
                                End If
                            End Try
                        End If
                        If IsNothing(myStream) Then
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If

        Me.txtRegistros.Text = Me.Datos.RowCount 'Me.gcDatos.DataSource.rows.count
    End Sub
    Private Sub Estilo(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView)

        For Each NombreColumna As DevExpress.XtraGrid.Columns.GridColumn In Grid.Columns

            If NombreColumna.FieldName.ToLower = "emp_codigo" And Me.cbDatosDe.SelectedItem.Substring(0, 1) <> "D" Then
                If Not (Me.Envio.EditValue Is Nothing) Then
                    'Me.cbEmpleado.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos(" emp_codigo_sysAsistencias as Codigo, rtrim(emp_pnombre) + ' ' + rtrim(emp_snombre) + ' ' + rtrim(emp_papellido) + ' ' + rtrim(emp_sapellido) as Nombre, emp_codigo as SysNomina ", "vempleados_finca", " emp_codigo_sysAsistencias <> ''").Tables(0)
                    Me.cbEmpleado.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos(" emp_codigo as Codigo,  nombre as Nombre, emp_codigo as SysNomina ", "vempleados", " empr_codigo = " & EmpresaActual).Tables(0)
                    Me.cbEmpleado.ValueMember = "Codigo"
                    Me.cbEmpleado.DisplayMember = "Nombre"
                    Me.cbEmpleado.PopulateColumns()
                    Me.cbEmpleado.Columns(0).Visible = False
                    NombreColumna.ColumnEdit = Me.cbEmpleado
                    Me.cbEmpleado.ShowFooter = False
                    NombreColumna.Caption = "Empleado"
                End If
            End If

            Select Case NombreColumna.FieldName.ToLower

                Case "emp_codigo", "emp_pnombre", "emp_snombre", "emp_papellido", _
                        "emp_sapellido", "emp_salario", "emp_formapago", "fecha", _
                        "presencia", "mitadDia", "feriado", "extrassimples", "extrasdobles", _
                        "latas", "importar", "emp_cedula", "emp_inss", "denegar"
                Case Else
                    NombreColumna.Visible = False
            End Select
            If NombreColumna.FieldName.ToLower = "emp_codigo" Then
                NombreColumna.SummaryItem.DisplayFormat = "{0:n}"
                NombreColumna.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If
            If NombreColumna.FieldName.ToLower = "extrasdobles" Then
                NombreColumna.SummaryItem.DisplayFormat = "{0:n2}"
                NombreColumna.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            End If
            If NombreColumna.FieldName.ToLower = "latas" Then
                NombreColumna.SummaryItem.DisplayFormat = "{0:n2}"
                NombreColumna.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            End If
        Next
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim Codigo As String

        'Importar Latas
        If Tabla = "Corte" Then
            For i As Integer = 0 To Me.Datos.RowCount - 1
                DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                DBConnexion.Open()
                transaccion = DBConnexion.BeginTransaction

                If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Importar"), False) = True Then
                    'Buscar en FCS_Latas
                    Dim DR As DataRowView = Me.cbEmpleado.GetDataSourceRowByKeyValue(Me.Datos.GetRow(i).row("emp_codigo"))
                    If Not (DR Is Nothing) Then
                        If VB.SysContab.SysAsistenciasDB.Buscar_Latas_Temp(Me.Datos.GetRowCellValue(i, "emp_codigo"), _
                            Me.Datos.GetRow(i).row("envio"), _
                            DR.Item(2), _
                            Me.Datos.GetRowCellValue(i, "Fecha")) = 0 Then


                            'Agregar en Temp, si no esta el mismo procedure lo edita. ;)
                            Try
                                If Me.Envio.GetColumnValue("Archivo") = False Then
                                    VB.SysContab.SysAsistenciasDB.AddLatasTemp(Me.Datos.GetRow(i).row("envio"), _
                                            Me.Datos.GetRow(i).row("emp_codigo"), _
                                            Me.Datos.GetRow(i).row("Fecha"), _
                                            Me.Datos.GetRow(i).row("Presencia"), _
                                            Me.Datos.GetRow(i).row("Feriado"), _
                                            Me.Datos.GetRow(i).row("Latas"), _
                                            "I")
                                End If
                                VB.SysContab.SysAsistenciasDB.AddLatas( _
                                        DR.Item(2), _
                                        Me.Datos.GetRow(i).row("fecha"), _
                                        Me.Datos.GetRow(i).row("Presencia"), _
                                        Me.Datos.GetRow(i).row("Feriado"), _
                                        Me.Datos.GetRow(i).row("Latas"), _
                                        Me.Datos.GetRow(i).row("Estado"))

                                VB.SysContab.Rutinas.okTransaccion()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                VB.SysContab.Rutinas.ErrorTransaccion()
                            End Try

                        Else
                            'si ya esta procesado no se toma en cuenta
                            'Generar un archivo con estos errores.
                        End If
                    End If
                Else
                    If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Denegar"), False) = True Then
                        'Denegar las latas
                        Try
                            VB.SysContab.SysAsistenciasDB.AddLatasTemp(Me.Datos.GetRow(i).row("envio"), _
                                       Me.Datos.GetRow(i).row("emp_codigo"), _
                                       Me.Datos.GetRow(i).row("fecha"), _
                                       Me.Datos.GetRow(i).row("Presencia"), _
                                       Me.Datos.GetRow(i).row("Feriado"), _
                                       Me.Datos.GetRow(i).row("Latas"), _
                                       "D")
                            VB.SysContab.Rutinas.okTransaccion()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            VB.SysContab.Rutinas.ErrorTransaccion()
                        End Try
                    End If

                End If
            Next
        End If


        'Importar Asistencias
        If Tabla = "Asistencias" Then
            For i As Integer = 0 To Me.Datos.RowCount - 1
                DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                DBConnexion.Open()
                transaccion = DBConnexion.BeginTransaction

                If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Importar"), False) = True Then
                    'Buscar en Asistencias
                    Dim DR As DataRowView = Me.cbEmpleado.GetDataSourceRowByKeyValue(Me.Datos.GetRow(i).row("emp_codigo")) 'Me.Datos.GetFocusedRowCellValue("emp_codigo"))

                    If DR Is Nothing Then
                        GoTo SeguirAsistencias
                    ElseIf VB.SysContab.SysAsistenciasDB.Buscar_Asistencias( _
                        DR.Item(2), _
                        Me.Datos.GetRowCellValue(i, "emp_codigo"), _
                        Me.Datos.GetRow(i).row("Fecha")) = 0 Then


                        Try
                            'If Me.Envio.GetColumnValue("Archivo") = True Then
                            VB.SysContab.SysAsistenciasDB.AddAsistenciasTemp(Me.Datos.GetRow(i).row("envio"), _
                                    Me.Datos.GetRow(i).row("emp_codigo"), _
                                    Me.Datos.GetRow(i).row("fecha"), _
                                    Me.Datos.GetRow(i).row("Presencia"), _
                                    Me.Datos.GetRow(i).row("HoraEntrada").ToString, _
                                    Me.Datos.GetRow(i).row("HoraSalida").ToString, _
                                    Me.Datos.GetRow(i).row("MitadDia"), _
                                    Me.Datos.GetRow(i).row("Feriado"), _
                                    Me.Datos.GetRow(i).row("ExtrasSimples"), _
                                    Me.Datos.GetRow(i).row("ExtrasDobles"), "I")
                            'End If
                            VB.SysContab.SysAsistenciasDB.AddAsistencias( _
                                    DR.Item(2), _
                                    Me.Datos.GetRow(i).row("fecha"), _
                                    Me.Datos.GetRow(i).row("Presencia"), _
                                    Me.Datos.GetRow(i).row("HoraEntrada").ToString, _
                                    Me.Datos.GetRow(i).row("HoraSalida").ToString, _
                                    Me.Datos.GetRow(i).row("MitadDia"), _
                                    Me.Datos.GetRow(i).row("Feriado"), _
                                    Me.Datos.GetRow(i).row("ExtrasSimples"), _
                                    Me.Datos.GetRow(i).row("ExtrasDobles"))

                            VB.SysContab.Rutinas.okTransaccion()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            VB.SysContab.Rutinas.ErrorTransaccion()
                        End Try

                    Else
                        'si ya esta procesado no se toma en cuenta
                        'Generar un archivo con estos errores.
                    End If

                Else
                    If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Denegar"), False) = True Then
                        'Denegar las asistencias
                        VB.SysContab.SysAsistenciasDB.AddAsistenciasTemp(Me.Datos.GetRow(i).row("envio"), _
                                                           Me.Datos.GetRow(i).row("emp_codigo"), _
                                                           Me.Datos.GetRow(i).row("fecha"), _
                                                           Me.Datos.GetRow(i).row("Presencia"), _
                                                           Me.Datos.GetRow(i).row("HoraEntrada").ToString, _
                                                           Me.Datos.GetRow(i).row("HoraSalida").ToString, _
                                                           Me.Datos.GetRow(i).row("MitadDia"), _
                                                           Me.Datos.GetRow(i).row("Feriado"), _
                                                           Me.Datos.GetRow(i).row("ExtrasSimples"), _
                                                           Me.Datos.GetRow(i).row("ExtrasDobles"), "D")
                    End If
                End If
SeguirAsistencias: Next
        End If
        'Importar los datos de los Empleados
        If Tabla = "Datos Empleados" Then
            'Datos Viejos
            If Me.Filtro.SelectedItem = "Empleados Registrados-Actualizacion de Datos" Then

                For i As Integer = 0 To Me.Datos.DataRowCount - 1
                    DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                    DBConnexion.Open()
                    transaccion = DBConnexion.BeginTransaction

                    If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Importar"), False) = True Then
                        'Seria ver si se aceptan los cambios de salario, y cambios de cedula,inss, nombre, forma de pago 

                    Else
                        If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Denegar"), False) = True Then
                            
                            Try

                                'Si no existe el registro se agrega
                                If VB.SysContab.SysAsistenciasDB.Buscar_Empleado_Temp( _
                                    Me.Datos.GetRow(i).row("emp_codigo"), _
                                    Me.Datos.GetRow(i).row("envio"), _
                                    "") = 0 Then

                                    VB.SysContab.EmpleadosDB.AddEmpleadosTemp(Me.Envio.EditValue, _
                                        Me.Datos.GetRow(i).row("emp_codigo"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_pnombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_snombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_papellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sapellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("depc_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_direccion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fnac"), Today), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_nacademico"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_profesion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sexo"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_inss"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_ruc"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_cedula"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fingreso"), Today), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("dep_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("cgo_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("fun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("hor_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_salario"), 0), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mon_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_formapago"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_hextra"), False), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("are_codigo"), "0"), _
                                        Me.Datos.GetRow(i).row("emp_pago"), _
                                        Me.Datos.GetRow(i).row("emp_contacto"), _
                                        Me.Datos.GetRow(i).row("emp_telcontacto"), _
                                        Me.Datos.GetRow(i).row("emp_acumulaprestaciones"), _
                                        Me.Datos.GetRow(i).row("emp_regimeninss"), _
                                        1, "")
                                End If

                                VB.SysContab.SysAsistenciasDB.Update_Empleado_Temp( _
                                    Me.Datos.GetRow(i).row("emp_codigo"), _
                                    Me.Datos.GetRow(i).row("envio"), _
                                    "", "D")


                                VB.SysContab.Rutinas.okTransaccion()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                VB.SysContab.Rutinas.ErrorTransaccion()

                            End Try
                        End If
                    End If
                Next
            End If
            '''''''''''''''''''''''''''''''''''''Nuevos
            If Me.Filtro.SelectedItem = "Empleados Nuevos" Then
                For i As Integer = 0 To Me.Datos.DataRowCount - 1 'Me.gcDatos.DataSource.DefaultView.rows.count - 1 '
                    DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                    DBConnexion.Open()
                    transaccion = DBConnexion.BeginTransaction

                    If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Importar"), False) = True Then 'Me.gcDatos.DataSource.DefaultView.rows(i)("Importar") = True Then '
                        'Buscar la cedula
                        If VB.SysContab.EmpleadosDB.GetDetails_cedula(Me.Datos.GetRow(i).row("emp_cedula")).Codigo Is Nothing Then
                            'Buscar el inss
                            If VB.SysContab.EmpleadosDB.GetDetails_inss(Me.Datos.GetRow(i).row("emp_inss")).Codigo Is Nothing Then
                                'Buscar el Codigo de Sysasistencias en Temp, para ver si ya esta procesado


                                Try
                                    Codigo = Me.Datos.GetRow(i).row("emp_codigo")
                                    VB.SysContab.EmpleadosDB.Additem(Codigo, _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_pnombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_snombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_papellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sapellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("depc_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_direccion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_telefono"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_celular"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_email"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fnac"), Today), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_nacademico"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_profesion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sexo"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_inss"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_ruc"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_cedula"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fingreso"), Today), _
                                        "Vacio", "01", _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("dep_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("cgo_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("fun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("hor_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_salario"), 0), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_estado"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_duracion"), 0), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mon_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_formapago"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_hextra"), False), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_vtransporte"), False), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("are_codigo"), "0"), _
                                        "", "", _
                                        Me.Datos.GetRow(i).row("emp_pago"), _
                                        Me.Datos.GetRow(i).row("emp_contacto"), _
                                        Me.Datos.GetRow(i).row("emp_telcontacto"), _
                                        "", "0", Me.Datos.GetRow(i).row("emp_acumulaprestaciones"), _
                                        Me.Datos.GetRow(i).row("emp_regimeninss"), 0, _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fingreso"), Today), _
                                        0, 0, 0, "", True, 0, True, False, _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("are_codigo"), "0"))

                                    'Actualizar el codigo de nomina
                                    'Si no existe el registro se agrega
                                    If VB.SysContab.SysAsistenciasDB.Buscar_Empleado_Temp( _
                                        Me.Datos.GetRow(i).row("emp_codigo"), _
                                        Me.Datos.GetRow(i).row("envio"), _
                                        Codigo) = 0 Then
                                        VB.SysContab.EmpleadosDB.AddEmpleadosTemp(Me.Envio.EditValue, _
                                            Me.Datos.GetRow(i).row("emp_codigo"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_pnombre"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_snombre"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_papellido"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sapellido"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("depc_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mun_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_direccion"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fnac"), Today), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_nacademico"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_profesion"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sexo"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_inss"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_ruc"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_cedula"), ""), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fingreso"), Today), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("dep_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("cgo_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("fun_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("hor_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_salario"), 0), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mon_codigo"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_formapago"), "0"), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_hextra"), False), _
                                            VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("are_codigo"), "0"), _
                                            Me.Datos.GetRow(i).row("emp_pago"), _
                                            Me.Datos.GetRow(i).row("emp_contacto"), _
                                            Me.Datos.GetRow(i).row("emp_telcontacto"), _
                                            Me.Datos.GetRow(i).row("emp_acumulaprestaciones"), _
                                            Me.Datos.GetRow(i).row("emp_regimeninss"), _
                                            1, Codigo)
                                    End If

                                    VB.SysContab.SysAsistenciasDB.Update_Empleado_Temp( _
                                        Me.Datos.GetRow(i).row("emp_codigo"), _
                                        Me.Datos.GetRow(i).row("envio"), _
                                        Codigo, "I")

                                    VB.SysContab.Rutinas.okTransaccion()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                    VB.SysContab.Rutinas.ErrorTransaccion()

                                End Try

                            End If
                        End If
                    Else
                        If VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("Denegar"), False) = True Then
                            'DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                            'DBConnexion.Open()
                            'transaccion = DBConnexion.BeginTransaction
                            Try

                                'Actualizar el codigo de nomina
                                'Si no existe el registro se agrega
                                If VB.SysContab.SysAsistenciasDB.Buscar_Empleado_Temp( _
                                    Me.Datos.GetRow(i).row("emp_codigo"), _
                                    Me.Datos.GetRow(i).row("envio"), _
                                    "") = 0 Then
                                    VB.SysContab.EmpleadosDB.AddEmpleadosTemp(Me.Envio.EditValue, _
                                        Me.Datos.GetRow(i).row("emp_codigo"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_pnombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_snombre"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_papellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sapellido"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("depc_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_direccion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fnac"), Today), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_nacademico"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_profesion"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_sexo"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_inss"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_ruc"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_cedula"), ""), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_fingreso"), Today), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("dep_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("cgo_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("fun_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("hor_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_salario"), 0), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("mon_codigo"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_formapago"), "0"), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("emp_hextra"), False), _
                                        VB.SysContab.RutinasNomina.NZ(Me.Datos.GetRow(i).row("are_codigo"), "0"), _
                                        Me.Datos.GetRow(i).row("emp_pago"), _
                                        Me.Datos.GetRow(i).row("emp_contacto"), _
                                        Me.Datos.GetRow(i).row("emp_telcontacto"), _
                                        Me.Datos.GetRow(i).row("emp_acumulaprestaciones"), _
                                        Me.Datos.GetRow(i).row("emp_regimeninss"), _
                                        1, "")
                                End If

                                VB.SysContab.SysAsistenciasDB.Update_Empleado_Temp( _
                                    Me.Datos.GetRow(i).row("emp_codigo"), _
                                    Me.Datos.GetRow(i).row("envio"), _
                                    "", "D")


                                VB.SysContab.Rutinas.okTransaccion()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                VB.SysContab.Rutinas.ErrorTransaccion()

                            End Try
                        End If
                    End If
                Next
                VB.SysContab.SysAsistenciasDB.Update_P_Empleado(Me.Envio.EditValue)
            End If
        End If

        Me.cbDatosDe.SelectedIndex = 0

        Me.Envio.Properties.DataSource = VB.SysContab.SysAsistenciasDB.LeerDatos("*", "Envios", " procesado = 0 ").Tables(0)
        Me.Envio.Properties.ValueMember = "envio"
        Me.Envio.Properties.DisplayMember = "envio"

        Me.gcDatos.DataSource = Nothing

    End Sub


    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged

        For i As Integer = 0 To Datos.DataRowCount
            Me.Datos.SetRowCellValue(i, "Importar", sender.checked)
            Me.Datos.SetRowCellValue(i, "Denegar", (Not sender.checked))
        Next

    End Sub

    Private Sub chkDenegarTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDenegarTodos.CheckedChanged

        For i As Integer = 0 To Datos.DataRowCount
            Me.Datos.SetRowCellValue(i, "Importar", (Not sender.checked))
            Me.Datos.SetRowCellValue(i, "Denegar", sender.checked)
        Next

    End Sub



    Private Sub cmdImpAsistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImpAsistencias.Click
        Me.ldesde.Visible = True
        Me.lhasta.Visible = True
        Me.dtpDesde.Visible = True
        Me.dtpHasta.Visible = True
        Me.cmdImprimir.Visible = True
        TablaExportar = "Asistencias"

    End Sub

    Private Sub cmdImpLatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImpLatas.Click
        Me.ldesde.Visible = True
        Me.lhasta.Visible = True
        Me.dtpDesde.Visible = True
        Me.dtpHasta.Visible = True
        Me.cmdImprimir.Visible = True
        TablaExportar = "Latas"
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If TablaExportar = "" Then
            Exit Sub
        End If
        'Validar Fechas
        If Me.dtpDesde.EditValue Is Nothing Then
            MsgBox("La fecha de inicio del reporte debe ser un dato v�lido", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        If Me.dtpHasta.EditValue Is Nothing Then
            MsgBox("La fecha de inicio del reporte debe ser un dato v�lido", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        ElseIf Me.dtpHasta.EditValue < Me.dtpDesde.EditValue Then
            MsgBox("La fecha final del reporte no debe ser anterior a la fecha de inicio", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        'Hacer la impresion
        Dim lds As New DataSet
        If TablaExportar = "Asistencias" Then
            lds = VB.SysContab.SysAsistenciasDB.Get_Asistencias(Me.dtpDesde.EditValue, Me.dtpHasta.EditValue)
        Else
            lds = VB.SysContab.SysAsistenciasDB.Get_Latas(Me.dtpDesde.EditValue, Me.dtpHasta.EditValue)
        End If
        
        Dim f As New frmGridDatos
        f.Origen = lds
        f.Show()
        'lds.WriteXml(Application.StartupPath & "\exportfiles\Asistencias.xml", XmlWriteMode.WriteSchema)
        'Devolver a su estado normal
        Me.ldesde.Visible = False
        Me.lhasta.Visible = False
        Me.dtpDesde.Visible = False
        Me.dtpHasta.Visible = False
        Me.cmdImprimir.Visible = False
        TablaExportar = ""
    End Sub
End Class
