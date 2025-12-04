<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_ra = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_ra = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_ajuda = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUCntrlSpaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRCntrlSpaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(430, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 99)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 99)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(149, 150)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(414, 29)
        Me.lbl_titulo.TabIndex = 29
        Me.lbl_titulo.Text = "CADASTRO DE ADMINISTRADOR"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_login.Location = New System.Drawing.Point(76, 262)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(64, 20)
        Me.lbl_login.TabIndex = 27
        Me.lbl_login.Text = "LOGIN"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_nome.Location = New System.Drawing.Point(154, 194)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(471, 26)
        Me.txt_nome.TabIndex = 1
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome.Location = New System.Drawing.Point(88, 200)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(60, 20)
        Me.lbl_nome.TabIndex = 25
        Me.lbl_nome.Text = "NOME"
        '
        'txt_ra
        '
        Me.txt_ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_ra.Location = New System.Drawing.Point(154, 227)
        Me.txt_ra.Mask = "99999999999"
        Me.txt_ra.Name = "txt_ra"
        Me.txt_ra.Size = New System.Drawing.Size(471, 26)
        Me.txt_ra.TabIndex = 2
        Me.txt_ra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ra
        '
        Me.lbl_ra.AutoSize = True
        Me.lbl_ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ra.Location = New System.Drawing.Point(106, 230)
        Me.lbl_ra.Name = "lbl_ra"
        Me.lbl_ra.Size = New System.Drawing.Size(34, 20)
        Me.lbl_ra.TabIndex = 23
        Me.lbl_ra.Text = "RA"
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(493, 12)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(138, 37)
        Me.btn_menu.TabIndex = 6
        Me.btn_menu.Text = "MENU"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Location = New System.Drawing.Point(319, 23)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(36, 16)
        Me.lbl_data.TabIndex = 16
        Me.lbl_data.Text = "Data"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Location = New System.Drawing.Point(193, 23)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(37, 16)
        Me.lbl_hora.TabIndex = 15
        Me.lbl_hora.Text = "Hora"
        '
        'btn_sair
        '
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sair.Location = New System.Drawing.Point(637, 12)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(138, 37)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_ajuda
        '
        Me.btn_ajuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajuda.Image = CType(resources.GetObject("btn_ajuda.Image"), System.Drawing.Image)
        Me.btn_ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajuda.Location = New System.Drawing.Point(9, 12)
        Me.btn_ajuda.Name = "btn_ajuda"
        Me.btn_ajuda.Size = New System.Drawing.Size(139, 37)
        Me.btn_ajuda.TabIndex = 8
        Me.btn_ajuda.Text = "AJUDA"
        Me.btn_ajuda.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.lbl_hora)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_ajuda)
        Me.Panel1.Location = New System.Drawing.Point(1, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 58)
        Me.Panel1.TabIndex = 32
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_senha.Location = New System.Drawing.Point(154, 293)
        Me.txt_senha.Mask = "999999999"
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(471, 26)
        Me.txt_senha.TabIndex = 4
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_senha.Location = New System.Drawing.Point(70, 293)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(70, 20)
        Me.lbl_senha.TabIndex = 33
        Me.lbl_senha.Text = "SENHA"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_login.Location = New System.Drawing.Point(154, 261)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(471, 26)
        Me.txt_login.TabIndex = 3
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.Location = New System.Drawing.Point(657, 294)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(116, 45)
        Me.btn_gravar.TabIndex = 5
        Me.btn_gravar.Text = "CONFIRMA"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(785, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUCntrlSpaceToolStripMenuItem})
        Me.MENUToolStripMenuItem.Image = CType(resources.GetObject("MENUToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'MENUCntrlSpaceToolStripMenuItem
        '
        Me.MENUCntrlSpaceToolStripMenuItem.Image = CType(resources.GetObject("MENUCntrlSpaceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUCntrlSpaceToolStripMenuItem.Name = "MENUCntrlSpaceToolStripMenuItem"
        Me.MENUCntrlSpaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MENUCntrlSpaceToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MENUCntrlSpaceToolStripMenuItem.Text = "MENU"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAIRCntrlSpaceToolStripMenuItem})
        Me.SAIRToolStripMenuItem.Image = CType(resources.GetObject("SAIRToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'SAIRCntrlSpaceToolStripMenuItem
        '
        Me.SAIRCntrlSpaceToolStripMenuItem.Image = CType(resources.GetObject("SAIRCntrlSpaceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAIRCntrlSpaceToolStripMenuItem.Name = "SAIRCntrlSpaceToolStripMenuItem"
        Me.SAIRCntrlSpaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.SAIRCntrlSpaceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SAIRCntrlSpaceToolStripMenuItem.Text = "SAIR"
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 416)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_ra)
        Me.Controls.Add(Me.lbl_ra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_ra As MaskedTextBox
    Friend WithEvents lbl_ra As Label
    Friend WithEvents btn_menu As Button
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_ajuda As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUCntrlSpaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRCntrlSpaceToolStripMenuItem As ToolStripMenuItem
End Class
