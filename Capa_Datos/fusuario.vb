Imports System.Data.SqlClient
Imports Capa_Logica
Public Class fusuario
    Inherits conexion
    Public Function validarusuario(ByVal dts As Eusuario) As DataTable
        conectado()
        cmd = New SqlCommand("_iniciosesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@users", dts._users)
        cmd.Parameters.AddWithValue("@passwords", dts._passwords)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As Eusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@users", dts._users)
            cmd.Parameters.AddWithValue("@passwords", dts._passwords)
            cmd.Parameters.AddWithValue("@nivel", dts._nivel)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar(ByVal dts As Eusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@users", dts._users)
            cmd.Parameters.AddWithValue("@passwords", dts._passwords)
            cmd.Parameters.AddWithValue("@nivel", dts._nivel)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminar(ByVal dts As Eusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@users", SqlDbType.NVarChar, 50).Value = dts._users
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



End Class

