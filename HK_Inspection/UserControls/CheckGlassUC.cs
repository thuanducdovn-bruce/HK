using Insnex.Vision2D.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HK_Inspection.UserControls
{
    public partial class CheckGlassUC : UserControl
    {
        
        public delegate void UCEventHandler(IInsRecordDisplay record);
        public event UCEventHandler RecordDisplayDoudlbeClick;

        public CheckGlassUC()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            lbIndex.Text = title;
        }

        public void UpdateRecord(CheckGlassInfors infors)
        {
            insRecordDisplayControl1.Record = infors != null && infors.Records != null && infors.Records.Length > 0
                ? infors.Records[0]
                : null;

            if (infors != null && infors.FinishedFlag && infors.HasResult)
            {
                if (infors.TotalResult)
                {
                    lbResult.Text = "OK";
                    lbResult.BackColor = Color.LimeGreen;
                }
                else
                {
                    lbResult.Text = "NG";
                    lbResult.BackColor = Color.Red;
                }
            }
            else if (infors != null && infors.FinishedFlag)
            {
                lbResult.Text = "DONE";
                lbResult.BackColor = Color.Goldenrod;
            }
            else
            {
                lbResult.Text = "CHECKING";
            }
        }

        public void ClearRecord()
        {
            insRecordDisplayControl1.Record = null;
            

            lbResult.Text = "";
            lbResult.BackColor = Color.Transparent;
        }

        private void recordDisplayDoubleClicked(object sender, EventArgs e)
        {
            IInsRecordDisplay record = (IInsRecordDisplay)sender;

            RecordDisplayDoudlbeClick?.Invoke(record);

        }
    }
}
