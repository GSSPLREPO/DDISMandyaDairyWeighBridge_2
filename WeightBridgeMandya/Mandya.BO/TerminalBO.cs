using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
   public class TerminalBO
    {
        #region WeighBridge Class Properties

        public const string WEIGHBRIDGE_TABLE = "Terminal_M";
        public const string WEIGHBRIDGE_TERMINALID = "TerminalId";
        public const string WEIGHBRIDGE_TERMINALNAME = "TerminalName";
        public const string WEIGHBRIDGE_INLET = "Inlet";
        public const string WEIGHBRIDGE_OUTLET = "Outlet";



        private int intTerminalId = 0;
        private string strTerminalName = string.Empty;
        private bool boolInlet = false;
        private bool boolOutlet = false;

        #endregion

        #region ---Properties---
        public int TerminalId
        {
            get { return intTerminalId; }
            set { intTerminalId = value; }
        }
        public string TerminalName
        {
            get { return strTerminalName; }
            set { strTerminalName = value; }
        }

        public bool Inlet
        {
            get { return boolInlet; }
            set { boolInlet = value; }
        }

        public bool Outlet
        {
            get { return boolOutlet; }
            set { boolOutlet = value; }
        }
        #endregion
    }
}
