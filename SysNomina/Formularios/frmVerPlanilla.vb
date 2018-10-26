Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Net.Mail.SmtpClient
Imports System.Net.Mail.MailMessage
Imports System.Xml
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Localization

Public Class frmVerPlanilla
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmVerPlanilla = Nothing

    Public Shared Function Instance() As frmVerPlanilla
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVerPlanilla()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdFicha As System.Windows.Forms.Button
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents Planilla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.cmdFicha = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.Planilla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnEmail)
        Me.GroupBox1.Controls.Add(Me.cmdFicha)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 41)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(124, 11)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(112, 24)
        Me.btnEmail.TabIndex = 14
        Me.btnEmail.Text = "Enviar Colilla"
        '
        'cmdFicha
        '
        Me.cmdFicha.Location = New System.Drawing.Point(6, 10)
        Me.cmdFicha.Name = "cmdFicha"
        Me.cmdFicha.Size = New System.Drawing.Size(112, 24)
        Me.cmdFicha.TabIndex = 7
        Me.cmdFicha.Text = "Colilla de Pago"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(260, 11)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(11, 7)
        Me.Grid.MainView = Me.Planilla
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(423, 189)
        Me.Grid.TabIndex = 140
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Planilla})
        '
        'Planilla
        '
        Me.Planilla.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.Planilla.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Planilla.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Planilla.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Planilla.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.Planilla.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.Planilla.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.Planilla.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Planilla.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Planilla.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Planilla.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Planilla.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.Planilla.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Planilla.Appearance.Empty.Options.UseBackColor = True
        Me.Planilla.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.Planilla.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.Planilla.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Planilla.Appearance.EvenRow.Options.UseBackColor = True
        Me.Planilla.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Planilla.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Planilla.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.Planilla.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.Planilla.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Planilla.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Planilla.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Planilla.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Planilla.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.Planilla.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Planilla.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Planilla.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Planilla.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Planilla.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Planilla.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Planilla.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Planilla.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.Planilla.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.Planilla.Appearance.GroupButton.Options.UseBackColor = True
        Me.Planilla.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Planilla.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.Planilla.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.Planilla.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Planilla.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Planilla.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.Planilla.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.Planilla.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Planilla.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Planilla.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.Planilla.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Planilla.Appearance.GroupRow.Options.UseBackColor = True
        Me.Planilla.Appearance.GroupRow.Options.UseFont = True
        Me.Planilla.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.Planilla.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Planilla.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Planilla.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.Planilla.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Planilla.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.Planilla.Appearance.HorzLine.Options.UseBackColor = True
        Me.Planilla.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Planilla.Appearance.OddRow.Options.UseBackColor = True
        Me.Planilla.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.Planilla.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.Planilla.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.Planilla.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Planilla.Appearance.Preview.Options.UseBackColor = True
        Me.Planilla.Appearance.Preview.Options.UseFont = True
        Me.Planilla.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Planilla.Appearance.Row.Options.UseBackColor = True
        Me.Planilla.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Planilla.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Planilla.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.Planilla.Appearance.VertLine.Options.UseBackColor = True
        Me.Planilla.GridControl = Me.Grid
        Me.Planilla.Name = "Planilla"
        Me.Planilla.OptionsSelection.MultiSelect = True
        Me.Planilla.OptionsView.EnableAppearanceEvenRow = True
        Me.Planilla.OptionsView.EnableAppearanceOddRow = True
        Me.Planilla.OptionsView.ShowAutoFilterRow = True
        Me.Planilla.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Planilla.OptionsView.ShowFooter = True
        Me.Planilla.OptionsView.ShowGroupPanel = False
        '
        'frmVerPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 260)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVerPlanilla"
        Me.Text = "Visor de Planilla"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet
    Public Shared Revisado, Aprobado, Contabilizado, Iniciado As Boolean

    Private Sub frmVerPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Visor de Planilla del Periodo " & Registro & "-" & VB.SysContab.PeriodoNominaDB.GetDetails(Registro).Descripcion
        ds = New DataSet()
        ds = VB.SysContab.PlanillaDDB.GetPlanillaCompleta(Registro.Substring(1, 8), Registro.Substring(0, 1))

        ds.Tables("Planilla").PrimaryKey = New DataColumn() {ds.Tables("Planilla").Columns("llave")}
        Dim ParentCols() As DataColumn
        ParentCols = New DataColumn() {ds.Tables("Planilla").Columns("llave")}

        ds.Tables("PlanillaDetalle").PrimaryKey = New DataColumn() {ds.Tables("PlanillaDetalle").Columns("llave"), _
                                            ds.Tables("PlanillaDetalle").Columns("Codigo"), _
                                            ds.Tables("PlanillaDetalle").Columns("Cuota"), _
                                            ds.Tables("PlanillaDetalle").Columns("Tipo de Movimiento")}

        Dim ChildCols() As DataColumn

        ChildCols = New DataColumn() {ds.Tables("PlanillaDetalle").Columns("llave")}

        Dim Relacion As DataRelation = Nothing
        Try
            Relacion = New DataRelation("Detalle", ParentCols, ChildCols)
        Catch ex As DataException
            MsgBox(ex.Message)
        End Try
        ds.Relations.Add(Relacion)

        Me.Grid.DataSource = ds.Tables("Planilla")
        'formato
        For i As Integer = 0 To Me.Planilla.Columns.Count - 1
            Me.Planilla.Columns(i).Visible = False
        Next

        Me.Planilla.Columns("Empleado").Visible = True
        Me.Planilla.Columns("Empleado").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("Empleado").Width = 200
        Me.Planilla.Columns("Empleado").VisibleIndex = 1

        Me.Planilla.Columns("Salario Básico").Visible = True
        Me.Planilla.Columns("Salario Básico").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("Salario Básico").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("Salario Básico").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("Salario Básico").VisibleIndex = 2

        Me.Planilla.Columns("IR").Visible = True
        Me.Planilla.Columns("IR").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("IR").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("IR").VisibleIndex = 3

        Me.Planilla.Columns("INSS").Visible = True
        Me.Planilla.Columns("INSS").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("INSS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("INSS").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("INSS").VisibleIndex = 4

        Me.Planilla.Columns("INSSPatronal").Visible = True
        Me.Planilla.Columns("INSSPatronal").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("INSSPatronal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("INSSPatronal").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("INSSPatronal").VisibleIndex = 5

        Me.Planilla.Columns("Total Ingresos").Visible = True
        Me.Planilla.Columns("Total Ingresos").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("Total Ingresos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("Total Ingresos").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("Total Ingresos").VisibleIndex = 6

        Me.Planilla.Columns("Total Egresos").Visible = True
        Me.Planilla.Columns("Total Egresos").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("Total Egresos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("Total Egresos").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("Total Egresos").VisibleIndex = 7

        Me.Planilla.Columns("A Recibir").Visible = True
        Me.Planilla.Columns("A Recibir").OptionsColumn.ReadOnly = True
        Me.Planilla.Columns("A Recibir").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Planilla.Columns("A Recibir").DisplayFormat.FormatString = "n2"
        Me.Planilla.Columns("A Recibir").VisibleIndex = 8

        Me.Planilla.Columns("Comentarios").Visible = True
        Me.Planilla.Columns("Comentarios").OptionsColumn.ReadOnly = False
        Me.Planilla.Columns("Comentarios").VisibleIndex = 9

        'La segunda vista
        'Me.Planilla.SetMasterRowExpanded(Me.Planilla.FocusedRowHandle, True)
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, "frmGenPlanilla")
        Me.btnEmail.Enabled = frmVerPlanilla.Aprobado

        Iniciado = True
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFicha.Click
        Dim fReportes As New frmReportes()
        'Dim rColilla As New rptColilla()
        Dim rColilla As Object
        rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
            Exit Sub
        End If
        rColilla.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        If Me.Planilla.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If

        ImpresionColilla(rColilla, Me.Planilla.GetFocusedRowCellValue("emp_codigo"), _
            Registro.Substring(1, 8), Registro.Substring(0, 1), "%", "%", "A")
        fReportes.crvReportes.ReportSource = rColilla
        fReportes.ShowDialog()

    End Sub


    'Private Sub btcActualizarMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcActualizarMensaje.Click

    '    If Me.Planilla.DataRowCount = 0 Then
    '        MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
    '        Exit Sub
    '    End If


    '    VB.SysContab.PlanillaDB.UpdateComentarios(Registro.Substring(1, 8), Registro.Substring(0, 1), _
    '    Me.Planilla.GetFocusedRowCellValue("emp_codigo"), Me.txtComentarios.Text)

    '    Me.Planilla.SetFocusedRowCellValue(Me.Planilla.Columns("Comentarios"), Me.txtComentarios.Text)
    'End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click

        If Me.Planilla.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If
        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim Empleados As New VB.SysContab.EmpleadosDetails()
        Dim emp As New VB.SysContab.EmpleadosDB()

        Empleados = VB.SysContab.EmpleadosDB.GetDetails(Me.Planilla.GetFocusedRowCellValue("emp_codigo"))

        If Empleados.Email <> "" And Not (Empleados.Email Is DBNull.Value) Then

            If VB.SysContab.Email.Enviar_Mail_Outlook(Empleados.Email, "Planilla " & _
                Registro.Substring(0, 1) & Registro.Substring(1, 8), _
                "Sírvase revisar la colilla de pago. " & vbCrLf & _
                Direccion_WebSite) Then
                MsgBox("Email enviado correctamente", MsgBoxStyle.Information, "SysNomina")
            Else
                MsgBox("Email no pudo ser enviado", MsgBoxStyle.Critical, "SysNomina")
            End If

        End If
    End Sub

    'Private Function Enviar_Mail(ByVal Direccion As String, ByVal TPeriodo As String, _
    '   ByVal Periodo As String, ByVal Path_Archivo As String) As Boolean

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

    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient()
    '    ClienteCorreo.Host = IP_SMTP '"10.2.100.74"
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

    '    Dim ClienteCorreo As New System.Net.Mail.SmtpClient()
    '    ClienteCorreo.Host = IP_SMTP '"10.2.100.74"
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

    'Dim myMailClient As New System.Net.Mail.SmtpClient(AppSettings("SMTPHost"))
    'myMailClient.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis
    'myMailClient.Send(strFromEmail, strTo, strSubject, strBody)

    'Private Function Enviar_Mail(ByVal Direccion As String, ByVal TPeriodo As String, _
    '   ByVal Periodo As String, ByVal r As Boolean) As Boolean

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
    'Private Function Enviar_Mail_Outlook(ByVal Direccion As String, ByVal TPeriodo As String, _
    '   ByVal Periodo As String) As Boolean


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
    '        '.bodyformat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML '2
    '        .body = "Sírvase revisar la colilla de pago.<A href=http://simtesis.com/planilla/default.aspx target=_blank>Siga este link para acusar recibo de la colilla.</A>"
    '        Try
    '            .send()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try

    '    End With
    '    myItem = Nothing
    '    Return True
    'End Function


    Private Sub ImpresionColilla(ByRef Documento As Object, ByVal empleado As String, _
        ByVal Periodo As String, ByVal TPeriodo As String, _
        ByVal Departamento As String, ByVal Area As String, ByVal Orden As String)

        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
            Exit Sub
        End If
        Documento.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim VacDS As DataSet

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\logoempresa_ref.xml", XmlWriteMode.WriteSchema)

        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, empleado, 0, Departamento, Area, Orden, 0, 0) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)
        'Dim vds As New DataSet
        'Dim ff As Date
        'ff = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal
        'vds.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(ff, empleado))
        'vds.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)
        'ff = Nothing

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

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
        lds = Nothing

    End Sub

    Private Sub Planilla_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Planilla.CellValueChanged
        If Iniciado Then
            If sender.name = "Planilla" Then
                If e.Column.FieldName = "Comentarios" Then
                    'sender.setfocusedrowcellvalue(sender.columns("Comentarios"), )
                    VB.SysContab.PlanillaDB.UpdateComentarios(Registro.Substring(1, 8), Registro.Substring(0, 1), _
                            Me.Planilla.GetFocusedRowCellValue("emp_codigo"), e.Value)
                Else
                    Exit Sub
                End If
            End If
            
        End If
    End Sub

    Private Sub Vista_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles Planilla.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer
        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat

    End Sub




    Private Sub Planilla_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles Planilla.MasterRowExpanded

        If Me.Grid.Views.Count > 1 Then
            'Ver el detalle
            For i As Integer = 1 To Me.Grid.Views.Count - 1
                If Me.Grid.Views(i).DetailLevel = 1 Then
                    Dim xcosa As New DevExpress.XtraGrid.Views.Grid.GridView
                    xcosa = Me.Grid.Views(i)
                    xcosa.OptionsBehavior.Editable = False
                    xcosa.Columns(0).Width = 200
                    xcosa.Columns(1).Width = 50
                    xcosa.Columns(2).Width = 50
                    xcosa.Columns(3).Width = 100
                    xcosa.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(4).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(4).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(5).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(5).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(5).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.Columns(6).Visible = False
                    xcosa.OptionsView.ShowAutoFilterRow = True
                    xcosa.OptionsView.ShowFooter = True
                    'Apariencia
                    xcosa.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.Options.UseBackColor = True
                    xcosa.Appearance.ColumnFilterButton.Options.UseBorderColor = True
                    xcosa.Appearance.ColumnFilterButton.Options.UseForeColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
                    xcosa.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.Empty.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.Empty.Options.UseBackColor = True
                    xcosa.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
                    xcosa.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.EvenRow.Options.UseBackColor = True
                    xcosa.Appearance.EvenRow.Options.UseForeColor = True
                    xcosa.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.Options.UseBackColor = True
                    xcosa.Appearance.FilterCloseButton.Options.UseBorderColor = True
                    xcosa.Appearance.FilterCloseButton.Options.UseForeColor = True
                    xcosa.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterPanel.Options.UseBackColor = True
                    xcosa.Appearance.FilterPanel.Options.UseForeColor = True
                    xcosa.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.FixedLine.Options.UseBackColor = True
                    xcosa.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
                    xcosa.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.FocusedCell.Options.UseBackColor = True
                    xcosa.Appearance.FocusedCell.Options.UseForeColor = True
                    xcosa.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
                    xcosa.Appearance.FocusedRow.Options.UseBackColor = True
                    xcosa.Appearance.FocusedRow.Options.UseForeColor = True
                    xcosa.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black 'FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FooterPanel.Options.UseBackColor = True
                    xcosa.Appearance.FooterPanel.Options.UseBorderColor = True
                    xcosa.Appearance.FooterPanel.Options.UseForeColor = True
                    xcosa.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupButton.Options.UseBackColor = True
                    xcosa.Appearance.GroupButton.Options.UseBorderColor = True
                    xcosa.Appearance.GroupButton.Options.UseForeColor = True
                    xcosa.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupFooter.Options.UseBackColor = True
                    xcosa.Appearance.GroupFooter.Options.UseBorderColor = True
                    xcosa.Appearance.GroupFooter.Options.UseForeColor = True
                    xcosa.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.GroupPanel.Options.UseBackColor = True
                    xcosa.Appearance.GroupPanel.Options.UseForeColor = True
                    xcosa.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupRow.Options.UseBackColor = True
                    xcosa.Appearance.GroupRow.Options.UseBorderColor = True
                    xcosa.Appearance.GroupRow.Options.UseForeColor = True
                    xcosa.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    xcosa.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.HeaderPanel.Options.UseBackColor = True
                    xcosa.Appearance.HeaderPanel.Options.UseBorderColor = True
                    xcosa.Appearance.HeaderPanel.Options.UseFont = True
                    xcosa.Appearance.HeaderPanel.Options.UseForeColor = True
                    xcosa.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
                    xcosa.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.HideSelectionRow.Options.UseBackColor = True
                    xcosa.Appearance.HideSelectionRow.Options.UseForeColor = True
                    xcosa.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.HorzLine.Options.UseBackColor = True
                    xcosa.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
                    xcosa.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.OddRow.Options.UseBackColor = True
                    xcosa.Appearance.OddRow.Options.UseForeColor = True
                    xcosa.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
                    xcosa.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
                    xcosa.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.Preview.Options.UseBackColor = True
                    xcosa.Appearance.Preview.Options.UseFont = True
                    xcosa.Appearance.Preview.Options.UseForeColor = True
                    xcosa.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
                    xcosa.Appearance.Row.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.Row.Options.UseBackColor = True
                    xcosa.Appearance.Row.Options.UseForeColor = True
                    xcosa.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.RowSeparator.Options.UseBackColor = True
                    xcosa.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
                    xcosa.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.SelectedRow.Options.UseBackColor = True
                    xcosa.Appearance.SelectedRow.Options.UseForeColor = True
                    xcosa.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
                    xcosa.Appearance.TopNewRow.Options.UseBackColor = True
                    xcosa.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.VertLine.Options.UseBackColor = True
                End If

            Next
        End If

    End Sub
End Class
