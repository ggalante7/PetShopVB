Public Class frm_3_Menu

#Region "BLOCO - FORM LOAD"


    Private Sub frm_3_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_produtos()
        Dim toolTip As New ToolTip()
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 1000
        toolTip.ReshowDelay = 500
        toolTip.ShowAlways = True
        toolTip.SetToolTip(btn_logout, "LogOut")
        toolTip.SetToolTip(btn_close, "Fechar")
        toolTip.SetToolTip(btn_minimize, "Minimizar")





        lbl_user_logado.Text = user_logado

        With cmb_acesso2_tipo_parametro.Items
            .Add("login_user")
            .Add("email_user")
        End With

        cmb_func_contatipo.Items.Clear()
        With cmb_func_contatipo.Items
            .Add("Administrador")
            .Add("Operador")
        End With

        With cmb_func_perguntas.Items
            .Add("Nome do seu primeiro animal de estimacao")
            .Add("Filme favorito")
            .Add("Time do coracao")
            .Add("Melhor musica")
            .Add("Livro favorito")
            .Add("Melhor jogo on-line")
        End With

        With cmb_caixa_formaPgto.Items
            cmb_caixa_formaPgto.Items.Clear()
            .Add("À vista")
            .Add("Parcelado")
        End With

        With cmb_pet_tipo.Items
            .Add("Cachorro")
            .Add("Gato")
            .Add("Pássaro")
            .Add("Roedor")
            .Add("Hamster")
            .Add("Outro...")
        End With

        With cmb_produtos_categoria.Items
            .Add("Brinquedos")
            .Add("Roupas")
            .Add("Rações")
            .Add("Higiene")
            .Add("Medicações")
            .Add("Outros")
        End With

        With cmb_produtos_pesquisa.Items
            .Add("nome")
            .Add("codigo")
            .Add("categoria")
        End With

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = (DateTime.Now.ToString("HH:mm"))
        lbl_data.Text = (DateTime.Now.ToString("dd/MM/yyyy"))
    End Sub

#End Region

#Region "BLOCO - MENU"
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If (sidemenu.Width = 65) Then
            sidemenu.Width = 215
            pic_logo01.Visible = True
            pic_logo02.Visible = False
        Else
            sidemenu.Width = 65
            pic_logo01.Visible = False
            pic_logo02.Visible = True
        End If
    End Sub
#End Region

#Region "BLOCO - CONSULTA"
    Private Sub btn_show_consulta_Click(sender As Object, e As EventArgs) Handles btn_show_consulta.Click
        limpar_cadastro_cliente()
        limpar_cadastro_func()
        limpar_campos_consulta()
        limpar_campos_produtos()


        pn_caixa.Visible = False
        pn_produtos.Visible = False
        pn_clientes.Visible = False
        pn_acesso_operador.Visible = False
        pn_acesso_admin.Visible = False
        pn_consulta.Visible = True
        pn_pets.Visible = False

    End Sub

    Private Sub btn_consulta_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_consulta_pesquisar.Click
        If txt_consulta_cpf.Text = "   .   .   -" Then
            MsgBox("Por favor digite o CPF do Cliente para efetuar o agendamento")
            Exit Sub
        Else
            sql = "select * from tb_clientes where cpf_cliente='" + txt_consulta_cpf.Text + "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                Dim opc = MsgBox("Cpf não registrado, deseja cadastrar cliente?", vbYesNo)
                If opc = MsgBoxResult.Yes Then
                    btn_show_consulta.selected = False
                    btn_show_clientes.selected = True
                    pn_consulta.Visible = False
                    pn_clientes.Visible = True
                Else
                    Exit Sub
                End If
            Else
                cod_cliente = rs.Fields(0).Value
                nome_cliente = rs.Fields(2).Value

                sql = "select * from tb_pet where id_dono =" & cod_cliente & " order by pet_nome asc"
                rs = db.Execute(sql)

                Do While rs.EOF = False
                    With cmb_consulta_nome_pet.Items
                        .Add(rs.Fields(3).Value)
                        rs.MoveNext()
                    End With
                Loop

                txt_consulta_nome_cliente.Text = nome_cliente
            End If
        End If


    End Sub

    Private Sub cmb_consulta_nome_pet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_consulta_nome_pet.SelectedIndexChanged
        sql = "select * From tb_pet where pet_nome='" & cmb_consulta_nome_pet.Text & "'"
        rs = db.Execute(sql)

        raca_pet = rs.Fields(2).Value
        tipo_pet = rs.Fields(5).Value
        id_pet = rs.Fields(0).Value
        txt_consulta_nome_cliente.Text = nome_cliente
        txt_consulta_tipo_pet.Text = tipo_pet
        txt_consulta_raca_pet.Text = raca_pet
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll

        hora = CInt(HScrollBar1.Value / 60)
        If hora = 10 Then
            hora = 18
        ElseIf hora = 9 Then
            hora = 17
        ElseIf hora = 8 Then
            hora = 16
        ElseIf hora = 7 Then
            hora = 15
        ElseIf hora = 6 Then
            hora = 14
        ElseIf hora = 5 Then
            hora = 13
        ElseIf hora = 4 Then
            hora = 12
        ElseIf hora = 3 Then
            hora = 11
        ElseIf hora = 2 Then
            hora = 10
        ElseIf hora = 1 Then
            hora = 9
        ElseIf hora = 0 Then
            hora = 8


        End If
        lbl_consulta_hora.Text = Format(hora, "00")

    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll

        minuto = HScrollBar2.Value / 2
        If minuto < 150 Then
            minuto = 0
        ElseIf minuto > 150 Then
            minuto = 30
        End If
        lbl_consulta_minuto.Text = Format(CInt(minuto), "00")
    End Sub

    Private Sub btn_consulta_salvar_Click(sender As Object, e As EventArgs) Handles btn_consulta_salvar.Click
        Dim data_consulta = bdp_dta_consulta.ToString()
        If txt_consulta_cpf.Text = "   .   .   -" Then
            MsgBox("Insira o CPF do cliente")
        ElseIf txt_consulta_nome_cliente.Text = "" Or cmb_consulta_nome_pet.Text = "" Or txt_consulta_tipo_pet.Text = "" Or txt_consulta_raca_pet.Text = "" Or txt_consulta_motivo.Text = "" Then
            MsgBox("Preencha todos os campos de cadastro!!!")

            Exit Sub
        Else
            hora_marcada = hora & ":" & minuto
            sql = "insert into tb_consulta (id_veterinario, hora_consulta, data_consulta, id_pet, motivo_consulta, info_consulta) values (1, '" & hora_marcada & "', '" & Format(bdp_dta_consulta.Value, "dd/MM/yyyy") & "', " & id_pet & ", '" & txt_consulta_motivo.Text & "','" & txt_consulta_obs.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Consulta marcada com sucesso criada com sucesso!")
            limpar_campos_consulta()


        End If

    End Sub

    Private Sub btn_consulta_caixa_Click(sender As Object, e As EventArgs)
        pn_consulta.Hide()
        pn_caixa.Show()
        btn_show_caixa.selected = True
        btn_show_consulta.selected = False
    End Sub

    Private Sub btn_consulta_limpar_Click(sender As Object, e As EventArgs) Handles btn_consulta_limpar.Click
        limpar_campos_consulta()
    End Sub
