Public Class frm_cadastro
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Try
            resp = MsgBox("Deseja Sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Erro ao sair", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If String.IsNullOrEmpty(txt_nome.Text) Or
               String.IsNullOrEmpty(txt_ra.Text) Or
               String.IsNullOrEmpty(txt_login.Text) Or
               String.IsNullOrEmpty(txt_senha.Text) Then
                MsgBox("Campo(s) Vazio(s)", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If


            SQL = $"select * from tb_login where ra='{txt_ra.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = $"insert into tb_login 
                (nome,ra,login, senha) 
                value (
                    '{txt_nome.Text}',
                    '{txt_ra.Text}',
                    '{txt_login.Text}',
                    '{txt_senha.Text}'
                    )"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar novo administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        limpar_dados()
    End Sub

    Private Sub txt_ra_LostFocus(sender As Object, e As EventArgs) Handles txt_ra.LostFocus

        Try
            SQL = $"select * from tb_login where ra='{txt_ra.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                txt_nome.Focus()
                txt_ra.BackColor = Color.White
            Else
                txt_ra.BackColor = Color.Red
                MsgBox("RA já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

        Catch ex As Exception
            MsgBox("RA não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Private Sub MENUCntrlSpaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUCntrlSpaceToolStripMenuItem.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub SAIRCntrlSpaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRCntrlSpaceToolStripMenuItem.Click
        sair()
    End Sub
End Class