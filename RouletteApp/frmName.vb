Public Class frmName

    ' This form prompts the user to enter their name and optionally set and image (default is the blank user 
    ' image from Windows 10, fitting With the pseudo Modern UI/Windows 8 design scheme) and then advance to 
    ' the game

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ' Allows the player to select an image to be shown in game
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose an Image (Recommended Size 128x128)"
        fdlg.InitialDirectory = "%userdir%\pictures"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        ' Shows selected image in pbxUser once player confirms an image
        If fdlg.ShowDialog() = DialogResult.OK Then
            pbxUser.Image = Image.FromFile(fdlg.FileName)
        End If
    End Sub


    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        ' Check to prevent the user from entering a blank name, displays error message if none is present
        If txtName.Text = "" Then
            MsgBox("Please enter your name before continuing.")
        Else
            ' Advances to main menu
            frmWelcome.Show()
            Me.Close()
        End If
    End Sub
End Class