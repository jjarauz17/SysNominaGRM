Imports System.IO
Public Class frmImportacion_Archivos

    Private Sub frmImportacion_Archivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
    End Sub

    Private Sub cargar()

        Me.cbTipo_Movimiento.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables(0) 'VB.SysContab.TipoIngresoDB.GetList(IIf(Me.unico, "U", "P")).Tables("TipoIngreso")
        Me.cbTipo_Movimiento.ValueMember = "Codigo"
        Me.cbTipo_Movimiento.DisplayMember = "Descripcion"

        cbMonedas.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMonedas.ValueMember = "Codigo"
        cbMonedas.DisplayMember = "Descripcion"

        Me.dgLista.DataSource = VB.SysContab.DocumentosDB.Get_Importacion("%")
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("tipo_archivo").ColumnEdit = Me.cbTipo_Archivo
        Me.vLista.Columns("tipo_movimiento").ColumnEdit = Me.cbTipo_Movimiento
        Me.vLista.Columns("moneda").ColumnEdit = Me.cbMonedas


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        Dim arrImage() As Byte
        Dim _FS As FileStream
        arrImage = VB.SysContab.DocumentosDB.Get_Archivo(Me.vLista.GetFocusedRowCellValue("ID Importacion"))
        _FS = New FileStream("Documento.tmp", FileMode.Create, FileAccess.Write)
        _FS.Write(arrImage, 0, arrImage.Length)
        _FS.Close()
        _FS.Dispose()

        Dim f As New frmVisorTexto
        f.texto.Text = System.IO.File.ReadAllText("Documento.tmp")
        f.ShowDialog()
    End Sub
End Class