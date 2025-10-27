Public Class frm_login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql_login()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        sql = $"select * from tb_login where usuario='{txt_usuario.Text}' AND senha='{txt_senha.Text}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(3).Value = "ativa" Then
                Try
                    FormUsuario.ShowDialog()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End Try
            Else
                MsgBox("Conta Bloqueada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If

        ElseIf txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
            Form1.ShowDialog()
            Me.Hide()
        Else
            MsgBox("Credenciais inválidas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_usuario.Focus()
        End If
    End Sub
End Class