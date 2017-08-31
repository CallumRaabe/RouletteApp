<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblGameScrn = New System.Windows.Forms.Label()
        Me.lblPlaying = New System.Windows.Forms.Label()
        Me.lblBetTypes = New System.Windows.Forms.Label()
        Me.lblPlacingBet = New System.Windows.Forms.Label()
        Me.lblSelecting = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.lblGroups1 = New System.Windows.Forms.Label()
        Me.lblGroups2 = New System.Windows.Forms.Label()
        Me.lblBankrupt = New System.Windows.Forms.Label()
        Me.lblMessageLog = New System.Windows.Forms.Label()
        Me.lblHelpText = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.pbxHelp = New System.Windows.Forms.PictureBox()
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!)
        Me.lblTitle.Location = New System.Drawing.Point(11, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(63, 32)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Help"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblHome.Location = New System.Drawing.Point(11, 85)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(62, 25)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Home"
        '
        'lblGameScrn
        '
        Me.lblGameScrn.AutoSize = True
        Me.lblGameScrn.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblGameScrn.Location = New System.Drawing.Point(11, 110)
        Me.lblGameScrn.Name = "lblGameScrn"
        Me.lblGameScrn.Size = New System.Drawing.Size(156, 25)
        Me.lblGameScrn.TabIndex = 5
        Me.lblGameScrn.Text = "The Game Screen"
        '
        'lblPlaying
        '
        Me.lblPlaying.AutoSize = True
        Me.lblPlaying.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblPlaying.Location = New System.Drawing.Point(11, 135)
        Me.lblPlaying.Name = "lblPlaying"
        Me.lblPlaying.Size = New System.Drawing.Size(142, 25)
        Me.lblPlaying.TabIndex = 6
        Me.lblPlaying.Text = "Playing Roulette"
        '
        'lblBetTypes
        '
        Me.lblBetTypes.AutoSize = True
        Me.lblBetTypes.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblBetTypes.Location = New System.Drawing.Point(12, 160)
        Me.lblBetTypes.Name = "lblBetTypes"
        Me.lblBetTypes.Size = New System.Drawing.Size(91, 25)
        Me.lblBetTypes.TabIndex = 7
        Me.lblBetTypes.Text = "Bet Types"
        '
        'lblPlacingBet
        '
        Me.lblPlacingBet.AutoSize = True
        Me.lblPlacingBet.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblPlacingBet.Location = New System.Drawing.Point(16, 210)
        Me.lblPlacingBet.Name = "lblPlacingBet"
        Me.lblPlacingBet.Size = New System.Drawing.Size(117, 25)
        Me.lblPlacingBet.TabIndex = 8
        Me.lblPlacingBet.Text = "Placing a Bet"
        '
        'lblSelecting
        '
        Me.lblSelecting.AutoSize = True
        Me.lblSelecting.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblSelecting.Location = New System.Drawing.Point(16, 235)
        Me.lblSelecting.Name = "lblSelecting"
        Me.lblSelecting.Size = New System.Drawing.Size(173, 25)
        Me.lblSelecting.TabIndex = 9
        Me.lblSelecting.Text = "Selecting a Number"
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblBatch.Location = New System.Drawing.Point(16, 260)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(179, 25)
        Me.lblBatch.TabIndex = 10
        Me.lblBatch.Text = "Batch Select Buttons"
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblGroups.Location = New System.Drawing.Point(16, 285)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(150, 25)
        Me.lblGroups.TabIndex = 11
        Me.lblGroups.Text = "Selecting Groups"
        '
        'lblGroups1
        '
        Me.lblGroups1.AutoSize = True
        Me.lblGroups1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblGroups1.Location = New System.Drawing.Point(138, 310)
        Me.lblGroups1.Name = "lblGroups1"
        Me.lblGroups1.Size = New System.Drawing.Size(19, 25)
        Me.lblGroups1.TabIndex = 12
        Me.lblGroups1.Text = "1"
        '
        'lblGroups2
        '
        Me.lblGroups2.AutoSize = True
        Me.lblGroups2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblGroups2.Location = New System.Drawing.Point(138, 335)
        Me.lblGroups2.Name = "lblGroups2"
        Me.lblGroups2.Size = New System.Drawing.Size(22, 25)
        Me.lblGroups2.TabIndex = 13
        Me.lblGroups2.Text = "2"
        '
        'lblBankrupt
        '
        Me.lblBankrupt.AutoSize = True
        Me.lblBankrupt.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblBankrupt.Location = New System.Drawing.Point(16, 360)
        Me.lblBankrupt.Name = "lblBankrupt"
        Me.lblBankrupt.Size = New System.Drawing.Size(139, 25)
        Me.lblBankrupt.TabIndex = 14
        Me.lblBankrupt.Text = "Going Bankrupt"
        '
        'lblMessageLog
        '
        Me.lblMessageLog.AutoSize = True
        Me.lblMessageLog.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblMessageLog.Location = New System.Drawing.Point(12, 185)
        Me.lblMessageLog.Name = "lblMessageLog"
        Me.lblMessageLog.Size = New System.Drawing.Size(121, 25)
        Me.lblMessageLog.TabIndex = 15
        Me.lblMessageLog.Text = "Message Log"
        '
        'lblHelpText
        '
        Me.lblHelpText.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblHelpText.Location = New System.Drawing.Point(201, 213)
        Me.lblHelpText.Name = "lblHelpText"
        Me.lblHelpText.Size = New System.Drawing.Size(468, 366)
        Me.lblHelpText.TabIndex = 17
        Me.lblHelpText.Text = "Choose an option from the side"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblBack.Location = New System.Drawing.Point(11, 554)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(127, 25)
        Me.lblBack.TabIndex = 18
        Me.lblBack.Text = "Back to Game"
        '
        'pbxHelp
        '
        Me.pbxHelp.Image = CType(resources.GetObject("pbxHelp.Image"), System.Drawing.Image)
        Me.pbxHelp.Location = New System.Drawing.Point(201, 12)
        Me.pbxHelp.Name = "pbxHelp"
        Me.pbxHelp.Size = New System.Drawing.Size(468, 198)
        Me.pbxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxHelp.TabIndex = 16
        Me.pbxHelp.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 588)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblHelpText)
        Me.Controls.Add(Me.pbxHelp)
        Me.Controls.Add(Me.lblMessageLog)
        Me.Controls.Add(Me.lblBankrupt)
        Me.Controls.Add(Me.lblGroups2)
        Me.Controls.Add(Me.lblGroups1)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.lblBatch)
        Me.Controls.Add(Me.lblSelecting)
        Me.Controls.Add(Me.lblPlacingBet)
        Me.Controls.Add(Me.lblBetTypes)
        Me.Controls.Add(Me.lblPlaying)
        Me.Controls.Add(Me.lblGameScrn)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.TopMost = True
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblGameScrn As Label
    Friend WithEvents lblPlaying As Label
    Friend WithEvents lblBetTypes As Label
    Friend WithEvents lblPlacingBet As Label
    Friend WithEvents lblSelecting As Label
    Friend WithEvents lblBatch As Label
    Friend WithEvents lblGroups As Label
    Friend WithEvents lblGroups1 As Label
    Friend WithEvents lblGroups2 As Label
    Friend WithEvents lblBankrupt As Label
    Friend WithEvents lblMessageLog As Label
    Friend WithEvents pbxHelp As PictureBox
    Friend WithEvents lblHelpText As Label
    Friend WithEvents lblBack As Label
End Class
