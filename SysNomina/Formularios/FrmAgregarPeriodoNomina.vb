
Public Class frmAgregarPeriodoNomina
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarPeriodoNomina = Nothing
    Friend WithEvents Mes As System.Windows.Forms.MonthCalendar
    Dim iniciado As Boolean = False
    Private Rango As SelectionRange
    Dim Sufijo As String
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMinHextra As System.Windows.Forms.TextBox
    Friend WithEvents chkGenIndemnizacion As System.Windows.Forms.CheckBox

    Friend WithEvents dgFechas As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdCerrarDia As System.Windows.Forms.Button
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpSnack As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpMCS As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    'Dim Fechas As New VB.SysContab.FechasdeTrabajo

    Public Shared Function Instance() As frmAgregarPeriodoNomina
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarPeriodoNomina()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSemanas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCerrarDia = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpSnack = New DevExpress.XtraEditors.DateEdit()
        Me.dtpMCS = New DevExpress.XtraEditors.DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMinHextra = New System.Windows.Forms.TextBox()
        Me.chkGenIndemnizacion = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.Mes = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.txtSemanas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgFechas = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpSnack.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSnack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMCS.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMCS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(128, 40)
        Me.txtCodigo.MaxLength = 14
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(809, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 19)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(9, 19)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCerrarDia
        '
        Me.cmdCerrarDia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrarDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarDia.ForeColor = System.Drawing.Color.Black
        Me.cmdCerrarDia.Location = New System.Drawing.Point(731, 337)
        Me.cmdCerrarDia.Name = "cmdCerrarDia"
        Me.cmdCerrarDia.Size = New System.Drawing.Size(72, 24)
        Me.cmdCerrarDia.TabIndex = 2
        Me.cmdCerrarDia.Text = "Cerrar Dia"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 68)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.SystemColors.Window
        Me.cbTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"SEMANAL", "CATORCENAL", "QUINCENAL", "MENSUAL", "DESTAJO", "VACACIONES", "EXTRA", "UNIDAD DE TRABAJO(CORTE)"})
        Me.cbTipo.Location = New System.Drawing.Point(127, 13)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(400, 21)
        Me.cbTipo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Tipo:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 21)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Fecha SnackBar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(14, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 21)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Fecha MCS"
        '
        'dtpSnack
        '
        Me.dtpSnack.EditValue = Nothing
        Me.dtpSnack.Location = New System.Drawing.Point(143, 306)
        Me.dtpSnack.Name = "dtpSnack"
        Me.dtpSnack.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpSnack.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpSnack.Size = New System.Drawing.Size(144, 20)
        Me.dtpSnack.TabIndex = 145
        '
        'dtpMCS
        '
        Me.dtpMCS.EditValue = Nothing
        Me.dtpMCS.Location = New System.Drawing.Point(143, 280)
        Me.dtpMCS.Name = "dtpMCS"
        Me.dtpMCS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpMCS.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpMCS.Size = New System.Drawing.Size(144, 20)
        Me.dtpMCS.TabIndex = 144
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(458, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 20)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Generar Indemnización:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(458, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 24)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Valor Mínimo Hora Extra:"
        '
        'txtMinHextra
        '
        Me.txtMinHextra.Location = New System.Drawing.Point(675, 280)
        Me.txtMinHextra.Name = "txtMinHextra"
        Me.txtMinHextra.Size = New System.Drawing.Size(100, 20)
        Me.txtMinHextra.TabIndex = 141
        '
        'chkGenIndemnizacion
        '
        Me.chkGenIndemnizacion.AutoSize = True
        Me.chkGenIndemnizacion.Location = New System.Drawing.Point(675, 309)
        Me.chkGenIndemnizacion.Name = "chkGenIndemnizacion"
        Me.chkGenIndemnizacion.Size = New System.Drawing.Size(15, 14)
        Me.chkGenIndemnizacion.TabIndex = 140
        Me.chkGenIndemnizacion.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 38)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Origen Cálculos"
        '
        'cbOrigen
        '
        Me.cbOrigen.Items.AddRange(New Object() {"Periodo Definido", "Reloj"})
        Me.cbOrigen.Location = New System.Drawing.Point(128, 230)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbOrigen.TabIndex = 138
        '
        'Mes
        '
        Me.Mes.Location = New System.Drawing.Point(553, 13)
        Me.Mes.Name = "Mes"
        Me.Mes.ShowToday = False
        Me.Mes.TabIndex = 137
        Me.Mes.TitleForeColor = System.Drawing.Color.Orange
        Me.Mes.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Mensaje:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(127, 131)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(400, 80)
        Me.txtComentarios.TabIndex = 4
        '
        'txtSemanas
        '
        Me.txtSemanas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSemanas.Enabled = False
        Me.txtSemanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemanas.Location = New System.Drawing.Point(128, 94)
        Me.txtSemanas.MaxLength = 14
        Me.txtSemanas.Name = "txtSemanas"
        Me.txtSemanas.Size = New System.Drawing.Size(112, 20)
        Me.txtSemanas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Semanas:"
        '
        'dgFechas
        '
        Me.dgFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFechas.Location = New System.Drawing.Point(3, 3)
        Me.dgFechas.MainView = Me.Vista
        Me.dgFechas.Name = "dgFechas"
        Me.dgFechas.Size = New System.Drawing.Size(800, 328)
        Me.dgFechas.TabIndex = 2
        Me.dgFechas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        Me.dgFechas.Visible = False
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgFechas
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(809, 392)
        Me.XtraTabControl1.TabIndex = 125
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Window
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Label10)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.cbTipo)
        Me.XtraTabPage1.Controls.Add(Me.dtpSnack)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.dtpMCS)
        Me.XtraTabPage1.Controls.Add(Me.txtCodigo)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.txtMinHextra)
        Me.XtraTabPage1.Controls.Add(Me.Mes)
        Me.XtraTabPage1.Controls.Add(Me.chkGenIndemnizacion)
        Me.XtraTabPage1.Controls.Add(Me.txtDescripcion)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.txtSemanas)
        Me.XtraTabPage1.Controls.Add(Me.cbOrigen)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.txtComentarios)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(803, 364)
        Me.XtraTabPage1.Text = "Datos Generales"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.cmdCerrarDia)
        Me.XtraTabPage2.Controls.Add(Me.dgFechas)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(803, 364)
        Me.XtraTabPage2.Text = "Calendario"
        '
        'frmAgregarPeriodoNomina
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 458)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmAgregarPeriodoNomina"
        Me.Text = "Periodo de Nomina"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtpSnack.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSnack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMCS.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMCS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarPeriodoNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PNomina As New VB.SysContab.PeriodoNominaDB()

        Me.Mes.Enabled = False
        If Nuevo = "NO" Then
            Rango = New SelectionRange
            Me.Text = "Editar Periodo de Nomina"

            Dim Detalles As VB.SysContab.PeriodoNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
            Me.dgFechas.DataSource = Detalles.Calendario
            Me.Vista.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Vista.Columns("Fecha").DisplayFormat.FormatString = "D" 'DD, dd MMM yyyy"

            If Detalles.Calendario Is Nothing Then
                Me.dgFechas.Visible = False
                Me.cmdCerrarDia.Visible = False
            Else
                If Detalles.Calendario.Rows.Count = 0 Then
                    Me.dgFechas.Visible = False
                    Me.cmdCerrarDia.Visible = False
                Else
                    Me.dgFechas.Visible = True
                    Me.cmdCerrarDia.Visible = True
                End If
            End If
            Rango.Start = Detalles.FInicio
            Rango.End = Detalles.FFinal
            Me.Mes.MinDate = Rango.Start
            Me.Mes.MaxDate = Rango.End
            Me.Mes.MaxSelectionCount = IIf(Detalles.Tipo = "D" Or Detalles.Tipo = "U", 3, 1) * (DateDiff(DateInterval.Day, Rango.Start, Rango.End) + IIf(Detalles.Tipo = "C", 0, 1))
            Me.Mes.SelectionStart = Rango.Start
            Me.Mes.SelectionEnd = Rango.End

            Me.Mes.Refresh()

            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.txtComentarios.Text = Detalles.Comentarios
            Select Case Detalles.Tipo.ToUpper
                Case "S"
                    Me.cbTipo.SelectedText = "SEMANAL"
                Case "Q"
                    Me.cbTipo.SelectedText = "QUINCENAL"
                Case "M"
                    Me.cbTipo.SelectedText = "MENSUAL"
                Case "D"
                    Me.cbTipo.SelectedText = "DESTAJO"
                    'Case "L"
                    '    Me.cbTipo.SelectedText = "LIQUIDACION"
                Case "V"
                    Me.cbTipo.SelectedText = "VACACIONES"
                Case "E"
                    Me.cbTipo.SelectedText = "EXTRA"
                Case "U"
                    Me.cbTipo.SelectedText = "UNIDAD DE TRABAJO(CORTE)"
            End Select
            Me.chkGenIndemnizacion.Checked = Detalles.GenerarIndemnizacion
            Me.txtMinHextra.Text = Detalles.MinHoraExtra
            Me.cbOrigen.SelectedIndex = IIf(Microsoft.VisualBasic.Left(Detalles.Origen, 1) = "P", 0, 1)
            Me.cmdAceptar.Enabled = IIf(Detalles.Revisado = True Or Detalles.Aprobado = True Or Detalles.Contabilizado = True, False, True)
            ' Si el periodo es de destajo
            If Detalles.Tipo = "D" Or Detalles.Tipo = "U" Then
                Me.txtMinHextra.Enabled = True
                Me.chkGenIndemnizacion.Enabled = True
            Else
                Me.txtMinHextra.Enabled = False
                Me.chkGenIndemnizacion.Enabled = False
            End If
            Me.cbTipo.Enabled = False
            Me.cbOrigen.Enabled = False
            Me.dtpMCS.EditValue = Detalles.Fecha_MCS
            Me.dtpSnack.EditValue = Detalles.Fecha_SnackBar

        Else
            Me.Text = "Agregar Periodo de Nomina"
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""
            Me.cbTipo.SelectedText = "QUINCENAL"
            Me.cbTipo.Enabled = True
            Me.Mes.MaxSelectionCount = 15
            Me.cmdAceptar.Enabled = True
            Me.txtComentarios.Text = ""
            Me.cbOrigen.SelectedIndex = 0
            Me.cbOrigen.Enabled = False
            Me.txtMinHextra.Text = "-1"
            Me.txtMinHextra.Enabled = False
            Me.chkGenIndemnizacion.Checked = True
            Me.chkGenIndemnizacion.Enabled = False

        End If

        iniciado = True
        Me.Refresh()


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click

        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim em As New VB.SysContab.EmpresasDB(), Empresa As New VB.SysContab.EmpresasDetails()
        Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        Dim AFiscal As String ', cadena1 As String

        Dim FInicio, Ffinal As Date

        If Me.cbTipo.Text.Substring(0, 1) = "V" Then
            If Not (VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionEnd.Date.AddDays(1)) Is Nothing Or VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1)) = 0) Then
                FInicio = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1))).Inicio
                Ffinal = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1))).Final
            Else
                MsgBox("No hay Periodo Fiscal definido para la empresa", MsgBoxStyle.Critical, "STS-Nomina")
                Exit Sub
            End If
        Else
            If Not (VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date) Is Nothing Or VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date) = 0) Then
                FInicio = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date)).Inicio
                Ffinal = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date)).Final
            Else
                MsgBox("No hay Periodo Fiscal definido para la empresa", MsgBoxStyle.Critical, "STS-Nomina")
                Exit Sub
            End If
        End If

       

        If Me.Mes.SelectionStart.Date >= FInicio.Date And _
            Me.Mes.SelectionStart <= Ffinal.Date Then
            AFiscal = DatePart(DateInterval.Year, FInicio.Date) & "-" & _
                    DatePart(DateInterval.Year, Ffinal.Date)
        Else
            MsgBox("Esta intentando generar un Periodo de Nomina que esta fuera del año fiscal actual de la empresa", MsgBoxStyle.OkOnly)
            AFiscal = DatePart(DateInterval.Year, FInicio.Date) & "-" & _
                    DatePart(DateInterval.Year, Ffinal.Date)
            'Exit Sub
        End If

        If Me.dtpMCS.EditValue Is Nothing Then
            MsgBox("Seleccione la fecha de Corte del MCS por favor", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Me.dtpSnack.EditValue Is Nothing Then
            MsgBox("Seleccione la fecha de Corte del Snack Bar por favor", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Me.Mes.SelectionEnd < Me.dtpMCS.EditValue Then
            MsgBox("La fecha de cierre del MCS no debe ser mayor que la fecha de fin del periodo de nomina")
            Exit Sub
        End If
        If Me.Mes.SelectionEnd < Me.dtpSnack.EditValue Then
            MsgBox("La fecha de cierre del SNACK BAR no debe ser mayor que la fecha de fin del periodo de nomina")
            Exit Sub
        End If

        Dim cAFiscal As Int16
        cAFiscal = VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart)

        If Nuevo = "SI" Then

            VB.SysContab.PeriodoNominaDB.Additem(Me.txtCodigo.Text, Me.txtDescripcion.Text, _
                Me.Mes.SelectionStart, Me.Mes.SelectionEnd, _
                Me.cbTipo.Text.Substring(0, 1), AFiscal, _
                Me.txtSemanas.Text, Me.txtComentarios.Text, Microsoft.VisualBasic.Left(Me.cbOrigen.Text, 1), _
                Me.txtMinHextra.Text, Me.chkGenIndemnizacion.Checked, cAFiscal, Me.dtpMCS.EditValue, _
                Me.dtpSnack.EditValue, Me.Mes.SelectionEnd)

        Else
            'Modificar solo el comentario
            VB.SysContab.PeriodoNominaDB.Update_Comentario(Me.txtCodigo.Text, _
                    Me.cbTipo.Text.Substring(0, 1), _
                    Me.txtComentarios.Text, _
                    Me.dtpMCS.EditValue, Me.dtpSnack.EditValue)
        End If
        Me.Close()
    End Sub


    Private Sub cbTipo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipo.Validating
        Dim EmpresaDetail As New VB.SysContab.EmpresasDetails()

        Dim Rango As New SelectionRange()
        Dim Inicial As Boolean

        Sufijo = ""

        EmpresaDetail = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        If Me.cbTipo.Text.Substring(0, 1) <> "V" Then
            'Para Nominas Regulares
            Rango = VB.SysContab.PeriodoNominaDB.GetListNuevo(Me.cbTipo.Text.Substring(0, 1), Sufijo, Inicial, Date.Now)
        ElseIf Me.cbTipo.Text.Substring(0, 1) = "E" Then
            'Nominas Extras
            Rango = VB.SysContab.PeriodoNominaDB.GetListNuevo(Me.cbTipo.Text.Substring(0, 1), Sufijo, Inicial, Date.Now)
        Else
            'Para Vacaciones
            Rango.Start = DateAdd(DateInterval.Day, 1, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4)))
            Rango.End = CDate(Meses(Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 4, 2) - 1).ToString & "/" & _
                Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 4, 2) & "/" & _
                Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 7, 4))
            Sufijo = "01"
        End If

        If Sufijo Is DBNull.Value Then  'Se paso de las dos cifras
            MsgBox("Ya se ha pasado del maximo de 99 Nominas disponibles para este mes", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        If Rango Is Nothing Then 'Se devuelve Nothing cuando el periodo de nomina anterior no ha sido cerrado
            MsgBox("La Planilla del periodo anterior no ha sido procesada", MsgBoxStyle.OkOnly)
            Me.cmdAceptar.Enabled = False
            Exit Sub
        Else
            Me.cmdAceptar.Enabled = True
        End If
        'Buscar el siguiente periodo  correspondiente al tipo que se ha seleccionado
        Me.Mes.MinDate = Rango.Start
        Me.Mes.MaxDate = Rango.End 'IIf(Me.cbTipo.Text.Substring(0, 1) = "U", DateAdd(DateInterval.Day, 21, Rango.Start), Rango.End)
        Me.Mes.MaxSelectionCount = IIf(Me.cbTipo.Text.Substring(0, 1) = "D" Or Me.cbTipo.Text.Substring(0, 1) = "U", 3, 1) * (DateDiff(DateInterval.Day, Rango.Start, Rango.End) + IIf(Me.cbTipo.Text.Substring(0, 1) = "C", 0, 1))
        'Me.Mes.SelectionRange = Rango
        Me.Mes.SelectionStart = Rango.Start
        Me.Mes.SelectionEnd = Rango.End

        Me.Mes.Refresh()
        If Me.cbTipo.Text.Substring(0, 1) <> "E" And _
            Me.cbTipo.Text.Substring(0, 1) <> "C" And _
            Me.cbTipo.Text.Substring(0, 1) <> "D" And _
            Me.cbTipo.Text.Substring(0, 1) <> "U" And _
            Me.cbTipo.Text.Substring(0, 1) <> "S" Then
            Me.Mes.Enabled = Inicial
        Else
            Me.Mes.Enabled = True
            Me.Mes.MaxDate = IIf(Me.cbTipo.Text.Substring(0, 1) = "C" Or _
                            Me.cbTipo.Text.Substring(0, 1) = "D" Or _
                            Me.cbTipo.Text.Substring(0, 1) = "U", DateTimePicker.MaximumDateTime, Rango.End)
        End If
        'Sufijo
        If Sufijo <> "" And (Me.cbTipo.Text.Substring(0, 1) <> "V" And _
            Me.cbTipo.Text.Substring(0, 1) <> "E") Then
            Select Case Sufijo
                Case "01"
                    Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) = "M", "1er", "1era")

                Case "02"
                    Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) = "M", "2do", "2da")

                Case "03"
                    Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) <> "S" And Me.cbTipo.Text.Substring(0, 1) <> "D" And Me.cbTipo.Text.Substring(0, 1) <> "U", "Error-", "3ra")

                Case "04"
                    Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) <> "S", "Error-", "4ta")
            End Select

            Select Case Me.cbTipo.Text
                Case "SEMANAL"
                    Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Semana " & Format(Rango.End, "MMM") & "-" & Format(Rango.End, "yyyy")
                Case "CATORCENAL"
                    Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Catorcena " & Format(Rango.End, "MMM") & "-" & Format(Rango.End, "yyyy")
                Case "QUINCENAL"
                    Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                Case "MENSUAL"
                    Me.txtDescripcion.Text = "Mes de " & Format(Rango.Start, "MMMM") & "-" & Format(Rango.Start, "yyyy")
                Case "DESTAJO"
                    Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & " Destajo de " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                Case "UNIDAD DE TRABAJO(CORTE)"
                    Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & Me.cbTipo.Text & " " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                    'Case "LIQUIDACION"
                    '    Me.txtDescripcion.Text = "Liquidación Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy") 'Me.txtDescripcion.Text & " " & 
            End Select
            Me.txtCodigo.Text = Format(IIf(Me.cbTipo.Text = "CATORCENAL" Or Me.cbTipo.Text = "SEMANAL", Rango.End, Rango.Start), "yyyyMM") & Sufijo
            Me.txtSemanas.Text = VB.SysContab.RutinasNomina.BuscarSabados(Rango.Start, Rango.End)
            Me.txtDescripcion.Enabled = False
        ElseIf Me.cbTipo.Text.Substring(0, 1) = "V" Then
            Me.txtDescripcion.Text = "Pago de Vacaciones desde " & Rango.Start.ToShortDateString & " hasta " & Rango.End.ToShortDateString
            Me.txtCodigo.Text = Format(DateAdd(DateInterval.Day, 1, Rango.End), "yyyyMM") & Sufijo
            Me.txtDescripcion.Enabled = False
            Me.txtSemanas.Text = 0
        ElseIf Me.cbTipo.Text.Substring(0, 1) = "E" Then
            Me.txtDescripcion.Text = "Pago de Nómina Extra desde " & Rango.Start.ToShortDateString & " hasta " & Rango.End.ToShortDateString
            Me.txtDescripcion.Enabled = True
            Me.txtCodigo.Text = Format(Rango.End, "yyyyMM") & Sufijo
            Me.txtSemanas.Text = 0
        End If
        If Me.cbTipo.Text.Substring(0, 1) = "D" Or Me.cbTipo.Text.Substring(0, 1) = "U" Then
            Me.cbOrigen.SelectedIndex = 1
            Me.cbOrigen.Enabled = False 'Por el momento dejar que solo cambie el concepto sin que el usuario lo cambie. Por el momento
        Else
            Me.cbOrigen.SelectedIndex = 0
            Me.cbOrigen.Enabled = False
        End If

        If Me.cbTipo.Text.Substring(0, 1) = "D" Or Me.cbTipo.Text.Substring(0, 1) = "U" Then
            Me.txtMinHextra.Enabled = True
            Me.chkGenIndemnizacion.Enabled = True
        Else
            Me.txtMinHextra.Enabled = False
            Me.chkGenIndemnizacion.Enabled = False
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dejar este codigo para el caso de que se resuelva si la seleccion es permitida al usuario.'
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   Me.Mes.Enabled = True
        '   Select Case cbTipo.SelectedText
        '    Case "SEMANAL"
        '        Me.Mes.MaxSelectionCount = 7
        '        Me.Mes.MinDate = IIf(Weekday(CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))) = 1, _
        '               Me.Mes.TodayDate, _
        '               DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))), _
        '                   CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))))
        '        Me.Mes.MaxDate = DateAdd(DateInterval.Day, 27, Me.Mes.MinDate)
        '    Case "QUINCENAL"
        '        Me.Mes.MaxSelectionCount = 15
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '    Case "MENSUAL"
        '        Me.Mes.MaxSelectionCount = Meses(Month(Me.Mes.TodayDate))
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '    Case "DESTAJO"
        '        Me.Mes.MaxSelectionCount = Meses(Month(Me.Mes.TodayDate))
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))

        'End Select
    End Sub

    Private Sub Mes_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Mes.DateChanged
        If iniciado Then
            If (Me.cbTipo.Text.Substring(0, 1) = "D" Or Me.cbTipo.Text.Substring(0, 1) = "U") Then
                If (DateDiff(DateInterval.Day, Me.Mes.SelectionStart, Me.Mes.SelectionEnd) + 1) Mod 7 <> 0 Then
                    Me.Mes.SelectionEnd = DateAdd(DateInterval.Day, ((((DateDiff(DateInterval.Day, Me.Mes.SelectionStart, Me.Mes.SelectionEnd) + 1) \ 7) + 1) * 7) - 1, Me.Mes.SelectionStart)
                End If


                If Sufijo <> "" And (Me.cbTipo.Text.Substring(0, 1) <> "V" And _
                    Me.cbTipo.Text.Substring(0, 1) <> "E") Then
                    Select Case Sufijo
                        Case "01"
                            Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) = "M", "1er", "1era")

                        Case "02"
                            Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) = "M", "2do", "2da")

                        Case "03"
                            Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) <> "S" And Me.cbTipo.Text.Substring(0, 1) <> "D" And Me.cbTipo.Text.Substring(0, 1) <> "U", "Error-", "3ra")

                        Case "04"
                            Me.txtDescripcion.Text = IIf(Me.cbTipo.Text.Substring(0, 1) <> "S", "Error-", "4ta")
                    End Select

                    Select Case Me.cbTipo.Text
                        Case "SEMANAL"
                            Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Semana " & Format(Me.Mes.SelectionEnd, "MMM") & "-" & Format(Me.Mes.SelectionEnd, "yyyy")
                        Case "CATORCENAL"
                            Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Catorcena " & Format(Me.Mes.SelectionEnd, "MMM") & "-" & Format(Me.Mes.SelectionEnd, "yyyy")
                        Case "QUINCENAL"
                            Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & "Quincena " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "MENSUAL"
                            Me.txtDescripcion.Text = "Mes de " & Format(Rango.Start, "MMMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "DESTAJO"
                            Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & " Destajo de " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "UNIDAD DE TRABAJO(CORTE)"
                            Me.txtDescripcion.Text = Me.txtDescripcion.Text & " " & Me.cbTipo.Text & " " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                            'Case "LIQUIDACION"
                            '    Me.txtDescripcion.Text = "Liquidación Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy") 'Me.txtDescripcion.Text & " " & 
                    End Select
                End If
                Me.txtCodigo.Text = Format(IIf(Me.cbTipo.Text = "CATORCENAL" Or Me.cbTipo.Text = "SEMANAL", Me.Mes.SelectionEnd, Me.Mes.SelectionStart), "yyyyMM") & Sufijo
                Me.txtSemanas.Text = VB.SysContab.RutinasNomina.BuscarSabados(Me.Mes.SelectionStart, Me.Mes.SelectionEnd)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarDia.Click
        If Me.dgFechas.Visible = True Then
            If Me.Vista.DataRowCount = 0 Then
                MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
                Exit Sub
            Else
                If Me.Vista.GetFocusedRowCellValue("Cerrado") = True Then
                    If MsgBox("Este Dia ya esta cerrado, desea re-abrirlo para edición?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        VB.SysContab.PeriodoNominaDB.PeriodoNomina_Fecha_Cerrar(Me.txtCodigo.Text.Substring(0, 8), _
                            Me.cbTipo.Text.Substring(0, 1), Me.Vista.GetFocusedRowCellValue("Fecha"), False)
                        Me.Vista.SetFocusedRowCellValue(Me.Vista.Columns("Cerrado"), False)
                    End If
                Else
                    MsgBox("No se puede cerrar un dia desde la Nomina, favor comunicarse" & vbCrLf & _
                        "con el administrador de SysAsistencias", MsgBoxStyle.Critical, "Sts.Nomina")
                    Exit Sub
                End If
            End If
        End If

    End Sub

   
End Class
