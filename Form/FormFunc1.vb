Public Class FormFunc1
    Public EquivIndex(10000) As Integer
    Public ModeloIndex(10000) As Integer
    Public ExisteEquivalencia As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxProveedor.SelectedIndexChanged, BoxTipo.SelectedIndexChanged
        BoxTipo.Enabled = True
        BoxModelo.Text = "Seleccionar Modelo de Producto"
        BoxModelo.Items.Clear()
        ProveedorModelo.Clear()
        BoxPropiedad.Items.Clear()
        BoxPrecio.Items.Clear()
        BoxEquivalencia.Items.Clear()
        BoxGama.Text = "Seleccionar Gama de Producto"
        BoxGama.Items.Clear()
        ListTipo.Items.Clear()
        If BoxProveedor.SelectedItem.ToString = "IntarCon" Then
            If BoxTipo.SelectedIndex <= 0 Then
                ProveedorModelo = IntarConEq.Copy()
            ElseIf BoxTipo.SelectedIndex = 1 Then
                ProveedorModelo = IntarConEvap.Copy()
            Else
                ProveedorModelo = IntarConCond.Copy()
            End If
        ElseIf BoxProveedor.SelectedItem.ToString = "Zanotti" Then
            If BoxTipo.SelectedIndex <= 0 Then
                ProveedorModelo = ZanottiEq.Copy()
            ElseIf BoxTipo.SelectedIndex = 1 Then
                ProveedorModelo = ZanottiEvap.Copy()
            Else
                ProveedorModelo = ZanottiCond.Copy()
            End If
        ElseIf BoxProveedor.SelectedItem.ToString = "Kide" Then
            If BoxTipo.SelectedIndex <= 0 Then
                ProveedorModelo = KideEq.Copy()
            ElseIf BoxTipo.SelectedIndex = 1 Then
                ProveedorModelo = KideEvap.Copy()
            Else
                ProveedorModelo = KideCond.Copy()
            End If
        End If
        If BoxTipo.SelectedIndex <= 0 Then
            RivaColdModelo = RivaColdEq.Copy()
        ElseIf BoxTipo.SelectedIndex = 1 Then
            RivaColdModelo = RivaColdEvap.Copy()
        Else
            RivaColdModelo = RivaColdCond.Copy()
        End If
        For i = 0 To ProveedorModelo.Rows.Count - 1
            BoxModelo.Items.Add(ProveedorModelo(i)("Modelo").ToString)
            AddList(BoxGama, ProveedorModelo, i, "Gama")
            ModeloIndex(i) = i
        Next i
    End Sub
    Private Sub BoxModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxModelo.SelectedIndexChanged
        ExisteEquivalencia = 0
        BoxEquivalencia.Items.Clear()
        ListTipo.Items.Clear()
        For i = 0 To RivaColdModelo.Rows.Count - 1
            If ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))("Config1").ToString = RivaColdModelo.Rows(i)("Ficha producto_Tipo").ToString Then
                If ProveedorModelo.Columns.IndexOf("Config2") = -1 Then
                    Equivalencia(i, ExisteEquivalencia)
                ElseIf ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))("Config2").ToString = RivaColdModelo.Rows(i)("Ficha producto_Montaje").ToString Then
                    If ProveedorModelo.Columns.IndexOf("Config3") = -1 Then
                        Equivalencia(i, ExisteEquivalencia)
                        'If Then
                        'End If
                    End If
                End If
            End If
        Next i
        For i = 1 To 10
            If ProveedorModelo.Columns.IndexOf("Config" & i) <> -1 Then
                ListTipo.Items.Add(ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))("Config" & i).ToString)
            End If
        Next
        If ExisteEquivalencia = 0 Then
            BoxEquivalencia.Items.Add("No existe equivalencia")
        Else
            BoxEquivalencia.SelectedIndex = 0
        End If
        BoxEquivalencia_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub BoxEquivalencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxEquivalencia.SelectedIndexChanged
        BoxPropiedad.Items.Clear()
        BoxPrecio.Items.Clear()
        If ExisteEquivalencia <> 0 Then
            BotonFicha.Enabled = True
            Dim ArrBox(10) As String
            ArrBox(0) = ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))("Precio").ToString & "€"
            If ArrBox(0) = "€" Then ArrBox(0) = "No disponible"
            ArrBox(1) = RivaColdModelo.Rows(EquivIndex(BoxEquivalencia.SelectedIndex.ToString))("Precio").ToString & "€"
            If ArrBox(1) = "€" Then ArrBox(1) = "No disponible"
            Dim LVIPrecio = New ListViewItem(ArrBox)
            BoxPrecio.Items.Add(LVIPrecio)
            Dim DVelocidad(2) As String
            DVelocidad = {"PC", "AV", "BV"}
            For l = 0 To 2
                For i = 0 To ProveedorModelo.Columns.Count - 1
                    If ProveedorModelo.Columns(i).ToString.StartsWith(DVelocidad(l) & "_") And ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))(i).ToString <> "" Then
                        ArrBox(0) = ProveedorModelo.Columns(i).ToString.Replace(DVelocidad(l) & "_", "").Split("_")(0)
                        ArrBox(1) = ProveedorModelo.Columns(i).ToString.Replace(DVelocidad(l) & "_", "").Split("_")(1)
                        ArrBox(2) = ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))(i).ToString.Replace("W", "") & "W"
                        ArrBox(3) = "-"
                        ArrBox(4) = "-"
                        For j = 0 To RivaColdModelo.Columns.Count - 1
                            If RivaColdModelo.Columns(j).ToString.StartsWith(DVelocidad(l) & "_") Then
                                Dim PC1 = RivaColdModelo.Columns(j).ToString.Split("_")
                                Dim PC2 = ProveedorModelo.Columns(i).ToString.Split("_")
                                If PC1(2) = PC2(2) Then
                                    For k = 0 To 4
                                        If PC1(1).Replace("°C", "").Replace(" K", "") + k = PC2(1).Replace("°C", "").Replace(" K", "") Then
                                            ArrBox(3) = RivaColdModelo.Rows(EquivIndex(BoxEquivalencia.SelectedIndex.ToString))(j).ToString.Replace("W", "") & "W"
                                            If ArrBox(3) = "W" Then ArrBox(3) = "-"
                                            If IsNumeric(ArrBox(2).Replace("W", "")) And IsNumeric(ArrBox(3).Replace("W", "")) Then
                                                ArrBox(4) = FormatNumber((ArrBox(3).Replace("W", "") / ArrBox(2).Replace("W", "") - 1) * 100, 2) & "%"
                                            Else ArrBox(4) = "-"
                                            End If
                                            Exit For
                                        End If
                                    Next k
                                End If
                            End If
                        Next j
                        Dim LVIPropiedad = New ListViewItem(ArrBox)
                        BoxPropiedad.Items.Add(LVIPropiedad)
                    End If
                Next i
            Next l
        Else
            BotonFicha.Enabled = False
        End If
    End Sub
    Sub Equivalencia(i As Integer, n As Integer)
        Dim ArrBox2(10) As String
        Dim Registro As Integer = 0
        Dim Count As Integer = 0
        Dim CheckStock As String
        Dim DVelocidad(2) As String
        DVelocidad = {"PC", "AV", "BV"}
        For o = 0 To 2
            For k = 0 To ProveedorModelo.Columns.Count - 1
                If ProveedorModelo.Columns(k).ToString.StartsWith(DVelocidad(o) & "_") And ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))(k).ToString <> "" Then
                    For l = 0 To RivaColdModelo.Columns.Count - 1
                        If RivaColdModelo.Columns(l).ToString.StartsWith(DVelocidad(o) & "_") Then
                            Dim PC1 = RivaColdModelo.Columns(l).ToString.Split("_")
                            Dim PC2 = ProveedorModelo.Columns(k).ToString.Split("_")
                            If PC1(2) = PC2(2) Then
                                For m = 0 To 4
                                    If PC1(1).Replace("°C", "").Replace(" K", "") + m = PC2(1).Replace("°C", "").Replace(" K", "") Then
                                        ArrBox2(0) = ProveedorModelo.Rows(ModeloIndex(BoxModelo.SelectedIndex.ToString))(k).ToString
                                        ArrBox2(1) = RivaColdModelo.Rows(i)(l).ToString
                                        If IsNumeric(ArrBox2(0).Replace("W", "")) And IsNumeric(ArrBox2(1).Replace("W", "")) Then
                                            Registro += (ArrBox2(1).Replace("W", "") / ArrBox2(0).Replace("W", "") - 1) * 100
                                            Count += 1
                                        End If
                                        Exit For
                                    End If
                                Next m
                            End If
                        End If
                    Next l
                End If
            Next k
        Next o
        If RivaColdModelo.Rows(i)("Ficha producto_Stock").ToString = "Si" Then
            CheckStock = "✔ "
        Else
            CheckStock = "✘  "
        End If
        If Registro / Count < NumericUpDown2.Value And Registro / Count > NumericUpDown1.Value Then
            BoxEquivalencia.Items.Add(CheckStock & RivaColdModelo.Rows(i)("Ref").ToString & "      " & FormatNumber(Registro / Count, 2) & "%")
            EquivIndex(n) = i
            ExisteEquivalencia = n + 1
        End If
    End Sub
    Private Sub BotonFicha_Click(sender As Object, e As EventArgs) Handles BotonFicha.Click
        RivaColdSelectIndex = EquivIndex(BoxEquivalencia.SelectedIndex.ToString)
        If BoxTipo.SelectedIndex <= 0 Then
            RivaColdSelectTipo = "RivaColdEq"
        ElseIf BoxTipo.SelectedIndex = 1 Then
            RivaColdSelectTipo = "RivaColdEvap"
        Else
            RivaColdSelectTipo = "RivaColdCond"
        End If
        Me.Dispose()
        FormFT.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        MainForm.ShowDialog()
    End Sub
    Private Sub BoxGama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxGama.SelectedIndexChanged
        BoxModelo.Items.Clear()
        Dim ModeloIndexTemp As Integer = 0
        For i = 0 To ProveedorModelo.Rows.Count - 1
            If ProveedorModelo(i)("Gama").ToString = BoxGama.SelectedItem.ToString Then
                BoxModelo.Items.Add(ProveedorModelo(i)("Modelo").ToString)
                ModeloIndex(ModeloIndexTemp) = i
                ModeloIndexTemp += 1
            End If
        Next i
    End Sub
End Class