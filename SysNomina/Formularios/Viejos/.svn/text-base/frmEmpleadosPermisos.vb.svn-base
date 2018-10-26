Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmEmpleadosPermisos
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmEmpleadosPermisos = Nothing

    Public Shared Function Instance() As frmEmpleadosPermisos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEmpleadosPermisos()
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
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents Empleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdConsulta As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdConsulta = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl
        Me.Empleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdConsulta)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdConsulta
        '
        Me.cmdConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsulta.Location = New System.Drawing.Point(275, 16)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(72, 24)
        Me.cmdConsulta.TabIndex = 7
        Me.cmdConsulta.Text = "Consulta"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(88, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Permisos"
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 78)
        Me.dgEmpleados.MainView = Me.Empleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(353, 232)
        Me.dgEmpleados.TabIndex = 12
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Empleados})
        '
        'Empleados
        '
        Me.Empleados.GridControl = Me.dgEmpleados
        Me.Empleados.Name = "Empleados"
        Me.Empleados.OptionsBehavior.Editable = False
        Me.Empleados.OptionsView.ShowAutoFilterRow = True
        Me.Empleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Empleados.OptionsView.ShowFooter = True
        Me.Empleados.OptionsView.ShowGroupPanel = False
        '
        'frmEmpleadosPermisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 570)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmpleadosPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEmpleadosPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Liquidado] = False and FechaFin is null")

        dgEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables("Empleados")
        Me.Empleados.Columns(0).Width = 80
        Me.Empleados.Columns(1).Width = 250
        Me.Empleados.Columns(2).Width = 300
        Me.Empleados.Columns(3).Width = 50

        Me.Empleados.Columns("Liquidado").Visible = False
        Me.Empleados.Columns("Liquidado").OptionsColumn.ShowInCustomizationForm = False
        'Me.Empleados.Columns("Liquidado").FilterInfo = Filtro

        Me.Empleados.Columns("Email").Visible = False
        Me.Empleados.Columns("Usuario").Visible = False
        Me.Empleados.Columns("Acumula Prestaciones").Visible = False
        Me.Empleados.Columns("Forma de Pago").Visible = False
        Me.Empleados.Columns("INSS").Visible = False
        Me.Empleados.Columns("Cédula").Visible = False
        Me.Empleados.Columns("FechaFin").Visible = False
        Me.Empleados.Columns("SalarioxDia").Visible = False
        Me.Empleados.Columns("SalarioxHora").Visible = False

        If Me.Empleados.DataRowCount <> 0 Then
            Registro = Me.Empleados.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "Mantenimiento de Permisos de Empleados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Me.Empleados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If

        Dim f As frmAgregarPermisos = frmAgregarPermisos.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub Empleados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Empleados.FocusedRowChanged
        Registro = Me.Empleados.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        Dim f As New frmPermisosConsulta
        f.MdiParent = Me.MdiParent
        f.Show()
        
    End Sub
End Class
