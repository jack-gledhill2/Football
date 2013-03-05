Public Class Manager

    Private _name As String
    Private _birthDate As DateTime

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
    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property


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

            If PlayerCount = 11 Then Exit For
        Next

        TeamList = MyTeamSelection

    End Sub

End Class
