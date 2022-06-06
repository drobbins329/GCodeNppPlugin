using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodeNpp.Forms
{
    public partial class Lathe_Tools : Form
    {
        private static string pattern = @"/^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$/";
        public Lathe_Tools()
        {
            InitializeComponent();
        }

        private void SFM_RPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var currentControl = this.Controls.Find("SFM_RPM", true).First();
            var resultControl = this.Controls.Find("SFM_Result", true).First();
            var sfmDiameterControl = this.Controls.Find("SFM_D", true).First();
            double.TryParse(currentControl.Text + e.KeyChar, out double keyPressed);
            double.TryParse(sfmDiameterControl.Text, out double diametervalue);
            resultControl.Text = ((keyPressed * diametervalue * 3.14) / 12).ToString();
            return;
        }

        private void SFM_D_KeyPress(object sender, KeyPressEventArgs e)
        {
            var currentControl = this.Controls.Find("SFM_D", true).First();
            var resultControl = this.Controls.Find("SFM_Result", true).First();
            var sfmRPMControl = this.Controls.Find("SFM_RPM", true).First();
            double.TryParse(currentControl.Text + e.KeyChar, out double keyPressed);
            double.TryParse(sfmRPMControl.Text, out double rpmvalue);
            resultControl.Text = ((rpmvalue * keyPressed * 3.14) / 12).ToString();
            return;
        }

        private void RPM_SFM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var currentControl = this.Controls.Find("RPM_SFM", true).First();
            var resultControl = this.Controls.Find("RPM_Result", true).First();
            var sfmDiameterControl = this.Controls.Find("RPM_D", true).First();
            double.TryParse(currentControl.Text + e.KeyChar, out double keyPressed);
            double.TryParse(sfmDiameterControl.Text, out double diametervalue);
            resultControl.Text = (keyPressed *(12/3.14) / diametervalue).ToString();
        }

        private void RPM_D_KeyPress(object sender, KeyPressEventArgs e)
        {
            var currentControl = this.Controls.Find("RPM_D", true).First();
            var resultControl = this.Controls.Find("RPM_Result", true).First();
            var sfmRPMControl = this.Controls.Find("RPM_SFM", true).First();
            double.TryParse(currentControl.Text + e.KeyChar, out double keyPressed);
            double.TryParse(sfmRPMControl.Text, out double rpmvalue);
            resultControl.Text = (rpmvalue * (12/3.14) / keyPressed).ToString();
            return;
        }
        
        private void IPR_IPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ipmControl = this.Controls.Find("IPR_IPM", true).First();
            var rpmControl = this.Controls.Find("IPR_RPM", true).First();
            var resultControl = this.Controls.Find("IPR_Result", true).First();
            double.TryParse(ipmControl.Text + e.KeyChar, out double ipmValue);
            double.TryParse(rpmControl.Text, out double rpmValue);
            resultControl.Text = (ipmValue/rpmValue).ToString();
            return;
        }

        private void IPR_RPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ipmControl = this.Controls.Find("IPR_IPM", true).First();
            var rpmControl = this.Controls.Find("IPR_RPM", true).First();
            var resultControl = this.Controls.Find("IPR_Result", true).First();
            double.TryParse(rpmControl.Text + e.KeyChar, out double rpmValue);
            double.TryParse(ipmControl.Text, out double ipmValue);
            resultControl.Text = (ipmValue/rpmValue).ToString();
            return;
        }

        private void IPM_IPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            var iprControl = this.Controls.Find("IPM_IPR", true).First();
            var rpmControl = this.Controls.Find("IPM_RPM", true).First();
            var resultControl = this.Controls.Find("IPM_Result", true).First();
            double.TryParse(iprControl.Text + e.KeyChar, out double iprValue);
            double.TryParse(rpmControl.Text, out double rpmValue);
            resultControl.Text = (iprValue * rpmValue).ToString();
            return;
        }

        private void IPM_RPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var iprControl = this.Controls.Find("IPM_IPR", true).First();
            var rpmControl = this.Controls.Find("IPM_RPM", true).First();
            var resultControl = this.Controls.Find("IPM_Result", true).First();
            double.TryParse(rpmControl.Text + e.KeyChar, out double rpmValue);
            double.TryParse(iprControl.Text, out double iprValue);
            resultControl.Text = (iprValue * rpmValue).ToString();
            return;
        }

        private void MRR_SFM_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sfmControl = this.Controls.Find("MRR_SFM", true).First();
            var iprControl = this.Controls.Find("MRR_IPR", true).First();
            var docControl = this.Controls.Find("MRR_DOC", true).First();
            var resultControl = this.Controls.Find("MRR_Result", true).First();
            double.TryParse(sfmControl.Text + e.KeyChar, out double sfmValue);
            double.TryParse(iprControl.Text, out double iprValue);
            double.TryParse(docControl.Text, out double docValue);
            resultControl.Text = (sfmValue * 12 * iprValue * docValue).ToString();
            return;
        }

        private void MRR_IPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sfmControl = this.Controls.Find("MRR_SFM", true).First();
            var iprControl = this.Controls.Find("MRR_IPR", true).First();
            var docControl = this.Controls.Find("MRR_DOC", true).First();
            var resultControl = this.Controls.Find("MRR_Result", true).First();
            double.TryParse(sfmControl.Text, out double sfmValue);
            double.TryParse(iprControl.Text + e.KeyChar, out double iprValue);
            double.TryParse(docControl.Text, out double docValue);
            resultControl.Text = (sfmValue * 12 * iprValue * docValue).ToString();
            return;
        }

        private void MRR_DOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sfmControl = this.Controls.Find("MRR_SFM", true).First();
            var iprControl = this.Controls.Find("MRR_IPR", true).First();
            var docControl = this.Controls.Find("MRR_DOC", true).First();
            var resultControl = this.Controls.Find("MRR_Result", true).First();
            double.TryParse(sfmControl.Text, out double sfmValue);
            double.TryParse(iprControl.Text, out double iprValue);
            double.TryParse(docControl.Text + e.KeyChar, out double docValue);
            resultControl.Text = (sfmValue * 12 * iprValue * docValue).ToString();
            return;
        }
    }
}
