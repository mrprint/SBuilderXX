using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SlimDX;
using SlimDX.Direct3D9;

namespace SBuilderX
{
    public partial class FrmGBuilding
    {
        public FrmGBuilding()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _imgGenB.Name = "imgGenB";
            _optGbMultiSided.Name = "optGbMultiSided";
            _optGbPyramidal.Name = "optGbPyramidal";
            _optGbSlant.Name = "optGbSlant";
            _optGbRidge.Name = "optGbRidge";
            _optGbPeaked.Name = "optGbPeaked";
            _optGbFlat.Name = "optGbFlat";
        }

        private bool FullScreen = false;
        private float Grid = 10.0f;
        private string helpInfo = "Left mouse to rotate. Mouse wheel to zoom (rolling) or to pan (pressing). Right mouse to return.";

        private void CancelCommand(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OKCommand(object sender, EventArgs e)
        {
            moduleOBJECTS.bottomTexture = (int)nUPbottomTexture.Value;
            moduleOBJECTS.roofTexture = (int)nUProofTexture.Value;
            moduleOBJECTS.topTexture = (int)nUPtopTexture.Value;
            moduleOBJECTS.windowTexture = (int)nUPwindowTexture.Value;
            moduleOBJECTS.sizeX = (float)nUPsizeX.Value;
            moduleOBJECTS.sizeZ = (float)nUPsizeZ.Value;
            moduleOBJECTS.scale_gb = (float)nUPscale.Value;
            My.MyProject.Forms.FrmObjectsP.nUPsizeX.Value = (decimal)moduleOBJECTS.sizeX;
            My.MyProject.Forms.FrmObjectsP.nUPsizeZ.Value = (decimal)moduleOBJECTS.sizeZ;
            My.MyProject.Forms.FrmObjectsP.nUPscale.Value = (decimal)moduleOBJECTS.scale_gb;
            if (moduleOBJECTS.BuildingType == 256)
                My.MyProject.Forms.FrmObjectsP.optGbFlat.Checked = true;
            if (moduleOBJECTS.BuildingType == 257)
                My.MyProject.Forms.FrmObjectsP.optGbPeaked.Checked = true;
            if (moduleOBJECTS.BuildingType == 258)
                My.MyProject.Forms.FrmObjectsP.optGbRidge.Checked = true;
            if (moduleOBJECTS.BuildingType == 259)
                My.MyProject.Forms.FrmObjectsP.optGbSlant.Checked = true;
            if (moduleOBJECTS.BuildingType == 260)
                My.MyProject.Forms.FrmObjectsP.optGbPyramidal.Checked = true;
            if (moduleOBJECTS.BuildingType == 261)
                My.MyProject.Forms.FrmObjectsP.optGbMultiSided.Checked = true;
            moduleOBJECTS.sizeBottomY = (float)nUPsizeBottomY.Value;
            moduleOBJECTS.sizeWindowY = (float)nUPsizeWindowY.Value;
            moduleOBJECTS.sizeTopY = (float)nUPsizeTopY.Value;
            moduleOBJECTS.sizeRoofY = (float)nUPsizeRoofY.Value;
            if (moduleOBJECTS.BuildingType == 260)  // pyramidal
            {
                moduleOBJECTS.sizeTopX = (float)nUPsizeTopX.Value;
                moduleOBJECTS.sizeTopZ = (float)nUPsizeTopZ.Value;
            }
            else
            {
                moduleOBJECTS.sizeTopX = sizeTopX_S;
                moduleOBJECTS.sizeTopZ = sizeTopZ_S;
            }

            moduleOBJECTS.textureIndexBottomX = (int)(256m * nUPtextureIndexBottomX.Value);
            moduleOBJECTS.textureIndexBottomZ = (int)(256m * nUPtextureIndexBottomZ.Value);
            moduleOBJECTS.textureIndexWindowX = (int)(256m * nUPtextureIndexWindowX.Value);
            moduleOBJECTS.textureIndexWindowY = (int)(256m * nUPtextureIndexWindowY.Value);
            moduleOBJECTS.textureIndexWindowZ = (int)(256m * nUPtextureIndexWindowZ.Value);
            moduleOBJECTS.textureIndexTopX = (int)(256m * nUPtextureIndexTopZ.Value);
            moduleOBJECTS.textureIndexTopZ = (int)(256m * nUPtextureIndexTopZ.Value);
            moduleOBJECTS.textureIndexRoofX = (int)(256m * nUPtextureIndexRoofX.Value);
            moduleOBJECTS.textureIndexRoofY = (int)(256m * nUPtextureIndexRoofY.Value);
            moduleOBJECTS.textureIndexRoofZ = (int)(256m * nUPtextureIndexRoofZ.Value);
            moduleOBJECTS.gableTexture = (int)nUPgableTexture.Value;
            moduleOBJECTS.textureIndexGableY = (int)(256m * nUPtextureIndexGableY.Value);
            moduleOBJECTS.textureIndexGableZ = (int)(256m * nUPtextureIndexGableZ.Value);
            moduleOBJECTS.faceTexture = (int)nUPfaceTexture.Value;
            moduleOBJECTS.textureIndexFaceX = (int)(256m * nUPtextureIndexFaceX.Value);
            moduleOBJECTS.textureIndexFaceY = (int)(256m * nUPtextureIndexFaceY.Value);
            moduleOBJECTS.buildingSides = (int)nUPbuildingSides.Value;
            moduleOBJECTS.smoothing = ckSmoothing.Checked;
            Dispose();
        }

        private void FrmGBuilding_Load(object sender, EventArgs e)
        {
            nUPsizeX.Value = (decimal)moduleOBJECTS.sizeX;
            nUPsizeZ.Value = (decimal)moduleOBJECTS.sizeZ;
            nUPscale.Value = (decimal)moduleOBJECTS.scale_gb;
            nUPbottomTexture.Value = moduleOBJECTS.bottomTexture;
            nUPwindowTexture.Value = moduleOBJECTS.windowTexture;
            nUPtopTexture.Value = moduleOBJECTS.topTexture;
            nUProofTexture.Value = moduleOBJECTS.roofTexture;
            nUPsizeBottomY.Value = (decimal)moduleOBJECTS.sizeBottomY;
            nUPsizeWindowY.Value = (decimal)moduleOBJECTS.sizeWindowY;
            nUPsizeTopY.Value = (decimal)moduleOBJECTS.sizeTopY;
            nUPsizeRoofY.Value = (decimal)moduleOBJECTS.sizeRoofY;
            nUPsizeTopX.Value = (decimal)moduleOBJECTS.sizeTopX;
            nUPsizeTopZ.Value = (decimal)moduleOBJECTS.sizeTopZ;
            sizeTopX_S = moduleOBJECTS.sizeTopX;
            sizeTopZ_S = moduleOBJECTS.sizeTopZ;
            nUPtextureIndexBottomX.Value = (decimal)(moduleOBJECTS.textureIndexBottomX / 256d);
            nUPtextureIndexBottomZ.Value = (decimal)(moduleOBJECTS.textureIndexBottomZ / 256d);
            nUPtextureIndexWindowX.Value = (decimal)(moduleOBJECTS.textureIndexWindowX / 256d);
            nUPtextureIndexWindowY.Value = (decimal)(moduleOBJECTS.textureIndexWindowY / 256d);
            nUPtextureIndexWindowZ.Value = (decimal)(moduleOBJECTS.textureIndexWindowZ / 256d);
            nUPtextureIndexTopZ.Value = (decimal)(moduleOBJECTS.textureIndexTopX / 256d);
            nUPtextureIndexTopZ.Value = (decimal)(moduleOBJECTS.textureIndexTopZ / 256d);
            nUPtextureIndexRoofX.Value = (decimal)(moduleOBJECTS.textureIndexRoofX / 256d);
            nUPtextureIndexRoofY.Value = (decimal)(moduleOBJECTS.textureIndexRoofY / 256d);
            nUPtextureIndexRoofZ.Value = (decimal)(moduleOBJECTS.textureIndexRoofZ / 256d);
            nUPgableTexture.Value = moduleOBJECTS.gableTexture;
            nUPtextureIndexGableY.Value = (decimal)(moduleOBJECTS.textureIndexGableY / 256d);
            nUPtextureIndexGableZ.Value = (decimal)(moduleOBJECTS.textureIndexGableZ / 256d);
            nUPfaceTexture.Value = moduleOBJECTS.faceTexture;
            nUPtextureIndexFaceX.Value = (decimal)(moduleOBJECTS.textureIndexFaceX / 256d);
            nUPtextureIndexFaceY.Value = (decimal)(moduleOBJECTS.textureIndexFaceY / 256d);
            nUPbuildingSides.Value = moduleOBJECTS.buildingSides;
            ckSmoothing.Checked = moduleOBJECTS.smoothing;
            optGbFlat.Checked = false;
            optGbPeaked.Checked = false;
            optGbRidge.Checked = false;
            optGbSlant.Checked = false;
            optGbPyramidal.Checked = false;
            optGbMultiSided.Checked = false;
            if (moduleOBJECTS.BuildingType == 256)
                optGbFlat.Checked = true;
            if (moduleOBJECTS.BuildingType == 257)
                optGbPeaked.Checked = true;
            if (moduleOBJECTS.BuildingType == 258)
                optGbRidge.Checked = true;
            if (moduleOBJECTS.BuildingType == 259)
                optGbSlant.Checked = true;
            if (moduleOBJECTS.BuildingType == 260)
                optGbPyramidal.Checked = true;
            if (moduleOBJECTS.BuildingType == 261)
                optGbMultiSided.Checked = true;

            // SetBuildingType()  because false >>> true called it already

            LoadGraphics();
        }

        private float sizeTopX_S;   // _S to store 
        private float sizeTopZ_S;

        private void SetBuildingType()
        {
            string A = "";
            if (moduleOBJECTS.BuildingType == 256)
                A = "Rectangular - FLAT roof";
            if (moduleOBJECTS.BuildingType == 257)
                A = "Rectangular - PEAKED roof";
            if (moduleOBJECTS.BuildingType == 258)
                A = "Rectangular - RIDGE roof";
            if (moduleOBJECTS.BuildingType == 259)
                A = "Rectangular - SLANT roof";
            if (moduleOBJECTS.BuildingType == 260)
                A = "Pyramidal Building";
            if (moduleOBJECTS.BuildingType == 261)
                A = "Multi-Sided Building";
            Text = "SBuilderX - Generic Buildings - " + A;
            nUPsizeBottomY.Enabled = false;
            nUPtextureIndexBottomX.Enabled = false;
            nUPtextureIndexBottomZ.Enabled = false;
            nUPsizeWindowY.Enabled = false;
            nUPtextureIndexWindowX.Enabled = false;
            nUPtextureIndexWindowY.Enabled = false;
            nUPtextureIndexWindowZ.Enabled = false;
            nUPsizeTopX.Enabled = false;
            nUPsizeTopY.Enabled = false;
            nUPsizeTopZ.Enabled = false;
            lbTW.Enabled = false;
            lbTD.Enabled = false;
            nUPtextureIndexTopX.Enabled = false;
            nUPtextureIndexTopZ.Enabled = false;
            nUPsizeRoofY.Enabled = false;
            nUPtextureIndexRoofX.Enabled = false;
            nUPtextureIndexRoofY.Enabled = false;
            nUPtextureIndexRoofZ.Enabled = false;
            nUPgableTexture.Enabled = false;
            nUPtextureIndexGableY.Enabled = false;
            nUPtextureIndexGableZ.Enabled = false;
            nUPfaceTexture.Enabled = false;
            nUPtextureIndexFaceX.Enabled = false;
            nUPtextureIndexFaceY.Enabled = false;
            frMulti.Enabled = false;
            nUPbuildingSides.Enabled = false;
            ckSmoothing.Enabled = false;
            nUPWX.Value = nUPsizeX.Value;
            nUPWZ.Value = nUPsizeZ.Value;
            nUPRX.Value = nUPsizeX.Value;
            nUPRZ.Value = nUPsizeZ.Value;
            lbBZT.Enabled = false;
            lbWZT.Enabled = false;
            lbTZT.Enabled = false;
            lbRYT.Enabled = false;
            lbF.Enabled = false;
            lbFXT.Enabled = false;
            lbFYT.Enabled = false;
            lbG.Enabled = false;
            lbGYT.Enabled = false;
            lbGZT.Enabled = false;
            lbRH.Enabled = true;
            if (moduleOBJECTS.BuildingType == 256)
                lbRH.Enabled = false;
            if (moduleOBJECTS.BuildingType == 256 | moduleOBJECTS.BuildingType == 257 | moduleOBJECTS.BuildingType == 258 | moduleOBJECTS.BuildingType == 259)
            // Rect flat
            {
                nUPsizeBottomY.Enabled = true;
                nUPtextureIndexBottomX.Enabled = true;
                nUPtextureIndexBottomZ.Enabled = true;
                nUPsizeWindowY.Enabled = true;
                nUPtextureIndexWindowX.Enabled = true;
                nUPtextureIndexWindowY.Enabled = true;
                nUPtextureIndexWindowZ.Enabled = true;
                nUPsizeTopY.Enabled = true;
                nUPtextureIndexTopX.Enabled = true;
                nUPtextureIndexTopZ.Enabled = true;
                nUPtextureIndexRoofX.Enabled = true;
                nUPtextureIndexRoofZ.Enabled = true;
                lbBZT.Enabled = true;
                lbWZT.Enabled = true;
                lbTZT.Enabled = true;
            }

            if (moduleOBJECTS.BuildingType == 257)  // Rect peaked
            {
                nUPsizeRoofY.Enabled = true;
                nUPtextureIndexRoofY.Enabled = true;
                lbRYT.Enabled = true;
            }

            if (moduleOBJECTS.BuildingType == 258)  // Rect Ridge
            {
                nUPsizeRoofY.Enabled = true;
                nUPgableTexture.Enabled = true;
                nUPtextureIndexGableY.Enabled = true;
                nUPtextureIndexGableZ.Enabled = true;
                lbG.Enabled = true;
                lbGYT.Enabled = true;
                lbGZT.Enabled = true;
            }

            if (moduleOBJECTS.BuildingType == 259)  // Rect slant
            {
                nUPsizeRoofY.Enabled = true;
                nUPgableTexture.Enabled = true;
                nUPtextureIndexGableY.Enabled = true;
                nUPtextureIndexGableZ.Enabled = true;
                nUPfaceTexture.Enabled = true;
                nUPtextureIndexFaceX.Enabled = true;
                nUPtextureIndexFaceY.Enabled = true;
                lbF.Enabled = true;
                lbFXT.Enabled = true;
                lbFYT.Enabled = true;
                lbG.Enabled = true;
                lbGYT.Enabled = true;
                lbGZT.Enabled = true;
            }

            if (moduleOBJECTS.BuildingType == 260)  // pyramidal
            {
                nUPsizeTopX.Enabled = true;
                nUPsizeTopZ.Enabled = true;
                lbTW.Enabled = true;
                lbTD.Enabled = true;
                nUPsizeBottomY.Enabled = true;
                nUPtextureIndexBottomX.Enabled = true;
                nUPtextureIndexBottomZ.Enabled = true;
                nUPsizeWindowY.Enabled = true;
                nUPtextureIndexWindowX.Enabled = true;
                nUPtextureIndexWindowY.Enabled = true;
                nUPtextureIndexWindowZ.Enabled = true;
                nUPsizeTopY.Enabled = true;
                nUPtextureIndexTopX.Enabled = true;
                nUPtextureIndexTopZ.Enabled = true;
                nUPtextureIndexRoofX.Enabled = true;
                nUPtextureIndexRoofZ.Enabled = true;
                lbBZT.Enabled = true;
                lbWZT.Enabled = true;
                lbTZT.Enabled = true;
                lbRH.Enabled = false;
            }

            if (moduleOBJECTS.BuildingType == 261) // multi sided
            {
                frMulti.Enabled = true;
                nUPbuildingSides.Enabled = true;
                ckSmoothing.Enabled = true;
                nUPsizeBottomY.Enabled = true;
                nUPtextureIndexBottomX.Enabled = true;
                nUPsizeWindowY.Enabled = true;
                nUPtextureIndexWindowX.Enabled = true;
                nUPtextureIndexWindowY.Enabled = true;
                nUPsizeTopY.Enabled = true;
                nUPtextureIndexTopX.Enabled = true;
                nUPsizeRoofY.Enabled = true;
                nUPtextureIndexRoofX.Enabled = true;
                nUPtextureIndexRoofY.Enabled = true;
                nUPtextureIndexRoofZ.Enabled = true;
                lbRYT.Enabled = true;
            }

            if (moduleOBJECTS.BuildingType == 260)  // pyramidal
            {
                nUPsizeTopX.Value = (decimal)sizeTopX_S;
                nUPsizeTopZ.Value = (decimal)sizeTopZ_S;
                sizTopX = sizeTopX_S;
                sizTopZ = sizeTopZ_S;
            }
            else
            {
                nUPsizeTopX.Value = nUPsizeX.Value;
                nUPsizeTopZ.Value = nUPsizeZ.Value;
                sizTopX = (float)nUPsizeX.Value;
                sizTopZ = (float)nUPsizeZ.Value;
            }

            if (IsInit)
                return;
            ResetDevice();
        }

        // Our global variables for this project
        private Device renderDevice = null; // Our rendering device
        private VertexBuffer vertexBuffer = null;
        private VertexBuffer vertexBuffer0 = null;

        private struct VertexPT
        {
            public Vector3 Position;
            public Vector2 Texture;
        }

        private struct VertexPC
        {
            public Vector3 Position;
            public int Color;
        }

        private bool pause = false;
        private SlimDX.Direct3D9.Font fntOut;
        private string sDevInfo;
        private Matrix modelMatrix;
        private float modelScale = 1f;
        private float modelAngleX = 0f;
        private float modelAngleY = 0f;
        private float modelPanX = 0f;
        private float modelPanY = 0f;
        private bool IsInit = true;

        private void LoadGraphics()
        {
            SetEvents();
            if (!InitializeGraphics()) // Initialize Direct3D
            {
                MessageBox.Show("Could not initialize slimDX.Direct3D!");
                return;
            }

            Show();
            var s = new object();
            var e = new EventArgs();
            RebuildBuilding(s, e);
            IsInit = false;
            while (Created)
            {
                Render();
                Application.DoEvents();
            }
        }

        private bool InitializeGraphics()
        {
            var d3D = new Direct3D();
            var presentParams = new PresentParameters();
            try
            {
                renderDevice = new Device(d3D, 0, DeviceType.Hardware, imgGenB.Handle, CreateFlags.HardwareVertexProcessing, presentParams);
                ResetDevice();
                LoadTextures();
                SetupMatrices();
                fntOut = new SlimDX.Direct3D9.Font(renderDevice, new System.Drawing.Font("Arial", 10f, FontStyle.Regular));
                // sDevInfo = Manager.Adapters(0).Information.Description

                sDevInfo = "UNKNOWN ADAPTER";
                pause = false;
                return true;
            }
            catch (Direct3D9Exception e)
            {
                return false;
            }
        } // InitializeGraphics

        private void ResetDevice()
        {
            CreateVertexBuffer();
            renderDevice.SetRenderState(RenderState.CullMode, false);
            renderDevice.SetRenderState(RenderState.Lighting, false);
            renderDevice.SetRenderState(RenderState.ZEnable, true);
        }

        private void SetEvents()
        {
            nUPsizeX.ValueChanged += RebuildBuilding;
            nUPsizeZ.ValueChanged += RebuildBuilding;
            nUPsizeBottomY.ValueChanged += RebuildBuilding;
            nUPsizeWindowY.ValueChanged += RebuildBuilding;
            nUPsizeTopY.ValueChanged += RebuildBuilding;
            nUPsizeRoofY.ValueChanged += RebuildBuilding;
            nUPtextureIndexBottomX.ValueChanged += RebuildBuilding;
            nUPtextureIndexBottomZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowX.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowY.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexTopX.ValueChanged += RebuildBuilding;
            nUPtextureIndexTopZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexRoofX.ValueChanged += RebuildBuilding;
            nUPtextureIndexRoofY.ValueChanged += RebuildBuilding;
            nUPtextureIndexRoofZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexGableY.ValueChanged += RebuildBuilding;
            nUPtextureIndexGableZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexFaceX.ValueChanged += RebuildBuilding;
            nUPtextureIndexFaceY.ValueChanged += RebuildBuilding;
            nUPbuildingSides.ValueChanged += RebuildBuilding;
            nUPGrid.ValueChanged += RebuildBuilding;
            nUPbottomTexture.ValueChanged += LoadBottomTexture;
            nUPwindowTexture.ValueChanged += LoadWindowTexture;
            nUPtopTexture.ValueChanged += LoadTopTexture;
            nUProofTexture.ValueChanged += LoadRoofTexture;
            nUPgableTexture.ValueChanged += LoadGableTexture;
            nUPfaceTexture.ValueChanged += LoadFaceTexture;
            cmdCancel.Click += CancelCommand;
            cmdOK.Click += OKCommand;
        }

        // these are local
        private float texIndexBottomX;
        private float texIndexBottomZ;
        private float texIndexWindowX;
        private float texIndexWindowZ;
        private float texIndexWindowY;
        private float texIndexTopX;
        private float texIndexTopZ;
        private float texIndexRoofX;
        private float texIndexRoofY;
        private float texIndexRoofZ;
        private float texIndexGableY;
        private float texIndexGableZ;
        private float texIndexFaceX;
        private float texIndexFaceY;
        private float sizX;
        private float sizZ;
        private float sizTopX;
        private float sizTopZ;
        private float sizBottomY;
        private float sizWindowY;
        private float sizTopY;
        private float sizRoofY;
        private int sides;

        private void RebuildBuilding(object sender, EventArgs e)
        {
            Grid = (float)nUPGrid.Value;
            sizX = (float)nUPsizeX.Value;
            sizZ = (float)nUPsizeZ.Value;
            if (moduleOBJECTS.BuildingType == 260)  // pyramidal
            {
                sizTopX = (float)nUPsizeTopX.Value;
                sizTopZ = (float)nUPsizeTopZ.Value;
            }
            else
            {
                sizTopX = (float)nUPsizeX.Value;
                sizTopZ = (float)nUPsizeZ.Value;
            }

            nUPWX.Value = nUPsizeX.Value;
            nUPWZ.Value = nUPsizeZ.Value;
            nUPRX.Value = nUPsizeX.Value;
            nUPRZ.Value = nUPsizeZ.Value;
            sizBottomY = (float)nUPsizeBottomY.Value;
            sizWindowY = (float)nUPsizeWindowY.Value;
            sizTopY = (float)nUPsizeTopY.Value;
            sizRoofY = (float)nUPsizeRoofY.Value;
            texIndexBottomX = (float)nUPtextureIndexBottomX.Value;
            texIndexBottomZ = (float)nUPtextureIndexBottomZ.Value;
            texIndexWindowX = (float)nUPtextureIndexWindowX.Value;
            texIndexWindowY = (float)nUPtextureIndexWindowY.Value;
            texIndexWindowZ = (float)nUPtextureIndexWindowZ.Value;
            texIndexTopX = (float)nUPtextureIndexTopX.Value;
            texIndexTopZ = (float)nUPtextureIndexTopZ.Value;
            texIndexRoofX = (float)nUPtextureIndexRoofX.Value;
            texIndexRoofY = (float)nUPtextureIndexRoofY.Value;
            texIndexRoofZ = (float)nUPtextureIndexRoofZ.Value;
            texIndexGableY = (float)nUPtextureIndexGableY.Value;
            texIndexGableZ = (float)nUPtextureIndexGableZ.Value;
            texIndexFaceX = (float)nUPtextureIndexFaceX.Value;
            texIndexFaceY = (float)nUPtextureIndexFaceY.Value;
            sides = (int)nUPbuildingSides.Value;
            ResetDevice();
        }

        private void CreateVertexBuffer()
        {
            int N;

            // never we have 300 vertices; they are i at the end
            var v = new VertexPT[301];
            int i = 0;
            float sX0, sX1, y0, y1, sZ0, sZ1, tX, tY, tZ, gY, gZ, fX, fY;
            float t0 = 0f;
            float t1 = 1f;
            float tb = 0f;
            float tw = 0f;
            if (nUPbottomTexture.Value > 85m)
                tb = 0.5f;
            if (nUPwindowTexture.Value > 84m)
                tw = 0.5f;
            float rX, rZ;
            y0 = -(sizBottomY + sizWindowY + sizTopY) / 2.0f;
            if (moduleOBJECTS.BuildingType == 261)  // multisided
            {
                rX = sizX / 2f;
                rZ = sizZ / 2f;
                float pi1 = (float)(moduleMAIN.PI / sides);
                float pi2 = pi1 * 2f;
                // bottom
                y1 = y0 + sizBottomY;
                tX = texIndexBottomX;
                if (sizBottomY > 0f)
                {
                    var loopTo = sides;
                    for (N = 1; N <= loopTo; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N - 1) * pi2 - pi1));
                        sX1 = (float)(rX * Math.Cos(N * pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N - 1) * pi2 - pi1));
                        sZ1 = (float)(rZ * Math.Sin(N * pi2 - pi1));
                        v[i + 0] = VPT(sX0, y0, sZ0, t0, t0);
                        v[i + 1] = VPT(sX0, y1, sZ0, t0, t1);
                        v[i + 2] = VPT(sX1, y1, sZ1, tX, t1);
                        v[i + 3] = VPT(sX1, y0, sZ1, tX, t0);
                        i = i + 4;
                    }
                }

                y0 = y1;
                y1 = y0 + sizWindowY;
                tX = texIndexWindowX;
                tY = texIndexWindowY;
                if (sizWindowY > 0f)
                {
                    var loopTo1 = sides;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N - 1) * pi2 - pi1));
                        sX1 = (float)(rX * Math.Cos(N * pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N - 1) * pi2 - pi1));
                        sZ1 = (float)(rZ * Math.Sin(N * pi2 - pi1));
                        v[i + 0] = VPT(sX0, y0, sZ0, t0, t0);
                        v[i + 1] = VPT(sX0, y1, sZ0, t0, tY);
                        v[i + 2] = VPT(sX1, y1, sZ1, tX, tY);
                        v[i + 3] = VPT(sX1, y0, sZ1, tX, t0);
                        i = i + 4;
                    }
                }

                y0 = y1;
                y1 = y0 + sizTopY;
                tX = texIndexTopX;
                if (sizTopY > 0f)
                {
                    var loopTo2 = sides;
                    for (N = 1; N <= loopTo2; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N - 1) * pi2 - pi1));
                        sX1 = (float)(rX * Math.Cos(N * pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N - 1) * pi2 - pi1));
                        sZ1 = (float)(rZ * Math.Sin(N * pi2 - pi1));
                        v[i + 0] = VPT(sX0, y0, sZ0, t0, t0);
                        v[i + 1] = VPT(sX0, y1, sZ0, t0, t1);
                        v[i + 2] = VPT(sX1, y1, sZ1, tX, t1);
                        v[i + 3] = VPT(sX1, y0, sZ1, tX, t0);
                        i = i + 4;
                    }
                }

                // roof of multised
                y0 = y1;
                y1 = y0 + sizRoofY;
                tX = texIndexRoofX;
                tZ = texIndexRoofZ;
                var loopTo3 = sides;
                for (N = 1; N <= loopTo3; N++)
                {
                    sX0 = (float)(rX * Math.Cos((N - 1) * pi2 - pi1));
                    sX1 = (float)(rX * Math.Cos(N * pi2 - pi1));
                    sZ0 = (float)(rZ * Math.Sin((N - 1) * pi2 - pi1));
                    sZ1 = (float)(rZ * Math.Sin(N * pi2 - pi1));
                    v[i + 0] = VPT(sX0, y0, sZ0, t0, t0);
                    v[i + 1] = VPT(0f, y1, 0f, tX / 2f, tZ);
                    v[i + 2] = VPT(sX1, y0, sZ1, tX, t0);
                    i = i + 3;
                }
            }
            else  // non multisided
            {
                sX0 = sizX / 2f;
                sX1 = sizX / 2f;
                sZ0 = sizZ / 2f;
                sZ1 = sizZ / 2f;

                // bottom
                y1 = y0 + sizBottomY;
                tX = texIndexBottomX;
                tZ = texIndexBottomZ;
                if (sizBottomY > 0f)
                {
                    v[i + 0] = VPT(-sX0, y0, -sZ0, t0, t0);  // frontX
                    v[i + 1] = VPT(-sX1, y1, -sZ1, t0, t1);
                    v[i + 2] = VPT(+sX1, y1, -sZ1, tX, t1);
                    v[i + 3] = VPT(+sX0, y0, -sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, tb, t0);  // rightZ
                    v[i + 1] = VPT(+sX1, y1, -sZ1, tb, t1);
                    v[i + 2] = VPT(+sX1, y1, +sZ1, tZ, t1);
                    v[i + 3] = VPT(+sX0, y0, +sZ0, tZ, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);  // backX
                    v[i + 1] = VPT(+sX1, y1, +sZ1, t0, t1);
                    v[i + 2] = VPT(-sX1, y1, +sZ1, tX, t1);
                    v[i + 3] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, tb, t0);  // leftZ
                    v[i + 1] = VPT(-sX1, y1, +sZ1, tb, t1);
                    v[i + 2] = VPT(-sX1, y1, -sZ1, tZ, t1);
                    v[i + 3] = VPT(-sX0, y0, -sZ0, tZ, t0);
                    i = i + 4;
                }

                // window
                y0 = y1;
                y1 = y0 + sizWindowY;
                tX = texIndexWindowX;
                tZ = texIndexWindowZ;
                tY = texIndexWindowY;
                if (sizWindowY > 0f)
                {
                    v[i + 0] = VPT(-sX0, y0, -sZ0, tw, t0);  // frontX
                    v[i + 1] = VPT(-sX1, y1, -sZ1, tw, tY);
                    v[i + 2] = VPT(+sX1, y1, -sZ1, tX, tY);
                    v[i + 3] = VPT(+sX0, y0, -sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(+sX1, y1, -sZ1, t0, tY);
                    v[i + 2] = VPT(+sX1, y1, +sZ1, tZ, tY);
                    v[i + 3] = VPT(+sX0, y0, +sZ0, tZ, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(+sX1, y1, +sZ1, t0, tY);
                    v[i + 2] = VPT(-sX1, y1, +sZ1, tX, tY);
                    v[i + 3] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(-sX1, y1, +sZ1, t0, tY);
                    v[i + 2] = VPT(-sX1, y1, -sZ1, tZ, tY);
                    v[i + 3] = VPT(-sX0, y0, -sZ0, tZ, t0);
                    i = i + 4;
                }

                // top
                // sX0 = sizX / 2
                sX1 = sizTopX / 2f;
                // sZ0 = sizZ / 2
                sZ1 = sizTopZ / 2f;
                y0 = y1;
                y1 = y0 + sizTopY;
                tX = texIndexTopX;
                tZ = texIndexTopZ;
                if (sizTopY > 0f)
                {
                    v[i + 0] = VPT(-sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(-sX1, y1, -sZ1, t0, t1);
                    v[i + 2] = VPT(+sX1, y1, -sZ1, tX, t1);
                    v[i + 3] = VPT(+sX0, y0, -sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(+sX1, y1, -sZ1, t0, t1);
                    v[i + 2] = VPT(+sX1, y1, +sZ1, tZ, t1);
                    v[i + 3] = VPT(+sX0, y0, +sZ0, tZ, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(+sX1, y1, +sZ1, t0, t1);
                    v[i + 2] = VPT(-sX1, y1, +sZ1, tX, t1);
                    v[i + 3] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(-sX1, y1, +sZ1, t0, t1);
                    v[i + 2] = VPT(-sX1, y1, -sZ1, tZ, t1);
                    v[i + 3] = VPT(-sX0, y0, -sZ0, tZ, t0);
                    i = i + 4;
                }

                if (moduleOBJECTS.BuildingType == 256 | moduleOBJECTS.BuildingType == 260)   // flat or pyramid
                {
                    sX0 = sizTopX / 2f;
                    sZ0 = sizTopZ / 2f;
                    y0 = y1;
                    // y1 = y0 + sizRoofY
                    tX = texIndexRoofX;
                    tZ = texIndexRoofZ;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, tZ);
                    v[i + 1] = VPT(+sX0, y0, +sZ0, tX, tZ);
                    v[i + 2] = VPT(+sX0, y0, -sZ0, tX, t0);
                    v[i + 3] = VPT(-sX0, y0, -sZ0, t0, t0);
                    i = i + 4;
                }

                if (moduleOBJECTS.BuildingType == 257)   // peaked
                {
                    sX0 = sizTopX / 2f;
                    sZ0 = sizTopZ / 2f;
                    y0 = y1;
                    y1 = y0 + sizRoofY;
                    tX = texIndexRoofX;
                    tZ = texIndexRoofZ;
                    tY = texIndexRoofY;
                    v[i + 0] = VPT(-sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(0f, y1, 0f, tX / 2f, tY);
                    v[i + 2] = VPT(+sX0, y0, -sZ0, tX, t0);
                    i = i + 3;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(0f, y1, 0f, tZ / 2f, tY);
                    v[i + 2] = VPT(+sX0, y0, +sZ0, tZ, t0);
                    i = i + 3;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(0f, y1, 0f, tX / 2f, tY);
                    v[i + 2] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 3;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(0f, y1, 0f, tZ / 2f, tY);
                    v[i + 2] = VPT(-sX0, y0, -sZ0, tZ, t0);
                    i = i + 3;
                }

                if (moduleOBJECTS.BuildingType == 258)   // ridge
                {
                    sX0 = sizTopX / 2f;
                    sZ0 = sizTopZ / 2f;
                    y0 = y1;
                    y1 = y0 + sizRoofY;
                    tX = texIndexRoofX;
                    tZ = texIndexRoofZ;
                    gY = texIndexGableY;
                    gZ = texIndexGableZ;
                    v[i + 0] = VPT(-sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(-sX0, y1, 0f, t0, tZ);
                    v[i + 2] = VPT(+sX0, y1, 0f, tX, tZ);
                    v[i + 3] = VPT(+sX0, y0, -sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(+sX0, y1, 0f, t0, tZ);
                    v[i + 2] = VPT(-sX0, y1, 0f, tX, tZ);
                    v[i + 3] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(+sX0, y1, 0f, gZ / 2f, gY);
                    v[i + 2] = VPT(+sX0, y0, +sZ0, gZ, t0);
                    i = i + 3;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(-sX0, y1, 0f, gZ / 2f, gY);
                    v[i + 2] = VPT(-sX0, y0, -sZ0, gZ, t0);
                    i = i + 3;
                }

                if (moduleOBJECTS.BuildingType == 259)   // slant
                {
                    sX0 = sizTopX / 2f;
                    sZ0 = sizTopZ / 2f;
                    y0 = y1;
                    y1 = y0 + sizRoofY;
                    tX = texIndexRoofX;
                    tZ = texIndexRoofZ;
                    gY = texIndexGableY;
                    gZ = texIndexGableZ;
                    fX = texIndexFaceX;
                    fY = texIndexFaceY;
                    v[i + 0] = VPT(-sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(-sX0, y1, -sZ0, t0, fY);
                    v[i + 2] = VPT(+sX0, y1, -sZ0, fX, fY);
                    v[i + 3] = VPT(+sX0, y0, -sZ0, fX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(+sX0, y1, -sZ0, t0, tZ);
                    v[i + 2] = VPT(-sX0, y1, -sZ0, tX, tZ);
                    v[i + 3] = VPT(-sX0, y0, +sZ0, tX, t0);
                    i = i + 4;
                    v[i + 0] = VPT(+sX0, y0, -sZ0, t0, t0);
                    v[i + 1] = VPT(+sX0, y1, -sZ0, t0, gY);
                    v[i + 2] = VPT(+sX0, y0, +sZ0, gZ, t0);
                    i = i + 3;
                    v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);
                    v[i + 1] = VPT(-sX0, y1, -sZ0, gZ, gY);
                    v[i + 2] = VPT(-sX0, y0, -sZ0, gZ, t0);
                    i = i + 3;
                }
            }


            // base
            sX0 = sizX / 2f;
            sZ0 = sizZ / 2f;
            y0 = -(sizBottomY + sizWindowY + sizTopY) / 2.0f;
            v[i + 0] = VPT(-sX0, y0, +sZ0, t0, t0);    // seen from underneath
            v[i + 1] = VPT(-sX0, y0, -sZ0, t0, t1);
            v[i + 2] = VPT(+sX0, y0, -sZ0, t1, t1);
            v[i + 3] = VPT(+sX0, y0, +sZ0, t1, t0);
            i = i + 4;
            Array.Resize(ref v, i);
            int sizeVector = Marshal.SizeOf(typeof(VertexPT));
            // MsgBox(i.ToString & "  " & sizeVector.ToString) ' size vector should be 20 (in bytes)

            vertexBuffer = new VertexBuffer(renderDevice, sizeVector * i, Usage.WriteOnly, VertexFormat.Position | VertexFormat.Texture2, Pool.Managed);
            var stream = vertexBuffer.Lock(0, 0, LockFlags.None);
            stream.WriteRange(v);
            vertexBuffer.Unlock();
            var C = Color.White;

            // this time there will be 43 vertices, no need to ReDim!
            var v0 = new VertexPC[44];
            i = -1;
            sX0 = -6 * Grid;
            sZ0 = -5 * Grid;
            sZ1 = 5f * Grid;
            for (N = 1; N <= 11; N++)
            {
                i += 1;
                sX0 += Grid;
                v0[i] = VPC(sX0, y0, sZ0, C);
                i += 1;
                v0[i] = VPC(sX0, y0, sZ1, C);
            }

            sX0 = -5 * Grid;
            sX1 = 5f * Grid;
            sZ0 = -6 * Grid;
            for (N = 1; N <= 11; N++)
            {
                i += 1;
                sZ0 += Grid;
                v0[i] = VPC(sX0, y0, sZ0, C);
                i += 1;
                v0[i] = VPC(sX1, y0, sZ0, C);
            }

            // ReDim Preserve v0(i - 1)

            int red = Color.Red.ToArgb();
            v0[10].Color = red;
            v0[11].Color = red;
            int green = Color.Green.ToArgb();
            v0[32].Color = green;
            v0[33].Color = green;
            sizeVector = Marshal.SizeOf(typeof(VertexPC));
            // MsgBox(i.ToString & "  " & sizeVector.ToString)
            vertexBuffer0 = new VertexBuffer(renderDevice, sizeVector * 44, Usage.WriteOnly, VertexFormat.Position | VertexFormat.Diffuse, Pool.Managed);
            var stream0 = vertexBuffer0.Lock(0, 0, LockFlags.None);
            stream0.WriteRange(v0);
            vertexBuffer0.Unlock();
        } // OnCreateVertexBuffer

        private VertexPT VPT(float x1, float x2, float x3, float x4, float x5)
        {
            VertexPT VPTRet = default;
            VPTRet.Position = new Vector3(x1, x2, x3);
            VPTRet.Texture = new Vector2(x4, x5);
            return VPTRet;
        }

        private VertexPC VPC(float x1, float x2, float x3, Color x4)
        {
            VertexPC VPCRet = default;
            VPCRet.Position = new Vector3(x1, x2, x3);
            VPCRet.Color = x4.ToArgb();
            return VPCRet;
        }

        private void Render()
        {
            int N;
            if (pause)
            {
                return;
            }

            renderDevice.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.SkyBlue, 1.0f, 0);
            renderDevice.BeginScene();
            modelMatrix = Matrix.Scaling(modelScale, modelScale, modelScale);
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.RotationX((float)(modelAngleX * (Math.PI / 180d))));
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.RotationY((float)(modelAngleY * (Math.PI / 180d))));
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.Translation(modelPanX, modelPanY, 0f));
            renderDevice.SetTransform(TransformState.World, modelMatrix);
            renderDevice.SetStreamSource(0, vertexBuffer, 0, 20);
            renderDevice.VertexFormat = VertexFormat.Position | VertexFormat.Texture2;
            int i = 0;
            if (moduleOBJECTS.BuildingType == 261)  // multisided
            {
                if (sizBottomY > 0f)
                {
                    renderDevice.SetTexture(0, textureB);
                    var loopTo = sides;
                    for (N = 1; N <= loopTo; N++)
                    {
                        renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                        i = i + 4;
                    }
                }

                if (sizWindowY > 0f)
                {
                    renderDevice.SetTexture(0, textureW);
                    var loopTo1 = sides;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                        i = i + 4;
                    }
                }

                if (sizTopY > 0f)
                {
                    renderDevice.SetTexture(0, textureT);
                    var loopTo2 = sides;
                    for (N = 1; N <= loopTo2; N++)
                    {
                        renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                        i = i + 4;
                    }
                }

                renderDevice.SetTexture(0, textureR);
                var loopTo3 = sides;
                for (N = 1; N <= loopTo3; N++)
                {
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 1);
                    i = i + 3;
                }
            }
            else  // non multisided
            {
                if (sizBottomY > 0f)
                {
                    renderDevice.SetTexture(0, textureB);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 4, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 8, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 12, 2);
                    i = i + 16;
                }

                if (sizWindowY > 0f)
                {
                    renderDevice.SetTexture(0, textureW);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 4, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 8, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 12, 2);
                    i = i + 16;
                }

                if (sizTopY > 0f)
                {
                    renderDevice.SetTexture(0, textureT);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 4, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 8, 2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 12, 2);
                    i = i + 16;
                }

                if (moduleOBJECTS.BuildingType == 256 | moduleOBJECTS.BuildingType == 260)
                {
                    // flat roof
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    i = i + 4;
                }

                if (moduleOBJECTS.BuildingType == 257)
                {
                    // peak roof
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 4);
                    i = i + 12;
                }

                if (moduleOBJECTS.BuildingType == 258)
                {
                    // ridg roof
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    i = i + 4;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    i = i + 4;
                    renderDevice.SetTexture(0, textureG);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 1);
                    i = i + 3;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 1);
                    i = i + 3;
                }

                if (moduleOBJECTS.BuildingType == 259)
                {
                    // slant roof
                    renderDevice.SetTexture(0, textureF);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    i = i + 4;
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
                    i = i + 4;
                    renderDevice.SetTexture(0, textureG);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 1);
                    i = i + 3;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i + 0, 1);
                    i = i + 3;
                }
            }

            // base
            renderDevice.SetTexture(0, texture0);
            renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i + 0, 2);
            i = i + 4;

            // size of VectorPC is 16
            renderDevice.SetStreamSource(0, vertexBuffer0, 0, 16);
            renderDevice.VertexFormat = VertexFormat.Position | VertexFormat.Diffuse;
            renderDevice.SetTexture(0, null);
            renderDevice.SetTextureStageState(0, TextureStage.ColorOperation, 4);
            renderDevice.DrawPrimitives(PrimitiveType.LineList, 0, 22);

            // fntOut.DrawString(Nothing, sDevInfo, 5, 5, Color.DarkBlue)
            if (FullScreen)
            {
                fntOut.DrawString(null, helpInfo, 5, 5, Color.DarkBlue);
            }

            renderDevice.EndScene();
            renderDevice.Present();
        } // Render

        private void SetupMatrices()
        {
            modelScale = moduleOBJECTS.sizeX;
            if (moduleOBJECTS.sizeZ > modelScale)
                modelScale = moduleOBJECTS.sizeZ;
            modelScale = 5.0f / modelScale;
            renderDevice.SetTransform(TransformState.World, Matrix.Scaling(modelScale, modelScale, modelScale));
            renderDevice.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0f, 0f, -10), new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f)));
            renderDevice.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH((float)(Math.PI / 4d), (float)(4d / 3d), 1f, 100f));
        } // SetupMatrices

        private string texFolder = Application.StartupPath + @"\Tools\GenB\";
        private Texture textureB = null;

        private void LoadBottomTexture(object sender, EventArgs e)
        {
            string textB = Strings.Trim(nUPbottomTexture.Value.ToString());
            string textBfile = texFolder + "bottom" + textB + ".jpg";
            try
            {
                textureB = Texture.FromFile(renderDevice, textBfile);
            }
            catch (Exception ex)
            {
                textureB = Texture.FromFile(renderDevice, texFolder + "bottom00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture textureW = null;

        private void LoadWindowTexture(object sender, EventArgs e)
        {
            string textW = Strings.Trim(nUPwindowTexture.Value.ToString());
            string textWfile = texFolder + "window" + textW + ".jpg";
            try
            {
                textureW = Texture.FromFile(renderDevice, textWfile);
            }
            catch (Exception ex)
            {
                textureW = Texture.FromFile(renderDevice, texFolder + "window00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture textureT = null;

        private void LoadTopTexture(object sender, EventArgs e)
        {
            string textT = Strings.Trim(nUPtopTexture.Value.ToString());
            string textTfile = texFolder + "top" + textT + ".jpg";
            try
            {
                textureT = Texture.FromFile(renderDevice, textTfile);
            }
            catch (Exception ex)
            {
                textureT = Texture.FromFile(renderDevice, texFolder + "top00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture textureR = null;

        private void LoadRoofTexture(object sender, EventArgs e)
        {
            string textR = Strings.Trim(nUProofTexture.Value.ToString());
            string textRfile = texFolder + "roof" + textR + ".jpg";
            try
            {
                textureR = Texture.FromFile(renderDevice, textRfile);
            }
            catch (Exception ex)
            {
                textureR = Texture.FromFile(renderDevice, texFolder + "roof00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture textureF = null;

        private void LoadFaceTexture(object sender, EventArgs e)
        {
            string textFfile;
            int T = (int)nUPfaceTexture.Value;
            if (T >= 1000)
            {
                textFfile = texFolder + "window" + Strings.Trim((T - 1000).ToString()) + ".jpg";
            }
            else
            {
                textFfile = texFolder + "face" + Strings.Trim(T.ToString()) + ".jpg";
            }

            try
            {
                textureF = Texture.FromFile(renderDevice, textFfile);
            }
            catch (Exception ex)
            {
                textureF = Texture.FromFile(renderDevice, texFolder + "face00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture textureG = null;

        private void LoadGableTexture(object sender, EventArgs e)
        {
            string textGfile;
            int T = (int)nUPgableTexture.Value;
            if (T >= 1000)
            {
                textGfile = texFolder + "window" + Strings.Trim((T - 1000).ToString()) + ".jpg";
            }
            else
            {
                textGfile = texFolder + "gable" + Strings.Trim(T.ToString()) + ".jpg";
            }

            try
            {
                textureG = Texture.FromFile(renderDevice, textGfile);
            }
            catch (Exception ex)
            {
                textureG = Texture.FromFile(renderDevice, texFolder + "gable00.jpg");
            }

            RebuildBuilding(sender, e);
        }

        private Texture texture0 = null;

        private void LoadTextures()
        {
            texture0 = Texture.FromFile(renderDevice, texFolder + "base00.jpg");
            string textB = Strings.Trim(nUPbottomTexture.Value.ToString());
            string textBfile = texFolder + "bottom" + textB + ".jpg";
            try
            {
                textureB = Texture.FromFile(renderDevice, textBfile);
            }
            catch (Exception ex)
            {
                textureB = Texture.FromFile(renderDevice, texFolder + "bottom00.jpg");
            }

            string textW = Strings.Trim(nUPwindowTexture.Value.ToString());
            string textWfile = texFolder + "window" + textW + ".jpg";
            try
            {
                textureW = Texture.FromFile(renderDevice, textWfile);
            }
            catch (Exception ex)
            {
                textureW = Texture.FromFile(renderDevice, texFolder + "window00.jpg");
            }

            string textT = Strings.Trim(nUPtopTexture.Value.ToString());
            string textTfile = texFolder + "top" + textT + ".jpg";
            try
            {
                textureT = Texture.FromFile(renderDevice, textTfile);
            }
            catch (Exception ex)
            {
                textureT = Texture.FromFile(renderDevice, texFolder + "top00.jpg");
            }

            string textR = Strings.Trim(nUProofTexture.Value.ToString());
            string textRfile = texFolder + "roof" + textR + ".jpg";
            try
            {
                textureR = Texture.FromFile(renderDevice, textRfile);
            }
            catch (Exception ex)
            {
                textureR = Texture.FromFile(renderDevice, texFolder + "roof00.jpg");
            }

            string textFfile;
            int T = (int)nUPfaceTexture.Value;
            if (T >= 1000)
            {
                textFfile = texFolder + "window" + Strings.Trim((T - 1000).ToString()) + ".jpg";
            }
            else
            {
                textFfile = texFolder + "face" + Strings.Trim(T.ToString()) + ".jpg";
            }

            try
            {
                textureF = Texture.FromFile(renderDevice, textFfile);
            }
            catch (Exception ex)
            {
                textureF = Texture.FromFile(renderDevice, texFolder + "face00.jpg");
            }

            string textGfile;
            T = (int)nUPgableTexture.Value;
            if (T >= 1000)
            {
                textGfile = texFolder + "window" + Strings.Trim((T - 1000).ToString()) + ".jpg";
            }
            else
            {
                textGfile = texFolder + "gable" + Strings.Trim(T.ToString()) + ".jpg";
            }

            try
            {
                textureG = Texture.FromFile(renderDevice, textGfile);
            }
            catch (Exception ex)
            {
                textureG = Texture.FromFile(renderDevice, texFolder + "gable00.jpg");
            }
        }

        private int PanX;
        private int PanY;
        private int MouseX;
        private int MouseY;
        private float AngleX;
        private float AngleY;
        private bool modelMove = false;
        private bool modelPan = false;
        private Point ImgLoc = new Point(323, 238);
        private Size ImgSiz = new Size(286, 252);

        private void ImgGenB_MouseDown(object sender, MouseEventArgs e)
        {
            int Button = (int)e.Button / 0x100000;
            if (Button == 1)
            {
                MouseX = e.X;
                MouseY = e.Y;
                AngleX = modelAngleX;
                AngleY = modelAngleY;
                modelMove = true;
            }
            else if (Button == 4)
            {
                MouseX = e.X;
                MouseY = e.Y;
                PanX = (int)modelPanX;
                PanY = (int)modelPanY;
                modelPan = true;
            }
            else if (Button == 2)
            {
                Hide();
                if (FullScreen)
                {
                    imgGenB.Location = ImgLoc;
                    imgGenB.Size = ImgSiz;
                }
                else
                {
                    imgGenB.Location = new Point(0, 0);
                    imgGenB.Size = new Size(Size.Width, Size.Height);
                }

                FullScreen = !FullScreen;
                IsInit = true;
                renderDevice.Dispose();
                LoadGraphics();
            }
        }

        private void ImgGenB_MouseHover(object sender, EventArgs e)
        {
            imgGenB.Focus();
        }

        private void ImgGenB_MouseMove(object sender, MouseEventArgs e)
        {
            if (modelMove == true)
            {
                modelAngleY = AngleY + (MouseX - e.X) * 2f;
                modelAngleX = AngleX - (e.Y - MouseY) * 2f;
            }

            if (modelPan)
            {
                modelPanY = PanY + (MouseY - e.Y) / 30f;
                modelPanX = PanX + (e.X - MouseX) / 30f;
                if (modelPanY > 3f)
                    modelPanY = 3f;
                if (modelPanY < -3)
                    modelPanY = -3;
                if (modelPanX > 3f)
                    modelPanX = 3f;
                if (modelPanX < -3)
                    modelPanX = -3;
            }
        }

        private void ImgGenB_MouseUp(object sender, MouseEventArgs e)
        {
            modelMove = false;
            modelPan = false;
        }

        private void ImgGenB_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                modelScale = modelScale * 1.5f;
            }

            if (e.Delta < 0)
            {
                modelScale = modelScale / 1.5f;
            }
        }

        private void CmdCancel_MouseHover(object sender, EventArgs e)
        {
            cmdCancel.Focus();
        }

        private void OptGbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbFlat.Checked)
            {
                moduleOBJECTS.BuildingType = 256;
                SetBuildingType();
            }
        }

        private void OptGbPeaked_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbPeaked.Checked)
            {
                moduleOBJECTS.BuildingType = 257;
                SetBuildingType();
            }
        }

        private void OptGbRidge_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbRidge.Checked)
            {
                moduleOBJECTS.BuildingType = 258;
                SetBuildingType();
            }
        }

        private void OptGbSlant_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbSlant.Checked)
            {
                moduleOBJECTS.BuildingType = 259;
                SetBuildingType();
            }
        }

        private void OptGbPyramidal_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbPyramidal.Checked)
            {
                moduleOBJECTS.BuildingType = 260;
                SetBuildingType();
            }
        }

        private void OptGbMultiSided_CheckedChanged(object sender, EventArgs e)
        {
            if (optGbMultiSided.Checked)
            {
                moduleOBJECTS.BuildingType = 261;
                SetBuildingType();
            }
        }
    }
}