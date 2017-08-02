using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmAZL : Form
    {
        private List<DataTable> tables;
        public frmAZL()
        {
            InitializeComponent();
            SetToolWindows();
            dtpDate.Value = DateTime.Now;
            gdvAZL.MultiSelect = true;
            gdvIDs.MultiSelect = true;
        }


        private void SetToolWindows()
        {
            DockWindow[] windows = radDock1.DockWindows.ToolWindows;

            foreach (DockWindow item in windows)
            {
                item.DockState = DockState.AutoHide;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DALSSTEM dal = new DALSSTEM();
                tables = dal.GetAZL(dtpDate.Value);
                gdvIDs.DataSource = null;

                if (tables.Count > 0)
                {
                    gdvAZL.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                    gdvAZL.DataSource = tables[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("The system cannot calculate the AZL report.\nPlease check if your pc is mapped to SSTEM server.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvAZL_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(gdvAZL.SelectedRows.Count > 0)
            {
                string user = gdvAZL.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = (from r in tables[1].AsEnumerable()
                                where r.Field<string>("USER") == user && r.Field<string>("TRACKING_ID").Trim().Length == 9
                                select r).CopyToDataTable();

                gdvIDs.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                gdvIDs.DataSource = dt;
            }

        }
    }
}
