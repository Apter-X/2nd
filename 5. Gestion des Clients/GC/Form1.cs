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

            try
            {
                conn.DBConnect();
                MessageBox.Show("Connected!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Connection: " + e);
                throw;
            }
            finally
            {
                conn.Count();
            }
        }
    }
}
