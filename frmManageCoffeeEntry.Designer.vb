<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageCoffeeEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageCoffeeEntry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Coffeename = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Combo_size = New System.Windows.Forms.ComboBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Pic_Coffeeimg = New System.Windows.Forms.PictureBox()
        Me.Check_Status = New System.Windows.Forms.CheckBox()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.txt_coffeeCode = New System.Windows.Forms.TextBox()
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coffee Code "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coffee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(347, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'txt_Coffeename
        '
        Me.txt_Coffeename.Location = New System.Drawing.Point(478, 123)
        Me.txt_Coffeename.Name = "txt_Coffeename"
        Me.txt_Coffeename.Size = New System.Drawing.Size(348, 23)
        Me.txt_Coffeename.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Combo_size
        '
        Me.Combo_size.FormattingEnabled = True
        Me.Combo_size.Location = New System.Drawing.Point(478, 177)
        Me.Combo_size.Name = "Combo_size"
        Me.Combo_size.Size = New System.Drawing.Size(348, 24)
        Me.Combo_size.TabIndex = 7
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(478, 230)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(348, 23)
        Me.txt_price.TabIndex = 8
        '
        'btn_Browse
        '
        Me.btn_Browse.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Browse.Location = New System.Drawing.Point(60, 333)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(254, 47)
        Me.btn_Browse.TabIndex = 9
        Me.btn_Browse.Text = "Browse"
        Me.btn_Browse.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Save.Location = New System.Drawing.Point(351, 334)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(132, 46)
        Me.Btn_Save.TabIndex = 12
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Pic_Coffeeimg
        '
        Me.Pic_Coffeeimg.Image = CType(resources.GetObject("Pic_Coffeeimg.Image"), System.Drawing.Image)
        Me.Pic_Coffeeimg.Location = New System.Drawing.Point(60, 64)
        Me.Pic_Coffeeimg.Name = "Pic_Coffeeimg"
        Me.Pic_Coffeeimg.Size = New System.Drawing.Size(254, 263)
        Me.Pic_Coffeeimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Coffeeimg.TabIndex = 13
        Me.Pic_Coffeeimg.TabStop = False
        '
        'Check_Status
        '
        Me.Check_Status.AutoSize = True
        Me.Check_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Status.Location = New System.Drawing.Point(478, 281)
        Me.Check_Status.Name = "Check_Status"
        Me.Check_Status.Size = New System.Drawing.Size(96, 21)
        Me.Check_Status.TabIndex = 14
        Me.Check_Status.Text = "Available"
        Me.Check_Status.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Edit.Location = New System.Drawing.Point(522, 333)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(132, 47)
        Me.Btn_Edit.TabIndex = 15
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Delete.Location = New System.Drawing.Point(694, 334)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(132, 46)
        Me.btn_Delete.TabIndex = 16
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'txt_coffeeCode
        '
        Me.txt_coffeeCode.Location = New System.Drawing.Point(478, 69)
        Me.txt_coffeeCode.Name = "txt_coffeeCode"
        Me.txt_coffeeCode.Size = New System.Drawing.Size(348, 23)
        Me.txt_coffeeCode.TabIndex = 17
        '
        'frmManageCoffeeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(881, 429)
        Me.Controls.Add(Me.txt_coffeeCode)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Check_Status)
        Me.Controls.Add(Me.Pic_Coffeeimg)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Combo_size)
        Me.Controls.Add(Me.txt_Coffeename)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmManageCoffeeEntry"
        Me.Text = "Form2"
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Coffeename As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Combo_size As ComboBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents btn_Browse As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Pic_Coffeeimg As PictureBox
    Friend WithEvents Check_Status As CheckBox
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents txt_coffeeCode As TextBox
End Class
