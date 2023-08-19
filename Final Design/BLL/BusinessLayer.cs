using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLayer
    {
        DataLayer dataLayer = new DataLayer();

        #region sales
        public List<Medicin> GetMedicins()
        {
            DataTable dataTable = dataLayer.GetMedicin();

            List<Medicin> medicins = new List<Medicin>();
            foreach (DataRow medicin in dataTable.Rows)
            {
                int id;
                decimal price;
                int quantity;
                Medicin med = new Medicin();
                
                bool res1 = int.TryParse(medicin["id"].ToString(), out id);
                bool res2 = decimal.TryParse(medicin["price"].ToString(), out price);
                bool res3 = int.TryParse(medicin["quantity"].ToString(), out quantity);
                med.ID = res1 ? id : 0;
                med.Price = res2 ? price : 0M;
                med.Quantity = res3 ? quantity : 0;
                med.Name = medicin["name"].ToString();
                med.Description = medicin["description"].ToString();

                medicins.Add(med);

            }
            return medicins;
        }

        public List<Medicin> Search(string Name)
        {
            DataTable dataTable = dataLayer.Search(Name);

            List<Medicin> medicins = new List<Medicin>();
            foreach (DataRow medicin in dataTable.Rows)
            {
                int id;
                decimal price;
                int quantity;
                Medicin med = new Medicin();

                bool res1 = int.TryParse(medicin["id"].ToString(), out id);
                bool res2 = decimal.TryParse(medicin["price"].ToString(), out price);
                bool res3 = int.TryParse(medicin["quantity"].ToString(), out quantity);
                med.ID = res1 ? id : 0;
                med.Price = res2 ? price : 0M;
                med.Quantity = res3 ? quantity : 0;
                med.Name = medicin["name"].ToString();
                med.Description = medicin["description"].ToString();

                medicins.Add(med);

            }
            return medicins;
        }


        public int UpdateMedicin(int id, int quantity)
        {
            int count = dataLayer.UpdateMedicin(id , quantity);
            return count;
        }

        public int UpdateRetreveMedicin(int id, int quantity)
        {
            int count = dataLayer.UpdateRetreveMedicin(id, quantity);
            return count;
        }


        public int UpdateOrderMedicin(int medicine_id, int order_id, int quantity)
        {
            int count = dataLayer.UpdateOrderMedicin(medicine_id, order_id , quantity);
            return count;
        }


        public int InsertNewOrder(decimal total_price)
        {
            int count = dataLayer.InsertNewOrder(total_price);
            return count;
        }


        public int InsertOrderMedicin(int medicine_id, int order_id, int quantity )
        {
            int count = dataLayer.InsertOrderMedicin(medicine_id, order_id , quantity );
            return count;
        }


        public List<Order> GetOrderId()
        {
            DataTable dataTable = dataLayer.GetOrderId();

            List<Order> orders = new List<Order>();
            foreach (DataRow Order in dataTable.Rows)
            {
                int id;
                Order order = new Order();
                //bool res1 = int.TryParse(Order["id"].ToString(), out id);
                order.Order_ID = (int)Order["id"];//res1 ? id : 0;

                orders.Add(order);

            }
            return orders;
        }


        public List<Sales> GetOrderById(int orderId , int medicinId)
        {
            DataTable dataTable = dataLayer.GetOrderById(orderId , medicinId);

            List<Sales> sales = new List<Sales>();
            foreach (DataRow order in dataTable.Rows)
            {
                
                Sales sal = new Sales();

                sal.Medicin_ID = (int)order["medicine_id"];
                sal.Order_ID = (int)order["order_id"];
                sal.quantity = (int)order["quantity"]; 

                sales.Add(sal);
            }
            return sales;
        }
        #endregion

        #region admin
        public List<Admin> GetAdmin()
        {
            DataTable dataTable = dataLayer.getAdmin();
            List<Admin> admins = new List<Admin>();
            foreach (DataRow admin in dataTable.Rows)
            {
                Admin c = new Admin();
                c.ID = Convert.ToInt32(admin["id"]);
                c.Username = admin["username"].ToString();
                c.Password = Convert.ToString(admin["password"]);

                admins.Add(c);
            }
            return admins;
        }
        public int UpdatAdmin(string Password, int id)
        {
            int count = dataLayer.UpdatAdmin(Password, id);
            return count;
        }
        #endregion

        #region medicin
        public List<Medicin> getMsdicin()
        {
            DataTable dataTable = dataLayer.getMsdicin();
            List<Medicin> medicins = new List<Medicin>();
            foreach (DataRow medici in dataTable.Rows)
            {

                decimal pric;
                int qunti;
                int i;

                Medicin _medicin = new Medicin();

                _medicin.ID = Convert.ToInt32(medici["id"]);
                _medicin.Name = medici["name"].ToString();
                _medicin.Description = medici["description"].ToString();
                bool res1 = int.TryParse(medici["quantity"].ToString(), out qunti);
                bool res = decimal.TryParse(medici["Price"].ToString(), out pric);
                bool res2 = int.TryParse(medici["medicine_company_id"].ToString(), out i);


                _medicin.Price = res ? pric : 0M;
                _medicin.Quantity = res1 ? qunti : 0;
                _medicin.company_Id = res2 ? i : 0;


                medicins.Add(_medicin);

            }
            return medicins;
        }
        public int Insertmesicin(string _name, string _description, decimal _price, int _quantity, int _company_Id)
        {
            int count = dataLayer.Insertmesicin(_name, _description, _price, _quantity, _company_Id);

            return count;
        }
        public int Updatemedicine(int _id, string _name, string _description, decimal _price, int _quantity, int _company_Id)
        {
            int count = dataLayer.Updatemedicine(_id, _name, _description, _price, _quantity, _company_Id);
            return count;
        }
        public int DeleteMsdicin(int _id)
        {

            int count = dataLayer.DeleteMsdicin(_id);
            return count;
        }
        #endregion

        #region company
        public List<Company_medicin> GetCompany_Medicins()
        {
            DataTable dataTable = dataLayer.GetCompanyMedicin();
            List<Company_medicin> companys = new List<Company_medicin>();
            foreach (DataRow company in dataTable.Rows)
            {
                Company_medicin c = new Company_medicin();
                c.ID = Convert.ToInt32(company["id"]);
                c.Name = company["name"].ToString();
                c.Address = company["address"].ToString();
                c.PhoneNumber =company["phone_number"].ToString();

                companys.Add(c);
            }
            return companys;
        }

        public int InsertCompanyMedicine(string name, string address, string phone_number)
        {
            int count = dataLayer.InsertCompanyMedicin(name, address, phone_number);
            return count;
        }


        public int UpdateCompanyMedicine(int id, string name, string address, string phone_number
            )
        {
            int count = dataLayer.UpdateCompanyMedicin(id, name, address, phone_number);
            return count;
        }
        public int DeleteCompanyMedicine(int id)

        {
            int count = dataLayer.DeleteCompanyMedicin(id);
            return count;
        }
        #endregion

    }
}
