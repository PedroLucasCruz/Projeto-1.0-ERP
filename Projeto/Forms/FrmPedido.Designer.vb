<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboEmitente = New System.Windows.Forms.ComboBox()
        Me.cboDestino = New System.Windows.Forms.ComboBox()
        Me.txtCodigoPedido = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.lblEmitente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboEmitente
        '
        Me.cboEmitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmitente.FormattingEnabled = True
        Me.cboEmitente.Location = New System.Drawing.Point(83, 86)
        Me.cboEmitente.Name = "cboEmitente"
        Me.cboEmitente.Size = New System.Drawing.Size(230, 21)
        Me.cboEmitente.TabIndex = 1
        '
        'cboDestino
        '
        Me.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestino.FormattingEnabled = True
        Me.cboDestino.Location = New System.Drawing.Point(83, 128)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(230, 21)
        Me.cboDestino.TabIndex = 2
        '
        'txtCodigoPedido
        '
        Me.txtCodigoPedido.Location = New System.Drawing.Point(83, 45)
        Me.txtCodigoPedido.Name = "txtCodigoPedido"
        Me.txtCodigoPedido.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigoPedido.TabIndex = 4
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(83, 210)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(114, 20)
        Me.txtQuantidade.TabIndex = 5
        '
        'cboProduto
        '
        Me.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(83, 169)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(230, 21)
        Me.cboProduto.TabIndex = 6
        '
        'lblEmitente
        '
        Me.lblEmitente.AutoSize = True
        Me.lblEmitente.Location = New System.Drawing.Point(27, 89)
        Me.lblEmitente.Name = "lblEmitente"
        Me.lblEmitente.Size = New System.Drawing.Size(48, 13)
        Me.lblEmitente.TabIndex = 7
        Me.lblEmitente.Text = "Emitente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Destinatario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quantidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "status"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmitente)
        Me.Controls.Add(Me.cboProduto)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtCodigoPedido)
        Me.Controls.Add(Me.cboDestino)
        Me.Controls.Add(Me.cboEmitente)
        Me.Name = "FrmPedido"
        Me.Text = "FrmPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEmitente As ComboBox
    Friend WithEvents cboDestino As ComboBox
    Friend WithEvents txtCodigoPedido As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents cboProduto As ComboBox
    Friend WithEvents lblEmitente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
