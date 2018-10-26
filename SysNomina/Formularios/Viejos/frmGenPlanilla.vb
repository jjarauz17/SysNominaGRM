Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Net.Mail.SmtpClient
Imports System.Xml
Imports System.Net.Mail.MailMessage



Public Class frmGenPlanilla
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmGenPlanilla = Nothing
    Public cEmpleado, cDepartamento, cArea, cOrden As String
    Public cLocalidad As Integer = 0
    Public ChkSalario As Boolean = True
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dgPeriodoNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents vPlanillas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Public Cancelar As Boolean

    Public Shared Function Instance() As frmGenPlanilla
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGenPlanilla()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGenFirme As System.Windows.Forms.Button
    Friend WithEvents cmdGenTemporal As System.Windows.Forms.Button
    Friend WithEvents cmdVisor As System.Windows.Forms.Button
    Friend WithEvents cmdVerFichas As System.Windows.Forms.Button
    Friend WithEvents cmdIRSairi As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents btnFirmasPlanilla As System.Windows.Forms.Button
    Friend WithEvents btnXMLINSS As System.Windows.Forms.Button
    Friend WithEvents btnBAC As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnConsolidado As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbArchivos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEnvio As System.Windows.Forms.Label
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdCaldera As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdVerFichas = New System.Windows.Forms.Button
        Me.cmdVisor = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdGenTemporal = New System.Windows.Forms.Button
        Me.btnFirmasPlanilla = New System.Windows.Forms.Button
        Me.btnEmail = New System.Windows.Forms.Button
        Me.cmdGenFirme = New System.Windows.Forms.Button
        Me.btnXMLINSS = New System.Windows.Forms.Button
        Me.btnBAC = New System.Windows.Forms.Button
        Me.cmdIRSairi = New System.Windows.Forms.Button
        Me.gbArchivos = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnConsolidado = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdCaldera = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtEnvio = New System.Windows.Forms.Label
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.dgPeriodoNomina = New DevExpress.XtraGrid.GridControl
        Me.vPlanillas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.gbArchivos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdVerFichas)
        Me.GroupBox1.Controls.Add(Me.cmdVisor)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdGenTemporal)
        Me.GroupBox1.Location = New System.Drawing.Point(824, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 244)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdVerFichas
        '
        Me.cmdVerFichas.Location = New System.Drawing.Point(8, 48)
        Me.cmdVerFichas.Name = "cmdVerFichas"
        Me.cmdVerFichas.Size = New System.Drawing.Size(112, 24)
        Me.cmdVerFichas.TabIndex = 10
        Me.cmdVerFichas.Text = "Colillas de Pago"
        '
        'cmdVisor
        '
        Me.cmdVisor.Location = New System.Drawing.Point(8, 24)
        Me.cmdVisor.Name = "cmdVisor"
        Me.cmdVisor.Size = New System.Drawing.Size(112, 24)
        Me.cmdVisor.TabIndex = 9
        Me.cmdVisor.Text = "Ver Planilla"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 72)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdGenTemporal
        '
        Me.cmdGenTemporal.Location = New System.Drawing.Point(8, 184)
        Me.cmdGenTemporal.Name = "cmdGenTemporal"
        Me.cmdGenTemporal.Size = New System.Drawing.Size(112, 24)
        Me.cmdGenTemporal.TabIndex = 1
        Me.cmdGenTemporal.Text = "Generar Temporal"
        Me.cmdGenTemporal.Visible = False
        '
        'btnFirmasPlanilla
        '
        Me.btnFirmasPlanilla.Location = New System.Drawing.Point(256, 16)
        Me.btnFirmasPlanilla.Name = "btnFirmasPlanilla"
        Me.btnFirmasPlanilla.Size = New System.Drawing.Size(112, 24)
        Me.btnFirmasPlanilla.TabIndex = 14
        Me.btnFirmasPlanilla.Text = "Firmas de Planilla"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(136, 16)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(112, 24)
        Me.btnEmail.TabIndex = 13
        Me.btnEmail.Text = "Enviar Colillas"
        '
        'cmdGenFirme
        '
        Me.cmdGenFirme.Location = New System.Drawing.Point(16, 16)
        Me.cmdGenFirme.Name = "cmdGenFirme"
        Me.cmdGenFirme.Size = New System.Drawing.Size(112, 24)
        Me.cmdGenFirme.TabIndex = 8
        Me.cmdGenFirme.Text = "Generar "
        '
        'btnXMLINSS
        '
        Me.btnXMLINSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXMLINSS.Location = New System.Drawing.Point(8, 72)
        Me.btnXMLINSS.Name = "btnXMLINSS"
        Me.btnXMLINSS.Size = New System.Drawing.Size(112, 24)
        Me.btnXMLINSS.TabIndex = 15
        Me.btnXMLINSS.Text = "Generar XML INSS"
        '
        'btnBAC
        '
        Me.btnBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBAC.Location = New System.Drawing.Point(8, 48)
        Me.btnBAC.Name = "btnBAC"
        Me.btnBAC.Size = New System.Drawing.Size(112, 24)
        Me.btnBAC.TabIndex = 12
        Me.btnBAC.Text = "Gen. Arch Elect."
        '
        'cmdIRSairi
        '
        Me.cmdIRSairi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRSairi.Location = New System.Drawing.Point(8, 24)
        Me.cmdIRSairi.Name = "cmdIRSairi"
        Me.cmdIRSairi.Size = New System.Drawing.Size(112, 24)
        Me.cmdIRSairi.TabIndex = 11
        Me.cmdIRSairi.Text = "Generar IR"
        '
        'gbArchivos
        '
        Me.gbArchivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbArchivos.Controls.Add(Me.cmdIRSairi)
        Me.gbArchivos.Controls.Add(Me.btnXMLINSS)
        Me.gbArchivos.Controls.Add(Me.btnBAC)
        Me.gbArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArchivos.Location = New System.Drawing.Point(824, 256)
        Me.gbArchivos.Name = "gbArchivos"
        Me.gbArchivos.Size = New System.Drawing.Size(128, 120)
        Me.gbArchivos.TabIndex = 115
        Me.gbArchivos.TabStop = False
        Me.gbArchivos.Text = "Archivos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnConsolidado)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.cmdCaldera)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(824, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 136)
        Me.GroupBox3.TabIndex = 116
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reportes"
        '
        'btnConsolidado
        '
        Me.btnConsolidado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolidado.Location = New System.Drawing.Point(8, 24)
        Me.btnConsolidado.Name = "btnConsolidado"
        Me.btnConsolidado.Size = New System.Drawing.Size(112, 24)
        Me.btnConsolidado.TabIndex = 11
        Me.btnConsolidado.Text = "Consolidado"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 15
        '
        'cmdCaldera
        '
        Me.cmdCaldera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCaldera.Location = New System.Drawing.Point(8, 48)
        Me.cmdCaldera.Name = "cmdCaldera"
        Me.cmdCaldera.Size = New System.Drawing.Size(112, 24)
        Me.cmdCaldera.TabIndex = 12
        Me.cmdCaldera.Text = "Consolidado + Liq"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtEnvio)
        Me.GroupBox4.Controls.Add(Me.cmdGenFirme)
        Me.GroupBox4.Controls.Add(Me.btnEmail)
        Me.GroupBox4.Controls.Add(Me.btnFirmasPlanilla)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 464)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(810, 48)
        Me.GroupBox4.TabIndex = 117
        Me.GroupBox4.TabStop = False
        '
        'txtEnvio
        '
        Me.txtEnvio.AutoSize = True
        Me.txtEnvio.Location = New System.Drawing.Point(417, 22)
        Me.txtEnvio.MinimumSize = New System.Drawing.Size(170, 0)
        Me.txtEnvio.Name = "txtEnvio"
        Me.txtEnvio.Size = New System.Drawing.Size(170, 13)
        Me.txtEnvio.TabIndex = 15
        Me.txtEnvio.Text = "Enviado correo al empleado:"
        '
        'dgPeriodoNomina
        '
        Me.dgPeriodoNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPeriodoNomina.EmbeddedNavigator.Name = ""
        Me.dgPeriodoNomina.Location = New System.Drawing.Point(8, 36)
        Me.dgPeriodoNomina.MainView = Me.vPlanillas
        Me.dgPeriodoNomina.Name = "dgPeriodoNomina"
        Me.dgPeriodoNomina.Size = New System.Drawing.Size(810, 422)
        Me.dgPeriodoNomina.TabIndex = 118
        Me.dgPeriodoNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vPlanillas})
        '
        'vPlanillas
        '
        Me.vPlanillas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vPlanillas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vPlanillas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.vPlanillas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.Empty.Options.UseBackColor = True
        Me.vPlanillas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.vPlanillas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.vPlanillas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.vPlanillas.Appearance.EvenRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.vPlanillas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vPlanillas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.vPlanillas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vPlanillas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vPlanillas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vPlanillas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.vPlanillas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vPlanillas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vPlanillas.Appearance.GroupRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupRow.Options.UseFont = True
        Me.vPlanillas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.vPlanillas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.vPlanillas.Appearance.HorzLine.Options.UseBackColor = True
        Me.vPlanillas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.OddRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.vPlanillas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.vPlanillas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.vPlanillas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.Preview.Options.UseBackColor = True
        Me.vPlanillas.Appearance.Preview.Options.UseFont = True
        Me.vPlanillas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.Row.Options.UseBackColor = True
        Me.vPlanillas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vPlanillas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vPlanillas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.vPlanillas.Appearance.VertLine.Options.UseBackColor = True
        Me.vPlanillas.GridControl = Me.dgPeriodoNomina
        Me.vPlanillas.Name = "vPlanillas"
        Me.vPlanillas.OptionsBehavior.Editable = False
        Me.vPlanillas.OptionsView.EnableAppearanceEvenRow = True
        Me.vPlanillas.OptionsView.EnableAppearanceOddRow = True
        Me.vPlanillas.OptionsView.ShowAutoFilterRow = True
        Me.vPlanillas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vPlanillas.OptionsView.ShowGroupPanel = False
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(12, 13)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 119
        Me.chkTodos.Text = "&Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'frmGenPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.dgPeriodoNomina)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbArchivos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGenPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.gbArchivos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables"
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[per_codigo] like '_" & Now.Year.ToString & "%'")
#End Region
    Private Sub frmGenPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cEmpleado = ""
        cDepartamento = ""
        cArea = ""
        cOrden = ""

        Me.Refrescar()

        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        Me.cmdVisor.Enabled = IIf(Registro <> "Vacio" And Me.cmdVisor.Enabled = True, True, False)
        Me.txtEnvio.Visible = False
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub vPlanillas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vPlanillas.FocusedRowChanged
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        Me.btnBAC.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
               Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
               Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
               Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
               Me.btnBAC.Enabled = True, True, False)

        'Me.btnXMLINSS.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
        '    Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
        '    Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
        '    Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
        '    Me.btnXMLINSS.Enabled = True, True, False)

        Me.cmdGenFirme.Enabled = IIf(Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
            Me.cmdGenFirme.Enabled = True, True, False)
    End Sub


    Private Sub cmdGenFirme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenFirme.Click
        Dim Periodo As New VB.SysContab.PeriodoNominaDetails()


        If Me.vPlanillas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        Else
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        End If

        Periodo = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If Periodo.Tipo = "A" Then
            MsgBox("Esta planilla es de Aguinaldo, no puede generarse desde esta opción", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Periodo.MovGen = False And Periodo.Tipo <> "V" And Periodo.Tipo <> "U" Then
            MsgBox("No se han generado los movimientos de esta planilla", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Periodo.Aprobado Then
            MsgBox("Esta planilla ya ha sido aprobada, no puede volver a generarse.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'Falta agregar la opcion de deshacer planilla para cuando el periodo de nomina ya ha sido revisado, que 
        'solamente lo haga el supervisor o el contador, usando el Rol mas alto para deshacerla.RMPR 13/04/2007

        If Periodo.Procesado = True And Periodo.Aprobado = False Then
            If MsgBox("Esta Nomina Ya fue procesada, Desea Desaplicarla?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Select Case Periodo.Tipo
                    Case "V"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Vacaciones(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        Exit Sub
                    Case "E"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Extra(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        Exit Sub
                    Case "U"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Corte(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        Exit Sub
                    Case Else
                        If VB.SysContab.PlanillaDB.Planilla_unDo(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        Exit Sub
                End Select
            Else
                Exit Sub
            End If
        End If
        Select Case Periodo.Tipo
            Case "V"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Vacaciones(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    Return
                End If
            Case "E"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Extra(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    Return
                End If
            Case "U"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Corte(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    Return
                End If
            Case Else
                If Not VB.SysContab.PlanillaDB.Planilla_Do(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    Return
                End If
        End Select

        VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, False)
        MsgBox("Planilla Generada Satisfactoriamente", MsgBoxStyle.OkOnly)

        Me.Refrescar()
    End Sub



    Private Sub cmdVisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisor.Click
        Dim f As frmVerPlanilla = frmVerPlanilla.Instance

        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        frmVerPlanilla.Contabilizado = Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado")
        frmVerPlanilla.Revisado = Me.vPlanillas.GetFocusedRowCellValue("per_revisado")
        frmVerPlanilla.Aprobado = Me.vPlanillas.GetFocusedRowCellValue("per_aprobado")
        f.Show()

    End Sub

    Private Sub cmdVerFichas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerFichas.Click

        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim g As frmImp_colillas = frmImp_colillas.Instance
        g.ShowDialog()
     
        If Me.Cancelar = True Then
            Exit Sub
        End If


        If bColilla = True Then

            Dim Variables As New ArrayList
            Dim Datos As New ArrayList
            Variables.Clear()
            Datos.Clear()
            Variables.Add("Empresa")
            Variables.Add("Periodo")
            Variables.Add("TPeriodo")
            Variables.Add("Empleado")
            Variables.Add("Departamento")
            Variables.Add("Area")
            Variables.Add("Orden")
            Datos.Add(EmpresaActual)
            Datos.Add(Periodo)
            Datos.Add(TPeriodo)
            Datos.Add(Me.cEmpleado)
            Datos.Add(Me.cDepartamento)
            Datos.Add(Me.cArea)
            Datos.Add(Me.cOrden)

            Dim DT As New DataTable("Encabezado")
            DT = VB.SysContab.FuncionesDB.ProcedureParameters(Datos, Variables, "_Colilla_Encabezado")
            DT.TableName = "Encabezado"
            DT.WriteXml(Application.StartupPath & "\exportfiles\Enc.xml")
            Dim rpt As New Colilla
            rpt.Periodo = Periodo
            rpt.TPeriodo = TPeriodo
            rpt.Departamento = Me.cDepartamento
            rpt.Area = Me.cArea
            rpt.NombreEmpresa.Text = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).Nombre
            rpt.PeriodoNomina.Text = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FInicio.ToShortDateString & "-" & VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal.ToShortDateString & "-" & VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).Descripcion
            rpt.DataSource = DT
            rpt.ShowPreview()
        Else
            Dim fReportes As New frmReportes()
            If MsgBox("Desea imprimir en media pagina las colillas?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.Yes Then
                'esta es la de media pagina con el reporte de la colonia
                'Dim rColilla As New rptColilla_MediaPagina
                Dim rColilla As New Object
                rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt")
                    Exit Sub
                End If

                rColilla.load(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                ImpresionColilla_MediaPagina(rColilla, Me.cEmpleado, 0, Me.cDepartamento, Me.cArea, Me.cOrden)
                fReportes.crvReportes.ReportSource = rColilla

                'Dim rColilla As New rptColilla_MP
                'ImpresionColilla_Xerox(rColilla, Me.cEmpleado, Me.cDepartamento, Me.cArea, Me.cOrden)
                'fReportes.crvReportes.ReportSource = rColilla

            Else
                'Dim rColilla As New rptColilla()
                Dim rColilla As New Object
                rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
                    Exit Sub
                End If

                rColilla.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                ImpresionColilla(rColilla, Me.cEmpleado, Me.cDepartamento, Me.cArea, Me.cOrden)
                fReportes.crvReportes.ReportSource = rColilla

            End If
            fReportes.ShowDialog()
        End If
    End Sub

    Private Sub ImpresionColilla_MediaPagina(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Localidad As Integer, ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataSet
        Dim IngrDS As DataSet
        Dim Periodo As String, TPeriodo As String

        'Documento = New rptColilla_MediaPagina
        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt")
            Exit Sub
        End If

        Documento.load(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)



        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado_Codigo, Localidad, Departamento, Area, Orden) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        IngrDS = VB.SysContab.PlanillaDB.ImprimirColilla_Detalle(Periodo, TPeriodo, Empleado_Codigo, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\Detalle.xml", XmlWriteMode.WriteSchema)
        IngrDS = Nothing

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Database.Tables("ColillaDetalle").Location = Application.StartupPath & "\Detalle.xml"

        Documento.subreports.item("Ingresos").database.tables(0).location = Application.StartupPath & "\Detalle.xml"
        Documento.subreports.item("Deducciones").database.tables(0).location = Application.StartupPath & "\Detalle.xml"

    End Sub

    Private Sub ImpresionColilla(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataSet
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim VacDS As DataSet

        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado, 0, Departamento, Area, Orden) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        'Dim VDS As New DataSet
        'Dim ff As Date
        'ff = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal
        'VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(ff, Empleado_Codigo))
        'VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)
        'ff = Nothing


        'CalDS = Planilla.ImprimirColilla_Asistencias(Periodo, TPeriodo, Empleado, Departamento, Area)
        'CalDS.WriteXml(Application.StartupPath & "\CalPla.xml", XmlWriteMode.WriteSchema)

        'LatDS = Planilla.ImprimirColilla_Latas(Periodo, TPeriodo, Empleado, Departamento, Area)
        'LatDS.WriteXml(Application.StartupPath & "\LatPla.xml", XmlWriteMode.WriteSchema)

        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, Empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, Empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)
        VacDS = VB.SysContab.PlanillaDB.ImprimirColillaEgrVD(Periodo, TPeriodo, Empleado, Departamento, Area)
        VacDS.WriteXml(Application.StartupPath & "\VacPla.xml", XmlWriteMode.WriteSchema)
        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()

        Documento.Subreports.Item("rptVDescansadas").Database.Tables(0).Location = Application.StartupPath & "\VacPla.xml" '.SetDataSource()
        'Documento.subreports.item("V").Database.Tables("Empleados").Location = Application.StartupPath & "\V.xml"
        'If Registro.Substring(0, 1) = "U" Then
        '    Documento.Subreports.Item("semana1").Database.Tables("Calendario").Location = Application.StartupPath & "\LatPla.xml" '.SetDataSource()
        '    Documento.Subreports.Item("semana2").Database.Tables(0).Location = Application.StartupPath & "\LatPla.xml" '.SetDataSource()
        'End If
        'If Registro.Substring(0, 1) = "D" Then
        '    Documento.Subreports.Item("Semana1").Database.Tables(0).Location = Application.StartupPath & "\calPla.xml" '.SetDataSource()
        '    Documento.Subreports.Item("Semana2").Database.Tables(0).Location = Application.StartupPath & "\calPla.xml" '.SetDataSource()

        'End If

    End Sub

    Private Sub ImpresionColilla_Xerox(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataSet
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        'Dim VacDS As DataSet
        Dim VDS As New DataSet
        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado, 0, Departamento, Area, Orden) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        Dim ff As Date
        ff = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal
        VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(ff, Empleado_Codigo))
        VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)
        ff = Nothing



        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, Empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, Empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()
        Documento.subreports.item("V").Database.Tables(0).Location = Application.StartupPath & "\V.xml"

    End Sub

    Private Sub ImpresionColilla(ByRef Documento As Object, ByVal empleado As String, _
            ByVal Periodo As String, ByVal TPeriodo As String, ByVal Departamento As String, _
            ByVal Area As String, _
            ByVal Orden As String)


        Dim lds As DataSet
        Dim EncDS As DataSet
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim VacDS As DataSet

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia


        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
            Exit Sub
        End If

        Documento.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing

        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, empleado, 0, Departamento, Area, Orden) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)
        'Dim VDS As New DataSet

        'VDS = Nothing
        'VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal, empleado))
        'VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)


        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)
        VacDS = VB.SysContab.PlanillaDB.ImprimirColillaEgrVD(Periodo, TPeriodo, empleado, Departamento, Area)
        VacDS.WriteXml(Application.StartupPath & "\VacPla.xml", XmlWriteMode.WriteSchema)

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("rptVDescansadas").Database.Tables(0).Location = Application.StartupPath & "\VacPla.xml" '.SetDataSource()
        'Documento.Subreports.Item("V").Database.Tables("Empleados").Location = Application.StartupPath & "\V.xml"

    End Sub

    Private Sub cmdIRSairi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRSairi.Click

        Dim ds As New DataSet()

        If Microsoft.VisualBasic.Left(Registro, 1) = "A" Then
            MsgBox("Esta planilla es de Aguinaldo, no lleva retención de IR", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ds = VB.SysContab.PlanillaDB.IRSairi(Microsoft.VisualBasic.Right(Registro, 8), Microsoft.VisualBasic.Left(Registro, 1))
        Me.SFD.InitialDirectory = Application.StartupPath()

        Me.SFD.Filter = "Text Files (*.txt)|*.txt"
        Me.SFD.FilterIndex = 1
        Me.SFD.RestoreDirectory = True
        Me.SFD.FileName = Application.StartupPath() & "\exportfiles\" & Microsoft.VisualBasic.Left(Registro, 1) & Microsoft.VisualBasic.Right(Registro, 8) & ".txt"
        If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If VB.SysContab.RutinasNomina.ExportarTXT(ds.Tables("Ir"), Me.SFD.FileName, Longitud_Linea_Archivos.SAIRI) Then
                    MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            Catch Ex As Exception
                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally

            End Try
        End If



    End Sub

    Private Sub btnBAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBAC.Click
        Dim f As frmGenPagoNominaElectronica = frmGenPagoNominaElectronica.Instance

        f.Periodo = Registro.Substring(1, 8)
        f.TPeriodo = Registro.Substring(0, 1)
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub Refrescar()
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList(True)
        Me.vPlanillas.Columns("per_codigo").Caption = "Periodo de Nomina" '0

        Me.vPlanillas.Columns("per_descripcion").Caption = "Descripción" '1
        Me.vPlanillas.Columns("per_descripcion").Width = 250

        Me.vPlanillas.Columns("per_procesado").Caption = "Procesada?"  '2
        Me.vPlanillas.Columns("per_revisado").Caption = "Revisada?"  '3
        Me.vPlanillas.Columns("per_aprobado").Caption = "Aprobada?" '4
        Me.vPlanillas.Columns("per_contabilizado").Caption = "Contabilizada?" '5
        Me.vPlanillas.Columns("per_finicio").Caption = "Desde"
        Me.vPlanillas.Columns("per_codigo").FilterInfo = Filtro
        Me.vPlanillas.Columns("per_ffinal").Caption = "Hasta"


        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        If Me.vPlanillas.DataRowCount > 0 Then
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo") 'dgPeriodoNomina.Item(0, 0)

            Me.btnBAC.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
                Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
                Me.btnBAC.Enabled = True, True, False)

            'Me.btnXMLINSS.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
            '    Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
            '    Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
            '    Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
            '    Me.btnXMLINSS.Enabled = True, True, False)
            Me.btnEmail.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
                Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
                Me.btnEmail.Enabled = True, True, False)
            Me.cmdGenFirme.Enabled = IIf(Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
                Me.cmdGenFirme.Enabled = True, True, False)

            'Me.btnBAC.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnBAC.Enabled = True, True, False)
            'Me.btnXMLINSS.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnXMLINSS.Enabled = True, True, False)
            'Me.btnEmail.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnEmail.Enabled = True, True, False)
            'Me.cmdGenFirme.Enabled = IIf(Not dgPeriodoNomina.Item(0, 5) And Me.cmdGenFirme.Enabled = True, True, False)
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        Dim Empleados As New VB.SysContab.EmpleadosDetails()
        Dim emp As New VB.SysContab.EmpleadosDB()
        Dim Empleado As String, Periodo As String, TPeriodo As String
        Dim ds As New DataSet()

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.txtEnvio.Visible = True
        ds = VB.SysContab.PlanillaDB.GetListPlanilla(Periodo, TPeriodo, "%")
        'Dim crExportOptions As CrystalDecisions.Shared.ExportOptions
        'Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim fname As String
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1

            'rColilla = New rptColilla
            Empleado = ds.Tables(0).Rows(i)("emp_codigo")
            Empleados = VB.SysContab.EmpleadosDB.GetDetails(Empleado)

            If Empleados.Email.Trim <> "" And Not (Empleados.Email Is DBNull.Value) Then
                'Me.ImpresionColilla(rColilla, Empleado, Periodo, TPeriodo)

                'fname = Application.StartupPath() & "\exportfiles\" & ds.Tables(0).Rows(i)("pla_tipo") & ds.Tables(0).Rows(i)("pla_codigo") & "_" & EmpresaActual.ToString.PadLeft(2, "0") & "_" & ds.Tables(0).Rows(i)("emp_codigo") & ".pdf"
                'crDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions()
                'crDiskFileDestinationOptions.DiskFileName = fname
                'crExportOptions = rColilla.ExportOptions
                'With crExportOptions
                '.DestinationOptions = crDiskFileDestinationOptions
                '.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                '.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                'End With
                'rColilla.Export()
                Me.txtEnvio.Text = "Enviando Correo al Empleado:" & Empleado
                'Me.Enviar_Mail(Empleados.Email, TPeriodo, Periodo)
                VB.SysContab.Email.Enviar_Mail_Outlook(Empleados.Email, "Planilla " & TPeriodo & Periodo, _
                "Sírvase revisar la colilla de pago. " & vbCrLf & _
                Direccion_WebSite)
                'rColilla = Nothing
            End If

        Next
        MsgBox("Colillas Enviadas", MsgBoxStyle.Information, "SysNomina")
        Me.txtEnvio.Visible = False
        ''''''''''''''''''''''''''''''''
    End Sub

    Private Sub btnFirmasPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirmasPlanilla.Click
        Dim fReportes As New frmReportes()
        'Dim reporte As New rptFirmasPlanillaXML_Digital
        Dim reporte As New Object
        reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt")
            Exit Sub
        End If

        reporte.load(Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim digital As Boolean

        Dim g As frmImp_colillas = frmImp_colillas.Instance

        g.ShowDialog()
        If Me.Cancelar = True Then
            Exit Sub
        End If


        digital = True

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        Dim lds, ds As DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)

        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
        ds = VB.SysContab.PlanillaDB.FirmasPlanilla(Registro.Substring(1, 8), Registro.Substring(0, 1), _
            True, Me.cEmpleado, Me.cLocalidad, Me.cDepartamento, Me.cArea, Me.cOrden, Me.ChkSalario)
        ds.WriteXml(Application.StartupPath & "\Firmas.xml", XmlWriteMode.WriteSchema)

        reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
        reporte.Database.Tables("_GetListFirmasPlanilla").Location = Application.StartupPath & "\Firmas.xml"

        fReportes.crvReportes.ReportSource = reporte
        fReportes.ShowDialog()

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
        lds = Nothing
    End Sub

    Private Sub btnXMLINSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXMLINSS.Click

        Me.FBD.SelectedPath = Application.StartupPath() & "\exportfiles\"
        If Me.FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                VB.SysContab.RutinasNomina.INSSXML(Registro.Substring(1, 6), Me.FBD.SelectedPath)
            Catch Ex As Exception
                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally
            End Try
        End If



    End Sub

    Private Sub btnConsolidado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolidado.Click
        'If MsgBox("Desea ver la pantalla del NUEVO CONSOLIDADO", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
        '    Dim f As frmRptPlanillaConsolidado_New = frmRptPlanillaConsolidado_New.Instance
        '    Nuevo = "SI"
        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'Else
        Dim f As frmRptPlanillaConsolidado = frmRptPlanillaConsolidado.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

        'End If

    End Sub


    Private Sub cmdCaldera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCaldera.Click
        'Dim ds As New DataSet()

        'Dim writer As XmlTextWriter = New XmlTextWriter(Application.StartupPath() & "\exportfiles\Caldera.xml", System.Text.Encoding.Unicode)
        'ds = VB.SysContab.PlanillaDB.GetListPlanilla_Caldera(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(Registro, 8), 6), "02", "0")

        'If File.Exists(Application.StartupPath() & "\exportfiles\caldera.xls") Then
        '    If MsgBox("Ya existe el archivo Caldera.xls, desea Sobreescribirlo? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If

        ''Add processing instructions to the beginning of the XML file, one 
        ''of which indicates a style sheet.
        'writer.WriteProcessingInstruction("xml", "version='1.0'")
        'writer.WriteProcessingInstruction( _
        '    "xml-stylesheet", "type='text/xsl' href='" & Application.StartupPath & "\exportfiles\caldera.xsl'")

        ''Write the XML from the dataset to the file.
        'ds.WriteXml(writer)
        'writer.Close()
        Dim f As frmRptPlanillaConsolidado_New = frmRptPlanillaConsolidado_New.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.vPlanillas.Columns("per_codigo").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.vPlanillas.Columns("per_codigo").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, " [per_codigo] like '_" & Now.Year.ToString & "%'")
        End If
        Me.vPlanillas.BestFitColumns()
    End Sub
    Private Sub vPlanillas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vPlanillas.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refrescar()
        End If
    End Sub
    'Private Sub Enviar_Mail(ByVal Direccion As String, ByVal TPeriodo As String, _
    '    ByVal Periodo As String, ByVal Path_Archivo As String)
    '    Dim correo As New System.Net.Mail.MailMessage("alberto.nunez@almori.com", Direccion)

    '    correo.Attachments.Clear()
    '    correo.Attachments.Add(New System.Net.Mail.Attachment(Path_Archivo))
    '    ' El asunto
    '    correo.Subject = "Planilla " & TPeriodo & Periodo
    '    ' El cuerpo o texto del mensaje
    '    correo.Body = "Sírvase revisar la colilla de pago.  " & _
    '            "<A href=http://simtesis.com/planilla/default.aspx?pla=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(Periodo, 10) & "&tipo=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(TPeriodo, 10) & " target=_blank > Siga este link para acusar recibo de la colilla. </A>"
    '    ' El formato del mensaje (texto o html)
    '    correo.IsBodyHtml = True
    '    ' La prioridad (baja, normal o alta)
    '    correo.Priority = System.Net.Mail.MailPriority.Normal
    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient
    '    ClienteCorreo.Host = IP_SMTP '"10.2.100.74"
    '    Try
    '        ClienteCorreo.Send(correo)
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message)
    '    End Try


    'End Sub

    'Private Sub Enviar_Mail(ByVal Direccion As String, ByVal TPeriodo As String, _
    '    ByVal Periodo As String)
    '    Dim correo As New System.Net.Mail.MailMessage("rosa.porras@almori.com", Direccion)

    '    ' El asunto
    '    correo.Subject = "Planilla " & TPeriodo & Periodo

    '    ' El cuerpo o texto del mensaje
    '    correo.Body = "Sírvase revisar la colilla de pago.  " & _
    '            "<A href=http://simtesis.com/planilla/default.aspx target=_blank > Siga este link para acusar recibo de la colilla. </A>" ' ?pla=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(Periodo, 10) & "&tipo=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(TPeriodo, 10) & " target=_blank > Siga este link para acusar recibo de la colilla. </A>"
    '    ' El formato del mensaje (texto o html)
    '    correo.IsBodyHtml = True
    '    ' La prioridad (baja, normal o alta)
    '    correo.Priority = System.Net.Mail.MailPriority.Normal
    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient
    '    ClienteCorreo.Host = IP_SMTP '"10.2.100.74"
    '    Try
    '        ClienteCorreo.Send(correo)
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message)
    '    End Try


    'End Sub
    'Private Function Enviar_Mail(ByVal Direccion As String, ByVal TPeriodo As String, _
    '   ByVal Periodo As String) As Boolean

    '    Dim correo As New System.Net.Mail.MailMessage("alberto.nunez@almori.com", Direccion)

    '    ' El asunto
    '    correo.Subject = "Planilla " & TPeriodo & Periodo
    '    ' El cuerpo o texto del mensaje
    '    correo.Body = "Sírvase revisar la colilla de pago.  " & _
    '            "<A href=http://simtesis.com/planilla/default.aspx target=_blank > Siga este link para acusar recibo de la colilla. </A>"
    '    ' El formato del mensaje (texto o html)
    '    correo.IsBodyHtml = True
    '    ' La prioridad (baja, normal o alta)
    '    correo.Priority = System.Net.Mail.MailPriority.Normal

    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient(IP_SMTP)
    '    ClienteCorreo.DeliveryMethod = Net.Mail.SmtpDeliveryMethod.PickupDirectoryFromIis

    '    Try
    '        ClienteCorreo.Send(correo)
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message)
    '        While Not (ex.InnerException Is Nothing)
    '            MsgBox("The following InnerException reported: " + ex.InnerException.ToString())
    '            ex = ex.InnerException
    '        End While
    '        Return False
    '        Exit Function
    '    End Try
    '    Return True
    'End Function

    'Private Sub Enviar_Mail_Outlook(ByVal Direccion As String, ByVal TPeriodo As String, _
    '   ByVal Periodo As String)

    '    Dim myOlApp, myItem As Object
    '    Dim j As Integer
    '    myOlApp = CreateObject("Outlook.Application")
    '    myItem = myOlApp.createitem(0)
    '    With myItem
    '        If Microsoft.VisualBasic.Left(Direccion, 2) = "MS" Then
    '            j = Microsoft.VisualBasic.InStr(Direccion, ":")
    '            .to = Microsoft.VisualBasic.Right(Direccion, Len(Direccion) - j)
    '        Else
    '            .to = Direccion
    '        End If
    '        .subject = "Planilla " & TPeriodo & Periodo
    '        .bodyformat = 0
    '        .body = "Sírvase revisar la colilla de pago.  " & _
    '                    "<A href=http://simtesis.com/planilla/default.aspx target=_blank > Siga este link para acusar recibo de la colilla. </A>" ' ?pla=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(Periodo, 10) & "&tipo=" & Edanmo.Security.Cryptography.StringEncryption.Encrypt(TPeriodo, 10) & " target=_blank > Siga este link para acusar recibo de la colilla. </A>"
    '        Try
    '            .send()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try

    '    End With
    '    myItem = Nothing

    'End Sub

    
End Class
