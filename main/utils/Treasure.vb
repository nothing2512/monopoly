Public Class Treasure

    Public Type As Integer
    Public Text As String
    Public GotoIndex As Integer
    Public Money As Integer

    Public Sub New(Type, Text, GotoIndex, Money)
        Me.Type = Type
        Me.Text = Text
        Me.GotoIndex = GotoIndex
        Me.Money = Money
    End Sub

    Public Sub Show()
        MsgBox(Text, vbOK)
    End Sub
End Class
