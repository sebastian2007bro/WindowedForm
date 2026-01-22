Public Class WindowController
    Public Sub StartTimer()

        'Dim jj As New Form
        'Dim kk1 As New Button
        'Dim kk2 As New Button

        'jj.Controls.Add(kk1)
        'jj.Controls.Add(kk2)

        'kk1.BringToFront()
        'kk2.BringToFront()

        'kk1.Location = New Point(1, 1)
        'kk1.Location = New Point(1, 10)

        'AddHandler kk1.Click, Sub()
        '                          WindowedFormTimer.Start()
        '                      End Sub

        'AddHandler kk2.Click, Sub()
        '                          WindowedFormTimer.Stop()
        '                      End Sub

        'jj.Show()

        WindowedFormTimer.Interval = 100
        WindowedFormTimer.Enabled = True
        AddHandler WindowedFormTimer.Tick, AddressOf WindowedFormTimer_Tick
    End Sub

    Public WindowedFormTimer As New Timer

    Public Sub WindowedFormTimer_Tick(sender As Object, e As EventArgs)
        If MainClass.Form1.currentForm IsNot Nothing Then
            If MainClass.Form1.currentForm.FormBorderStyle = FormBorderStyle.None Then
                MainClass.Form1.currentForm.FormBorderStyle = FormBorderStyle.Sizable
            End If
            If MainClass.Form1.currentForm.Dock = DockStyle.Fill Then
                MainClass.Form1.currentForm.Dock = DockStyle.None
            End If
        End If


    End Sub
End Class