Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Number : ")
        no = ReadLine()

        Select Case no
            Case 1 To 9
                WriteLine("1 to 9")
            Case 10 To 19
                WriteLine("10 to 19")
            Case 20 To 29
                WriteLine("20 to 19")
            Case 30 To 39
                WriteLine("30 to 19")
            Case 40 To 49
                WriteLine("40 to 19")
            Case 50 To 59
                WriteLine("50 to 19")
            Case 60 To 69
                WriteLine("60 to 19")
            Case 70 To 79
                WriteLine("70 to 19")
            Case 80 To 89
                WriteLine("80 to 19")
            Case 90 To 99
                WriteLine("90 to 19")
            Case Else
                WriteLine("Out Of 99")
        End Select



    End Sub
End Module