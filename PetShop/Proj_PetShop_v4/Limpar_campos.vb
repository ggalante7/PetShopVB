Module Limpar_campos
    Sub limpar_cadastro_func()
        With frm_3_Menu
            .txt_func_email.Clear()
            .txt_func_login.Clear()
            .txt_func_resposta.Clear()
            .txt_func_rsenha.Clear()
            .txt_func_senha.Clear()
            .txt_func_nome.Clear()
            .txt_func_cpf.Clear()
            .txt_func_rg.Clear()
            .cmb_func_contatipo.Text = ""
            .cmb_func_perguntas.Text = ""
            .img_func_foto.Load(Application.StartupPath & "\Fotos\foto_branco.png")
        End With

    End Sub

    Sub limpar_campos_produtos()
        frm_3_Menu.txt_produtos_cod.Clear()
        frm_3_Menu.txt_produtos_nome.Clear()
        frm_3_Menu.txt_produtos_valor.Clear()
        frm_3_Menu.txt_produtos_qtd.Clear()
        frm_3_Menu.cmb_produtos_categoria.Text = ""
    End Sub

    Sub limpar_cadastro_cliente()
        With frm_3_Menu
            .txt_cliente_nome.Clear()
            .txt_cliente_cpf.Clear()
            .txt_cliente_telefone.Clear()
            .txt_cliente_cel.Clear()
            .txt_cliente_cidade.Clear()
            .txt_cliente_bairro.Clear()
            .txt_cliente_rua.Clear()
            .txt_cliente_numero.Clear()
            .txt_cliente_cep.Clear()
            .txt_cliente_uf.Clear()
            .txt_cliente_email.Clear()
            .txt_cliente_complemento.Clear()
        End With
    End Sub

    Sub limpar_campos_pets()
        With frm_3_Menu
            .txt_pet_cpf.Clear()
            .txt_pet_nome.Clear()
            .txt_pet_idade.Clear()
            .cmb_pet_porte.Text = ""
            .cmb_pet_raca.Text = ""
            .cmb_pet_tipo.Text = ""
        End With
    End Sub


    Sub limpar_campos_consulta()
        With frm_3_Menu
            .txt_consulta_cpf.Clear()
            .txt_consulta_obs.Clear()
            .txt_consulta_nome_cliente.Clear()
            .cmb_consulta_nome_pet.Items.Clear()
            .cmb_consulta_nome_pet.Text = ""
            .txt_consulta_tipo_pet.Clear()
            .txt_consulta_raca_pet.Clear()
            .txt_consulta_motivo.Clear()
            .bdp_dta_consulta.ResetText()
        End With

    End Sub




End Module
