Public Class frm_amant
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub btn_book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_book.Click
        frm_book_select.ShowDialog()
    End Sub

    Private Sub frm_amant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    
        grd_grayesh.DataSource = ds.Tables("t_amanat")
    End Sub

    Private Sub btn_mem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mem.Click
        frm_select_mem.ShowDialog()
    End Sub
    Sub up()

        With ds.Tables("t_amanat")
            .Rows(crow_t_amanat)("b_name") = txt_name_book.Text
            .Rows(crow_t_amanat)("b_cod") = txt_code_book.Text
            .Rows(crow_t_amanat)("az_") = txt_az.Text
            .Rows(crow_t_amanat)("ta_") = txt_ta.Text
            .Rows(crow_t_amanat)("des") = txt_des.Text
            .Rows(crow_t_amanat)("code_m") = txt_code_mem.Text
            .Rows(crow_t_amanat)("mem_name") = txt_name_mem.Text

        End With
        My.Forms.Form1.up("Select*From  t_amanat", "t_amanat")
        '
    End Sub
    Private Sub btn_sabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sabt.Click
        'Try
        If txt_name_book.Text = Nothing Then
            MessageBox.Show("نام کتاب را وارد کنید")
            btn_book.Select()
            Exit Sub
        End If
        If txt_name_mem.Text = Nothing Then
            MessageBox.Show("نام عضو را وارد کنید")
            btn_mem.Select()
            Exit Sub
        End If
        My.Forms.Form1.new_r("t_amanat")
        up()
        ds.Tables("t_amanat").Clear()
        My.Forms.Form1.fill_t_amanat()
        rc(Me)
        'cmb_sex.SelectedIndex = 0


        'Catch ex As Exception

        'End Try
    End Sub
End Class