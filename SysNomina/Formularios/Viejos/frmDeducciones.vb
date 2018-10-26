Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmDeducciones
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmDeducciones = Nothing
    Friend WithEvents dgDeduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDeduccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdLote As System.Windows.Forms.Button
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Public Tipo As String

    Public Shared Function Instance() As frmDeducciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDeducciones()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Cancelado] = False")
#End Region
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
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdLote = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgDeduccion = New DevExpress.XtraGrid.GridControl
        Me.VDeduccion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdLote)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdLote
        '
        Me.cmdLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLote.Location = New System.Drawing.Point(572, 16)
        Me.cmdLote.Name = "cmdLote"
        Me.cmdLote.Size = New System.Drawing.Size(72, 24)
        Me.cmdLote.TabIndex = 7
        Me.cmdLote.Text = "Por Tipo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(400, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(304, 16)
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
        'dgDeduccion
        '
        Me.dgDeduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeduccion.Location = New System.Drawing.Point(8, 28)
        Me.dgDeduccion.MainView = Me.VDeduccion
        Me.dgDeduccion.Name = "dgDeduccion"
        Me.dgDeduccion.Size = New System.Drawing.Size(655, 161)
        Me.dgDeduccion.TabIndex = 12
        Me.dgDeduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDeduccion})
        '
        'VDeduccion
        '
        Me.VDeduccion.GridControl = Me.dgDeduccion
        Me.VDeduccion.Name = "VDeduccion"
        Me.VDeduccion.OptionsBehavior.Editable = False
        Me.VDeduccion.OptionsSelection.MultiSelect = True
        Me.VDeduccion.OptionsView.ShowAutoFilterRow = True
        Me.VDeduccion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDeduccion.OptionsView.ShowFooter = True
        Me.VDeduccion.OptionsView.ShowGroupPanel = False
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(12, 5)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 18
        Me.chkTodos.Text = "&Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'frmDeducciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(670, 255)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.dgDeduccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDeducciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmDeducciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
        Me.Text = "Mantenimiento de Deducciones de Empleados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name & Tipo)
        Me.Refresh()

    End Sub
    Sub cargar()
        dgDeduccion.DataSource = VB.SysContab.DeduccionDB.GetList().Tables("Deduccion").DefaultView
        Me.VDeduccion.Columns("Nomina Regular").Visible = False
        Me.VDeduccion.Columns("Fecha").Visible = False
        Me.VDeduccion.Columns("emp_formapago").Visible = False
        Me.VDeduccion.Columns("Codigo").Width = 50
        Me.VDeduccion.Columns("Empleado").Width = 250
        Me.VDeduccion.Columns("Cancelado").FilterInfo = Filtro
        Me.VDeduccion.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VDeduccion.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VDeduccion.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VDeduccion.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VDeduccion.Columns("Valor Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VDeduccion.Columns("Valor Cuota").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VDeduccion.Columns("Codigo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.VDeduccion.Columns("Codigo").SummaryItem.DisplayFormat = "{0:n0}"
        Me.VDeduccion.Columns("Codigo").SummaryItem.Tag = "Cuenta"

        Me.VDeduccion.BestFitColumns()
        If Me.VDeduccion.DataRowCount <> 0 Then
            Registro = Me.VDeduccion.GetRowCellValue(0, "Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Dim f As frmAgregarDeduccion = frmAgregarDeduccion.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VDeduccion.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If
        Registro = Me.VDeduccion.GetFocusedRowCellValue("Codigo")

        Dim f As frmAgregarDeduccion = frmAgregarDeduccion.Instance
        Nuevo = "NO"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VDeduccion.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        Else
            Registro = Me.VDeduccion.GetFocusedRowCellValue("Codigo")
        End If

        If MsgBox("Esta seguro que dese borrar el Registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        VB.SysContab.DeduccionDB.delete(Registro)
        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)
        dgDeduccion.DataSource = VB.SysContab.DeduccionDB.GetList().Tables("Deduccion").DefaultView

        If Me.VDeduccion.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VDeduccion.GetFocusedRowCellValue("Codigo")
        End If


    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub


    Private Sub VDeduccion_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VDeduccion.FocusedRowChanged
        Registro = Me.VDeduccion.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLote.Click
        If QuincenaTrabajo = "" Then
            Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
            g.ShowDialog()
            If QuincenaTrabajo = "" Then
                Exit Sub
            End If
        End If
        Dim f As New frmDeducciones_Tipo
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.VDeduccion.Columns("Cancelado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.VDeduccion.Columns("Cancelado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Cancelado] = False")
        End If
    End Sub
    Private Sub VDeduccion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VDeduccion.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub
End Class
