Imports System.Data.SqlClient

Public Class ConexionBD

    Public cadenaConexion As String = "Data Source = DESKTOP-3QTRLEI; Initial Catalog= Inventario; Integrated Security = True"

    Public Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(cadenaConexion)
        Return conexion
    End Function

    Public Sub AbrirConexion(ByRef conexionEnviada As SqlConnection)
        Try
            'Bloque de instrucciones que se quieren hacer
            If conexionEnviada.State <> ConnectionState.Open Then
                conexionEnviada.Open()
            End If

        Catch ex As Exception
            'Bloque de instrucciones que se realizan si en el bloque try hay un error
            Console.WriteLine("Error al abrir la conexion enviada.")
        End Try
    End Sub

    Public Sub CerrarConexion(ByRef conexionEnviada As SqlConnection)

        Try
            If conexionEnviada.State = ConnectionState.Open Then
                conexionEnviada.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("No se pudo cerrar la conexion")
        End Try

    End Sub

    Public Sub InsertarDatos(ByVal query As String)
        Dim conexion As SqlConnection = ObtenerConexion()
        Try
            AbrirConexion(conexion)
            Dim comando As New SqlCommand(query, conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("No se pudo ejecujar el insert. " + query)
        Finally
            CerrarConexion(conexion)
        End Try
    End Sub

    Public Sub Delete()

    End Sub

    Public Sub Update()

    End Sub

    Public Function SelectQuery(ByVal querySelect As String) As DataTable
        Dim conexion As SqlConnection = ObtenerConexion()
        Dim data As New DataTable
        Try
            AbrirConexion(conexion)
            Dim adaptador As New SqlDataAdapter(querySelect, conexion)
            adaptador.Fill(data)
        Catch ex As Exception
            Console.WriteLine("Error en SelectQuery")
        Finally
            CerrarConexion(conexion)
        End Try

        Return data
    End Function


End Class
