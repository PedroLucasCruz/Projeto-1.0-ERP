Imports System.Data.Common
Imports System.Data.SqlClient

Public Class FrmPedido
    Dim objPedido As New Pedido

    Private Sub LblEmitente_Click(sender As Object, e As EventArgs) Handles lblEmitente.Click

    End Sub

    Private Sub FrmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar_Combo()
        txtCodigoPedido.Enabled = False
    End Sub
    Public Function PopularCombo(ByVal dr As SqlDataReader, ByVal ValueMember As String,
                                 Optional ByVal DisplayMember() As String = Nothing, Optional ByVal Separador As String = " - ",
                                 Optional ByVal bSelecione As Boolean = False, Optional ByVal TextoSelecione As String = "Selecione...",
                                 Optional ByVal bDisplayMember2Coluna As Boolean = False,
                                 Optional ByVal intColunaDisplayMember As Integer = 2) As DataTable
        Dim dt As New DataTable
        Dim ddr As DataRow
        Dim i As Integer
        Dim strDescricao As String = Nothing

        dt = New DataTable("Combo")
        dt.Columns.Add("INTCODPESSOA_PK", GetType(Integer))
        dt.Columns.Add("NOMEPESSOA", GetType(String))

        Try
            If dr.HasRows = True Then

                If bSelecione = True Then
                    ddr = dt.NewRow
                    ddr("INTCODPESSOA_PK") = 0
                    ddr("NOMEPESSOA") = TextoSelecione
                    dt.Rows.Add(ddr)
                End If

                While dr.Read = True
                    ddr = dt.NewRow
                    ddr("INTCODPESSOA_PK") = dr(ValueMember)

                    If DisplayMember IsNot Nothing Then
                        For i = LBound(DisplayMember) To UBound(DisplayMember)
                            strDescricao = strDescricao & dr(DisplayMember(i)) & Separador
                        Next
                        strDescricao = strDescricao.Substring(0, Len(strDescricao) - 3)

                        ddr("NOMEPESSOA") = Trim(strDescricao)
                    ElseIf bDisplayMember2Coluna = True Then
                        ddr("NOMEPESSOA") = dr(intColunaDisplayMember)
                    Else
                        ddr("NOMEPESSOA") = dr("NOMEPESSOA")
                    End If

                    dt.Rows.Add(ddr)
                    strDescricao = ""
                End While

            End If
        Catch Ex As Exception
            MsgBox(Ex.ToString)
            Throw New Exception("Erro mModuloLib | Rotina: PopularCombo", Ex)
        End Try

        Return dt
    End Function


    Public Function PopularComboProduto(ByVal dr As SqlDataReader, ByVal ValueMember As String,
                                 Optional ByVal DisplayMember() As String = Nothing, Optional ByVal Separador As String = " - ",
                                 Optional ByVal bSelecione As Boolean = False, Optional ByVal TextoSelecione As String = "Selecione...",
                                 Optional ByVal bDisplayMember2Coluna As Boolean = False,
                                 Optional ByVal intColunaDisplayMember As Integer = 2) As DataTable
        Dim dt As New DataTable
        Dim ddr As DataRow
        Dim i As Integer
        Dim strDescricao As String = Nothing

        dt = New DataTable("Combo")
        dt.Columns.Add("INTCODPRODUTO_PK", GetType(Integer))
        dt.Columns.Add("NOMEPRODUTO", GetType(String))

        Try
            If dr.HasRows = True Then

                If bSelecione = True Then
                    ddr = dt.NewRow
                    ddr("INTCODPRODUTO_PK") = 0
                    ddr("NOMEPRODUTO") = TextoSelecione
                    dt.Rows.Add(ddr)
                End If

                While dr.Read = True
                    ddr = dt.NewRow
                    ddr("INTCODPRODUTO_PK") = dr(ValueMember)

                    If DisplayMember IsNot Nothing Then
                        For i = LBound(DisplayMember) To UBound(DisplayMember)
                            strDescricao = strDescricao & dr(DisplayMember(i)) & Separador
                        Next
                        strDescricao = strDescricao.Substring(0, Len(strDescricao) - 3)

                        ddr("NOMEPRODUTO") = Trim(strDescricao)
                    ElseIf bDisplayMember2Coluna = True Then
                        ddr("NOMEPRODUTO") = dr(intColunaDisplayMember)
                    Else
                        ddr("NOMEPRODUTO") = dr("NOMEPRODUTO") & " " & dr("VALOR")
                    End If

                    dt.Rows.Add(ddr)
                    strDescricao = ""
                End While

            End If
        Catch Ex As Exception
            MsgBox(Ex.ToString)
            Throw New Exception("Erro mModuloLib | Rotina: PopularCombo", Ex)
        End Try

        Return dt
    End Function


    Private Sub Iniciar_Combo()
        'Dim Dr As SqlDataReader
        Dim objEmpresas As New Pessoa

        Try

            'Combo de emitente
            With cboEmitente
                .ValueMember = "INTCODPESSOA_PK"
                .DisplayMember = "NOMEPESSOA"

                ' Dr = objEmpresas.PesquisarTodosPessoa()

                .DataSource = PopularCombo(objEmpresas.PesquisarTodosPessoaOrigem(), ValueMember:="INTCODPESSOA_PK", bSelecione:=True, TextoSelecione:="Selecione...")
            End With
            cboEmitente.SelectedIndex = 0

            'objEmpresas.objConn.Close()

            'Combo de emitente
            With cboDestino
                .ValueMember = "INTCODPESSOA_PK"
                .DisplayMember = "NOMEPESSOA"

                ' Dr = objEmpresas.PesquisarTodosPessoa()

                .DataSource = PopularCombo(objEmpresas.PesquisarTodosPessoaDestino(), ValueMember:="INTCODPESSOA_PK", bSelecione:=True, TextoSelecione:="Selecione...")
            End With
            cboEmitente.SelectedIndex = 0



            With cboProduto
                .ValueMember = "INTCODPRODUTO_PK"
                .DisplayMember = "NOMEPRODUTO"
                ' Dr = objEmpresas.PesquisarTodosPessoa()

                .DataSource = PopularComboProduto(objEmpresas.PesquisarTodosProdutos(), ValueMember:="INTCODPRODUTO_PK", bSelecione:=True, TextoSelecione:="Selecione...")
            End With
            cboEmitente.SelectedIndex = 0


            'AjustarDropCombo(cboFuncao)


            'Dr.Close()

            'With cboFilialComputador
            '    .ValueMember = "intCod"
            '    .DisplayMember = "strDescricao"

            '    Dr = objEmpresas.RetornarEmpresasPorComputador()
            '    .DataSource = PopularCombo(dr:=Dr, ValueMember:="intCod_Emp", bDisplayMember2Coluna:=True,
            '                               bSelecione:=True, TextoSelecione:="Selecione...", intColunaDisplayMember:=1)

            'End With
            'AjustarDropCombo(cboFilialComputador)
            'cboFilialComputador.SelectedIndex = 0

        Catch ex As Exception
            If ex.InnerException IsNot Nothing Then
                MsgBox(ex.ToString)
            End If
        Finally
            'If Dr IsNot Nothing Then
            '    If Dr.IsClosed = False Then
            '        Dr.Close()
            objEmpresas.objConn.Close()
            '    End If
            'End If
        End Try
    End Sub

    Private Sub GravarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub gravarDados()
        Try
            Dim codigo As Integer = 0
            preencherCamposPedido()
            codigo = objPedido.Incluir()
            txtCodigoPedido.Text = codigo
            preencherCamposPedidoItem(codigo)
            objPedido.IncluirItemPedido()
        Catch ex As Exception
            MsgBox("Erro ao gravar o pedido")
            MsgBox(ex.ToString)
        End Try
        MsgBox("Pedido Gravado com sucesso! Consulte a Analise de pedido")

        'MsgBox(txtCodigoPedido.Text)
    End Sub

    Public Sub preencherCamposPedidoItem(ByVal intCodigoPedido As Integer, Optional ByVal dtReader As SqlDataReader = Nothing)


        If dtReader Is Nothing Then
            With objPedido
                .INTCODPEDIDO_FK = intCodigoPedido
                .INTCODPRODUTO_FK = cboProduto.SelectedValue
                .QUANTIDADE = txtQuantidade.Text
                ' .VALOR = 
            End With
        Else
            ' = dtReader!STRSITUACAOPEDIDO
            'cboEmitente.SelectedValue = dtReader!INTCODEMITENTE
            'cboEmitente.SelectedValue = dtReader!INTCODDESTINO

        End If


    End Sub



    Public Sub preencherCamposPedido(Optional ByVal dtReader As SqlDataReader = Nothing)

        'MsgBox(cboEmitente.SelectedValue.ToString)

        If dtReader Is Nothing Then
            With objPedido
                .STRSITUACAOPEDIDO = "SOLICITADO"
                .INTCODEMITENTE = cboEmitente.SelectedValue
                .INTCODDESTINO = cboDestino.SelectedValue
            End With
        Else
            ' = dtReader!STRSITUACAOPEDIDO
            cboEmitente.SelectedValue = dtReader!INTCODEMITENTE
            cboEmitente.SelectedValue = dtReader!INTCODDESTINO

        End If


    End Sub

    Private Sub GravarToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        gravarDados()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravarDados()

    End Sub
End Class