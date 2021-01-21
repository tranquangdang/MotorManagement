Imports System.Data.SqlClient

Public Class Main
    Dim constring As String = "Server=8265U\U8265;Database=Motor;Trusted_Connection=True;"
    Dim conn As New SqlConnection
    Dim cmd As String
    Public WithEvents boundMotor As BindingManagerBase
    Public WithEvents boundOI As BindingManagerBase
    Dim selTblMotor = "select * from tblMotor"
    Dim selTblOrderInvoice = "select * from tblOrderInvoice"

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        pnMotor.Visible = False
        pnCreateInvoice.Visible = False
        tsmiInvoice_Click(sender, e)
        conn = New SqlConnection(constring)
    End Sub

    'Sub để thực thi lệnh xem bảng Motor, đối số truyền vào là 1 lệnh SQL
    Public Sub ExcutetblMotor(cmd)
        conn = New SqlConnection(constring)
        Dim Command As New SqlCommand(cmd, conn)
        conn.Open()
        Dim DR As SqlDataReader = Command.ExecuteReader
        Dim DTMotor As New DataTable("tblMotor")
        DTMotor.Load(DR, LoadOption.OverwriteChanges)
        conn.Close()
        DataGridViewMotor.DataSource = DTMotor
        DataGridViewMotor.Columns(5).DefaultCellStyle.Format = "N0"
        boundMotor = Me.BindingContext(DTMotor)
    End Sub

    'Sub để thực thi lệnh xem bảng OrderInvoice, đối số truyền vào là 1 lệnh SQL
    Public Sub ExcutetblOrderInvoice(cmd)
        conn = New SqlConnection(constring)
        Dim Command As New SqlCommand(cmd, conn)
        conn.Open()
        Dim DR As SqlDataReader = Command.ExecuteReader
        Dim DTOrderInvoice As New DataTable("tblOrderInvoice")
        DTOrderInvoice.Load(DR, LoadOption.OverwriteChanges)
        conn.Close()
        DataGridViewOI.DataSource = DTOrderInvoice
        DataGridViewOI.Columns(6).DefaultCellStyle.Format = "N0"
        boundOI = Me.BindingContext(DTOrderInvoice)
    End Sub

    'Hiển thị giá trị hàng được chọn ra textBox
    Public Sub Selected_Row_TblMotor(ByVal sender As Object, ByVal e As System.EventArgs) Handles boundMotor.PositionChanged
        txtProductID.Text = boundMotor.Current("ProductID")
        txtModel.Text = boundMotor.Current("Model")
        txtBrand.Text = boundMotor.Current("Brand")
        cboCategory.Text = boundMotor.Current("Category")
        txtCylCap.Text = boundMotor.Current("CylinderCapacity")
        txtPrice.Text = boundMotor.Current("Price")
        txtPrice.Text = String.Format("{0:#}", Convert.ToDecimal(txtPrice.Text))
        txtQty.Text = boundMotor.Current("Quantity")
    End Sub

    'Reset textBox và DataGridViewMotor
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtProductID.Text = ""
        txtModel.Text = ""
        txtBrand.Text = ""
        cboCategory.Text = ""
        txtCylCap.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        ExcutetblMotor(selTblMotor)
    End Sub

    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    'Kiểm tra rỗng
    Public Function CheckEmpty() As Boolean
        If txtProductID.Text = "" Or txtModel.Text = "" Or lblCategory.Text = "" Or cboCategory.Text = "" Or txtCylCap.Text = "" Or txtPrice.Text = "" Or txtQty.Text = "" Then
            MessageBox.Show("Chưa nhập đầy đủ cho các trường!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

    'Thêm xe
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If CheckEmpty() = True Then
                If MessageBox.Show("Bạn có muốn thêm không!", "Thêm dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    cmd = "insert into tblMotor values('" & Trim(txtProductID.Text) & "', N'" & Trim(txtModel.Text) & "', N'" & Trim(txtBrand.Text) & "', N'" & cboCategory.Text & "', " & Trim(txtCylCap.Text) & ", " & Trim(txtPrice.Text) & ", " & Trim(txtQty.Text) & ")"
                    Dim Command As New SqlCommand(cmd, conn)
                    conn.Open()
                    Command.ExecuteNonQuery()
                    conn.Close()
                    btnReset_Click(sender, e)
                    Selected_Row_TblMotor(sender, e)
                    MessageBox.Show("Đã thêm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnReset_Click(sender, e)
        End Try
    End Sub

    'Xóa xe
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If txtProductID.Text <> "" Then
                If MessageBox.Show("Bạn có muốn xóa không!", "Xóa dữ liệu", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = vbYes Then
                    cmd = "delete from tblMotor where ProductID = '" & txtProductID.Text & "'"
                    Dim Command As New SqlCommand(cmd, conn)
                    conn.Open()
                    Command.ExecuteNonQuery()
                    conn.Close()
                    btnReset_Click(sender, e)
                    Selected_Row_TblMotor(sender, e)
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Chưa chọn trường cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnReset_Click(sender, e)
        End Try
    End Sub

    'Sửa thông tin xe
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If CheckEmpty() Then
                cmd = "update tblMotor set ProductID = '" & Trim(txtProductID.Text) & "',
                        Model = N'" & Trim(txtModel.Text) & "', Brand = N'" & Trim(txtBrand.Text) & "',
                        Category = N'" & Trim(cboCategory.Text) & "',
                        CylinderCapacity = " & Trim(txtCylCap.Text) & ",
                        Price = " & Trim(txtPrice.Text) & ",
                        Quantity = " & Trim(txtQty.Text) & " 
                        where ProductID = '" & txtProductID.Text & "'"
                Dim Command As New SqlCommand(cmd, conn)
                conn.Open()
                Command.ExecuteNonQuery()
                conn.Close()
                btnReset_Click(sender, e)
                Selected_Row_TblMotor(sender, e)
                MessageBox.Show("Đã sửa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnReset_Click(sender, e)
        End Try
    End Sub

    'Về đầu
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        boundMotor.Position = 0
    End Sub

    'Tiếp theo
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        boundMotor.Position += 1
    End Sub

    'Quay lại
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        boundMotor.Position -= 1
    End Sub

    'Cuối cùng
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        boundMotor.Position = boundMotor.Count - 1
    End Sub

    'Tìm kiếm theo ----------------Tên-------------------------
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim search As String = ""
            search = Trim(InputBox("Nhập tên xe cần tìm kiếm:", "Tìm kiếm"))
            If search <> "" Then
                cmd = "select * from tblMotor where Model like N'%" & search & "%'"
                ExcutetblMotor(cmd)
                If DataGridViewMotor.Rows.Count = 0 Then
                    MessageBox.Show("Không tìm thấy!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnReset_Click(sender, e)
                Else
                    Selected_Row_TblMotor(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnReset_Click(sender, e)
        End Try
    End Sub

    Public Function TimeSplit(value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim time As String = ""
        time &= TimeSplit(DateTime.Now.Hour)
        time &= ":" & TimeSplit(DateTime.Now.Minute)
        time &= ":" & TimeSplit(DateTime.Now.Second)
        lblTime.Text = time
        lblDate.Text = DateTime.Today
    End Sub

    Private Sub tsmiInvoice_Click(sender As Object, e As EventArgs) Handles tsmiInvoice.Click
        DataGridViewOI.ReadOnly = True
        DataGridViewOI.AllowUserToAddRows = False
        DataGridViewOI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewOI.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        pnMotor.Visible = False
        pnCreateInvoice.Visible = False
        pnInvoiceDetail.Visible = True
        lstSearchBy.Visible = False
        txtSearchBy.Enabled = False
        ExcutetblOrderInvoice(selTblOrderInvoice)
    End Sub

    Private Sub tsmiCreateInvoice_Click(sender As Object, e As EventArgs) Handles tsmiCreateInvoice.Click
        pnInvoiceDetail.Visible = False
        pnCreateInvoice.Visible = True
        nud.Maximum = 50
        nud.Minimum = 1

        txtCustName.Text = ""
        txtTelNo.Text = ""
        txtSearch.Text = "(Tìm kiếm)"
        txtIDC.Text = ""
        rtxAddress.Text = ""
        nud.Value = 1
        lstSearch.Visible = False
        lstSearch.Items.Clear()
        lblTotalMoney.Text = 0

        lvCreateInvoice.Columns.Clear()
        lvCreateInvoice.Items.Clear()
        lvCreateInvoice.Columns.Add("STT", 70, HorizontalAlignment.Center)
        lvCreateInvoice.Columns.Add("Mã hàng", 150, HorizontalAlignment.Center)
        lvCreateInvoice.Columns.Add("Mặt hàng", 250, HorizontalAlignment.Center)
        lvCreateInvoice.Columns.Add("Giá", 200, HorizontalAlignment.Center)
        lvCreateInvoice.Columns.Add("Số lượng (chiếc)", 200, HorizontalAlignment.Center)
        lvCreateInvoice.Columns.Add("Thành tiền", 200, HorizontalAlignment.Center)
        lvCreateInvoice.View = View.Details
    End Sub

    Private Sub tsmiProduct_Click(sender As Object, e As EventArgs) Handles tsmiMotor.Click
        pnCreateInvoice.Visible = False
        pnInvoiceDetail.Visible = False
        pnMotor.Visible = True
        DataGridViewMotor.ReadOnly = True
        DataGridViewMotor.AllowUserToAddRows = False
        DataGridViewMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Chỉnh độ rộng cột
        DataGridViewMotor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells 'Chỉnh độ rộng hàng
        cboCategory.Items.AddRange(New String() {"Xe số", "Xe tay ga", "Xe thể thao", "Xe phân khối lớn", "Xe điện"})
        ExcutetblMotor(selTblMotor)
        Selected_Row_TblMotor(sender, e)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> "" Then
            cmd = "select Model from tblMotor where Model like N'%" & txtSearch.Text & "%'
                    order by 'Model' asc"
            Dim Command As New SqlCommand(cmd, conn)
            conn.Open()
            Dim DR As SqlDataReader = Command.ExecuteReader
            lstSearch.Items.Clear()
            If DR.HasRows Then
                lstSearch.Visible = True
                Do While DR.Read()
                    lstSearch.Items.Add(DR.Item("Model"))
                Loop
            End If
            conn.Close()
        Else
            lstSearch.Items.Clear()
            lstSearch.Visible = False
        End If
    End Sub

    Public Function GetSubTotal() As Decimal
        Dim TotalValue As Decimal
        Dim tmp As Decimal
        For n As Integer = 0 To lvCreateInvoice.Items.Count - 1
            If Decimal.TryParse(lvCreateInvoice.Items(n).SubItems(5).Text, tmp) Then
                TotalValue += tmp
            End If
        Next
        Return TotalValue
    End Function

    Public Function CheckDuplicate() As Boolean 'Kiểm tra trùng mặt hàng
        Dim i As Integer
        For Each it In lvCreateInvoice.Items
            If it.SubItems(2).text = lstSearch.GetItemText(lstSearch.SelectedItem) Then
                i += 1
            End If
        Next

        If i = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub lstSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles lstSearch.MouseClick
        If lvCreateInvoice.Items.Count <> 0 And CheckDuplicate() = False Then
            For Each item In lvCreateInvoice.Items
                If item.SubItems(2).text = lstSearch.GetItemText(lstSearch.SelectedItem) Then
                    item.subitems(4).text += 1
                    item.subitems(5).text = item.subitems(3).text * item.subitems(4).text
                    item.subitems(5).text = String.Format("{0:#,##0}", Convert.ToDecimal(item.subitems(5).text))
                End If
            Next
            txtSearch.Text = ""
            lstSearch.Items.Clear()
            lstSearch.Visible = False
            lblTotalMoney.Text = String.Format("{0:#,##0}", Convert.ToDecimal(GetSubTotal()))
        Else
            Dim it As ListViewItem
            Dim stt As Integer
            stt = 1
            For Each row In lvCreateInvoice.Items
                stt += 1
            Next
            it = lvCreateInvoice.Items.Add(stt)
            cmd = "select * from tblMotor where Model = N'" & lstSearch.GetItemText(lstSearch.SelectedItem) & "'"
            Dim Command As New SqlCommand(cmd, conn)
            conn.Open()
            Dim DR As SqlDataReader = Command.ExecuteReader
            DR.Read()
            it.SubItems.Add(DR.Item("ProductID"))
            it.SubItems.Add(DR.Item("Model"))
            it.SubItems.Add(String.Format("{0:#,##0}", Convert.ToDecimal(DR.Item("Price"))))
            it.SubItems.Add(1)
            it.SubItems.Add(String.Format("{0:#,##0}", Convert.ToDecimal(DR.Item("Price"))))
            conn.Close()
            txtSearch.Text = ""
            lstSearch.Items.Clear()
            lstSearch.Visible = False
            lblTotalMoney.Text = String.Format("{0:#,##0}", Convert.ToDecimal(GetSubTotal()))
        End If
        txtSearch.Text = "(Tìm kiếm)"
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud.ValueChanged
        For Each item In lvCreateInvoice.SelectedItems
            item.subitems(4).text = nud.Value
            item.subitems(5).text = item.subitems(3).text * nud.Value
            item.subitems(5).text = String.Format("{0:#,##0}", Convert.ToDecimal(item.subitems(5).text))
        Next
        lblTotalMoney.Text = String.Format("{0:#,##0}", Convert.ToDecimal(GetSubTotal()))
    End Sub

    Private Sub nud_Click(sender As Object, e As EventArgs) Handles nud.Click
        If lvCreateInvoice.SelectedItems.Count = 0 Then
            nud.Value = 1
            MessageBox.Show("Vui lòng chọn xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnDel2_Click(sender As Object, e As EventArgs) Handles btnDel2.Click 'Nút xóa sản phẩm trong list view
        Dim item As ListViewItem
        Dim stt As Integer
        Dim l = (From i In lvCreateInvoice.SelectedItems).ToList
        For Each item In l
            item.Remove()
        Next
        lblTotalMoney.Text = String.Format("{0:#,##0}", Convert.ToDecimal(GetSubTotal()))
        nud.Value = 1
        For Each item In lvCreateInvoice.Items
            stt += 1
            item.SubItems(0).Text = stt
        Next
    End Sub

    Private Sub lvCreateInvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCreateInvoice.SelectedIndexChanged
        If lvCreateInvoice.SelectedItems.Count = 1 Then
            nud.Value = lvCreateInvoice.FocusedItem.SubItems(4).Text
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If String.IsNullOrEmpty(txtCustName.Text) <> True And
                String.IsNullOrEmpty(txtTelNo.Text) <> True And String.IsNullOrEmpty(txtIDC.Text) <> True And lvCreateInvoice.Items.Count <> 0 Then
                If MessageBox.Show("Bạn có tạo mới hóa đơn không?!", "Thêm dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    cmd = "select OrderID from tblOrderInvoice"
                    Dim OrderID As String = ""
                    Dim Command As New SqlCommand(cmd, conn)
                    conn.Open()
                    Dim DR As SqlDataReader = Command.ExecuteReader()
                    If DR.HasRows Then
                        Do While DR.Read = True
                            OrderID = DR.Item("OrderID")
                        Loop
                        OrderID = Convert.ToInt32(Microsoft.VisualBasic.Right(OrderID, 4)) + 1
                        OrderID = "O" & OrderID.PadLeft(4, "0")
                    Else
                        OrderID = "O0001"
                    End If
                    conn.Close()
                    cmd = "insert into tblOrderInvoice values('" & OrderID & "', getdate(),
                            N'" & txtCustName.Text & "', '" &
                            txtTelNo.Text & "', '" & txtIDC.Text & "',
                            N'" & rtxAddress.Text & "', default)"
                    Dim insert As New SqlCommand(cmd, conn)
                    conn.Open()
                    insert.ExecuteNonQuery()
                    conn.Close()
                    For Each item In lvCreateInvoice.Items
                        Dim ProductID As String = ""
                        Dim QtyOrdered As Integer
                        ProductID = item.subitems(1).text
                        QtyOrdered = item.subitems(4).text
                        cmd = "insert into tblOrderInvoiceDetail values('" & OrderID & "', '" & ProductID & "', " & QtyOrdered & ",  0)"
                        'MsgBox(cmd)
                        Dim insertDetail As New SqlCommand(cmd, conn)
                        conn.Open()
                        insertDetail.ExecuteNonQuery()
                        conn.Close()
                    Next
                    lvCreateInvoice.Items.Clear()
                    MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tsmiCreateInvoice_Click(sender, e)
                End If
            Else
                MessageBox.Show("Chưa nhập đầy đủ cho các trường!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtSearchBy_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBy.TextChanged
        If cbModel.Checked = True Then
            If txtSearchBy.Text <> "" Then
                cmd = "select Model from tblMotor where Model like N'%" & txtSearchBy.Text &
                    "%' order by 'Model' asc"
                Dim Command As New SqlCommand(cmd, conn)
                conn.Open()
                Dim DR As SqlDataReader = Command.ExecuteReader
                lstSearchBy.Items.Clear()
                If DR.HasRows Then
                    lstSearchBy.Visible = True
                    Do While DR.Read()
                        lstSearchBy.Items.Add(DR.Item("Model"))
                    Loop
                End If
                conn.Close()
            Else
                lstSearchBy.Items.Clear()
                lstSearchBy.Visible = False
            End If
        End If

        If cbOrderID.Checked = True Then
            If txtSearchBy.Text <> "" Then
                cmd = "select OrderID from tblOrderInvoice where OrderID like N'%" & txtSearchBy.Text &
                    "%' order by 'OrderID' asc"
                Dim Command As New SqlCommand(cmd, conn)
                conn.Open()
                Dim DR As SqlDataReader = Command.ExecuteReader
                lstSearchBy.Items.Clear()
                If DR.HasRows Then
                    lstSearchBy.Visible = True
                    Do While DR.Read()
                        lstSearchBy.Items.Add(DR.Item("OrderID"))
                    Loop
                End If
                conn.Close()
            Else
                lstSearchBy.Items.Clear()
                lstSearchBy.Visible = False
            End If
        End If
    End Sub

    Private Sub cbOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderDate.CheckedChanged
        If cbOrderDate.Checked = True Then
            cbCustName.Checked = False
            cbModel.Checked = False
            cbOrderID.Checked = False
            pbSearch.Visible = False
            txtSearchBy.Visible = False
            lblNum.Visible = True
            lblNumText.Visible = True
            lblNum.Text = 0
            mc.Show()
        Else
            mc.Hide()
            lblNum.Visible = False
            lblNumText.Visible = False
            pbSearch.Visible = True
            txtSearchBy.Visible = True
        End If
    End Sub

    Private Sub cbOrderID_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderID.CheckedChanged
        If cbOrderID.Checked = True Then
            cbCustName.Checked = False
            cbModel.Checked = False
            cbOrderDate.Checked = False
            txtSearchBy.Enabled = True
        Else
            txtSearchBy.Enabled = False
            txtSearchBy.Text = ""
            lstSearchBy.Visible = False
        End If
    End Sub

    Private Sub cbModel_CheckedChanged(sender As Object, e As EventArgs) Handles cbModel.CheckedChanged
        If cbModel.Checked = True Then
            cbCustName.Checked = False
            cbOrderID.Checked = False
            cbOrderDate.Checked = False
            txtSearchBy.Enabled = True
        Else
            txtSearchBy.Enabled = False
            txtSearchBy.Text = ""
            lstSearchBy.Visible = False
        End If
    End Sub

    Private Sub cbCustName_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustName.CheckedChanged
        If cbCustName.Checked = True Then
            cbModel.Checked = False
            cbOrderID.Checked = False
            cbOrderDate.Checked = False
            txtSearchBy.Enabled = True
        Else
            txtSearchBy.Text = ""
            txtSearchBy.Enabled = False
        End If
    End Sub

    Private Sub mc_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mc.DateChanged
        lblNum.Text = (mc.SelectionRange.End - mc.SelectionRange.Start).TotalDays + 1
    End Sub

    Private Sub lstSearchBy_MouseClick(sender As Object, e As MouseEventArgs) Handles lstSearchBy.MouseClick
        txtSearchBy.Text = lstSearchBy.SelectedItem
        lstSearchBy.Visible = False
    End Sub

    Private Sub txtSearchBy_Click(sender As Object, e As EventArgs) Handles txtSearchBy.Click
        txtSearchBy.Text = ""
    End Sub

    Private Sub btnSearchBy_Click(sender As Object, e As EventArgs) Handles btnSearchBy.Click
        If cbOrderDate.Checked = True Then
            Dim start As String = mc.SelectionRange.Start.Date.ToString("MM/dd/yyyy")
            Dim endd As String = mc.SelectionRange.End.Date.ToString("MM/dd/yyyy")
            If mc.SelectionRange.End.Day - mc.SelectionRange.Start.Day = 0 Then
                cmd = "select * from tblOrderInvoice where OrderDate between N'" & start &
                    "' and N'" & start & " 23:59:59.997" & "'"
                conn.Open()
                ExcutetblOrderInvoice(cmd)
                conn.Close()
            Else
                cmd = "select * from tblOrderInvoice where OrderDate between N'" & start &
                    "' and N'" & endd & " 23:59:59.997" & "'"
                conn.Open()
                ExcutetblOrderInvoice(cmd)
                conn.Close()
            End If
            If DataGridViewOI.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy đơn hàng nào trong khoảng thời gian trên!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExcutetblOrderInvoice(selTblOrderInvoice)
            End If
        End If

        If cbCustName.Checked = True Then
            cmd = "select * from tblOrderInvoice where CustName like N'%" & txtSearchBy.Text & "%'"
            conn.Open()
            ExcutetblOrderInvoice(cmd)
            conn.Close()
            If DataGridViewOI.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExcutetblOrderInvoice(selTblOrderInvoice)
            End If
        End If

        If cbModel.Checked = True Then
            Dim ProductID As String
            cmd = "select ProductID from tblMotor where Model = N'" & txtSearchBy.Text & "'"
            Dim Command As New SqlCommand(cmd, conn)
            conn.Open()
            Dim DR As SqlDataReader = Command.ExecuteReader
            If DR.HasRows Then
                DR.Read()
                ProductID = DR.Item("ProductID")
                conn.Close()
                cmd = "select tblOrderInvoice.* from tblOrderInvoice,tblOrderInvoiceDetail where
                        tblOrderInvoiceDetail.ProductID = '" & ProductID &
                        "' and tblOrderInvoice.OrderID = tblOrderInvoiceDetail.OrderID"
                conn.Open()
                ExcutetblOrderInvoice(cmd)
                conn.Close()
            Else
                conn.Close()
                MessageBox.Show("Không tìm thấy tên sản phẩm!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
            If DataGridViewOI.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy đơn hàng nào chứa sản phẩm đang tìm kiếm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExcutetblOrderInvoice(selTblOrderInvoice)
            End If
        End If

        If cbOrderID.Checked = True Then
            Dim OrderID As String
            cmd = "select OrderID from tblOrderInvoice where OrderID = N'" & txtSearchBy.Text & "'"
            Dim Command As New SqlCommand(cmd, conn)
            conn.Open()
            Dim DR As SqlDataReader = Command.ExecuteReader
            If DR.HasRows Then
                DR.Read()
                OrderID = DR.Item("OrderID")
                conn.Close()
                cmd = "select * from tblOrderInvoice where OrderID = N'" & txtSearchBy.Text & "'"
                conn.Open()
                ExcutetblOrderInvoice(cmd)
                conn.Close()
            Else
                conn.Close()
                MessageBox.Show("Không tìm thấy đơn hàng nào!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                ExcutetblOrderInvoice(selTblOrderInvoice)
            End If
            If DataGridViewOI.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy đơn hàng nào!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                ExcutetblOrderInvoice(selTblOrderInvoice)
            End If
        End If
        txtSearchBy.Text = ""
        lstSearchBy.Items.Clear()
        lstSearchBy.Visible = False
    End Sub

    Private Sub btnDelManage_Click(sender As Object, e As EventArgs) Handles btnDelManage.Click
        If MessageBox.Show("Bạn có chắc chắn muốn xóa?!", "Thêm dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            cmd = "delete from tblOrderInvoiceDetail where OrderID = '" & boundOI.Current("OrderID") & "'"
            Dim delOID As New SqlCommand(cmd, conn)
            conn.Open()
            delOID.ExecuteNonQuery()
            conn.Close()
            cmd = "delete from tblOrderInvoice where OrderID = '" & boundOI.Current("OrderID") & "'"
            Dim delOI As New SqlCommand(cmd, conn)
            conn.Open()
            delOI.ExecuteNonQuery()
            conn.Close()
            ExcutetblOrderInvoice(selTblOrderInvoice)
        End If
    End Sub

    Private Sub btnRs_Click(sender As Object, e As EventArgs) Handles btnRs.Click
        ExcutetblOrderInvoice(selTblOrderInvoice)
        cbCustName.Checked = False
        cbModel.Checked = False
        cbOrderID.Checked = False
        cbOrderDate.Checked = False
        txtSearchBy.Text = ""
        pbSearch.Visible = True
        txtSearchBy.Visible = True
        lblNum.Visible = False
        lblNumText.Visible = False
    End Sub

    Private Sub XMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToolStripMenuItem.Click
        Dim db As New MotorDataContext
        Dim export As New XDocument(
        New XElement(
            "Motors",
                New XComment("Danh sách"),
                From motor In db.tblMotors Select motor
                Select New XElement(
                    "Motor",
                        New XElement("Brand", New XText(motor.Brand)),
                        New XElement("Model", New XText(motor.Model)),
                        New XElement("Category", New XText(motor.Category)),
                        New XElement("CylinderCapacity", New XText(String.Format("{0:#,##0.00}", Convert.ToDecimal(motor.CylinderCapacity)))),
                        New XElement("Price", New XText(String.Format("{0:#,##0}", Convert.ToDecimal(motor.Price)))),
                        New XElement("Quantity", New XText(String.Format("{0:#,##0}", Convert.ToDecimal(motor.Quantity))))
                    )
                )
            )
        export.Save("D:\\Motor.xml")
    End Sub

    Private Sub btnOItoXML_Click(sender As Object, e As EventArgs) Handles btnOItoXML.Click
        Dim db As New MotorDataContext
        Dim export As New XDocument(
        New XElement(
            "OrderInvoices",
                New XComment("Hóa đơn"),
                From invoice In db.tblOrderInvoices Select invoice Where invoice.TotalMoney <> vbNull
                Select New XElement(
                    "Invoice",
                        New XElement("OrderID", New XText(invoice.OrderID)),
                        New XElement("OrderDate", New XText(String.Format("{0:g}", Convert.ToDateTime(invoice.OrderDate)))),
                        New XElement("CustName", New XText(invoice.CustName)),
                        New XElement("TelNo", New XText(invoice.TelNo)),
                        New XElement("IDC", New XText(invoice.IDC)),
                        New XElement("Address", New XText(invoice.Address)),
                        New XElement(
                            "OrderDetails",
                                New XComment("Chi tiết"),
                                From details In db.tblOrderInvoiceDetails Select details
                                Select New XElement(
                                    "Detail",
                                        New XElement("ProductID", New XText(details.ProductID)),
                                        New XElement("QtyOrderd", New XText(details.QtyOrdered)),
                                        New XElement("Amount", New XText(String.Format("{0:#,##0}", Convert.ToDecimal(details.Amount))))
                                )
                        ),
                        New XElement("TotalMoney", New XText(String.Format("{0:#,##0}", Convert.ToDecimal(invoice.TotalMoney))))
                    )
                )
        )
        export.Save("D:\\Invoice.xml")
    End Sub
End Class