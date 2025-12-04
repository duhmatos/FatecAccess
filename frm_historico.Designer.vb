<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_historico))
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_ajuda = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_baixar = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_novo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_inicio = New System.Windows.Forms.Label()
        Me.lbl_fim = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_consulta = New System.Windows.Forms.Label()
        Me.lbl_i = New System.Windows.Forms.Label()
        Me.lbl_f = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrmhistoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FrmhistoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(493, 12)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(138, 37)
        Me.btn_menu.TabIndex = 3
        Me.btn_menu.Text = "MENU"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Location = New System.Drawing.Point(280, 23)
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
        Me.btn_sair.TabIndex = 4
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
        Me.btn_ajuda.TabIndex = 5
        Me.btn_ajuda.Text = "AJUDA"
        Me.btn_ajuda.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(431, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 99)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 99)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(23, 144)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(309, 29)
        Me.lbl_titulo.TabIndex = 39
        Me.lbl_titulo.Text = "HISTÓRICO DE ACESSO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_baixar)
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.lbl_hora)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_ajuda)
        Me.Panel1.Location = New System.Drawing.Point(2, 542)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 58)
        Me.Panel1.TabIndex = 42
        '
        'btn_baixar
        '
        Me.btn_baixar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_baixar.Image = CType(resources.GetObject("btn_baixar.Image"), System.Drawing.Image)
        Me.btn_baixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_baixar.Location = New System.Drawing.Point(349, 12)
        Me.btn_baixar.Name = "btn_baixar"
        Me.btn_baixar.Size = New System.Drawing.Size(138, 37)
        Me.btn_baixar.TabIndex = 2
        Me.btn_baixar.Text = "BAIXAR"
        Me.btn_baixar.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv_dados.Location = New System.Drawing.Point(18, 266)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(759, 270)
        Me.dgv_dados.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.HeaderText = "ra"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.HeaderText = "nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 58
        '
        'Column3
        '
        Me.Column3.HeaderText = "perfil"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 54
        '
        'Column4
        '
        Me.Column4.HeaderText = "data"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 53
        '
        'Column5
        '
        Me.Column5.HeaderText = "entrada"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 68
        '
        'Column6
        '
        Me.Column6.HeaderText = "saida"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 57
        '
        'Column7
        '
        Me.Column7.HeaderText = "status"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "acesso"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 66
        '
        'Column9
        '
        Me.Column9.HeaderText = "placa"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 58
        '
        'Column10
        '
        Me.Column10.HeaderText = "veiculo"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 66
        '
        'btn_novo
        '
        Me.btn_novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo.Image = CType(resources.GetObject("btn_novo.Image"), System.Drawing.Image)
        Me.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_novo.Location = New System.Drawing.Point(527, 216)
        Me.btn_novo.Name = "btn_novo"
        Me.btn_novo.Size = New System.Drawing.Size(238, 37)
        Me.btn_novo.TabIndex = 1
        Me.btn_novo.Text = "NOVO PERÍODO"
        Me.btn_novo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lbl_inicio
        '
        Me.lbl_inicio.AutoSize = True
        Me.lbl_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_inicio.Location = New System.Drawing.Point(90, 182)
        Me.lbl_inicio.Name = "lbl_inicio"
        Me.lbl_inicio.Size = New System.Drawing.Size(44, 20)
        Me.lbl_inicio.TabIndex = 44
        Me.lbl_inicio.Text = "inicio"
        '
        'lbl_fim
        '
        Me.lbl_fim.AutoSize = True
        Me.lbl_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_fim.Location = New System.Drawing.Point(90, 216)
        Me.lbl_fim.Name = "lbl_fim"
        Me.lbl_fim.Size = New System.Drawing.Size(30, 20)
        Me.lbl_fim.TabIndex = 45
        Me.lbl_fim.Text = "fim"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_tipo.Location = New System.Drawing.Point(720, 182)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(45, 20)
        Me.lbl_tipo.TabIndex = 47
        Me.lbl_tipo.Text = "TIPO"
        '
        'lbl_consulta
        '
        Me.lbl_consulta.AutoSize = True
        Me.lbl_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_consulta.Location = New System.Drawing.Point(523, 182)
        Me.lbl_consulta.Name = "lbl_consulta"
        Me.lbl_consulta.Size = New System.Drawing.Size(95, 20)
        Me.lbl_consulta.TabIndex = 46
        Me.lbl_consulta.Text = "CONSULTA"
        '
        'lbl_i
        '
        Me.lbl_i.AutoSize = True
        Me.lbl_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_i.Location = New System.Drawing.Point(24, 182)
        Me.lbl_i.Name = "lbl_i"
        Me.lbl_i.Size = New System.Drawing.Size(62, 20)
        Me.lbl_i.TabIndex = 48
        Me.lbl_i.Text = "INICIO:"
        '
        'lbl_f
        '
        Me.lbl_f.AutoSize = True
        Me.lbl_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_f.Location = New System.Drawing.Point(24, 216)
        Me.lbl_f.Name = "lbl_f"
        Me.lbl_f.Size = New System.Drawing.Size(41, 20)
        Me.lbl_f.TabIndex = 49
        Me.lbl_f.Text = "FIM:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip1.TabIndex = 50
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
        'FrmhistoricoBindingSource
        '
        Me.FrmhistoricoBindingSource.DataSource = GetType(prj_cad_adsva2.frm_historico)
        '
        'frm_historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 601)
        Me.Controls.Add(Me.lbl_f)
        Me.Controls.Add(Me.lbl_i)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_consulta)
        Me.Controls.Add(Me.lbl_fim)
        Me.Controls.Add(Me.lbl_inicio)
        Me.Controls.Add(Me.btn_novo)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_historico"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FrmhistoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menu As Button
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_ajuda As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_baixar As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents btn_novo As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_inicio As Label
    Friend WithEvents lbl_fim As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_consulta As Label
    Friend WithEvents lbl_i As Label
    Friend WithEvents lbl_f As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FrmhistoricoBindingSource As BindingSource
End Class
