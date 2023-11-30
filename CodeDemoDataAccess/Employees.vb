Imports iNovation.Code.General
'Imports iNovation.Code.Desktop  'uncomment this line if targeting desktop environment
Imports iNovation.Code.Web  'comment this line if targeting desktop environment
Imports iNovation.Code.Sequel
Imports iNovation.Code.Encryption

Public Class Employees

    Private Shared ReadOnly Property InitialCatalogVariableName As String = ""
    Private Shared ReadOnly Property UserIdVariableName As String = ""
    Private Shared ReadOnly Property PasswordVariableName As String = ""
    Private Shared ReadOnly Property EncryptionKeyVariableName As String = ""
    Private Shared ReadOnly Property con_string__ As String = "Data Source=" & Environment.MachineName & "\SQLEXPRESS;Initial Catalog=" & Environment.GetEnvironmentVariable(InitialCatalogVariableName, EnvironmentVariableTarget.User) & ";Persist Security Info=True;User ID=" & Environment.GetEnvironmentVariable(UserIdVariableName, EnvironmentVariableTarget.User) & ";Password=" & Environment.GetEnvironmentVariable(PasswordVariableName, EnvironmentVariableTarget.User)
    Private Shared ReadOnly Property key__ As String = Environment.GetEnvironmentVariable(EncryptionKeyVariableName, EnvironmentVariableTarget.User)

    Public Shared Function Add(empTitle As String, empName As String, empGender As String, empUsername As String, empPassword As String) As Boolean
        Return CommitSequel(BuildInsertString("Employees", {"empTitle", "empName", "empGender", "empUsername", "empPassword"}), con_string__, {"empTitle", Encrypt(key__, empTitle), "empName", Encrypt(key__, empName), "empGender", Encrypt(key__, empGender), "empUsername", Encrypt(key__, empUsername), "empPassword", Encrypt(key__, empPassword)})
    End Function

    Public Shared Function Update(empTitle As String, empName As String, empGender As String, empUsername As String, empPassword As String, Id As Int32) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empTitle", "empName", "empGender", "empUsername", "empPassword"}, {"Id"}), con_string__, {"empTitle", Encrypt(key__, empTitle), "empName", Encrypt(key__, empName), "empGender", Encrypt(key__, empGender), "empUsername", Encrypt(key__, empUsername), "empPassword", Encrypt(key__, empPassword), "Id", Id})
    End Function

    Public Sub Clear(IdControl As System.Web.UI.WebControls.WebControl, empTitleControl As System.Web.UI.WebControls.WebControl, empNameControl As System.Web.UI.WebControls.WebControl, empGenderControl As System.Web.UI.WebControls.WebControl, empUsernameControl As System.Web.UI.WebControls.WebControl, empPasswordControl As System.Web.UI.WebControls.WebControl)

        iNovation.Code.Web.Clear({IdControl, empTitleControl, empNameControl, empGenderControl, empUsernameControl, empPasswordControl})
    End Sub

    Public Shared Function GetempTitle(Id As Int32) As String
        Return Decrypt(key__, QData(BuildSelectString("Employees", {"empTitle"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id}))
    End Function
    Public Shared Function GetempName(Id As Int32) As String
        Return Decrypt(key__, QData(BuildSelectString("Employees", {"empName"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id}))
    End Function
    Public Shared Function GetempGender(Id As Int32) As String
        Return Decrypt(key__, QData(BuildSelectString("Employees", {"empGender"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id}))
    End Function
    Public Shared Function GetempUsername(Id As Int32) As String
        Return Decrypt(key__, QData(BuildSelectString("Employees", {"empUsername"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id}))
    End Function
    Public Shared Function GetempPassword(Id As Int32) As String
        Return Decrypt(key__, QData(BuildSelectString("Employees", {"empPassword"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id}))
    End Function


    Public Shared Function SetempTitle(Id As Int32, empTitle As String) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empTitle"}, {"Id"}), con_string__, {"empTitle", Encrypt(key__, empTitle), "Id", Id})
    End Function
    Public Shared Function SetempName(Id As Int32, empName As String) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empName"}, {"Id"}), con_string__, {"empName", Encrypt(key__, empName), "Id", Id})
    End Function
    Public Shared Function SetempGender(Id As Int32, empGender As String) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empGender"}, {"Id"}), con_string__, {"empGender", Encrypt(key__, empGender), "Id", Id})
    End Function
    Public Shared Function SetempUsername(Id As Int32, empUsername As String) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empUsername"}, {"Id"}), con_string__, {"empUsername", Encrypt(key__, empUsername), "Id", Id})
    End Function
    Public Shared Function SetempPassword(Id As Int32, empPassword As String) As Boolean
        Return CommitSequel(BuildUpdateString("Employees", {"empPassword"}, {"Id"}), con_string__, {"empPassword", Encrypt(key__, empPassword), "Id", Id})
    End Function


    Public Shared Function DisplayAll(grid_here As System.Web.UI.WebControls.GridView) As System.Web.UI.WebControls.GridView
        Return Display(grid_here, BuildSelectString("Employees", {"Id", "empTitle", "empName", "empGender", "empUsername", "empPassword"}, Nothing, "Id", OrderBy.ASC), con_string__)
    End Function

    Public Shared Function DisplayByID(grid_here As System.Web.UI.WebControls.GridView, Id As Int32) As System.Web.UI.WebControls.GridView
        Return Display(grid_here, BuildSelectString("Employees", {"Id", "empTitle", "empName", "empGender", "empUsername", "empPassword"}, {"Id"}, "Id", OrderBy.ASC), con_string__, {"Id", Id})
        'If ID is Username, like in Cart, replace ID with Username
    End Function

    Public Shared Function DropId(IdDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If IdDropDown.Items.Count < 1 Then BindProperty(IdDropDown, BuildSelectString_DISTINCT("Employees", {"Id"}, Nothing), con_string__, Nothing, "Id")
        Return IdDropDown

    End Function
    Public Shared Function DropempTitle(empTitleDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If empTitleDropDown.Items.Count < 1 Then BindProperty(TempDropDown, BuildSelectString_DISTINCT("Employees", {"empTitle"}, Nothing), con_string__, Nothing, "empTitle")
        For i = CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Count - 1 To 0 Step -1
            CType(empTitleDropDown, System.Web.UI.WebControls.DropDownList).Items.Add(Decrypt(key__, CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Item(i).ToString))
        Next
        CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Visible = False
        Return empTitleDropDown

    End Function
    Public Shared Function DropempName(empNameDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If empNameDropDown.Items.Count < 1 Then BindProperty(TempDropDown, BuildSelectString_DISTINCT("Employees", {"empName"}, Nothing), con_string__, Nothing, "empName")
        For i = CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Count - 1 To 0 Step -1
            CType(empNameDropDown, System.Web.UI.WebControls.DropDownList).Items.Add(Decrypt(key__, CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Item(i).ToString))
        Next
        CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Visible = False
        Return empNameDropDown

    End Function
    Public Shared Function DropempGender(empGenderDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If empGenderDropDown.Items.Count < 1 Then BindProperty(TempDropDown, BuildSelectString_DISTINCT("Employees", {"empGender"}, Nothing), con_string__, Nothing, "empGender")
        For i = CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Count - 1 To 0 Step -1
            CType(empGenderDropDown, System.Web.UI.WebControls.DropDownList).Items.Add(Decrypt(key__, CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Item(i).ToString))
        Next
        CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Visible = False
        Return empGenderDropDown

    End Function
    Public Shared Function DropempUsername(empUsernameDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If empUsernameDropDown.Items.Count < 1 Then BindProperty(TempDropDown, BuildSelectString_DISTINCT("Employees", {"empUsername"}, Nothing), con_string__, Nothing, "empUsername")
        For i = CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Count - 1 To 0 Step -1
            CType(empUsernameDropDown, System.Web.UI.WebControls.DropDownList).Items.Add(Decrypt(key__, CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Item(i).ToString))
        Next
        CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Visible = False
        Return empUsernameDropDown

    End Function
    Public Shared Function DropempPassword(empPasswordDropDown As System.Web.UI.WebControls.DropDownList, TempDropDown As System.Web.UI.WebControls.DropDownList) As System.Web.UI.WebControls.DropDownList
        If empPasswordDropDown.Items.Count < 1 Then BindProperty(TempDropDown, BuildSelectString_DISTINCT("Employees", {"empPassword"}, Nothing), con_string__, Nothing, "empPassword")
        For i = CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Count - 1 To 0 Step -1
            CType(empPasswordDropDown, System.Web.UI.WebControls.DropDownList).Items.Add(Decrypt(key__, CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Items.Item(i).ToString))
        Next
        CType(TempDropDown, System.Web.UI.WebControls.DropDownList).Visible = False
        Return empPasswordDropDown

    End Function


    Public Shared Function MigrateProfileToAccount()
        'shop only
        'update field of same name in accounts table with ...
        Dim p As New System.Web.Profile.ProfileBase()
        p.GetPropertyValue("numberOfVisits")
        'or Statistics.Traffic.GetNumberOfVisits 
    End Function


    Public Shared Function Delete() As Boolean
        Return CommitSequel(DeleteString_CONDITIONAL("Employees", {"Id", "="}), con_string__, {"Id", ""})
    End Function

    Public Shared Function Exists(Id As Int32) As Boolean
        Return QExists("Employees", con_string__, {"Id"}, {"Id", Encrypt(key__, Id)})
    End Function

End Class