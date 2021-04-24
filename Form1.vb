Public Class Form1

    Dim date1, date2 As Date
    Dim dateSpan As TimeSpan
    Dim difference As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalculateAge_Click(sender As Object, e As EventArgs) Handles BtnCalculateAge.Click
        date1 = Me.DateTimePicker1.Value.ToShortDateString
        date2 = Me.DateTimePicker2.Value.ToShortDateString
        dateSpan = date2 - date1
        difference = dateSpan.Days
        Me.dateOutput.Text = (" Your age  : " + Str(Int(difference / 365)) + " Years ")
        difference = difference Mod 365
        Me.dateOutput.Text = Me.dateOutput.Text + (Str(Int(difference / 30)) + " Months ")
        difference = difference Mod 30
        Me.dateOutput.Text = Me.dateOutput.Text + (Str(difference) + " Days ")
    End Sub

End Class