Public Class Lands

    Public X As Double
    Public Y As Double
    Public LandType As Integer
    Public Card As Cards
    Public Tax As Integer

    Public Sub New(X As Integer, Y As Integer, LandType As Integer)
        Me.X = X
        Me.Y = Y
        Me.LandType = LandType
    End Sub

    Public Sub New(X As Integer, Y As Integer, LandType As Integer, Card As Cards)
        Me.X = X
        Me.Y = Y
        Me.LandType = LandType
        Me.Card = Card
    End Sub

    Public Sub New(X As Integer, Y As Integer, LandType As Integer, Tax As Integer)
        Me.X = X
        Me.Y = Y
        Me.LandType = LandType
        Me.Tax = Tax
    End Sub

End Class
