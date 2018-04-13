Public Class Receipt
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Buy_Units.receiptsCustomer.Surname
        TextBox2.Text = Buy_Units.receiptsCustomer.Other_Name
        TextBox3.Text = Buy_Units.receiptsCustomer.Amounts_Purchased

        TextBox5.Text = Date.Today
        TextBox6.Text = GenerateCardId(16, True)
    End Sub

    Public Function GenerateCardId(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        mainView.Show()
        Buy_Units.Dispose()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class