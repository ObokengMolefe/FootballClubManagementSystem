Public Class SponsorList

    Public Property Sponsors As SortedDictionary(Of Integer, Sponsor)

    Public Sub New()
        Sponsors = New SortedDictionary(Of Integer, Sponsor)
    End Sub

    Public Sub New(dbSponsorList As SortedDictionary(Of Integer, Sponsor))
        Sponsors = dbSponsorList
    End Sub

    Public Sub Add(sponsor As Sponsor)
        Sponsors.Add(sponsor.SponsorID, sponsor)
    End Sub

    Public Sub Remove(id As Integer)
        Sponsors.Remove(id)
    End Sub

    Public Function GetSponsor(key As Integer) As Sponsor
        If (Sponsors.ContainsKey(key)) Then
            Return Sponsors(key)
        Else
            Return Nothing
        End If
    End Function

    Public Function GenerateID() As Integer
        Dim ID As Integer = 100
        If (Sponsors.Count > 0) Then
            ID = Sponsors.Keys.Last + 1
        End If
        Return ID
    End Function
End Class
