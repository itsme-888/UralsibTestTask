using Microsoft.EntityFrameworkCore;
using System.Data;
using UralsibTestTask.Models;

namespace UralsibTestTask
{
    public partial class ShowClientInfo : Form
    {
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        Client CurrentClient { get; }
        ClientInfo CurrentClientInfo { get; set; }
        public ShowClientInfo(Client client)
        {
            CurrentClient = client;
            InitializeComponent();
            SetDataToControls();
        }

        private void SetDataToControls()
        {
            using (DataContext context = new DataContext())
            {
                if (CurrentClientInfo == null)
                    CurrentClientInfo = context.ClientsInfo.First(c => c.ClientInfoId == CurrentClient.ClientInfoId);

                tbName.Text = CurrentClient.Name;
                tbSurname.Text = CurrentClient.Surname;
                tbPatr.Text = CurrentClient.Patronymic;

                tbEmail.Text = CurrentClientInfo.Email;
                dtpBirthDay.Value = CurrentClientInfo.BirthDay;
                mTbPhone.Text = CurrentClientInfo.Phone;

                context.Buys.Where(b => b.ClientId == CurrentClient.ClientId).Load();
                var buys = context.Buys.Local.ToBindingList();
                buyBindingSource.DataSource = buys;
            }
        }

        private void buyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentSelectedBuy = (sender as BindingSource).Current as Buy;

            if (currentSelectedBuy != null && currentSelectedBuy.Photo != null)
                pictureBox1.Image = ByteToImage(currentSelectedBuy.Photo);
            else
                pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentSelectedBuy = buyBindingSource.Current as Buy;

            if (currentSelectedBuy != null)
            {
                using (DataContext context = new DataContext())
                {
                    context.Remove(currentSelectedBuy);
                    context.SaveChanges();
                }

                SetDataToControls();
            }
            else
                MessageBox.Show("Нет покупок.");
        }
    }
}
