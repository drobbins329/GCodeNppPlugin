using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using GCodeNpp.Forms;
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;

namespace GCodeNpp
{
    internal class GCodeNppPlugin
    {
        public GCodeNppPlugin()
        { }
        private static IScintillaGateway editor;


        public const string PLUGIN_NAME = "GCodeNpp";
        static Lathe_Tools lathe_ToolsDlg = null;
        static int idLatheToolsDlg = -1;
        static Bitmap tbBmp = GCodeNpp.Properties.Resources.star;
        static Bitmap tbBmp_tbTab = GCodeNpp.Properties.Resources.star_bmp;
        static Icon tbIcon = null;

        public void CommandMenuInit()
        {
            editor = new ScintillaGateway(PluginBase.GetCurrentScintilla());
            
            PluginBase.SetCommand(0, "Lathe Tools", myLatheCalcDialog); idLatheToolsDlg = 0;
            PluginBase.SetCommand(1,"Humanize", HumanizeGCodeText, new ShortcutKey(true, true, true, Keys.S));
        }

        internal static void HumanizeGCodeText()
        {
            var e = editor;
            int lineCount = e.GetLineCount();
            char[] interupts = ("BCDGMFHIJKMNPQUVWXYZRST").ToCharArray();
            char[] comments = new char[] { '(', ')' };
            int pos = 0;
            string[] docLines = new string[lineCount];
            for(int i = 0; i < lineCount; i++)
            {
                docLines[i] = e.GetLine(i);
            }
            for (int i = 0; i < lineCount; i++)
            {
                char[] lineChars = docLines[i].ToCharArray();
                string thisLine = String.Empty;
                bool comment = false;
                
                for (int j = 0; j < lineChars.Length; j++)
                {
                    char c = lineChars[j];
                    if (c == '(') comment = true;
                    if (c == ')') comment = false;
                    if (interupts.Contains(c))
                    {
                        if (comment)
                        {
                            thisLine += c;
                            continue;
                        }

                        if (j == 0)
                        {
                            thisLine += c;
                            continue;
                        }

                        if (lineChars[j - 1] == ' ')
                        {
                            thisLine += c;
                            continue;
                        }

                        thisLine += $" {c}";
                    }
                    else
                    {
                        thisLine += c;
                    }

                    // if (j == lineChars.Length - 1)
                    // {
                    //     thisLine += "\n";
                    // }

                    if (lineChars.Length == 0)
                    {
                        thisLine += "\n";
                    }
                }

                docLines[i] = thisLine;
            }
            string finalText = String.Empty;
            foreach (string s in docLines)
            {
                finalText += s;
            }
            e.SetText(finalText);
        }

        internal static void myLatheCalcDialog()
        {
            if(lathe_ToolsDlg == null)
            {
                using (Bitmap newBmp = new Bitmap(16, 16))
                {
                    Graphics g = Graphics.FromImage(newBmp);
                    ColorMap[] colorMap = new ColorMap[1];
                    colorMap[0] = new ColorMap();
                    colorMap[0].OldColor = Color.Fuchsia;
                    colorMap[0].NewColor = Color.FromKnownColor(KnownColor.ButtonFace);
                    ImageAttributes attr = new ImageAttributes();
                    attr.SetRemapTable(colorMap);
                    g.DrawImage(tbBmp_tbTab, new Rectangle(0, 0, 16, 16), 0, 0, 16, 16, GraphicsUnit.Pixel, attr);
                    tbIcon = Icon.FromHandle(newBmp.GetHicon());
                }

                lathe_ToolsDlg = new Lathe_Tools();
                NppTbData _nppTbData = new NppTbData();

                _nppTbData.hClient = lathe_ToolsDlg.Handle;
                _nppTbData.pszName = "Lathe Tools";
                _nppTbData.dlgID = idLatheToolsDlg;
                _nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT | NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;
                _nppTbData.hIconTab = (uint)tbIcon.Handle;
                _nppTbData.pszModuleName = PLUGIN_NAME;
                IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
                Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);
            }
            else 
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMSHOW, 0, lathe_ToolsDlg.Handle);
            }
        }        

        public void SetToolBarIcon()
        {
            toolbarIcons tbIcons = new toolbarIcons();
            tbIcons.hToolbarBmp = tbBmp.GetHbitmap();
            IntPtr pTbIcons = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons));
            Marshal.StructureToPtr(tbIcons, pTbIcons, false);
            Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_ADDTOOLBARICON, PluginBase._funcItems.Items[idLatheToolsDlg]._cmdID, pTbIcons);
            Marshal.FreeHGlobal(pTbIcons);
        }

    }
}
