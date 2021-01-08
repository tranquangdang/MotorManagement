Public Class rpMotor
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMotor.tblMotor' table. You can move, or remove it, as needed.
        Me.tblMotorTableAdapter.Fill(Me.DSMotor.tblMotor)

        Me.rpXe.RefreshReport()
    End Sub
End Class