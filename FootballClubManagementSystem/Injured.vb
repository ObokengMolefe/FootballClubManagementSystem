Public Class Injured

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property PlayerID As Integer
    Public Property Diagnosis As String
    Public Property EndDate As Date
    Public Property StartDate As Date
    Public ReadOnly Property Duration As Integer
        Get
            Return EndDate.Subtract(StartDate).Days
        End Get
    End Property

    Public Sub New(pId As Integer, diagno As String, endate As Date)
        PlayerID = pId
        Diagnosis = diagno
        EndDate = endate
        StartDate = Date.Today
    End Sub

    Public Overrides Function ToString() As String
        Return PlayerID & " " & Diagnosis
    End Function
End Class
