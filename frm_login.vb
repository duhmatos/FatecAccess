Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        conecta_banco_mysql()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            Debug.WriteLine(txt_senha.Text)

            If String.IsNullOrEmpty(txt_login.Text) Or String.IsNullOrEmpty(txt_senha.Text) Then
                MsgBox("Campo(s) Vazio(s)", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If

            SQL = $"select * from tb_login where login='{txt_login.Text}' and senha='{txt_senha.Text}'"
            rs = db.Execute(SQL)
            'MsgBox(rs.RecordCount.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            If rs.EOF = True Then
                If rs.RecordCount > 0 Then
                Else
                    MsgBox("Credenciais Incorretas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                    Return
                End If
            End If
            'End If
            aux_login = txt_login.Text
            Me.Hide()
            frm_menu.Show() 'Chamada de formulários
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class