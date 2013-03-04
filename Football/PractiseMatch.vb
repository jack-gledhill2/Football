Imports System.Linq

Module PractiseMatch
    Sub Main()

        Dim MyManager As New Manager()

        'Dim FilteredList As IEnumerable(Of Player)

        ' FilteredList = From t In MyManager.TeamList Ord

        Dim PlayerCount As Int16 = 15




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
