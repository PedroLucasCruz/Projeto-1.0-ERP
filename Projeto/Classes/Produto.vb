Imports System.Data.SqlClient
Public Class Produto
    Public objSql As New Acesso
    Private Tran As SqlTransaction
    Private objConexão As New Acesso

    'Banco
    Public SqlBd As New SqlCommand
    Public gConAdoBd As New Acesso

    'Parametros para imputar no banco de dados
    Dim strNomeProduto As String = ""
    Dim strDescricao As String = ""
    Dim dblValor As Double = ""
    Dim intQuantidade As Integer = 0
    Dim intCodProduto As Integer = 0


    Public Sub ConfigurarComandoSQL(ByVal bIniciar As Boolean, Optional ByVal strNomeProcedure As String = "")

        If bIniciar Then

            SqlBd.Parameters.Clear()
            SqlBd.Connection = gConAdoBd.objConexao
            SqlBd.CommandType = CommandType.StoredProcedure
            SqlBd.CommandText = strNomeProcedure
        Else

            SqlBd.Parameters.Clear()

        End If
    End Sub

    'asas
    Public Function Incluir() As Integer
        'Tran = objSql.gConAdoBd.BeginTransaction

        Try
            ConfigurarComandoSQL(True, "spProduto_m")
            With SqlBd

                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 1)
                .Parameters.AddWithValue("@INTCODPRODUTO_PK", intCodProduto)
                .Parameters.AddWithValue("@NOMEPRODUTO", strNomeProduto)
                .Parameters.AddWithValue("@DESCRICAO", strDescricao)
                .Parameters.AddWithValue("@VALOR", dblValor)

                Dim INTCODPRODUTO_NOVO As SqlParameter = .Parameters.Add("@INTCODPRODUTO_PK", SqlDbType.Int, 0, "INTCODPRODUTO_PK")
                INTCODPRODUTO_NOVO.Direction = ParameterDirection.Output

                .ExecuteNonQuery()
                Tran.Commit()

                Return Integer.Parse(INTCODPRODUTO_NOVO.Value)
            End With

        Catch Ex As Exception
            Tran.Rollback()
            Throw New Exception("Erro ao inserir dados de Pessoa no banco", Ex)
        Finally
            ConfigurarComandoSQL(False)
        End Try

    End Function

    Public Sub alterar()
        ' Tran = objSql.gConAdoBd.BeginTransaction

        Try
            ConfigurarComandoSQL(True, "spProduto_m")
            With SqlBd

                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 2)
                .Parameters.AddWithValue("@INTCODPRODUTO_PK", intCodProduto)
                .Parameters.AddWithValue("@NOMEPRODUTO", strNomeProduto)
                .Parameters.AddWithValue("@DESCRICAO", strDescricao)
                .Parameters.AddWithValue("@VALOR", dblValor)


                'Dim INTCODPESSOA As SqlParameter = .Parameters.Add("@INTCODPESSOA_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPESSOA.Direction = ParameterDirection.Output

                .ExecuteNonQuery()
                Tran.Commit()

            End With

        Catch Ex As Exception
            Tran.Rollback()
            Throw New Exception("Erro ao alterar dados de Pessoa no banco", Ex)
        Finally
            ConfigurarComandoSQL(False)
        End Try

    End Sub

    Public Sub excluir()
        'Tran = objSql.gConAdoBd.BeginTransaction
        Try
            ConfigurarComandoSQL(True, "spProduto_m")
            With SqlBd

                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 3)
                .Parameters.AddWithValue("@INTCODPRODUTO_PK", intCodProduto)
                .ExecuteNonQuery()
                Tran.Commit()
            End With

        Catch Ex As Exception
            Tran.Rollback()
            Throw New Exception("Erro ao excluir dados de Pessoa no banco", Ex)
        Finally
            ConfigurarComandoSQL(False)
        End Try

    End Sub

End Class
