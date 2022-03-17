Imports System.IO
Imports System.Reflection

Public Class Home

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Parametres.LoadSettingsFromRegistry()
        LoadPlayers()
    End Sub

    Private Sub PlayerName_TextChanged(sender As Object, e As EventArgs) Handles PlayerName.TextChanged
        Me.Play.Enabled = Me.PlayerName.Text.Length >= 3
    End Sub

    Private Sub PlayerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PlayerName.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            Jouer(sender, e)
        End If
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub Form_Exit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Voulez-vous vraiment quitter?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmation de fermeture") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Jouer(sender As Object, e As EventArgs) Handles Play.Click
        If (Me.PlayerName.Text.Length >= 3) Then
            If Not Me.PlayerName.Text.Contains(PlayerModule.separateur) Then
                Me.PlayerName.Text = StrConv(Me.PlayerName.Text, VbStrConv.ProperCase)
                If Players.FindAll(Function(p) p.nom = Me.PlayerName.Text).Count = 0 Then
                    Players.Add(New Player() With {
                        .nom = Me.PlayerName.Text,
                        .carreMax = 0,
                        .cumulTemps = 0,
                        .parties = 0,
                        .tempsMin = 0
                    })
                    SavePlayers()
                End If
                Jeu.Show()
                Jeu.Joueur.Text = Me.PlayerName.Text
                Me.Hide()
            Else
                MsgBox("Chaîne de caractère interdite détectée dans le nom du joueur.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erreur")
            End If
        End If
    End Sub

    Private Sub Options_Click(sender As Object, e As EventArgs) Handles Options.Click
        Parametres.Show()
        Me.Hide()
    End Sub

    Private Sub Scores_Click(sender As Object, e As EventArgs) Handles ScoresButton.Click
        Scores.Show()
        Me.Hide()
    End Sub
End Class
