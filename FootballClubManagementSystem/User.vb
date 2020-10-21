Public Class User

    Public Property Username As String
    Public Property Password As String
    Public Property Department As Department
    Public Property Name As String
    Public Property Surname As String

    Public Sub New()

    End Sub

    Public Sub New(usrname As String, pwd As String, dep As Department, fname As String, lname As String)
        Username = usrname
        Password = pwd
        Department = dep
        Name = fname
        Surname = lname
    End Sub

    Public Overrides Function ToString() As String
        Return Name & " " & Surname
    End Function

    Public Sub Login()
        frmFCMS.show()
    End Sub

    Public Function GetDepartment() As Department
        Return Me.Department
    End Function

    Public Function CredentialsMatch(pswd As String, usrname As String) As Boolean
        If Me.Password = pswd And Me.Username = usrname Then
            Return True
        Else
            Return True
        End If
    End Function

    Public Function GetDepEnumIdex(department As String) As Integer
        Dim index As Integer
        Select Case department
            Case "HumanResources"
                index = 0
            Case "Finance"
                index = 1
            Case "Management"
                index = 2
        End Select
        Return index
    End Function
End Class

Public Enum Department
    HumanResources
    Finance
    Management
End Enum

