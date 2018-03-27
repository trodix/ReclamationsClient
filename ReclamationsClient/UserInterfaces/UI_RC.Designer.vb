<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_RC
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Enregistrement = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtp_DateReception = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_Enreg = New System.Windows.Forms.Button()
        Me.RB_Soustraitance = New System.Windows.Forms.RadioButton()
        Me.RB_Agencement = New System.Windows.Forms.RadioButton()
        Me.Tbx_RefClient = New System.Windows.Forms.TextBox()
        Me.Tbx_ConfIni = New System.Windows.Forms.TextBox()
        Me.Label_NomCli = New System.Windows.Forms.Label()
        Me.Label_ContactCli = New System.Windows.Forms.Label()
        Me.Label_TelCli = New System.Windows.Forms.Label()
        Me.Label_MailCli = New System.Windows.Forms.Label()
        Me.Cmb_Clients = New System.Windows.Forms.ComboBox()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RTB_AnalyseCommentaire = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_AnalyseRejet = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btn_AnalyseValider = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Nud_NbPieces = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Recencement = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.RB_PieceRetour_Oui = New System.Windows.Forms.RadioButton()
        Me.RB_PieceRetour_Non = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Nud_ValMarchande = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Nud_CoutTransport = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cmb_TypeCause = New System.Windows.Forms.ComboBox()
        Me.Cmb_CategCause = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Mail = New System.Windows.Forms.Button()
        Me.Btn_Info = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Btn_Avoir = New System.Windows.Forms.Button()
        Me.Label_Statut = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.RTB_Commentaire = New System.Windows.Forms.RichTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Btn_AjouterPJ = New System.Windows.Forms.Button()
        Me.Btn_SupprPJ = New System.Windows.Forms.Button()
        Me.LB_PiecesJointes = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TLP_Main.SuspendLayout()
        Me.TLP_Enregistrement.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Nud_NbPieces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_ValMarchande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_CoutTransport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.AutoScroll = True
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Controls.Add(Me.TLP_Enregistrement, 1, 6)
        Me.TLP_Main.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TLP_Main.Controls.Add(Me.TableLayoutPanel1, 1, 7)
        Me.TLP_Main.Controls.Add(Me.TableLayoutPanel2, 1, 8)
        Me.TLP_Main.Controls.Add(Me.Label23, 1, 2)
        Me.TLP_Main.Controls.Add(Me.TableLayoutPanel3, 1, 4)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 10
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(1152, 834)
        Me.TLP_Main.TabIndex = 0
        '
        'TLP_Enregistrement
        '
        Me.TLP_Enregistrement.AutoScroll = True
        Me.TLP_Enregistrement.AutoSize = True
        Me.TLP_Enregistrement.BackColor = System.Drawing.Color.Transparent
        Me.TLP_Enregistrement.ColumnCount = 7
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Enregistrement.Controls.Add(Me.Label1, 1, 2)
        Me.TLP_Enregistrement.Controls.Add(Me.Label2, 1, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Dtp_DateReception, 2, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Label3, 1, 5)
        Me.TLP_Enregistrement.Controls.Add(Me.Label4, 1, 6)
        Me.TLP_Enregistrement.Controls.Add(Me.Label5, 4, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Label6, 4, 5)
        Me.TLP_Enregistrement.Controls.Add(Me.Label7, 4, 6)
        Me.TLP_Enregistrement.Controls.Add(Me.Label8, 1, 8)
        Me.TLP_Enregistrement.Controls.Add(Me.Label9, 1, 9)
        Me.TLP_Enregistrement.Controls.Add(Me.Label12, 0, 0)
        Me.TLP_Enregistrement.Controls.Add(Me.Btn_Enreg, 4, 11)
        Me.TLP_Enregistrement.Controls.Add(Me.RB_Soustraitance, 2, 2)
        Me.TLP_Enregistrement.Controls.Add(Me.RB_Agencement, 2, 3)
        Me.TLP_Enregistrement.Controls.Add(Me.Tbx_RefClient, 2, 8)
        Me.TLP_Enregistrement.Controls.Add(Me.Tbx_ConfIni, 2, 9)
        Me.TLP_Enregistrement.Controls.Add(Me.Label_NomCli, 2, 6)
        Me.TLP_Enregistrement.Controls.Add(Me.Label_ContactCli, 5, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Label_TelCli, 5, 5)
        Me.TLP_Enregistrement.Controls.Add(Me.Label_MailCli, 5, 6)
        Me.TLP_Enregistrement.Controls.Add(Me.Cmb_Clients, 2, 5)
        Me.TLP_Enregistrement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Enregistrement.Location = New System.Drawing.Point(23, 445)
        Me.TLP_Enregistrement.Name = "TLP_Enregistrement"
        Me.TLP_Enregistrement.RowCount = 14
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Enregistrement.Size = New System.Drawing.Size(1106, 494)
        Me.TLP_Enregistrement.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 70)
        Me.Label1.Name = "Label1"
        Me.TLP_Enregistrement.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(194, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type de client: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date réception RC: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtp_DateReception
        '
        Me.Dtp_DateReception.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtp_DateReception.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateReception.Location = New System.Drawing.Point(316, 133)
        Me.Dtp_DateReception.Name = "Dtp_DateReception"
        Me.Dtp_DateReception.Size = New System.Drawing.Size(214, 26)
        Me.Dtp_DateReception.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Code du client: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nom du client: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(576, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Contact: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Téléphone: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(576, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 30)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Adresse mail: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 30)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Référence du client: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 30)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "N° de Conf initiale: "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TLP_Enregistrement.SetColumnSpan(Me.Label12, 10)
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1100, 50)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Enregistrement"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Enreg
        '
        Me.Btn_Enreg.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Enreg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Enreg.FlatAppearance.BorderSize = 0
        Me.Btn_Enreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Enreg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enreg.ForeColor = System.Drawing.Color.White
        Me.Btn_Enreg.Location = New System.Drawing.Point(576, 353)
        Me.Btn_Enreg.Name = "Btn_Enreg"
        Me.Btn_Enreg.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Enreg.TabIndex = 16
        Me.Btn_Enreg.Text = "Enregistrer"
        Me.Btn_Enreg.UseVisualStyleBackColor = False
        '
        'RB_Soustraitance
        '
        Me.RB_Soustraitance.AutoSize = True
        Me.RB_Soustraitance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RB_Soustraitance.FlatAppearance.BorderSize = 0
        Me.RB_Soustraitance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Soustraitance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Soustraitance.Location = New System.Drawing.Point(316, 73)
        Me.RB_Soustraitance.Name = "RB_Soustraitance"
        Me.RB_Soustraitance.Size = New System.Drawing.Size(214, 24)
        Me.RB_Soustraitance.TabIndex = 18
        Me.RB_Soustraitance.TabStop = True
        Me.RB_Soustraitance.Text = "Soustraitance"
        Me.RB_Soustraitance.UseVisualStyleBackColor = True
        '
        'RB_Agencement
        '
        Me.RB_Agencement.AutoSize = True
        Me.RB_Agencement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RB_Agencement.FlatAppearance.BorderSize = 0
        Me.RB_Agencement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Agencement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Agencement.Location = New System.Drawing.Point(316, 103)
        Me.RB_Agencement.Name = "RB_Agencement"
        Me.RB_Agencement.Size = New System.Drawing.Size(214, 24)
        Me.RB_Agencement.TabIndex = 19
        Me.RB_Agencement.TabStop = True
        Me.RB_Agencement.Text = "Agencement"
        Me.RB_Agencement.UseVisualStyleBackColor = True
        '
        'Tbx_RefClient
        '
        Me.Tbx_RefClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tbx_RefClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_RefClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_RefClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_RefClient.Location = New System.Drawing.Point(316, 273)
        Me.Tbx_RefClient.Name = "Tbx_RefClient"
        Me.Tbx_RefClient.Size = New System.Drawing.Size(214, 19)
        Me.Tbx_RefClient.TabIndex = 20
        '
        'Tbx_ConfIni
        '
        Me.Tbx_ConfIni.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tbx_ConfIni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_ConfIni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_ConfIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_ConfIni.Location = New System.Drawing.Point(316, 303)
        Me.Tbx_ConfIni.Name = "Tbx_ConfIni"
        Me.Tbx_ConfIni.Size = New System.Drawing.Size(214, 19)
        Me.Tbx_ConfIni.TabIndex = 21
        '
        'Label_NomCli
        '
        Me.Label_NomCli.AutoSize = True
        Me.Label_NomCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_NomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NomCli.Location = New System.Drawing.Point(316, 190)
        Me.Label_NomCli.Name = "Label_NomCli"
        Me.Label_NomCli.Size = New System.Drawing.Size(214, 30)
        Me.Label_NomCli.TabIndex = 22
        Me.Label_NomCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_ContactCli
        '
        Me.Label_ContactCli.AutoSize = True
        Me.Label_ContactCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_ContactCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ContactCli.Location = New System.Drawing.Point(776, 130)
        Me.Label_ContactCli.Name = "Label_ContactCli"
        Me.Label_ContactCli.Size = New System.Drawing.Size(214, 30)
        Me.Label_ContactCli.TabIndex = 23
        Me.Label_ContactCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_TelCli
        '
        Me.Label_TelCli.AutoSize = True
        Me.Label_TelCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_TelCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TelCli.Location = New System.Drawing.Point(776, 160)
        Me.Label_TelCli.Name = "Label_TelCli"
        Me.Label_TelCli.Size = New System.Drawing.Size(214, 30)
        Me.Label_TelCli.TabIndex = 24
        Me.Label_TelCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_MailCli
        '
        Me.Label_MailCli.AutoSize = True
        Me.Label_MailCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_MailCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MailCli.Location = New System.Drawing.Point(776, 190)
        Me.Label_MailCli.Name = "Label_MailCli"
        Me.Label_MailCli.Size = New System.Drawing.Size(214, 30)
        Me.Label_MailCli.TabIndex = 25
        Me.Label_MailCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_Clients
        '
        Me.Cmb_Clients.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_Clients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Clients.FormattingEnabled = True
        Me.Cmb_Clients.Location = New System.Drawing.Point(316, 163)
        Me.Cmb_Clients.Name = "Cmb_Clients"
        Me.Cmb_Clients.Size = New System.Drawing.Size(214, 28)
        Me.Cmb_Clients.TabIndex = 26
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(1106, 80)
        Me.Label_Titre.TabIndex = 1
        Me.Label_Titre.Text = "Réclamation client"
        Me.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RTB_AnalyseCommentaire, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AnalyseRejet, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AnalyseValider, 3, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 945)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1106, 294)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'RTB_AnalyseCommentaire
        '
        Me.RTB_AnalyseCommentaire.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RTB_AnalyseCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.RTB_AnalyseCommentaire, 3)
        Me.RTB_AnalyseCommentaire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_AnalyseCommentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_AnalyseCommentaire.Location = New System.Drawing.Point(336, 103)
        Me.RTB_AnalyseCommentaire.Name = "RTB_AnalyseCommentaire"
        Me.RTB_AnalyseCommentaire.Size = New System.Drawing.Size(434, 94)
        Me.RTB_AnalyseCommentaire.TabIndex = 4
        Me.RTB_AnalyseCommentaire.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label10, 3)
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(336, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(434, 30)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Commentaires"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_AnalyseRejet
        '
        Me.Btn_AnalyseRejet.BackColor = System.Drawing.Color.Red
        Me.Btn_AnalyseRejet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AnalyseRejet.FlatAppearance.BorderSize = 0
        Me.Btn_AnalyseRejet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AnalyseRejet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AnalyseRejet.ForeColor = System.Drawing.Color.White
        Me.Btn_AnalyseRejet.Location = New System.Drawing.Point(336, 223)
        Me.Btn_AnalyseRejet.Name = "Btn_AnalyseRejet"
        Me.Btn_AnalyseRejet.Size = New System.Drawing.Size(194, 44)
        Me.Btn_AnalyseRejet.TabIndex = 2
        Me.Btn_AnalyseRejet.Text = "Rejeter"
        Me.Btn_AnalyseRejet.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label13, 6)
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1100, 50)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Analyse"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_AnalyseValider
        '
        Me.Btn_AnalyseValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_AnalyseValider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AnalyseValider.FlatAppearance.BorderSize = 0
        Me.Btn_AnalyseValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AnalyseValider.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AnalyseValider.ForeColor = System.Drawing.Color.White
        Me.Btn_AnalyseValider.Location = New System.Drawing.Point(576, 223)
        Me.Btn_AnalyseValider.Name = "Btn_AnalyseValider"
        Me.Btn_AnalyseValider.Size = New System.Drawing.Size(194, 44)
        Me.Btn_AnalyseValider.TabIndex = 1
        Me.Btn_AnalyseValider.Text = "Valider"
        Me.Btn_AnalyseValider.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Nud_NbPieces, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_Recencement, 4, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RB_PieceRetour_Oui, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RB_PieceRetour_Non, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Nud_ValMarchande, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Nud_CoutTransport, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Cmb_TypeCause, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Cmb_CategCause, 5, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 1245)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1106, 394)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(576, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 30)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Catégorie cause"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nud_NbPieces
        '
        Me.Nud_NbPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nud_NbPieces.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Nud_NbPieces.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nud_NbPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_NbPieces.Location = New System.Drawing.Point(336, 104)
        Me.Nud_NbPieces.Name = "Nud_NbPieces"
        Me.Nud_NbPieces.Size = New System.Drawing.Size(194, 22)
        Me.Nud_NbPieces.TabIndex = 29
        '
        'Btn_Recencement
        '
        Me.Btn_Recencement.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Recencement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Recencement.FlatAppearance.BorderSize = 0
        Me.Btn_Recencement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Recencement.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Recencement.ForeColor = System.Drawing.Color.White
        Me.Btn_Recencement.Location = New System.Drawing.Point(576, 253)
        Me.Btn_Recencement.Name = "Btn_Recencement"
        Me.Btn_Recencement.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Recencement.TabIndex = 28
        Me.Btn_Recencement.Text = "Enregistrer"
        Me.Btn_Recencement.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label14, 10)
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1100, 50)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Recencement"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(136, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(194, 19)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Nombre pièces RC"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(136, 130)
        Me.Label20.Name = "Label20"
        Me.TableLayoutPanel2.SetRowSpan(Me.Label20, 2)
        Me.Label20.Size = New System.Drawing.Size(194, 60)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Pièce Retour"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RB_PieceRetour_Oui
        '
        Me.RB_PieceRetour_Oui.AutoSize = True
        Me.RB_PieceRetour_Oui.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RB_PieceRetour_Oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_PieceRetour_Oui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PieceRetour_Oui.Location = New System.Drawing.Point(336, 133)
        Me.RB_PieceRetour_Oui.Name = "RB_PieceRetour_Oui"
        Me.RB_PieceRetour_Oui.Size = New System.Drawing.Size(194, 24)
        Me.RB_PieceRetour_Oui.TabIndex = 22
        Me.RB_PieceRetour_Oui.TabStop = True
        Me.RB_PieceRetour_Oui.Text = "Oui"
        Me.RB_PieceRetour_Oui.UseVisualStyleBackColor = True
        '
        'RB_PieceRetour_Non
        '
        Me.RB_PieceRetour_Non.AutoSize = True
        Me.RB_PieceRetour_Non.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RB_PieceRetour_Non.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_PieceRetour_Non.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PieceRetour_Non.Location = New System.Drawing.Point(336, 163)
        Me.RB_PieceRetour_Non.Name = "RB_PieceRetour_Non"
        Me.RB_PieceRetour_Non.Size = New System.Drawing.Size(194, 24)
        Me.RB_PieceRetour_Non.TabIndex = 23
        Me.RB_PieceRetour_Non.TabStop = True
        Me.RB_PieceRetour_Non.Text = "Non"
        Me.RB_PieceRetour_Non.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(576, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(194, 30)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Valeur Marchande"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nud_ValMarchande
        '
        Me.Nud_ValMarchande.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Nud_ValMarchande.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nud_ValMarchande.DecimalPlaces = 2
        Me.Nud_ValMarchande.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Nud_ValMarchande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_ValMarchande.Location = New System.Drawing.Point(776, 103)
        Me.Nud_ValMarchande.Name = "Nud_ValMarchande"
        Me.Nud_ValMarchande.Size = New System.Drawing.Size(194, 22)
        Me.Nud_ValMarchande.TabIndex = 26
        Me.Nud_ValMarchande.ThousandsSeparator = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(576, 130)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(194, 30)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Coût de Transport"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nud_CoutTransport
        '
        Me.Nud_CoutTransport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Nud_CoutTransport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nud_CoutTransport.DecimalPlaces = 2
        Me.Nud_CoutTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Nud_CoutTransport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_CoutTransport.Location = New System.Drawing.Point(776, 133)
        Me.Nud_CoutTransport.Name = "Nud_CoutTransport"
        Me.Nud_CoutTransport.Size = New System.Drawing.Size(194, 22)
        Me.Nud_CoutTransport.TabIndex = 27
        Me.Nud_CoutTransport.ThousandsSeparator = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(136, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 30)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Type de cause"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmb_TypeCause
        '
        Me.Cmb_TypeCause.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_TypeCause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_TypeCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TypeCause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_TypeCause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TypeCause.FormattingEnabled = True
        Me.Cmb_TypeCause.Location = New System.Drawing.Point(336, 73)
        Me.Cmb_TypeCause.Name = "Cmb_TypeCause"
        Me.Cmb_TypeCause.Size = New System.Drawing.Size(194, 28)
        Me.Cmb_TypeCause.TabIndex = 32
        '
        'Cmb_CategCause
        '
        Me.Cmb_CategCause.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_CategCause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_CategCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_CategCause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_CategCause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_CategCause.FormattingEnabled = True
        Me.Cmb_CategCause.Location = New System.Drawing.Point(776, 73)
        Me.Cmb_CategCause.Name = "Cmb_CategCause"
        Me.Cmb_CategCause.Size = New System.Drawing.Size(194, 28)
        Me.Cmb_CategCause.TabIndex = 33
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Location = New System.Drawing.Point(23, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(1106, 2)
        Me.Label23.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoScroll = True
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Mail, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Info, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Avoir, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label_Statut, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(23, 125)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1106, 294)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Btn_Mail
        '
        Me.Btn_Mail.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Mail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Mail.FlatAppearance.BorderSize = 0
        Me.Btn_Mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mail.ForeColor = System.Drawing.Color.White
        Me.Btn_Mail.Location = New System.Drawing.Point(909, 3)
        Me.Btn_Mail.Name = "Btn_Mail"
        Me.Btn_Mail.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Mail.TabIndex = 0
        Me.Btn_Mail.Text = "Mail interne"
        Me.Btn_Mail.UseVisualStyleBackColor = False
        '
        'Btn_Info
        '
        Me.Btn_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Info.FlatAppearance.BorderSize = 0
        Me.Btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Info.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Info.ForeColor = System.Drawing.Color.White
        Me.Btn_Info.Location = New System.Drawing.Point(909, 53)
        Me.Btn_Info.Name = "Btn_Info"
        Me.Btn_Info.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Info.TabIndex = 1
        Me.Btn_Info.Text = "Informer client"
        Me.Btn_Info.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 50)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Statut: "
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_Avoir
        '
        Me.Btn_Avoir.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Avoir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Avoir.FlatAppearance.BorderSize = 0
        Me.Btn_Avoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Avoir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Avoir.ForeColor = System.Drawing.Color.White
        Me.Btn_Avoir.Location = New System.Drawing.Point(103, 53)
        Me.Btn_Avoir.Name = "Btn_Avoir"
        Me.Btn_Avoir.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Avoir.TabIndex = 3
        Me.Btn_Avoir.Text = "Déclencher avoir"
        Me.Btn_Avoir.UseVisualStyleBackColor = False
        '
        'Label_Statut
        '
        Me.Label_Statut.AutoSize = True
        Me.Label_Statut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Statut.Location = New System.Drawing.Point(103, 0)
        Me.Label_Statut.Name = "Label_Statut"
        Me.Label_Statut.Size = New System.Drawing.Size(194, 50)
        Me.Label_Statut.TabIndex = 4
        Me.Label_Statut.Text = "Enregistrement"
        Me.Label_Statut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoScroll = True
        Me.TableLayoutPanel4.ColumnCount = 8
        Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanel4, 4)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RTB_Commentaire, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label25, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_AjouterPJ, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_SupprPJ, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LB_PiecesJointes, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 123)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1100, 168)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'RTB_Commentaire
        '
        Me.RTB_Commentaire.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RTB_Commentaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Commentaire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_Commentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_Commentaire.Location = New System.Drawing.Point(158, 33)
        Me.RTB_Commentaire.Name = "RTB_Commentaire"
        Me.RTB_Commentaire.Size = New System.Drawing.Size(444, 132)
        Me.RTB_Commentaire.TabIndex = 0
        Me.RTB_Commentaire.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(158, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(444, 30)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Commentaires"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(628, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(234, 30)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Pièces jointes"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_AjouterPJ
        '
        Me.Btn_AjouterPJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Btn_AjouterPJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AjouterPJ.FlatAppearance.BorderSize = 0
        Me.Btn_AjouterPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AjouterPJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AjouterPJ.ForeColor = System.Drawing.Color.White
        Me.Btn_AjouterPJ.Location = New System.Drawing.Point(898, 3)
        Me.Btn_AjouterPJ.Name = "Btn_AjouterPJ"
        Me.Btn_AjouterPJ.Size = New System.Drawing.Size(24, 24)
        Me.Btn_AjouterPJ.TabIndex = 16
        Me.Btn_AjouterPJ.Text = "+"
        Me.Btn_AjouterPJ.UseVisualStyleBackColor = False
        '
        'Btn_SupprPJ
        '
        Me.Btn_SupprPJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_SupprPJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_SupprPJ.FlatAppearance.BorderSize = 0
        Me.Btn_SupprPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SupprPJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SupprPJ.ForeColor = System.Drawing.Color.White
        Me.Btn_SupprPJ.Location = New System.Drawing.Point(868, 3)
        Me.Btn_SupprPJ.Name = "Btn_SupprPJ"
        Me.Btn_SupprPJ.Size = New System.Drawing.Size(24, 24)
        Me.Btn_SupprPJ.TabIndex = 17
        Me.Btn_SupprPJ.Text = "-"
        Me.Btn_SupprPJ.UseVisualStyleBackColor = False
        '
        'LB_PiecesJointes
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.LB_PiecesJointes, 3)
        Me.LB_PiecesJointes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_PiecesJointes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PiecesJointes.FormattingEnabled = True
        Me.LB_PiecesJointes.ItemHeight = 20
        Me.LB_PiecesJointes.Location = New System.Drawing.Point(628, 33)
        Me.LB_PiecesJointes.Name = "LB_PiecesJointes"
        Me.LB_PiecesJointes.Size = New System.Drawing.Size(294, 132)
        Me.LB_PiecesJointes.TabIndex = 18
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UI_RC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TLP_Main)
        Me.Name = "UI_RC"
        Me.Size = New System.Drawing.Size(1152, 834)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.TLP_Enregistrement.ResumeLayout(False)
        Me.TLP_Enregistrement.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Nud_NbPieces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_ValMarchande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_CoutTransport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents Label_Titre As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents RB_PieceRetour_Oui As RadioButton
    Friend WithEvents RB_PieceRetour_Non As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Nud_ValMarchande As NumericUpDown
    Friend WithEvents Nud_CoutTransport As NumericUpDown
    Friend WithEvents Btn_Recencement As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Btn_Mail As Button
    Friend WithEvents Btn_Info As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Btn_Avoir As Button
    Friend WithEvents Nud_NbPieces As NumericUpDown
    Friend WithEvents Label_Statut As Label
    Friend WithEvents TLP_Enregistrement As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtp_DateReception As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_Enreg As Button
    Friend WithEvents RB_Soustraitance As RadioButton
    Friend WithEvents RB_Agencement As RadioButton
    Friend WithEvents Tbx_RefClient As TextBox
    Friend WithEvents Tbx_ConfIni As TextBox
    Friend WithEvents Label_NomCli As Label
    Friend WithEvents Label_ContactCli As Label
    Friend WithEvents Label_TelCli As Label
    Friend WithEvents Label_MailCli As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents RTB_Commentaire As RichTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Cmb_Clients As ComboBox
    Friend WithEvents Btn_AnalyseValider As Button
    Friend WithEvents RTB_AnalyseCommentaire As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_AnalyseRejet As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Cmb_TypeCause As ComboBox
    Friend WithEvents Cmb_CategCause As ComboBox
    Friend WithEvents Btn_AjouterPJ As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btn_SupprPJ As Button
    Friend WithEvents LB_PiecesJointes As ListBox
End Class
