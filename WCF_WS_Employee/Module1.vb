Imports System.Runtime.Serialization
Imports System.ServiceModel.Description
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract>
Public Interface IService

    <OperationContract()>
    <WebGet()>
    Function SeekEmployee() As List(Of Employee)
End Interface

Public Class Service
    Implements IService
    Public Function SeekEmployee() As List(Of Employee) Implements IService.SeekEmployee
        Dim EmployeeCollection As New List(Of Employee)()

        EmployeeCollection.Add(New Employee(1, "Matt", "Daimon"))
        EmployeeCollection.Add(New Employee(2, "Arnold", "Mendez"))
        EmployeeCollection.Add(New Employee(3, "Silvester", "Stallone"))
        EmployeeCollection.Add(New Employee(4, "Scarlet", "johanson"))
        EmployeeCollection.Add(New Employee(5, "Jean Claude", "VanDame"))
        EmployeeCollection.Add(New Employee(6, "Terminator", "Baby"))
        EmployeeCollection.Add(New Employee(7, "John", "HILL"))
        EmployeeCollection.Add(New Employee(8, "Steven", "Hall"))
        EmployeeCollection.Add(New Employee(9, "Renee", "Ruso"))
        Return EmployeeCollection
    End Function
End Class

Module Module1

    Sub Main()
        Dim SetupWCF As WebServiceHost = New WebServiceHost(GetType(Service), New Uri("http://localhost:8000/"))
        SetupWCF.Open()
        Console.WriteLine("Press <Enter> to stop the WCF Self-Hosted")
        Console.ReadLine()
    End Sub

End Module
