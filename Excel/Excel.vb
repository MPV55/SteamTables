Option Explicit

Private Function PropName(IProp As Integer) As String
Dim tagName As String

Select Case IProp

    Case 1
        tagName = "Volume"
    Case 2
        tagName = "Density"
    Case 3
        tagName = "Zo"
    Case 4
        tagName = "/U>"
    Case 5
        tagName = "H"
    Case 6
        tagName = "G>"
    Case 7
        tagName = "A"
    Case 8
        tagName = "S"
    Case 9
        tagName = "Cp"
    Case 10
        tagName = "Cv"
    Case 11
        tagName = "CTE"
    Case 12
        tagName = "Ziso"
    Case 13
        tagName = "VelS"
    Case 14
        tagName = "dPdT"
    Case 15
        tagName = "dTdV"
    Case 16
        tagName = "dVdP"
    Case 17
        tagName = "JTC"
    Case 18
        tagName = "IJTC"
    Case 19
        tagName = "Vis>"
    Case 20
        tagName = "ThrmCond"
    Case 21
        tagName = "SurfTen"
    Case 22
        tagName = "PrdNum"
    Case 23
        tagName = "DielCons"
End Select

PropName = tagName
End Function



Public Function WtrStmTbl95TP(Temp As Double, Press As Double, IPhs As Integer, IProp As Integer) As Double

'IPhs=1 -Liquid
'IPhs=2 -Vapor


Dim IE As New InternetExplorer

Dim Doc As HTMLDocument
Dim strProps As String
Dim tagName As String
Dim EleLen As Integer
Dim TagLen As Integer
Dim nDigit As Integer
    

On Error GoTo err

IE.Visible = False

IE.navigate "http://cemiegeo.somee.com/IIEWebServiceSteamTables.asmx/IAPWS95TP?Temp=" & Temp & "&Press=" & Press

    'Wait until IE is done loading page
    Do While IE.readyState <> READYSTATE_COMPLETE
        Application.StatusBar = "Loading ..."
        DoEvents
    Loop

    Application.StatusBar = ""


    Set Doc = IE.document
    Dim i As Integer


    If (IPhs = 1) Then
        i = 0
    ElseIf (IPhs = 2) Then
        i = 1
    Else
        MsgBox "IPhs can be 1 or 2"
        Exit Function
    End If

    If (IProp >= 1 And IProp <= 23) Then
        tagName = PropName(IProp)
    Else
        MsgBox "IProp can be 1 or 23"
        Exit Function
    End If



    strProps = Trim(Doc.getElementsByTagName(tagName)(i).innerText)

    EleLen = Len(strProps)
    TagLen = Len(tagName)

    nDigit = EleLen - TagLen * 2 - 5

    strProps = Mid(strProps, TagLen + 3, nDigit)
    WtrStmTbl95TP = Val(strProps)

    Exit Function

err:
    MsgBox Error

End Function


Public Function WtrStmTbl95T(SepBoundary As Integer, Temp As Double, IPhs As Integer, IProp As Integer) As Double

'IPhs=1 -Liquid
'IPhs=2 -Vapor


Dim IE As New InternetExplorer
Dim Doc As HTMLDocument
Dim strProps As String
Dim tagName As String
Dim i As Integer
Dim EleLen As Integer
Dim TagLen As Integer
Dim nDigit As Integer

On Error GoTo err

    IE.Visible = False

    IE.navigate "http://cemiegeo.somee.com/IIEWebServiceSteamTables.asmx/IAPWS95T?SepBoundary=" & SepBoundary & "&Temp=" & Temp

    'Wait until IE is done loading page
    Do While IE.readyState <> READYSTATE_COMPLETE
        Application.StatusBar = "Loading ..."
        DoEvents
    Loop

    Application.StatusBar = ""
    Set Doc = IE.document
    If (IPhs = 1) Then
        i = 0
    ElseIf (IPhs = 2) Then
        i = 1
    Else
        MsgBox "IPhs can be 1 or 2"
        Exit Function
    End If

    If (IProp >= 1 And IProp <= 23) Then
        tagName = PropName(IProp)
    Else
        MsgBox "IProp can be 1 or 23"
        Exit Function
    End If
    
    strProps = Trim(Doc.getElementsByTagName(tagName)(i).innerText)
    EleLen = Len(strProps)
    TagLen = Len(tagName)
    nDigit = EleLen - TagLen * 2 - 5

    strProps = Mid(strProps, TagLen + 3, nDigit)
    WtrStmTbl95T = Val(strProps)

    Exit Function

