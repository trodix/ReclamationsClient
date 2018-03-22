<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Liste = New System.Windows.Forms.Button()
        Me.Btn_Nouveau = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(3, 53)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(1028, 572)
        Me.Panel_Main.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Liste)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Nouveau)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1028, 44)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Btn_Liste
        '
        Me.Btn_Liste.AutoSize = True
        Me.Btn_Liste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Liste.FlatAppearance.BorderSize = 0
        Me.Btn_Liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Liste.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Liste.ForeColor = System.Drawing.Color.White
        Me.Btn_Liste.Image = CType(resources.GetObject("Btn_Liste.Image"), System.Drawing.Image)
        Me.Btn_Liste.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Liste.Name = "Btn_Liste"
        Me.Btn_Liste.Size = New System.Drawing.Size(222, 40)
        Me.Btn_Liste.TabIndex = 0
        Me.Btn_Liste.Text = "Liste des Réclamations"
        Me.Btn_Liste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Liste.UseVisualStyleBackColor = True
        '
        'Btn_Nouveau
        '
        Me.Btn_Nouveau.AutoSize = True
        Me.Btn_Nouveau.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Nouveau.FlatAppearance.BorderSize = 0
        Me.Btn_Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nouveau.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nouveau.ForeColor = System.Drawing.Color.White
        Me.Btn_Nouveau.Image = CType(resources.GetObject("Btn_Nouveau.Image"), System.Drawing.Image)
        Me.Btn_Nouveau.Location = New System.Drawing.Point(231, 3)
        Me.Btn_Nouveau.Name = "Btn_Nouveau"
        Me.Btn_Nouveau.Size = New System.Drawing.Size(223, 40)
        Me.Btn_Nouveau.TabIndex = 1
        Me.Btn_Nouveau.Text = "Nouvelle Réclamation"
        Me.Btn_Nouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Nouveau.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Main, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1034, 628)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 628)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn_Liste As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Nouveau As Button
End Class
