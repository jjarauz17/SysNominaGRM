Imports DevExpress.XtraTreeList.Nodes
Public Class frmOrganigrama
#Region "Variables"
    Dim Cargado As Boolean = False
#End Region
    Private Sub frmOrganigrama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
        Cargado = True
    End Sub

    Private Sub cargar()

        Me.cbDebitos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.cbDebitos.DisplayMember = "Nombre"
        Me.cbDebitos.ValueMember = "Cuenta"

        Me.cbCreditos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.cbCreditos.DisplayMember = "Nombre"
        Me.cbCreditos.ValueMember = "Cuenta"

        Me.cbGastos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Rubros(False)
        Me.cbGastos.DisplayMember = "Nombre"
        Me.cbGastos.ValueMember = "Rubro"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.Lista_Combo("0")
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.Arbol.DataSource = VB.SysContab.RH_OrganigramaDB.Listar()
        Me.Arbol.KeyFieldName = "org_codigo"
        Me.Arbol.ParentFieldName = "org_padre"
        Me.Arbol.BestFitColumns()
        Me.Arbol.Columns("org_descripcion").Caption = "Centro de Costo"
        Me.Arbol.Columns("org_sufijo").Visible = True
        Me.Arbol.Columns("org_sufijo").Caption = "Prefijo Contable"
        Me.Arbol.Columns("empr_codigo").Visible = False
        Me.Arbol.Columns("emp_codigo").ColumnEdit = Me.cbEmpleados
        Me.Arbol.Columns("emp_codigo").Visible = False
        Me.Arbol.Columns("org_email").Visible = False
        Me.Arbol.Columns("org_nivel").Visible = False
        Me.Arbol.Columns("org_activo").Visible = False
        Me.Arbol.Columns("org_path").Visible = False

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        Dim parentNode As TreeListNode = Arbol.FocusedNode
        If parentNode Is Nothing Then
            Exit Sub
        End If
        If parentNode.GetValue("org_descripcion") Is DBNull.Value Then
            Exit Sub
        End If
        If parentNode.GetValue("org_descripcion") = "" Then
            Exit Sub
        End If

        Dim newNode As TreeListNode = Arbol.AppendNode(New Object() {""}, parentNode)
        Arbol.SetNodeIndex(newNode, parentNode.Nodes.Count - 1)
        parentNode.Expanded = True
        Arbol.FocusedNode = newNode
        If parentNode.GetValue("org_codigo") Is DBNull.Value Then
        Else
            Arbol.FocusedNode.SetValue("org_padre", parentNode.GetValue("org_codigo"))
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim Node As TreeListNode = Arbol.FocusedNode
        If Node Is Nothing Then
            Exit Sub
        End If
        Arbol.DeleteNode(Node)
    End Sub

    Private Sub TreeList1_AfterFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles Arbol.AfterFocusNode
        If Me.Arbol.FocusedNode.GetValue("org_codigo") Is DBNull.Value Then
            Exit Sub
        End If
        Me.GridControl1.DataSource = VB.SysContab.RH_OrganigramaDB.Plantilla(Me.Arbol.FocusedNode.GetValue("org_codigo"))
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("rub_codigo").Caption = "Código"
        Me.vLista.Columns("rub_tipo").Caption = "Tipo de Movimiento"
        Me.vLista.Columns("rub_descripcion").Caption = "Descripción"
        Me.vLista.Columns("org_codigo").Visible = False
        Me.vLista.Columns("rub_cuentadebito").ColumnEdit = Me.cbDebitos
        Me.vLista.Columns("rub_cuentadebito").Caption = "Cuenta Débito"
        Me.vLista.Columns("rub_cuentacredito").ColumnEdit = Me.cbCreditos
        Me.vLista.Columns("rub_cuentacredito").Caption = "Cuenta Crédito"
        Me.vLista.Columns("rub_gasto").ColumnEdit = Me.cbGastos
        Me.vLista.Columns("rub_gasto").Caption = "Rubro Gastos"
        For i As Integer = 0 To Me.vLista.Columns.Count - 1
            If Me.vLista.Columns(i).FieldName = "rub_cuentadebito" Or Me.vLista.Columns(i).FieldName = "rub_cuentacredito" Or Me.vLista.Columns(i).FieldName = "rub_gasto" Then
                Me.vLista.Columns(i).OptionsColumn.ReadOnly = False
                Me.vLista.Columns(i).OptionsColumn.AllowFocus = True
            Else
                Me.vLista.Columns(i).OptionsColumn.ReadOnly = True
                Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
            End If

        Next

    End Sub

    Private Sub TreeList1_BeforeFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeFocusNodeEventArgs) Handles Arbol.BeforeFocusNode
        If Cargado = True Then
            If e.OldNode Is Nothing Then
                Exit Sub
            End If
            If e.OldNode.GetValue("org_descripcion") Is DBNull.Value Then
                e.CanFocus = False
            Else : e.CanFocus = True
            End If
        End If
    End Sub

    Private Sub TreeList1_ValidateNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.ValidateNodeEventArgs) Handles Arbol.ValidateNode
        Dim cadena As String
        cadena = sender.focusednode.getvalue("org_descripcion")
        If cadena Is DBNull.Value Or cadena = "" Then
            e.ErrorText = "Debe describir el elemento del organigrama"
            e.Valid = False
        End If
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click

        'Procesar los borrados
        Dim dt As DataTable
        dt = Me.Arbol.DataSource.getchanges(DataRowState.Deleted)
        If Not dt Is Nothing Then
            dt.RejectChanges()

            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("org_codigo") Is DBNull.Value Then
                Else
                    VB.SysContab.RH_OrganigramaDB.Borrar(dt.Rows(i)("org_codigo"))
                End If
            Next
            dt.Dispose()
        End If
        Dim _Arbol As TreeListNode
        _Arbol = Arbol.Nodes(0)
        For i As Integer = 0 To _Arbol.Nodes.Count - 1
            Me.guardar(_Arbol.Nodes(i), _
                IIf(_Arbol.Nodes(i).Level = 1, 0, _
                _Arbol.Nodes(i).GetValue("org_codigo")), "")
        Next

        cargar()

    End Sub

    Private Sub guardar(ByRef Nodo As TreeListNode, ByVal Padre As Integer, ByVal Camino As String)
        'Procesar el actual

        Camino = Camino + IIf(Padre = 0, "", ",") + Padre.ToString
        If Not Nodo.GetValue("org_codigo") Is DBNull.Value Then
            VB.SysContab.RH_OrganigramaDB.Modificar(Nodo.GetValue("org_codigo"), _
                Padre, _
                Nodo.GetValue("org_descripcion").ToString, _
                Nodo.GetValue("emp_codigo").ToString, _
                Nodo.GetValue("org_email").ToString, _
                Camino, _
                Nodo.GetValue("org_sufijo").ToString)
        Else
            Nodo.SetValue("org_codigo", _
                VB.SysContab.RH_OrganigramaDB.Agregar(Padre, _
                            Nodo.GetValue("org_descripcion"), _
                            Nodo.GetValue("emp_codigo").ToString, _
                            Nodo.GetValue("org_email").ToString, _
                            Camino, Nodo.GetValue("org_sufijo").ToString))
        End If
        Padre = Nodo.GetValue("org_codigo")
        For i As Integer = 0 To Nodo.Nodes.Count - 1
            guardar(Nodo.Nodes(i), Padre, Camino)
        Next
        Nodo.SetValue("org_padre", Padre)
    End Sub


    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        For i As Integer = 0 To Me.vLista.DataRowCount - 1

            VB.SysContab.RH_OrganigramaDB.Plantilla_Add(Me.Arbol.FocusedNode.GetValue("org_codigo"), _
             Me.vLista.GetRowCellValue(i, "rub_codigo"), _
             Me.vLista.GetRowCellValue(i, "rub_tipo"), _
             Me.vLista.GetRowCellValue(i, "rub_cuentadebito"), _
             Me.vLista.GetRowCellValue(i, "rub_cuentacredito"), _
             Me.vLista.GetRowCellValue(i, "rub_gasto"))

        Next
    End Sub

    Private Sub cmdLimpiarPlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiarPlantilla.Click

    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Dim f As New frmComprobante
        f.ShowDialog()
    End Sub

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim f As New frmPlantillaDetalle
        f.TRubro = Me.vLista.GetFocusedRowCellValue("rub_tipo")
        f.Rubro = Me.vLista.GetFocusedRowCellValue("rub_codigo")

        f.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

        Dim dt As New DataTable
        dt = VB.SysContab.RH_OrganigramaDB.RH_Organigrama_Importar()


        arbolimportado.datasource = dt
        arbolimportado.keyfieldname = "idsubcentro"
        arbolimportado.parentfieldname = "padre"

        Dim _arbol As TreeListNode
        _arbol = arbolimportado.nodes(0)
        For i As Integer = 0 To _arbol.Nodes.Count - 1
            Me.Importar(_arbol.Nodes(i))
        Next
        cargar()
    End Sub

    Private Sub Importar(ByRef Nodo As TreeListNode)
        VB.SysContab.RH_OrganigramaDB.RH_Organigrama_ImportarAdd(Nodo.GetValue("idsubcentro"), _
                Nodo.GetValue("padre"), Nodo.GetValue("nombre"))
        For i As Integer = 0 To Nodo.Nodes.Count - 1
            Importar(Nodo.Nodes(i))
        Next

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        frmExportarImprimir.Mostrar(GridControl1)
    End Sub
End Class