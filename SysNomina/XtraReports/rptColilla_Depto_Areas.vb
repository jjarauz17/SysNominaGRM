Public Class rptColilla_Depto_Areas

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint

        Dim Fila As DataRowView = GetCurrentRow()

        If Fila.Item("emp_estado") = "C" Then
            Me.txtEmpleado.Text = "Consultor:"
        ElseIf Fila.Item("Emp_estado") = "F" Then
            Me.txtEmpleado.Text = "Empleado:"
        Else
            Me.txtEmpleado.Text = "Registro:"
        End If
        Me.txtEmpleado.Text = Me.txtEmpleado.Text & " " & Fila.Item("Codigo") & " " & Fila.Item("Nombre")

        If Not Fila.Item("Categoria") = "" Then
            Me.txtEmpleado.Text = Me.txtEmpleado.Text & " Cat:" & Fila.Item("Categoria")
        End If

    End Sub
End Class