#End Region

#Region "BLOCO - CAIXA"
    Private Sub btn_show_caixa_Click(sender As Object, e As EventArgs) Handles btn_show_caixa.Click

        pn_caixa.Visible = True
        pn_produtos.Visible = False
        pn_clientes.Visible = False
        pn_acesso_operador.Visible = False
        pn_acesso_admin.Visible = False
        pn_consulta.Visible = False
        pn_pets.Visible = False
    End Sub
    Private Sub txt_caixa_cpf_Leave(sender As Object, e As EventArgs) Handles txt_caixa_cpf.Leave
        Dim opc

        If txt_caixa_cpf.Text = "   .   .   -" Then
            MsgBox("Por favor digite o CPF do Cliente para efetuar a venda")
            Exit Sub
        Else
            sql = "select * from tb_clientes where cpf_cliente='" + txt_caixa_cpf.Text + "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                opc = MsgBox("Cpf não registrado, deseja cadastrar cliente?", vbYesNo)
                If opc = MsgBoxResult.Yes Then
                    btn_show_caixa.selected = False
                    btn_show_clientes.selected = True
                    pn_caixa.Visible = False
                    pn_clientes.Visible = True
                Else
                    Exit Sub
                End If
            Else
                cmb_caixa_pet.Enabled = True
                cmb_caixa_produto.Enabled = True
                txt_caixa_quant.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmb_caixa_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_caixa_produto.SelectedIndexChanged
        Dim cod_cliente As String
        cmb_caixa_pet.Items.Clear()
        sql = "select * from tb_clientes where cpf_cliente='" + txt_caixa_cpf.Text + "'"
        rs = db.Execute(sql)
        cod_cliente = rs.Fields(0).Value

        sql = "select * from tb_pet where id_dono=" + cod_cliente
        rs = db.Execute(sql)
        Do While rs.EOF = False
            With cmb_caixa_pet.Items
                .Add(rs.Fields(3).Value)
                rs.MoveNext()
            End With
        Loop


        sql = "select * from tb_produtos where nome='" & cmb_caixa_produto.Text & "'"
        rs = db.Execute(sql)
        txt_caixa_valoru.Text = "R$ " & rs.Fields(2).Value

        If (cmb_caixa_produto.Text = "Banho c/tosa" Or cmb_caixa_produto.Text = "Banho s/tosa" Or cmb_caixa_produto.Text = "Hospedagem") Then
            Label104.Visible = True
            cmb_caixa_pet.Visible = True
            txt_caixa_quant.Visible = False
            Label67.Visible = False
        Else
            Label104.Visible = False
            cmb_caixa_pet.Visible = False
            txt_caixa_quant.Visible = True
            Label67.Visible = True
        End If



    End Sub

    Private Sub cmb_caixa_formaPgto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_caixa_formaPgto.SelectedIndexChanged
        Select Case cmb_caixa_formaPgto.SelectedIndex
            Case 1
                With cmb_caixa_parcelas.Items
                    .Add("2X")
                    .Add("3X")
                    .Add("4X")
                    .Add("5X")
                    .Add("6X")
                End With
                cmb_caixa_parcelas.Enabled = True
            Case Else
                cmb_caixa_parcelas.Enabled = False
                cmb_caixa_parcelas.Text = ""
                txt_caixa_valor_parcela.Text = ""

        End Select
    End Sub

    Private Sub cmb_caixa_parcelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_caixa_parcelas.SelectedIndexChanged
        Select Case cmb_caixa_parcelas.SelectedIndex
            Case 0
                valor_parcela = valor_compra / 2
                txt_caixa_valor_parcela.Text = valor_parcela.ToString()
            Case 1
                valor_parcela = valor_compra / 3
                txt_caixa_valor_parcela.Text = valor_parcela.ToString()
            Case 2
                valor_parcela = valor_compra / 4
                txt_caixa_valor_parcela.Text = valor_parcela.ToString()
            Case 3
                valor_parcela = valor_compra / 5
                txt_caixa_valor_parcela.Text = valor_parcela.ToString()
            Case 4
                valor_parcela = valor_compra / 6
                txt_caixa_valor_parcela.Text = valor_parcela.ToString()
        End Select
    End Sub


    Private Sub btn_compra_limpar_Click(sender As Object, e As EventArgs) Handles btn_compra_limpar.Click
        Limpar_caixa()
    End Sub


    Private Sub btn_compra_carrinho_Click(sender As Object, e As EventArgs) Handles btn_compra_carrinho.Click
        If txt_caixa_cpf.Text = "   .   .   -" Then
            MsgBox("Preencha o campo CPF do cliente")
        ElseIf cmb_caixa_produto.Text = "" Then
            MsgBox("Selecione o produto vendido")
        Else
            Dim valor_u = CDbl(txt_caixa_valoru.Text)
            Dim qtd_prod
            Dim valor_tot As Double

            If (cmb_caixa_produto.Text = "Banho c/tosa" Or cmb_caixa_produto.Text = "Banho s/tosa" Or cmb_caixa_produto.Text = "Hospedagem") Then
                qtd_prod = 1
                valor_tot = valor_u * qtd_prod
            Else
                If txt_caixa_quant.Text = "" Then
                    MsgBox("digite a quantidade de produtos")
                    Exit Sub
                ElseIf CInt(txt_caixa_quant.Text) > rs.Fields(3).Value Then
                    MsgBox("Não foi possível adicionar ao carrinho" & vbNewLine & "Existem somente " & rs.Fields(3).Value & " no estoque")
                    Exit Sub
                Else
                    qtd_prod = CInt(txt_caixa_quant.Text)
                    valor_tot = valor_u * qtd_prod
                End If

            End If
            sql = "select * from tb_produtos where nome='" & cmb_caixa_produto.Text & "'"
            rs = db.Execute(sql)
            With dgw_carrinho
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, qtd_prod.ToString(), valor_tot.ToString())
                rs.MoveNext()
            End With

            cmb_caixa_formaPgto.Text = ""
            cmb_caixa_formaPgto.Enabled = False
            cmb_caixa_produto.Text = ""
            txt_caixa_valoru.Clear()
            txt_caixa_quant.Clear()

            valor_compra += valor_tot
        End If
    End Sub

    Private Sub btn_compra_fechar_compra_Click(sender As Object, e As EventArgs) Handles btn_compra_fechar_compra.Click
        txt_caixa_valor.Text = valor_compra
        cmb_caixa_formaPgto.Enabled = True
        cmb_caixa_produto.Text = ""
        txt_caixa_valoru.Clear()
        txt_caixa_quant.Clear()

    End Sub

    Private Sub btn_caixa_finalizar_Click(sender As Object, e As EventArgs) Handles btn_caixa_finalizar.Click
        Dim codigo_venda, qtd_carrinho, id_cliente, qtd_final, qtd_total As Integer
        Dim cod_prod, qtd_prods As String
        qtd_carrinho = dgw_carrinho.Rows.Count
        If txt_caixa_cpf.Text = "   .   .   -" Then
            MsgBox("Digite o CPF do cliente")
        ElseIf cmb_caixa_formaPgto.Text = "À vista" Or cmb_caixa_formaPgto.Text = "Parcelado" Then
            sql = "Select * from tb_clientes where cpf_cliente='" & txt_caixa_cpf.Text & "'"
            rs = db.Execute(sql)
            id_cliente = rs.Fields(0).Value

            sql = "select top 1 * from tb_venda order by id_venda desc"
            rs = db.Execute(sql)

            codigo_venda = rs.Fields(0).Value + 1

            For i As Integer = 0 To qtd_carrinho - 2
                cod_prod = CInt(dgw_carrinho.Rows(i).Cells(0).Value.ToString())
                qtd_prods = CInt(dgw_carrinho.Rows(i).Cells(3).Value.ToString())
                sql = "insert into tb_venda (id_venda, id_cliente, id_produto, forma_pgto, num_parcelas, valor_parcelas, valor_total, qnt_prod, vendido_por) values (" & codigo_venda & "," & id_cliente & "," & cod_prod & ",'" & cmb_caixa_formaPgto.Text & "','" & cmb_caixa_parcelas.Text & "','" & txt_caixa_valor_parcela.Text & "','" & txt_caixa_valor.Text & "'," & qtd_prods & ",'" & user_logado & "')"
                rs = db.Execute(sql)
            Next



            For i As Integer = 0 To qtd_carrinho - 2
                cod_prod = CInt(dgw_carrinho.Rows(i).Cells(0).Value.ToString())
                qtd_prods = CInt(dgw_carrinho.Rows(i).Cells(3).Value.ToString())
                sql = "select * from tb_produtos where codigo=" & cod_prod
                rs = db.Execute(sql)

                qtd_total = rs.Fields(3).Value
                qtd_final = qtd_total - qtd_prods

                sql = "update tb_produtos set quantidade=" & qtd_final & " where codigo=" & cod_prod
                rs = db.Execute(sql)
            Next

            MsgBox("Compra Efetuada com sucesso!" + vbNewLine + "Número da compra é: " & codigo_venda)
            Limpar_caixa()

        Else
            MsgBox("A Compra ainda está no carrinho, feche-a!")
        End If




    End Sub


