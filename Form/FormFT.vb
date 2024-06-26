Public Class FormFT
    Public RivaColdTable As New DataTable
    Private Sub FTDatos(sender As Object, e As EventArgs) Handles BoxModelo.SelectedIndexChanged
        Dim ArrBox(100) As String
        Dim RegPC(100), RegDC(100), RegTPC(100), RegTDC(100) As String
        Dim RegAV(100), RegBV(100), RegTAV(100), RegTBV(100) As String
        Dim CountPC As Integer = 0
        Dim CountDC As Integer = 0
        Dim CountAV As Integer = 0
        Dim CountBV As Integer = 0
        FichaTecnica.Items.Clear()
        PFList.Items.Clear()
        PFList.Columns.Clear()
        RivaColdSelectIndex = BoxModelo.SelectedIndex.ToString
        If BoxModelo.SelectedItem.ToString <> "" And BoxModeloTipo.SelectedItem.ToString <> "" Then
            For i = 0 To RivaColdTable.Columns.Count - 1
                If RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString <> "" Then
                    If RivaColdTable.Columns(i).ToString.StartsWith("PC_") Then
                        RegPC(CountPC) = RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString
                        RegTPC(CountPC) = RivaColdTable.Columns(i).ToString.Replace("PC_", "")
                        CountPC += 1
                    ElseIf RivaColdTable.Columns(i).ToString.StartsWith("DC_") Then
                        RegDC(CountDC) = RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString
                        RegTDC(CountDC) = RivaColdTable.Columns(i).ToString.Replace("DC_", "")
                        CountDC += 1
                    ElseIf RivaColdTable.Columns(i).ToString.StartsWith("AV_") Then
                        RegAV(CountAV) = RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString
                        RegTAV(CountAV) = RivaColdTable.Columns(i).ToString.Replace("AV_", "")
                        CountAV += 1
                    ElseIf RivaColdTable.Columns(i).ToString.StartsWith("BV_") Then
                        RegBV(CountBV) = RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString
                        RegTBV(CountBV) = RivaColdTable.Columns(i).ToString.Replace("BV_", "")
                        CountBV += 1
                    Else
                        ArrBox(0) = RivaColdTable.Columns(i).ToString
                        ArrBox(1) = RivaColdTable.Rows(RivaColdSelectIndex)(i).ToString
                        Dim LVFichaTecnica = New ListViewItem(ArrBox)
                        FichaTecnica.Items.Add(LVFichaTecnica)
                    End If
                End If
            Next i
            If CountAV > 1 Or CountBV > 1 Then
                PFList.Columns.Add("AV/BV", 50)
            End If
            PFList.Columns.Add("Tamb\Tc", 60)
            TablaPF(CountPC, RegTPC, RegPC, 0, RegTDC, RegDC, "")
            TablaPF(CountAV, RegTAV, RegAV, 1, RegTDC, RegDC, "AV")
            TablaPF(CountBV, RegTBV, RegBV, 1, RegTDC, RegDC, "BV")
        End If
    End Sub
    Function TablaPF(CountPC As Integer, RegTPC As String(), RegPC As String(),
                     ConstDV As Integer, RegTDC As String(), RegDC As String(), V As String)
        Dim ArrTc(100), ArrTamb(100), ArrReg(100) As String
        Dim CountTc, CountTamb As New Integer
        For i = 0 To CountPC - 1
            If ArrTc.Contains(RegTPC(i).Split("_")(1).ToString) Then
            Else
                ArrTc(CountTc) = RegTPC(i).Split("_")(1).ToString
                PFList.Columns.Add(ArrTc(CountTc), 75)
                CountTc += 1
            End If
        Next i

        For i = 0 To CountPC - 1
            If ArrTamb.Contains(RegTPC(i).Split("_")(0).ToString) Then
            Else
                ArrTamb(CountTamb) = RegTPC(i).Split("_")(0).ToString
                CountTamb += 1
            End If
        Next i
        For k = 0 To CountTamb - 1
            For j = 0 To CountTc - 1 + ConstDV
                For i = 0 To CountPC - 1
                    If RegTPC(i).Split("_")(0).ToString = ArrTamb(k) Then
                        If RegTPC(i).Split("_")(1).ToString = ArrTc(j) Then
                            ArrReg(j + ConstDV + 1) = RegPC(i)
                            For l = 0 To CountPC - 1
                                If RegTPC(i) = RegTDC(l) Then
                                    ArrReg(j + ConstDV + 1) = RegPC(i) + " (" + RegDC(l).Replace("(", "").Replace("m³)", "") & "m³)"
                                    Exit For
                                End If
                            Next l
                        End If
                    End If
                Next i
            Next j
            ArrReg(ConstDV) = ArrTamb(k)
            If ConstDV = 1 Then
                ArrReg(0) = V
            End If
            Dim LVPFList = New ListViewItem(ArrReg)
            PFList.Items.Add(LVPFList)
            ArrReg.Initialize()
        Next k
    End Function

    Private Sub GoBack(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        MainForm.ShowDialog()
    End Sub
    Private Sub SelectionTipo(sender As Object, e As EventArgs) Handles BoxModeloTipo.SelectedIndexChanged
        If BoxModeloTipo.SelectedItem.ToString = "RivaColdEq" Then
            RivaColdTable = RivaColdEq.Copy()
        ElseIf BoxModeloTipo.SelectedItem.ToString = "RivaColdEvap" Then
            RivaColdTable = RivaColdEvap.Copy()
        ElseIf BoxModeloTipo.SelectedItem.ToString = "RivaColdCond" Then
            RivaColdTable = RivaColdCond.Copy()
        ElseIf BoxModeloTipo.SelectedItem.ToString = "RivaColdCentral" Then
            RivaColdTable = RivaColdCentral.Copy()
        End If
        BoxModelo.Items.Clear()
        FichaTecnica.Items.Clear()
        PFList.Items.Clear()
        BoxGama.Items.Clear()
        BoxModelo.Text = "Seleccionar Modelo de Producto"
        BoxGama.Text = "Seleccionar Gama de Producto"
        If BoxModeloTipo.SelectedItem.ToString <> "" Then
            For i = 0 To RivaColdTable.Rows.Count - 1
                BoxModelo.Items.Add(RivaColdTable.Rows(i)("Ref").ToString)
                AddList(BoxGama, RivaColdTable, i, "Gama")
            Next i
        End If
    End Sub
    Private Sub FormFT_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If RivaColdSelectTipo <> "" Then
            BoxModeloTipo.SelectedItem = RivaColdSelectTipo
            BoxModelo.SelectedIndex = RivaColdSelectIndex
        End If
    End Sub
    Private Sub BoxGama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxGama.SelectedIndexChanged
        BoxModelo.Items.Clear()
        BoxModelo.Text = "Seleccionar Modelo de Producto"
        For i = 0 To RivaColdTable.Rows.Count - 1
            If BoxGama.SelectedItem.ToString = RivaColdTable.Rows(i)("Gama").ToString Then
                BoxModelo.Items.Add(RivaColdTable.Rows(i)("Ref").ToString)
            End If
        Next i
    End Sub
End Class