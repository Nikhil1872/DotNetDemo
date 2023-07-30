namespace Nikhil_Talmale_063.Models
{
    public class Creditcard
    {
        public int Cardno { get; set; }
       
        public DateTime ExpiryDate { get; set; }

        public string Bankname { get; set; }

        public int Pid { get; set; }

        public Creditcard(int cardno, DateTime expiryDate, string bankname, int pid)
        {
            Cardno = cardno;
            ExpiryDate = expiryDate;
            Bankname = bankname;
            Pid= pid;
        }

        public Creditcard()
        {
        }
    }
}
