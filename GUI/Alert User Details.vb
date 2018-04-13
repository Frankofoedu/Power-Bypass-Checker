Public Class Alert_User_Details
    Private Sub Alert_User_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Check_Alerts.currentcustomer.Surname.ToString
        TextBox2.Text = Check_Alerts.currentcustomer.Other_Name.ToString
        TextBox3.Text = Check_Alerts.currentcustomer.Card_No.ToString
        TextBox4.Text = Check_Alerts.currentcustomer.Amounts_Purchased.ToString
        TextBox5.Text = Check_Alerts.currentcustomer.Token_Days.ToString
        TextBox6.Text = Check_Alerts.currentcustomer.Grace_Value.ToString
        Label8.Text = Check_Alerts.currentcustomer.Address_Of_supply


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        mainView.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class