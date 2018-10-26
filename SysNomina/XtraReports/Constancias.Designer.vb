<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Constancias
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.Departamento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.pblogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.CargoGerente = New DevExpress.XtraReports.UI.XRLabel
        Me.NombreGerente = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Pie = New DevExpress.XtraReports.UI.XRLabel
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel
        Me.Ingreso = New DevExpress.XtraReports.UI.XRLabel
        Me.Cargo = New DevExpress.XtraReports.UI.XRLabel
        Me.Salario = New DevExpress.XtraReports.UI.XRLabel
        Me.Area = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFormaPago = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Height = 0
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Departamento, Me.XrLabel1, Me.pblogo, Me.CargoGerente, Me.NombreGerente, Me.XrLine1, Me.Pie, Me.Nombre, Me.Ingreso, Me.Cargo, Me.Salario, Me.Area, Me.XrLabel9, Me.lblFormaPago, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.Empresa, Me.XrLabel4, Me.XrLabel2})
        Me.PageHeader.Height = 742
        Me.PageHeader.Name = "PageHeader"
        '
        'Departamento
        '
        Me.Departamento.CanShrink = True
        Me.Departamento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departamento", "")})
        Me.Departamento.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Departamento.Location = New System.Drawing.Point(233, 400)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Departamento.ParentStyleUsing.UseFont = False
        Me.Departamento.Size = New System.Drawing.Size(409, 34)
        Me.Departamento.Text = "Departamento"
        '
        'XrLabel1
        '
        Me.XrLabel1.CanShrink = True
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(8, 400)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(217, 34)
        Me.XrLabel1.Text = "Departamento:"
        '
        'pblogo
        '
        Me.pblogo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "_GetLogoEmpresa.logo", "")})
        Me.pblogo.Location = New System.Drawing.Point(500, 8)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(142, 92)
        Me.pblogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'CargoGerente
        '
        Me.CargoGerente.CanShrink = True
        Me.CargoGerente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CargoGerente", "")})
        Me.CargoGerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CargoGerente.Location = New System.Drawing.Point(192, 708)
        Me.CargoGerente.Name = "CargoGerente"
        Me.CargoGerente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CargoGerente.ParentStyleUsing.UseFont = False
        Me.CargoGerente.Size = New System.Drawing.Size(317, 34)
        Me.CargoGerente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'NombreGerente
        '
        Me.NombreGerente.CanShrink = True
        Me.NombreGerente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NombreGerente", "")})
        Me.NombreGerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreGerente.Location = New System.Drawing.Point(192, 675)
        Me.NombreGerente.Name = "NombreGerente"
        Me.NombreGerente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NombreGerente.ParentStyleUsing.UseFont = False
        Me.NombreGerente.Size = New System.Drawing.Size(317, 34)
        Me.NombreGerente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(208, 667)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(275, 8)
        '
        'Pie
        '
        Me.Pie.CanShrink = True
        Me.Pie.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Texto", "")})
        Me.Pie.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Pie.Location = New System.Drawing.Point(8, 483)
        Me.Pie.Name = "Pie"
        Me.Pie.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Pie.ParentStyleUsing.UseFont = False
        Me.Pie.Size = New System.Drawing.Size(634, 100)
        '
        'Nombre
        '
        Me.Nombre.CanShrink = True
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Nombre.Location = New System.Drawing.Point(233, 258)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.ParentStyleUsing.UseFont = False
        Me.Nombre.Size = New System.Drawing.Size(409, 34)
        '
        'Ingreso
        '
        Me.Ingreso.CanShrink = True
        Me.Ingreso.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ingreso", "{0:dd 'de' MMMM 'de' yyyy}")})
        Me.Ingreso.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Ingreso.Location = New System.Drawing.Point(233, 300)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ingreso.ParentStyleUsing.UseFont = False
        Me.Ingreso.Size = New System.Drawing.Size(409, 34)
        '
        'Cargo
        '
        Me.Cargo.CanShrink = True
        Me.Cargo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo", "")})
        Me.Cargo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Cargo.Location = New System.Drawing.Point(233, 333)
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo.ParentStyleUsing.UseFont = False
        Me.Cargo.Size = New System.Drawing.Size(409, 34)
        '
        'Salario
        '
        Me.Salario.CanShrink = True
        Me.Salario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Salario", "")})
        Me.Salario.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Salario.Location = New System.Drawing.Point(233, 367)
        Me.Salario.Name = "Salario"
        Me.Salario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salario.ParentStyleUsing.UseFont = False
        Me.Salario.Size = New System.Drawing.Size(409, 34)
        '
        'Area
        '
        Me.Area.CanShrink = True
        Me.Area.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Area", "")})
        Me.Area.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Area.Location = New System.Drawing.Point(233, 442)
        Me.Area.Name = "Area"
        Me.Area.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Area.ParentStyleUsing.UseFont = False
        Me.Area.Size = New System.Drawing.Size(409, 34)
        '
        'XrLabel9
        '
        Me.XrLabel9.CanShrink = True
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(8, 442)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(217, 34)
        Me.XrLabel9.Text = "Área:"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.CanShrink = True
        Me.lblFormaPago.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FormaPago", "")})
        Me.lblFormaPago.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormaPago.Location = New System.Drawing.Point(8, 367)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFormaPago.ParentStyleUsing.UseFont = False
        Me.lblFormaPago.Size = New System.Drawing.Size(217, 34)
        Me.lblFormaPago.Text = "Salario:"
        '
        'XrLabel7
        '
        Me.XrLabel7.CanShrink = True
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(8, 333)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(217, 34)
        Me.XrLabel7.Text = "Cargo:"
        '
        'XrLabel6
        '
        Me.XrLabel6.CanShrink = True
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(8, 300)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(217, 34)
        Me.XrLabel6.Text = "Fecha de Ingreso:"
        '
        'XrLabel5
        '
        Me.XrLabel5.CanShrink = True
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(8, 258)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(217, 34)
        Me.XrLabel5.Text = "Nombre del Colaborador"
        '
        'Empresa
        '
        Me.Empresa.CanShrink = True
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa", "")})
        Me.Empresa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Empresa.Location = New System.Drawing.Point(125, 197)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.ParentStyleUsing.UseFont = False
        Me.Empresa.Size = New System.Drawing.Size(308, 34)
        Me.Empresa.Text = "[ Digite el nombre de la Empresa]"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.XrLabel4.Location = New System.Drawing.Point(8, 158)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(642, 84)
        Me.XrLabel4.Text = "La suscrita Gerente de Recursos Humanos hace constar que los datos que a continua" & _
            "ción se detallan son válidos y corresponden a los registros de Administración de" & _
            " Personal de "
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(8, 117)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(642, 25)
        Me.XrLabel2.Text = "C O N S T A N C I A"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        '
        'Constancias
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ingreso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Pie As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CargoGerente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreGerente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents lblFormaPago As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents pblogo As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Departamento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
