Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmGenMovimientos
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmGenMovimientos = Nothing

    Public Shared Function Instance() As frmGenMovimientos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGenMovimientos()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim TDeducciones, TDetDeducciones As DataTable
    Dim TIngresos, TDetIngresos As DataTable

    Dim D As New VB.SysContab.DeduccionDB(), DD As New VB.SysContab.DetalleDeduccionDB()
    Dim Ing As New VB.SysContab.IngresoDB(), DIng As New VB.SysContab.DetalleIngresoDB()
    Dim Permisos As New VB.SysContab.PermisosDB(), DPermisos As New VB.SysContab.PermisosDetails()
    Dim PeriodoNomina As New VB.SysContab.PeriodoNominaDB(), DPN As New VB.SysContab.PeriodoNominaDetails()
    Dim cEmpleado As String, cMovimiento As String
    Dim Tabla As DataTable
    Dim ds As DataSet, ds2 As DataSet, ds3 As DataSet
    Dim ED As New VB.SysContab.EmpresasDetails
    Friend WithEvents dgPeriodoNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents PBar As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents VPeriodos As DevExpress.XtraGrid.Views.Grid.GridView




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
    Friend WithEvents cmdGenDef As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdGenDef = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.dgPeriodoNomina = New DevExpress.XtraGrid.GridControl
        Me.VPeriodos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PBar = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdGenDef)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 224)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdGenDef
        '
        Me.cmdGenDef.Location = New System.Drawing.Point(6, 10)
        Me.cmdGenDef.Name = "cmdGenDef"
        Me.cmdGenDef.Size = New System.Drawing.Size(112, 24)
        Me.cmdGenDef.TabIndex = 7
        Me.cmdGenDef.Text = "Generar "
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(6, 40)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'dgPeriodoNomina
        '
        Me.dgPeriodoNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPeriodoNomina.EmbeddedNavigator.Name = ""
        Me.dgPeriodoNomina.Location = New System.Drawing.Point(12, 12)
        Me.dgPeriodoNomina.MainView = Me.VPeriodos
        Me.dgPeriodoNomina.Name = "dgPeriodoNomina"
        Me.dgPeriodoNomina.Size = New System.Drawing.Size(400, 200)
        Me.dgPeriodoNomina.TabIndex = 118
        Me.dgPeriodoNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VPeriodos})
        '
        'VPeriodos
        '
        Me.VPeriodos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VPeriodos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPeriodos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VPeriodos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.Empty.Options.UseBackColor = True
        Me.VPeriodos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VPeriodos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VPeriodos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VPeriodos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VPeriodos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VPeriodos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPeriodos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VPeriodos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VPeriodos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VPeriodos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPeriodos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VPeriodos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VPeriodos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupRow.Options.UseFont = True
        Me.VPeriodos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VPeriodos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VPeriodos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VPeriodos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.OddRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VPeriodos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VPeriodos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VPeriodos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.Preview.Options.UseBackColor = True
        Me.VPeriodos.Appearance.Preview.Options.UseFont = True
        Me.VPeriodos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.Row.Options.UseBackColor = True
        Me.VPeriodos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPeriodos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VPeriodos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VPeriodos.Appearance.VertLine.Options.UseBackColor = True
        Me.VPeriodos.GridControl = Me.dgPeriodoNomina
        Me.VPeriodos.Name = "VPeriodos"
        Me.VPeriodos.OptionsBehavior.Editable = False
        Me.VPeriodos.OptionsView.EnableAppearanceEvenRow = True
        Me.VPeriodos.OptionsView.EnableAppearanceOddRow = True
        Me.VPeriodos.OptionsView.ShowAutoFilterRow = True
        Me.VPeriodos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VPeriodos.OptionsView.ShowFooter = True
        Me.VPeriodos.OptionsView.ShowGroupPanel = False
        '
        'PBar
        '
        Me.PBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBar.Enabled = False
        Me.PBar.Location = New System.Drawing.Point(12, 218)
        Me.PBar.Name = "PBar"
        Me.PBar.Properties.MarqueeAnimationSpeed = 50
        Me.PBar.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle
        Me.PBar.Size = New System.Drawing.Size(400, 18)
        Me.PBar.TabIndex = 119
        Me.PBar.Visible = False
        '
        'frmGenMovimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 245)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.dgPeriodoNomina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGenMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGenMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ED = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetListFiltro("%", "0", "0").Tables("PeriodoNomina")
        Me.VPeriodos.Columns("per_codigo").Caption = "Periodo"
        Me.VPeriodos.Columns("per_descripcion").Caption = "Descripción"
        Me.VPeriodos.Columns("per_finicio").Caption = "Fecha Inicio"
        Me.VPeriodos.Columns("per_ffinal").Caption = "Fecha Final"

        Me.VPeriodos.Columns(0).Width = 50
        Me.VPeriodos.Columns(1).Width = 250
        Me.VPeriodos.Columns(2).Width = 80
        Me.VPeriodos.Columns(3).Width = 80



        If Me.VPeriodos.DataRowCount <> 0 Then
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
            Me.cmdGenDef.Enabled = True

        Else
            Registro = "Vacio"
            Me.cmdGenDef.Enabled = False
        End If

        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdGenDef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenDef.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer
        Dim myds As DataSet, MCS As DataSet
        Dim Actualizados, Agregados As Integer, sPeriodo As String


        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")

        sPeriodo = Registro.Substring(0, 1) & "-" & Registro.Substring(1, 8)
        DPN = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        'Ver si se van a deshacer los movimientos
        'o lo busco en dpn o en el check de la pantalla
        If DPN.Procesado Then
            MsgBox("Este periodo ya tiene generada la planilla. No se pueden deshacer sus movimientos", MsgBoxStyle.Critical, "STS-Nomina")
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            If DPN.MovGen Then
                If MsgBox("Los movimientos de este periodo ya fueron generados, desea revertir este proceso?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "STS-Nomina") = MsgBoxResult.Yes Then
                    'Deshacer movimientos de Permisos
                    PBar.Enabled = True
                    PBar.Visible = True
                    PBar.Properties.Stopped = False
                    Refresh()

                    VB.SysContab.PermisosDB.Aplicar_Undo(Registro.Substring(1, 8), Registro.Substring(0, 1))
                    VB.SysContab.PeriodoNominaDB.Movimientos_Undo(Registro.Substring(1, 8), Registro.Substring(0, 1))
                    PeriodoNomina.MovGen(Registro.Substring(1, 8), Registro.Substring(0, 1), False)
                    VB.SysContab.MCS_DB.AplicarTransaccion("%", _
                                False, _
                                Registro, _
                                "", "")

                    VB.SysContab.MCS_DB.SnackBar_AplicarTransaccion(Registro.Substring(0, 1), _
                        Registro.Substring(1, 8), "%", "", False)

                    Me.VPeriodos.SetFocusedRowCellValue(Me.VPeriodos.Columns("Movimientos Generados"), False)
                    MsgBox("Movimientos Revertidos", MsgBoxStyle.Information, "STS-Nomina")
                    GoTo Final
                Else
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            Else
                PBar.Enabled = True
                PBar.Visible = True
                PBar.Properties.Stopped = False
                Refresh()

                'Paso 0: Procesar la comida si la empresa tiene configurado el modulo de comida
                If ED.MCS And Registro.Substring(0, 1) = "Q" Then
                    Dim nTransaccion As String = ""
                    Dim nTransaccion2 As String = ""

                    myds = VB.SysContab.MCS_DB.GetList(False, Registro.Substring(1, 8), Registro.Substring(0, 1))
                    'MsgBox("Comida" & myds.Tables(0).Rows.Count)
                    MCS = VB.SysContab.MCS_DB.GetConfiguracion
                    If MCS Is Nothing Then
                        MsgBox("No se han configurado las cuentas para las deducciones el modulo MCS", MsgBoxStyle.Critical, "STS-Nomina")
                        GoTo Final
                        'Exit Sub
                    End If
                    If Registro.Substring(0, 1) = "A" Or Registro.Substring(0, 1) = "E" Or Registro.Substring(0, 1) = "V" Then
                        GoTo continuar
                    End If
                    For i = 0 To myds.Tables(0).Rows.Count - 1
                        Try

                            If myds.Tables(0).Rows(i)("Empleado") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTransaccion = cMovimiento
                                'Agregar la Deduccion del empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, myds.Tables(0).Rows(i)("emp_codigo"), _
                                                    CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                                    DPN.FFinal, _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    1, _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    0.0, _
                                                    MCS.Tables(0).Rows(0)("emp_deduccion"), _
                                                    True, _
                                                    False, _
                                                    False, _
                                                    ED.MONEDABASE, _
                                                    True, _
                                                    True, False, 0, 0, nTransaccion) = False Then
                                    Exit For
                                End If
                            End If

                            If myds.Tables(0).Rows(i)("Iva_Empleado") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTransaccion2 = cMovimiento
                                'Agregar la Deduccion del IVA empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, myds.Tables(0).Rows(i)("emp_codigo"), _
                                                        CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                                        DPN.FFinal, _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        1, _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        0.0, _
                                                        MCS.Tables(0).Rows(0)("emp_deduccion_iva"), _
                                                        True, _
                                                        False, _
                                                        False, _
                                                        ED.MONEDABASE, _
                                                        True, _
                                                        True, False, 0, 0, nTransaccion2) = False Then
                                    Exit For
                                End If

                            End If
                            VB.SysContab.MCS_DB.AplicarTransaccion(myds.Tables(0).Rows(i)("emp_codigo"), _
                                                                              True, Registro, _
                                                                              nTransaccion, nTransaccion2)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Try
                        End Try


                    Next
                    myds.Clear()
                End If
                'Paso 0.1: Snack Bar
                Dim nTSnack As String = ""
                Dim mydt As New DataTable
                If Registro.Substring(0, 1) = "Q" Then
                    mydt = VB.SysContab.MCS_DB.SnackBar_GetList(Registro.Substring(1, 8), Registro.Substring(0, 1))
                Else : mydt = Nothing
                End If

                If Not mydt Is Nothing Then
                    'MsgBox("Comida" & mydt.Rows.Count)
                    For i = 0 To mydt.Rows.Count - 1
                        Try
                            cMovimiento = ""
                            If mydt.Rows(i)("total") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTSnack = cMovimiento
                                'Agregar la Deduccion del empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, _
                                        mydt.Rows(i)("emp_codigo"), _
                                        CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                        DPN.FFinal, _
                                        mydt.Rows(i)("total"), _
                                        mydt.Rows(i)("total"), _
                                        1, _
                                        mydt.Rows(i)("total"), _
                                        0.0, _
                                        mydt.Rows(i)("Codigo_Deduccion"), _
                                        True, _
                                        False, _
                                        False, _
                                        ED.MONEDABASE, _
                                        True, _
                                        True, False, 0, 0, nTSnack) = False Then
                                    Exit For
                                End If
                            End If

                            VB.SysContab.MCS_DB.SnackBar_AplicarTransaccion(Registro.Substring(0, 1), _
                            Registro.Substring(1, 8), mydt.Rows(i)("emp_codigo"), nTSnack, True)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Try
                        End Try
                    Next
                    mydt.Clear()
                End If

                'Paso 1: Procesar los permisos
