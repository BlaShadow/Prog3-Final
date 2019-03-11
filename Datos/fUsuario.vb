Imports System.Data.SqlClient
Imports Entidades

Public Class fUsuario

    Inherits Conexion

    Public Function validarusuario(ByVal dts As Eusuario) As DataTable
        conectado()
        cmd = New SqlCommand("_iniciosesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@users", dts._Usuario)
        cmd.Parameters.AddWithValue("@pass", dts._Contraseña)

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
End Class
