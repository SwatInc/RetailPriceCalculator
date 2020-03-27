Public Class Cart
    Private Property Barcode As String
    Public Property Quantity As Decimal
    Public Property Description As String
    Public Property RetailUnit As String
    Public Property RetailSalePrice As Decimal 'Selling price to customers
    Public Property ProfitMargin As Decimal
    Public Property Rate As Decimal 'cost price per retail piece
    Private Property TaxRate As Decimal
    Public Property AmountWithTax As Decimal
    Public Property WholeSaleCostPrice As Decimal
    Public Property WholeSaleUnit As String

End Class
