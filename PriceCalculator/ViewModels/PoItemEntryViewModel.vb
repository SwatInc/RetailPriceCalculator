Imports System.ComponentModel

Public Class PoItemEntryViewModel


#Region "Default Constructor"
    Public Sub New()

        InitializeLists()
        GenerateDemoData()

        AddItem()
    End Sub

#End Region

#Region "Datasource properties"

    Public Property Stores As List(Of Store)
    Public Property Items As List(Of Item)
    Private Property ItemDetails As List(Of ItemDetails)
    Public Property CartItems As BindingList(Of Cart)

#End Region

#Region "Selected Value Properties"

    Public Property SelectedStoreId As String
    Public Property SelectedItemBarcode As String

#End Region

#Region "Other Properties"

    Public Property SubTotal As Double
    Public Property TotalTax As Double
    Public Property GrandTotal As Double

#End Region

#Region "Private Methods"

    Private Sub GenerateDemoData()

        'Add Item details data
        ItemDetails.Add(New ItemDetails() With
                        {
                        .Barcode = "3515521552",
                        .Description = "Hup Seng Biscuts 200g",
                        .IsTaxed = True, .RetailUnit = "pcs",
                        .RetailUnitsPerWholeSaleUnit = 12.0,
                        .TaxRate = New Tax() With {.Id = 1, .Description = "GST 6%", .Rate = 6.0},
                        .WholeSaleCostPrice = 144.0,
                        .WholeSaleUnit = "1 x 12"
                        })
        ItemDetails.Add(New ItemDetails() With
                        {
                        .Barcode = "1525582555",
                        .Description = "Taza Mineral Water 5L x 4",
                        .IsTaxed = True, .RetailUnit = "Bottle",
                        .RetailUnitsPerWholeSaleUnit = 12.0,
                        .TaxRate = New Tax() With {.Id = 1, .Description = "No Tax", .Rate = 0.0},
                        .WholeSaleCostPrice = 55.0,
                        .WholeSaleUnit = "1 x 4"
                        })

        'Demo Store data
        Stores.Add(New Store() With {.Id = 1, .Description = "Samraahi Store"})
        Stores.Add(New Store() With {.Id = 2, .Description = "Gaobili plus"})
        Stores.Add(New Store() With {.Id = 3, .Description = "Seeds"})
        Stores.Add(New Store() With {.Id = 4, .Description = "Blue Coin"})

        'Demo Item data
        Items.Add(New Item With {.Barcode = "3515521552", .Description = "Hup Seng Biscuts 200g"})
        Items.Add(New Item With {.Barcode = "1525582555", .Description = "Taza Mineral Water 5L x 4"})



    End Sub

    ''' <summary>
    ''' Add the current selected item to cart
    ''' </summary>
    Public Sub AddItem()
        CartItems.Add(New Cart() With {.Quantity = 1, .Description = "ABC"})
    End Sub

    Private Sub InitializeLists()

        'InitializeLists
        Stores = New List(Of Store)
        Items = New List(Of Item)
        CartItems = New BindingList(Of Cart)
        ItemDetails = New List(Of ItemDetails)

    End Sub

#End Region

End Class
