Imports System.Linq.Expressions
Imports System.Data.OleDb ' Adicionado para suportar objetos de banco de dados

Public Class frm_menu
    Public credenciais As String
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        conecta_banco_mysql()

        With aux_login
            SQL = $"select * from tb_login where login='{aux_login}'"
            rs = db.Execute(SQL)
        End With

        If rs.EOF = False Then
            lbl_nome.Text = rs.Fields(2).Value
            lbl_ra.Text = rs.Fields(3).Value
        End If

        MsgBox(lbl_nome.Text, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Bem-Vindo!")


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay.ToString("HH:mm:ss")
        lbl_data.Text = Now.Date.ToString("dd/MM/yyyy")
    End Sub

    ' Botoes Navegacao (Barra superior) 
    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        sair()
    End Sub

    Private Sub CADASTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTToolStripMenuItem.Click
        Try
            frm_cadastro.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Cadastro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ConvidadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvidadosToolStripMenuItem.Click
        Try
            frm_gerar.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Convidado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    ' Botoes Navegacao (interface)
    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Criar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        sair()
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Alterar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Try
            frm_consultar.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Consultar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Excluir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub



    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Cadastrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Alterar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Try
            frm_consultar.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Consultar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Try
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Excluir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ConvidadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConvidadosToolStripMenuItem1.Click
        Try
            frm_pessoas.perfil = "convidado"
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Convidado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub TercerizadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TercerizadosToolStripMenuItem1.Click
        Try
            frm_pessoas.perfil = "terceirizado"
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Terceirizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_convidado_Click(sender As Object, e As EventArgs) Handles btn_convidado.Click
        Try
            frm_pessoas.perfil = "convidado"
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Convidado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_terceirizado_Click(sender As Object, e As EventArgs) Handles btn_terceirizado.Click
        Try
            frm_pessoas.perfil = "terceirizado"
            frm_pessoas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar Terceirizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        Try
            frm_gerar.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BloquearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloquearToolStripMenuItem.Click
        Try
            frm_bloquear.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Bloquear", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub btn_bloquear_Click(sender As Object, e As EventArgs) Handles btn_bloquear.Click
        Try
            frm_bloquear.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Bloquear", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
            End
        End Try
    End Sub
End Class