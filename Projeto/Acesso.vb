Imports System.Data.SqlClient

Public Class Acesso

    'Public gConAdoBd As New SqlConnection
    Public objConexao As New SqlConnection
    Public stringConexão As String

    Public Sub conectar()

        Try
            objConexao = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;") 'USER ID= sa; PASSWORD=;")
            objConexao.Open()

        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco!")
        End Try

    End Sub
    Public Sub fechar()
        Try
            If Not IsNothing(objConexao) Then

                If objConexao.State = ConnectionState.Open Then
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex 'retorna para onde estiver executando
        End Try

    End Sub

    Public Function executeQuery(ByVal command As String) As DataSet
        Dim ds As New DataSet
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objcommand As New SqlClient.SqlCommand

        Try
            objcommand = objConexao.CreateCommand
            objcommand.CommandText = command
            objDataAdapter = New SqlClient.SqlDataAdapter(objcommand)

            objDataAdapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function


End Class
