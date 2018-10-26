Public Class frmOrigen 
    Private FormularioOrigen As Object
    Public Sub New(ByRef FO As Object)
        InitializeComponent()
        FormularioOrigen = FO
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        FormularioOrigen.Respuesta = "0"
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim ws As New EDU_Asistencias.Service1SoapClient
        'Dim prueba As DataTable
        'prueba = ws.HorasDocente(76, New Date(2013, 5, 1), New Date(2013, 5, 15), True)
        FormularioOrigen.respuesta = Me.RadioGroup1.EditValue
        Me.Close()

    End Sub

    Private Sub frmOrigen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadioGroup1.EditValue = 1
    End Sub
End Class