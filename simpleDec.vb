Module Module1
  'Use import System .console ,and we do not need to put "Console. " for the out put of a sentence.
    Sub Main()
    'Dim is a declearation statement and storage allocation statement.
        Dim dblsalesAmt As Double = 10.0
        Dim dblbonusPay As Double
        Dim totalPay As Integer
        Dim SALE_QUOTA As Integer = 5
        Dim Bonus_PERCENT As Integer = 6

        If (dblsalesAmt > SALE_QUOTA) Then
            dblbonusPay = dblsalesAmt * BONUS_PERCENT
            totalPay = dblsalesAmt + dblbonusPay
        End If

        Console.WriteLine(" The total is:" & totalPay)
    'line 16 could also be written as WriteLine(" The total is : {0} ", taxPay )
    'Does this follow an array POV ?
    'Since totalPay is third in line to be decleared, is it {2} ?
    End Sub
  
End Module
