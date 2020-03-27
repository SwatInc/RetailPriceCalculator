Public Class Item
    Public Property Barcode As String
    Public Property Description As String

    Public Overrides Function ToString() As String
        Return $"{Barcode} | {Description}"
    End Function
End Class
