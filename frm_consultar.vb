Imports System.Security.Cryptography.X509Certificates

Public Class frm_consultar
    Private Sub frm_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        carregar_dgv_consulta()

        ' 1. Carrega o DGV com todos os dados
        carregar_dgv_consulta()

        ' 2. Popula o ComboBox de Campos com as opções de busca
        cmb_campo.Items.Clear()
        cmb_campo.Items.Add("ra")
        cmb_campo.Items.Add("nome")
        ' Adicione outras colunas que deseja buscar (ex: "perfil", "curso")
        cmb_campo.SelectedIndex = 0


        'cmb_campo.Items.Clear()

        'Try
        '    ' SQL MODIFICADO: Seleciona apenas as colunas 'ra' e 'nome'
        '    SQL = "SELECT ra, nome FROM tb_usuarios WHERE 1 = 0"
        '    rs = db.Execute(SQL)

        '    If rs IsNot Nothing AndAlso rs.State = 1 Then

        '        For Each f In rs.Fields
        '            ' O loop irá adicionar 'ra' e depois 'nome'
        '            cmb_campo.Items.Add(f.Name)
        '        Next

        '        rs.Close()
        '        rs = Nothing

        '        If cmb_campo.Items.Count > 0 Then
        '            cmb_campo.SelectedIndex = 0
        '        End If
        '    End If

        'Catch ex As Exception
        '    MsgBox("Erro ao carregar colunas: " & ex.Message, MsgBoxStyle.Critical)

        '    If rs IsNot Nothing Then
        '        If rs.State <> 0 Then
        '            rs.Close()
        '        End If
        '    End If
        'End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
        lbl_data.Text = Now.Date
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = $"select * from tb_usuarios where {cmb_campo.SelectedValue} like '{txt_buscar.Text}%' order by nome asc"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub
    Public busca, campo As String

    'Private Sub btn_gravar_click(sender As Object, e As EventArgs) Handles btn_gravar.Click

    '    txt_buscar.Text =  busca
    '    cmb_campo.SelectedValue = campo



    '    SQL = $"insert into tb_usuarios 
    '            (nome,ra,curso,periodo, perfil,acesso,placa,veiculo,status,foto) 
    '            value (
    '                '{txt_buscar.Text}',
    '                '{cmb_campo.SelectedValue}'
    '                )"

    '    rs = db.Execute(UCase(SQL))

    '    MsgBox("dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso")
    'End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

        ' 1. Obtém o termo de busca do TextBox
        Dim busca As String = txt_buscar.Text.Trim()

        ' 2. Obtém a coluna a ser filtrada do ComboBox
        Dim campo As String
        If cmb_campo.SelectedItem IsNot Nothing Then
            campo = cmb_campo.SelectedItem.ToString().Trim()
        Else
            MsgBox("Selecione um campo de busca válido.", MsgBoxStyle.Exclamation, "Erro de Campo")
            Exit Sub
        End If

        ' 3. Executa a rotina de filtro
        Filtrar_dgv_Busca(busca, campo)

        ' NOTA: A lógica de INSERT foi removida, pois este botão está sendo usado para CONSULTAR.
    End Sub
    Private Sub SAIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem1.Click
        sair()
    End Sub

    Private Sub MENUToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem1.Click
        frm_menu.Show()
        Me.Hide()
    End Sub
End Class