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
    internal class ClassBLLIngreUC
    {
        public bool SaveItem(Image img, string name, string unitCalc)
        {
            try
            {
                ClassDBIngreUC objdal = new ClassDBIngreUC();
                return objdal.AddItemsToTable(img, name, unitCalc);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItems()
        {
            try
            {
                ClassDBIngreUC objdal = new ClassDBIngreUC();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