#End Region

#Region "BLOCO - CADASTRO DE CLIENTES"
    Private Sub btn_show_clientes_Click(sender As Object, e As EventArgs) Handles btn_show_clientes.Click
        limpar_cadastro_cliente()
        limpar_cadastro_func()
        limpar_campos_consulta()
        limpar_campos_produtos()

        txt_cliente_nome.Focus()
        pn_caixa.Visible = False
        pn_produtos.Visible = False
        pn_acesso_operador.Visible = False
        pn_acesso_admin.Visible = False
        pn_consulta.Visible = False
        pn_pets.Visible = False
        pn_clientes.Visible = True


    End Sub



    Private Sub txt_cliente_cpf_Leave(sender As Object, e As EventArgs) Handles txt_cliente_cpf.Leave
        sql = "Select * from tb_clientes where cpf_cliente='" & txt_cliente_cpf.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF <> True Then
            If txt_cliente_cpf.Text = rs.Fields(1).Value Then
                resp = MsgBox("CPF já cadastrado " & vbNewLine & "Deseja cadastrar um novo pet para este dono?", MessageBoxButtons.YesNo)
                If resp = MsgBoxResult.Yes Then
                    pn_caixa.Visible = False
                    pn_produtos.Visible = False
                    pn_acesso_operador.Visible = False
                    pn_acesso_admin.Visible = False
                    pn_consulta.Visible = False
                    pn_pets.Visible = True
                    pn_clientes.Visible = False
                    btn_show_clientes.selected = False
                    btn_show_pets.selected = True
                    Limpar_campos.limpar_cadastro_cliente()
                Else
                    txt_cliente_cpf.Text = ""
                End If

                Exit Sub
            End If
        End If

    End Sub

    Private Sub btn_cliente_salvar_Click(sender As Object, e As EventArgs) Handles btn_cliente_salvar.Click
        Dim nome_c = txt_cliente_nome.Text
        Dim cpf_c = txt_cliente_cpf.Text
        Dim tel_c = txt_cliente_telefone.Text
        Dim cel_c = txt_cliente_cel.Text
        Dim cidade_c = txt_cliente_cidade.Text
        Dim bairro_c = txt_cliente_bairro.Text
        Dim rua_c = txt_cliente_rua.Text
        Dim num_c = txt_cliente_numero.Text
        Dim cep_c = txt_cliente_cep.Text
        Dim uf_c = txt_cliente_uf.Text
        Dim email_c = txt_cliente_email.Text

        If nome_c = "" Or cpf_c = "" Or tel_c = "" Or cel_c = "" Or email_c = "" Or cidade_c = "" Or bairro_c = "" Or rua_c = "" Or num_c = "" Or cep_c = "" Or uf_c = "" Then
            MsgBox("Preencha todos os campos de cadastro!")
            Exit Sub
        End If

        If rs.EOF = True Then
            sql = "INSERT INTO tb_clientes (cpf_cliente, email_cliente, nome_cliente, cep_cliente, uf_cliente, cidade_cliente, bairro_cliente, rua_cliente, num_cliente, fone_res, fone_cel) VALUES ('" & cpf_c & "','" & email_c & "','" & nome_c & "','" & cep_c & "','" & uf_c & "','" & cidade_c & "', '" & bairro_c & "', '" & rua_c & "', '" & num_c & "', '" & tel_c & "', '" & cel_c & "')"
            rs = db.Execute(sql)
            cpf = txt_cliente_cpf.Text
            resp = MsgBox("Parabéns, " & nome_c & " agora é um cliente Syspet!" & vbNewLine & "Deseja cadastrar um novo pet para este dono?", MessageBoxButtons.YesNo)
            If resp = MsgBoxResult.Yes Then
                pn_pets.Visible = True
                pn_clientes.Visible = False
                btn_show_clientes.selected = False
                btn_show_pets.selected = True
                txt_pet_cpf.Text = cpf
            Else
                Limpar_campos.limpar_cadastro_cliente()
                txt_cliente_nome.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btn_cliente_limpar_Click(sender As Object, e As EventArgs) Handles btn_cliente_limpar.Click
        Limpar_campos.limpar_cadastro_cliente()
    End Sub


