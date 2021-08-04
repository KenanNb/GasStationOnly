﻿using GasStationOnly.Models;
using GasStationOnly.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationOnly
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            List<string> octanes = new List<string>
            {
                "92",
                "95",
                "gass"
            };
            gasolineComboBox.DataSource = octanes;
        }

        public EventHandler<EventArgs> PayButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadPaymentButtonClicked { get; set; }
        public List<GassStation> GassStations { set
            {
                AllPaymentsListbox.DataSource = null;
                AllPaymentsListbox.DataSource = value;
            }
        }
                
        public string GasolineText { get => gasolineComboBox.Text; set => gasolineComboBox.Text = value; }
        public string PriceText { get => priceTxtb.Text; set => priceTxtb.Text = value; }
        public string TimeText { get => TimeTxtb.Text; set => TimeTxtb.Text = value; }
        public string AmountText { get => amountTxtb.Text; set => amountTxtb.Text = value; }
        public string SumText { get => sumTxtb.Text; set => sumTxtb.Text = value; }
        public string PrePriceText { get => totalPaymentTxtb.Text; set => totalPaymentTxtb.Text = value; }
        public bool IsAmount { get => amountRbtn.Checked; set => amountRbtn.Checked=value; }

        private void payBtn_Click(object sender, EventArgs e)
        {
            PayButtonClicked.Invoke(sender,e);
        }

        private void loadPaymentsBtn_Click(object sender, EventArgs e)
        {
            LoadPaymentButtonClicked.Invoke(sender, e);
        }

        private void amountRbtn_CheckedChanged(object sender, EventArgs e)
        {
            sumTxtb.Enabled = false;
            sumTxtb.Text = "";
            amountTxtb.Enabled = true;
            TimeTxtb.Enabled = false;
            totalPaymentTxtb.Enabled = false;
            if (amountRbtn.Checked)
            {
                amountRbtn.ForeColor = Color.SpringGreen;
            }
            else
            {
                amountRbtn.ForeColor = Color.Black;
            }
        }

        private void sumRbtn_CheckedChanged(object sender, EventArgs e)
        {
            sumTxtb.Enabled = true;
            amountTxtb.Enabled = false;
            amountTxtb.Text = "";
            TimeTxtb.Enabled = false;            
            totalPaymentTxtb.Enabled = false;

            if (sumRbtn.Checked)
            {
                sumRbtn.ForeColor = Color.SpringGreen;
            }
            else
            {
                sumRbtn.ForeColor = Color.Black;
            }
        }

        private void gasolineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sb = gasolineComboBox.SelectedItem as string;
            if (sb == "92") {
                priceTxtb.Text = "1";
            }
            else if(sb == "95")
            {
                priceTxtb.Text = "1.45";
            }
            else
            {
                priceTxtb.Text = "0.8";
            }
        }

        private void amountTxtb_TextChanged(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(priceTxtb.Text) * decimal.Parse(amountTxtb.Text);
            totalPaymentTxtb.Text = total.ToString();
        }

        private void sumTxtb_TextChanged(object sender, EventArgs e)
        {
            totalPaymentTxtb.Text = sumTxtb.Text;
        }
    }
}
