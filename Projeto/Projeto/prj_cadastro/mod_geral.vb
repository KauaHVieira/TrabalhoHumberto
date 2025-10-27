Module mod_geral
    Public db As New ADODB.Connection 'Variável responsável pelo database
    Public rs As New ADODB.Recordset 'Recordset
    Public diretorio, sql, aux_cpf, aux_usuario, resp, status_conta As String 'Declaração de variáveis
    Public cont As Integer
    Public dir_banco = Application.StartupPath & "\Banco\cadastro.mdb"

    Sub conecta_banco_access()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.OLEDB.Jet.4.0;Data Source=" & dir_banco)
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub conectar_banco_login()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=ALUNO38\SQLEXPRESS;Initial Catalog=login_adsma2;trusted_connection=yes;")
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub conectar_banco()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=ALUNO38\SQLEXPRESS;Initial Catalog=cad_clientes_adsma2;trusted_connection=yes;")
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub conecta_banco_mysql()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=cad_clientes_adsma2;UID=root;PWD=usbw;port=3307;option=3;")
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub conecta_banco_mysql_login()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=login_contas_adsma2;UID=root;PWD=usbw;port=3307;option=3;")
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        With frm_cadastro.dgv_dados
            sql = "select * from tb_clientes order by nome asc"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_dados_login()
        With frm_contas.dgv_login
            sql = "select * from tb_login order by usuario asc"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_tipos_dados_login()
        With frm_contas.cmb_campo.Items
            .Add("USUARIO")
            .Add("STATUS")
        End With
        frm_contas.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_tipos_dados()
        With frm_cadastro.cmb_campo.Items
            .Add("CPF")
            .Add("NOME")
        End With
        frm_cadastro.cmb_campo.SelectedIndex = 1
    End Sub
End Module
