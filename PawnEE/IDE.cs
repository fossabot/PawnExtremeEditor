using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Runtime.InteropServices;
using System.Xml;
using DiscordRPC;

namespace PawnEE
{
    public partial class IDE : Form
    {
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        FilesView explo = new FilesView();
        public IDE()
        {
            InitializeComponent();
            Console output = new Console();
            output.Text = "Sortie";
            output.Show(dockPanel1, DockState.DockBottom);
            
            WelcomeFrame welcomepage = new WelcomeFrame();
            welcomepage.Text = "Bienvenue";
            welcomepage.Show(dockPanel1, DockState.Document);

            explo.Text = "Explorateur";
            explo.Show(dockPanel1, DockState.DockLeft);
            
            ListingFrame errors = new ListingFrame();
            errors.Text = "Liste d'erreurs";
            errors.Show(dockPanel1, DockState.DockBottom);

            output.consoleText = "Checking PawnCC updates..\nPawnCC is up to date! (3.10.9)\nPawnEE succesfully loaded!";


            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, Top);
            e.Graphics.FillRectangle(Brushes.Green, Left);
            e.Graphics.FillRectangle(Brushes.Green, Right);
            e.Graphics.FillRectangle(Brushes.Green, Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 20;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3000),this.DisplayRectangle);
        }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        string pathToFile = "";
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Pawn File";
            theDialog.Filter = "Pawn Files|*.pwn";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = theDialog.FileName;
                
            }

            if (File.Exists(pathToFile))
            {
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    TextEditor untitlededit = new TextEditor();
                    untitlededit.Text = theDialog.SafeFileName;
                    untitlededit.editorText = sr.ReadToEnd();
                    untitlededit.Show(dockPanel1, DockState.Document);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selectionnez le dossier contenant le serveur SA:MP";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                ListDirectory(explo.treeViewFV, fbd.SelectedPath);
                EventHandler.workspaceFilePath = fbd.SelectedPath;
                if (!File.Exists(fbd.SelectedPath + "\\samp-server.exe"))
                {
                    PopupBox pop = new PopupBox();
                    pop.message = "Il semblerais que le fichier 'samp-server.exe' ne soit \npas présent dans le projet.\n\nVoulez-vous continuer ?";
                    pop.button1Text = "OK";
                    pop.button2Text = "Quitter";
                    pop.Show();
                }
            }
            

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }


        public DiscordRpcClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new DiscordRpcClient("632427300402495508");
            client.Initialize();
            if (System.Security.Principal.WindowsIdentity.GetCurrent().Name == "SALIMOC-PC\\salimoc")
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Scripting..",
                    State = "PawnExtremeEditor v1.0",
                    Assets = new Assets()
                    {
                        LargeImageKey = "pawnee_logo",
                        LargeImageText = "PawnEE",
                        SmallImageKey = "pawnee_dev",
                        SmallImageText = "PawnEE Developper"
                    }
                });
            }
            else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Scripting..",
                    State = "PawnExtremeEditor v1.0",
                    Assets = new Assets()
                    {
                        LargeImageKey = "pawnee_logo",
                        LargeImageText = "PawnEE",
                        SmallImageKey = "user",
                        SmallImageText = "PawnEE User"
                    }
                });
            }

            timer1.Start();
        }
        
        private void menuStrip3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        string pathToFileFV = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (EventHandler.treeViewClick == true)
            {
                EventHandler.treeViewClick = false;
                pathToFileFV = EventHandler.workspaceFilePath + EventHandler.treeViewClickFilePath;
                using (StreamReader sr = new StreamReader(pathToFileFV))
                {
                    TextEditor untitlededit = new TextEditor();
                    untitlededit.Text = EventHandler.treeViewGetFileName;
                    untitlededit.editorText = sr.ReadToEnd();
                    untitlededit.Show(dockPanel1, DockState.Document);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private string fileBeingEdited;
        private void dockPanel1_ActiveDocumentChanged(object sender, EventArgs e)
        {
            string testvt = dockPanel1.ActiveDocument.ToString();
            string[] str = testvt.Split(':');
            string test2 = str[1].Remove(0, 1);
            string[] check = test2.Split('.');

            for (int i = 0; i < check.Length; i++)
            {
                if (i == 1)
                {
                    fileBeingEdited = test2;
                    button4.Enabled = true;
                    button7.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                    button7.Enabled = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        string pathToExe = "";
        private void button10_Click(object sender, EventArgs e)
        {
            pathToExe = Application.StartupPath + "\\tmp\\def.ee";
            using (StreamReader sr = new StreamReader(pathToExe))
            {
                TextEditor untitlededit = new TextEditor();
                untitlededit.Text = "untitled.pwn";
                untitlededit.editorText = sr.ReadToEnd();
                untitlededit.Show(dockPanel1, DockState.Document);
            }
        }
    }
}
