<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.pbxExit = New System.Windows.Forms.PictureBox()
        Me.pbxPlay = New System.Windows.Forms.PictureBox()
        Me.pbxUser = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!)
        Me.lblMessage.Location = New System.Drawing.Point(9, 26)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(244, 45)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.Text = "Welcome, Name"
        '
        'pbxExit
        '
        Me.pbxExit.Image = Global.Roulette.My.Resources.Resources.exit1
        Me.pbxExit.Location = New System.Drawing.Point(315, 105)
        Me.pbxExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(262, 162)
        Me.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxExit.TabIndex = 8
        Me.pbxExit.TabStop = False
        '
        'pbxPlay
        '
        Me.pbxPlay.Image = Global.Roulette.My.Resources.Resources.play1
        Me.pbxPlay.Location = New System.Drawing.Point(9, 105)
        Me.pbxPlay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxPlay.Name = "pbxPlay"
        Me.pbxPlay.Size = New System.Drawing.Size(262, 162)
        Me.pbxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPlay.TabIndex = 0
        Me.pbxPlay.TabStop = False
        '
        'pbxUser
        '
        Me.pbxUser.Location = New System.Drawing.Point(514, 273)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(64, 69)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 9
        Me.pbxUser.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semilight", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(16, 288)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(494, 37)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "Name"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 352)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.pbxUser)
        Me.Controls.Add(Me.pbxExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.pbxPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmWelcome"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roulette"
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxPlay As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents pbxExit As System.Windows.Forms.PictureBox
    Friend WithEvents pbxUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblUser As System.Windows.Forms.Label

End Class
