Imports System.Net
Imports System.Net.Dns


Namespace VB.SysContab
    Public Class Email

        Public Shared Function GetIP() As String
            Dim h As IPHostEntry = GetHostEntry(GetHostName)
            Dim IP As String = CType(h.AddressList.GetValue(0), _
              IPAddress).ToString()

            Return IP
        End Function
        Public Shared Function Enviar_Mail_Outlook(ByVal Direccion As String, ByVal Subject As String, _
            ByVal Body As String, Optional ByVal Attachment_Path As String = "") As Boolean

            Dim sendMail As Microsoft.Office.Interop.Outlook.Application
            Dim j As Integer

            Try
                Dim newMail As Microsoft.Office.Interop.Outlook.MailItem
                sendMail = New Microsoft.Office.Interop.Outlook.Application
                newMail = sendMail.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
                If Microsoft.VisualBasic.Left(Direccion, 2) = "MS" Then
                    j = Microsoft.VisualBasic.InStr(Direccion, ":")
                    newMail.To = Microsoft.VisualBasic.Right(Direccion, Len(Direccion) - j)
                Else
                    newMail.To = Direccion
                End If
                newMail.Subject = Subject

                ' newMail.Display() 'esto sirve para mostrar el correo en la ventana de Outlook
                newMail.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
                newMail.Body = Body
                If Attachment_Path <> "" Then
                    Dim Attachs As Microsoft.Office.Interop.Outlook.Attachments = newMail.Attachments
                    Dim Attach As Microsoft.Office.Interop.Outlook.Attachment
                    Attach = Attachs.Add(Attachment_Path, , , )
                End If

                newMail.Send()
                newMail = Nothing
            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message)
                While Not (ex.InnerException Is Nothing)
                    MsgBox("The following InnerException reported: " + ex.InnerException.ToString())
                    ex = ex.InnerException
                End While
                'Return False
                Exit Function
            End Try
            sendMail = Nothing
            Return True
        End Function
    End Class

End Namespace
