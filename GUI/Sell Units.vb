Imports System.ComponentModel
Imports System.Math
Public Class Buy_Units
    Dim db As New administrationEntities3
    Dim customerList As New List(Of CustomerData)
    Dim currrentCustomerIndex As Integer
    Public receiptsCustomer As CustomerData

    Dim gracevalue As Integer
    Dim tokendays As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim newTransaction = From s In db.CustomerDatas
                             Where s.Card_No = TextBox1.Text



        customerList = newTransaction.ToList
        If customerList.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Surname", .DataPropertyName = "Surname"})
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Other Name", .DataPropertyName = "Other_Name"})
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Card NO", .DataPropertyName = "Card_No"})

            DataGridView1.DataSource = customerList
            Label9.Visible = True
        Else

            MsgBox("user not found")
        End If




    End Sub



    Private Sub Buy_Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rate = 28
        Label6.Text = "RATE : #" & rate & " Per KWH"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox2.Text <> "" And TextBox3.Text <> "" Then

            Dim currentcustomer As CustomerData = customerList(currrentCustomerIndex)

            Dim today1 As Date
            Dim tokendate As Date
            Dim gracedate As Date

            If ComboBox1.Text = "" Then
                MsgBox("please select amount")
                Exit Sub
            End If

            'DataGridView1.SelectedRows(0).Cells(2).Value = ComboBox1.Text

            currentcustomer.Amounts_Purchased = CInt(ComboBox1.Text)
            today1 = Date.Now
            tokendate = today1.AddDays(tokendays)
            gracedate = today1.AddDays(gracevalue)



            If currentcustomer.Grace_Value < Date.Today Or currentcustomer.Grace_Value.ToString = "" Then
                currentcustomer.Token_Days = tokendate
                currentcustomer.Grace_Value = gracedate
                currentcustomer.Area_Time_Diff = Nothing
                currentcustomer.Area_State_End_Time = Nothing
                currentcustomer.Area_State_Start_Time = Nothing



            ElseIf currentcustomer.Grace_Value > Date.Today Then
                currentcustomer.Token_Days = DateAdd(DateInterval.Day, DateDiff(DateInterval.Day, Today, currentcustomer.Token_Days.Value), tokendate)
                currentcustomer.Grace_Value = DateAdd(DateInterval.Day, DateDiff(DateInterval.Day, Today, currentcustomer.Grace_Value.Value), gracedate)

            End If

            db.SaveChanges()
            receiptsCustomer = currentcustomer


            MsgBox("Units has been purchased")

            Me.Hide()
            Receipt.ShowDialog()
        Else
            MsgBox("No User Selected")

        End If






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt As String = String.Empty
        Dim title As String = "Set New Rate"


        Dim answer As Object

        ' Display prompt, title, and default value.
        answer = InputBox(prompt, title, "")

        If String.IsNullOrEmpty(answer) Then
            MessageBox.Show("No new Rate selected : ")
            Exit Sub

        Else
            MessageBox.Show("New Rate is : " & answer)
            rate = answer

            Label6.Text = "RATE : #" & rate & " Per KWH"
        End If

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

        If TextBox2.Text <> "" AndAlso TextBox3.Text <> "" Then
            Dim currentcustomer As CustomerData = customerList(currrentCustomerIndex)
            If currentcustomer.Total_Watts IsNot Nothing Then

                Dim hrs = ((ComboBox1.Text) / rate) / (currentcustomer.Total_Watts / 30)
                tokendays = hrs
                gracevalue = tokendays + 30
                TextBox5.Text = CInt((ComboBox1.Text) / rate)
                TextBox6.Text = Date.Today.AddDays(tokendays)
                TextBox4.Text = Date.Today.AddDays(gracevalue)
            Else
                MsgBox("user info is not complete")
                Exit Sub
            End If
        Else
            MsgBox("no user selected")
            ComboBox1.Text = ""
            Exit Sub
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mainView.Show()

        Me.Dispose()

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        currrentCustomerIndex = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(currrentCustomerIndex)


        TextBox2.Text = customerList(e.RowIndex).Surname.ToString
        TextBox3.Text = customerList(e.RowIndex).Other_Name.ToString
        TextBox7.Text = customerList(e.RowIndex).Total_Watts.ToString
    End Sub

    Private Sub Buy_Units_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        db.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class