using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class GlobalForm : Form
    {
        ArendaObject obj = new ArendaObject();
        Tenant tenant = new Tenant();

        public void LoginTXT(string log, string role, int id)
        {
            textBoxLogin.Text = log;
            textBoxRole.Text = role;
            obj.UserId = id;
            tenant.UserId = id;
        }

        private void GlobalForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public GlobalForm()
        {
            AutorizationForm autof = new AutorizationForm();
            InitializeComponent();

            using (DataContext db = new DataContext())
            {
                comboBoxObjects.DataSource = db.ArendaObjects.ToList();
                comboBoxObjects.DisplayMember = "ObjectName";
                comboBoxObjects.ValueMember = "ArendaObjectId";

            }
        }

        private void addUnit_Click(object sender, EventArgs e)
        {
            // Сохранить новый объект аренды в DB
            obj.City = textBoxCity.Text.Trim();
            obj.Street = textBoxStreet.Text.Trim();
            obj.HouseNumber = Convert.ToInt32(textBoxHouseNum.Text.Trim());
            obj.ApartmentNumber = Convert.ToInt32(textBoxApartamentNum.Text);
            obj.HouseArea = Convert.ToDouble(textBoxArea.Text);
            obj.NumberRoom = Convert.ToInt32(textBoxRoomNum.Text);
            obj.Floor = Convert.ToInt32(textBoxFloor.Text);
            obj.Owner = textBoxOwner.Text.Trim();
            obj.ObjectName = "г." + obj.City + " ул." + obj.Street + " д." + obj.HouseNumber + " кв." + obj.ApartmentNumber;
            
            using(DataContext db = new DataContext())
            {
                db.ArendaObjects.Add(obj);
                db.SaveChanges();
                ClearTabControl(this);
                GlobalForm_Load(this, e);
            }
        }
        public static void ClearTabControl(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                {
                    if (c.Name != "gbLog_In") ClearTabControl(c);
                }
                
            }
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addTenant_Click(object sender, EventArgs e)
        {
            tenant.FirstName = tbfirstName.Text;
            tenant.LastName = tblastName.Text;
            tenant.ThirdName= tbthirdName.Text;
            tenant.ObjectArenda = tbObjectArenda.Text;
            tenant.Phone_1 = tbPhone1.Text;
            tenant.Phone_2 = tbPhone2.Text;
            tenant.Email = tbEmail.Text;
            tenant.Lease_date = DateTime.Parse(tbLeaseDate.Text);
            tenant.Rent_price = Decimal.Parse(tbRent.Text);
            tenant.Pledge = Decimal.Parse(tbPleadge.Text);
            tenant.Series_passport = Int32.Parse(tbpaspSeries.Text);
            tenant.Number_passport = Int32.Parse(tbpaspNum.Text);
            tenant.City = tbCity.Text;
            tenant.Address = tbaddress.Text;

            using (DataContext db = new DataContext())
            {
                db.Add(tenant);
                db.SaveChanges();

                ClearTabControl(this);
                GlobalForm_Load(this, e);
            }
            
        }

        private void comboBoxObjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbObjectArenda.Text = comboBoxObjects.Text;
            GlobalForm_Load(this, e);
        }
    }
}
