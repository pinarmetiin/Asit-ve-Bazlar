Public Class Form3
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If TrackBar1.Value = 2 Then


        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        If TrackBar1.Value = 3 Then

        End If
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs)



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 10
        Timer1.Stop()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.Value = ProgressBar1.Value + 5


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 35
        Timer1.Stop()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 28
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 5
        Timer1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        Timer1.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 90
        Timer1.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 80
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 56

        Timer1.Stop()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 90
        Timer1.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 100
        Timer1.Stop()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://learningapps.org/display?v=prbayaqkj21")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://learningapps.org/display?v=py5oewdtn21")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form5.Show()
    End Sub
End Class