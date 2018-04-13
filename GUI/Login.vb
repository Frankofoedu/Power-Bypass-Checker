Imports System.Data.SqlClient

Public Class login
    'Dim provider As String
    'Dim dataFile As String
    'Dim connString As String
    'Dim myConnection As SqlConnection = New SqlConnection
    Public firstname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Me.DialogResult = DialogResult.OK

        'myConnection.ConnectionString = My.Settings.administrationConnectionString
        'myConnection.Open()

        ''the query:
        'Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [AdminTable] WHERE [username] = '" & TextBox1.Text & "' AND [password] = '" & TextBox2.Text & "'", myConnection)
        'Dim dr As SqlDataReader = cmd.ExecuteReader


        '' the following variable is hold true if user is found, and false if user is not found
        'Dim userFound As Boolean = False
        'Dim firstname As String

        'dr.Read()

        'If dr.HasRows Then
        '    userFound = True
        '    firstname = dr.Item("FirstName").ToString

        'End If

        ''check the result
        'If userFound = True Then
        '    'If dt.Rows.Count > 0 Then
        '    ' MsgBox(firstname)
        '    myConnection.Close()
        '    Me.Hide()
        '    mainView.Show()
        '    mainView.Label1.Text = "Logged in: " & firstname
        'Else
        '    MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        '    myConnection.Close()
        '    Exit Sub
        'End If


        Dim db As New administrationEntities3
        Dim admntb As New AdminTable

        Dim resultQuery = From admins In db.AdminTables
                          Where admins.username = TextBox1.Text
                          Where admins.password = TextBox2.Text
                          Select admins.FirstName


        Dim result = resultQuery.ToList

        If result.Count > 0 Then
            firstname = result.First
            Me.Hide()
            mainView.Show()
            mainView.Label1.Text = "Logged in: " & firstname
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
        'db.Dispose()
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Project", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Project", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        End If
    End Sub
End Class