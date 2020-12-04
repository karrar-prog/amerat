Imports DevExpress.XtraEditors

Partial Public Class fm_statistics

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub tileBar_SelectedItemChanged(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles tileBar.SelectedItemChanged
        navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item)
    End Sub

    Private Sub fm_statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
