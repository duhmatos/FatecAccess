


Public Class frm_gerar
    Private Sub frm_gerar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cmb_tipo.Items.Clear()

        Try
            ' SQL MODIFICADO: Seleciona apenas as colunas 'ra' e 'nome'
            SQL = "SELECT ra, nome FROM tb_usuarios WHERE 1 = 0"
            rs = db.Execute(SQL)

            If rs IsNot Nothing AndAlso rs.State = 1 Then

                For Each f In rs.Fields
                    ' O loop irá adicionar 'ra' e depois 'nome'
                    cmb_tipo.Items.Add(f.Name)
                Next

                rs.Close()
                rs = Nothing

                If cmb_tipo.Items.Count > 0 Then
                    cmb_tipo.SelectedIndex = 0
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar colunas: " & ex.Message, MsgBoxStyle.Critical)

            If rs IsNot Nothing Then
                If rs.State <> 0 Then
                    rs.Close()
                End If
            End If
        End Try
    End Sub


    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub



    Private Sub MENUToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem1.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub SAIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem1.Click
        sair()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        sair()
    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        Try
            ' 1. Salva as datas no formato SQL (YYYY-MM-DD)
            datai = dtp_inicio.Value.ToString("yyyy-MM-dd")
            dataf = dtp_fim.Value.ToString("yyyy-MM-dd")

            ' 2. Salva o termo de busca
            consulta = txt_consulta.Text.Trim()

            ' 3. CORREÇÃO: Verifica se SelectedValue é Nulo antes de acessar .ToString()
            If cmb_tipo.SelectedValue IsNot Nothing Then
                tipo = cmb_tipo.SelectedValue.ToString() ' O valor deve ser 'ra' ou 'nome'
            Else
                ' Se for nulo, atribui um valor padrão seguro (ex: o texto do item, ou uma string vazia)
                tipo = cmb_tipo.Text.Trim()
                If String.IsNullOrEmpty(tipo) Then
                    MsgBox("Selecione um tipo de filtro (RA ou Nome).", MsgBoxStyle.Exclamation)
                    Exit Sub ' Impede a abertura do frm_historico sem filtro
                End If
            End If

            ' 4. Abre o formulário de histórico
            frm_historico.ShowDialog()

        Catch ex As Exception
            MsgBox("Erro ao gerar relatório: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class