Module Module1

    Public Sub Main()
        Dim name, destination, carrier, airport As String
        Dim flightNumber As Integer
        Dim month, day As Integer

        'Greetings
        Console.WriteLine("Welcome to Sahjeed's Online Airport Portal")
        Console.WriteLine("Est. Sep 11, 2001" & vbNewLine)

        'ask for user info
        Console.WriteLine("Please enter your surname")
        name = Console.ReadLine()

        Console.WriteLine($"Good day {name}, please enter your destination" & vbNewLine)
        Call destinationList()
        destination = Console.ReadLine()

        'sets destination to "airport" variable
        Select Case destination.ToUpper
            Case "CEB"
                airport = "Cebu"
            Case "KLO"
                airport = "Kalibo"
            Case "WNP"
                airport = "Naga"
            Case "PPS"
                airport = "Puerto Princesa"
        End Select




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
End Module
