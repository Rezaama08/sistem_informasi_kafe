<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Btn_Pay = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_ManageCoffee = New System.Windows.Forms.Button()
        Me.Btn_NewOrder = New System.Windows.Forms.Button()
        Me.Btn_CancelOrder = New System.Windows.Forms.Button()
        Me.Btn_report = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_orderno = New System.Windows.Forms.Label()
        Me.lbl_OrderDate = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(23, 129)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(328, 22)
        Me.txt_search.TabIndex = 4
        '
        'Btn_Pay
        '
        Me.Btn_Pay.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Pay.Location = New System.Drawing.Point(588, 518)
        Me.Btn_Pay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Pay.Name = "Btn_Pay"
        Me.Btn_Pay.Size = New System.Drawing.Size(505, 38)
        Me.Btn_Pay.TabIndex = 7
        Me.Btn_Pay.Text = "Pay"
        Me.Btn_Pay.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(588, 136)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(593, 378)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Coffee Code"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(118, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "20220052"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(28, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Order No  :"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_total.Location = New System.Drawing.Point(996, 90)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(27, 29)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "0"
        '
        'btn_ManageCoffee
        '
        Me.btn_ManageCoffee.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_ManageCoffee.Location = New System.Drawing.Point(324, 1)
        Me.btn_ManageCoffee.Name = "btn_ManageCoffee"
        Me.btn_ManageCoffee.Size = New System.Drawing.Size(139, 49)
        Me.btn_ManageCoffee.TabIndex = 12
        Me.btn_ManageCoffee.Text = "Manage Coffe"
        Me.btn_ManageCoffee.UseVisualStyleBackColor = False
        '
        'Btn_NewOrder
        '
        Me.Btn_NewOrder.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_NewOrder.Location = New System.Drawing.Point(488, 1)
        Me.Btn_NewOrder.Name = "Btn_NewOrder"
        Me.Btn_NewOrder.Size = New System.Drawing.Size(139, 49)
        Me.Btn_NewOrder.TabIndex = 13
        Me.Btn_NewOrder.Text = "New Order"
        Me.Btn_NewOrder.UseVisualStyleBackColor = False
        '
        'Btn_CancelOrder
        '
        Me.Btn_CancelOrder.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_CancelOrder.Location = New System.Drawing.Point(651, 1)
        Me.Btn_CancelOrder.Name = "Btn_CancelOrder"
        Me.Btn_CancelOrder.Size = New System.Drawing.Size(139, 49)
        Me.Btn_CancelOrder.TabIndex = 14
        Me.Btn_CancelOrder.Text = "Cancel Order"
        Me.Btn_CancelOrder.UseVisualStyleBackColor = False
        '
        'Btn_report
        '
        Me.Btn_report.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_report.Location = New System.Drawing.Point(823, 1)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(139, 49)
        Me.Btn_report.TabIndex = 15
        Me.Btn_report.Text = "Report"
        Me.Btn_report.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.Red
        Me.Btn_Exit.Location = New System.Drawing.Point(984, 1)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(139, 49)
        Me.Btn_Exit.TabIndex = 16
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(22, 156)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(560, 400)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'Timer1
        '
        '
        'lbl_orderno
        '
        Me.lbl_orderno.AutoSize = True
        Me.lbl_orderno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderno.Location = New System.Drawing.Point(118, 65)
        Me.lbl_orderno.Name = "lbl_orderno"
        Me.lbl_orderno.Size = New System.Drawing.Size(53, 17)
        Me.lbl_orderno.TabIndex = 1
        Me.lbl_orderno.Text = "12312"
        '
        'lbl_OrderDate
        '
        Me.lbl_OrderDate.AutoSize = True
        Me.lbl_OrderDate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OrderDate.Location = New System.Drawing.Point(19, 102)
        Me.lbl_OrderDate.Name = "lbl_OrderDate"
        Me.lbl_OrderDate.Size = New System.Drawing.Size(99, 17)
        Me.lbl_OrderDate.TabIndex = 3
        Me.lbl_OrderDate.Text = "Order Date :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1183, 576)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_report)
        Me.Controls.Add(Me.Btn_CancelOrder)
        Me.Controls.Add(Me.Btn_NewOrder)
        Me.Controls.Add(Me.btn_ManageCoffee)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Pay)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.lbl_OrderDate)
        Me.Controls.Add(Me.lbl_orderno)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Btn_Pay As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_ManageCoffee As Button
    Friend WithEvents Btn_NewOrder As Button
    Friend WithEvents Btn_CancelOrder As Button
    Friend WithEvents Btn_report As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_orderno As Label
    Friend WithEvents lbl_OrderDate As Label
End Class
