Imports Clases
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList.Nodes
Imports System.Reflection
Imports DevExpress.XtraLayout

Public Class FrmAgregarRol

    Public M As Ribbon.RibbonControl
    Private Nuevo As Boolean = False
    Private Elimina As Boolean
    Private Procedimiento As String
    Private IdRol As Integer
    Private Temp As Boolean = False
    Private DT As New DataTable("Menu")
    Private Carga As Boolean = False
    Private Rol As New RolesCLS
    Private Data As DataTable = Nothing

    Private Sub FrmAgregarRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se debe pasar el ribon en la llamada
        'M = Global.StS.Nomina.frmPrincipal.RibbonControl
        GetData()
    End Sub

    Private Sub GetData()
        DT = Rol.ListDetalles(0)
        Tree.DataSource = Nothing
        Tree.DataSource = DT
        CrearArbol()
        Carga = True
        GridDetalle.DataSource = Rol.List

    End Sub

    Private Sub CrearArbol()
        For Each Pagina As Ribbon.RibbonPage In M.Pages
            Dim NPagina As TreeListNode = Tree.AppendNode(Nothing, -1)
            NPagina.ImageIndex = 0
            NPagina.SelectImageIndex = 0
            NPagina.Item(Tree.Columns("Menu")) = Pagina.Text
            NPagina.Item(Tree.Columns("Nombre")) = Pagina.Name
            NPagina.Item(Tree.Columns("Activo")) = 0
            Tree.FocusedNode = NPagina
            For Each Grupo As Ribbon.RibbonPageGroup In Pagina.Groups
                If Not Tree.FocusedNode Is Nothing Then
                    Dim NGrupo As TreeListNode = Tree.AppendNode(Nothing, NPagina)
                    NGrupo.ImageIndex = 1
                    NGrupo.SelectImageIndex = 1
                    NGrupo.Item(Tree.Columns("Menu")) = Grupo.Text
                    NGrupo.Item(Tree.Columns("Nombre")) = Grupo.Name
                    NGrupo.Item(Tree.Columns("Activo")) = 0
                    Tree.FocusedNode = NGrupo
                    For Each Opcion As Object In Grupo.ItemLinks
                        If TypeOf Opcion Is BarButtonItemLink Then
                            If Not Tree.FocusedNode Is Nothing Then
                                Dim NOpcion As TreeListNode = Tree.AppendNode(Nothing, NGrupo)
                                NOpcion.ImageIndex = 2
                                NOpcion.SelectImageIndex = 2
                                NOpcion.Item(Tree.Columns("Menu")) = Opcion.Caption
                                NOpcion.Item(Tree.Columns("Nombre")) = CType(Opcion, BarButtonItemLink).Item.Name
                                NOpcion.Item(Tree.Columns("Activo")) = 0
                                NOpcion.Item(Tree.Columns("Tag")) = CType(Opcion, BarButtonItemLink).Item.Tag
                                Tree.FocusedNode = NOpcion
                                Try
                                    Dim Forma As DevExpress.XtraEditors.XtraForm = [Assembly].GetEntryAssembly.CreateInstance([Assembly].GetEntryAssembly.GetName.Name + "." + CType(Opcion, BarButtonItemLink).Item.Tag)
                                    For Each Con As Control In Forma.Controls
                                        ControlDetalle(Con, NOpcion)
                                    Next
                                Catch ex As Exception

                                End Try
                            End If
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub ControlDetalle(ByRef Con As Control, ByRef Nodo As TreeListNode)
        On Error Resume Next
        If Con.HasChildren Then
            For Each Cont As Control In Con.Controls
                ControlDetalle(Cont, Nodo)
            Next
        End If
        If TypeOf Con Is DevExpress.XtraEditors.SimpleButton And Con.Tag <> Nothing Then
            Dim NBoton As TreeListNode = Tree.AppendNode(Nothing, Nodo)
            NBoton.ImageIndex = 3
            NBoton.SelectImageIndex = 3
            NBoton.Item(Tree.Columns("Menu")) = Con.Text.Replace("&", "")
            NBoton.Item(Tree.Columns("Nombre")) = Con.Name
            NBoton.Item(Tree.Columns("Activo")) = 0
            NBoton.Item(Tree.Columns("Tag")) = Con.Tag
            Tree.FocusedNode = NBoton
        End If
    End Sub

    Public Sub Mostrar(ByRef Menus As Ribbon.RibbonControl)
        M = Menus
        Me.Show()
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        IdRol = 0
        Nuevo = True
        Elimina = False
        cmdguardar.Enabled = True
        cmdeditar.Enabled = False
        txtdescripcion.Enabled = True
        txtnombre.Enabled = True
        txtnombre.Text = Nothing
        txtdescripcion.Text = Nothing
        Tree.Enabled = True
        txtnombre.Focus()
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        Carga = False
        Rol.Nombre = txtnombre.Text
        Rol.Descripcion = txtdescripcion.Text
        If Rol.Save(DT) Then
            Rol.Dispose()
            Tree.Enabled = False
            cmdeditar.Enabled = False
            cmdnuevo.Enabled = True
            cmdguardar.Enabled = False
            txtnombre.Text = Nothing
            txtdescripcion.Text = Nothing
            IdRol = 0
            GetData()
        End If
        Carga = True
    End Sub

    Private Sub GridDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDetalle.Click
        If GridView1.DataRowCount = 0 Then
            Exit Sub
        End If
        cmdeditar.Enabled = True
    End Sub

    Private Sub CargaRol()
        Carga = False
        Data = Nothing
        Data = Rol.ListDetalles(IdRol)
        For i As Integer = 0 To Data.Rows.Count - 1
            If Not IsDBNull(Data.Rows(i)("Data")) Then
                'Funcion.DBFileToFile(Data.Rows(i)("Data"), "XML\xml_" & Data.Rows(i)("Nombre") & ".xml")
                Data.Rows(i)("Name") = My.Application.Info.DirectoryPath & "\XML\xml_" & Data.Rows(i)("Nombre") & ".xml"
            End If
        Next
        For Each Nodo As TreeListNode In Tree.Nodes
            For i As Integer = 0 To Data.Rows.Count - 1
                If Nodo.Item("Nombre") = Data.Rows(i)("Nombre") Then
                    Nodo.Checked = Data.Rows(i)("Activo")
                    Nodo.Item("Activo") = Data.Rows(i)("Activo")
                    Nodo.Item("IdDetalle") = Data.Rows(i)("IdDetalle")
                    Nodo.Item("Name") = Data.Rows(i)("Name")
                End If
            Next
            BuscarNodosHijos(Nodo)
        Next
        Carga = True
    End Sub

    Private Sub BuscarNodosHijos(ByVal node As TreeListNode)
        ', Data.Rows(i)("Activo"), Data.Rows(i)("Nombre"), Data.Rows(i)("IdDetalle")
        For i As Integer = 0 To node.Nodes.Count - 1
            For j As Integer = 0 To Data.Rows.Count - 1
                If node.Nodes(i).Item("Nombre") = Data.Rows(j)("Nombre") Then
                    node.Nodes(i).Checked = Data.Rows(j)("Activo")
                    node.Nodes(i).Item("IdDetalle") = Data.Rows(j)("IdDetalle")
                    node.Nodes(i).Item("Activo") = Data.Rows(j)("Activo")
                    node.Nodes(i).Item("Name") = Data.Rows(j)("Name")
                End If
            Next
            BuscarNodosHijos(node.Nodes(i))
        Next
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeditar.Click
        Try
            Dim fila As DataRow
            fila = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            txtnombre.Text = fila.Item("Nombre")
            txtdescripcion.Text = fila.Item("Descripcion")
            IdRol = fila.Item("IdRol")
            CargaRol()
        Catch ex As Exception

        End Try

        cmdguardar.Enabled = True
        txtnombre.Enabled = True
        txtdescripcion.Enabled = True
        Tree.Enabled = True
        Nuevo = False

    End Sub

    Private Sub Tree_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles Tree.FocusedNodeChanged
        
    End Sub

    Private Sub Tree_AfterCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles Tree.AfterCheckNode
        e.Node.Item("Activo") = e.Node.CheckState
        SetCheckedChildNodes(e.Node, e.Node.CheckState)
        SetCheckedParentNodes(e.Node, e.Node.CheckState)
    End Sub


    Private Sub SetCheckedChildNodes(ByVal node As TreeListNode, ByVal check As CheckState)
        For i As Integer = 0 To node.Nodes.Count - 1
            node.Nodes(i).CheckState = check
            node.Nodes(i).Item("Activo") = check
            SetCheckedChildNodes(node.Nodes(i), check)
        Next
    End Sub

    Private Sub SetCheckedParentNodes(ByVal node As TreeListNode, ByVal check As CheckState)
        If Not IsNothing(node.ParentNode) Then
            Dim b As Boolean = False
            Dim state As CheckState
            For i As Integer = 0 To node.ParentNode.Nodes.Count - 1
                state = node.ParentNode.Nodes(i).CheckState
                If Not check.Equals(state) Then
                    b = Not b
                    Exit For
                End If
            Next
            node.ParentNode.CheckState = IIf(b, CheckState.Checked, check)
            node.ParentNode.Item("Activo") = IIf(b, CheckState.Checked, check)
            SetCheckedParentNodes(node.ParentNode, check)
        End If
    End Sub

End Class