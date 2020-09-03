using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddCar addCar = new FormAddCar();
            addCar.ShowDialog();
        }

        private void buttonRaports_Click(object sender, EventArgs e)
        {
            ReportsForm raport = new ReportsForm();
            raport.ShowDialog();
        }

        private void buttonTiresSwap_Click(object sender, EventArgs e)
        {
            TairSwapForm tariswap = new TairSwapForm();
            tariswap.ShowDialog();
        }

        private void buttonReplacmentFilters_Click(object sender, EventArgs e)
        {
            ReplacmentFiltersForm replacmentFilters = new ReplacmentFiltersForm();
            replacmentFilters.ShowDialog();
        }
        private void buttonExchangeLiquid_Click(object sender, EventArgs e)
        {
            ExchangeLiquidForm exchangeLiquid = new ExchangeLiquidForm();
            exchangeLiquid.ShowDialog();
        }
    }
}
