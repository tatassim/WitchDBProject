using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseProject.DataAccess;
using DataBaseProject.UserControls;

namespace DataBaseProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void WitchUserControl_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SabbathWConnStr"].ConnectionString;
            witchUserControl1.BoundControl(connectionString);
        }

        private void witchUserControl1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SabbathWConnStr"].ConnectionString;
            witchUserControl1.BoundControl(connectionString);
            covenUserControl1.BoundControl(connectionString);
            habitatUserControl1.BoundControl(connectionString);

        }
    }
}
