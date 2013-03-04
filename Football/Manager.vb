Public Class Manager

    Public TeamList As IEnumerable(Of Player)

    Public Sub New()

        Dim Sqaud As New Squad()

        Dim PlayerCount As Int16 = 0

        Dim MyTeamSelection As New List(Of Player)
        Dim player As Player

        'list of players

        For Each player In Sqaud.Players

            'select his squad

            PlayerCount = PlayerCount + 1

            MyTeamSelection.Add(player)

            If PlayerCount = 15 Then Exit For
        Next

        TeamList = MyTeamSelection

    End Sub

End Class
