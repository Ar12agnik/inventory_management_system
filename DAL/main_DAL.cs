using System.Data;
using System.Numerics;
using inventory_management_system.models;
using Microsoft.Data.SqlClient;

namespace inventory_management_system.DAL
{
    public class main_DAL
    {
        static string connstring = "Data Source=agnik; database=Inventory_management_system;Integrated Security=True;TrustServerCertificate=True;";
        //Vendor Part starts

        public bool createnewvendor(vendor _vendor)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connstring))
            {

                SqlCommand cmd = new SqlCommand("sp_createvendor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vendor_name", _vendor.vendor_name);
                cmd.Parameters.AddWithValue("@vendor_address", _vendor.vendor_address);
                cmd.Parameters.AddWithValue("@vendor_contact", _vendor.vendor_contact);
                con.Open();
                id = cmd.ExecuteNonQuery();
                con.Close();

            }
            if (id > 0)
                return true;
            else
                return false;
        }
        public List<vendor> get_all_vendor()
        {
            List<vendor> _vendor = new List<vendor>();
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand("sp_getallVendors", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    vendor __vendor = new vendor();
                    __vendor.vendor_id = Convert.ToInt32(rdr["Vendor Id"]);
                    __vendor.vendor_name = rdr["Vendor Name"]?.ToString() ?? string.Empty;
                    __vendor.vendor_address = rdr["Vendor address"]?.ToString() ?? string.Empty;
                    __vendor.vendor_contact = rdr["Vendor Contact"]?.ToString() ?? string.Empty;
                    _vendor.Add(__vendor);
                }
            }
            return _vendor;
        }
        public List<vendor> get_vendor_by_id(int vendor_id)
        {
            List<vendor> _vendor = new List<vendor>();
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand("sp_getVendorDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    vendor __vendor = new vendor();
                    __vendor.vendor_id = Convert.ToInt32(rdr["vendor_id"]);
                    __vendor.vendor_name = rdr["Vendor Name"]?.ToString() ?? string.Empty;
                    __vendor.vendor_address = rdr["Vendor address"]?.ToString() ?? string.Empty;
                    __vendor.vendor_contact = rdr["Vendor Contact"]?.ToString() ?? string.Empty;
                    _vendor.Add(__vendor);
                }
            }
            return _vendor;
        }
        public bool updateVendor(vendor _vendor)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connstring))
            {

                SqlCommand cmd = new SqlCommand("sp_updateVendor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vendor_id", _vendor.vendor_id);
                cmd.Parameters.AddWithValue("@vendor_name", _vendor.vendor_name);
                cmd.Parameters.AddWithValue("@vendor_address", _vendor.vendor_address);
                cmd.Parameters.AddWithValue("@vendorContact", _vendor.vendor_contact);
                con.Open();
                id = cmd.ExecuteNonQuery();
                con.Close();

            }
            if (id > 0)
                return true;
            else
                return false;
        }
        public bool deletevendor(int vendor_id)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand("sp_deleteVendor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                id = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (id > 0)
                return true;
            else
                return false;
        }
        //Vendor Part Ends

    }
}
