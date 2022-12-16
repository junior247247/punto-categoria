Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As New SqlConnection

    Public Function conectado()


        Try


            'cnn = New SqlConnection("data source=20.126.25.74 ;initial catalog=sispunto_de_ventas;user id=sa ;password=Junior221089")

            cnn = New SqlConnection("data source=(local);initial catalog=sispunto_de_ventas;integrated security=true")

            cnn.Open()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

    Public Function desconectado()
        Try



            If cnn.State = ConnectionState.Open Then

                cnn.Close()
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
