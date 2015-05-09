Imports System.Data.OleDb
Module Module1
    Public ds As New DataSet()
    Public strSql, st2, strCon As String
    Public con As OleDbConnection
    Public cb As OleDbCommandBuilder
    Public da As OleDbDataAdapter
    Public y As Byte
    Public crow_t_book, crow_t_member, crow_t_amanat, crow_t_set As Int32
    Public pardakhti As Long

    Public roz As String


    Public Sub changelanguge(ByVal cl As String)
        Dim lang As System.Windows.Forms.InputLanguage
        For Each lang In System.Windows.Forms.InputLanguage.InstalledInputLanguages
            If (lang.Culture.TwoLetterISOLanguageName = cl) Then
                System.Windows.Forms.Application.CurrentCulture = lang.Culture
                System.Windows.Forms.Application.CurrentInputLanguage = lang
            End If
        Next
    End Sub
    Public Sub rc(ByVal ctr As Control)
        Dim intco As Integer
        cc(ctr)
        If ctr.Controls.Count > 0 Then
            For intco = 1 To ctr.Controls.Count
                rc(ctr.Controls(intco - 1))

            Next
        End If
    End Sub
    Sub cc(ByVal ctc As Control)
        If InStr(ctc.Tag, "skip", CompareMethod.Text) = 0 Then
            If TypeOf (ctc) Is System.Windows.Forms.TextBox Then
                ctc.Text = ""
            ElseIf TypeOf (ctc) Is System.Windows.Forms.RichTextBox Then

                ctc.Text = ""

            ElseIf TypeOf (ctc) Is System.Windows.Forms.ComboBox Then
                Dim objcom As System.Windows.Forms.ComboBox = ctc
                objcom.SelectedIndex = -1

            ElseIf TypeOf (ctc) Is System.Windows.Forms.CheckBox Then
                Dim objcom As System.Windows.Forms.CheckBox = ctc
                objcom.Checked = False


            ElseIf TypeOf (ctc) Is System.Windows.Forms.PictureBox Then
                Dim objcom As System.Windows.Forms.PictureBox = ctc
                objcom.Refresh()
            End If
        End If

    End Sub
End Module
