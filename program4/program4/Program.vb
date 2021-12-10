Imports System.Console

Module Program
    Sub Main()

        Dim n1, n2, n3 As String

        Write("Enter 1st Number : ")
        n1 = ReadLine()

        Write("Enter 2nd Number : ")
        n2 = ReadLine()

        Write("Enter 3rd Number : ")
        n3 = ReadLine()

        If n1 > n2 Then
            WriteLine("N1 Is Maximum Number")
        ElseIf n1 > n3 Then
            WriteLine("N1 Is Maximum Number")
        ElseIf n2 > n3 Then
            WriteLine("N2 Is Maximum Number")
        ElseIf n3 > n1 Then
            WriteLine("N3 Is Maximum Number")
        Else
            WriteLine("Number Is Not Valid")
        End If


    End Sub
End Module
