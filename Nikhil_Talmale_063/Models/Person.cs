namespace Nikhil_Talmale_063.Models
{
    public class Person
    {
        public int Pid { get; set; } 
        public string Fname { get; set; }

        public string Lname { get; set; }


        public Creditcard c1 { get; set; }

        public Person(int pid, string fname, string lname, Creditcard c1)
        {
            Pid = pid;
            Fname = fname;
            Lname = lname;
            this.c1 = c1;
        }

        public Person()
        {
        }
    }
}
