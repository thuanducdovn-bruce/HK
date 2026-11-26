using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Cognex.VisionPro;
using Insnex.Vision2D;
namespace HK_Inspection

{
    public class CheckGlassInfors
    {
        public InsRecord[] Records { get; set; } 
        public bool[] Results { get; set; }
        public bool TotalResult { get; set; }
        public bool HasResult { get; set; }
        public bool FinishedFlag { get; set; }

        public CheckGlassInfors()
        {
            Records = new InsRecord[1];
            Results = new bool[1];
            TotalResult = false;
            HasResult = false;
            FinishedFlag = false;
        }
    }
}
