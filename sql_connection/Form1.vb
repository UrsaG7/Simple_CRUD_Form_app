Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Common
Imports System.Drawing.Text
Imports System.Data.SqlTypes
Imports System.Linq.Expressions
Imports System.IO
Public Class Form1

    Private connectionstrings As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString

    Private Sub button_login_Click(sender As Object, e As EventArgs) Handles button_login.Click
        Dim emp_id As String = text_employeeid.Text
        Dim pass As String = text_password.Text

        If authenticate_user(emp_id, pass) Then
            update_last_login(emp_id, pass)
            MessageBox.Show("Login successful")
            panel_login.Visible = False
        Else
            MessageBox.Show("Employee id or Password not found")
        End If

    End Sub

    Private Function authenticate_user(employee_id As String, password As String) As Boolean
        Using sqlconn As New SqlConnection(connectionstrings)
            If sqlconn Is Nothing OrElse sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()

                Dim query As String = $"SELECT COUNT(*) FROM Employee WHERE [Employee Id]=@emp_id AND [Password]=@pass"
                Using sqlcmd As New SqlCommand(query, sqlconn)
                    sqlcmd.Parameters.AddWithValue("@emp_id", employee_id)
                    sqlcmd.Parameters.AddWithValue("@pass", password)
                    Dim usercount As Integer = CInt(sqlcmd.ExecuteScalar())
                    Return usercount > 0
                End Using
            Else
                MessageBox.Show("Connection already established")
            End If
        End Using
    End Function

    Private Function update_last_login(employee_id As String, password As String)
        Using sqlconn As New SqlConnection(connectionstrings)
            sqlconn.Open()
            Dim query_login As String = $"UPDATE Employee SET [Last Login]=@lastlogintime WHERE [Employee Id]=@emp_id AND [Password]=@pass"
            Dim loginTime = DateTime.Now
            Using sqlcmd_login As New SqlCommand(query_login, sqlconn)
                sqlcmd_login.Parameters.AddWithValue("@lastlogintime", loginTime)
                sqlcmd_login.Parameters.AddWithValue("@emp_id", employee_id)
                sqlcmd_login.Parameters.AddWithValue("@pass", password)

                sqlcmd_login.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Individual")
        ComboBox1.Items.Add("Business")
        ComboBox1.Items.Add("Government")

    End Sub

    Private Function combo_value(item As String)
        Dim combobox_value As New Dictionary(Of String, Integer)
        combobox_value.Add("Individual", 1)
        combobox_value.Add("Business", 2)
        combobox_value.Add("Government", 3)

        Return combobox_value(item)
    End Function

    Private Sub button_add_Click(sender As Object, e As EventArgs) Handles button_add.Click
        Using sqlconn As New SqlConnection(connectionstrings)
            Try
                sqlconn.Open()
                Dim client_name As String = text_clientname.Text
                Dim city As String = text_city.Text
                Dim client_type As String = ComboBox1.SelectedItem.ToString()
                Dim combo_intValue As Integer = combo_value(client_type)
                Dim sales_id As Integer = CInt(text_salesid.Text)

                Dim query_add As String = $"INSERT INTO client_data VALUES(@clientname, @clientcity, @clienttype, @salespersonid)"
                Using sqlcmd_add As New SqlCommand(query_add, sqlconn)
                    sqlcmd_add.Parameters.AddWithValue("@clientname", client_name)
                    sqlcmd_add.Parameters.AddWithValue("@clientcity", city)
                    sqlcmd_add.Parameters.AddWithValue("@clienttype", combo_intValue)
                    sqlcmd_add.Parameters.AddWithValue("@salespersonid", sales_id)

                    If check_duplicate(client_name, city, combo_intValue, sales_id) Then
                        Dim proceed_question As DialogResult = MessageBox.Show("There is at least an entry with the exact same value, do you want to proceed anyway?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If proceed_question = DialogResult.Yes Then
                            sqlcmd_add.ExecuteNonQuery()
                            MessageBox.Show("Entry successfully added")
                        Else
                            MessageBox.Show("No entry is added")
                        End If
                    Else
                        sqlcmd_add.ExecuteNonQuery()
                        MessageBox.Show("Entry successfully added")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Incorrect Input", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function check_duplicate(name As String, city As String, type As Integer, sales_id As Integer) As Boolean
        Using sqlconn As New SqlConnection(connectionstrings)
            sqlconn.Open()
            Dim query_checkclient As String = $"SELECT COUNT(*) FROM client_data WHERE Name=@client_name AND City=@clientcity AND Client_type=@clienttype AND [Sales Person Id]=@salespersonid"
            Using sqlcmd_check As New SqlCommand(query_checkclient, sqlconn)
                sqlcmd_check.Parameters.AddWithValue("@client_name", name)
                sqlcmd_check.Parameters.AddWithValue("@clientcity", city)
                sqlcmd_check.Parameters.AddWithValue("@clienttype", type)
                sqlcmd_check.Parameters.AddWithValue("@salespersonid", sales_id)
                Dim duplicate_count As Integer = CInt(sqlcmd_check.ExecuteScalar())
                Return duplicate_count > 0
            End Using
        End Using
    End Function

    Private Sub button_update_Click(sender As Object, e As EventArgs) Handles button_update.Click
        populate_gridview()
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Dim exit_question As DialogResult = MessageBox.Show("Quit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Using sqlconn As New SqlConnection(connectionstrings)
            If exit_question = DialogResult.Yes Then
                sqlconn.Close()
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub populate_gridview()
        Using sqlconn As New SqlConnection(connectionstrings)
            sqlconn.Open()
            Dim query_updategrid As String = $"SELECT * FROM client_data"
            Using sqlcmd_populate As New SqlCommand(query_updategrid, sqlconn)
                Dim reader As SqlDataReader = sqlcmd_populate.ExecuteReader()
                Dim dt As New DataTable
                dt.Load(reader)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        text_clientname.Text = ""
        text_city.Text = ""
        ComboBox1.SelectedIndex = -1
        text_salesid.Text = ""
        box_search.Text = ""
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim row_index As Integer = DataGridView1.SelectedRows(0).Index
                Dim selected_rows As DataGridViewRow = DataGridView1.Rows(row_index)
                Dim row_id As Integer = CInt(selected_rows.Cells("clientId").Value)

                Dim delete_question As DialogResult = MessageBox.Show("Delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If delete_question = DialogResult.Yes Then
                    delete_rows(row_id)
                    DataGridView1.Rows.RemoveAt(row_index)
                End If
            Else
                MessageBox.Show("Please select a row")
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Function delete_rows(id As Integer)
        Using sqlconn As New SqlConnection(connectionstrings)
            sqlconn.Open()
            Dim query_delete As String = $"DELETE FROM client_data WHERE clientId=@id"
            Using sqlcmd_delete As New SqlCommand(query_delete, sqlconn)
                sqlcmd_delete.Parameters.AddWithValue("@id", id)
                sqlcmd_delete.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Private Sub button_print_Click(sender As Object, e As EventArgs) Handles button_print.Click
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

        If dt IsNot Nothing Then
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
                saveFileDialog.Title = "Save CSV File"
                saveFileDialog.DefaultExt = "csv"
                saveFileDialog.AddExtension = True
                saveFileDialog.FileName = "your_file_name.csv"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim fileName As String = saveFileDialog.FileName

                    Using writer As New StreamWriter(fileName)
                        ' Write the header
                        Dim header As String = String.Join(",", dt.Columns.Cast(Of DataColumn)().Select(Function(col) col.ColumnName))
                        writer.WriteLine(header)

                        ' Write the data rows
                        For Each row As DataRow In dt.Rows
                            Dim values As String() = Array.ConvertAll(row.ItemArray, Function(item) If(item Is Nothing, "", item.ToString()))
                            writer.WriteLine(String.Join(",", values))
                        Next
                    End Using
                    MessageBox.Show("Data exported to CSV successfully.")
                Else
                    MessageBox.Show("Save operation canceled.")
                End If
            End Using
        Else
            MessageBox.Show("No data to export.")
        End If
    End Sub
End Class
