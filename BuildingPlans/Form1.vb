Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inchesToMeters As Decimal
        Dim metersToInches As Decimal
        Dim value As Decimal


        If IsNumeric(txtValue.Text) Then
            value = Convert.ToDecimal(txtValue.Text)
            If value >= 0 Then
                If toMeterConversion.Checked Then

                    inchesToMeters = value * 0.0254
                    txtOutput.Text = inchesToMeters.ToString()

                ElseIf toInchConversion.Checked Then
                    metersToInches = value * 39.3701
                    txtOutput.Text = metersToInches.ToString()
                End If
            Else
                MsgBox("You entered " & value.ToString() & ". Enter a positive number")
                txtValue.Text = ""
                txtValue.Focus()



            End If
        Else
            MsgBox("Enter a number.")
            txtValue.Text = ""
            txtValue.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Text = ""
        txtOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
