'Alexis Villagran 
'Spring 2025
'RCET 2265
'SimpleCalculator
'https://github.com/alxsvxn/SimpleCalculator.git

Module SimpleCalculator

    Sub Main()

        Console.WriteLine("Hello! Welcome to the BRAND NEW super-quantum-computing-super-computer Version 2.0")
        Console.WriteLine()
        Console.WriteLine("To start, we are going to need some numbers:")

        Dim input1 As String 'This line assigns 'input1' as a string
        input1 = Console.ReadLine() 'This declares 'input1' as something that the user inputs
        Dim num1 As Integer = CInt(input1) 'This assigns num1 as an integer and takes the users input and converts it from a string to an integer

        Console.WriteLine("Great, now for our second number!")

        Dim input2 As String = Console.ReadLine() 'This is a slightly simpler for of the code in line 15, but instead asks for an input and stores it in the same line
        Dim num2 As Integer = CInt(input2) 'This is doing the same thing as line 17 as we still need to conver the string number to an integer

        Console.WriteLine("Awesome, now would you like to Add or Mulitply them?")

    End Sub

End Module
