Public Class frmAgregarHorario
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarHorario = Nothing
    Private HEnt As String, HSal As String, LCodigo As String
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttotalhoras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthorasDescanso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents frmAgregarHorarioConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

    Public Shared Function Instance() As frmAgregarHorario
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarHorario()
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
    Friend WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraSalida As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.frmAgregarHorarioConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txthorasDescanso = New DevExpress.XtraEditors.SpinEdit()
        Me.txttotalhoras = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarHorarioConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarHorarioConvertedLayout.SuspendLayout()
        CType(Me.txthorasDescanso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotalhoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Checked = False
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(105, 36)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(200, 20)
        Me.dtpHoraEntrada.TabIndex = 21
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(105, 60)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(200, 20)
        Me.dtpHoraSalida.TabIndex = 22
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(105, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AllowFocused = False
        Me.txtCodigo.Size = New System.Drawing.Size(200, 20)
        Me.txtCodigo.StyleController = Me.frmAgregarHorarioConvertedLayout
        Me.txtCodigo.TabIndex = 122
        '
        'frmAgregarHorarioConvertedLayout
        '
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.txthorasDescanso)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.txttotalhoras)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.dtpHoraSalida)
        Me.frmAgregarHorarioConvertedLayout.Controls.Add(Me.dtpHoraEntrada)
        Me.frmAgregarHorarioConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarHorarioConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarHorarioConvertedLayout.Name = "frmAgregarHorarioConvertedLayout"
        Me.frmAgregarHorarioConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(983, 233, 250, 350)
        Me.frmAgregarHorarioConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarHorarioConvertedLayout.Size = New System.Drawing.Size(512, 206)
        Me.frmAgregarHorarioConvertedLayout.TabIndex = 125
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(421, 172)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 22)
        Me.cmdCancelar.StyleController = Me.frmAgregarHorarioConvertedLayout
        Me.cmdCancelar.TabIndex = 126
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(338, 172)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 22)
        Me.cmdAceptar.StyleController = Me.frmAgregarHorarioConvertedLayout
        Me.cmdAceptar.TabIndex = 125
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'txthorasDescanso
        '
        Me.txthorasDescanso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txthorasDescanso.Location = New System.Drawing.Point(105, 108)
        Me.txthorasDescanso.Name = "txthorasDescanso"
        Me.txthorasDescanso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txthorasDescanso.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txthorasDescanso.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txthorasDescanso.Size = New System.Drawing.Size(200, 20)
        Me.txthorasDescanso.StyleController = Me.frmAgregarHorarioConvertedLayout
        Me.txthorasDescanso.TabIndex = 124
        '
        'txttotalhoras
        '
        Me.txttotalhoras.Enabled = False
        Me.txttotalhoras.Location = New System.Drawing.Point(105, 84)
        Me.txttotalhoras.Name = "txttotalhoras"
        Me.txttotalhoras.Size = New System.Drawing.Size(200, 20)
        Me.txttotalhoras.StyleController = Me.frmAgregarHorarioConvertedLayout
        Me.txttotalhoras.TabIndex = 123
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(512, 206)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txthorasDescanso
        Me.LayoutControlItem1.CustomizationFormText = "txthorasDescansoitem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem1.Name = "txthorasDescansoitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem1.Text = "Horas Descanso:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txttotalhoras
        Me.LayoutControlItem2.CustomizationFormText = "txttotalhorasitem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem2.Name = "txttotalhorasitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem2.Text = "Total Horas:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCodigo
        Me.LayoutControlItem3.CustomizationFormText = "txtCodigoitem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "txtCodigoitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem3.Text = "Codigo de Horario:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtpHoraSalida
        Me.LayoutControlItem6.CustomizationFormText = "dtpHoraSalidaitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "dtpHoraSalidaitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem6.Text = "Hora Salida:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpHoraEntrada
        Me.LayoutControlItem7.CustomizationFormText = "dtpHoraEntradaitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "dtpHoraEntradaitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem7.Text = "Hora Entrada:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(90, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(492, 40)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(297, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(195, 120)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdAceptar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(326, 160)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdCancelar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(409, 160)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 160)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(326, 26)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAgregarHorario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 206)
        Me.Controls.Add(Me.frmAgregarHorarioConvertedLayout)
        Me.Name = "frmAgregarHorario"
        Me.Text = "Horarios"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarHorarioConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarHorarioConvertedLayout.ResumeLayout(False)
        CType(Me.txthorasDescanso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotalhoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarHorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Nuevo = "NO" Then
            Me.txtCodigo.Text = ""
            txttotalhoras.Text = ""
            HEnt = ""
            HSal = ""

            Me.Text = "Editar Horario"

            Dim Detalles As VB.SysContab.HorarioDetails = VB.SysContab.HorarioDB.GetDetails(Registro)

            LCodigo = Detalles.Codigo
            Me.txtCodigo.Text = Detalles.Descripcion
            Me.dtpHoraEntrada.Text = Detalles.entrada
            Me.dtpHoraSalida.Text = Detalles.salida
            'Me.txttotalhoras.Text = DateDiff(DateInterval.Minute, CDate(Detalles.entrada), CDate(Detalles.salida), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) / 60
            Me.txttotalhoras.EditValue = Detalles.Horas + Detalles.HorasDescanso
            Me.txthorasDescanso.EditValue = Detalles.HorasDescanso


        Else
            Me.Text = "Agregar Horario"
            Me.txtCodigo.EditValue = ""
            txttotalhoras.EditValue = ""
            HEnt = ""
            HSal = ""
            LCodigo = ""
            Me.txthorasDescanso.EditValue = 0

        End If


        Me.Refresh()


    End Sub



    Private Sub dtpHoraSalida_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraSalida.Leave

        txttotalhoras.EditValue = (DateDiff(DateInterval.Minute, CDate(dtpHoraEntrada.Text), CDate(dtpHoraSalida.Text), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) / 60)
        HSal = Mid(dtpHoraSalida.Text, 1, 5) & Mid(dtpHoraSalida.Text, 10, 1).ToUpper & Mid(dtpHoraSalida.Text, 12, 2).ToUpper
        If HEnt <> "" Then
            Me.txtCodigo.Text = HEnt & HSal
        End If
    End Sub

    Private Sub dtpHoraEntrada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraEntrada.Leave
        HEnt = Mid(dtpHoraEntrada.Text, 1, 5) & Mid(dtpHoraEntrada.Text, 10, 1).ToUpper & Mid(dtpHoraEntrada.Text, 12, 1).ToUpper
    End Sub


    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim Horarios As New VB.SysContab.HorarioDB()
        Dim ds As DataSet
        Dim CodigoNvo As String, Grabado As Integer


        If Nuevo = "SI" Then
            ds = Horarios.GetListDescripcion(Me.txtCodigo.Text)
            If ds.Tables("Horario").Rows.Count <> 0 Then
                MsgBox("Ese horario ya ha sido definido anteriormente, favor revisar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Codigo ya Existe")
                Exit Sub
            Else
                CodigoNvo = Horarios.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
                Grabado = Horarios.Additem(CodigoNvo, Me.txtCodigo.EditValue, Me.dtpHoraEntrada.Value, _
                        Me.dtpHoraSalida.Value, Me.txttotalhoras.EditValue, Me.txthorasDescanso.EditValue)
                If Grabado = 0 Then
                    MsgBox("Registro agregado satisfactoriamente", MsgBoxStyle.OkOnly)
                    Me.Close()
                End If
            End If
        Else
            Grabado = Horarios.Update(LCodigo, Me.txtCodigo.EditValue, Me.dtpHoraEntrada.Value, _
                    Me.dtpHoraSalida.Value, Me.txttotalhoras.EditValue, Me.txthorasDescanso.EditValue)
            If Grabado = 0 Then
                MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.OkOnly)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class
