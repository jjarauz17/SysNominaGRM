
Public Class frmRptPlanillaConsolidado_New
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmRptPlanillaConsolidado_New = Nothing

    Public Shared Function Instance() As frmRptPlanillaConsolidado_New
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptPlanillaConsolidado_New()
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
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents cbPeriodo2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkCamposDinamicos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLiquidaciones As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCamposDinamicos = New DevExpress.XtraEditors.CheckEdit
        Me.cbPeriodo2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkLiquidaciones = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chkCamposDinamicos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLiquidaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(8, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(808, 20)
        Me.etDescripcion.TabIndex = 114
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Desde:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(672, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 180)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(8, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 24)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 42)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(106, 20)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.NullText = ""
        Me.cbPeriodo.Size = New System.Drawing.Size(406, 20)
        Me.cbPeriodo.TabIndex = 118
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox7.Location = New System.Drawing.Point(32, 172)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(624, 56)
        Me.GroupBox7.TabIndex = 127
        Me.GroupBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 24)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(416, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkLiquidaciones)
        Me.GroupBox2.Controls.Add(Me.chkCamposDinamicos)
        Me.GroupBox2.Controls.Add(Me.cbPeriodo2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbPeriodo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 118)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'chkCamposDinamicos
        '
        Me.chkCamposDinamicos.Location = New System.Drawing.Point(27, 77)
        Me.chkCamposDinamicos.Name = "chkCamposDinamicos"
        Me.chkCamposDinamicos.Properties.Caption = "Campos Dinamicos"
        Me.chkCamposDinamicos.Size = New System.Drawing.Size(152, 19)
        Me.chkCamposDinamicos.TabIndex = 121
        '
        'cbPeriodo2
        '
        Me.cbPeriodo2.Location = New System.Drawing.Point(106, 46)
        Me.cbPeriodo2.Name = "cbPeriodo2"
        Me.cbPeriodo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo2.Properties.NullText = ""
        Me.cbPeriodo2.Size = New System.Drawing.Size(406, 20)
        Me.cbPeriodo2.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(24, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Hasta:"
        '
        'chkLiquidaciones
        '
        Me.chkLiquidaciones.Location = New System.Drawing.Point(360, 77)
        Me.chkLiquidaciones.Name = "chkLiquidaciones"
        Me.chkLiquidaciones.Properties.Caption = "Incluir Liquidaciones"
        Me.chkLiquidaciones.Size = New System.Drawing.Size(152, 19)
        Me.chkLiquidaciones.TabIndex = 122
        '
        'frmRptPlanillaConsolidado_New
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.etDescripcion)
        Me.Name = "frmRptPlanillaConsolidado_New"
        Me.Text = "Reporte Consolidado de Planilla"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chkCamposDinamicos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLiquidaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Tasa As New VB.SysContab.Tasa_CambioDB()

    Private Sub frmVerPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        Me.cbMonedaCambio.ValueMember = "MonedaCambio"
        Me.cbMonedaCambio.DisplayMember = "Nombre"


        Me.cbPeriodo.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(0).Tables("PeriodoNomina_Afiscal")
        Me.cbPeriodo.Properties.ValueMember = "Per_codigo"
        Me.cbPeriodo.Properties.DisplayMember = "Per_descripcion"
        Me.cbPeriodo.EditValue = Registro

        Me.cbPeriodo2.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_AfiscalBuscar(0).Tables("PeriodoNomina_Afiscal")
        Me.cbPeriodo2.Properties.ValueMember = "Per_codigo"
        Me.cbPeriodo2.Properties.DisplayMember = "Per_descripcion"
        Me.cbPeriodo2.EditValue = Registro
        Me.chkLiquidaciones.EditValue = True
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Me.cbPeriodo2.EditValue = "" Or Me.cbPeriodo.EditValue = "" Then
            MsgBox("Seleccione Mes o Periodo de Nomina a imprimir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim lds, ds As DataSet

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)

        'ds = VB.SysContab.PlanillaDB.RhConsolidado(Me.cbPeriodo.EditValue.ToString.Substring(1, 8), _
        '  Me.cbPeriodo2.EditValue.ToString.Substring(1, 8), Me.cbMonedaCambio.SelectedValue, _
        '  Me.chkCamposDinamicos.EditValue)
        ds = VB.SysContab.PlanillaDB.RhConsolidado(Me.cbPeriodo.EditValue, _
            Me.cbPeriodo2.EditValue, Me.cbMonedaCambio.SelectedValue, _
            Me.chkCamposDinamicos.EditValue, Me.chkLiquidaciones.EditValue)

        ds.WriteXml(Application.StartupPath & "\ConPla.xml", XmlWriteMode.WriteSchema)
        Dim f As New frmGridDatos
        f.Text = "Consolidado de Planillas desde " & Me.cbPeriodo.Text & " hasta " & Me.cbPeriodo2.Text 
        f.Origen = ds
        f.ShowDialog()
        lds = Nothing
        ds = Nothing
        Me.Close()
    End Sub


    Private Sub cbPeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodo.EditValueChanged
        If TypeName(Me.cbPeriodo.EditValue) = "String" Then
            Registro = Me.cbPeriodo.EditValue
        End If
    End Sub

    Private Sub cbPeriodo2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodo2.EditValueChanged
        If TypeName(Me.cbPeriodo2.EditValue) = "String" Then
            Registro = Me.cbPeriodo2.EditValue
        End If
    End Sub
End Class
