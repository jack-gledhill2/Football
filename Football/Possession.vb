''' <summary>
''' Random possesion let's work on this
''' </summary>
''' <remarks></remarks>
Public Class Possession
    Public PlayerNumber As Int16
    Public Sub New()

        Dim MyValue As Integer
        MyValue = CInt(Int((10 * Rnd()) + 0)) ' Generate random value between 1 and 6.

        PlayerNumber = MyValue

    End Sub
End Class
