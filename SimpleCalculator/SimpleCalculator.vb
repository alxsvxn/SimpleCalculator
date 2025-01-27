'Alexis Villagran 
'Spring 2025
'RCET 2265
'SimpleCalculator
'https://github.com/alxsvxn/SimpleCalculator.git

Module SimpleCalculator

    Sub Main()

        Dim input1 As String
        Dim userInput As String
        Dim input2 As String

        Console.WriteLine("Hello! Welcome to the BRAND NEW super-quantum-computing-super-computer Version 2.0")
        Console.WriteLine()
        Console.WriteLine("To start, we are going to need some numbers:")

        input1 = Console.ReadLine() 'This declares 'input1' as something that the user inputs
        Dim num1 As Integer = CInt(input1) 'This assigns num1 as an integer and takes the users input and converts it from a string to an integer

        Console.WriteLine("Great, now for our second number!")

        input2 = Console.ReadLine()
        Dim num2 As Integer = CInt(input2) 'This is doing the same thing as line 17 as we still need to convert the string number to an integer

        Console.WriteLine("Would you like to: " & vbNewLine _ 'Making code more neat as to not exceed about 80Ch per line
                          & "1. Add" & vbNewLine _
                          & "2. Subtract" & vbNewLine _
                          & "3. Multiply" & vbNewLine
                          )
        userInput = Console.ReadLine

        Console.WriteLine($"You chose {userInput}.")

        If userInput = "1" Then 'This is an if statement, allows for choice of multiple options
            Console.WriteLine("You chose to Add.")
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}")
        ElseIf userInput = "2" Then
            Console.WriteLine("You chose to Subtract.")
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}")
        ElseIf userInput = "3" Then
            Console.WriteLine("You chose to Multiply.")
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}")
        Else
            Console.WriteLine("no.")
        End If

    End Sub

End Module
