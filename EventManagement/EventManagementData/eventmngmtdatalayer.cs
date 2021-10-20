using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementData
{
    public class eventmngmtdatalayer
    {
        EventManagementEntities eventmanagemententities = new EventManagementEntities();
        UsersTable userobj = new UsersTable();
        BookingStatu statusobj = new BookingStatu();
        public string InsertUser(UsersTable usersdata)
        {
            eventmanagemententities.UsersTables.Add(usersdata);
            eventmanagemententities.SaveChanges();
            return "User inerted";
        }
        public string InsertEvent(EventsTable eventdata)
        {
            eventmanagemententities.EventsTables.Add(eventdata);
            eventmanagemententities.SaveChanges();
            return "booking successfull";
        }
        public string InsertFlowers(FlowerOrder flowerdata)
        {
            eventmanagemententities.FlowerOrders.Add(flowerdata);
            eventmanagemententities.SaveChanges();
            return "flower order inserted";
        }
        public string InsertFood(FoodOrder fooddata)
        {
            eventmanagemententities.FoodOrders.Add(fooddata);
            eventmanagemententities.SaveChanges();
            return "food order inserted";
        }
        public DataTable getBookingstatusBYID(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select booking_id,book_date,status from EventsTable as E INNER JOIN BookingStatus as B on B.user_id = E.user_id where B.user_id =" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;



        }
        public string ValidationUserLogin(string ui_email, string ui_password)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable where email = '" + ui_email + "' and password ='" + ui_password + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            if (sdr.Read())
            {
                sqlConnection.Close();
                return "Success";
            }
            else
            {
                sqlConnection.Close();
                return "Fail";

            }


        }
        public string ConfirmBooking(int user_id, int event_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select COUNT(*) from FoodOrder where user_id=" + user_id + "and event_id=" + event_id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sqlConnection.Close();
            SqlCommand sqlCommand1 = new SqlCommand("select COUNT(*) from FlowerOrder where user_id=" + user_id + "and event_id=" + event_id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr1 = sqlCommand.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            sqlConnection.Close();
            int foodcount = Convert.ToInt32(dt.Rows[0][0]);
            int flowercount = Convert.ToInt32(dt1.Rows[0][0]);
            string qry = "";

            if (foodcount > 1 && flowercount > 1)
            {

                return "False";
            }
            else if (foodcount == 1 && flowercount == 1)
            {

                qry = "insert into BookingStatus values(" + 1 + "," + 1 + "," + user_id + ",'pending')";

            }
            else if (foodcount == 2 && flowercount == 1)
            {
                qry = "insert into BookingStatus values(" + 0 + "," + 1 + "," + user_id + ",'pending')";

            }
            else
            {
                qry = "insert into BookingStatus values(" + 1 + "," + 0 + "," + user_id + ",'pending')";

            }
            SqlCommand cmd = new SqlCommand(qry, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "True";




        }
        public string ValidationAdminLogin(string ui_username, string ui_password)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from Admin where admin_id = '" + ui_username + "' and password ='" + ui_password + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            if (sdr.Read())
            {
                sqlConnection.Close();
                return "Success";
            }
            else
            {
                sqlConnection.Close();
                return "Fail";

            }


        }
        public int notificationcount()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select COUNT(*) from BookingStatus where status= 'pending' or status='Pending'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sqlConnection.Close();

            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable GetUsers()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetEvents()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from EventsTable", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetEventsByID(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from EventsTable where user_id=" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public int GetUserID(string email)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select user_id from UsersTable where email= '" + email + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return Convert.ToInt32(dt.Rows[0][0]);

        }
        public DataTable GetUsersByID(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EventManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable where user_id=" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

    }
}
