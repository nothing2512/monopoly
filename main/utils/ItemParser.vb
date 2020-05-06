Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class ItemParser

    Public Shared Function GetConfigurations() As Dictionary(Of String, Integer)
        Dim data As New Dictionary(Of String, Integer)
        Dim Content = File.ReadAllText(JsonLocation & JsonConfig)
        Dim Obj = JObject.Parse(Content)

        data.Add("startMoney", Obj.Item("startMoney"))
        data.Add("go", Obj.Item("go"))
        data.Add("onGo", Obj.Item("onGo"))

        Return data
    End Function

    Public Shared Function ParseLands() As List(Of Lands)
        Dim Data As New List(Of Lands)
        Dim Content = File.ReadAllText(JsonLocation & JsonLands)
        Dim Obj = JArray.Parse(Content)

        For Each Item In Obj

            Dim X = Item.Item("x")
            Dim Y = Item.Item("y")
            Dim LandType As Integer = Item.Item("landType")

            If LandType = LandGo Or LandType = LandJail Or LandType = LandGotoJail Or LandType = LandFreePark Or
               LandType = LandMysteryBox Or LandType = LandSideStory Then
                Data.Add(New Lands(X, Y, LandType))
            ElseIf LandType = LandTax Then
                Dim Tax As Integer = Item.Item("tax")
                Data.Add(New Lands(X, Y, LandType, Tax))
            ElseIf LandType = LandCard Or LandType = LandCompany Or LandType = LandStation Then
                Data.Add(New Lands(X, Y, LandType, ParseCard(Item.Item("card"))))
            End If
        Next

        Return Data
    End Function

    Public Shared Function ParseTreasure() As Dictionary(Of String, List(Of Treasure))
        Dim Data As New Dictionary(Of String, List(Of Treasure))
        Dim Treasures As New List(Of Treasure)
        Dim sideStory As New List(Of Treasure)
        Dim Content = File.ReadAllText(JsonLocation & JsonTreasure)
        Dim Obj = JObject.Parse(Content)

        Data.Add("treasure", Obj.Item("treasure").ToObject(Of List(Of Treasure)))
        Data.Add("sideStory", Obj.Item("sideStory").ToObject(Of List(Of Treasure)))

        Return Data
    End Function

    Private Shared Function ParseCard(Token As JToken) As Cards
        Dim House = Token.Item("house")
        Dim Houses = New Houses(
            House.Item("housePrice"),
            House.Item("hotelPrice"),
            House.Item("house1"),
            House.Item("house2"),
            House.Item("house3"),
            House.Item("house4"),
            House.Item("hotel")
        )

        Return New Cards(
            Token.Item("name"),
            Token.Item("type"),
            Token.Item("price"),
            Token.Item("complex"),
            Token.Item("cost"),
            Houses
        )
    End Function
End Class
