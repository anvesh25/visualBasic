Public Class CustmerAccount
    Inherits BankAccount
    Private Hasloan As Boolean
    Private LoanAmount As Decimal

    Public Property CustomerLoan() As Decimal
        Get
            Return LoanAmount
        End Get
        Set(ByVal value As Decimal)
            LoanAmount = value
        End Set
    End Property

    Public Property LoanTaken() As Boolean
        Get
            Return Hasloan
        End Get
        Set(ByVal value As Boolean)
            Hasloan = value
        End Set
    End Property
End Class
