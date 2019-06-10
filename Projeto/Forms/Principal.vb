Imports System.Data.SqlClient

Public Class Form1

    Private objConexão As New Acesso
    Private Sub Button1_Click(sender As Object, e As EventArgs)


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
        dt.Columns.Add("intCod", GetType(Integer))
        dt.Columns.Add("strDescricao", GetType(String))

        Try
            If dr.HasRows Then

                If bSelecione = True Then
                    ddr = dt.NewRow
                    ddr("intCod") = 0
                    ddr("strDescricao") = TextoSelecione
                    dt.Rows.Add(ddr)
                End If

                While dr.Read = True
                    ddr = dt.NewRow
                    ddr("intCod") = dr(ValueMember)

                    If DisplayMember IsNot Nothing Then
                        For i = LBound(DisplayMember) To UBound(DisplayMember)
                            strDescricao = strDescricao & dr(DisplayMember(i)) & Separador
                        Next
                        strDescricao = strDescricao.Substring(0, Len(strDescricao) - 3)

                        ddr("strDescricao") = Trim(strDescricao)
                    ElseIf bDisplayMember2Coluna = True Then
                        ddr("strDescricao") = dr(intColunaDisplayMember)
                    Else
                        ddr("strDescricao") = dr("Descrição")
                    End If

                    dt.Rows.Add(ddr)
                    strDescricao = ""
                End While

            End If
        Catch Ex As Exception
            Throw New Exception("Erro PopularCombo", Ex)
        End Try

        Return dt
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    objConexão.conectar()
        'Catch ex As Exception
        '    MsgBox("Erro ao conectar com o banco")
        '    objConexão.fechar()
        'End Try

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'MsgBox("Menu de cliente!")
        frmPessoa.MdiParent = Me
        frmPessoa.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        MsgBox("Menu Produto")
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FrmPedido.MdiParent = Me
        FrmPedido.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmAnalisePedido.MdiParent = Me
        frmAnalisePedido.Show()
    End Sub
End Class
