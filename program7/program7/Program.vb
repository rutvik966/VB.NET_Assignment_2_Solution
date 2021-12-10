Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        If no Mod 3 = 0 And no Mod 5 = 0 Then
            WriteLine("Divisible By 5 And 3")
        ElseIf no Mod 3 = 0 Then
            WriteLine("Number Is Divisible By 3")
        ElseIf no Mod 5 = 0 Then
            WriteLine("Number Is Divisible By 5")
        Else
            WriteLine("Not Divisible By 5 And/Or 3")
        End If


    End Sub
End Module