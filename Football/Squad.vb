Public Class Squad

    Public Players As IList(Of Player)

    Public Sub New()

        Dim TempList As New List(Of Player)
        TempList.Add(New Player("Stuart Nelson", Date.FromOADate(17 / 9 / 1981), 1, "R", "Goal keeper", False))
        TempList.Add(New Player("Matt Fish", Date.FromOADate(5 / 1 / 1989), 2, "R", "Defender", False))
        TempList.Add(New Player("Joe Martin", Date.FromOADate(29 / 11 / 1989), 3, "L", "Defender", False))
        TempList.Add(New Player("Leon Legge", Date.FromOADate(1 / 7 / 1985), 6, "R", "Defender", False))
        TempList.Add(New Player("Andy Frampton", Date.FromOADate(3 / 9 / 1979), 12, "R", "Defender", False))
        TempList.Add(New Player("Callum Davies", Date.FromOADate(8 / 2 / 1993), 15, "R", "Defender", False))
        TempList.Add(New Player("Adam Barrett", Date.FromOADate(29 / 11 / 1979), 26, "R", "Defender", False))
        TempList.Add(New Player("Chris Whelpdale", Date.FromOADate(27 / 1 / 1989), 7, "R", "MidFielder", False))
        TempList.Add(New Player("Charlie Lee", Date.FromOADate(5 / 1 / 1987), 8, "R", "MidFielder", False))
        TempList.Add(New Player("Anton Robinson", Date.FromOADate(17 / 2 / 1986), 10, "R", "Midfielder", False))
        TempList.Add(New Player("Charlie Allen", Date.FromOADate(24 / 3 / 1992), 14, "R", "Midfielder", False))
        TempList.Add(New Player("Myles Weston", Date.FromOADate(12 / 3 / 1988), 24, "R", "Midfielder", False))
        TempList.Add(New Player("Steven Gregory", Date.FromOADate(19 / 3 / 1987), 28, "R", "Midfielder", False))
        TempList.Add(New Player("Danny Kedwell", Date.FromOADate(3 / 8 / 1983), 9, "R", "Striker", False))
        TempList.Add(New Player("Adam Birchall", Date.FromOADate(2 / 12 / 1984), 17, "R", "Striker", False))
        TempList.Add(New Player("Antonio German", Date.FromOADate(26 / 12 / 1991), 19, "R", "Striker", False))
        TempList.Add(New Player("Deon Burton", Date.FromOADate(25 / 10 / 1976), 20, "R", "Striker", False))
        Players = TempList

    End Sub
End Class
