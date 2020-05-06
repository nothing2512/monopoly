Public Class Player

    Public Name As String
    Public Money As Integer
    Public JailStack As Integer
    Public LandPosition As Integer
    Public StationCount As Integer
    Public CompanyCount As Integer
    Public isGameOver As Boolean
    Public Dicer As Dicer
    Public DiceStack As Integer
    Public Img As PictureBox
    Public Lands As List(Of Lands)

    Public Sub New(Name As String, Money As Integer, Lands As List(Of Lands), Img As PictureBox)
        Me.Name = Name
        Me.Money = Money
        Me.Img = Img
        Me.Lands = Lands

        Dicer = New Dicer(Lands)
        JailStack = 0
        LandPosition = 0
        StationCount = 0
        CompanyCount = 0
        isGameOver = False
    End Sub

    Public Function RollDice() As Dictionary(Of String, Object)
        DiceStack += 1

        Dim Dice = Dicer.Dice(LandPosition)
        Dim Land As Lands = Dice(KEY_LAND)
        Dim IsDouble As Boolean = Dice(KEY_DOUBLE)
        Dim ThroughGo As Boolean = Dice(KEY_THROUGH_GO)

        If DiceStack = 3 And IsDouble Then
            Land = Lands(JailStack)
            Dice(KEY_LAND) = Land
            Move(Land.X, Land.Y)
            Return Dice
        End If

        If ThroughGo Then
            Money += 200
        End If

        Move(Land.X, Land.Y)

        Return Dice
    End Function

    Public Sub Move(X, Y)
        Img.Location = New Point(X, Y)
    End Sub

End Class
