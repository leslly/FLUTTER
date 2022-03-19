Module Module1
  Sub Main()
    
     Const PI = 3.14149
     Dim radius, area As Single
    
     radius = 7
     area = PI * radius * radius
    
      Console.WriteLine("Area = " & Str(area))
      Console.ReadKey()
    'What's the difference between RradKey and ReadLine ?
    'What's the difference between public and private constant ?
    'Output: Area = 135.933
    
  End Sub
End Module
