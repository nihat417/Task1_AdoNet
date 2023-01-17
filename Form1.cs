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
            string selectString = "\r\nSELECT NAME\r\nFROM Categories";
            using SqlCommand cmd = new SqlCommand(selectString, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Authors_cmbx.Items.Add(reader[0]);
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
            string selectedString = @"
                                      Select Authors.FirstName
                                      From Books
                                      JOIN Authors ON Authors.Id=Id_Author
                                      JOIN Categories ON Id_Category=Categories.Id
                                      WHERE Categories.Name=@p1";
            using SqlCommand cmd = new SqlCommand(selectedString, conn);
            cmd.Parameters.AddWithValue("@p1",Authors_cmbx.SelectedItem.ToString());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category_cmbx.Items.Add(reader[0]);
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
        books_Listbox.Items.Clear();
        Add_Data();
    }

    private void Execute_Btn_Click(object sender, EventArgs e)
    {
        try
        {
            conn?.Open();
            string selectedString = @"SELECT Books.Name
                                      FROM Books
                                      JOIN Authors ON Authors.Id=Id_Author
                                      JOIN Categories ON Categories.Id=Books.Id_Category
                                      WHERE Categories.Name=@p1";

            using SqlCommand cmd=new SqlCommand(selectedString,conn);
            cmd.Parameters.AddWithValue("@p1",Authors_cmbx.SelectedItem.ToString());
            reader= cmd.ExecuteReader();

            while(reader.Read())
            {
                books_Listbox.Items.Add(reader[0]);
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
            string selectedString = @"INSERT INTO Authors(Id,FirstName,LastName) VALUES(@id,@p1,@p2)";
            using SqlCommand cmd=new SqlCommand(selectedString,conn);
            cmd.Parameters.AddWithValue("@p1",Insert_Nametextbox.Text);
            cmd.Parameters.AddWithValue("@p2",Insert_LastNametextbox.Text);
            cmd.Parameters.AddWithValue("@id", Insert_Idtextbox.Text);
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
        
        try
        {
            conn?.Open();
            string selectedstring = @"DELETE FROM AUTHORS WHERE [FirstName] = @p1 ";
            using SqlCommand cmd = new SqlCommand(selectedstring,conn);
            cmd.Parameters.AddWithValue("@p1", Insert_Nametextbox.Text);
            reader =cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            MessageBox.Show(ex.Message);
        }
        finally
        { 
            conn?.Close();
            reader?.Close();
            
        }
    }

    private void AllAuthorsBtn_Click(object sender, EventArgs e)
    {
        conn?.Open();
        try
        {
            string selectedstring = "SELECT Authors.FirstName,Authors.LastName\r\nFROM Authors";
            using SqlCommand cmd=new SqlCommand(selectedstring,conn);
            reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                books_Listbox.Items.Add(reader[0]);
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
    //
}