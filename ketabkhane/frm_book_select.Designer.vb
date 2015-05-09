<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_book_select
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_book_select))
        Dim grd_grayesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.grd_grayesh = New Janus.Windows.GridEX.GridEX
        CType(Me.grd_grayesh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grd_grayesh.Location = New System.Drawing.Point(0, 0)
        Me.grd_grayesh.Name = "grd_grayesh"
        Me.grd_grayesh.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grd_grayesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grd_grayesh.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grd_grayesh.Size = New System.Drawing.Size(468, 302)
        Me.grd_grayesh.TabIndex = 1
        Me.grd_grayesh.TabStop = False
        Me.grd_grayesh.TotalRowFormatStyle.Font = New System.Drawing.Font("B Zar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grd_grayesh.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.grd_grayesh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grd_grayesh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'frm_book_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 302)
        Me.Controls.Add(Me.grd_grayesh)
        Me.Name = "frm_book_select"
        Me.Text = "انتخاب کتاب"
        CType(Me.grd_grayesh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grd_grayesh As Janus.Windows.GridEX.GridEX
End Class
