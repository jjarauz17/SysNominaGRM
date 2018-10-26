Public Class frmEditarHExtras
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmEditarHExtras = Nothing
    Private HEnt As String, HSal As String, LCodigo As String
    Friend WithEvents dgDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDetalle As DevExpress.XtraGrid.Views.Grid.GridView

    Public Shared Function Instance() As frmEditarHExtras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEditarHExtras()
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
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.dgDetalle = New DevExpress.XtraGrid.GridControl
        Me.VDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
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
        Me.txtCodigo.Location = New System.Drawing.Point(104, 40)
        Me.txtCodigo.MaxLength = 14
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(96, 20)
        Me.txtCodigo.TabIndex = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(27, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 40)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(96, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(104, 64)
        Me.txtNombre.MaxLength = 14
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(432, 20)
        Me.txtNombre.TabIndex = 125
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.EmbeddedNavigator.Name = ""
        Me.dgDetalle.Location = New System.Drawing.Point(27, 90)
        Me.dgDetalle.MainView = Me.VDetalle
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(589, 200)
        Me.dgDetalle.TabIndex = 127
        Me.dgDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDetalle})
        '
        'VDetalle
        '
        Me.VDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VDetalle.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDetalle.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VDetalle.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.VDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VDetalle.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VDetalle.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.VDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VDetalle.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDetalle.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VDetalle.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.VDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.VDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.VDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.VDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.VDetalle.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VDetalle.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VDetalle.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VDetalle.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDetalle.Appearance.Preview.Options.UseBackColor = True
        Me.VDetalle.Appearance.Preview.Options.UseFont = True
        Me.VDetalle.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VDetalle.Appearance.Row.Options.UseBackColor = True
        Me.VDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.VDetalle.GridControl = Me.dgDetalle
        Me.VDetalle.Name = "VDetalle"
        Me.VDetalle.OptionsBehavior.Editable = False
        Me.VDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.VDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.VDetalle.OptionsView.ShowAutoFilterRow = True
        Me.VDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDetalle.OptionsView.ShowFooter = True
        Me.VDetalle.OptionsView.ShowGroupPanel = False
        '
        'frmEditarHExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 342)
        Me.Controls.Add(Me.dgDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmEditarHExtras"
        Me.Text = "Detalle de Marcadas de Empleado"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmEditarHExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CEmpleado As New VB.SysContab.EmpleadosDetails()
        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()

        CEmpleado = VB.SysContab.EmpleadosDB.GetDetails(Registro)
        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)

        Me.txtCodigo.Text = CEmpleado.Codigo
        Me.txtNombre.Text = CEmpleado.PNombre & " " & CEmpleado.SNombre & " " & CEmpleado.PApellido & " " & CEmpleado.SApellido


        Me.dgDetalle.DataSource = VB.SysContab.MarcaRelojDB.GetListMarcadas(CEmpleado.Codigo, CEmpleado.Departamento, PNominaDetails.FInicio, PNominaDetails.FFinal).Tables("Marcadas")

        'If Me.VDetalle.DataRowCount <> 0 Then
        '    Registro = Me.VDetalle.GetFocusedRowCellValue("Fecha")
        'Else
        '    Registro = "Vacio"
        'End If

        Me.Text = "Marcadas de Reloj de Empleado"
        Me.Refresh()

    End Sub




    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

    End Sub
End Class
