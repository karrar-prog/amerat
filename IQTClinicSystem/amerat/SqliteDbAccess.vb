
Imports System
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms

Public Class SqliteDbAccess
    Public Shared ConStr As SQLiteConnection = New SQLiteConnection("Data Source={Application.StartupPath}\\db\\fingerPrintDB.db;Version=3 ;UTF8Encoding=True;")

    Public Shared Function ReturnDataTable(ByVal sqlStr As String, ByVal parm As SQLiteParameter()) As DataTable
        Dim dt = New DataTable()

        Try

            If ConStr.State = ConnectionState.Closed Then
                ConStr.Open()
            End If

            Dim cmd = New SQLiteCommand With {
                .CommandText = sqlStr,
                .Connection = ConStr
            }

            If parm IsNot Nothing Then
                cmd.Parameters.AddRange(parm)
            End If

            Dim da = New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If ConStr.State = ConnectionState.Open Then
                ConStr.Close()
            End If
        End Try

        Return dt
    End Function

    Shared _dr As SQLiteDataReader

    Public Shared Function ReturnDataRow(ByVal sqlStr As String, ByVal parm As SQLiteParameter()) As SQLiteDataReader
        Try

            If ConStr.State = ConnectionState.Closed Then
                ConStr.Open()
            End If

            Dim cmd = New SQLiteCommand With {
                .CommandText = sqlStr,
                .Connection = ConStr
            }

            If parm IsNot Nothing Then
                cmd.Parameters.AddRange(parm)
            End If

            _dr = cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If ConStr.State = ConnectionState.Open Then
                ConStr.Close()
            End If
        End Try

        Return _dr
    End Function

    Public Shared Function ReturnDataSet(ByVal sqlStr As String, ByVal parm As SQLiteParameter(), ByVal TypeComm As Integer) As DataSet
        Dim ds = New DataSet()

        Try

            If ConStr.State = ConnectionState.Closed Then
                ConStr.Open()
            End If

            Dim cmd = New SQLiteCommand With {
                .CommandText = sqlStr,
                .Connection = ConStr
            }

            If parm IsNot Nothing Then
                cmd.Parameters.AddRange(parm)
            End If

            Dim da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If ConStr.State = ConnectionState.Open Then
                ConStr.Close()
            End If
        End Try

        Return ds
    End Function

    Public Shared Sub ExcuteData(ByVal sqlStr As String, ByVal parm As SQLiteParameter())
        Try

            If ConStr.State = ConnectionState.Closed Then
                ConStr.Open()
            End If

            Dim cmd = New SQLiteCommand With {
                .CommandText = sqlStr,
                .Connection = ConStr
            }

            If parm IsNot Nothing Then
                cmd.Parameters.AddRange(parm)
            End If

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If ConStr.State = ConnectionState.Open Then
                ConStr.Close()
            End If
        End Try
    End Sub

    Public Function GetLastId(ByVal tableName As String) As Integer
        Dim dt = New DataTable()
        Dim id = 0

        Try

            If ConStr.State = ConnectionState.Closed Then
                ConStr.Open()
            End If

            Dim da = New SQLiteDataAdapter("SELECT IDENT_CURRENT('" & tableName & "')", ConStr)
            da.Fill(dt)
            id = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If ConStr.State = ConnectionState.Open Then
                ConStr.Close()
            End If
        End Try

        Return id
    End Function

    Public Sub DbBackup(ByVal notes As String, ByVal dbName As String)
    End Sub

    Public Sub CheckNo(ByVal e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "8" Then
            e.Handled = True
        End If
    End Sub
End Class
