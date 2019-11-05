Imports OOP_Dll


Module Module1
    Sub Main()
        Dim person1 As Humans = New Indian
        Dim person2 As Humans = New Human
        ' Dim person3 As Humans = New Humans 'will throw error
        Dim person4 As Indian = New Indian

        person1.speak("asd123")
        person2.speak("something")

        person1.Eat()
        person4.Eat()

        person1.Setage(5)
        Console.Write(person1.Getage() & vbCrLf)

        'person2.dosomething()

        Console.ReadKey()
    End Sub

End Module


Class Human
    Inherits Humans

    Public Shared Sub dosomething()
        Console.Write("Did something" & vbCrLf)
    End Sub
End Class
Class Indian
    Inherits Human
    Public Overrides Sub speak(ByVal str As String)
        Console.Write("Speaks Tamil" & vbCrLf)
    End Sub
    Public Sub Eat()
        Console.Write("Eats Rice" & vbCrLf)
    End Sub
End Class
