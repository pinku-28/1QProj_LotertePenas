Module Module1

    Public Sub Main()
        Dim name, destination, carrier, airport, airline, receipt, month As String
        Dim flightNumber As New Random
        Dim day, fNumber, i As Integer

        Console.Title = "Sahjeed's Online Airport Portal"

        'Greetings
        Console.WriteLine("Welcome to Sahjeed's Online Airport Portal")
        Console.WriteLine("Est. Sep 11, 2001" & vbNewLine)

        'ask for user info
        Console.WriteLine("Please enter your name")
        name = Console.ReadLine()

        Console.WriteLine("")

        'sets destination to "airport" variable
        Console.WriteLine($"Good day {name}, please enter your destination" & vbNewLine)
        Call destinationList()
        destination = Console.ReadLine()

        Select Case destination.ToUpper
            Case "CEB"
                airport = "Mactan - Cebu"
            Case "KLO"
                airport = "Kalibo"
            Case "WNP"
                airport = "Naga"
            Case "PPS"
                airport = "Puerto Princesa"
            Case Else
                airport = "Error. Please repeat process."
        End Select
        Console.WriteLine("")

        'sets airline or carrier
        Console.WriteLine("Please enter your preferred airline" & vbNewLine)
        Call airlineList()
        airline = Console.ReadLine()

        Select Case airline.ToUpper
            Case "CBP"
                carrier = "Cebu Pacific Airlines"
            Case "PAL"
                carrier = "Philippine Airlines"
            Case Else
                carrier = "Error. Please repeat process."
        End Select

        Console.WriteLine("")

        'sets the date of the flight
        Console.Write("Enter the desired month (1-12): ")
        Select Case Console.ReadLine()
            Case 1
                month = "January"
            Case 2
                month = "February"
            Case 3
                month = "March"
            Case 4
                month = "April"
            Case 5
                month = "May"
            Case 6
                month = "June"
            Case 7
                month = "July"
            Case 8
                month = "August"
            Case 9
                month = "September"
            Case 10
                month = "October"
            Case 11
                month = "November"
            Case 12
                month = "December"

        End Select
        Console.Write("Enter the desired day: ")
        day = Console.ReadLine()

        Console.WriteLine("")

        'randomizes flight number
        fNumber = flightNumber.Next(1, 4000)

        'adds title
        Console.ForegroundColor = ConsoleColor.Magenta
        While i < 20
            Console.Write("-")
            i += 1
        End While
        Console.Write("R E C E I P T")
        i = 0
        While i < 20
            Console.Write("-")
            i += 1
        End While
        Console.WriteLine("")

        'prints the receipt
        Console.WriteLine("Flight Details: " & vbNewLine)

        receipt = $"Name: {name}" & vbCrLf &
            $"From: Ninoy Aquino International Airport" & vbCrLf &
            $"To: {airport} International Airport" & vbCrLf &
            $"Carrier: {carrier}" & vbCrLf &
            $"Date: {month} {day}" & vbCrLf &
            $"Flight Number: F-{fNumber}" & vbCrLf

        Console.WriteLine(receipt)
        Console.ResetColor()

        Console.WriteLine("Press enter to exit...")

        Console.ReadLine()
    End Sub
    Public Sub destinationList()
        Dim list As String
        list = "Here's the list of destinations" & vbCrLf &
            "CEB | Mactan - Cebu Airport" & vbCrLf &
            "KLO | Kalibo Airport" & vbCrLf &
            "WNP | Naga Airport" & vbCrLf &
            "PPS | Puerto Princesa Airport"

        Console.WriteLine(list)
    End Sub
    Public Sub airlineList()
        Dim list As String
        list = "These are the available airlines" & vbCrLf &
            "PAL | Philippines Airlines" & vbCrLf &
            "CBP | Cebu Pacific Airlines"

        Console.WriteLine(list)
    End Sub
End Module
