Public Class RegistrationPart3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OffAccountNumber = TextBox1.Text
        OffMeterNo = TextBox2.Text
        OffMeterMake = TextBox3.Text
        OffLastBillAmt = TextBox4.Text
        OffTotalOuts = TextBox4.Text


        Me.Hide()
        RegistrationPart4.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrationPart2.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainView.Show()
        Me.Close()

    End Sub
End Class