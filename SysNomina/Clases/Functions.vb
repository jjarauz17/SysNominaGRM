Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class Functions

    'Public Sub DeleteGridRow(ByRef Grid As Views.Grid.GridView, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Delete Then Grid.DeleteRow(Grid.FocusedRowHandle)
    'End Sub

    Public Function IsNull(ByVal Var, Optional ByVal Valor = vbNullString)
        If IsDBNull(Var) OrElse IsNothing(Var) OrElse Var = vbNullString OrElse Var = Nothing Then
            Return IIf(IsNothing(Valor), "", Valor)
        Else
            Return Var
        End If
    End Function

    Public Function GetDBImage(ByVal Source As Object) As Image
        If IsDBNull(Source) = False Then
            Dim imagedata() As Byte
            Dim imageBytedata As MemoryStream
            imagedata = Source
            imageBytedata = New MemoryStream(imagedata)
            Return Image.FromStream(imageBytedata)
        Else
            Return Nothing
        End If
    End Function

    Public Function SetDBImage(ByVal Imagen As Image) As Byte()
        If IsNothing(Imagen) Then
            Return Nothing
        Else
            Dim ms As MemoryStream = New MemoryStream()
            Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End If
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

    Public Sub DBFileToFile(ByVal FileDB As Object, ByVal Nombre As String)
        Dim Ruta As String
        Dim Data() As Byte = CType(FileDB, Byte())
        Dim Tamano As Integer
        Tamano = Data.GetUpperBound(0)
        Ruta = Application.StartupPath & "\" & Nombre
        If File.Exists(Ruta) Then Kill(Ruta)
        Dim Archivo As New FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Write)
        Archivo.Write(Data, 0, Tamano)
        Archivo.Close()
        Process.Start(Ruta)
    End Sub

End Class
