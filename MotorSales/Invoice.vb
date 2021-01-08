Public Class Invoice
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInvoice.tblOrderInvoice' table. You can move, or remove it, as needed.
        Me.tblOrderInvoiceTableAdapter.Fill(Me.DSInvoice.tblOrderInvoice, Main.boundOI.Current("OrderID"))
        'TODO: This line of code loads data into the 'DSInvoice.tblInvoice' table. You can move, or remove it, as needed.
        Me.tblInvoiceTableAdapter.Fill(Me.DSInvoice.tblInvoice, Main.boundOI.Current("OrderID"))

        Me.ReportViewerInvoice.RefreshReport()
    End Sub
End Class