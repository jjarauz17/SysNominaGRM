Imports System.Diagnostics
Imports System
Imports Clases

Module Module2
    Public Refrescamiento As Integer = 8000

    Public Cadena As Conection
    Public Funcion As New Functions

    ''Dim objStreamReader As StreamReader
    ''Dim strLine As String

    ''Pass the file path and the file name to the StreamReader constructor.
    'Dim objStreamReader = New StreamReader("C:\Testfile.txt")

    ''Read the first line of text.
    'Dim strLine = objStreamReader.ReadLine

    ''Continue to read until you reach the end of the file.
    'Do While Not strLine Is Nothing

    ''Write the line to the Console window.
    '  Console.WriteLine(strLine)

    ''Read the next line.
    '  strLine = objStreamReader.ReadLine
    'Loop

    ''Close the file.
    'objStreamReader.Close()

    'Console.ReadLine()
    'Public Sub EscribeLog(ByVal Mensaje As String)

    '    If Not EventLog.SourceExists("Log.txt") Then
    '        EventLog.CreateEventSource("Log.txt", "Errores")
    '    End If
    '    Dim ELog As New EventLog
    '    ELog.Source = "Log.txt"
    '    ELog.Log = "Log.txt"
    '    ELog.WriteEntry(Mensaje, EventLogEntryType.Warning, 234, CType(3, Short))
    'End Sub
End Module
