
Public Class RegistrationPart1contd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim output As Integer
        For Each tb As NumericUpDown In TableLayoutPanel1.Controls.OfType(Of NumericUpDown)()
            output = output + (tb.Value * tb.Tag)

        Next

        totalWatts = output

        ' Update database

        CustomerData1.Account_Number = AccountNumber
        CustomerData1.Alternate_No = AlternateNo
        CustomerData1.Applicant = applicant
        CustomerData1.Current_Billing_Information = CurrentBillinngInfo
        CustomerData1.Existing_Connection_Details = ExistingConnectionDetails
        CustomerData1.LGA = LGA
        CustomerData1.Name_On_The_Bill = NameOnTheBill
        CustomerData1.Old_Meter_Number = OldMeterNumber
        CustomerData1.Other_Name = OtherName
        CustomerData1.State = State
        CustomerData1.Surname = Surname
        CustomerData1.Tariff_Class = TariffClass
        CustomerData1.TelNo = TelNo
        CustomerData1.Type_Of_Connection = TypeOfConnection
        CustomerData1.Type_Of_Premises = TypeOfPremises
        CustomerData1.Use_Of_Premises = UseOfPremises
        CustomerData1.VillageTown = VillageTown
        CustomerData1.Address_Of_supply = addressOfSupply
        CustomerData1.Total_Watts = totalWatts
        CustomerData1.Area = Area

        CustomerData1.Area_State = GetAreaState(Area)


        CardNo = CheckAndGenerateCardId()
        CustomerData1.Card_No = CardNo

        Using db As New administrationEntities3
            db.CustomerDatas.Add(CustomerData1)
            db.SaveChanges()
        End Using


        User_Details.Show()
        Me.Close()


    End Sub

    Function GetAreaState(area As String) As Boolean
        Using db As New administrationEntities3

            Dim query = From cust In db.CustomerDatas
                        Where cust.Area = area
                        Select cust.Area_State

            If query.Count <> 0 Then
                Return query.FirstOrDefault
            Else
                Return True
            End If


        End Using
    End Function
    Public Function GenerateCardId(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function

    Public Function CheckAndGenerateCardId() As String
        Using db As New administrationEntities3
            Dim CardNo As String = GenerateCardId(11, True)

            Dim query = From s In db.CustomerDatas
                        Where s.Card_No = CardNo
                        Select s.Card_No

            Dim cardList = query.ToList

            If cardList.Count > 0 Then
                Return CheckAndGenerateCardId()
            Else
                Return CardNo
            End If
        End Using



    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrationPart1.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainView.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newLbl As Label = New Label
        Dim newUpd As NumericUpDown = New NumericUpDown
        Dim applianceName As String
        Dim applianceTag As Integer

        applianceName = InputBox("Enter the appliance name",,,,)

        If applianceName = "" Then
            MessageBox.Show("no appliance added")
            Exit Sub
        End If

        applianceTag = InputBox("Enter the appliance Units",,,,)

        If applianceTag = vbNull Then
            MessageBox.Show("Appliance Units not added")
            Exit Sub
        End If

        newLbl.Text = TableLayoutPanel1.RowCount & "." & " " & applianceName
        newLbl.Font = New Font(FontFamily.GenericSansSerif, 8.25, FontStyle.Bold)

        newUpd.Tag = applianceTag
        newUpd.Size = New Size(56, 20)

        TableLayoutPanel1.Controls.Add(newLbl, 0, TableLayoutPanel1.RowCount)
        TableLayoutPanel1.Controls.Add(newUpd, 1, TableLayoutPanel1.RowCount)
    End Sub
End Class