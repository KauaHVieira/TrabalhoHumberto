Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdivinharNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdivinharNúmeroToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\jogosorteio.bat")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Try
            frm_cadastro.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub OperadoresMatemáticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperadoresMatemáticosToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\operadoresbat.bat")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub JoKenPoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JoKenPoToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\ppt.bat")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub SoletrandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoletrandoToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\VBScript\soletrandoHumberto.vbs")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub AutomaçãoDeLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomaçãoDeLoginToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Python\Email.py")
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        Try
            frm_contas.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja reamente sair da aplicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
