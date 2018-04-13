Imports System.Data.SqlClient
Public Class mainView
    Dim _mousedown As Boolean
    Dim startpt As Point
    Public foorm As New Form


    Private Sub mainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdministrationDataSet.Table' table. You can move, or remove it, as needed.
        ' Me.TableTableAdapter.Fill(Me.AdministrationDataSet.Table)

    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Buy_Units.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Check_Alerts.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        RegistrationPart1.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        New_Admin.Show()
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Project", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) Handles picMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            picMax.Image = My.Resources.retoredown
        Else
            WindowState = FormWindowState.Normal
            picMax.Image = My.Resources.mazimize
        End If
    End Sub

    Private Sub picMax_MouseHover(sender As Object, e As EventArgs) Handles picMax.MouseHover
        picMax.BackColor = Color.DarkTurquoise
    End Sub

    Private Sub picMax_MouseLeave(sender As Object, e As EventArgs) Handles picMax.MouseLeave
        picMax.BackColor = Color.Turquoise
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles picMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMin_MouseHover(sender As Object, e As EventArgs) Handles picMin.MouseHover
        picMin.BackColor = Color.DarkTurquoise
    End Sub

    Private Sub picMin_MouseLeave(sender As Object, e As EventArgs) Handles picMin.MouseLeave
        picMin.BackColor = Color.Turquoise
    End Sub

    Private Sub PicClose_MouseHover(sender As Object, e As EventArgs) Handles PicClose.MouseHover
        PicClose.BackColor = Color.DarkRed
    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs) Handles PicClose.MouseLeave
        PicClose.BackColor = Color.Red
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        _mousedown = True
        startpt = e.Location
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If _mousedown = True Then
            Dim currpos As Point = PointToScreen(e.Location)
            Location = New Point(currpos.X - startpt.X, currpos.Y - startpt.Y)
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        _mousedown = False
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Switcher.ShowDialog()
    End Sub
End Class