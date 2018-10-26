Imports DbConnect

Namespace VB.SysContab
    Public Class RubrosEmpresaDetails
        Public Codigo As String
        Public Descripcion As String
        Public Cuenta_Debito As String
        Public Cuenta_Credito As String
        Public Sistema As Boolean
        Public Factor As Decimal
        Public Contabilizar As Boolean
    End Class


    Public Class RubrosEmpresaDB
        Public Shared Function GetDetails(ByVal Codigo As String) As RubrosEmpresaDetails
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            Dim dt As New DataTable
            Dim detalles As New RubrosEmpresaDetails

            Try
                dt = v.EjecutarComando("_RH_GetDetails_RubrosEmpresa", "Tabla")
                If dt.Rows.Count = 1 Then
                    detalles.Codigo = dt.Rows(0)("tre_codigo")
                    detalles.Descripcion = dt.Rows(0)("tre_descripcion")
                    detalles.Cuenta_Debito = dt.Rows(0)("tre_ctacontable")
                    detalles.Cuenta_Credito = dt.Rows(0)("tre_ctacontablecred")
                    detalles.Sistema = dt.Rows(0)("tre_sistema")
                    detalles.Factor = dt.Rows(0)("factor")
                    detalles.Contabilizar = IsNull(dt.Rows(0)("tre_contabilizar"), False)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                detalles = Nothing
            End Try
            dt = Nothing
            Return detalles
        End Function

        Public Shared Function GetList() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Try
                Return v.EjecutarComando("_RH_GetList_RubrosEmpresa", "Rubros")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function GetList_Detalle(ByVal Codigo As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("TRE", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            Try
                Return v.EjecutarComando("_RH_TRE_TI", "DetalleRubros")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function GetList_Nuevo() As String
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Output, 0)

            Try
                v.EjecutarComando("_RH_GetTRE_NUevo")
                Return v.GetParameter("Codigo").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return "001"
            End Try
        End Function

        Public Shared Sub AddItem(ByVal Descripcion As String, ByVal Factor As Double, Contabilizar As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Descripcion)
            v.AddParameter("Factor", SqlDbType.Float, 5, ParameterDirection.Input, Factor)
            v.AddParameter("Contabilizar", SqlDbType.Int, 5, ParameterDirection.Input, Contabilizar)

            Try
                v.EjecutarComando("_RH_TRE_Add")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub UpdateItem(ByVal Codigo As String, ByVal Descripcion As String, ByVal Factor As Double, Contabilizar As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Descripcion)
            v.AddParameter("Factor", SqlDbType.Float, 5, ParameterDirection.Input, Factor)
            v.AddParameter("Contabilizar", SqlDbType.Int, 5, ParameterDirection.Input, Contabilizar)
            Try
                v.EjecutarComando("_RH_TRE_Update")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub TRE_TI_Detalle(ByVal TRE As String, ByVal TI As String, ByVal Activo As Boolean)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tre", SqlDbType.NVarChar, 3, ParameterDirection.Input, TRE)
            v.AddParameter("ti", SqlDbType.NVarChar, 3, ParameterDirection.Input, TI)
            v.AddParameter("activo", SqlDbType.Bit, 1, ParameterDirection.Input, Activo)
            Try
                v.EjecutarComando("_RH_TRE_TI_Update")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Namespace

