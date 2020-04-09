<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSignOn = New System.Windows.Forms.Button()
        Me.btnFaceID = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRemember = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnForgot = New System.Windows.Forms.Button()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(18, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Citi Mobile App Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bank UserID: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password: "
        '
        'btnSignOn
        '
        Me.btnSignOn.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSignOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOn.ForeColor = System.Drawing.Color.White
        Me.btnSignOn.Location = New System.Drawing.Point(77, 285)
        Me.btnSignOn.Name = "btnSignOn"
        Me.btnSignOn.Size = New System.Drawing.Size(222, 43)
        Me.btnSignOn.TabIndex = 6
        Me.btnSignOn.Text = "Sign On"
        Me.btnSignOn.UseVisualStyleBackColor = False
        '
        'btnFaceID
        '
        Me.btnFaceID.BackColor = System.Drawing.Color.Red
        Me.btnFaceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaceID.Location = New System.Drawing.Point(247, 389)
        Me.btnFaceID.Name = "btnFaceID"
        Me.btnFaceID.Size = New System.Drawing.Size(91, 38)
        Me.btnFaceID.TabIndex = 7
        Me.btnFaceID.Text = "FaceID"
        Me.btnFaceID.UseVisualStyleBackColor = False
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(121, 185)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(176, 24)
        Me.txtUserID.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(121, 231)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(178, 24)
        Me.txtPassword.TabIndex = 10
        '
        'btnRemember
        '
        Me.btnRemember.BackColor = System.Drawing.Color.Red
        Me.btnRemember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemember.Location = New System.Drawing.Point(18, 389)
        Me.btnRemember.Name = "btnRemember"
        Me.btnRemember.Size = New System.Drawing.Size(139, 38)
        Me.btnRemember.TabIndex = 14
        Me.btnRemember.Text = "Remember me"
        Me.btnRemember.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(263, 433)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Need Help?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnForgot
        '
        Me.btnForgot.BackColor = System.Drawing.Color.Gainsboro
        Me.btnForgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgot.Location = New System.Drawing.Point(105, 334)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(160, 23)
        Me.btnForgot.TabIndex = 17
        Me.btnForgot.Text = "Forgot Username/ Password"
        Me.btnForgot.UseVisualStyleBackColor = False
        '
        'btnShowPass
        '
        Me.btnShowPass.Image = Global.Prototype_Design.My.Resources.Resources.eye1
        Me.btnShowPass.Location = New System.Drawing.Point(305, 229)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(41, 31)
        Me.btnShowPass.TabIndex = 16
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Prototype_Design.My.Resources.Resources.citilogo1
        Me.PictureBox2.Location = New System.Drawing.Point(44, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(294, 90)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(382, 522)
        Me.Controls.Add(Me.btnForgot)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnRemember)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnFaceID)
        Me.Controls.Add(Me.btnSignOn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Prototype Design"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSignOn As Button
    Friend WithEvents btnFaceID As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRemember As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnForgot As Button
End Class
