Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class ItemDetails
    Inherits Item
    Implements INotifyPropertyChanged

    Private _RetailUnitPrice As Decimal
    Private _WholeSaleCostPrice As Decimal
    Public Property IsTaxed As Boolean
    Public Property TaxRate As Tax
    Public Property WholeSaleCostPrice As Decimal
        Get
            Return _WholeSaleCostPrice
        End Get
        Set
            _WholeSaleCostPrice = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property WholeSaleUnit As String
    Public Property RetailUnit As String
    Public Property RetailUnitsPerWholeSaleUnit As Decimal 'pakeh gai inna varu
    Public Property RetailUnitPrice As Decimal
        Get
            Return _RetailUnitPrice
        End Get
        Private Set
            _RetailUnitPrice = Value
        End Set
    End Property

    Private Sub OnPropertyChanged(<CallerMemberName> Optional propertyChanged As String = "")
        RaiseEvent propertyChanged(Me, New PropertyChangedEventArgs(propertyChanged))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
