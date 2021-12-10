Imports System.Console

Module Program
    Sub Main()

        Dim a, b As Double
        Dim g As String

        Write("Enter Salary Of Staff Member : ")
        a = ReadLine()

        Write("Enter Gender Of Staff Member : ")
        g = ReadLine()

        Select Case g
            Case "f"
                b = a * 10 / 100
                WriteLine("Your Bonus Is " & b)
            Case "F"
                b = a * 10 / 100
                WriteLine("Your Bonus Is " & b)
            Case "m"
                b = a * 15 / 100
                WriteLine("Your Bonus Is " & b)
            Case "M"
                b = a * 15 / 100
                WriteLine("Your Bonus Is " & b)
            Case Else
                WriteLine("Enter Valid Gender")
        End Select




    End Sub
End Module
