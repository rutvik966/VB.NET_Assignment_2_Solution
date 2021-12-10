Imports System.Console

Module Program
    Sub Main()

        Dim no As String

        Write("Enter Any Operater : ")
        no = ReadLine()

        Select Case no
            Case "+"
                WriteLine("arithmatic operater")
            Case "-"
                WriteLine("arithmatic operater")
            Case "*"
                WriteLine("arithmatic operater")
            Case "/"
                WriteLine("arithmatic operater")
            Case "\"
                WriteLine("arithmatic operater")
            Case "mod"
                WriteLine("arithmatic operater")
            Case Else
                WriteLine("not arithmatic")
        End Select


    End Sub
End Module