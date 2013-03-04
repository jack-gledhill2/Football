Public Class Team
    Private _name As String
    Private _dtEstablished As DateTime

    Property dtEstablished As DateTime
        Get
            Return _dtEstablished
        End Get
        Set(ByVal value As DateTime)
            Me._dtEstablished = dtEstablished
        End Set
    End Property


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

    Public Sub New(ByVal ListOfPlayers As IList(Of Player))

        'Dim myPlayer As New Player("Jack Gledhill")

        _ListOfPlayers = ListOfPlayers
        _dtEstablished = Now()

    End Sub


End Class
