Public Class CustomerAccount

    Inherits BankAccount
    Private _hasloan As Boolean
    Private _loanAmount As Decimal

    Public Property CustomerLoan() As Decimal
        Get
            Return _loanAmount
        End Get
        Set(ByVal value As Decimal)
            _loanAmount = value
        End Set
    End Property

    Public Property LoanTaken() As Boolean
        Get
            Return _hasloan
        End Get
        Set(ByVal value As Boolean)
            _hasloan = value
        End Set
    End Property
End Class
