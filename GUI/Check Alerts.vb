Imports projectMsc

Public Class Check_Alerts
    Dim customerAlertList As List(Of CustomerData)
    Dim selectedrow As DataGridViewRow
    Public Shared currentcustomer As CustomerData
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            selectedrow = DataGridView1.Rows(e.RowIndex)
            currentcustomer = customerAlertList(e.RowIndex)
            Alert_User_Details.Show()
            mainView.Hide()
            Me.Dispose()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainView.Show()
        Me.Dispose()

    End Sub



    Private Sub Check_Alerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New administrationentities3
            Dim cs As New CustomerData

            Dim today As Date
            today = Date.Today


            Dim newTransaction = From s In db.CustomerDatas
                                 Where Entity.DbFunctions.AddDays(s.Grace_Value, s.Area_Time_Diff) < today
                                 Order By s.Grace_Value
            '



            customerAlertList = newTransaction.ToList
            If customerAlertList.Count > 0 Then
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Surname", .DataPropertyName = "Surname"})
                DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Other Name", .DataPropertyName = "Other_Name"})
                DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Amounts Purchased", .DataPropertyName = "Amounts_Purchased"})
                DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Token Expiry Date", .DataPropertyName = "token_days"})
                DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Grace Period Date", .DataPropertyName = "Grace_Value"})

                DataGridView1.DataSource = customerAlertList
            Else
                Me.Show()
                MsgBox("no out of date customers in the database")

            End If
        End Using

    End Sub
End Class