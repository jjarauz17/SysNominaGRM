Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports Microsoft.Win32
Imports System.Net.Sockets
Imports System.Xml
Imports DbConnect

Namespace VB.SysContab

    Public Class RutinasNomina

        Public Shared Function ExportarTXT_sairi(ByVal Tablas As DataTable, ByVal Q As String, ByVal Longitud As Integer) As Boolean
            Dim i As Integer

            Dim objStreamWriter As StreamWriter = New StreamWriter(Q, False, System.Text.Encoding.Default) 'File.CreateText(Q)
            objStreamWriter.Flush()
            For i = 0 To Tablas.Rows.Count - 1
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Microsoft.VisualBasic.Left(Tablas.Rows(i)("Linea"), Longitud))
            Next
            objStreamWriter.Close()
            Return True
        End Function
       
        'Public Function Exportar_XLS(ByVal DS As DataSet)

        'End Function

        Public Shared Function NZ(ByVal Valor As Object, ByVal Devuelto As Object) As Object
            If Valor Is DBNull.Value Then
                'Select Case Devuelto.GetType.FullName
                '    Case "System.String"
                '        Return ""
                '    Case "System.Integer"
                '        Return 0
                '    Case "System.Datetime"
                '        Return
                '    Case Else
                '        Return Valor
                'End Select
                Return Devuelto
            Else
                Return Valor
            End If
        End Function
        Public Function LeerXML(ByVal Path As String) As DataSet
            Dim ds As New DataSet()
            If File.Exists(Path) Then
                ds.ReadXml(Path)
                Return ds
            Else
                MsgBox("No existe ese archivo", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
        End Function

        Public Shared Sub INSSXML(ByVal mes As String, ByVal path As String)

            Dim i As Integer
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Mes", SqlDbType.NVarChar, 6, ParameterDirection.Input, mes)
            Dim tabla As New DataTable
            tabla = v.EjecutarComando("_GetListEmprRef_INSS", "EmpresasREf")
            If tabla Is Nothing Then
                Exit Sub
            End If
            Dim inss As Integer = 0


            For j As Integer = 0 To tabla.Rows.Count - 1
                Dim ds As New DataSet
                ds = PlanillaDB.INSSXML_DS(mes, tabla.Rows(j)("Empr_ref"))
                If ds.Tables("INSSXML").Rows.Count = 0 Then
                    GoTo seguir
                    'MsgBox("No hay registros que exportar", MsgBoxStyle.Critical)
                    'Exit Sub
                End If

                inss = VB.SysContab.EmpresasDB.GetDetails(tabla.Rows(j)("Empr_ref")).INSS
                Try

                    Dim writer As XmlTextWriter = New XmlTextWriter(path & "\inss_" & inss.ToString & "_" & mes & ".xml", System.Text.Encoding.GetEncoding(28591))
                    With writer
                        ' Write XML data.
                        writer.Formatting = Formatting.Indented

                        'Escribir el encabezado obligatorio
                        writer.WriteStartDocument()

                        'encabezado del inss
                        writer.WriteStartElement("inss:documento")
                        writer.WriteAttributeString("xmlns:inss", "http://inss.gob.ni/novedades")

                        'Escribir el bloque
                        writer.WriteStartElement("bloque", "")
                        'Registros
                        writer.WriteElementString("registro", inss.ToString) 'XmlConvert.ToString(ds.Tables("INSSXML").Rows.Count))
                        'Periodo
                        writer.WriteElementString("periodo", Microsoft.VisualBasic.Left(mes, 4) & "-" & Microsoft.VisualBasic.Right(mes, 2))
                        writer.WriteEndElement()
                        'Escribir el detalle
                        writer.WriteStartElement("detalle", "")
                        'Dim detalleEmpleado As EmpleadosDetails

                        For i = 0 To ds.Tables("INSSXML").Rows.Count - 1

                            'Escribir la novedad
                            writer.WriteStartElement("novedad", "")
                            'Escribir el nINSS
                            writer.WriteElementString("nss", ds.Tables("INSSXML").Rows(i)("inss"))
                            'Escribir el Nombres
                            writer.WriteElementString("p-nombre", ds.Tables("INSSXML").Rows(i)("NOMBRES"))
                            'Escribir el Apellidos
                            writer.WriteElementString("p-apellido", ds.Tables("INSSXML").Rows(i)("APELLIDOS"))
                            'Escribir el Mes-nomina
                            writer.WriteElementString("nomina", ds.Tables("INSSXML").Rows(i)("MES"))
                            'detalleEmpleado = VB.SysContab.EmpleadosDB.GetDetails(ds.Tables("INSSXML").Rows(i)("emp_codigo"))
                            'Escribir el tipo de Novedad
                            writer.WriteElementString("tipo-novedad", ds.Tables("INSSXML").Rows(i)("novedad")) 'IIf(detalleEmpleado.Localidad = 1, "02", "03"))
                            'Escribir la fecha
                            writer.WriteElementString("fecha", ds.Tables("INSSXML").Rows(i)("fecha"))
                            'Escribir Salario Devengado
                            writer.WriteElementString("sal-devengado", ds.Tables("INSSXML").Rows(i)("devengado"))
                            'Escribir Salario Mensual
                            writer.WriteElementString("sal-mensual", ds.Tables("INSSXML").Rows(i)("Mensual")) 'XmlConvert.ToString(IIf(detalleEmpleado.Localidad = 1, 0.0, ds.Tables("INSSXML").Rows(i)("Mensual"))))
                            'Escribir Aporte
                            writer.WriteElementString("aporte", XmlConvert.ToString(0.0))
                            'Escribir las Semanas
                            writer.WriteElementString("semanas", ds.Tables("INSSXML").Rows(i)("cSemanas"))
                            'Escribir el Centro de Costo
                            writer.WriteElementString("centro-costo", ds.Tables("INSSXML").Rows(i)("ccosto"))
                            'Escribir Tipo empleado
                            writer.WriteElementString("tipo-empleo", ds.Tables("INSSXML").Rows(i)("estado"))
                            writer.WriteEndElement()
                        Next


                        writer.WriteEndDocument()

                        'Write the XML to file and close the writer.
                        writer.Flush()

                    End With
                    writer.Close()
                    '            For j As Integer = 0 To tabla.Rows.Count - 1

                    '                inss = VB.SysContab.EmpresasDB.GetDetails(tabla.Rows(j)("Empr_ref")).INSS
                    '                Dim w As XmlWriter
                    '                Dim s As New XmlWriterSettings
                    '                s.Encoding = System.Text.Encoding.GetEncoding(28591)
                    '                s.Indent = True

                    '                w = XmlWriter.Create(path & "\inss_w" & inss.ToString & ".xml", s)

                    '                Dim ds As New DataSet
                    '                ds.Tables.Add("bloque")
                    '                ds.Tables("bloque").Columns.Add("registro")
                    '                ds.Tables("bloque").Columns.Add("periodo")
                    '                ds.Tables("bloque").Rows.Add()
                    '                ds.Tables("bloque").Rows(0)(0) = inss
                    '                ds.Tables("bloque").Rows(0)(1) = Microsoft.VisualBasic.Left(mes, 4) & "-" & Microsoft.VisualBasic.Right(mes, 2)


                    '                ds.Tables.Add(PlanillaDB.INSSXML_DT(mes, tabla.Rows(0)("Empr_ref")).Copy)

                    '                ds.Namespace = "http://inss.gob.ni/novedades"
                    '                ds.Prefix = "inss"
                    '                ds.DataSetName = "documento"
                    '                ds.Tables(0).Prefix = ""
                    '                ds.Tables(1).Prefix = ""
                    '                ds.Tables(0).Namespace = ""
                    '                ds.Tables(1).Namespace = ""
                    '                ds.WriteXml(w)
                    '                w.Close()
                    'seguir:     Next
                    'With w

                    '    'Escribir el encabezado obligatorio
                    '    w.WriteStartDocument()
                    '    'encabezado del inss
                    '    w.WriteStartElement("inss:documento")
                    '    w.WriteAttributeString("xmlns:inss", "http://inss.gob.ni/novedades")

                    '    'Escribir el bloque
                    '    w.WriteStartElement("bloque", "")
                    '    'Registros
                    '    w.WriteElementString("registro", inss.ToString) 'XmlConvert.ToString(ds.Tables("INSSXML").Rows.Count))
                    '    'Periodo
                    '    w.WriteElementString("periodo", Microsoft.VisualBasic.Left(mes, 4) & "-" & Microsoft.VisualBasic.Right(mes, 2))
                    '    w.WriteEndElement()
                    '    'Escribir el detalle
                    '    w.WriteStartElement("detalle", "")
                    '    Dim detalleEmpleado As EmpleadosDetails

                    '    For i = 0 To ds.Tables("INSSXML").Rows.Count - 1

                    '        'Escribir la novedad
                    '        w.WriteStartElement("novedad", "")
                    '        'Escribir el nINSS
                    '        w.WriteElementString("nss", ds.Tables("INSSXML").Rows(i)("inss"))
                    '        'Escribir el Nombres
                    '        w.WriteElementString("p-nombre", ds.Tables("INSSXML").Rows(i)("NOMBRES"))
                    '        'Escribir el Apellidos
                    '        w.WriteElementString("p-apellido", ds.Tables("INSSXML").Rows(i)("APELLIDOS"))
                    '        'Escribir el Mes-nomina
                    '        w.WriteElementString("nomina", ds.Tables("INSSXML").Rows(i)("MES"))
                    '        detalleEmpleado = VB.SysContab.EmpleadosDB.GetDetails(ds.Tables("INSSXML").Rows(i)("emp_codigo"))
                    '        'Escribir el tipo de Novedad
                    '        w.WriteElementString("tipo-novedad", IIf(detalleEmpleado.Localidad = 1, "02", "03"))
                    '        'Escribir la fecha
                    '        w.WriteElementString("fecha", ds.Tables("INSSXML").Rows(i)("fecha"))
                    '        'Escribir Salario Devengado
                    '        w.WriteElementString("sal-devengado", ds.Tables("INSSXML").Rows(i)("devengado"))
                    '        'Escribir Salario Mensual
                    '        w.WriteElementString("sal-mensual", XmlConvert.ToString(IIf(detalleEmpleado.Localidad = 1, 0.0, ds.Tables("INSSXML").Rows(i)("Mensual"))))
                    '        'Escribir Aporte
                    '        w.WriteElementString("aporte", XmlConvert.ToString(0.0))
                    '        'Escribir las Semanas
                    '        w.WriteElementString("semanas", ds.Tables("INSSXML").Rows(i)("cSemanas"))
                    '        'Escribir el Centro de Costo
                    '        w.WriteElementString("centro-costo", ds.Tables("INSSXML").Rows(i)("ccosto"))
                    '        'Escribir Tipo empleado
                    '        w.WriteElementString("tipo-empleo", ds.Tables("INSSXML").Rows(i)("estado"))
                    '        w.WriteEndElement()
                    '    Next
                    '    w.WriteEndDocument()
                    '    'Write the XML to file and close the writer.
                    '    w.Flush()

                    'End With
                    'w.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

