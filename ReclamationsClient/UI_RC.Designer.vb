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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RTB_commentaireEnreg = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FLP_PiecesJointes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TLP_Main.SuspendLayout()
        Me.TLP_Enregistrement.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.AutoScroll = True
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Controls.Add(Me.TLP_Enregistrement, 1, 3)
        Me.TLP_Main.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TLP_Main.Controls.Add(Me.TableLayoutPanel1, 1, 4)
        Me.TLP_Main.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 8
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(1151, 744)
        Me.TLP_Main.TabIndex = 0
        '
        'TLP_Enregistrement
        '
        Me.TLP_Enregistrement.ColumnCount = 7
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Enregistrement.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Enregistrement.Controls.Add(Me.Label1, 1, 2)
        Me.TLP_Enregistrement.Controls.Add(Me.ComboBox1, 2, 2)
        Me.TLP_Enregistrement.Controls.Add(Me.Label2, 1, 3)
        Me.TLP_Enregistrement.Controls.Add(Me.DateTimePicker1, 2, 3)
        Me.TLP_Enregistrement.Controls.Add(Me.Label3, 1, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Label4, 1, 5)
        Me.TLP_Enregistrement.Controls.Add(Me.Label5, 4, 2)
        Me.TLP_Enregistrement.Controls.Add(Me.Label6, 4, 3)
        Me.TLP_Enregistrement.Controls.Add(Me.Label7, 4, 4)
        Me.TLP_Enregistrement.Controls.Add(Me.Label8, 1, 7)
        Me.TLP_Enregistrement.Controls.Add(Me.Label9, 1, 8)
        Me.TLP_Enregistrement.Controls.Add(Me.Label10, 1, 10)
        Me.TLP_Enregistrement.Controls.Add(Me.RTB_commentaireEnreg, 1, 11)
        Me.TLP_Enregistrement.Controls.Add(Me.Label11, 4, 10)
        Me.TLP_Enregistrement.Controls.Add(Me.FLP_PiecesJointes, 4, 11)
        Me.TLP_Enregistrement.Controls.Add(Me.Label12, 0, 0)
        Me.TLP_Enregistrement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Enregistrement.Location = New System.Drawing.Point(23, 123)
        Me.TLP_Enregistrement.Name = "TLP_Enregistrement"
        Me.TLP_Enregistrement.RowCount = 13
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TLP_Enregistrement.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Enregistrement.Size = New System.Drawing.Size(1105, 494)
        Me.TLP_Enregistrement.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type de client: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(335, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date réception RC: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(335, 103)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 26)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 130)
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
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 160)
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
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(575, 70)
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
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(575, 100)
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
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(575, 130)
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
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 240)
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
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(135, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 30)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "N° de Conf initiale: "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(135, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 30)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Commentaire"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RTB_commentaireEnreg
        '
        Me.RTB_commentaireEnreg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RTB_commentaireEnreg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TLP_Enregistrement.SetColumnSpan(Me.RTB_commentaireEnreg, 2)
        Me.RTB_commentaireEnreg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_commentaireEnreg.Location = New System.Drawing.Point(135, 373)
        Me.RTB_commentaireEnreg.Name = "RTB_commentaireEnreg"
        Me.RTB_commentaireEnreg.Size = New System.Drawing.Size(394, 94)
        Me.RTB_commentaireEnreg.TabIndex = 12
        Me.RTB_commentaireEnreg.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(575, 340)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 30)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Pièces jointes"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FLP_PiecesJointes
        '
        Me.FLP_PiecesJointes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FLP_PiecesJointes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLP_Enregistrement.SetColumnSpan(Me.FLP_PiecesJointes, 2)
        Me.FLP_PiecesJointes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_PiecesJointes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_PiecesJointes.Location = New System.Drawing.Point(575, 373)
        Me.FLP_PiecesJointes.Name = "FLP_PiecesJointes"
        Me.FLP_PiecesJointes.Size = New System.Drawing.Size(394, 94)
        Me.FLP_PiecesJointes.TabIndex = 14
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
        Me.Label12.Size = New System.Drawing.Size(1099, 50)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Enregistrement"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(1105, 80)
        Me.Label_Titre.TabIndex = 1
        Me.Label_Titre.Text = "Réclamation client"
        Me.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 623)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1105, 494)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label13, 3)
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1099, 50)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Analyse"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 1123)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1105, 494)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label14, 3)
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1099, 50)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Recencement"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UI_RC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TLP_Main)
        Me.Name = "UI_RC"
        Me.Size = New System.Drawing.Size(1151, 744)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.TLP_Enregistrement.ResumeLayout(False)
        Me.TLP_Enregistrement.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents TLP_Enregistrement As TableLayoutPanel
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RTB_commentaireEnreg As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FLP_PiecesJointes As FlowLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label14 As Label
End Class
