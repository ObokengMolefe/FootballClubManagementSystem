Public Class InjuryList

    Public Property InjuredPlayers As SortedDictionary(Of Integer, Injured)

    Public Sub New()
        InjuredPlayers = New SortedDictionary(Of Integer, Injured)
    End Sub

    Public Sub New(dbInjuredList As SortedDictionary(Of Integer, Injured))
        InjuredPlayers = dbInjuredList
    End Sub

    Public Sub Add(player As Injured)
        InjuredPlayers.Add(player.PlayerID, player)
    End Sub

    Public Sub Remove(id As Integer)
        InjuredPlayers.Remove(id)
    End Sub

    Public Sub Modify(player As Injured, newDiagnosis As String, newDate As Date)
        player.Diagnosis = newDiagnosis
        player.EndDate = newDate 
    End Sub

    Public Function GetPlayer(id As Integer) As Injured

        If (InjuredPlayers.ContainsKey(id)) Then
            Return InjuredPlayers(id)
        Else
            Return Nothing
        End If
    End Function
End Class
