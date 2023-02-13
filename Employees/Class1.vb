Public Class Employee
    Public Shared firstName As String
    Private newPropertyValue As String

    Public Property NewProperty() As String
        Get
            Return firstName
        End Get
        Set(ByVal value As String)
            firstName = value
        End Set
    End Property

    Public Shared lastName As String
    Public Shared email As String
    Public Shared employeeNumber As String

    Private _salary As String

    'Public Property _salary() As String


    Sub New(first$, last$)
        Me.firstName = first
        Me.lastName = last
        Me.employeeNumber = "000000000"
        Me.email = $"{Me.firstName}{Me.lastName}@acmeco.com"
    End Sub

End Class
