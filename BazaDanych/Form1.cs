using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getItemsFromDB();
        }

        List<Owner> ownerList = new List<Owner>();
        List<Car> carList = new List<Car>();
        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=samochody";

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            string query = "INSERT INTO samochod VALUES(NULL,'"+brandTB.Text+ "','"+modelTB.Text+ "','"+colorTB.Text+"')";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        private void AddOwnerBtn_Click(object sender, EventArgs e)
        {
            int index = carCB.SelectedIndex;
            int id = carList[index].id_samochod;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            string query = "INSERT INTO wlasciciel VALUES(NULL,'" + nameTB.Text + "','"+lastNameTB.Text+"','"+id+"')";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        private void EditCar_Click(object sender, EventArgs e)
        {
            int index = carListview.Items.IndexOf(carListview.SelectedItems[0]);
            int id = carList[index].id_samochod;
            string query = "UPDATE samochod SET Marka=@marka, Model=@model, Kolor=@kolor where Id_samochod = @id";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(query,databaseConnection);
            command.Parameters.AddWithValue("@marka", brandTB.Text);
            command.Parameters.AddWithValue("@model", modelTB.Text);
            command.Parameters.AddWithValue("@kolor", colorTB.Text);
            command.Parameters.AddWithValue("@id", id);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        private void EditOwner_Click(object sender, EventArgs e)
        {
            int carIndex = carCB.SelectedIndex;
            int ownerIndex = ownerListview.Items.IndexOf(ownerListview.SelectedItems[0]);
            int id_samochod = carList[carIndex].id_samochod;
            int id_wlasciciel = ownerList[ownerIndex].id_wlasciciel;
            string query = "UPDATE wlasciciel SET Imie=@imie, Nazwisko=@nazwisko, Id_samochod=@id_samochod where Id_wlasciciel = @id_wlasciciel";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.Parameters.AddWithValue("@imie", nameTB.Text);
            command.Parameters.AddWithValue("@nazwisko", lastNameTB.Text);
            command.Parameters.AddWithValue("@id_wlasciciel", id_wlasciciel);
            command.Parameters.AddWithValue("@id_samochod", id_samochod);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            int index = carListview.Items.IndexOf(carListview.SelectedItems[0]);
            int id = carList[index].id_samochod;
            string query = "DELETE FROM samochod where Id_samochod = @id";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.Parameters.AddWithValue("@id", id);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        private void DeleteOwner_Click(object sender, EventArgs e)
        {
            int ownerIndex = ownerListview.Items.IndexOf(ownerListview.SelectedItems[0]);
            int id = ownerList[ownerIndex].id_wlasciciel;
            string query = "DELETE FROM wlasciciel where Id_wlasciciel = @id";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.Parameters.AddWithValue("@id", id);
            databaseConnection.Open();
            command.ExecuteNonQuery();
            getItemsFromDB();
        }

        public void getItemsFromDB()
        {
            carListview.Items.Clear();
            ownerListview.Items.Clear();
            carCB.Items.Clear();
            carList.Clear();
            ownerList.Clear();

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            string query = "Select * from samochod";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                Car car = new Car(Convert.ToInt32(myReader["id_samochod"].ToString()), myReader["Marka"].ToString(), myReader["Model"].ToString(), myReader["Kolor"].ToString());
                carList.Add(car);
                carListview.Items.Add(car.ToString());
                carCB.Items.Add(myReader["Marka"].ToString() + " " + myReader["Model"].ToString());
            }
            myReader.Close();

            query = "Select * from wlasciciel";
            command = new MySqlCommand(query, databaseConnection);
            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                Owner owner = new Owner(Convert.ToInt32(myReader["Id_wlasciciel"].ToString()), myReader["Imie"].ToString(), myReader["Nazwisko"].ToString(), Convert.ToInt32(myReader["id_samochod"].ToString()));
                ownerList.Add(owner);
                int carid = owner.id_samochod;
                try
                {
                   var item = carList.First(x => x.id_samochod == carid);
                   ownerListview.Items.Add(owner + "\n Samochód: " + item.model + " " + item.marka);
                }
                catch
                {
                    ownerListview.Items.Add(owner + "\n Samochód: ");
                }

            }
        }

        private void CarListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carListview.SelectedIndices.Count > 0)
            {
                int index = carListview.Items.IndexOf(carListview.SelectedItems[0]);
                brandTB.Text = carList[index].model;
                modelTB.Text = carList[index].marka;
                colorTB.Text = carList[index].kolor;
            }
        }

        private void OwnerListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ownerListview.SelectedIndices.Count > 0)
            {
                int index = ownerListview.Items.IndexOf(ownerListview.SelectedItems[0]);
                nameTB.Text = ownerList[index].imie;
                lastNameTB.Text = ownerList[index].nazwisko;
                carCB.SelectedItem = null;
            }
        }
    }
}
