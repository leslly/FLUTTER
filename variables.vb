Module Module1

    Sub Main()
        Dim a As Short
        Dim b As Integer
        Dim c As Double

        a = 10
        b = 20
        c = a + b

        Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c)
    'The output of this would be a = 10, b = 20, c = 30
    ' In a previous code i ask a question about the digits in curly brackets.
    ' The answer is the arrangment does matter .
    ' If a = {2}, b = {1}, c = {0}, the out put will be 30, 20, 10 respectively.
        Console.ReadLine()
       
    End Sub

End Module
