using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;
using GCodeNpp;

namespace Kbg.NppPluginNET
{
    class Main
    {
        private static readonly GCodeNpp.GCodeNppPlugin gCodeNppPlugin = new GCodeNpp.GCodeNppPlugin();

        public const string PluginName = GCodeNpp.GCodeNppPlugin.PLUGIN_NAME;

        public static void OnNotification(ScNotification notification)
        {
            var n = notification.ToString();
        }

        internal static void CommandMenuInit()
        {
            gCodeNppPlugin.CommandMenuInit();
        }
        
        internal static void SetToolBarIcon()
        {
            gCodeNppPlugin.SetToolBarIcon();
        }

        internal static void PluginCleanUp()
        {
            // do nothing.
        }     

        
    }
}