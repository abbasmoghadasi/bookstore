Imports System.Data.OleDb
Imports FarsiLibrary.Utils
Imports System.IO

Public Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'BankDataSet.t_set' table. You can move, or remove it, as needed.
        Me.T_setTableAdapter.Fill(Me.BankDataSet.t_set)
        Dim pfile As String
        roz = PersianDate.Now.ToString("d")
        FaMonthView1.SelectedDateTime = Today
        y = PersianDate.Now.Year - 1300
        lbl_persiandate.Text = PersianDate.Now.ToString("D")
        changelanguge("fa")
        pfile = Directory.GetCurrentDirectory()
        'strCon = "Provider = Microsoft.jet.OLEDB.4.0;Data Source =" + pfile + "\bank.mdb;Jet OLEDB:Database Password=!@#$%^"
        'strCon = "Provider = Microsoft.jet.OLEDB.4.0;Data Source =bank.mdb;Jet OLEDB:Database Password=!@#$%^"
        strCon = "Provider = Microsoft.jet.OLEDB.4.0;Data Source =bank.mdb"
        con = New OleDbConnection(strCon)
        fill_t_book()
        fill_t_member()
        fill_t_amanat()
        fill_t_set()
        ReflectionLabel2.Text = TextBox1.Text
        ReflectionLabel1.Text = TextBox1.Text
        GroupPanel1.Text = TextBox1.Text
    End Sub
    Sub fill_t_book()
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("ارتباط با بانك اطلاعات برقرار نشد!")
            End

        End Try
        strSql = "Select*From t_book"
        Dim da As New OleDbDataAdapter(strSql, con)
        ' ds.Clear()
        da.Fill(ds, "t_book")
        con.Close()
        crow_t_book = Me.BindingContext(ds, "t_book").Count
        grd_book.DataSource = ds.Tables("t_book")
    End Sub
    Sub fill_t_member()
        crow_t_member = crow("Select*From t_member", "t_member")
        grd_aza.DataSource = ds.Tables("t_member")
    End Sub
    Sub fill_t_amanat()
        crow_t_amanat = crow("Select*From t_amanat", "t_amanat")
    End Sub
    Sub fill_t_set()
        crow_t_set = crow("Select*From t_set", "t_set")
    End Sub
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        frm_def_book.ShowDialog()
    End Sub

    Public Function crow(ByVal str As String, ByVal str2 As String) As Integer
        'con.Open()t_dars_daneshjoo
        Dim da As New OleDbDataAdapter(str, con)
        da.Fill(ds, str2)
        con.Close()
        'Me.grd.DataSource = ds.Tables(str2)pardakht_shakhs_t
        crow = Me.BindingContext(ds, str2).Count
    End Function
    Public Sub new_r(ByVal str_t As String)
        ds.Tables(str_t).Rows.Add(ds.Tables(str_t).NewRow)
    End Sub
    Public Sub up(ByVal strsql As String, ByVal str_t As String)
        Dim da As New OleDbDataAdapter(strsql, con)
        con.Open()
        cb = New OleDbCommandBuilder(da)
        da = cb.DataAdapter
        da.Update(ds, str_t)
        con.Close()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        frm_member.ShowDialog()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_amanet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_amanet.Click
        frm_amant.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        'T_setBindingSource.AddNew()
        Dim od As New OpenFileDialog
        od.Filter = "Image|*.gif;*.tif;*.jpg;*.bmp"
        od.ShowDialog()
        If od.FileName <> "" Then
            Me.PictureBox1.Image = Image.FromFile(od.FileName)
        End If
        Me.Validate()
        Me.T_setBindingSource.EndEdit()
        Me.T_setTableAdapter.Update(Me.BankDataSet.t_set)

    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        TextBox1.Text = InputBox("متن مورد نظر را وارد کنید", "درج متن")
        Me.Validate()
        Me.T_setBindingSource.EndEdit()
        Me.T_setTableAdapter.Update(Me.BankDataSet.t_set)
        ReflectionLabel2.Text = TextBox1.Text
        ReflectionLabel1.Text = TextBox1.Text
        GroupPanel1.Text = TextBox1.Text
    End Sub
End Class
