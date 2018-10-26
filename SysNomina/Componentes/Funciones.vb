Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Module Funciones

    Enum Consultas
        Monedas
        Bancos
        TipoPrestamo
        PeriodoCapitalizacion
        Bodegas
        TipoInventario
        ClaseInventario
        UnidadesDeMedida
        TipoEmpaque
        Depositantes
        DetalleReciboImportacion
        DetalleReciboExportacion
        Productos
        Categorias
        RecibosDeBodega
        DetalleParaSalidas
        CIASeguro
        GruposTarifas
        Polizas
    End Enum

    Enum CalculadoraFinanciera
        ValorActual
        ValorFuturo
        VAN
        TIR
        TasaEfectiva
        AnualidadOrdinaria
    End Enum

    Public Function ObtieneDatos(ByVal StrSQL As String) As DataTable
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim DA As New SqlDataAdapter(StrSQL, DC)
        Dim DS As New DataTable
        DA.Fill(DS)
        Return DS
    End Function

    Public Function ObtieneData(ByVal StrSQL As String) As DataTable
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim DA As New SqlDataAdapter(StrSQL, DC)
        Dim DS As New DataTable
        DA.Fill(DS)
        Return DS
    End Function

    Public Function GuardaDatos(ByVal StrSQL As String) As Boolean
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Try
            '            Debug.WriteLine(StrSQL)
            Dim DCom As New SqlCommand(StrSQL, DC)
            DC.Open()
            DCom.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            DC.Close()
        End Try
    End Function

    Public Sub LimpiarControles(ByRef Forma As Object)
        On Error Resume Next
        For Each Con As Control In Forma.Controls
            If Con.HasChildren Then
                LimpiarControles(Con)
            End If
            For Each Cont As Control In Con.Controls
                If TypeOf Cont Is TextBox Then Cont.Text = vbNullString
                If TypeOf Cont Is DevExpress.XtraEditors.TextEdit Then
                    CType(Cont, DevExpress.XtraEditors.TextEdit).Text = Nothing
                    CType(Cont, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                End If
                If TypeOf Con Is ComboBox Then CType(Con, ComboBox).SelectedIndex = -1
                If TypeOf Cont Is DevExpress.XtraGrid.GridControl Then CType(Cont, DevExpress.XtraGrid.GridControl).DataSource = Nothing
                If TypeOf Con Is DevExpress.XtraEditors.LookUpEdit Then
                    CType(Con, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
                End If
            Next
        Next
    End Sub

    Public Sub VerificaCombos(ByRef Forma As Object)
        For Each Con As Control In Forma.Controls
            If Con.HasChildren Then
                VerificaCombos(Con)
            End If
            For Each Cont As Control In Con.Controls
                If TypeOf Con Is DevExpress.XtraEditors.LookUpEdit Then
                    CType(Con, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
                    If CType(Con, DevExpress.XtraEditors.LookUpEdit).IsPopupOpen Then
                        CType(Con, DevExpress.XtraEditors.LookUpEdit).ClosePopup()
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub GetBodegasList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneDatos(Consultas.Bodegas)
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.PopulateColumns()
        Combo.Properties.PopupWidth = 500
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetTipoBodegasList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneData("SELECT CAST(0 AS int) AS Codigo , 'Todas' as Nombre UNION ALL SELECT IdTipo as Codigo,Nombre FROM CodigoTipoBodega")
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.PopulateColumns()
        Combo.Properties.PopupWidth = 500
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetCategoriasList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneDatos(Consultas.Categorias)
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.PopulateColumns()
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetUnidadesMedidaList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneDatos(Consultas.UnidadesDeMedida)
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopulateColumns()
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetClientesList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneDatos(Consultas.Depositantes)
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.PopulateColumns()
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ShowFooter = False
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopupWidth = 500
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetClientesAll(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneData("SELECT 0 AS Codigo,'Todos' AS Nombre UNION ALL SELECT ClienteID AS Codigo, CASE WHEN Tipo=1 THEN Nombres + ' ' + Apellidos ELSE RazonSocial END as Nombre FROM CatalogoClientes ")
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.PopulateColumns()
        Combo.Properties.Columns("Codigo").Visible = False
        Combo.Properties.ShowFooter = False
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopupWidth = 500
        Combo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    End Sub

    Public Sub GetItemClientesList(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Combo.DataSource = ObtieneDatos(Consultas.Depositantes)
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Nombre"
        Combo.PopulateColumns()
        Combo.Columns("Codigo").Visible = False
        Combo.ShowFooter = False
        Combo.ForceInitialize()
    End Sub

    Public Sub GetTarifasList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = ObtieneDatos(Consultas.GruposTarifas)
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "Codigo"
        Combo.Properties.NullText = ""
        Combo.Properties.ShowHeader = False
        Combo.Properties.ShowFooter = False
        Combo.Properties.PopulateColumns()
        Combo.Properties.Columns("Codigo").Visible = False
    End Sub

    Public Sub GetTiposEmpaquesList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        With Combo.Properties
            .DataSource = ObtieneDatos(Consultas.TipoEmpaque)
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
            .ForceInitialize()
            .PopulateColumns()
            .Columns(0).Visible = False
            .AutoSearchColumnIndex = 1
        End With
    End Sub

    Public Sub GetTarifasClientes(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Combo.DataSource = ObtieneData("SELECT Nombre,IdTarifa,Tipo,Desde,Hasta FROM CodigoTarifas WHERE Activo = 1")
        Combo.PopulateColumns()
        Combo.ShowFooter = False
        Combo.Columns("IdTarifa").Visible = False
        Combo.Columns("Tipo").Visible = False
        Combo.DisplayMember = "Nombre"
        Combo.ValueMember = "IdTarifa"
        Combo.ForceInitialize()
        Combo.PopupWidth = 500
    End Sub

    Public Sub GetTarifasClientesFiscal(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Combo.DataSource = ObtieneData("SELECT Nombre,CodigoTarifa,Tipo,Desde,Hasta FROM CatalogoTarifas")
        Combo.PopulateColumns()
        Combo.ShowFooter = False
        Combo.Columns("CodigoTarifa").Visible = False
        Combo.Columns("Tipo").Visible = False
        Combo.DisplayMember = "Nombre"
        Combo.ValueMember = "CodigoTarifa"
        Combo.ForceInitialize()
        Combo.PopupWidth = 500
    End Sub

    Public Sub GetTarifasClientesGV(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit)
        Combo.DataSource = ObtieneData("SELECT Nombre,IdTarifa,Tipo,Desde,Hasta FROM CodigoTarifas WHERE Activo = 1")
        Combo.View.PopulateColumns()
        Combo.ShowFooter = False
        Combo.View.Columns("IdTarifa").Visible = False
        Combo.View.Columns("Tipo").Visible = False
        Combo.DisplayMember = "Nombre"
        Combo.ValueMember = "IdTarifa"
    End Sub

    Public Sub GetTarifasAll(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        With Combo.Properties
            .DataSource = ObtieneData("SPGetTarifasFactura " & 1)
            .PopulateColumns()
            .ShowFooter = False
            'Combo.Columns("IdTarifa").Visible = False
            .DisplayMember = "Nombre"
            .ValueMember = "IdTarifa"
            .ForceInitialize()
            .PopupWidth = 500
        End With
    End Sub

    Public Sub GetTarifasFactura(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Combo.DataSource = ObtieneData("SPGetTarifasFactura")
        Combo.PopulateColumns()
        Combo.ShowFooter = False
        'Combo.Columns("IdTarifa").Visible = False
        Combo.DisplayMember = "Nombre"
        Combo.ValueMember = "IdTarifa"
        Combo.ForceInitialize()
        Combo.PopupWidth = 500
    End Sub

    Public Sub GetTarifasBono(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        With Combo.Properties
            .DataSource = ObtieneData("SPGetTarifasBono")
            .ValueMember = "IdTarifa"
            .DisplayMember = "Nombre"
            .PopulateColumns()
            .Columns("IdTarifa").Visible = False
            .ShowFooter = False
        End With
    End Sub

    Public Sub GetFormaPagoList(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        With Combo.Properties
            .DataSource = ObtieneData("SPGetFormasPago")
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
            .PopulateColumns()
            .Columns("Codigo").Visible = False
            .ShowFooter = False
        End With
    End Sub

    Public Function ProcedureParameters(ByVal Parametros As ArrayList, ByVal Variables As ArrayList, ByVal Procedimiento As String) As DataTable
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure
        If Not Parametros Is Nothing Then
            Dim Parametro(Parametros.Count) As SqlParameter
            For i As Integer = 0 To Parametros.Count - 1
                Parametro(i) = New SqlParameter(Variables(i).ToString, TipoDatos(Parametros(i).GetType))
                Parametro(i).Value = Parametros(i)
                Command.Parameters.Add(Parametro(i))
            Next
        End If
        Try
            DC.Open()
            Command.CommandTimeout = 0
            Dim DA As New SqlDataAdapter(Command)
            DA.Fill(DT)
        Catch ex As Exception
            MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical)
        Finally
            DC.Close()
        End Try
        Return DT
    End Function

    Function TipoDatos(ByVal Value As Type) As SqlDbType
        Select Case Value.Name
            Case "String" : Return SqlDbType.NVarChar
            Case "Int32" : Return SqlDbType.Int
            Case "Double" : Return SqlDbType.Money
            Case "Decimal" : Return SqlDbType.Money
            Case "DateTime" : Return SqlDbType.SmallDateTime
            Case "Boolean" : Return SqlDbType.Bit
        End Select
    End Function

    Public Function ProcedureSave(ByVal Parametros As ArrayList, ByVal Variables As ArrayList, ByVal Procedimiento As String) As Boolean
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure
        Dim Parametro(Parametros.Count) As SqlParameter
        For i As Integer = 0 To Parametros.Count - 1
            Parametro(i) = New SqlParameter(Variables(i).ToString, TipoDatos(Parametros(i).GetType))
            Parametro(i).Value = Parametros(i)
            Command.Parameters.Add(Parametro(i))
        Next
        Try
            DC.Open()
            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            DC.Close()
        End Try
    End Function

    Public Function Letras(ByVal tyCantidad As Double, ByVal Moneda As Boolean) As String

        Dim i As Integer
        Dim lyCantidad As Double, lyCentavos As Double, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero
        'Redondea el valor a dos coma flotante
        tyCantidad = Math.Round(tyCantidad, 2)
        'Redondea el valor sin coma flotante
        lyCantidad = Int(tyCantidad)
        'Nos determina la cantidad de centavos
        lyCentavos = (tyCantidad - lyCantidad) * 100
        Letras = vbNullString
        '  string data [] = new string [] { "a", "b", "c", "d", "e" };

        Dim laUnidades() As String = {"Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}


        'Arreglo que nos determina las unidades de los numeros llega hasta veintinueve porque de ahi en adelante los numeros son iguales
        '  laUnidades = Array("Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesisiete", "Diesiocho", "Diesinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve")
        'Arreglo que nos determina las decenas de los numeros
        Dim laDecenas() As String = {"Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"}
        'Arreglo que nos determina las centenas de los numeros
        Dim laCentenas() As String = {"Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
        'Nos indica los bloques de tres que se peocesan. Inicialmente es uno. Unidades, decenas y centenas.
        lnNumeroBloques = 1

        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0

            'Ciclo for que nos determina con cada ciclo las unidades (1) decenas (2) centenas (3)
            For i = 1 To 3
                'lnDigito toma el residuo de lyCantidad dividido entre diez
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            'Asigna nombre a las unidades. i vale una indicando que son unidades
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", System.DBNull.Value) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "Cien", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    Letras = lcBloque
                Case 2
                    Letras = lcBloque & IIf(lnBloqueCero = 3, System.DBNull.Value, " Mil") & Letras
                Case 3
                    Letras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " Millon", " Millones") & Letras
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        'No escribe la cadena final de la conversion con la cantida de centavos si existen

        Letras = (Letras & IIf(tyCantidad > 1, IIf(Moneda, " Cordobas ", " dias "), IIf(Moneda, " Cordoba ", " dia ")) & IIf(Moneda, " Con " & CInt(lyCentavos) & "/100", "")).ToString '.ToUpper
        'Format(Str(lyCentavos), "00")
    End Function

    Public Function CalculoFinanciero(ByVal Interes As Double, ByVal Flujo() As Double, ByVal Monto As Double, ByVal Plazo As Double, ByVal Calculo As CalculadoraFinanciera)
        Dim Intereses As Double = ((Interes / 100) / 4)
        Select Case Calculo
            Case CalculadoraFinanciera.VAN : Return Format((Financial.NPV(IIf(Interes > 0, Interes / 100, Interes), Flujo)) + (Monto * -1), "n2")
            Case CalculadoraFinanciera.TIR : Return (Format((Financial.IRR(Flujo)), "p"))
            Case CalculadoraFinanciera.ValorFuturo : Return Format((Financial.FV(IIf(Interes > 0, Interes / 100, Interes) / 12, Plazo, -Monto, 0, DueDate.BegOfPeriod)), "n2")
            Case CalculadoraFinanciera.ValorActual : Return Format((Financial.PV(IIf(Interes > 0, Interes / 100, Interes) / 12, Plazo, Monto, 0, DueDate.EndOfPeriod)), "n2")
            Case CalculadoraFinanciera.TasaEfectiva : Return Format((Math.Pow((1 + (Interes / 100)), Plazo) - 1) / 100, "p")
            Case CalculadoraFinanciera.AnualidadOrdinaria : Return Format(Monto * ((Math.Pow((1 + Intereses), -Plazo)) / Intereses), "n2")
            Case Else : Return 0
        End Select
    End Function

    Public Function IsNull(ByVal Var, Optional ByVal Valor = vbNullString)
        If IsDBNull(Var) OrElse IsNothing(Var) OrElse Var = vbNullString OrElse Var = Nothing Then
            Return IIf(IsNothing(Valor), "", Valor)
        Else
            Return Var
        End If
    End Function

    Public Function IsDataNull(ByVal Var, Optional ByVal Valor = vbNullString)
        If IsDBNull(Var) OrElse Var = Nothing Then
            Return IIf(IsNothing(Valor), "", Valor)
        Else
            Return Var
        End If
    End Function

    Public Function Letras(ByVal tyCantidad As Double, ByVal Sigla As String, ByVal Moneda As Boolean) As String
        Letras = vbNullString
        Dim i As Integer
        Dim lyCantidad As Double, lyCentavos As Double, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero
        'Redondea el valor a dos coma flotante
        tyCantidad = Math.Round(tyCantidad, 2)
        'Redondea el valor sin coma flotante
        lyCantidad = Int(tyCantidad)
        'Nos determina la cantidad de centavos
        lyCentavos = (tyCantidad - lyCantidad) * 100

        '  string data [] = new string [] { "a", "b", "c", "d", "e" };

        Dim laUnidades() As String = {"Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}


        'Arreglo que nos determina las unidades de los numeros llega hasta veintinueve porque de ahi en adelante los numeros son iguales
        '  laUnidades = Array("Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesisiete", "Diesiocho", "Diesinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve")
        'Arreglo que nos determina las decenas de los numeros
        Dim laDecenas() As String = {"Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"}
        'Arreglo que nos determina las centenas de los numeros
        Dim laCentenas() As String = {"Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
        'Nos indica los bloques de tres que se peocesan. Inicialmente es uno. Unidades, decenas y centenas.
        lnNumeroBloques = 1

        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0

            'Ciclo for que nos determina con cada ciclo las unidades (1) decenas (2) centenas (3)
            For i = 1 To 3
                'lnDigito toma el residuo de lyCantidad dividido entre diez
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            'Asigna nombre a las unidades. i vale una indicando que son unidades
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", System.DBNull.Value) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "Cien", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    Letras = lcBloque
                Case 2
                    Letras = lcBloque & IIf(lnBloqueCero = 3, System.DBNull.Value, " Mil") & Letras
                Case 3
                    Letras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " Millon", " Millones") & Letras
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        'No escribe la cadena final de la conversion con la cantida de centavos si existen
        'Letras = (Letras & IIf(tyCantidad > 1, " Cordobas ", " Cordoba ") & " CON " & CInt(lyCentavos) & "/100").ToString.ToUpper
        Letras = (Letras & " " & IIf(Moneda, "", IIf(CInt(lyCentavos) > 0, "Punto " & CInt(lyCentavos), "")) & " " & Sigla & IIf(Moneda, " Con " & CInt(lyCentavos) & "/100", "")).ToString
        'Format(Str(lyCentavos), "00")
    End Function

    Public Sub FormatRepository(ByRef Combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        With Combo
            .ShowFooter = False
            .ShowHeader = False
            .PopulateColumns()
        End With
    End Sub

    Public Sub ImprimeDiseño(ByVal Tipo As Integer)
        Dim Cadena As String
        Try
            Dim Data() As Byte = CType(ObtieneData("SELECT constancia FROM Constancia WHERE idconstancia = " & Tipo & " and empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\Reporte.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Function Decimales(ByVal Valor As Double) As Double
        Return CDbl(FormatNumber(Valor, 2))
    End Function

    Public Sub FormatoGrid(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView)
        For i As Integer = 0 To Grid.Columns.Count - 1
            Grid.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Grid.Columns(i).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Grid.Columns(i).AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8, FontStyle.Bold)
        Next
    End Sub

    Public Function TasaCambio(ByVal Fecha As Date, ByVal Moneda As String) As Double
        Dim DC As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim Command As New SqlCommand("SPGetTasa", DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure
        Dim VFecha As SqlParameter
        Dim VMoneda As SqlParameter
        Dim VValor As SqlParameter

        VFecha = New SqlParameter("Fecha", SqlDbType.SmallDateTime)
        VFecha.Value = Fecha
        VMoneda = New SqlParameter("Moneda", SqlDbType.NVarChar)
        VMoneda.Value = Moneda
        VValor = New SqlParameter("Valor", SqlDbType.Money)
        VValor.Direction = ParameterDirection.Output

        Command.Parameters.Add(VFecha)
        Command.Parameters.Add(VMoneda)
        Command.Parameters.Add(VValor)

        Try
            DC.Open()
            Dim DA As New SqlDataAdapter(Command)
            DA.Fill(DT)
        Catch ex As Exception
            MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical)
        Finally
            DC.Close()
        End Try

        Return VValor.Value

    End Function


    Public Function FillDatasetFromGrid(ByVal Data As DataSet, ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView) As DataSet
        Dim rowHandle As Integer
        Dim gridRow As DataRow
        Dim i As Integer = 0
        Do While i < Grid.RowCount
            rowHandle = Grid.GetVisibleRowHandle(i)
            If (Not Grid.IsGroupRow(rowHandle)) Then
                gridRow = Grid.GetDataRow(rowHandle)
                Data.Tables(0).Rows.Add(gridRow.ItemArray)
            End If
            i += 1
        Loop
        Return Data
    End Function

    Public Function GetVersion(ByVal ProductoVersion As String) As String
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim ver As Version
            ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            Return My.Application.Info.ProductName.ToString & ". Publicación v" & String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision)
        Else
            Return My.Application.Info.ProductName.ToString & ". Publicación v" & ProductoVersion
        End If
    End Function

    Sub ShowSplash(Optional ByVal sTitulo As String = "")
        Try
            If sTitulo <> "" Then WaitTitulo = sTitulo
            If sTitulo = "" Then WaitTitulo = "Cargando..."
            SplashScreenManager.ShowForm(GetType(WaitForm))
        Catch ex As Exception
        End Try

    End Sub

    Sub HideSplash()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception
        End Try

    End Sub

    Public Sub XtraMsg(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
                      Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, _
                      Optional ByVal Titulo As String = "")

        XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono)
    End Sub

    Public Function XtraMsg2(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Question, _
                                Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.YesNo, _
                                Optional ByVal Titulo As String = "") As Boolean

        If XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
