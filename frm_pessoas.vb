Public Class frm_pessoas

    Public perfil As String
    Private Class DataValue
        Private value As String
        Private name As String

        Public Sub New(ByVal value As String, ByVal name As String)
            Me.value = value
            Me.name = name
        End Sub

        Public ReadOnly Property getId As String
            Get
                Return value
            End Get
        End Property

        Public ReadOnly Property getName As String
            Get
                Return name
            End Get
        End Property
    End Class
    Private Sub frm_pessoas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        carregar_dados()

        populateComboBox(cmb_curso, "select idcurso, dscurso from tb_curso")
        populateComboBox(cmb_periodo, "select idperiodo, dsperiodo from tb_periodo")
        populateComboBox(cmb_perfil, "select idperfil, dsperfil from tb_perfil")
        populateComboBox(cmb_acesso, "select idacesso, dsacesso from tb_acesso")
        populateComboBox(cmb_veiculo, "select idveiculo, dsveiculo from tb_veiculo")
        populateComboBox(cmb_status, "select idstatus, dsstatus from tb_status")

        limpar_cadastro()

        If perfil = "convidado" Then
            cmb_perfil.SelectedValue = "4"
            cmb_curso.SelectedValue = "7"
        ElseIf perfil = "terceirizado" Then
            cmb_perfil.SelectedValue = "5"
            cmb_curso.SelectedValue = "8"
        End If
    End Sub

    Private Sub populateComboBox(cobObject As ComboBox, query As String)
        With cobObject
            rs = db.Execute(query)
            Dim testDataSource As New List(Of DataValue)

            Try
                Do While rs.EOF = False
                    Dim aux = New DataValue(rs.Fields(0).Value, rs.Fields(1).Value)
                    testDataSource.Add(aux)
                    rs.MoveNext()
                Loop
                .DataSource = testDataSource
                .DisplayMember = "getName"
                .ValueMember = "getId"
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub


    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .ShowDialog()
                diretorio = .FileName
                diretorio = diretorio.Replace("\", "/")
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro para carregar a imagem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub btn_gravar_Click_1(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If String.IsNullOrEmpty(txt_nome.Text) Or
               String.IsNullOrEmpty(txt_ra.Text) Or
               String.IsNullOrEmpty(cmb_curso.SelectedValue) Or
               String.IsNullOrEmpty(cmb_periodo.SelectedValue) Or
               String.IsNullOrEmpty(cmb_status.SelectedValue) Then
                MsgBox("Campo(s) Vazio(s)", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If


            SQL = $"select * from tb_usuarios where ra='{txt_ra.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = $"insert into tb_usuarios 
                (nome,ra,curso,periodo, perfil,acesso,placa,veiculo,status,foto) 
                value (
                    '{txt_nome.Text}',
                    '{txt_ra.Text}',
                    '{cmb_curso.SelectedValue}',
                    '{cmb_periodo.SelectedValue}', 
                    '{cmb_perfil.SelectedValue}',
                    '{cmb_acesso.SelectedValue}',
                    '{txt_placa.Text}',
                    '{cmb_veiculo.SelectedValue}',
                    '{cmb_status.SelectedValue}',
                    '{diretorio}'
                    )"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"update tb_usuarios set 
                    nome='{txt_nome.Text}',
                    ra='{txt_ra.Text}',
                    curso='{cmb_curso.SelectedValue}',
                    periodo='{cmb_periodo.SelectedValue}',
                    perfil='{cmb_perfil.SelectedValue}',
                    acesso='{cmb_acesso.SelectedValue}',
                    placa='{txt_placa.Text}',
                    veiculo='{cmb_veiculo.SelectedValue}',
                    status='{cmb_status.SelectedValue}',
                    foto='{diretorio}'
                    where ra='{txt_ra.Text}'"
                rs = db.Execute(UCase(SQL))

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            End If
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_ra_LostFocus(sender As Object, e As EventArgs) Handles txt_ra.LostFocus
        Try
            SQL = $"select * from tb_usuarios where ra='{txt_ra.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
            Else
                txt_ra.BackColor = Color.Yellow
                MsgBox("RA já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

        Catch ex As Exception
            MsgBox("RA não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub



    Private Sub txt_ra_DoubleClick(sender As Object, e As EventArgs) Handles txt_ra.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(10).Selected = True Then
                    Dim auxra = .CurrentRow.Cells(2).Value.ToString()

                    SQL = $"select * from tb_usuarios where ra='{auxra}'"
                    Console.WriteLine(SQL)
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        txt_ra.Text = CStr(rs.Fields(0).Value)
                        txt_nome.Text = CStr(rs.Fields(1).Value)
                        cmb_perfil.SelectedValue = CStr(rs.Fields(2).Value)
                        cmb_curso.SelectedValue = CStr(rs.Fields(3).Value)
                        cmb_periodo.SelectedValue = CStr(rs.Fields(4).Value)
                        cmb_acesso.SelectedValue = CStr(rs.Fields(5).Value)
                        txt_placa.Text = CStr(rs.Fields(6).Value)
                        cmb_veiculo.SelectedValue = CStr(rs.Fields(7).Value)
                        cmb_status.SelectedValue = CStr(rs.Fields(8).Value)
                        'diretorio = rs.Fields(9).Value
                        'img_foto.Load(rs.Fields(9).Value)

                        carregar_dados()
                    End If


                ElseIf .CurrentRow.Cells(11).Selected = True Then
                    aux_ra = .CurrentRow.Cells(2).Value
                    SQL = $"select * from tb_usuarios where ra='{aux_ra}'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then

                        resp = MsgBox($"Deseja excluir o ra: {aux_ra}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_usuarios where ra='{aux_ra}'"
                            rs = db.Execute(SQL)
                            carregar_dados()
                        End If
                    End If
                Else
                    Exit Sub
                End If



            End With
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        sair()
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sair()
    End Sub

    Private Sub SAIRCntrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRCntrlToolStripMenuItem.Click
        sair()
    End Sub

    Private Sub MENUToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem1.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

End Class
