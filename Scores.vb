Public Class Scores

    Dim Ordre As String = "Carrés max DESC, Temps pris ASC"

    Public Sub ReloadScoreboard()

        'Public Property nom As String
        'Public Property carreMax As Integer
        'Public Property tempsMin As Integer
        'Public Property parties As Integer
        'Public Property cumulTemps As Integer

        Dim playersTable As DataTable = New DataTable()

        Dim nomCol As DataColumn = New DataColumn("Nom", GetType(String))

        playersTable.Columns.Add(nomCol)
        playersTable.Columns.Add(New DataColumn("Carrés max", GetType(Integer)))
        playersTable.Columns.Add(New DataColumn("Temps pris", GetType(String)))
        playersTable.Columns.Add(New DataColumn("Parties jouées", GetType(Integer)))
        playersTable.Columns.Add(New DataColumn("Temps cumulé", GetType(String)))

        playersTable.PrimaryKey = New DataColumn() {nomCol}

        For Each ply As Player In Players
            Dim tempsMin As TimeSpan = TimeSpan.FromSeconds(ply.tempsMin)
            Dim cumulTemps As TimeSpan = TimeSpan.FromSeconds(ply.cumulTemps)

            playersTable.Rows.Add(ply.nom, ply.carreMax, tempsMin.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        tempsMin.Seconds.ToString.PadLeft(2, "0"c), ply.parties, cumulTemps.Hours.ToString.PadLeft(2, "0"c) & ":" &
                        cumulTemps.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        cumulTemps.Seconds.ToString.PadLeft(2, "0"c))
        Next

        Dim vw As DataView = playersTable.DefaultView
        vw.Sort = Ordre

        Me.PlayersTbl.DataSource = vw
        Me.PlayersTbl.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic
        Me.PlayersTbl.Columns(1).SortMode = DataGridViewColumnSortMode.Programmatic
        Me.PlayersTbl.Columns(2).SortMode = DataGridViewColumnSortMode.Programmatic
        Me.PlayersTbl.Columns(3).SortMode = DataGridViewColumnSortMode.Programmatic
        Me.PlayersTbl.Columns(4).SortMode = DataGridViewColumnSortMode.Programmatic

        Me.PlayersCombo.Items.Clear()
        For Each row As DataRow In playersTable.Rows
            Me.PlayersCombo.Items.Add(row("Nom"))
        Next
    End Sub

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadScoreboard()
    End Sub

    Private Sub Form_Exit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PlayersCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayersCombo.SelectedIndexChanged
        Dim ply As Player = Players.Find(Function(p) p.nom = Me.PlayersCombo.SelectedItem)

        Dim tempsMin As TimeSpan = TimeSpan.FromSeconds(ply.tempsMin)
        Dim cumulTemps As TimeSpan = TimeSpan.FromSeconds(ply.cumulTemps)

        MsgBox("Nom du joueur: " & ply.nom &
               Environment.NewLine & "Max de carrés trouvés: " & ply.carreMax &
               Environment.NewLine & "Temps minimum pour trouver " & ply.carreMax & " carrés: " & tempsMin.Minutes.ToString.PadLeft(2, "0"c) &
                        ":" & tempsMin.Seconds.ToString.PadLeft(2, "0"c) &
               Environment.NewLine & "Parties jouées: " & ply.parties &
               Environment.NewLine & "Temps cumulé en jeu: " & cumulTemps.Hours.ToString.PadLeft(2, "0"c) & ":" &
                        cumulTemps.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        cumulTemps.Seconds.ToString.PadLeft(2, "0"c), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information du joueur")
    End Sub

    Private Sub ModeOrdre_Click(sender As Object, e As EventArgs) Handles ModeOrdre.Click
        If Ordre = "Carrés max DESC, Temps pris ASC" Then
            Ordre = "Carrés max ASC, Temps pris ASC"
            ModeOrdre.Text = "Affichage croissant"
        Else
            Ordre = "Carrés max DESC, Temps pris ASC"
            ModeOrdre.Text = "Affichage décroissant"
        End If
        ReloadScoreboard()
    End Sub
End Class