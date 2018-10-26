Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Text
Imports System.Xml
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository

Module Utils

    Function PrimerDia(ByVal Fecha As DateTime) As DateTime
        Return DateSerial(Year(Fecha), Month(Fecha), 1)
    End Function

    Function UltimoDia(Fecha As DateTime) As DateTime
        Return DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
    End Function

    Public Sub RegistroGrid(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, _
                            Optional ByVal Form As DevExpress.XtraEditors.XtraForm = Nothing)
        Grid.SaveLayoutToRegistry(Login & Form.Text & Grid.Name)
    End Sub

    Public Sub RegistroPivotGrid(ByRef Grid As DevExpress.XtraPivotGrid.PivotGridControl, _
                                 Optional ByVal Form As DevExpress.XtraEditors.XtraForm = Nothing)
        Grid.SaveLayoutToRegistry(Login & Form.Text & Grid.Name)
    End Sub

    Public Sub GetGridViewSchema(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, _
                                 ByVal Form As DevExpress.XtraEditors.XtraForm)
        If Not Form Is Nothing Then
            Grid.RestoreLayoutFromRegistry(Login & Form.Text & Grid.Name)
        End If
    End Sub

    Public Sub SetGridViewSchema(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, _
                                 Optional ByVal Form As DevExpress.XtraEditors.XtraForm = Nothing)
        Grid.SaveLayoutToRegistry(Login & Form.Text & Grid.Name)
    End Sub

    Public Sub SetPivotGridSchema(ByRef Grid As DevExpress.XtraPivotGrid.PivotGridControl, Optional ByVal Form As DevExpress.XtraEditors.XtraForm = Nothing)
        Grid.SaveLayoutToRegistry(Login & Form.Text & Grid.Name)
    End Sub

    Public Sub GetPivotGridSchema(ByRef Grid As DevExpress.XtraPivotGrid.PivotGridControl, ByVal Form As DevExpress.XtraEditors.XtraForm)
        If Not Form Is Nothing Then
            Grid.RestoreLayoutFromRegistry(Login & Form.Text & Grid.Name)
        End If
    End Sub

    Public Sub ValidarGridSchema(iVista As DevExpress.XtraGrid.Views.Grid.GridView, _
                                 Form As DevExpress.XtraEditors.XtraForm)

        If db_Esquemas.GetEsquema(Form.Name, 0).Rows.Count <> 0 Then
            ''Configuracion del Usuario
            ''Configuracion Inicial
            Dim xml As New Xml.XmlDocument  ''= db_Esquemas.GetEsquema(Me.Name, 0).Rows.Item(0)("xml")
            xml.LoadXml(db_Esquemas.GetEsquema(Form.Name, 0).Rows.Item(0)("xml"))

            ''Borrar Archivo, para evitar cache
            If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml") Then
                Kill(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
            End If

            xml.Save(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
            ''
            iVista.RestoreLayoutFromXml(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
        Else
            If db_Esquemas.GetEsquema(Form.Name, 1).Rows.Count <> 0 Then
                ''Configuracion Inicial
                Dim xml As New Xml.XmlDocument  ''= db_Esquemas.GetEsquema(Me.Name, 0).Rows.Item(0)("xml")
                xml.LoadXml(db_Esquemas.GetEsquema(Form.Name, 1).Rows.Item(0)("xml"))

                ''Borrar Archivo, para evitar cache
                If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml") Then
                    Kill(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
                End If

                xml.Save(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
                ''
                iVista.RestoreLayoutFromXml(Application.StartupPath & "\xml\xml_" & Form.Name.ToString & ".xml")
            End If
        End If
    End Sub

    Public Sub DBFileToFile(ByVal FileDB As Object, ByVal Nombre As String)
        Dim Ruta As String = Application.StartupPath & "\" & Nombre
        If File.Exists(Ruta) Then Kill(Ruta)

        Dim xml As XmlDocument = New XmlDocument
        xml.LoadXml(FileDB)
        xml.Save(Application.StartupPath & "\" & Nombre)

    End Sub

    Public Function XMLToDBFile(ByVal FileName As String) As Byte()
        Dim Archivo As FileStream = Nothing
        Dim ArchivoData() As Byte = Nothing
        If FileName = Nothing Then
            Return Nothing
        Else
            Archivo = New FileStream(FileName, _
                                FileMode.Open, FileAccess.Read)
            Array.Resize(ArchivoData, (Archivo.Length()))
            Archivo.Read(ArchivoData, 0, ArchivoData.Length)
            Archivo.Close()
        End If
        Return ArchivoData
    End Function

    Public Function FileToDBFile(ByVal FileName As String) As Byte()
        Dim Archivo As FileStream = Nothing
        Dim ArchivoData() As Byte = Nothing
        If FileName = Nothing Then
            Return Nothing
        Else
            Archivo = New FileStream(FileName, _
                                FileMode.Open, FileAccess.Read)
            Array.Resize(ArchivoData, (Archivo.Length() + 1))
            Archivo.Read(ArchivoData, 0, ArchivoData.Length)
            Archivo.Close()
        End If
        Return ArchivoData
    End Function

    'Public Sub CargarLayout(ByVal Forma As XtraForm, ByVal Esquema As DevExpress.XtraLayout.LayoutControl)
    '    Try
    '        If UAdmin = 0 Then
    '            Dim Rol As New RolesCLS
    '            Dim Conf As IO.MemoryStream = Rol.GetLayout(Forma.Name, URol)
    '            If Not Conf Is Nothing Then Esquema.RestoreLayoutFromStream(Conf)
    '            Rol.Dispose()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Public Function GetStreamString(ByVal source As String) As MemoryStream
        Dim Str As Stream = New MemoryStream(ASCIIEncoding.Default.GetBytes(source))
        Return Str
    End Function

    Public Sub Formulario(ByVal f As XtraForm)

        f.StartPosition = FormStartPosition.CenterScreen
        f.MaximizeBox = False
        f.MinimizeBox = False
        f.CloseBox = False
        f.ShowDialog()
    End Sub

    Public Function fx(dt As DataTable, Optional Campo As Integer = 0) As String

        If dt.Rows.Count > 0 Then
            Return IsNull(dt.Rows(0).Item(Campo), 0)
        Else
            Return String.Empty
        End If

    End Function

    Public Function fxName(dt As DataTable, Campo As String) As String

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(Campo)
        Else
            Return String.Empty
        End If

    End Function

    Public Sub FormatoGrid(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, _                           
                           Optional Decimales As Integer = 2, _
                           Optional CountSummaryIndex As Integer = 0, _
                           Optional VerFind As Boolean = True, _
                           Optional Editable As Boolean = False)

        Try
            Grid.OptionsView.ShowFooter = True
            Grid.OptionsView.ShowAutoFilterRow = True
            '
            Grid.OptionsFind.AlwaysVisible = VerFind
            Grid.OptionsFind.ShowClearButton = False
            Grid.OptionsBehavior.Editable = Editable
            '
            'Grid.Columns(0).Width = "50"
            'Grid.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count

            For i As Integer = 0 To Grid.Columns.Count - 1

                If Grid.Columns(i).ColumnType.FullName = "System.Double" Or Grid.Columns(i).ColumnType.FullName = "System.Decimal" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:n" & Decimales.ToString & "}"

                    Grid.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Grid.Columns(i).SummaryItem.DisplayFormat = "{0:n" & Decimales.ToString & "}"
                End If

                If Grid.Columns(i).ColumnType.FullName = "System.DateTime" Or Grid.Columns(i).ColumnType.FullName = "System.DateTime" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:dd/MM/yyyy}"

                    If Grid.Columns(i).GetCaption = "Registro" Then
                        Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        Grid.Columns(i).DisplayFormat.FormatString = "{0:dd/MM/yyyy hh:mm tt}"
                    End If

                    If Grid.Columns(i).GetCaption = "Hora" Then
                        Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        Grid.Columns(i).DisplayFormat.FormatString = "{0:hh:mm tt}"
                    End If
                End If

                If Grid.Columns(i).ColumnType.FullName = "System.Int32" Or Grid.Columns(i).ColumnType.FullName = "System.Int16" Or Grid.Columns(i).ColumnType.FullName = "System.Integer" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0}"
                End If

                If Grid.Columns(i).GetCaption = "Tasa" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:n4}"
                End If


                Grid.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Grid.Columns(i).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                Grid.Columns(i).AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9, FontStyle.Bold)

                ' Grid.Columns(i).OptionsColumn.AllowEdit = Editable
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SimpleFormatGrid(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, _
                                ByVal Editable As Boolean, _
                                ByVal CellAlignment As DevExpress.Utils.HorzAlignment, _
                                ByVal CountSummaryIndex As Integer, _
                                ByVal Decimales As Integer, _
                                ByVal VerFind As Boolean, _
                                ByVal ParamArray InvisibleColumns() As Int32)

        '    If Grid.RowCount > 0 Then
        Try

            Grid.Columns(CountSummaryIndex).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Grid.OptionsBehavior.Editable = Editable
            '
            Grid.OptionsView.ShowFooter = True
            Grid.OptionsView.ShowAutoFilterRow = True
            '
            Grid.OptionsFind.AlwaysVisible = VerFind
            Grid.OptionsFind.ShowClearButton = False

            For i As Integer = 0 To Grid.Columns.Count - 1

                If Grid.Columns(i).ColumnType.FullName = "System.Double" Or Grid.Columns(i).ColumnType.FullName = "System.Decimal" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:n" & Decimales.ToString & "}"

                    Grid.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Grid.Columns(i).SummaryItem.DisplayFormat = "{0:n" & Decimales.ToString & "}"
                End If

                If Grid.Columns(i).ColumnType.FullName = "System.Int32" Or Grid.Columns(i).ColumnType.FullName = "System.Int16" Or Grid.Columns(i).ColumnType.FullName = "System.Integer" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0}"
                End If

                If Grid.Columns(i).ColumnType.FullName = "System.DateTime" Or Grid.Columns(i).ColumnType.FullName = "System.DateTime" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:dd/MM/yyyy}"

                    If Grid.Columns(i).GetCaption = "Registro" Then
                        Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        Grid.Columns(i).DisplayFormat.FormatString = "{0:dd/MM/yyyy hh:mm tt}"
                    End If

                    If Grid.Columns(i).GetCaption = "Hora" Then
                        Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        Grid.Columns(i).DisplayFormat.FormatString = "{0:hh:mm tt}"
                    End If
                End If

                If Grid.Columns(i).GetCaption = "Tasa" Then
                    Grid.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Grid.Columns(i).DisplayFormat.FormatString = "{0:n4}"
                End If

                'Grid.Columns(i).OptionsColumn.AllowEdit = Editable
                Grid.Columns(i).AppearanceHeader.TextOptions.HAlignment = CellAlignment
                Grid.Columns(i).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                Grid.Columns(i).AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9, FontStyle.Bold)

                ' Grid.Columns(i).AppearanceCell.TextOptions.HAlignment = CellAlignment
                'Grid.Columns(i).AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                'Grid.Columns(i).AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9)
            Next

            'Ocultar Columnas
            If Not InvisibleColumns Is Nothing Then
                For i = 0 To InvisibleColumns.Length - 1
                    Grid.Columns(InvisibleColumns(i)).Visible = False
                Next
            End If

            'Grid.BestFitColumns()
        Catch ex As Exception
        End Try
        '  End If
    End Sub

    Public Sub Combo(ByVal cb As DevExpress.XtraEditors.LookUpEdit, ByVal dt As DataTable)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = dt.Columns(0).Caption
        cb.Properties.DisplayMember = dt.Columns(1).Caption
        cb.Properties.PopulateColumns()


        For i As Integer = 0 To cb.Properties.Columns.Count - 1
            cb.Properties.Columns(i).Visible = False
        Next

        Try            
            cb.Properties.Columns(1).Visible = True            
            cb.Properties.NullText = "[Seleccione]"
            cb.Properties.ShowHeader = False
            cb.Properties.ShowFooter = False
        Catch ex As Exception
        End Try

    End Sub

    Public Sub Combo(ByVal cb As DevExpress.XtraEditors.CheckedComboBoxEdit, ByVal dt As DataTable)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = dt.Columns(0).Caption
        cb.Properties.DisplayMember = dt.Columns(1).Caption

    End Sub

    Public Sub Combo(ByVal cb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal dt As DataTable)

        cb.DataSource = dt
        cb.ValueMember = dt.Columns(0).Caption
        cb.DisplayMember = dt.Columns(1).Caption
        cb.PopulateColumns()

        For i As Integer = 0 To cb.Columns.Count - 1
            cb.Columns(i).Visible = False
        Next

        Try
            cb.Columns(1).Visible = True
            'cb.ItemIndex = 0
            cb.NullText = "[Seleccione]"
            cb.ShowHeader = False
            cb.ShowFooter = False
        Catch ex As Exception
        End Try

    End Sub


    Public Sub GridLookUp(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit, _
                                ByVal Vista As DevExpress.XtraGrid.Views.Grid.GridView, _
                                ByVal dt As DataTable)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = dt.Columns(0).ColumnName
        cb.Properties.DisplayMember = dt.Columns(1).ColumnName
        cb.Properties.PopulateViewColumns()
        FormatoGrid(Vista)

        'For i As Integer = 0 To Vista.Columns.Count - 1
        '    Vista.Columns(i).Visible = False
        'Next

        Vista.Columns(0).Visible = True
        Vista.Columns(1).Visible = True
        Vista.Columns(2).Visible = True

        Vista.OptionsBehavior.Editable = False
        Vista.OptionsView.ShowAutoFilterRow = True

        ' Vista.BestFitColumns()
    End Sub

    'Public Sub LimpiarControles(ByRef f As DevExpress.XtraEditors.XtraForm)
    '    For Each Con As Control In f.Controls
    '        If Con.HasChildren Then
    '            For Each Cont As Control In Con.Controls
    '                If TypeOf Cont Is TextBox Then Cont.Text = vbNullString
    '                If TypeOf Cont Is DevExpress.XtraEditors.TextEdit Then Cont.Text = vbNullString
    '                If TypeOf Cont Is DevExpress.XtraEditors.LookUpEdit Then Cont.Text = vbNullString
    '            Next
    '        End If
    '        If TypeOf Con Is TextBox Then Con.Text = vbNullString
    '        If TypeOf Con Is DevExpress.XtraEditors.TextEdit Then Con.Text = vbNullString
    '        If TypeOf Con Is DevExpress.XtraEditors.LookUpEdit Then Con.Text = vbNullString
    '    Next
    'End Sub

    Public Sub VistaPrevia(ByRef Grid As Object, _
                           Optional ByVal Titulo As String = "", _
                           Optional ByVal Periodo As String = "")
        Try
            Dim Ps As New PrintingSystem
            Dim Cl As New PrintableComponentLink
            Ps.Links.AddRange(New Object() {Cl})
            Cl.Component = Grid

            Dim leftColumn As String = "Fecha y Hora : [Date Printed] - [Time Printed]"
            Dim rightColumn As String = "Paginas: [Page # of Pages #]"

            ' Create a PageHeaderFooter object and initializing it with
            ' the link's PageHeaderFooter.
            Dim phf As PageHeaderFooter = _
                TryCast(Cl.PageHeaderFooter, PageHeaderFooter)

            ' Clear the PageHeaderFooter's contents.
            phf.Footer.Content.Clear()
            phf.Header.Content.Clear()

            phf.Header.Font = New System.Drawing.Font("Tahoma", 12, FontStyle.Bold)

            phf.Header.Content.AddRange(New String() _
                {"", Titulo + vbCrLf + Periodo, ""})

            phf.Footer.LineAlignment = BrickAlignment.Center
            ' Add custom information to the link's header.
            phf.Footer.Content.AddRange(New String() _
                {leftColumn, "", rightColumn})
            phf.Footer.LineAlignment = BrickAlignment.Center

            Cl.CreateDocument()
            Cl.Landscape = True
            Cl.ShowPreview()

            'GridP.ShowPrintPreview()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LookUp(ByVal Combo As LookUpEdit, _
                              ByVal Datasource As DataTable, _
                              ByVal DisplayMember As String, _
                              ByVal ValueMember As String, _
                              ByVal ParamArray InvisibleColumns() As Integer)

        Combo.Properties.DataSource = Datasource
        Combo.Properties.DisplayMember = DisplayMember
        Combo.Properties.ValueMember = ValueMember
        Combo.Properties.PopulateColumns()

        'Ocultar Columnas
        If Not InvisibleColumns Is Nothing Then
            For i = 0 To InvisibleColumns.Length - 1
                Combo.Properties.Columns(InvisibleColumns(i)).Visible = False
            Next
        End If

        'For i As Integer = 0 To Datasource.Rows.Count - 1
        '    If InvisibleColumns.Contains(i) Then
        '        Combo.Properties.Columns(i).Visible = False
        '    End If
        'Next
    End Sub

    Public Sub GridLookUp(ByVal Combo As GridLookUpEdit, _
                                  ByVal Datasource As DataTable, _
                                  ByVal DisplayMember As String, _
                                  ByVal ValueMember As String, _
                                  ByVal ParamArray InvisibleColumns() As Integer)

        Combo.Properties.DataSource = Datasource
        Combo.Properties.DisplayMember = DisplayMember
        Combo.Properties.ValueMember = ValueMember
        Combo.Properties.PopulateViewColumns()

        Combo.Properties.NullText = "[Seleccione]"
        FormatoGrid(Combo.Properties.View)

        'Ocultar Todas las Columnas
        For i As Integer = 0 To Combo.Properties.View.Columns.Count - 1
            Combo.Properties.View.Columns(i).Visible = False
        Next

        'Mostrar Columnas
        If Not InvisibleColumns Is Nothing Then
            For i = 0 To InvisibleColumns.Length - 1
                Combo.Properties.View.Columns(InvisibleColumns(i)).Visible = True
            Next
        End If
    End Sub

    Public Sub RepositorySearchLook(ByVal Combo As RepositoryItemSearchLookUpEdit, _
                                    ByVal Datasource As DataTable, _
                                    ByVal DisplayMember As String, _
                                    ByVal ValueMember As String, _
                                    ByVal ParamArray InvisibleColumns() As Integer)

        Combo.DataSource = Datasource
        Combo.DisplayMember = DisplayMember
        Combo.ValueMember = ValueMember
        Combo.PopulateViewColumns()

        Combo.View.OptionsView.ShowAutoFilterRow = True
        FormatoGrid(Combo.View)

        'Ocultar Columnas del Grid
        If Not InvisibleColumns Is Nothing Then
            For i = 0 To InvisibleColumns.Length - 1
                Combo.View.Columns(InvisibleColumns(i)).Visible = False
            Next
        End If

        'For i As Integer = 0 To Datasource.Rows.Count - 1
        '    If InvisibleColumns.Contains(i) Then
        '        Combo.View.Columns(i).Visible = False
        '    End If
        'Next
    End Sub

    Public Sub SearchLookUp(ByVal Combo As SearchLookUpEdit, _
                                    ByVal Datasource As DataTable, _
                                    ByVal DisplayMember As String, _
                                    ByVal ValueMember As String, _
                                    ByVal ParamArray InvisibleColumns() As Integer)

        Combo.Properties.DataSource = Datasource
        Combo.Properties.DisplayMember = DisplayMember
        Combo.Properties.ValueMember = ValueMember
        Combo.Properties.PopulateViewColumns()
        Combo.Properties.View.OptionsView.ShowAutoFilterRow = True
        FormatoGrid(Combo.Properties.View)

        'Ocultar Columnas del Grid
        If Not InvisibleColumns Is Nothing Then
            For i = 0 To InvisibleColumns.Length - 1
                Combo.Properties.View.Columns(InvisibleColumns(i)).Visible = False
            Next
        End If


        'For i As Integer = 0 To Datasource.Columns.Count - 1
        '    If InvisibleColumns.Contains(i) Then
        '        Combo.Properties.View.Columns(i).Visible = False
        '    End If
        'Next
    End Sub

    Public Function Encrypt(ByVal clave As String) As String
        ' Defino variables 
        Dim indice As Integer = 1
        Dim largo As Integer = 0
        Dim final As String = ""

        ' Calculo el largo de la cadena 
        largo = Len(Trim(clave))

        ' Creo un array para contener los dígitos de cada clave 
        Dim caracteres(largo) As String

        ' Desencripto los dígitos 
        For indice = 1 To largo
            caracteres(indice) = Mid(clave, indice, 1)
            caracteres(indice) = Chr(Asc(caracteres(indice)) + indice)
            final = final & caracteres(indice)
        Next indice

        ' Retorno la cadena desencriptada 
        Return final
    End Function

    Public Function Decrypt(ByVal clave As String) As String
        ' Defino variables 
        Dim indice As Integer = 1
        Dim largo As Integer = 0
        Dim final As String = ""

        ' Calculo el largo de la cadena 
        largo = Len(Trim(clave))

        ' Creo un array para contener los dígitos de cada clave 
        Dim caracteres(largo) As String

        ' Desencripto los dígitos 
        For indice = 1 To largo
            caracteres(indice) = Mid(clave, indice, 1)
            caracteres(indice) = Chr(Asc(caracteres(indice)) - indice)
            final = final & caracteres(indice)
        Next indice

        ' Retorno la cadena desencriptada 
        Return final
    End Function

    Public Sub Movimientos_Teclas(e As KeyEventArgs, iVista As DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Control = True Then
            If e.KeyCode = Keys.Up Then
                iVista.FocusedRowHandle = 1
            End If

            If e.KeyCode = Keys.Down Then
                iVista.FocusedRowHandle = iVista.RowCount - 1
            End If

            If e.KeyCode = Keys.Left Then
                iVista.FocusedColumn = iVista.VisibleColumns(1)
            End If

            If e.KeyCode = Keys.Right Then
                iVista.FocusedColumn = iVista.VisibleColumns(iVista.VisibleColumns.Count - 2)
            End If
        End If
        '' Copiar solo el valor de la Celda del Grid
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Clipboard.SetText(iVista.GetFocusedDisplayText())
            e.Handled = True
        End If
    End Sub

    Public Function ImageBytes(ByVal img As Image) As Byte()
        'Esta Funcion Devuelve el la Foto en formato Byte para ser almacenada en la
        'base de datos de la forma adecuada
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Public Function Letras(ByVal tyCantidad As Double, Optional ByVal Moneda As String = "") As String

        Dim i As Integer
        Dim lyCantidad As Double, lyCentavos As Double, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero
        'Redondea el valor a dos coma flotante
        tyCantidad = Math.Round(tyCantidad, 2)
        'Redondea el valor sin coma flotante
        lyCantidad = Int(tyCantidad)
        'Nos determina la cantidad de centavos
        lyCentavos = (tyCantidad - lyCantidad) * 100

        '  string data [] = new string [] { "a", "b", "c", "d", "e" };

        Dim laUnidades() As String = {"Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}


        'Arreglo que nos determina las unidades de los numeros llega hasta veintinueve porque de ahi en adelante los numeros son iguales
        '  laUnidades = Array("Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesisiete", "Diesiocho", "Diesinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve")
        'Arreglo que nos determina las decenas de los numeros
        Dim laDecenas() As String = {"Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"}
        'Arreglo que nos determina las centenas de los numeros
        Dim laCentenas() As String = {"Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
        'Nos indica los bloques de tres que se peocesan. Inicialmente es uno. Unidades, decenas y centenas.
        lnNumeroBloques = 1

        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0

            'Ciclo for que nos determina con cada ciclo las unidades (1) decenas (2) centenas (3)
            For i = 1 To 3
                'lnDigito toma el residuo de lyCantidad dividido entre diez
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            'Asigna nombre a las unidades. i vale una indicando que son unidades
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", System.DBNull.Value) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "Cien", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    Letras = lcBloque
                Case 2
                    Letras = lcBloque & IIf(lnBloqueCero = 3, System.DBNull.Value, " Mil") & Letras
                Case 3
                    Letras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " Millon", " Millones") & Letras
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        'No escribe la cadena final de la conversion con la cantida de centavos si existen

        'SE deja en comentario el nombre de la moneda hasta que se agregue una opcion de incluir descripcion de la 
        'moneda dentro del cheque segun el registro en la tabla monedas BRobelo 26092007
        'Letras = (Letras & IIf(tyCantidad > 1, " Cordobas ", " Cordoba ") & " CON " & CInt(lyCentavos) & "/100").ToString.ToUpper
        Letras = (Letras & IIf(tyCantidad > 1, " ", "") & Moneda & " CON " & CInt(lyCentavos).ToString.PadLeft(2, "0"c) & "/100").ToString.ToUpper
        'Format(Str(lyCentavos), "00")
    End Function

End Module
