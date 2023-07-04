Imports System.Data.SqlClient
Imports System.IO

Public Class frmManageCoffee
    Dim conn As New SqlConnection("Data Source=LAPTOP-4B8B2V83;Initial Catalog=coffe.accdb;Integrated Security=True")
    Dim dr As SqlDataReader

    Private Sub frmManageCoffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM coffeeMaster", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("coffeecode"), dr.Item("coffeename"), dr.Item("size"), dr.Item("price"), CBool(dr.Item("status")), dr.Item("img"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frmManageCoffeeEntry.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With frmManageCoffeeEntry
            .txt_coffeeCode.Text = DataGridView1.CurrentRow.Cells(0).Value
            .txt_Coffeename.Text = DataGridView1.CurrentRow.Cells(1).Value
            .Combo_size.Text = DataGridView1.CurrentRow.Cells(2).Value
            .txt_price.Text = DataGridView1.CurrentRow.Cells(3).Value
            .Check_Status.Checked = CBool(DataGridView1.CurrentRow.Cells(4).Value)



            Dim bytes As [Byte]() = DirectCast(DataGridView1.CurrentRow.Cells(5).Value, Byte())
            Dim ms As New MemoryStream(bytes)
            .Pic_Coffeeimg.Image = Image.FromStream(ms)

            .Btn_Save.Enabled = False
            .txt_coffeeCode.ReadOnly = True
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
