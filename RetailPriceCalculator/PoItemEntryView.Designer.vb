<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoItemEntryView
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PoItemEntryView))
        Me.SimpleButtonSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEditSearchItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEditStores = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControlSubTotal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControlTax = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.LookUpEditSearchItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditStores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButtonSearch
        '
        Me.SimpleButtonSearch.Appearance.Font = New System.Drawing.Font("Faruma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButtonSearch.Appearance.Options.UseFont = True
        Me.SimpleButtonSearch.Appearance.Options.UseTextOptions = True
        Me.SimpleButtonSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleButtonSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SimpleButtonSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButtonSearch.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButtonSearch.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButtonSearch.Location = New System.Drawing.Point(695, 12)
        Me.SimpleButtonSearch.Name = "SimpleButtonSearch"
        Me.SimpleButtonSearch.Size = New System.Drawing.Size(172, 46)
        Me.SimpleButtonSearch.TabIndex = 1
        Me.SimpleButtonSearch.Tag = "SimpleButtonSeach"
        '
        'LookUpEditSearchItem
        '
        Me.LookUpEditSearchItem.EditValue = ""
        Me.LookUpEditSearchItem.Location = New System.Drawing.Point(188, 12)
        Me.LookUpEditSearchItem.Name = "LookUpEditSearchItem"
        Me.LookUpEditSearchItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditSearchItem.Properties.NullText = "މުދަލުގެ ނަން / ބާރކޯޑު ސްކޭން ކޮއްލާ ..."
        Me.LookUpEditSearchItem.Properties.NullValuePrompt = "މުދަލުގެ ނަން / ބާރކޯޑު ސްކޭން ކޮއްލާ ..."
        Me.LookUpEditSearchItem.Properties.NullValuePromptShowForEmptyValue = True
        Me.LookUpEditSearchItem.Properties.ShowNullValuePromptWhenFocused = True
        Me.LookUpEditSearchItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditSearchItem.Size = New System.Drawing.Size(501, 46)
        Me.LookUpEditSearchItem.TabIndex = 0
        '
        'LookUpEditStores
        '
        Me.LookUpEditStores.EditValue = ""
        Me.LookUpEditStores.Location = New System.Drawing.Point(10, 12)
        Me.LookUpEditStores.Name = "LookUpEditStores"
        Me.LookUpEditStores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditStores.Properties.NullText = "ފިހާރަ ނަންގަވާ ..."
        Me.LookUpEditStores.Properties.NullValuePrompt = "ފިހާރަ ނަންގަވާ ..."
        Me.LookUpEditStores.Properties.NullValuePromptShowForEmptyValue = True
        Me.LookUpEditStores.Properties.ShowNullValuePromptWhenFocused = True
        Me.LookUpEditStores.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditStores.Size = New System.Drawing.Size(172, 46)
        Me.LookUpEditStores.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(10, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(857, 315)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(444, 478)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(172, 46)
        Me.DateEdit1.TabIndex = 4
        '
        'LabelControlSubTotal
        '
        Me.LabelControlSubTotal.Appearance.Font = New System.Drawing.Font("Faruma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlSubTotal.Appearance.Options.UseFont = True
        Me.LabelControlSubTotal.Location = New System.Drawing.Point(792, 37)
        Me.LabelControlSubTotal.Name = "LabelControlSubTotal"
        Me.LabelControlSubTotal.Size = New System.Drawing.Size(42, 30)
        Me.LabelControlSubTotal.TabIndex = 5
        Me.LabelControlSubTotal.Text = "ޖުމްލަ "
        '
        'LabelControlTax
        '
        Me.LabelControlTax.Appearance.Font = New System.Drawing.Font("Faruma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlTax.Appearance.Options.UseFont = True
        Me.LabelControlTax.Location = New System.Drawing.Point(429, 37)
        Me.LabelControlTax.Name = "LabelControlTax"
        Me.LabelControlTax.Size = New System.Drawing.Size(58, 30)
        Me.LabelControlTax.TabIndex = 6
        Me.LabelControlTax.Text = " ޓެކުސް"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Faruma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(110, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 30)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = " މުޅި ޖުމްލަ "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 25)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "12300.00"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(707, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 25)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "12300.00"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(344, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 25)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "12300.00"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControlSubTotal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControlTax)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 385)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(857, 85)
        Me.GroupControl1.TabIndex = 18
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(241, 478)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(172, 46)
        Me.SimpleButton1.TabIndex = 19
        '
        'PoItemEntryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 530)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LookUpEditStores)
        Me.Controls.Add(Me.SimpleButtonSearch)
        Me.Controls.Add(Me.LookUpEditSearchItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PoItemEntryView"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ގަންނަ މުދަލުގެ ތަފްސީލު"
        CType(Me.LookUpEditSearchItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditStores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButtonSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEditSearchItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditStores As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControlSubTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControlTax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
