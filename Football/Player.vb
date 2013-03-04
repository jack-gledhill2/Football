Public Class Player

    Private _name As String
    Private _birthDate As DateTime
    Private _shirtNumber As Integer
    Private _strongerFoot As String
    Private _position As String
    Private _possession As Boolean

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

    Public Sub New(ByVal Player_Name As String, ByVal ShirtNumber As Integer)

        Name = Player_Name
        _shirtNumber = ShirtNumber

    End Sub
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

    Public ReadOnly Property Possession As Boolean
        Get

        End Get

    End Property
End Class

