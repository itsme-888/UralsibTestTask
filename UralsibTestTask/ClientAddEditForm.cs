using UralsibTestTask.Models;

namespace UralsibTestTask
{
    public partial class ClientAddEditForm : Form
    {
        Client CurrentClient { get; }
        ClientInfo CurrentClientInfo { get; set; }

        public ClientAddEditForm()
        {
            InitializeComponent();
            this.Text = "Добавить";
            this.dtpBirthDay.Value = DateTime.Now.AddYears(-20);
        }

        public ClientAddEditForm(Client client)
        {
            InitializeComponent();
            this.Text = "Изменить";
            this.CurrentClient = client;
            SetData();
        }

        private void SetData()
        {
            using (DataContext context = new DataContext())
            {
                CurrentClientInfo = context.ClientsInfo.First(c => c.ClientInfoId == CurrentClient.ClientInfoId);

                tbName.Text = CurrentClient.Name;
                tbSurname.Text = CurrentClient.Surname;
                tbPatr.Text = CurrentClient.Patronymic;

                tbEmail.Text = CurrentClientInfo.Email;
                dtpBirthDay.Value = CurrentClientInfo.BirthDay;
                mTbPhone.Text = CurrentClientInfo.Phone;
            }
        }

        private void ClientAddEditForm_Load(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(IsDataValid() == false)
            {
                MessageBox.Show("Некоторые поля не заполнены или заполнены неверно.");
                return;
            }

            if(CurrentClient == null)
            {
                using (DataContext context = new DataContext())
                {
                    var client = new Client {
                        Name = tbName.Text,
                        Surname = tbSurname.Text,
                        Patronymic = tbPatr.Text
                    };

                    context.Clients.Add(client);

                    var clientInfo = new ClientInfo
                    {
                        Email = tbEmail.Text,
                        BirthDay = dtpBirthDay.Value,
                        Phone = mTbPhone.Text,
                        Client = client,
                    };

                    context.ClientsInfo.Add(clientInfo);
                    context.SaveChanges();
                }
            }
            else
            {
                using (DataContext context = new DataContext())
                {
                    context.Clients.Attach(CurrentClient);
                    context.ClientsInfo.Attach(CurrentClientInfo);

                    CurrentClient.Name = tbName.Text;
                    CurrentClient.Surname = tbSurname.Text;
                    CurrentClient.Patronymic = tbPatr.Text;

                    CurrentClientInfo.Email = tbEmail.Text;
                    CurrentClientInfo.BirthDay = dtpBirthDay.Value;
                    CurrentClientInfo.Phone = mTbPhone.Text;

                    context.SaveChanges();
                }
            }

            this.Close();
        }



        readonly Color errorColor = Color.Red;
        readonly Color normalColor = SystemColors.Window;
        private bool IsDataValid()
        {
            bool correct = true;

            foreach (var control in this.Controls)
            {
                if (control != null)
                {
                    if (control is TextBox)
                    {
                        var tb = control as TextBox;

                        if (string.IsNullOrWhiteSpace(tb.Text))
                        {
                            correct = false;
                            tb.BackColor = errorColor;
                            tb.TextChanged += Tb_TextChanged;
                        }
                    }

                    if (control is MaskedTextBox)
                    {
                        var mTb = control as MaskedTextBox;

                        if(mTb.MaskCompleted == false)
                        {
                            correct = false;
                            mTb.BackColor = errorColor;
                            mTb.TextChanged += MTb_TextChanged;
                        }
                    }
                }
            }
            return correct;
        }

        private void MTb_TextChanged(object? sender, EventArgs e)
        {
            (sender as MaskedTextBox).BackColor = normalColor;
            (sender as MaskedTextBox).TextChanged -= MTb_TextChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {
            (sender as TextBox).BackColor = normalColor;
            (sender as TextBox).TextChanged -= Tb_TextChanged;
        }
    }
}
