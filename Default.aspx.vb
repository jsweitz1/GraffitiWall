Public Class _Default
    Inherits System.Web.UI.Page
    Dim cn As New Data.SqlClient.SqlConnection("Data Source=tcp:graffitiwalldbserver.database.windows.net,1433;Initial Catalog=GraffitiWall_db;User Id=jsweitz1@graffitiwalldbserver;Password=ASA732!ASA732!")


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myReader As Data.SqlClient.SqlDataReader
        Dim message As String
        Dim cmd As New Data.SqlClient.SqlCommand(("SELECT TOP 1 MessageContent FROM Messages ORDER BY NEWID()"), cn)

        Try
            cn.Open()
            myReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            While myReader.Read()
                message = myReader("MessageContent")
                lblGraffiti.Text = message
            End While
        Catch ex As Exception
            myReader = Nothing
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub btnShowGraffiti_Click(sender As Object, e As EventArgs) Handles btnShowGraffiti.Click
        lblGraffiti.Text = "This is a test Graffiti!!"




        Dim myReader As Data.SqlClient.SqlDataReader
        Dim message As String
        Dim cmd As New Data.SqlClient.SqlCommand(("SELECT TOP 1 MessageContent FROM Messages ORDER BY NEWID()"), cn)

        Try
            cn.Open()
            myReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            While myReader.Read()
                message = myReader("MessageContent")
                lblGraffiti.Text = message
            End While
        Catch ex As Exception
            myReader = Nothing
        Finally
            cn.Close()
        End Try

    End Sub

    Protected Sub btnAddGraffiti_Click(sender As Object, e As EventArgs) Handles btnAddGraffiti.Click
        Response.Redirect("~/Add.aspx")
    End Sub
End Class