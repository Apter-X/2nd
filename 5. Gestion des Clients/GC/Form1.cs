using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database conn = new Database();

            conn.Insert("clients", "first_name, last_name, address, city", "zak, kaz, 17 rue Metz, casablanca");
        }
    }
}
