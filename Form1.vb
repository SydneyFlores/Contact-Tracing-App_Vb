Imports System.IO


Public Class Form1
    Dim txtwriter As StreamWriter




    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        txtwriter = My.Computer.FileSystem.OpenTextFileWriter("Data.txt", True)
        txtwriter.WriteLine("FullName: " & TextBoxfn.Text)
        txtwriter.WriteLine("ContactNumber: " & TextBoxcn.Text)
        txtwriter.WriteLine("Address: " & RichTextBoxadr.Text)
        txtwriter.WriteLine("EmailAddress: " & TextBoxea.Text)
        txtwriter.WriteLine("Date: " & DateTimePickerdate.Text)


        txtwriter.Close()
        MessageBox.Show("Successfully Added")
    End Sub
End Class
