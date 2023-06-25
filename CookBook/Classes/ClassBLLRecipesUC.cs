using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Classes
{
    internal class ClassBLLRecipesUC
    {
        public bool SaveItem(Image img, string name, string description, string dishType)
        {
            try
            {
                ClassDBRecipesUC objdal = new ClassDBRecipesUC();
                return objdal.AddItemsToTable(img, name, description, dishType);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItems(string searchText)
        {
            try
            {
                ClassDBRecipesUC objdal = new ClassDBRecipesUC();
                return objdal.ReadItemsTable(searchText);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
