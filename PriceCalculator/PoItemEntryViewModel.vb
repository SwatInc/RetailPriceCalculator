Public Class PoItemEntryViewModel
#Region "Default Constructor"
    Public Sub New()

        InitializeLists()
        GenerateDemoData()
    End Sub

#End Region

#Region "Datasources"

    Public Property Stores As List(Of Store)
    Public Property Items As List(Of Item)
    Public Property CartItems As List(Of Cart)

#End Region

#Region "Private Methods"

    Private Sub GenerateDemoData()

        'Demo Store data
        Stores.Add(New Store() With {.Id = 1, .Description = "Samraahi Store"})
        Stores.Add(New Store() With {.Id = 2, .Description = "Gaobili plus"})
        Stores.Add(New Store() With {.Id = 3, .Description = "Seeds"})
        Stores.Add(New Store() With {.Id = 4, .Description = "Blue Coin"})

        'Demo Item data
        Items.Add(New Item With {.Barcode = "3515521552", .Description = "Hup Seng Biscuts 200g"})
        Items.Add(New Item With {.Barcode = "1525582555", .Description = "Taza Mineral Water 5L x 4"})

    End Sub

    Private Sub InitializeLists()

        'InitializeLists
        Stores = New List(Of Store)
        Items = New List(Of Item)
        CartItems = New List(Of Cart)

    End Sub

#End Region

End Class
