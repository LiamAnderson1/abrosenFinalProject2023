Public Class Form1
    Dim dx As Integer
    Dim dy As Integer
    Dim laps As Integer
    Dim CantTouchFinish As Boolean

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            PBCar.Image = My.Resources.carRIGHT
            dx = 5
            dy = 0
        ElseIf e.KeyCode = Keys.Left Then
            PBCar.Image = My.Resources.carLEFT
            dx = -5
            dy = 0
        ElseIf e.KeyCode = Keys.Up Then
            PBCar.Image = My.Resources.carUP
            dx = 0
            dy = -5
        ElseIf e.KeyCode = Keys.Down Then
            PBCar.Image = My.Resources.carDOWN
            dx = 0
            dy = 5

        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As ToolStripItemClickedEventArgs) Handles StartToolStripMenuItem.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs, msgBox As Integer) Handles Timer1.Tick
        Label1.Text = (Label1.Text + 1) / 60
        PBCar.Left = PBCar.Left + dx
        PBCar.Top = PBCar.Top + dy

        'Collisions
        If PBCar.Bounds.IntersectsWith(PB1Grass.Bounds) Or
           PBCar.Bounds.IntersectsWith(PictureBox1.Bounds) Or
           PBCar.Bounds.IntersectsWith(PictureBox2.Bounds) Or
           PBCar.Bounds.IntersectsWith(PictureBox3.Bounds) Or
           PBCar.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            Timer1.Enabled = False
            Application.Restart()
        End If


        'Dim choice As Integer
        'choice = MsgBox("You crashed. Would you like to start again?", MsgBoxStyle, vbYesNo)
        'If choice = vbYes Then
        'Application.Restart()
        'Else

        'End If
        'End If

        If PBCar.Bounds.IntersectsWith(LBHalf.Bounds) Then
            CantTouchFinish = True

        End If

        If PBCar.Bounds.IntersectsWith(PBFin.Bounds) And
                CantTouchFinish = True Then
            CantTouchFinish = False
            laps = laps + 1
            If laps = 2 Then
                Timer1.Enabled = False

                Dim choice As Integer
                choice = msgBox("You crashed. Would you like to start again?", MsgBoxStyle, vbYesNo)
                If choice = vbYes Then
                    Application.Restart()
                Else

                End If
            End If
        End If
    End Sub

    Private Function MsgBox(v As String, msgBoxStyle As MsgBoxStyle, vbYesNo As MsgBoxStyle) As Integer
        Throw New NotImplementedException()
    End Function

    Private ReadOnly Property MsgBox(v As String, msgBoxStyle As MsgBoxStyle, vbYesNo As MsgBoxStyle) As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class