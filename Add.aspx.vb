Public Class Add
    Inherits System.Web.UI.Page
    Dim cn As New Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\GraffitiDB.mdf;Integrated Security=True")

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbAdd.Text = ""
        lblStatus.Text = ""

    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblGraffitiAdd.Text = tbAdd.Text
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim message As String
        Dim timestamp As String

        message = tbAdd.Text
        message = message.Replace("""", "")
        message = message.Replace("'", "")
        message = message.Replace(";", "")
        timestamp = DateTime.Now

        If String.IsNullOrEmpty(message) Then
            lblStatus.Text = "Type Something..."
        Else
            cn.Open()
            Dim cmd As New Data.SqlClient.SqlCommand(("INSERT INTO Messages (MessageContent, MessageTimestamp) VALUES ('" & message & "', '" & timestamp & "')"), cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            tbAdd.Text = ""
            lblGraffitiAdd.Text = ""
            lblStatus.Text = "Graffiti Added!"
            SetFocus(tbAdd)
        End If


    End Sub
End Class