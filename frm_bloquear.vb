Public Class frm_bloquear
    Private Sub frm_bloquear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        populateComboBox(cmb_status, $"select idstatus, dsstatus from tb_status")

    End Sub
    Private Class DataValue
        ' O ID (value) agora é Integer
        Private value As Integer
        Private name As String

        ' O construtor recebe Integer
        Public Sub New(ByVal value As Integer, ByVal name As String)
            Me.value = value
            Me.name = name
        End Sub

        ' O retorno do getId é Integer
        Public ReadOnly Property getId As Integer
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

    Private Sub populateComboBox(cobObject As ComboBox, query As String)
        Dim rs As Object = Nothing

        With cobObject
            .Items.Clear()

            Try
                rs = db.Execute(query)

                Dim testDataSource As New List(Of DataValue)

                If rs IsNot Nothing AndAlso rs.EOF = False Then
                    Do While rs.EOF = False
                        ' USANDO CInt() PARA CONVERTER O VALOR DO RECORDSET PARA INTEGER
                        Dim aux = New DataValue(CInt(rs.Fields(0).Value), CStr(rs.Fields(1).Value))
                        testDataSource.Add(aux)
                        rs.MoveNext()
                    Loop
                End If

                .DataSource = testDataSource
                .DisplayMember = "getName"
                .ValueMember = "getId"

                If .Items.Count > 0 Then
                    .SelectedIndex = 0
                End If

            Catch ex As Exception
                MsgBox($"Erro ao popular ComboBox: {ex.Message}", MsgBoxStyle.Critical, "ATENÇÃO")
            Finally
                If rs IsNot Nothing Then rs.Close()
            End Try
        End With
    End Sub

    Private Sub CarregarStatusComboBox()
        Dim SQL_Status As String = $"SELECT idstatus, dsstatus FROM tb_status ORDER BY idstatus ASC"
        populateComboBox(cmb_status, SQL_Status)
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
            MsgBox("Erro ao Sair", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub SAIRCntrlSpaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRCntrlSpaceToolStripMenuItem.Click
        sair()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim SQL As String
        Dim rs As Object = Nothing
        ' Tenta converter o valor para Integer, caso seja numérico
        Dim NovoStatus As String = cmb_status.SelectedValue.ToString().Trim()
        Dim RaUsuario As String = txt_ra.Text.Trim()
        Dim NomeUsuario As String = txt_nome.Text.Trim()

        If String.IsNullOrWhiteSpace(RaUsuario) AndAlso String.IsNullOrWhiteSpace(NomeUsuario) Then
            MsgBox("Informe o RA ou o Nome do usuário para realizar a atualização.", MsgBoxStyle.Exclamation, "Dados Faltando")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(NovoStatus) Then
            MsgBox("Selecione o novo Status. O ComboBox de Status está vazio ou sem seleção.", MsgBoxStyle.Exclamation, "Status Vazio")
            Exit Sub
        End If

        Try
            ' 1. MONTAGEM DO COMANDO UPDATE (STATUS SEM ASPAS SIMPLES)
            ' Se status na tb_usuarios for INTEGER, use: status={NovoStatus}
            SQL = $"UPDATE tb_usuarios SET status={NovoStatus} WHERE "

            If Not String.IsNullOrWhiteSpace(RaUsuario) Then
                SQL &= $"ra='{RaUsuario}'"
            End If

            If Not String.IsNullOrWhiteSpace(NomeUsuario) Then
                If Not String.IsNullOrWhiteSpace(RaUsuario) Then
                    SQL &= $" AND nome='{NomeUsuario}'"
                Else
                    SQL &= $"nome='{NomeUsuario}'"
                End If
            End If

            ' 2. EXECUÇÃO
            db.Execute(SQL)

            MsgBox("Status Alterado com sucesso!", MsgBoxStyle.Information, "AVISO")

        Catch ex As Exception
            If ex.Message.ToLower().Contains("foreign key constraint fails") Then
                MsgBox($"ERRO FATAL: O código de status '{NovoStatus}' não existe na tabela tb_status. Por favor, verifique se o ID está corretamente cadastrado na tb_status. Detalhe: {ex.Message}", MsgBoxStyle.Critical, "ERRO DE CHAVE ESTRANGEIRA (FK)")
            Else
                MsgBox($"Erro ao tentar alterar o status: {ex.Message}", MsgBoxStyle.Critical, "ERRO")
            End If
        End Try
    End Sub

    Private Sub txt_ra_LostFocus(sender As Object, e As EventArgs) Handles txt_ra.LostFocus
        Try
            SQL = $"select * from tb_usuarios where ra='{txt_ra.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                txt_ra.BackColor = Color.White
            Else
                txt_ra.BackColor = Color.Yellow
                resp = MsgBox("RA já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("RA não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus
        Try
            SQL = $"select * from tb_usuarios where nome='{txt_nome.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                txt_ra.BackColor = Color.White
            Else
                txt_nome.BackColor = Color.Yellow
                resp = MsgBox("NOME já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("RA não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub MENUCntrlSpaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUCntrlSpaceToolStripMenuItem.Click
        Me.Hide()
        frm_menu.Show()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Me.Hide()
        frm_menu.Show()
    End Sub
End Class