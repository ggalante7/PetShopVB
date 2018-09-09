Public Class frm_1_login
    Private Sub frm_1_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        txt_user.Focus()

    End Sub
#Region "Login"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = (DateTime.Now.ToString("HH:mm"))
        lbl_data.Text = (DateTime.Now.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim login = txt_user.Text
        Dim senha = txt_senha.Text

        If login = "" Or senha = "" Then
            MsgBox("Preencha todos os campos!!!")
            Exit Sub
        End If

        sql = "select * from tb_login where login_user='" & txt_user.Text & "'"
        rs = db.Execute(sql)


        If rs.EOF = False Then
            If rs.Fields(3).Value = senha Then
                user_logado = rs.Fields(2).Value
                frm_3_Menu.Show()
                txt_user.Text = ""
                txt_senha.Text = ""
                Me.Hide()
                user_login()
            Else
                MsgBox("Senha incorreta, tente novamente")
                txt_senha.Clear()
            End If
        Else
            MsgBox("Usuario inexistente!!!")
            txt_user.Clear()
            txt_senha.Clear()
        End If
    End Sub

    Private Sub txt_user_Leave(sender As Object, e As EventArgs)
        If (txt_user.Text = "") Then
            txt_user.Text = "usuario"
        End If
    End Sub

    Private Sub txt_user_Enter(sender As Object, e As EventArgs) Handles txt_user.Enter
        If (txt_user.Text = "usuario") Then
            txt_user.Text = ""
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbl_recuperar_Click(sender As Object, e As EventArgs) Handles lbl_recuperar.Click
        pn_login.Visible = False
        pn_recuperar.visible = True

    End Sub

    Private Sub lbl_recuperar_MouseEnter(sender As Object, e As EventArgs) Handles lbl_recuperar.MouseEnter
        lbl_recuperar.ForeColor = Color.FromArgb(74, 161, 229)
    End Sub

    Private Sub lbl_recuperar_MouseLeave(sender As Object, e As EventArgs) Handles lbl_recuperar.MouseLeave
        lbl_recuperar.ForeColor = Color.Black
    End Sub
#End Region

#Region "Recuperar Senha"
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        txt_rec_resp.Text = "resposta"
        txt_rec_user.Text = "usuario"
        txt_rec_pergunta.Text = "pergunta"
        pn_login.Visible = True
        pn_recuperar.Visible = False
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        sql = "select * from tb_login where login_user='" & txt_rec_user.Text & "'"
        rs = db.Execute(sql)

        If txt_rec_resp.Text = rs.Fields(7).Value Then
            MsgBox("A senha do usuário é: " & rs.Fields(2).Value)
        Else
            MsgBox("Resposta incorreta!")
        End If
    End Sub

    Private Sub txt_rec_user_Leave(sender As Object, e As EventArgs) Handles txt_rec_user.Leave
        If (txt_rec_user.Text = "") Then
            txt_rec_user.Text = "usuario"
        Else
           
            sql = "select * from tb_login where login_user='" & txt_rec_user.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF <> True Then
                txt_rec_pergunta.Text = rs.Fields(6).Value
            Else
                MsgBox("Usuário não encontrado")
                txt_rec_user.Focus()
            End If

        End If
    End Sub

    Private Sub txt_rec_user_Enter(sender As Object, e As EventArgs) Handles txt_rec_user.Enter
        If (txt_rec_user.Text = "usuario") Then
            txt_rec_user.Text = ""
        End If

    End Sub

    Private Sub txt_rec_resp_Enter(sender As Object, e As EventArgs) Handles txt_rec_resp.Enter
        If (txt_rec_resp.Text = "resposta") Then
            txt_rec_resp.Text = ""
        End If
    End Sub

    Private Sub txt_rec_resp_Leave(sender As Object, e As EventArgs) Handles txt_rec_resp.Leave
        If (txt_rec_resp.Text = "") Then
            txt_rec_resp.Text = "resposta"
        End If
    End Sub
#End Region

End Class