Public Class Liquidacion
    Public Shared Detalle As DataSet

    Private Sub detallado_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles detallado.BeforePrint
        Try
            detallado.Text = "Yo " & NyA2.Text & " hago constar que las suma de C$ " & _
                CDbl(IIf(TT_REC.Text = "", "0.00", TT_REC.Text)).ToString("n2") & _
                " (" & monto_letras.Text & ") " & _
                " corresponde a mi liquidación final de prestaciones sociales como trabajador de " & _
                empresa.Text & ", y que durante el tiempo que laboré para dicha empresa, recibí todos mis sueldos y demás prestaciones sociales a las que tengo derecho conforme al Código del Trabajo vigente. Por este motivo otorgo finiquito a ésta empresa de cualquier reclamo posterior."
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        Dim rptS As New Liquidacion

        Me.ss.Text = "( C$ " & Me.salariocord.Text & " T/C: " & Me.TC.Text & ")"
        Me.lMaximo.Visible = IIf(sfijo.Text = "", False, True)
        Me.Maximo.Visible = IIf(sfijo.Text = "", False, True)
        Me.lPromedio.Visible = IIf(sfijo.Text = "", False, True)
        Me.Promedio.Visible = IIf(sfijo.Text = "", False, True)
        rptS.DataSource = Detalle

        'rptS.DataSource = Detalle
        Liq_det.ReportSource = rptS
    End Sub
  
    Private Sub PageFooter_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.AfterPrint
        'Try
        '    Me.TT_REC.Text = CDbl(IIf(Me.ting.Text = "", 0, Me.ting.Text) - IIf(Me.teg.Text = "", 0, Me.teg.Text) - IIf(Me.ir.Text = "", 0, Me.ir.Text) - IIf(Me.inssl.Text = "", 0, Me.inssl.Text)).ToString("n2")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub
End Class