Imports System.Data.SqlClient
Public Class New_Admin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim FirstName As String = TextBox1.Text
        'Dim LastName As String = TextBox2.Text
        'Dim username As String = TextBox3.Text
        'Dim password As String = TextBox4.Text

        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            If tb.Text = String.Empty Then
                MessageBox.Show("please fill all information")
                Exit Sub
            End If

        Next

        If TextBox4.Text <> TextBox5.Text Then
            MessageBox.Show("The passwords do not match. Please Try again")
            Exit Sub
        End If

        'myConnection.ConnectionString = My.Settings.administrationConnectionString
        'myConnection.Open()
        'Dim cmd As SqlCommand = New SqlCommand("INSERT INTO AdminTable([username],[password],[FirstName],[LastName]) VALUES('" & username & "','" & password & "','" & FirstName & "','" & LastName & "')", myConnection)

        'myConnection.Close()
        'Me.Hide()
        'mainView.Show()
        Dim db As New administrationEntities3
        Dim newAdmin As New AdminTable

        newAdmin.FirstName = TextBox1.Text
        newAdmin.LastName = TextBox2.Text
        newAdmin.username = TextBox3.Text
        newAdmin.password = TextBox4.Text


        db.AdminTables.Add(newAdmin)


        db.SaveChanges()
        MsgBox("new admin added")

        For Each tb As Control In Me.Controls.OfType(Of TextBox)()
            tb.Text = ""
        Next
        '    db.Dispose()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "New Admin", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class