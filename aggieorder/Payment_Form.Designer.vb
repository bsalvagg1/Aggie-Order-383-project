<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.CardNumber_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExpiryDate_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Code_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ZIPCode_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PaymentAmount_Label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GoToShipping_Button = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AddressLine_TextBox = New System.Windows.Forms.TextBox()
        Me.City_TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.State_ComboBox = New System.Windows.Forms.ComboBox()
        Me.BackToCart_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 273)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name on card"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_TextBox.Location = New System.Drawing.Point(33, 311)
        Me.Name_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.Name_TextBox.TabIndex = 1
        '
        'CardNumber_TextBox
        '
        Me.CardNumber_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNumber_TextBox.Location = New System.Drawing.Point(28, 450)
        Me.CardNumber_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CardNumber_TextBox.Name = "CardNumber_TextBox"
        Me.CardNumber_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.CardNumber_TextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 412)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card Number"
        '
        'ExpiryDate_TextBox
        '
        Me.ExpiryDate_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDate_TextBox.Location = New System.Drawing.Point(28, 584)
        Me.ExpiryDate_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ExpiryDate_TextBox.Name = "ExpiryDate_TextBox"
        Me.ExpiryDate_TextBox.Size = New System.Drawing.Size(276, 38)
        Me.ExpiryDate_TextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 547)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Expiry Date"
        '
        'Code_TextBox
        '
        Me.Code_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_TextBox.Location = New System.Drawing.Point(334, 584)
        Me.Code_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Code_TextBox.Name = "Code_TextBox"
        Me.Code_TextBox.Size = New System.Drawing.Size(276, 38)
        Me.Code_TextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 547)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CCV"
        '
        'ZIPCode_TextBox
        '
        Me.ZIPCode_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPCode_TextBox.Location = New System.Drawing.Point(708, 584)
        Me.ZIPCode_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ZIPCode_TextBox.Name = "ZIPCode_TextBox"
        Me.ZIPCode_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.ZIPCode_TextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 547)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ZIP/Postal Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Payment Amount"
        '
        'PaymentAmount_Label
        '
        Me.PaymentAmount_Label.AutoSize = True
        Me.PaymentAmount_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentAmount_Label.Location = New System.Drawing.Point(17, 167)
        Me.PaymentAmount_Label.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.PaymentAmount_Label.Name = "PaymentAmount_Label"
        Me.PaymentAmount_Label.Size = New System.Drawing.Size(117, 63)
        Me.PaymentAmount_Label.TabIndex = 12
        Me.PaymentAmount_Label.Text = "Xyz"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(426, 63)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Payment Invoice"
        '
        'GoToShipping_Button
        '
        Me.GoToShipping_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToShipping_Button.Location = New System.Drawing.Point(704, 691)
        Me.GoToShipping_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.GoToShipping_Button.Name = "GoToShipping_Button"
        Me.GoToShipping_Button.Size = New System.Drawing.Size(584, 153)
        Me.GoToShipping_Button.TabIndex = 14
        Me.GoToShipping_Button.Text = "Go to Shipping Information"
        Me.GoToShipping_Button.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(698, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Billing Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(698, 217)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 31)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address Line 1"
        '
        'AddressLine_TextBox
        '
        Me.AddressLine_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLine_TextBox.Location = New System.Drawing.Point(704, 254)
        Me.AddressLine_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.AddressLine_TextBox.Name = "AddressLine_TextBox"
        Me.AddressLine_TextBox.Size = New System.Drawing.Size(582, 38)
        Me.AddressLine_TextBox.TabIndex = 17
        '
        'City_TextBox
        '
        Me.City_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_TextBox.Location = New System.Drawing.Point(704, 365)
        Me.City_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.City_TextBox.Name = "City_TextBox"
        Me.City_TextBox.Size = New System.Drawing.Size(262, 38)
        Me.City_TextBox.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(698, 328)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 31)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "City"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1012, 328)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 31)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "State"
        '
        'State_ComboBox
        '
        Me.State_ComboBox.FormattingEnabled = True
        Me.State_ComboBox.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.State_ComboBox.Location = New System.Drawing.Point(1018, 364)
        Me.State_ComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.State_ComboBox.Name = "State_ComboBox"
        Me.State_ComboBox.Size = New System.Drawing.Size(262, 33)
        Me.State_ComboBox.TabIndex = 21
        '
        'BackToCart_Button
        '
        Me.BackToCart_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToCart_Button.Location = New System.Drawing.Point(31, 691)
        Me.BackToCart_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.BackToCart_Button.Name = "BackToCart_Button"
        Me.BackToCart_Button.Size = New System.Drawing.Size(584, 153)
        Me.BackToCart_Button.TabIndex = 22
        Me.BackToCart_Button.Text = "Back to Cart"
        Me.BackToCart_Button.UseVisualStyleBackColor = True
        '
        'Payment_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 883)
        Me.Controls.Add(Me.BackToCart_Button)
        Me.Controls.Add(Me.State_ComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.City_TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AddressLine_TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GoToShipping_Button)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PaymentAmount_Label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ZIPCode_TextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Code_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExpiryDate_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CardNumber_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Payment_Form"
        Me.Text = "Payment_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents CardNumber_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ExpiryDate_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Code_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ZIPCode_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PaymentAmount_Label As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GoToShipping_Button As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AddressLine_TextBox As TextBox
    Friend WithEvents City_TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents State_ComboBox As ComboBox
    Friend WithEvents BackToCart_Button As Button
End Class
