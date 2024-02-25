using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlOrders : UserControl
    {
        public static UsrCtrlOrders instance = new();

        public UsrCtrlOrders()
        {
            InitializeComponent();
        }
    }
}
