Public Class frmexportaciongrid
    Inherits System.Windows.Forms.Form
    Private GridP As Object
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Public Titulo As String = ""

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optexcel As System.Windows.Forms.RadioButton
    Friend WithEvents opthtml As System.Windows.Forms.RadioButton
    Friend WithEvents optpdf As System.Windows.Forms.RadioButton
    Friend WithEvents optrtf As System.Windows.Forms.RadioButton
    Friend WithEvents opttxt As System.Windows.Forms.RadioButton
    Friend WithEvents optprint As System.Windows.Forms.RadioButton
    Friend WithEvents cmdaceptar As System.Windows.Forms.Button
    Friend WithEvents cmdcancelar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmexportaciongrid))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optexcel = New System.Windows.Forms.RadioButton
        Me.opthtml = New System.Windows.Forms.RadioButton
        Me.optpdf = New System.Windows.Forms.RadioButton
        Me.optrtf = New System.Windows.Forms.RadioButton
        Me.opttxt = New System.Windows.Forms.RadioButton
        Me.optprint = New System.Windows.Forms.RadioButton
        Me.cmdaceptar = New System.Windows.Forms.Button
        Me.cmdcancelar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optexcel)
        Me.GroupBox1.Controls.Add(Me.opthtml)
        Me.GroupBox1.Controls.Add(Me.optpdf)
        Me.GroupBox1.Controls.Add(Me.optrtf)
        Me.GroupBox1.Controls.Add(Me.opttxt)
        Me.GroupBox1.Controls.Add(Me.optprint)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Exportacion"
        '
        'optexcel
        '
        Me.optexcel.Location = New System.Drawing.Point(16, 24)
        Me.optexcel.Name = "optexcel"
        Me.optexcel.Size = New System.Drawing.Size(104, 24)
        Me.optexcel.TabIndex = 0
        Me.optexcel.Text = "Microsoft Excel"
        '
        'opthtml
        '
        Me.opthtml.Location = New System.Drawing.Point(16, 56)
        Me.opthtml.Name = "opthtml"
        Me.opthtml.Size = New System.Drawing.Size(104, 24)
        Me.opthtml.TabIndex = 0
        Me.opthtml.Text = "Web (HTML)"
        '
        'optpdf
        '
        Me.optpdf.Location = New System.Drawing.Point(16, 88)
        Me.optpdf.Name = "optpdf"
        Me.optpdf.Size = New System.Drawing.Size(144, 24)
        Me.optpdf.TabIndex = 0
        Me.optpdf.Text = "Acrobat Reader (PDF)"
        '
        'optrtf
        '
        Me.optrtf.Location = New System.Drawing.Point(176, 24)
        Me.optrtf.Name = "optrtf"
        Me.optrtf.Size = New System.Drawing.Size(104, 24)
        Me.optrtf.TabIndex = 0
        Me.optrtf.Text = "Microsoft Word"
        '
        'opttxt
        '
        Me.opttxt.Location = New System.Drawing.Point(176, 56)
        Me.opttxt.Name = "opttxt"
        Me.opttxt.Size = New System.Drawing.Size(104, 24)
        Me.opttxt.TabIndex = 0
        Me.opttxt.Text = "Texto Plano"
        '
        'optprint
        '
        Me.optprint.Checked = True
        Me.optprint.Location = New System.Drawing.Point(176, 88)
        Me.optprint.Name = "optprint"
        Me.optprint.Size = New System.Drawing.Size(104, 24)
        Me.optprint.TabIndex = 0
        Me.optprint.TabStop = True
        Me.optprint.Text = "Vista Previa"
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Location = New System.Drawing.Point(144, 144)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdaceptar.TabIndex = 1
        Me.cmdaceptar.Text = "Aceptar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(232, 144)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancelar.TabIndex = 2
        Me.cmdcancelar.Text = "Cancelar"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.CustomPaperSize = New System.Drawing.Size(0, 0)
        Me.PrintableComponentLink1.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        '
        'frmexportaciongrid
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmexportaciongrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones de Exportacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmexportaciongrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintableComponentLink1.Component = Me.GridP

    End Sub

    Public Sub Mostrar(ByRef Grid As Object)
        GridP = Grid
        Me.ShowDialog()
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Dim Extension As String = vbNullString
        If optexcel.Checked Then Extension = "*.xls"
        If optpdf.Checked Then Extension = "*.pdf"
        If opthtml.Checked Then Extension = "*.html"
        If optrtf.Checked Then Extension = "*.rtf"
        If opttxt.Checked Then Extension = "*.txt"
        If Not optprint.Checked Then
            Guardar.DefaultExt = Extension
            Guardar.Filter = "(" & Extension & ")|" & Extension
            If Guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
                If optexcel.Checked Then GridP.ExportToXls(Guardar.FileName)
                If optpdf.Checked Then GridP.ExportToPdf(Guardar.FileName)
                If opthtml.Checked Then GridP.ExportToHtml(Guardar.FileName)
                If optrtf.Checked Then GridP.ExportToRtf(Guardar.FileName)
                If opttxt.Checked Then GridP.ExportToText(Guardar.FileName)
            End If
            Close()
        Else
            Close()

            Dim a As New DevExpress.XtraPrinting.PageHeaderFooter
            a.Header.Content.AddRange(New String() {"", Me.Titulo, ""})
            a.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            a.Footer.Content.AddRange(New String() {"Impreso el " & Today.ToShortDateString, "Pag´s: [Page # of Pages #]"})
            a.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            PrintableComponentLink1.PageHeaderFooter = a

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
            'GridP.ShowPrintPreview()
        End If
    End Sub

End Class
