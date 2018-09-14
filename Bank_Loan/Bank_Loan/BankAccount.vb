Public Class BankAccount
    Private AccountNumber, Name As String
    Private Balance As Decimal

    Public WriteOnly Property CustomerAccountNumber() As String
        Set(ByVal value As String)
            AccountNumber = value
        End Set
    End Property

    Public WriteOnly Property CustomerName() As String
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Public Property CustomerBalance() As Decimal
        Get
            Return Balance
        End Get
        Set(ByVal value As Decimal)

        End Set
    End Property

    Public Sub Deposit(ByVal amount As Decimal)
        Balance = Balance + amount
    End Sub

    Public Sub Withdrawal(ByVal amount As Decimal)
        Balance = Balance - amount
    End Sub
End Class
