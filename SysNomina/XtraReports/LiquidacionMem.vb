Public Class LiquidacionMem
    Public Shared dt As New DataTable

    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        Dim rptS As New LiquidacionMem

        Me.ss.Text = "( C$ " & Me.salariocord.Text & " T/C: " & Me.TC.Text & ")"
        rptS.DataSource = dt
        Detalle.ReportSource = rptS
    End Sub
End Class