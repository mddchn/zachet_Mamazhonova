using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachet_var7
{
    public partial class Form1 :Form
    {
        private List<Product> products;
        private List<Group> groups;
        public Form1 ()
        {
            InitializeComponent();
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Кулинария" },
                new Product { Id = 2, Name = "Масло" },
                new Product { Id = 3, Name = "Product 3" },
                new Product { Id = 4, Name = "Product 4" },
                new Product { Id = 5, Name = "Product 5" }
            };

            groups = new List<Group>
            {
                new Group { InventoryNumber = 1, ProductId = 1, GroupName = "Печенье", Price = 100 },
                new Group { InventoryNumber = 2, ProductId = 1, GroupName = "Шоколад", Price = 200 },
                new Group { InventoryNumber = 3, ProductId = 2, GroupName = "Масло сливочное", Price = 300 },
                new Group { InventoryNumber = 4, ProductId = 2, GroupName = "Масло оливковое", Price = 400 },
                new Group { InventoryNumber = 5, ProductId = 5, GroupName = "Group 3", Price = 500 }
            };
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            string groupName = groupComboBox.SelectedItem.ToString();

            var query = from Group in groups
                        join Product in products on Group.ProductId equals Product.Id
                        where Group.GroupName == groupName
                        select new
                        {
                            InventoryNumber = Group.InventoryNumber,
                            ProductName = Product.Name,
                            Price = Group.Price
                        };

            label1.Text = $"Объединение для группы '{groupName}':\n";
            foreach (var item in query)
            {
                label1.Text += $"Группа: {item.ProductName} \t\tОбщая цена: {item.Price}\n";
            }
        }

        private void DeleteGroup (string groupName)
        {
           
            var itemsToDelete = from Group in groups
                                where Group.GroupName == groupName
                                select Group;

            
            foreach (var item in itemsToDelete.ToList())
            {
                groups.Remove(item);
            }
        }

        private void deleteButton_Click_Click (object sender, EventArgs e)
        {
            string groupName = groupComboBox.SelectedItem.ToString();

            DeleteGroup(groupName);

            label1.Text = $"Удалена группа '{groupName}' со всеми элементами.";
        }
    }
}
