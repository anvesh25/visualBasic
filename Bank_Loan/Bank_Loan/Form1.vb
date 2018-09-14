Public Class Form1
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
End Class
