Imports ToggleButton_Demo
Public Class Switcher
    Dim checkformload As Boolean = False
    Private Sub Switcher_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            checkformload = False
            Using db As New administrationEntities3

                For i = 1 To 5
                    Dim Mylbl As Label = CType(Me.Controls("Label" & i), Label)

                    Dim mytoggle As ToggleButton = CType(Me.Controls("ToggleButton" & i), ToggleButton)

                    Dim query = From s In db.CustomerDatas
                                Where s.Area = Mylbl.Text
                                Select s

                    If query.Count <> 0 Then

                        If query.First.Area_State = False Then
                            mytoggle.ToggleState = ToggleButton.ToggleButtonState.ON
                        ElseIf query.First.Area_State = True Then
                            mytoggle.ToggleState = ToggleButton.ToggleButtonState.OFF

                        End If
                    End If

10:             Next

                checkformload = True
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub

    Private Sub ToggleButton1_ButtonStateChanged(sender As Object, e As ToggleButton_Demo.ToggleButton.ToggleButtonStateEventArgs) Handles ToggleButton1.ButtonStateChanged
        If checkformload = True Then
            If checkformload = True Then
                Using db As New administrationEntities3
                    Dim query = From s In db.CustomerDatas
                                Where s.Area = Label1.Text
                                Select s

                    If ToggleButton1.ToggleState = ToggleButton.ToggleButtonState.ON Then
                        For Each cust In query
                            cust.Area_State = True
                            cust.Area_State_End_Time = Date.Today
                            cust.Area_Time_Diff = cust.Area_Time_Diff + DateDiff(DateInterval.Day, cust.Area_State_Start_Time.Value, cust.Area_State_End_Time.Value)
                        Next
                        db.SaveChanges()
                    Else
                        For Each cust In query
                            cust.Area_State = False
                            cust.Area_State_Start_Time = Date.Today
                        Next
                        db.SaveChanges()
                    End If
                End Using

            End If
        End If

    End Sub
    Private Sub ToggleButton2_ButtonStateChanged(sender As Object, e As ToggleButton_Demo.ToggleButton.ToggleButtonStateEventArgs) Handles ToggleButton2.ButtonStateChanged
        If checkformload = True Then
            If checkformload = True Then
                Using db As New administrationEntities3
                    Dim query = From s In db.CustomerDatas
                                Where s.Area = Label2.Text
                                Select s

                    If ToggleButton2.ToggleState = ToggleButton.ToggleButtonState.ON Then
                        For Each cust In query
                            cust.Area_State = True
                            cust.Area_State_End_Time = Date.Today
                            cust.Area_Time_Diff = cust.Area_Time_Diff + DateDiff(DateInterval.Day, cust.Area_State_Start_Time.Value, cust.Area_State_End_Time.Value)
                        Next
                        db.SaveChanges()
                    Else
                        For Each cust In query
                            cust.Area_State = False
                            cust.Area_State_Start_Time = Date.Today
                        Next
                        db.SaveChanges()
                    End If
                End Using

            End If
        End If
    End Sub
    Private Sub ToggleButton3_ButtonStateChanged(sender As Object, e As ToggleButton_Demo.ToggleButton.ToggleButtonStateEventArgs) Handles ToggleButton3.ButtonStateChanged
        If checkformload = True Then
            If checkformload = True Then
                Using db As New administrationEntities3
                    Dim query = From s In db.CustomerDatas
                                Where s.Area = Label3.Text
                                Select s

                    If ToggleButton3.ToggleState = ToggleButton.ToggleButtonState.ON Then
                        For Each cust In query
                            cust.Area_State = True
                            cust.Area_State_End_Time = Date.Today
                            cust.Area_Time_Diff = cust.Area_Time_Diff + DateDiff(DateInterval.Day, cust.Area_State_Start_Time.Value, cust.Area_State_End_Time.Value)
                        Next
                        db.SaveChanges()
                    Else
                        For Each cust In query
                            cust.Area_State = False
                            cust.Area_State_Start_Time = Date.Today
                        Next
                        db.SaveChanges()
                    End If
                End Using

            End If
        End If
    End Sub

    Private Sub ToggleButton4_ButtonStateChanged(sender As Object, e As ToggleButton_Demo.ToggleButton.ToggleButtonStateEventArgs) Handles ToggleButton4.ButtonStateChanged
        If checkformload = True Then
            Using db As New administrationEntities3
                Dim query = From s In db.CustomerDatas
                            Where s.Area = Label4.Text
                            Select s

                If ToggleButton4.ToggleState = ToggleButton.ToggleButtonState.ON Then
                    For Each cust In query
                        cust.Area_State = True
                        cust.Area_State_End_Time = Date.Today
                        cust.Area_Time_Diff = cust.Area_Time_Diff + DateDiff(DateInterval.Day, cust.Area_State_Start_Time.Value, cust.Area_State_End_Time.Value)
                    Next
                    db.SaveChanges()
                Else
                    For Each cust In query
                        cust.Area_State = False
                        cust.Area_State_Start_Time = Date.Today
                    Next
                    db.SaveChanges()
                End If
            End Using

        End If
    End Sub

    Private Sub ToggleButton5_ButtonStateChanged(sender As Object, e As ToggleButton_Demo.ToggleButton.ToggleButtonStateEventArgs) Handles ToggleButton5.ButtonStateChanged
        If checkformload = True Then
            Using db As New administrationEntities3
                Dim query = From s In db.CustomerDatas
                            Where s.Area = Label5.Text
                            Select s

                If ToggleButton5.ToggleState = ToggleButton.ToggleButtonState.ON Then
                    For Each cust In query
                        cust.Area_State = True
                        cust.Area_State_End_Time = Date.Today
                        cust.Area_Time_Diff = cust.Area_Time_Diff + DateDiff(DateInterval.Day, cust.Area_State_Start_Time.Value, cust.Area_State_End_Time.Value)
                    Next
                    db.SaveChanges()
                Else
                    For Each cust In query
                        cust.Area_State = False
                        cust.Area_State_Start_Time = Date.Today
                    Next
                    db.SaveChanges()
                End If
            End Using

        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        mainView.Show()
    End Sub
End Class