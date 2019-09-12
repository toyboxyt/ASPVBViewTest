Public Class UpdatePanelTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Debug.WriteLine("test")
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = Integer.Parse(TextBox2.Text)
        Dim b As Integer = Integer.Parse(TextBox3.Text)
        TextBox1.Text = Convert.ToString(a + b)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = Integer.Parse(TextBox4.Text)
        Dim b As Integer = Integer.Parse(TextBox5.Text)
        TextBox6.Text = Convert.ToString(a + b)
    End Sub

End Class