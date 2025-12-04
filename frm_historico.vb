Imports System.Globalization
Imports System.IO


Public Class frm_historico
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Try
            resp = MsgBox("Deseja Sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Sair", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        Me.Hide()
    End Sub
    ' Evento Load que utiliza as variáveis salvas
    Private Sub frm_historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        ' Atribuição das variáveis globais aos Labels
        lbl_inicio.Text = datai
        lbl_fim.Text = dataf
        lbl_consulta.Text = consulta
        lbl_tipo.Text = tipo
        carregar_dgv()
    End Sub

    Private Sub CarregarDetalhesUsuario(ra_usuario As String)
        Dim rs_usuario As Object
        Dim SQL_Usuario As String

        If String.IsNullOrEmpty(ra_usuario) Then
            ' Limpar os campos de detalhe aqui
            ' Ex: txt_ra.Text = ""
            Exit Sub
        End If

        Try
            ' Busca na tb_usuarios
            SQL_Usuario = $"SELECT * FROM tb_usuarios WHERE ra='{ra_usuario}'"
            rs_usuario = db.Execute(SQL_Usuario)

            If rs_usuario IsNot Nothing AndAlso rs_usuario.EOF = False Then

                Console.WriteLine("Detalhes do usuário carregados via método separado.")

                ' AJUSTE SEUS CONTROLES AQUI:
                ' Ex: txt_ra.Text = CStr(rs_usuario.Fields(0).Value) 
                ' Ex: txt_nome.Text = CStr(rs_usuario.Fields(1).Value) 

            End If

            If rs_usuario IsNot Nothing Then rs_usuario.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar detalhes do usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MENUToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem1.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub SAIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem1.Click
        sair()
    End Sub


    Private Sub btn_baixar_Click(sender As Object, e As EventArgs) Handles btn_baixar.Click
        Dim DesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim FileName As String = $"Historico_Acessos_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt"
        Dim FullPath As String = Path.Combine(DesktopPath, FileName)

        Dim StreamWriter As System.IO.StreamWriter = Nothing
        Dim HeaderLine As New System.Text.StringBuilder
        Dim DataLine As New System.Text.StringBuilder

        Try
            StreamWriter = New System.IO.StreamWriter(FullPath)

            For Each column As DataGridViewColumn In dgv_dados.Columns
                HeaderLine.Append(column.HeaderText).Append(vbTab)
            Next
            StreamWriter.WriteLine(HeaderLine.ToString().TrimEnd(vbTab.ToCharArray()))

            For Each row As DataGridViewRow In dgv_dados.Rows
                If row.IsNewRow Then Continue For

                DataLine.Clear()

                For Each cell As DataGridViewCell In row.Cells
                    Dim CellValue As String = If(cell.Value Is Nothing, "", cell.Value.ToString().Replace(vbCrLf, " ").Replace(vbLf, " "))
                    DataLine.Append(CellValue).Append(vbTab)
                Next

                StreamWriter.WriteLine(DataLine.ToString().TrimEnd(vbTab.ToCharArray()))
            Next

            StreamWriter.Close()
            MsgBox($"Dados salvos com sucesso em:{vbCrLf}{FullPath}", MsgBoxStyle.Information, "Exportação Concluída")

        Catch ex As Exception
            MsgBox($"Erro ao salvar o arquivo:{vbCrLf}{ex.Message}", MsgBoxStyle.Critical, "Erro de Exportação")
        Finally
            If Not StreamWriter Is Nothing Then
                StreamWriter.Dispose()
            End If
        End Try
    End Sub

End Class