Public Class frmDarFeriados
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmDarFeriados = Nothing
    Public Shared Function Instance() As frmDarFeriados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDarFeriados()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    
    Friend WithEvents dgFeriados As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vferiados As DevExpress.XtraGrid.Views.Grid.GridView
    Public Shared Todos As Boolean

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.dgFeriados = New DevExpress.XtraGrid.GridControl
        Me.Vferiados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vferiados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 49)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(94, 16)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        '
        'dgFeriados
        '
        Me.dgFeriados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFeriados.EmbeddedNavigator.Name = ""
        Me.dgFeriados.Location = New System.Drawing.Point(12, 12)
        Me.dgFeriados.MainView = Me.Vferiados
        Me.dgFeriados.Name = "dgFeriados"
        Me.dgFeriados.Size = New System.Drawing.Size(400, 200)
        Me.dgFeriados.TabIndex = 123
        Me.dgFeriados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vferiados})
        '
        'Vferiados
        '
        Me.Vferiados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.Vferiados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Vferiados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Vferiados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Vferiados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.Vferiados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.Vferiados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.Vferiados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Vferiados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Vferiados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Vferiados.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Vferiados.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.Vferiados.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vferiados.Appearance.Empty.Options.UseBackColor = True
        Me.Vferiados.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.Vferiados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.Vferiados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Vferiados.Appearance.EvenRow.Options.UseBackColor = True
        Me.Vferiados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Vferiados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Vferiados.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.Vferiados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Vferiados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vferiados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Vferiados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Vferiados.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.Vferiados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Vferiados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Vferiados.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Vferiados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Vferiados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Vferiados.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Vferiados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Vferiados.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.Vferiados.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.Vferiados.Appearance.GroupButton.Options.UseBackColor = True
        Me.Vferiados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Vferiados.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.Vferiados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.Vferiados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Vferiados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Vferiados.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.Vferiados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.Vferiados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Vferiados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Vferiados.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.Vferiados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Vferiados.Appearance.GroupRow.Options.UseBackColor = True
        Me.Vferiados.Appearance.GroupRow.Options.UseFont = True
        Me.Vferiados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.Vferiados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Vferiados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Vferiados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.Vferiados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Vferiados.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.Vferiados.Appearance.HorzLine.Options.UseBackColor = True
        Me.Vferiados.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Vferiados.Appearance.OddRow.Options.UseBackColor = True
        Me.Vferiados.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.Vferiados.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.Vferiados.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.Vferiados.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vferiados.Appearance.Preview.Options.UseBackColor = True
        Me.Vferiados.Appearance.Preview.Options.UseFont = True
        Me.Vferiados.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Vferiados.Appearance.Row.Options.UseBackColor = True
        Me.Vferiados.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Vferiados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Vferiados.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.Vferiados.Appearance.VertLine.Options.UseBackColor = True
        Me.Vferiados.GridControl = Me.dgFeriados
        Me.Vferiados.Name = "Vferiados"
        Me.Vferiados.OptionsView.EnableAppearanceEvenRow = True
        Me.Vferiados.OptionsView.EnableAppearanceOddRow = True
        Me.Vferiados.OptionsView.ShowAutoFilterRow = True
        Me.Vferiados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vferiados.OptionsView.ShowFooter = True
        Me.Vferiados.OptionsView.ShowGroupPanel = False
        '
        'frmDarFeriados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 281)
        Me.Controls.Add(Me.dgFeriados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmDarFeriados"
        Me.Text = "Feriados"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vferiados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDarFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgFeriados.DataSource = VB.SysContab.FeriadosDB.GetListds(QuincenaTrabajo).Tables(0)
        Me.Vferiados.PopulateColumns()
        Me.Vferiados.Columns("Dia").OptionsColumn.ReadOnly = True
        Me.Vferiados.Columns("Mes").OptionsColumn.ReadOnly = True
        Me.Vferiados.Columns("Descripcion").OptionsColumn.ReadOnly = True
        Me.Vferiados.Columns("Fecha").OptionsColumn.ReadOnly = True

        If Registro = "Vacio" Then
            Me.Text = "Feriados Definidos para - No hay registros Seleccionados"
        Else
            Me.Text = "Feriados Definidos para - " & IIf(frmDarFeriados.Todos, "Todos", VB.SysContab.EmpleadosDB.GetDetails(Registro).Nombre)
        End If
        Me.Refresh()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Fecha As DateTime
        Dim i As Integer

        For i = 0 To Me.Vferiados.DataRowCount - 1
            If Me.Vferiados.GetFocusedRowCellValue("Seleccionado") Then
                Fecha = Me.Vferiados.GetFocusedRowCellValue("Fecha")
                If Registro <> "Vacio" Then 'No Hay empleados en el grid
                    If frmDarFeriados.Todos Then
                        'Borrar los permisos existentes permisos existentes
                        VB.SysContab.PermisosDB.Delete_Feriados(Fecha, _
                            QuincenaTrabajo.Substring(1, 8), _
                            QuincenaTrabajo.Substring(0, 1), _
                            frmDarFeriados.Todos, "")
                        VB.SysContab.PermisosDB.Add_Feriados(Fecha, _
                            QuincenaTrabajo.Substring(1, 8), _
                            QuincenaTrabajo.Substring(0, 1), _
                            frmDarFeriados.Todos, "")
                    Else
                        'Borrar los permisos existentes permisos existentes
                        VB.SysContab.PermisosDB.Delete_Feriados(Fecha, _
                            QuincenaTrabajo.Substring(1, 8), _
                            QuincenaTrabajo.Substring(0, 1), _
                            frmDarFeriados.Todos, Registro)
                        VB.SysContab.PermisosDB.Add_Feriados(Fecha, _
                            QuincenaTrabajo.Substring(1, 8), _
                            QuincenaTrabajo.Substring(0, 1), _
                            frmDarFeriados.Todos, Registro)
                    End If
                Else
                    MsgBox("No hay empleados a quien asignar los feriados", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Next

        MsgBox("Registros Generados Satisfactoriamente", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

End Class
