Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class frmPessoa
    Dim estado As String = ""
    Dim objPessoa As New Pessoa

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        gravarDados()
    End Sub

    Public Sub gravarDados()

        preencherCampos()
        objPessoa.Incluir()

    End Sub

    Public Sub preencherCampos(Optional ByVal dtReader As SqlDataReader = Nothing)

        If dtReader Is Nothing Then
            With objPessoa
                .strNomePessoa = txtNomePessoa.Text
                .strSobreNome = txtSobreNomePessoa.Text
                .strCpfCnpjPessoa = txtCpfCnpjPessoa.Text
                .strEnderecoPessoa = txtEnderecoPessoa.Text
                .strContatoPessoa = txtContatoPessoa.Text
            End With
        Else
            txtNomePessoa.Text = dtReader!NOMEPESSOA
            txtSobreNomePessoa.Text = dtReader!SOBRENOMEPESSOA
            txtCpfCnpjPessoa.Text = dtReader!CPFCNPJPESSOA
            txtEnderecoPessoa.Text = dtReader!ENDERECOPESSOA
            txtContatoPessoa.Text = dtReader!CONTATOPESSOA
        End If

    End Sub

    Private Sub FrmPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'teste de entrada 
        Console.Write("teste")
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        gravarDados()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'frmPessoaConsultar.MdiParent = Me

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmPessoaConsultar.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravarDados()
    End Sub
End Class