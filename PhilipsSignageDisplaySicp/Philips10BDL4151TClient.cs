using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using PhilipsSignageDisplaySicp.Models;

namespace PhilipsSignageDisplaySicp
{
    public class Philips10BDL4151TClient
       : PhilipsSicpClient
    {
        public Philips10BDL4151TClient(SicpSocket socket, byte monitorId = 1, byte groupId = 0)
            : base(socket, monitorId, groupId) { }

        public virtual void EnableLedStrip(Color color)
        {
            Set(SicpCommands.LedControlSet, true.ToByte(), color.R, color.G, color.B);
        }

        public virtual void DisableLedStrip()
        {
            Set(SicpCommands.LedControlSet, false.ToByte(), 0, 0, 0);
        }

        public virtual LedStripResult GetLedStrip()
        {
            return Get<LedStripResult>(SicpCommands.LedControlGet);
        }
    }
}
