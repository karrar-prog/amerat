Module GlobalValue


    Public store_title As New List(Of String)
    Public type_title As New List(Of String)
    Public Function check_perission(user_permission As Integer) As Boolean
        If user.type = user_permission Then
            Return True
        Else
            Return False

        End If
    End Function
End Module
