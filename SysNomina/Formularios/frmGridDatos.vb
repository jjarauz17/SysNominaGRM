Imports DbConnect
Imports System.IO
Public Class frmGridDatos
    Public Origen As DataSet
    Private Titulo As String = ""

    Private Sub frmGridDatos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ContextMenuStrip1.Items("cmImprimir").Visible = False
        If Origen Is Nothing Then
            MsgBox("No se puede ver el detalle debido a que no se paso ninguna tabla al formulario", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Origen.Tables.Count <> 1 Then
            MsgBox("No se puede ver el detalle debido a que no se paso ninguna tabla al formulario", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Me.PGDatos.DataSource = Origen.Tables(0)
        'Origen.WriteXml("C:\test.xml", XmlWriteMode.WriteSchema)
        If Origen.Tables(0).TableName = "RH_Deglose" Then
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Titulo = "Deglose de Monedas"
            Me.PGDatos.Visible = True
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            PGDatos.OptionsView.ShowDataHeaders = True
            PGDatos.OptionsView.ShowColumnHeaders = True
            PGDatos.OptionsView.ShowColumnGrandTotals = False



            PGDatos.Fields.Add("pago", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("pago").Caption = "Forma Pago"

            PGDatos.Fields.Add("denominacion", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("denominacion").Caption = "Denominacion"

            PGDatos.Fields.Add("localidad", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("localidad").Caption = "Localidad"

            PGDatos.Fields.Add("departamento", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("departamento").Caption = "Departamento"

            PGDatos.Fields.Add("area", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("area").Caption = "Area"

            PGDatos.Fields.Add("codigo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("codigo").Caption = "Codigo"

            PGDatos.Fields.Add("nombre", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("nombre").Caption = "Nombre"

            PGDatos.Fields.Add("valor", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("valor").Caption = "Valor"
            PGDatos.Fields("valor").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PGDatos.Fields("valor").CellFormat.FormatString = "n2"

            PGDatos.Fields.Add("descripcion", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("descripcion").Caption = "Descripcion"


        ElseIf Origen.Tables(0).TableName = "Planilla_Consolidado" Then
            Me.LCAcciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Titulo = "Consolidado de Planilla"
            Me.PGDatos.Visible = True
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            PGDatos.OptionsView.ShowDataHeaders = True
            PGDatos.OptionsView.ShowColumnHeaders = True
            PGDatos.OptionsView.ShowColumnGrandTotals = False

            PGDatos.Fields.Add("Forma Pago", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Forma Pago").FieldName = "Forma Pago"
            PGDatos.Fields("Forma Pago").Width = 250

            PGDatos.Fields.Add("depnombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("depnombre").FieldName = "depnombre"
            PGDatos.Fields("depnombre").Caption = "Departamento"

            PGDatos.Fields.Add("Nombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Nombre").FieldName = "Nombre"
            PGDatos.Fields("Nombre").Width = 250

            PGDatos.Fields.Add("NombreINSS", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("NombreINSS").FieldName = "NombreINSS"
            PGDatos.Fields("NombreINSS").Width = 125

            PGDatos.Fields.Add("arenombre", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("arenombre").FieldName = "arenombre"
            PGDatos.Fields("arenombre").Caption = "Area"
            PGDatos.Fields("arenombre").Width = 125

            PGDatos.Fields.Add("Localidad", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Localidad").FieldName = "Localidad"
            PGDatos.Fields("Localidad").Width = 125

            PGDatos.Fields.Add("emp_codigo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("emp_codigo").FieldName = "emp_codigo"
            PGDatos.Fields("emp_codigo").Caption = "Código"
            PGDatos.Fields("emp_codigo").Width = 125

            PGDatos.Fields.Add("INSS", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("INSS").FieldName = "INSS"
            PGDatos.Fields("INSS").Width = 125


            PGDatos.Fields.Add("Cedula", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cedula").FieldName = "Cedula"
            PGDatos.Fields("Cedula").Width = 125

            PGDatos.Fields.Add("Salario Fijo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Salario Fijo").FieldName = "Salario Fijo"
            PGDatos.Fields("Salario Fijo").Width = 50

            PGDatos.Fields.Add("Forma Pago", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Forma Pago").FieldName = "Forma Pago"
            PGDatos.Fields("Forma Pago").Width = 50

            PGDatos.Fields.Add("Cargo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cargo").FieldName = "Cargo"
            PGDatos.Fields("Cargo").Width = 125

            PGDatos.Fields.Add("rTipo", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("rTipo").FieldName = "rTipo"
            PGDatos.Fields("rTipo").Caption = "Tipo"

            PGDatos.Fields.Add("R", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("R").FieldName = "R"
            PGDatos.Fields("R").Caption = "Rubros"

            PGDatos.Fields.Add("xCodigo", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("xCodigo").FieldName = "xCodigo"
            PGDatos.Fields("xCodigo").Caption = "Codigo Rubro"

            PGDatos.Fields.Add("descripcion", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("descripcion").FieldName = "descripcion"
            PGDatos.Fields("descripcion").Caption = "Rubro"

            PGDatos.Fields.Add("valor", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("valor").FieldName = "valor"
            PGDatos.Fields("valor").Caption = "Monto"
            PGDatos.Fields("valor").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PGDatos.Fields("valor").CellFormat.FormatString = "n2"

            For i As Integer = 0 To Origen.Tables(0).Columns.Count - 1
                If Origen.Tables(0).Columns(i).ColumnName.ToUpper = "CE" Then
                    For j As Integer = i + 1 To Origen.Tables(0).Columns.Count - 1
                        PGDatos.Fields.Add(Origen.Tables(0).Columns(j).ColumnName, DevExpress.XtraPivotGrid.PivotArea.FilterArea)
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).FieldName = Origen.Tables(0).Columns(j).ColumnName
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).Caption = Origen.Tables(0).Columns(j).ColumnName
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).Visible = False
                    Next
                    Exit For
                End If
            Next


            Me.chkSelector.Checked = False

        ElseIf Origen.Tables(0).TableName = "Planilla_Consolidado_RH" Then
            Titulo = "Consolidado de Planilla + Liquidaciones"
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.cbMeses.Visible = False
            Me.PGDatos.Visible = True
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never


            PGDatos.OptionsView.ShowDataHeaders = True
            PGDatos.OptionsView.ShowColumnHeaders = True

            PGDatos.Fields.Add("Forma Pago", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Forma Pago").FieldName = "Forma Pago"
            PGDatos.Fields("Forma Pago").Width = 250

            PGDatos.Fields.Add("Departamento", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Departamento").FieldName = "Departamento"
            PGDatos.Fields("Departamento").Caption = "Departamento"

            PGDatos.Fields.Add("Nombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Nombre").FieldName = "Nombre"
            PGDatos.Fields("Nombre").Width = 250

            PGDatos.Fields.Add("NombreINSS", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("NombreINSS").FieldName = "NombreINSS"
            PGDatos.Fields("NombreINSS").Width = 125
            PGDatos.Fields("NombreINSS").Options.ShowInCustomizationForm = True
            PGDatos.Fields("NombreINSS").Visible = False

            PGDatos.Fields.Add("Area", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Area").FieldName = "Area"
            PGDatos.Fields("Area").Caption = "Area"
            PGDatos.Fields("Area").Width = 125
            PGDatos.Fields("Area").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Area").Visible = False

            PGDatos.Fields.Add("Localidad", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Localidad").FieldName = "Localidad"
            PGDatos.Fields("Localidad").Width = 125
            PGDatos.Fields("Localidad").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Localidad").Visible = False

            PGDatos.Fields.Add("Categoria", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Categoria").FieldName = "Categoria"
            PGDatos.Fields("Categoria").Width = 125
            PGDatos.Fields("Categoria").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Categoria").Visible = False

            PGDatos.Fields.Add("Nomina", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Nomina").FieldName = "Nomina"
            PGDatos.Fields("Nomina").Width = 125
            PGDatos.Fields("Nomina").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Nomina").Visible = True

            PGDatos.Fields.Add("Mes", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Mes").FieldName = "Mes"
            PGDatos.Fields("Mes").Width = 125
            PGDatos.Fields("Mes").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Mes").Visible = True

            PGDatos.Fields.Add("Liquidacion", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Liquidacion").FieldName = "Liquidacion"
            PGDatos.Fields("Liquidacion").Width = 125
            PGDatos.Fields("Liquidacion").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Liquidacion").Visible = True


            PGDatos.Fields.Add("Empleado", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Empleado").FieldName = "Empleado"
            PGDatos.Fields("Empleado").Caption = "Código"
            PGDatos.Fields("Empleado").Width = 125
            PGDatos.Fields("Empleado").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Empleado").Visible = False

            PGDatos.Fields.Add("INSS", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("INSS").FieldName = "INSS"
            PGDatos.Fields("INSS").Width = 125
            PGDatos.Fields("INSS").Options.ShowInCustomizationForm = True
            PGDatos.Fields("INSS").Visible = False

            PGDatos.Fields.Add("Cedula", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cedula").FieldName = "Cedula"
            PGDatos.Fields("Cedula").Width = 125
            PGDatos.Fields("Cedula").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Cedula").Visible = False


            PGDatos.Fields.Add("Cargo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cargo").FieldName = "Cargo"
            PGDatos.Fields("Cargo").Width = 125
            PGDatos.Fields("Cargo").Options.ShowInCustomizationForm = True
            PGDatos.Fields("Cargo").Visible = False

            PGDatos.Fields.Add("Clase Rubro", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Clase Rubro").FieldName = "Clase Rubro"
            PGDatos.Fields("Clase Rubro").Caption = "Clase Rubro"

            PGDatos.Fields.Add("Tipo Rubro", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Tipo Rubro").FieldName = "Tipo Rubro"
            PGDatos.Fields("Tipo Rubro").Caption = "Tipo Rubro"

            PGDatos.Fields.Add("Rubro", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Rubro").FieldName = "Rubro"
            PGDatos.Fields("Rubro").Caption = "Rubro"

            'PGDatos.Fields.Add("", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            'PGDatos.Fields("descripcion").FieldName = "descripcion"
            'PGDatos.Fields("descripcion").Caption = "Rubro"

            PGDatos.Fields.Add("Monto", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Monto").FieldName = "Monto"
            PGDatos.Fields("Monto").Caption = "Monto"
            PGDatos.Fields("Monto").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PGDatos.Fields("Monto").CellFormat.FormatString = "n2"

            PGDatos.Fields.Add("Cantidad", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cantidad").FieldName = "Cantidad"
            PGDatos.Fields("Cantidad").Caption = "Cantidad"
            PGDatos.Fields("Cantidad").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PGDatos.Fields("Cantidad").CellFormat.FormatString = "n2"


            For i As Integer = 0 To Origen.Tables(0).Columns.Count - 1
                If Origen.Tables(0).Columns(i).ColumnName.ToUpper = "CE" Then
                    For j As Integer = i + 1 To Origen.Tables(0).Columns.Count - 1
                        PGDatos.Fields.Add(Origen.Tables(0).Columns(j).ColumnName, DevExpress.XtraPivotGrid.PivotArea.FilterArea)
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).FieldName = Origen.Tables(0).Columns(j).ColumnName
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).Caption = Origen.Tables(0).Columns(j).ColumnName
                        PGDatos.Fields(Origen.Tables(0).Columns(j).ColumnName).Visible = False
                    Next
                    Exit For
                End If
            Next


            Me.chkSelector.Checked = False
        ElseIf Origen.Tables(0).TableName = "HeadCount" Then
            Titulo = "Head Count"
            Me.cbMeses.Visible = True
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Dim v1 As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v1.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Me.cbMeses.Properties.DataSource = v1.EjecutarComando("_MesesIC", "Meses")
            Me.cbMeses.Properties.DisplayMember = "Mes"
            Me.cbMeses.Properties.ValueMember = "Fecha"
            Me.cbMeses.EditValue = New Date(Now.Date.Year, Now.Date.Month, Date.DaysInMonth(Now.Year, Now.Month))
            Me.cbMeses.Properties.PopulateColumns()
            Me.cbMeses.Properties.Columns(1).Visible = False

            Me.PGDatos.Visible = True
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            PGDatos.OptionsView.ShowDataHeaders = True
            PGDatos.OptionsView.ShowColumnHeaders = True
            PGDatos.OptionsView.ShowColumnGrandTotals = False


            PGDatos.Fields.Add("Departamento", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Departamento").FieldName = "Departamento"
            PGDatos.Fields("Departamento").Caption = "Departamento"
            PGDatos.Fields("Departamento").Width = 250

            PGDatos.Fields.Add("Area", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Area").FieldName = "Area"
            PGDatos.Fields("Area").Caption = "Area"
            PGDatos.Fields("Area").Width = 250

            PGDatos.Fields.Add("Nombre", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Nombre").FieldName = "Nombre"
            PGDatos.Fields("Nombre").Width = 250

            PGDatos.Fields.Add("Cargo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Cargo").FieldName = "Cargo"
            PGDatos.Fields("Cargo").Width = 250

            PGDatos.Fields.Add("Codigo", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Codigo").FieldName = "Codigo"
            PGDatos.Fields("Codigo").Width = 125
            PGDatos.Fields("Codigo").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count

            PGDatos.Fields.Add("Tipo", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Tipo").FieldName = "Tipo"
            PGDatos.Fields("Tipo").Caption = "Tipo Resumen"

            'PGDatos.Fields.Add("Mes Entrada", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            'PGDatos.Fields("Mes Entrada").FieldName = "Mes Entrada"
            'PGDatos.Fields("Mes Entrada").Caption = "Mes"

            PGDatos.CollapseAll()

        ElseIf Origen.Tables(0).TableName = "Asistencias" Then
            Titulo = "Asistencias"
            Me.PGDatos.Visible = True
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never


            PGDatos.Fields.Add("Departamento", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Departamento").FieldName = "Departamento"

            PGDatos.Fields.Add("nombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("nombre").FieldName = "nombre"
            PGDatos.Fields("nombre").Caption = "Nombre"

            PGDatos.Fields.Add("Fecha", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Fecha").FieldName = "Fecha"
            PGDatos.Fields("Fecha").GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date

            PGDatos.Fields.Add("Fecha2", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Fecha2").FieldName = "Fecha2"
            PGDatos.Fields("Fecha2").GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfWeek

            PGDatos.Fields.Add("Presencia", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Presencia").FieldName = "Presencia"

            PGDatos.Fields.Add("Feriado", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Feriado").FieldName = "Feriado"

            PGDatos.Fields.Add("ExtrasSimples", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("ExtrasSimples").FieldName = "ExtrasSimples"

            PGDatos.Fields.Add("ExtrasDobles", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("ExtrasDobles").FieldName = "ExtrasDobles"

        ElseIf Origen.Tables(0).TableName = "Latas" Then
            Titulo = "Latas"
            Me.PGDatos.Visible = True
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never


            PGDatos.Fields.Add("Departamento", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Departamento").FieldName = "Departamento"

            PGDatos.Fields.Add("nombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("nombre").FieldName = "nombre"

            PGDatos.Fields.Add("Fecha", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Fecha").FieldName = "Fecha"
            PGDatos.Fields("Fecha").GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date

            PGDatos.Fields.Add("Fecha2", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Fecha2").FieldName = "Fecha2"
            PGDatos.Fields("Fecha2").GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfWeek

            PGDatos.Fields.Add("Feriado", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Feriado").FieldName = "Feriado"

            PGDatos.Fields.Add("Latas", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("Latas").FieldName = "Latas"
        ElseIf Origen.Tables(0).TableName = "EMPLEADOS" Then
            Titulo = "Empleados"
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.PGDatos.Visible = False
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.DGDatos.Visible = True
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            Me.DGDatos.DataSource = Me.Origen.Tables(0)
            Me.VDGDatos.PopulateColumns()

        ElseIf Origen.Tables(0).TableName = "Liquidacion_Global" Then
            Titulo = "Liquidacion Global"
            Me.cbMeses.Visible = False
            Me.lcchktotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.PGDatos.Visible = True
            Me.lciPGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.DGDatos.Visible = False
            Me.lciVDGDatos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            PGDatos.OptionsView.ShowDataHeaders = True
            PGDatos.OptionsView.ShowColumnHeaders = True

            PGDatos.Fields.Add("Localidad", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            PGDatos.Fields("Localidad").FieldName = "Localidad"

            PGDatos.Fields.Add("Departamento", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("Departamento").FieldName = "Departamento"

            PGDatos.Fields.Add("nombre", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            PGDatos.Fields("nombre").FieldName = "nombre"
            PGDatos.Fields("nombre").Width = 250
            PGDatos.Fields("nombre").Caption = "Nombre"

            PGDatos.Fields.Add("Tipo", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            PGDatos.Fields("Tipo").FieldName = "Tipo"
            PGDatos.Fields("Tipo").Caption = "Tipo"

            PGDatos.Fields.Add("mov_valor", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            PGDatos.Fields("mov_valor").FieldName = "Monto"
            PGDatos.Fields("Monto").Caption = "Valor"
            PGDatos.Fields("Monto").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PGDatos.Fields("Monto").CellFormat.FormatString = "n2"

        End If


    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim forma As New frmExportarImprimir
        'forma.Mostrar(Grid)
        If Me.PGDatos.Visible = True Then
            ' forma.Titulo = Titulo
            forma.Mostrar(Me.PGDatos, Titulo)
        Else
            forma.Mostrar(Me.DGDatos)
        End If
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub cbMeses_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMeses.EditValueChanged
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.cbMeses.EditValue)
        Dim dt As New DataSet
        dt.Tables.Add(v.EjecutarComando("_HeadCount", "HeadCount"))
        Me.Origen = dt
        dt = Nothing
        Me.PGDatos.DataSource = Origen.Tables(0)
    End Sub
    Private Sub chkSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelector.CheckedChanged
        If Me.chkSelector.Checked Then
            PGDatos.FieldsCustomization()
        Else
            PGDatos.DestroyCustomization()
        End If
    End Sub

    Private Sub PGDatos_FieldAreaChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PGDatos.FieldAreaChanged
        If Origen.Tables(0).TableName = "Planilla_Consolidado" And Me.chkTotals.Checked Then
            For i As Integer = 0 To PGDatos.Fields.Count - 1
                If PGDatos.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.RowArea Then
                    If PGDatos.Fields(i).AreaIndex = 0 Then
                        If PGDatos.Fields(i).CustomTotals.Count = 0 Then
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Count)
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Sum)
                            PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
                        End If
                    Else
                        PGDatos.Fields(i).CustomTotals.Clear()
                        PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
                    End If
                End If
            Next
            PGDatos.Fields("Monto").TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        End If

    End Sub

    Private Sub chkTotals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTotals.CheckedChanged
        If (Origen.Tables(0).TableName = "Planilla_Consolidado" Or Origen.Tables(0).TableName = "Planilla_Consolidado_RH") And Me.chkTotals.Checked Then
            For i As Integer = 0 To PGDatos.Fields.Count - 1
                If PGDatos.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.RowArea Then
                    If PGDatos.Fields(i).AreaIndex = 0 Then
                        If PGDatos.Fields(i).CustomTotals.Count = 0 Then
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Count)
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Sum)
                            PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
                        End If
                    Else

                        PGDatos.Fields(i).CustomTotals.Clear()
                        PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
                    End If
                ElseIf PGDatos.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea Then
                    If PGDatos.Fields(i).AreaIndex = 1 Then
                        If PGDatos.Fields(i).CustomTotals.Count = 0 Then
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Average)
                            PGDatos.Fields(i).CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Sum)
                            PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
                        End If
                    Else

                        PGDatos.Fields(i).CustomTotals.Clear()
                        PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
                    End If
                End If
            Next
            PGDatos.Fields("Monto").TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        Else
            For i As Integer = 0 To PGDatos.Fields.Count - 1
                PGDatos.Fields(i).CustomTotals.Clear()
                PGDatos.Fields(i).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals
                PGDatos.Fields("Monto").TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals
            Next
        End If
    End Sub
    ''-----------------------------------------------------------------------
    ''-----------------------------------------------------------------------
    ''-----------------------------------------------------------------------
    ''-----------------------------------------------------------------------
    Private Sub cmResumexDepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmResumenxDepto.Click
        Dim visor As New frmReportes
        If Not File.Exists(Application.StartupPath & "\reportes\rptResumenPlanilla.rpt") Then
            MsgBox("No se encuentra el reporte: " & Application.StartupPath & "rptResumenPlanilla.rpt")
            Exit Sub
        End If

        Dim reporte As New Object
        reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        reporte.Load(Application.StartupPath & "\reportes\rptResumenPlanilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        If Me.Origen.Tables(0).TableName = "Planilla_Consolidado" Then
            reporte.Database.Tables("Planilla_Consolidado").Location = Application.StartupPath & "\ConPla.xml"
        ElseIf Me.Origen.Tables(0).TableName = "Planilla_Consolidado_RH" Then
            Dim dt As New DataTable
            dt = Me.Origen.Tables(0).Copy()
            dt.TableName = "Planilla_Consolidado"
            dt.WriteXml(Application.StartupPath & "\ConPla_1.xml", XmlWriteMode.WriteSchema)
            reporte.Database.Tables("Planilla_Consolidado").Location = Application.StartupPath & "\ConPla_1.xml"
        End If

        reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = reporte
        visor.ShowDialog()
        visor.Dispose()
        visor = Nothing
    End Sub

    Private Sub cmDetallexEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmDetallexEmpleado.Click
        Dim visor As New frmReportes
        'Dim Documento As New rptColilla_Depto
        Dim Documento As New Object
        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla_Depto.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla_Depto.rpt")
            Exit Sub
        End If

        Documento.load(Application.StartupPath & "\reportes\rptColilla_Depto.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        ''Imprimir el detalle

        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)


        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, "%", "0", "%", "%", "C", 0, 0)
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)


        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, "%", "%", "%")
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, "%", "%", "%")
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)

        'Dim x As New rptColilla_Depto_Areas
        'x.DataSource = EncDS
        'x.ShowPreview()

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml"
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml"
        'Documento.Subreports.Item("Resumen").Database.Tables("Planilla_Consolidado").Location = Application.StartupPath & "\ConPla.xml"
        'Documento.Subreports.Item("Resumen").Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Documento
        visor.ShowDialog()
        visor.Dispose()
        visor = Nothing
    End Sub

    Private Sub cmExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmExportar.Click
        Dim forma As New frmExportarImprimir
        'forma.Mostrar(Grid)
        If Me.PGDatos.Visible = True Then
            'forma.Titulo = Titulo
            PGDatos.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False
            PGDatos.OptionsPrint.PrintUnusedFilterFields = False
            forma.Mostrar(Me.PGDatos, Titulo)

        Else
            forma.Mostrar(Me.DGDatos)
        End If
    End Sub
    Private ds As New DataSet("Reporte")
    Private Sub cmImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmImprimir.Click
        PrintableComponentLink1.ShowPreview()
        'Dim report As XtraReport1

        'ds.Tables(0).Clear()
        'report = New XtraReport1(FillDatasetFromGrid(ds, Me.PGDatos), GridView1, chkconsolidado.Checked, chkhorizontal.Checked)
        'report.Logo.ImageUrl = Application.StartupPath & "\graphics\logo.jpg"
        'If txttitulo.Text <> Nothing Then report.Titulo.Text = txttitulo.Text
        'report.Fecha.Text = "PERIODO DEL : " & Desde.DateTime.Date & " AL " & Hasta.DateTime.Date
        ''Else
        ''    report = New XtraReport1(ds, GridView1)
        ''End If
        'report.ShowPreview()
    End Sub

    Private Sub PGDatos_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PGDatos.FieldValueDisplayText
        If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value Then
            If e.Value = "Total a Recibir" Then
                e.DisplayText = ""
            End If
        ElseIf e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
            e.DisplayText = "Totales"
        End If
    End Sub

    Private Sub cmdResumenxdeptoxarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResumenxdeptoxarea.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptResumenPlanillaxDeptoxArea
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptResumenPlanillaxDeptoxArea.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptResumenPlanillaxDeptoxArea.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptResumenPlanillaxDeptoxArea.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Reporte.Database.Tables("Planilla_Consolidado").Location = Application.StartupPath & "\ConPla.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()
        visor.Dispose()
        visor = Nothing
    End Sub

    Private Sub cmdCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmDesgloseMoneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDesgloseMoneda.Click
        'Dim visor As New frmReportes
        'Dim reporte As New rptDegloseMonedas


        ' ''Imprimir el detalle
        'Dim EncDS As DataSet, lds As DataSet

        Dim Periodo As String, TPeriodo As String
        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        'lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        'lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)

        'EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, "%", "0", "%", "%", "C")
        'EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)


        'reporte.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa.xml"
        'reporte.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"

        'visor.crvReportes.ReportSource = reporte
        'visor.ShowDialog()
        'visor.Dispose()
        'visor = Nothing

        Dim nf As New frmGridDatos
        nf.Origen = VB.SysContab.PlanillaDB.RhDeglose(Periodo, TPeriodo)
        nf.ContextMenuStrip1.Items(0).Enabled = False
        nf.ContextMenuStrip1.Items(1).Enabled = False
        nf.ContextMenuStrip1.Items(2).Enabled = False
        nf.ContextMenuStrip1.Items(3).Enabled = False

        nf.StartPosition = FormStartPosition.CenterScreen
        nf.Show()

    End Sub

    Private Sub cmResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmResumen.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptResumenPlanilla_Empresa
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptResumenPlanilla_Empresa.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptResumenPlanilla_Empresa.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptResumenPlanilla_Empresa.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Reporte.Database.Tables("Planilla_Consolidado").Location = Application.StartupPath & "\ConPla.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()
        visor.Dispose()
        visor = Nothing
    End Sub

    Private Sub cmdAceptar_Click_1(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        frmExportarImprimir.Mostrar(PGDatos)
    End Sub
End Class