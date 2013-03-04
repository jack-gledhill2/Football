Imports System.Linq

Module PractiseMatch
    Sub Main()

        Dim MyManager As New Manager()
        Dim PlayerPossesion As Int16 = RndPosession()

        MyManager.TeamList(PlayerPossesion).Possession = True

        For Each Player In MyManager.TeamList
            If Player.Possession Then
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name & " ON THE BALL!")
            Else
                Console.WriteLine(CStr(Player.ShirtNumber) & " " & Player.Name)
            End If
        Next

    End Sub


    Public Function RndPosession() As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 11)
    End Function

End Module
