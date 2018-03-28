Module Module1

    Dim numbersList As New List(Of Integer) 'used to store a list of 1000 numbers between 1 and 100
    Dim largenumbersList As New List(Of Integer) 'used to store a list of 5000 numbers between 1 and 100

    Sub quicksort(ByRef a As List(Of Integer), ByVal LB As Integer, ByVal UB As Integer)



























    End Sub

    Sub print(ByRef a As List(Of Integer))
        Dim i
        For i = 0 To a.Count() - 1
            Console.Write("  " & a(i))
        Next
        Console.WriteLine()
    End Sub

    Private Sub Create_numbersList()
        For i = 0 To 999
            numbersList.Add(Rnd() * 100 + 1)
        Next
    End Sub
    Private Sub Create_largenumbersList()
        For i = 0 To 4999
            largenumbersList.Add(Rnd() * 100 + 1)
        Next
    End Sub

    Private Sub TestQuickSort()
        Randomize()
        print(numbersList)
        'code to carry out a timed sort for numbersList and print out the time
        Dim watchnL As Stopwatch = Stopwatch.StartNew()
        quicksort(numbersList, 0, numbersList.Count - 1) 'quicksort the numbersList
        watchnL.Stop()
        print(numbersList)
        Console.WriteLine("Time taken for quicksort on numbersList (1000 numbers 1..100) is " & watchnL.Elapsed.TotalSeconds & "seconds (press enter for next sort")
        Console.ReadLine()

        print(largenumbersList)
        'code to carry out a timed sort for numbersList and print out the time
        Dim watchLnL As Stopwatch = Stopwatch.StartNew()
        quicksort(largenumbersList, 0, largenumbersList.Count - 1) 'quicksort the numbersList
        watchLnL.Stop()
        print(largenumbersList)
        Console.WriteLine("Time taken for quicksort on largenumbersList (1000 numbers 1..100) is " & watchLnL.Elapsed.TotalSeconds & "seconds")
    End Sub
    Sub main()
        Create_numbersList()
        Create_largenumbersList()
        TestQuickSort()
        Console.ReadLine()
    End Sub
End Module
