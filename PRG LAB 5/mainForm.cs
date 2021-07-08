using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_LAB_5
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void buttonCityHighest_Click(object sender, EventArgs e)
        {
            var city = (string)this.cityTableAdapter.MaxQuery();
            MessageBox.Show(this, "City with highest population is " + city + ".","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonSortByDesc_Click(object sender, EventArgs e)
        {
            var query = from c in this.populationDBDataSet.City.AsEnumerable()
                        orderby c.Population descending
                        select c;

            this.cityDataGridView.DataSource = query.ToList();
        }

        private void buttonCityLowest_Click(object sender, EventArgs e)
        {
            var city = (string)this.cityTableAdapter.MinQuery();
            MessageBox.Show(this, "City with lowest population is " + city + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSortByAsc_Click(object sender, EventArgs e)
        {
            var query = from c in this.populationDBDataSet.City.AsEnumerable()
                        orderby c.Population
                        select c;

            this.cityDataGridView.DataSource = query.ToList();
        }

        private void buttonSortByCity_Click(object sender, EventArgs e)
        {
            var query = from c in this.populationDBDataSet.City.AsEnumerable()
                        orderby c.Name

                        select c;

            this.cityDataGridView.DataSource = query.ToList();
        }

        private void buttonTotalPopulation_Click(object sender, EventArgs e)
        {
            var totalPopulation = (from c in this.populationDBDataSet.City.AsEnumerable()
                                   select c.Population).Sum();
            MessageBox.Show(this, "Total population is " + totalPopulation.ToString("n0") + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonAvgPopulation_Click(object sender, EventArgs e)
        {
            var avgPopulation = (from c in this.populationDBDataSet.City.AsEnumerable()
                                   select c.Population).Average();
            MessageBox.Show(this, "Average population is " + avgPopulation.ToString("n0") + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            var query = from c in this.populationDBDataSet.City.AsEnumerable() 
                        select c;

            this.cityDataGridView.DataSource = query.ToList();
        }
    }
}
