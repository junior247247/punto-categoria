Public Class Parse
    Public Shared Function ToDecimal(monto As Decimal) As String
        Dim value1 As Decimal = CDec(monto)
        Dim formattedValue1 As String = String.Format("{0:n}", value1)
        Dim len = formattedValue1.Substring(0, formattedValue1.Length - 3)
        Dim converSionServico1 = len.Replace(".", ",") + formattedValue1.Substring(formattedValue1.Length - 3, 3)
        Return converSionServico1
    End Function
End Class
