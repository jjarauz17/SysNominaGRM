Imports DevExpress.XtraSplashScreen
Public Class ADORNOS
    Public Shared Sub ShowSplash()
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm))
        Catch ex As Exception
        End Try

    End Sub

    Public Shared Sub HideSplash()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception
        End Try

    End Sub
End Class
