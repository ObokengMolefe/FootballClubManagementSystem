Imports System
Imports System.Text
Imports System.Collections

Public Class UserBook

    Private sysUsers As List(Of User)
    Public ReadOnly Property Users As List(Of User)
        Get
            Return sysUsers
        End Get
    End Property

    Default Public ReadOnly Property Item(usrname As String) As User
        Get
            For Each usr As User In sysUsers
                If usr.Username = usrname Then
                    Return usr
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public Sub New()
        sysUsers = New List(Of User)
    End Sub

    Public Sub New(users As List(Of User))
        sysUsers = users
    End Sub

    Public Sub AddUser(usr As User)
        sysUsers.Add(usr)
    End Sub

End Class
