Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class _Default
    Inherits System.Web.UI.Page
    Class MyUser
        Public Property Name As String
        Public Property Age As Integer

        Public Sub New(ByVal inName As String, ByVal inAge As String)
            Name = inName
            Age = inAge
        End Sub
    End Class


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'DropDownList1.Items.Add(New ListItem("test", "7"))

        'Dim dic As New Dictionary(Of String, String)
        'dic.Add("なま", "1")
        'dic.Add("ffa", "rr2")
        'dic.Add("fe", "va3")

        'DropDownList1.DataSource = dic
        'DropDownList1.DataTextField = "Key"
        'DropDownList1.DataValueField = "Value"
        'DropDownList1.DataBind()


        Dim uslist As New List(Of MyUser)
        uslist.Add(New MyUser("yama", 18))
        uslist.Add(New MyUser("moto", 23))

        DropDownList3.DataSource = uslist
        DropDownList3.DataTextField = "Name"
        DropDownList3.DataValueField = "Age"
        DropDownList3.DataBind()



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("name")
        dt.Columns.Add("age")

        Dim newRow As DataRow = dt.NewRow()
        newRow("name") = "yamada"
        newRow("age") = 20
        dt.Rows.Add(newRow)

        newRow = dt.NewRow()
        newRow("name") = "ssuz"
        newRow("age") = 15
        dt.Rows.Add(newRow)

        DropDownList1.DataSource = dt
        DropDownList1.DataTextField = "name"
        DropDownList1.DataValueField = "age"
        DropDownList1.DataBind()
    End Sub



    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "0"

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Builder = New MySqlConnectionStringBuilder()
        ' データベースに接続するために必要な情報をBuilderに与える
        Builder.Server = "localhost"
        Builder.Port = 3306
        Builder.UserID = "root"
        Builder.Password = ""
        Builder.Database = "test"
        Dim ConStr = Builder.ToString()
        Dim Con As MySqlConnection = Nothing
        Con = New MySqlConnection
        Con.ConnectionString = ConStr
        Con.Open()

        Dim SqlStr As String

        SqlStr = String.Format("SELECT * FROM `{0}` WHERE `name`='{1}';", "abtb", "taro")
        Debug.WriteLine(String.Format("SQL On {0} -->{1}", "abtb", SqlStr))

        Dim Adapter = New MySqlDataAdapter(SqlStr, Con)
        Dim Ds As New DataSet
        Adapter.Fill(Ds)
        Con.Close()

        If Ds.Tables.Count > 0 Then
            Dim dt As DataTable = Ds.Tables(0)
            If dt.Rows.Count() > 0 Then
                Dim nIndex As Integer = 0
                For Each row As DataRow In dt.Rows
                    'Debug.WriteLine(row.ItemArray.ToList().ToString())
                    nIndex += 1
                Next
            Else
            End If
        End If

    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        Debug.WriteLine("" & DropDownList3.SelectedValue)
    End Sub

    Protected Sub DropDownList3_TextChanged(sender As Object, e As EventArgs) Handles DropDownList3.TextChanged
        Debug.WriteLine("" & DropDownList3.SelectedValue)

    End Sub

    Protected Sub DropDownList3_PreRender(sender As Object, e As EventArgs) Handles DropDownList3.PreRender
        DropDownList3.Enabled = CheckBox1.Checked
        Debug.WriteLine("DropDownList3_PreRender " & DropDownList3.SelectedValue)
    End Sub

    Protected Sub DropDownList3_DataBound(sender As Object, e As EventArgs) Handles DropDownList3.DataBound
        Debug.WriteLine("DropDownList3_DataBound " & DropDownList3.SelectedValue)

    End Sub

    Protected Sub DropDownList3_DataBinding(sender As Object, e As EventArgs) Handles DropDownList3.DataBinding
        Debug.WriteLine("DropDownList3_DataBinding " & DropDownList3.SelectedValue)

    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DropDownList3.Enabled = CheckBox1.Checked
    End Sub

    Protected Sub DropDownList3_Init(sender As Object, e As EventArgs) Handles DropDownList3.Init
        Debug.WriteLine("DropDownList3_Init " & DropDownList3.SelectedValue)
    End Sub

    Protected Sub DropDownList3_Disposed(sender As Object, e As EventArgs) Handles DropDownList3.Disposed
        Debug.WriteLine("DropDownList3_Disposed " & DropDownList3.SelectedValue)
    End Sub

    Protected Sub DropDownList3_Load(sender As Object, e As EventArgs) Handles DropDownList3.Load
        Debug.WriteLine("DropDownList3_Load " & DropDownList3.SelectedValue)
    End Sub

    Protected Sub DropDownList3_Unload(sender As Object, e As EventArgs) Handles DropDownList3.Unload
        Debug.WriteLine("DropDownList3_Unload " & DropDownList3.SelectedValue)
    End Sub
End Class