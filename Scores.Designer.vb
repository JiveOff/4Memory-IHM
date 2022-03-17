<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scores))
        Me.PlayersTbl = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayersCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ModeOrdre = New System.Windows.Forms.Button()
        Me.ImageLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PlayersTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayersTbl
        '
        Me.PlayersTbl.AllowUserToAddRows = False
        Me.PlayersTbl.AllowUserToDeleteRows = False
        Me.PlayersTbl.AllowUserToResizeColumns = False
        Me.PlayersTbl.AllowUserToResizeRows = False
        Me.PlayersTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PlayersTbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PlayersTbl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.PlayersTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayersTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlayersTbl.Location = New System.Drawing.Point(12, 120)
        Me.PlayersTbl.Name = "PlayersTbl"
        Me.PlayersTbl.ReadOnly = True
        Me.PlayersTbl.ShowEditingIcon = False
        Me.PlayersTbl.Size = New System.Drawing.Size(611, 316)
        Me.PlayersTbl.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(81, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Le jeu de mémorisation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "4 Memory"
        '
        'PlayersCombo
        '
        Me.PlayersCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PlayersCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PlayersCombo.FormattingEnabled = True
        Me.PlayersCombo.Location = New System.Drawing.Point(459, 42)
        Me.PlayersCombo.Name = "PlayersCombo"
        Me.PlayersCombo.Size = New System.Drawing.Size(147, 21)
        Me.PlayersCombo.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(466, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Rechercher un joueur"
        '
        'ModeOrdre
        '
        Me.ModeOrdre.Location = New System.Drawing.Point(12, 86)
        Me.ModeOrdre.Name = "ModeOrdre"
        Me.ModeOrdre.Size = New System.Drawing.Size(611, 21)
        Me.ModeOrdre.TabIndex = 16
        Me.ModeOrdre.Text = "Affichage décroissant"
        Me.ModeOrdre.UseVisualStyleBackColor = True
        '
        'ImageLogo
        '
        Me.ImageLogo.Image = Global.ProjetIHM.My.Resources.Resources.logo
        Me.ImageLogo.Location = New System.Drawing.Point(13, 13)
        Me.ImageLogo.Name = "ImageLogo"
        Me.ImageLogo.Size = New System.Drawing.Size(58, 58)
        Me.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageLogo.TabIndex = 17
        Me.ImageLogo.TabStop = False
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 450)
        Me.Controls.Add(Me.ImageLogo)
        Me.Controls.Add(Me.ModeOrdre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PlayersCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayersTbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores - 4 Memory"
        CType(Me.PlayersTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayersTbl As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayersCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ModeOrdre As Button
    Friend WithEvents ImageLogo As PictureBox
End Class
