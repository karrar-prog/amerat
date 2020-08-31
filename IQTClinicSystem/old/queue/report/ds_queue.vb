Partial Class ds_queue
    Partial Class t_queueDataTable

        Private Sub t_queueDataTable_t_queueRowChanging(sender As Object, e As t_queueRowChangeEvent) Handles Me.t_queueRowChanging

        End Sub

        Private Sub t_queueDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.current_nameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
