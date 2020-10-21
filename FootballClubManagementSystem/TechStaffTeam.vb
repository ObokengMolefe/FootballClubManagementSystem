Public Class TechStaffTeam

    Public Property Staff As SortedDictionary(Of Integer, TechnicalStaff)

    Public Sub New()
        Staff = New SortedDictionary(Of Integer, TechnicalStaff)
    End Sub

    Public Sub New(staffList As SortedDictionary(Of Integer, TechnicalStaff))
        Staff = staffList
    End Sub

    Public Sub Add(member As TechnicalStaff)
        Staff.Add(member.ID, member)
    End Sub

    Public Sub Remove(staffId As Integer)
        Staff.Remove(staffId)
    End Sub

    Public Function Contains(memId As Integer) As Boolean
        If (Staff.ContainsKey(memId)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetStaffMember(staffId As Integer) As TechnicalStaff
        If (Staff.ContainsKey(staffId)) Then
            Return Staff(staffId)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function GenerateID(role As String) As Integer
        Dim memID As Integer
        Select Case role
            Case "Coach"
                memID = 111
            Case "Doctor"
                memID = 222
            Case "Scout"
                memID = 333
            Case "PhysicalTrainer"
                memID = 444
            Case "AssistantCoach"
                memID = 555
        End Select
        Return memID
    End Function


End Class


