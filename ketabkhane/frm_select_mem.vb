Public Class frm_select_mem

    Private Sub frm_select_mem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grd_grayesh.DataSource = ds.Tables("t_member")
    End Sub

    Private Sub grd_grayesh_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_grayesh.DoubleClick
        frm_amant.txt_name_mem.Text = grd_grayesh.CurrentRow.Cells("name_m").Value.ToString
        frm_amant.txt_code_mem.Text = grd_grayesh.CurrentRow.Cells("code_m").Value.ToString
        Close()
    End Sub
End Class