Public Class frm_contas

    Private Sub frm_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql_login()
        carregar_dados_login()
        carregar_tipos_dados_login()
    End Sub
    Private Sub dgv_login_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_login.CellContentClick
        Try
            With dgv_login
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    sql = $"select * from tb_login where usuario='{aux_usuario}'"
                    rs = db.Execute(sql)
                    txt_usuario.Text = rs.Fields(1).Value
                    txt_senha.Text = rs.Fields(2).Value
                    If rs.Fields(3).Value = "ativa" Then
                        Rbtn_ativa.Checked = True
                        status_conta = "ativa"
                    Else
                        status_conta = "bloqueada"
                        Rbtn_bloqueada.Checked = True
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir a conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from tb_login where usuario='{aux_usuario}'"
                        rs = db.Execute(sql)
                        carregar_dados_login()
                    End If
                Else
                    Exit Sub
                End If

            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If Rbtn_ativa.Checked = True Then
            status_conta = "ativa"
        Else
            status_conta = "bloqueada"
        End If
        Try
            sql = $"select * from tb_login where usuario='{txt_usuario.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = $"update tb_login set usuario='{txt_usuario.Text}',
                                             senha='{txt_senha.Text}',
                                             status='{status_conta}' where usuario='{txt_usuario.Text}'"
                rs = db.Execute(sql)
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = $"insert into tb_login (usuario, senha, status) values
                        ('{txt_usuario.Text}', '{txt_senha.Text}', '{status_conta}')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_dados_login()
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            txt_usuario.Clear()
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        With dgv_login
            sql = $"select * from tb_login where {cmb_campo.Text} like '{txt_buscar.Text}%'"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False '
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    ''Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
    'Me.Close()
    'Form1.Show()
    'End Sub
End Class