#End Region

#Region "BLOCO - PRODUTOS/ESTOQUE"
    Private Sub btn_show_produtos_Click(sender As Object, e As EventArgs) Handles btn_show_produtos.Click
        Limpar_campos.limpar_cadastro_cliente()
        Limpar_campos.limpar_cadastro_func()
        Limpar_campos.limpar_campos_consulta()
        Limpar_campos.limpar_campos_produtos()


        pn_caixa.Visible = False
        pn_produtos.Visible = True
        pn_clientes.Visible = False
        pn_acesso_operador.Visible = False
        pn_acesso_admin.Visible = False
        pn_consulta.Visible = False
        pn_pets.Visible = False



        txt_produtos_cod.Enabled = False
        btn_procurar_produtos.Enabled = False
        txt_produtos_nome.Enabled = False
        txt_produtos_qtd.Enabled = False
        txt_produtos_valor.Enabled = False
        btn_produtos_salvar.Enabled = False
    End Sub

    Private Sub rdn_cadastrar_produtos_CheckedChanged(sender As Object, e As EventArgs) Handles rdn_produtos_cadastrar.CheckedChanged
        txt_produtos_cod.Enabled = False
        btn_procurar_produtos.Enabled = False

        txt_produtos_nome.Enabled = True
        txt_produtos_qtd.Enabled = True
        txt_produtos_valor.Enabled = True
        btn_produtos_salvar.Enabled = True

        op = 1
    End Sub

    Private Sub rdn_adicionar_produtos_CheckedChanged(sender As Object, e As EventArgs) Handles rdn_produtos_adicionar.CheckedChanged
        txt_produtos_cod.Enabled = True
        btn_procurar_produtos.Enabled = True

        txt_produtos_nome.Enabled = True
        txt_produtos_qtd.Enabled = True
        txt_produtos_valor.Enabled = True
        btn_produtos_salvar.Enabled = True

        op = 2
    End Sub

    Private Sub btn_salvar_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos_salvar.Click
        Dim rdn1 = rdn_produtos_adicionar.TabIndex
        Dim rdn2 = rdn_produtos_cadastrar.TabIndex

        Dim cod_prod = txt_produtos_cod.Text
        Dim nome_prod = txt_produtos_nome.Text
        Dim qtd_prod = txt_produtos_qtd.Text
        Dim valor_prod = txt_produtos_valor.Text

        Select Case op
            Case 1
                sql = "select * from tb_produtos where nome='" & nome_prod & "'"
                rs = db.Execute(sql)

                If nome_prod = "" Or qtd_prod = "" Or valor_prod = "" Or cmb_produtos_categoria.Text = "" Then
                    MsgBox("Preencha todos os campos!!!")
                    Exit Sub
                End If

                Do While rs.EOF <> True
                    cont = cont + 1
                Loop

                If rs.EOF = True Then
                    sql = "insert into tb_produtos values ('" & cont & "','" & nome_prod & "', '" & valor_prod & "', '" & qtd_prod & "', '" & cmb_produtos_categoria.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Produto cadastrado com sucesso!!!")
                    cmb_caixa_produto.Items.Clear()
                    carregar_produtos()

                    txt_produtos_cod.Focus()
                End If

            Case 2
                sql = "select * from tb_produtos where codigo=" & cod_prod
                rs = db.Execute(sql)

                If nome_prod = "" Or qtd_prod = "" Or valor_prod = "" Or cod_prod = "" Or cmb_produtos_categoria.Text = "" Then
                    MsgBox("Preencha todos os campos!!!")

                End If

                If rs.EOF = False Then
                    If nome_prod = rs.Fields(1).Value And txt_produtos_valor.Text = rs.Fields(2).Value And txt_produtos_qtd.Text = rs.Fields(3).Value Then
                        MsgBox("Nenhuma alteração foi feita, impossível atualizar!!!")

                        Exit Sub
                    Else
                        sql = "update tb_produtos set nome='" & nome_prod & "', valor='" & valor_prod & "', quantidade=" & qtd_prod & ", categoria='" & cmb_produtos_categoria.Text & "' where codigo=" & cod_prod
                        rs = db.Execute(sql)
                        MsgBox("Produto Cadastrado com Sucesso!!!")

                    End If
                End If

            Case Else
                MsgBox("Selecione alguma opção nos botões!!!")

                Exit Sub
        End Select
    End Sub

    Private Sub btn_procurar_produtos_Click(sender As Object, e As EventArgs) Handles btn_procurar_produtos.Click
        sql = "select * from tb_produtos where codigo=" & txt_produtos_cod.Text
        rs = db.Execute(sql)

        If rs.EOF = False Then
            mostrar_dados_produtos()
        Else
            MsgBox("Produto não encontrado/cadastrado!!!")
            txt_produtos_cod.Focus()
        End If
    End Sub

    Private Sub cmb_produtos_pesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produtos_pesquisa.SelectedIndexChanged, txt_produtos_parametro.TextChanged
        sql = "select * from tb_produtos where " & cmb_produtos_pesquisa.Text & " like'" & txt_produtos_parametro.Text & "%'"
        rs = db.Execute(sql)
        cont = 1
        dgw_produtos.Rows.Clear()

        Do While rs.EOF = False
            With dgw_produtos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub btn_produtos_limpar_Click(sender As Object, e As EventArgs) Handles btn_produtos_limpar.Click
        Limpar_campos.limpar_campos_produtos()
    End Sub
