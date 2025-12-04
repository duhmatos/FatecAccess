<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerar))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_ajuda = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_fim = New System.Windows.Forms.Label()
        Me.lbl_inicio = New System.Windows.Forms.Label()
        Me.lbl_consulta = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_consulta = New System.Windows.Forms.TextBox()
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fim = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_gerar = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(436, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 99)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 99)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(245, 133)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(309, 29)
        Me.lbl_titulo.TabIndex = 35
        Me.lbl_titulo.Text = "HISTÓRICO DE ACESSO"
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
        Me.Panel1.Location = New System.Drawing.Point(7, 385)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 58)
        Me.Panel1.TabIndex = 38
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
        'lbl_fim
        '
        Me.lbl_fim.AutoSize = True
        Me.lbl_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_fim.Location = New System.Drawing.Point(24, 215)
        Me.lbl_fim.Name = "lbl_fim"
        Me.lbl_fim.Size = New System.Drawing.Size(74, 20)
        Me.lbl_fim.TabIndex = 39
        Me.lbl_fim.Text = "Data Fim"
        '
        'lbl_inicio
        '
        Me.lbl_inicio.AutoSize = True
        Me.lbl_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_inicio.Location = New System.Drawing.Point(24, 185)
        Me.lbl_inicio.Name = "lbl_inicio"
        Me.lbl_inicio.Size = New System.Drawing.Size(85, 20)
        Me.lbl_inicio.TabIndex = 40
        Me.lbl_inicio.Text = "Data Inicio"
        '
        'lbl_consulta
        '
        Me.lbl_consulta.AutoSize = True
        Me.lbl_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_consulta.Location = New System.Drawing.Point(439, 185)
        Me.lbl_consulta.Name = "lbl_consulta"
        Me.lbl_consulta.Size = New System.Drawing.Size(72, 20)
        Me.lbl_consulta.TabIndex = 42
        Me.lbl_consulta.Text = "Consulta"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_tipo.Location = New System.Drawing.Point(439, 215)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(39, 20)
        Me.lbl_tipo.TabIndex = 41
        Me.lbl_tipo.Text = "Tipo"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(527, 212)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(251, 28)
        Me.cmb_tipo.TabIndex = 4
        '
        'txt_consulta
        '
        Me.txt_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_consulta.Location = New System.Drawing.Point(529, 179)
        Me.txt_consulta.Name = "txt_consulta"
        Me.txt_consulta.Size = New System.Drawing.Size(248, 26)
        Me.txt_consulta.TabIndex = 3
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_inicio.Location = New System.Drawing.Point(129, 182)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(268, 26)
        Me.dtp_inicio.TabIndex = 1
        '
        'dtp_fim
        '
        Me.dtp_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fim.Location = New System.Drawing.Point(129, 215)
        Me.dtp_fim.Name = "dtp_fim"
        Me.dtp_fim.Size = New System.Drawing.Size(268, 26)
        Me.dtp_fim.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 49
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem1})
        Me.MENUToolStripMenuItem.Image = CType(resources.GetObject("MENUToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'MENUToolStripMenuItem1
        '
        Me.MENUToolStripMenuItem1.Image = CType(resources.GetObject("MENUToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem1.Name = "MENUToolStripMenuItem1"
        Me.MENUToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MENUToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.MENUToolStripMenuItem1.Text = "MENU"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAIRToolStripMenuItem1})
        Me.SAIRToolStripMenuItem.Image = CType(resources.GetObject("SAIRToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'SAIRToolStripMenuItem1
        '
        Me.SAIRToolStripMenuItem1.Image = CType(resources.GetObject("SAIRToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SAIRToolStripMenuItem1.Name = "SAIRToolStripMenuItem1"
        Me.SAIRToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.SAIRToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.SAIRToolStripMenuItem1.Text = "SAIR"
        '
        'btn_gerar
        '
        Me.btn_gerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar.Location = New System.Drawing.Point(298, 270)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(228, 40)
        Me.btn_gerar.TabIndex = 5
        Me.btn_gerar.Text = "Gerar Histórico (Ctrl. + H)"
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'frm_gerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtp_fim)
        Me.Controls.Add(Me.dtp_inicio)
        Me.Controls.Add(Me.txt_consulta)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.lbl_consulta)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_inicio)
        Me.Controls.Add(Me.lbl_fim)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_gerar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_gerar"
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
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_ajuda As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_fim As Label
    Friend WithEvents lbl_inicio As Label
    Friend WithEvents lbl_consulta As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents txt_consulta As TextBox
    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents dtp_fim As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_gerar As Button
End Class
