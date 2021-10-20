using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementData;
using System.Data;
using System.Data.SqlClient;

namespace EventBusiness
{
    public class BusinessLayerClass
    {
        eventmngmtdatalayer datalayerobj = new eventmngmtdatalayer();

        public string InsertUser(UsersTable usersdata)
        {
            string msg = datalayerobj.InsertUser(usersdata);
            return msg;
        }
        public string InsertEvents(EventsTable eventdata)
        {
            string msg = datalayerobj.InsertEvent(eventdata);
            return msg;
        }
        public string InsertFlowers(FlowerOrder flowerdata)
        {
            string msg = datalayerobj.InsertFlowers(flowerdata);
            return msg;
        }
        public string InsertFood(FoodOrder fooddata)
        {
            string msg = datalayerobj.InsertFood(fooddata);
            return msg;
        }
        public DataTable getBookingstatusBYID(int id)
        {
            return datalayerobj.getBookingstatusBYID(id);
        }
        public string ValidationUserLogin(string email, string password)
        {

            return datalayerobj.ValidationUserLogin(email, password);
        }
        public string ConfirmBooking(int user_id, int event_id)
        {
            return datalayerobj.ConfirmBooking(user_id, event_id);
        }
        public string ValidationAdminLogin(string ui_username, string ui_password)
        {

            return datalayerobj.ValidationAdminLogin(ui_username, ui_password);
        }
        public int notificationcount()
        {
            return datalayerobj.notificationcount();
        }
        public DataTable GetBookings()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from BookingStatus where status='Pending' or status='pending'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;

        }
        public DataTable GetUsers()
        {
            return datalayerobj.GetUsers();
        }
        public DataTable GetEvents()
        {
            return datalayerobj.GetEvents();
        }
        public DataTable GetEventsByID(int id)
        {
            return datalayerobj.GetEventsByID(id);
        }
        public int GetUserID(string email)
        {
            return datalayerobj.GetUserID(email);
        }
        public DataTable GetUsersByID(int id)
        {
            return datalayerobj.GetUsersByID(id);
        }
    }
}
