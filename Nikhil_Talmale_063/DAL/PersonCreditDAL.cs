using MySqlConnector;
using Nikhil_Talmale_063.Models;

namespace Nikhil_Talmale_063.DAL
{
    public class PersonCreditDAL
    {

        static string constr = @"server=localhost;userid=root;password=12345;database=creditcarddb";


        public static List<Person> GetListOfPersons()
        {
            List<Person> list = new List<Person>();


            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "Select  from Person ;";
                    MySqlDataReader rd = cmd.ExecuteReader();
                    Console.WriteLine("\n\n");
                    while (rd.Read())
                    {
                        Person b = new Person()
                        {
                            Pid = rd.GetInt32(0),
                            Fname = rd.GetString(1),
                            Lname = rd.GetString(1),
                        };

                        list.Add(b);

                    }

                    con.Close();
                }
                return list;

            }
        }

        public static Person GetData(int id)
        {
            Person b = new Person();
            
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    
                    cmd.CommandText = "select p.pid, p.fname,p.lname, c.cardno,c.expirydate,c.bankname, from person p ,creditcard c where p.pid = @id;";

                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader rd = cmd.ExecuteReader();

                    Console.WriteLine("\n\n");
                    while (rd.Read())
                    {


                        b.Pid = rd.GetInt32(0);
                        b.Fname = rd.GetString(1);
                        b.Lname = rd.GetString(2);
                          
                    
                    }

                    con.Close();
                }
                return b;

            }
        }






    }
    
    








      

}
