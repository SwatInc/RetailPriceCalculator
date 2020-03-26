Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports PriceCalculator

Public Class MainView
    Public Sub New()

        InitializeComponent()
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        'Subscribe for events
        AddHandler BarButtonItemOpenCart.ItemClick, AddressOf BarButtonItemOpenCartItemClick
    End Sub

    Private Sub BarButtonItemOpenCartItemClick(sender As Object, e As ItemClickEventArgs)
        OpenCartView()
    End Sub

    Private Sub OpenCartView()
        Dim cart As PoItemEntryView = New PoItemEntryView(New PoItemEntryViewModel()) With {
            .MdiParent = Me,
            .StartPosition = FormStartPosition.CenterParent
        }

        cart.Show()

    End Sub
End Class
