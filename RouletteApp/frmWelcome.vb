Public Class frmWelcome

    ' This form is the welcome screen, giving the player the option to either play the game or exit.

    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Welcomes the user with the name they previously input
        lblMessage.Text = "Welcome, " & frmName.txtName.Text
        ' Assigns the users name and image to the lower right of the window
        lblUser.Text = frmName.txtName.Text
        pbxUser.Image = frmName.pbxUser.Image
    End Sub

    Private Sub pbxPlay_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxPlay.MouseHover
        ' Darkens the Play button while a mouse is hovering over it
        pbxPlay.Image = New Bitmap(My.Resources.play2)
    End Sub

    Private Sub pbxPlay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxPlay.MouseLeave
        ' Lightens the Play button after the mouse leaves it's area
        pbxPlay.Image = New Bitmap(My.Resources.play1)
    End Sub

    Private Sub pbxPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPlay.Click
        ' Continues to frmGame, where the player can play the game
        frmGame.Show()
        Me.Close()
    End Sub

    Private Sub pbxExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxExit.MouseHover
        ' Darkens the Exit button while a mouse is hovering over it
        pbxExit.Image = New Bitmap(My.Resources.exit2)
    End Sub

    Private Sub pbxExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxExit.MouseLeave
        ' Lightens the Exit button after the mouse leaves it's area
        pbxExit.Image = New Bitmap(My.Resources.exit1)
    End Sub

    Private Sub pbxExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxExit.Click
        ' Exits the game and terminates the process
        End
    End Sub

End Class
