<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItemOpenCart = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItemOpenCart})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
        Me.RibbonControl1.Size = New System.Drawing.Size(1147, 126)
        '
        'BarButtonItemOpenCart
        '
        Me.BarButtonItemOpenCart.Caption = "މުދާ ވަށި"
        Me.BarButtonItemOpenCart.Id = 1
        Me.BarButtonItemOpenCart.ImageOptions.Image = CType(resources.GetObject("BarButtonItemOpenCart.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemOpenCart.ItemAppearance.Disabled.Font = New System.Drawing.Font("Mv GroupX Avas", 18.0!)
        Me.BarButtonItemOpenCart.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItemOpenCart.ItemAppearance.Hovered.Font = New System.Drawing.Font("Mv GroupX Avas", 18.0!)
        Me.BarButtonItemOpenCart.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItemOpenCart.ItemAppearance.Normal.Font = New System.Drawing.Font("Mv GroupX Avas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItemOpenCart.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItemOpenCart.ItemAppearance.Pressed.Font = New System.Drawing.Font("Mv GroupX Avas", 18.0!)
        Me.BarButtonItemOpenCart.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItemOpenCart.Name = "BarButtonItemOpenCart"
        Me.BarButtonItemOpenCart.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItemOpenCart)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'MainView
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 492)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Font = New System.Drawing.Font("Faruma", 12.0!)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainView"
        Me.Ribbon = Me.RibbonControl1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "އަގު ލިސްޓު"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemOpenCart As DevExpress.XtraBars.BarButtonItem
End Class
