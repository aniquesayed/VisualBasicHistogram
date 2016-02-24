Module Module1

    Sub Main()
        Dim StuMarks As Integer = 0
        Dim Numofstu As Integer = 0
        Dim Marks0to29 As Integer = 0
        Dim Marks30to39 As Integer = 0
        Dim Marks40to69 As Integer = 0
        Dim Marks70to100 As Integer = 0
        Dim TotalMarks As Integer = 0
        Dim Group1 As Integer = 0
        Dim Group2 As Integer = 0
        Dim Group3 As Integer = 0
        Dim Group4 As Integer = 0
        Dim Average As Integer = 0

        Console.WriteLine("Please enter the marks")
        StuMarks = Console.ReadLine()

        While (StuMarks <= 100)
            TotalMarks = TotalMarks + StuMarks
            Numofstu = Numofstu + 1

            If StuMarks >= 0 And StuMarks <= 29 Then
                Marks0to29 = Marks0to29 + 1
            End If

            If StuMarks >= 30 And StuMarks <= 39 Then
                Marks30to39 = Marks30to39 + 1
            End If

            If StuMarks >= 40 And StuMarks <= 69 Then
                Marks40to69 = Marks40to69 + 1
            End If

            If StuMarks >= 70 And StuMarks <= 100 Then
                Marks70to100 = Marks70to100 + 1
            End If

            Console.WriteLine("Please Enter Marks")
            StuMarks = Console.ReadLine()
        End While

        Average = StuMarks / TotalMarks

        Console.WriteLine("0-29 ")
        For Group1 = 1 To Marks0to29
            Console.WriteLine("*")
        Next
        Console.WriteLine()

        Console.WriteLine("30-39 ")
        For Group2 = 1 To Marks30to39
            Console.WriteLine("*")
        Next
        Console.WriteLine()

        Console.WriteLine("40-69 ")
        For Group3 = 1 To Marks40to69
            Console.WriteLine("*")
        Next
        Console.WriteLine()

        Console.WriteLine("70-100 ")
        For Group4 = 1 To Marks70to100
            Console.WriteLine("*")
        Next

        Console.WriteLine()
    End Sub

End Module
