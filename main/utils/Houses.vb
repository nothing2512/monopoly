Public Class Houses

    Public HousePrice As Integer
    Public HouseSold As Integer
    Public HotelPrice As Integer
    Public HotelSold As Integer
    Public Costs As New List(Of Integer)
    Public Hotel As Integer

    Public Sub New(HousePrice, HotelPrice, House1, House2, House3, House4, Hotel)
        Me.HousePrice = HousePrice
        Me.HotelPrice = HotelPrice

        Costs.Add(House1)
        Costs.Add(House2)
        Costs.Add(House3)
        Costs.Add(House4)
        Costs.Add(Hotel)

        HouseSold = HousePrice / 2
        HotelSold = HotelPrice / 2
    End Sub

End Class
