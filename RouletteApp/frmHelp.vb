Public Class frmHelp
    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        ' Closes this window and returns to game window
        Me.Close()
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblHome.BackColor = Color.Black
        lblHome.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "Choose an option from the side"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub

    Private Sub lblGameScrn_Click(sender As Object, e As EventArgs) Handles lblGameScrn.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblGameScrn.BackColor = Color.Black
        lblGameScrn.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "The game screen is the window you see when you play the game. In it is everything you need to play the game."
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub

    Private Sub lblPlaying_Click(sender As Object, e As EventArgs) Handles lblPlaying.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblPlaying.BackColor = Color.Black
        lblPlaying.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "Roulette is played by placing bets on numbers or groups of numbers that may be rolled. Players win if the number they bet appears and lose if the number does not."
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub

    Private Sub lblBetTypes_Click(sender As Object, e As EventArgs) Handles lblBetTypes.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblBetTypes.BackColor = Color.Black
        lblBetTypes.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "In Roulette, players can choose from numerous bet types, which are as follows (with their odds)
-	Red/Black, Odd/Even - 1:1
-	High (19-36) or Low (1-18) - 1:1
-	Dozen – (1-12), (13-24) or (25-36) - 2:1
-	Column - 2:1
-	Group of six numbers - 5:1
-	Group of four numbers - 8:1
-	Group of three numbers - 11:1
-	Group of two numbers - 17:1
-	A single number - 35:1
-	If a zero is spun the house collects all bets.
"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub

    Private Sub lblMessageLog_Click(sender As Object, e As EventArgs) Handles lblMessageLog.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblMessageLog.BackColor = Color.Black
        lblMessageLog.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "The message log provides instructions at certain stages (selecting a group modifier) and details on your wins and losses. If you are unsure what to do, look at that."
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.messages)
    End Sub

    Private Sub lblPlacingBet_Click(sender As Object, e As EventArgs) Handles lblPlacingBet.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblPlacingBet.BackColor = Color.Black
        lblPlacingBet.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "You can place a bet by typing your amount into the text box and selecting your number(s) then clicking Place Bet. Keep in mind that your bet amount must be a multiple of 5, $100 or less and is under the amount in your balance"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub

    Private Sub lblSelecting_Click(sender As Object, e As EventArgs) Handles lblSelecting.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblSelecting.BackColor = Color.Black
        lblSelecting.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "You can select a number by clicking on it's box on the board. Deselecting is done by clicking it again."
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources._select)
    End Sub

    Private Sub lblBatch_Click(sender As Object, e As EventArgs) Handles lblBatch.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblBatch.BackColor = Color.Black
        lblBatch.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "Selecting one of the batch options will select all the necessary numbers for you. Deselecting is done by clicking your option again"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources._select)
    End Sub

    Private Sub lblGroups2_Click(sender As Object, e As EventArgs) Handles lblGroups2.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblGroups2.BackColor = Color.Black
        lblGroups2.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "Selecting a group of 2 is done differently. After clicking the button, you then make a choice on your first number. By clicking this number, you are presented with all your available options for that number, which you can then click on to complete the duo. Deselection is done by clicking on either number or the Group 2 button"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.group2)
    End Sub

    Private Sub lblGroups1_Click(sender As Object, e As EventArgs) Handles lblGroups1.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblGroups1.BackColor = Color.Black
        lblGroups1.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "When selecting a group of 6, 4 or 3, after selecting the modifier button you then click the first number of the group, and then the rest of the group will be selected. Deselection is done by clicking the first number or the modifier button"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.group6)
    End Sub

    Private Sub lblBankrupt_Click(sender As Object, e As EventArgs) Handles lblBankrupt.Click
        ' Clears all formatting changes on labels
        Clear()
        ' Changes the colour of the label and text so it looks to be selected
        lblBankrupt.BackColor = Color.Black
        lblBankrupt.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "When you run out of money, a message box pops up to inform you of this. You will then no longer be able to place any bets. You may quit the game at this point"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.lose)
    End Sub

    Private Sub Clear()
        ' Reverts labels back to default
        lblHome.BackColor = Color.Transparent
        lblGameScrn.BackColor = Color.Transparent
        lblPlaying.BackColor = Color.Transparent
        lblBetTypes.BackColor = Color.Transparent
        lblMessageLog.BackColor = Color.Transparent
        lblPlacingBet.BackColor = Color.Transparent
        lblSelecting.BackColor = Color.Transparent
        lblBatch.BackColor = Color.Transparent
        lblGroups1.BackColor = Color.Transparent
        lblGroups2.BackColor = Color.Transparent
        lblBankrupt.BackColor = Color.Transparent
        lblHome.ForeColor = Color.Black
        lblGameScrn.ForeColor = Color.Black
        lblPlaying.ForeColor = Color.Black
        lblBetTypes.ForeColor = Color.Black
        lblMessageLog.ForeColor = Color.Black
        lblPlacingBet.ForeColor = Color.Black
        lblSelecting.ForeColor = Color.Black
        lblBatch.ForeColor = Color.Black
        lblGroups1.ForeColor = Color.Black
        lblGroups2.ForeColor = Color.Black
        lblBankrupt.ForeColor = Color.Black
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Changes the colour of the label and text so it looks to be selected
        lblHome.BackColor = Color.Black
        lblHome.ForeColor = Color.White
        ' Changes help text dependent on selected choice
        lblHelpText.Text = "Choose an option from the side"
        ' Changes picture box image to appropriate image
        pbxHelp.Image = New Bitmap(My.Resources.main_window)
    End Sub
End Class