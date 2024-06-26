Imports System.Data
Imports System.Data.OleDb
Module Main
    Public RivaColdSelect As New OleDbConnection
    Public Adapt As New OleDbDataAdapter
    Public OleCommand As OleDbCommand
    Sub Main()
        Try
            RivaColdSelect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\call-bc\Carpetas Publicas\TECNIC\RivaColdSelect\RivaColdSelect.accdb"
            RivaColdSelect.Open()
        Catch ex As Exception
        End Try
        RivaColdDB()
        IntarComDB()
        ZanottiDB()
        KideDB()
        MainForm.ShowDialog()
    End Sub
    Public RivaColdEq, RivaColdEvap, RivaColdCond, RivaColdCentral As New DataTable
    Public RivaColdModelo As New DataTable
    Public RivaColdSelectIndex As Integer
    Public RivaColdSelectTipo As String
    Function RivaColdDB()
        Adapt.SelectCommand = New OleDbCommand("SELECT * FROM RivaColdEq", RivaColdSelect)
        Adapt.Fill(RivaColdEq)
        Adapt.SelectCommand = New OleDbCommand("SELECT * FROM RivaColdEvap", RivaColdSelect)
        Adapt.Fill(RivaColdEvap)
        Adapt.SelectCommand = New OleDbCommand("SELECT * FROM RivaColdCond", RivaColdSelect)
        Adapt.Fill(RivaColdCond)
    End Function
    Public ProveedorModelo As New DataTable
    Public IntarConEq, IntarConEqSC, IntarConEvap, IntarConCond As New DataTable
    Public ZanottiEq, ZanottiEvap, ZanottiCond As New DataTable
    Public KideEq, KideEvap, KideCond As New DataTable
    Function IntarComDB()
        Adapt.SelectCommand = New OleDbCommand("Select * From IntarConEq", RivaColdSelect)
        Adapt.Fill(IntarConEq)
        Adapt.SelectCommand = New OleDbCommand("Select * From IntarConEvap", RivaColdSelect)
        Adapt.Fill(IntarConEvap)
        Adapt.SelectCommand = New OleDbCommand("Select * From IntarConCond", RivaColdSelect)
        Adapt.Fill(IntarConCond)
    End Function
    Function ZanottiDB()
        Adapt.SelectCommand = New OleDbCommand("Select * From ZanottiEq", RivaColdSelect)
        Adapt.Fill(ZanottiEq)
        'Adapt.SelectCommand = New OleDbCommand("Select * From ZanottiEvap", RivaColdSelect)
        'Adapt.Fill(ZanottiEvap)
        'Adapt.SelectCommand = New OleDbCommand("Select * From ZanottiCond", RivaColdSelect)
        'Adapt.Fill(ZanottiCond)
    End Function
    Function KideDB()
        Adapt.SelectCommand = New OleDbCommand("Select * From KideEq", RivaColdSelect)
        Adapt.Fill(KideEq)
        Adapt.SelectCommand = New OleDbCommand("Select * From KideEvap", RivaColdSelect)
        Adapt.Fill(KideEvap)
        Adapt.SelectCommand = New OleDbCommand("Select * From KideCond", RivaColdSelect)
        Adapt.Fill(KideCond)
    End Function
    Function AddList(Box As ComboBox, TableDatos As DataTable, i As Integer, Columna As String)
        If Box.Items.Contains(TableDatos.Rows(i)(Columna).ToString) Then
        Else
            Box.Items.Add(TableDatos.Rows(i)(Columna).ToString)
        End If
    End Function
End Module