Continuar:      myds = VB.SysContab.PermisosDB.GetList_Aplicar(Registro.Substring(1, 8), Registro.Substring(0, 1))
                For i = 0 To myds.Tables(0).Rows.Count - 1
                    VB.SysContab.PermisosDB.Add(myds.Tables(0).Rows(i)("prm_codigo"), _
                        Registro.Substring(1, 8), _
                        Registro.Substring(0, 1), _
                        myds.Tables(0).Rows(i)("prm_cantidad"), myds.Tables(0).Rows(i)("prm_sextodia"), _
                        myds.Tables(0).Rows(i)("prm_septimodia"), myds.Tables(0).Rows(i)("prm_hasta"))

                    VB.SysContab.PermisosDB.UpdateSaldo(myds.Tables(0).Rows(i)("prm_codigo"), myds.Tables(0).Rows(i)("prm_cantidad"))
                Next
                'DEDUCCIONES 
                Agregados += VB.SysContab.DeduccionDB.GenerarDeducciones(Registro.Substring(1, 8), Registro.Substring(0, 1))
                Agregados += VB.SysContab.IngresoDB.GenerarIngresos(Registro.Substring(1, 8), Registro.Substring(0, 1))

                PBar.Properties.Stopped = True
                PBar.Enabled = False
                PBar.Visible = False

                PeriodoNomina.MovGen(Registro.Substring(1, 8), Registro.Substring(0, 1), True)
                Me.VPeriodos.SetFocusedRowCellValue(Me.VPeriodos.Columns("Movimientos Generados"), True)
                MsgBox("Se han Agregado " & Agregados.ToString & " registro(s) y Actualizado " & Actualizados.ToString & " registro(s)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                ''''Aca termina el proceso de Generar Movimientos
                Me.Cursor = Cursors.Default
                Exit Sub
                End If

        End If
Final:
        Me.Cursor = Cursors.Default
        PBar.Properties.Stopped = True
        PBar.Enabled = False
        PBar.Visible = False
    End Sub




    Private Sub VPeriodos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VPeriodos.FocusedRowChanged
        'Guarda el código nomina seleccionado en el grid
        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        If Registro = "Vacio" Then
            DPN = Nothing
            Me.cmdGenDef.Enabled = False
        Else
            DPN = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
            Me.cmdGenDef.Enabled = True

        End If
    End Sub
End Class
