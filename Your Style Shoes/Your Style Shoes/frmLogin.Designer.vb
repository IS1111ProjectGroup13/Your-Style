<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Your_Style_Shoes.My.Resources.Resources.logo_your_style
        Me.picLogo.Location = New System.Drawing.Point(18, 40)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(309, 378)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCustomer.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Location = New System.Drawing.Point(366, 118)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(155, 66)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "&I Am A Customer"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEmployee.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(366, 268)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(155, 61)
        Me.btnEmployee.TabIndex = 2
        Me.btnEmployee.Text = "& I Am An Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 450)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnEmployee As Button
End Class
