using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gersof.Common.Logger;

namespace Gersof.Common.Logger.TestForm
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnerr_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Nueva excepcion");
            }catch(Exception ex)
            {
                HelperLogger.Current.RegisterEventLogError(ex, "App1", "MACHINE1", "METHOD");
            }
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            HelperLogger.Current.RegisterEventLogInfo("Holaaaa");
        }
    }
}