seguir:     Next
        End Sub

        Public Shared Function Servidores() As Array
            Dim RKey0 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", False)
            Dim Nombre As String = ""
            Dim Arreglo() As String = Nothing, Longitud As Integer

            For Each Nombre In RKey0.GetSubKeyNames
                If Nombre = "Microsoft" Then
                    Exit For
                End If
            Next
            If Nombre = "Microsoft" Then
                Dim RKey1 As RegistryKey = RKey0.OpenSubKey(Nombre, False)

                For Each Nombre In RKey1.GetSubKeyNames
                    If Nombre = "Microsoft SQL Server" Then
                        Exit For
                    End If
                Next
                If Nombre = "Microsoft SQL Server" Then
                    Dim RKey2 As RegistryKey = RKey1.OpenSubKey(Nombre, False)

                    For Each Nombre In RKey2.GetSubKeyNames
                        If Nombre = "80" Then
                            Exit For
                        End If
                    Next
                    If Nombre = "80" Then
                        Dim rkey3 As RegistryKey = RKey2.OpenSubKey(Nombre, False)
                        For Each Nombre In rkey3.GetSubKeyNames
                            If Nombre = "Tools" Then
                                Exit For
                            End If

                        Next
                        If Nombre = "Tools" Then
                            Dim rkey4 As RegistryKey = rkey3.OpenSubKey(Nombre, False)
                            For Each Nombre In rkey4.GetSubKeyNames
                                If Nombre = "SQLEW" Then
                                    Exit For
                                End If
                            Next
                            If Nombre = "SQLEW" Then
                                Dim rkey5 As RegistryKey = rkey4.OpenSubKey(Nombre, False)
                                For Each Nombre In rkey5.GetSubKeyNames
                                    If Nombre = "Registered Servers X" Then
                                        Exit For
                                    End If
                                Next
                                If Nombre = "Registered Servers X" Then
                                    Dim rkey6 As RegistryKey = rkey5.OpenSubKey(Nombre, False)
                                    'La i controla el arreglo de servidores
                                    'La j controla el arreglo obtenido
                                    Dim i, j As Integer
                                    i = 0
                                    For Each Nombre In rkey6.GetSubKeyNames
                                        Dim RegKey As RegistryKey = rkey6.OpenSubKey(Nombre, False)
                                        If Arreglo Is Nothing Then
                                            Longitud = RegKey.GetValueNames.Length - 1
                                        Else
                                            Longitud = RegKey.GetValueNames.Length + UBound(Arreglo)
                                        End If
                                        ReDim Preserve Arreglo(Longitud)
                                        For j = 0 To RegKey.GetValueNames.Length - 1
                                            Arreglo(i) = RegKey.GetValueNames(j)
                                            i = i + 1
                                        Next

                                    Next
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Array.Sort(Arreglo)
            Return Arreglo
        End Function
        'Public Shared Sub CargaReporte()
        '    Dim Reporte As New rptEmpleados()
        '    Dim fReportes As New frmReportes()
        '    Dim Empresa As New VB.SysContab.EmpresasDB()
        '    Reporte.SetDataSource(Empresa.Inicio)
        '    fReportes.crvReportes.ReportSource = Reporte
        '    'SyncLock (Reporte)
        '    '    Try
        '    '        Reporte.Load()
        '    '    Catch ex As Exception
        '    '        MsgBox(ex.Message)
        '    '    End Try
        '    'End SyncLock
        '    If myThread.IsAlive Then
        '        myThread.Abort()
        '        myThread = Nothing
        '        Reporte = Nothing
        '        fReportes = Nothing
        '        finalize()
        '    End If
        'End Sub

        Public Shared Function BuscarSabados(ByVal Desde As DateTime, ByVal Hasta As DateTime) As Integer
            Dim i As Integer
            Dim Sabados As Integer ', Dia As DateTime
            Sabados = 0
            For i = 0 To DateDiff(DateInterval.Day, Desde, Hasta) '- 1
                If Weekday(DateAdd(DateInterval.Day, i, Desde)) = 7 Then ' Sabados
                    Sabados += 1
                End If
            Next

            Return Sabados
        End Function
        Public Shared Function BuscarunSabado(ByVal Desde As DateTime, ByVal Hasta As DateTime, ByVal Sabado As Integer) As Date
            Dim i As Integer
            Dim Sabados As Integer ', Dia As DateTime
            Sabados = 0
            For i = 0 To DateDiff(DateInterval.Day, Desde, Hasta) '- 1
                If Weekday(DateAdd(DateInterval.Day, i, Desde)) = 7 Then ' Sabados
                    Sabados += 1
                End If
                If Sabados = Sabado Then
                    Exit For
                End If
            Next

            Return DateAdd(DateInterval.Day, i, Desde)
        End Function
        Public Shared Function BuscarSabadodelMes(ByVal Sabado As Date) As Integer
            Dim i As Integer
            Dim Sabados As Integer, Desde As Date, Hasta As Date
            Desde = New Date(Year(Sabado), Month(Sabado), 1)
            Hasta = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, Desde))
            Sabados = 0
            For i = 0 To DateDiff(DateInterval.Day, Desde, Hasta)
                If Weekday(DateAdd(DateInterval.Day, i, Desde)) = 7 Then ' Sabados
                    Sabados += 1
                    If DateAdd(DateInterval.Day, i, Desde) = Sabado Then
                        Exit For
                    End If
                End If

            Next

            Return Sabados
        End Function


        Public Shared Function ExportarTXT(ByVal Tablas As DataTable, ByVal Q As String, ByVal Longitud As Integer) As Boolean
            Dim i As Integer

            Dim objStreamWriter As StreamWriter = New StreamWriter(Q, False, System.Text.Encoding.Default) 'File.CreateText(Q)
            objStreamWriter.Flush()

            For i = 0 To Tablas.Rows.Count - 1
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Microsoft.VisualBasic.Left(Tablas.Rows(i)("Linea"), Longitud))
            Next
            objStreamWriter.Close()
            Return True
        End Function


        'Public Shared Function Exportar_Archivo(ByVal Tablas As DataTable, ByVal Nombre As String) As Boolean
        '    Dim i, j As Integer
        '    Dim Cadena As String

        '    'If File.Exists(Application.StartupPath() & "\exportfiles\" & Nombre & ".txt") Then
        '    '    If MsgBox("Ya existe un archivo: " & Nombre & ". Desea Sobreescribirlo? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '    '        Return False
        '    '        Exit Function
        '    '    End If
        '    'End If

        '    Dim objStreamWriter As StreamWriter = File.CreateText(Application.StartupPath() & "\exportfiles\" & Nombre & ".txt")
        '    objStreamWriter.Flush()

        '    For i = 0 To Tablas.Rows.Count - 1
        '        Cadena = ""
        '        For j = 0 To Tablas.Columns.Count - 1
        '            Cadena = Cadena & "," & Tablas.Rows(i)(j).ToString
        '        Next
        '        objStreamWriter.WriteLine(Cadena)
        '    Next
        '    objStreamWriter.Close()
        '    Return True
        'End Function

        Public Shared Function Exportar_DBF(ByVal Directorio As String, ByVal Nombre As String, ByVal DT As DataTable) As Boolean
            Dim conn As New OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directorio & ";Extended Properties=dBASE IV;User ID=Admin;Password=;"
            Dim cTabla As New OleDbCommand("Create Table " & Nombre & " (codcta varchar(20), subcta varchar(20), conesp varchar(100), Debitos float, Creditos Float)", conn)
            Dim adTabla As New OleDbDataAdapter(cTabla)
            'borrar si existe
            If File.Exists(Directorio + Nombre + ".dbf") Then
                File.Delete(Directorio + Nombre + ".dbf")
            End If
            'Crear la tabla

            Try
                conn.Open()
                adTabla.SelectCommand.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception

                'Llenar la tabla

            End Try
            Dim cInsertar As New OleDbCommand("Insert into " & Nombre & "(codcta, subcta, conesp, Debitos, Creditos) Values(@P1, @P2, @P3, @P4, @P5)", conn)
            cInsertar.Parameters.Add("@P1", OleDbType.VarChar, 20)
            cInsertar.Parameters.Add("@P2", OleDbType.VarChar, 20)
            cInsertar.Parameters.Add("@P3", OleDbType.VarChar, 100)
            cInsertar.Parameters.Add("@P4", OleDbType.Decimal, 10)
            cInsertar.Parameters.Add("@P5", OleDbType.Decimal, 10)
            Try
                conn.Open()
                For i As Integer = 0 To DT.Rows.Count - 1
                    cInsertar.Parameters("@P1").Value = DT.Rows(i)("Cuenta")
                    cInsertar.Parameters("@P2").Value = DT.Rows(i)("SubCuenta")
                    cInsertar.Parameters("@P3").Value = DT.Rows(i)("mov_concepto")
                    cInsertar.Parameters("@P4").Value = DT.Rows(i)("debito")
                    cInsertar.Parameters("@P5").Value = DT.Rows(i)("credito")
                    cInsertar.ExecuteNonQuery()
                Next
                conn.Close()
            Catch ex As Exception

            End Try

        End Function

        Public Shared Function Exportar_Archivo_Almori(ByVal Tablas As DataTable, ByVal Nombre As String, Optional ByVal Tipo As String = ".txt") As Boolean
            Dim i, j As Integer
            Dim Cadena As String

            'If File.Exists(Application.StartupPath() & "\exportfiles\" & Nombre & ".txt") Then
            '    If MsgBox("Ya existe un archivo: " & Nombre & ". Desea Sobreescribirlo? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            '        Return False
            '        Exit Function
            '    End If
            'End If

            Dim objStreamWriter As StreamWriter = File.CreateText(IIf(Tipo = "", "", Application.StartupPath() & "\exportfiles\") & Nombre & Tipo)
            objStreamWriter.Flush()
            If Tipo = "" Then
                Cadena = "Account, Debit, Credit, Memo, Department"
                objStreamWriter.WriteLine(Cadena)
            End If
            For i = 0 To Tablas.Rows.Count - 1
                Cadena = ""
                For j = 0 To Tablas.Columns.Count - 1
                    Cadena = Cadena & IIf(Cadena = "" And j = 0, "", ",") & Tablas.Rows(i)(j).ToString
                Next
                Cadena = Cadena & ","
                objStreamWriter.WriteLine(Cadena)
            Next
            objStreamWriter.Close()
            Return True
        End Function

        Public Shared Function Exportar_Archivo_TXT(ByVal Tablas As DataTable, ByVal Nombre As String, Optional ByVal Tipo As String = ".txt") As Boolean
            Dim i, j As Integer
            Dim Cadena As String

            Dim objStreamWriter As StreamWriter = File.CreateText(IIf(Tipo = "", "", Application.StartupPath() & "\exportfiles\") & Nombre & Tipo)
            objStreamWriter.Flush()
            If Tipo = "" Then
                Cadena = "Cuenta, Debito, Credito, Memo"
                objStreamWriter.WriteLine(Cadena)
            End If
            'dt1.Columns("SubCuenta").ColumnName = "Account"
            'dt1.Columns("debito").ColumnName = "Debit"
            'dt1.Columns("credito").ColumnName = "Credit"
            'dt1.Columns("mov_concepto").ColumnName = "Memo"

            For i = 0 To Tablas.Rows.Count - 1
                Cadena = ""
                For j = 0 To Tablas.Columns.Count - 1
                    Cadena = Tablas.Rows(i)("Cuenta").ToString & "," & _
                            Tablas.Rows(i)("debito").ToString & "," & _
                            Tablas.Rows(i)("credito").ToString & "," & _
                            Tablas.Rows(i)("mov_concepto").ToString
                Next
                objStreamWriter.WriteLine(Cadena)
            Next
            objStreamWriter.Close()
            Return True
        End Function

        Public Shared Function ExportarTXT_Tab(ByVal Tablas As DataTable, ByVal Q As String) As Boolean
            Dim i As Integer
            Dim Cadena As String
            Dim objStreamWriter As StreamWriter = New StreamWriter(Q, False, System.Text.Encoding.Default) 'File.CreateText(Q)
            objStreamWriter.Flush()

            For i = 0 To Tablas.Rows.Count - 1
                Cadena = Tablas.Rows(i)("identificador") & vbTab & _
                    Tablas.Rows(i)("nombre") & vbTab & _
                    Tablas.Rows(i)("arecibir")
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Cadena)
            Next
            objStreamWriter.Close()
            Return True
        End Function



        Public Shared Function Exportar_Archivo(ByVal Tablas As DataTable, ByVal Nombre As String, Optional ByVal Tipo As String = ".txt") As Boolean
            Dim i, j As Integer
            Dim Cadena As String

            Dim objStreamWriter As StreamWriter = File.CreateText(IIf(Tipo = "", "", Application.StartupPath() & "\exportfiles\") & Nombre & Tipo)
            objStreamWriter.Flush()
            For i = 0 To Tablas.Rows.Count - 1
                Cadena = ""
                For j = 0 To Tablas.Columns.Count - 1
                    Cadena = Cadena & IIf(Cadena = "" And j = 0, "", ",") & Tablas.Rows(i)(j).ToString
                Next
                Cadena = Cadena & ","
                objStreamWriter.WriteLine(Cadena)
            Next
            objStreamWriter.Close()
            Return True
        End Function


        Public Shared Function ExportarTXT_Banco(ByVal Tablas As DataTable, ByVal Q As String, ByVal Servicio As String) As Boolean
            Dim i As Integer

            If File.Exists(Application.StartupPath() & "\exportfiles\PE_" & Servicio & ".prn") Then

            End If

            Dim objStreamWriter As StreamWriter = New StreamWriter(Application.StartupPath() & "\exportfiles\PE_" & Servicio & ".prn", False, System.Text.Encoding.Default)
            objStreamWriter.Flush()

            For i = 0 To Tablas.Rows.Count - 1
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Microsoft.VisualBasic.Left(Tablas.Rows(i)("Linea"), 122))
            Next
            objStreamWriter.Close()
            Return True
        End Function
        Public Shared Function ExportarTXT_Banco(ByVal Tablas As DataTable, ByVal Q As String, ByVal Servicio As String, ByVal conSFD As Boolean) As Boolean
            Dim i As Integer

            If File.Exists(Servicio) Then

            End If

            Dim objStreamWriter As StreamWriter = New StreamWriter(Servicio, False, System.Text.Encoding.Default)
            objStreamWriter.Flush()

            For i = 0 To Tablas.Rows.Count - 1
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Microsoft.VisualBasic.Left(Tablas.Rows(i)("Linea"), 122))
            Next
            objStreamWriter.Close()
            Return True
        End Function


        Public Function Deglose(ByVal Cantidad As Double) As Array

            Dim DegloseMoneda(11, 1), i As Double, lCantidad As Double
            lCantidad = Math.Round(Cantidad, 2)
            For i = 0 To 11
                DegloseMoneda(i, 0) = Billetes(i)
                DegloseMoneda(i, 1) = Fix(Math.Round((lCantidad / DegloseMoneda(i, 0)), 2))
                lCantidad = Math.Round(lCantidad Mod DegloseMoneda(i, 0), 2)
            Next
            Return DegloseMoneda

        End Function
        Public Shared Sub OcultarMenu(ByVal control As Form)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is GroupBox Then
                    control.Controls.Item(i).Visible = False
                End If
            Next
        End Sub

        'Funcion para limpiar los elementos de un formulario
        Public Shared Sub LimpiarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = ""
                End If
            Next
        End Sub

        Public Sub EstablecerCero(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = "0.00"
                End If
            Next
        End Sub

        Public Sub DeshabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = False
                End If
            Next
        End Sub

        Public Sub HabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = True
                End If
            Next
        End Sub



        Public Shared Function FormatGenerico(ByVal Grilla As DataGrid, ByVal fuente As DataTable) As Boolean
            Dim i As Integer = 0
            Grilla.TableStyles.Clear()
            Dim EstiloGrilla As New DataGridTableStyle()

            EstiloGrilla.MappingName = fuente.TableName()
            'Estilo de la Grilla, para la tabla maestra de terceros de facturación
            Dim column As New DataGridTextBoxColumn()
            Dim column2 As New NumericUpDown()

            Dim fila1 As DataRow = fuente.NewRow()
            'Dim fila As DataGridTableStyle
            'Dim column1 As DataGrid
            'fuente.Rows.Add(fila1)

            While i < fuente.Columns.Count
                If fuente.Columns(i).Caption <> "." Then
                    ' defaults
                    column = New DataGridTextBoxColumn()
                    column.MappingName = fuente.Columns(i).ColumnName

                    column.HeaderText = fuente.Columns(i).Caption
                    column.Width = fuente.Columns(i).Caption.Length * 20
                    column.NullText = ""
                    column.ReadOnly = True

                    If column.MappingName.ToUpper = "TERROR" Then
                        column.Width = 600
                    End If

                    If fuente.TableName.ToUpper = "AFISCAL" And Grilla.Name.ToUpper = "DGAFISCAL" Then
                        If column.MappingName.ToUpper = "EMPR_CODIGO" Or _
                            column.MappingName.ToUpper = "EMP_CODIGO" Or _
                            column.MappingName.ToUpper = "PER_ANIOFISCAL" Then
                            Exit While
                        End If

                        If column.MappingName.ToUpper = "MES" Then
                            column.Width = 200
                        End If
                    End If

                    If fuente.TableName.ToUpper = "PLANILLA" And Grilla.Name.ToUpper = "DGEMPLEADOS" Then
                        If column.MappingName.ToUpper = "EMPR_CODIGO" Or _
                            column.MappingName.ToUpper = "EMP_CODIGO" Or _
                            column.MappingName.ToUpper = "PLA_CODIGO" Or _
                            column.MappingName.ToUpper = "PLA_TIPO" Or _
                            column.MappingName.ToUpper = "LLAVE" Then
                            Exit While
                        End If

                    End If

                    If fuente.TableName = "PlanillaDetalle" And Grilla.Name.ToUpper = "DGDETALLE" Then
                        If column.MappingName.ToUpper = "EMPR_CODIGO" Or _
                            column.MappingName.ToUpper = "EMP_CODIGO" Or _
                            column.MappingName.ToUpper = "PLA_CODIGO" Or _
                            column.MappingName.ToUpper = "PLA_TIPO" Or _
                            column.MappingName.ToUpper = "MOV_CODIGO" Or _
                            column.MappingName.ToUpper = "MOV_CUOTA" Or _
                            column.MappingName.ToUpper = "MOV_TIPO" Or _
                            column.MappingName.ToUpper = "LLAVE" Then
                            Exit While
                        End If

                    End If

                    If column.MappingName.ToUpper = "PER_PROCESADO" Then
                        column.HeaderText = "Periodo Procesado"
                        column.Width = 150
                    End If
                    If column.MappingName.ToUpper = "PER_REVISADO" Then
                        column.HeaderText = "Periodo Revisado"
                        column.Width = 150
                    End If
                    If column.MappingName.ToUpper = "PER_APROBADO" Then
                        column.HeaderText = "Periodo Aprobado"
                        column.Width = 150
                    End If
                    If column.MappingName.ToUpper = "PER_CONTABILIZADO" Then
                        column.HeaderText = "Periodo Contabilizado"
                        column.Width = 150
                    End If

                    If column.MappingName.ToUpper = "SBASICO" Or _
                        Right(column.MappingName.ToUpper, 7) = "SBASICO" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Salario Basico"
                    End If

                    If column.MappingName.ToUpper = "ANTIGUEDAD" Or _
                        Right(column.MappingName.ToUpper, 10) = "ANTIGUEDAD" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Antiguedad"
                    End If

                    If column.MappingName.ToUpper = "IR" Or _
                        Right(column.MappingName.ToUpper, 3) = "_IR" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "IR"

                    End If

                    If column.MappingName.ToUpper = "INSS" Or _
                        Right(column.MappingName.ToUpper, 5) = "_INSS" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "INSS"
                    End If
                    If column.MappingName.ToUpper = "INSSPATRONAL" Or _
                        Right(column.MappingName.ToUpper, 12) = "INSSPATRONAL" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "INSS Patronal"
                    End If

                    If column.MappingName.ToUpper = "TINGRESOS" Or _
                        Right(column.MappingName.ToUpper, 9) = "TINGRESOS" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Total Ingresos"
                    End If

                    If column.MappingName.ToUpper = "TEGRESOS" Or _
                        Right(column.MappingName.ToUpper, 8) = "TEGRESOS" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Total Egresos"
                    End If
                    If column.MappingName.ToUpper = "INGRESO" Or _
                        Right(column.MappingName.ToUpper, 7) = "INGRESO" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Ingreso"
                    End If

                    If column.MappingName.ToUpper = "EGRESO" Or _
                        Right(column.MappingName.ToUpper, 6) = "EGRESO" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Egreso"
                    End If

                    If column.MappingName.ToUpper = "A_RECIBIR" Or _
                        Right(column.MappingName.ToUpper, 9) = "A_RECIBIR" Then
                        column.Width = 100
                        column.Format = "#,###,###,##0.00"
                        column.Alignment = HorizontalAlignment.Right
                        column.HeaderText = "Total a Recibir"
                    End If

                    If column.MappingName.ToUpper = "FINICIO" Or _
                        Right(column.MappingName.ToUpper, 7) = "FINICIO" Then
                        column.Width = 100
                        column.Format = "dd/MM/yyyy"
                        column.HeaderText = "Fecha Inicio"
                    End If
                    If column.MappingName.ToUpper = "FECHA" Or _
                        Right(column.MappingName.ToUpper, 7) = "FECHA" Then
                        column.Width = 100
                        column.Format = "dd/MM/yyyy"
                        column.HeaderText = "Fecha"
                    End If

                    If column.MappingName.ToUpper = "FFINAL" Or _
                        Right(column.MappingName.ToUpper, 6) = "FFINAL" Then
                        column.Width = 100
                        column.Format = "dd/MM/yyyy"
                        column.HeaderText = "Fecha Final"
                    End If

                    If column.MappingName.ToUpper = "HINICIO" Or _
                        Right(column.MappingName.ToUpper, 7) = "HINICIO" Then
                        column.Width = 100
                        column.Format = "hh:mm tt"
                        column.HeaderText = "Hora Inicio"
                    End If

                    If column.MappingName.ToUpper = "HFINAL" Or _
                        Right(column.MappingName.ToUpper, 6) = "HFINAL" Then
                        column.Width = 100
                        column.Format = "hh:mm tt"
                        column.HeaderText = "Hora Final"
                    End If


                    If column.MappingName.ToUpper = "NOMBRE" Or _
                        Right(column.MappingName.ToUpper, 6) = "NOMBRE" Then
                        column.Width = 350
                        column.HeaderText = "Nombre"
                    End If

                    If column.MappingName.ToUpper = "DESCRIPCION" Or _
                        Right(column.MappingName.ToUpper, 11) = "DESCRIPCION" Then
                        column.HeaderText = "Descripcion"
                        If fuente.TableName.ToUpper = "PERIODONOMINA" Then
                            column.Width = 250
                        Else
                            column.Width = 350
                        End If

                    End If
                    If column.MappingName.ToUpper = "DIRECCION" Or _
                        Right(column.MappingName.ToUpper, 9) = "DIRECCION" Then
                        column.Width = 350
                        column.HeaderText = "Direccion"
                    End If

                    If column.MappingName.ToUpper = "MES" And fuente.TableName.ToUpper <> "AFISCAL" Then
                        column.HeaderText = "Código"
                        column.Width = 160
                    End If


                    If column.MappingName.ToUpper = "CODIGO" Or _
                        Right(column.MappingName.ToUpper, 6) = "CODIGO" Then
                        column.Width = 100
                        column.HeaderText = "Codigo"

                    End If

                    If column.MappingName.ToUpper = "EMPLEADO" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                        Else
                            column.Width = 200
                        End If
                    End If

                    If column.MappingName.ToUpper = "QUINCENA" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 100
                        End If
                    End If

                    If column.MappingName.ToUpper = "AUTORIZADAS" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                            column.ReadOnly = False
                        End If
                    End If

                    If column.MappingName.ToUpper = "SOLICITADAS" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                        End If
                    End If


                    If column.MappingName.ToUpper = "NUMERO_MES" Or _
                        column.MappingName.ToUpper = "NOMBRE_EMPLEADO" Or _
                        column.MappingName.ToUpper = "NUMERO" Then
                        column.Width = 0
                    End If






                    If column.MappingName.ToUpper = "ENTRADA" Then
                        'column.HeaderText = "Entrada " & Chr(13) & fuente.Columns(i).Caption
                        Select Case Grilla.Name.ToUpper
                            Case Is <> "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 100
                            Case Is = "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Format = "hh:mm tt"
                                column.Width = 150
                            Case Is = "DGDETALLE"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 150
                        End Select
                    End If


                    If column.MappingName.ToUpper = "SALIDA" Then
                        Select Case Grilla.Name.ToUpper
                            Case Is = "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Format = "hh:mm tt"
                                column.Width = 150
                            Case Is = "DGDETALLE"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 150

                        End Select
                    End If

                    If column.MappingName.ToUpper = "DIA" Then
                        column.ReadOnly = True
                        'column.Alignment = HorizontalAlignment.Right
                        'column.Width = 150

                    End If


                    EstiloGrilla.GridColumnStyles.Add(column)

                End If
                i += 1
            End While

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Grilla.TableStyles.Clear()
            If Grilla.Name = "dgTasaCambio" Or Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Then
                EstiloGrilla.AllowSorting = False
                If Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Then

                    Dim fila As DataRow = fuente.NewRow()

                    '
                    Dim filaPresupuesto As DataRow = fuente.NewRow()
                    Dim filaDebe As DataRow = fuente.NewRow()
                    Dim filaHaber As DataRow = fuente.NewRow()
                    Dim filaSaldo As DataRow = fuente.NewRow()

                    Dim x As Integer
                    Dim total As Double

                    Dim TotalPresupuesto As Double
                    Dim TotalDebe As Double
                    Dim TotalHaber As Double
                    Dim TotalSaldo As Double

                    Dim TotalVentas As Double
                    Dim TotalComisiones As Double

                    Dim TotalEntradas As Double
                    Dim TotalUnidades As Double
                    Dim TotalUnidadesEntrada As Double

                    Dim TotalServicios As Double
                    Dim TotalServiciosValor As Double

                    total = 0

                    TotalPresupuesto = 0
                    TotalDebe = 0
                    TotalHaber = 0
                    TotalSaldo = 0

                    TotalVentas = 0
                    TotalComisiones = 0

                    TotalUnidades = 0

                    TotalEntradas = 0
                    TotalUnidadesEntrada = 0

                    TotalServicios = 0
                    TotalServiciosValor = 0

                    If Grilla.Name = "dgCatalogoAcumulados" Then
                        For x = 0 To fuente.Rows.Count - 1
                            'If dsFicha.Tables("Tabla").Rows(0).Item("Cargo_anterior") Is DBNull.Value Then
                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                TotalPresupuesto = TotalPresupuesto + Grilla.Item(x, 1)
                            End If

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalDebe = TotalDebe + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalHaber = TotalHaber + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalSaldo = TotalSaldo + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                total = total + Grilla.Item(x, 1)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Presupuesto") = TotalPresupuesto
                        fila("Debe") = TotalDebe
                        fila("Haber") = TotalHaber
                        fila("Saldo") = TotalSaldo

                        'fila("Numero_Mes") = 13

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumulados" Then

                        For x = 0 To fuente.Rows.Count - 1
                            'If dsFicha.Tables("Tabla").Rows(0).Item("Cargo_anterior") Is DBNull.Value Then

                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                total = total + Grilla.Item(x, 1)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Monto") = total

                        'fila("Numero_Mes") = 13

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgVentas" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalComisiones = TotalComisiones + Grilla.Item(x, 3)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Ventas") = TotalVentas
                        fila("Comision") = TotalComisiones

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumuladosProductos" Then
                        For x = 0 To fuente.Rows.Count - 1

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidadesEntrada = TotalUnidadesEntrada + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalEntradas = TotalEntradas + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidades = TotalUnidades + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 6) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 6)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Unidades") = TotalUnidades
                        fila("Valor") = TotalVentas
                        fila("Entrada") = TotalUnidadesEntrada
                        fila("Valor_Entrada") = TotalEntradas

                        fuente.Rows.Add(fila)

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)
                    ElseIf Grilla.Name = "dgVentasServicios" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalServicios = TotalServicios + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalServiciosValor = TotalServiciosValor + Grilla.Item(x, 4)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Unidades") = TotalServicios
                        fila("Valor") = TotalServiciosValor

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    End If
                End If

            End If

            Grilla.TableStyles.Add(EstiloGrilla)

            'Grilla.TableStyles.Item(0).BackColor = Grilla.BackColor.CadetBlue
            Grilla.TableStyles.Item(0).BackColor = Drawing.Color.FromArgb(225, 236, 236) 'Grilla.BackColor.FromArgb(200, 223, 212)
            Grilla.TableStyles.Item(0).GridLineColor = Drawing.Color.SteelBlue
            Grilla.TableStyles.Item(0).HeaderBackColor = Drawing.Color.LightSteelBlue

            'Grilla = Grilla.BackColor.FromArgb(255, 0, 0)


            'Grilla.TableStyles.Item(0).

            'Grilla.TableStyles.Item(0). = Grilla.BackColor.CadetBlue
            'Grilla.TableStyles.Item(0).RowHeadersVisible = False
            'Grilla.TableStyles.Item(0).RowHeaderWidth = 10

        End Function

        ' Al estar declarado como Shared, podemos usarlo sin crear
        ' una instancia de la clase
        Public Shared Sub CambiarEstilo(ByVal tControl As Control)
            ' Cambiar el estilo del control...
            ' sólo si es uno de los indicados
            Select Case tControl.GetType.Name
                ''''''Case "Label"
                ''''''    CType(tControl, Label).FlatStyle = FlatStyle.System
                Case "CheckBox"
                    CType(tControl, CheckBox).FlatStyle = FlatStyle.System
                Case "RadioButton"
                    CType(tControl, RadioButton).FlatStyle = FlatStyle.System
                Case "Button"
                    ' Si el botón tiene asignada la propiedad Image     (11/Oct/02)
                    ' no cambiarlo...
                    Dim tButton As Button = CType(tControl, Button)
                    If tButton.Image Is Nothing Then
                        tButton.FlatStyle = FlatStyle.System
                    End If
                Case "GroupBox"
                    CType(tControl, GroupBox).FlatStyle = FlatStyle.System
            End Select
            '
            ' Cambiar también los controles contenidos en cada control...
            If tControl.Controls.Count > 0 Then
                Dim tControl2 As Control
                '
                For Each tControl2 In tControl.Controls
                    CambiarEstilo(tControl2)
                Next
            End If
        End Sub

        'Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)

        '    Dim s As String
        '    s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        '    Console.WriteLine(s)

        'End Sub

        'Private Sub etProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etProveedores.MouseEnter
        '    etProveedores.BackColor = etGenerales.BackColor.White
        '    etProveedores.ForeColor = etGenerales.BackColor.FromArgb(0, 51, 102)

        'End Sub

        Public Shared Sub EntrarMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Drawing.Color.White
            Etiqueta.ForeColor = Drawing.Color.FromArgb(0, 51, 102)

        End Sub

        Public Shared Sub SalirMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Drawing.Color.FromArgb(0, 51, 102)
            Etiqueta.ForeColor = Drawing.Color.White
        End Sub



        Public Shared Function ConversionDecimales(ByVal nnumero As Double) As String


            Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
            Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
            Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                        "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
            Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
            Dim num2, letra, ls_decimal As String ', auxlinea As String
            'string UNIDAD[10],DECENA[10],CENTENA[10],EXCEPCION[5]
            Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

            If nnumero = 0 Then
                letra = "CERO "
                Return letra
            End If



            num2 = CStr(Math.Round(nnumero, 2))

            n100000000 = Int(nnumero / 100000000)
            nnumero = nnumero - n100000000 * 100000000
            n10000000 = Int(nnumero / 10000000)
            nnumero = nnumero - n10000000 * 10000000
            n1000000 = Int(nnumero / 1000000)
            nnumero = nnumero - n1000000 * 1000000
            n100000 = Int(nnumero / 100000)
            nnumero = nnumero - n100000 * 100000
            n10000 = Int(nnumero / 10000)
            nnumero = nnumero - n10000 * 10000
            n1000 = Int(nnumero / 1000)
            nnumero = nnumero - n1000 * 1000
            n100 = Int(nnumero / 100)
            nnumero = nnumero - n100 * 100
            n10 = Int(nnumero / 10)
            nnumero = nnumero - n10 * 10
            n = Int(nnumero)

            'real en pb???

            n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
            n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
            n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
            n100000 = CDbl(CStr(Math.Round(n100000, 2)))
            n10000 = CDbl(CStr(Math.Round(n10000, 2)))
            n1000 = CDbl(CStr(Math.Round(n1000, 2)))
            n100 = CDbl(CStr(Math.Round(n100, 2)))
            n10 = CDbl(CStr(Math.Round(n10, 2)))
            n = CDbl(CStr(Math.Round(n, 2)))

            num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


            nnumero = CDbl(Right(num2, 2))
            '  MILLONES
            If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
                letra = "CIEN "
            Else
                If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                    letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
                Else
                    letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                    If n1000000 <> 0 And n10000000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000000 + 1)
                End If
            End If
            If letra Is Nothing Or n1000000 <> 0 Then
                If n1000000 = 1 Then
                    letra = letra + "MILLON "
                Else
                    letra = letra + "MILLONES "
                End If
            End If

            'MILES
            If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
                letra = letra + "CIEN "
            Else
                If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                    letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
                Else
                    letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                    If n1000 <> 0 And n10000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000 + 1)
                End If
            End If
            If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
                letra = letra + "MIL "
            End If
            If n100 = 1 And n10 = 0 And n = 0 Then
                letra = letra + "CIEN "
            Else
                If n10 = 1 And n > 0 And n <= 5 Then
                    letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
                Else
                    letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                    If n <> 0 And n10 <> 0 Then
                        Select Case n10
                            Case 1
                                Select Case n
                                    Case 6, 7, 8, 9
                                        letra = Left(letra, Len(letra) - 2)
                                        letra = letra + "CI"
                                End Select
                            Case 2
                                letra = Left(letra, Len(letra) - 2)
                                letra = letra + "I"
                            Case Else
                                letra = letra + "Y "
                        End Select

                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n + 1)
                    If n = 1 And (n10 = 1 Or n10 = 2) Then
                        letra = Left(letra, Len(letra) - 1)
                        letra = letra
                    End If

                End If
            End If


            ''''''
            If nnumero < 10 Then
                ls_decimal = "0" + CStr(nnumero)
            Else
                ls_decimal = CStr(nnumero)
            End If

            letra = letra + ls_decimal + "/100"
            'linea1 = letra
            'If Len(Trim(letra)) < 50 Then
            '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
            'Else
            '    linea1 = linea1 + ""
            'End If

            'linea2 = linea2.PadRight(22, "*")
            'If Len(linea1) > 65 Then
            '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
            '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
            '    linea1 = auxlinea
            'End If

            Return letra
        End Function

        Public Shared Function ConversionEnteros(ByVal nnumero As Double) As String


            Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
            Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
            Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                        "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
            Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
            Dim num2, letra As String 'auxlinea, ls_decimal As String

            Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

            If nnumero = 0 Then
                letra = "CERO "
                Return letra
            End If

            num2 = CStr(Math.Round(nnumero, 2))

            n100000000 = Int(nnumero / 100000000)
            nnumero = nnumero - n100000000 * 100000000
            n10000000 = Int(nnumero / 10000000)
            nnumero = nnumero - n10000000 * 10000000
            n1000000 = Int(nnumero / 1000000)
            nnumero = nnumero - n1000000 * 1000000
            n100000 = Int(nnumero / 100000)
            nnumero = nnumero - n100000 * 100000
            n10000 = Int(nnumero / 10000)
            nnumero = nnumero - n10000 * 10000
            n1000 = Int(nnumero / 1000)
            nnumero = nnumero - n1000 * 1000
            n100 = Int(nnumero / 100)
            nnumero = nnumero - n100 * 100
            n10 = Int(nnumero / 10)
            nnumero = nnumero - n10 * 10
            n = Int(nnumero)

            'real en pb???

            n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
            n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
            n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
            n100000 = CDbl(CStr(Math.Round(n100000, 2)))
            n10000 = CDbl(CStr(Math.Round(n10000, 2)))
            n1000 = CDbl(CStr(Math.Round(n1000, 2)))
            n100 = CDbl(CStr(Math.Round(n100, 2)))
            n10 = CDbl(CStr(Math.Round(n10, 2)))
            n = CDbl(CStr(Math.Round(n, 2)))

            num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


            nnumero = CDbl(Right(num2, 2))
            '  MILLONES
            If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
                letra = "CIEN "
            Else
                If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                    letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
                Else
                    letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                    If n1000000 <> 0 And n10000000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000000 + 1)
                End If
            End If
            If letra Is Nothing Or n1000000 <> 0 Then
                If n1000000 = 1 Then
                    letra = letra + "MILLON "
                Else
                    letra = letra + "MILLONES "
                End If
            End If

            'MILES
            If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
                letra = letra + "CIEN "
            Else
                If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                    letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
                Else
                    letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                    If n1000 <> 0 And n10000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000 + 1)
                End If
            End If
            If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
                letra = letra + "MIL "
            End If
            If n100 = 1 And n10 = 0 And n = 0 Then
                letra = letra + "CIEN "
            Else
                If n10 = 1 And n > 0 And n <= 5 Then
                    letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
                Else
                    letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                    If n <> 0 And n10 <> 0 Then
                        Select Case n10
                            Case 1
                                Select Case n
                                    Case 6, 7, 8, 9
                                        letra = Left(letra, Len(letra) - 2)
                                        letra = letra + "CI"
                                End Select
                            Case 2
                                letra = Left(letra, Len(letra) - 2)
                                letra = letra + "I"
                            Case Else
                                letra = letra + "Y "
                        End Select

                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n + 1)
                    If n = 1 And (n10 = 1 Or n10 = 2) Then
                        letra = Left(letra, Len(letra) - 1)
                        letra = letra
                    End If

                End If
            End If


            'If nnumero < 10 Then
            '    ls_decimal = CStr(nnumero)
            'Else
            '    ls_decimal = CStr(nnumero)
            'End If
            'letra = letra
            'linea1 = letra
            'If Len(Trim(letra)) < 50 Then
            '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
            'Else
            '    linea1 = linea1 + ""
            'End If

            'linea2 = linea2.PadRight(22, "*")
            'If Len(linea1) > 65 Then

            '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
            '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
            '    linea1 = auxlinea
            'End If


            Return letra
        End Function


    End Class

End Namespace
