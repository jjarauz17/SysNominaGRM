Imports System.IO
Imports DevExpress.Spreadsheet
Public Class frmVer_Archivos

    Private Sub frmVer_Archivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.dgLista.DataSource = Catalogos.EDU_Archivos_List()
        Me.vlista.Columns("archivo").Visible = False
        Me.scdetalle.ReadOnly = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub vlista_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vlista.FocusedRowChanged

        If Me.vlista.GetRowCellValue(Me.vlista.FocusedRowHandle, "origen") = 1 Then
            Dim arrImage() As Byte
            Dim _FS As MemoryStream
            arrImage = Me.vlista.GetRowCellValue(Me.vlista.FocusedRowHandle, "archivo")
            _FS = New MemoryStream(arrImage)
            _FS.Write(arrImage, 0, arrImage.Length)
            _FS.Close()
            _FS.Dispose()

            Me.scdetalle.LoadDocument(_FS, DocumentFormat.Xls)
            'Dim f As New frmVisorTexto
            'f.texto.Text = System.IO.File.ReadAllText("Documento.tmp")
            'f.ShowDialog()
        End If

    End Sub
End Class