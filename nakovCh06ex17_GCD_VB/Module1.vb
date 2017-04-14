Imports System

Namespace nakovCh06ex17_GCD

    Public Class EuclidAlgo

        Public Shared Sub Main(ByVal args As String())
            Console.WriteLine("Please enter 2 positive integers: ")
            Dim numA As String = Console.ReadLine()
            Dim numB As String = Console.ReadLine()
            Dim a As Integer = 0
            Dim b As Integer = 0
            Dim checkA As Boolean = Integer.TryParse(numA, a)
            Dim checkB As Boolean = Integer.TryParse(numB, b)
            If checkA <> True OrElse checkB <> True Then
                Console.WriteLine("Please enter a positive integer")
            End If

            Console.WriteLine("The greatest common divisor for {0} and {1} is:{2} ", a, b, GCD(a, b))
            Console.WriteLine("The least common multiple   for {0} and {1} is:{2} ", a, b, LCM(a, b))
        End Sub

        Public Shared Function GCD(ByVal a As Integer, ByVal b As Integer) As Integer
            If a = 0 Then
                Return b
            End If

            While b <> 0
                If a > b Then a -= b Else b -= a
            End While

            Return a
        End Function

        Public Shared Function LCM(ByVal a As Integer, ByVal b As Integer) As Integer
            Dim result As Integer = (a * b) / GCD(a, b)
            Return result
        End Function
    End Class
End Namespace
