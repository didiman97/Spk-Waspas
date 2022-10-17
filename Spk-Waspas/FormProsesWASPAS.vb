Imports System.Data.OleDb

Public Class FormProsesWASPAS

    Dim bobot1, bobot2, bobot3, bobot4, bobot5 As Decimal


    Dim total As Decimal = 0
    Dim maxc1 As Double = 0
    Dim maxc2 As Double = 0
    Dim maxc3 As Double = 0
    Dim maxc4 As Double = 0
    Dim maxc5 As Double = 0
    Dim minc1 As Double = 99999
    Dim minc2 As Double = 99999
    Dim minc3 As Double = 99999
    Dim minc4 As Double = 99999
    Dim minc5 As Double = 99999
    Dim nilc1 As String = ""
    Dim nilc2 As String = ""
    Dim nilc3 As String = ""
    Dim nilc4 As String = ""
    Dim nilc5 As String = ""



    Sub TampilData()
        On Error Resume Next
        'Untuk mengetahui nilai benefit dan cost
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Kriteria order by KodeKriteria asc ", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    Dim s As Integer
                    ListView1.Items.Clear()
                    While Data.Read
                        If Data("Keterangan") = "Benefit" Then
                            s = 1
                        Else
                            s = -1

                        End If
                        If Data("KodeKriteria") = "C1" Then
                            bobot1 = s * (Data("Bobot"))
                        ElseIf Data("KodeKriteria") = "C2" Then
                            bobot2 = s * (Data("Bobot"))
                        ElseIf Data("KodeKriteria") = "C3" Then
                            bobot3 = s * (Data("Bobot"))
                        ElseIf Data("KodeKriteria") = "C4" Then
                            bobot4 = s * (Data("Bobot"))
                        ElseIf Data("KodeKriteria") = "C5" Then
                            bobot5 = s * (Data("Bobot"))

                        End If
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        'Algoritma Ke 2 = Merubah Nilai Kriteria Menjadi Matriks Keputusan
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from NilaiKriteria order by KodePetani asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(x + 1)
                        ListView1.Items(x).SubItems.Add(Data("KodePetani"))
                        ListView1.Items(x).SubItems.Add(Data("Nama"))



                        Dim c1 As Integer
                        If Val(Data("c1")) >= 0 And Val(Data("c1")) <= 6 Then
                            c1 = 1
                        ElseIf Val(Data("c1")) >= 7 And Val(Data("c1")) <= 9 Then
                            c1 = 2
                        ElseIf Val(Data("c1")) >= 10 And Val(Data("c1")) <= 15 Then
                            c1 = 3
                        Else
                            c1 = 4
                        End If
                        Dim c2 As Integer
                        If Val(Data("c2")) >= 0 And Val(Data("c2")) <= 4 Then
                            c2 = 1
                        ElseIf Val(Data("c2")) >= 5 And Val(Data("c2")) <= 8 Then
                            c2 = 2
                        ElseIf Val(Data("c2")) >= 9 And Val(Data("c2")) <= 16 Then
                            c2 = 3
                        Else
                            c2 = 4
                        End If

                        Dim c3 As Integer
                        If Val(Data("c3")) >= 0 And Val(Data("c3")) <= 3 Then
                            c3 = 1
                        ElseIf Val(Data("c3")) >= 4 And Val(Data("c3")) <= 6 Then
                            c3 = 2
                        ElseIf Val(Data("c3")) >= 7 And Val(Data("c3")) <= 12 Then
                            c3 = 3
                        Else
                            c3 = 4
                        End If
                        Dim c4 As Integer
                        Dim c5 As Integer
                        If (Data("c4")) = "Tidak Memiliki" Then
                            c4 = 1
                        Else
                            c4 = 4
                        End If

                        If (Data("c5")) = "Tidak Memiliki" Then
                            c5 = 1
                        Else
                            c5 = 4
                        End If




                        ListView1.Items(x).SubItems.Add(c1)
                        ListView1.Items(x).SubItems.Add(c2)
                        ListView1.Items(x).SubItems.Add(c3)
                        ListView1.Items(x).SubItems.Add(c4)
                        ListView1.Items(x).SubItems.Add(c5)



                        x = x + 1

                    End While
                End Using
            End Using
        End Using
    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView2.Items.Clear()
        ListView3.Items.Clear()
        Using Koneksi As New OleDbConnection(Database)
            Using Cmd As New OleDbCommand("delete * from Hasil ", Koneksi)
                Koneksi.Open()
                Cmd.CommandType = CommandType.Text
                Cmd.ExecuteNonQuery()
            End Using
        End Using


        For i = 0 To ListView1.Items.Count - 1


            Dim c1 As Double = ListView1.Items(i).SubItems(3).Text.ToString
            Dim c2 As Double = ListView1.Items(i).SubItems(4).Text.ToString
            Dim c3 As Double = ListView1.Items(i).SubItems(5).Text.ToString
            Dim c4 As Double = ListView1.Items(i).SubItems(6).Text.ToString
            Dim c5 As Double = ListView1.Items(i).SubItems(7).Text.ToString
            ' MsgBox(i + 1 & "--" & c5)

            If maxc1 < c1 Then
                maxc1 = c1
            End If
            If maxc2 < c2 Then
                maxc2 = c2
            End If

            If maxc3 < c3 Then
                maxc3 = c3
            End If
            If maxc4 < c4 Then
                maxc4 = c4
            End If

            If maxc5 < c5 Then
                maxc5 = c5
            End If

            If minc1 > c1 Then
                minc1 = c1
            End If
            If minc2 > c2 Then
                minc2 = c2
            End If

            If minc3 > c3 Then
                minc3 = c3
            End If
            If minc4 > c4 Then
                minc4 = c4
            End If

            If minc5 > c5 Then
                minc5 = c5
            End If

        Next
        For i = 0 To ListView1.Items.Count - 1
            Dim a As Double = ListView1.Items(i).SubItems(3).Text.ToString
            Dim b As Double = ListView1.Items(i).SubItems(4).Text.ToString
            Dim c As Double = ListView1.Items(i).SubItems(5).Text.ToString
            Dim d As Double = ListView1.Items(i).SubItems(6).Text.ToString
            Dim ee As Double = ListView1.Items(i).SubItems(7).Text.ToString
            'proses normalisasi Matriks
            If bobot1 > 0 Then
                ListView2.Items.Add(a / maxc1)
            Else
                ListView2.Items.Add(minc1 / a)
            End If
            If bobot2 > 0 Then
                ListView2.Items(i).SubItems.Add(b / maxc2)

            Else
                ListView2.Items(i).SubItems.Add(minc2 / b)
            End If

            If bobot3 > 0 Then
                ListView2.Items(i).SubItems.Add(c / 4)

            Else
                ListView2.Items(i).SubItems.Add(minc3 / c)
            End If
            If bobot4 > 0 Then
                ListView2.Items(i).SubItems.Add(d / maxc4)

            Else
                ListView2.Items(i).SubItems.Add(minc4 / d)
            End If
            If bobot5 > 0 Then
                ListView2.Items(i).SubItems.Add(ee / maxc5)

            Else
                ListView2.Items(i).SubItems.Add(minc5 / ee)
            End If
        Next

        For i = 0 To ListView2.Items.Count - 1
            Dim kode As String = ListView1.Items(i).SubItems(1).Text.ToString
            Dim nama As String = ListView1.Items(i).SubItems(2).Text.ToString
            Dim c1 As String = ListView2.Items(i).Text.ToString
            Dim c2 As String = ListView2.Items(i).SubItems(1).Text.ToString
            Dim c3 As String = ListView2.Items(i).SubItems(2).Text.ToString
            Dim c4 As String = ListView2.Items(i).SubItems(3).Text.ToString
            Dim c5 As String = ListView2.Items(i).SubItems(4).Text.ToString
            Dim bb1 As Double = bobot1
            Dim wsm As Double
            Dim wp As Double

            wsm = 0.5 * ((c1 * 0.15) + (c2 * 0.18) + (c3 * 0.2) + (c4 * 0.22) + (c5 * 0.25))
            wp = 0.5 * ((c1 ^ 0.15) * (c2 ^ 0.18) * (c3 ^ 0.2) * (c4 ^ 0.22) * (c5 ^ 0.25))
            Dim qi As Double = FormatNumber((wsm + wp), 3)

            ListView3.Items.Add(kode)
            ListView3.Items(i).SubItems.Add(nama)
            ListView3.Items(i).SubItems.Add(qi)
            Dim ket As String = "-"
            Using koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("insert into Hasil values('" & _
                                              kode & "','" & _
                                              nama & "','" & _
                                              qi & "','" & _
                                               ket & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using
        Next

        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Hasil order by NilaiAkhir desc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView3.Items.Clear()
                    While Data.Read
                        ListView3.Items.Add(Data("KodePetani"))
                        ListView3.Items(x).SubItems.Add(Data("Nama"))
                        ListView3.Items(x).SubItems.Add(Data("NilaiAkhir"))
                        ListView3.Items(x).SubItems.Add("Prioritas - " & x + 1)
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        Using Koneksi As New OleDbConnection(Database)
            Using Cmd As New OleDbCommand("delete * from Hasil ", Koneksi)
                Koneksi.Open()
                Cmd.CommandType = CommandType.Text
                Cmd.ExecuteNonQuery()
            End Using
        End Using

        For i = 0 To ListView3.Items.Count - 1
            Dim a As String = ListView3.Items(i).Text.ToString
            Dim b As String = ListView3.Items(i).SubItems(1).Text.ToString
            Dim c As String = ListView3.Items(i).SubItems(2).Text.ToString
            Dim d As String = ListView3.Items(i).SubItems(3).Text.ToString

            Using koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("insert into Hasil values('" & _
                                              a & "','" & _
                                              b & "','" & _
                                              c & "','" & _
                                               d & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using

        Next

        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Hasil", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView3.Items.Clear()
                    While Data.Read
                        ListView3.Items.Add(Data("KodePetani"))
                        ListView3.Items(x).SubItems.Add(Data("Nama"))
                        ListView3.Items(x).SubItems.Add(Data("NilaiAkhir"))
                        ListView3.Items(x).SubItems.Add(Data("HasilKeputusan"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'FormLaporan.Show()

    End Sub

    Private Sub FormProsesWASPAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        'ListView3.Hide()

    End Sub
End Class