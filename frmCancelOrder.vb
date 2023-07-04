Imports System.Data.SqlClient
Imports System.IO

Public Class frmCancelOrder
    Dim conn As New SqlConnection("Data Source=LAPTOP-4B8B2V83;Initial Catalog=coffe.accdb;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim i As Integer

    Dim btncategory As New Button

    Private Sub frmCancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderload()
    End Sub

    Sub orderload()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT sum([price]) as [price],[orderno] FROM OrderMaster GROUP BY orderno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("orderno"), dr.Item("price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT sum([price]) as [price],[orderno] FROM OrderMaster WHERE orderno LIKE '%" & txt_search.Text & "%' GROUP BY orderno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("orderno"), dr.Item("price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If MsgBox("Are You Sure Cancel this Order", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "Column2" Then
                conn.Open()
                Dim cmd As New SqlCommand("DELETE FROM OrderMaster WHERE orderno=@orderno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@orderno", DataGridView1.CurrentRow.Cells(0).Value.ToString())
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Order Cancel Successfully")
                End If
                conn.Close()
            End If
        Else
            Return
        End If
        orderload()
    End Sub
End Class
