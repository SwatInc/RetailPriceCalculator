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
        Me.GridControlCart = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRetailUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCostPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAmountWithTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControlSubTotal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControlTax = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumnRetailSalePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnProfitMargin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnWholeSaleUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LookUpEditSearchItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditStores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlCart, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButtonSearch.Location = New System.Drawing.Point(735, 12)
        Me.SimpleButtonSearch.Name = "SimpleButtonSearch"
        Me.SimpleButtonSearch.Size = New System.Drawing.Size(131, 32)
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
        Me.LookUpEditSearchItem.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LookUpEditSearchItem.Properties.ShowHeader = False
        Me.LookUpEditSearchItem.Properties.ShowNullValuePromptWhenFocused = True
        Me.LookUpEditSearchItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditSearchItem.Size = New System.Drawing.Size(543, 32)
        Me.LookUpEditSearchItem.TabIndex = 0
        '
        'LookUpEditStores
        '
        Me.LookUpEditStores.EditValue = ""
        Me.LookUpEditStores.Location = New System.Drawing.Point(10, 12)
        Me.LookUpEditStores.Name = "LookUpEditStores"
        Me.LookUpEditStores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditStores.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")})
        Me.LookUpEditStores.Properties.NullText = "ފިހާރަ ނަންގަވާ ..."
        Me.LookUpEditStores.Properties.NullValuePrompt = "ފިހާރަ ނަންގަވާ ..."
        Me.LookUpEditStores.Properties.NullValuePromptShowForEmptyValue = True
        Me.LookUpEditStores.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LookUpEditStores.Properties.ShowHeader = False
        Me.LookUpEditStores.Properties.ShowNullValuePromptWhenFocused = True
        Me.LookUpEditStores.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditStores.Size = New System.Drawing.Size(172, 32)
        Me.LookUpEditStores.TabIndex = 2
        '
        'GridControlCart
        '
        Me.GridControlCart.Location = New System.Drawing.Point(10, 67)
        Me.GridControlCart.MainView = Me.GridView1
        Me.GridControlCart.Name = "GridControlCart"
        Me.GridControlCart.Size = New System.Drawing.Size(857, 328)
        Me.GridControlCart.TabIndex = 3
        Me.GridControlCart.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnDescription, Me.GridColumnQuantity, Me.GridColumnRetailUnit, Me.GridColumnCostPrice, Me.GridColumnAmountWithTax, Me.GridColumnRetailSalePrice, Me.GridColumnRate, Me.GridColumnProfitMargin, Me.GridColumnWholeSaleUnit})
        Me.GridView1.DetailHeight = 365
        Me.GridView1.GridControl = Me.GridControlCart
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumnDescription
        '
        Me.GridColumnDescription.Caption = "މުދަލުގެ ނަން"
        Me.GridColumnDescription.FieldName = "Description"
        Me.GridColumnDescription.Name = "GridColumnDescription"
        Me.GridColumnDescription.Visible = True
        Me.GridColumnDescription.VisibleIndex = 1
        Me.GridColumnDescription.Width = 226
        '
        'GridColumnQuantity
        '
        Me.GridColumnQuantity.Caption = "އަދަދު"
        Me.GridColumnQuantity.FieldName = "Quantity"
        Me.GridColumnQuantity.Name = "GridColumnQuantity"
        Me.GridColumnQuantity.Visible = True
        Me.GridColumnQuantity.VisibleIndex = 0
        Me.GridColumnQuantity.Width = 53
        '
        'GridColumnRetailUnit
        '
        Me.GridColumnRetailUnit.Caption = "ޔުނިޓު"
        Me.GridColumnRetailUnit.FieldName = "RetailUnit"
        Me.GridColumnRetailUnit.Name = "GridColumnRetailUnit"
        Me.GridColumnRetailUnit.Visible = True
        Me.GridColumnRetailUnit.VisibleIndex = 2
        Me.GridColumnRetailUnit.Width = 65
        '
        'GridColumnCostPrice
        '
        Me.GridColumnCostPrice.Caption = "ގަންނަ އަގު"
        Me.GridColumnCostPrice.FieldName = "WholeSaleCostPrice"
        Me.GridColumnCostPrice.Name = "GridColumnCostPrice"
        Me.GridColumnCostPrice.Visible = True
        Me.GridColumnCostPrice.VisibleIndex = 7
        Me.GridColumnCostPrice.Width = 76
        '
        'GridColumnAmountWithTax
        '
        Me.GridColumnAmountWithTax.Caption = "އަގާއި ޓެކްސް"
        Me.GridColumnAmountWithTax.FieldName = "AmountWithTax"
        Me.GridColumnAmountWithTax.Name = "GridColumnAmountWithTax"
        Me.GridColumnAmountWithTax.Visible = True
        Me.GridColumnAmountWithTax.VisibleIndex = 6
        Me.GridColumnAmountWithTax.Width = 86
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(452, 490)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(131, 32)
        Me.DateEdit1.TabIndex = 4
        '
        'LabelControlSubTotal
        '
        Me.LabelControlSubTotal.Appearance.Font = New System.Drawing.Font("Mv Lady Luck", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlSubTotal.Appearance.Options.UseFont = True
        Me.LabelControlSubTotal.Location = New System.Drawing.Point(784, 37)
        Me.LabelControlSubTotal.Name = "LabelControlSubTotal"
        Me.LabelControlSubTotal.Size = New System.Drawing.Size(64, 33)
        Me.LabelControlSubTotal.TabIndex = 5
        Me.LabelControlSubTotal.Text = "  ޖުމްލަ"
        '
        'LabelControlTax
        '
        Me.LabelControlTax.Appearance.Font = New System.Drawing.Font("Mv Lady Luck", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControlTax.Appearance.Options.UseFont = True
        Me.LabelControlTax.Location = New System.Drawing.Point(443, 39)
        Me.LabelControlTax.Name = "LabelControlTax"
        Me.LabelControlTax.Size = New System.Drawing.Size(63, 33)
        Me.LabelControlTax.TabIndex = 6
        Me.LabelControlTax.Text = " ޓެކުސް"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Mv Lady Luck", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(96, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 33)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = " މުޅި ޖުމްލަ "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(33, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 21)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "12300.00"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(721, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 21)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "12300.00"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(380, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 21)
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
        Me.GroupControl1.Location = New System.Drawing.Point(10, 401)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(857, 78)
        Me.GroupControl1.TabIndex = 18
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(291, 490)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 32)
        Me.SimpleButton1.TabIndex = 19
        '
        'GridColumnRetailSalePrice
        '
        Me.GridColumnRetailSalePrice.Caption = "ވިއްކާ އަގު"
        Me.GridColumnRetailSalePrice.FieldName = "ReatailSalePrice"
        Me.GridColumnRetailSalePrice.Name = "GridColumnRetailSalePrice"
        Me.GridColumnRetailSalePrice.Visible = True
        Me.GridColumnRetailSalePrice.VisibleIndex = 3
        Me.GridColumnRetailSalePrice.Width = 64
        '
        'GridColumnRate
        '
        Me.GridColumnRate.Caption = "ރޭޓު"
        Me.GridColumnRate.FieldName = "Rate"
        Me.GridColumnRate.Name = "GridColumnRate"
        Me.GridColumnRate.Visible = True
        Me.GridColumnRate.VisibleIndex = 5
        Me.GridColumnRate.Width = 56
        '
        'GridColumnProfitMargin
        '
        Me.GridColumnProfitMargin.Caption = "ފައިދާ %"
        Me.GridColumnProfitMargin.FieldName = "ProfitMargin"
        Me.GridColumnProfitMargin.Name = "GridColumnProfitMargin"
        Me.GridColumnProfitMargin.Visible = True
        Me.GridColumnProfitMargin.VisibleIndex = 4
        Me.GridColumnProfitMargin.Width = 62
        '
        'GridColumnWholeSaleUnit
        '
        Me.GridColumnWholeSaleUnit.Caption = "ގ. ޔުނިޓް"
        Me.GridColumnWholeSaleUnit.FieldName = "WholeSaleUnit"
        Me.GridColumnWholeSaleUnit.Name = "GridColumnWholeSaleUnit"
        Me.GridColumnWholeSaleUnit.Visible = True
        Me.GridColumnWholeSaleUnit.VisibleIndex = 8
        Me.GridColumnWholeSaleUnit.Width = 81
        '
        'PoItemEntryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 534)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.GridControlCart)
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
        CType(Me.GridControlCart, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControlCart As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents GridColumnDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCostPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmountWithTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRetailUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRetailSalePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnProfitMargin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnWholeSaleUnit As DevExpress.XtraGrid.Columns.GridColumn
End Class
