using System.Data;
using WinFormsPayment.SOLID;
using System.Data.SqlClient;

namespace WinFormsPayment
{
    public partial class Form1 : Form
    {
        //global variable
        string selectedPaymentType;
        IPaymentMethod paymentMethod;

        public Form1()
        {
            InitializeComponent();
            LoadPaymentTypes();
        }

        private void LoadPaymentTypes()
        {
            // Sql üzerinden combobox'ý doldurmak için sql server connection string.
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PaymentDb;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PaymentTypes", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbPaymentType.DataSource = dt;
                    cmbPaymentType.DisplayMember = "DisplayName";
                    cmbPaymentType.ValueMember = "ClassName";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
        
            PaymentFactory factory = new PaymentFactory();
            paymentMethod = factory.createNewPayment(selectedPaymentType);
            PaymentProcessor processor = new PaymentProcessor(paymentMethod);
            lblResult.Text = processor.ProcessPayment(txtAmount.Text);

        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedValue ile database'ten çekilen data'nýn deðeri alýnýyor. 
            selectedPaymentType = cmbPaymentType.SelectedValue.ToString();
        }

        private void lblPaymentType_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