#End Region

#Region "BLOCO - PETS"
    Private Sub btn_show_pets_Click(sender As Object, e As EventArgs) Handles btn_show_pets.Click
        limpar_cadastro_cliente()
        limpar_cadastro_func()
        limpar_campos_consulta()
        limpar_campos_produtos()
        Limpar_caixa()

        pn_caixa.Visible = False
        pn_produtos.Visible = False
        pn_clientes.Visible = False
        pn_acesso_operador.Visible = False
        pn_acesso_admin.Visible = False
        pn_consulta.Visible = False
        pn_pets.Visible = True

    End Sub

    Private Sub cmb_pet_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pet_tipo.SelectedIndexChanged
        If cmb_pet_tipo.SelectedItem = "Cachorro" Then
            cmb_pet_raca.Enabled = True
            cmb_pet_porte.Enabled = True
            With cmb_pet_raca.Items
                .Clear()
                .Add("Poodle")
                .Add("Pinscher")
                .Add("Labrador")
                .Add("Yorkshire")
                .Add("Shih Tzu")
                .Add("Maltês")
                .Add("Pug")
                .Add("Golden Retriever")
                .Add("Bulldog Francês")
                .Add("Lulu da Pomerânia")
                .Add("Rottweiler")
                .Add("Bulldog Inglês")
                .Add("Lhasa Apso")
                .Add("Pastor Alemão")
                .Add("Beagle")
                .Add("Vira-Lata")
                .Add("Outro")
            End With
            With cmb_pet_porte.Items
                .Add("Medio")
                .Add("Pequeno")
                .Add("Grande")
            End With
        ElseIf cmb_pet_tipo.SelectedItem = "Gato" Then
            cmb_pet_raca.Enabled = True
            cmb_pet_porte.Enabled = False
            cmb_pet_porte.Text = ""
            With cmb_pet_raca.Items
                .Clear()
                .Add("Persa")
                .Add("Siamês")
                .Add("Ragdoll")
                .Add("Maine Coon")
                .Add("Abissínio")
                .Add("Sagrado da Birmânia")
                .Add("Sphynx")
                .Add("Oriental Shorthair")
                .Add("American Shorthair")
                .Add("Exótico")
            End With
        Else
            cmb_pet_raca.Enabled = False
            cmb_pet_porte.Enabled = False
            cmb_pet_porte.Text = ""
            cmb_pet_raca.Text = ""
        End If
    End Sub


    Private Sub btn_pet_limpar_Click(sender As Object, e As EventArgs) Handles btn_pet_limpar.Click
        limpar_campos_pets()
    End Sub

    Private Sub btn_pet_salvar_Click(sender As Object, e As EventArgs) Handles btn_pet_salvar.Click
        If txt_pet_cpf.Text = "   .   .   -" Then
            MsgBox("Por favor digite o CPF do Cliente para efetuar o cadastro do Pet")
            Exit Sub
        Else
            conexao_banco()
            sql = "insert into tb_pet (id_dono, Raca, pet_nome, pet_idade, pet_tipo, pet_porte) values (" & cliente_selec & ",'" & cmb_pet_raca.Text & "','" & txt_pet_nome.Text & "','" & txt_pet_idade.Text & "','" & cmb_pet_tipo.Text & "','" & cmb_pet_porte.Text & "')"
            rs = db.Execute(sql)

            MsgBox("Pet registrado com sucesso")
            limpar_campos_pets()
            txt_pet_cpf.Focus()
        End If

    End Sub

    Private Sub txt_pet_cpf_Leave(sender As Object, e As EventArgs) Handles txt_pet_cpf.Leave
        If txt_pet_cpf.Text = "   .   .   -" Then
            MsgBox("Por favor digite o CPF do Cliente para efetuar o cadastro do Pet")
            Exit Sub
        Else
            sql = "select * from tb_clientes where cpf_cliente='" + txt_pet_cpf.Text + "'"
            rs = db.Execute(sql)
            cliente_selec = rs.Fields(0).Value

            If rs.EOF = True Then
                Dim opc = MsgBox("Cpf não registrado, deseja cadastrar cliente?", vbYesNo)
                If opc = MsgBoxResult.Yes Then
                    btn_show_pets.selected = False
                    btn_show_clientes.selected = True
                    pn_pets.Visible = False
                    pn_clientes.Visible = True
                Else txt_pet_cpf.Text = ""
                    txt_pet_cpf.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub


