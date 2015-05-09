Public Class frm_book_select

    Private Sub grd_grayesh_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_grayesh.DoubleClick
        frm_amant.txt_name_book.Text = grd_grayesh.CurrentRow.Cells("b_name").Value.ToString
        frm_amant.txt_code_book.Text = grd_grayesh.CurrentRow.Cells("b_code").Value.ToString
        Close()
    End Sub

    Private Sub frm_book_select_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grd_grayesh.DataSource = ds.Tables("t_book")
    End Sub
End Class