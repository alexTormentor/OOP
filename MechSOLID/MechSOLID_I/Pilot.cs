using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_I
{
    public class Pilot
    {
        public void GetStatus(IStatus status)
        {
            status.GetStatus();
        }
        public void Message(IMessage msg)
        {
            msg.Message();
        }
        public void Connect(IConnect connect)
        {
            connect.ConnectToOrbiter();
        }
        public void LandscapeAnalyze(IAnalyze analize)
        {
            analize.LandscapeAnalyze();
        }
    }
}
