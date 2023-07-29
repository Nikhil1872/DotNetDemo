using BookManagement.Models;
using MySqlConnector;

namespace BookManagement.DAL
{
    public class BookDAL
    {

        static string constr = @"server=localhost;userid=root;password=12345;database=test";



        public static List<Book> GetListOfBooks()
        {
            List<Book> list = new List<Book>();


            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "Select * from Book;";
                    MySqlDataReader rd = cmd.ExecuteReader();
                    Console.WriteLine("\n\n");
                    while (rd.Read())
                    {
                        Book b = new Book()
                        {
                            Id = rd.GetInt32(0),
                            Name = rd.GetString(1),
                            Author = rd.GetString(2),
                            Price = rd.GetFloat(3),
                            Publication = rd.GetString(4),
                            BookType = rd.GetChar(5),
                            Created = rd.GetDateTime(6),
                            Updated = rd.GetDateTime(7)
                        };
                        list.Add(b);

                    }

                    con.Close();
                }
                return list;

            }
        }
        public static Book GetBook(int id)
        {
            Book b = new Book();
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "Select * from Book where Id = @id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader rd = cmd.ExecuteReader();

                    Console.WriteLine("\n\n");
                    while (rd.Read())
                    {


                        b.Id = rd.GetInt32(0);
                        b.Name = rd.GetString(1);
                        b.Author = rd.GetString(2);
                        b.Price = rd.GetFloat(3);
                        b.Publication = rd.GetString(4);
                        b.BookType = rd.GetChar(5);
                        b.Created = rd.GetDateTime(6);
                        b.Updated = rd.GetDateTime(7);


                    }

                    con.Close();
                }
                return b;

            }
        }

        public static int InsertData(Book b)
        {
            int res = default;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Console.WriteLine("in InsertData BookDal");

                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Book values(@id,@name,@author,@price,@publication,@bktype,@created,@updated)";
                    cmd.Parameters.AddWithValue("@id", b.Id);
                    cmd.Parameters.AddWithValue("@name", b.Name);
                    cmd.Parameters.AddWithValue("@author", b.Author);
                    cmd.Parameters.AddWithValue("@price", b.Price);
                    cmd.Parameters.AddWithValue("@publication", b.Publication);
                    cmd.Parameters.AddWithValue("@bktype", b.BookType);
                    cmd.Parameters.AddWithValue("@created", b.Created);
                    cmd.Parameters.AddWithValue("@updated", b.Updated);

                    res = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return res;
            }
        }

        public static int UpdateData(Book b)
        {
            int res = default;

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand()  )
                {
                    cmd.Connection = con;



                    cmd.CommandText = "Update Book set Name= @name,Author= @author,Price=@price,Publication=@publication,BookType=@bktype,Updated=@updated where Id=@id";

                    cmd.Parameters.AddWithValue("@id", b.Id);
                    cmd.Parameters.AddWithValue("@name", b.Name);
                    cmd.Parameters.AddWithValue("@author", b.Author);
                    cmd.Parameters.AddWithValue("@price", b.Price);
                    cmd.Parameters.AddWithValue("@publication", b.Publication);
                    cmd.Parameters.AddWithValue("@bktype", b.BookType);
                    cmd.Parameters.AddWithValue("@updated", b.Updated);

                    res = cmd.ExecuteNonQuery();
                    con.Close() ;
                }
            }
            return res;

        }

        public static int DeleteData(int id)
        {
            int res = default;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "Delete from Book where Id=@id";
                    cmd.Parameters.AddWithValue("@id", id);


                    res = cmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            return res;
        }

        internal static List<Book> GetListofBooks()
        {
            throw new NotImplementedException();
        }
    }
}
