using System.Data.SqlClient;

namespace ADONETEG
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Select Data");
                Console.WriteLine("3. Updata Data");
                Console.WriteLine("4. Delete Data");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertData();
                        break;
                    case "2":
                        SelectData();
                        break;
                    case "3":
                        UpdateData();
                        break;
                    case "4":
                        DeleteData();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
        }

        private static void InsertData()
        {
            Getcon();
            Console.WriteLine("Enter Cid, Cname and Fees ");
            int Cid = Convert.ToInt32(Console.ReadLine());
            string Cname = Console.ReadLine();
            float fees = float.Parse(Console.ReadLine());
            cmd = new SqlCommand("insert into courses values(@CId,@Cname,@Fees)");
            cmd.Parameters.AddWithValue("@CId", Cid);
            cmd.Parameters.AddWithValue("@Cname", Cname);
            cmd.Parameters.AddWithValue("@Fees", fees);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + " Record(s) got inserted successfully");

        }

        private static void UpdateData()
        {
            Getcon();
            Console.WriteLine("Enter Cid for updation ");
            int Cid = Convert.ToInt32(Console.ReadLine());
            string Cname = Console.ReadLine();
            float fees = float.Parse(Console.ReadLine());
            cmd = new SqlCommand("update courses set Cname=@Cname,Fees=@Fees where CId=@Cid");
            cmd.Parameters.AddWithValue("@CId", Cid);
            cmd.Parameters.AddWithValue("@Cname", Cname);
            cmd.Parameters.AddWithValue("@Fees", fees);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + " Record(s) got update successfully");

        }

        private static void DeleteData()
        {
            Getcon();
            Console.WriteLine("Enter Cid for deletion ");
            int Cid = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("delete from courses where CId=@Cid");
            cmd.Parameters.AddWithValue("@CId", Cid);

            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + " Record(s) got deleted successfully");

        }
        private static void SelectData()
        {
            Console.WriteLine("Displaying the Records");
            Getcon();
            cmd = new SqlCommand("select * from courses", con);
            //cmd.Connecton =con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.Write(dr[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Getcon()
        {
            con = new SqlConnection("Data Source=LAPTOP-O40H1NOE\\SQLEXPRESS;Initial Catalog = Wipro; Integrated Security =True;");
            con.Open();
        }
    }
}