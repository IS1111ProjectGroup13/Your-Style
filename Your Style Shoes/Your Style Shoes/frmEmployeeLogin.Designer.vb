<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeLogin
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
        Me.pnlEmployee = New System.Windows.Forms.Panel()
        Me.picEmployeeLogo = New System.Windows.Forms.PictureBox()
        Me.lblEmployeeUsername = New System.Windows.Forms.Label()
        Me.lblEmployeePassword = New System.Windows.Forms.Label()
        Me.txtEmployeeUsername = New System.Windows.Forms.TextBox()
        Me.txtEmployeePassword = New System.Windows.Forms.TextBox()
        Me.pnlBlackCustomer = New System.Windows.Forms.Panel()
        Me.pnlEmployee.SuspendLayout()
        CType(Me.picEmployeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEmployee
        '
        Me.pnlEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlEmployee.Controls.Add(Me.picEmployeeLogo)
        Me.pnlEmployee.Location = New System.Drawing.Point(0, -1)
        Me.pnlEmployee.Name = "pnlEmployee"
        Me.pnlEmployee.Size = New System.Drawing.Size(388, 113)
        Me.pnlEmployee.TabIndex = 0
        '
        'picEmployeeLogo
        '
        Me.picEmployeeLogo.Image = Global.Your_Style_Shoes.My.Resources.Resources.logo_your_style
        Me.picEmployeeLogo.Location = New System.Drawing.Point(3, 3)
        Me.picEmployeeLogo.Name = "picEmployeeLogo"
        Me.picEmployeeLogo.Size = New System.Drawing.Size(100, 96)
        Me.picEmployeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEmployeeLogo.TabIndex = 0
        Me.picEmployeeLogo.TabStop = False
        '
        'lblEmployeeUsername
        '
        Me.lblEmployeeUsername.AutoSize = True
        Me.lblEmployeeUsername.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeUsername.Location = New System.Drawing.Point(69, 206)
        Me.lblEmployeeUsername.Name = "lblEmployeeUsername"
        Me.lblEmployeeUsername.Size = New System.Drawing.Size(104, 20)
        Me.lblEmployeeUsername.TabIndex = 1
        Me.lblEmployeeUsername.Text = "Username"
        '
        'lblEmployeePassword
        '
        Me.lblEmployeePassword.AutoSize = True
        Me.lblEmployeePassword.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeePassword.Location = New System.Drawing.Point(69, 285)
        Me.lblEmployeePassword.Name = "lblEmployeePassword"
        Me.lblEmployeePassword.Size = New System.Drawing.Size(101, 20)
        Me.lblEmployeePassword.TabIndex = 2
        Me.lblEmployeePassword.Text = "Password"
        '
        'txtEmployeeUsername
        '
        Me.txtEmployeeUsername.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeUsername.Location = New System.Drawing.Point(179, 206)
        Me.txtEmployeeUsername.Name = "txtEmployeeUsername"
        Me.txtEmployeeUsername.Size = New System.Drawing.Size(127, 28)
        Me.txtEmployeeUsername.TabIndex = 3
        '
        'txtEmployeePassword
        '
        Me.txtEmployeePassword.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeePassword.Location = New System.Drawing.Point(179, 285)
        Me.txtEmployeePassword.Name = "txtEmployeePassword"
        Me.txtEmployeePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtEmployeePassword.Size = New System.Drawing.Size(127, 28)
        Me.txtEmployeePassword.TabIndex = 4
        '
        'pnlBlackCustomer
        '
        Me.pnlBlackCustomer.BackColor = System.Drawing.Color.Black
        Me.pnlBlackCustomer.Location = New System.Drawing.Point(0, 104)
        Me.pnlBlackCustomer.Name = "pnlBlackCustomer"
        Me.pnlBlackCustomer.Size = New System.Drawing.Size(388, 15)
        Me.pnlBlackCustomer.TabIndex = 5
        '
        'frmEmployeeLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 450)
        Me.Controls.Add(Me.pnlBlackCustomer)
        Me.Controls.Add(Me.txtEmployeePassword)
        Me.Controls.Add(Me.txtEmployeeUsername)
        Me.Controls.Add(Me.lblEmployeePassword)
        Me.Controls.Add(Me.lblEmployeeUsername)
        Me.Controls.Add(Me.pnlEmployee)
        Me.Name = "frmEmployeeLogin"
        Me.Text = "Employee Login"
        Me.pnlEmployee.ResumeLayout(False)
        CType(Me.picEmployeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents picEmployeeLogo As PictureBox
    Friend WithEvents lblEmployeeUsername As Label
    Friend WithEvents lblEmployeePassword As Label
    Friend WithEvents txtEmployeeUsername As TextBox
    Friend WithEvents txtEmployeePassword As TextBox
    Friend WithEvents pnlBlackCustomer As Panel
End Class
