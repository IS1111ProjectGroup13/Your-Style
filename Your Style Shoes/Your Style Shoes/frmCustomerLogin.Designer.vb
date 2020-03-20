<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerLogin
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
        Me.pnlCustomer = New System.Windows.Forms.Panel()
        Me.lblCustomerUsername = New System.Windows.Forms.Label()
        Me.lblCustomerPassword = New System.Windows.Forms.Label()
        Me.txtCustomerUsername = New System.Windows.Forms.TextBox()
        Me.txtCustomerPassword = New System.Windows.Forms.TextBox()
        Me.picLogoCustomer = New System.Windows.Forms.PictureBox()
        Me.pnlBlackCustomer = New System.Windows.Forms.Panel()
        Me.pnlCustomer.SuspendLayout()
        CType(Me.picLogoCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustomer
        '
        Me.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlCustomer.Controls.Add(Me.picLogoCustomer)
        Me.pnlCustomer.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomer.Name = "pnlCustomer"
        Me.pnlCustomer.Size = New System.Drawing.Size(383, 104)
        Me.pnlCustomer.TabIndex = 0
        '
        'lblCustomerUsername
        '
        Me.lblCustomerUsername.AutoSize = True
        Me.lblCustomerUsername.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerUsername.Location = New System.Drawing.Point(63, 196)
        Me.lblCustomerUsername.Name = "lblCustomerUsername"
        Me.lblCustomerUsername.Size = New System.Drawing.Size(104, 20)
        Me.lblCustomerUsername.TabIndex = 1
        Me.lblCustomerUsername.Text = "Username"
        '
        'lblCustomerPassword
        '
        Me.lblCustomerPassword.AutoSize = True
        Me.lblCustomerPassword.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerPassword.Location = New System.Drawing.Point(52, 265)
        Me.lblCustomerPassword.Name = "lblCustomerPassword"
        Me.lblCustomerPassword.Size = New System.Drawing.Size(101, 20)
        Me.lblCustomerPassword.TabIndex = 2
        Me.lblCustomerPassword.Text = "Password"
        '
        'txtCustomerUsername
        '
        Me.txtCustomerUsername.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerUsername.Location = New System.Drawing.Point(173, 196)
        Me.txtCustomerUsername.Name = "txtCustomerUsername"
        Me.txtCustomerUsername.Size = New System.Drawing.Size(127, 28)
        Me.txtCustomerUsername.TabIndex = 3
        '
        'txtCustomerPassword
        '
        Me.txtCustomerPassword.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPassword.Location = New System.Drawing.Point(159, 262)
        Me.txtCustomerPassword.Name = "txtCustomerPassword"
        Me.txtCustomerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCustomerPassword.Size = New System.Drawing.Size(127, 28)
        Me.txtCustomerPassword.TabIndex = 4
        '
        'picLogoCustomer
        '
        Me.picLogoCustomer.Image = Global.Your_Style_Shoes.My.Resources.Resources.logo_your_style
        Me.picLogoCustomer.Location = New System.Drawing.Point(3, 3)
        Me.picLogoCustomer.Name = "picLogoCustomer"
        Me.picLogoCustomer.Size = New System.Drawing.Size(100, 88)
        Me.picLogoCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoCustomer.TabIndex = 0
        Me.picLogoCustomer.TabStop = False
        '
        'pnlBlackCustomer
        '
        Me.pnlBlackCustomer.BackColor = System.Drawing.Color.Black
        Me.pnlBlackCustomer.Location = New System.Drawing.Point(0, 97)
        Me.pnlBlackCustomer.Name = "pnlBlackCustomer"
        Me.pnlBlackCustomer.Size = New System.Drawing.Size(383, 18)
        Me.pnlBlackCustomer.TabIndex = 5
        '
        'frmCustomerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(383, 450)
        Me.Controls.Add(Me.pnlBlackCustomer)
        Me.Controls.Add(Me.txtCustomerPassword)
        Me.Controls.Add(Me.txtCustomerUsername)
        Me.Controls.Add(Me.lblCustomerPassword)
        Me.Controls.Add(Me.lblCustomerUsername)
        Me.Controls.Add(Me.pnlCustomer)
        Me.Name = "frmCustomerLogin"
        Me.Text = "Customer Login"
        Me.pnlCustomer.ResumeLayout(False)
        CType(Me.picLogoCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCustomer As Panel
    Friend WithEvents picLogoCustomer As PictureBox
    Friend WithEvents lblCustomerUsername As Label
    Friend WithEvents lblCustomerPassword As Label
    Friend WithEvents txtCustomerUsername As TextBox
    Friend WithEvents txtCustomerPassword As TextBox
    Friend WithEvents pnlBlackCustomer As Panel
End Class
