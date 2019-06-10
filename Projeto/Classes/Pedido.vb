Imports System.Data.SqlClient

Public Class Pedido
    Public objSql As New Acesso
    Private Tran As SqlTransaction
    Private objConexãoLocal As New Acesso

    'Pedido
    Public STRSITUACAOPEDIDO As String
    Public INTCODEMITENTE As Integer
    Public INTCODDESTINO As Integer

    'ItensPedido
    Public INTCODPEDIDO_FK As Integer
    Public INTCODPRODUTO_FK As Integer
    Public QUANTIDADE As Integer
    Public VALOR As Integer

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
        Dim INTCODPEDIDO_NOVO As SqlParameter = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPedido_m")
            With SqlBd

                '.Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 1)
                .Parameters.AddWithValue("@STRSITUACAOPEDIDO", STRSITUACAOPEDIDO)
                .Parameters.AddWithValue("@INTCODEMITENTE", INTCODEMITENTE)
                .Parameters.AddWithValue("@INTCODDESTINO", INTCODDESTINO)

                INTCODPEDIDO_NOVO = .Parameters.Add("@INTCODPEDIDO_PK", SqlDbType.Int, 0, "intCodReg")
                INTCODPEDIDO_NOVO.Direction = ParameterDirection.Output

                .ExecuteScalar()
                'Tran.Commit()

                Return Integer.Parse(INTCODPEDIDO_NOVO.Value)
            End With

        Catch Ex As Exception
            MsgBox(Ex.ToString)
            'Throw New(EX)
            'Tran.Rollback()

        Finally
            '  objSql.ConfigurarComandoSQL(False)
            '  objConexãoLocal.
            objConn.Close()
        End Try
        Return Integer.Parse(INTCODPEDIDO_NOVO.Value)
    End Function


    Public Sub IncluirItemPedido()
        Dim INTCODPEDIDO_NOVO As SqlParameter = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spPedido_m")
            With SqlBd

                '.Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 2)
                .Parameters.AddWithValue("@INTCODPEDIDO_FK", INTCODPEDIDO_FK)
                .Parameters.AddWithValue("@INTCODPRODUTO_FK", INTCODPRODUTO_FK)
                .Parameters.AddWithValue("@QUANTIDADE", QUANTIDADE)
                .Parameters.AddWithValue("@VALOR", VALOR)

                'INTCODPEDIDO_NOVO = .Parameters.Add("@INTCODPEDIDO_PK", SqlDbType.Int, 0, "intCodReg")
                'INTCODPEDIDO_NOVO.Direction = ParameterDirection.Output

                .ExecuteScalar()
                'Tran.Commit()
                'Return Integer.Parse(INTCODPEDIDO_NOVO.Value)

            End With

        Catch Ex As Exception
            MsgBox(Ex.ToString)

        Finally
            '  objSql.ConfigurarComandoSQL(False)
            '  objConexãoLocal.
            objConn.Close()
        End Try
        'Return Integer.Parse(INTCODPEDIDO_NOVO.Value)
    End Sub


    Public Function PesquisarProximoPedido(ByVal codigo As Integer) As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spConsultarPedido_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 1)
                .Parameters.AddWithValue("@pFiltro", codigo)
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
            Throw New Exception("Erro Pesquisar primeiro", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function


    Public Function PesquisarAnteriorPedido(ByVal codigo As Integer) As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spConsultarPedido_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 2)
                .Parameters.AddWithValue("@pFiltro", codigo)
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
            Throw New Exception("Erro Pesquisar primeiro", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function


    Public Function PesquisarPrimeiroPedido() As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spConsultarPedido_s")
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
            Throw New Exception("Erro Pesquisar primeiro", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function

    Public Function PesquisarUltimoPedido() As SqlDataReader
        Dim dtReaderLocal As SqlDataReader = Nothing
        objConn = New SqlClient.SqlConnection("Data Source = DESKTOP-9N126U5\; INITIAL CATALOG = BaseDeDados; Trusted_Connection=True; MultipleActiveResultSets=True;")
        objConn.Open()

        Try
            ConfigurarComandoSQL(True, "spConsultarPedido_s")
            With SqlBd
                .Transaction = Tran
                .Parameters.AddWithValue("@pTipo", 4)
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
            Throw New Exception("Erro Pesquisar primeiro", Ex)
        Finally
            '  objSql.ConfigurarComandoSQL(False)
            'objConn.Close()
            'dtReader.Close()
        End Try
        Return dtReaderLocal
    End Function


End Class
