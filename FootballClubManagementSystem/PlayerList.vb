Imports System.Text
Imports System.Collections

Public Class PlayerList

    Public Property Players As SortedDictionary(Of Integer, Player)

    Public Sub New()
        Players = New SortedDictionary(Of Integer, Player)
    End Sub

    Public Sub New(dbPlayerList As SortedDictionary(Of Integer, Player))
        Players = dbPlayerList
    End Sub

    Public Sub Add(player As Player)
        Players.Add(player.ID, player)
    End Sub

    Public Sub Remove(id As Integer)
        Players.Remove(id)
    End Sub

    Public Function GetPlayer(id As Integer) As Player

        If (Players.ContainsKey(id)) Then
            Return Players(id)
        Else
            Return Nothing
        End If
    End Function

End Class
