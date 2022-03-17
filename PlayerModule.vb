Imports System.IO

Module PlayerModule

    Dim playersSaveName As String = "players.ihm"

    Public separateur As String = "||"
    Public pw As String = "j9hugZjfsUkHXEMza3XKRSyPDHMLXxU4mRENDm6PvhZcZE62dVw3GCLWGMK6saWJEw2GFzpddeKQAhXc"

    Public Class Player
        Public Property nom As String
        Public Property carreMax As Integer
        Public Property tempsMin As Integer
        Public Property parties As Integer
        Public Property cumulTemps As Integer

        Public Function LoadPlayer(str As String)
            Dim wrapper As New Simple3Des(pw)
            Try
                Dim plainText As String = wrapper.DecryptData(str)
                Dim playerArr() As String = plainText.Split(New String() {separateur}, StringSplitOptions.RemoveEmptyEntries)
                nom = playerArr(0)
                carreMax = Integer.Parse(playerArr(1))
                tempsMin = Integer.Parse(playerArr(2))
                parties = Integer.Parse(playerArr(3))
                cumulTemps = Integer.Parse(playerArr(4))
                Return Me
            Catch ex As System.Security.Cryptography.CryptographicException
                MsgBox("Une erreur est survenue lors du chargement des données joueur.")
                Return False
            End Try
        End Function

        Public Overrides Function ToString() As String
            Dim wrapper As New Simple3Des(pw)
            Return wrapper.EncryptData(nom & separateur & carreMax & separateur & tempsMin & separateur & parties & separateur & cumulTemps)
        End Function
    End Class

    Public Players As New List(Of Player)

    Public Sub LoadPlayers()
        Players.Clear()
        Dim pathSave As String = Parametres.repertoire & "\\4Memory_Data\\"
        If Not Directory.Exists(pathSave) Then
            Directory.CreateDirectory(pathSave)
        End If
        If File.Exists(pathSave & playersSaveName) Then
            Dim reader As New StreamReader(pathSave & playersSaveName)
            While reader.Peek >= 0
                Dim line As String = reader.ReadLine()
                Players.Add(New Player().LoadPlayer(line))
            End While
            reader.Close()
        Else
            Dim fs As FileStream = File.Create(pathSave & playersSaveName)
            fs.Close()
        End If
        Home.PlayerName.Items.Clear()
        For Each ply As Player In Players
            Home.PlayerName.Items.Add(ply.nom)
        Next
    End Sub

    Public Sub SavePlayers()
        Dim pathSave As String = Parametres.repertoire & "\\4Memory_Data\\"
        If Not Directory.Exists(pathSave) Then
            Directory.CreateDirectory("4Memory_Data")
        End If
        If Not File.Exists(pathSave & playersSaveName) Then
            Dim fs As FileStream = File.Create(pathSave & playersSaveName)
            fs.Close()
        End If
        Dim sw As New StreamWriter(pathSave & playersSaveName)
        For Each ply As Player In Players
            sw.WriteLine(ply)
        Next
        sw.Close()
        LoadPlayers()
        Scores.ReloadScoreboard()
    End Sub

End Module
