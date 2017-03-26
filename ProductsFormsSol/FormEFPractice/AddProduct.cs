using FormEFPractice.Infrastructure;
using System;
using System.Linq;
using System.Windows.Forms;
using WPFAppPractice.domain;

namespace FormEFPractice
{
    public partial class AddProduct : Form
    {
        UnitOfWork context;
        public AddProduct(UnitOfWork context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cat_cb.DataSource = context.Categories.GetAllEntries().ToList();
            cat_cb.ValueMember = "Id";
            cat_cb.DisplayMember = "Name";
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (name_tb.Text.Length == 0 || price_tb.Text.Length == 0 || cat_cb.Text.Length == 0)
            {
                MessageBox.Show("All fields are required for filling");
                return;
            }

            Product p = new Product();
            p.Name = name_tb.Text;
            p.Qty = Convert.ToInt32(qty_num.Value);
            p.Price = Convert.ToDecimal(price_tb.Text);
            p.Category = (Category)cat_cb.SelectedItem;

            if (p != null)
            {
                context.Products.Insert(p);
                context.Save();
            }

            MessageBox.Show("New product added.");
            this.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
