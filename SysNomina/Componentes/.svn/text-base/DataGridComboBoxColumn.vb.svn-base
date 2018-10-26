Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DataGridTextBoxCombo
    Public Class DataGridComboBoxColumn


        Inherits DataGridTextBoxColumn
        Public WithEvents ColumnComboBox As ComboBox
        Private WithEvents _source As CurrencyManager
        Private _rowNum As Integer
        Private _isEditing As Boolean
        Private _valueChanging As ComboValueChanged

        Public Shared RowCount As Integer
        'Fields
        'Constructors
        'Events
        'Methods

        'Dim Articulos As New VB.SysContab.ArticulosDB()

        Shared Sub New()

        End Sub

        Private Sub ManejaScroll(ByVal sender As Object, ByVal e As EventArgs)
            If ColumnComboBox.Visible Then
                ColumnComboBox.Visible = False
            End If
        End Sub

        Public Sub New(ByVal valueChanging As ComboValueChanged)
            MyBase.New()
            _isEditing = False
            RowCount = -1
            _valueChanging = valueChanging
            ColumnComboBox = New ComboBox()
            AddHandler ColumnComboBox.Leave, New EventHandler(AddressOf LeaveComboBox)
            AddHandler ColumnComboBox.Enter, New EventHandler(AddressOf ComboMadeCurrent)
            AddHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)

        End Sub
        Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal readOnly1 As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)

            'on very first pass, set this static member to number of items in tables
            'check to see if we are on the new row
            If (RowCount = -(1)) Then
                RowCount = source.Count
            End If
            If (RowCount < source.Count) Then
                ' remove the one that has been added
                ' and add a new to sync 
                source.RemoveAt((source.Count - 1))
                source.AddNew()
            End If
            RowCount = source.Count
            MyBase.Edit(source, rowNum, bounds, readOnly1, instantText, cellIsVisible)
            _rowNum = rowNum
            _source = source
            ColumnComboBox.Parent = Me.TextBox.Parent
            ColumnComboBox.Location = Me.TextBox.Location
            ColumnComboBox.Size = New Size(Me.TextBox.Size.Width, ColumnComboBox.Size.Height)
            RemoveHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)
            ColumnComboBox.Text = Me.TextBox.Text
            AddHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)
            Me.TextBox.Visible = False
            ColumnComboBox.Visible = True
            ColumnComboBox.BringToFront()
            ColumnComboBox.Focus()

        End Sub
        Protected Overloads Overrides Function Commit(ByVal dataSource As CurrencyManager, ByVal rowNum As Integer) As Boolean

            If _isEditing Then
                _isEditing = False
                SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text)
            End If

            Return True

        End Function

        Private Sub ComboIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

            _valueChanging(_rowNum, ColumnComboBox.Text)

        End Sub

        Private Sub ComboMadeCurrent(ByVal sender As Object, ByVal e As EventArgs)

            _isEditing = True

        End Sub

        Private Sub LeaveComboBox(ByVal sender As Object, ByVal e As EventArgs)
            ''If Articulos.ArticulosBuscar(ColumnComboBox.Text).Tables("Articulos").Rows.Count = 0 Then
            ''    MsgBox("No existe el Producto o Servicio", MsgBoxStyle.Information)
            ''    'ColumnComboBox.Focus()
            ''    Exit Sub
            ''End If

            If _isEditing Then
                SetColumnValueAtRow(_source, _rowNum, ColumnComboBox.Text)
                _isEditing = False
                Invalidate()
            End If
            ColumnComboBox.Hide()

        End Sub

        Private Sub ColumnComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedValueChanged
            Indice = ColumnComboBox.SelectedIndex

        End Sub

        Private Sub ColumnComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedIndexChanged
            Indice = ColumnComboBox.SelectedIndex

        End Sub

        'Private Sub ColumnComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ColumnComboBox.KeyPress
        '    If Articulos.ArticulosBuscar(ColumnComboBox.Text).Tables("Articulos").Rows.Count = 0 Then
        '        MsgBox("No existe el Producto o Servicio", MsgBoxStyle.Information)
        '        e.Handled = True
        '        ColumnComboBox.Focus()
        '        Exit Sub
        '    End If
        'End Sub


       

    End Class

End Namespace