#End Region

#Region "BLOCO - MEU ACESSO"
    Private Sub btn_show_acesso_Click(sender As Object, e As EventArgs) Handles btn_show_acesso.Click
        If user_logado <> "" Then
            sql = "select * from tb_login where login_user='" & user_logado & "'"
            rs = db.Execute(sql)

            If rs.Fields(9).Value = "Admin" Then
                pn_caixa.Visible = False
                pn_produtos.Visible = False
                pn_clientes.Visible = False
                pn_acesso_admin.Visible = True
                pn_consulta.Visible = False
                pn_pets.Visible = False
            ElseIf rs.Fields(9).Value = "Operador" Then
                pn_caixa.Visible = False
                pn_produtos.Visible = False
                pn_clientes.Visible = False
                pn_acesso_operador.Visible = True
                pn_consulta.Visible = False
                pn_pets.Visible = False
            Else
                pn_caixa.Visible = False
                pn_produtos.Visible = False
                pn_clientes.Visible = False
                pn_acesso_vet.Visible = True
                pn_consulta.Visible = False
                pn_pets.Visible = False
                sql = "select * from tb_vet where login_sist='" & user_logado & "'"
                rs = db.Execute(sql)
                cod_vet = rs.Fields(0).Value
                sql = "select * from tb_consulta where id_veterinario=" & cod_vet
                rs = db.Execute(sql)

                Do While rs.EOF = False
                    With dgw_vet
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value)
                        rs.MoveNext()
                    End With
                Loop

            End If
        Else
            pn_caixa.Visible = False
            pn_produtos.Visible = False
            pn_clientes.Visible = False
            pn_acesso_operador.Visible = False
            pn_acesso_admin.Visible = False
            pn_consulta.Visible = False
            pn_pets.Visible = False
            resp = MsgBox("Não foi localizado nenhum login de usuário" & vbNewLine & "deseja voltar para a tela de login?", MessageBoxButtons.YesNo)
            If resp = MsgBoxResult.Yes Then
                frm_1_login.Show()
                Me.Hide()
            Else

                pn_caixa.Visible = False
                pn_produtos.Visible = False
                pn_clientes.Visible = False
                pn_acesso_operador.Visible = False
                pn_acesso_admin.Visible = False
                pn_consulta.Visible = False
                pn_pets.Visible = False
            End If
        End If

    End Sub


#Region "Acesso Admnistrador"

