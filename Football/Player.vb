Public Class Player

    Private _name As String
    Private _birthDate As DateTime
    Private _shirtNumber As Integer
    Private _strongerFoot As String
    Private _position As String
    Private _possession As Boolean

    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property

    ''' <summary>
    ''' Creates a new player imstance
    ''' </summary>
    ''' <param name="Player_Name">The players name</param>
    ''' <param name="BirthDate">The players age</param>
    ''' <param name="ShirtNumber">The players shirt number</param>
    ''' <param name="StrongerFoot">The Players stronger foot</param>
    ''' <param name="Position">The player position</param>
    ''' <param name="Possession">Whether the player has the ball or not</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Player_Name As String,
                   ByVal BirthDate As DateTime,
                   ByVal ShirtNumber As Integer,
                   ByVal StrongerFoot As String,
                   ByVal Position As String,
                   ByVal Possession As Boolean)

        _name = Player_Name
        _birthDate = BirthDate
        _shirtNumber = ShirtNumber
        _strongerFoot = StrongerFoot
        _position = Position
        _possession = Possession

    End Sub
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
    Property ShirtNumber As Integer
        Get
            Return _shirtNumber

        End Get
        Set(ByVal value As Integer)
            _shirtNumber = value
        End Set
    End Property
    Property StrongFoot As Boolean
        Get
            Return _strongerFoot
        End Get
        Set(ByVal value As Boolean)
            _strongerFoot = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _position = value
            End If
        End Set
    End Property
    Public Property Possession As Boolean
        Get
            Return _possession
        End Get
        Set(ByVal value As Boolean)
            _possession = value
        End Set
    End Property


End Class

