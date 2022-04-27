Public Class Form1
    Dim intCost As Integer

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        intCost = CInt(txtPrice.Text) * Int(txtNum.Text)

        If chkBirth.Checked = True And chkMem.Checked = True Then
            txtTotal.Text = intCost * 0.7
        ElseIf chkBirth.Checked = True And chkMem.Checked = False Then
            txtTotal.Text = intCost * 0.9
        ElseIf chkBirth.Checked = False And chkMem.Checked = True Then
            txtTotal.Text = intCost * 0.8
        Else
            txtTotal.Text = intCost

        End If
    End Sub
End Class
