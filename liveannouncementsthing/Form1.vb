Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TwitterBox.Text = "i'm live ! <3" & Environment.NewLine & "https://twitch.tv/soafen / https://youtube.com/channel/UCuYCyQxgGPEzggZnfzV4xDQ/live" & Environment.NewLine & DescriptionBox.Text
        DiscordBox.Text = "@stream pings" & Environment.NewLine & "i'm live!! \<33" & Environment.NewLine & "<https://twitch.tv/soafen> / https://youtube.com/channel/UCuYCyQxgGPEzggZnfzV4xDQ/live" & Environment.NewLine & DescriptionBox.Text
    End Sub
End Class
