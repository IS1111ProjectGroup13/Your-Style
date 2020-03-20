Public Class frmLogin
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        'If you click the Employee button you will be brought to the Employee Login'
        Me.Hide()
        frmEmployeeLogin.Visible = True And frmCustomerLogin.Visible = False
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        'If you click the Customer button you will be brought to the Customer Login'
        Me.Hide()
        frmCustomerLogin.Visible = True And frmEmployeeLogin.Visible = False
    End Sub
End Class
