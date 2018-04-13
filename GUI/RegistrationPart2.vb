Public Class RegistrationPart2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OName = TextBox1.Text
        OAddress = TextBox2.Text
        OTown = TextBox3.Text
        OLGA = TextBox4.Text
        OState = TextBox5.Text
        OTelNo = TextBox6.Text
        OAltNo = TextBox7.Text
        OEmail = TextBox8.Text
        OPreviousOccupant = TextBox9.Text
        OAccountNumber = TextBox10.Text
        OmeterNumber = TextBox11.Text

        Me.Hide()
        RegistrationPart3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrationPart1contd.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainView.Show()
        Me.Close()

    End Sub
End Class