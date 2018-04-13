Public Class User_Details
    Private Sub User_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  PictureBox1.Load()
        TextBox1.Text = Surname
        TextBox2.Text = OtherName
        TextBox3.Text = CardNo
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainView.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()

    End Sub
End Class