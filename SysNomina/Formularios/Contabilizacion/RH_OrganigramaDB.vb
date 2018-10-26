Imports DbConnect

Namespace VB.SysContab

    Public Class RH_OrganigramaDB

        Public Shared Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable

            Dim rows As DataRow()

            Dim dtNew As DataTable

            ' copy table structure
            dtNew = dt.Clone()

            ' sort and filter data
            rows = dt.Select(filter)

            ' fill dtNew with selected rows

            For Each dr As DataRow In rows
                dtNew.ImportRow(dr)

            Next

            ' return filtered dt
            Return dtNew

        End Function

        Public Shared Function RH_Organigrama_Importar() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Try
                Return v.EjecutarComando("_RH_Organigrama_Importar", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub RH_Organigrama_ImportarAdd(idsubcentro As Integer, padre As Integer, nombre As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("idsubcentro", SqlDbType.Int, 5, ParameterDirection.Input, idsubcentro)
            v.AddParameter("padre", SqlDbType.Int, 5, ParameterDirection.Input, padre)
            v.AddParameter("nombre", SqlDbType.NVarChar, 250, ParameterDirection.Input, nombre)

            Try
                v.EjecutarComando("_RH_Organigrama_Importaradd")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub


        Public Shared Function RH_PlanillaContabilizar_Detalle(ByVal rubro As String, _
            ByVal Periodo As String, ByVal org_codigo As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("rub_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, rubro)
            v.AddParameter("periodo", SqlDbType.NVarChar, 9, ParameterDirection.Input, Periodo)
            v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, org_codigo)

            Try
                Return v.EjecutarComando("_RH_PlanillaContabilizar_Detalle", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub Organigrama_Detalle(ByVal Organigrama As Integer, ByVal Empleado As String, ByVal Porcentaje As Double)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Organigrama)
            v.AddParameter("porcentaje", SqlDbType.Float, 5, ParameterDirection.Input, Porcentaje)

            Try
                v.EjecutarComando("_RH_Organigrama_Empleado_Add")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub Organigrama_Detalle_Borrar(ByVal Organigrama As Integer, ByVal Empleado As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Organigrama)

            Try
                v.EjecutarComando("_RH_Organigrama_Empleado_Delete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Function Plantilla(ByRef CuentasVacias As Integer, ByVal Periodo As String, _
            ByVal TPeriodo As String, ByVal Moneda As String, ByVal AgruparCuentas As Boolean) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            Dim dt As New DataTable
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("CuentasVacias", SqlDbType.Int, 5, ParameterDirection.Output, CuentasVacias)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("Moneda", SqlDbType.NVarChar, 2, ParameterDirection.Input, Moneda)
            v.AddParameter("Agrupar", SqlDbType.Bit, 2, ParameterDirection.Input, AgruparCuentas)

            Try

                dt = v.EjecutarComando("_RH_PlanillaContabilizar", "Tabla")
                CuentasVacias = v.GetParameter("CuentasVacias").Valor
                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
                CuentasVacias = 0
            End Try
        End Function

        Public Shared Function Listar() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_Organigrama_List", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try
        End Function
        Public Shared Function Plantilla(ByVal Codigo As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            Try
                Return v.EjecutarComando("_RH_Plantilla_List", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try
        End Function

        Public Shared Sub Plantilla_Add(ByVal Codigo As Integer, ByVal Rubro As String, ByVal TRubro As String, ByVal Debito As String, ByVal Credito As String, _
                                        ByVal rub_gasto As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("rub_codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Rubro)
            v.AddParameter("rub_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TRubro)
            v.AddParameter("rub_cuentaDebito", SqlDbType.NVarChar, 64, ParameterDirection.Input, Debito)
            v.AddParameter("rub_cuentaCredito", SqlDbType.NVarChar, 64, ParameterDirection.Input, Credito)
            v.AddParameter("rub_gasto", SqlDbType.Int, 5, ParameterDirection.Input, rub_gasto)
            Try
                v.EjecutarComando("_RH_Plantilla_Rubros")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Function Agregar(ByVal Padre As Integer, ByVal Descripcion As String, _
                ByVal Empleado As String, ByVal Email As String, ByVal Camino As String, ByVal Sufijo As String) As Integer
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            v.AddParameter("Padre", SqlDbType.Int, 5, ParameterDirection.Input, Padre)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
            v.AddParameter("sufijo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Sufijo)
            v.AddParameter("empleado", SqlDbType.NVarChar, 50, ParameterDirection.Input, Empleado)
            v.AddParameter("email", SqlDbType.NVarChar, 50, ParameterDirection.Input, Email)
            v.AddParameter("nivel", SqlDbType.Int, 50, ParameterDirection.Input, 0)
            v.AddParameter("empresa", SqlDbType.Int, 50, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("camino", SqlDbType.NVarChar, 200, ParameterDirection.Input, Camino)
            Try
                v.EjecutarComando("_RH_Organigrama_Add")
                Return v.GetParameter("ID").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Sub Modificar(ByVal Id As Integer, ByVal Padre As Integer, _
            ByVal Descripcion As String, ByVal Empleado As String, ByVal Email As String, ByVal Camino As String, _
            ByVal Sufijo As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("Descripcion", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
            v.AddParameter("empleado", SqlDbType.NVarChar, 50, ParameterDirection.Input, Empleado)
            v.AddParameter("email", SqlDbType.NVarChar, 50, ParameterDirection.Input, Email)
            v.AddParameter("id", SqlDbType.Int, 50, ParameterDirection.Input, Id)
            v.AddParameter("padre", SqlDbType.Int, 50, ParameterDirection.Input, Padre)
            v.AddParameter("camino", SqlDbType.NVarChar, 200, ParameterDirection.Input, Camino)
            v.AddParameter("org_sufijo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Sufijo)
            Try
                v.EjecutarComando("_RH_Organigrama_Update")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

        Public Shared Sub Borrar(ByVal Id As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("id", SqlDbType.Int, 50, ParameterDirection.Input, Id)
            Try
                v.EjecutarComando("_RH_Organigrama_Delete")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

        Public Shared Function PlantillaDetalle(Optional ByVal Empleado As String = "%", _
        Optional ByVal TRubro As String = "%", Optional ByVal Rubro As String = "%") As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("trubro", SqlDbType.NVarChar, 1, ParameterDirection.Input, TRubro)
            v.AddParameter("rubro", SqlDbType.NVarChar, 10, ParameterDirection.Input, Rubro)
            Try
                Return v.EjecutarComando("_RH_PlantillaDetalle_GetList", "Detalle")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try
        End Function

        Public Shared Function PlantillaDetalle_Add(ByVal Empleado As String, _
           ByVal TRubro As String, ByVal Rubro As String, ByVal CuentaDebito As String, _
           ByVal CuentaCredito As String, ByVal Activo As Boolean) As Boolean

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("trubro", SqlDbType.NVarChar, 1, ParameterDirection.Input, TRubro)
            v.AddParameter("rubro", SqlDbType.NVarChar, 10, ParameterDirection.Input, Rubro)
            v.AddParameter("CDebito", SqlDbType.NVarChar, 64, ParameterDirection.Input, CuentaDebito)
            v.AddParameter("CCredito", SqlDbType.NVarChar, 64, ParameterDirection.Input, CuentaCredito)
            v.AddParameter("Activo", SqlDbType.Bit, 1, ParameterDirection.Input, Activo)
            Try
                v.EjecutarComando("_RH_PlantillaDetalle_Add")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Function

        Public Shared Function EnviarComprobante(ByVal Documento As String, ByVal Fecha As Date, ByVal Concepto As String, _
                ByVal Usuario As String, ByVal Host As String, ByVal Estado As Integer, ByVal Datos As DataTable, _
                ByVal CuentaDescuadre As String, ByVal ValorDescuadre As Decimal, AgrupadoxCuenta As Boolean) As Integer

            Dim Distribucion As New DataTable, Detalle As New DataTable
            If AgrupadoxCuenta = False Then
                Detalle = RH_OrganigramaDB.SelectDataTable(Datos, "TIPO = 1")
            Else
                'agrupado
                Detalle = RH_OrganigramaDB.SelectDataTable(Datos, "TIPO = 2")
            End If

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("documento", SqlDbType.NVarChar, 50, ParameterDirection.Input, Documento)
            v.AddParameter("fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
            v.AddParameter("concepto", SqlDbType.NVarChar, 50, ParameterDirection.Input, Concepto)
            v.AddParameter("usuario", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario)
            v.AddParameter("host", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            v.AddParameter("estado", SqlDbType.Int, 5, ParameterDirection.Input, Estado)
            v.AddParameter("valor", SqlDbType.Int, 5, ParameterDirection.InputOutput, 0)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.InputOutput, 0)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("xCuenta", SqlDbType.Bit, 5, ParameterDirection.Input, AgrupadoxCuenta)
            Try
                v.IniciarTransaccion()
                v.EjecutarComando("_IMP_Comprobante")

                If v.GetParameter("valor").Valor = -1 Then
                    MsgBox("No se pudo grabar el encabezado del comprobante.Ya existe uno ")
                    Return False
                Else
                    Dim id As Integer, did As Integer
                    id = v.GetParameter("ID").Valor
                    ''Exportando el detalle del comprobante
                    For i As Integer = 0 To Detalle.Rows.Count - 1
                        v.RemoveParameters()
                        v.AddParameter("cID", SqlDbType.Int, 5, ParameterDirection.InputOutput, id)
                        v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Detalle.Rows(i)("cuenta"))
                        v.AddParameter("debe", SqlDbType.Money, 64, ParameterDirection.Input, Detalle.Rows(i)("debito"))
                        v.AddParameter("haber", SqlDbType.Money, 64, ParameterDirection.Input, Detalle.Rows(i)("credito"))
                        v.AddParameter("comentario", SqlDbType.NVarChar, 250, ParameterDirection.Input, Detalle.Rows(i)("mov_concepto"))
                        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Try
                            v.EjecutarComando("_IMP_Comprobantedetalle")
                            did = v.GetParameter("cID").Valor
                            v.RemoveParameters()

                            ''Grabar la distrubucion
                            If AgrupadoxCuenta = True Then
                                Distribucion = RH_OrganigramaDB.SelectDataTable(Datos, "TIPO = 1 and cuenta='" & Detalle.Rows(i)("cuenta") & "' and mov_concepto2 ='" & Detalle.Rows(i)("mov_concepto2") & "' AND DC = '" & Detalle.Rows(i)("DC") & "'")
                                ' LOS DEBITOS
                                For j As Integer = 0 To Distribucion.Rows.Count - 1
                                    v.RemoveParameters()
                                    v.AddParameter("dID", SqlDbType.Int, 5, ParameterDirection.InputOutput, did)
                                    v.AddParameter("idrubrogasto", SqlDbType.Int, 5, ParameterDirection.Input, Distribucion.Rows(j)("rub_gasto"))
                                    v.AddParameter("valor", SqlDbType.Money, 64, ParameterDirection.Input, Distribucion.Rows(j)("debito") + Distribucion.Rows(j)("credito"))
                                    v.AddParameter("tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, IIf(Distribucion.Rows(j)("credito") > 0, "C", "D"))
                                    v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Distribucion.Rows(j)("cuenta"))
                                    v.AddParameter("idsubcentro", SqlDbType.Int, 5, ParameterDirection.Input, Distribucion.Rows(j)("idsubcentro"))
                                    v.AddParameter("cantidad", SqlDbType.Money, 64, ParameterDirection.Input, 0)
                                    v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                                    Try
                                        v.EjecutarComando("_IMP_Comprobantedetalle_Distribucion")
                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                        v.AnularTransaccion()
                                        Return False
                                    End Try
                                Next


                            Else
                                v.AddParameter("dID", SqlDbType.Int, 5, ParameterDirection.InputOutput, did)
                                v.AddParameter("idrubrogasto", SqlDbType.Int, 5, ParameterDirection.Input, Detalle.Rows(i)("rub_gasto"))
                                v.AddParameter("valor", SqlDbType.Money, 64, ParameterDirection.Input, Detalle.Rows(i)("debito") + Detalle.Rows(i)("credito"))
                                v.AddParameter("tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, IIf(Detalle.Rows(i)("credito") > 0, "C", "D"))
                                v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Detalle.Rows(i)("cuenta"))
                                v.AddParameter("cantidad", SqlDbType.Money, 64, ParameterDirection.Input, 0)
                                v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                                Try
                                    v.EjecutarComando("_IMP_Comprobantedetalle_Distribucion")
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                    v.AnularTransaccion()
                                    Return False
                                End Try
                            End If

                            

                           
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            v.AnularTransaccion()
                            Return False
                        End Try
                    Next

                    If ValorDescuadre <> 0 Then
                        v.RemoveParameters()
                        v.AddParameter("cID", SqlDbType.Int, 5, ParameterDirection.Input, id)
                        v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, CuentaDescuadre)
                        v.AddParameter("debe", SqlDbType.Money, 64, ParameterDirection.Input, IIf(ValorDescuadre > 0, 0, Math.Abs(ValorDescuadre)))
                        v.AddParameter("haber", SqlDbType.Money, 64, ParameterDirection.Input, IIf(ValorDescuadre < 0, 0, Math.Abs(ValorDescuadre)))
                        v.AddParameter("comentario", SqlDbType.NVarChar, 250, ParameterDirection.Input, "Ajuste por descuadre")
                        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Try
                            v.EjecutarComando("_IMP_Comprobantedetalle")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            v.AnularTransaccion()
                            Return False
                        End Try
                    End If

                    ''Exportando la distribucion
                End If
                v.CompletarTransaccion()
                Return True
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                v.AnularTransaccion()
                Return False
            End Try



        End Function


    End Class

End Namespace


