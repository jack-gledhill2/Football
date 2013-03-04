''' <summary>
''' Random possesion
''' </summary>
''' <remarks></remarks>
Public Class Possession
    Public PlayerNumber As Int16
    Public Sub New()

        Dim rn As New Random

        PlayerNumber = rn.Next(0, 10)

        rn = Nothing


    End Sub
End Class
