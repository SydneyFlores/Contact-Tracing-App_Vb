<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxfn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxcn = New System.Windows.Forms.TextBox()
        Me.TextBoxea = New System.Windows.Forms.TextBox()
        Me.RichTextBoxadr = New System.Windows.Forms.RichTextBox()
        Me.DateTimePickerdate = New System.Windows.Forms.DateTimePicker()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.CameraDisplay = New System.Windows.Forms.PictureBox()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Timerupdater = New System.Windows.Forms.Timer(Me.components)
        CType(Me.CameraDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing Form"
        '
        'TextBoxfn
        '
        Me.TextBoxfn.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfn.Location = New System.Drawing.Point(243, 151)
        Me.TextBoxfn.Name = "TextBoxfn"
        Me.TextBoxfn.Size = New System.Drawing.Size(203, 27)
        Me.TextBoxfn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contact Number : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enail Address : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Date : "
        '
        'TextBoxcn
        '
        Me.TextBoxcn.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxcn.Location = New System.Drawing.Point(243, 200)
        Me.TextBoxcn.Name = "TextBoxcn"
        Me.TextBoxcn.Size = New System.Drawing.Size(203, 27)
        Me.TextBoxcn.TabIndex = 7
        '
        'TextBoxea
        '
        Me.TextBoxea.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxea.Location = New System.Drawing.Point(243, 379)
        Me.TextBoxea.Name = "TextBoxea"
        Me.TextBoxea.Size = New System.Drawing.Size(203, 27)
        Me.TextBoxea.TabIndex = 9
        '
        'RichTextBoxadr
        '
        Me.RichTextBoxadr.Location = New System.Drawing.Point(243, 249)
        Me.RichTextBoxadr.Name = "RichTextBoxadr"
        Me.RichTextBoxadr.Size = New System.Drawing.Size(203, 96)
        Me.RichTextBoxadr.TabIndex = 11
        Me.RichTextBoxadr.Text = ""
        '
        'DateTimePickerdate
        '
        Me.DateTimePickerdate.Location = New System.Drawing.Point(243, 427)
        Me.DateTimePickerdate.Name = "DateTimePickerdate"
        Me.DateTimePickerdate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerdate.TabIndex = 12
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(367, 508)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 13
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'CameraDisplay
        '
        Me.CameraDisplay.Location = New System.Drawing.Point(476, 176)
        Me.CameraDisplay.Name = "CameraDisplay"
        Me.CameraDisplay.Size = New System.Drawing.Size(354, 334)
        Me.CameraDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CameraDisplay.TabIndex = 14
        Me.CameraDisplay.TabStop = False
        '
        'btnopen
        '
        Me.btnopen.Location = New System.Drawing.Point(581, 526)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(125, 53)
        Me.btnopen.TabIndex = 15
        Me.btnopen.Text = "Open Camera"
        Me.btnopen.UseVisualStyleBackColor = True
        '
        'Timerupdater
        '
        Me.Timerupdater.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(842, 671)
        Me.Controls.Add(Me.btnopen)
        Me.Controls.Add(Me.CameraDisplay)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.DateTimePickerdate)
        Me.Controls.Add(Me.RichTextBoxadr)
        Me.Controls.Add(Me.TextBoxea)
        Me.Controls.Add(Me.TextBoxcn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxfn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing App"
        CType(Me.CameraDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxfn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxcn As TextBox
    Friend WithEvents TextBoxea As TextBox
    Friend WithEvents RichTextBoxadr As RichTextBox
    Friend WithEvents DateTimePickerdate As DateTimePicker
    Friend WithEvents btnsubmit As Button
    Friend WithEvents CameraDisplay As PictureBox
    Friend WithEvents btnopen As Button
    Friend WithEvents Timerupdater As Timer
End Class
