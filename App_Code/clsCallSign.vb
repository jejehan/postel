'--- System Module ---
Imports Microsoft.VisualBasic

'--- Custom Module ---
Imports clsDataBase
Imports clsGeneral
Imports System.Data
Imports System

Public Class clsCallSign

    Public Shared Function CallSignPrefixHuruf(ByVal ProsesID As String, ByVal Company As String, _
                                     ByVal Tingkat As String, ByVal Orda As String) As String

        Dim s As String = ""
        Try
            Select Case UCase(Tingkat)
                Case "BARU", "PEMULA"
                    s = "YH"
                Case "SIAGA"
                    Select Case Orda
                        Case "8", "13", "21", "25", "27"
                            s = "YD"
                        Case "9", "14", "22", "26", "28"
                            s = "YG"
                        Case Else
                            s = "YD,YG"
                    End Select
                Case "PENGGALANG"
                    Select Case Orda
                        Case "8", "13", "21", "25", "27"
                            s = "YC"
                        Case "9", "14", "22", "26", "28"
                            s = "YF"
                        Case Else
                            s = "YC,YF"
                    End Select
                Case "PENEGAK"
                    Select Case Orda
                        Case "8", "13", "21", "25", "27"
                            s = "YB"
                        Case "9", "14", "22", "26", "28"
                            s = "YE"
                        Case Else
                            s = "YB,YE"
                    End Select
                Case "KHUSUS", "KEHORMATAN"
                    Select Case Orda
                        Case "8", "13", "21", "25", "27"
                            s = "YB,YC,YD"
                        Case "9", "14", "22", "26", "28"
                            s = "YE,YF,YG"
                    End Select
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try

        Return s

    End Function

    Public Shared Function CallArea(ByVal Orda As String) As String

        Dim s As String = ""
        Try
            Select Case Orda
                Case "1"
                    s = "0"
                Case "2", "3"
                    s = "1"
                Case "4", "5"
                    s = "2"
                Case "6"
                    s = "3"
                Case "7", "8", "9", "10", "11"
                    s = "4"
                Case "12", "13", "14"
                    s = "5"
                Case "15", "16"
                    s = "6"
                Case "17", "18", "19", "20"
                    s = "7"
                Case "21", "22", "23", "24", "26", "27", "28"
                    s = "8"
                Case "29", "30", "31", "32", "33"
                    s = "9"
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try

        Return s

    End Function

    Public Shared Function CallSignSuffix(ByVal ProsesID As String, ByVal Company As String, _
                                     ByVal Tingkat As String, ByVal Orda As String, _
                                     ByVal CallSignPrefixHuruf1a As String) As String
        Dim i As Integer = 0
        Dim CS As String = ""
        Dim s As String = "a"
        Dim dt As DataTable = Nothing
        Dim Count As Integer = 0
        Dim CallSignPrefixHuruf1 As String = ""
        Dim CallSignPrefixAngka1 As String = ""
        Dim CallSignSuffix1 As String = ""
        Dim KodeOrda_Tingkat As String = ConvertDigit(Orda, 2) & CallArea(Orda)
        Dim CS_Suffix As String = ""
        Dim CS_Suffix_Abjad As String = ""
        Try
            CallSignPrefixHuruf1 = CallSignPrefixHuruf(ProsesID, Company, Tingkat, Orda)
            CallSignPrefixAngka1 = CallArea(Orda)

            Select Case KodeOrda_Tingkat
                Case "010" '--- Jakarta
                    For i = 2 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "021" '--- Jabar
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "031" '--- Banten
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "042" '--- Jateng
                    For i = 2 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "052" '--- Yogyakarta
                    For i = 2 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "063" '--- Jatim
                    For i = 2 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "074" '--- Jambi
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "084" '--- Sumsel
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "094" '--- Bangka Belitung
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "104" '--- Bengkulu
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "114" '--- Lampung
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "125" '--- Sumbar
                    For i = 2 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "135" '--- Riau
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "145" '--- Kep. Riau
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "156" '--- Aceh
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "166" '--- Sumut
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "177" '--- Kalbar
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "187" '--- Kalsel
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "197" '--- Kalteng
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "207" '--- Kaltim
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "218" '--- Sulsel
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "228" '--- Sulbar
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "238" '--- Sultenggara
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "248" '--- Sultengah
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "258" '--- Sulut
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "268" '--- Gorontalo
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "278" '--- Maluku
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "288" '--- Maluku Utara
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "299" '--- Bali
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "309" '--- NTB
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "319" '--- NTT
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "329" '--- Papua Barat
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
                Case "339" '--- Papua
                    For i = 3 To 4
                        dt = getCSSuffix(KodeOrda_Tingkat, i)
                        If dt.Rows(0)("Suffix_IAR_StatusFull") = 0 Then
                            Exit For
                        End If
                    Next
            End Select
            CS_Suffix = dt.Rows(0)("Suffix_IAR_Start")
            Do Until s = ""
                CS_Suffix_Abjad = ""
                For i = 1 To Len(CS_Suffix) Step 2
                    CS_Suffix_Abjad = CS_Suffix_Abjad & ConvertAbjad(Mid(CS_Suffix, i, 2))
                Next
                s = CekCallSign(CallSignPrefixHuruf1 & CallSignPrefixAngka1 & CS_Suffix_Abjad, "IAR")
                If s = "" Then
                    s = CS_Suffix_Abjad
                    Exit Do
                Else
                    CS_Suffix = CS_Suffix + 1
                End If
            Loop
        Catch ex As Exception
            s = ex.Message
        End Try

        Return s

    End Function

    Public Shared Function ConvertAbjad(ByVal Angka As String) As String

        Dim s1 As String = ""
        Try
            Select Case Angka
                Case "10"
                    s1 = ""
                Case "11"
                    s1 = "A"
                Case "12"
                    s1 = "B"
                Case "13"
                    s1 = "C"
                Case "14"
                    s1 = "D"
                Case "15"
                    s1 = "E"
                Case "16"
                    s1 = "F"
                Case "17"
                    s1 = "G"
                Case "18"
                    s1 = "H"
                Case "19"
                    s1 = "I"
                Case "20"
                    s1 = "J"
                Case "21"
                    s1 = "K"
                Case "22"
                    s1 = "L"
                Case "23"
                    s1 = "M"
                Case "24"
                    s1 = "N"
                Case "25"
                    s1 = "O"
                Case "26"
                    s1 = "P"
                Case "27"
                    s1 = "Q"
                Case "28"
                    s1 = "R"
                Case "29"
                    s1 = "S"
                Case "30"
                    s1 = "T"
                Case "31"
                    s1 = "U"
                Case "32"
                    s1 = "V"
                Case "33"
                    s1 = "W"
                Case "34"
                    s1 = "X"
                Case "35"
                    s1 = "Y"
                Case "36"
                    s1 = "Z"

            End Select

        Catch ex As Exception
            s1 = ex.Message
        End Try
        Return s1

    End Function

    Public Shared Function CallSign(ByVal ProsesID As String, ByVal Company As String, _
                                     ByVal Tingkat As String, ByVal Orda As String) As String

        Dim s As String = ""
        Dim CallSignNew As String = ""
        Dim CallSignPrefixHuruf1 As String = ""
        Dim CallSignPrefixAngka1 As String = ""
        Dim CallSignSuffix1 As String = ""
        Try
            CallSignPrefixHuruf1 = CallSignPrefixHuruf(ProsesID, Company, Tingkat, Orda)
            CallSignPrefixAngka1 = CallArea(Orda)
            CallSignSuffix1 = CallSignSuffix(ProsesID, Company, Tingkat, Orda, CallSignPrefixHuruf1)
            CallSignNew = CallSignPrefixHuruf1 & CallSignPrefixAngka1 & CallSignSuffix1
            s = CekCallSign(CallSignNew, "IAR")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s


    End Function

End Class
