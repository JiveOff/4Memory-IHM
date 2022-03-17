<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.Button()
        Me.ScoresButton = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.PlayerName = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(93, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4 Memory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(97, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Le jeu de mémorisation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(83, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Entrez votre nom..."
        '
        'Play
        '
        Me.Play.Enabled = False
        Me.Play.Location = New System.Drawing.Point(64, 166)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(159, 25)
        Me.Play.TabIndex = 4
        Me.Play.Text = "Jouer"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Location = New System.Drawing.Point(64, 224)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(159, 25)
        Me.Options.TabIndex = 5
        Me.Options.Text = "Paramètres"
        Me.Options.UseVisualStyleBackColor = True
        '
        'ScoresButton
        '
        Me.ScoresButton.Location = New System.Drawing.Point(64, 255)
        Me.ScoresButton.Name = "ScoresButton"
        Me.ScoresButton.Size = New System.Drawing.Size(159, 25)
        Me.ScoresButton.TabIndex = 6
        Me.ScoresButton.Text = "Scores"
        Me.ScoresButton.UseVisualStyleBackColor = True
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(64, 286)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(159, 25)
        Me.Quitter.TabIndex = 7
        Me.Quitter.Text = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'PlayerName
        '
        Me.PlayerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PlayerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PlayerName.FormattingEnabled = True
        Me.PlayerName.Location = New System.Drawing.Point(34, 140)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(220, 21)
        Me.PlayerName.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetIHM.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(29, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 342)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PlayerName)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.ScoresButton)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4 Memory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Play As Button
    Friend WithEvents Options As Button
    Friend WithEvents ScoresButton As Button
    Friend WithEvents Quitter As Button
    Friend WithEvents PlayerName As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
