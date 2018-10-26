Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmMonedas
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmMonedas = Nothing

    Public Shared Function Instance() As frmMonedas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMonedas()
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
    Friend WithEvents dgMonedas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VMonedas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgMonedas = New DevExpress.XtraGrid.GridControl
        Me.VMonedas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 208)
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
        'dgMonedas
        '
        Me.dgMonedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMonedas.Location = New System.Drawing.Point(9, 12)
        Me.dgMonedas.MainView = Me.VMonedas
        Me.dgMonedas.Name = "dgMonedas"
        Me.dgMonedas.Size = New System.Drawing.Size(480, 190)
        Me.dgMonedas.TabIndex = 12
        Me.dgMonedas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VMonedas})
        '
        'VMonedas
        '
        Me.VMonedas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VMonedas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VMonedas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VMonedas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VMonedas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.Empty.Options.UseBackColor = True
        Me.VMonedas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VMonedas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VMonedas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VMonedas.Appearance.EvenRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VMonedas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VMonedas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VMonedas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VMonedas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VMonedas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMonedas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VMonedas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupButton.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VMonedas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VMonedas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VMonedas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VMonedas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VMonedas.Appearance.GroupRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.GroupRow.Options.UseFont = True
        Me.VMonedas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VMonedas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VMonedas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VMonedas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VMonedas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VMonedas.Appearance.HorzLine.Options.UseBackColor = True
        Me.VMonedas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.OddRow.Options.UseBackColor = True
        Me.VMonedas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VMonedas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VMonedas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VMonedas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VMonedas.Appearance.Preview.Options.UseBackColor = True
        Me.VMonedas.Appearance.Preview.Options.UseFont = True
        Me.VMonedas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VMonedas.Appearance.Row.Options.UseBackColor = True
        Me.VMonedas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VMonedas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VMonedas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VMonedas.Appearance.VertLine.Options.UseBackColor = True
        Me.VMonedas.GridControl = Me.dgMonedas
        Me.VMonedas.Name = "VMonedas"
        Me.VMonedas.OptionsBehavior.Editable = False
        Me.VMonedas.OptionsView.EnableAppearanceEvenRow = True
        Me.VMonedas.OptionsView.EnableAppearanceOddRow = True
        Me.VMonedas.OptionsView.ShowAutoFilterRow = True
        Me.VMonedas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VMonedas.OptionsView.ShowFooter = True
        Me.VMonedas.OptionsView.ShowGroupPanel = False
        '
        'frmMonedas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 268)
        Me.Controls.Add(Me.dgMonedas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMonedas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
        Me.Text = "Mantenimiento de Monedas"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub
    Private Sub cargar()
        dgMonedas.DataSource = VB.SysContab.MonedaDB.GetList().Tables("Monedas")
        Me.VMonedas.Columns("Codigo").Width = 80
        Me.VMonedas.Columns("Descripcion").Width = 300
        Me.VMonedas.Columns("Simbolo").Width = 80

        If Me.VMonedas.DataRowCount <> 0 Then
            Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VMonedas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Nuevo = "NO"
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VMonedas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        Dim Monedas As New VB.SysContab.MonedaDB()

        If MsgBox("Esta seguro que dese borrar la Moneda: " & Me.VMonedas.GetFocusedRowCellValue("Descripcion"), _
            MsgBoxStyle.YesNo + MsgBoxStyle.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        VB.SysContab.MonedaDB.delete(Me.VMonedas.GetFocusedRowCellValue("Codigo"))

        cargar()
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub

    Private Sub VMonedas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VMonedas.FocusedRowChanged
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
