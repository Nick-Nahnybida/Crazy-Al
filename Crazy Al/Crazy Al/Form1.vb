Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variable declarations
        Dim decSalesAmount As Decimal                   ' Monthly sales amount
        Dim decAdvancePayAmount As Decimal              ' Advance pay taken
        Dim decCommissionRate As Decimal                ' Commission rate
        Dim decCommissionAmount As Decimal              ' Commission
        Dim decNetPay As Decimal                        ' Net Pay

        Try
            ' Get the amount of sales.
            decSalesAmount = CDec(txtSalesAmount.Text)

            ' Get the amount of advance pay.
            decAdvancePayAmount = CDec(txtAdvancePayAmount.Text)

            ' Determine the commission rate.
            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.05D

                Case 10000 To 14999
                    decCommissionRate = 0.1D

                Case 15000 To 17999
                    decCommissionRate = 0.12D

                Case 18000 To 21999
                    decCommissionRate = 0.14D

                Case Is >= 22000
                    decCommissionRate = 0.15D
            End Select

            ' Calculate the commission and net pay amounts.
            decCommissionAmount = decSalesAmount * decCommissionRate
            decNetPay = decCommissionAmount - decAdvancePayAmount

            ' Display the rate, commission, and net pay.
            lblCommissionRate.Text = decCommissionRate.ToString("p")
            lblCommissionAmount.Text = decCommissionAmount.ToString("c")
            lblNetPay.Text = decNetPay.ToString("c")

        Catch
            ' Display an error message.
            lblStatus.Text = "Please enter numeric values."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdvancePayAmount.Clear()
        txtSalesAmount.Clear()
        lblCommissionAmount.Text = ("")
        lblCommissionRate.Text = ("")
        lblNetPay.Text = ("")
        lblStatus.Text = ("")
    End Sub
End Class
