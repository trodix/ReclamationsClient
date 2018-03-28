<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ListeRC
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Liste = New System.Windows.Forms.DataGridView()
        Me.Col_idRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_NumConfIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Statut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_OuvrirRC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbx_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Liste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Liste, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1120, 732)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DGV_Liste
        '
        Me.DGV_Liste.AllowUserToAddRows = False
        Me.DGV_Liste.AllowUserToDeleteRows = False
        Me.DGV_Liste.AllowUserToOrderColumns = True
        Me.DGV_Liste.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Liste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idRC, Me.Col_DateRC, Me.Col_CodeClient, Me.Col_NumConfIni, Me.Col_Statut})
        Me.DGV_Liste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Liste.GridColor = System.Drawing.Color.White
        Me.DGV_Liste.Location = New System.Drawing.Point(3, 93)
        Me.DGV_Liste.MultiSelect = False
        Me.DGV_Liste.Name = "DGV_Liste"
        Me.DGV_Liste.ReadOnly = True
        Me.DGV_Liste.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Liste.Size = New System.Drawing.Size(1114, 616)
        Me.DGV_Liste.TabIndex = 0
        '
        'Col_idRC
        '
        Me.Col_idRC.HeaderText = "idRC"
        Me.Col_idRC.Name = "Col_idRC"
        Me.Col_idRC.ReadOnly = True
        '
        'Col_DateRC
        '
        Me.Col_DateRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateRC.HeaderText = "Date de l'enregistrement"
        Me.Col_DateRC.Name = "Col_DateRC"
        Me.Col_DateRC.ReadOnly = True
        '
        'Col_CodeClient
        '
        Me.Col_CodeClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_CodeClient.HeaderText = "Code client"
        Me.Col_CodeClient.Name = "Col_CodeClient"
        Me.Col_CodeClient.ReadOnly = True
        '
        'Col_NumConfIni
        '
        Me.Col_NumConfIni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_NumConfIni.HeaderText = "N° Conf initiale"
        Me.Col_NumConfIni.Name = "Col_NumConfIni"
        Me.Col_NumConfIni.ReadOnly = True
        '
        'Col_Statut
        '
        Me.Col_Statut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Statut.HeaderText = "Statut"
        Me.Col_Statut.Name = "Col_Statut"
        Me.Col_Statut.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_OuvrirRC, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Tbx_Search, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1114, 44)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Btn_OuvrirRC
        '
        Me.Btn_OuvrirRC.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Btn_OuvrirRC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_OuvrirRC.FlatAppearance.BorderSize = 0
        Me.Btn_OuvrirRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OuvrirRC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OuvrirRC.ForeColor = System.Drawing.Color.White
        Me.Btn_OuvrirRC.Location = New System.Drawing.Point(969, 5)
        Me.Btn_OuvrirRC.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_OuvrirRC.Name = "Btn_OuvrirRC"
        Me.Btn_OuvrirRC.Size = New System.Drawing.Size(140, 34)
        Me.Btn_OuvrirRC.TabIndex = 2
        Me.Btn_OuvrirRC.Text = "Ouvrir"
        Me.Btn_OuvrirRC.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Liste des réclamations client"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbx_Search
        '
        Me.Tbx_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbx_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Search.Location = New System.Drawing.Point(817, 10)
        Me.Tbx_Search.Name = "Tbx_Search"
        Me.Tbx_Search.Size = New System.Drawing.Size(144, 24)
        Me.Tbx_Search.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(697, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rechercher"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UI_ListeRC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UI_ListeRC"
        Me.Size = New System.Drawing.Size(1120, 732)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DGV_Liste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_Liste As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Btn_OuvrirRC As Button
    Friend WithEvents Col_idRC As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateRC As DataGridViewTextBoxColumn
    Friend WithEvents Col_CodeClient As DataGridViewTextBoxColumn
    Friend WithEvents Col_NumConfIni As DataGridViewTextBoxColumn
    Friend WithEvents Col_Statut As DataGridViewTextBoxColumn
    Friend WithEvents Tbx_Search As TextBox
    Friend WithEvents Label2 As Label
End Class
