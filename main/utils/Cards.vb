Public Class Cards

    Private _Cost As Integer

    Public Name As String
    Public Type As Integer
    Public Price As Integer
    Public Sell As Integer
    Public Complex As String
    Public House As Houses

    Public Property Cost As Integer
        Get
            If (TotalHouse = 0) Then
                Return _Cost
            Else
                Return House.Costs(TotalHouse - 1)
            End If
        End Get
        Set(value As Integer)
            _Cost = value
        End Set
    End Property

    Public Owner As Integer
    Public TotalHouse As Integer

    Public Sub New(Name, Type, Price, Complex, Cost, House)
        Me.Name = Name
        Me.Type = Type
        Me.Price = Price
        Me.Complex = Complex
        Me.Cost = Cost
        Me.House = House

        Owner = Nothing
        Sell = Price / 2
        TotalHouse = 0
    End Sub

End Class
