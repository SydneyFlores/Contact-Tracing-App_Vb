Imports System.IO
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec


Public Class Form1
    Dim txtwriter As StreamWriter
    Dim Display As VideoCaptureDevice
    Dim bitDisplay As Bitmap




    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        txtwriter = My.Computer.FileSystem.OpenTextFileWriter("Data.txt", True)
        txtwriter.WriteLine("*********************************** ")
        txtwriter.WriteLine(vbLf & "FullName: " & TextBoxfn.Text)
        txtwriter.WriteLine("ContactNumber: " & TextBoxcn.Text)
        txtwriter.WriteLine("Address: " & RichTextBoxadr.Text)
        txtwriter.WriteLine("EmailAddress: " & TextBoxea.Text)
        txtwriter.WriteLine("Date: " & DateTimePickerdate.Text)


        txtwriter.Close()
        MessageBox.Show("Successfully Added")
    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        Dim camDisplay As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If camDisplay.ShowDialog() = DialogResult.OK Then
            Display = camDisplay.VideoDevice
            AddHandler Display.NewFrame, New NewFrameEventHandler(AddressOf PictureBoxDisplay)
            Display.Start()
            Timerupdater.Start()
        End If

    End Sub

    Private Sub PictureBoxDisplay(sender As Object, eventArgs As NewFrameEventArgs)
        bitDisplay = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        CameraDisplay.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Timerupdater_Tick(sender As Object, e As EventArgs) Handles Timerupdater.Tick
        Dim camerareader As BarcodeReader = New BarcodeReader()
        If CameraDisplay.Image IsNot Nothing Then

            Dim readerresult As Result = camerareader.Decode(DirectCast(CameraDisplay.Image, Bitmap))
            If readerresult IsNot Nothing Then
                Dim output As String = readerresult.ToString()
                Dim data As String() = output.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                TextBoxfn.Text = data(0)
                TextBoxcn.Text = data(1)
                RichTextBoxadr.Text = data(2)
                TextBoxea.Text = data(3)

                Timerupdater.Stop()


            End If
        End If
    End Sub
End Class
