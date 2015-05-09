<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ClockStyle1 As PureComponents.ScheduleSet.Calendars.ClockStyle = New PureComponents.ScheduleSet.Calendars.ClockStyle
        Dim grd_book_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grd_aza_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grd_daneshjoo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_persiandate = New System.Windows.Forms.Label
        Me.Clock1 = New PureComponents.ScheduleSet.Calendars.Clock
        Me.FaMonthView1 = New FarsiLibrary.Win.Controls.FAMonthView
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.grd_book = New Janus.Windows.GridEX.GridEX
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.grd_aza = New Janus.Windows.GridEX.GridEX
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SideBar1 = New DevComponents.DotNetBar.SideBar
        Me.SideBarPanelItem2 = New DevComponents.DotNetBar.SideBarPanelItem
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.btn_amanet = New DevComponents.DotNetBar.ButtonItem
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.grd_daneshjoo = New Janus.Windows.GridEX.GridEX
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.T_setBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New ketabkhane_n.bankDataSet
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.T_setTableAdapter = New ketabkhane_n.bankDataSetTableAdapters.t_setTableAdapter
        Me.TableAdapterManager = New ketabkhane_n.bankDataSetTableAdapters.TableAdapterManager
        Me.Panel1.SuspendLayout()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.grd_book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.grd_aza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.grd_daneshjoo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_setBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RibbonClientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 73)
        Me.Panel1.TabIndex = 0
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.ReflectionImage1)
        Me.RibbonClientPanel1.Controls.Add(Me.ReflectionLabel1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(784, 73)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseDown.Class = ""
        Me.RibbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseOver.Class = ""
        Me.RibbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonClientPanel1.TabIndex = 1
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'ReflectionImage1
        '
        Me.ReflectionImage1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.BackgroundImage = CType(resources.GetObject("ReflectionImage1.BackgroundStyle.BackgroundImage"), System.Drawing.Image)
        Me.ReflectionImage1.BackgroundStyle.Class = ""
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.Location = New System.Drawing.Point(693, 9)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(79, 61)
        Me.ReflectionImage1.TabIndex = 2
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("B Traffic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(472, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(206, 70)
        Me.ReflectionLabel1.TabIndex = 1
        Me.ReflectionLabel1.Text = "کانون فرهنگی هنری شهید مهربان"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(584, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 489)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ExpandablePanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 183)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 306)
        Me.Panel4.TabIndex = 1
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.TabControl1)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpandablePanel1.ExpandOnTitleClick = True
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExpandablePanel1.RightToLeftLayout = True
        Me.ExpandablePanel1.Size = New System.Drawing.Size(200, 306)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 2
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "نوار ابزار"
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(200, 280)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2003
        Me.TabControl1.TabIndex = 269
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem4)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Panel6)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(200, 255)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.lbl_persiandate)
        Me.Panel6.Controls.Add(Me.Clock1)
        Me.Panel6.Controls.Add(Me.FaMonthView1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel6.Size = New System.Drawing.Size(198, 253)
        Me.Panel6.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "امروز:"
        '
        'lbl_persiandate
        '
        Me.lbl_persiandate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_persiandate.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_persiandate.Location = New System.Drawing.Point(22, 283)
        Me.lbl_persiandate.Name = "lbl_persiandate"
        Me.lbl_persiandate.Size = New System.Drawing.Size(121, 16)
        Me.lbl_persiandate.TabIndex = 2
        Me.lbl_persiandate.Text = "Label1"
        Me.lbl_persiandate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Clock1
        '
        Me.Clock1.ClockHandSize = 70
        Me.Clock1.DigitsPosition = PureComponents.ScheduleSet.Calendars.ClockDigitsPosition.Hidden
        Me.Clock1.Location = New System.Drawing.Point(46, 2)
        Me.Clock1.Name = "Clock1"
        Me.Clock1.Size = New System.Drawing.Size(94, 76)
        ClockStyle1.BackColor = System.Drawing.Color.Transparent
        ClockStyle1.BorderStyle = PureComponents.ScheduleSet.BorderStyle.None
        ClockStyle1.DigitsBackColor = System.Drawing.Color.PaleTurquoise
        ClockStyle1.DigitsBorder = PureComponents.ScheduleSet.BorderStyle.Solid
        ClockStyle1.DigitsBorderColor = System.Drawing.Color.SteelBlue
        ClockStyle1.DigitsFadeColor = System.Drawing.Color.LightCyan
        ClockStyle1.DigitsFillStyle = PureComponents.ScheduleSet.FillStyle.VerticalFading
        ClockStyle1.DigitsForeColor = System.Drawing.Color.DimGray
        ClockStyle1.DigitsShape = PureComponents.ScheduleSet.Shape.Vista
        ClockStyle1.FillStyle = PureComponents.ScheduleSet.FillStyle.Flat
        ClockStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        ClockStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        ClockStyle1.HandImage = Nothing
        ClockStyle1.HandShape = PureComponents.ScheduleSet.Calendars.ClockHandShape.Shape1
        ClockStyle1.Image = CType(resources.GetObject("ClockStyle1.Image"), System.Drawing.Image)
        ClockStyle1.Shape = PureComponents.ScheduleSet.Shape.Vista
        Me.Clock1.Style = ClockStyle1
        Me.Clock1.TabIndex = 1
        '
        'FaMonthView1
        '
        Me.FaMonthView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FaMonthView1.IsNull = False
        Me.FaMonthView1.Location = New System.Drawing.Point(18, 84)
        Me.FaMonthView1.Name = "FaMonthView1"
        Me.FaMonthView1.SelectedDateTime = New Date(2010, 3, 9, 0, 12, 37, 406)
        Me.FaMonthView1.TabIndex = 0
        Me.FaMonthView1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "زمان و تاریخ"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.grd_book)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(200, 255)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 3
        Me.TabControlPanel2.TabItem = Me.TabItem3
        '
        'grd_book
        '
        Me.grd_book.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grd_book.AlternatingColors = True
        Me.grd_book.BuiltInTextsData = resources.GetString("grd_book.BuiltInTextsData")
        Me.grd_book.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        grd_book_DesignTimeLayout.LayoutString = resources.GetString("grd_book_DesignTimeLayout.LayoutString")
        Me.grd_book.DesignTimeLayout = grd_book_DesignTimeLayout
        Me.grd_book.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_book.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd_book.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grd_book.FilterRowFormatStyle.BackColor = System.Drawing.Color.Linen
        Me.grd_book.FilterRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd_book.FilterRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical
        Me.grd_book.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grd_book.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grd_book.GroupByBoxVisible = False
        Me.grd_book.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grd_book.Location = New System.Drawing.Point(1, 1)
        Me.grd_book.Name = "grd_book"
        Me.grd_book.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_book.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_book.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_book.Size = New System.Drawing.Size(198, 253)
        Me.grd_book.TabIndex = 1
        Me.grd_book.TabStop = False
        Me.grd_book.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_book.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_book.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_book.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel2
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "کتاب"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.grd_aza)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(200, 255)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'grd_aza
        '
        Me.grd_aza.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grd_aza.AlternatingColors = True
        Me.grd_aza.BuiltInTextsData = resources.GetString("grd_aza.BuiltInTextsData")
        Me.grd_aza.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        grd_aza_DesignTimeLayout.LayoutString = resources.GetString("grd_aza_DesignTimeLayout.LayoutString")
        Me.grd_aza.DesignTimeLayout = grd_aza_DesignTimeLayout
        Me.grd_aza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_aza.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd_aza.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grd_aza.FilterRowFormatStyle.BackColor = System.Drawing.Color.Linen
        Me.grd_aza.FilterRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd_aza.FilterRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical
        Me.grd_aza.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grd_aza.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grd_aza.GroupByBoxVisible = False
        Me.grd_aza.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grd_aza.Location = New System.Drawing.Point(1, 1)
        Me.grd_aza.Name = "grd_aza"
        Me.grd_aza.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_aza.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_aza.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_aza.Size = New System.Drawing.Size(198, 253)
        Me.grd_aza.TabIndex = 4
        Me.grd_aza.TabStop = False
        Me.grd_aza.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_aza.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_aza.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_aza.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "اعضا"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SideBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 177)
        Me.Panel3.TabIndex = 0
        '
        'SideBar1
        '
        Me.SideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.SideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.SideBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideBar1.ExpandedPanel = Me.SideBarPanelItem2
        Me.SideBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.SideBar1.Location = New System.Drawing.Point(0, 0)
        Me.SideBar1.Name = "SideBar1"
        Me.SideBar1.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideBarPanelItem1, Me.SideBarPanelItem2})
        Me.SideBar1.Size = New System.Drawing.Size(200, 177)
        Me.SideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.SideBar1.TabIndex = 1
        Me.SideBar1.Text = "SideBar1"
        Me.SideBar1.UsingSystemColors = True
        '
        'SideBarPanelItem2
        '
        Me.SideBarPanelItem2.FontBold = True
        Me.SideBarPanelItem2.Name = "SideBarPanelItem2"
        Me.SideBarPanelItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem4, Me.ButtonItem5})
        Me.SideBarPanelItem2.Text = "تنظیمات"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "درج تصویر"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "درج متن"
        '
        'SideBarPanelItem1
        '
        Me.SideBarPanelItem1.FontBold = True
        Me.SideBarPanelItem1.Name = "SideBarPanelItem1"
        Me.SideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3, Me.btn_amanet})
        Me.SideBarPanelItem1.Text = "اطلاعات پایه"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "ورود اطلاعات کتاب"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "مدیریت اعضا"
        '
        'btn_amanet
        '
        Me.btn_amanet.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btn_amanet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btn_amanet.Name = "btn_amanet"
        Me.btn_amanet.Text = "امانت کتاب"
        '
        'TabItem2
        '
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "اساتید"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.grd_daneshjoo)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(200, 0)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        '
        'grd_daneshjoo
        '
        Me.grd_daneshjoo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grd_daneshjoo.AlternatingColors = True
        Me.grd_daneshjoo.BuiltInTextsData = resources.GetString("grd_daneshjoo.BuiltInTextsData")
        Me.grd_daneshjoo.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        grd_daneshjoo_DesignTimeLayout.LayoutString = resources.GetString("grd_daneshjoo_DesignTimeLayout.LayoutString")
        Me.grd_daneshjoo.DesignTimeLayout = grd_daneshjoo_DesignTimeLayout
        Me.grd_daneshjoo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_daneshjoo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd_daneshjoo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grd_daneshjoo.FilterRowFormatStyle.BackColor = System.Drawing.Color.Linen
        Me.grd_daneshjoo.FilterRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd_daneshjoo.FilterRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical
        Me.grd_daneshjoo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grd_daneshjoo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grd_daneshjoo.GroupByBoxVisible = False
        Me.grd_daneshjoo.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grd_daneshjoo.Location = New System.Drawing.Point(1, 1)
        Me.grd_daneshjoo.Name = "grd_daneshjoo"
        Me.grd_daneshjoo.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_daneshjoo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_daneshjoo.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_daneshjoo.Size = New System.Drawing.Size(198, 0)
        Me.grd_daneshjoo.TabIndex = 916
        Me.grd_daneshjoo.TabStop = False
        Me.grd_daneshjoo.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_daneshjoo.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_daneshjoo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_daneshjoo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupPanel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(584, 489)
        Me.Panel5.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PictureBox1)
        Me.GroupPanel1.Controls.Add(Me.ReflectionLabel2)
        Me.GroupPanel1.Controls.Add(Me.TextBox1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(584, 489)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "GroupPanel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.T_setBindingSource, "pic", True))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(578, 335)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'T_setBindingSource
        '
        Me.T_setBindingSource.DataMember = "t_set"
        Me.T_setBindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.Class = ""
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("B Traffic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ReflectionLabel2.Location = New System.Drawing.Point(178, 34)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(206, 70)
        Me.ReflectionLabel2.TabIndex = 1
        Me.ReflectionLabel2.Text = "کانون فرهنگی هنری شهید مهربان"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_setBindingSource, "des", True))
        Me.TextBox1.Location = New System.Drawing.Point(376, 252)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 47
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "اساتید"
        '
        'T_setTableAdapter
        '
        Me.T_setTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_amanatTableAdapter = Nothing
        Me.TableAdapterManager.t_bookTableAdapter = Nothing
        Me.TableAdapterManager.t_memberTableAdapter = Nothing
        Me.TableAdapterManager.t_setTableAdapter = Me.T_setTableAdapter
        Me.TableAdapterManager.UpdateOrder = ketabkhane_n.bankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "saya"
        Me.Panel1.ResumeLayout(False)
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.grd_book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.grd_aza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.grd_daneshjoo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_setBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SideBar1 As DevComponents.DotNetBar.SideBar
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_persiandate As System.Windows.Forms.Label
    Friend WithEvents Clock1 As PureComponents.ScheduleSet.Calendars.Clock
    Friend WithEvents FaMonthView1 As FarsiLibrary.Win.Controls.FAMonthView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents grd_daneshjoo As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_amanet As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents grd_book As Janus.Windows.GridEX.GridEX
    Friend WithEvents grd_aza As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BankDataSet As ketabkhane_n.bankDataSet
    Friend WithEvents T_setBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_setTableAdapter As ketabkhane_n.bankDataSetTableAdapters.t_setTableAdapter
    Friend WithEvents TableAdapterManager As ketabkhane_n.bankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SideBarPanelItem2 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
