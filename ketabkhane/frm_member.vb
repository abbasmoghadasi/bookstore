Public Class frm_member
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub btn_sabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sabt.Click
        Try
            If txt_name.Text = Nothing Then
                MessageBox.Show("نام عضو را وارد کنید")
                txt_name.Select()
                Exit Sub
            End If
            My.Forms.Form1.new_r("t_member")
            up()
            ds.Tables("t_member").Clear()
            My.Forms.Form1.fill_t_member()
            rc(Me)
            'cmb_sex.SelectedIndex = 0

            txt_name.Select()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_parvandeh_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_parvandeh.Leave
        Try

            Dim i, t As Integer
            For i = 0 To crow_t_member - 1

                t = ds.Tables("t_member").Rows(i)("code_m")

                If Val(txt_parvandeh.Text) = t Then
                    Me.Panel3.Show()
                    dgp()
                    Me.dg.Rows(i).Cells(0).Selected = True

                    Me.dg.Rows(i).Cells(0).Style.SelectionBackColor = Color.LightPink

                    MessageBox.Show("شماره پرونده نباید تکراری باشد")
                    txt_parvandeh.Text = "00"
                    Me.btn_sabt.Enabled = False
                    txt_parvandeh.Select()

                    Exit Sub
                Else
                    Me.Panel3.Hide()
                    btn_sabt.Enabled = True

                End If

            Next i
        Catch ex As Exception

        End Try
  
    End Sub
    Sub dgp()
        Dim i As Integer
        With dg
            .DataSource = ds.Tables("t_member")
            .Columns(0).HeaderText = "کد"
            .Columns(0).Width = 30
            .Columns(3).HeaderText = "نام دانشجو"
            .Columns(3).Width = 150
            .Columns(1).Visible = False
            For i = 4 To crow_t_member - 1
                .Columns(i).Visible = False
            Next
        End With
    End Sub
    Sub up()

        With ds.Tables("t_member")
            .Rows(crow_t_member)("code_m") = txt_parvandeh.Text
            .Rows(crow_t_member)("name_") = txt_name.Text
            .Rows(crow_t_member)("fname_") = txt_fname.Text
            .Rows(crow_t_member)("name_m") = txt_name.Text + " " + txt_fname.Text
            .Rows(crow_t_member)("shsh") = txt_shsh.Text
            .Rows(crow_t_member)("meli_") = txt_meli.Text
            .Rows(crow_t_member)("tel") = txt_tel.Text

        End With
        My.Forms.Form1.up("Select*From  t_member", "t_member")

    End Sub

    Private Sub frm_member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.t_member' table. You can move, or remove it, as needed.
        grd_grayesh.DataSource = ds.Tables("t_member")

    End Sub

    Private Sub txt_parvandeh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_tel.KeyDown, txt_shsh.KeyDown, txt_pedar.KeyDown, txt_parvandeh.KeyDown, txt_name.KeyDown, txt_meli.KeyDown, txt_fname.KeyDown, txt_des.KeyDown, btn_sabt.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
        If sender.text = "" And e.KeyData = Keys.Space Then

            SendKeys.Send("{BS}")
        End If
    End Sub
End Class