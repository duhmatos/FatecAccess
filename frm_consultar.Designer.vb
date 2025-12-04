<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consultar))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.lbl_campo = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.btn_ajuda = New System.Windows.Forms.Button()
        Me.cmb_campo = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(417, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 99)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 99)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(174, 139)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(152, 29)
        Me.lbl_titulo.TabIndex = 22
        Me.lbl_titulo.Text = "CONSULTA"
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_buscar.Location = New System.Drawing.Point(90, 171)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(552, 26)
        Me.txt_buscar.TabIndex = 1
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_buscar.Location = New System.Drawing.Point(7, 177)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(83, 20)
        Me.lbl_buscar.TabIndex = 27
        Me.lbl_buscar.Text = "BUSCAR"
        '
        'lbl_campo
        '
        Me.lbl_campo.AutoSize = True
        Me.lbl_campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_campo.Location = New System.Drawing.Point(12, 204)
        Me.lbl_campo.Name = "lbl_campo"
        Me.lbl_campo.Size = New System.Drawing.Size(71, 20)
        Me.lbl_campo.TabIndex = 25
        Me.lbl_campo.Text = "CAMPO"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.Location = New System.Drawing.Point(648, 177)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(116, 45)
        Me.btn_gravar.TabIndex = 3
        Me.btn_gravar.Text = "CONFIRMA"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sair.Location = New System.Drawing.Point(623, 12)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(138, 37)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.lbl_hora)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_ajuda)
        Me.Panel1.Location = New System.Drawing.Point(2, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 58)
        Me.Panel1.TabIndex = 34
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(479, 11)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(138, 37)
        Me.btn_menu.TabIndex = 4
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
        'btn_ajuda
        '
        Me.btn_ajuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajuda.Image = CType(resources.GetObject("btn_ajuda.Image"), System.Drawing.Image)
        Me.btn_ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajuda.Location = New System.Drawing.Point(9, 12)
        Me.btn_ajuda.Name = "btn_ajuda"
        Me.btn_ajuda.Size = New System.Drawing.Size(139, 37)
        Me.btn_ajuda.TabIndex = 6
        Me.btn_ajuda.Text = "AJUDA"
        Me.btn_ajuda.UseVisualStyleBackColor = True
        '
        'cmb_campo
        '
        Me.cmb_campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_campo.FormattingEnabled = True
        Me.cmb_campo.ItemHeight = 20
        Me.cmb_campo.Location = New System.Drawing.Point(90, 201)
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(552, 28)
        Me.cmb_campo.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10})
        Me.dgv_dados.Location = New System.Drawing.Point(16, 267)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(764, 117)
        Me.dgv_dados.TabIndex = 37
        '
        'Column8
        '
        Me.Column8.HeaderText = "cont"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 53
        '
        'Column1
        '
        Me.Column1.HeaderText = "ra"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.HeaderText = "nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 58
        '
        'Column3
        '
        Me.Column3.HeaderText = "perfil"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 54
        '
        'Column4
        '
        Me.Column4.HeaderText = "curso"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 58
        '
        'Column5
        '
        Me.Column5.HeaderText = "periodo"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.HeaderText = "acesso"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 66
        '
        'Column7
        '
        Me.Column7.HeaderText = "placa"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 58
        '
        'Column9
        '
        Me.Column9.HeaderText = "veiculo"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 66
        '
        'Column10
        '
        Me.Column10.HeaderText = "status"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 60
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 24)
        Me.MenuStrip1.TabIndex = 38
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
        'frm_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 450)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.cmb_campo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.lbl_buscar)
        Me.Controls.Add(Me.lbl_campo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_consultar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents lbl_buscar As Label
    Friend WithEvents lbl_campo As Label
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents btn_ajuda As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents cmb_campo As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MENUToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
