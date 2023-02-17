Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = TextBox1.Text
        Dim reader As StreamReader = New StreamReader(path)
        Dim content As String = reader.ReadToEnd()
        RichTextBox1.Text = content
        reader.Close()

        Dim delimiter As Char = " "
        Dim boxContent As String = RichTextBox1.Text
        Dim substrings As String() = boxContent.Split(delimiter)
        Dim ganjil As Integer = 0
        Dim genap As Integer = 0
        Dim total As Integer = 0

        For Each Data As String In substrings
            total += 1
            If Integer.Parse(Data) Mod 2 = 0 Then
                genap += 1
            Else
                ganjil += 1
            End If

        Next

        Label4.Text = $"Jumlah Angka Ganjil { ganjil }"
        Label3.Text = $"Jumlah Angka Genap { genap }"
        Label5.Text = $"Jumlah Seluruh Angka { total }"

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
