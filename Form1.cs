using System.Data.SqlClient;

namespace Task1_AdoNet;

public partial class Form1 : Form
{

    SqlConnection?conn = null;
    SqlDataReader? reader= null;

    public Form1()
    {
        InitializeComponent();

        string connectionString = "Data Source=NIKO;Initial Catalog=Library;Integrated Security=True;";
        conn=new SqlConnection(connectionString);
        Add_Data();
    }

    private void Add_Data()
    {
        try
        {
            conn?.Open();
            string selectString = "SELECT * FROM Authors";
            using SqlCommand cmd = new SqlCommand(selectString, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Authors_cmbx.Items.Add(reader[1]);
            }
        }
        catch (Exception EX)
        {
            MessageBox.Show(EX.Message);
            throw;
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    private void Authors_cmbx_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            conn?.Open();
            string selectedString = @"SELECT * FROM Categories";
            using SqlCommand cmd = new SqlCommand(selectedString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category_cmbx.Items.Add(reader[1]);
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    private void Refresh_Btn_Click(object sender, EventArgs e)
    {
        Authors_cmbx.Items.Clear();
        Add_Data();
    }

    private void Execute_Btn_Click(object sender, EventArgs e)
    {
        try
        {
            conn?.Open();
            string selectedString = @"SELECT * 
                                      FROM Books
                                      JOIN Authors ON Authors.Id=Books.Id_Author
                                      JOIN Categories ON Categories.Id=Books.Id_Category
                                      WHERE Authors.FirstName=@p1 AND Categories.[Name] = @p2";

            using SqlCommand cmd=new SqlCommand(selectedString,conn);
            cmd.Parameters.AddWithValue("@p1",Authors_cmbx.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@p2", Category_cmbx.SelectedItem.ToString());
            reader= cmd.ExecuteReader();

            while(reader.Read())
            {
                books_Listbox.Items.Add(reader[1]);
            }

        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        { 
            conn?.Close();
            reader?.Close();
        }

    }

    private void Add_Btn_Click(object sender, EventArgs e)
    {
        conn?.Open();

        try
        {
            string selectedString = @"INSERT INTO Authors(Id,FirstName,LastName) VALUES(2,@p1,@p2)";
            using SqlCommand cmd=new SqlCommand(selectedString,conn);
            cmd.Parameters.AddWithValue("@p1",Insert_Nametextbox.Text);
            cmd.Parameters.AddWithValue("@p2",Insert_LastNametextbox.Text);
            reader= cmd.ExecuteReader();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        { 
            conn?.Close();
            reader?.Close();
        }
    }

    private void Delete_Btn_Click(object sender, EventArgs e)
    {
        conn?.Open();
        try
        {
            string selectedstring = @"DELETE FROM AUTHORS WHERE [FirstName] = @p1 AND [LastName] = @p2";
            using SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("p1", Insert_Nametextbox.Text);
            cmd.Parameters.AddWithValue("p2",Insert_LastNametextbox.Text);
            reader =cmd.ExecuteReader();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        { 
            conn?.Close();
            reader?.Close();
        }
    }
}