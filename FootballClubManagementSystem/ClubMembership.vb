Public Class ClubMembership

    Public Property Fans As SortedDictionary(Of Integer, Fan)

    Public Sub New()
        Fans = New SortedDictionary(Of Integer, Fan)
    End Sub

    Public Sub New(dbFans As SortedDictionary(Of Integer, Fan))
        Fans = dbFans
    End Sub

    Public Sub Add(fan As Fan)
        Fans.Add(fan.ID, Fan)
    End Sub

    Public Sub Remove(id As Integer)
        Fans.Remove(id)
    End Sub

    Public Function GetFan(id As Integer) As Fan

        If (Fans.ContainsKey(id)) Then
            Return Fans(id)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub ExpireMembership(clubFans As SortedDictionary(Of Integer, Fan))
        For Each fanMem As KeyValuePair(Of Integer, Fan) In clubFans
            If (Date.Today = fanMem.Value.EndDate) Then
                fanMem.Value.Expired = True
            End If
        Next
    End Sub

    Public Shared Function GenerateID(clubFans As SortedDictionary(Of Integer, Fan)) As Integer
        Dim newID As Integer
        If (clubFans.Count = 0) Then
            Return 1
        Else
            newID = clubFans.Keys.Last + 1
            Return newID
        End If
    End Function
End Class
