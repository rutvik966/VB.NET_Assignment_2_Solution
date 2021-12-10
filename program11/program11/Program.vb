Imports System.Console

Module Program
    Sub Main()

        Dim a As Double

        Write("Enter Days : ")
        a = ReadLine()

        WriteLine("Days IS " & a)
        WriteLine("Months Is " & a / 30)
        WriteLine("Year Is " & a / 360)

    End Sub
End Module
