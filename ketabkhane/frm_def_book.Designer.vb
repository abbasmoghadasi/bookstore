<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_def_book
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_def_book))
        Dim grd_grayesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btn_cancel = New Janus.Windows.EditControls.UIButton
        Me.btn_sabt = New Janus.Windows.EditControls.UIButton
        Me.txt_des = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_nasher = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_molaef = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_subject = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_code = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grd_grayesh = New Janus.Windows.GridEX.GridEX
        Me.GroupPanel1.SuspendLayout()
        CType(Me.grd_grayesh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btn_cancel)
        Me.GroupPanel1.Controls.Add(Me.btn_sabt)
        Me.GroupPanel1.Controls.Add(Me.txt_des)
        Me.GroupPanel1.Controls.Add(Me.txt_nasher)
        Me.GroupPanel1.Controls.Add(Me.txt_molaef)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.txt_subject)
        Me.GroupPanel1.Controls.Add(Me.txt_code)
        Me.GroupPanel1.Controls.Add(Me.txt_name)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupPanel1.Size = New System.Drawing.Size(400, 215)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "ورود اطلاعات کتاب"
        '
        'btn_cancel
        '
        Me.btn_cancel.Icon = CType(resources.GetObject("btn_cancel.Icon"), System.Drawing.Icon)
        Me.btn_cancel.Location = New System.Drawing.Point(18, 120)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(118, 30)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "انصراف"
        Me.btn_cancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_sabt
        '
        Me.btn_sabt.Icon = CType(resources.GetObject("btn_sabt.Icon"), System.Drawing.Icon)
        Me.btn_sabt.Location = New System.Drawing.Point(18, 84)
        Me.btn_sabt.Name = "btn_sabt"
        Me.btn_sabt.Size = New System.Drawing.Size(118, 30)
        Me.btn_sabt.TabIndex = 6
        Me.btn_sabt.Text = "ثبت اطلاعات"
        Me.btn_sabt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txt_des
        '
        '
        '
        '
        Me.txt_des.Border.Class = "TextBoxBorder"
        Me.txt_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_des.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_des.FocusHighlightEnabled = True
        Me.txt_des.Location = New System.Drawing.Point(18, 156)
        Me.txt_des.Multiline = True
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(315, 34)
        Me.txt_des.TabIndex = 5
        '
        'txt_nasher
        '
        '
        '
        '
        Me.txt_nasher.Border.Class = "TextBoxBorder"
        Me.txt_nasher.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nasher.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_nasher.FocusHighlightEnabled = True
        Me.txt_nasher.Location = New System.Drawing.Point(157, 129)
        Me.txt_nasher.Name = "txt_nasher"
        Me.txt_nasher.Size = New System.Drawing.Size(176, 21)
        Me.txt_nasher.TabIndex = 4
        '
        'txt_molaef
        '
        '
        '
        '
        Me.txt_molaef.Border.Class = "TextBoxBorder"
        Me.txt_molaef.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_molaef.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_molaef.FocusHighlightEnabled = True
        Me.txt_molaef.Location = New System.Drawing.Point(157, 98)
        Me.txt_molaef.Name = "txt_molaef"
        Me.txt_molaef.Size = New System.Drawing.Size(176, 21)
        Me.txt_molaef.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(341, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "توضیح:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(339, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ناشر:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(339, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "مولف:"
        '
        'txt_subject
        '
        '
        '
        '
        Me.txt_subject.Border.Class = "TextBoxBorder"
        Me.txt_subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_subject.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_subject.FocusHighlightEnabled = True
        Me.txt_subject.Location = New System.Drawing.Point(157, 67)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(176, 21)
        Me.txt_subject.TabIndex = 2
        '
        'txt_code
        '
        '
        '
        '
        Me.txt_code.Border.Class = "TextBoxBorder"
        Me.txt_code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_code.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_code.FocusHighlightEnabled = True
        Me.txt_code.Location = New System.Drawing.Point(157, 36)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(176, 21)
        Me.txt_code.TabIndex = 1
        '
        'txt_name
        '
        '
        '
        '
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name.FocusHighlightColor = System.Drawing.Color.MistyRose
        Me.txt_name.FocusHighlightEnabled = True
        Me.txt_name.Location = New System.Drawing.Point(157, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(176, 21)
        Me.txt_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(339, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "موضوع:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(339, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "کد کتاب:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(339, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "نام کتاب:"
        '
        'grd_grayesh
        '
        Me.grd_grayesh.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grd_grayesh.AlternatingColors = True
        Me.grd_grayesh.BuiltInTextsData = resources.GetString("grd_grayesh.BuiltInTextsData")
        Me.grd_grayesh.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        grd_grayesh_DesignTimeLayout.LayoutString = resources.GetString("grd_grayesh_DesignTimeLayout.LayoutString")
        Me.grd_grayesh.DesignTimeLayout = grd_grayesh_DesignTimeLayout
        Me.grd_grayesh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_grayesh.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd_grayesh.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grd_grayesh.FilterRowFormatStyle.BackColor = System.Drawing.Color.Linen
        Me.grd_grayesh.FilterRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd_grayesh.FilterRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical
        Me.grd_grayesh.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grd_grayesh.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grd_grayesh.GroupByBoxVisible = False
        Me.grd_grayesh.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grd_grayesh.Location = New System.Drawing.Point(0, 215)
        Me.grd_grayesh.Name = "grd_grayesh"
        Me.grd_grayesh.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_grayesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_grayesh.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_grayesh.Size = New System.Drawing.Size(400, 309)
        Me.grd_grayesh.TabIndex = 0
        Me.grd_grayesh.TabStop = False
        Me.grd_grayesh.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_grayesh.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_grayesh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_grayesh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'frm_def_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 524)
        Me.Controls.Add(Me.grd_grayesh)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frm_def_book"
        Me.Text = "ورود اطلاعات کتاب"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.grd_grayesh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_sabt As Janus.Windows.EditControls.UIButton
    Friend WithEvents txt_des As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_nasher As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_molaef As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_subject As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grd_grayesh As Janus.Windows.GridEX.GridEX
End Class