#Region "Acesso Admin - Mudar Senha"
    Private Sub txt_acesso1_login_Leave(sender As Object, e As EventArgs) Handles txt_acesso1_login.Leave
        conexao_banco()
        sql = "select * from tb_login where login_user ='" & txt_acesso1_login.Text & "'"
        rs = db.Execute(sql)

        If txt_acesso1_login.Text = "" Then
            MsgBox("Preencha o campo de login!!!")

        End If

        If rs.EOF = False Then
            If rs.Fields(1).Value = txt_acesso1_login.Text Then
                txt_acesso1_pergunta.Text = rs.Fields(6).Value

                Exit Sub
            Else
                MsgBox("Usuário não encontrado, tente novamente!!!")

            End If
        End If
    End Sub

    Private Sub txt_acesso1_resposta_LostFocus(sender As Object, e As EventArgs) Handles txt_acesso1_resposta.TextChanged
        sql = "select * from tb_login where resposta_user ='" & txt_acesso1_resposta.Text & "'"
        rs = db.Execute(sql)

        If txt_acesso1_resposta.Text = "" Then
            MsgBox("Preencha o campo de login!!!")

        End If

        If rs.EOF = False Then
            If rs.Fields(7).Value = txt_acesso1_resposta.Text Then
                txt_acesso1_senha.Enabled = True
                txt_acesso1_rsenha.Enabled = True
                btn_acesso1_confirmar.Enabled = True

                Exit Sub
            Else
                MsgBox("Resposta incorreta, tente novamente!!!")

            End If
        End If

    End Sub

    Private Sub btn_acesso1_confirmar_Click(sender As Object, e As EventArgs) Handles btn_acesso1_confirmar.Click
        conexao_banco()
        sql = "select * from tb_login"
        rs = db.Execute(sql)

        If txt_acesso1_senha.Text = "" Or txt_acesso1_rsenha.Text = "" Then
            MsgBox("Preencha os campos corretamente!!!")

            Exit Sub
        ElseIf txt_acesso1_senha.Text <> txt_acesso1_rsenha.Text Then
            MsgBox("Os campos não condizem, tente novamente!!!")

            Exit Sub
        End If

        If rs.EOF = False Then
            sql = "update tb_login set senha_user='" & txt_acesso1_rsenha.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Senha alterada com sucesso!!!")

        Else
            MsgBox("Erro!!!")

        End If
    End Sub
#End Region

#Region "Acesso Admin - Cadastrar Funcionário"
    Private Sub btn_func_criar_Click(sender As Object, e As EventArgs) Handles btn_func_criar.Click
        conexao_banco()

        Dim login = txt_func_login.Text
        Dim senha = txt_func_senha.Text
        Dim rsenha = txt_func_rsenha.Text
        Dim email = txt_func_email.Text
        Dim tipo = cmb_func_contatipo.Text
        Dim nome = txt_func_nome.Text
        Dim pergunta = cmb_func_perguntas.Text
        Dim resposta = txt_func_resposta.Text
        Dim cpf = txt_func_cpf.Text
        Dim rg = txt_func_rg.Text

        sql = "select * from tb_login where login_user='" & login & "' or email_user='" & email & "'"
        rs = db.Execute(sql)

        If email = "" Or resposta = "" Or rsenha = "" Or senha = "" Or email = "" Or tipo = "" Or pergunta = "" Or nome = "" Or cpf = "" Or rg = "" Then
            MsgBox("Preencha todos os campos de cadastro!")

            Exit Sub
        ElseIf senha <> rsenha Then
            MsgBox("Senhas diferem!")
            txt_func_senha.Clear()
            txt_func_rsenha.Clear()
            txt_func_senha.Focus()

            Exit Sub
        End If

        If rs.EOF = False Then
            If email = rs.Fields(1).Value Or email = rs.Fields(4).Value Or cpf = rs.Fields(6).Value Or rg = rs.Fields(5).Value Then
                MsgBox("Usuario, email, cpf ou rg ja cadastrado!!!")

                Exit Sub
            End If
        Else
            If rs.EOF = True Then
                Select Case cmb_func_contatipo.SelectedIndex
                    Case 0
                        sql = "insert into tb_login (cpf_user, login_user, senha_user,nome_user,email_user,rg_user,pergunta_user,resposta_user,tipo_conta,status_conta,foto_user) values ('" & cpf & "', '" & login & "', '" & senha & "', '" & nome & "', '" & email & "', '" & rg & "', '" & pergunta & "', '" & resposta & "', 'Admin','Ativa', '" & diretorio & "')"
                        rs = db.Execute(sql)
                        MsgBox("Contra criada com sucesso!")
                        limpar_cadastro_func()
                        txt_func_nome.Focus()

                        Exit Sub
                    Case 1
                        sql = "insert into tb_login values ('" & cpf & "', '" & login & "', '" & senha & "', '" & nome & "', '" & email & "', '" & rg & "', '" & pergunta & "', '" & resposta & "', '" & "Operador" & "', '" & "ativa" & "', '" & diretorio & "')"
                        rs = db.Execute(sql)
                        MsgBox("Contra criada com sucesso!")
                        limpar_cadastro_func()

                        txt_func_nome.Focus()
                        Exit Sub
                End Select
            End If
        End If
    End Sub

    Private Sub img_func_foto_Click(sender As Object, e As EventArgs) Handles img_func_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_func_foto.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("ERRO")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_func_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles btn_func_visualizar.CheckedChanged
        If btn_func_visualizar.Checked = True Then
            txt_func_senha.PasswordChar = ""
            txt_func_rsenha.PasswordChar = ""
        Else
            txt_func_senha.PasswordChar = "*"
            txt_func_rsenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_func_limpar_Click(sender As Object, e As EventArgs) Handles btn_func_limpar.Click
        limpar_cadastro_func()
    End Sub
#End Region

