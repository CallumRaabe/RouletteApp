<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.pbxUser = New System.Windows.Forms.PictureBox()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.btnBrowse.Location = New System.Drawing.Point(12, 146)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(128, 30)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!)
        Me.lblName.Location = New System.Drawing.Point(145, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(210, 37)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Enter your name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semilight", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(145, 63)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.MaxLength = 16
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(351, 51)
        Me.txtName.TabIndex = 3
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.btnContinue.Location = New System.Drawing.Point(397, 132)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(99, 44)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'pbxUser
        '
        Me.pbxUser.BackColor = System.Drawing.Color.Transparent
        Me.pbxUser.Image = Global.Roulette.My.Resources.Resources.thumb_Picture
        Me.pbxUser.Location = New System.Drawing.Point(12, 14)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(128, 128)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 1
        Me.pbxUser.TabStop = False
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbxUser)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmName"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roulette"
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents pbxUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
