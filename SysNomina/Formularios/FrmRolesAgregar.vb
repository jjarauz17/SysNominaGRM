Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class FrmRolesAgregar
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAcumulado As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ckHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents tvAcciones As System.Windows.Forms.TreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tvAcciones1 As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAcumulado = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ckHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tvAcciones = New System.Windows.Forms.TreeView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tvAcciones1 = New System.Windows.Forms.TreeView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAcumulado, Me.cmdAceptar})
        Me.GroupBox2.Location = New System.Drawing.Point(928, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 520)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Location = New System.Drawing.Point(8, 48)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(64, 24)
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(64, 22)
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Guardar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvAcciones1, Me.ckHabilitado, Me.txtNombre, Me.Label29, Me.Label13, Me.txtDescripcion, Me.Label1})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 112)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'ckHabilitado
        '
        Me.ckHabilitado.Location = New System.Drawing.Point(8, 80)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(112, 24)
        Me.ckHabilitado.TabIndex = 142
        Me.ckHabilitado.Text = "Habilitado"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 16)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(280, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Text = ""
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 24)
        Me.Label29.TabIndex = 135
        Me.Label29.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 48)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(280, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(432, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvAcciones, Me.lbAsignados, Me.Label3, Me.lbRecursos, Me.Label2, Me.Button2, Me.Button1, Me.Label4})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 408)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'lbAsignados
        '
        Me.lbAsignados.Location = New System.Drawing.Point(344, 32)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(208, 303)
        Me.lbAsignados.TabIndex = 1
        Me.lbAsignados.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 24)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Recursos Asignados"
        Me.Label3.Visible = False
        '
        'lbRecursos
        '
        Me.lbRecursos.Location = New System.Drawing.Point(16, 32)
        Me.lbRecursos.Name = "lbRecursos"
        Me.lbRecursos.Size = New System.Drawing.Size(208, 303)
        Me.lbRecursos.TabIndex = 0
        Me.lbRecursos.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Recursos Disponibles"
        Me.Label2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Quitar"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar"
        Me.Button1.Visible = False
        '
        'tvAcciones
        '
        Me.tvAcciones.CheckBoxes = True
        Me.tvAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAcciones.ImageIndex = -1
        Me.tvAcciones.Indent = 40
        Me.tvAcciones.Location = New System.Drawing.Point(16, 24)
        Me.tvAcciones.Name = "tvAcciones"
        Me.tvAcciones.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Nuevo"), New System.Windows.Forms.TreeNode("Editar", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Activos")}), New System.Windows.Forms.TreeNode("Imprimir", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Fijos"), New System.Windows.Forms.TreeNode("Contrato"), New System.Windows.Forms.TreeNode("Registro"), New System.Windows.Forms.TreeNode("Datos Generales"), New System.Windows.Forms.TreeNode("Ubicación")}), New System.Windows.Forms.TreeNode("Horarios"), New System.Windows.Forms.TreeNode("Borrar")})
        Me.tvAcciones.SelectedImageIndex = -1
        Me.tvAcciones.Size = New System.Drawing.Size(520, 376)
        Me.tvAcciones.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Recursos"
        '
        'tvAcciones1
        '
        Me.tvAcciones1.CheckBoxes = True
        Me.tvAcciones1.ImageIndex = -1
        Me.tvAcciones1.Location = New System.Drawing.Point(576, 48)
        Me.tvAcciones1.Name = "tvAcciones1"
        Me.tvAcciones1.SelectedImageIndex = -1
        Me.tvAcciones1.Size = New System.Drawing.Size(72, 24)
        Me.tvAcciones1.TabIndex = 143
        Me.tvAcciones1.Visible = False
        '
        'FrmRolesAgregar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.GroupBox2, Me.GroupBox3})
        Me.Name = "FrmRolesAgregar"
        Me.Text = "Agregar Roles"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmRolesAgregar = Nothing

    Public Shared Function Instance() As FrmRolesAgregar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRolesAgregar
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function


    Dim Disponibles As DataSet = New DataSet
    Dim DisTable As DataTable = Disponibles.Tables.Add("Disponibles")
    Dim DisRow As DataRow = DisTable.NewRow()
    Dim D1 As DataColumn = DisTable.Columns.Add("D1")
    Dim D2 As DataColumn = DisTable.Columns.Add("D2")


    Dim Seleccionados As DataSet = New DataSet
    Dim workTable As DataTable = Seleccionados.Tables.Add("Seleccionados")
    Dim workRow As DataRow = workTable.NewRow()
    Dim c1 As DataColumn = workTable.Columns.Add("c1")
    Dim c2 As DataColumn = workTable.Columns.Add("c2")

    Dim RolID As Integer


    Private Sub FrmRolesAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = Me.Name

        RolID = "-1"

        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetLisRecursos()

        Dim Rol As DataSet = VB.SysContab.SeguridadDB.GetRol(RolID)

        Dim i As Integer
        Dim j As Integer

        For i = 0 To Ds.Tables("Tabla").Rows.Count - 1
            DisRow = DisTable.NewRow()
            DisRow(D1) = Ds.Tables("Tabla").Rows(i).Item("Recurso")
            DisRow(D2) = Ds.Tables("Tabla").Rows(i).Item("Nombre")
            DisTable.Rows.Add(DisRow)
        Next

        lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        lbRecursos.ValueMember = "D1"
        lbRecursos.DisplayMember = "D2"

        Me.tvAcciones.Nodes.Clear()
        'Me.tvAcciones1.Nodes.Clear()

        For j = 0 To Rol.Tables("RolesRecursos").Rows.Count - 1
            '
            Me.tvAcciones.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_Nombre"))
            Me.tvAcciones1.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_ID"))
            Me.tvAcciones.Nodes.Item(j).Checked = Rol.Tables("RolesRecursos").Rows(j).Item("Asignado")
        Next


        'For i = 0 To Seleccionados.Tables("Seleccionados").Rows.Count - 1
        '    Me.tvAcciones.Nodes.Add(Seleccionados.Tables("Seleccionados").Rows(i).Item("c2"))
        '    Me.tvAcciones1.Nodes.Add(Seleccionados.Tables("Seleccionados").Rows(i).Item("c1"))

        '    'Me.tvAcciones.Nodes.Item(i).Checked = Seleccionados.Tables("RolesRecursos").Rows(i).Item("Asignado")
        'Next

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim dsAcciones As DataSet

        For i = 0 To Me.tvAcciones1.GetNodeCount(False) - 1
            'MsgBox(Me.tvAcciones1.Nodes.Item(i).Text)
            dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, Me.tvAcciones1.Nodes.Item(i).Text, RolID)

            For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                Me.tvAcciones.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                Me.tvAcciones1.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))

                Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")

                For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows.Count - 1
                    Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                    Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))

                    Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Asignado")

                    For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows.Count - 1
                        Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                        Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))

                        Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z) = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Asignado")
                    Next
                Next
            Next
        Next

    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub


    ' Asignar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If lbRecursos.Items.Count > 0 Then
            workRow = workTable.NewRow()
            workRow(c1) = lbRecursos.SelectedValue
            workRow(c2) = lbRecursos.Text
            workTable.Rows.Add(workRow)

            lbAsignados.DataSource = Seleccionados.Tables("Seleccionados")
            lbAsignados.ValueMember = "c1"
            lbAsignados.DisplayMember = "c2"

            Disponibles.Tables("Disponibles").Rows(lbRecursos.SelectedIndex).Delete()
        End If



    End Sub

    ' Quitar
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If lbAsignados.Items.Count > 0 Then
            DisRow = DisTable.NewRow()
            DisRow(D1) = lbAsignados.SelectedValue
            DisRow(D2) = lbAsignados.Text
            DisTable.Rows.Add(DisRow)

            lbRecursos.DataSource = Disponibles.Tables("Disponibles")
            lbRecursos.ValueMember = "D1"
            lbRecursos.DisplayMember = "D2"

            Seleccionados.Tables("Seleccionados").Rows(lbAsignados.SelectedIndex).Delete()

        End If


    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim DBConn As SqlConnection
        Dim conexion As New VB.SysContab.Rutinas
        DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
        Dim Transaccion As SqlTransaction = Nothing
        Dim i As Integer = 0

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Try

            DBConn.Open()
            Transaccion = DBConn.BeginTransaction

            Dim RolID As String = VB.SysContab.SeguridadDB.RolesAdd(txtNombre.Text, txtDescripcion.Text, ckHabilitado.Checked, DBConn, Transaccion)


            For i = 0 To Me.tvAcciones.GetNodeCount(False) - 1
                If Me.tvAcciones.Nodes.Item(i).Checked = True Then
                    VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes.Item(i).Text, DBConn, Transaccion)
                End If

                For x = 0 To Me.tvAcciones.Nodes(i).GetNodeCount(False) - 1
                    If Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = True Then
                        VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes.Item(x).Text, DBConn, Transaccion)
                        'MsgBox(Me.tvAcciones.Nodes(i).Nodes.Item(x).Text)
                    End If

                    For y = 0 To Me.tvAcciones.Nodes(i).Nodes(x).GetNodeCount(False) - 1
                        If Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = True Then
                            VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Item(y).Text, DBConn, Transaccion)
                            'MsgBox(Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Text)
                        End If

                        For z = 0 To Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).GetNodeCount(False) - 1
                            If Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Checked = True Then
                                VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Text, DBConn, Transaccion)
                                'MsgBox(Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Text)
                            End If
                        Next
                    Next
                Next
            Next

            'For i = 0 To Seleccionados.Tables("seleccionados").Rows.Count - 1
            '    VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Seleccionados.Tables("seleccionados").Rows(i).Item("C1"), DBConn, Transaccion)
            'Next

            Transaccion.Commit()
            DBConn.Close()

            MsgBox("Se Registrado Correctamente el Rol")

            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Transaccion.Rollback()
            DBConn.Close()
        End Try
    End Sub

End Class