<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPessoa
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
        Me.txtNomePessoa = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContatoPessoa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnderecoPessoa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCpfCnpjPessoa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSobreNomePessoa = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomePessoa
        '
        Me.txtNomePessoa.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomePessoa.Location = New System.Drawing.Point(124, 23)
        Me.txtNomePessoa.Name = "txtNomePessoa"
        Me.txtNomePessoa.Size = New System.Drawing.Size(219, 20)
        Me.txtNomePessoa.TabIndex = 0
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNome.Location = New System.Drawing.Point(37, 26)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtContatoPessoa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEnderecoPessoa)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCpfCnpjPessoa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSobreNomePessoa)
        Me.Panel1.Controls.Add(Me.lblNome)
        Me.Panel1.Controls.Add(Me.txtNomePessoa)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 209)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(37, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contato"
        '
        'txtContatoPessoa
        '
        Me.txtContatoPessoa.Location = New System.Drawing.Point(124, 177)
        Me.txtContatoPessoa.Name = "txtContatoPessoa"
        Me.txtContatoPessoa.Size = New System.Drawing.Size(219, 20)
        Me.txtContatoPessoa.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(37, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Endereço"
        '
        'txtEnderecoPessoa
        '
        Me.txtEnderecoPessoa.Location = New System.Drawing.Point(124, 139)
        Me.txtEnderecoPessoa.Name = "txtEnderecoPessoa"
        Me.txtEnderecoPessoa.Size = New System.Drawing.Size(219, 20)
        Me.txtEnderecoPessoa.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(37, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CPF/CNPJ"
        '
        'txtCpfCnpjPessoa
        '
        Me.txtCpfCnpjPessoa.Location = New System.Drawing.Point(124, 100)
        Me.txtCpfCnpjPessoa.Name = "txtCpfCnpjPessoa"
        Me.txtCpfCnpjPessoa.Size = New System.Drawing.Size(219, 20)
        Me.txtCpfCnpjPessoa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(37, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sobre Nome"
        '
        'txtSobreNomePessoa
        '
        Me.txtSobreNomePessoa.Location = New System.Drawing.Point(124, 60)
        Me.txtSobreNomePessoa.Name = "txtSobreNomePessoa"
        Me.txtSobreNomePessoa.Size = New System.Drawing.Size(219, 20)
        Me.txtSobreNomePessoa.TabIndex = 4
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(416, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenuItem5.Text = "Gravar"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem6.Text = "Alterar"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(315, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(416, 294)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "frmPessoa"
        Me.Text = "Cadastro de Pessoas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomePessoa As TextBox
    Private WithEvents lblNome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContatoPessoa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEnderecoPessoa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCpfCnpjPessoa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobreNomePessoa As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
