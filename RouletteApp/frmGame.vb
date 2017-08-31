Public Class frmGame
    ' The players current account balance is written to this integer
    Dim Balance As Integer

    ' Integer added for testing purposes to ensure that the right amount of numbers were selected. 
    ' Used as a trigger for Disable()
    Dim Selected As Integer

    ' Integers that allow the selection or deselection of numbers and buttons to occur
    Dim No1Select As Integer
    Dim No2Select As Integer
    Dim No3Select As Integer
    Dim No4Select As Integer
    Dim No5Select As Integer
    Dim No6Select As Integer
    Dim No7Select As Integer
    Dim No8Select As Integer
    Dim No9Select As Integer
    Dim No10Select As Integer
    Dim No11Select As Integer
    Dim No12Select As Integer
    Dim No13Select As Integer
    Dim No14Select As Integer
    Dim No15Select As Integer
    Dim No16Select As Integer
    Dim No17Select As Integer
    Dim No18Select As Integer
    Dim No19Select As Integer
    Dim No20Select As Integer
    Dim No21Select As Integer
    Dim No22Select As Integer
    Dim No23Select As Integer
    Dim No24Select As Integer
    Dim No25Select As Integer
    Dim No26Select As Integer
    Dim No27Select As Integer
    Dim No28Select As Integer
    Dim No29Select As Integer
    Dim No30Select As Integer
    Dim No31Select As Integer
    Dim No32Select As Integer
    Dim No33Select As Integer
    Dim No34Select As Integer
    Dim No35Select As Integer
    Dim No36Select As Integer
    Dim BlackSelect As Integer
    Dim RedSelect As Integer
    Dim OddSelect As Integer
    Dim EvenSelect As Integer
    Dim Dozen1Select As Integer
    Dim Dozen2Select As Integer
    Dim Dozen3Select As Integer
    Dim Half1Select As Integer
    Dim Half2Select As Integer
    Dim Column1Select As Integer
    Dim Column2Select As Integer
    Dim Column3Select As Integer
    Dim Group6Select As Integer
    Dim Group4Select As Integer
    Dim Group3Select As Integer
    Dim Group2Select As Integer

    ' The amount won in a bet is written temporarily here 
    Dim Winnings As Integer

    ' The current odds are written here
    Dim Odds As Integer

    ' These integers are for randomised messages upon win or loss
    Dim WinMessage As Integer
    Dim LoseMessage As Integer


    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Imports image and name from frmWelcome
        pbxUser.Image = frmWelcome.pbxUser.Image
        lblUser.Text = frmWelcome.lblUser.Text

        ' Sets base balance to $500
        Balance = 500

        ' Writes the Balance to a label for the player to see
        lblBalance.Text = ("$" & Balance)

        ' Prints a message in the message area welcoming the player to the game and informs them of the help button
        lblMessages.Text = "Welcome " & lblUser.Text & ". If you require assistance, press the Help button."

        ' Current odds is 35:1 for a single number bet. This is the default state
        Odds = 35

    End Sub

    Private Sub txtBet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBet.KeyPress

        ' Limits input into the Bet textbox to only numbers using ASCII code
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        ' Shows the Insufficient Funds error if the player does not have enough money
        If Val(txtBet.Text) > Val(Balance) Then
            lblInsufficientFunds.Visible = True
            btnPlaceBet.Enabled = False

            ' If the bet isn't a factor of 5, display the corresponding error
        ElseIf Val(txtBet.Text) Mod 5 <> 0 Then
            lblFactor5.Visible = True
            btnPlaceBet.Enabled = False

            ' If the bet is over $100, display respective error
        ElseIf Val(txtBet.Text) > 100 Then
            lblOverLimit.Visible = True
            btnPlaceBet.Enabled = False

            ' Hides all errors and enables the Place Bet button if bet is legal
        Else
            btnPlaceBet.Enabled = True
            lblFactor5.Visible = False
            lblInsufficientFunds.Visible = False
            lblOverLimit.Visible = False
        End If

    End Sub

    Private Sub lblGroup6_Click(sender As Object, e As EventArgs) Handles lblGroup6.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Group6Select = 0 Then
            ' Changes the label's colour
            lblGroup6.BackColor = Color.Turquoise
            ' Marks the button as selected
            Group6Select = 1
            ' Sets the amount of selected numbers to 6
            Selected = Selected + 6
            ' Writes instructions to lblMessages
            lblMessages.Text = "Please select a number from the enabled options"
            ' Disables all buttons, then enables the buttons relevant to this selection
            Disable()
            lblGroup6.Enabled = True
            lblNo1.Enabled = True
            lblNo4.Enabled = True
            lblNo7.Enabled = True
            lblNo10.Enabled = True
            lblNo13.Enabled = True
            lblNo16.Enabled = True
            lblNo19.Enabled = True
            lblNo22.Enabled = True
            lblNo25.Enabled = True
            lblNo28.Enabled = True
            lblNo31.Enabled = True
            ' Sets the odds to 5:1
            Odds = 5
            ' Runs if the button is deselected
        ElseIf Group6Select = 1 Then
            ' Resets to default state for board
            Reset()
        End If
    End Sub

    Private Sub lblGroup4_Click(sender As Object, e As EventArgs) Handles lblGroup4.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Group4Select = 0 Then
            ' Sets the label's colour
            lblGroup4.BackColor = Color.Turquoise
            ' Marks the button as selected
            Group4Select = 1
            ' Records that 4 numbers are being selected
            Selected = Selected + 4
            ' Writes instructions to lblMessages
            lblMessages.Text = "Please select a number from the enabled options"
            ' Disables all buttons and enables ones relevant to this selection
            Disable()
            lblGroup4.Enabled = True
            lblNo1.Enabled = True
            lblNo2.Enabled = True
            lblNo4.Enabled = True
            lblNo5.Enabled = True
            lblNo7.Enabled = True
            lblNo8.Enabled = True
            lblNo10.Enabled = True
            lblNo11.Enabled = True
            lblNo13.Enabled = True
            lblNo14.Enabled = True
            lblNo16.Enabled = True
            lblNo17.Enabled = True
            lblNo19.Enabled = True
            lblNo20.Enabled = True
            lblNo22.Enabled = True
            lblNo23.Enabled = True
            lblNo25.Enabled = True
            lblNo26.Enabled = True
            lblNo28.Enabled = True
            lblNo29.Enabled = True
            lblNo31.Enabled = True
            lblNo32.Enabled = True
            ' Sets the odds to 8:1
            Odds = 8
            ' Code that runs if button is selected
        ElseIf Group4Select = 1 Then
            ' Resets game board
            Reset()
        End If
    End Sub

    Private Sub lblGroup3_Click(sender As Object, e As EventArgs) Handles lblGroup3.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Group3Select = 0 Then
            ' Changes the colour of the label
            lblGroup3.BackColor = Color.Turquoise
            ' Marks as selected
            Group3Select = 1
            ' Registers 3 numbers as selected
            Selected = Selected + 3
            ' Provides instructions in lblMessages
            lblMessages.Text = "Please select a number from the enabled options"
            ' Disables all buttons except ones relevant to selection
            Disable()
            lblGroup3.Enabled = True
            lblNo1.Enabled = True
            lblNo4.Enabled = True
            lblNo7.Enabled = True
            lblNo10.Enabled = True
            lblNo13.Enabled = True
            lblNo16.Enabled = True
            lblNo19.Enabled = True
            lblNo22.Enabled = True
            lblNo25.Enabled = True
            lblNo28.Enabled = True
            lblNo31.Enabled = True
            lblNo34.Enabled = True
            ' Changes odds to 11:1
            Odds = 11
            ' If selected
        ElseIf Group3Select = 1 Then
            ' Resets to default state
            Reset()
        End If
    End Sub

    Private Sub lblGroup2_Click(sender As Object, e As EventArgs) Handles lblGroup2.Click

        ' Runs when the button is not selected
        If Group2Select = 0 Then
            lblGroup2.BackColor = Color.Turquoise
            Group2Select = 1
            Selected = Selected + 2
            lblMessages.Text = "Please select your first number"
            lblGroup6.Enabled = 0
            lblGroup4.Enabled = 0
            lblGroup3.Enabled = 0
            lblHalf1.Enabled = 0
            lblHalf2.Enabled = 0
            lblOdd.Enabled = 0
            lblEven.Enabled = 0
            lblRed.Enabled = 0
            lblBlack.Enabled = 0
            lblDozen1.Enabled = 0
            lblDozen2.Enabled = 0
            lblDozen3.Enabled = 0
            lblColumn1.Enabled = 0
            lblColumn2.Enabled = 0
            lblColumn3.Enabled = 0
            Odds = 17
        ElseIf Group2Select = 1 Then
            Reset()
        End If
    End Sub

    ' The following code handles the selection and deselection of numbers. This includes if
    ' the Group modifiers are enabled. As No1 utilises all the code found in the next
    ' 36 Private Subs, it will be fully commented for reference use

    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click

        ' This code only runs when selecting a group of 6
        If Group6Select = 1 Then
            ' Code that runs if 1 isn't selected
            If No1Select = 0 Then
                ' Selects the group of 6
                No1Select = 1
                No2Select = 1
                No3Select = 1
                No4Select = 1
                No5Select = 1
                No6Select = 1
                ' Changes the colour of the group's labels
                lblNo1.BackColor = Color.LightSalmon
                lblNo2.BackColor = Color.DarkGray
                lblNo3.BackColor = Color.LightSalmon
                lblNo4.BackColor = Color.DarkGray
                lblNo5.BackColor = Color.LightSalmon
                lblNo6.BackColor = Color.DarkGray
                ' Disabling all other buttons
                lblNo4.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                ' If 1 is selected
            ElseIf No1Select = 1
                ' Deselects group
                No1Select = 0
                No2Select = 0
                No3Select = 0
                No4Select = 0
                No5Select = 0
                No6Select = 0
                ' Changes group's colours back to default
                lblNo1.BackColor = Color.Red
                lblNo2.BackColor = Color.Black
                lblNo3.BackColor = Color.Red
                lblNo4.BackColor = Color.Black
                lblNo5.BackColor = Color.Red
                lblNo6.BackColor = Color.Black
                ' Enables all other buttons enabled for Group 6 selection
                lblNo4.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

            ' This code is for selection of a group of 4
        ElseIf Group4Select = 1 Then
            ' Runs if 1 is not selected
            If No1Select = 0 Then
                ' Selects the numbers in the group
                No1Select = 1
                No2Select = 1
                No4Select = 1
                No5Select = 1
                ' Changes the colours of the group to their highlighted state
                lblNo1.BackColor = Color.LightSalmon
                lblNo2.BackColor = Color.DarkGray
                lblNo4.BackColor = Color.DarkGray
                lblNo5.BackColor = Color.LightSalmon
                ' Disables all other buttons
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
                ' If 1 is selected
            ElseIf No1Select = 1
                ' Deselects the group
                No1Select = 0
                No2Select = 0
                No4Select = 0
                No5Select = 0
                ' Changes group's labels to default colours
                lblNo1.BackColor = Color.Red
                lblNo2.BackColor = Color.Black
                lblNo4.BackColor = Color.Black
                lblNo5.BackColor = Color.Red
                ' Enables all other numbers enabled by Group 4
                lblNo2.Enabled = True
                lblNo4.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

            ' For selecting a group of 3
        ElseIf Group3Select = 1 Then
            ' If 1 is not selected
            If No1Select = 0 Then
                ' Selects the numbers in the line
                No1Select = 1
                No2Select = 1
                No3Select = 1
                ' Changes the number's colours to highligted state
                lblNo1.BackColor = Color.LightSalmon
                lblNo2.BackColor = Color.DarkGray
                lblNo3.BackColor = Color.LightSalmon
                ' Disables all other options
                lblNo4.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
                ' If 1 is selected
            ElseIf No1Select = 1
                ' Deselects the row
                No1Select = 0
                No2Select = 0
                No3Select = 0
                ' Reverts colours to default
                lblNo1.BackColor = Color.Red
                lblNo2.BackColor = Color.Black
                lblNo3.BackColor = Color.Red
                ' Enables all other Group 3 options
                lblNo4.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

            ' Runs if selecting a group of 2
        ElseIf Group2Select = 1 Then
            ' Runs if 1 is not selected
            If No1Select = 0 Then
                ' If 2 is already selected
                If No2Select = 1 Then
                    ' Disables all other options for both numbers
                    lblNo5.Enabled = 0
                    lblNo3.Enabled = 0
                    lblNo4.Enabled = 0
                    ' Mark 1 as selected
                    No1Select = 1
                    ' Changes 1 to highlighted state
                    lblNo1.BackColor = Color.LightSalmon
                    ' If 4 is already selected
                ElseIf No4Select = 1 Then
                    ' Disables all other option for both numbers
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo2.Enabled = 0
                    ' Mark 1 as selected
                    No1Select = 1
                    ' Changes colour to highlighted state
                    lblNo1.BackColor = Color.LightSalmon
                Else
                    ' Disables all options except the ones available for a group of 2
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo1.Enabled = 1
                    lblNo2.Enabled = 1
                    lblNo4.Enabled = 1
                    ' Provides instructions in message area
                    lblMessages.Text = "Please select your second number from the enabled options"
                    ' Marks 1 as selected
                    No1Select = 1
                    ' Changes 1's colour to highlighted state
                    lblNo1.BackColor = Color.LightSalmon
                End If
                ' If 1 is selected
            ElseIf No1Select = 1 Then
                ' If 2 is also selected
                If No2Select = 1 Then
                    ' Enables the other options for 2
                    lblNo5.Enabled = 1
                    lblNo3.Enabled = 1
                    ' Marks 1 as not selected
                    No1Select = 0
                    ' Changes 1's colour to default 
                    lblNo1.BackColor = Color.Red
                    ' If 4 is selected instead
                ElseIf No4Select = 1 Then
                    ' Enables other options available to 4
                    lblNo5.Enabled = 1
                    lblNo7.Enabled = 1
                    ' Marks 1 as not selected
                    No1Select = 0
                    ' Changes 1's colour to default
                    lblNo1.BackColor = Color.Red
                    ' If 1 is the only item selected
                Else
                    ' Resets the game board to default
                    Reset()
                    ' Re-sets Group 2 as selected
                    Group2Select = 1
                    ' Re-sets instructions in lblMessages to selecting first number
                    lblMessages.Text = "Please select your first number"
                    ' Disables other batch select buttons
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    ' Changes selected number count to 2 as it gets reset to 0 by Reset()
                    Selected = 2
                End If
            End If

            ' Code that allows selection/deselection of the button
            ' If the button is not selected, following runs
        Else
            If No1Select = 0 Then
                ' Indicates one number has been selected, used to trigger disabling and enabling of selections
                Selected = Selected + 1
                ' Writes to the integer that this number has been selected
                No1Select = 1
                ' Changes the background colour to indicate selection to user
                lblNo1.BackColor = Color.LightSalmon
                ' Disables all other selections to prevent breaking the game
                Disable()

                ' If button is already selected, this code runs
            ElseIf No1Select = 1 Then
                ' Resets the game board to default
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click

        If Group4Select = 1 Then
            If No2Select = 0 Then
                No2Select = 1
                No3Select = 1
                No5Select = 1
                No6Select = 1
                lblNo2.BackColor = Color.DarkGray
                lblNo3.BackColor = Color.LightSalmon
                lblNo5.BackColor = Color.LightSalmon
                lblNo6.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False

            ElseIf No2Select = 1 Then
                No2Select = 0
                No3Select = 0
                No5Select = 0
                No6Select = 0
                lblNo2.BackColor = Color.Black
                lblNo3.BackColor = Color.Red
                lblNo5.BackColor = Color.Red
                lblNo6.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No2Select = 0 Then
                If No1Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo3.Enabled = 0
                    lblNo4.Enabled = 0
                    No2Select = 1
                    lblNo2.BackColor = Color.DarkGray
                ElseIf No5Select = 1 Then
                    lblNo1.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo8.Enabled = 0
                    No2Select = 1
                    lblNo2.BackColor = Color.DarkGray
                ElseIf No3Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo1.Enabled = 0
                    lblNo6.Enabled = 0
                    No2Select = 1
                    lblNo2.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo2.Enabled = 1
                    lblNo1.Enabled = 1
                    lblNo5.Enabled = 1
                    lblNo3.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No2Select = 1
                    lblNo2.BackColor = Color.DarkGray
                End If
            ElseIf No2Select = 1 Then
                If No1Select = 1 Then
                    lblNo4.Enabled = 1
                    No2Select = 0
                    lblNo2.BackColor = Color.Black
                ElseIf No5Select = 1 Then
                    lblNo4.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    No2Select = 0
                    lblNo2.BackColor = Color.Black
                ElseIf No3Select = 1 Then
                    lblNo6.Enabled = 1
                    No2Select = 0
                    lblNo2.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No2Select = 0 Then
                Selected = Selected + 1
                No2Select = 1
                lblNo2.BackColor = Color.DarkGray
                Disable()

            ElseIf No2Select = 1 Then
                Reset()
            End If
        End If

    End Sub

    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        If Group2Select = 1 Then
            If No3Select = 0 Then
                If No2Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo1.Enabled = 0
                    lblNo6.Enabled = 0
                    No3Select = 1
                    lblNo3.BackColor = Color.LightSalmon
                ElseIf No6Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo2.Enabled = 0
                    No3Select = 1
                    lblNo3.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo3.Enabled = 1
                    lblNo2.Enabled = 1
                    lblNo6.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No3Select = 1
                    lblNo3.BackColor = Color.LightSalmon
                End If
            ElseIf No3Select = 1 Then
                If No2Select = 1 Then
                    lblNo5.Enabled = 1
                    lblNo1.Enabled = 1
                    No3Select = 0
                    lblNo3.BackColor = Color.Red
                ElseIf No6Select = 1 Then
                    lblNo5.Enabled = 1
                    lblNo9.Enabled = 1
                    No3Select = 0
                    lblNo3.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No3Select = 0 Then
                Selected = Selected + 1
                No3Select = 1
                lblNo3.BackColor = Color.LightSalmon
                Disable()
            ElseIf No3Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        If Group6Select = 1 Then
            If No4Select = 0 Then
                No4Select = 1
                No5Select = 1
                No6Select = 1
                No7Select = 1
                No8Select = 1
                No9Select = 1
                lblNo4.BackColor = Color.DarkGray
                lblNo5.BackColor = Color.LightSalmon
                lblNo6.BackColor = Color.DarkGray
                lblNo7.BackColor = Color.LightSalmon
                lblNo8.BackColor = Color.DarkGray
                lblNo9.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No4Select = 1
                No4Select = 0
                No5Select = 0
                No6Select = 0
                No7Select = 0
                No8Select = 0
                No9Select = 0
                lblNo4.BackColor = Color.Black
                lblNo5.BackColor = Color.Red
                lblNo6.BackColor = Color.Black
                lblNo7.BackColor = Color.Red
                lblNo8.BackColor = Color.Black
                lblNo9.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No4Select = 0 Then
                No4Select = 1
                No5Select = 1
                No7Select = 1
                No8Select = 1
                lblNo4.BackColor = Color.DarkGray
                lblNo5.BackColor = Color.LightSalmon
                lblNo7.BackColor = Color.LightSalmon
                lblNo8.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No4Select = 1 Then
                No4Select = 0
                No5Select = 0
                No7Select = 0
                No8Select = 0
                lblNo4.BackColor = Color.Black
                lblNo5.BackColor = Color.Red
                lblNo7.BackColor = Color.Red
                lblNo8.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No4Select = 0 Then
                No4Select = 1
                No5Select = 1
                No6Select = 1
                lblNo4.BackColor = Color.DarkGray
                lblNo5.BackColor = Color.LightSalmon
                lblNo6.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No4Select = 1
                No4Select = 0
                No5Select = 0
                No6Select = 0
                lblNo4.BackColor = Color.Black
                lblNo5.BackColor = Color.Red
                lblNo6.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No4Select = 0 Then
                If No1Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo2.Enabled = 0
                    No4Select = 1
                    lblNo4.BackColor = Color.DarkGray
                ElseIf No5Select = 1 Then
                    lblNo1.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo2.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo8.Enabled = 0
                    No4Select = 1
                    lblNo4.BackColor = Color.DarkGray
                ElseIf No7Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo1.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo10.Enabled = 0
                    No4Select = 1
                    lblNo4.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo1.Enabled = 1
                    lblNo5.Enabled = 1
                    lblNo7.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No4Select = 1
                    lblNo4.BackColor = Color.DarkGray
                End If
            ElseIf No4Select = 1 Then
                If No1Select = 1 Then
                    lblNo2.Enabled = 1
                    No4Select = 0
                    lblNo4.BackColor = Color.Black
                ElseIf No5Select = 1 Then
                    lblNo2.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    No4Select = 0
                    lblNo4.BackColor = Color.Black
                ElseIf No7Select = 1 Then
                    lblNo8.Enabled = 1
                    lblNo10.Enabled = 1
                    No4Select = 0
                    lblNo4.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No4Select = 0 Then
                Selected = Selected + 1
                No4Select = 1
                lblNo4.BackColor = Color.DarkGray
                Disable()
            ElseIf No4Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        If Group4Select = 1 Then
            If No5Select = 0 Then
                No5Select = 1
                No6Select = 1
                No8Select = 1
                No9Select = 1
                lblNo5.BackColor = Color.LightSalmon
                lblNo6.BackColor = Color.DarkGray
                lblNo8.BackColor = Color.DarkGray
                lblNo9.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo2.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No5Select = 1 Then
                No5Select = 0
                No6Select = 0
                No7Select = 0
                No8Select = 0
                lblNo5.BackColor = Color.Red
                lblNo6.BackColor = Color.Black
                lblNo8.BackColor = Color.Black
                lblNo9.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No5Select = 0 Then
                If No2Select = 1 Then
                    lblNo1.Enabled = 0
                    lblNo3.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo8.Enabled = 0
                    No5Select = 1
                    lblNo5.BackColor = Color.LightSalmon
                ElseIf No4Select = 1 Then
                    lblNo1.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo2.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo8.Enabled = 0
                    No5Select = 1
                    lblNo5.BackColor = Color.LightSalmon
                ElseIf No6Select = 1 Then
                    lblNo3.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo2.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo8.Enabled = 0
                    No5Select = 1
                    lblNo5.BackColor = Color.LightSalmon
                ElseIf No8Select = 1 Then
                    lblNo2.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo11.Enabled = 0
                    No5Select = 1
                    lblNo5.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo5.Enabled = 1
                    lblNo2.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No5Select = 1
                    lblNo5.BackColor = Color.LightSalmon
                End If
            ElseIf No5Select = 1 Then
                If No2Select = 1 Then
                    lblNo1.Enabled = 1
                    lblNo3.Enabled = 1
                    No5Select = 0
                    lblNo5.BackColor = Color.Red
                ElseIf No4Select = 1 Then
                    lblNo1.Enabled = 1
                    lblNo7.Enabled = 1
                    No5Select = 0
                    lblNo5.BackColor = Color.Red
                ElseIf No6Select = 1 Then
                    lblNo3.Enabled = 1
                    lblNo9.Enabled = 1
                    No5Select = 0
                    lblNo5.BackColor = Color.Red
                ElseIf No8Select = 1 Then
                    lblNo7.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo11.Enabled = 1
                    No5Select = 0
                    lblNo5.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No5Select = 0 Then
                Selected = Selected + 1
                No5Select = 1
                lblNo5.BackColor = Color.LightSalmon
                Disable()
            ElseIf No5Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        If Group2Select = 1 Then
            If No6Select = 0 Then
                If No3Select = 1 Then
                    lblNo9.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo2.Enabled = 0
                    No6Select = 1
                    lblNo6.BackColor = Color.DarkGray
                ElseIf No5Select = 1 Then
                    lblNo3.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo2.Enabled = 0
                    No6Select = 1
                    lblNo6.BackColor = Color.DarkGray
                ElseIf No9Select = 1 Then
                    lblNo3.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo12.Enabled = 0
                    No6Select = 1
                    lblNo6.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo3.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo5.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No6Select = 1
                    lblNo6.BackColor = Color.DarkGray
                End If
            ElseIf No6Select = 1 Then
                If No3Select = 1 Then
                    lblNo2.Enabled = 1
                    No6Select = 0
                    lblNo6.BackColor = Color.Black
                ElseIf No5Select = 1 Then
                    lblNo2.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo8.Enabled = 1
                    No6Select = 0
                    lblNo6.BackColor = Color.Black
                ElseIf No9Select = 1 Then
                    lblNo8.Enabled = 1
                    lblNo12.Enabled = 1
                    No6Select = 0
                    lblNo6.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No6Select = 0 Then
                Selected = Selected + 1
                No6Select = 1
            lblNo6.BackColor = Color.DarkGray
            Disable()
        ElseIf No6Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click

        If Group6Select = 1 Then
            If No7Select = 0 Then
                No7Select = 1
                No8Select = 1
                No9Select = 1
                No10Select = 1
                No11Select = 1
                No12Select = 1
                lblNo7.BackColor = Color.LightSalmon
                lblNo8.BackColor = Color.DarkGray
                lblNo9.BackColor = Color.LightSalmon
                lblNo10.BackColor = Color.DarkGray
                lblNo11.BackColor = Color.DarkGray
                lblNo12.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No7Select = 1
                No7Select = 0
                No8Select = 0
                No9Select = 0
                No10Select = 0
                No11Select = 0
                No12Select = 0
                lblNo7.BackColor = Color.Red
                lblNo8.BackColor = Color.Black
                lblNo9.BackColor = Color.Red
                lblNo10.BackColor = Color.Black
                lblNo11.BackColor = Color.Black
                lblNo12.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No7Select = 0 Then
                No7Select = 1
                No8Select = 1
                No10Select = 1
                No11Select = 1
                lblNo7.BackColor = Color.LightSalmon
                lblNo8.BackColor = Color.DarkGray
                lblNo10.BackColor = Color.DarkGray
                lblNo11.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No7Select = 1 Then
                No7Select = 0
                No8Select = 0
                No10Select = 0
                No11Select = 0
                lblNo7.BackColor = Color.Red
                lblNo8.BackColor = Color.Black
                lblNo10.BackColor = Color.Black
                lblNo11.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No7Select = 0 Then
                No7Select = 1
                No8Select = 1
                No9Select = 1
                lblNo7.BackColor = Color.LightSalmon
                lblNo8.BackColor = Color.DarkGray
                lblNo9.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No7Select = 1
                No7Select = 0
                No8Select = 0
                No9Select = 0
                lblNo7.BackColor = Color.Red
                lblNo8.BackColor = Color.Black
                lblNo9.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No7Select = 0 Then
                If No4Select = 1 Then
                    lblNo1.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo10.Enabled = 0
                    No7Select = 1
                    lblNo7.BackColor = Color.LightSalmon
                ElseIf No8Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo4.Enabled = 0
                    No7Select = 1
                    lblNo7.BackColor = Color.LightSalmon
                ElseIf No10Select = 1 Then
                    lblNo4.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo13.Enabled = 0
                    No7Select = 1
                    lblNo7.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo7.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo8.Enabled = 1
                    lblNo10.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No7Select = 1
                    lblNo7.BackColor = Color.LightSalmon
                End If
            ElseIf No7Select = 1 Then
                If No4Select = 1 Then
                    lblNo1.Enabled = 1
                    lblNo5.Enabled = 1
                    No7Select = 0
                    lblNo7.BackColor = Color.Red
                ElseIf No8Select = 1 Then
                    lblNo5.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo11.Enabled = 1
                    No7Select = 0
                    lblNo7.BackColor = Color.Red
                ElseIf No10Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo13.Enabled = 1
                    No7Select = 0
                    lblNo7.BackColor = Color.Red
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No7Select = 0 Then
                Selected = Selected + 1
                No7Select = 1
                lblNo7.BackColor = Color.LightSalmon
                Disable()
            ElseIf No7Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        If Group4Select = 1 Then
            If No8Select = 0 Then
                No8Select = 1
                No9Select = 1
                No11Select = 1
                No12Select = 1
                lblNo8.BackColor = Color.DarkGray
                lblNo9.BackColor = Color.LightSalmon
                lblNo11.BackColor = Color.DarkGray
                lblNo12.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No8Select = 1 Then
                No8Select = 0
                No9Select = 0
                No11Select = 0
                No12Select = 0
                lblNo8.BackColor = Color.Black
                lblNo9.BackColor = Color.Red
                lblNo11.BackColor = Color.Black
                lblNo12.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No8Select = 0 Then
                If No5Select = 1 Then
                    lblNo2.Enabled = 0
                    lblNo4.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo11.Enabled = 0
                    No8Select = 1
                    lblNo8.BackColor = Color.DarkGray
                ElseIf No7Select = 1 Then
                    lblNo4.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo11.Enabled = 0
                    No8Select = 1
                    lblNo8.BackColor = Color.DarkGray
                ElseIf No9Select = 1 Then
                    lblNo6.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo11.Enabled = 0
                    No8Select = 1
                    lblNo8.BackColor = Color.DarkGray
                ElseIf No11Select = 1 Then
                    lblNo10.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo9.Enabled = 0
                    No8Select = 1
                    lblNo8.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo8.Enabled = 1
                    lblNo5.Enabled = 1
                    lblNo7.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo11.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No8Select = 1
                    lblNo8.BackColor = Color.DarkGray
                End If
            ElseIf No8Select = 1 Then
                If No5Select = 1 Then
                    lblNo2.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo6.Enabled = 1
                    No8Select = 0
                    lblNo8.BackColor = Color.Black
                ElseIf No7Select = 1 Then
                    lblNo4.Enabled = 1
                    lblNo10.Enabled = 1
                    No8Select = 0
                    lblNo8.BackColor = Color.Black
                ElseIf No9Select = 1 Then
                    lblNo6.Enabled = 1
                    lblNo12.Enabled = 1
                    No8Select = 0
                    lblNo8.BackColor = Color.Black
                ElseIf No11Select = 1 Then
                    lblNo10.Enabled = 1
                    lblNo12.Enabled = 1
                    lblNo14.Enabled = 1
                    No8Select = 0
                    lblNo8.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No8Select = 0 Then
                Selected = Selected + 1
                No8Select = 1
                lblNo8.BackColor = Color.DarkGray
                Disable()
            ElseIf No8Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        If Group2Select = 1 Then
            If No9Select = 0 Then
                If No6Select = 1 Then
                    lblNo3.Enabled = 0
                    lblNo5.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo12.Enabled = 0
                    No9Select = 1
                    lblNo9.BackColor = Color.LightSalmon
                ElseIf No8Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo6.Enabled = 0
                    No9Select = 1
                    lblNo9.BackColor = Color.LightSalmon
                ElseIf No12Select = 1 Then
                    lblNo15.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo6.Enabled = 0
                    No9Select = 1
                    lblNo9.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    lblNo12.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No9Select = 1
                    lblNo9.BackColor = Color.LightSalmon
                End If
            ElseIf No9Select = 1 Then
                If No6Select = 1 Then
                    lblNo3.Enabled = 1
                    lblNo5.Enabled = 1
                    No9Select = 0
                    lblNo9.BackColor = Color.Red
                ElseIf No8Select = 1 Then
                    lblNo5.Enabled = 1
                    lblNo7.Enabled = 1
                    lblNo11.Enabled = 1
                    No9Select = 0
                    lblNo9.BackColor = Color.Red
                ElseIf No12Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo15.Enabled = 1
                    No9Select = 0
                    lblNo9.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No9Select = 0 Then
                Selected = Selected + 1
                No9Select = 1
            lblNo9.BackColor = Color.LightSalmon
            Disable()
        ElseIf No9Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo10_Click(sender As Object, e As EventArgs) Handles lblNo10.Click
        If Group6Select = 1 Then
            If No10Select = 0 Then
                No10Select = 1
                No11Select = 1
                No12Select = 1
                No13Select = 1
                No14Select = 1
                No15Select = 1
                lblNo10.BackColor = Color.DarkGray
                lblNo11.BackColor = Color.DarkGray
                lblNo12.BackColor = Color.LightSalmon
                lblNo13.BackColor = Color.DarkGray
                lblNo14.BackColor = Color.LightSalmon
                lblNo15.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo7.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No10Select = 1
                No10Select = 0
                No11Select = 0
                No12Select = 0
                No13Select = 0
                No14Select = 0
                No15Select = 0
                lblNo10.BackColor = Color.Black
                lblNo11.BackColor = Color.Black
                lblNo12.BackColor = Color.Red
                lblNo13.BackColor = Color.Black
                lblNo14.BackColor = Color.Red
                lblNo15.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo7.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No10Select = 0 Then
                No10Select = 1
                No11Select = 1
                No13Select = 1
                No14Select = 1
                lblNo10.BackColor = Color.DarkGray
                lblNo11.BackColor = Color.DarkGray
                lblNo13.BackColor = Color.DarkGray
                lblNo14.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No10Select = 1 Then
                No10Select = 0
                No11Select = 0
                No13Select = 0
                No14Select = 0
                lblNo10.BackColor = Color.Black
                lblNo11.BackColor = Color.Black
                lblNo13.BackColor = Color.Black
                lblNo14.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No10Select = 0 Then
                No10Select = 1
                No11Select = 1
                No12Select = 1
                lblNo10.BackColor = Color.DarkGray
                lblNo11.BackColor = Color.DarkGray
                lblNo12.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo4.Enabled = False
                lblNo7.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No10Select = 1
                No10Select = 0
                No11Select = 0
                No12Select = 0
                lblNo10.BackColor = Color.Black
                lblNo11.BackColor = Color.Black
                lblNo12.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo7.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No10Select = 0 Then
                If No7Select = 1 Then
                    lblNo4.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo13.Enabled = 0
                    No10Select = 1
                    lblNo10.BackColor = Color.DarkGray
                ElseIf No11Select = 1 Then
                    lblNo8.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo13.Enabled = 0
                    No10Select = 1
                    lblNo10.BackColor = Color.DarkGray
                ElseIf No13Select = 1 Then
                    lblNo14.Enabled = 0
                    lblNo16.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo11.Enabled = 0
                    No10Select = 1
                    lblNo10.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo10.Enabled = 1
                    lblNo7.Enabled = 1
                    lblNo11.Enabled = 1
                    lblNo13.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                End If
            ElseIf No11Select = 1 Then
                If No7Select = 1 Then
                    lblNo4.Enabled = 1
                    lblNo8.Enabled = 1
                    No10Select = 0
                    lblNo10.BackColor = Color.Black
                ElseIf No11Select = 1 Then
                    lblNo8.Enabled = 1
                    lblNo12.Enabled = 1
                    lblNo14.Enabled = 1
                    No10Select = 0
                    lblNo10.BackColor = Color.Black
                ElseIf No13Select = 1 Then
                    lblNo14.Enabled = 1
                    lblNo16.Enabled = 1
                    No10Select = 0
                    lblNo10.BackColor = Color.Black
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No10Select = 0 Then
                Selected = Selected + 1
                No10Select = 1
                lblNo10.BackColor = Color.DarkGray
                Disable()
            ElseIf No10Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo11_Click(sender As Object, e As EventArgs) Handles lblNo11.Click

        If Group4Select = 1 Then
            If No11Select = 0 Then
                No11Select = 1
                No12Select = 1
                No14Select = 1
                No15Select = 1
                lblNo11.BackColor = Color.DarkGray
                lblNo12.BackColor = Color.LightSalmon
                lblNo14.BackColor = Color.LightSalmon
                lblNo15.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No11Select = 1 Then
                No11Select = 0
                No12Select = 0
                No14Select = 0
                No15Select = 0
                lblNo11.BackColor = Color.Black
                lblNo12.BackColor = Color.Red
                lblNo14.BackColor = Color.Red
                lblNo15.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No11Select = 0 Then
                If No8Select = 1 Then
                    lblNo5.Enabled = 0
                    lblNo7.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo14.Enabled = 0
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                ElseIf No10Select = 1 Then
                    lblNo7.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo14.Enabled = 0
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                ElseIf No12Select = 1 Then
                    lblNo9.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo14.Enabled = 0
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                ElseIf No14Select = 1 Then
                    lblNo13.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo8.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo12.Enabled = 0
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo11.Enabled = 1
                    lblNo8.Enabled = 1
                    lblNo10.Enabled = 1
                    lblNo12.Enabled = 1
                    lblNo14.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No11Select = 1
                    lblNo11.BackColor = Color.DarkGray
                End If
            ElseIf No11Select = 1 Then
                If No8Select = 1 Then
                    lblNo7.Enabled = 1
                    lblNo5.Enabled = 1
                    lblNo9.Enabled = 1
                    No11Select = 0
                    lblNo11.BackColor = Color.Black
                ElseIf No10Select = 1 Then
                    lblNo7.Enabled = 1
                    lblNo13.Enabled = 1
                    No11Select = 0
                    lblNo11.BackColor = Color.Black
                ElseIf No12Select = 1 Then
                    lblNo9.Enabled = 1
                    lblNo15.Enabled = 1
                    No11Select = 0
                    lblNo11.BackColor = Color.Black
                ElseIf No14Select = 1 Then
                    lblNo13.Enabled = 1
                    lblNo15.Enabled = 1
                    lblNo17.Enabled = 1
                    No11Select = 0
                    lblNo11.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No11Select = 0 Then
                Selected = Selected + 1
                No11Select = 1
                lblNo11.BackColor = Color.DarkGray
                Disable()
            ElseIf No11Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo12_Click(sender As Object, e As EventArgs) Handles lblNo12.Click
        If Group2Select = 1 Then
            If No12Select = 0 Then
                If No9Select = 1 Then
                    lblNo15.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo6.Enabled = 0
                    lblNo8.Enabled = 0
                    No12Select = 1
                    lblNo12.BackColor = Color.LightSalmon
                ElseIf No11Select = 1 Then
                    lblNo8.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo15.Enabled = 0
                    No12Select = 1
                    lblNo12.BackColor = Color.LightSalmon
                ElseIf No15Select = 1 Then
                    lblNo14.Enabled = 0
                    lblNo9.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo11.Enabled = 0
                    No12Select = 1
                    lblNo12.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo12.Enabled = 1
                    lblNo9.Enabled = 1
                    lblNo11.Enabled = 1
                    lblNo15.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No12Select = 1
                    lblNo12.BackColor = Color.LightSalmon
                End If
            ElseIf No12Select = 1 Then
                If No9Select = 1 Then
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    No12Select = 0
                    lblNo12.BackColor = Color.Red
                ElseIf No11Select = 1 Then
                    lblNo10.Enabled = 1
                    lblNo14.Enabled = 1
                    lblNo8.Enabled = 1
                    No12Select = 0
                    lblNo12.BackColor = Color.Red
                ElseIf No15Select = 1 Then
                    lblNo14.Enabled = 1
                    lblNo18.Enabled = 1
                    No12Select = 0
                    lblNo12.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No12Select = 0 Then
                Selected = Selected + 1
                No12Select = 1
            lblNo12.BackColor = Color.LightSalmon
            Disable()
        ElseIf No12Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo13_Click(sender As Object, e As EventArgs) Handles lblNo13.Click
        If Group6Select = 1 Then
            If No13Select = 0 Then
                No13Select = 1
                No14Select = 1
                No15Select = 1
                No16Select = 1
                No17Select = 1
                No18Select = 1
                lblNo13.BackColor = Color.DarkGray
                lblNo14.BackColor = Color.LightSalmon
                lblNo15.BackColor = Color.DarkGray
                lblNo16.BackColor = Color.LightSalmon
                lblNo17.BackColor = Color.DarkGray
                lblNo18.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo4.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No13Select = 1
                No13Select = 0
                No14Select = 0
                No15Select = 0
                No16Select = 0
                No17Select = 0
                No18Select = 0
                lblNo13.BackColor = Color.Black
                lblNo14.BackColor = Color.Red
                lblNo15.BackColor = Color.Black
                lblNo16.BackColor = Color.Red
                lblNo17.BackColor = Color.Black
                lblNo18.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo4.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No13Select = 0 Then
                No13Select = 1
                No14Select = 1
                No16Select = 1
                No17Select = 1
                lblNo13.BackColor = Color.DarkGray
                lblNo14.BackColor = Color.LightSalmon
                lblNo16.BackColor = Color.LightSalmon
                lblNo17.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo10.Enabled = False
                lblNo14.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No13Select = 1 Then
                No13Select = 0
                No14Select = 0
                No16Select = 0
                No17Select = 0
                lblNo13.BackColor = Color.Black
                lblNo14.BackColor = Color.Red
                lblNo16.BackColor = Color.Red
                lblNo17.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo10.Enabled = True
                lblNo14.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No13Select = 0 Then
                No13Select = 1
                No14Select = 1
                No15Select = 1
                lblNo13.BackColor = Color.DarkGray
                lblNo14.BackColor = Color.LightSalmon
                lblNo15.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo4.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No13Select = 1
                No13Select = 0
                No14Select = 0
                No15Select = 0
                lblNo13.BackColor = Color.Black
                lblNo14.BackColor = Color.Red
                lblNo15.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo4.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No13Select = 0 Then
                If No10Select = 1 Then
                    lblNo7.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo16.Enabled = 0
                    No13Select = 1
                    lblNo13.BackColor = Color.DarkGray
                ElseIf No14Select = 1 Then
                    lblNo11.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo16.Enabled = 0
                    No13Select = 1
                    lblNo13.BackColor = Color.DarkGray
                ElseIf No16Select = 1 Then
                    lblNo10.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo19.Enabled = 0
                    No6Select = 1
                    lblNo6.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo13.Enabled = 1
                    lblNo10.Enabled = 1
                    lblNo14.Enabled = 1
                    lblNo16.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No13Select = 1
                    lblNo13.BackColor = Color.DarkGray
                End If
            ElseIf No13Select = 1 Then
                If No10Select = 1 Then
                    lblNo7.Enabled = 1
                    lblNo11.Enabled = 1
                    No13Select = 0
                    lblNo13.BackColor = Color.Black
                ElseIf No14Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo15.Enabled = 1
                    lblNo17.Enabled = 1
                    No13Select = 0
                    lblNo13.BackColor = Color.Black
                ElseIf No16Select = 1 Then
                    lblNo19.Enabled = 1
                    lblNo17.Enabled = 1
                    No13Select = 0
                    lblNo13.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No13Select = 0 Then
                Selected = Selected + 1
                No13Select = 1
                lblNo13.BackColor = Color.DarkGray
                Disable()
            ElseIf No13Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo14_Click(sender As Object, e As EventArgs) Handles lblNo14.Click

        If Group4Select = 1 Then
            If No14Select = 0 Then
                No14Select = 1
                No15Select = 1
                No17Select = 1
                No18Select = 1
                lblNo14.BackColor = Color.LightSalmon
                lblNo15.BackColor = Color.DarkGray
                lblNo17.BackColor = Color.DarkGray
                lblNo18.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo10.Enabled = False
                lblNo16.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No14Select = 1 Then
                No14Select = 0
                No15Select = 0
                No17Select = 0
                No18Select = 0
                lblNo14.BackColor = Color.Red
                lblNo15.BackColor = Color.Black
                lblNo17.BackColor = Color.Black
                lblNo18.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo10.Enabled = True
                lblNo16.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No14Select = 0 Then
                If No11Select = 1 Then
                    lblNo8.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    No14Select = 1
                    lblNo14.BackColor = Color.LightSalmon
                ElseIf No13Select = 1 Then
                    lblNo10.Enabled = 0
                    lblNo16.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    No14Select = 1
                    lblNo14.BackColor = Color.LightSalmon
                ElseIf No15Select = 1 Then
                    lblNo12.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo17.Enabled = 0
                    No14Select = 1
                    lblNo14.BackColor = Color.LightSalmon
                ElseIf No17Select = 1 Then
                    lblNo16.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo15.Enabled = 0
                    No14Select = 1
                    lblNo14.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo14.Enabled = 1
                    lblNo11.Enabled = 1
                    lblNo13.Enabled = 1
                    lblNo15.Enabled = 1
                    lblNo17.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No14Select = 1
                    lblNo14.BackColor = Color.LightSalmon
                End If
            ElseIf No14Select = 1 Then
                If No11Select = 1 Then
                    lblNo8.Enabled = 1
                    lblNo10.Enabled = 1
                    lblNo12.Enabled = 1
                    No14Select = 0
                    lblNo14.BackColor = Color.Red
                ElseIf No13Select = 1 Then
                    lblNo10.Enabled = 1
                    lblNo16.Enabled = 1
                    No14Select = 0
                    lblNo14.BackColor = Color.Red
                ElseIf No15Select = 1 Then
                    lblNo12.Enabled = 1
                    lblNo18.Enabled = 1
                    No14Select = 0
                    lblNo14.BackColor = Color.Red
                ElseIf No17Select = 1 Then
                    lblNo16.Enabled = 1
                    lblNo18.Enabled = 1
                    lblNo20.Enabled = 1
                    No14Select = 0
                    lblNo14.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No14Select = 0 Then
                Selected = Selected + 1
                No14Select = 1
                lblNo14.BackColor = Color.LightSalmon
                Disable()
            ElseIf No14Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo15_Click(sender As Object, e As EventArgs) Handles lblNo15.Click
        If Group2Select = 1 Then
            If No15Select = 0 Then
                If No12Select = 1 Then
                    lblNo9.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo18.Enabled = 0
                    No15Select = 1
                    lblNo15.BackColor = Color.DarkGray
                ElseIf No14Select = 1 Then
                    lblNo11.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo18.Enabled = 0
                    No15Select = 1
                    lblNo15.BackColor = Color.DarkGray
                ElseIf No18Select = 1 Then
                    lblNo12.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo17.Enabled = 0
                    No15Select = 1
                    lblNo15.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo15.Enabled = 1
                    lblNo12.Enabled = 1
                    lblNo14.Enabled = 1
                    lblNo18.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No15Select = 1
                    lblNo15.BackColor = Color.DarkGray
                End If
            ElseIf No15Select = 1 Then
                If No12Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo9.Enabled = 1
                    No15Select = 0
                    lblNo15.BackColor = Color.Black
                ElseIf No14Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo13.Enabled = 1
                    lblNo17.Enabled = 1
                    No15Select = 0
                    lblNo15.BackColor = Color.Black
                ElseIf No18Select = 1 Then
                    lblNo21.Enabled = 1
                    lblNo17.Enabled = 1
                    No15Select = 0
                    lblNo15.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No15Select = 0 Then
                Selected = Selected + 1
                No15Select = 1
            lblNo15.BackColor = Color.DarkGray
            Disable()
        ElseIf No15Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo16_Click(sender As Object, e As EventArgs) Handles lblNo16.Click
        If Group6Select = 1 Then
            If No16Select = 0 Then
                No16Select = 1
                No17Select = 1
                No18Select = 1
                No19Select = 1
                No20Select = 1
                No21Select = 1
                lblNo16.BackColor = Color.LightSalmon
                lblNo17.BackColor = Color.DarkGray
                lblNo18.BackColor = Color.LightSalmon
                lblNo19.BackColor = Color.DarkGray
                lblNo20.BackColor = Color.DarkGray
                lblNo21.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo4.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No16Select = 1
                No16Select = 0
                No17Select = 0
                No18Select = 0
                No19Select = 0
                No20Select = 0
                No21Select = 0
                lblNo16.BackColor = Color.Red
                lblNo17.BackColor = Color.Black
                lblNo18.BackColor = Color.Red
                lblNo19.BackColor = Color.Black
                lblNo20.BackColor = Color.Black
                lblNo21.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo4.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No16Select = 0 Then
                No16Select = 1
                No17Select = 1
                No19Select = 1
                No20Select = 1
                lblNo16.BackColor = Color.LightSalmon
                lblNo17.BackColor = Color.DarkGray
                lblNo19.BackColor = Color.DarkGray
                lblNo20.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No16Select = 1 Then
                No16Select = 0
                No17Select = 0
                No19Select = 0
                No20Select = 0
                lblNo16.BackColor = Color.Red
                lblNo17.BackColor = Color.Black
                lblNo19.BackColor = Color.Black
                lblNo20.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No16Select = 0 Then
                No16Select = 1
                No17Select = 1
                No18Select = 1
                lblNo16.BackColor = Color.LightSalmon
                lblNo17.BackColor = Color.DarkGray
                lblNo18.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo4.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No16Select = 1
                No16Select = 0
                No17Select = 0
                No18Select = 0
                lblNo16.BackColor = Color.Red
                lblNo17.BackColor = Color.Black
                lblNo18.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo4.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No16Select = 0 Then
                If No13Select = 1 Then
                    lblNo19.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo10.Enabled = 0
                    lblNo14.Enabled = 0
                    No16Select = 1
                    lblNo16.BackColor = Color.LightSalmon
                ElseIf No17Select = 1 Then
                    lblNo14.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo13.Enabled = 0
                    lblNo19.Enabled = 0
                    No16Select = 1
                    lblNo16.BackColor = Color.LightSalmon
                ElseIf No19Select = 1 Then
                    lblNo13.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo22.Enabled = 0
                    No16Select = 1
                    lblNo16.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo16.Enabled = 1
                    lblNo13.Enabled = 1
                    lblNo19.Enabled = 1
                    lblNo17.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No16Select = 1
                    lblNo16.BackColor = Color.LightSalmon
                End If
            ElseIf No16Select = 1 Then
                If No13Select = 1 Then
                    lblNo10.Enabled = 1
                    lblNo14.Enabled = 1
                    No16Select = 0
                    lblNo16.BackColor = Color.Red
                ElseIf No17Select = 1 Then
                    lblNo14.Enabled = 1
                    lblNo18.Enabled = 1
                    lblNo20.Enabled = 1
                    No16Select = 0
                    lblNo16.BackColor = Color.Red
                ElseIf No19Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo22.Enabled = 1
                    No16Select = 0
                    lblNo16.BackColor = Color.Red
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No16Select = 0 Then
                Selected = Selected + 1
                No16Select = 1
                lblNo16.BackColor = Color.LightSalmon
                Disable()
            ElseIf No16Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo17_Click(sender As Object, e As EventArgs) Handles lblNo17.Click

        If Group4Select = 1 Then
            If No17Select = 0 Then
                No17Select = 1
                No18Select = 1
                No20Select = 1
                No21Select = 1
                lblNo17.BackColor = Color.DarkGray
                lblNo18.BackColor = Color.LightSalmon
                lblNo20.BackColor = Color.DarkGray
                lblNo21.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No17Select = 1 Then
                No17Select = 0
                No18Select = 0
                No20Select = 0
                No21Select = 0
                lblNo17.BackColor = Color.Black
                lblNo18.BackColor = Color.Red
                lblNo20.BackColor = Color.Black
                lblNo21.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No17Select = 0 Then
                If No14Select = 1 Then
                    lblNo13.Enabled = 0
                    lblNo11.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo16.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo20.Enabled = 0
                    No17Select = 1
                    lblNo17.BackColor = Color.DarkGray
                ElseIf No16Select = 1 Then
                    lblNo13.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo20.Enabled = 0
                    No17Select = 1
                    lblNo17.BackColor = Color.DarkGray
                ElseIf No18Select = 1 Then
                    lblNo16.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo15.Enabled = 0
                    lblNo21.Enabled = 0
                    No17Select = 1
                    lblNo17.BackColor = Color.DarkGray
                ElseIf No20Select = 1 Then
                    lblNo19.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo16.Enabled = 0
                    lblNo18.Enabled = 0
                    No17Select = 1
                    lblNo17.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo17.Enabled = 1
                    lblNo16.Enabled = 1
                    lblNo18.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo14.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No17Select = 1
                    lblNo17.BackColor = Color.DarkGray
                End If
            ElseIf No17Select = 1 Then
                If No14Select = 1 Then
                    lblNo11.Enabled = 1
                    lblNo13.Enabled = 1
                    lblNo15.Enabled = 1
                    No17Select = 0
                    lblNo17.BackColor = Color.Black
                ElseIf No16Select = 1 Then
                    lblNo13.Enabled = 1
                    lblNo19.Enabled = 1
                    No17Select = 0
                    lblNo17.BackColor = Color.Black
                ElseIf No18Select = 1 Then
                    lblNo15.Enabled = 1
                    lblNo21.Enabled = 1
                    No17Select = 0
                    lblNo17.BackColor = Color.Black
                ElseIf No20Select = 1 Then
                    lblNo19.Enabled = 1
                    lblNo21.Enabled = 1
                    lblNo23.Enabled = 1
                    No17Select = 0
                    lblNo17.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No17Select = 0 Then
                Selected = Selected + 1
                No17Select = 1
                lblNo17.BackColor = Color.DarkGray
                Disable()
            ElseIf No17Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo18_Click(sender As Object, e As EventArgs) Handles lblNo18.Click

        If Group2Select = 1 Then
            If No18Select = 0 Then
                If No15Select = 1 Then
                    lblNo14.Enabled = 0
                    lblNo12.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo21.Enabled = 0
                    No18Select = 1
                    lblNo18.BackColor = Color.LightSalmon
                ElseIf No17Select = 1 Then
                    lblNo14.Enabled = 0
                    lblNo16.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo15.Enabled = 0
                    No18Select = 1
                    lblNo18.BackColor = Color.LightSalmon
                ElseIf No21Select = 1 Then
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo24.Enabled = 0
                    No18Select = 1
                    lblNo18.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo18.Enabled = 1
                    lblNo15.Enabled = 1
                    lblNo17.Enabled = 1
                    lblNo21.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No18Select = 1
                    lblNo18.BackColor = Color.LightSalmon
                End If
            ElseIf No18Select = 1 Then
                If No15Select = 1 Then
                    lblNo14.Enabled = 1
                    lblNo12.Enabled = 1
                    No18Select = 0
                    lblNo18.BackColor = Color.Red
                ElseIf No17Select = 1 Then
                    lblNo14.Enabled = 1
                    lblNo16.Enabled = 1
                    lblNo20.Enabled = 1
                    No18Select = 0
                    lblNo18.BackColor = Color.Red
                ElseIf No21Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo24.Enabled = 1
                    No18Select = 0
                    lblNo18.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No18Select = 0 Then
                Selected = Selected + 1
                No18Select = 1
                lblNo18.BackColor = Color.LightSalmon
                Disable()
            ElseIf No18Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo19_Click(sender As Object, e As EventArgs) Handles lblNo19.Click
        If Group6Select = 1 Then
            If No19Select = 0 Then
                No19Select = 1
                No20Select = 1
                No21Select = 1
                No22Select = 1
                No23Select = 1
                No24Select = 1
                lblNo19.BackColor = Color.DarkGray
                lblNo20.BackColor = Color.DarkGray
                lblNo21.BackColor = Color.LightSalmon
                lblNo22.BackColor = Color.DarkGray
                lblNo23.BackColor = Color.LightSalmon
                lblNo24.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo4.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No19Select = 1
                No19Select = 0
                No20Select = 0
                No21Select = 0
                No22Select = 0
                No23Select = 0
                No24Select = 0
                lblNo19.BackColor = Color.Black
                lblNo20.BackColor = Color.Black
                lblNo21.BackColor = Color.Red
                lblNo22.BackColor = Color.Black
                lblNo23.BackColor = Color.Red
                lblNo24.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo4.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No19Select = 0 Then
                No19Select = 1
                No20Select = 1
                No22Select = 1
                No23Select = 1
                lblNo19.BackColor = Color.DarkGray
                lblNo20.BackColor = Color.DarkGray
                lblNo22.BackColor = Color.DarkGray
                lblNo23.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo16.Enabled = False
                lblNo20.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No19Select = 1 Then
                No19Select = 0
                No20Select = 0
                No22Select = 0
                No23Select = 0
                lblNo19.BackColor = Color.Black
                lblNo20.BackColor = Color.Black
                lblNo22.BackColor = Color.Black
                lblNo23.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo16.Enabled = True
                lblNo20.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No19Select = 0 Then
                No19Select = 1
                No20Select = 1
                No21Select = 1
                lblNo19.BackColor = Color.DarkGray
                lblNo20.BackColor = Color.DarkGray
                lblNo21.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo4.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No19Select = 1
                No19Select = 0
                No20Select = 0
                No21Select = 0
                lblNo19.BackColor = Color.Black
                lblNo20.BackColor = Color.Black
                lblNo21.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo4.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No19Select = 0 Then
                If No16Select = 1 Then
                    lblNo13.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo20.Enabled = 0
                    No19Select = 1
                    lblNo19.BackColor = Color.DarkGray
                ElseIf No20Select = 1 Then
                    lblNo17.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo16.Enabled = 0
                    No19Select = 1
                    lblNo19.BackColor = Color.DarkGray
                ElseIf No22Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo16.Enabled = 0
                    No19Select = 1
                    lblNo19.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo19.Enabled = 1
                    lblNo16.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo22.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No19Select = 1
                    lblNo19.BackColor = Color.DarkGray
                End If
            ElseIf No19Select = 1 Then
                If No16Select = 1 Then
                    lblNo13.Enabled = 1
                    lblNo17.Enabled = 1
                    No19Select = 0
                    lblNo19.BackColor = Color.Black
                ElseIf No20Select = 1 Then
                    lblNo17.Enabled = 1
                    lblNo21.Enabled = 1
                    lblNo23.Enabled = 1
                    No19Select = 0
                    lblNo19.BackColor = Color.Black
                ElseIf No22Select = 1 Then
                    lblNo23.Enabled = 1
                    lblNo25.Enabled = 1
                    No19Select = 0
                    lblNo19.BackColor = Color.Black
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No19Select = 0 Then
                Selected = Selected + 1
                No19Select = 1
                lblNo19.BackColor = Color.DarkGray
                Disable()
            ElseIf No19Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo20_Click(sender As Object, e As EventArgs) Handles lblNo20.Click

        If Group4Select = 1 Then
            If No20Select = 0 Then
                No20Select = 1
                No21Select = 1
                No23Select = 1
                No24Select = 1
                lblNo20.BackColor = Color.DarkGray
                lblNo21.BackColor = Color.LightSalmon
                lblNo23.BackColor = Color.LightSalmon
                lblNo24.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo16.Enabled = False
                lblNo22.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No20Select = 1 Then
                No20Select = 0
                No21Select = 0
                No23Select = 0
                No24Select = 0
                lblNo20.BackColor = Color.Black
                lblNo21.BackColor = Color.Red
                lblNo23.BackColor = Color.Red
                lblNo24.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo16.Enabled = True
                lblNo22.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No20Select = 0 Then
                If No17Select = 1 Then
                    lblNo16.Enabled = 0
                    lblNo14.Enabled = 0
                    lblNo18.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo23.Enabled = 0
                    No20Select = 1
                    lblNo20.BackColor = Color.DarkGray
                ElseIf No19Select = 1 Then
                    lblNo16.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo23.Enabled = 0
                    No20Select = 1
                    lblNo20.BackColor = Color.DarkGray
                ElseIf No21Select = 1 Then
                    lblNo18.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo19.Enabled = 0
                    No20Select = 1
                    lblNo20.BackColor = Color.DarkGray
                ElseIf No23Select = 1 Then
                    lblNo22.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo17.Enabled = 0
                    No20Select = 1
                    lblNo20.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo17.Enabled = 1
                    lblNo19.Enabled = 1
                    lblNo21.Enabled = 1
                    lblNo23.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No20Select = 1
                    lblNo20.BackColor = Color.DarkGray
                End If
            ElseIf No20Select = 1 Then
                If No17Select = 1 Then
                    lblNo16.Enabled = 1
                    lblNo14.Enabled = 1
                    lblNo18.Enabled = 1
                    No20Select = 0
                    lblNo20.BackColor = Color.Black
                ElseIf No19Select = 1 Then
                    lblNo16.Enabled = 1
                    lblNo22.Enabled = 1
                    No20Select = 0
                    lblNo20.BackColor = Color.Black
                ElseIf No21Select = 1 Then
                    lblNo18.Enabled = 1
                    lblNo24.Enabled = 1
                    No20Select = 0
                    lblNo20.BackColor = Color.Black
                ElseIf No23Select = 1 Then
                    lblNo22.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo26.Enabled = 1
                    No20Select = 0
                    lblNo20.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No20Select = 0 Then
                Selected = Selected + 1
                No20Select = 1
                lblNo20.BackColor = Color.DarkGray
                Disable()
            ElseIf No20Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo21_Click(sender As Object, e As EventArgs) Handles lblNo21.Click

        If Group2Select = 1 Then
            If No21Select = 0 Then
                If No18Select = 1 Then
                    lblNo15.Enabled = 0
                    lblNo17.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo24.Enabled = 0
                    No21Select = 1
                    lblNo21.BackColor = Color.LightSalmon
                ElseIf No20Select = 1 Then
                    lblNo17.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo18.Enabled = 0
                    No21Select = 1
                    lblNo21.BackColor = Color.LightSalmon
                ElseIf No24Select = 1 Then
                    lblNo27.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo18.Enabled = 0
                    No21Select = 1
                    lblNo21.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo21.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo18.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No21Select = 1
                    lblNo21.BackColor = Color.LightSalmon
                End If
            ElseIf No21Select = 1 Then
                If No18Select = 1 Then
                    lblNo17.Enabled = 1
                    lblNo15.Enabled = 1
                    No21Select = 0
                    lblNo21.BackColor = Color.Red
                ElseIf No20Select = 1 Then
                    lblNo17.Enabled = 1
                    lblNo19.Enabled = 1
                    lblNo23.Enabled = 1
                    No21Select = 0
                    lblNo21.BackColor = Color.Red
                ElseIf No24Select = 1 Then
                    lblNo27.Enabled = 1
                    lblNo23.Enabled = 1
                    No21Select = 0
                    lblNo21.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No21Select = 0 Then
                Selected = Selected + 1
                No21Select = 1
            lblNo21.BackColor = Color.LightSalmon
            Disable()
        ElseIf No21Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo22_Click(sender As Object, e As EventArgs) Handles lblNo22.Click
        If Group6Select = 1 Then
            If No22Select = 0 Then
                No22Select = 1
                No23Select = 1
                No24Select = 1
                No25Select = 1
                No26Select = 1
                No27Select = 1
                lblNo22.BackColor = Color.DarkGray
                lblNo23.BackColor = Color.LightSalmon
                lblNo24.BackColor = Color.DarkGray
                lblNo25.BackColor = Color.LightSalmon
                lblNo26.BackColor = Color.DarkGray
                lblNo27.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo4.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No22Select = 1
                No22Select = 0
                No23Select = 0
                No24Select = 0
                No25Select = 0
                No26Select = 0
                No27Select = 0
                lblNo22.BackColor = Color.Black
                lblNo23.BackColor = Color.Red
                lblNo24.BackColor = Color.Black
                lblNo25.BackColor = Color.Red
                lblNo26.BackColor = Color.Black
                lblNo27.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo4.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No22Select = 0 Then
                No22Select = 1
                No23Select = 1
                No25Select = 1
                No26Select = 1
                lblNo22.BackColor = Color.DarkGray
                lblNo23.BackColor = Color.LightSalmon
                lblNo25.BackColor = Color.LightSalmon
                lblNo26.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No22Select = 1 Then
                No22Select = 0
                No23Select = 0
                No25Select = 0
                No26Select = 0
                lblNo22.BackColor = Color.Black
                lblNo23.BackColor = Color.Red
                lblNo25.BackColor = Color.Red
                lblNo26.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No22Select = 0 Then
                No22Select = 1
                No23Select = 1
                No24Select = 1
                lblNo22.BackColor = Color.DarkGray
                lblNo23.BackColor = Color.LightSalmon
                lblNo24.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo4.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No22Select = 1
                No22Select = 0
                No23Select = 0
                No24Select = 0
                lblNo22.BackColor = Color.Black
                lblNo23.BackColor = Color.Red
                lblNo24.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo4.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No22Select = 0 Then
                If No19Select = 1 Then
                    lblNo16.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo25.Enabled = 0
                    No22Select = 1
                    lblNo22.BackColor = Color.DarkGray
                ElseIf No23Select = 1 Then
                    lblNo20.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo25.Enabled = 0
                    No22Select = 1
                    lblNo22.BackColor = Color.DarkGray
                ElseIf No25Select = 1 Then
                    lblNo28.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo23.Enabled = 0
                    No22Select = 1
                    lblNo22.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo22.Enabled = 1
                    lblNo19.Enabled = 1
                    lblNo25.Enabled = 1
                    lblNo23.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No22Select = 1
                    lblNo22.BackColor = Color.DarkGray
                End If
            ElseIf No22Select = 1 Then
                If No19Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo16.Enabled = 1
                    No22Select = 0
                    lblNo22.BackColor = Color.Black
                ElseIf No23Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo26.Enabled = 1
                    No22Select = 0
                    lblNo22.BackColor = Color.Black
                ElseIf No25Select = 1 Then
                    lblNo26.Enabled = 1
                    lblNo28.Enabled = 1
                    No22Select = 0
                    lblNo22.BackColor = Color.Black
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No22Select = 0 Then
                Selected = Selected + 1
                No22Select = 1
                lblNo22.BackColor = Color.DarkGray
                Disable()
            ElseIf No22Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo23_Click(sender As Object, e As EventArgs) Handles lblNo23.Click

        If Group4Select = 1 Then
            If No23Select = 0 Then
                No23Select = 1
                No24Select = 1
                No26Select = 1
                No27Select = 1
                lblNo23.BackColor = Color.LightSalmon
                lblNo24.BackColor = Color.DarkGray
                lblNo26.BackColor = Color.DarkGray
                lblNo27.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No23Select = 1 Then
                No23Select = 0
                No24Select = 0
                No26Select = 0
                No27Select = 0
                lblNo23.BackColor = Color.Red
                lblNo24.BackColor = Color.Black
                lblNo26.BackColor = Color.Black
                lblNo27.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No23Select = 0 Then
                If No20Select = 1 Then
                    lblNo17.Enabled = 0
                    lblNo19.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    No23Select = 1
                    lblNo23.BackColor = Color.LightSalmon
                ElseIf No22Select = 1 Then
                    lblNo19.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    No23Select = 1
                    lblNo23.BackColor = Color.LightSalmon
                ElseIf No24Select = 1 Then
                    lblNo21.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo26.Enabled = 0
                    No23Select = 1
                    lblNo23.BackColor = Color.LightSalmon
                ElseIf No26Select = 1 Then
                    lblNo25.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo20.Enabled = 0
                    No23Select = 1
                    lblNo23.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo23.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo22.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo26.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No23Select = 1
                    lblNo23.BackColor = Color.LightSalmon
                End If
            ElseIf No23Select = 1 Then
                If No20Select = 1 Then
                    lblNo19.Enabled = 1
                    lblNo17.Enabled = 1
                    lblNo21.Enabled = 1
                    No23Select = 0
                    lblNo23.BackColor = Color.Red
                ElseIf No22Select = 1 Then
                    lblNo19.Enabled = 1
                    lblNo25.Enabled = 1
                    No23Select = 0
                    lblNo23.BackColor = Color.Red
                ElseIf No24Select = 1 Then
                    lblNo21.Enabled = 1
                    lblNo27.Enabled = 1
                    No23Select = 0
                    lblNo23.BackColor = Color.Red
                ElseIf No26Select = 1 Then
                    lblNo25.Enabled = 1
                    lblNo27.Enabled = 1
                    lblNo29.Enabled = 1
                    No23Select = 0
                    lblNo23.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No23Select = 0 Then
                Selected = Selected + 1
                No23Select = 1
                lblNo23.BackColor = Color.LightSalmon
                Disable()
            ElseIf No23Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo24_Click(sender As Object, e As EventArgs) Handles lblNo24.Click
        If Group2Select = 1 Then
            If No24Select = 0 Then
                If No21Select = 1 Then
                    lblNo18.Enabled = 0
                    lblNo20.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo23.Enabled = 0
                    No24Select = 1
                    lblNo24.BackColor = Color.DarkGray
                ElseIf No23Select = 1 Then
                    lblNo20.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo21.Enabled = 0
                    No24Select = 1
                    lblNo24.BackColor = Color.DarkGray
                ElseIf No27Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo26.Enabled = 0
                    No24Select = 1
                    lblNo24.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo21.Enabled = 1
                    lblNo23.Enabled = 1
                    lblNo27.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No24Select = 1
                    lblNo24.BackColor = Color.DarkGray
                End If
            ElseIf No24Select = 1 Then
                If No21Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo18.Enabled = 1
                    No24Select = 0
                    lblNo24.BackColor = Color.Black
                ElseIf No23Select = 1 Then
                    lblNo20.Enabled = 1
                    lblNo22.Enabled = 1
                    lblNo26.Enabled = 1
                    No24Select = 0
                    lblNo24.BackColor = Color.Black
                ElseIf No27Select = 1 Then
                    lblNo26.Enabled = 1
                    lblNo30.Enabled = 1
                    No24Select = 0
                    lblNo24.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No24Select = 0 Then
                Selected = Selected + 1
                No24Select = 1
                lblNo24.BackColor = Color.DarkGray
                Disable()
            ElseIf No24Select = 1 Then
                Reset()
            End If

        End If

    End Sub

    Private Sub lblNo25_Click(sender As Object, e As EventArgs) Handles lblNo25.Click
        If Group6Select = 1 Then
            If No25Select = 0 Then
                No25Select = 1
                No26Select = 1
                No27Select = 1
                No28Select = 1
                No29Select = 1
                No30Select = 1
                lblNo25.BackColor = Color.LightSalmon
                lblNo26.BackColor = Color.DarkGray
                lblNo27.BackColor = Color.LightSalmon
                lblNo28.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo30.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo4.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
            ElseIf No25Select = 1
                No25Select = 0
                No26Select = 0
                No27Select = 0
                No28Select = 0
                No29Select = 0
                No30Select = 0
                lblNo25.BackColor = Color.Red
                lblNo26.BackColor = Color.Black
                lblNo27.BackColor = Color.Red
                lblNo28.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo30.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo4.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
            End If
        ElseIf Group4Select = 1 Then
            If No25Select = 0 Then
                No25Select = 1
                No26Select = 1
                No28Select = 1
                No29Select = 1
                lblNo25.BackColor = Color.LightSalmon
                lblNo26.BackColor = Color.DarkGray
                lblNo28.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo22.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No25Select = 1 Then
                No25Select = 0
                No26Select = 0
                No28Select = 0
                No29Select = 0
                lblNo25.BackColor = Color.Red
                lblNo26.BackColor = Color.Black
                lblNo28.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo22.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No25Select = 0 Then
                No25Select = 1
                No26Select = 1
                No27Select = 1
                lblNo25.BackColor = Color.LightSalmon
                lblNo26.BackColor = Color.DarkGray
                lblNo27.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo4.Enabled = False
                lblNo28.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No25Select = 1
                No25Select = 0
                No26Select = 0
                No27Select = 0
                lblNo25.BackColor = Color.Red
                lblNo26.BackColor = Color.Black
                lblNo27.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo4.Enabled = True
                lblNo28.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No25Select = 0 Then
                If No22Select = 1 Then
                    lblNo19.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo28.Enabled = 0
                    No25Select = 1
                    lblNo25.BackColor = Color.DarkGray
                ElseIf No26Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo28.Enabled = 0
                    No25Select = 1
                    lblNo25.BackColor = Color.DarkGray
                ElseIf No28Select = 1 Then
                    lblNo29.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo26.Enabled = 0
                    No25Select = 1
                    lblNo25.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo25.Enabled = 1
                    lblNo22.Enabled = 1
                    lblNo26.Enabled = 1
                    lblNo28.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No25Select = 1
                    lblNo25.BackColor = Color.DarkGray
                End If
            ElseIf No25Select = 1 Then
                If No22Select = 1 Then
                    lblNo23.Enabled = 1
                    lblNo19.Enabled = 1
                    No25Select = 0
                    lblNo25.BackColor = Color.Black
                ElseIf No26Select = 1 Then
                    lblNo23.Enabled = 1
                    lblNo27.Enabled = 1
                    lblNo29.Enabled = 1
                    No25Select = 0
                    lblNo25.BackColor = Color.Black
                ElseIf No28Select = 1 Then
                    lblNo29.Enabled = 1
                    lblNo31.Enabled = 1
                    No25Select = 0
                    lblNo25.BackColor = Color.Black
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No25Select = 0 Then
                Selected = Selected + 1
                No25Select = 1
                lblNo25.BackColor = Color.LightSalmon
                Disable()
            ElseIf No25Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo26_Click(sender As Object, e As EventArgs) Handles lblNo26.Click

        If Group4Select = 1 Then
            If No26Select = 0 Then
                No26Select = 1
                No27Select = 1
                No29Select = 1
                No30Select = 1
                lblNo26.BackColor = Color.DarkGray
                lblNo27.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo30.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo22.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No26Select = 1 Then
                No26Select = 0
                No27Select = 0
                No29Select = 0
                No30Select = 0
                lblNo26.BackColor = Color.Black
                lblNo27.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo30.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo22.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No26Select = 0 Then
                If No23Select = 1 Then
                    lblNo20.Enabled = 0
                    lblNo22.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo29.Enabled = 0
                    No26Select = 1
                    lblNo26.BackColor = Color.DarkGray
                ElseIf No25Select = 1 Then
                    lblNo22.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo29.Enabled = 0
                    No26Select = 1
                    lblNo26.BackColor = Color.DarkGray
                ElseIf No27Select = 1 Then
                    lblNo24.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo23.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo29.Enabled = 0
                    No26Select = 1
                    lblNo26.BackColor = Color.DarkGray
                ElseIf No29Select = 1 Then
                    lblNo28.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo23.Enabled = 0
                    No26Select = 1
                    lblNo26.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo26.Enabled = 1
                    lblNo27.Enabled = 1
                    lblNo25.Enabled = 1
                    lblNo23.Enabled = 1
                    lblNo29.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No26Select = 1
                    lblNo26.BackColor = Color.DarkGray
                End If
            ElseIf No26Select = 1 Then
                If No23Select = 1 Then
                    lblNo22.Enabled = 1
                    lblNo20.Enabled = 1
                    lblNo24.Enabled = 1
                    No26Select = 0
                    lblNo26.BackColor = Color.Black
                ElseIf No25Select = 1 Then
                    lblNo22.Enabled = 1
                    lblNo28.Enabled = 1
                    No26Select = 0
                    lblNo26.BackColor = Color.Black
                ElseIf No27Select = 1 Then
                    lblNo24.Enabled = 1
                    lblNo30.Enabled = 1
                    No26Select = 0
                    lblNo26.BackColor = Color.Black
                ElseIf No29Select = 1 Then
                    lblNo28.Enabled = 1
                    lblNo30.Enabled = 1
                    lblNo32.Enabled = 1
                    No26Select = 0
                    lblNo26.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No26Select = 0 Then
                Selected = Selected + 1
                No26Select = 1
                lblNo26.BackColor = Color.DarkGray
                Disable()
            ElseIf No26Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo27_Click(sender As Object, e As EventArgs) Handles lblNo27.Click
        If Group2Select = 1 Then
            If No27Select = 0 Then
                If No24Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo21.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo30.Enabled = 0
                    No27Select = 1
                    lblNo27.BackColor = Color.LightSalmon
                ElseIf No30Select = 1 Then
                    lblNo33.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    No27Select = 1
                    lblNo27.BackColor = Color.LightSalmon
                ElseIf No26Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo24.Enabled = 0
                    lblNo30.Enabled = 0
                    No27Select = 1
                    lblNo27.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo27.Enabled = 1
                    lblNo24.Enabled = 1
                    lblNo26.Enabled = 1
                    lblNo30.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No27Select = 1
                    lblNo27.BackColor = Color.LightSalmon
                End If
            ElseIf No27Select = 1 Then
                If No24Select = 1 Then
                    lblNo21.Enabled = 1
                    lblNo23.Enabled = 1
                    No27Select = 0
                    lblNo27.BackColor = Color.Red
                ElseIf No26Select = 1 Then
                    lblNo23.Enabled = 1
                    lblNo25.Enabled = 1
                    lblNo29.Enabled = 1
                    No27Select = 0
                    lblNo27.BackColor = Color.Red
                ElseIf No30Select = 1 Then
                    lblNo33.Enabled = 1
                    lblNo29.Enabled = 1
                    No27Select = 0
                    lblNo27.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No27Select = 0 Then
                Selected = Selected + 1
                No27Select = 1
            lblNo27.BackColor = Color.LightSalmon
            Disable()
        ElseIf No27Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo28_Click(sender As Object, e As EventArgs) Handles lblNo28.Click
        If Group6Select = 1 Then
            If No28Select = 0 Then
                No28Select = 1
                No29Select = 1
                No30Select = 1
                No31Select = 1
                No32Select = 1
                No33Select = 1
                lblNo28.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo30.BackColor = Color.LightSalmon
                lblNo31.BackColor = Color.DarkGray
                lblNo32.BackColor = Color.LightSalmon
                lblNo33.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo4.Enabled = False
                lblNo31.Enabled = False
            ElseIf No28Select = 1
                No28Select = 0
                No29Select = 0
                No30Select = 0
                No31Select = 0
                No32Select = 0
                No33Select = 0
                lblNo28.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo30.BackColor = Color.Red
                lblNo31.BackColor = Color.Black
                lblNo32.BackColor = Color.Red
                lblNo33.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo4.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No28Select = 0 Then
                No28Select = 1
                No29Select = 1
                No31Select = 1
                No32Select = 1
                lblNo28.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo31.BackColor = Color.DarkGray
                lblNo32.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo22.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No28Select = 1 Then
                No28Select = 0
                No29Select = 0
                No31Select = 0
                No32Select = 0
                lblNo28.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo31.BackColor = Color.Black
                lblNo32.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo22.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No28Select = 0 Then
                No28Select = 1
                No29Select = 1
                No30Select = 1
                lblNo28.BackColor = Color.LightSalmon
                lblNo29.BackColor = Color.DarkGray
                lblNo30.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo4.Enabled = False
                lblNo31.Enabled = False
                lblNo34.Enabled = False
            ElseIf No28Select = 1
                No28Select = 0
                No29Select = 0
                No30Select = 0
                lblNo28.BackColor = Color.Red
                lblNo29.BackColor = Color.Black
                lblNo30.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo4.Enabled = True
                lblNo31.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No28Select = 0 Then
                If No25Select = 1 Then
                    lblNo22.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo29.Enabled = 0
                    No28Select = 1
                    lblNo28.BackColor = Color.LightSalmon
                ElseIf No29Select = 1 Then
                    lblNo26.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo25.Enabled = 0
                    No28Select = 1
                    lblNo28.BackColor = Color.LightSalmon
                ElseIf No31Select = 1 Then
                    lblNo32.Enabled = 0
                    lblNo34.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo25.Enabled = 0
                    No28Select = 1
                    lblNo28.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo28.Enabled = 1
                    lblNo25.Enabled = 1
                    lblNo29.Enabled = 1
                    lblNo31.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No28Select = 1
                    lblNo28.BackColor = Color.LightSalmon
                End If
            ElseIf No28Select = 1 Then
                If No25Select = 1 Then
                    lblNo26.Enabled = 1
                    lblNo22.Enabled = 1
                    No28Select = 0
                    lblNo28.BackColor = Color.Red
                ElseIf No29Select = 1 Then
                    lblNo26.Enabled = 1
                    lblNo30.Enabled = 1
                    lblNo32.Enabled = 1
                    No28Select = 0
                    lblNo28.BackColor = Color.Red
                ElseIf No31Select = 1 Then
                    lblNo34.Enabled = 1
                    lblNo32.Enabled = 1
                    No28Select = 0
                    lblNo28.BackColor = Color.Red
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No28Select = 0 Then
                Selected = Selected + 1
                No28Select = 1
                lblNo28.BackColor = Color.LightSalmon
                Disable()
            ElseIf No28Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo29_Click(sender As Object, e As EventArgs) Handles lblNo29.Click
        If Group4Select = 1 Then
            If No29Select = 0 Then
                No29Select = 1
                No30Select = 1
                No32Select = 1
                No33Select = 1
                lblNo29.BackColor = Color.DarkGray
                lblNo30.BackColor = Color.LightSalmon
                lblNo32.BackColor = Color.LightSalmon
                lblNo33.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo22.Enabled = False
                lblNo31.Enabled = False
                lblNo32.Enabled = False
            ElseIf No29Select = 1 Then
                No29Select = 0
                No30Select = 0
                No32Select = 0
                No33Select = 0
                lblNo29.BackColor = Color.Black
                lblNo30.BackColor = Color.Red
                lblNo32.BackColor = Color.Red
                lblNo33.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo22.Enabled = True
                lblNo31.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No29Select = 0 Then
                If No26Select = 1 Then
                    lblNo23.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo32.Enabled = 0
                    No29Select = 1
                    lblNo29.BackColor = Color.DarkGray
                ElseIf No28Select = 1 Then
                    lblNo25.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo26.Enabled = 0
                    No29Select = 1
                    lblNo29.BackColor = Color.DarkGray
                ElseIf No30Select = 1 Then
                    lblNo27.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo26.Enabled = 0
                    No29Select = 1
                    lblNo29.BackColor = Color.DarkGray
                ElseIf No32Select = 1 Then
                    lblNo31.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo35.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo26.Enabled = 0
                    No29Select = 1
                    lblNo29.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo29.Enabled = 1
                    lblNo2.Enabled = 1
                    lblNo4.Enabled = 1
                    lblNo6.Enabled = 1
                    lblNo8.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No29Select = 1
                    lblNo29.BackColor = Color.DarkGray
                End If
            ElseIf No29Select = 1 Then
                If No26Select = 1 Then
                    lblNo25.Enabled = 1
                    lblNo23.Enabled = 1
                    lblNo27.Enabled = 1
                    No29Select = 0
                    lblNo29.BackColor = Color.Black
                ElseIf No28Select = 1 Then
                    lblNo25.Enabled = 1
                    lblNo31.Enabled = 1
                    No29Select = 0
                    lblNo29.BackColor = Color.Black
                ElseIf No30Select = 1 Then
                    lblNo27.Enabled = 1
                    lblNo33.Enabled = 1
                    No29Select = 0
                    lblNo29.BackColor = Color.Black
                ElseIf No32Select = 1 Then
                    lblNo31.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo35.Enabled = 1
                    No29Select = 0
                    lblNo29.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No29Select = 0 Then
                Selected = Selected + 1
                No29Select = 1
                lblNo29.BackColor = Color.DarkGray
                Disable()
            ElseIf No29Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo30_Click(sender As Object, e As EventArgs) Handles lblNo30.Click
        If Group2Select = 1 Then
            If No30Select = 0 Then
                If No27Select = 1 Then
                    lblNo24.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo33.Enabled = 0
                    No30Select = 1
                    lblNo30.BackColor = Color.LightSalmon
                ElseIf No29Select = 1 Then
                    lblNo26.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo33.Enabled = 0
                    No30Select = 1
                    lblNo30.BackColor = Color.LightSalmon
                ElseIf No33Select = 1 Then
                    lblNo32.Enabled = 0
                    lblNo36.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo27.Enabled = 0
                    No30Select = 1
                    lblNo30.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo30.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo29.Enabled = 1
                    lblNo27.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No30Select = 1
                    lblNo30.BackColor = Color.LightSalmon
                End If
            ElseIf No30Select = 1 Then
                If No27Select = 1 Then
                    lblNo24.Enabled = 1
                    lblNo26.Enabled = 1
                    No30Select = 0
                    lblNo30.BackColor = Color.Red
                ElseIf No29Select = 1 Then
                    lblNo26.Enabled = 1
                    lblNo28.Enabled = 1
                    lblNo32.Enabled = 1
                    No30Select = 0
                    lblNo30.BackColor = Color.Red
                ElseIf No33Select = 1 Then
                    lblNo32.Enabled = 1
                    lblNo36.Enabled = 1
                    No30Select = 0
                    lblNo30.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No30Select = 0 Then
                Selected = Selected + 1
                No30Select = 1
            lblNo30.BackColor = Color.LightSalmon
            Disable()
        ElseIf No30Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo31_Click(sender As Object, e As EventArgs) Handles lblNo31.Click
        If Group6Select = 1 Then
            If No31Select = 0 Then
                No31Select = 1
                No32Select = 1
                No33Select = 1
                No34Select = 1
                No35Select = 1
                No36Select = 1
                lblNo31.BackColor = Color.DarkGray
                lblNo32.BackColor = Color.LightSalmon
                lblNo33.BackColor = Color.DarkGray
                lblNo34.BackColor = Color.LightSalmon
                lblNo35.BackColor = Color.DarkGray
                lblNo36.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo4.Enabled = False
            ElseIf No31Select = 1
                No31Select = 0
                No32Select = 0
                No33Select = 0
                No34Select = 0
                No35Select = 0
                No36Select = 0
                lblNo31.BackColor = Color.Black
                lblNo32.BackColor = Color.Red
                lblNo33.BackColor = Color.Black
                lblNo34.BackColor = Color.Red
                lblNo35.BackColor = Color.Black
                lblNo36.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo4.Enabled = True
            End If

        ElseIf Group4Select = 1 Then
            If No31Select = 0 Then
                No31Select = 1
                No32Select = 1
                No34Select = 1
                No35Select = 1
                lblNo31.BackColor = Color.DarkGray
                lblNo32.BackColor = Color.LightSalmon
                lblNo34.BackColor = Color.LightSalmon
                lblNo35.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo22.Enabled = False
                lblNo32.Enabled = False
            ElseIf No31Select = 1 Then
                No31Select = 0
                No32Select = 0
                No34Select = 0
                No35Select = 0
                lblNo31.BackColor = Color.Black
                lblNo32.BackColor = Color.Red
                lblNo34.BackColor = Color.Red
                lblNo35.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo22.Enabled = True
                lblNo32.Enabled = True
            End If

        ElseIf Group3Select = 1 Then
            If No31Select = 0 Then
                No31Select = 1
                No32Select = 1
                No33Select = 1
                lblNo31.BackColor = Color.DarkGray
                lblNo32.BackColor = Color.LightSalmon
                lblNo33.BackColor = Color.DarkGray
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo4.Enabled = False
                lblNo34.Enabled = False
            ElseIf No31Select = 1
                No31Select = 0
                No32Select = 0
                No33Select = 0
                lblNo31.BackColor = Color.Black
                lblNo32.BackColor = Color.Red
                lblNo33.BackColor = Color.Black
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo4.Enabled = True
                lblNo34.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No31Select = 0 Then
                If No28Select = 1 Then
                    lblNo29.Enabled = 0
                    lblNo25.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo34.Enabled = 0
                    No31Select = 1
                    lblNo31.BackColor = Color.DarkGray
                ElseIf No32Select = 1 Then
                    lblNo29.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo35.Enabled = 0
                    lblNo28.Enabled = 0
                    lblNo34.Enabled = 0
                    No31Select = 1
                    lblNo31.BackColor = Color.DarkGray
                ElseIf No34Select = 1 Then
                    lblNo35.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo28.Enabled = 0
                    No31Select = 1
                    lblNo31.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo31.Enabled = 1
                    lblNo28.Enabled = 1
                    lblNo32.Enabled = 1
                    lblNo34.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No31Select = 1
                    lblNo31.BackColor = Color.DarkGray
                End If
            ElseIf No31Select = 1 Then
                If No28Select = 1 Then
                    lblNo29.Enabled = 1
                    lblNo25.Enabled = 1
                    No31Select = 0
                    lblNo31.BackColor = Color.Black
                ElseIf No32Select = 1 Then
                    lblNo29.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo35.Enabled = 1
                    No31Select = 0
                    lblNo31.BackColor = Color.Black
                ElseIf No34Select = 1 Then
                    lblNo35.Enabled = 1
                    No31Select = 0
                    lblNo31.BackColor = Color.Black
                Else
                    Reset()
                        Group2Select = 1
                        lblMessages.Text = "Please select your first number"
                        lblGroup6.Enabled = 0
                        lblGroup4.Enabled = 0
                        lblGroup3.Enabled = 0
                        lblHalf1.Enabled = 0
                        lblHalf2.Enabled = 0
                        lblOdd.Enabled = 0
                        lblEven.Enabled = 0
                        lblRed.Enabled = 0
                        lblBlack.Enabled = 0
                        lblDozen1.Enabled = 0
                        lblDozen2.Enabled = 0
                        lblDozen3.Enabled = 0
                        lblColumn1.Enabled = 0
                        lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
                End If

        Else
            If No31Select = 0 Then
                Selected = Selected + 1
                No31Select = 1
                lblNo31.BackColor = Color.DarkGray
                Disable()
            ElseIf No31Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo32_Click(sender As Object, e As EventArgs) Handles lblNo32.Click
        If Group4Select = 1 Then
            If No32Select = 0 Then
                No32Select = 1
                No33Select = 1
                No35Select = 1
                No36Select = 1
                lblNo32.BackColor = Color.LightSalmon
                lblNo33.BackColor = Color.DarkGray
                lblNo35.BackColor = Color.DarkGray
                lblNo36.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo2.Enabled = False
                lblNo4.Enabled = False
                lblNo5.Enabled = False
                lblNo7.Enabled = False
                lblNo8.Enabled = False
                lblNo11.Enabled = False
                lblNo13.Enabled = False
                lblNo14.Enabled = False
                lblNo10.Enabled = False
                lblNo17.Enabled = False
                lblNo19.Enabled = False
                lblNo20.Enabled = False
                lblNo16.Enabled = False
                lblNo23.Enabled = False
                lblNo25.Enabled = False
                lblNo26.Enabled = False
                lblNo28.Enabled = False
                lblNo29.Enabled = False
                lblNo31.Enabled = False
                lblNo22.Enabled = False
            ElseIf No32Select = 1 Then
                No32Select = 0
                No33Select = 0
                No35Select = 0
                No36Select = 0
                lblNo32.BackColor = Color.Red
                lblNo33.BackColor = Color.Black
                lblNo35.BackColor = Color.Black
                lblNo36.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo4.Enabled = True
                lblNo2.Enabled = True
                lblNo5.Enabled = True
                lblNo7.Enabled = True
                lblNo8.Enabled = True
                lblNo11.Enabled = True
                lblNo13.Enabled = True
                lblNo14.Enabled = True
                lblNo10.Enabled = True
                lblNo17.Enabled = True
                lblNo19.Enabled = True
                lblNo20.Enabled = True
                lblNo16.Enabled = True
                lblNo23.Enabled = True
                lblNo25.Enabled = True
                lblNo26.Enabled = True
                lblNo28.Enabled = True
                lblNo29.Enabled = True
                lblNo31.Enabled = True
                lblNo22.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No32Select = 0 Then
                If No29Select = 1 Then
                    lblNo28.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo26.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo35.Enabled = 0
                    No32Select = 1
                    lblNo32.BackColor = Color.LightSalmon
                ElseIf No31Select = 1 Then
                    lblNo28.Enabled = 0
                    lblNo34.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo35.Enabled = 0
                    No32Select = 1
                    lblNo32.BackColor = Color.LightSalmon
                ElseIf No33Select = 1 Then
                    lblNo36.Enabled = 0
                    lblNo30.Enabled = 0
                    lblNo29.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo35.Enabled = 0
                    No32Select = 1
                    lblNo32.BackColor = Color.LightSalmon
                ElseIf No35Select = 1 Then
                    lblNo34.Enabled = 0
                    lblNo36.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo29.Enabled = 0
                    No32Select = 1
                    lblNo32.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo32.Enabled = 1
                    lblNo31.Enabled = 1
                    lblNo29.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo35.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No32Select = 1
                    lblNo32.BackColor = Color.LightSalmon
                End If
            ElseIf No32Select = 1 Then
                If No29Select = 1 Then
                    lblNo28.Enabled = 1
                    lblNo30.Enabled = 1
                    lblNo26.Enabled = 1
                    No32Select = 0
                    lblNo32.BackColor = Color.Red
                ElseIf No31Select = 1 Then
                    lblNo28.Enabled = 1
                    lblNo24.Enabled = 1
                    No32Select = 0
                    lblNo32.BackColor = Color.Red
                ElseIf No33Select = 1 Then
                    lblNo30.Enabled = 1
                    lblNo36.Enabled = 1
                    No32Select = 0
                    lblNo32.BackColor = Color.Red
                ElseIf No35Select = 1 Then
                    lblNo34.Enabled = 1
                    lblNo36.Enabled = 1
                    No32Select = 0
                    lblNo32.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No32Select = 0 Then
                Selected = Selected + 1
                No32Select = 1
                lblNo32.BackColor = Color.LightSalmon
                Disable()
            ElseIf No32Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo33_Click(sender As Object, e As EventArgs) Handles lblNo33.Click
        If Group2Select = 1 Then
            If No33Select = 0 Then
                If No36Select = 1 Then
                    lblNo35.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo30.Enabled = 0
                    No33Select = 1
                    lblNo33.BackColor = Color.DarkGray
                ElseIf No32Select = 1 Then
                    lblNo29.Enabled = 0
                    lblNo31.Enabled = 0
                    lblNo35.Enabled = 0
                    lblNo36.Enabled = 0
                    lblNo30.Enabled = 0
                    No33Select = 1
                    lblNo33.BackColor = Color.DarkGray
                ElseIf No30Select = 1 Then
                    lblNo29.Enabled = 0
                    lblNo27.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo36.Enabled = 0
                    No33Select = 1
                    lblNo33.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo36.Enabled = 1
                    lblNo32.Enabled = 1
                    lblNo30.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No33Select = 1
                    lblNo33.BackColor = Color.DarkGray
                End If
            ElseIf No33Select = 1 Then
                If No36Select = 1 Then
                    lblNo35.Enabled = 1
                    No33Select = 0
                    lblNo33.BackColor = Color.Black
                ElseIf No32Select = 1 Then
                    lblNo29.Enabled = 1
                    lblNo31.Enabled = 1
                    lblNo35.Enabled = 1
                    No33Select = 0
                    lblNo33.BackColor = Color.Black
                ElseIf No30Select = 1 Then
                    lblNo29.Enabled = 1
                    lblNo27.Enabled = 1
                    No33Select = 0
                    lblNo33.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No33Select = 0 Then
                Selected = Selected + 1
                No33Select = 1
            lblNo33.BackColor = Color.DarkGray
            Disable()
        ElseIf No33Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo34_Click(sender As Object, e As EventArgs) Handles lblNo34.Click
        If Group3Select = 1 Then
            If No34Select = 0 Then
                No34Select = 1
                No35Select = 1
                No36Select = 1
                lblNo34.BackColor = Color.LightSalmon
                lblNo35.BackColor = Color.DarkGray
                lblNo36.BackColor = Color.LightSalmon
                lblNo1.Enabled = False
                lblNo7.Enabled = False
                lblNo10.Enabled = False
                lblNo13.Enabled = False
                lblNo16.Enabled = False
                lblNo19.Enabled = False
                lblNo22.Enabled = False
                lblNo25.Enabled = False
                lblNo28.Enabled = False
                lblNo4.Enabled = False
                lblNo31.Enabled = False
            ElseIf No34Select = 1
                No34Select = 0
                No35Select = 0
                No36Select = 0
                lblNo34.BackColor = Color.Red
                lblNo35.BackColor = Color.Black
                lblNo36.BackColor = Color.Red
                lblNo1.Enabled = True
                lblNo7.Enabled = True
                lblNo10.Enabled = True
                lblNo13.Enabled = True
                lblNo16.Enabled = True
                lblNo19.Enabled = True
                lblNo22.Enabled = True
                lblNo25.Enabled = True
                lblNo28.Enabled = True
                lblNo4.Enabled = True
                lblNo31.Enabled = True
            End If

        ElseIf Group2Select = 1 Then
            If No34Select = 0 Then
                If No35Select = 1 Then
                    lblNo36.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo31.Enabled = 0
                    No34Select = 1
                    lblNo34.BackColor = Color.LightSalmon
                ElseIf No31Select = 1 Then
                    lblNo28.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo35.Enabled = 0
                    No34Select = 1
                    lblNo34.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo34.Enabled = 1
                    lblNo35.Enabled = 1
                    lblNo31.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No34Select = 1
                    lblNo34.BackColor = Color.LightSalmon
                End If
            ElseIf No34Select = 1 Then
                If No35Select = 1 Then
                    lblNo32.Enabled = 1
                    lblNo36.Enabled = 1
                    No34Select = 0
                    lblNo34.BackColor = Color.Red
                ElseIf No31Select = 1 Then
                    lblNo28.Enabled = 1
                    lblNo32.Enabled = 1
                    No34Select = 0
                    lblNo34.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No34Select = 0 Then
                Selected = Selected + 1
                No34Select = 1
                lblNo34.BackColor = Color.LightSalmon
                Disable()
            ElseIf No34Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo35_Click(sender As Object, e As EventArgs) Handles lblNo35.Click

        If Group2Select = 1 Then
            If No35Select = 0 Then
                If No34Select = 1 Then
                    lblNo31.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo36.Enabled = 0
                    No35Select = 1
                    Group2Select = 1
                    lblNo35.BackColor = Color.DarkGray
                ElseIf No32Select = 1 Then
                    lblNo31.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo34.Enabled = 0
                    lblNo36.Enabled = 0
                    No35Select = 1
                    Group2Select = 1
                    lblNo35.BackColor = Color.DarkGray
                ElseIf No36Select = 1 Then
                    lblNo33.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo34.Enabled = 0
                    No35Select = 1
                    Group2Select = 1
                    lblNo35.BackColor = Color.DarkGray
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo35.Enabled = 1
                    lblNo34.Enabled = 1
                    lblNo32.Enabled = 1
                    lblNo36.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No35Select = 1
                    Group2Select = 1
                    lblNo35.BackColor = Color.DarkGray
                End If
            ElseIf No35Select = 1 Then
                If No34Select = 1 Then
                    lblNo31.Enabled = 1
                    No35Select = 0
                    Group2Select = 1
                    lblNo35.BackColor = Color.Black
                ElseIf No32Select = 1 Then
                    lblNo31.Enabled = 1
                    lblNo33.Enabled = 1
                    lblNo29.Enabled = 1
                    No35Select = 0
                    Group2Select = 1
                    lblNo35.BackColor = Color.Black
                ElseIf No36Select = 1 Then
                    lblNo33.Enabled = 1
                    No35Select = 0
                    Group2Select = 1
                    lblNo35.BackColor = Color.Black
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
            If No35Select = 0 Then
                Selected = Selected + 1
                No35Select = 1
            lblNo35.BackColor = Color.DarkGray
            Disable()
        ElseIf No35Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub lblNo36_Click(sender As Object, e As EventArgs) Handles lblNo36.Click
        If Group2Select = 1 Then
            If No36Select = 0 Then
                If No33Select = 1 Then
                    lblNo30.Enabled = 0
                    lblNo32.Enabled = 0
                    lblNo35.Enabled = 0
                    No36Select = 1
                    lblNo36.BackColor = Color.LightSalmon
                ElseIf No35Select = 1 Then
                    lblNo32.Enabled = 0
                    lblNo33.Enabled = 0
                    lblNo34.Enabled = 0
                    No36Select = 1
                    lblNo36.BackColor = Color.LightSalmon
                Else
                    Disable()
                    lblGroup2.Enabled = 1
                    lblNo36.Enabled = 1
                    lblNo35.Enabled = 1
                    lblNo33.Enabled = 1
                    lblMessages.Text = "Please select your second number from the enabled options"
                    No36Select = 1
                    lblNo36.BackColor = Color.LightSalmon
                End If
            ElseIf No36Select = 1 Then
                If No33Select = 1 Then
                    lblNo32.Enabled = 1
                    lblNo30.Enabled = 1
                    No36Select = 0
                    lblNo36.BackColor = Color.Red
                ElseIf No35Select = 1 Then
                    lblNo32.Enabled = 1
                    lblNo34.Enabled = 1
                    No36Select = 0
                    lblNo36.BackColor = Color.Red
                Else
                    Reset()
                    Group2Select = 1
                    lblMessages.Text = "Please select your first number"
                    lblGroup6.Enabled = 0
                    lblGroup4.Enabled = 0
                    lblGroup3.Enabled = 0
                    lblHalf1.Enabled = 0
                    lblHalf2.Enabled = 0
                    lblOdd.Enabled = 0
                    lblEven.Enabled = 0
                    lblRed.Enabled = 0
                    lblBlack.Enabled = 0
                    lblDozen1.Enabled = 0
                    lblDozen2.Enabled = 0
                    lblDozen3.Enabled = 0
                    lblColumn1.Enabled = 0
                    lblColumn2.Enabled = 0
                    lblColumn3.Enabled = 0
                    Selected = 2
                End If
            End If

        Else
        If No36Select = 0 Then
                Selected = Selected + 1
                No36Select = 1
            lblNo36.BackColor = Color.LightSalmon
            Disable()
        ElseIf No36Select = 1 Then
                Reset()
            End If
        End If
    End Sub

    Private Sub btnPlaceBet_Click(sender As Object, e As EventArgs) Handles btnPlaceBet.Click

        ' If an option is not selected, displays following error
        If Selected = 0 Then
            lblMessages.Text = "Please Select an option from the board To proceed"
        Else
            ' Runs the code to determine the rolled number and whether the player has won or not
            SpinAndWin()
        End If

    End Sub

    Private Sub lblBlack_Click(sender As Object, e As EventArgs) Handles lblBlack.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If BlackSelect = 0 Then
            ' Changes testing label Selected to show 18 numbers 
            Selected = Selected + 18
            BlackSelect = 1
            No2Select = 1
            No4Select = 1
            No6Select = 1
            No8Select = 1
            No10Select = 1
            No11Select = 1
            No13Select = 1
            No15Select = 1
            No17Select = 1
            No19Select = 1
            No20Select = 1
            No22Select = 1
            No24Select = 1
            No26Select = 1
            No29Select = 1
            No31Select = 1
            No33Select = 1
            No35Select = 1
            lblBlack.BackColor = Color.DarkGray
            lblNo2.BackColor = Color.DarkGray
            lblNo4.BackColor = Color.DarkGray
            lblNo6.BackColor = Color.DarkGray
            lblNo8.BackColor = Color.DarkGray
            lblNo10.BackColor = Color.DarkGray
            lblNo11.BackColor = Color.DarkGray
            lblNo13.BackColor = Color.DarkGray
            lblNo15.BackColor = Color.DarkGray
            lblNo17.BackColor = Color.DarkGray
            lblNo19.BackColor = Color.DarkGray
            lblNo20.BackColor = Color.DarkGray
            lblNo22.BackColor = Color.DarkGray
            lblNo24.BackColor = Color.DarkGray
            lblNo26.BackColor = Color.DarkGray
            lblNo29.BackColor = Color.DarkGray
            lblNo31.BackColor = Color.DarkGray
            lblNo33.BackColor = Color.DarkGray
            lblNo35.BackColor = Color.DarkGray
            Odds = 1
            Disable()
        ElseIf BlackSelect = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblRed_Click(sender As Object, e As EventArgs) Handles lblRed.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If RedSelect = 0 Then
            Selected = Selected + 18
            RedSelect = 1
            No1Select = 1
            No3Select = 1
            No5Select = 1
            No7Select = 1
            No9Select = 1
            No12Select = 1
            No14Select = 1
            No16Select = 1
            No18Select = 1
            No21Select = 1
            No23Select = 1
            No25Select = 1
            No27Select = 1
            No28Select = 1
            No30Select = 1
            No32Select = 1
            No34Select = 1
            No36Select = 1
            lblRed.BackColor = Color.LightSalmon
            lblNo1.BackColor = Color.LightSalmon
            lblNo3.BackColor = Color.LightSalmon
            lblNo5.BackColor = Color.LightSalmon
            lblNo7.BackColor = Color.LightSalmon
            lblNo9.BackColor = Color.LightSalmon
            lblNo12.BackColor = Color.LightSalmon
            lblNo14.BackColor = Color.LightSalmon
            lblNo16.BackColor = Color.LightSalmon
            lblNo18.BackColor = Color.LightSalmon
            lblNo21.BackColor = Color.LightSalmon
            lblNo23.BackColor = Color.LightSalmon
            lblNo25.BackColor = Color.LightSalmon
            lblNo27.BackColor = Color.LightSalmon
            lblNo28.BackColor = Color.LightSalmon
            lblNo30.BackColor = Color.LightSalmon
            lblNo32.BackColor = Color.LightSalmon
            lblNo34.BackColor = Color.LightSalmon
            lblNo36.BackColor = Color.LightSalmon
            Odds = 1
            Disable()
        ElseIf RedSelect = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblEven_Click(sender As Object, e As EventArgs) Handles lblEven.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If EvenSelect = 0 Then
            Selected = Selected + 18
            EvenSelect = 1
            No2Select = 1
            No4Select = 1
            No6Select = 1
            No8Select = 1
            No10Select = 1
            No12Select = 1
            No14Select = 1
            No16Select = 1
            No18Select = 1
            No20Select = 1
            No22Select = 1
            No24Select = 1
            No26Select = 1
            No28Select = 1
            No30Select = 1
            No32Select = 1
            No34Select = 1
            No36Select = 1
            lblEven.BackColor = Color.Turquoise
            lblNo2.BackColor = Color.DarkGray
            lblNo4.BackColor = Color.DarkGray
            lblNo6.BackColor = Color.DarkGray
            lblNo8.BackColor = Color.DarkGray
            lblNo10.BackColor = Color.DarkGray
            lblNo12.BackColor = Color.LightSalmon
            lblNo14.BackColor = Color.LightSalmon
            lblNo16.BackColor = Color.LightSalmon
            lblNo18.BackColor = Color.LightSalmon
            lblNo20.BackColor = Color.DarkGray
            lblNo22.BackColor = Color.DarkGray
            lblNo24.BackColor = Color.DarkGray
            lblNo26.BackColor = Color.DarkGray
            lblNo28.BackColor = Color.LightSalmon
            lblNo30.BackColor = Color.LightSalmon
            lblNo32.BackColor = Color.LightSalmon
            lblNo34.BackColor = Color.LightSalmon
            lblNo36.BackColor = Color.LightSalmon
            Odds = 1
            Disable()
        ElseIf EvenSelect = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblOdd_Click(sender As Object, e As EventArgs) Handles lblOdd.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If OddSelect = 0 Then
            Selected = Selected + 18
            OddSelect = 1
            No1Select = 1
            No3Select = 1
            No5Select = 1
            No7Select = 1
            No9Select = 1
            No11Select = 1
            No13Select = 1
            No15Select = 1
            No17Select = 1
            No19Select = 1
            No21Select = 1
            No23Select = 1
            No25Select = 1
            No27Select = 1
            No29Select = 1
            No31Select = 1
            No33Select = 1
            No35Select = 1
            lblOdd.BackColor = Color.Turquoise
            lblNo1.BackColor = Color.LightSalmon
            lblNo3.BackColor = Color.LightSalmon
            lblNo5.BackColor = Color.LightSalmon
            lblNo7.BackColor = Color.LightSalmon
            lblNo9.BackColor = Color.LightSalmon
            lblNo11.BackColor = Color.DarkGray
            lblNo13.BackColor = Color.DarkGray
            lblNo15.BackColor = Color.DarkGray
            lblNo17.BackColor = Color.DarkGray
            lblNo19.BackColor = Color.DarkGray
            lblNo21.BackColor = Color.LightSalmon
            lblNo23.BackColor = Color.LightSalmon
            lblNo25.BackColor = Color.LightSalmon
            lblNo27.BackColor = Color.LightSalmon
            lblNo29.BackColor = Color.DarkGray
            lblNo31.BackColor = Color.DarkGray
            lblNo33.BackColor = Color.DarkGray
            lblNo35.BackColor = Color.DarkGray
            Odds = 1
            Disable()
        ElseIf OddSelect = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblHalf1_Click(sender As Object, e As EventArgs) Handles lblHalf1.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Half1Select = 0 Then
            Selected = Selected + 18
            Half1Select = 1
            No1Select = 1
            No2Select = 1
            No3Select = 1
            No4Select = 1
            No5Select = 1
            No6Select = 1
            No7Select = 1
            No8Select = 1
            No9Select = 1
            No10Select = 1
            No11Select = 1
            No12Select = 1
            No13Select = 1
            No14Select = 1
            No15Select = 1
            No16Select = 1
            No17Select = 1
            No18Select = 1
            lblHalf1.BackColor = Color.Turquoise
            lblNo1.BackColor = Color.LightSalmon
            lblNo2.BackColor = Color.DarkGray
            lblNo3.BackColor = Color.LightSalmon
            lblNo4.BackColor = Color.DarkGray
            lblNo5.BackColor = Color.LightSalmon
            lblNo6.BackColor = Color.DarkGray
            lblNo7.BackColor = Color.LightSalmon
            lblNo8.BackColor = Color.DarkGray
            lblNo9.BackColor = Color.LightSalmon
            lblNo10.BackColor = Color.DarkGray
            lblNo11.BackColor = Color.DarkGray
            lblNo12.BackColor = Color.LightSalmon
            lblNo13.BackColor = Color.DarkGray
            lblNo14.BackColor = Color.LightSalmon
            lblNo15.BackColor = Color.DarkGray
            lblNo16.BackColor = Color.LightSalmon
            lblNo17.BackColor = Color.DarkGray
            lblNo18.BackColor = Color.LightSalmon
            Odds = 1
            Disable()
        ElseIf Half1Select = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblHalf2_Click(sender As Object, e As EventArgs) Handles lblHalf2.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Half2Select = 0 Then
            ' Registers selection of 18 numbers
            Selected = Selected + 18
            ' All relevant numbers marked as selected
            Half2Select = 1
            No19Select = 1
            No20Select = 1
            No21Select = 1
            No22Select = 1
            No23Select = 1
            No24Select = 1
            No25Select = 1
            No26Select = 1
            No27Select = 1
            No28Select = 1
            No29Select = 1
            No30Select = 1
            No31Select = 1
            No32Select = 1
            No33Select = 1
            No34Select = 1
            No35Select = 1
            No36Select = 1
            ' Changes colour of all selected
            lblHalf2.BackColor = Color.Turquoise
            lblNo19.BackColor = Color.DarkGray
            lblNo20.BackColor = Color.DarkGray
            lblNo21.BackColor = Color.LightSalmon
            lblNo22.BackColor = Color.DarkGray
            lblNo23.BackColor = Color.LightSalmon
            lblNo24.BackColor = Color.DarkGray
            lblNo25.BackColor = Color.LightSalmon
            lblNo26.BackColor = Color.DarkGray
            lblNo27.BackColor = Color.LightSalmon
            lblNo28.BackColor = Color.LightSalmon
            lblNo29.BackColor = Color.DarkGray
            lblNo30.BackColor = Color.LightSalmon
            lblNo31.BackColor = Color.DarkGray
            lblNo32.BackColor = Color.LightSalmon
            lblNo33.BackColor = Color.DarkGray
            lblNo34.BackColor = Color.LightSalmon
            lblNo35.BackColor = Color.DarkGray
            lblNo36.BackColor = Color.LightSalmon
            ' Sets odds to 1:1
            Odds = 1
            ' Disables all other options
            Disable()
            ' If selected
        ElseIf Half2Select = 1 Then
            ' Resets to default
            Reset()
        End If
    End Sub

    Private Sub lblDozen1_Click(sender As Object, e As EventArgs) Handles lblDozen1.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Dozen1Select = 0 Then
            ' Registers selection of 12 numbers
            Selected = Selected + 12
            ' Marks all below as selected
            Dozen1Select = 1
            No1Select = 1
            No2Select = 1
            No3Select = 1
            No4Select = 1
            No5Select = 1
            No6Select = 1
            No7Select = 1
            No8Select = 1
            No9Select = 1
            No10Select = 1
            No11Select = 1
            No12Select = 1
            ' Changes colours of selected
            lblDozen1.BackColor = Color.Turquoise
            lblNo1.BackColor = Color.LightSalmon
            lblNo2.BackColor = Color.DarkGray
            lblNo3.BackColor = Color.LightSalmon
            lblNo4.BackColor = Color.DarkGray
            lblNo5.BackColor = Color.LightSalmon
            lblNo6.BackColor = Color.DarkGray
            lblNo7.BackColor = Color.LightSalmon
            lblNo8.BackColor = Color.DarkGray
            lblNo9.BackColor = Color.LightSalmon
            lblNo10.BackColor = Color.DarkGray
            lblNo11.BackColor = Color.DarkGray
            lblNo12.BackColor = Color.LightSalmon
            ' Sets odds to 2:1
            Odds = 2
            ' Disables all other options
            Disable()
            ' If selected
        ElseIf Dozen1Select = 1 Then
            ' Resets to default
            Reset()
        End If
    End Sub

    Private Sub lblDozen2_Click(sender As Object, e As EventArgs) Handles lblDozen2.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Dozen2Select = 0 Then
            ' Registers selection of 12 numbers
            Selected = Selected + 12
            ' Sets this and included to be selected
            Dozen2Select = 1
            No13Select = 1
            No14Select = 1
            No15Select = 1
            No16Select = 1
            No17Select = 1
            No18Select = 1
            No19Select = 1
            No20Select = 1
            No21Select = 1
            No22Select = 1
            No23Select = 1
            No24Select = 1
            ' Colours of selected changed
            lblDozen2.BackColor = Color.Turquoise
            lblNo13.BackColor = Color.DarkGray
            lblNo14.BackColor = Color.LightSalmon
            lblNo15.BackColor = Color.DarkGray
            lblNo16.BackColor = Color.LightSalmon
            lblNo17.BackColor = Color.DarkGray
            lblNo18.BackColor = Color.LightSalmon
            lblNo19.BackColor = Color.DarkGray
            lblNo20.BackColor = Color.DarkGray
            lblNo21.BackColor = Color.LightSalmon
            lblNo22.BackColor = Color.DarkGray
            lblNo23.BackColor = Color.LightSalmon
            lblNo24.BackColor = Color.DarkGray
            ' Odds set to 2:1
            Odds = 2
            ' Disables all other options
            Disable()
            ' If selected
        ElseIf Dozen2Select = 1 Then
            ' Resets to default
            Reset()
        End If
    End Sub

    Private Sub lblDozen3_Click(sender As Object, e As EventArgs) Handles lblDozen3.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Dozen3Select = 0 Then
            ' Registers selection of 12 numbers
            Selected = Selected + 12
            ' Selects this and all included
            Dozen3Select = 1
            No25Select = 1
            No26Select = 1
            No27Select = 1
            No28Select = 1
            No29Select = 1
            No30Select = 1
            No31Select = 1
            No32Select = 1
            No33Select = 1
            No34Select = 1
            No35Select = 1
            No36Select = 1
            ' Changes colours of selected
            lblDozen3.BackColor = Color.Turquoise
            lblNo25.BackColor = Color.LightSalmon
            lblNo26.BackColor = Color.DarkGray
            lblNo27.BackColor = Color.LightSalmon
            lblNo28.BackColor = Color.LightSalmon
            lblNo29.BackColor = Color.DarkGray
            lblNo30.BackColor = Color.LightSalmon
            lblNo31.BackColor = Color.DarkGray
            lblNo32.BackColor = Color.LightSalmon
            lblNo33.BackColor = Color.DarkGray
            lblNo34.BackColor = Color.LightSalmon
            lblNo35.BackColor = Color.DarkGray
            lblNo36.BackColor = Color.LightSalmon
            ' Sets odds to 2:1
            Odds = 2
            ' Disables all other options
            Disable()
            ' If selected
        ElseIf Dozen3Select = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblColumn1_Click(sender As Object, e As EventArgs) Handles lblColumn1.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Column1Select = 0 Then
            ' Registers 12 numbers selected
            Selected = Selected + 12
            ' Marks this and all it includes selected
            Column1Select = 1
            No1Select = 1
            No4Select = 1
            No7Select = 1
            No10Select = 1
            No13Select = 1
            No16Select = 1
            No19Select = 1
            No22Select = 1
            No25Select = 1
            No28Select = 1
            No31Select = 1
            No34Select = 1
            ' Changes colour of all selected
            lblColumn1.BackColor = Color.Turquoise
            lblNo1.BackColor = Color.LightSalmon
            lblNo4.BackColor = Color.DarkGray
            lblNo7.BackColor = Color.LightSalmon
            lblNo10.BackColor = Color.DarkGray
            lblNo13.BackColor = Color.DarkGray
            lblNo16.BackColor = Color.LightSalmon
            lblNo19.BackColor = Color.DarkGray
            lblNo22.BackColor = Color.DarkGray
            lblNo25.BackColor = Color.LightSalmon
            lblNo28.BackColor = Color.LightSalmon
            lblNo31.BackColor = Color.DarkGray
            lblNo34.BackColor = Color.LightSalmon
            ' Sets odds to 2:1
            Odds = 2
            ' Disables all other options
            Disable()
            ' If selected:
        ElseIf Column1Select = 1 Then
            Reset()
        End If
    End Sub

    Private Sub lblColumn2_Click(sender As Object, e As EventArgs) Handles lblColumn2.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Column2Select = 0 Then
            ' Registers 12 numbers selected
            Selected = Selected + 12
            ' Marks this and all numbers it includes as selected
            Column2Select = 1
            No2Select = 1
            No5Select = 1
            No8Select = 1
            No11Select = 1
            No14Select = 1
            No17Select = 1
            No20Select = 1
            No23Select = 1
            No26Select = 1
            No29Select = 1
            No32Select = 1
            No35Select = 1
            ' Changes colours of all selected labels
            lblColumn2.BackColor = Color.Turquoise
            lblNo2.BackColor = Color.DarkGray
            lblNo5.BackColor = Color.LightSalmon
            lblNo8.BackColor = Color.DarkGray
            lblNo11.BackColor = Color.DarkGray
            lblNo14.BackColor = Color.LightSalmon
            lblNo17.BackColor = Color.DarkGray
            lblNo20.BackColor = Color.DarkGray
            lblNo23.BackColor = Color.LightSalmon
            lblNo26.BackColor = Color.DarkGray
            lblNo29.BackColor = Color.DarkGray
            lblNo32.BackColor = Color.LightSalmon
            lblNo35.BackColor = Color.DarkGray
            ' Sets odds to 2:1
            Odds = 2
            ' Disables all other buttons
            Disable()
            ' If button is selected
        ElseIf Column2Select = 1 Then
            ' Resets board
            Reset()
        End If
    End Sub

    Private Sub lblColumn3_Click(sender As Object, e As EventArgs) Handles lblColumn3.Click

        ' Code that allows selection/deselection of the button
        ' If the button is not selected, following runs
        If Column3Select = 0 Then
            ' Registers the selection of 12 numbers
            Selected = Selected + 12
            ' Marks this button and all it includes as selected
            Column3Select = 1
            No3Select = 1
            No6Select = 1
            No9Select = 1
            No12Select = 1
            No15Select = 1
            No18Select = 1
            No21Select = 1
            No24Select = 1
            No27Select = 1
            No30Select = 1
            No33Select = 1
            No36Select = 1
            ' Changes colour of all labels
            lblColumn3.BackColor = Color.Turquoise
            lblNo3.BackColor = Color.LightSalmon
            lblNo6.BackColor = Color.DarkGray
            lblNo9.BackColor = Color.LightSalmon
            lblNo12.BackColor = Color.LightSalmon
            lblNo15.BackColor = Color.DarkGray
            lblNo18.BackColor = Color.LightSalmon
            lblNo21.BackColor = Color.LightSalmon
            lblNo24.BackColor = Color.DarkGray
            lblNo27.BackColor = Color.LightSalmon
            lblNo30.BackColor = Color.LightSalmon
            lblNo33.BackColor = Color.DarkGray
            lblNo36.BackColor = Color.LightSalmon
            ' Sets odds to 2:1
            Odds = 2
            ' Disables all other buttons
            Disable()
            ' If the button is selected when clicked:
        ElseIf Column3Select = 1 Then
            ' Resets board
            Reset()
        End If
    End Sub

    Private Sub SpinAndWin()

        ' Removes the player's bet from their balance
        Balance = Balance - txtBet.Text
        ' Writes new balance to label
        lblBalance.Text = ("$ " & Balance)
        ' Allows a random number to be selected (between 0-36)
        Randomize()
        lblSpinNo.Text = Int(Rnd() * 37)

        ' Code to check if the player's bet corresponds to the randomised number. If it is, the player gets their bet 
        ' and their winnings added to the balance and prints a win message. Otherwise, the lose message is printed and 
        ' the game checks if the player has hit or exceeded $0. First one commented to highlight individual components.

        If lblSpinNo.Text = 1 Then
            ' Sets the background of lblSpinNo to match the color on the board
            lblSpinNo.BackColor = Color.Red
            ' If the number spun is 1, it checks if the player had selected 1
            If No1Select = 1 Then
                ' Calculates what the player earns by multiplying their bet with the current odds
                Winnings = (txtBet.Text * Odds)
                ' Adds the Winnings along with the player's bet to the player's balance
                Balance = Balance + Winnings + txtBet.Text
                ' Writes new balance to label
                lblBalance.Text = ("$ " & Balance)
                ' Displays a randomised win message
                WinMsg()
            Else
                ' Displays a randomised lose message
                LoseMsg()
                ' Checks if the player run out of money
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 2 Then
            lblSpinNo.BackColor = Color.Black
            If No2Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 3 Then
            lblSpinNo.BackColor = Color.Red
            If No3Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        ElseIf lblSpinNo.Text = 4 Then
            lblSpinNo.BackColor = Color.Black
            If No4Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        ElseIf lblSpinNo.Text = 5 Then
            lblSpinNo.BackColor = Color.Red
            If No5Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        ElseIf lblSpinNo.Text = 6 Then
            lblSpinNo.BackColor = Color.Black
            If No6Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        ElseIf lblSpinNo.Text = 7 Then
            lblSpinNo.BackColor = Color.Red
            If No7Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        ElseIf lblSpinNo.Text = 8 Then
            lblSpinNo.BackColor = Color.Black
            If No8Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 9 Then
            lblSpinNo.BackColor = Color.Red
            If No9Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 10 Then
            lblSpinNo.BackColor = Color.Black
            If No10Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 11 Then
            lblSpinNo.BackColor = Color.Black
            If No11Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 12 Then
            lblSpinNo.BackColor = Color.Red
            If No12Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 13 Then
            lblSpinNo.BackColor = Color.Black
            If No13Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 14 Then
            lblSpinNo.BackColor = Color.Red
            If No14Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 15 Then
            lblSpinNo.BackColor = Color.Black
            If No15Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 16 Then
            lblSpinNo.BackColor = Color.Red
            If No16Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 17 Then
            lblSpinNo.BackColor = Color.Black
            If No17Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 18 Then
            lblSpinNo.BackColor = Color.Red
            If No18Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 19 Then
            lblSpinNo.BackColor = Color.Black
            If No19Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 20 Then
            lblSpinNo.BackColor = Color.Black
            If No20Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 21 Then
            lblSpinNo.BackColor = Color.Red
            If No21Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 22 Then
            lblSpinNo.BackColor = Color.Black
            If No22Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 23 Then
            lblSpinNo.BackColor = Color.Red
            If No23Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 24 Then
            lblSpinNo.BackColor = Color.Black
            If No24Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 25 Then
            lblSpinNo.BackColor = Color.Red
            If No25Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 26 Then
            lblSpinNo.BackColor = Color.Black
            If No26Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 27 Then
            lblSpinNo.BackColor = Color.Red
            If No27Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 28 Then
            lblSpinNo.BackColor = Color.Red
            If No28Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 29 Then
            lblSpinNo.BackColor = Color.Black
            If No29Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
        End If
        If lblSpinNo.Text = 30 Then
            lblSpinNo.BackColor = Color.Red
            If No30Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 31 Then
            lblSpinNo.BackColor = Color.Black
            If No31Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 32 Then
            lblSpinNo.BackColor = Color.Red
            If No32Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 33 Then
            lblSpinNo.BackColor = Color.Black
            If No33Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 34 Then
            lblSpinNo.BackColor = Color.Red
            If No34Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 35 Then
            lblSpinNo.BackColor = Color.Black
            If No35Select = 1 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If

        ElseIf lblSpinNo.Text = 36 Then
            lblSpinNo.BackColor = Color.Red
            If No1Select = 36 Then
                Winnings = (txtBet.Text * Odds)
                Balance = Balance + Winnings + txtBet.Text
                lblBalance.Text = ("$ " & Balance)
                WinMsg()
            Else
                LoseMsg()
                BalanceCheck()
            End If
            ' As 0 is a default loss, the colour and loss mechanism are only used
        ElseIf lblSpinNo.Text = 0 Then
            lblSpinNo.BackColor = Color.Green
            LoseMsg()
            BalanceCheck()
        End If
        ' Resets the game board if the player has not opted into preserving their bet every time they place one
        If chkReset.Checked = False Then
            Reset()
        End If
    End Sub

    Private Sub Disable()
        ' Disables or enables selection of buttons, dependent on if a number is selected or not
        If Val(Selected) >= 1 Then
            'Runs if a button is selected
            lblNo1.Enabled = False
            lblNo2.Enabled = False
            lblNo3.Enabled = False
            lblNo4.Enabled = False
            lblNo5.Enabled = False
            lblNo6.Enabled = False
            lblNo7.Enabled = False
            lblNo8.Enabled = False
            lblNo9.Enabled = False
            lblNo10.Enabled = False
            lblNo11.Enabled = False
            lblNo12.Enabled = False
            lblNo13.Enabled = False
            lblNo14.Enabled = False
            lblNo15.Enabled = False
            lblNo16.Enabled = False
            lblNo17.Enabled = False
            lblNo18.Enabled = False
            lblNo19.Enabled = False
            lblNo20.Enabled = False
            lblNo21.Enabled = False
            lblNo22.Enabled = False
            lblNo23.Enabled = False
            lblNo24.Enabled = False
            lblNo25.Enabled = False
            lblNo26.Enabled = False
            lblNo27.Enabled = False
            lblNo28.Enabled = False
            lblNo29.Enabled = False
            lblNo30.Enabled = False
            lblNo31.Enabled = False
            lblNo32.Enabled = False
            lblNo33.Enabled = False
            lblNo34.Enabled = False
            lblNo35.Enabled = False
            lblNo36.Enabled = False
            lblDozen1.Enabled = False
            lblDozen2.Enabled = False
            lblDozen3.Enabled = False
            lblHalf1.Enabled = False
            lblHalf2.Enabled = False
            lblEven.Enabled = False
            lblOdd.Enabled = False
            lblRed.Enabled = False
            lblBlack.Enabled = False
            lblGroup6.Enabled = False
            lblGroup4.Enabled = False
            lblGroup3.Enabled = False
            lblGroup2.Enabled = False
            lblColumn1.Enabled = False
            lblColumn2.Enabled = False
            lblColumn3.Enabled = False
            If Dozen1Select = 1 Then
                lblDozen1.Enabled = True
            ElseIf Dozen2Select = 1
                lblDozen2.Enabled = True
            ElseIf Dozen3Select = 1
                lblDozen3.Enabled = True
            ElseIf Half1Select = 1
                lblHalf1.Enabled = True
            ElseIf Half2Select = 1
                lblHalf2.Enabled = True
            ElseIf EvenSelect = 1
                lblEven.Enabled = True
            ElseIf OddSelect = 1
                lblOdd.Enabled = True
            ElseIf RedSelect = 1
                lblRed.Enabled = True
            ElseIf BlackSelect = 1
                lblBlack.Enabled = True
            ElseIf Group4Select = 1
                lblGroup4.Enabled = True
            ElseIf Group3Select = 1
                lblGroup3.Enabled = True
            ElseIf Group2Select = 1
                lblGroup2.Enabled = True
            ElseIf Column1Select = 1
                lblColumn1.Enabled = True
            ElseIf Column2Select = 1
                lblColumn2.Enabled = True
            ElseIf Column3Select = 1
                lblColumn3.Enabled = True
            ElseIf No1Select = 1
                lblNo1.Enabled = True
            ElseIf No2Select = 1
                lblNo2.Enabled = True
            ElseIf No3Select = 1
                lblNo3.Enabled = True
            ElseIf No4Select = 1
                lblNo4.Enabled = True
            ElseIf No5Select = 1
                lblNo5.Enabled = True
            ElseIf No6Select = 1
                lblNo6.Enabled = True
            ElseIf No7Select = 1
                lblNo7.Enabled = True
            ElseIf No8Select = 1
                lblNo8.Enabled = True
            ElseIf No9Select = 1
                lblNo9.Enabled = True
            ElseIf No10Select = 1
                lblNo10.Enabled = True
            ElseIf No11Select = 1
                lblNo11.Enabled = True
            ElseIf No12Select = 1
                lblNo12.Enabled = True
            ElseIf No13Select = 1
                lblNo13.Enabled = True
            ElseIf No14Select = 1
                lblNo14.Enabled = True
            ElseIf No15Select = 1
                lblNo15.Enabled = True
            ElseIf No16Select = 1
                lblNo16.Enabled = True
            ElseIf No17Select = 1
                lblNo17.Enabled = True
            ElseIf No18Select = 1
                lblNo18.Enabled = True
            ElseIf No19Select = 1
                lblNo19.Enabled = True
            ElseIf No20Select = 1
                lblNo20.Enabled = True
            ElseIf No21Select = 1
                lblNo21.Enabled = True
            ElseIf No22Select = 1
                lblNo22.Enabled = True
            ElseIf No23Select = 1
                lblNo23.Enabled = True
            ElseIf No24Select = 1
                lblNo24.Enabled = True
            ElseIf No25Select = 1
                lblNo25.Enabled = True
            ElseIf No26Select = 1
                lblNo26.Enabled = True
            ElseIf No27Select = 1
                lblNo27.Enabled = True
            ElseIf No28Select = 1
                lblNo28.Enabled = True
            ElseIf No29Select = 1
                lblNo29.Enabled = True
            ElseIf No30Select = 1
                lblNo30.Enabled = True
            ElseIf No31Select = 1
                lblNo31.Enabled = True
            ElseIf No32Select = 1
                lblNo32.Enabled = True
            ElseIf No33Select = 1
                lblNo33.Enabled = True
            ElseIf No34Select = 1
                lblNo34.Enabled = True
            ElseIf No35Select = 1
                lblNo35.Enabled = True
            ElseIf No36Select = 1
                lblNo36.Enabled = True

            End If
            ' Runs if a button is deselected
        ElseIf Val(Selected) = 0 Then
            lblNo1.Enabled = True
            lblNo2.Enabled = True
            lblNo3.Enabled = True
            lblNo4.Enabled = True
            lblNo5.Enabled = True
            lblNo6.Enabled = True
            lblNo7.Enabled = True
            lblNo8.Enabled = True
            lblNo9.Enabled = True
            lblNo10.Enabled = True
            lblNo11.Enabled = True
            lblNo12.Enabled = True
            lblNo13.Enabled = True
            lblNo14.Enabled = True
            lblNo15.Enabled = True
            lblNo16.Enabled = True
            lblNo17.Enabled = True
            lblNo18.Enabled = True
            lblNo19.Enabled = True
            lblNo20.Enabled = True
            lblNo21.Enabled = True
            lblNo22.Enabled = True
            lblNo23.Enabled = True
            lblNo24.Enabled = True
            lblNo25.Enabled = True
            lblNo26.Enabled = True
            lblNo27.Enabled = True
            lblNo28.Enabled = True
            lblNo29.Enabled = True
            lblNo30.Enabled = True
            lblNo31.Enabled = True
            lblNo32.Enabled = True
            lblNo33.Enabled = True
            lblNo34.Enabled = True
            lblNo35.Enabled = True
            lblNo36.Enabled = True
            lblDozen1.Enabled = True
            lblDozen2.Enabled = True
            lblDozen3.Enabled = True
            lblHalf1.Enabled = True
            lblHalf2.Enabled = True
            lblEven.Enabled = True
            lblOdd.Enabled = True
            lblRed.Enabled = True
            lblBlack.Enabled = True
            lblGroup6.Enabled = True
            lblGroup4.Enabled = True
            lblGroup3.Enabled = True
            lblGroup2.Enabled = True
            lblColumn1.Enabled = True
            lblColumn2.Enabled = True
            lblColumn3.Enabled = True
        End If
    End Sub

    Private Sub Reset()
        ' Resets the board to default, enabling all buttons, resetting colours, odds and the bet textbox
        lblNo1.Enabled = True
            lblNo2.Enabled = True
            lblNo3.Enabled = True
            lblNo4.Enabled = True
            lblNo5.Enabled = True
            lblNo6.Enabled = True
            lblNo7.Enabled = True
            lblNo8.Enabled = True
            lblNo9.Enabled = True
            lblNo10.Enabled = True
            lblNo11.Enabled = True
            lblNo12.Enabled = True
            lblNo13.Enabled = True
            lblNo14.Enabled = True
            lblNo15.Enabled = True
            lblNo16.Enabled = True
            lblNo17.Enabled = True
            lblNo18.Enabled = True
            lblNo19.Enabled = True
            lblNo20.Enabled = True
            lblNo21.Enabled = True
            lblNo22.Enabled = True
            lblNo23.Enabled = True
            lblNo24.Enabled = True
            lblNo25.Enabled = True
            lblNo26.Enabled = True
            lblNo27.Enabled = True
            lblNo28.Enabled = True
            lblNo29.Enabled = True
            lblNo30.Enabled = True
            lblNo31.Enabled = True
            lblNo32.Enabled = True
            lblNo33.Enabled = True
            lblNo34.Enabled = True
            lblNo35.Enabled = True
            lblNo36.Enabled = True
            lblDozen1.Enabled = True
            lblDozen2.Enabled = True
            lblDozen3.Enabled = True
            lblHalf1.Enabled = True
            lblHalf2.Enabled = True
            lblEven.Enabled = True
            lblOdd.Enabled = True
            lblRed.Enabled = True
            lblBlack.Enabled = True
            lblGroup6.Enabled = True
            lblGroup4.Enabled = True
            lblGroup3.Enabled = True
            lblGroup2.Enabled = True
            lblColumn1.Enabled = True
            lblColumn2.Enabled = True
            lblColumn3.Enabled = True
            lblNo1.BackColor = Color.Red
            lblNo2.BackColor = Color.Black
            lblNo3.BackColor = Color.Red
            lblNo4.BackColor = Color.Black
            lblNo5.BackColor = Color.Red
            lblNo6.BackColor = Color.Black
            lblNo7.BackColor = Color.Red
            lblNo8.BackColor = Color.Black
            lblNo9.BackColor = Color.Red
            lblNo10.BackColor = Color.Black
            lblNo11.BackColor = Color.Black
            lblNo12.BackColor = Color.Red
            lblNo13.BackColor = Color.Black
            lblNo14.BackColor = Color.Red
            lblNo15.BackColor = Color.Black
            lblNo16.BackColor = Color.Red
            lblNo17.BackColor = Color.Black
            lblNo18.BackColor = Color.Red
            lblNo19.BackColor = Color.Black
            lblNo20.BackColor = Color.Black
            lblNo21.BackColor = Color.Red
            lblNo22.BackColor = Color.Black
            lblNo23.BackColor = Color.Red
            lblNo24.BackColor = Color.Black
            lblNo25.BackColor = Color.Red
            lblNo26.BackColor = Color.Black
            lblNo27.BackColor = Color.Red
            lblNo28.BackColor = Color.Red
            lblNo29.BackColor = Color.Black
            lblNo30.BackColor = Color.Red
            lblNo31.BackColor = Color.Black
            lblNo32.BackColor = Color.Red
            lblNo33.BackColor = Color.Black
            lblNo34.BackColor = Color.Red
            lblNo35.BackColor = Color.Black
            lblNo36.BackColor = Color.Red
            lblDozen1.BackColor = Color.LightSeaGreen
            lblDozen2.BackColor = Color.LightSeaGreen
            lblDozen3.BackColor = Color.LightSeaGreen
            lblHalf1.BackColor = Color.LightSeaGreen
            lblHalf2.BackColor = Color.LightSeaGreen
            lblEven.BackColor = Color.LightSeaGreen
            lblOdd.BackColor = Color.LightSeaGreen
            lblRed.BackColor = Color.LightSeaGreen
            lblBlack.BackColor = Color.LightSeaGreen
            lblGroup6.BackColor = Color.LightSeaGreen
            lblGroup4.BackColor = Color.LightSeaGreen
            lblGroup3.BackColor = Color.LightSeaGreen
            lblGroup2.BackColor = Color.LightSeaGreen
            lblColumn1.BackColor = Color.LightSeaGreen
            lblColumn2.BackColor = Color.LightSeaGreen
            lblColumn3.BackColor = Color.LightSeaGreen
            No1Select = 0
            No2Select = 0
            No3Select = 0
            No4Select = 0
            No5Select = 0
            No6Select = 0
            No7Select = 0
            No8Select = 0
            No9Select = 0
            No10Select = 0
            No11Select = 0
            No12Select = 0
            No13Select = 0
            No14Select = 0
            No15Select = 0
            No16Select = 0
            No17Select = 0
            No18Select = 0
            No19Select = 0
            No20Select = 0
            No21Select = 0
            No22Select = 0
            No23Select = 0
            No24Select = 0
            No25Select = 0
            No26Select = 0
            No27Select = 0
            No28Select = 0
            No29Select = 0
            No30Select = 0
            No31Select = 0
            No32Select = 0
            No33Select = 0
            No34Select = 0
            No35Select = 0
            No36Select = 0
            Dozen1Select = 0
            Dozen2Select = 0
            Dozen3Select = 0
            Half1Select = 0
            Half2Select = 0
            EvenSelect = 0
            OddSelect = 0
            RedSelect = 0
            BlackSelect = 0
            Group6Select = 0
            Group4Select = 0
            Group3Select = 0
            Group2Select = 0
            Column1Select = 0
            Column2Select = 0
            Column3Select = 0
            txtBet.Clear()
            Selected = 0
        Odds = 35
    End Sub

    Private Sub WinMsg()
        ' Randomises from a set of messages that display if the player wins a bet
        Randomize()
        WinMessage = Int(Rnd() * 4) + 1
        Select Case WinMessage
            Case 1
                lblMessages.Text = lblUser.Text & " got lucky And won $" & Winnings
            Case 2
                lblMessages.Text = "The odds were in " & lblUser.Text & "'s favour, as they just won $" & Winnings
            Case 3
                lblMessages.Text = lblUser.Text & " won $" & Winnings
            Case 4
                lblMessages.Text = "Luck seems to have blessed " & lblUser.Text & ", as they just won $" & Winnings
        End Select

    End Sub

    Private Sub LoseMsg()
        ' Randomises from a set of messages to display if the player loses a bet
        Randomize()
        LoseMessage = Int(Rnd() * 4) + 1
        Select Case LoseMessage
            Case 1
                lblMessages.Text = "The luck was against " & lblUser.Text & ", they just lost $" & txtBet.Text
            Case 2
                lblMessages.Text = lblUser.Text & " lost $" & txtBet.Text
            Case 3
                lblMessages.Text = lblUser.Text & " should reconsider their betting habits, they just lost $" & txtBet.Text
            Case 4
                lblMessages.Text = "Everyone has bad luck sometimes, " & lblUser.Text & ". You lost $" & txtBet.Text
        End Select
    End Sub

    Private Sub BalanceCheck()
        ' A check to see if the balance has hit 0. Disables further gameplay when this happens
        If Balance <= 0 Then
            txtBet.Enabled = 0
            btnPlaceBet.Enabled = 0
            MsgBox("You have run out of money. Game over!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Quits the game window and returns to the menu
        frmWelcome.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Shows the help window
        frmHelp.Show()
    End Sub
End Class