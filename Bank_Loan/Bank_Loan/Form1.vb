Public Class Form1
    Dim oneAccount As CustomerAccount
    Dim LoanDetails As String = "{0,-18}{2,-18}{3,-18}{4,-18}{5,-18}{6,-16}"

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm If you wnat to exit", "Bank Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_Acct_Number.Clear()
        txt_Cust_name.Clear()
        txt_Open_Balance.Clear()
        txt_Loan.Clear()
        txt_Withdraw.Clear()
        txt_Balance.Clear()
        chk_Loan.Checked = False
    End Sub

    Private Sub btn_Deposit_Click(sender As Object, e As EventArgs) Handles btn_Deposit.Click
        Dim amount As Decimal
        amount = txt_Withdraw.Text
        oneAccount.Deposit(amount)
        txt_Balance.Text = Format(oneAccount.CustomerBalance, "Currency")
    End Sub

    Private Sub btn_Withdraw_Click(sender As Object, e As EventArgs) Handles btn_Withdraw.Click
        Dim amount As Decimal
        amount = txt_Withdraw.Text
        oneAccount.Withdrawal(amount)
        txt_Balance.Text = Format(oneAccount.CustomerBalance, "Currency")
    End Sub

    Private Sub btn_Acct_Update_Click(sender As Object, e As EventArgs) Handles btn_Acct_Update.Click
        Dim accountNumber As String
        Dim name As String
        Dim balance As Decimal
        Dim loan As Decimal

        accountNumber = txt_Acct_Number.Text
        name = txt_Cust_name.Text
        balance = Val(txt_Balance.Text)
        oneAccount.CustomerAccountNumber = accountNumber
        oneAccount.CustomerName = name
        oneAccount.CustomerBalance = balance

        If chk_Loan.Checked = True Then
            loan = txt_Loan.Text
            oneAccount.LoanTaken = True
            oneAccount.CustomerLoan = loan
        Else
            oneAccount.LoanTaken = False
        End If
        txt_Balance.Text = Format(OneAccount.CustomerBalance, "Currency")
    End Sub

    Private Sub btn_Display_Click(sender As Object, e As EventArgs) Handles btn_Display.Click
        Dim loan As Decimal
        Dim accountNumber, customerName, openingBalance, currentBalance, loanTaken, amountOfLoan, amountDeposited As String
        If oneAccount.LoanTaken Then
            loan = oneAccount.CustomerLoan

            accountNumber = txt_Acct_Number.Text
            customerName = txt_Cust_name.Text
            openingBalance = Val(txt_Open_Balance.Text)
            currentBalance = Val(txt_Loan.Text) - Val(txt_Withdraw.Text)
            txt_Balance.Text = currentBalance
            If chk_Loan.Checked = True Then
                loanTaken = "Yes"
            Else
                loanTaken = "No"
            End If
            amountOfLoan = Format(loan, "Currency")
            amountDeposited = txt_Balance.Text
            amountDeposited = amountDeposited
            amountDeposited = Format(amountDeposited, "Currency")

            lst_Display.Items.Add(String.Format(LoanDetails, accountNumber, customerName, openingBalance, currentBalance, loanTaken, amountOfLoan, amountDeposited))
        End If
    End Sub

    Private Sub txt_Loan_TextChanged(sender As Object, e As EventArgs) Handles txt_Loan.TextChanged

    End Sub

    Private Sub txt_Loan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Loan.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_Withdraw_TextChanged(sender As Object, e As EventArgs) Handles txt_Withdraw.TextChanged

    End Sub

    Private Sub txt_Withdraw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Withdraw.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_Open_Balance_TextChanged(sender As Object, e As EventArgs) Handles txt_Open_Balance.TextChanged

    End Sub

    Private Sub txt_Open_Balance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Open_Balance.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_Display.Items.Add(String.Format(LoanDetails, "accountNumber", "CustomerName", "openingBalance", "currentBalance", "loanTaken", "amountOfLoan", "amountDeposited"))
    End Sub
End Class
