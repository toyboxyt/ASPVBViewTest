Public Class DataClass


    Public Function getDataField() As DataSet

        Dim dt As DataTable
        Dim dr As DataRow

        Dim ds As DataSet

        dt = New DataTable()

        dt.Columns.Add("DataTextField", GetType(String))
        dt.Columns.Add("DataValueField", GetType(String))

        dr = dt.NewRow
        dr("DataValueField") = "100"
        dr("DataTextField") = "100です。"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DataValueField") = "200"
        dr("DataTextField") = "200です。"
        dt.Rows.Add(dr)

        'DataSet作成
        ds = New DataSet
        ds.Tables.Add(dt)

        Return ds
    End Function


    Public Function getData() As DataSet
        Dim dt As DataTable
        Dim dr As DataRow

        Dim ds As DataSet

        dt = New DataTable()

        dt.Columns.Add("DropDownList", GetType(String))

        dr = dt.NewRow
        dr("DropDownList") = "100"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DropDownList") = "200"
        dt.Rows.Add(dr)

        'DataSet作成
        ds = New DataSet
        ds.Tables.Add(dt)

        Return ds
    End Function

End Class
