Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmFeriados
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmFeriados = Nothing

    Public Shared Function Instance() As frmFeriados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFeriados()
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
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents dgFeriados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VFeriados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgFeriados = New DevExpress.XtraGrid.GridControl
        Me.VFeriados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(296, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(200, 16)
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
        'dgFeriados
        '
        Me.dgFeriados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFeriados.Location = New System.Drawing.Point(8, 12)
        Me.dgFeriados.MainView = Me.VFeriados
        Me.dgFeriados.Name = "dgFeriados"
        Me.dgFeriados.Size = New System.Drawing.Size(400, 200)
        Me.dgFeriados.TabIndex = 12
        Me.dgFeriados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VFeriados})
        '
        'VFeriados
        '
        Me.VFeriados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VFeriados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VFeriados.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFeriados.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VFeriados.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.Empty.Options.UseBackColor = True
        Me.VFeriados.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VFeriados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VFeriados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VFeriados.Appearance.EvenRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VFeriados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VFeriados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VFeriados.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFeriados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VFeriados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VFeriados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VFeriados.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupButton.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VFeriados.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFeriados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VFeriados.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VFeriados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VFeriados.Appearance.GroupRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.GroupRow.Options.UseFont = True
        Me.VFeriados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFeriados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VFeriados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VFeriados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VFeriados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VFeriados.Appearance.HorzLine.Options.UseBackColor = True
        Me.VFeriados.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.OddRow.Options.UseBackColor = True
        Me.VFeriados.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VFeriados.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VFeriados.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VFeriados.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFeriados.Appearance.Preview.Options.UseBackColor = True
        Me.VFeriados.Appearance.Preview.Options.UseFont = True
        Me.VFeriados.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VFeriados.Appearance.Row.Options.UseBackColor = True
        Me.VFeriados.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFeriados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VFeriados.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VFeriados.Appearance.VertLine.Options.UseBackColor = True
        Me.VFeriados.GridControl = Me.dgFeriados
        Me.VFeriados.Name = "VFeriados"
        Me.VFeriados.OptionsBehavior.Editable = False
        Me.VFeriados.OptionsView.EnableAppearanceEvenRow = True
        Me.VFeriados.OptionsView.EnableAppearanceOddRow = True
        Me.VFeriados.OptionsView.ShowAutoFilterRow = True
        Me.VFeriados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VFeriados.OptionsView.ShowFooter = True
        Me.VFeriados.OptionsView.ShowGroupPanel = False
        '
        'frmFeriados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 276)
        Me.Controls.Add(Me.dgFeriados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFeriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")
        Me.VFeriados.PopulateColumns()
        Me.VFeriados.Columns(0).Width = 50
        Me.VFeriados.Columns(1).Width = 50
        Me.VFeriados.Columns(2).Width = 250

        Me.VFeriados.Columns("_Dia").Caption = "Dia"
        Me.VFeriados.Columns("_Mes").Caption = "Mes"
        Me.VFeriados.Columns("_Descripcion").Caption = "Descripción"


        If Me.VFeriados.DataRowCount <> 0 Then
            Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "Mantenimiento de Feriados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarFeriados = frmAgregarFeriados.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")


    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VFeriados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarFeriados = frmAgregarFeriados.Instance
        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Registro que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VFeriados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim Feriados As New VB.SysContab.FeriadosDB()

        If MsgBox("Esta seguro que dese borrar el Feriado: " & _
            Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes"), _
            MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        VB.SysContab.FeriadosDB.delete(Me.VFeriados.GetFocusedRowCellValue("_Mes"), _
            Me.VFeriados.GetFocusedRowCellValue("_Dia"))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetList().Tables("Feriados")
        If Me.VFeriados.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
        End If

    End Sub

    Private Sub VFeriados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VFeriados.FocusedRowChanged
        Registro = Me.VFeriados.GetFocusedRowCellValue("_Dia") & Me.VFeriados.GetFocusedRowCellValue("_Mes")
    End Sub
End Class
