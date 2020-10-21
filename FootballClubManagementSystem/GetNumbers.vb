Public Class GetNumbers

#Region "Get Numbers from Fans"

    Public Shared Sub GetFanNumsGenderCat(ByRef male As Integer, ByRef female As Integer, ByRef gold As Integer, ByRef silver As Integer, ByRef bronze As Integer)
        For Each f As KeyValuePair(Of Integer, Fan) In frmFCMS.membership.Fans
            If (f.Value.Gender = "Male") Then
                male += 1
            Else
                female += 1
            End If

            If (f.Value.Category = "Gold") Then
                gold += 1
            ElseIf (f.Value.Category = "Silver") Then
                silver += 1
            Else
                bronze += 1
            End If
        Next
    End Sub
#End Region
End Class
