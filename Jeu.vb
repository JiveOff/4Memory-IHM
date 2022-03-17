Public Class Jeu

    Dim tempsRestant As Date = #00:00:00#
    Dim bypassClose As Boolean
    Dim imageDefaut As Image = Image.FromFile(".//images//themes//" & Parametres.theme & "//cartedefault.png")
    Dim setSelected As Integer = -1
    Dim ignoreInput As Boolean = False

    Dim carreIdentifie As Integer = 0

    Dim debutCarre As Double
    Dim debutPartieTime As Double
    Dim lastCarre As Double = -1

    Dim paused As Boolean = False

    Private Class Card
        Public Property id As Integer
        Public Property label As Label
        Public Property image As Image
        Public Property imageSet As Integer
        Public Property shown As Boolean
    End Class

    Private Cartes As New List(Of Card)

    Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
    End Function

    Public Sub Wait(ByVal seconds As Single)
        Static start As Single
        start = Microsoft.VisualBasic.Timer()
        Do While Microsoft.VisualBasic.Timer() < start + seconds
            Application.DoEvents()
        Loop
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Pause.Enabled = False
        Me.paused = False
        Me.GroupBoxCartes.Enabled = True

        Me.Triche.Visible = Parametres.cheat

        bypassClose = False
        carreIdentifie = 0

        tempsRestant = #00:00:00#
        tempsRestant = DateAdd(DateInterval.Minute, Parametres.minutes, tempsRestant)
        tempsRestant = DateAdd(DateInterval.Second, Parametres.secondes, tempsRestant)

        Me.Temps.Text = Format(tempsRestant, "mm:ss")
        For v As Integer = 1 To 20
            Me.Cartes.Add(New Card() With {
                .image = Image.FromFile(".//images//themes//" & Parametres.theme & "//carte" & v Mod 5 & ".png"),
                .imageSet = v Mod 5,
                .shown = False
            })
        Next
        Cartes = Shuffle(Cartes)
        Dim i As Integer = 0
        For Each Carte As Label In GroupBoxCartes.Controls
            Me.Cartes(i).id = i
            Me.Cartes(i).label = Carte
            Me.Cartes(i).label.Image = Image.FromFile(".//images//themes//" & Parametres.theme & "//cartedefault.png")
            Me.Cartes(i).label.Name = i
            Me.Cartes(i).label.Enabled = True
            AddHandler Me.Cartes(i).label.Click, AddressOf Me.CarteClick
            i += 1
        Next
    End Sub
    Private Sub RenderCartes()
        For Each Carte As Card In Cartes
            If Carte.label.Enabled = True Then
                If Carte.shown Then
                    Carte.label.Image = Carte.image
                Else
                    Carte.label.Image = imageDefaut
                End If
            End If
        Next
    End Sub

    Private Sub CarteClick(sender As Object, e As EventArgs)
        Dim LabelCarte As Label = CType(sender, Label)
        Dim Carte As Card = Cartes(Convert.ToInt32(LabelCarte.Name))

        If ignoreInput Then
            Return
        End If

        If Not Me.Timer1.Enabled Then
            DebutPartie()
        End If

        If Not Carte.shown Then
            Carte.shown = True
            RenderCartes()

            If setSelected = Carte.imageSet Then
                Dim found As Integer = 0
                For Each Carte_1 As Card In Cartes
                    If Carte_1.shown = True Then
                        found += 1
                    End If
                Next
                If (found = 4) Then
                    For Each Carte_1 As Card In Cartes
                        If Carte_1.shown = True Then
                            Carte_1.shown = False
                            Carte_1.label.Enabled = False
                        End If
                    Next

                    carreIdentifie += 1
                    lastCarre = Microsoft.VisualBasic.Timer()

                    RenderCartes()
                    CheckWin()
                    setSelected = -1
                End If
            Else
                If setSelected = -1 Then
                    setSelected = Carte.imageSet
                    debutCarre = Microsoft.VisualBasic.Timer()
                Else
                    ignoreInput = True
                    setSelected = -1
                    Wait(1)
                    For Each Carte_1 As Card In Cartes
                        If Carte_1.shown = True Then
                            Carte_1.shown = False
                        End If
                    Next
                    ignoreInput = False
                    RenderCartes()
                End If
            End If
        End If
    End Sub

    Function GetStats() As String

        If (Parametres.cheat) Then
            Return "Vous avez triché. Pas de bras, pas de chocolat."
        End If

        Dim Pb As Boolean, PbTemps = False

        Dim player As Player = Players.Find(Function(p) p.nom = Me.Joueur.Text)
        If (carreIdentifie > player.carreMax) Then
            player.carreMax = carreIdentifie
            player.tempsMin = Math.Floor(lastCarre - debutPartieTime)
            Pb = True
        ElseIf (carreIdentifie = player.carreMax) Then
            If (Math.Floor(lastCarre - debutPartieTime) < player.tempsMin) Then
                player.tempsMin = Math.Floor(lastCarre - debutPartieTime)
                PbTemps = True
            End If
        End If

        Dim tempsPasse As TimeSpan = TimeSpan.FromSeconds(Math.Floor(lastCarre - debutPartieTime))

        player.parties += 1
        SavePlayers()

        If carreIdentifie = 0 Then
            Return "Vous n'avez identifié aucun carré durant cette partie."
        Else
            If Pb Then
                Return "Vous avez pris " & tempsPasse.Minutes.ToString.PadLeft(2, "0"c) & ":" & tempsPasse.Seconds.ToString.PadLeft(2, "0"c) & " pour identifier " & carreIdentifie & " carrés et c'est votre nouveau record personnel de carrés max!"
            ElseIf PbTemps Then
                Return "Vous avez pris " & tempsPasse.Minutes.ToString.PadLeft(2, "0"c) & ":" & tempsPasse.Seconds.ToString.PadLeft(2, "0"c) & " pour identifier " & carreIdentifie & " carrés et c'est votre nouveau record personnel de temps pour ce nombre de carrés!"
            Else
                Return "Vous avez pris " & tempsPasse.Minutes.ToString.PadLeft(2, "0"c) & ":" & tempsPasse.Seconds.ToString.PadLeft(2, "0"c) & " pour identifier " & carreIdentifie & " carrés, mais malheureusement, ce n'est pas votre meilleur score!"
            End If
        End If
    End Function

    Private Sub FinTemps()
        bypassClose = True
        Timer1.Stop()
        MsgBox("Vous avez perdu la partie." & Environment.NewLine & GetStats(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1, "Perdu!")
        Me.Close()
    End Sub

    Private Sub CheckWin()
        Dim Won As Boolean = True
        For Each Carte As Card In Cartes
            If Carte.label.Enabled Then
                Won = False
            End If
        Next
        If Won Then
            Timer1.Stop()
            MsgBox("Vous avez gagné la partie." & Environment.NewLine & GetStats(), MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1, "Gagné!")
            bypassClose = True
            Me.Close()
        End If
    End Sub

    Private Sub DebutPartie()
        Me.Pause.Enabled = Parametres.pause
        debutPartieTime = Microsoft.VisualBasic.Timer()
        Me.Timer1.Interval = 1000.0
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tempsRestant.Second = 0 And tempsRestant.Minute = 0 Then
            FinTemps()
            Return
        End If
        tempsRestant = DateAdd(DateInterval.Second, -1, tempsRestant)
        Me.Temps.Text = Format(tempsRestant, "mm:ss")
        Dim player As Player = Players.Find(Function(p) p.nom = Me.Joueur.Text)
        player.cumulTemps += 1
    End Sub

    Private Sub Abandon_Click(sender As Object, e As EventArgs) Handles Abandon.Click
        Me.Close()
        SavePlayers()
    End Sub

    Private Sub CloseEvent(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bypassClose Then
            Home.Show()
            Return
        End If
        If MsgBox("Voulez-vous vraiment arrêter la partie?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmation de fermeture") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Home.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Triche.Click
        For Each Carte As Card In Cartes
            Carte.shown = Not Carte.shown
        Next
        RenderCartes()
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If ignoreInput Then
            Return
        End If
        Me.paused = Not Me.paused
        Me.Timer1.Enabled = Not Me.paused
        Me.GroupBoxCartes.Enabled = Not Me.paused
    End Sub
End Class