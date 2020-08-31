Partial Class dt_ser_enter
    Partial Class serjuryDataTable

        Private Sub serjuryDataTable_serjuryRowChanging(sender As Object, e As serjuryRowChangeEvent) Handles Me.serjuryRowChanging

        End Sub

        Private Sub serjuryDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ser_typeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
