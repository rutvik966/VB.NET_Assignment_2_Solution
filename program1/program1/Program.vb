Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        If no > 0 Then
            WriteLine("Number Is Positive")
        ElseIf no = 0 Then
            WriteLine("Number Is Zero")
        ElseIf no < 0 Then
            WriteLine("Number Is Negative")
        Else
            WriteLine("Not Valid Number")
        End If


    End Sub
End Module
