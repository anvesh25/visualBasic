Public Class BankAccount
    Private _accountNumber, _name As String
    Private _balance As Decimal

    Public WriteOnly Property CustomerAccountNumber() As String
        Set(ByVal value As String)
            NewMethod1(value)
        End Set
    End Property

    Private Sub NewMethod1(value As String)
        _accountNumber = value
    End Sub

    Public WriteOnly Property CustomerName() As String
        Set(ByVal value As String)
            NewMethod(value)
        End Set
    End Property

    Private Sub NewMethod(value As String)
        _name = value
    End Sub

    Public Property CustomerBalance() As Decimal
        Get
            Return _balance
        End Get
        Set(ByVal value As Decimal)

        End Set
    End Property

    Public Sub Deposit(ByVal amount As Decimal)
        _balance = _balance + amount
    End Sub

    Public Sub Withdrawal(ByVal amount As Decimal)
        _balance = _balance - amount
    End Sub
End Class
