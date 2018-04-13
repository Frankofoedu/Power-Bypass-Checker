Public Class RegistrationPart1
    Public regform1 As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)

        If empty.Count > 0 Then
            If Not empty.Count = 1 Then
                MessageBox.Show("please fill all fields")
            Else
                If Not empty.SingleOrDefault.Name = "Textbox13" Then
                    MessageBox.Show("please fill all fields")
                    Exit Sub
                End If
            End If
        End If

        SaveDb()
        Me.Hide()
        RegistrationPart1contd.Show()

    End Sub

    Sub SaveDb()

        If ComboBox1.Text = "" Then
            MessageBox.Show("Please Enter Your Area")
            Exit Sub
        Else
            If ComboBox2.Text = "" Then
                MessageBox.Show("Please Enter Your Building type")
                Exit Sub
            End If
        End If

        For Each rdbtn As RadioButton In Panel5.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                applicant = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel4.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                UseOfPremises = rdbtn.Text
            End If
        Next

        For Each rdbtn As RadioButton In Panel3.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then

                ExistingConnectionDetails = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel2.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                CurrentBillinngInfo = rdbtn.Text
            End If
        Next

        For Each rdbtn As RadioButton In Panel1.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                MeterType = rdbtn.Text
            End If
        Next

        For Each rdbtn As RadioButton In Panel6.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                TypeOfConnection = rdbtn.Text
            End If
        Next

        Surname = TextBox1.Text
        OtherName = TextBox2.Text
        LGA = TextBox4.Text
        State = TextBox5.Text
        TelNo = TextBox6.Text
        AlternateNo = TextBox7.Text
        TypeOfPremises = ComboBox2.Text
        NameOnTheBill = TextBox11.Text
        AccountNumber = TextBox12.Text
        OldMeterNumber = TextBox13.Text
        TariffClass = TextBox14.Text
        addressOfSupply = TextBox15.Text
        Area = ComboBox1.Text
        VillageTown = TextBox3.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        mainView.Show()
    End Sub
    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim area As String
        area = ComboBox1.Text

        Select Case area
            Case "AKPAKA PHASE II"
                TextBox4.Text = "Onitsha North"
            Case "GRA PHASE I"
                TextBox4.Text = "Onitsha North"
            Case "NSUGBE"
                TextBox4.Text = "Anambra East"
            Case "HOUSING"
                TextBox4.Text = "Onitsha South"
            Case "3-3"
                TextBox4.Text = "Onitsha South"
        End Select
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress, TextBox12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class