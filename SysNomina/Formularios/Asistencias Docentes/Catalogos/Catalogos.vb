Imports DbConnect

Public Class Catalogos

    Public Shared Function EDU_AsistenciasResumen(Quincena As String) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("trn_quincena", SqlDbType.NVarChar, 10, ParameterDirection.Input, Quincena)
        Try
            Dim dt As New DataTable
            dt = v.EjecutarComando("_EDU_Asistencias_Resumen", "Resumen")
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function EDU_Procesar_Asistencias(Quincena As String, ByRef Errores As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("trn_quincena", SqlDbType.NVarChar, 10, ParameterDirection.Input, Quincena)
        v.AddParameter("errores", SqlDbType.Int, 10, ParameterDirection.InputOutput, Errores)
        Try
            Dim dt As New DataTable
            dt = v.EjecutarComando("_EDU_Procesar_Asistencias", "Archivos")
            Errores = v.GetParameter("errores").Valor
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function EDU_Archivos_List() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_EDU_aImportado_List", "Archivos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Sub EDU_BitacoraArchivos(ByVal Archivo() As Byte, Origen As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Archivo", SqlDbType.VarBinary, 8000, ParameterDirection.Input, Archivo)
        v.AddParameter("Origen", SqlDbType.Int, 1, ParameterDirection.Input, Origen)

        Try
            v.EjecutarComando("_EDU_Importacion_Add")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        v = Nothing
    End Sub

    Public Shared Function EDU_Contratos_List(cod_turno As String, estado As String) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("estado", SqlDbType.NVarChar, 1, ParameterDirection.Input, estado)
        v.AddParameter("cod_turno", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_turno)
        Try
            Return v.EjecutarComando("_EDU_Contratos_List", "Contratos")

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function EDU_Contratos_Add(id As Integer, cedula As String, docente As String, cod_asignatura As String, asignatura As String, _
                                        cod_turno As String, turno As String, desde As Date, hasta As Date, valor_hora As Decimal, moneda As String) As Integer

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("moneda", SqlDbType.NVarChar, 2, ParameterDirection.Input, moneda)
        v.AddParameter("id", SqlDbType.Int, 2, ParameterDirection.InputOutput, id)
        v.AddParameter("cedula", SqlDbType.NVarChar, 50, ParameterDirection.Input, cedula)
        v.AddParameter("docente", SqlDbType.NVarChar, 250, ParameterDirection.Input, docente)
        v.AddParameter("cod_asignatura", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_asignatura)
        v.AddParameter("asignatura", SqlDbType.NVarChar, 250, ParameterDirection.Input, asignatura)
        v.AddParameter("cod_turno", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_turno)
        v.AddParameter("turno", SqlDbType.NVarChar, 250, ParameterDirection.Input, turno)
        v.AddParameter("desde", SqlDbType.SmallDateTime, 50, ParameterDirection.Input, desde)
        v.AddParameter("hasta", SqlDbType.SmallDateTime, 50, ParameterDirection.Input, hasta)
        v.AddParameter("valor_hora", SqlDbType.Float, 50, ParameterDirection.Input, valor_hora)
        Try
            v.EjecutarComando("_EDU_Contratos_Add")
            Return v.GetParameter("id").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try

    End Function


    Public Shared Function EDU_Configuraciones() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_EDU_Configuraciones_List", "Configuraciones")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Sub EDU_Configuraciones_Add(Moneda As String, TipoIngreso As String)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("mon_contratos", SqlDbType.NVarChar, 2, ParameterDirection.Input, Moneda)
        v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, TipoIngreso)
        Try
            v.EjecutarComando("_EDU_Configuraciones_Add")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Function EDU_Asistencias_Listar(desde As Date, hasta As Date) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, desde)
        v.AddParameter("hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, hasta)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_EDU_Asistencias_List", "Asistencias")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Shared Function EDU_Facultad(ByVal Facultad As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, Facultad)
        Try
            Return v.EjecutarComando("_EDU_Facultad", "Facultad")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function EDU_Facultad_Add(ByVal id As Integer, ByVal Facultad As String, ByVal Descripcion As String, _
        Optional ByVal Borrar As Boolean = False, Optional ByVal Importando As Boolean = False) As Integer

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.InputOutput, id)
        v.AddParameter("id_facultad", SqlDbType.NVarChar, 10, ParameterDirection.Input, Facultad)
        v.AddParameter("desc_facultad", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        v.AddParameter("importando", SqlDbType.Bit, 5, ParameterDirection.Input, Importando)
        Try
            v.EjecutarComando("_EDU_Facultad_Add")
            Return v.GetParameter("id").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Shared Function EDU_Carrera(ByVal Carrera As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, Carrera)
        Try
            Return v.EjecutarComando("_EDU_Carrera", "Carrera")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function EDU_Carrera_Add(ByVal id As Integer, ByVal Carrera As String, ByVal Facultad As String, _
        ByVal Descripcion As String, ByVal Org_codigo As Integer, Optional ByVal Borrar As Boolean = False) As Integer

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.InputOutput, id)
        v.AddParameter("id_carrera", SqlDbType.NVarChar, 10, ParameterDirection.Input, Carrera)
        v.AddParameter("id_facultad", SqlDbType.NVarChar, 10, ParameterDirection.Input, Facultad)
        v.AddParameter("desc_carrera", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
        v.AddParameter("org_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Org_codigo)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        Try
            v.EjecutarComando("_EDU_Carrera_Add")
            Return v.GetParameter("id").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Shared Function EDU_Asignatura(ByVal Asignatura As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, Asignatura)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_EDU_Asignatura", "Asignatura")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function EDU_Asignatura_Add(ByVal id As Integer, ByVal Asignatura As String, tdi_codigo As String, ByVal Descripcion As String, _
            ByVal rub_gasto As Integer, Optional ByVal Borrar As Boolean = False, Optional ByVal Importando As Boolean = False) As Integer

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.InputOutput, id)
        v.AddParameter("id_asignatura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Asignatura)
        v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, tdi_codigo)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("rub_gasto", SqlDbType.Int, 5, ParameterDirection.Input, rub_gasto)
        v.AddParameter("desc_asignatura", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        v.AddParameter("importando", SqlDbType.Bit, 5, ParameterDirection.Input, Importando)
        Try
            v.EjecutarComando("_EDU_Asignatura_Add")
            Return v.GetParameter("id").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Shared Function EDU_Turno(ByVal Turno As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, Turno)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_EDU_Turno", "Turno")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function EDU_Turno_Add(ByVal id As Integer, ByVal Turno As String, ByVal Descripcion As String, _
        ByVal Cuenta As String, tdi_codigo As String, Optional ByVal Borrar As Boolean = False, Optional ByVal Importando As Boolean = False) As Integer

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.InputOutput, id)
        v.AddParameter("id_Turno", SqlDbType.NVarChar, 10, ParameterDirection.Input, Turno)
        v.AddParameter("desc_Turno", SqlDbType.NVarChar, 250, ParameterDirection.Input, Descripcion)
        v.AddParameter("cta_contable", SqlDbType.NVarChar, 64, ParameterDirection.Input, Cuenta)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        v.AddParameter("importando", SqlDbType.Bit, 5, ParameterDirection.Input, Importando)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, tdi_codigo)
        Try
            v.EjecutarComando("_EDU_Turno_Add")
            Return v.GetParameter("id").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Shared Sub EDU_Asistencias_Add(ByVal id As Integer, ByVal desde As Date, ByVal hasta As Date, _
            ByVal cod_turno As String, ByVal turno As String, ByVal cod_carrera As String, ByVal carrera As String, _
            ByVal cod_facultad As String, ByVal facultad As String, cod_asignatura As String, asignatura As String, _
            ByVal horas As Decimal, ByVal cod_docente As String, _
            ByVal docente As String, ByVal cedula As String, QuincenaTrabajo As String, Horas_Importadas As Decimal)

        'ByVal fecha As Date, _
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("desde", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, desde)
        v.AddParameter("hasta", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, hasta)
        'v.AddParameter("fecha", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, fecha)
        v.AddParameter("cod_turno", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_turno)
        v.AddParameter("turno", SqlDbType.NVarChar, 50, ParameterDirection.Input, turno)
        v.AddParameter("cod_carrera", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_carrera)
        v.AddParameter("carrera", SqlDbType.NVarChar, 50, ParameterDirection.Input, carrera)
        v.AddParameter("cod_asignatura", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_asignatura)
        v.AddParameter("asignatura", SqlDbType.NVarChar, 250, ParameterDirection.Input, asignatura)
        v.AddParameter("cod_facultad", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_facultad)
        v.AddParameter("facultad", SqlDbType.NVarChar, 50, ParameterDirection.Input, facultad)
        v.AddParameter("horas", SqlDbType.Float, 18, ParameterDirection.Input, horas)
        v.AddParameter("cod_docente", SqlDbType.NVarChar, 50, ParameterDirection.Input, cod_docente)
        v.AddParameter("docente", SqlDbType.NVarChar, 250, ParameterDirection.Input, docente)
        v.AddParameter("cedula", SqlDbType.NVarChar, 50, ParameterDirection.Input, cedula)
        v.AddParameter("empresa", SqlDbType.Int, 50, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("quincena", SqlDbType.NVarChar, 50, ParameterDirection.Input, QuincenaTrabajo)
        v.AddParameter("horas_importadas", SqlDbType.Float, 18, ParameterDirection.Input, Horas_Importadas)
        Try
            v.EjecutarComando("_EDU_Asistencias_Add")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub EDU_Asistencias_Borrar(ByVal desde As Date, ByVal hasta As Date, ByVal Turno As String)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("desde", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, desde)
        v.AddParameter("hasta", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, hasta)
        v.AddParameter("quincena", SqlDbType.NVarChar, 50, ParameterDirection.Input, QuincenaTrabajo)
        v.AddParameter("turno", SqlDbType.NVarChar, 10, ParameterDirection.Input, Turno)

        Try
            v.EjecutarComando("_EDU_Asistencias_borrar")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub EDU_Asistencias_ActualizarHoras(ByVal id As Integer, ByVal horas As Decimal)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("horas", SqlDbType.Float, 10, ParameterDirection.Input, horas)

        Try
            v.EjecutarComando("_EDU_Asistencias_Update")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

End Class
