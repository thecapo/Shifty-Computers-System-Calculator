Public Class Form1

    Dim value1 As Decimal
    Dim value2 As Decimal
    Dim value3 As Decimal
    Dim value4 As Decimal
    Dim value5 As Decimal
    Dim value6 As Decimal
    Dim value7 As Decimal
    Dim value8 As Decimal
    Dim value9 As Decimal
    Dim value10 As Decimal
    Dim value11 As Decimal
    Dim value12 As Decimal
    Dim totalAmount As Decimal
    Dim expectedAmount As Decimal


    Private Sub chkbxCPU1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxCPU1.CheckedChanged
        If chkbxCPU1.Checked = True Then
            lstbxOrders.Items.Add("Intel G1840          55")
            value1 = 55
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxCPU1.Checked = False
            lstbxOrders.Items.Remove("Intel G1840          55")
            value1 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxCPU2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxCPU2.CheckedChanged
        If chkbxCPU2.Checked = True Then
            lstbxOrders.Items.Add("Intel i5-4460            249")
            value2 = 249
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxCPU2.Checked = False
            lstbxOrders.Items.Remove("Intel i5-4460            249")
            value2 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxCPU3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxCPU3.CheckedChanged
        If chkbxCPU3.Checked = True Then
            lstbxOrders.Items.Add("Intel Xeon E3-1231V3         349")
            value3 = 349
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxCPU3.Checked = False
            lstbxOrders.Items.Remove("Intel Xeon E3-1231V3         349")
            value3 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxRAM1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxRAM1.CheckedChanged
        If chkbxRAM1.Checked = True Then
            lstbxOrders.Items.Add("4G Single 1333 Patriot-S         49 ")
            value4 = 49
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxRAM1.Checked = False
            lstbxOrders.Items.Remove("4G Single 1333 Patriot-S         49 ")
            value4 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxRAM2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxRAM2.CheckedChanged
        If chkbxRAM2.Checked = True Then
            lstbxOrders.Items.Add("8G Single 1866 Kingston-Fury         92 ")
            value5 = 92
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxRAM2.Checked = False
            lstbxOrders.Items.Remove("8G Single 1866 Kingston-Fury         92 ")
            value5 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxRAM3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxRAM3.CheckedChanged
        If chkbxRAM3.Checked = True Then
            lstbxOrders.Items.Add("16G Kit 1600 (8Gx2) Corsair Vengeance-LP         196 ")
            value6 = 196
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxRAM3.Checked = False
            lstbxOrders.Items.Remove("16G Kit 1600 (8Gx2) Corsair Vengeance-LP         196 ")
            value6 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxHDD1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxHDD1.CheckedChanged
        If chkbxHDD1.Checked = True Then
            lstbxOrders.Items.Add("Seagate 3.5in SSHD 1TB           99 ")
            value7 = 99
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxHDD1.Checked = False
            lstbxOrders.Items.Remove("Seagate 3.5in SSHD 1TB           99 ")
            value7 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxHDD2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxHDD2.CheckedChanged
        If chkbxHDD2.Checked = True Then
            lstbxOrders.Items.Add("Seagate 3.5in NAS 2TB            129 ")
            value8 = 129
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxHDD2.Checked = False
            lstbxOrders.Items.Remove("Seagate 3.5in NAS 2TB            129 ")
            value8 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxHDD3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxHDD3.CheckedChanged
        If chkbxHDD3.Checked = True Then
            lstbxOrders.Items.Add("WD Red Pro SATA3 3TB         234 ")
            value9 = 234
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxHDD3.Checked = False
            lstbxOrders.Items.Remove("WD Red Pro SATA3 3TB         234 ")
            value9 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxSCREEN1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxSCREEN1.CheckedChanged
        If chkbxSCREEN1.Checked = True Then
            lstbxOrders.Items.Add("24in 2ms BenQ GL2460         179 ")
            value10 = 179
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxSCREEN1.Checked = False
            lstbxOrders.Items.Remove("24in 2ms BenQ GL2460         179 ")
            value10 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxSCREEN2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxSCREEN2.CheckedChanged
        If chkbxSCREEN2.Checked = True Then
            lstbxOrders.Items.Add("27in 4ms Benq GW2760HS               329 ")
            value11 = 329
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxSCREEN2.Checked = False
            lstbxOrders.Items.Remove("27in 4ms Benq GW2760HS               329 ")
            value11 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub chkbxSCREEN3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxSCREEN3.CheckedChanged
        If chkbxSCREEN3.Checked = True Then
            lstbxOrders.Items.Add("27in 5ms 4k-UHD Asus PB279Q(3840x2160)           999 ")
            value12 = 999
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        Else
            chkbxSCREEN3.Checked = False
            lstbxOrders.Items.Remove("27in 5ms 4k-UHD Asus PB279Q(3840x2160)           999 ")
            value12 = 0
            lblExpectPrice.Text = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10 + value11 + value12 & " "
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        lblAmount.Text = lblExpectPrice.Text
    End Sub
End Class
