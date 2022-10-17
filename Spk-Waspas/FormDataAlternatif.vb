Imports System.Data.OleDb

Public Class FormDataAlternatif
    Sub TampilData()
        On Error Resume Next

        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Alternatif order by KodePetani asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(x + 1)
                        ListView1.Items(x).SubItems.Add(Data("KodePetani"))
                        ListView1.Items(x).SubItems.Add(Data("Nama"))
                        ListView1.Items(x).SubItems.Add(Data("JenisKelamin"))
                        ListView1.Items(x).SubItems.Add(Data("PendidikanAkhir"))
                        ListView1.Items(x).SubItems.Add(Data("NIK"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using

    End Sub
    Sub bersihdata()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub FormDataNasabah_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call bersihdata()

    End Sub
    Private Sub FormDataNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Using koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("insert into Alternatif values('" & _
                                              TextBox1.Text & "','" & _
                                              TextBox2.Text & "','" & _
                                              ComboBox1.Text & "','" & _
                                              ComboBox2.Text & "','" & _
                                               TextBox3.Text & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data " & TextBox2.Text & " Berhasil Disimpan")
                    Call TampilData()
                    Call bersihdata()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Call TampilData()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        On Error Resume Next

        TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        ComboBox1.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        ComboBox2.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(5).Text.ToString

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("update Alternatif set Nama='" & TextBox2.Text & _
                                                                     "',JenisKelamin='" & ComboBox1.Text & _
                                                                     "',PendidikanAkhir='" & ComboBox2.Text & _
                                                                     "',NIK='" & TextBox3.Text & _
                                                                     "' where KodePetani='" & TextBox1.Text & "'", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Perubahan Data Berhasil")
            Call TampilData()
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
                    Using Cmd As New OleDbCommand("delete * from Alternatif where KodePetani='" & TextBox1.Text & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()
                    End Using
                End Using

                Call TampilData()

                Call bersihdata()

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        Else
            bersihdata()

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call bersihdata()
        Me.Close()

    End Sub




   
  

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call bersihdata()
        Call TampilData()

    End Sub
End Class