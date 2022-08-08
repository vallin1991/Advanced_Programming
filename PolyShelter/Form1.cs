using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            DateTime dateTime1 = datePicker1.Value;
            DateTime dateTime2 = datePicker2.Value;
            string date1 = dateTime1.ToString("yyyy-MM-dd");
            string date2 = dateTime2.ToString("yyyy-MM-dd");
            PetSQL petSQL = new PetSQL();
            List<Pet> pet;

            pet = petSQL.GetPatientsByPeriod(date1, date2);

            foreach (var pet in patients)
            {
                string[] row = { pet.Ssn, pet.FirstName, pet.LastName, pet.Dob.ToShortDateString() };

                patientDataGridView.Rows.Add(row);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
