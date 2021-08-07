Public Class Form1

    Private height As Single = 0
    Private weight As Single = 0
    Private status As String
    Private bmi As Integer

    Public Function getData() As Single

        height = CInt(txtbxheight.Text)
        weight = CInt(txtbxweight.Text)
        bmi
        Return height
        Return weight
    End Function
    Public Function calculateBmi(ByRef h As Single, ByRef w As Single) As Integer

        h = height * 0.0254 ' to meters 
        w = weight * 0.45359237 ' to kgs

        bmi = CInt(w / (Math.Pow(h, 2)))
        Return bmi
    End Function

    Public Function calculateStatus(ByRef b As Integer) As String
        b = CSng(bmi)

        Select Case b
            Case < 18.5
                status = "underweight"
            Case 18.6 To 24.9
                status = "normal"
            Case 25.0 To 29.9
                status = "overweight"
            Case > 30
                status = "obese"
        End Select


        Return status
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'getData()
        btnExit.BackColor = Color.Red

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxheight.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        getData()
        calculateBmi(height, weight)
        calculateStatus(bmi)
        lstbxbmi.Items.Clear()
        lstbxstatus.Items.Clear()
        lstbxbmi.Items.Add("bmi is " & bmi)
        lstbxstatus.Items.Add("status is " & status)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        'Me.BackColor = Color.Red

        Dim dialog As DialogResult
        dialog = MsgBox("Do you want to close the app", MsgBoxStyle.YesNo)

        If dialog = vbYes Then
            Me.Close()
        ElseIf dialog = vbNo Then
            Exit Sub

        End If

    End Sub

End Class
