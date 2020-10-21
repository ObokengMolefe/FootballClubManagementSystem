Public Class TechnicalStaff
    Inherits Employee

    Public Property Role As Role

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, name As String, surname As String, phone As Integer, address As String, endDate As Date, mail As String, sal As Decimal, rol As Role)
        MyBase.New(id, name, surname, phone, address, endDate, mail, sal)
        Role = rol
    End Sub

    Public Overrides Function ToString() As String
        Return Name & " " & Surname & " the " & Role.ToString

    End Function

    Public Function GetRoleEnumIndex(roleString As String) As Integer
        Dim role As Integer
        Select Case roleString
            Case "Coach"
                role = 0
            Case "AssistantCoach"
                role = 1
            Case "PhysicalTrainer"
                role = 2
            Case "Scout"
                role = 3
            Case "Docto"
                role = 4
        End Select
        Return role
    End Function
End Class

Public Enum Role
    Coach
    AssistantCoach
    PhysicalTrainer
    Scout
    Doctor
End Enum
