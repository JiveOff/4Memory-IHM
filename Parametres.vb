Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Public Class Parametres

    Private RegistryKey As String = "HKEY_CURRENT_USER\Software\4Memory"

    Public minutes As Integer = 1
    Public secondes As Integer = 0

    Public repertoire As String = Path.GetDirectoryName(Assembly.GetEntryAssembly.Location)

    Public theme As String = "default"

    Public pause As Boolean = False
    Public cheat As Boolean = False

    Private reloading As Boolean = False

    Dim konamiCode() As Object = {Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A}
    Dim konamiSequence() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    Dim konamiIndex As Integer = 0

    Private Sub Parametres_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        If konamiIndex < 9 And konamiSequence(konamiIndex) = False And e.KeyCode = konamiCode(konamiIndex) Then
            konamiSequence(konamiIndex) = True
            konamiIndex += 1
        ElseIf konamiIndex = 9 And e.KeyCode = konamiCode(konamiIndex) Then
            If (cheat) Then
                MsgBox("Ouais ouais, je préfère ça.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mode Triche désactivé")
                cheat = False
            Else
                MsgBox("Le Konami Code... je me demande bien à quoi celui-ci va servir sur un 4 Memory..." & Environment.NewLine & "Essayez de lancer une nouvelle partie pour voir?", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "Mode Triche activé")
                cheat = True
            End If
        Else
            konamiIndex = 0
            For i As Integer = 0 To konamiSequence.Length - 1
                konamiSequence(i) = False
            Next
        End If
    End Sub

    Private Sub Parcourir_Click(sender As Object, e As EventArgs) Handles Parcourir.Click
        Dim DialogRes As DialogResult = Me.FolderDialog.ShowDialog()
        If DialogRes = DialogResult.OK And Not String.IsNullOrWhiteSpace(Me.FolderDialog.SelectedPath) Then
            repertoire = Me.FolderDialog.SelectedPath
            Me.RepSauv.Text = repertoire
            LoadPlayers()
            Scores.ReloadScoreboard()
        End If
    End Sub

    Private Sub ReloadSettings()
        reloading = True

        Me.RepSauv.Text = repertoire

        Me.Themes.Items.Clear()
        For Each Dir As String In System.IO.Directory.GetDirectories("./images/themes")
            If File.Exists(Dir & "/carte0.png") And File.Exists(Dir & "/carte1.png") And File.Exists(Dir & "/carte2.png") And File.Exists(Dir & "/carte3.png") And File.Exists(Dir & "/carte4.png") And File.Exists(Dir & "/cartedefault.png") Then
                Me.Themes.Items.Add(Dir.Replace("./images/themes\", ""))
            End If
        Next
        Me.Themes.SelectedItem = Me.theme

        Me.carte0.Image = Image.FromFile(".//images//themes//" & Me.theme & "//carte0.png")
        Me.carte1.Image = Image.FromFile(".//images//themes//" & Me.theme & "//carte1.png")
        Me.carte2.Image = Image.FromFile(".//images//themes//" & Me.theme & "//carte2.png")
        Me.carte3.Image = Image.FromFile(".//images//themes//" & Me.theme & "//carte3.png")
        Me.carte4.Image = Image.FromFile(".//images//themes//" & Me.theme & "//carte4.png")
        Me.cartedefault.Image = Image.FromFile(".//images//themes//" & Me.theme & "//cartedefault.png")

        Me.PauseCheck.Checked = Me.pause

        Me.Mins.Text = minutes.ToString()
        Me.Secs.Text = secondes.ToString()

        reloading = False
    End Sub

    Private Sub Themes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Themes.SelectedIndexChanged
        Me.theme = Me.Themes.SelectedItem
        If Not reloading Then
            ReloadSettings()
        End If
    End Sub

    Public Sub LoadSettingsFromRegistry()
        If My.Computer.Registry.GetValue(RegistryKey, "SaveDirectory", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue(RegistryKey, "SaveDirectory", repertoire)
        Else
            repertoire = My.Computer.Registry.GetValue(RegistryKey, "SaveDirectory", Nothing)
        End If

        If My.Computer.Registry.GetValue(RegistryKey, "GameTime", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue(RegistryKey, "GameTime", minutes & ":" & secondes)
        Else
            Dim GameTime() As String = My.Computer.Registry.GetValue(RegistryKey, "GameTime", Nothing).ToString().Split(New String() {":"}, StringSplitOptions.None)
            minutes = Int32.Parse(GameTime(0))
            secondes = Int32.Parse(GameTime(1))
        End If

        If My.Computer.Registry.GetValue(RegistryKey, "Theme", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue(RegistryKey, "Theme", theme)
        Else
            theme = My.Computer.Registry.GetValue(RegistryKey, "Theme", Nothing)
        End If

        If My.Computer.Registry.GetValue(RegistryKey, "Pause", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue(RegistryKey, "Pause", pause.ToString())
        Else
            pause = Boolean.Parse(My.Computer.Registry.GetValue(RegistryKey, "Pause", Nothing).ToString())
        End If
    End Sub

    Public Sub SaveSettingsToRegistry()
        My.Computer.Registry.SetValue(RegistryKey, "SaveDirectory", repertoire)
        My.Computer.Registry.SetValue(RegistryKey, "GameTime", minutes & ":" & secondes)
        My.Computer.Registry.SetValue(RegistryKey, "Theme", theme)
        My.Computer.Registry.SetValue(RegistryKey, "Pause", pause.ToString())
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        ReloadSettings()
    End Sub

    Private Sub MinSec_Check(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Mins.KeyPress, Secs.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Return
            End If
        End If
    End Sub

    Private Sub Form_Exit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        SaveButton_Click(sender, e)
    End Sub

    Private Sub MinsSecs_TextChanged(sender As Object, e As EventArgs) Handles Mins.TextChanged, Secs.TextChanged
        If Not reloading Then
            If Not String.IsNullOrWhiteSpace(Me.Mins.Text) Then
                If Convert.ToInt32(Me.Mins.Text) >= 60 Then
                    Me.Mins.Text = 59
                End If
                Me.minutes = Convert.ToInt32(Me.Mins.Text)
            End If
            If Not String.IsNullOrWhiteSpace(Me.Secs.Text) Then
                If Convert.ToInt32(Me.Secs.Text) >= 60 Then
                    Me.Secs.Text = 59
                End If
                Me.secondes = Convert.ToInt32(Me.Secs.Text)
            End If
        End If
    End Sub

    Private Sub Pause_CheckedChanged(sender As Object, e As EventArgs) Handles PauseCheck.CheckedChanged
        Me.pause = Me.PauseCheck.Checked
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveSettingsToRegistry()
        Me.Hide()
        Home.Show()
    End Sub
End Class