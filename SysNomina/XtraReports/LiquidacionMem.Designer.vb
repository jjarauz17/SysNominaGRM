<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LiquidacionMem
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Detalle = New DevExpress.XtraReports.UI.XRSubreport()
        Me.ss = New DevExpress.XtraReports.UI.XRLabel()
        Me.monsimb = New DevExpress.XtraReports.UI.XRLabel()
        Me.raya2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.NyA = New DevExpress.XtraReports.UI.XRLabel()
        Me.Codigo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Dep = New DevExpress.XtraReports.UI.XRLabel()
        Me.Salariom = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ingreso = New DevExpress.XtraReports.UI.XRLabel()
        Me.Salida = New DevExpress.XtraReports.UI.XRLabel()
        Me.NyA2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Codigo2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Dep2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Salariom2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ingreso2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Salida2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TC = New DevExpress.XtraReports.UI.XRLabel()
        Me.salariocord = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.raya = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Fecha2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liqnum2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liqnum = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liquidacionf = New DevExpress.XtraReports.UI.XRLabel()
        Me.empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Detalle})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UsePadding = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Detalle
        '
        Me.Detalle.Id = 0
        Me.Detalle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        '
        'ss
        '
        Me.ss.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss.LocationFloat = New DevExpress.Utils.PointFloat(342.0!, 200.0!)
        Me.ss.Name = "ss"
        Me.ss.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ss.SizeF = New System.Drawing.SizeF(258.0!, 17.0!)
        Me.ss.StylePriority.UseFont = False
        Me.ss.Text = "T/C"
        '
        'monsimb
        '
        Me.monsimb.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.mon_simbolo")})
        Me.monsimb.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monsimb.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 200.0!)
        Me.monsimb.Name = "monsimb"
        Me.monsimb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.monsimb.SizeF = New System.Drawing.SizeF(50.0!, 17.0!)
        Me.monsimb.StylePriority.UseFont = False
        '
        'raya2
        '
        Me.raya2.BackColor = System.Drawing.Color.Transparent
        Me.raya2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.raya2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 267.0!)
        Me.raya2.Name = "raya2"
        Me.raya2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.raya2.SizeF = New System.Drawing.SizeF(650.0!, 2.0!)
        Me.raya2.StylePriority.UseBackColor = False
        Me.raya2.StylePriority.UseBorders = False
        Me.raya2.StylePriority.UsePadding = False
        '
        'NyA
        '
        Me.NyA.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NyA.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 100.0!)
        Me.NyA.Name = "NyA"
        Me.NyA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NyA.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.NyA.StylePriority.UseFont = False
        Me.NyA.Text = "Nombres y Apellidos:"
        '
        'Codigo
        '
        Me.Codigo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 125.0!)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Codigo.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Codigo.StylePriority.UseFont = False
        Me.Codigo.Text = "Codigo:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 150.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Dependencia:"
        '
        'Dep
        '
        Me.Dep.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dep.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 175.0!)
        Me.Dep.Name = "Dep"
        Me.Dep.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dep.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Dep.StylePriority.UseFont = False
        Me.Dep.Text = "Cargo:"
        '
        'Salariom
        '
        Me.Salariom.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salariom.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 200.0!)
        Me.Salariom.Name = "Salariom"
        Me.Salariom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salariom.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Salariom.StylePriority.UseFont = False
        Me.Salariom.Text = "Salario Mensual: "
        '
        'Ingreso
        '
        Me.Ingreso.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingreso.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 225.0!)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ingreso.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Ingreso.StylePriority.UseFont = False
        Me.Ingreso.Text = "Fecha de Ingreso:"
        '
        'Salida
        '
        Me.Salida.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salida.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 250.0!)
        Me.Salida.Name = "Salida"
        Me.Salida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salida.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Salida.StylePriority.UseFont = False
        Me.Salida.Text = "Fecha de salida:"
        '
        'NyA2
        '
        Me.NyA2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.nombre")})
        Me.NyA2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NyA2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 100.0!)
        Me.NyA2.Name = "NyA2"
        Me.NyA2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NyA2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.NyA2.StylePriority.UseFont = False
        '
        'Codigo2
        '
        Me.Codigo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.emp_codigo", "{0:n8}")})
        Me.Codigo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 125.0!)
        Me.Codigo2.Name = "Codigo2"
        Me.Codigo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Codigo2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Codigo2.StylePriority.UseFont = False
        '
        'Dep2
        '
        Me.Dep2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.dep_nombre")})
        Me.Dep2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dep2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 150.0!)
        Me.Dep2.Name = "Dep2"
        Me.Dep2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dep2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Dep2.StylePriority.UseFont = False
        '
        'Cargo2
        '
        Me.Cargo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.Funcion")})
        Me.Cargo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 175.0!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Cargo2.StylePriority.UseFont = False
        '
        'Salariom2
        '
        Me.Salariom2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_smensual", "{0:n2}")})
        Me.Salariom2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salariom2.LocationFloat = New DevExpress.Utils.PointFloat(233.0!, 200.0!)
        Me.Salariom2.Name = "Salariom2"
        Me.Salariom2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salariom2.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.Salariom2.StylePriority.UseFont = False
        Me.Salariom2.StylePriority.UseTextAlignment = False
        Me.Salariom2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Ingreso2
        '
        Me.Ingreso2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.emp_fingreso", "{0:dd""-""MMMM""-""yyyy}")})
        Me.Ingreso2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingreso2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 225.0!)
        Me.Ingreso2.Name = "Ingreso2"
        Me.Ingreso2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ingreso2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Ingreso2.StylePriority.UseFont = False
        '
        'Salida2
        '
        Me.Salida2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.baj_fecha", "{0:dd""-""MMMM""-""yyyy}")})
        Me.Salida2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salida2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 250.0!)
        Me.Salida2.Name = "Salida2"
        Me.Salida2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salida2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Salida2.StylePriority.UseFont = False
        '
        'TC
        '
        Me.TC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_tc", "{0:n2}")})
        Me.TC.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 75.0!)
        Me.TC.Name = "TC"
        Me.TC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TC.SizeF = New System.Drawing.SizeF(67.0!, 17.0!)
        Me.TC.StylePriority.UseFont = False
        Me.TC.StylePriority.UseTextAlignment = False
        Me.TC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.TC.Visible = False
        '
        'salariocord
        '
        Me.salariocord.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_salario", "{0:n2}")})
        Me.salariocord.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salariocord.LocationFloat = New DevExpress.Utils.PointFloat(350.0!, 75.0!)
        Me.salariocord.Name = "salariocord"
        Me.salariocord.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.salariocord.SizeF = New System.Drawing.SizeF(33.0!, 17.0!)
        Me.salariocord.StylePriority.UseFont = False
        Me.salariocord.StylePriority.UseTextAlignment = False
        Me.salariocord.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.salariocord.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ss, Me.monsimb, Me.raya2, Me.Salida2, Me.Codigo, Me.XrLabel10, Me.Dep, Me.Salariom, Me.Ingreso, Me.Salida, Me.NyA2, Me.Codigo2, Me.Dep2, Me.Cargo2, Me.Salariom2, Me.Ingreso2, Me.NyA, Me.salariocord, Me.TC, Me.raya, Me.Picture, Me.Fecha2, Me.Fecha, Me.Liqnum2, Me.Liqnum, Me.Liquidacionf, Me.empresa})
        Me.PageHeader.HeightF = 269.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'raya
        '
        Me.raya.BackColor = System.Drawing.Color.Transparent
        Me.raya.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.raya.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 92.0!)
        Me.raya.Name = "raya"
        Me.raya.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.raya.SizeF = New System.Drawing.SizeF(650.0!, 2.0!)
        Me.raya.StylePriority.UseBackColor = False
        Me.raya.StylePriority.UseBorders = False
        Me.raya.StylePriority.UsePadding = False
        '
        'Picture
        '
        Me.Picture.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 8.0!)
        Me.Picture.Name = "Picture"
        Me.Picture.SizeF = New System.Drawing.SizeF(92.0!, 59.0!)
        '
        'Fecha2
        '
        Me.Fecha2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_fecha", "{0:dd""-""MMMM""-""yyyy}")})
        Me.Fecha2.LocationFloat = New DevExpress.Utils.PointFloat(142.0!, 74.0!)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha2.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 75.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(133.0!, 17.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.Text = "Fecha de elaboracion:"
        '
        'Liqnum2
        '
        Me.Liqnum2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_codigo")})
        Me.Liqnum2.LocationFloat = New DevExpress.Utils.PointFloat(575.0!, 74.0!)
        Me.Liqnum2.Name = "Liqnum2"
        Me.Liqnum2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Liqnum2.SizeF = New System.Drawing.SizeF(67.0!, 17.0!)
        '
        'Liqnum
        '
        Me.Liqnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Liqnum.LocationFloat = New DevExpress.Utils.PointFloat(475.0!, 75.0!)
        Me.Liqnum.Name = "Liqnum"
        Me.Liqnum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Liqnum.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.Liqnum.StylePriority.UseFont = False
        Me.Liqnum.Text = "Liquidacion N°:"
        '
        'Liquidacionf
        '
        Me.Liquidacionf.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Liquidacionf.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 33.0!)
        Me.Liquidacionf.Multiline = True
        Me.Liquidacionf.Name = "Liquidacionf"
        Me.Liquidacionf.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Liquidacionf.SizeF = New System.Drawing.SizeF(642.0!, 33.0!)
        Me.Liquidacionf.StylePriority.UseFont = False
        Me.Liquidacionf.StylePriority.UseTextAlignment = False
        Me.Liquidacionf.Text = "Memoria de Cálculo de Liquidación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Prestaciones Sociales"
        Me.Liquidacionf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'empresa
        '
        Me.empresa.BackColor = System.Drawing.Color.Transparent
        Me.empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetLogoEmpresa.empresa")})
        Me.empresa.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empresa.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 0.0!)
        Me.empresa.Name = "empresa"
        Me.empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.empresa.SizeF = New System.Drawing.SizeF(642.0!, 33.0!)
        Me.empresa.StylePriority.UseBackColor = False
        Me.empresa.StylePriority.UseFont = False
        Me.empresa.StylePriority.UseTextAlignment = False
        Me.empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 25.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'LiquidacionMem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Version = "13.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Liquidacionf As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Liqnum2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Liqnum As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salariom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Dep As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Codigo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NyA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents raya As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ingreso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salida2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ingreso2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salariom2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Dep2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Codigo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NyA2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents raya2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents monsimb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents salariocord As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ss As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detalle As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
