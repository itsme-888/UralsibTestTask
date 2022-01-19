using Microsoft.EntityFrameworkCore;
using UralsibTestTask.Models;

namespace UralsibTestTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadAllClient();
        }

        private void LoadAllClient()
        {
            using (DataContext context = new DataContext())
            {
                context.Clients.Load();
                var c = context.Clients.Local.ToBindingList();
                clientBindingSource1.DataSource = c;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                var client = new Client { Name = "Name", Surname = "Surname", Patronymic = "PatName" };
                context.Clients.Add(client);
                var clientInfo = new ClientInfo
                {
                    Email = "email@email.com",
                    BirthDay = DateTime.Now,
                    Phone = "8(912)334-43-24",
                    Client = client,
                };

                
                context.ClientsInfo.Add(clientInfo);
                context.SaveChanges();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            var form = new ClientAddEditForm();
            form.ShowDialog();
            LoadAllClient();
        }

        private void bChangeClient_Click(object sender, EventArgs e)
        {
            var client = clientBindingSource1.Current as Client;

            if (client != null)
            {
                var form = new ClientAddEditForm(client);
                form.ShowDialog();
                LoadAllClient();
            }
            else MessageBox.Show("Клиент не выбран");

        }

        private void bAddBuyCurrentClient_Click(object sender, EventArgs e)
        {
            var client = clientBindingSource1.Current as Client;

            if (client != null)
            {
                var form = new AddBuy(client);
                form.ShowDialog();
            }
            else MessageBox.Show("Клиент не выбран");
        }

        private void bDelCurrent_Click(object sender, EventArgs e)
        {
            var client = clientBindingSource1.Current as Client;

            if (client != null)
            {
                using (DataContext context = new DataContext())
                {
                    context.Clients.Remove(client);
                    context.ClientsInfo.Remove(new ClientInfo { ClientInfoId = client.ClientInfoId });
                    context.SaveChanges();
                }
                LoadAllClient();
            }
            else MessageBox.Show("Клиент не выбран");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = clientBindingSource1.Current as Client;

            if (client != null)
            {
                using (DataContext context = new DataContext())
                {
                    var form = new ShowClientInfo(client);
                    form.ShowDialog();
                }
            }
            else MessageBox.Show("Клиент не выбран");
        }
    }
}