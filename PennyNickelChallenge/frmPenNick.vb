' Program Name: Penny or Nickel Challenge
' Date: October 22, 2024
' Author: K Bola
' Purpose: This application finds the amount of monthly pay if paid penny or nickel for the first workday and the pay is doubled each subsequent workday

Public Class frmPenNick
    Private Sub btnCalcPay_Click(sender As Object, e As EventArgs) Handles btnCalcPay.Click
        Const cdblPenny As Double = 1
        Const cdblNickel As Double = 1
        Dim strDays As String
        Dim dblDays As Double
        Dim decTotalPay As Decimal
        Dim strNonNumeric As String = "Enter a number"
        Dim strNegativeValue As String = "Enter a positive number"
        strDays = txtNumberDays.Text
        If (IsNumeric(strDays)) Then
            dblDays = Convert.ToDouble(strDays)
            If (dblDays < 0) Then
                MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
                txtNumberDays.Clear()
            End If
            If (dblDays >= 10 And dblDays <= 22 And radPenny.Checked) Then
                dblDays *= cdblPenny
                decTotalPay = dblDays * 2
                lblMonthlyPay.Visible = True
                lblMonthlyPay.Text = decTotalPay.ToString("C")
            ElseIf (dblDays >= 10 And dblDays <= 22 And radNickel.Checked) Then
                dblDays *= cdblNickel
                decTotalPay = dblDays * 2
                lblMonthlyPay.Visible = True
                lblMonthlyPay.Text = decTotalPay.ToString("C")
            Else
                MsgBox("Number of Days in a Pay Period can not be less than 10" & vbCrLf & "and also check whether you have selected the Pay Amount", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
                txtNumberDays.Clear()
            End If
        Else
            MsgBox(strNonNumeric, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Non Numeric Value")
            txtNumberDays.Clear()
        End If
    End Sub

    Private Sub muClear_Click(sender As Object, e As EventArgs) Handles muClear.Click
        radPenny.Checked = False
        radNickel.Checked = False
        txtNumberDays.Clear()
        txtNumberDays.Focus()
        lblMonthlyPay.Text = ""
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
