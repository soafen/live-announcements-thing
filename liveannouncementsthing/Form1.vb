﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.LiveStreaming_IsOn, AudioPlayMode.Background)
        TwitterBox.Text = "i'm live ! <3" & Environment.NewLine & "lightspeed.tv/soafen" & Environment.NewLine & "kick.com/soafen" & Environment.NewLine & "youtube.com/@soafen/live" & Environment.NewLine & DescriptionBox.Text & Environment.NewLine & "# # #"
        DiscordBox.Text = "@stream pings" & Environment.NewLine & "i'm live!! \<33" & Environment.NewLine & Environment.NewLine & "https://lightspeed.tv/soafen" & Environment.NewLine & "https://kick.com/soafen" & Environment.NewLine & "https://youtube.com/@soafen/live" & Environment.NewLine & Environment.NewLine & DescriptionBox.Text
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.title = TitleBox.Text
        My.Settings.desc = DescriptionBox.Text
        My.Computer.Audio.Play(My.Resources.LiveStreaming_HasStopped, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TitleBox.Text = My.Settings.title
        DescriptionBox.Text = My.Settings.desc
    End Sub

    Private Sub titlebox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleBox.TextChanged
        My.Settings.title = TitleBox.Text
    End Sub

    Private Sub DescriptionBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescriptionBox.TextChanged
        My.Settings.desc = DescriptionBox.Text
    End Sub
End Class
