Public Class frm_def_book
    Inherits DevComponents.DotNetBar.Office2007Form

    Sub up()

        With ds.Tables("t_book")
            .Rows(crow_t_book)("b_name") = txt_name.Text
            .Rows(crow_t_book)("b_code") = txt_code.Text
            .Rows(crow_t_book)("b_subject") = txt_subject.Text
            .Rows(crow_t_book)("b_moalef") = txt_molaef.Text
            .Rows(crow_t_book)("b_nasher") = txt_nasher.Text
            .Rows(crow_t_book)("b_des") = txt_des.Text

        End With
        My.Forms.Form1.up("Select*From  t_book", "t_book")

    End Sub

    Private Sub btn_sabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sabt.Click
        Try
            If txt_name.Text = Nothing Then
                MessageBox.Show("نام کتاب را وارد کنید")
                txt_name.Select()
                Exit Sub
            End If
            My.Forms.Form1.new_r("t_book")
            up()
            ds.Tables("t_book").Clear()
            My.Forms.Form1.fill_t_book()
            rc(Me)
            'cmb_sex.SelectedIndex = 0
        
            txt_name.Select()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_def_book_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grd_grayesh.DataSource = ds.Tables("t_book")
    End Sub

    Private Sub txt_name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_subject.KeyDown, txt_nasher.KeyDown, txt_name.KeyDown, txt_molaef.KeyDown, txt_des.KeyDown, txt_code.KeyDown, btn_sabt.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
        If sender.text = "" And e.KeyData = Keys.Space Then

            SendKeys.Send("{BS}")
        End If
    End Sub
End Class