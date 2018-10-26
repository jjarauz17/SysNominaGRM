Imports System.Data.SqlClient

Module Module1

    Public WaitTitulo As String = "Cargando..."
    'Para Terraza
    'Public Mantenimiento_Deduccion As Boolean = True
    Public crystal As Boolean = False 'true para almori
    Public PasswordSQL As String = ""
    ''''''''''''
    '' ''Para Almori
    Public Mantenimiento_Deduccion As Boolean = False
    Public bColilla As Boolean = True
    '''''''''''''
    Public RolEdicionSalario As String = "2" '19 para Luis Oreamuno, 2 para el resto
    '  Public IP_SMTP As String = VB.SysContab.Email.GetIP()
    Public Direccion_WebSite As String = "http://simtesis.com/planilla/default.aspx"


    Public transaccion As SqlTransaction
    Public DBConnexion As New SqlConnection()

    Public CadConexion As String
    Public Usuario As String
    Public loginDet As New VB.SysContab.LoginDetailsDB

    Public Indice As Integer
    Public myThread As Threading.Thread

    Public Nuevo As String
    Public Registro As String
    Public Registro1 As String

    Public Opened As String

    Public EmpresaActual As String = 1
    Public NombreEmpresaActual As String = "SUPLIDORA INTERNACIONAL, S.A"

    Public QuincenaTrabajo As String = ""
    Public Meses() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
    Public Billetes() As Double = {500, 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}

    Public FormPrincipal As New frmMain

    Public ConsecutivoBac_Planilla As String
    Public FechaPagoPlanilla As Date

    Public Login As String
    Public Password As String
    Public Usuario_ID As String
    Public UPassword As String
    Public Server As String
    Public DBName As String

    Public Round As String

    Public Structure MiRango
        Public Inicio As DateTime
        Public Final As DateTime
        Public Codigo As String
        Public Descripcion As String
    End Structure


    Public Enum Longitud_Linea_Archivos
        SAIRI = 371
        BAC = 122
    End Enum

    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    'para saber el ultimo dia del mes
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

End Module
