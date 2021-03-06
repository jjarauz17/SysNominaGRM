Imports DbConnect
Public Class frmSolictudConstancia
    Private Sub frmSolictudConstancia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fecha.EditValue = Now.Date
        Me.cargarconstancias()
        Me.cargarempleados()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        VB.SysContab.SolicitudDB.Guardar(Me.cbConstancias.GetColumnValue("Tipo Constancia"), _
            Me.Descripcion.Text, _
            Me.Fecha.EditValue, _
            Me.cbConstancias.EditValue, _
            Me.cbEmpleado.EditValue)
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
    Sub cargarconstancias()
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Me.cbConstancias.Properties.DataSource = v.EjecutarComando("_Get_RH_Constancias", "Constancias")
            Me.cbConstancias.Properties.PopulateColumns()
            Me.cbConstancias.Properties.Columns("Codigo").Visible = False
            Me.cbConstancias.Properties.Columns("Tipo Constancia").Visible = False
            Me.cbConstancias.Properties.DisplayMember = "Descripcion"
            Me.cbConstancias.Properties.ValueMember = "Codigo"
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        v = Nothing

    End Sub
    Sub cargarempleados()
        Me.cbEmpleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleado.Properties.DisplayMember = "nombre"
        Me.cbEmpleado.Properties.ValueMember = "emp_codigo"
    End Sub
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
            newMail.Display() 'esto sirve para mostrar el correo en la ventana de Outlook
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
            Exit Function
        End Try
        sendMail = Nothing
        Return True
    End Function
End Class