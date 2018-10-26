Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAsignarHorarios
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAsignarHorarios = Nothing

    Public Shared Function Instance() As frmAsignarHorarios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAsignarHorarios()
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

    

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents CkBTodas As System.Windows.Forms.CheckBox

#End Region

    Private Sub frmAutHExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As DataSet

        VB.SysContab.RutinasNomina.CambiarEstilo(Me)

        CBDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        CBDepartamento.ValueMember = "Codigo"
        CBDepartamento.DisplayMember = "Nombre"

        CBHorario.DataSource = VB.SysContab.HorarioDB.GetListBuscarCombo("%").Tables("Horario")
        CBHorario.ValueMember = "Codigo"
        CBHorario.DisplayMember = "Descripcion"

        ds = VB.SysContab.EmpleadosDB.GetListDepto("%", 1)
        dgHExtras.DataSource = ds.Tables(0)

        If ds.Tables("Empleados").Rows.Count <> 0 Then
            Registro = Me.GVHorarios.DataSource.table.rows(0).item("Codigo")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Asignación de Horarios a Empleados"

        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub




    Private Sub CBDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CBDepartamento.Validating
        Dim ds As DataSet
        ds = VB.SysContab.EmpleadosDB.GetListDepto(IIf(Val(Me.CBDepartamento.SelectedValue) <> 0, Me.CBDepartamento.SelectedValue, "%"), 1)
        ds.Tables("Empleados").DefaultView.AllowDelete = False
        ds.Tables("Empleados").DefaultView.AllowNew = False

        dgHExtras.DataSource = ds.Tables(0).DefaultView
        If ds.Tables("Empleados").Rows.Count = 0 Then
            Exit Sub
        End If
        Registro = Me.GVHorarios.DataSource.table.rows(Me.GVHorarios.FocusedRowHandle).item("Codigo")

    End Sub



    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Me.CBHorario.SelectedValue Is Nothing Or Me.CBHorario.SelectedValue Is DBNull.Value Then
            MsgBox("Seleccione un Horario a Asignar", MsgBoxStyle.Critical, "STS-Nomina")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To Me.GVHorarios.DataSource.table.rows.count - 1
            If Me.GVHorarios.DataSource.table.rows(i)("Marca") = True Then
                VB.SysContab.EmpleadosDB.UpdateHorario(Me.GVHorarios.DataSource.table.rows(i)("Codigo"), _
                            Me.CBHorario.SelectedValue)
            End If
        Next
        Dim ds As DataSet

        ds = VB.SysContab.EmpleadosDB.GetListDepto(IIf(Val(Me.CBDepartamento.SelectedValue) <> 0, Me.CBDepartamento.SelectedValue, "%"), 1)
        dgHExtras.DataSource = ds.Tables(0)

        If ds.Tables("Empleados").Rows.Count = 0 Then
            Exit Sub
        End If

        Registro = Me.GVHorarios.DataSource.table.rows(Me.GVHorarios.FocusedRowHandle).item("Codigo")
        Me.CkBTodas.Checked = False
    End Sub

    Private Sub CBDepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBDepartamento.SelectedIndexChanged
        If IsNumeric(CBDepartamento.SelectedValue) Then
            Dim ds As DataSet

            ds = VB.SysContab.EmpleadosDB.GetListDepto(IIf(Val(Me.CBDepartamento.SelectedValue) <> 0, Me.CBDepartamento.SelectedValue, "%"), 1)
            dgHExtras.DataSource = ds.Tables(0)

            If ds.Tables("Empleados").Rows.Count = 0 Then
                Exit Sub
            End If

            Registro = Me.GVHorarios.DataSource.table.rows(Me.GVHorarios.FocusedRowHandle).item("Codigo")
            Me.CkBTodas.Checked = False
        End If
    End Sub

    Private Sub CkBTodas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CkBTodas.CheckedChanged
        Dim i As Integer
        For i = 0 To Me.GVHorarios.DataSource.table.rows.count - 1
            Me.GVHorarios.DataSource.table.rows(i).item("Marca") = Me.CkBTodas.Checked
        Next

    End Sub
End Class
