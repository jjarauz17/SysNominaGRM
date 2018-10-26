Imports System
Imports DevExpress.Utils
Imports DevExpress.Export
Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Web.ASPxPivotGrid

Public Class frmExportarImprimir

    Private GridP As Object
    Public Titulo_Print As String, Periodo_Print As String, Orientacion As Boolean

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Public Sub Mostrar(ByRef Grid As Object, _
                        Optional ByVal Titulo As String = "", _
                        Optional ByVal Rango As String = "", _
                        Optional Vertical As Boolean = True)
        GridP = Grid
        Titulo_Print = Titulo
        Periodo_Print = Rango
        Orientacion = Vertical

        Me.ShowDialog()
        Me.Dispose()
    End Sub

    'Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    '    Dim Extension As String = String.Empty

    '    If Me.rgOpciones.EditValue = 1 Then Extension = "*.xls"
    '    If Me.rgOpciones.EditValue = 2 Then Extension = "*.html"
    '    If Me.rgOpciones.EditValue = 3 Then Extension = "*.pdf"
    '    If Me.rgOpciones.EditValue = 4 Then Extension = "*.rtf"
    '    If Me.rgOpciones.EditValue = 5 Then Extension = "*.txt"


    '    If Me.rgOpciones.EditValue <> 6 Then
    '        Guardar.DefaultExt = Extension
    '        Guardar.Filter = "(" & Extension & ")|" & Extension

    '        If Guardar.ShowDialog = DialogResult.OK Then

    '            If Me.rgOpciones.EditValue = 1 Then GridP.ExportToXls(Guardar.FileName)
    '            If Me.rgOpciones.EditValue = 2 Then GridP.ExportToHtml(Guardar.FileName)
    '            If Me.rgOpciones.EditValue = 3 Then GridP.ExportToPdf(Guardar.FileName)
    '            If Me.rgOpciones.EditValue = 4 Then GridP.ExportToRtf(Guardar.FileName)
    '            If Me.rgOpciones.EditValue = 5 Then GridP.ExportToText(Guardar.FileName)

    '            If XtraMessageBox.Show("¿ Abrir Archivo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
    '                Process.Start(Guardar.FileName)
    '            End If
    '        End If
    '        Me.Close()
    '    Else
    '        Me.Close()
    '        GridP.ShowPrintPreview()
    '    End If
    'End Sub

    Private Sub pExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExcel.Click
        Exportar("*.xls")
    End Sub

    Private Sub pWord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pWord.Click
        Exportar("*.rtf")
    End Sub

    Private Sub pPdf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pPdf.Click
        Exportar("*.pdf")
    End Sub

    Private Sub pWeb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pWeb.Click
        Exportar("*.html")
    End Sub

    Private Sub pTxt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pTxt.Click
        Exportar("*.txt")
    End Sub

    Private Sub pPrevia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pPrevia.Click
        GridP.ShowPrintPreview()
        Me.Close()
    End Sub

    Sub Exportar(ByVal Extension As String)

        Guardar.DefaultExt = Extension
        Guardar.Filter = "(" & Extension & ")|" & Extension

        'Dim xl As New DevExpress.XtraPrinting.XlsxExportOptions
        'xl.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value

        'Dim iPivot As DevExpress.XtraPivotGrid.PivotGridControl
        'iPivot.ExportToXlsx("c:\xls\pivot.xlsx", DevExpress.XtraPrinting.TextExportMode.Value)

        If Guardar.ShowDialog = DialogResult.OK Then
            'Try
            '    If Extension = "*.xls" Then GridP.ExportToXls(Guardar.FileName, xl)
            'Catch ex As Exception
            '    GridP.ExportToXlsx(Guardar.FileName, xl)
            'End Try

            If Extension = "*.xlsx" Then

                'Si es un grid
                If TypeOf (GridP) Is DevExpress.XtraGrid.GridControl Then _
                    CType(GridP, DevExpress.XtraGrid.GridControl).ExportToXlsx(Guardar.FileName, New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})

                'Si es un Pivot
                If TypeOf (GridP) Is DevExpress.XtraPivotGrid.PivotGridControl Then
                    Dim iPivot As DevExpress.XtraPivotGrid.PivotGridControl

                    Dim options As XlsxExportOptionsEx
                    options = New XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG}
                    options.SheetName = "Dinamico"

                    iPivot = CType(GridP, DevExpress.XtraPivotGrid.PivotGridControl)

                    iPivot.OptionsView.ShowColumnHeaders = False
                    iPivot.OptionsView.ShowDataHeaders = False
                    Try
                        iPivot.ExportToXlsx(Guardar.FileName, options)
                    Catch ex As Exception
                        iPivot.ExportToXlsx(Guardar.FileName)
                    End Try


                    iPivot.OptionsView.ShowColumnHeaders = True
                    iPivot.OptionsView.ShowDataHeaders = True
                End If

                'Si es un Arbol
                If TypeOf (GridP) Is DevExpress.XtraTreeList.TreeList Then _
                    CType(GridP, DevExpress.XtraTreeList.TreeList).ExportToXlsx(Guardar.FileName, New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})

                'Si es una Vista
                If TypeOf (GridP) Is DevExpress.XtraGrid.Views.Grid.GridView Then _
                    CType(GridP, DevExpress.XtraGrid.Views.Grid.GridView).ExportToXlsx(Guardar.FileName, New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})

                'Dim iGrid As DevExpress.XtraGrid.GridControl
                'Dim iPivot As DevExpress.XtraPivotGrid.PivotGridControl

                'Try
                '    iGrid = CType(GridP, DevExpress.XtraGrid.GridControl)
                '    iGrid.ExportToXlsx(Guardar.FileName, New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
                'Catch ex As Exception

                '    Dim options As XlsxExportOptionsEx
                '    options = New XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG}
                '    options.SheetName = "Dinamico"

                '    iPivot = CType(GridP, DevExpress.XtraPivotGrid.PivotGridControl)

                '    iPivot.OptionsView.ShowColumnHeaders = False
                '    iPivot.OptionsView.ShowDataHeaders = False

                '    iPivot.ExportToXlsx(Guardar.FileName, options)
                'End Try

                'If  CType(GridP,DevExpress.XtraGrid.GridControl) is 
                'If GridP Is DevExpress.XtraGrid.GridControl then GridP.ExportToXlsx(Guardar.FileName, xl) Then
                'CType(GridP, DevExpress.XtraPivotGrid.PivotGridControl).ExportToXlsx(Guardar.FileName, DevExpress.XtraPrinting.TextExportMode.Value)

            End If

            If Extension = "*.html" Then GridP.ExportToHtml(Guardar.FileName)
            If Extension = "*.pdf" Then GridP.ExportToPdf(Guardar.FileName)
            If Extension = "*.rtf" Then GridP.ExportToRtf(Guardar.FileName)
            If Extension = "*.txt" Then GridP.ExportToText(Guardar.FileName)
            '
            If XtraMessageBox.Show("¿ Abrir Archivo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Process.Start(Guardar.FileName)
            End If
            '
            Me.Close()
        End If
    End Sub


    Private Sub ExportPivot(ByVal iPivot As PivotGridControl)

        'For Each field As DevExpress.XtraPivotGrid.PivotGridField In iPivot.Fields
        '    If field.ValueFormat IsNot Nothing AndAlso (Not String.IsNullOrEmpty(field.ValueFormat.FormatString)) Then
        '        If checkCustomFormattedValuesAsText.Checked Then
        '            field.UseNativeFormat = DefaultBoolean.False
        '        Else
        '            field.UseNativeFormat = DefaultBoolean.True
        '        End If
        '    End If
        'Next field

        'ASPxPivotGridExporter1.OptionsPrint.PrintHeadersOnEveryPage = checkPrintHeadersOnEveryPage.Checked
        'ASPxPivotGridExporter1.OptionsPrint.MergeColumnFieldValues = checkMergeColumnFieldValues.Checked
        'ASPxPivotGridExporter1.OptionsPrint.MergeRowFieldValues = checkMergeRowFieldValues.Checked

        'If checkPrintFilterFieldHeaders.Checked Then
        '    ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.True
        'Else
        '    ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False
        'End If
        'If checkPrintColumnFieldHeaders.Checked Then
        '    ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = DefaultBoolean.True
        'Else
        '    ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = DefaultBoolean.False
        'End If
        'If checkPrintRowFieldHeaders.Checked Then
        '    ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = DefaultBoolean.True
        'Else
        '    ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = DefaultBoolean.False
        'End If
        'If checkPrintDataFieldHeaders.Checked Then
        '    ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = DefaultBoolean.True
        'Else
        '    ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = DefaultBoolean.False
        'End If

        'Const fileName As String = "PivotGrid"
        'Dim options As XlsxExportOptionsEx
        'Select Case listExportFormat.SelectedIndex
        '    Case 0
        '        ASPxPivotGridExporter1.ExportPdfToResponse(fileName, saveAs)
        '    Case 1
        '        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG}
        '        ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs)
        '    Case 2
        '        ASPxPivotGridExporter1.ExportMhtToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", True, saveAs)
        '    Case 3
        '        ASPxPivotGridExporter1.ExportRtfToResponse(fileName, saveAs)
        '    Case 4
        '        ASPxPivotGridExporter1.ExportTextToResponse(fileName, saveAs)
        '    Case 5
        '        ASPxPivotGridExporter1.ExportHtmlToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", True, saveAs)
        '    Case 6
        '        If allowGroupingCheckBox.Checked Then
        '            If exportCellValuesAsText.Checked Then
        '                If allowFixedColumns.Checked Then
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                Else
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                End If
        '            Else
        '                If allowFixedColumns.Checked Then
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                Else
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.True, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                End If
        '            End If
        '        Else
        '            If exportCellValuesAsText.Checked Then
        '                If allowFixedColumns.Checked Then
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                Else
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Text, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                End If
        '            Else
        '                If allowFixedColumns.Checked Then
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.True, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                Else
        '                    If allowFixedColumns.Checked Then
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.True, .RawDataMode = exportRawData.Checked}
        '                    Else
        '                        options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = DefaultBoolean.False, .TextExportMode = TextExportMode.Value, .AllowFixedColumns = DefaultBoolean.False, .AllowFixedColumnHeaderPanel = DefaultBoolean.False, .RawDataMode = exportRawData.Checked}
        '                    End If
        '                End If
        '            End If
        '        End If
        '        ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs)
        'End Select
    End Sub






    Private Sub bExcel_Click(sender As Object, e As EventArgs) Handles bExcel.Click
        Exportar("*.xls")
    End Sub

    Private Sub bExcelx_Click(sender As Object, e As EventArgs) Handles bExcelx.Click
        Exportar("*.xlsx")
    End Sub

    Private Sub bWord_Click(sender As Object, e As EventArgs) Handles bWord.Click
        Exportar("*.rtf")
    End Sub

    Private Sub bPdf_Click(sender As Object, e As EventArgs) Handles bPdf.Click
        Exportar("*.pdf")
    End Sub

    Private Sub bTexto_Click(sender As Object, e As EventArgs) Handles bTexto.Click
        Exportar("*.txt")
    End Sub

    Private Sub bWeb_Click(sender As Object, e As EventArgs) Handles bWeb.Click
        Exportar("*.html")
    End Sub

    Private Sub bPrevia_Click(sender As Object, e As EventArgs) Handles bPrevia.Click
        VistaPrevia(GridP, Titulo_Print, Periodo_Print)
    End Sub

End Class