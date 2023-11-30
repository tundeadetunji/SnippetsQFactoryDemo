Imports iNovation.Code.General
Imports iNovation.Code.Web

Imports CodeDemoDataAccess.Employees
Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs)
        If Not Page.IsValid Then Return
        Add(Content(TitleDropDown), Content(NameTextBox), Content(GenderDropDown), Content(UsernameTextBox), Content(PasswordTextBox))
    End Sub

    Private Sub _Default_Init(sender As Object, e As EventArgs) Handles Me.Init
        If Not Page.IsPostBack Then
            TitleDrop(TitleDropDown)
            GenderDrop(GenderDropDown)
        End If
    End Sub
End Class