Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        If no >= 40 Then
            WriteLine("PASS")
        Else
            WriteLine("FAIL")
        End If


    End Sub
End Module
