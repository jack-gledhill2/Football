Imports System.Linq

Module PractiseMatch
    Sub Main()

        Dim MyManager As New Manager()
        Dim PlayerPossesion As Int16 = RndPosession()

        MyManager.TeamList(PlayerPossesion).Possession = True

        ' match starts
        For Each Player In MyManager.TeamList
            If Player.Possession Then
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name & " ON THE BALL!")
            Else
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name)
            End If
        Next

        'gill' keep possesssion for 11 passes
        For a = 0 To 10
            'take ball away
            MyManager.TeamList(PlayerPossesion).Possession = False
            'pick a new player to pass to
            PlayerPossesion = RndPosession()
            MyManager.TeamList(PlayerPossesion).Possession = True
            'Display the player
            Console.WriteLine(CStr(MyManager.TeamList(PlayerPossesion).ShirtNumber) & " " & MyManager.TeamList(PlayerPossesion).Name & " ON THE BALL!")
        Next

    End Sub


    Public Function RndPosession() As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(0, 10)
    End Function

End Module
