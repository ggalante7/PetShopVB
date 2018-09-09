Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public resp As String
    Public diretorio, aux, sql As String
    Public op, operacao, user_logado, cpf, servico, nome_cliente, raca_pet, tipo_pet, hora_marcada As String
    Public cont, cont_caixa, cod_cliente, id_pet, cod_vet, cliente_selec As Integer
    Public valor_compra, valor_parcela, hora, minuto As Double
    Public conexao = Application.StartupPath & "\Banco_Dados\db_petshop.mdb"

    Sub user_login()
        With frm_3_Menu
            .btn_show_acesso.selected = False
            .btn_show_caixa.selected = True
            .btn_show_clientes.selected = False
            .btn_show_consulta.selected = False
            .btn_show_pets.selected = False
            .btn_show_produtos.selected = False
            .pn_caixa.Visible = True
            .pn_produtos.Visible = False
            .pn_clientes.Visible = False
            .pn_acesso_operador.Visible = False
            .pn_acesso_admin.Visible = False
            .pn_consulta.Visible = False
            .pn_pets.Visible = False
            sql = "select * from tb_login where login_user='" & user_logado & "'"
            rs = db.Execute(sql)
            .lbl_user_logado.Text = rs.Fields(4).Value
            limpar_tudo()
        End With

    End Sub

    Sub limpar_tudo()
        limpar_cadastro_cliente()
        limpar_cadastro_func()
        Limpar_caixa()
        limpar_campos_consulta()
        limpar_campos_pets()
        limpar_campos_produtos()
    End Sub

    Sub conexao_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.jet.OLEDB.4.0;data source=" & conexao)
        Catch ex As Exception
            MsgBox("Deu ruim")
        End Try
    End Sub

    Sub carregar_produtos()
        sql = "select * from tb_produtos where quantidade > 0 order by nome asc"
        rs = db.Execute(sql)

        cont = 1

        Do While rs.EOF = False
            With frm_3_Menu.cmb_caixa_produto.Items
                .Add(rs.Fields(1).Value)
                cont = cont + 1
                rs.MoveNext()
            End With
        Loop
    End Sub





    Sub carregar_dados_login()
        sql = "select * from tb_login order by login_user asc"
        rs = db.Execute(sql)
        cont = 1

        With frm_3_Menu.dgw_manutencao
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(9).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub Limpar_caixa()
        With frm_3_Menu
            .dgw_carrinho.Rows.Clear()
            .txt_caixa_cpf.Clear()
            .cmb_caixa_pet.Visible = False
            .Label104.Visible = False
            .Label67.Visible = True
            .txt_caixa_quant.Visible = True
            .txt_caixa_valor.Clear()
            .cmb_caixa_produto.Text = ""
            .txt_caixa_valoru.Clear()
            .txt_caixa_quant.Clear()
            .txt_caixa_quant.Enabled = False
            .cmb_caixa_produto.Enabled = False
            .cmb_caixa_formaPgto.Enabled = False
            .cmb_caixa_formaPgto.Text = ""
            .cmb_caixa_parcelas.Text = ""
            .cmb_caixa_parcelas.Enabled = False
            valor_compra = 0
        End With

    End Sub

    Sub mostrar_dados_produtos()
        frm_3_Menu.txt_produtos_nome.Text = rs.Fields(1).Value
        frm_3_Menu.txt_produtos_valor.Text = rs.Fields(2).Value
        frm_3_Menu.txt_produtos_qtd.Text = rs.Fields(3).Value
        frm_3_Menu.cmb_produtos_categoria.Text = rs.Fields(4).Value
    End Sub



End Module


