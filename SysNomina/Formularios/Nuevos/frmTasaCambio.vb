Imports System.IO
Imports System.Xml

Public Class frmTasaCambio

    Dim DEmpresa As New VB.SysContab.EmpresasDetails()
    Dim A As Integer, M As Integer, MB As String, MC As String
    Private Sub frmTasaCambio_Load(sender As Object, e As EventArgs) Handles Me.Load

        DEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        cbmonedabase.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbmonedabase.Properties.ValueMember = "Codigo"
        cbmonedabase.Properties.DisplayMember = "Descripcion"

        cbmonedacambio.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbmonedacambio.Properties.ValueMember = "Codigo"
        cbmonedacambio.Properties.DisplayMember = "Descripcion"

        Me.cbanios.Properties.DataSource = VB.SysContab.Tasa_CambioDB.GetAnios()
        Me.cbanios.Properties.ValueMember = "anio"
        Me.cbanios.Properties.DisplayMember = "anio"


    End Sub
    Private Sub cargar()
        A = Me.cbanios.EditValue
        M = Me.cbmes.SelectedIndex + 1
        MB = Me.cbmonedabase.EditValue
        MC = Me.cbmonedacambio.EditValue

        ShowSplash()
        Me.gcTc.DataSource = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(Me.cbmes.SelectedIndex + 1, Me.cbanios.EditValue, Me.cbmonedabase.EditValue, Me.cbmonedacambio.EditValue).Tables(0)
        Me.GridView1.Columns("Dia").OptionsColumn.ReadOnly = True
        HideSplash()
    End Sub
    Private Function Validar() As Boolean
        If Me.cbanios.EditValue Is Nothing Then
            MsgBox("Seleccione el año por favor")
            Return False
            Exit Function
        End If
        If Me.cbanios.EditValue Is DBNull.Value Then
            MsgBox("Seleccione el año por favor")
            Return False
            Exit Function
        End If

        If Me.cbmes.EditValue Is Nothing Then
            MsgBox("Seleccione el Mes")
            Return False
            Exit Function
        End If
        If Me.cbmes.EditValue Is DBNull.Value Then
            MsgBox("Seleccione el Mes")
            Return False
            Exit Function
        End If

        If Me.cbmonedabase.EditValue Is Nothing Then
            MsgBox("Seleccione la Moneda base")
            Return False
            Exit Function
        End If
        If Me.cbmonedabase.EditValue Is DBNull.Value Then
            MsgBox("Seleccione la Moneda base")
            Return False
            Exit Function
        End If

        If Me.cbmonedacambio.EditValue Is Nothing Then
            MsgBox("Seleccione la Moneda de Cambio")
            Return False
            Exit Function
        End If
        If Me.cbmonedacambio.EditValue Is DBNull.Value Then
            MsgBox("Seleccione la Moneda de Cambio")
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        If Validar() = True Then
            cargar()
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ''Tasa de Cambio
        Dim nArchivo As String
        Dim myStream As Stream = Nothing
        Dim xmlds As New DataSet
        myStream = Nothing
        Me.OFD.InitialDirectory = Application.StartupPath()

        Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
        Me.OFD.FilterIndex = 1


        If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = Me.OFD.OpenFile()
            Catch Ex As Exception
                MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If Not IsNothing(myStream) Then
                    nArchivo = Me.OFD.FileName
                    'myStream.Close()
                    xmlds = New DataSet()
                    If VB.SysContab.DocumentosDB.Leer_Archivo(nArchivo, xmlds) = -1 Then  'xmlds =VB.SysContab.RutinasNomina.LeerXML(nArchivo)
                        MsgBox("Error al cargar el archivo")
                    End If
                End If
            End Try
        End If
        If IsNothing(myStream) Then
            Exit Sub
        End If
        ShowSplash()
        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "fecha" Then
            MsgBox("El nombre del primer campo debe ser <Fecha>", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "valor" Then
            MsgBox("El nombre del segundo campo debe ser <Valor>", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        Dim Errores As New DataSet()
        Errores = xmlds.Clone()
        Errores.Tables(0).Columns.Add("TError")
        Dim dTC As New VB.SysContab.Tasa_CambioDetails()
        For i = 0 To xmlds.Tables(0).Rows.Count - 1
            If Not IsDate(xmlds.Tables(0).Rows(i)("fecha")) Then
                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Fecha Inválida"
                GoTo ContinueT
            End If
            If Not IsNumeric(xmlds.Tables(0).Rows(i)("valor")) Then
                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Numero de formato inválido"
                GoTo ContinueT
            End If
            dTC = VB.SysContab.Tasa_CambioDB.GetDetails(DEmpresa.MONEDABASE, Me.cbmonedacambio.EditValue, _
                     DatePart(DateInterval.Day, xmlds.Tables(0).Rows(i)("fecha")), _
                     DatePart(DateInterval.Month, xmlds.Tables(0).Rows(i)("fecha")), _
                     DatePart(DateInterval.Year, xmlds.Tables(0).Rows(i)("fecha")))
            If dTC.MonedaBase Is Nothing Then
                'no lo encontro
                VB.SysContab.Tasa_CambioDB.Additem(DEmpresa.MONEDABASE, Me.cbmonedacambio.EditValue, _
                     DatePart(DateInterval.Day, xmlds.Tables(0).Rows(i)("fecha")), _
                     DatePart(DateInterval.Month, xmlds.Tables(0).Rows(i)("fecha")), _
                     DatePart(DateInterval.Year, xmlds.Tables(0).Rows(i)("fecha")), _
                     xmlds.Tables(0).Rows(i)("valor"))
            Else
                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "La tasa de cambio ya ha sido ingresada para este dia"
                GoTo ContinueT
            End If

ContinueT: Next
        MsgBox("Archivo Importado", MsgBoxStyle.OkOnly, "SysNomina")
        Dim fArchivo(myStream.Length) As Byte
        myStream.Read(fArchivo, 0, myStream.Length)
        VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "T", "", _
            Me.cbmonedacambio.EditValue, _
            New Date(Me.cbanios.EditValue, Me.cbmes.SelectedIndex + 1, 1), _
            0, False, False)
        myStream.Close()
        If Errores.Tables(0).Rows.Count <> 0 Then
            VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")
            gcTc.DataSource = Nothing
            Me.GridView1.Columns.Clear()
            gcTc.DataSource = Errores.Tables(0)
            'dgDetalle.CaptionText = "Errores de Importación de Archivos"
            Me.Refresh()

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.GridView1.Columns(0).Name = "TError" Or Me.gcTc.DataSource.tablename = "Archivo" Then
            Exit Sub
        End If
        If Me.GridView1.DataRowCount = 0 Then
            MsgBox("No hay registros que guardar")
            Exit Sub
        End If
        ShowSplash()
        For i As Integer = 0 To Me.GridView1.DataRowCount - 1
            VB.SysContab.Tasa_CambioDB.Update(MB, MC, Me.GridView1.GetRowCellValue(i, "Dia"), M, A, _
                    Me.GridView1.GetRowCellValue(i, "Tasa Cambio"))
        Next
        HideSplash()
    End Sub

    Private Sub cmdWeb_Click(sender As Object, e As EventArgs) Handles cmdWeb.Click
        If Validar() = False Then
            Exit Sub
        End If

        Try
            'Dim ws As New TCambio.Tipo_Cambio_BCNSoapClient '' ws_tc.Tipo_Cambio_BCN
            Dim ws As New ws_tc.Tipo_Cambio_BCN
            Dim objElement As XmlElement
            Dim xmlNodLista As XmlNodeList
            Dim dt As New DataTable
            ShowSplash()
            'CONSUMIMOS EL SERVICIO
            objElement = ws.RecuperaTC_Mes(Me.cbanios.EditValue, cbmes.SelectedIndex + 1)
            xmlNodLista = objElement.GetElementsByTagName("Tc")

            'AGREGAMOS LAS COLUMNAS AL DATATABLE 
            For Each Node As XmlNode In xmlNodLista.Item(0).ChildNodes
                Dim Col As New DataColumn(Node.Name, System.Type.GetType("System.String"))
                dt.Columns.Add(Col)
            Next

            'AGREGAR LA INFORMACION AL DATATABLE 
            For IntVal As Integer = 0 To xmlNodLista.Count - 1
                Dim dr As DataRow = dt.NewRow
                For Col As Integer = 0 To dt.Columns.Count - 1
                    If Not IsDBNull(xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText) Then
                        dr(Col) = xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText
                    Else
                        dr(Col) = Nothing
                    End If
                Next
                dt.Rows.Add(dr)
            Next
            For i As Integer = 1 To Now.DaysInMonth(Me.cbanios.EditValue, cbmes.SelectedIndex + 1)
                VB.SysContab.Tasa_CambioDB.delete(Me.cbmonedabase.EditValue, Me.cbmonedacambio.EditValue, i, cbmes.SelectedIndex + 1, Me.cbanios.EditValue)
            Next
            '
            For i As Integer = 0 To dt.Rows.Count - 1
                VB.SysContab.Tasa_CambioDB.Additem(Me.cbmonedabase.EditValue, Me.cbmonedacambio.EditValue, _
                     dt.Rows.Item(i)("Dia"), _
                    cbmes.SelectedIndex + 1, Me.cbanios.EditValue, dt.Rows.Item(i)("Valor"))
            Next
            HideSplash()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Consulte su conexión a Internet o llame al administrador del Sistema.", MessageBoxIcon.Error)
        End Try

        cargar()
    End Sub
End Class