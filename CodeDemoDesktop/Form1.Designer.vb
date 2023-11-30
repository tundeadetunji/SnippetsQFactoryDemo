<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleDropDown = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderDropDown = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title  (Àkọ́lé Ìtẹríba)"
        '
        'TitleDropDown
        '
        Me.TitleDropDown.FormattingEnabled = True
        Me.TitleDropDown.Location = New System.Drawing.Point(21, 43)
        Me.TitleDropDown.Name = "TitleDropDown"
        Me.TitleDropDown.Size = New System.Drawing.Size(133, 27)
        Me.TitleDropDown.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name  (Orúkọ)"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(21, 95)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(310, 26)
        Me.NameTextBox.TabIndex = 3
        '
        'GenderDropDown
        '
        Me.GenderDropDown.FormattingEnabled = True
        Me.GenderDropDown.Location = New System.Drawing.Point(21, 146)
        Me.GenderDropDown.Name = "GenderDropDown"
        Me.GenderDropDown.Size = New System.Drawing.Size(182, 27)
        Me.GenderDropDown.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender  (Ìwà)"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(21, 198)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(310, 26)
        Me.UsernameTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Username  (Orúko Olùmúlò)"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(21, 249)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(310, 26)
        Me.PasswordTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password  (Ọ̀rọ̀ Ìgbaniwọlé)"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(85, 293)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(179, 40)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "SAVE  (Fipamọ́)"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 355)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GenderDropDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleDropDown)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Example  (Àpẹrẹ)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TitleDropDown As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GenderDropDown As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveButton As Button
End Class
