Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        If no Mod 2 = 0 Then
            WriteLine("Number Is Even")
        Else
            WriteLine("Number Is Odd")
        End If


    End Sub
End Module
