Public Class frmReportes
    Inherits DevExpress.XtraEditors.XtraForm

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
    Public WithEvents crvReportes As CrystalDecisions.Windows.Forms.CrystalReportViewer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crvReportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvReportes
        '
        Me.crvReportes.ActiveViewIndex = -1
        Me.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportes.DisplayGroupTree = False
        Me.crvReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportes.Location = New System.Drawing.Point(0, 0)
        Me.crvReportes.Name = "crvReportes"
        Me.crvReportes.SelectionFormula = ""
        Me.crvReportes.Size = New System.Drawing.Size(579, 439)
        Me.crvReportes.TabIndex = 2
        Me.crvReportes.ViewTimeSelectionFormula = ""
        '
        'frmReportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(579, 439)
        Me.Controls.Add(Me.crvReportes)
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'crvReportes.Width = Screen.PrimaryScreen.Bounds.Width() - 20
        'crvReportes.Height = Screen.PrimaryScreen.Bounds.Height() - 65
    End Sub

    Private Sub frmReportes_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'crvReportes.Width = MyBase.Width - 30
        'crvReportes.Height = MyBase.Height - 43
    End Sub

End Class
