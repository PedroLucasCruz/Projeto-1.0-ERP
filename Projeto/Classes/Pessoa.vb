Imports System.Data.SqlClient

Public Class Pessoa
    Public objSql As New Acesso
    Private Tran As SqlTransaction
    Private objConexãoLocal As New Acesso

    'Banco

    'Public gConAdoBd As New Acesso

    'Parametros para imputar no banco de dados
    Public strNomePessoa As String = ""
    Public strSobreNome As String = ""
    Public strCpfCnpjPessoa As String = ""
    Public strEnderecoPessoa As String = ""
    Public strContatoPessoa As String = ""
    Public intCodPessoa As Integer = 0

    Public objConn As New SqlConnection
    'Dim stringConexão As String = "Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True;"

    Public SqlBd As New SqlCommand
    Public dtReader As SqlDataReader

    Public Sub ConfigurarComandoSQL(ByVal bIniciar As Boolean, Optional ByVal strNomeProcedure As String = "")

        If bIniciar Then

            With SqlBd
                .Parameters.Clear()
                'SqlBd.Connection = objConexãoLocal.objConexao
                .Connection = objConn
                .CommandType = CommandType.StoredProcedure
                .CommandText = strNomeProcedure
            End With

        Else
            SqlBd.Parameters.Clear()
        End If
    End Sub

    Public Function Incluir() As Integer

        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPessoa_m")
            With SqlBd

                '.Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 1)
                .Parameters.AddWithValue("@NOMEPESSOA", strNomePessoa)
                .Parameters.AddWithValue("@SOBRENOMEPESSOA", strSobreNome)
                .Parameters.AddWithValue("@CPFCNPJPESSOA", strCpfCnpjPessoa)
                .Parameters.AddWithValue("@ENDERECOPESSOA", strEnderecoPessoa)
                .Parameters.AddWithValue("@CONTATOPESSOA", strContatoPessoa)
                .Parameters.AddWithValue("@TIPO", "VENDEDOR")
                Dim INTCODPESSOA_NOVO As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                INTCODPESSOA_NOVO.Direction = ParameterDirection.Output

                .ExecuteScalar()
                'Tran.Commit()

                ' Return Integer.Parse(INTCODPESSOA_NOVO.Value)
            End With

        Catch Ex As Exception
            MsgBox(Ex.ToString)
            'Tran.Rollback()

        Finally
            '  objSql.ConfigurarComandoSQL(False)
            '  objConexãoLocal.
            objConn.Close()
        End Try

    End Function


    Public Sub alterar()
        ' Tran = objSql.gConAdoBd.BeginTransaction

        Try
            ConfigurarComandoSQL(True, "spPessoa_m")
            With SqlBd

                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 2)
                .Parameters.AddWithValue("@NOMEPESSOA", strNomePessoa)
                .Parameters.AddWithValue("@SOBRENOMEPESSOA", strSobreNome)
                .Parameters.AddWithValue("@CPFCNPJPESSOA", strCpfCnpjPessoa)
                .Parameters.AddWithValue("@ENDERECOPESSOA", strEnderecoPessoa)
                .Parameters.AddWithValue("@CONTATOPESSOA", strContatoPessoa)
                .Parameters.AddWithValue("@INTCODPESSOA_PK", intCodPessoa)

                'Dim INTCODPESSOA As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPESSOA.Direction = ParameterDirection.Output

                .ExecuteNonQuery()
                Tran.Commit()

            End With

        Catch Ex As Exception
            Tran.Rollback()
            Throw New Exception("Erro ao alterar dados de Pessoa no banco", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
        End Try

    End Sub

    Public Sub excluir()
        ' Tran = objSql.gConAdoBd.BeginTransaction
        Try
            ConfigurarComandoSQL(True, "spPessoa_m")
            With SqlBd

                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 3)
                .Parameters.AddWithValue("@INTCODPESSOA_PK", intCodPessoa)
                .ExecuteNonQuery()
                Tran.Commit()

            End With

        Catch Ex As Exception
            Tran.Rollback()
            Throw New Exception("Erro ao excluir dados de Pessoa no banco", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
        End Try

    End Sub


    Public Function PesquisarTodosPessoaOrigem() As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPesquisar_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 1)
                '.Parameters.AddWithValue("", )

                'Dim INTCODPESSOA As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPESSOA.Direction = ParameterDirection.Output

                dtReaderLocal = .ExecuteReader()
                Return dtReaderLocal
                'Tran.Commit()

            End With

        Catch Ex As Exception
            'Tran.Rollback()
            MsgBox(Ex.ToString)
            Throw New Exception("Erro ao alterar dados de Pessoa no banco", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function



    'PesquisarTodosPessoaDestino


    Public Function PesquisarTodosPessoaDestino() As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPesquisar_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 2)
                '.Parameters.AddWithValue("", )

                'Dim INTCODPESSOA As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPESSOA.Direction = ParameterDirection.Output

                dtReaderLocal = .ExecuteReader()
                Return dtReaderLocal
                'Tran.Commit()

            End With

        Catch Ex As Exception
            'Tran.Rollback()
            MsgBox(Ex.ToString)
            Throw New Exception("Erro ao alterar dados de Pessoa no banco", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function

    Public Function PesquisarTodosProdutos() As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPesquisar_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 3)
                '.Parameters.AddWithValue("", )

                'Dim INTCODPESSOA As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPESSOA.Direction = ParameterDirection.Output

                dtReaderLocal = .ExecuteReader()
                Return dtReaderLocal
                'Tran.Commit()

            End With

        Catch Ex As Exception
            'Tran.Rollback()
            MsgBox(Ex.ToString)
            Throw New Exception("Erro ao alterar dados de Pessoa no banco", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function

End Class
