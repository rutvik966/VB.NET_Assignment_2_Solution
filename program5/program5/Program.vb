Imports System.Console

Module Program
    Sub Main()

        Dim s1, s2, s3, s4, s5, s6, total, per As Double

        Write("Enter 1st Subject Mark : ")
        s1 = ReadLine()

        Write("Enter 2nd Subject Mark : ")
        s2 = ReadLine()

        Write("Enter 3rd Subject Mark : ")
        s3 = ReadLine()

        Write("Enter 4th Subject Mark : ")
        s4 = ReadLine()

        Write("Enter 5th Subject Mark : ")
        s5 = ReadLine()

        Write("Enter 6th Subject Mark : ")
        s6 = ReadLine()

        total = s1 + s2 + s3 + s4 + s5 + s6
        per = total / 6

        WriteLine("Total Of Subject Mark : " & total)
        WriteLine("Percentage Is " & per)

        If per >= 70 Then
            WriteLine("DIST")
        ElseIf per >= 60 Then
            WriteLine("FIRST")
        ElseIf per > 50 Then
            WriteLine("SECOND")
        ElseIf per >= 40 Then
            WriteLine("PASS")
        ElseIf per < 40 Then
            WriteLine("FAIL")
        Else
            WriteLine("FAIL")
        End If


    End Sub
End Module
