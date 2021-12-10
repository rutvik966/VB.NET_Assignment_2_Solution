Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        Select Case no Mod 2
            Case 0
                WriteLine("Number Is Even")
            Case Else
                WriteLine("Number Is Odd")
        End Select


    End Sub
End Module
