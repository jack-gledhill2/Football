''' <summary>
''' Random possesion let's work on this
''' </summary>
''' <remarks></remarks>
Public Class Possession
    Public PlayerNumber
    Private MyValue As Integer
    Sub New()
        Me.MyValue = CInt(Int((10 * Rnd()) + 0))
        PlayerNumber = Me.MyValue
    End Sub

End Class
