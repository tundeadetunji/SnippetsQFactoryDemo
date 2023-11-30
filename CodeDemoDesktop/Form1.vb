Imports iNovation.Code.General
Imports iNovation.Code.Desktop
Imports iNovation.Code.Encryption
Imports iNovation.Code.Sequel
Public Class Form1

    Private ReadOnly Property con_string__ As String = "Data Source=" & Environment.MachineName & "\SQLEXPRESS;Initial Catalog=" & Environment.GetEnvironmentVariable("InitialCatalog", EnvironmentVariableTarget.User) & ";Persist Security Info=True;User ID=" & Environment.GetEnvironmentVariable("UserId", EnvironmentVariableTarget.User) & ";Password=" & Environment.GetEnvironmentVariable("Password", EnvironmentVariableTarget.User)
    Private ReadOnly Property key__ As String = "Encryption_Key_Here"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleDrop(TitleDropDown)
        GenderDrop(GenderDropDown)
    End Sub

    Private Sub TitleDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TitleDropDown.SelectedIndexChanged
        NameTextBox.Focus()
    End Sub

    Private Sub GenderDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderDropDown.SelectedIndexChanged
        UsernameTextBox.Focus()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        EnableControl(sender, False)
        CommitSequel(BuildInsertString("Employees", {"empTitle", "empName", "empGender", "empUsername", "empPassword"}), con_string__, {"empTitle", Content(TitleDropDown), "empName", Content(NameTextBox), "empGender", Content(GenderDropDown), "empUsername", Content(UsernameTextBox), "empPassword", Encrypt(key__, Content(PasswordTextBox))})
        EnableControl(sender)
    End Sub
End Class
