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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_Loan = New System.Windows.Forms.CheckBox()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.lbl_Withdraw = New System.Windows.Forms.Label()
        Me.lbl_Loan = New System.Windows.Forms.Label()
        Me.lbl_opening_Balance = New System.Windows.Forms.Label()
        Me.lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.txt_Balance = New System.Windows.Forms.TextBox()
        Me.txt_Withdraw = New System.Windows.Forms.TextBox()
        Me.txt_Loan = New System.Windows.Forms.TextBox()
        Me.txt_Open_Balance = New System.Windows.Forms.TextBox()
        Me.txt_Cust_name = New System.Windows.Forms.TextBox()
        Me.txt_Acct_Number = New System.Windows.Forms.TextBox()
        Me.lbl_Acct_Number = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lst_Display = New System.Windows.Forms.ListBox()
        Me.btn_Acct_Update = New System.Windows.Forms.Button()
        Me.btn_Withdraw = New System.Windows.Forms.Button()
        Me.btn_Deposit = New System.Windows.Forms.Button()
        Me.btn_Display = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_Loan)
        Me.GroupBox1.Controls.Add(Me.lbl_Balance)
        Me.GroupBox1.Controls.Add(Me.lbl_Withdraw)
        Me.GroupBox1.Controls.Add(Me.lbl_Loan)
        Me.GroupBox1.Controls.Add(Me.lbl_opening_Balance)
        Me.GroupBox1.Controls.Add(Me.lbl_Customer_Name)
        Me.GroupBox1.Controls.Add(Me.txt_Balance)
        Me.GroupBox1.Controls.Add(Me.txt_Withdraw)
        Me.GroupBox1.Controls.Add(Me.txt_Loan)
        Me.GroupBox1.Controls.Add(Me.txt_Open_Balance)
        Me.GroupBox1.Controls.Add(Me.txt_Cust_name)
        Me.GroupBox1.Controls.Add(Me.txt_Acct_Number)
        Me.GroupBox1.Controls.Add(Me.lbl_Acct_Number)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Cutomer"
        '
        'chk_Loan
        '
        Me.chk_Loan.AutoSize = True
        Me.chk_Loan.Location = New System.Drawing.Point(366, 21)
        Me.chk_Loan.Name = "chk_Loan"
        Me.chk_Loan.Size = New System.Drawing.Size(15, 14)
        Me.chk_Loan.TabIndex = 12
        Me.chk_Loan.UseVisualStyleBackColor = True
        '
        'lbl_Balance
        '
        Me.lbl_Balance.AutoSize = True
        Me.lbl_Balance.Location = New System.Drawing.Point(387, 107)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Balance.TabIndex = 11
        Me.lbl_Balance.Text = "Balance"
        '
        'lbl_Withdraw
        '
        Me.lbl_Withdraw.AutoSize = True
        Me.lbl_Withdraw.Location = New System.Drawing.Point(387, 63)
        Me.lbl_Withdraw.Name = "lbl_Withdraw"
        Me.lbl_Withdraw.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Withdraw.TabIndex = 10
        Me.lbl_Withdraw.Text = "Withdraw"
        '
        'lbl_Loan
        '
        Me.lbl_Loan.AutoSize = True
        Me.lbl_Loan.Location = New System.Drawing.Point(387, 20)
        Me.lbl_Loan.Name = "lbl_Loan"
        Me.lbl_Loan.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Loan.TabIndex = 9
        Me.lbl_Loan.Text = "Loan"
        '
        'lbl_opening_Balance
        '
        Me.lbl_opening_Balance.AutoSize = True
        Me.lbl_opening_Balance.Location = New System.Drawing.Point(10, 111)
        Me.lbl_opening_Balance.Name = "lbl_opening_Balance"
        Me.lbl_opening_Balance.Size = New System.Drawing.Size(89, 13)
        Me.lbl_opening_Balance.TabIndex = 8
        Me.lbl_opening_Balance.Text = "Opening Balance"
        '
        'lbl_Customer_Name
        '
        Me.lbl_Customer_Name.AutoSize = True
        Me.lbl_Customer_Name.Location = New System.Drawing.Point(10, 63)
        Me.lbl_Customer_Name.Name = "lbl_Customer_Name"
        Me.lbl_Customer_Name.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Customer_Name.TabIndex = 7
        Me.lbl_Customer_Name.Text = "Customer's Name"
        '
        'txt_Balance
        '
        Me.txt_Balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Balance.Enabled = False
        Me.txt_Balance.Location = New System.Drawing.Point(496, 104)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Size = New System.Drawing.Size(165, 20)
        Me.txt_Balance.TabIndex = 6
        '
        'txt_Withdraw
        '
        Me.txt_Withdraw.Location = New System.Drawing.Point(496, 60)
        Me.txt_Withdraw.Name = "txt_Withdraw"
        Me.txt_Withdraw.Size = New System.Drawing.Size(165, 20)
        Me.txt_Withdraw.TabIndex = 5
        '
        'txt_Loan
        '
        Me.txt_Loan.Location = New System.Drawing.Point(496, 15)
        Me.txt_Loan.Name = "txt_Loan"
        Me.txt_Loan.Size = New System.Drawing.Size(165, 20)
        Me.txt_Loan.TabIndex = 4
        '
        'txt_Open_Balance
        '
        Me.txt_Open_Balance.Location = New System.Drawing.Point(120, 104)
        Me.txt_Open_Balance.Multiline = True
        Me.txt_Open_Balance.Name = "txt_Open_Balance"
        Me.txt_Open_Balance.Size = New System.Drawing.Size(164, 29)
        Me.txt_Open_Balance.TabIndex = 3
        '
        'txt_Cust_name
        '
        Me.txt_Cust_name.Location = New System.Drawing.Point(120, 60)
        Me.txt_Cust_name.Name = "txt_Cust_name"
        Me.txt_Cust_name.Size = New System.Drawing.Size(164, 20)
        Me.txt_Cust_name.TabIndex = 2
        '
        'txt_Acct_Number
        '
        Me.txt_Acct_Number.Location = New System.Drawing.Point(120, 15)
        Me.txt_Acct_Number.Name = "txt_Acct_Number"
        Me.txt_Acct_Number.Size = New System.Drawing.Size(164, 20)
        Me.txt_Acct_Number.TabIndex = 1
        '
        'lbl_Acct_Number
        '
        Me.lbl_Acct_Number.AutoSize = True
        Me.lbl_Acct_Number.Location = New System.Drawing.Point(10, 18)
        Me.lbl_Acct_Number.Name = "lbl_Acct_Number"
        Me.lbl_Acct_Number.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Acct_Number.TabIndex = 0
        Me.lbl_Acct_Number.Text = "Account Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst_Display)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction information"
        '
        'lst_Display
        '
        Me.lst_Display.FormattingEnabled = True
        Me.lst_Display.Location = New System.Drawing.Point(8, 16)
        Me.lst_Display.Name = "lst_Display"
        Me.lst_Display.Size = New System.Drawing.Size(778, 186)
        Me.lst_Display.TabIndex = 0
        '
        'btn_Acct_Update
        '
        Me.btn_Acct_Update.Location = New System.Drawing.Point(8, 383)
        Me.btn_Acct_Update.Name = "btn_Acct_Update"
        Me.btn_Acct_Update.Size = New System.Drawing.Size(113, 37)
        Me.btn_Acct_Update.TabIndex = 2
        Me.btn_Acct_Update.Text = "Account Update"
        Me.btn_Acct_Update.UseVisualStyleBackColor = True
        '
        'btn_Withdraw
        '
        Me.btn_Withdraw.Location = New System.Drawing.Point(167, 383)
        Me.btn_Withdraw.Name = "btn_Withdraw"
        Me.btn_Withdraw.Size = New System.Drawing.Size(85, 37)
        Me.btn_Withdraw.TabIndex = 3
        Me.btn_Withdraw.Text = "&Withdraw"
        Me.btn_Withdraw.UseVisualStyleBackColor = True
        '
        'btn_Deposit
        '
        Me.btn_Deposit.Location = New System.Drawing.Point(304, 383)
        Me.btn_Deposit.Name = "btn_Deposit"
        Me.btn_Deposit.Size = New System.Drawing.Size(85, 37)
        Me.btn_Deposit.TabIndex = 4
        Me.btn_Deposit.Text = "&Deposit"
        Me.btn_Deposit.UseVisualStyleBackColor = True
        '
        'btn_Display
        '
        Me.btn_Display.Location = New System.Drawing.Point(437, 383)
        Me.btn_Display.Name = "btn_Display"
        Me.btn_Display.Size = New System.Drawing.Size(85, 37)
        Me.btn_Display.TabIndex = 5
        Me.btn_Display.Text = "D&isplay"
        Me.btn_Display.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(571, 383)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(85, 37)
        Me.btn_Reset.TabIndex = 6
        Me.btn_Reset.Text = "&Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(709, 383)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(85, 37)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "E&xit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 454)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Display)
        Me.Controls.Add(Me.btn_Deposit)
        Me.Controls.Add(Me.btn_Withdraw)
        Me.Controls.Add(Me.btn_Acct_Update)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Acct_Update As Button
    Friend WithEvents btn_Withdraw As Button
    Friend WithEvents btn_Deposit As Button
    Friend WithEvents btn_Display As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents chk_Loan As CheckBox
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents lbl_Withdraw As Label
    Friend WithEvents lbl_Loan As Label
    Friend WithEvents lbl_opening_Balance As Label
    Friend WithEvents lbl_Customer_Name As Label
    Friend WithEvents txt_Balance As TextBox
    Friend WithEvents txt_Withdraw As TextBox
    Friend WithEvents txt_Loan As TextBox
    Friend WithEvents txt_Open_Balance As TextBox
    Friend WithEvents txt_Cust_name As TextBox
    Friend WithEvents txt_Acct_Number As TextBox
    Friend WithEvents lbl_Acct_Number As Label
    Friend WithEvents lst_Display As ListBox
End Class
