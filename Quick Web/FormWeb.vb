Public Class FormWeb
    Private Sub FormWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        doBrowse()
    End Sub


    Private Sub doBrowse()
        Web.Url = New Uri(TxtWeb.Text)
    End Sub

    Private Sub Web_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Web.DocumentCompleted
        Dim bmp As Bitmap = New Bitmap(GetFavIcon)
        Me.Icon = Icon.FromHandle(bmp.GetHicon)
        Me.Text = Web.Document.Title
        TxtWeb.Text = Web.Document.Url.ToString
    End Sub

    Private Function GetFavIcon() As Image
        Dim iconURL = "http://" & Web.Url.Host & "/favicon.ico"
        Dim request As Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
        Dim response As Net.HttpWebResponse = request.GetResponse()
        Dim stream As IO.Stream = response.GetResponseStream()
        Return Image.FromStream(stream)
    End Function

    Private Sub CmdHome_Click(sender As Object, e As EventArgs) Handles CmdHome.Click
        Web.Url = New Uri(My.Settings.home)
    End Sub

    Private Sub CmdForward_Click(sender As Object, e As EventArgs) Handles CmdForward.Click
        Web.GoForward()
    End Sub

    Private Sub CmdBack_Click(sender As Object, e As EventArgs) Handles CmdBack.Click
        Web.GoBack()
    End Sub

    Private Sub TxtWeb_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWeb.KeyDown
        If e.KeyCode = Keys.Enter Then
            doBrowse()
        End If
    End Sub
End Class
