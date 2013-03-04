Imports System.Linq

Module PractiseMatch
    Sub Main()
        Dim Team As New Team()
        Dim FilteredList As IEnumerable(Of Player)

        FilteredList = From t In Team._ListOfPlayers Where t.Name Like "Jack Gledhill"

        For Each Player In FilteredList
            Console.WriteLine(Player.Name)
        Next

    End Sub




End Module
