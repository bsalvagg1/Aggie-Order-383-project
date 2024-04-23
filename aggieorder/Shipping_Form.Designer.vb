<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shipping_Form
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
        Me.State_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.City_TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ZIPCode_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BillingAddress_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackToPayment_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'State_ComboBox
        '
        Me.State_ComboBox.FormattingEnabled = True
        Me.State_ComboBox.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.State_ComboBox.Location = New System.Drawing.Point(340, 452)
        Me.State_ComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.State_ComboBox.Name = "State_ComboBox"
        Me.State_ComboBox.Size = New System.Drawing.Size(262, 33)
        Me.State_ComboBox.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(334, 416)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 31)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "State"
        '
        'City_TextBox
        '
        Me.City_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_TextBox.Location = New System.Drawing.Point(26, 453)
        Me.City_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.City_TextBox.Name = "City_TextBox"
        Me.City_TextBox.Size = New System.Drawing.Size(262, 38)
        Me.City_TextBox.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 416)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "City"
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_TextBox.Location = New System.Drawing.Point(26, 342)
        Me.Address_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.Address_TextBox.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 305)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 31)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Address Line 1"
        '
        'ZIPCode_TextBox
        '
        Me.ZIPCode_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPCode_TextBox.Location = New System.Drawing.Point(30, 580)
        Me.ZIPCode_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ZIPCode_TextBox.Name = "ZIPCode_TextBox"
        Me.ZIPCode_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.ZIPCode_TextBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 543)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 31)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ZIP/Postal Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(722, 63)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Enter Your Shipping Address"
        '
        'BillingAddress_CheckBox
        '
        Me.BillingAddress_CheckBox.AutoSize = True
        Me.BillingAddress_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingAddress_CheckBox.Location = New System.Drawing.Point(30, 144)
        Me.BillingAddress_CheckBox.Name = "BillingAddress_CheckBox"
        Me.BillingAddress_CheckBox.Size = New System.Drawing.Size(419, 35)
        Me.BillingAddress_CheckBox.TabIndex = 32
        Me.BillingAddress_CheckBox.Text = "Check to use Billing Address"
        Me.BillingAddress_CheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "--------------------"
        '
        'BackToPayment_Button
        '
        Me.BackToPayment_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToPayment_Button.Location = New System.Drawing.Point(26, 693)
        Me.BackToPayment_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.BackToPayment_Button.Name = "BackToPayment_Button"
        Me.BackToPayment_Button.Size = New System.Drawing.Size(308, 153)
        Me.BackToPayment_Button.TabIndex = 34
        Me.BackToPayment_Button.Text = "Back to Payment Invoice"
        Me.BackToPayment_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(364, 693)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 153)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Go to..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Shipping_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 906)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackToPayment_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BillingAddress_CheckBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.State_ComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.City_TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Address_TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ZIPCode_TextBox)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Shipping_Form"
        Me.Text = "Shipping_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents State_ComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents City_TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Address_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ZIPCode_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BillingAddress_CheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackToPayment_Button As Button
    Friend WithEvents Button1 As Button
End Class
