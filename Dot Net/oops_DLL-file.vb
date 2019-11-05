Public MustInherit Class Humans
    Private Shared AgeOfman As Integer
    Public Sub Setage(ByVal age As Integer)
        AgeOfman = age
    End Sub
    Public Function Getage()
        Return ("Age is " & AgeOfman)
    End Function
    Public Overridable Sub speak(ByVal str As String)
        Console.Write("Speaks English" & vbCrLf)
    End Sub
    Public Sub Eat()
        Console.Write("Eats Food" & vbCrLf)
    End Sub
End Class