err:
    MsgBox Error
End Function


Public Function WtrStmTbl95P(SepBoundary As Integer, Press As Double, IPhs As Integer, IProp As Integer) As Double

'IPhs=1 -Liquid
'IPhs=2 -Vapor


Dim IE As New InternetExplorer
Dim Doc As HTMLDocument
Dim strProps As String
Dim tagName As String
Dim i As Integer
Dim EleLen As Integer
Dim TagLen As Integer
Dim nDigit As Integer

On Error GoTo err

    IE.Visible = False

    IE.navigate "http://cemiegeo.somee.com/IIEWebServiceSteamTables.asmx/IAPWS95P?SepBoundary=" & SepBoundary & "&Press=" & Press

    'Wait until IE is done loading page
    Do While IE.readyState <> READYSTATE_COMPLETE
        Application.StatusBar = "Loading ..."
        DoEvents
    Loop

    Application.StatusBar = ""

    Set Doc = IE.document

    If (IPhs = 1) Then
        i = 0
    ElseIf (IPhs = 2) Then
        i = 1
    Else
        MsgBox "IPhs can be 1 or 2"
        Exit Function
    End If

    If (IProp >= 1 And IProp <= 23) Then
        tagName = PropName(IProp)
    Else
        MsgBox "IProp can be 1 or 23"
        Exit Function
    End If

    strProps = Trim(Doc.getElementsByTagName(tagName)(i).innerText)
    EleLen = Len(strProps)
    TagLen = Len(tagName)
    nDigit = EleLen - TagLen * 2 - 5

    strProps = Mid(strProps, TagLen + 3, nDigit)
    WtrStmTbl95P = Val(strProps)

    Exit Function

err:
    MsgBox Error

End Function

Public Function TSep(SepBoundary As Integer, Press As Double) As Double

Dim IE As New InternetExplorer
Dim Doc As HTMLDocument
Dim strProps As String
Dim EleLen As Integer
Dim TagLen As Integer
Dim nDigit As Integer

On Error GoTo err

    IE.Visible = False

    IE.navigate "http://cemiegeo.somee.com/IIEWebServiceSteamTables.asmx/IAPWS95P?SepBoundary=" & SepBoundary & "&Press=" & Press

    'Wait until IE is done loading page
    Do While IE.readyState <> READYSTATE_COMPLETE
        Application.StatusBar = "Loading ..."
        DoEvents
    Loop

    Application.StatusBar = ""

    Set Doc = IE.document


    strProps = Trim(Doc.getElementsByTagName("Temp")(0).innerText)
    EleLen = Len(strProps)
    TagLen = Len("Temp")
    nDigit = EleLen - TagLen * 2 - 5

    strProps = Mid(strProps, TagLen + 3, nDigit)
    TSep = Val(strProps)

    Exit Function

err:
    MsgBox Error

End Function


Public Function PSep(SepBoundary As Integer, Temp As Double) As Double

Dim IE As New InternetExplorer
Dim Doc As HTMLDocument
Dim strProps As String
Dim EleLen As Integer
Dim TagLen As Integer
Dim nDigit As Integer

On Error GoTo err

    IE.Visible = False

    IE.navigate "http://cemiegeo.somee.com/IIEWebServiceSteamTables.asmx/IAPWS95T?SepBoundary=" & SepBoundary & "&Temp=" & Temp
    'Wait until IE is done loading page
    Do While IE.readyState <> READYSTATE_COMPLETE
        Application.StatusBar = "Loading ..."
        DoEvents
    Loop

    Application.StatusBar = ""

    Set Doc = IE.document


    strProps = Trim(Doc.getElementsByTagName("Press")(0).innerText)
    EleLen = Len(strProps)
    TagLen = Len("Press")
    nDigit = EleLen - TagLen * 2 - 5

    strProps = Mid(strProps, TagLen + 3, nDigit)
    PSep = Val(strProps)

    Exit Function

err:
    MsgBox Error
End Function
