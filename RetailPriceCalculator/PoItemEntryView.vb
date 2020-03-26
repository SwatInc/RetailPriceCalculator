Imports PriceCalculator

Public Class PoItemEntryView
    Private _viewModel As PoItemEntryViewModel

    Public Sub New(viewModel As PoItemEntryViewModel)

        InitializeComponent()
        Me._viewModel = viewModel

        InitializeBindings()

    End Sub

    Private Sub InitializeBindings()
        'Store
        Me.LookUpEditStores.Properties.DataSource = _viewModel.Stores
        Me.LookUpEditStores.Properties.DisplayMember = NameOf(Store.Description)
        Me.LookUpEditStores.Properties.ValueMember = NameOf(Store.Id)

        'Item Search
        Me.LookUpEditSearchItem.Properties.DataSource = _viewModel.Items
        Me.LookUpEditSearchItem.Properties.DisplayMember = NameOf(Item.Description)
        Me.LookUpEditSearchItem.Properties.ValueMember = NameOf(Item.Barcode)


    End Sub
End Class