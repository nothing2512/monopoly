Public Class Dicer

    Private Land As List(Of Lands)

    Public Sub New(Land As List(Of Lands))
        Me.Land = Land
    End Sub


    Public Function Dice(Position As Integer) As Dictionary(Of String, Object)
        Dim Data As New Dictionary(Of String, Object)
        Dim R As New Random()

        Dim LandSize = Land.Count - 1
        Dim Dice1 = R.Next(1, 6)
        Dim Dice2 = R.Next(1, 6)
        Dim TotalDice = Dice1 + Dice2
        Dim ISDouble = Dice1 = Dice2

        Data.Add(KEY_DICE, New List(Of Integer)(New Integer() {Dice1, Dice2}))
        Data.Add(KEY_DOUBLE, ISDouble)

        If (TotalDice + Position > LandSize) Then
            Data.Add(KEY_LAND, Land(TotalDice + Position - LandSize))
            Data.Add(KEY_THROUGH_GO, True)
        End If
        Data.Add(KEY_LAND, Land(TotalDice + Position))
        Data.Add(KEY_THROUGH_GO, True)
        Return Data
    End Function

End Class
