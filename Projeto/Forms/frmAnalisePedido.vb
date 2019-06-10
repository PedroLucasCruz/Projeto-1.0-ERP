Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Class frmAnalisePedido

    Dim QUANTIDADE As String

    Private Function EnviarEmail(ByVal txtProduto As String, ByVal txtQuantidade As String)
        Dim objEnvio As SmtpClient = Nothing
        Dim objEmail As MailMessage = Nothing
        Dim blnRetorno As Boolean = False 'Se for enviado com sucesso vai ficar como true

        Try
            ' objEnvio = New SmtpClient("smtp.gmail.com", "587")
            objEnvio = New SmtpClient("smtp.gmail.com", "587")
            'objEnvio.Credentials = NetworkCredential
            'objEnvio.Host = "smtp.gmail.com"
            objEnvio.EnableSsl = False
            objEnvio.UseDefaultCredentials = False

            objEmail = New MailMessage

            'Enviar destino 
            'objEmail.To.Add(New MailAddress("strDestino", "strNome"))
            objEmail.To.Add(New MailAddress("pedroteste43@gmail.com", "Pedro"))

            'Email (emitente) remetente que será usado par ao envio 
            objEmail.From = New MailAddress("pedroteste43@gmail.com", "Solicitação de estoque para o produto: " & txtProduto)

            objEmail.Priority = MailPriority.High 'Prioridade do email / baixo/ media /alta, no caso está em alta

            'Setar confirmação e leitura
            objEmail.Headers.Add("Disposition-Notification-To", "pedroteste43@gmail.com")

            'Setar a menssagem de texto
            Dim messagem As AlternateView = AlternateView.CreateAlternateViewFromString("Solicitação do produto" & txtProduto & "Quantidade: " & txtQuantidade, Nothing, Mime.MediaTypeNames.Text.Plain)

            Dim credencial As New NetworkCredential("pedroteste43@gmail.com", "erptesteerp43")
            objEnvio.Credentials = credencial

            'Enviar email
            objEnvio.Send(objEmail)

            'Retorna
            blnRetorno = True


        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show(ex.Message)
        Finally
            objEmail = Nothing
            objEnvio = Nothing
        End Try
        Return blnRetorno
    End Function

    Public Sub enviarEmailG(ByVal txtProduto As String, ByVal txtQuantidade As String)
        Try
            Dim smtpServidor As New SmtpClient
            Dim email As New MailMessage
            smtpServidor.UseDefaultCredentials = False
            smtpServidor.Credentials = New NetworkCredential("pedroteste43@gmail.com", "senacodeiosegundafeira")
            smtpServidor.Port = 587
            smtpServidor.EnableSsl = True
            smtpServidor.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress("pedroteste43@gmail.com")
            email.To.Add("pedroteste43@gmail.com")
            email.IsBodyHtml = True
            email.Subject = "pedroteste43@gmail.com"
            email.Body = "Solicitação do produto: " & txtProduto & "Quantidade: " & txtQuantidade
            smtpServidor.Send(email)
            MsgBox("Email Enviado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Dim objPedidoAnalise As New Pedido
    Dim strFuncoes As String

    Public Sub desabilitarControles()
        txtEmitente.Enabled = False
        txtDestino.Enabled = False
        txtProduto.Enabled = False
        txtQuantidade.Enabled = False
        txtData.Enabled = False
        txtCodigo.Enabled = False
    End Sub

    Private Sub FrmAnalisePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dr As SqlDataReader = Nothing
        dr = objPedidoAnalise.PesquisarPrimeiroPedido()
        preencherObjetos(dr)
        dr.Close()

        desabilitarControles()
    End Sub

    Public Sub preencherObjetos(ByVal dr As SqlDataReader)

        While dr.Read = True
            With objPedidoAnalise

                lblStatus.Text = dr!STRSITUACAOPEDIDO
                txtEmitente.Text = dr!NOMEPESSOAEMITENTE
                txtDestino.Text = dr!NOMEPESSOADESTINO
                txtProduto.Text = dr!NOMEPRODUTO
                txtQuantidade.Text = dr!QUANTIDADE
                txtData.Text = dr!dtDATA
                txtCodigo.Text = dr!INTCODPEDIDO_PK

            End With
        End While



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dr As SqlDataReader
        dr = objPedidoAnalise.PesquisarPrimeiroPedido()
        preencherObjetos(dr)
        dr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dr As SqlDataReader
        dr = objPedidoAnalise.PesquisarAnteriorPedido(txtCodigo.Text)
        preencherObjetos(dr)
        dr.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dr As SqlDataReader
        dr = objPedidoAnalise.PesquisarProximoPedido(txtCodigo.Text)
        preencherObjetos(dr)
        dr.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dr As SqlDataReader
        dr = objPedidoAnalise.PesquisarUltimoPedido()
        preencherObjetos(dr)
        dr.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        enviarEmailG(txtProduto.Text, txtQuantidade.Text)
        'If EnviarEmail(txtProduto.Text, txtQuantidade.Text) = True Then
        '    MsgBox("Email enviado com sucesso")
        '    ' Else
        '    ' MsgBox("Falha ao enviar email")
        'End If

    End Sub
End Class