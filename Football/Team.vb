Public Class Team
    Private _name As String
    Private _birthDate As DateTime

    Public _ListOfPlayers As IList(Of Player)

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    Public Sub New()

        'Dim myPlayer As New Player("Jack Gledhill")


        Dim TempList As New List(Of Player)()

        Dim Player = New Player("Jack Gledhill", 9)

        TempList.Add(Player)
        TempList.Add(New Player("Jon Pankhurst", 1))

        _ListOfPlayers = TempList

        'i9jiuoj
        'tyest



    End Sub
End Class
