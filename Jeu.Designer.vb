<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxCartes = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Carte = New System.Windows.Forms.Label()
        Me.Abandon = New System.Windows.Forms.Button()
        Me.Temps = New System.Windows.Forms.Label()
        Me.Joueur = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Triche = New System.Windows.Forms.Button()
        Me.Pause = New System.Windows.Forms.Button()
        Me.ImageLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBoxCartes.SuspendLayout()
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(744, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Joueur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(532, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Temps restant"
        '
        'Timer1
        '
        '
        'GroupBoxCartes
        '
        Me.GroupBoxCartes.Controls.Add(Me.Label19)
        Me.GroupBoxCartes.Controls.Add(Me.Label20)
        Me.GroupBoxCartes.Controls.Add(Me.Label21)
        Me.GroupBoxCartes.Controls.Add(Me.Label22)
        Me.GroupBoxCartes.Controls.Add(Me.Label23)
        Me.GroupBoxCartes.Controls.Add(Me.Label14)
        Me.GroupBoxCartes.Controls.Add(Me.Label15)
        Me.GroupBoxCartes.Controls.Add(Me.Label16)
        Me.GroupBoxCartes.Controls.Add(Me.Label17)
        Me.GroupBoxCartes.Controls.Add(Me.Label18)
        Me.GroupBoxCartes.Controls.Add(Me.Label13)
        Me.GroupBoxCartes.Controls.Add(Me.Label12)
        Me.GroupBoxCartes.Controls.Add(Me.Label11)
        Me.GroupBoxCartes.Controls.Add(Me.Label10)
        Me.GroupBoxCartes.Controls.Add(Me.Label9)
        Me.GroupBoxCartes.Controls.Add(Me.Label8)
        Me.GroupBoxCartes.Controls.Add(Me.Label7)
        Me.GroupBoxCartes.Controls.Add(Me.Label6)
        Me.GroupBoxCartes.Controls.Add(Me.Label5)
        Me.GroupBoxCartes.Controls.Add(Me.Carte)
        Me.GroupBoxCartes.Location = New System.Drawing.Point(19, 92)
        Me.GroupBoxCartes.Name = "GroupBoxCartes"
        Me.GroupBoxCartes.Size = New System.Drawing.Size(707, 580)
        Me.GroupBoxCartes.TabIndex = 6
        Me.GroupBoxCartes.TabStop = False
        Me.GroupBoxCartes.Text = "Cartes"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(556, 432)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 128)
        Me.Label19.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(422, 432)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 128)
        Me.Label20.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(288, 432)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 128)
        Me.Label21.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(154, 432)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 128)
        Me.Label22.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(20, 432)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 128)
        Me.Label23.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(556, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 128)
        Me.Label14.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(422, 299)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 128)
        Me.Label15.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(288, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 128)
        Me.Label16.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(154, 299)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 128)
        Me.Label17.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(20, 299)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 128)
        Me.Label18.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(556, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 128)
        Me.Label13.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(422, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 128)
        Me.Label12.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(288, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 128)
        Me.Label11.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(154, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 128)
        Me.Label10.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 128)
        Me.Label9.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(556, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 128)
        Me.Label8.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(422, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 128)
        Me.Label7.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(288, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 128)
        Me.Label6.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(154, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 128)
        Me.Label5.TabIndex = 1
        '
        'Carte
        '
        Me.Carte.Location = New System.Drawing.Point(20, 30)
        Me.Carte.Name = "Carte"
        Me.Carte.Size = New System.Drawing.Size(128, 128)
        Me.Carte.TabIndex = 0
        '
        'Abandon
        '
        Me.Abandon.Location = New System.Drawing.Point(741, 138)
        Me.Abandon.Name = "Abandon"
        Me.Abandon.Size = New System.Drawing.Size(120, 35)
        Me.Abandon.TabIndex = 7
        Me.Abandon.Text = "Abandonner"
        Me.Abandon.UseVisualStyleBackColor = True
        '
        'Temps
        '
        Me.Temps.Font = New System.Drawing.Font("Calibri", 10.25!)
        Me.Temps.Location = New System.Drawing.Point(538, 46)
        Me.Temps.Name = "Temps"
        Me.Temps.Size = New System.Drawing.Size(104, 21)
        Me.Temps.TabIndex = 8
        Me.Temps.Text = "00:00"
        Me.Temps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joueur
        '
        Me.Joueur.Font = New System.Drawing.Font("Calibri", 10.25!)
        Me.Joueur.Location = New System.Drawing.Point(724, 46)
        Me.Joueur.Name = "Joueur"
        Me.Joueur.Size = New System.Drawing.Size(104, 21)
        Me.Joueur.TabIndex = 9
        Me.Joueur.Text = "NomJoueur"
        Me.Joueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(88, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Le jeu de mémorisation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(84, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "4 Memory"
        '
        'Triche
        '
        Me.Triche.BackColor = System.Drawing.Color.IndianRed
        Me.Triche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Triche.Location = New System.Drawing.Point(741, 179)
        Me.Triche.Name = "Triche"
        Me.Triche.Size = New System.Drawing.Size(120, 35)
        Me.Triche.TabIndex = 14
        Me.Triche.Text = "Tricher"
        Me.Triche.UseVisualStyleBackColor = False
        Me.Triche.Visible = False
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(741, 97)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(120, 35)
        Me.Pause.TabIndex = 15
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'ImageLogo
        '
        Me.ImageLogo.Image = Global.ProjetIHM.My.Resources.Resources.logo
        Me.ImageLogo.Location = New System.Drawing.Point(20, 16)
        Me.ImageLogo.Name = "ImageLogo"
        Me.ImageLogo.Size = New System.Drawing.Size(58, 58)
        Me.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageLogo.TabIndex = 16
        Me.ImageLogo.TabStop = False
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.ImageLogo)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.Triche)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Joueur)
        Me.Controls.Add(Me.Temps)
        Me.Controls.Add(Me.Abandon)
        Me.Controls.Add(Me.GroupBoxCartes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu - 4 Memory"
        Me.GroupBoxCartes.ResumeLayout(False)
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBoxCartes As GroupBox
    Friend WithEvents Abandon As Button
    Friend WithEvents Temps As Label
    Friend WithEvents Joueur As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Carte As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Triche As Button
    Friend WithEvents Pause As Button
    Friend WithEvents ImageLogo As PictureBox
End Class
