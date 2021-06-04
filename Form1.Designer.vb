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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date1label = New System.Windows.Forms.Label()
        Me.date2label = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BtnCalculateAge = New System.Windows.Forms.Button()
        Me.dateOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-206, -51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'date1label
        '
        Me.date1label.AutoSize = True
        Me.date1label.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.date1label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.date1label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date1label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.date1label.Location = New System.Drawing.Point(52, 84)
        Me.date1label.Name = "date1label"
        Me.date1label.Padding = New System.Windows.Forms.Padding(10)
        Me.date1label.Size = New System.Drawing.Size(94, 35)
        Me.date1label.TabIndex = 1
        Me.date1label.Text = "Enter DOB : "
        Me.date1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date2label
        '
        Me.date2label.AutoSize = True
        Me.date2label.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.date2label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.date2label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date2label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.date2label.Location = New System.Drawing.Point(52, 141)
        Me.date2label.Name = "date2label"
        Me.date2label.Padding = New System.Windows.Forms.Padding(10)
        Me.date2label.Size = New System.Drawing.Size(144, 35)
        Me.date2label.TabIndex = 2
        Me.date2label.Text = "Enter  Date to Know : "
        Me.date2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker1.Location = New System.Drawing.Point(241, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 23)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(241, 145)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(135, 23)
        Me.DateTimePicker2.TabIndex = 4
        '
        'BtnCalculateAge
        '
        Me.BtnCalculateAge.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCalculateAge.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCalculateAge.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCalculateAge.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.BtnCalculateAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCalculateAge.Location = New System.Drawing.Point(154, 204)
        Me.BtnCalculateAge.Name = "BtnCalculateAge"
        Me.BtnCalculateAge.Size = New System.Drawing.Size(146, 30)
        Me.BtnCalculateAge.TabIndex = 5
        Me.BtnCalculateAge.Text = "Calculate Age"
        Me.BtnCalculateAge.UseVisualStyleBackColor = False
        '
        'dateOutput
        '
        Me.dateOutput.AutoSize = True
        Me.dateOutput.Location = New System.Drawing.Point(52, 247)
        Me.dateOutput.Name = "dateOutput"
        Me.dateOutput.Size = New System.Drawing.Size(0, 15)
        Me.dateOutput.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.agecalculator.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 326)
        Me.Controls.Add(Me.dateOutput)
        Me.Controls.Add(Me.BtnCalculateAge)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.date2label)
        Me.Controls.Add(Me.date1label)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 365)
        Me.MinimumSize = New System.Drawing.Size(440, 365)
        Me.Name = "Form1"
        Me.Text = "Age Calculator "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents date1label As Label
    Friend WithEvents date2label As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents BtnCalculateAge As Button
    Friend WithEvents dateOutput As Label
End Class
