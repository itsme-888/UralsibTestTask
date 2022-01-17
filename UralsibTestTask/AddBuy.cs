using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UralsibTestTask.Models;

namespace UralsibTestTask
{
    public partial class AddBuy : Form
    {
        Client CurrentClient { get; }

        string selectedImagePath;

        public AddBuy(Client client)
        {
            InitializeComponent();
            CurrentClient = client;
        }

        private void AddBuy_Load(object sender, EventArgs e)
        {
            lCurrentClientFIO.Text = $"{CurrentClient.Surname} {CurrentClient.Name} {CurrentClient.Patronymic}"; 
            dtpDateTime.Value = DateTime.Now;
        }

        private byte[] GetImageBytes()
        {
            if (string.IsNullOrEmpty(selectedImagePath))
                return null;
            else
                return File.ReadAllBytes(selectedImagePath);
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            var rawPrice = tbPrice.Text;

            if(decimal.TryParse(rawPrice, out decimal price))
            {
                var newBuy = new Buy
                {
                    ClientId = CurrentClient.ClientId,
                    Photo = GetImageBytes(),
                    DateTimeBuy = dtpDateTime.Value,
                    Price = price,
                };

                using (DataContext context = new DataContext())
                {
                    context.Buys.Add(newBuy);
                    context.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Цена указана неверно");
            }
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void bClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
