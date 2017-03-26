using System;
using System.Linq;
using System.Windows.Forms;
using FormEFPractice.Infrastructure;
using FormEFPractice.DBConnection;
using System.Reflection;
using WPFAppPractice.domain;

namespace FormEFPractice
{
    public partial class productsForm : Form
    {
        UnitOfWork context;

        public productsForm()
        {
            InitializeComponent();
        }

        private void exitTSMItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.Dispose();
        }

        private void productsForm_Load(object sender, EventArgs e)
        {
            this.context = new UnitOfWork(new ProductDBContext());

            // Загружаем данные из базы данных (Two-Way Binding)
            productDataGridView.DataSource = context.Products.GetAllEntries().ToList();

            // Загрузка категорий в бар поиска
            var catList = context.Categories.GetAllEntries().ToList();
            string[] items = new string[catList.Count];
            for (int i = 0; i < catList.Count; i++)
            {
                items[i] = catList[i].Name;
            }
            srch_cb.Items.AddRange(items);
        }

        // Срабатывает при любых манипуляциях с ячейкой (также и во время заполнения)
        private void productDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверка наличия точки в DataPropertyName
            if ((productDataGridView.Rows[e.RowIndex].DataBoundItem != null) && 
                (productDataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                // Присвоение строкового значения свойства экземпляра класса ячейке
                e.Value = BindProperty(productDataGridView.Rows[e.RowIndex].DataBoundItem,
                    productDataGridView.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        // Метод привязки свойства объекта (например объекта сущности)
        private string BindProperty(object property, string propertyName)
        {
            string value = "";
            if (propertyName.Contains("."))
            {
                // массив всех свойств объекта
                PropertyInfo[] propArray = property.GetType().GetProperties();
                // Левая часть прикрепляемого свойства (т. е. передаваемый сложный тип объекта)
                string leftPartOfPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));

                // Перебор свойств объекта и поиск нужного свойства через проверку. И используя рекурсию продвигаемся вправо через каждую точку в заданном имени
                foreach (PropertyInfo item in propArray)
                {
                    if (item.Name.Equals(leftPartOfPropertyName))
                    {
                        value = BindProperty(item.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propType = property.GetType();
                PropertyInfo propInfo = propType.GetProperty(propertyName);
                value = propInfo.GetValue(property, null).ToString();
            }

            return value;
        }

        private void updateProductsTSMtem_Click(object sender, EventArgs e)
        {
            context.Save();
            productDataGridView.DataSource = context.Products.GetAllEntries().ToList();
        }

        private void delProductsTSMItem_Click(object sender, EventArgs e)
        {
            int itemsCount = productDataGridView.SelectedRows.Count;
            if (itemsCount > 0)
            {
                for (int i = 0; i < itemsCount; i++)
                {
                    int id = Convert.ToInt32(productDataGridView.SelectedRows[i].Cells[0].Value);
                    Product p = context.Products.GetByID(id);
                    if (p != null)
                    {
                        context.Products.Delete(p);
                    }
                }
            }
            context.Save();
            MessageBox.Show("Deleted " + itemsCount + " entries.");
            productDataGridView.DataSource = context.Products.GetAllEntries().ToList();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            if (srch_tb.Text.Length == 0 && srch_cb.Text.Length == 0)
            {
                productDataGridView.DataSource = context.Products.GetAllEntries().ToList();
            }
            if (srch_cb.Text.Length == 0 && srch_tb.Text.Length != 0)
            {
                productDataGridView.DataSource = context.Products.FindBy(p => p.Name.Contains(srch_tb.Text)).ToList();
            }
            if (srch_cb.Text.Length != 0 && srch_tb.Text.Length == 0)
            {
                productDataGridView.DataSource = context.Products.FindBy(p => p.Category.Name.Contains(srch_cb.Text)).ToList();
            }
            if (srch_cb.Text.Length != 0 && srch_tb.Text.Length != 0)
            {
                productDataGridView.DataSource = context.Products.FindBy(p => p.Category.Name.Contains(srch_cb.Text) && p.Name.Contains(srch_tb.Text)).ToList();
            }
        }

        private void addProductTSMItem_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct(context);
            addForm.Owner = this;
            addForm.Show();
        }
    }
}
