Public Class Game

    Public Players As List(Of Player)
    Public Turn As Integer
    Public TotalPlayerAlive As Integer

    Public Sub New(Players As List(Of Player))
        Me.Players = Players

        TotalPlayerAlive = Players.Count
        Turn = 0
    End Sub

    Public Sub StartGame()

    End Sub

End Class
