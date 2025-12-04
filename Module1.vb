Module Module1
    Public diretorio, SQL, aux_ra, aux_login, resp As String
    Public datai, dataf, consulta, tipo As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};" &
                    "SERVER=localhost;" &
                    "DATABASE=fatec_acess;" &
                    "UID=root;" &
                    "PWD=usbw;" &
                    "port=3307;" &
                    "option3;")
            MsgBox("Conexâo OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With frm_pessoas
                .txt_ra.BackColor = Color.White
                .txt_ra.Clear()
                .txt_nome.Clear()
                .cmb_curso.SelectedIndex = -1
                .cmb_periodo.SelectedIndex = -1
                .cmb_perfil.SelectedIndex = -1
                .cmb_veiculo.SelectedIndex = -1
                .cmb_acesso.SelectedIndex = -1
                .cmb_status.SelectedIndex = -1
                .txt_placa.Clear()
                .img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
                .txt_ra.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_dados()
        Try
            With frm_cadastro
                .txt_ra.BackColor = Color.White
                .txt_ra.Clear()
                .txt_nome.Clear()
                .txt_login.Clear()
                .txt_senha.Clear()
                .txt_ra.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = $"select * from tb_usuarios order by ra asc"
            rs = db.Execute(SQL)
            With frm_pessoas.dgv_dados
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_dgv()
        ' Declaração local de SQL, se necessário, ou use a variável global se for o caso
        ' Dim SQL As String 

        Try
            ' 1. EXECUTA A CONSULTA
            SQL = $"SELECT ra, nome, perfil, data, entrada, saida, status, acesso, placa, veiculo FROM tb_historico ORDER BY data ASC"
            ' Nota: Recomenda-se listar as colunas explicitamente em vez de usar *

            rs = db.Execute(SQL)

            ' 2. PREENCHE O DATAGRIDVIEW
            With frm_historico.dgv_dados ' Certifique-se de que frm_historico está ativo!
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,
                         rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value,
                         rs.Fields(8).Value, rs.Fields(9).Value)

                    rs.MoveNext()
                Loop
            End With

            ' 3. FECHA O RECORDSET APÓS O USO
            If rs IsNot Nothing Then rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar o DGV manualmente: " & ex.Message, MsgBoxStyle.Critical)
            If rs IsNot Nothing Then rs.Close() ' Garante o fechamento mesmo em caso de erro

        End Try
    End Sub

    Sub sair()
        Try
            resp = MsgBox("Deseja Sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Sair", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Sub carregar_dgv_consulta()
        Dim rs As Object = Nothing
        Dim cont As Integer ' Necessário para a coluna de numeração

        Try
            ' 1. EXECUTA A CONSULTA
            Dim SQL As String = "SELECT u.ra, u.nome, u.perfil, u.curso, u.periodo, u.acesso, u.placa, u.veiculo, s.dsstatus AS status_desc FROM tb_usuarios u INNER JOIN tb_status s ON u.status = s.idstatus ORDER BY u.nome ASC"
            rs = db.Execute(SQL)

            ' 2. PREENCHE O DATAGRIDVIEW
            With frm_consultar.dgv_dados
                .Rows.Clear()
                cont = 1

                If rs IsNot Nothing AndAlso rs.EOF = False Then
                    Do While rs.EOF = False
                        ' Adiciona 10 VALORES: cont + 9 campos do SQL
                        .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,
         rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, CStr(rs.Fields(8).Value))
                        '                                                                                   
                        ' Use CStr() ou CInt() para forçar o valor a ser lido
                        cont += 1
                        rs.MoveNext()
                    Loop
                End If
            End With

        Catch ex As Exception
            MsgBox("Erro ao carregar o DGV manualmente: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If rs IsNot Nothing Then rs.Close()
        End Try
    End Sub

    Public Sub Filtrar_dgv_Busca(TermoBusca As String, CampoFiltro As String)
        Dim rs As Object = Nothing
        Dim cont As Integer

        If String.IsNullOrEmpty(CampoFiltro) OrElse String.IsNullOrEmpty(TermoBusca) Then
            MsgBox("Selecione um campo e digite um termo de busca.", MsgBoxStyle.Exclamation, "Busca Vazia")
            carregar_dgv_consulta() ' Recarrega tudo se a busca estiver vazia
            Exit Sub
        End If

        Try
            ' Montagem do SQL para busca com LIKE
            Dim SQL As String = $"SELECT u.ra, u.nome, u.perfil, u.curso, u.periodo, u.acesso, u.placa, u.veiculo, s.dsstatus AS status_desc FROM tb_usuarios u INNER JOIN tb_status s ON u.status = s.idstatus WHERE u.{CampoFiltro} LIKE '%{TermoBusca}%' ORDER BY u.nome ASC"
            rs = db.Execute(SQL)

            With frm_consultar.dgv_dados
                .Rows.Clear()
                cont = 1

                If rs IsNot Nothing AndAlso rs.EOF = False Then
                    Do While rs.EOF = False

                        ' Adiciona 10 VALORES: cont + 9 campos do SQL
                        .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,
                                    rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, CStr(rs.Fields(8).Value))

                        cont += 1
                        rs.MoveNext()
                    Loop
                Else
                    MsgBox($"Nenhum usuário encontrado para '{TermoBusca}' no campo '{CampoFiltro}'.", MsgBoxStyle.Information, "Resultado Vazio")
                End If
            End With

        Catch ex As Exception
            MsgBox($"Erro ao filtrar DGV. Verifique se o campo '{CampoFiltro}' está correto. Detalhe: {ex.Message}", MsgBoxStyle.Critical, "Erro de Busca")
        Finally
            If rs IsNot Nothing Then rs.Close()
        End Try
    End Sub

End Module