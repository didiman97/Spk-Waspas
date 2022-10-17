Imports System.Data.OleDb

Public Class FormPenilaian
    Sub tampildata()
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Alternatif order by KodePetani asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ComboBox3.Items.Clear()
                    While Data.Read
                        ComboBox3.Items.Add(Data("KodePetani"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
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
                        ListView1.Items(x).SubItems.Add(Data("c1"))
                        ListView1.Items(x).SubItems.Add(Data("c2"))
                        ListView1.Items(x).SubItems.Add(Data("c3"))
                        ListView1.Items(x).SubItems.Add(Data("c4"))
                        ListView1.Items(x).SubItems.Add(Data("c5"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using



    End Sub
    Private Sub FormPenilaian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampildata()

    End Sub
    Sub bersihdata()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Using koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("insert into NilaiKriteria values('" & _
                                              ComboBox3.Text & "','" & _
                                              TextBox2.Text & "','" & _
                                              TextBox3.Text & "','" & _
                                              TextBox4.Text & "','" & _
                                              TextBox5.Text & "','" & _
                                              ComboBox1.Text & "','" & _
                                              ComboBox2.Text & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data " & TextBox2.Text & " Berhasil Disimpan")
                    Call tampildata()
                    Call bersihdata()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Call tampildata()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("update NilaiKriteria set Nama='" & TextBox2.Text & _
                                                                     "',c1='" & TextBox3.Text & _
                                                                     "',c2='" & TextBox4.Text & _
                                                                     "',c3='" & TextBox5.Text & _
                                                                     "',c4='" & ComboBox1.Text & _
                                                                     "',c5='" & ComboBox2.Text & _
                                                                     "' where KodePetani='" & ComboBox3.Text & "'", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Perubahan Data Berhasil")
            Call tampildata()
            Call bersihdata()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim konfirmasi As String
        konfirmasi = MsgBox("Anda Yakin Ingin Menghapus Data " & TextBox2.Text & " ...?", vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Try
                Using Koneksi As New OleDbConnection(Database)
                    Using Cmd As New OleDbCommand("delete * from NilaiKriteria where KodePetani='" & ComboBox3.Text & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()
                    End Using
                End Using

                Call tampildata()

                Call bersihdata()

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        Else
            bersihdata()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call bersihdata()
        Call tampildata()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        ComboBox3.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
        TextBox5.Text = ListView1.SelectedItems(0).SubItems(5).Text.ToString
        ComboBox1.Text = ListView1.SelectedItems(0).SubItems(6).Text.ToString
        ComboBox2.Text = ListView1.SelectedItems(0).SubItems(7).Text.ToString

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Alternatif where KodePetani='" & ComboBox3.Text & "'", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    While Data.Read
                        TextBox2.Text = (Data("Nama"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class