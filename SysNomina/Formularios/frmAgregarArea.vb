Public Class frmAgregarArea
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarArea = Nothing

    Public Shared Function Instance() As frmAgregarArea
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarArea()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cbDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spDiasLaborales As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.spDiasLaborales = New DevExpress.XtraEditors.SpinEdit()
        Me.cbEmpleados = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.cbDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDiasLaborales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txtOrden)
        Me.GroupBox1.Controls.Add(Me.spDiasLaborales)
        Me.GroupBox1.Controls.Add(Me.cbEmpleados)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.cbDepartamento)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 251)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(19, 158)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl6.TabIndex = 110
        Me.LabelControl6.Text = "Dias Laborales:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(19, 131)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl4.TabIndex = 109
        Me.LabelControl4.Text = "Empleado Supervisor:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 108
        Me.LabelControl3.Text = "Nombre:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 107
        Me.LabelControl2.Text = "Codigo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 106
        Me.LabelControl1.Text = "Departamento:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(19, 184)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl5.TabIndex = 105
        Me.LabelControl5.Text = "Orden Reportes:"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(210, 177)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.MaxLength = 10
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 104
        '
        'spDiasLaborales
        '
        Me.spDiasLaborales.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.spDiasLaborales.Location = New System.Drawing.Point(210, 151)
        Me.spDiasLaborales.Name = "spDiasLaborales"
        Me.spDiasLaborales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spDiasLaborales.Properties.IsFloatValue = False
        Me.spDiasLaborales.Properties.Mask.EditMask = "N00"
        Me.spDiasLaborales.Properties.MaxValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.spDiasLaborales.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.spDiasLaborales.Size = New System.Drawing.Size(100, 20)
        Me.spDiasLaborales.TabIndex = 102
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Location = New System.Drawing.Point(210, 124)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", 200, "Empleado")})
        Me.cbEmpleados.Properties.NullText = ""
        Me.cbEmpleados.Size = New System.Drawing.Size(344, 20)
        Me.cbEmpleados.TabIndex = 101
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(210, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 99
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(210, 55)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 98
        '
        'cbDepartamento
        '
        Me.cbDepartamento.Location = New System.Drawing.Point(210, 23)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 200, "Departamento")})
        Me.cbDepartamento.Properties.NullText = ""
        Me.cbDepartamento.Size = New System.Drawing.Size(344, 20)
        Me.cbDepartamento.TabIndex = 97
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(248, 221)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(168, 221)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmAgregarArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 260)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDiasLaborales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el C�digo del Area", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Area", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        If Nuevo = "SI" Then
            Try
                VB.SysContab.AreaDB.Additem(Me.cbDepartamento.EditValue, txtCodigo.Text, _
                    txtNombre.Text, _
                    IIf(Me.cbEmpleados.EditValue Is Nothing, 0, Me.cbEmpleados.EditValue), _
                    Me.spDiasLaborales.EditValue, Me.txtOrden.EditValue)
            Catch ex As Exception
                MsgBox(ex.Message)
                txtCodigo.Focus()
                Exit Sub
            End Try

            MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            VB.SysContab.RutinasNomina.LimpiarControles(GroupBox1)
            txtCodigo.Focus()
            Me.Close()
        Else
            VB.SysContab.AreaDB.Update(Me.cbDepartamento.EditValue, Me.txtCodigo.Text, txtNombre.Text, _
                    IIf(Me.cbEmpleados.EditValue Is Nothing, 0, Me.cbEmpleados.EditValue), _
                    Me.spDiasLaborales.EditValue, Me.txtOrden.EditValue)
            MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()
        End If

        Me.Refresh()
    End Sub

    Private Sub frmAgregararea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim D As New VB.SysContab.DepartamentosDB()

        cbDepartamento.Properties.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        cbDepartamento.Properties.ValueMember = "Codigo"
        cbDepartamento.Properties.DisplayMember = "Nombre"

        Me.cbEmpleados.Properties.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.Properties.DisplayMember = "nombre"
        Me.cbEmpleados.Properties.ValueMember = "emp_codigo"

        If Nuevo = "NO" Then
            Me.Text = "Editar Areas"
            txtCodigo.Properties.ReadOnly = True
            Dim Detalles As VB.SysContab.AreaDetails = VB.SysContab.AreaDB.GetDetails(Registro, Registro1)
            Me.cbDepartamento.EditValue = Detalles.Departamento
            Me.cbDepartamento.Enabled = False
            Me.txtCodigo.Text = Detalles.Area
            Me.txtNombre.Text = Detalles.Descripcion
            Me.spDiasLaborales.EditValue = Detalles.Dias_Laborales
            Me.cbEmpleados.EditValue = Detalles.Empleado
            Me.txtOrden.EditValue = Detalles.OrdenReportes
            Me.txtNombre.Focus()

        Else
            Me.Text = "Agregar Areas"
            Me.cbDepartamento.Enabled = True
            Me.txtCodigo.Text = VB.SysContab.AreaDB.GetListNuevo(Registro)
            Me.txtNombre.Text = ""
            Me.spDiasLaborales.EditValue = 6
            Me.txtOrden.EditValue = ""
        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.EditValueChanged
        If IsNumeric(Me.cbDepartamento.EditValue) Then
            If Nuevo = "SI" Then
                Me.txtCodigo.Text = VB.SysContab.AreaDB.GetListNuevo(Me.cbDepartamento.EditValue)
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If
        End If
    End Sub
End Class
