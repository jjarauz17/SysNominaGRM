Imports System
Imports System.Windows.Forms
Imports System.Text
'Para manipular archivos gráficos
Imports System.Drawing
Imports System.Drawing.Imaging
'Para manipular directorios y ficheros
Imports System.IO
'Para iniciar y detener procesos del sistema local
Imports System.Diagnostics


Public Class frmExplorador
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cbDrive As System.Windows.Forms.ComboBox
    Friend WithEvents tvDir As System.Windows.Forms.TreeView
    Friend WithEvents lvImg As System.Windows.Forms.ListView
    Friend WithEvents pbImg As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbEmi As System.Windows.Forms.PictureBox
    Friend WithEvents iconImg As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbImg As System.Windows.Forms.Label
    Friend WithEvents btCode As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbDrive = New System.Windows.Forms.ComboBox()
        Me.tvDir = New System.Windows.Forms.TreeView()
        Me.iconImg = New System.Windows.Forms.ImageList(Me.components)
        Me.lvImg = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.pbImg = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbEmi = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btCode = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.lbImg = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDrive
        '
        Me.cbDrive.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.cbDrive.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDrive.Location = New System.Drawing.Point(16, 32)
        Me.cbDrive.Name = "cbDrive"
        Me.cbDrive.Size = New System.Drawing.Size(192, 24)
        Me.cbDrive.TabIndex = 0
        '
        'tvDir
        '
        Me.tvDir.ImageList = Me.iconImg
        Me.tvDir.Location = New System.Drawing.Point(16, 64)
        Me.tvDir.Name = "tvDir"
        Me.tvDir.Size = New System.Drawing.Size(192, 152)
        Me.tvDir.TabIndex = 1
        Me.tvDir.TabStop = False
        '
        'iconImg
        '
        Me.iconImg.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iconImg.ImageSize = New System.Drawing.Size(16, 16)
        Me.iconImg.TransparentColor = System.Drawing.Color.Transparent
        '
        'lvImg
        '
        Me.lvImg.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.lvImg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvImg.LargeImageList = Me.iconImg
        Me.lvImg.Location = New System.Drawing.Point(16, 232)
        Me.lvImg.Name = "lvImg"
        Me.lvImg.Size = New System.Drawing.Size(192, 160)
        Me.lvImg.SmallImageList = Me.iconImg
        Me.lvImg.StateImageList = Me.iconImg
        Me.lvImg.TabIndex = 2
        Me.lvImg.TabStop = False
        Me.lvImg.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Elegir una imagen"
        Me.ColumnHeader1.Width = 188
        '
        'pbImg
        '
        Me.pbImg.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImg.Location = New System.Drawing.Point(240, 16)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(400, 300)
        Me.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbImg.TabIndex = 3
        Me.pbImg.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 392)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar imágenes"
        '
        'pbEmi
        '
        Me.pbEmi.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.pbEmi.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbEmi.Location = New System.Drawing.Point(16, 408)
        Me.pbEmi.Name = "pbEmi"
        Me.pbEmi.Size = New System.Drawing.Size(72, 32)
        Me.pbEmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmi.TabIndex = 5
        Me.pbEmi.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btSalir, Me.btCode})
        Me.GroupBox3.Location = New System.Drawing.Point(544, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 96)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'btCode
        '
        Me.btCode.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCode.Location = New System.Drawing.Point(8, 16)
        Me.btCode.Name = "btCode"
        Me.btCode.Size = New System.Drawing.Size(96, 24)
        Me.btCode.TabIndex = 13
        Me.btCode.TabStop = False
        Me.btCode.Text = "Actualizar"
        '
        'lbImg
        '
        Me.lbImg.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.lbImg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbImg.Location = New System.Drawing.Point(224, 320)
        Me.lbImg.Name = "lbImg"
        Me.lbImg.Size = New System.Drawing.Size(432, 16)
        Me.lbImg.TabIndex = 9
        Me.lbImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSalir
        '
        Me.btSalir.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(8, 40)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(96, 24)
        Me.btSalir.TabIndex = 14
        Me.btSalir.TabStop = False
        Me.btSalir.Text = "Salir"
        '
        'frmExplorador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 452)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbImg, Me.lvImg, Me.tvDir, Me.cbDrive, Me.GroupBox1, Me.GroupBox3, Me.pbEmi, Me.pbImg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmExplorador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explorador de imágenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '---------------------------------------------------------------------------------------
    'PROPIEDADES ESPECÍFICAS DEL LISTVIEW lvImg
    'necesarias para poder mostrar los elementos 
    'tal y como se muestran en esta aplicación:

    '1 - Añadir una columna
    'Me.lvImg.Columns.AddRange(New System.Windows.Forms.ColumnHeader()	{Me.ColumnHeader1})
    '2 - Asociar el control IMAGELIST iconImg a las propiedades LargeImageList, SmallImageList y StateImageList
    'Me.lvImg.LargeImageList = Me.iconImg
    'Me.lvImg.SmallImageList = Me.iconImg
    'Me.lvImg.StateImageList = Me.iconImg
    '3 - Propiedad view con el valor Details
    'Me.lvImg.View = System.Windows.Forms.View.Details
    '--------------------------------------------------------------------------------------

    'Para saber si la imagen está ajustada a la ventana o a tamaño real
    Dim ajustar As Boolean = True

    ' Variable para ser utilizada en el método btAbrir_Click
    Dim nombreImg As String = ""

    'Al cargar el formulario
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'rellenar el Combobox con las letras de unidad del sistema:
        'array de cadenas para contener los nombres de las unidades
        Dim drives() As String
        'rellenar el array con las unidades lógicas del sistema
        drives = System.Environment.GetLogicalDrives()
        'rellenar el Combobox dese el array
        Me.cbDrive.Items.AddRange(drives)
        'lbImg.Text = "Ninguna imagen cargada"

    End Sub

    'Al seleccionar un ítem del Combobox
    Private Sub cbDrive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDrive.SelectedIndexChanged
        Try
            'la clase DirectoryInfo expone métodos de instancia para _
            'crear, mover y enumerar archivos en directorios y subdirectorios;
            'se utiliza la clase DirectoryInfo para operaciones típicas como copiar, _
            'mover, cambiar de nombre, enumerar, crear y eliminar directorios.

            'obtener los directorios de la unidad seleccionada;
            Dim combo As New DirectoryInfo(Me.cbDrive.Text)
            Dim carpetas() As DirectoryInfo
            carpetas = combo.GetDirectories()
            'limpiar el Treeview
            tvDir.Nodes.Clear()
            'rellenar el Treeview con los nombres de los directorios;
            'TreeNode representa a los nodos del Treeview
            Dim carpetas2 As DirectoryInfo
            Dim nodo As TreeNode
            For Each carpetas2 In carpetas
                'el constructor de la clase Treenode inicializa una nueva instancia _
                'aquí se usa con 3 parámetros: _
                '1 - el texto de etiqueta especificado _
                '2 - la imagen que se ha de mostrar cuando el nodo de árbol esté _
                'seleccionado (índice del Imagelist).
                '3 - la imagen que se ha de mostrar cuando el nodo de árbol esté _
                'sin seleccionar (índice del Imagelist).
                nodo = New TreeNode(carpetas2.FullName, 0, 1)
                Me.tvDir.Nodes.Add(nodo)
            Next

            'Mostrar mensaje del error capturado
        Catch pollo As Exception
            MessageBox.Show("Mensaje de error: " & pollo.Message, "Error al leer la unidad " & cbDrive.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbDrive.Text = "C:\"
        End Try

    End Sub

    'Al elegir un directorio en el Treeview
    Private Sub tvDir_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvDir.AfterSelect
        Try
            'si el nodo del árbol no está expandido
            If Not e.Node.IsExpanded Then
                'obtener los subdirectorios del nodo seleccionado
                Dim carpetas3 As DirectoryInfo
                carpetas3 = New DirectoryInfo(e.Node.FullPath)
                Dim carpetas4() As DirectoryInfo
                carpetas4 = carpetas3.GetDirectories()

                'rellenar el Treeview con los nombres de los subdirectorios;
                'TreeNode representa a los nodos del Treeview
                Dim subcarpetas As DirectoryInfo
                Dim nodo As TreeNode
                For Each subcarpetas In carpetas4
                    'el constructor de la clase Treenode inicializa una nueva instancia _
                    'aquí se usa con 3 parámetros: _
                    '1 - el texto de etiqueta especificado _
                    '2 - la imagen que se ha de mostrar cuando el nodo de árbol esté _
                    'seleccionado (índice del Imagelist).
                    '3 - la imagen que se ha de mostrar cuando el nodo de árbol esté _
                    'sin seleccionar (índice del Imagelist).
                    nodo = New TreeNode(subcarpetas.Name, 0, 1)
                    e.Node.Nodes.Add(nodo.Text)
                Next

                'obtener los archivos del subdirectorio
                Dim archivos() As FileInfo
                archivos = carpetas3.GetFiles()

                'limpiar el Listview
                Me.lvImg.Items.Clear()

                'rellenar el Listview con los nombres de los archivos
                'que cumplan la condición: terminar por las extensiones 
                'de archivos de imagen (se pueden cambiar las que aparecen aquí)
                Dim imagen As FileInfo
                For Each imagen In archivos
                    'a cada extensión se le puede asignar una imagen diferente eb el Imagelist
                    Select Case imagen.Extension
                        Case ".BMP", ".bmp"
                            Me.lvImg.Items.Add(imagen.Name, 2)
                        Case ".JPG", ".JPEG", ".jpg", ".jpeg"
                            Me.lvImg.Items.Add(imagen.Name, 3)
                    End Select
                Next
            End If

            'si no hay elementos en el Listview, vaicar la caja de imagen
            If Me.lvImg.Items.Count = 0 Then
                Me.pbImg.Image = Nothing
                Me.lbImg.Text = "Ninguna imagen cargada"
            End If

            'Mostrar mensaje del error capturado
        Catch pollo As Exception
            MessageBox.Show("Mensaje de error: " & pollo.Message, "Error al leer imágenes ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'al pulsar en un elemento del Listview (se produce el evento SelectedIndexChanged
    Private Sub lvImg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvImg.SelectedIndexChanged
        'procedimiento descrito más abajo
        Call refrescarImg()
        'mostrar información sobre ancho y alto de la imagen seleccionada
        Me.lbImg.Text = "Ancho de imagen: " + pbImg.Image.Width.ToString + _
          " px.  /  Alto de imagen: " + pbImg.Image.Height.ToString + " px"
    End Sub

    Private Sub refrescarImg()
        Try
            'si hay algún elemento seleccionado en el Listview
            If Me.lvImg.SelectedItems.Count > 0 Then
                'invalidar la región gráfica del Picturebox para volver a rellenarla
                'con la imagen elegida en el control Listview
                Me.pbImg.Invalidate()
                Me.pbImg.Image = New Bitmap(Me.tvDir.SelectedNode.FullPath & "\" & Me.lvImg.SelectedItems(0).Text)

            End If

            'Mostrar mensaje del error capturado
        Catch pollo As Exception
            MessageBox.Show("Mensaje de error: " & pollo.Message, "Error al leer imágenes ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Para copiar la imagen al protapapeles
    Private Sub btCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbImg.Image Is Nothing Then
            'función detallada en el siguiente bloque
            Call fnClipboard()
        End If
    End Sub

    'Función que devuelve un objeto desde el portapapeles.
    'La clase ClipBoard deriva de la clase Object y tiene 3 miembros:
    'constructor / GetDataObject / SetDataObject
    Private Function fnClipboard() As Object
        'Copiar imagen al portapeles
        'SetDataObject lleva 2 parámetros (objeto, booleano)
        'Si booleano es true, el objeto queda en el portapapeles
        'después de haber cerrado la aplicación
        Clipboard.SetDataObject(pbImg.Image, True)
        'Variable objClipboard para contener el portapeles
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        'devuelve el portapapeles como mapa de bits
        Return objClipboard.GetData(DataFormats.Bitmap)
    End Function

    'Para mostrar la imagen a tamaño real o ajustado
    Private Sub btAjustar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbImg.Image Is Nothing Then
            'si ya está a tamaño real, pasar a modo Ajustado
            If ajustar = True Then
                'pasar a modo Normal (tamaño real)
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage
                ajustar = False
            Else
                'si la imagen está en modo Ajustado (Stretch)
                pbImg.SizeMode = PictureBoxSizeMode.CenterImage
                ajustar = True
            End If
        End If
    End Sub

    'Menú que voltea horizontalmente la imagen
    Private Sub btFlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbImg.Image Is Nothing Then
            pbImg.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            pbImg.Refresh() 'Recarga la imagen
        End If
    End Sub

    'Para guardar el archivo en otro formato (BMP a JPG, JPG a BMP) o en otra carpeta
    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbImg.Image Is Nothing Then
            dlgSave = New SaveFileDialog()
            dlgSave.Filter = "Mapas de bits (*.bmp)|*.bmp|Imágenes JPG (*.jpg)|*.jpg"
            dlgSave.Title = "Guarda la imagen como..."
            If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                nombreImg = dlgSave.FileName
                If (nombreImg.EndsWith("jpg")) Then
                    pbImg.Image.Save(nombreImg, ImageFormat.Jpeg)
                End If
                If (nombreImg.EndsWith("bmp")) Then
                    pbImg.Image.Save(nombreImg, ImageFormat.Bmp)
                End If
            End If
        End If
    End Sub

    'Salir de la aplicación
    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    'Para mostrar un cuadro de ayuda
    Private Sub btAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Información al usuario
        MessageBox.Show("Explorador de imágenes realizado en Visual Basic .NET." + vbCrLf + "Autor: MILIUCO. Fecha: 09/10/2003.", "Acerca de...", MessageBoxButtons.OK)
    End Sub

    'Para mostrar el código del programa
    Public Sub btCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCode.Click
        'Obtener la ruta a la carpeta desde la que se ha iniciado la aplicación,
        Dim stRuta As String = Application.StartupPath

        Try ' para detectar y manipular excepciones (errores del programa)
            ''ProcessStartInfo se utiliza para iniciar procesos
            'Dim abrirDoc As ProcessStartInfo = New ProcessStartInfo()
            ''Añadir a la ruta "\Form1.txt" para abrir el archivo
            'abrirDoc.FileName = stRuta + "\Form1.txt"
            ''Información al usuario de la ruta obtenida en su sistema
            'MessageBox.Show("El código del programa se muestra mediante una instancia del Bloc de Notas." + vbCrLf + "El archivo"" Form1.txt"" ha de estar junto al ejecutable del programa." + vbCrLf + "La ruta al archivo ""Form1.txt"" en tu sistema debería ser:" + vbCrLf + abrirDoc.FileName, "Ver el código", MessageBoxButtons.OK)

            ''modo de apertura de archivo (también puede ser edit, print...)
            'abrirDoc.Verb = "open"
            ''abrir en ventana normal
            'abrirDoc.WindowStyle = ProcessWindowStyle.Normal
            ''Abrir el archivo mediante su programa asociado en Windows
            'Process.Start(abrirDoc)
            Dim f As frmAgregarEmpleado = frmAgregarEmpleado.Instance
            If f.QImagen = "Foto" Then
                f.Fotografia.Image = pbImg.Image
                If pbImg.Image Is Nothing Then
                    f.archivoFoto = ""
                Else
                    f.archivoFoto = Me.tvDir.SelectedNode.FullPath & "\" & Me.lvImg.SelectedItems(0).Text
                End If
            Else
                f.Firma.Image = pbImg.Image
                If pbImg.Image Is Nothing Then
                    f.archivoFirma = ""
                Else
                    f.archivoFirma = Me.tvDir.SelectedNode.FullPath & "\" & Me.lvImg.SelectedItems(0).Text
                End If
            End If


            Me.Close()
        Catch a As Exception 'Objeto Exception de nombre a
            'Mensaje relativo a la excepción lanzada
            MessageBox.Show("Se ha producido la siguiente excepción:" _
            + vbCrLf + vbCrLf + a.Message, "Mensaje de error")
        End Try
    End Sub


End Class

