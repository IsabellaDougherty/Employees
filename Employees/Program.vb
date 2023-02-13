Imports System

Module EmployeeDirectory
    Sub Main()
        Dim billy As New Employee("Billy", "Joel")
        Console.WriteLine(billy.firstName + " " + billy.lastName)
    End Sub
End Module