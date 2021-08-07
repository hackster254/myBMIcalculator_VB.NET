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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxheight = New System.Windows.Forms.TextBox()
        Me.txtbxweight = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstbxstatus = New System.Windows.Forms.ListBox()
        Me.lstbxbmi = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BMI CALCULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height in inches"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Weight in Pounds"
        '
        'txtbxheight
        '
        Me.txtbxheight.Location = New System.Drawing.Point(225, 20)
        Me.txtbxheight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxheight.Name = "txtbxheight"
        Me.txtbxheight.Size = New System.Drawing.Size(132, 22)
        Me.txtbxheight.TabIndex = 3
        '
        'txtbxweight
        '
        Me.txtbxweight.Location = New System.Drawing.Point(225, 63)
        Me.txtbxweight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxweight.Name = "txtbxweight"
        Me.txtbxweight.Size = New System.Drawing.Size(132, 22)
        Me.txtbxweight.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstbxstatus)
        Me.GroupBox1.Controls.Add(Me.lstbxbmi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbxweight)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbxheight)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 117)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(421, 181)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lstbxstatus
        '
        Me.lstbxstatus.FormattingEnabled = True
        Me.lstbxstatus.ItemHeight = 16
        Me.lstbxstatus.Location = New System.Drawing.Point(225, 144)
        Me.lstbxstatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbxstatus.Name = "lstbxstatus"
        Me.lstbxstatus.Size = New System.Drawing.Size(132, 20)
        Me.lstbxstatus.TabIndex = 8
        '
        'lstbxbmi
        '
        Me.lstbxbmi.FormattingEnabled = True
        Me.lstbxbmi.ItemHeight = 16
        Me.lstbxbmi.Location = New System.Drawing.Point(225, 108)
        Me.lstbxbmi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbxbmi.Name = "lstbxbmi"
        Me.lstbxbmi.Size = New System.Drawing.Size(132, 20)
        Me.lstbxbmi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "BMI kg.m2"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(119, 305)
        Me.btncalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(159, 28)
        Me.btncalculate.TabIndex = 6
        Me.btncalculate.Text = "CALCULATE BMI"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Location = New System.Drawing.Point(400, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxheight As TextBox
    Friend WithEvents txtbxweight As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btncalculate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lstbxstatus As ListBox
    Friend WithEvents lstbxbmi As ListBox
    Friend WithEvents btnExit As Button
End Class
