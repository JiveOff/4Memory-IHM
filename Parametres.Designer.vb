<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parametres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parametres))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SettingsBox = New System.Windows.Forms.GroupBox()
        Me.PauseCheck = New System.Windows.Forms.CheckBox()
        Me.cartedefault = New System.Windows.Forms.PictureBox()
        Me.Themes = New System.Windows.Forms.ComboBox()
        Me.Cartes = New System.Windows.Forms.GroupBox()
        Me.carte4 = New System.Windows.Forms.PictureBox()
        Me.carte3 = New System.Windows.Forms.PictureBox()
        Me.carte2 = New System.Windows.Forms.PictureBox()
        Me.carte1 = New System.Windows.Forms.PictureBox()
        Me.carte0 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Secs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Mins = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Parcourir = New System.Windows.Forms.Button()
        Me.RepSauv = New System.Windows.Forms.TextBox()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ImageLogo = New System.Windows.Forms.PictureBox()
        Me.SettingsBox.SuspendLayout()
        CType(Me.cartedefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cartes.SuspendLayout()
        CType(Me.carte4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(87, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Le jeu de mémorisation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(83, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "4 Memory"
        '
        'SettingsBox
        '
        Me.SettingsBox.Controls.Add(Me.PauseCheck)
        Me.SettingsBox.Controls.Add(Me.cartedefault)
        Me.SettingsBox.Controls.Add(Me.Themes)
        Me.SettingsBox.Controls.Add(Me.Cartes)
        Me.SettingsBox.Controls.Add(Me.Label7)
        Me.SettingsBox.Controls.Add(Me.Label6)
        Me.SettingsBox.Controls.Add(Me.Secs)
        Me.SettingsBox.Controls.Add(Me.Label5)
        Me.SettingsBox.Controls.Add(Me.Label4)
        Me.SettingsBox.Controls.Add(Me.Mins)
        Me.SettingsBox.Controls.Add(Me.Label3)
        Me.SettingsBox.Controls.Add(Me.Parcourir)
        Me.SettingsBox.Controls.Add(Me.RepSauv)
        Me.SettingsBox.Location = New System.Drawing.Point(16, 91)
        Me.SettingsBox.Name = "SettingsBox"
        Me.SettingsBox.Size = New System.Drawing.Size(407, 246)
        Me.SettingsBox.TabIndex = 14
        Me.SettingsBox.TabStop = False
        Me.SettingsBox.Text = "Paramètres"
        '
        'PauseCheck
        '
        Me.PauseCheck.AutoSize = True
        Me.PauseCheck.Location = New System.Drawing.Point(283, 64)
        Me.PauseCheck.Name = "PauseCheck"
        Me.PauseCheck.Size = New System.Drawing.Size(102, 17)
        Me.PauseCheck.TabIndex = 16
        Me.PauseCheck.Text = "Pause autorisée"
        Me.PauseCheck.UseVisualStyleBackColor = True
        '
        'cartedefault
        '
        Me.cartedefault.Location = New System.Drawing.Point(355, 94)
        Me.cartedefault.Name = "cartedefault"
        Me.cartedefault.Size = New System.Drawing.Size(32, 32)
        Me.cartedefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cartedefault.TabIndex = 15
        Me.cartedefault.TabStop = False
        '
        'Themes
        '
        Me.Themes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Themes.FormattingEnabled = True
        Me.Themes.Location = New System.Drawing.Point(134, 99)
        Me.Themes.Name = "Themes"
        Me.Themes.Size = New System.Drawing.Size(210, 21)
        Me.Themes.TabIndex = 12
        '
        'Cartes
        '
        Me.Cartes.Controls.Add(Me.carte4)
        Me.Cartes.Controls.Add(Me.carte3)
        Me.Cartes.Controls.Add(Me.carte2)
        Me.Cartes.Controls.Add(Me.carte1)
        Me.Cartes.Controls.Add(Me.carte0)
        Me.Cartes.Location = New System.Drawing.Point(19, 132)
        Me.Cartes.Name = "Cartes"
        Me.Cartes.Size = New System.Drawing.Size(368, 98)
        Me.Cartes.TabIndex = 11
        Me.Cartes.TabStop = False
        Me.Cartes.Text = "Cartes"
        '
        'carte4
        '
        Me.carte4.Location = New System.Drawing.Point(292, 19)
        Me.carte4.Name = "carte4"
        Me.carte4.Size = New System.Drawing.Size(64, 64)
        Me.carte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carte4.TabIndex = 14
        Me.carte4.TabStop = False
        '
        'carte3
        '
        Me.carte3.Location = New System.Drawing.Point(222, 19)
        Me.carte3.Name = "carte3"
        Me.carte3.Size = New System.Drawing.Size(64, 64)
        Me.carte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carte3.TabIndex = 13
        Me.carte3.TabStop = False
        '
        'carte2
        '
        Me.carte2.Location = New System.Drawing.Point(152, 19)
        Me.carte2.Name = "carte2"
        Me.carte2.Size = New System.Drawing.Size(64, 64)
        Me.carte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carte2.TabIndex = 12
        Me.carte2.TabStop = False
        '
        'carte1
        '
        Me.carte1.Location = New System.Drawing.Point(82, 19)
        Me.carte1.Name = "carte1"
        Me.carte1.Size = New System.Drawing.Size(64, 64)
        Me.carte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carte1.TabIndex = 11
        Me.carte1.TabStop = False
        '
        'carte0
        '
        Me.carte0.Location = New System.Drawing.Point(12, 19)
        Me.carte0.Name = "carte0"
        Me.carte0.Size = New System.Drawing.Size(64, 64)
        Me.carte0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carte0.TabIndex = 10
        Me.carte0.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Thème"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "secs"
        '
        'Secs
        '
        Me.Secs.Location = New System.Drawing.Point(204, 62)
        Me.Secs.Name = "Secs"
        Me.Secs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Secs.Size = New System.Drawing.Size(31, 20)
        Me.Secs.TabIndex = 6
        Me.Secs.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "mins"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Durée d'une partie"
        '
        'Mins
        '
        Me.Mins.Location = New System.Drawing.Point(134, 63)
        Me.Mins.Name = "Mins"
        Me.Mins.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mins.Size = New System.Drawing.Size(31, 20)
        Me.Mins.TabIndex = 3
        Me.Mins.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Répertoire"
        '
        'Parcourir
        '
        Me.Parcourir.Location = New System.Drawing.Point(289, 26)
        Me.Parcourir.Name = "Parcourir"
        Me.Parcourir.Size = New System.Drawing.Size(98, 21)
        Me.Parcourir.TabIndex = 1
        Me.Parcourir.Text = "Parcourir"
        Me.Parcourir.UseVisualStyleBackColor = True
        '
        'RepSauv
        '
        Me.RepSauv.Location = New System.Drawing.Point(134, 27)
        Me.RepSauv.Name = "RepSauv"
        Me.RepSauv.ReadOnly = True
        Me.RepSauv.Size = New System.Drawing.Size(149, 20)
        Me.RepSauv.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(16, 343)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(406, 30)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "Enregistrer"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ImageLogo
        '
        Me.ImageLogo.Image = Global.ProjetIHM.My.Resources.Resources.logo
        Me.ImageLogo.Location = New System.Drawing.Point(19, 16)
        Me.ImageLogo.Name = "ImageLogo"
        Me.ImageLogo.Size = New System.Drawing.Size(58, 58)
        Me.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageLogo.TabIndex = 16
        Me.ImageLogo.TabStop = False
        '
        'Parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 388)
        Me.Controls.Add(Me.ImageLogo)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.SettingsBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Parametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres - 4 Memory"
        Me.SettingsBox.ResumeLayout(False)
        Me.SettingsBox.PerformLayout()
        CType(Me.cartedefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cartes.ResumeLayout(False)
        CType(Me.carte4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SettingsBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Parcourir As Button
    Friend WithEvents RepSauv As TextBox
    Friend WithEvents FolderDialog As FolderBrowserDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Secs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Mins As TextBox
    Friend WithEvents Cartes As GroupBox
    Friend WithEvents carte4 As PictureBox
    Friend WithEvents carte3 As PictureBox
    Friend WithEvents carte2 As PictureBox
    Friend WithEvents carte1 As PictureBox
    Friend WithEvents carte0 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cartedefault As PictureBox
    Friend WithEvents Themes As ComboBox
    Friend WithEvents PauseCheck As CheckBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ImageLogo As PictureBox
End Class
