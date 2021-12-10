Imports System.Console

Module Program
    Sub Main()

        Dim a As Double

        Write("Enter Any 2 Digit Number Value : ")
        a = ReadLine()

        WriteLine("Sum Of 2 Numbers Is " & ((a \ 10) + (a Mod 10)))

        'WriteLine("Seprate The Number Are....")
        'WriteLine("First Value Is " & a \ 10)
        'WriteLine("Second Value Is " & a Mod 10)

    End Sub
End Module
