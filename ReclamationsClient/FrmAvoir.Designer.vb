<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvoir
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_NomClient = New System.Windows.Forms.Label()
        Me.Nud_Avoir = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tbx_NumFacture = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RTB_Commentaires = New System.Windows.Forms.RichTextBox()
        Me.LB_PiecesJointes = New System.Windows.Forms.ListBox()
        Me.Btn_AjouterPJ = New System.Windows.Forms.Button()
        Me.Btn_SupprPJ = New System.Windows.Forms.Button()
        Me.Btn_Envoi = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Nud_Avoir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label26, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_PiecesJointes, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_NomClient, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Nud_Avoir, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Tbx_NumFacture, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.RTB_Commentaires, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AjouterPJ, 6, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_SupprPJ, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Envoi, 4, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 16
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 582)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Montant de l'avoir: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 7)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Préparation avoir"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom du client: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_NomClient
        '
        Me.Label_NomClient.AutoSize = True
        Me.Label_NomClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_NomClient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NomClient.Location = New System.Drawing.Point(223, 92)
        Me.Label_NomClient.Name = "Label_NomClient"
        Me.Label_NomClient.Size = New System.Drawing.Size(194, 50)
        Me.Label_NomClient.TabIndex = 3
        Me.Label_NomClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nud_Avoir
        '
        Me.Nud_Avoir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nud_Avoir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Nud_Avoir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nud_Avoir.DecimalPlaces = 2
        Me.Nud_Avoir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_Avoir.Location = New System.Drawing.Point(223, 186)
        Me.Nud_Avoir.Name = "Nud_Avoir"
        Me.Nud_Avoir.Size = New System.Drawing.Size(194, 22)
        Me.Nud_Avoir.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 50)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "N° Facture initiale: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbx_NumFacture
        '
        Me.Tbx_NumFacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbx_NumFacture.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tbx_NumFacture.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_NumFacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_NumFacture.Location = New System.Drawing.Point(223, 257)
        Me.Tbx_NumFacture.Name = "Tbx_NumFacture"
        Me.Tbx_NumFacture.Size = New System.Drawing.Size(194, 19)
        Me.Tbx_NumFacture.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Commentaires"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RTB_Commentaires
        '
        Me.RTB_Commentaires.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RTB_Commentaires.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.RTB_Commentaires, 3)
        Me.RTB_Commentaires.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_Commentaires.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_Commentaires.Location = New System.Drawing.Point(223, 345)
        Me.RTB_Commentaires.Name = "RTB_Commentaires"
        Me.RTB_Commentaires.Size = New System.Drawing.Size(454, 144)
        Me.RTB_Commentaires.TabIndex = 8
        Me.RTB_Commentaires.Text = ""
        '
        'LB_PiecesJointes
        '
        Me.LB_PiecesJointes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.LB_PiecesJointes, 3)
        Me.LB_PiecesJointes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_PiecesJointes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PiecesJointes.FormattingEnabled = True
        Me.LB_PiecesJointes.ItemHeight = 20
        Me.LB_PiecesJointes.Location = New System.Drawing.Point(443, 175)
        Me.LB_PiecesJointes.Name = "LB_PiecesJointes"
        Me.TableLayoutPanel1.SetRowSpan(Me.LB_PiecesJointes, 3)
        Me.LB_PiecesJointes.Size = New System.Drawing.Size(294, 114)
        Me.LB_PiecesJointes.TabIndex = 19
        '
        'Btn_AjouterPJ
        '
        Me.Btn_AjouterPJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Btn_AjouterPJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AjouterPJ.FlatAppearance.BorderSize = 0
        Me.Btn_AjouterPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AjouterPJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AjouterPJ.ForeColor = System.Drawing.Color.White
        Me.Btn_AjouterPJ.Location = New System.Drawing.Point(713, 145)
        Me.Btn_AjouterPJ.Name = "Btn_AjouterPJ"
        Me.Btn_AjouterPJ.Size = New System.Drawing.Size(24, 24)
        Me.Btn_AjouterPJ.TabIndex = 20
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
        Me.Btn_SupprPJ.Location = New System.Drawing.Point(683, 145)
        Me.Btn_SupprPJ.Name = "Btn_SupprPJ"
        Me.Btn_SupprPJ.Size = New System.Drawing.Size(24, 24)
        Me.Btn_SupprPJ.TabIndex = 21
        Me.Btn_SupprPJ.Text = "-"
        Me.Btn_SupprPJ.UseVisualStyleBackColor = False
        '
        'Btn_Envoi
        '
        Me.Btn_Envoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_Envoi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Envoi.FlatAppearance.BorderSize = 0
        Me.Btn_Envoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Envoi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Envoi.ForeColor = System.Drawing.Color.White
        Me.Btn_Envoi.Location = New System.Drawing.Point(443, 515)
        Me.Btn_Envoi.Name = "Btn_Envoi"
        Me.Btn_Envoi.Size = New System.Drawing.Size(234, 44)
        Me.Btn_Envoi.TabIndex = 22
        Me.Btn_Envoi.Text = "Envoyer à l'émetteur"
        Me.Btn_Envoi.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(443, 142)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(234, 30)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Pièces jointes"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 7)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(23, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(728, 2)
        Me.Label6.TabIndex = 24
        '
        'FrmAvoir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 582)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmAvoir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAvoir"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Nud_Avoir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_NomClient As Label
    Friend WithEvents Nud_Avoir As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbx_NumFacture As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RTB_Commentaires As RichTextBox
    Friend WithEvents LB_PiecesJointes As ListBox
    Friend WithEvents Btn_AjouterPJ As Button
    Friend WithEvents Btn_SupprPJ As Button
    Friend WithEvents Btn_Envoi As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label6 As Label
End Class