#Region "Acesso Admin - Gerenciar Contas"
    Private Sub txt_acesso2_parametro_TextChanged(sender As Object, e As EventArgs) Handles txt_acesso2_parametro.TextChanged
        conexao_banco()
        If rdn_acesso2_ativas.Checked = True Then
            sql = "select * from tb_login where " & cmb_acesso2_tipo_parametro.Text & " like '" & txt_acesso2_parametro.Text & "%' and status_conta='" & "ativa" & "'"
            rs = db.Execute(sql)
        ElseIf rdn_acesso2_bloqueadas.Checked = True Then
            sql = "select * from tb_login where " & cmb_acesso2_tipo_parametro.Text & " like '" & txt_acesso2_parametro.Text & "%' and status_conta='" & "bloqueada" & "'"
            rs = db.Execute(sql)
        ElseIf rdn_acesso2_todas.Checked = True Then
            sql = "select * from tb_login where " & cmb_acesso2_tipo_parametro.Text & " like '" & txt_acesso2_parametro.Text & "%'"
            rs = db.Execute(sql)
        End If

        cont = 1

        With dgw_manutencao
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(9).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With

    End Sub

    Private Sub dgw_manutencao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_manutencao.CellContentClick
        conexao_banco()
        With dgw_manutencao
            If .CurrentRow.Cells(4).Selected Then
                sql = "select * from tb_login where login_user='" & .CurrentRow.Cells(1).Value & "'"
                rs = db.Execute(sql)
                If rs.Fields(9).Value = "ativa" Then
                    txt_acesso2_parametro.Clear()
                    cmb_acesso2_tipo_parametro.Text = ""
                    MsgBox("Conta ja esta ativa!")

                    Exit Sub
                Else
                    sql = "update tb_login set status_conta='" & "ativa" & "'  where login_user ='" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(sql)
                    txt_acesso2_parametro.Clear()
                    cmb_acesso2_tipo_parametro.Text = ""
                    MsgBox("Conta ativada com sucesso!")
                    carregar_dados_login()

                    Exit Sub
                End If
            ElseIf .CurrentRow.Cells(5).Selected Then
                sql = "select * from tb_login where login_user='" & .CurrentRow.Cells(1).Value & "'"
                rs = db.Execute(sql)
                If rs.Fields(9).Value = "bloqueada" Then
                    txt_acesso2_parametro.Clear()
                    cmb_acesso2_tipo_parametro.Text = ""
                    MsgBox("Conta ja bloqueada")

                    Exit Sub
                Else
                    sql = "update tb_login status_conta='" & "bloqueada" & "'  where login_user ='" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(sql)
                    txt_acesso2_parametro.Clear()
                    cmb_acesso2_tipo_parametro.Text = ""
                    MsgBox("Conta bloqueada com sucesso!")
                    carregar_dados_login()

                    Exit Sub
                End If
            ElseIf .CurrentRow.Cells(6).Selected Then
                resp = MsgBox("Deseja realmente excluir este usuario?" + vbNewLine + "Usuario: " & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atencao")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_login where login_user='" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(sql)
                    MsgBox("Usuario excluido com sucesso!")
                    carregar_dados_login()

                    Exit Sub
                End If
            End If
        End With
    End Sub

#End Region



#End Region

#Region "Acesso Operador"

#Region "Mudar senha"
    Private Sub btn_operador_confirmar_Click(sender As Object, e As EventArgs)
        conexao_banco()

        sql = "select * from tb_login"
        rs = db.Execute(sql)

        If txt_operador_senha.Text = "" Or txt_operador_rsenha.Text = "" Then
            MsgBox("Preencha os campos corretamente!!!")

            Exit Sub
        ElseIf txt_operador_senha.Text <> txt_operador_rsenha.Text Then
            MsgBox("Os campos não condizem, tente novamente!!!")

            Exit Sub
        End If

        If rs.EOF = False Then
            sql = "update tb_login set senha_user='" & txt_operador_rsenha.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Senha alterada com sucesso!!!")

        Else
            MsgBox("Erro!!!")

        End If
    End Sub

    Private Sub txt_operador_login_LostFocus(sender As Object, e As EventArgs)
        conexao_banco()

        sql = "select * from tb_login where login_user ='" & txt_operador_login.Text & "'"
        rs = db.Execute(sql)

        If txt_operador_login.Text = "" Then
            MsgBox("Preencha o campo de login!!!")

        End If

        If rs.EOF = False Then
            If rs.Fields(1).Value = txt_operador_login.Text Then
                txt_operador_pergunta.Text = rs.Fields(6).Value

                Exit Sub
            Else
                MsgBox("Usuário não encontrado, tente novamente!!!")

            End If
        End If
    End Sub

    Private Sub txt_operador_resposta_LostFocus(sender As Object, e As EventArgs)
        conexao_banco()

        sql = "select * from tb_login where resposta_user ='" & txt_operador_resposta.Text & "'"
        rs = db.Execute(sql)

        If txt_operador_resposta.Text = "" Then
            MsgBox("Preencha o campo de login!!!")

        End If

        If rs.EOF = False Then
            If rs.Fields(7).Value = txt_operador_resposta.Text Then
                txt_operador_senha.Enabled = True
                txt_operador_rsenha.Enabled = True
                btn_operador_confirmar.Enabled = True

                Exit Sub
            Else
                MsgBox("Resposta incorreta, tente novamente!!!")

            End If
        End If
    End Sub

#End Region
#End Region
#End Region

#Region "BLOCO - LOGOUT"
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Tem certeza que deseja sair?", vbYesNo)
        If resp = MsgBoxResult.Yes Then
            user_logado = vbEmpty
            limpar_tudo()
            frm_1_login.Show()
            Me.Hide()
        End If
    End Sub
#End Region

End Class