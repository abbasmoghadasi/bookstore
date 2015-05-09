<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_amant
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
        Dim DividerStyle1 As PureComponents.EntrySet.Controls.DividerStyle = New PureComponents.EntrySet.Controls.DividerStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_amant))
        Dim DividerStyle2 As PureComponents.EntrySet.Controls.DividerStyle = New PureComponents.EntrySet.Controls.DividerStyle
        Dim grd_grayesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Divider1 = New PureComponents.EntrySet.Controls.Divider
        Me.btn_sabt = New Janus.Windows.EditControls.UIButton
        Me.btn_cancel = New Janus.Windows.EditControls.UIButton
        Me.Divider12 = New PureComponents.EntrySet.Controls.Divider
        Me.btn_mem = New DevComponents.DotNetBar.ButtonX
        Me.txt_code_mem = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name_mem = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_ta = New FarsiLibrary.Win.Controls.FADatePicker
        Me.txt_az = New FarsiLibrary.Win.Controls.FADatePicker
        Me.btn_book = New DevComponents.DotNetBar.ButtonX
        Me.txt_des = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_code_book = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name_book = New DevComponents.DotNetBar.Controls.TextBoxX
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
        Me.GroupPanel1.Controls.Add(Me.Divider1)
        Me.GroupPanel1.Controls.Add(Me.btn_sabt)
        Me.GroupPanel1.Controls.Add(Me.btn_cancel)
        Me.GroupPanel1.Controls.Add(Me.Divider12)
        Me.GroupPanel1.Controls.Add(Me.btn_mem)
        Me.GroupPanel1.Controls.Add(Me.txt_code_mem)
        Me.GroupPanel1.Controls.Add(Me.txt_name_mem)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.txt_ta)
        Me.GroupPanel1.Controls.Add(Me.txt_az)
        Me.GroupPanel1.Controls.Add(Me.btn_book)
        Me.GroupPanel1.Controls.Add(Me.txt_des)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.txt_code_book)
        Me.GroupPanel1.Controls.Add(Me.txt_name_book)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupPanel1.Size = New System.Drawing.Size(517, 270)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "امانت کتاب"
        '
        'Divider1
        '
        Me.Divider1.Location = New System.Drawing.Point(43, 153)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(387, 10)
        DividerStyle1.Fading = PureComponents.EntrySet.Controls.DividerFading.None
        Me.Divider1.Style = DividerStyle1
        Me.Divider1.TabIndex = 947
        Me.Divider1.TabStop = False
        '
        'btn_sabt
        '
        Me.btn_sabt.Icon = CType(resources.GetObject("btn_sabt.Icon"), System.Drawing.Icon)
        Me.btn_sabt.Location = New System.Drawing.Point(107, 215)
        Me.btn_sabt.Name = "btn_sabt"
        Me.btn_sabt.Size = New System.Drawing.Size(118, 30)
        Me.btn_sabt.TabIndex = 6
        Me.btn_sabt.Text = "ثبت اطلاعات"
        Me.btn_sabt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_cancel
        '
        Me.btn_cancel.Icon = CType(resources.GetObject("btn_cancel.Icon"), System.Drawing.Icon)
        Me.btn_cancel.Location = New System.Drawing.Point(236, 215)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(118, 30)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "انصراف"
        Me.btn_cancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Divider12
        '
        Me.Divider12.Location = New System.Drawing.Point(45, 111)
        Me.Divider12.Name = "Divider12"
        Me.Divider12.Size = New System.Drawing.Size(387, 10)
        DividerStyle2.Fading = PureComponents.EntrySet.Controls.DividerFading.None
        Me.Divider12.Style = DividerStyle2
        Me.Divider12.TabIndex = 947
        Me.Divider12.TabStop = False
        '
        'btn_mem
        '
        Me.btn_mem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_mem.BackColor = System.Drawing.Color.Transparent
        Me.btn_mem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_mem.Location = New System.Drawing.Point(87, 78)
        Me.btn_mem.Name = "btn_mem"
        Me.btn_mem.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(6)
        Me.btn_mem.Size = New System.Drawing.Size(42, 20)
        Me.btn_mem.TabIndex = 920
        Me.btn_mem.Text = ". . ."
        '
        'txt_code_mem
        '
        Me.txt_code_mem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txt_code_mem.Border.Class = "TextBoxBorder"
        Me.txt_code_mem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_code_mem.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_code_mem.FocusHighlightEnabled = True
        Me.txt_code_mem.Location = New System.Drawing.Point(137, 77)
        Me.txt_code_mem.Name = "txt_code_mem"
        Me.txt_code_mem.ReadOnly = True
        Me.txt_code_mem.Size = New System.Drawing.Size(73, 21)
        Me.txt_code_mem.TabIndex = 919
        '
        'txt_name_mem
        '
        '
        '
        '
        Me.txt_name_mem.Border.Class = "TextBoxBorder"
        Me.txt_name_mem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name_mem.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_name_mem.Location = New System.Drawing.Point(216, 77)
        Me.txt_name_mem.Name = "txt_name_mem"
        Me.txt_name_mem.ReadOnly = True
        Me.txt_name_mem.Size = New System.Drawing.Size(176, 21)
        Me.txt_name_mem.TabIndex = 918
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(157, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 917
        Me.Label7.Text = "کد عضویت"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(282, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 916
        Me.Label5.Text = "نام عضو"
        '
        'txt_ta
        '
        Me.txt_ta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ta.Location = New System.Drawing.Point(87, 127)
        Me.txt_ta.Name = "txt_ta"
        Me.txt_ta.Size = New System.Drawing.Size(138, 20)
        Me.txt_ta.TabIndex = 915
        Me.txt_ta.TabStop = False
        '
        'txt_az
        '
        Me.txt_az.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_az.Location = New System.Drawing.Point(260, 130)
        Me.txt_az.Name = "txt_az"
        Me.txt_az.Size = New System.Drawing.Size(138, 20)
        Me.txt_az.TabIndex = 914
        Me.txt_az.TabStop = False
        '
        'btn_book
        '
        Me.btn_book.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_book.BackColor = System.Drawing.Color.Transparent
        Me.btn_book.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_book.Location = New System.Drawing.Point(87, 24)
        Me.btn_book.Name = "btn_book"
        Me.btn_book.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(6)
        Me.btn_book.Size = New System.Drawing.Size(42, 20)
        Me.btn_book.TabIndex = 913
        Me.btn_book.Text = ". . ."
        '
        'txt_des
        '
        '
        '
        '
        Me.txt_des.Border.Class = "TextBoxBorder"
        Me.txt_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_des.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_des.FocusHighlightEnabled = True
        Me.txt_des.Location = New System.Drawing.Point(58, 169)
        Me.txt_des.Multiline = True
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(315, 34)
        Me.txt_des.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(236, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "تا:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(404, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "از:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(379, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "توضیح:"
        '
        'txt_code_book
        '
        Me.txt_code_book.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txt_code_book.Border.Class = "TextBoxBorder"
        Me.txt_code_book.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_code_book.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_code_book.FocusHighlightEnabled = True
        Me.txt_code_book.Location = New System.Drawing.Point(137, 23)
        Me.txt_code_book.Name = "txt_code_book"
        Me.txt_code_book.ReadOnly = True
        Me.txt_code_book.Size = New System.Drawing.Size(73, 21)
        Me.txt_code_book.TabIndex = 1
        '
        'txt_name_book
        '
        '
        '
        '
        Me.txt_name_book.Border.Class = "TextBoxBorder"
        Me.txt_name_book.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name_book.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_name_book.Location = New System.Drawing.Point(216, 23)
        Me.txt_name_book.Name = "txt_name_book"
        Me.txt_name_book.ReadOnly = True
        Me.txt_name_book.Size = New System.Drawing.Size(176, 21)
        Me.txt_name_book.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(158, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "کد کتاب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(282, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "نام کتاب"
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
        Me.grd_grayesh.Location = New System.Drawing.Point(0, 270)
        Me.grd_grayesh.Name = "grd_grayesh"
        Me.grd_grayesh.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_grayesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_grayesh.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_grayesh.Size = New System.Drawing.Size(517, 306)
        Me.grd_grayesh.TabIndex = 4
        Me.grd_grayesh.TabStop = False
        Me.grd_grayesh.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_grayesh.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_grayesh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_grayesh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'frm_amant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 576)
        Me.Controls.Add(Me.grd_grayesh)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frm_amant"
        Me.Text = "امانت کتاب"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.grd_grayesh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btn_cancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_sabt As Janus.Windows.EditControls.UIButton
    Friend WithEvents txt_des As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_code_book As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_name_book As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ta As FarsiLibrary.Win.Controls.FADatePicker
    Friend WithEvents txt_az As FarsiLibrary.Win.Controls.FADatePicker
    Friend WithEvents btn_book As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_mem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_code_mem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_name_mem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Divider1 As PureComponents.EntrySet.Controls.Divider
    Friend WithEvents Divider12 As PureComponents.EntrySet.Controls.Divider
    Friend WithEvents grd_grayesh As Janus.Windows.GridEX.GridEX
End Class
