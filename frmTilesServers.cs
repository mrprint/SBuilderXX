using System;

namespace SBuilderXX
{
    public partial class frmTilesServers
    {
        public frmTilesServers()
        {
            InitializeComponent();
            _ListMapServers.Name = "ListMapServers";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
        }

        private void frmTilesServers_Load(object sender, EventArgs e)
        {
            string A = "TileServer plug-ins that conform to the  ";
            A = A + "SBuilderXX TileServer Interface can generate ";
            A = A + "image backgrounds. You should comply with ";
            A = A + "any copyrights that such images may hold.";
            Label1.Text = A;
            if (moduleTILES.NoOfServerTypes > 0)
            {
                ListMapServers.Enabled = true;
                ckMapServer.Enabled = true;
            }
            else
            {
                ckMapServer.Text = "No Map Server detected!";
                ListMapServers.Enabled = false;
                ckMapServer.Enabled = false;
                return;
            }

            int N, K;
            K = 0;
            int loopTo = moduleTILES.NoOfServerTypes;
            for (N = 1; N <= loopTo; N++)
            {
                ListMapServers.Items.Add(moduleTILES.ServerTypes[N].Name);
                if ((moduleTILES.ServerTypes[N].Name ?? "") == (moduleTILES.ActiveTileFolder ?? ""))
                    K = N;
            }

            if (K > 0)
            {
                ckMapServer.Checked = true;
                ListMapServers.SelectedIndex = K - 1;
                ckMapServer.Text = "Use " + moduleTILES.ServerTypes[K].Name + " ?";
            }
            else
            {
                ListMapServers.SelectedIndex = 0;
                ckMapServer.Checked = false;
                moduleTILES.ActiveTileFolder = "";
                // WriteTilesSettings()
                // WriteSettings()
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            int K = default(int);
            moduleTILES.ActiveTileFolder = "";
            moduleTILES.TileServer = null;
            moduleTILES.TilesDownloading.Clear();
            moduleTILES.TilesFailed.Clear();
            lock (moduleTILES.ttcLock)
            {
                moduleTILES.TilesToCome = 0;
            }
            foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(moduleMAIN.AppPath + @"\Tiles", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "L*"))
                My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
            if (ListMapServers.Enabled)
            {
                K = ListMapServers.SelectedIndex + 1;
                if (ckMapServer.Checked)
                    moduleTILES.ActiveTileFolder = moduleTILES.ServerTypes[K].Name;
            }

            if (!string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
            {
                My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Enabled = true;
                moduleTILES.TileServer = (TileServer.IServer)Activator.CreateInstance(moduleTILES.ServerTypes[K]);
                moduleTILES.MaximumZoom = moduleTILES.TileServer.MaximumZoom;
            }
            else
            {
                moduleTILES.TileVIEW = false;
                My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Checked = false;
                My.MyProject.Forms.FrmStart.FromBackgroundMapMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Enabled = false;
            }

            My.MyProject.Forms.FrmStart.MakeBackground();
            moduleMAIN.RebuildDisplay();
            moduleFILE_IO.WriteSettings();
            Dispose();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ListMapServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LT;
            LT = ListMapServers.SelectedIndex + 1;
            ckMapServer.Text = "Use " + moduleTILES.ServerTypes[LT].Name + " ?";
        }
    }
}