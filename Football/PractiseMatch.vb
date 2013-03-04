Imports System.Linq

Module PractiseMatch
    Sub Main()

        Dim Possession As New Possession()
        Dim MyManager As New Manager()

        ' match starts
        For Each Player In MyManager.TeamList
            If Player.Possession Then
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name & " ON THE BALL!")
            Else
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name)
            End If
        Next

        GameInPLay()
        'Ball in play keep possesssion for 11 passes

        For a = 0 To 10
            'take ball away
            MyManager.TeamList(Possession.PlayerNumber).Possession = False
            'pick a new player to pass to
            Possession = Nothing

            Possession = New Possession()

            'Display the player
            Console.WriteLine(CStr(MyManager.TeamList(Possession.PlayerNumber).ShirtNumber) & " " & _
                              MyManager.TeamList(Possession.PlayerNumber).Name & " ON THE BALL!")
        Next

        Console.ReadKey()

    End Sub



    Sub GameInPLay()
        Console.WriteLine("")
        Console.WriteLine("--------------------")
        Console.WriteLine("Game in play")
        Console.WriteLine("--------------------")
        Console.WriteLine("")
    End Sub
End Module
