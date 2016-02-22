Module module1
    Sub Main()

        For i = 4 To 0 Step -1

            Console.Write("Username: ")
            Dim userName As String = Console.ReadLine()
            userName.ToLower()
            Console.Write("Password: ")
            Dim userPass As String = Console.ReadLine()
            userPass.ToLower()

            If userName = "youssef" And userPass = "eliane2011" Then
                Console.WriteLine("Welcome sir Youssef :D")
                Exit For
            End If

            Console.WriteLine()
            Console.WriteLine("WRONG USERNAME OR PASSWORD!!!")
            Console.WriteLine(i & " Attempts left")

        Next

        Console.ReadLine()
    End Sub
End Module
