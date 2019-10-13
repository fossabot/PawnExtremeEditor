using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Runtime.InteropServices;

namespace PawnEE
{
    public partial class FilesView : DockContent
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public FilesView()
        {
            InitializeComponent();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Rechercher dans Explorateur");
        }



        public TreeView treeViewFV
        {
            get
            {
                return this.treeView1;
            }
            set
            {
                this.treeView1 = value;
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            EventHandler.treeViewClick = true;
            string pathTo = treeView1.SelectedNode.FullPath;
            string parentLength = treeView1.Nodes[0].ToString();
            string selectedNodeParent = treeView1.SelectedNode.Parent.ToString();
            parentLength = parentLength.Remove(0, 10);
            pathTo = pathTo.Remove(0, parentLength.Length);
            EventHandler.treeViewClickFilePath = pathTo;
            EventHandler.treeViewGetFileName = treeView1.SelectedNode.Text;
        }
    }
}
