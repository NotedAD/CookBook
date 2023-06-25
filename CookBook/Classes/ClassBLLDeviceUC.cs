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
    internal class ClassBLLDeviceUC
    {
            public bool SaveItem(Image img, string name)
            {
                try
                {
                    ClassDBDeviceUC objdal = new ClassDBDeviceUC();
                    return objdal.AddItemsToTable(img, name);
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
                ClassDBDeviceUC objdal = new ClassDBDeviceUC();
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

