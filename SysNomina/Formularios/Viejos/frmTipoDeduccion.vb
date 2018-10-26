Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmTipoDeduccion
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmTipoDeduccion = Nothing

    Public Shared Function Instance() As frmTipoDeduccion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTipoDeduccion()
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
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents dgTDeduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents VTipo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgTDeduccion = New DevExpress.XtraGrid.GridControl
        Me.VTipo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(392, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(104, 16)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'dgTDeduccion
        '
        Me.dgTDeduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTDeduccion.EmbeddedNavigator.Name = ""
        Me.dgTDeduccion.Location = New System.Drawing.Point(8, 12)
        Me.dgTDeduccion.MainView = Me.VTipo
        Me.dgTDeduccion.Name = "dgTDeduccion"
        Me.dgTDeduccion.Size = New System.Drawing.Size(480, 200)
        Me.dgTDeduccion.TabIndex = 12
        Me.dgTDeduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VTipo})
        '
        'VTipo
        '
        Me.VTipo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VTipo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VTipo.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VTipo.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VTipo.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.Empty.Options.UseBackColor = True
        Me.VTipo.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VTipo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VTipo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VTipo.Appearance.EvenRow.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VTipo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VTipo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VTipo.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VTipo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VTipo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VTipo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VTipo.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VTipo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupButton.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VTipo.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VTipo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VTipo.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VTipo.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VTipo.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VTipo.Appearance.GroupRow.Options.UseBackColor = True
        Me.VTipo.Appearance.GroupRow.Options.UseFont = True
        Me.VTipo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VTipo.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VTipo.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VTipo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VTipo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VTipo.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VTipo.Appearance.HorzLine.Options.UseBackColor = True
        Me.VTipo.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VTipo.Appearance.OddRow.Options.UseBackColor = True
        Me.VTipo.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VTipo.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VTipo.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VTipo.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VTipo.Appearance.Preview.Options.UseBackColor = True
        Me.VTipo.Appearance.Preview.Options.UseFont = True
        Me.VTipo.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VTipo.Appearance.Row.Options.UseBackColor = True
        Me.VTipo.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VTipo.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VTipo.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VTipo.Appearance.VertLine.Options.UseBackColor = True
        Me.VTipo.GridControl = Me.dgTDeduccion
        Me.VTipo.Name = "VTipo"
        Me.VTipo.OptionsBehavior.Editable = False
        Me.VTipo.OptionsView.EnableAppearanceEvenRow = True
        Me.VTipo.OptionsView.EnableAppearanceOddRow = True
        Me.VTipo.OptionsView.ShowAutoFilterRow = True
        Me.VTipo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VTipo.OptionsView.ShowFooter = True
        Me.VTipo.OptionsView.ShowGroupPanel = False
        '
        'frmTipoDeduccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 284)
        Me.Controls.Add(Me.dgTDeduccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTipoDeduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTipoDeduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargar()
        Me.Text = "Mantenimiento de Tipo de Deducciones"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Public Sub cargar()
        dgTDeduccion.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.VTipo.Columns("Tipo").Visible = False
        If Me.VTipo.DataRowCount <> 0 Then
            Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarTDeduccion = frmAgregarTDeduccion.Instance
        Dim TDeduccion As New VB.SysContab.TipoDeduccionDB()
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VTipo.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")

        Dim f As frmAgregarTDeduccion = frmAgregarTDeduccion.Instance
        Nuevo = "NO"
        If Not VB.SysContab.TipoDeduccionDB.GetDetails(Registro).Editable Then
            MsgBox("Este Tipo de Deduccion No es Editable. " & vbCrLf & _
                   "Es parte de la configuarción del Sistema." & vbCrLf & _
                   "Solamente podra editar los prefijos/sufijos contables", MsgBoxStyle.Information)
            'f.cmdAceptar.Enabled = False
        Else
            'f.cmdAceptar.Enabled = True
        End If

        f.MdiParent = Me.MdiParent
        f.Show()



    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VTipo.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
        If Not VB.SysContab.TipoDeduccionDB.GetDetails(Registro).Borrable Then
            MsgBox("Este Tipo de Deduccion No es Borrable. Es parte de la configuarción del Sistema", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Esta Seguro de borrar este registro?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            VB.SysContab.TipoDeduccionDB.delete(Registro)
        End If
        Me.cargar()
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub


    Private Sub VTipo_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VTipo.FocusedRowChanged
        Registro = Me.VTipo.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
