Public Class TransferList
    Public Property PlayerTransferList As SortedDictionary(Of Integer, Player)

    Public Sub New()
        PlayerTransferList = New SortedDictionary(Of Integer, Player)
    End Sub

    Public Sub New(dbList As SortedDictionary(Of Integer, Player))
        PlayerTransferList = dbList
    End Sub

    Public Sub Add(tranfer As Player)
        PlayerTransferList.Add(tranfer.ID, tranfer)
    End Sub

    Public Sub Remove(pID As Integer)
        PlayerTransferList.Remove(pID)
    End Sub

End Class
