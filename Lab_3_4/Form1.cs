using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3_4
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private CompaniesDatabase companiesDatabase;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            companiesDatabase = new CompaniesDatabase();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private async Task<Company> getCompanyData(string country, string nip)
        {
            string call = $"https://ec.europa.eu/taxation_customs/vies/rest-api/ms/{country}/vat/{nip}";
            string response = await client.GetStringAsync(call);
            return JsonSerializer.Deserialize<Company>(response);
        }

        private async void buttonDownload_ClickAsync_Click(object sender, EventArgs e)
        {
            textBoxResponse.Clear();

            string country = companyCountry_TextBox.Text;
            string nip = companyNip_TextBox.Text;

            Company company = await getCompanyData(country, nip);

            if (company != null)
            {
                if (company.isValid)
                {
                    textBoxResponse.Text = company.ToString().Replace("\n", Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("B³¹d przy wyszukiwaniu lub niepoprawny kraj/nip");
                }
            }
            else
            {
                textBoxResponse.Text = "B³¹d obiektu firmy";
            }
        }


        private async void addToDatabase_Button_Click(object sender, EventArgs e)
        {
            string country = companyCountry_TextBox.Text;
            string nip = companyNip_TextBox.Text;

            Company company = await getCompanyData(country, nip);

            if (company != null)
            {
                if (!companiesDatabase.Companies.Any(c => c.vatNumber == company.vatNumber))
                {
                    //companiesDatabase.Companies.Add(new Company() { isValid = company.isValid, name = company.name, address = company.address, vatNumber = company.vatNumber});
                    companiesDatabase.Companies.Add(company);
                    companiesDatabase.SaveChanges();
                    MessageBox.Show("Firma dodana do bazy danych");
                }
                else
                {
                    MessageBox.Show("Firma o tym NIP jest ju¿ w bazie danych");
                }
            }
            else
            {
                MessageBox.Show("Nie uda³o siê pobraæ danych firmy");
            }
        }

        private void deleteFromDatabase_Button_Click(object sender, EventArgs e)
        {
            companiesDatabase.Companies.RemoveRange(companiesDatabase.Companies);
            companiesDatabase.SaveChanges();

            MessageBox.Show("Zawartoœæ bazy danych zosta³a usuniêta");
        }

        private void showDataBase_Button_Click(object sender, EventArgs e)
        {
            textBoxResponse.Clear();

            var companies = companiesDatabase.Companies.ToList();

            if (companies.Any())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var company in companies)
                {
                    sb.AppendLine($"Nazwa: {company.name}");
                    sb.AppendLine($"Adres: {company.address}");
                    sb.AppendLine($"Numer VAT: {company.vatNumber}");
                    sb.AppendLine();
                }

                textBoxResponse.Text = sb.ToString();
            }
            else
            {
                textBoxResponse.Text = "Brak firm w bazie danych";
            }
        }

        private void companyCountry_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (companyCountry_TextBox.Text.All(char.IsLetter) || string.IsNullOrEmpty(companyCountry_TextBox.Text))
            {
                companyCountry_TextBox.BackColor = System.Drawing.Color.White;

                search_Button.Enabled = true;
                addToDatabase_Button.Enabled = true;
                deleteFromDatabase_Button.Enabled = true;
                showDataBase_Button.Enabled = true;
            }
            else
            {
                companyCountry_TextBox.BackColor = System.Drawing.Color.Red;

                search_Button.Enabled = false;
                addToDatabase_Button.Enabled = false;
                deleteFromDatabase_Button.Enabled = false;
                showDataBase_Button.Enabled = false;
            }
        }

        private void companyNip_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(companyNip_TextBox.Text, out long _) || string.IsNullOrEmpty(companyNip_TextBox.Text))
            {
                companyNip_TextBox.BackColor = System.Drawing.Color.White;

                search_Button.Enabled = true;
                addToDatabase_Button.Enabled = true;
                deleteFromDatabase_Button.Enabled = true;
                showDataBase_Button.Enabled = true;
            }
            else
            {
                companyNip_TextBox.BackColor = System.Drawing.Color.Red;
                search_Button.Enabled = false;
                addToDatabase_Button.Enabled = false;
                deleteFromDatabase_Button.Enabled = false;
                showDataBase_Button.Enabled = false;
            }
        }
    }
}