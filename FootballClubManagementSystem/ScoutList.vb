Public Class ScoutList

    Public Property Players As SortedDictionary(Of Integer, ScoutedPlayer)

    Public Sub New()
        Players = New SortedDictionary(Of Integer, ScoutedPlayer)
    End Sub

    Public Sub New(dbScoutList As SortedDictionary(Of Integer, ScoutedPlayer))
        Players = dbScoutList
    End Sub

    Public Sub Add(player As ScoutedPlayer)
        Players.Add(player.PlayerID, player)
    End Sub

    Public Sub Remove(id As Integer)
        Players.Remove(id)
    End Sub

    Public Function GetPlayer(id As Integer) As ScoutedPlayer

        If (Players.ContainsKey(id)) Then
            Return Players(id)
        Else
            Return Nothing
        End If
    End Function

    Public Function GenerateID() As Integer
        Dim pID As Integer = 1
        If (Players.Count > 0) Then
            pID = Players.Keys.Last + 1
        End If
        Return pID
    End Function


End Class
