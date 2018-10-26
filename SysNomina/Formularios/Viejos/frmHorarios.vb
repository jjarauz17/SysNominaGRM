Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmHorarios
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmHorarios_ = Nothing

    Public Shared Function Instance() As frmHorarios_
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmHorarios_()
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
    Friend WithEvents dgHorarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents VHorarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgHorarios = New DevExpress.XtraGrid.GridControl
        Me.VHorarios = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 283)
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
        'dgHorarios
        '
        Me.dgHorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgHorarios.Location = New System.Drawing.Point(12, 12)
        Me.dgHorarios.MainView = Me.VHorarios
        Me.dgHorarios.Name = "dgHorarios"
        Me.dgHorarios.Size = New System.Drawing.Size(480, 265)
        Me.dgHorarios.TabIndex = 12
        Me.dgHorarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VHorarios})
        '
        'VHorarios
        '
        Me.VHorarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VHorarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VHorarios.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorarios.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VHorarios.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.Empty.Options.UseBackColor = True
        Me.VHorarios.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VHorarios.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VHorarios.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VHorarios.Appearance.EvenRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorarios.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VHorarios.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VHorarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorarios.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VHorarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VHorarios.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VHorarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupButton.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VHorarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VHorarios.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VHorarios.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VHorarios.Appearance.GroupRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.GroupRow.Options.UseFont = True
        Me.VHorarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorarios.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VHorarios.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VHorarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VHorarios.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VHorarios.Appearance.HorzLine.Options.UseBackColor = True
        Me.VHorarios.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.OddRow.Options.UseBackColor = True
        Me.VHorarios.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VHorarios.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VHorarios.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VHorarios.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorarios.Appearance.Preview.Options.UseBackColor = True
        Me.VHorarios.Appearance.Preview.Options.UseFont = True
        Me.VHorarios.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VHorarios.Appearance.Row.Options.UseBackColor = True
        Me.VHorarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorarios.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VHorarios.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VHorarios.Appearance.VertLine.Options.UseBackColor = True
        Me.VHorarios.GridControl = Me.dgHorarios
        Me.VHorarios.Name = "VHorarios"
        Me.VHorarios.OptionsBehavior.Editable = False
        Me.VHorarios.OptionsView.EnableAppearanceEvenRow = True
        Me.VHorarios.OptionsView.EnableAppearanceOddRow = True
        Me.VHorarios.OptionsView.ShowAutoFilterRow = True
        Me.VHorarios.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VHorarios.OptionsView.ShowFooter = True
        Me.VHorarios.OptionsView.ShowGroupPanel = False
        '
        'frmHorarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 329)
        Me.Controls.Add(Me.dgHorarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        If Me.VHorarios.DataRowCount <> 0 Then
            Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Mantenimiento de Horarios"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub
    Private Sub Cargar()
        dgHorarios.DataSource = VB.SysContab.HorarioDB.GetList().Tables("Horario")
        Me.VHorarios.Columns("Entrada").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VHorarios.Columns("Entrada").DisplayFormat.FormatString = "hh:mm tt"
        Me.VHorarios.Columns("Salida").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VHorarios.Columns("Salida").DisplayFormat.FormatString = "hh:mm tt"

        If Me.VHorarios.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarHorario = frmAgregarHorario.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VHorarios.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarHorario = frmAgregarHorario.Instance
        Nuevo = "NO"
        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        f.MdiParent = Me.MdiParent
        f.cmdAceptar.Enabled = IIf(Registro = "000", False, True)
        f.Show()


    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VHorarios.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        If Registro = "000" Then
            MsgBox("Este registro no se debe borrar", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Esta seguro que dese borrar el Horario: " & Me.VHorarios.GetFocusedRowCellValue("Descripcion"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        VB.SysContab.HorarioDB.Delete(Registro)
        Cargar()

    End Sub



    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    End Sub

    Private Sub VHorarios_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VHorarios.FocusedRowChanged
        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
