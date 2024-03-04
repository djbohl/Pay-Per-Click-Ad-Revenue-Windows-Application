<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        avgCost = New TextBox()
        inputWeek1 = New TextBox()
        inputWeek2 = New TextBox()
        inputWeek3 = New TextBox()
        inputWeek4 = New TextBox()
        revWeek4 = New TextBox()
        revWeek3 = New TextBox()
        revWeek2 = New TextBox()
        revWeek1 = New TextBox()
        btnCalculate = New Button()
        Panel1 = New Panel()
        btnClear = New Button()
        btnClose = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Tahoma", 10.875F)
        Label1.Location = New Point(138, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(739, 74)
        Label1.TabIndex = 0
        Label1.Text = "This application calculates the amount of advertising revenue paid to a Web site that displays links to a selected vendor."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 10.875F)
        Label2.Location = New Point(148, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 35)
        Label2.TabIndex = 1
        Label2.Text = "Advertising cost per week:"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Tahoma", 10.875F)
        Label3.Location = New Point(148, 369)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 115)
        Label3.TabIndex = 2
        Label3.Text = "Number of Ad Clicks during the past 4 weekly periods"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(711, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 33)
        Label4.TabIndex = 3
        Label4.Text = "Revenue"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F)
        Label5.Location = New Point(421, 373)
        Label5.Name = "Label5"
        Label5.Size = New Size(26, 29)
        Label5.TabIndex = 4
        Label5.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F)
        Label6.Location = New Point(421, 432)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 29)
        Label6.TabIndex = 5
        Label6.Text = "2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F)
        Label7.Location = New Point(421, 495)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 29)
        Label7.TabIndex = 6
        Label7.Text = "3"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9F)
        Label8.Location = New Point(421, 558)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 29)
        Label8.TabIndex = 7
        Label8.Text = "4"
        ' 
        ' avgCost
        ' 
        avgCost.BorderStyle = BorderStyle.FixedSingle
        avgCost.Location = New Point(497, 181)
        avgCost.Name = "avgCost"
        avgCost.Size = New Size(200, 39)
        avgCost.TabIndex = 8
        ' 
        ' inputWeek1
        ' 
        inputWeek1.BorderStyle = BorderStyle.FixedSingle
        inputWeek1.Location = New Point(454, 369)
        inputWeek1.Name = "inputWeek1"
        inputWeek1.Size = New Size(200, 39)
        inputWeek1.TabIndex = 9
        ' 
        ' inputWeek2
        ' 
        inputWeek2.BorderStyle = BorderStyle.FixedSingle
        inputWeek2.Location = New Point(454, 432)
        inputWeek2.Name = "inputWeek2"
        inputWeek2.Size = New Size(200, 39)
        inputWeek2.TabIndex = 10
        ' 
        ' inputWeek3
        ' 
        inputWeek3.BorderStyle = BorderStyle.FixedSingle
        inputWeek3.Location = New Point(454, 495)
        inputWeek3.Name = "inputWeek3"
        inputWeek3.Size = New Size(200, 39)
        inputWeek3.TabIndex = 11
        ' 
        ' inputWeek4
        ' 
        inputWeek4.BorderStyle = BorderStyle.FixedSingle
        inputWeek4.Location = New Point(454, 558)
        inputWeek4.Name = "inputWeek4"
        inputWeek4.Size = New Size(200, 39)
        inputWeek4.TabIndex = 12
        ' 
        ' revWeek4
        ' 
        revWeek4.BackColor = SystemColors.InactiveCaption
        revWeek4.BorderStyle = BorderStyle.None
        revWeek4.Location = New Point(677, 558)
        revWeek4.Name = "revWeek4"
        revWeek4.Size = New Size(200, 32)
        revWeek4.TabIndex = 16
        ' 
        ' revWeek3
        ' 
        revWeek3.BackColor = SystemColors.InactiveCaption
        revWeek3.BorderStyle = BorderStyle.None
        revWeek3.Location = New Point(677, 495)
        revWeek3.Name = "revWeek3"
        revWeek3.Size = New Size(200, 32)
        revWeek3.TabIndex = 15
        ' 
        ' revWeek2
        ' 
        revWeek2.BackColor = SystemColors.InactiveCaption
        revWeek2.BorderStyle = BorderStyle.None
        revWeek2.Location = New Point(677, 432)
        revWeek2.Name = "revWeek2"
        revWeek2.Size = New Size(200, 32)
        revWeek2.TabIndex = 14
        ' 
        ' revWeek1
        ' 
        revWeek1.BackColor = SystemColors.InactiveCaption
        revWeek1.BorderStyle = BorderStyle.None
        revWeek1.Location = New Point(677, 369)
        revWeek1.Name = "revWeek1"
        revWeek1.Size = New Size(200, 32)
        revWeek1.TabIndex = 13
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnCalculate.Location = New Point(148, 693)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(195, 56)
        btnCalculate.TabIndex = 17
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Location = New Point(138, 287)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 21)
        Panel1.TabIndex = 20
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnClear.Location = New Point(415, 693)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(195, 56)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnClose.Location = New Point(682, 693)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(195, 56)
        btnClose.TabIndex = 22
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(152, 614)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(725, 60)
        lblStatus.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1033, 807)
        Controls.Add(lblStatus)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(Panel1)
        Controls.Add(btnCalculate)
        Controls.Add(revWeek4)
        Controls.Add(revWeek3)
        Controls.Add(revWeek2)
        Controls.Add(revWeek1)
        Controls.Add(inputWeek4)
        Controls.Add(inputWeek3)
        Controls.Add(inputWeek2)
        Controls.Add(inputWeek1)
        Controls.Add(avgCost)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pay per click ad revenue"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents avgCost As TextBox
    Friend WithEvents inputWeek1 As TextBox
    Friend WithEvents inputWeek2 As TextBox
    Friend WithEvents inputWeek3 As TextBox
    Friend WithEvents inputWeek4 As TextBox
    Friend WithEvents revWeek4 As TextBox
    Friend WithEvents revWeek3 As TextBox
    Friend WithEvents revWeek2 As TextBox
    Friend WithEvents revWeek1 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblStatus As Label

End Class
