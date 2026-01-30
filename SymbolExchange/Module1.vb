Module Module1

    Sub Main()
        Console.WriteLine("Input a string")
        Dim strLine1 = Console.ReadLine()
        Dim nLen = strLine1.Length
        Dim strLine2 = strLine1(nLen - 1) & strLine1.Substring(1, nLen - 2) & strLine1(0)
        Console.WriteLine("Exchange the first and the last symbol in the string")
        Console.WriteLine("Source string:{0}", strLine1)
        Console.WriteLine("Destinstion string:{0}", strLine2)
        Console.Read()
    End Sub

End Module
