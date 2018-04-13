Public Class RegistrationPart4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Integer
        For i = 1 To TableLayoutPanel1.RowCount

            If TypeOf TableLayoutPanel1.GetControlFromPosition(1, i) IsNot NumericUpDown Then
                Exit For
            End If
            Dim c As NumericUpDown = TableLayoutPanel1.GetControlFromPosition(1, i)
            j = c.Value

            Dim b As NumericUpDown = TableLayoutPanel1.GetControlFromPosition(2, i)
            j = j * b.Value

            OffTotalInstalledLoad = OffTotalInstalledLoad + j
        Next


        For Each rdbtn As RadioButton In Panel1.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                OffPoleAvailable = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel2.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                OffPoleType = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel3.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                OffPoleCondition = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel4.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                OffServiceLine = rdbtn.Text
            End If
        Next


        For Each rdbtn As RadioButton In Panel5.Controls.OfType(Of RadioButton)()
            If rdbtn.Checked = True Then
                OffLineWireCondition = rdbtn.Text
            End If
        Next

        OffEstimateLoadApplied = NumericUpDown52.Value
        OffRequestedVoltageType = TextBox1.Text
        OffTypeOfMeter = TextBox2.Text




        ' Update database

        CustomerData1.Account_Number = AccountNumber
        CustomerData1.Alternate_No = AlternateNo
        CustomerData1.Applicant = applicant
        CustomerData1.Current_Billing_Information = CurrentBillinngInfo
        CustomerData1.Existing_Connection_Details = ExistingConnectionDetails
        CustomerData1.LGA = LGA
        CustomerData1.Meter_Type = MeterType
        CustomerData1.Name_On_The_Bill = NameOnTheBill
        CustomerData1.No_Of_Flats = NoOfFlats
        CustomerData1.No_Of_Floors = NoOfFloors
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

        CustomerData1.Owner_Name = OName
        CustomerData1.Owner_Address = OAddress
        CustomerData1.Owner_Town = OTown
        CustomerData1.Owner_LGA = OLGA
        CustomerData1.Owner_State = OState
        CustomerData1.Owner_Tel_No = OTelNo
        CustomerData1.Owner_Alt_No = OAltNo
        CustomerData1.Owner_Email = OEmail
        CustomerData1.Owner_Previous_Occupant = OPreviousOccupant
        CustomerData1.Owner_Account_Number = OAccountNumber
        CustomerData1.Owner_Meter_Number = OmeterNumber

        CustomerData1.Office_Account_Number = OffAccountNumber
        CustomerData1.Office_Meter_No = OffMeterNo
        CustomerData1.Office_Meter_Make = OffMeterMake
        CustomerData1.Office_Last_Bill_Amount = OffLastBillAmt
        CustomerData1.Office_Total_Outstanding = OffTotalOuts

        CustomerData1.Office_Total_Installed_Load = OffTotalInstalledLoad
        CustomerData1.Office_Pole_Available = OffPoleAvailable
        CustomerData1.Office_Pole_Type = OffPoleType
        CustomerData1.Office_Pole_Condition = OffPoleCondition
        CustomerData1.Office_Service_Line = OffServiceLine
        CustomerData1.Office_Line_Wire_Condition = OffLineWireCondition
        CustomerData1.Office_Estimated_Load_Applied = OffEstimateLoadApplied
        CustomerData1.Office_Requested_Voltage_Type = OffRequestedVoltageType
        CustomerData1.Office_Type_Of_Meter = OffTypeOfMeter

        CardNo = CheckAndGenerateCardId()
        CustomerData1.Card_No = CardNo

        db.CustomerDatas.Add(CustomerData1)
        db.SaveChanges()
        If db.SaveChanges = True Then
            User_Details.Show()
            Me.Close()

        End If

    End Sub
    Public Function GenerateCardId(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function

    Public Function CheckAndGenerateCardId() As String
        Dim cs As New CustomerData
        Dim CardNo = GenerateCardId(10, True)

        Dim query = From s In db.CustomerDatas
                    Where s.Card_No = CardNo

        Dim cardList = query.ToList
        If cardList.Count > 0 Then CheckAndGenerateCardId()

        Return CardNo
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrationPart3.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainView.Show()
        Me.Close()

    End Sub
End Class