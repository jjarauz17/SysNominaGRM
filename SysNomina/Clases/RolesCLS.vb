Imports System.Drawing
Imports DbConnect
Imports DevExpress.XtraEditors

Public Class RolesCLS
    Implements IDisposable

#Region " Private variables "
    Private _IdRol As Integer
    Private _Nombre As String
    Private _Descripcion As String
#End Region

    Private Conn As Connect
    Private Cadena As New Conection
    Private Funcion As New Functions


#Region " Properties "
    Public ReadOnly Property IdRol() As Integer
        Get
            Return _IdRol
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            _Nombre = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal Value As String)
            _Descripcion = Value
        End Set
    End Property

#End Region

    Sub New()
        MyBase.New()
        _IdRol = 0
        _Nombre = String.Empty
        _Descripcion = String.Empty
    End Sub

    Public Function List() As DataTable
        _IdRol = 0
        Conn = New Connect(Cadena.ConectionString)
        Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.Input, IdRol)
        Return (Conn.EjecutarComando("Get_Roles"))
    End Function

    Public Function ListDetalles(ByVal Rol As Integer) As DataTable
        _IdRol = Rol
        Conn = New Connect(Cadena.ConectionString)
        Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.Input, IdRol)
        Return (Conn.EjecutarComando("Get_RolesDetalle"))
    End Function

    Public Sub Load(ByVal vIdRol As Integer)
        _IdRol = vIdRol
        If IdRol = 0 Then Exit Sub
        Conn = New Connect(Cadena.ConectionString)
        Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.Input, IdRol)
        Dim Tabla As DataTable = Conn.EjecutarComando("Get_Roles")
        If Tabla.Rows.Count = 0 Then Exit Sub
        _IdRol = Tabla.Rows(0).Item("IdRol")
        Nombre = Tabla.Rows(0).Item("Nombre").ToString
        Descripcion = Tabla.Rows(0).Item("Descripcion").ToString
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = List()
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdRol"
        Combo.Properties.ShowFooter = False
        Combo.Properties.ShowHeader = False
        Combo.Properties.NullText = "[Seleccione el rol]"
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopulateColumns()
        For i As Integer = 0 To Combo.Properties.Columns.Count - 1
            If i <> 1 Then Combo.Properties.Columns(i).Visible = False
        Next
    End Sub

    Public Function Save(ByVal RolesDetalles As DataTable) As Boolean
        Dim Conn As New DbConnect.Connect(Cadena.ConectionString)
        Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.InputOutput, IdRol)
        Conn.AddParameter("Nombre", SqlDbType.NVarChar, 500, ParameterDirection.Input, Nombre)
        Conn.AddParameter("Descripcion", SqlDbType.NVarChar, 500, ParameterDirection.Input, Descripcion)
        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("Proc_Roles")
            If IdRol = 0 Then _IdRol = Conn.GetParameter("IdRol").Valor

            For i As Integer = 0 To RolesDetalles.Rows.Count - 1
                Conn.RemoveParameters()

                Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.InputOutput, Funcion.IsNull(RolesDetalles.Rows(i)("IdDetalle"), 0))
                Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.Input, IdRol)
                Conn.AddParameter("Menu", SqlDbType.NVarChar, 500, ParameterDirection.Input, RolesDetalles.Rows(i)("Menu"))
                Conn.AddParameter("Activo", SqlDbType.Bit, 1, ParameterDirection.Input, RolesDetalles.Rows(i)("Activo"))
                Conn.AddParameter("Nombre", SqlDbType.NVarChar, 300, ParameterDirection.Input, RolesDetalles.Rows(i)("Nombre"))
                Conn.AddParameter("Tag", SqlDbType.NVarChar, 150, ParameterDirection.Input, RolesDetalles.Rows(i)("Tag"))
                Conn.AddParameter("Data", SqlDbType.Image, 0, ParameterDirection.Input, Nothing)
                Conn.EjecutarComando("Proc_RolesDetalle")

            Next
            Conn.CompletarTransaccion()
            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMessageBox.Show("Error : " & ex.Message, "", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
                MyBase.Finalize()
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class