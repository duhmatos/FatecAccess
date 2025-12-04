<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pessoas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pessoas))
        Me.lbl_ra = New System.Windows.Forms.Label()
        Me.txt_ra = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_ = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.CONT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.cmb_curso = New System.Windows.Forms.ComboBox()
        Me.cmb_periodo = New System.Windows.Forms.ComboBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_ajuda = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmb_veiculo = New System.Windows.Forms.ComboBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.cmb_perfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_placa = New System.Windows.Forms.Label()
        Me.lbl_veiculo = New System.Windows.Forms.Label()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.lbl_acesso = New System.Windows.Forms.Label()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRCntrlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_placa = New System.Windows.Forms.MaskedTextBox()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ra
        '
        Me.lbl_ra.AutoSize = True
        Me.lbl_ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ra.Location = New System.Drawing.Point(98, 213)
        Me.lbl_ra.Name = "lbl_ra"
        Me.lbl_ra.Size = New System.Drawing.Size(34, 20)
        Me.lbl_ra.TabIndex = 0
        Me.lbl_ra.Text = "RA"
        '
        'txt_ra
        '
        Me.txt_ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_ra.Location = New System.Drawing.Point(141, 210)
        Me.txt_ra.Mask = "9999999999999"
        Me.txt_ra.Name = "txt_ra"
        Me.txt_ra.Size = New System.Drawing.Size(559, 26)
        Me.txt_ra.TabIndex = 2
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome.Location = New System.Drawing.Point(72, 183)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(60, 20)
        Me.lbl_nome.TabIndex = 2
        Me.lbl_nome.Text = "NOME"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_nome.Location = New System.Drawing.Point(141, 177)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(559, 26)
        Me.txt_nome.TabIndex = 1
        '
        'lbl_
        '
        Me.lbl_.AutoSize = True
        Me.lbl_.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_.Location = New System.Drawing.Point(60, 245)
        Me.lbl_.Name = "lbl_"
        Me.lbl_.Size = New System.Drawing.Size(72, 20)
        Me.lbl_.TabIndex = 5
        Me.lbl_.Text = "CURSO"
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(778, 183)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(116, 127)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 10
        Me.img_foto.TabStop = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CONT, Me.Column3, Me.Column2, Me.Column1, Me.Column4, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column5, Me.Column6})
        Me.dgv_dados.Location = New System.Drawing.Point(0, 464)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(953, 117)
        Me.dgv_dados.TabIndex = 11
        '
        'CONT
        '
        Me.CONT.HeaderText = "CONT"
        Me.CONT.Name = "CONT"
        Me.CONT.Width = 62
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 64
        '
        'Column2
        '
        Me.Column2.HeaderText = "RA"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 47
        '
        'Column1
        '
        Me.Column1.HeaderText = "PERFIL"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 69
        '
        'Column4
        '
        Me.Column4.HeaderText = "CURSO"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "PERIODO"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.HeaderText = "ACESSO"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "PLACA"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 66
        '
        'Column10
        '
        Me.Column10.HeaderText = "VEICULO"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 78
        '
        'Column11
        '
        Me.Column11.HeaderText = "STATUS"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 53
        '
        'Column6
        '
        Me.Column6.HeaderText = "EXCLUIR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 59
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Silver
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(953, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_periodo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.lbl_periodo.Location = New System.Drawing.Point(41, 279)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(88, 20)
        Me.lbl_periodo.TabIndex = 14
        Me.lbl_periodo.Text = "PERíODO"
        '
        'cmb_curso
        '
        Me.cmb_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_curso.FormattingEnabled = True
        Me.cmb_curso.Location = New System.Drawing.Point(141, 242)
        Me.cmb_curso.Name = "cmb_curso"
        Me.cmb_curso.Size = New System.Drawing.Size(559, 28)
        Me.cmb_curso.TabIndex = 3
        '
        'cmb_periodo
        '
        Me.cmb_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_periodo.FormattingEnabled = True
        Me.cmb_periodo.Location = New System.Drawing.Point(141, 276)
        Me.cmb_periodo.Name = "cmb_periodo"
        Me.cmb_periodo.Size = New System.Drawing.Size(559, 28)
        Me.cmb_periodo.TabIndex = 4
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(221, 134)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(310, 29)
        Me.lbl_titulo.TabIndex = 19
        Me.lbl_titulo.Text = "CONTROLE DE ACESSO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(584, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 99)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 99)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.lbl_hora)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_ajuda)
        Me.Panel1.Location = New System.Drawing.Point(0, 574)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 58)
        Me.Panel1.TabIndex = 22
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(659, 13)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(138, 37)
        Me.btn_menu.TabIndex = 35
        Me.btn_menu.Text = "MENU"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Location = New System.Drawing.Point(319, 24)
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
        Me.lbl_hora.Location = New System.Drawing.Point(193, 24)
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
        Me.btn_sair.Location = New System.Drawing.Point(803, 13)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(138, 37)
        Me.btn_sair.TabIndex = 2
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_ajuda
        '
        Me.btn_ajuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajuda.Image = CType(resources.GetObject("btn_ajuda.Image"), System.Drawing.Image)
        Me.btn_ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajuda.Location = New System.Drawing.Point(9, 13)
        Me.btn_ajuda.Name = "btn_ajuda"
        Me.btn_ajuda.Size = New System.Drawing.Size(139, 37)
        Me.btn_ajuda.TabIndex = 1
        Me.btn_ajuda.Text = "AJUDA"
        Me.btn_ajuda.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.Location = New System.Drawing.Point(778, 354)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(116, 45)
        Me.btn_gravar.TabIndex = 10
        Me.btn_gravar.Text = "CONFIRMA"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'cmb_status
        '
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(144, 416)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(556, 28)
        Me.cmb_status.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'cmb_veiculo
        '
        Me.cmb_veiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_veiculo.FormattingEnabled = True
        Me.cmb_veiculo.Location = New System.Drawing.Point(445, 382)
        Me.cmb_veiculo.Name = "cmb_veiculo"
        Me.cmb_veiculo.Size = New System.Drawing.Size(115, 28)
        Me.cmb_veiculo.TabIndex = 8
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.lbl_status.Location = New System.Drawing.Point(54, 424)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(78, 20)
        Me.lbl_status.TabIndex = 29
        Me.lbl_status.Text = "STATUS"
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_foto.Location = New System.Drawing.Point(804, 316)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(56, 20)
        Me.lbl_foto.TabIndex = 30
        Me.lbl_foto.Text = "FOTO"
        '
        'cmb_perfil
        '
        Me.cmb_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Location = New System.Drawing.Point(141, 308)
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(559, 28)
        Me.cmb_perfil.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.Label5.Location = New System.Drawing.Point(60, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PERFIL"
        '
        'lbl_placa
        '
        Me.lbl_placa.AutoSize = True
        Me.lbl_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_placa.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.lbl_placa.Location = New System.Drawing.Point(154, 390)
        Me.lbl_placa.Name = "lbl_placa"
        Me.lbl_placa.Size = New System.Drawing.Size(57, 17)
        Me.lbl_placa.TabIndex = 33
        Me.lbl_placa.Text = "PLACA"
        '
        'lbl_veiculo
        '
        Me.lbl_veiculo.AutoSize = True
        Me.lbl_veiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_veiculo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.lbl_veiculo.Location = New System.Drawing.Point(369, 388)
        Me.lbl_veiculo.Name = "lbl_veiculo"
        Me.lbl_veiculo.Size = New System.Drawing.Size(74, 17)
        Me.lbl_veiculo.TabIndex = 34
        Me.lbl_veiculo.Text = "VEICULO"
        '
        'cmb_acesso
        '
        Me.cmb_acesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Location = New System.Drawing.Point(141, 342)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(559, 28)
        Me.cmb_acesso.TabIndex = 6
        '
        'lbl_acesso
        '
        Me.lbl_acesso.AutoSize = True
        Me.lbl_acesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_acesso.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.lbl_acesso.Location = New System.Drawing.Point(49, 345)
        Me.lbl_acesso.Name = "lbl_acesso"
        Me.lbl_acesso.Size = New System.Drawing.Size(82, 20)
        Me.lbl_acesso.TabIndex = 36
        Me.lbl_acesso.Text = "ACESSO"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(94, 26)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(953, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem1})
        Me.MENUToolStripMenuItem.Image = CType(resources.GetObject("MENUToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'MENUToolStripMenuItem1
        '
        Me.MENUToolStripMenuItem1.Image = CType(resources.GetObject("MENUToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem1.Name = "MENUToolStripMenuItem1"
        Me.MENUToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MENUToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.MENUToolStripMenuItem1.Text = "MENU (Cntrl.+ M)"
        '
        'SAIRToolStripMenuItem1
        '
        Me.SAIRToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAIRCntrlToolStripMenuItem})
        Me.SAIRToolStripMenuItem1.Image = CType(resources.GetObject("SAIRToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SAIRToolStripMenuItem1.Name = "SAIRToolStripMenuItem1"
        Me.SAIRToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.SAIRToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.SAIRToolStripMenuItem1.Text = "SAIR"
        '
        'SAIRCntrlToolStripMenuItem
        '
        Me.SAIRCntrlToolStripMenuItem.Image = CType(resources.GetObject("SAIRCntrlToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAIRCntrlToolStripMenuItem.Name = "SAIRCntrlToolStripMenuItem"
        Me.SAIRCntrlToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.SAIRCntrlToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SAIRCntrlToolStripMenuItem.Text = "SAIR"
        '
        'txt_placa
        '
        Me.txt_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_placa.Location = New System.Drawing.Point(217, 384)
        Me.txt_placa.Mask = "AAAA-9999"
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(86, 26)
        Me.txt_placa.TabIndex = 38
        '
        'frm_pessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 633)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.cmb_acesso)
        Me.Controls.Add(Me.lbl_acesso)
        Me.Controls.Add(Me.lbl_veiculo)
        Me.Controls.Add(Me.lbl_placa)
        Me.Controls.Add(Me.cmb_perfil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.cmb_veiculo)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.cmb_periodo)
        Me.Controls.Add(Me.cmb_curso)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.lbl_)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_ra)
        Me.Controls.Add(Me.lbl_ra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_pessoas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ra As Label
    Friend WithEvents txt_ra As MaskedTextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_ As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_periodo As Label
    Friend WithEvents cmb_curso As ComboBox
    Friend WithEvents cmb_periodo As ComboBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_ajuda As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmb_veiculo As ComboBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_foto As Label
    Friend WithEvents cmb_perfil As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_placa As Label
    Friend WithEvents lbl_veiculo As Label
    Friend WithEvents btn_menu As Button
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents lbl_acesso As Label
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SAIRCntrlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_placa As MaskedTextBox
    Friend WithEvents CONT As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
