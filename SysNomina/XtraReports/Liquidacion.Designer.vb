<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Liquidacion
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
        Me.Maximo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lMaximo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Promedio = New DevExpress.XtraReports.UI.XRLabel()
        Me.lPromedio = New DevExpress.XtraReports.UI.XRLabel()
        Me.ss = New DevExpress.XtraReports.UI.XRLabel()
        Me.monsimb = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liq_det = New DevExpress.XtraReports.UI.XRSubreport()
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
        Me.sfijo = New DevExpress.XtraReports.UI.XRLabel()
        Me.raya = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Fecha2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liqnum2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liqnum = New DevExpress.XtraReports.UI.XRLabel()
        Me.Liquidacionf = New DevExpress.XtraReports.UI.XRLabel()
        Me.empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.inssl = New DevExpress.XtraReports.UI.XRLabel()
        Me.ir = New DevExpress.XtraReports.UI.XRLabel()
        Me.teg = New DevExpress.XtraReports.UI.XRLabel()
        Me.ting = New DevExpress.XtraReports.UI.XRLabel()
        Me.monto_letras = New DevExpress.XtraReports.UI.XRLabel()
        Me.detallado = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.INSS_P = New DevExpress.XtraReports.UI.XRLabel()
        Me.INATEC = New DevExpress.XtraReports.UI.XRLabel()
        Me.Inatec1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.INSS = New DevExpress.XtraReports.UI.XRLabel()
        Me.TT_REC = New DevExpress.XtraReports.UI.XRLabel()
        Me.ttrecib = New DevExpress.XtraReports.UI.XRLabel()
        Me.raya1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.autorizado = New DevExpress.XtraReports.UI.XRLabel()
        Me.revisado = New DevExpress.XtraReports.UI.XRLabel()
        Me.elaborado = New DevExpress.XtraReports.UI.XRLabel()
        Me.f_autorizado = New DevExpress.XtraReports.UI.XRLabel()
        Me.f_revisado = New DevExpress.XtraReports.UI.XRLabel()
        Me.f_elaborado = New DevExpress.XtraReports.UI.XRLabel()
        Me.cedula = New DevExpress.XtraReports.UI.XRLabel()
        Me.cedula_num = New DevExpress.XtraReports.UI.XRLabel()
        Me.nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.rec_conf = New DevExpress.XtraReports.UI.XRLabel()
        Me.firma_recib = New DevExpress.XtraReports.UI.XRLabel()
        Me.rayadoble = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Maximo, Me.lMaximo, Me.Promedio, Me.lPromedio, Me.ss, Me.monsimb, Me.Liq_det, Me.raya2, Me.NyA, Me.Codigo, Me.XrLabel10, Me.Dep, Me.Salariom, Me.Ingreso, Me.Salida, Me.NyA2, Me.Codigo2, Me.Dep2, Me.Cargo2, Me.Salariom2, Me.Ingreso2, Me.Salida2})
        Me.Detail.HeightF = 233.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UsePadding = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Maximo
        '
        Me.Maximo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.Maximo", "{0:n2}")})
        Me.Maximo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximo.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 133.0!)
        Me.Maximo.Name = "Maximo"
        Me.Maximo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Maximo.SizeF = New System.Drawing.SizeF(117.0!, 17.0!)
        Me.Maximo.StylePriority.UseFont = False
        Me.Maximo.Text = "Promedio"
        '
        'lMaximo
        '
        Me.lMaximo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaximo.LocationFloat = New DevExpress.Utils.PointFloat(342.0!, 133.0!)
        Me.lMaximo.Name = "lMaximo"
        Me.lMaximo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lMaximo.SizeF = New System.Drawing.SizeF(125.0!, 17.0!)
        Me.lMaximo.StylePriority.UseFont = False
        Me.lMaximo.Text = "Salario M�ximo: C$"
        '
        'Promedio
        '
        Me.Promedio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.Promedio", "{0:n2}")})
        Me.Promedio.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promedio.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 133.0!)
        Me.Promedio.Name = "Promedio"
        Me.Promedio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Promedio.SizeF = New System.Drawing.SizeF(117.0!, 17.0!)
        Me.Promedio.StylePriority.UseFont = False
        Me.Promedio.Text = "Promedio"
        '
        'lPromedio
        '
        Me.lPromedio.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPromedio.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 133.0!)
        Me.lPromedio.Name = "lPromedio"
        Me.lPromedio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lPromedio.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.lPromedio.StylePriority.UseFont = False
        Me.lPromedio.Text = "Salario Promedio: C$"
        '
        'ss
        '
        Me.ss.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss.LocationFloat = New DevExpress.Utils.PointFloat(342.0!, 108.0!)
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
        Me.monsimb.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 108.0!)
        Me.monsimb.Name = "monsimb"
        Me.monsimb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.monsimb.SizeF = New System.Drawing.SizeF(50.0!, 17.0!)
        Me.monsimb.StylePriority.UseFont = False
        '
        'Liq_det
        '
        Me.Liq_det.Id = 0
        Me.Liq_det.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 208.0!)
        Me.Liq_det.Name = "Liq_det"
        Me.Liq_det.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        '
        'raya2
        '
        Me.raya2.BackColor = System.Drawing.Color.Transparent
        Me.raya2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.raya2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 200.0!)
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
        Me.NyA.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 8.0!)
        Me.NyA.Name = "NyA"
        Me.NyA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NyA.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.NyA.StylePriority.UseFont = False
        Me.NyA.Text = "Nombres y Apellidos:"
        '
        'Codigo
        '
        Me.Codigo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 33.0!)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Codigo.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Codigo.StylePriority.UseFont = False
        Me.Codigo.Text = "Codigo:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 58.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Dependencia:"
        '
        'Dep
        '
        Me.Dep.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dep.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 83.0!)
        Me.Dep.Name = "Dep"
        Me.Dep.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dep.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Dep.StylePriority.UseFont = False
        Me.Dep.Text = "Cargo:"
        '
        'Salariom
        '
        Me.Salariom.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salariom.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 108.0!)
        Me.Salariom.Name = "Salariom"
        Me.Salariom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salariom.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Salariom.StylePriority.UseFont = False
        Me.Salariom.Text = "Salario Mensual: "
        '
        'Ingreso
        '
        Me.Ingreso.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingreso.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 158.0!)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ingreso.SizeF = New System.Drawing.SizeF(167.0!, 17.0!)
        Me.Ingreso.StylePriority.UseFont = False
        Me.Ingreso.Text = "Fecha de Ingreso:"
        '
        'Salida
        '
        Me.Salida.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salida.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 183.0!)
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
        Me.NyA2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 8.0!)
        Me.NyA2.Name = "NyA2"
        Me.NyA2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NyA2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.NyA2.StylePriority.UseFont = False
        '
        'Codigo2
        '
        Me.Codigo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.emp_codigo", "{0:n8}")})
        Me.Codigo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 33.0!)
        Me.Codigo2.Name = "Codigo2"
        Me.Codigo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Codigo2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Codigo2.StylePriority.UseFont = False
        '
        'Dep2
        '
        Me.Dep2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.dep_nombre")})
        Me.Dep2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dep2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 58.0!)
        Me.Dep2.Name = "Dep2"
        Me.Dep2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dep2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Dep2.StylePriority.UseFont = False
        '
        'Cargo2
        '
        Me.Cargo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.Funcion")})
        Me.Cargo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 83.0!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Cargo2.StylePriority.UseFont = False
        '
        'Salariom2
        '
        Me.Salariom2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_smensual", "{0:n2}")})
        Me.Salariom2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salariom2.LocationFloat = New DevExpress.Utils.PointFloat(233.0!, 108.0!)
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
        Me.Ingreso2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 158.0!)
        Me.Ingreso2.Name = "Ingreso2"
        Me.Ingreso2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ingreso2.SizeF = New System.Drawing.SizeF(467.0!, 17.0!)
        Me.Ingreso2.StylePriority.UseFont = False
        '
        'Salida2
        '
        Me.Salida2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.baj_fecha", "{0:dd""-""MMMM""-""yyyy}")})
        Me.Salida2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salida2.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 183.0!)
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.sfijo, Me.salariocord, Me.TC, Me.raya, Me.Picture, Me.Fecha2, Me.Fecha, Me.Liqnum2, Me.Liqnum, Me.Liquidacionf, Me.empresa})
        Me.PageHeader.HeightF = 96.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'sfijo
        '
        Me.sfijo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.SFijo")})
        Me.sfijo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfijo.LocationFloat = New DevExpress.Utils.PointFloat(392.0!, 75.0!)
        Me.sfijo.Name = "sfijo"
        Me.sfijo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.sfijo.SizeF = New System.Drawing.SizeF(50.0!, 17.0!)
        Me.sfijo.StylePriority.UseFont = False
        Me.sfijo.Text = "sfijo"
        Me.sfijo.Visible = False
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
        Me.Liqnum.Text = "Liquidacion N�:"
        '
        'Liquidacionf
        '
        Me.Liquidacionf.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Liquidacionf.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 42.0!)
        Me.Liquidacionf.Name = "Liquidacionf"
        Me.Liquidacionf.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Liquidacionf.SizeF = New System.Drawing.SizeF(642.0!, 25.0!)
        Me.Liquidacionf.StylePriority.UseFont = False
        Me.Liquidacionf.StylePriority.UseTextAlignment = False
        Me.Liquidacionf.Text = "Liquidacion final de prestaciones sociales."
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
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.inssl, Me.ir, Me.teg, Me.ting, Me.monto_letras, Me.detallado, Me.XrLabel21, Me.INSS_P, Me.INATEC, Me.Inatec1, Me.INSS, Me.TT_REC, Me.ttrecib, Me.raya1, Me.XrLabel15, Me.XrLabel14, Me.autorizado, Me.revisado, Me.elaborado, Me.f_autorizado, Me.f_revisado, Me.f_elaborado, Me.cedula, Me.cedula_num, Me.nombre, Me.rec_conf, Me.firma_recib, Me.rayadoble})
        Me.PageFooter.HeightF = 302.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'inssl
        '
        Me.inssl.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_inss", "{0:n2}")})
        Me.inssl.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inssl.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 8.0!)
        Me.inssl.Name = "inssl"
        Me.inssl.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.inssl.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.inssl.StylePriority.UseFont = False
        Me.inssl.Text = "inssl"
        Me.inssl.Visible = False
        '
        'ir
        '
        Me.ir.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_ir", "{0:n2}")})
        Me.ir.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ir.LocationFloat = New DevExpress.Utils.PointFloat(358.0!, 8.0!)
        Me.ir.Name = "ir"
        Me.ir.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ir.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.ir.StylePriority.UseFont = False
        Me.ir.Text = "ir"
        Me.ir.Visible = False
        '
        'teg
        '
        Me.teg.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_egresos", "{0:n2}")})
        Me.teg.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teg.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 8.0!)
        Me.teg.Name = "teg"
        Me.teg.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.teg.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.teg.StylePriority.UseFont = False
        Me.teg.Text = "teg"
        Me.teg.Visible = False
        '
        'ting
        '
        Me.ting.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_tingresos", "{0:n2}")})
        Me.ting.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ting.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 8.0!)
        Me.ting.Name = "ting"
        Me.ting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ting.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.ting.StylePriority.UseFont = False
        Me.ting.Text = "ting"
        Me.ting.Visible = False
        '
        'monto_letras
        '
        Me.monto_letras.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.letras")})
        Me.monto_letras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monto_letras.LocationFloat = New DevExpress.Utils.PointFloat(458.0!, 92.0!)
        Me.monto_letras.Name = "monto_letras"
        Me.monto_letras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.monto_letras.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.monto_letras.StylePriority.UseFont = False
        Me.monto_letras.Visible = False
        '
        'detallado
        '
        Me.detallado.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 125.0!)
        Me.detallado.Name = "detallado"
        Me.detallado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.detallado.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        Me.detallado.StylePriority.UseTextAlignment = False
        Me.detallado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel21
        '
        Me.XrLabel21.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 117.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(650.0!, 2.0!)
        Me.XrLabel21.StylePriority.UseBackColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UsePadding = False
        '
        'INSS_P
        '
        Me.INSS_P.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_INSSPatronal", "{0:n2}")})
        Me.INSS_P.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSS_P.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 75.0!)
        Me.INSS_P.Name = "INSS_P"
        Me.INSS_P.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.INSS_P.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.INSS_P.StylePriority.UseFont = False
        Me.INSS_P.StylePriority.UseTextAlignment = False
        Me.INSS_P.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'INATEC
        '
        Me.INATEC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.liq_inatec", "{0:n2}")})
        Me.INATEC.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INATEC.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 92.0!)
        Me.INATEC.Name = "INATEC"
        Me.INATEC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.INATEC.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.INATEC.StylePriority.UseFont = False
        Me.INATEC.StylePriority.UseTextAlignment = False
        Me.INATEC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Inatec1
        '
        Me.Inatec1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inatec1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 92.0!)
        Me.Inatec1.Name = "Inatec1"
        Me.Inatec1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Inatec1.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.Inatec1.StylePriority.UseFont = False
        Me.Inatec1.Text = "INATEC"
        '
        'INSS
        '
        Me.INSS.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSS.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 75.0!)
        Me.INSS.Multiline = True
        Me.INSS.Name = "INSS"
        Me.INSS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.INSS.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        Me.INSS.StylePriority.UseFont = False
        Me.INSS.Text = "INSS Patronal"
        '
        'TT_REC
        '
        Me.TT_REC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.tt_rec", "{0:n2}")})
        Me.TT_REC.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_REC.LocationFloat = New DevExpress.Utils.PointFloat(567.0!, 50.0!)
        Me.TT_REC.Name = "TT_REC"
        Me.TT_REC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TT_REC.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.TT_REC.StylePriority.UseFont = False
        Me.TT_REC.StylePriority.UseTextAlignment = False
        Me.TT_REC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ttrecib
        '
        Me.ttrecib.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttrecib.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.ttrecib.Name = "ttrecib"
        Me.ttrecib.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ttrecib.SizeF = New System.Drawing.SizeF(133.0!, 17.0!)
        Me.ttrecib.StylePriority.UseFont = False
        Me.ttrecib.Text = "Total a Recibir:"
        '
        'raya1
        '
        Me.raya1.BackColor = System.Drawing.Color.Transparent
        Me.raya1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.raya1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 42.0!)
        Me.raya1.Name = "raya1"
        Me.raya1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.raya1.SizeF = New System.Drawing.SizeF(650.0!, 2.0!)
        Me.raya1.StylePriority.UseBackColor = False
        Me.raya1.StylePriority.UseBorders = False
        Me.raya1.StylePriority.UsePadding = False
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(133.0!, 17.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "* Gravable IR"
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 17.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(133.0!, 17.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "** Gravable INSS"
        '
        'autorizado
        '
        Me.autorizado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autorizado.LocationFloat = New DevExpress.Utils.PointFloat(517.0!, 283.0!)
        Me.autorizado.Name = "autorizado"
        Me.autorizado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.autorizado.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.autorizado.StylePriority.UseFont = False
        Me.autorizado.Text = "Autorizado"
        '
        'revisado
        '
        Me.revisado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revisado.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 283.0!)
        Me.revisado.Name = "revisado"
        Me.revisado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.revisado.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.revisado.StylePriority.UseFont = False
        Me.revisado.Text = "Revisado"
        '
        'elaborado
        '
        Me.elaborado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elaborado.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 283.0!)
        Me.elaborado.Name = "elaborado"
        Me.elaborado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.elaborado.SizeF = New System.Drawing.SizeF(83.0!, 17.0!)
        Me.elaborado.StylePriority.UseFont = False
        Me.elaborado.Text = "Elaborado"
        '
        'f_autorizado
        '
        Me.f_autorizado.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.f_autorizado.LocationFloat = New DevExpress.Utils.PointFloat(458.0!, 275.0!)
        Me.f_autorizado.Name = "f_autorizado"
        Me.f_autorizado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.f_autorizado.SizeF = New System.Drawing.SizeF(183.0!, 8.0!)
        Me.f_autorizado.StylePriority.UseBorders = False
        '
        'f_revisado
        '
        Me.f_revisado.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.f_revisado.LocationFloat = New DevExpress.Utils.PointFloat(233.0!, 275.0!)
        Me.f_revisado.Name = "f_revisado"
        Me.f_revisado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.f_revisado.SizeF = New System.Drawing.SizeF(183.0!, 8.0!)
        Me.f_revisado.StylePriority.UseBorders = False
        '
        'f_elaborado
        '
        Me.f_elaborado.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.f_elaborado.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 275.0!)
        Me.f_elaborado.Name = "f_elaborado"
        Me.f_elaborado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.f_elaborado.SizeF = New System.Drawing.SizeF(183.0!, 8.0!)
        Me.f_elaborado.StylePriority.UseBorders = False
        '
        'cedula
        '
        Me.cedula.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 226.0!)
        Me.cedula.Name = "cedula"
        Me.cedula.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cedula.SizeF = New System.Drawing.SizeF(58.0!, 17.0!)
        Me.cedula.StylePriority.UseFont = False
        Me.cedula.Text = "Ced #"
        '
        'cedula_num
        '
        Me.cedula_num.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.emp_cedula", "{0:n2}")})
        Me.cedula_num.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula_num.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 226.0!)
        Me.cedula_num.Name = "cedula_num"
        Me.cedula_num.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cedula_num.SizeF = New System.Drawing.SizeF(175.0!, 17.0!)
        Me.cedula_num.StylePriority.UseFont = False
        '
        'nombre
        '
        Me.nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vLiquidacionEnc.nombre")})
        Me.nombre.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 208.0!)
        Me.nombre.Name = "nombre"
        Me.nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nombre.SizeF = New System.Drawing.SizeF(233.0!, 17.0!)
        Me.nombre.StylePriority.UseFont = False
        Me.nombre.StylePriority.UseTextAlignment = False
        Me.nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'rec_conf
        '
        Me.rec_conf.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec_conf.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 192.0!)
        Me.rec_conf.Name = "rec_conf"
        Me.rec_conf.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.rec_conf.SizeF = New System.Drawing.SizeF(125.0!, 17.0!)
        Me.rec_conf.StylePriority.UseFont = False
        Me.rec_conf.Text = "Recibi Conforme"
        '
        'firma_recib
        '
        Me.firma_recib.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.firma_recib.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 183.0!)
        Me.firma_recib.Name = "firma_recib"
        Me.firma_recib.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.firma_recib.SizeF = New System.Drawing.SizeF(234.0!, 8.0!)
        Me.firma_recib.StylePriority.UseBorders = False
        '
        'rayadoble
        '
        Me.rayadoble.BackColor = System.Drawing.Color.Transparent
        Me.rayadoble.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.rayadoble.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 152.0!)
        Me.rayadoble.Name = "rayadoble"
        Me.rayadoble.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.rayadoble.SizeF = New System.Drawing.SizeF(650.0!, 8.0!)
        Me.rayadoble.StylePriority.UseBackColor = False
        Me.rayadoble.StylePriority.UseBorders = False
        Me.rayadoble.StylePriority.UsePadding = False
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'Liquidacion
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
    Friend WithEvents rayadoble As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents elaborado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents f_autorizado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents f_revisado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents f_elaborado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cedula As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cedula_num As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rec_conf As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents firma_recib As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents autorizado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents revisado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Liq_det As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents monto_letras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents detallado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents INSS_P As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents INATEC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Inatec1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents INSS As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TT_REC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ttrecib As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents raya1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents monsimb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents salariocord As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ss As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents inssl As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ir As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents teg As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ting As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Promedio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lPromedio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Maximo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lMaximo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sfijo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
