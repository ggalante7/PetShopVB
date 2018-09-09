<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_1_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_1_login))
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.img_pass = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.img_login = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_recuperar = New System.Windows.Forms.Label()
        Me.pn_login = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.pn_recuperar = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pn_rec_resp = New System.Windows.Forms.Panel()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_rec_resp = New System.Windows.Forms.TextBox()
        Me.pn_rec_pergunta = New System.Windows.Forms.Panel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_rec_pergunta = New System.Windows.Forms.TextBox()
        Me.pn_rec_user = New System.Windows.Forms.Panel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_rec_user = New System.Windows.Forms.TextBox()
        Me.btn_confirmar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_voltar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse9 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header.SuspendLayout()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.img_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_login.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_recuperar.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_rec_resp.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_rec_pergunta.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_rec_user.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data.Location = New System.Drawing.Point(187, 389)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 46
        Me.lbl_data.Text = "date"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hora.Location = New System.Drawing.Point(258, 389)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(26, 13)
        Me.lbl_hora.TabIndex = 45
        Me.lbl_hora.Text = "time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.header.Controls.Add(Me.btn_minimize)
        Me.header.Controls.Add(Me.btn_close)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(315, 38)
        Me.header.TabIndex = 47
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Image = Global.Proj_PetShop_v4.My.Resources.Resources.Minimize_Window_50px
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(233, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(30, 32)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimize.TabIndex = 16
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 10
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = Global.Proj_PetShop_v4.My.Resources.Resources.Close_Window
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(269, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(30, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 16
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.btn_login
        '
        'btn_login
        '
        Me.btn_login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.BorderRadius = 0
        Me.btn_login.ButtonText = "      Login     "
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login.Iconimage = CType(resources.GetObject("btn_login.Iconimage"), System.Drawing.Image)
        Me.btn_login.Iconimage_right = Nothing
        Me.btn_login.Iconimage_right_Selected = Nothing
        Me.btn_login.Iconimage_Selected = Nothing
        Me.btn_login.IconMarginLeft = 0
        Me.btn_login.IconMarginRight = 0
        Me.btn_login.IconRightVisible = False
        Me.btn_login.IconRightZoom = 0R
        Me.btn_login.IconVisible = False
        Me.btn_login.IconZoom = 90.0R
        Me.btn_login.IsTab = False
        Me.btn_login.Location = New System.Drawing.Point(53, 309)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_login.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_login.selected = False
        Me.btn_login.Size = New System.Drawing.Size(200, 35)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "      Login     "
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login.Textcolor = System.Drawing.Color.White
        Me.btn_login.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_user.Location = New System.Drawing.Point(19, 11)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(166, 20)
        Me.txt_user.TabIndex = 0
        Me.txt_user.Text = "usuario"
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(19, 10)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(166, 20)
        Me.txt_senha.TabIndex = 1
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel2.Controls.Add(Me.img_pass)
        Me.Panel2.Controls.Add(Me.txt_senha)
        Me.Panel2.Location = New System.Drawing.Point(53, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 40)
        Me.Panel2.TabIndex = 55
        '
        'img_pass
        '
        Me.img_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.img_pass.Image = Global.Proj_PetShop_v4.My.Resources.Resources.Password
        Me.img_pass.ImageActive = Nothing
        Me.img_pass.Location = New System.Drawing.Point(2, 3)
        Me.img_pass.Name = "img_pass"
        Me.img_pass.Size = New System.Drawing.Size(35, 35)
        Me.img_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_pass.TabIndex = 52
        Me.img_pass.TabStop = False
        Me.img_pass.Zoom = 10
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 10
        Me.BunifuElipse4.TargetControl = Me.Panel1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.img_login)
        Me.Panel1.Controls.Add(Me.txt_user)
        Me.Panel1.Location = New System.Drawing.Point(53, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.TabIndex = 54
        '
        'img_login
        '
        Me.img_login.BackColor = System.Drawing.Color.Transparent
        Me.img_login.Image = Global.Proj_PetShop_v4.My.Resources.Resources.User_
        Me.img_login.ImageActive = Nothing
        Me.img_login.Location = New System.Drawing.Point(2, 3)
        Me.img_login.Name = "img_login"
        Me.img_login.Size = New System.Drawing.Size(35, 35)
        Me.img_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_login.TabIndex = 52
        Me.img_login.TabStop = False
        Me.img_login.Zoom = 10
        '
        'lbl_recuperar
        '
        Me.lbl_recuperar.AutoSize = True
        Me.lbl_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_recuperar.Location = New System.Drawing.Point(101, 355)
        Me.lbl_recuperar.Name = "lbl_recuperar"
        Me.lbl_recuperar.Size = New System.Drawing.Size(104, 13)
        Me.lbl_recuperar.TabIndex = 56
        Me.lbl_recuperar.Text = "Esqueceu a Senha?"
        '
        'pn_login
        '
        Me.pn_login.Controls.Add(Me.BunifuImageButton1)
        Me.pn_login.Controls.Add(Me.lbl_recuperar)
        Me.pn_login.Controls.Add(Me.lbl_hora)
        Me.pn_login.Controls.Add(Me.Panel2)
        Me.pn_login.Controls.Add(Me.lbl_data)
        Me.pn_login.Controls.Add(Me.Panel1)
        Me.pn_login.Controls.Add(Me.btn_login)
        Me.pn_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_login.Location = New System.Drawing.Point(0, 38)
        Me.pn_login.Name = "pn_login"
        Me.pn_login.Size = New System.Drawing.Size(315, 423)
        Me.pn_login.TabIndex = 57
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Proj_PetShop_v4.My.Resources.Resources.logo_syspet31
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(32, 27)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(247, 98)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 48
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'pn_recuperar
        '
        Me.pn_recuperar.Controls.Add(Me.BunifuImageButton2)
        Me.pn_recuperar.Controls.Add(Me.pn_rec_resp)
        Me.pn_recuperar.Controls.Add(Me.pn_rec_pergunta)
        Me.pn_recuperar.Controls.Add(Me.pn_rec_user)
        Me.pn_recuperar.Controls.Add(Me.btn_confirmar)
        Me.pn_recuperar.Controls.Add(Me.btn_voltar)
        Me.pn_recuperar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_recuperar.Location = New System.Drawing.Point(0, 38)
        Me.pn_recuperar.Name = "pn_recuperar"
        Me.pn_recuperar.Size = New System.Drawing.Size(315, 423)
        Me.pn_recuperar.TabIndex = 57
        Me.pn_recuperar.Visible = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.Proj_PetShop_v4.My.Resources.Resources.logo_syspet31
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(32, 27)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(247, 98)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 57
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'pn_rec_resp
        '
        Me.pn_rec_resp.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pn_rec_resp.Controls.Add(Me.BunifuImageButton5)
        Me.pn_rec_resp.Controls.Add(Me.txt_rec_resp)
        Me.pn_rec_resp.Location = New System.Drawing.Point(53, 269)
        Me.pn_rec_resp.Name = "pn_rec_resp"
        Me.pn_rec_resp.Size = New System.Drawing.Size(200, 40)
        Me.pn_rec_resp.TabIndex = 58
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Image = Global.Proj_PetShop_v4.My.Resources.Resources.Communicate_50px
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(3, 3)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 53
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'txt_rec_resp
        '
        Me.txt_rec_resp.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_rec_resp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_rec_resp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rec_resp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_rec_resp.Location = New System.Drawing.Point(19, 10)
        Me.txt_rec_resp.Name = "txt_rec_resp"
        Me.txt_rec_resp.Size = New System.Drawing.Size(166, 20)
        Me.txt_rec_resp.TabIndex = 0
        Me.txt_rec_resp.Text = "resposta"
        Me.txt_rec_resp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pn_rec_pergunta
        '
        Me.pn_rec_pergunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pn_rec_pergunta.Controls.Add(Me.BunifuImageButton4)
        Me.pn_rec_pergunta.Controls.Add(Me.txt_rec_pergunta)
        Me.pn_rec_pergunta.Location = New System.Drawing.Point(53, 212)
        Me.pn_rec_pergunta.Name = "pn_rec_pergunta"
        Me.pn_rec_pergunta.Size = New System.Drawing.Size(200, 40)
        Me.pn_rec_pergunta.TabIndex = 58
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = Global.Proj_PetShop_v4.My.Resources.Resources.quest
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(3, 3)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 53
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'txt_rec_pergunta
        '
        Me.txt_rec_pergunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_rec_pergunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_rec_pergunta.Enabled = False
        Me.txt_rec_pergunta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rec_pergunta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_rec_pergunta.Location = New System.Drawing.Point(19, 10)
        Me.txt_rec_pergunta.Name = "txt_rec_pergunta"
        Me.txt_rec_pergunta.Size = New System.Drawing.Size(166, 20)
        Me.txt_rec_pergunta.TabIndex = 0
        Me.txt_rec_pergunta.Text = "pergunta"
        Me.txt_rec_pergunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pn_rec_user
        '
        Me.pn_rec_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pn_rec_user.Controls.Add(Me.BunifuImageButton3)
        Me.pn_rec_user.Controls.Add(Me.txt_rec_user)
        Me.pn_rec_user.Location = New System.Drawing.Point(53, 155)
        Me.pn_rec_user.Name = "pn_rec_user"
        Me.pn_rec_user.Size = New System.Drawing.Size(200, 40)
        Me.pn_rec_user.TabIndex = 58
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = Global.Proj_PetShop_v4.My.Resources.Resources.User_
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(3, 3)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 53
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'txt_rec_user
        '
        Me.txt_rec_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_rec_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_rec_user.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rec_user.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_rec_user.Location = New System.Drawing.Point(19, 10)
        Me.txt_rec_user.Name = "txt_rec_user"
        Me.txt_rec_user.Size = New System.Drawing.Size(166, 20)
        Me.txt_rec_user.TabIndex = 0
        Me.txt_rec_user.Text = "usuario"
        Me.txt_rec_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmar.BorderRadius = 0
        Me.btn_confirmar.ButtonText = "Confirmar"
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_confirmar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_confirmar.Iconimage = CType(resources.GetObject("btn_confirmar.Iconimage"), System.Drawing.Image)
        Me.btn_confirmar.Iconimage_right = Nothing
        Me.btn_confirmar.Iconimage_right_Selected = Nothing
        Me.btn_confirmar.Iconimage_Selected = Nothing
        Me.btn_confirmar.IconMarginLeft = 0
        Me.btn_confirmar.IconMarginRight = 0
        Me.btn_confirmar.IconRightVisible = False
        Me.btn_confirmar.IconRightZoom = 0R
        Me.btn_confirmar.IconVisible = False
        Me.btn_confirmar.IconZoom = 90.0R
        Me.btn_confirmar.IsTab = False
        Me.btn_confirmar.Location = New System.Drawing.Point(152, 336)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_confirmar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_confirmar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_confirmar.selected = False
        Me.btn_confirmar.Size = New System.Drawing.Size(98, 35)
        Me.btn_confirmar.TabIndex = 56
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_confirmar.Textcolor = System.Drawing.Color.White
        Me.btn_confirmar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_voltar
        '
        Me.btn_voltar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.BorderRadius = 0
        Me.btn_voltar.ButtonText = "Voltar"
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_voltar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_voltar.Iconimage = CType(resources.GetObject("btn_voltar.Iconimage"), System.Drawing.Image)
        Me.btn_voltar.Iconimage_right = Nothing
        Me.btn_voltar.Iconimage_right_Selected = Nothing
        Me.btn_voltar.Iconimage_Selected = Nothing
        Me.btn_voltar.IconMarginLeft = 0
        Me.btn_voltar.IconMarginRight = 0
        Me.btn_voltar.IconRightVisible = False
        Me.btn_voltar.IconRightZoom = 0R
        Me.btn_voltar.IconVisible = False
        Me.btn_voltar.IconZoom = 90.0R
        Me.btn_voltar.IsTab = False
        Me.btn_voltar.Location = New System.Drawing.Point(50, 336)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_voltar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_voltar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_voltar.selected = False
        Me.btn_voltar.Size = New System.Drawing.Size(98, 35)
        Me.btn_voltar.TabIndex = 56
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_voltar.Textcolor = System.Drawing.Color.White
        Me.btn_voltar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 10
        Me.BunifuElipse5.TargetControl = Me.btn_confirmar
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 10
        Me.BunifuElipse6.TargetControl = Me.btn_voltar
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 10
        Me.BunifuElipse7.TargetControl = Me.pn_rec_pergunta
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 10
        Me.BunifuElipse8.TargetControl = Me.pn_rec_user
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 10
        Me.BunifuElipse9.TargetControl = Me.pn_rec_resp
        '
        'frm_1_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(315, 461)
        Me.Controls.Add(Me.pn_login)
        Me.Controls.Add(Me.pn_recuperar)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_1_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Syspet"
        Me.header.ResumeLayout(False)
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.img_pass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_login.ResumeLayout(False)
        Me.pn_login.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_recuperar.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_rec_resp.ResumeLayout(False)
        Me.pn_rec_resp.PerformLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_rec_pergunta.ResumeLayout(False)
        Me.pn_rec_pergunta.PerformLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_rec_user.ResumeLayout(False)
        Me.pn_rec_user.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents img_login As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents img_pass As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_recuperar As Label
    Friend WithEvents pn_login As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents pn_recuperar As Panel
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pn_rec_user As Panel
    Friend WithEvents txt_rec_user As TextBox
    Friend WithEvents btn_voltar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_confirmar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pn_rec_resp As Panel
    Friend WithEvents txt_rec_resp As TextBox
    Friend WithEvents pn_rec_pergunta As Panel
    Friend WithEvents txt_rec_pergunta As TextBox
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse8 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse9 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
End Class
