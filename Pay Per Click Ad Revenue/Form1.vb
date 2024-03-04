Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' cost per week / numofclicks = cost per click
        Dim blnInputOk As Boolean = True
        Dim blnInputOk1 As Boolean = True
        Dim blnInputOk2 As Boolean = True
        Dim blnInputOk3 As Boolean = True
        Dim blnInputOk4 As Boolean = True
        Dim blnInputEmpty1 As Boolean = True
        Dim blnInputEmpty2 As Boolean = True
        Dim blnInputEmpty3 As Boolean = True
        Dim blnInputEmpty4 As Boolean = True
        Dim intCost As Integer ' Cost per week
        Dim intWeek1 As Integer ' Week one clicks
        Dim intWeek2 As Integer ' Week two clicks
        Dim intWeek3 As Integer ' Week three clicks
        Dim intWeek4 As Integer ' Week four clicks
        Dim decRev1 As Decimal ' Week 1 revenue
        Dim decRev2 As Decimal ' Week 2 revenue
        Dim decRev3 As Decimal ' Week 3 revenue
        Dim decRev4 As Decimal ' Week 4 revenue

        lblStatus.Text = String.Empty
        ' Validate and convert weekly cost
        If Integer.TryParse(avgCost.Text, intCost) = False Then
            lblStatus.Text = "Months must be an integer."
            blnInputOk = False
        End If

        ' Validate and convert week 1 clicks
        If String.IsNullOrEmpty(inputWeek1.Text) = True Then
            blnInputEmpty1 = True
        ElseIf String.IsNullOrEmpty(inputWeek1.Text) = False Then
            blnInputEmpty1 = False
            If Integer.TryParse(inputWeek1.Text, intWeek1) = False Then
                lblStatus.Text = "Clicks must be an integer."
                blnInputOk1 = False
            End If
        End If

        ' Validate and convert week 2 clicks
        If String.IsNullOrEmpty(inputWeek2.Text) = True Then
            blnInputEmpty2 = True
        ElseIf String.IsNullOrEmpty(inputWeek2.Text) = False Then
            blnInputEmpty2 = False
            If Integer.TryParse(inputWeek2.Text, intWeek2) = False Then
                lblStatus.Text = "Clicks must be an integer."
                blnInputOk2 = False
            End If
        End If

        ' Validate and convert week 3 clicks
        If String.IsNullOrEmpty(inputWeek3.Text) = True Then
            blnInputEmpty3 = True
        ElseIf String.IsNullOrEmpty(inputWeek3.Text) = False Then
            blnInputEmpty3 = False
            If Integer.TryParse(inputWeek3.Text, intWeek3) = False Then
                lblStatus.Text = "Clicks must be an integer."
                blnInputOk3 = False
            End If
        End If

        ' Validate and convert week 4 clicks
        If String.IsNullOrEmpty(inputWeek4.Text) = True Then
            blnInputEmpty4 = True
        ElseIf String.IsNullOrEmpty(inputWeek4.Text) = False Then
            blnInputEmpty4 = False
            If Integer.TryParse(inputWeek4.Text, intWeek4) = False Then
                lblStatus.Text = "Clicks must be an integer."
                blnInputOk4 = False
            End If
        End If

        ' Calculate each week that contains a value
        If blnInputOk = True Then
            ' Determine Week 1 cost per click
            If blnInputEmpty1 = True Then
                decRev1 = 0
            ElseIf blnInputEmpty1 = False Then
                If blnInputOk1 = True Then
                    decRev1 = intCost / intWeek1
                ElseIf blnInputOk1 = False Then
                    lblStatus.Text = "Clicks must be an integer."
                End If
            End If

            ' Determine Week 2 cost per click
            If blnInputEmpty2 = True Then
                decRev2 = 0
            ElseIf blnInputEmpty2 = False Then
                If blnInputOk2 = True Then
                    decRev2 = intCost / intWeek2
                ElseIf blnInputOk2 = False Then
                    lblStatus.Text = "Clicks must be an integer."
                End If
            End If

                ' Determine Week 3 cost per click
                If blnInputEmpty3 = True Then
                decRev3 = 0
            ElseIf blnInputEmpty3 = False Then
                If blnInputOk3 = True Then
                    decRev3 = intCost / intWeek3
                ElseIf blnInputOk3 = False Then
                    lblStatus.Text = "Clicks must be an integer."
                End If
            End If

            ' Determine Week 4 cost per click
            If blnInputEmpty4 = True Then
                decRev4 = 0
            ElseIf blnInputEmpty4 = False Then
                If blnInputOk4 = True Then
                    decRev4 = intCost / intWeek4
                ElseIf blnInputOk4 = False Then
                    lblStatus.Text = "Clicks must be an integer."
                End If
            End If

            ' Display revenue
            revWeek1.Text = decRev1.ToString("c")
            revWeek2.Text = decRev2.ToString("c")
            revWeek3.Text = decRev3.ToString("c")
            revWeek4.Text = decRev4.ToString("c")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        revWeek1.Text = String.Empty
        revWeek2.Text = String.Empty
        revWeek3.Text = String.Empty
        revWeek4.Text = String.Empty
        inputWeek1.Text = String.Empty
        inputWeek2.Text = String.Empty
        inputWeek3.Text = String.Empty
        inputWeek4.Text = String.Empty
        avgCost.Text = String.Empty
        lblStatus.Text = String.Empty
    End Sub
End Class
