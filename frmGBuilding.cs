using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DXColor  = SharpDX.Mathematics.Interop.RawColorBGRA;
using DXPoint  = SharpDX.Point;
using GDIPoint = System.Drawing.Point;
using GDISize  = System.Drawing.Size;
using GDIColor = System.Drawing.Color;

// ---------------------------------------------------------------------------
//  NuGet packages (replace SlimDX):
//
//    <PackageReference Include="SharpDX"              Version="4.2.0" />
//    <PackageReference Include="SharpDX.Direct3D9"    Version="4.2.0" />
//    <PackageReference Include="SharpDX.Mathematics"  Version="4.2.0" />
//
//  SharpDX is a near 1:1 replacement for SlimDX. The original TriangleFan,
//  VertexBuffer, Texture, Matrix (left-handed) and render loop logic are
//  all preserved exactly. The main API differences from SlimDX are:
//
//  1. Direct3D constructor:  new Direct3D()  (same)
//  2. Device constructor:    takes Direct3D as first arg (same)
//  3. DataStream:            stream.Write(v) instead of stream.WriteRange(v)
//  4. Font constructor:      new Font(device, height, width, weight, ...)
//  5. Result/error handling: SharpDX throws SharpDXException not Direct3D9Exception
//  6. Color:                 SharpDX.ColorBGRA instead of System.Drawing.Color
//     for Clear() — use new ColorBGRA(r,g,b,a) or Color.SkyBlue.ToArgb()
//  7. Matrix:                SharpDX.Matrix (same methods as SlimDX.Matrix)
//  8. Vector3/Vector2:       SharpDX.Vector3/Vector2 (same)
//  9. Present():             device.Present() (same)
// ---------------------------------------------------------------------------

namespace SBuilderXX
{
    public partial class FrmGBuilding
    {

        public FrmGBuilding()
        {
            InitializeComponent();  // this must be here and must be first
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
            moduleOBJECTS.bottomTexture  = (int)nUPbottomTexture.Value;
            moduleOBJECTS.roofTexture    = (int)nUProofTexture.Value;
            moduleOBJECTS.topTexture     = (int)nUPtopTexture.Value;
            moduleOBJECTS.windowTexture  = (int)nUPwindowTexture.Value;
            moduleOBJECTS.sizeX          = (float)nUPsizeX.Value;
            moduleOBJECTS.sizeZ          = (float)nUPsizeZ.Value;
            moduleOBJECTS.scale_gb       = (float)nUPscale.Value;
            My.MyProject.Forms.FrmObjectsP.nUPsizeX.Value  = (decimal)moduleOBJECTS.sizeX;
            My.MyProject.Forms.FrmObjectsP.nUPsizeZ.Value  = (decimal)moduleOBJECTS.sizeZ;
            My.MyProject.Forms.FrmObjectsP.nUPscale.Value  = (decimal)moduleOBJECTS.scale_gb;
            if (moduleOBJECTS.BuildingType == 256) My.MyProject.Forms.FrmObjectsP.optGbFlat.Checked       = true;
            if (moduleOBJECTS.BuildingType == 257) My.MyProject.Forms.FrmObjectsP.optGbPeaked.Checked     = true;
            if (moduleOBJECTS.BuildingType == 258) My.MyProject.Forms.FrmObjectsP.optGbRidge.Checked      = true;
            if (moduleOBJECTS.BuildingType == 259) My.MyProject.Forms.FrmObjectsP.optGbSlant.Checked      = true;
            if (moduleOBJECTS.BuildingType == 260) My.MyProject.Forms.FrmObjectsP.optGbPyramidal.Checked  = true;
            if (moduleOBJECTS.BuildingType == 261) My.MyProject.Forms.FrmObjectsP.optGbMultiSided.Checked = true;
            moduleOBJECTS.sizeBottomY = (float)nUPsizeBottomY.Value;
            moduleOBJECTS.sizeWindowY = (float)nUPsizeWindowY.Value;
            moduleOBJECTS.sizeTopY    = (float)nUPsizeTopY.Value;
            moduleOBJECTS.sizeRoofY   = (float)nUPsizeRoofY.Value;
            if (moduleOBJECTS.BuildingType == 260)
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
            moduleOBJECTS.textureIndexTopX    = (int)(256m * nUPtextureIndexTopZ.Value);
            moduleOBJECTS.textureIndexTopZ    = (int)(256m * nUPtextureIndexTopZ.Value);
            moduleOBJECTS.textureIndexRoofX   = (int)(256m * nUPtextureIndexRoofX.Value);
            moduleOBJECTS.textureIndexRoofY   = (int)(256m * nUPtextureIndexRoofY.Value);
            moduleOBJECTS.textureIndexRoofZ   = (int)(256m * nUPtextureIndexRoofZ.Value);
            moduleOBJECTS.gableTexture        = (int)nUPgableTexture.Value;
            moduleOBJECTS.textureIndexGableY  = (int)(256m * nUPtextureIndexGableY.Value);
            moduleOBJECTS.textureIndexGableZ  = (int)(256m * nUPtextureIndexGableZ.Value);
            moduleOBJECTS.faceTexture         = (int)nUPfaceTexture.Value;
            moduleOBJECTS.textureIndexFaceX   = (int)(256m * nUPtextureIndexFaceX.Value);
            moduleOBJECTS.textureIndexFaceY   = (int)(256m * nUPtextureIndexFaceY.Value);
            moduleOBJECTS.buildingSides       = (int)nUPbuildingSides.Value;
            moduleOBJECTS.smoothing           = ckSmoothing.Checked;
            Dispose();
        }

        private void FrmGBuilding_Load(object sender, EventArgs e)
        {
            nUPsizeX.Value               = (decimal)moduleOBJECTS.sizeX;
            nUPsizeZ.Value               = (decimal)moduleOBJECTS.sizeZ;
            nUPscale.Value               = (decimal)moduleOBJECTS.scale_gb;
            nUPbottomTexture.Value       = moduleOBJECTS.bottomTexture;
            nUPwindowTexture.Value       = moduleOBJECTS.windowTexture;
            nUPtopTexture.Value          = moduleOBJECTS.topTexture;
            nUProofTexture.Value         = moduleOBJECTS.roofTexture;
            nUPsizeBottomY.Value         = (decimal)moduleOBJECTS.sizeBottomY;
            nUPsizeWindowY.Value         = (decimal)moduleOBJECTS.sizeWindowY;
            nUPsizeTopY.Value            = (decimal)moduleOBJECTS.sizeTopY;
            nUPsizeRoofY.Value           = (decimal)moduleOBJECTS.sizeRoofY;
            nUPsizeTopX.Value            = (decimal)moduleOBJECTS.sizeTopX;
            nUPsizeTopZ.Value            = (decimal)moduleOBJECTS.sizeTopZ;
            sizeTopX_S                   = moduleOBJECTS.sizeTopX;
            sizeTopZ_S                   = moduleOBJECTS.sizeTopZ;
            nUPtextureIndexBottomX.Value = (decimal)(moduleOBJECTS.textureIndexBottomX / 256d);
            nUPtextureIndexBottomZ.Value = (decimal)(moduleOBJECTS.textureIndexBottomZ / 256d);
            nUPtextureIndexWindowX.Value = (decimal)(moduleOBJECTS.textureIndexWindowX / 256d);
            nUPtextureIndexWindowY.Value = (decimal)(moduleOBJECTS.textureIndexWindowY / 256d);
            nUPtextureIndexWindowZ.Value = (decimal)(moduleOBJECTS.textureIndexWindowZ / 256d);
            nUPtextureIndexTopZ.Value    = (decimal)(moduleOBJECTS.textureIndexTopX    / 256d);
            nUPtextureIndexTopZ.Value    = (decimal)(moduleOBJECTS.textureIndexTopZ    / 256d);
            nUPtextureIndexRoofX.Value   = (decimal)(moduleOBJECTS.textureIndexRoofX   / 256d);
            nUPtextureIndexRoofY.Value   = (decimal)(moduleOBJECTS.textureIndexRoofY   / 256d);
            nUPtextureIndexRoofZ.Value   = (decimal)(moduleOBJECTS.textureIndexRoofZ   / 256d);
            nUPgableTexture.Value        = moduleOBJECTS.gableTexture;
            nUPtextureIndexGableY.Value  = (decimal)(moduleOBJECTS.textureIndexGableY  / 256d);
            nUPtextureIndexGableZ.Value  = (decimal)(moduleOBJECTS.textureIndexGableZ  / 256d);
            nUPfaceTexture.Value         = moduleOBJECTS.faceTexture;
            nUPtextureIndexFaceX.Value   = (decimal)(moduleOBJECTS.textureIndexFaceX   / 256d);
            nUPtextureIndexFaceY.Value   = (decimal)(moduleOBJECTS.textureIndexFaceY   / 256d);
            nUPbuildingSides.Value       = moduleOBJECTS.buildingSides;
            ckSmoothing.Checked          = moduleOBJECTS.smoothing;

            optGbFlat.Checked = optGbPeaked.Checked = optGbRidge.Checked =
            optGbSlant.Checked = optGbPyramidal.Checked = optGbMultiSided.Checked = false;
            if (moduleOBJECTS.BuildingType == 256) optGbFlat.Checked       = true;
            if (moduleOBJECTS.BuildingType == 257) optGbPeaked.Checked     = true;
            if (moduleOBJECTS.BuildingType == 258) optGbRidge.Checked      = true;
            if (moduleOBJECTS.BuildingType == 259) optGbSlant.Checked      = true;
            if (moduleOBJECTS.BuildingType == 260) optGbPyramidal.Checked  = true;
            if (moduleOBJECTS.BuildingType == 261) optGbMultiSided.Checked = true;

            LoadGraphics();
        }

        private float sizeTopX_S;
        private float sizeTopZ_S;

        private void SetBuildingType()
        {
            string A = "";
            if (moduleOBJECTS.BuildingType == 256) A = "Rectangular - FLAT roof";
            if (moduleOBJECTS.BuildingType == 257) A = "Rectangular - PEAKED roof";
            if (moduleOBJECTS.BuildingType == 258) A = "Rectangular - RIDGE roof";
            if (moduleOBJECTS.BuildingType == 259) A = "Rectangular - SLANT roof";
            if (moduleOBJECTS.BuildingType == 260) A = "Pyramidal Building";
            if (moduleOBJECTS.BuildingType == 261) A = "Multi-Sided Building";
            Text = "SBuilderXX - Generic Buildings - " + A;

            nUPsizeBottomY.Enabled  = nUPtextureIndexBottomX.Enabled = nUPtextureIndexBottomZ.Enabled = false;
            nUPsizeWindowY.Enabled  = nUPtextureIndexWindowX.Enabled = nUPtextureIndexWindowY.Enabled = nUPtextureIndexWindowZ.Enabled = false;
            nUPsizeTopX.Enabled     = nUPsizeTopY.Enabled = nUPsizeTopZ.Enabled = false;
            lbTW.Enabled            = lbTD.Enabled = false;
            nUPtextureIndexTopX.Enabled = nUPtextureIndexTopZ.Enabled = false;
            nUPsizeRoofY.Enabled    = nUPtextureIndexRoofX.Enabled = nUPtextureIndexRoofY.Enabled = nUPtextureIndexRoofZ.Enabled = false;
            nUPgableTexture.Enabled = nUPtextureIndexGableY.Enabled = nUPtextureIndexGableZ.Enabled = false;
            nUPfaceTexture.Enabled  = nUPtextureIndexFaceX.Enabled = nUPtextureIndexFaceY.Enabled = false;
            frMulti.Enabled         = nUPbuildingSides.Enabled = ckSmoothing.Enabled = false;
            nUPWX.Value = nUPsizeX.Value; nUPWZ.Value = nUPsizeZ.Value;
            nUPRX.Value = nUPsizeX.Value; nUPRZ.Value = nUPsizeZ.Value;
            lbBZT.Enabled = lbWZT.Enabled = lbTZT.Enabled = lbRYT.Enabled = false;
            lbF.Enabled = lbFXT.Enabled = lbFYT.Enabled = false;
            lbG.Enabled = lbGYT.Enabled = lbGZT.Enabled = false;
            lbRH.Enabled = (moduleOBJECTS.BuildingType != 256);

            int bt = moduleOBJECTS.BuildingType;
            if (bt == 256 || bt == 257 || bt == 258 || bt == 259)
            {
                nUPsizeBottomY.Enabled = nUPtextureIndexBottomX.Enabled = nUPtextureIndexBottomZ.Enabled = true;
                nUPsizeWindowY.Enabled = nUPtextureIndexWindowX.Enabled = nUPtextureIndexWindowY.Enabled = nUPtextureIndexWindowZ.Enabled = true;
                nUPsizeTopY.Enabled    = nUPtextureIndexTopX.Enabled    = nUPtextureIndexTopZ.Enabled    = true;
                nUPtextureIndexRoofX.Enabled = nUPtextureIndexRoofZ.Enabled = true;
                lbBZT.Enabled = lbWZT.Enabled = lbTZT.Enabled = true;
            }
            if (bt == 257) { nUPsizeRoofY.Enabled = nUPtextureIndexRoofY.Enabled = lbRYT.Enabled = true; }
            if (bt == 258) { nUPsizeRoofY.Enabled = nUPgableTexture.Enabled = nUPtextureIndexGableY.Enabled = nUPtextureIndexGableZ.Enabled = lbG.Enabled = lbGYT.Enabled = lbGZT.Enabled = true; }
            if (bt == 259)
            {
                nUPsizeRoofY.Enabled = nUPgableTexture.Enabled = nUPtextureIndexGableY.Enabled = nUPtextureIndexGableZ.Enabled = true;
                nUPfaceTexture.Enabled = nUPtextureIndexFaceX.Enabled = nUPtextureIndexFaceY.Enabled = true;
                lbF.Enabled = lbFXT.Enabled = lbFYT.Enabled = lbG.Enabled = lbGYT.Enabled = lbGZT.Enabled = true;
            }
            if (bt == 260)
            {
                nUPsizeTopX.Enabled = nUPsizeTopZ.Enabled = lbTW.Enabled = lbTD.Enabled = true;
                nUPsizeBottomY.Enabled = nUPtextureIndexBottomX.Enabled = nUPtextureIndexBottomZ.Enabled = true;
                nUPsizeWindowY.Enabled = nUPtextureIndexWindowX.Enabled = nUPtextureIndexWindowY.Enabled = nUPtextureIndexWindowZ.Enabled = true;
                nUPsizeTopY.Enabled    = nUPtextureIndexTopX.Enabled    = nUPtextureIndexTopZ.Enabled    = true;
                nUPtextureIndexRoofX.Enabled = nUPtextureIndexRoofZ.Enabled = true;
                lbBZT.Enabled = lbWZT.Enabled = lbTZT.Enabled = true;
                lbRH.Enabled = false;
            }
            if (bt == 261)
            {
                frMulti.Enabled = nUPbuildingSides.Enabled = ckSmoothing.Enabled = true;
                nUPsizeBottomY.Enabled = nUPtextureIndexBottomX.Enabled = true;
                nUPsizeWindowY.Enabled = nUPtextureIndexWindowX.Enabled = nUPtextureIndexWindowY.Enabled = true;
                nUPsizeTopY.Enabled    = nUPtextureIndexTopX.Enabled    = true;
                nUPsizeRoofY.Enabled   = nUPtextureIndexRoofX.Enabled   = nUPtextureIndexRoofY.Enabled = nUPtextureIndexRoofZ.Enabled = lbRYT.Enabled = true;
            }
            if (bt == 260)
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

            if (IsInit) return;
            ResetDevice();
        }

        // ── DirectX objects (SharpDX replacements for SlimDX) ────────────
        private Device      renderDevice  = null;
        private VertexBuffer vertexBuffer  = null;
        private VertexBuffer vertexBuffer0 = null;

        // Vertex formats – identical to original
        [StructLayout(LayoutKind.Sequential)]
        private struct VertexPT
        {
            public Vector3 Position;
            public Vector2 Texture;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct VertexPC
        {
            public Vector3 Position;
            public int     Color;
        }

        private bool   pause      = false;
        private SharpDX.Direct3D9.Font fntOut;
        private string sDevInfo;
        private Matrix modelMatrix;
        private float  modelScale  = 1f;
        private float  modelAngleX = 0f;
        private float  modelAngleY = 0f;
        private float  modelPanX   = 0f;
        private float  modelPanY   = 0f;
        private bool   IsInit      = true;

        private float sizTopX, sizTopZ;

        private void LoadGraphics()
        {
            SetEvents();
            if (!InitializeGraphics())
            {
                MessageBox.Show("Could not initialize SharpDX Direct3D9!");
                return;
            }
            Show();
            object s = new object();
            EventArgs e = new EventArgs();
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
            try
            {
                var d3D = new Direct3D();

                // Try with multisampling first, fall back to None if not supported
                var msType = MultisampleType.FifteenSamples;
                if (!d3D.CheckDeviceMultisampleType(0, DeviceType.Hardware,
                        Format.X8R8G8B8, true, msType))
                {
                    msType = MultisampleType.None;
                }

                var presentParams = new PresentParameters
                {
                    MultiSampleType = MultisampleType.None,
                    MultiSampleQuality = 0,
                    SwapEffect = SwapEffect.Discard,
                    DeviceWindowHandle = imgGenB.Handle,  // back to imgGenB
                    BackBufferWidth = 0,
                    BackBufferHeight = 0,
                    BackBufferFormat = Format.Unknown,
                    BackBufferCount = 1,
                    Windowed = true,
                    EnableAutoDepthStencil = true,
                    AutoDepthStencilFormat = Format.D16,
                    PresentationInterval = PresentInterval.Immediate,
                };

                renderDevice = new Device(
                    d3D, 0,
                    DeviceType.Hardware,
                    imgGenB.Handle,
                    CreateFlags.HardwareVertexProcessing,
                    presentParams);

                ResetDevice();
                LoadTextures();
                SetupMatrices();

                fntOut = new SharpDX.Direct3D9.Font(renderDevice, new FontDescription
                {
                    Height = 16,
                    Width = 0,
                    Weight = FontWeight.Regular,
                    MipLevels = 1,
                    Italic = false,
                    CharacterSet = FontCharacterSet.Default,
                    OutputPrecision = FontPrecision.Default,
                    Quality = FontQuality.Default,
                    PitchAndFamily = FontPitchAndFamily.Default | FontPitchAndFamily.DontCare,
                    FaceName = "Arial"
                });

                sDevInfo = "UNKNOWN ADAPTER";
                pause = false;
                return true;
            }
            catch (SharpDXException ex)
            {
                MessageBox.Show("SharpDX init failed:\n" + ex.Message + "\n\nResult: " + ex.ResultCode);
                return false;
            }
        }

        private void ResetDevice()
        {
            CreateVertexBuffer();
            // SharpDX: SetRenderState uses same enum values as SlimDX
            renderDevice.SetRenderState(RenderState.CullMode,  (int)Cull.None);
            renderDevice.SetRenderState(RenderState.Lighting,  false);
            renderDevice.SetRenderState(RenderState.ZEnable,   true);
        }

        private void SetEvents()
        {
            nUPsizeX.ValueChanged               += RebuildBuilding;
            nUPsizeZ.ValueChanged               += RebuildBuilding;
            nUPsizeBottomY.ValueChanged         += RebuildBuilding;
            nUPsizeWindowY.ValueChanged         += RebuildBuilding;
            nUPsizeTopY.ValueChanged            += RebuildBuilding;
            nUPsizeRoofY.ValueChanged           += RebuildBuilding;
            nUPtextureIndexBottomX.ValueChanged += RebuildBuilding;
            nUPtextureIndexBottomZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowX.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowY.ValueChanged += RebuildBuilding;
            nUPtextureIndexWindowZ.ValueChanged += RebuildBuilding;
            nUPtextureIndexTopX.ValueChanged    += RebuildBuilding;
            nUPtextureIndexTopZ.ValueChanged    += RebuildBuilding;
            nUPtextureIndexRoofX.ValueChanged   += RebuildBuilding;
            nUPtextureIndexRoofY.ValueChanged   += RebuildBuilding;
            nUPtextureIndexRoofZ.ValueChanged   += RebuildBuilding;
            nUPtextureIndexGableY.ValueChanged  += RebuildBuilding;
            nUPtextureIndexGableZ.ValueChanged  += RebuildBuilding;
            nUPtextureIndexFaceX.ValueChanged   += RebuildBuilding;
            nUPtextureIndexFaceY.ValueChanged   += RebuildBuilding;
            nUPbuildingSides.ValueChanged       += RebuildBuilding;
            nUPGrid.ValueChanged                += RebuildBuilding;
            nUPbottomTexture.ValueChanged       += LoadBottomTexture;
            nUPwindowTexture.ValueChanged       += LoadWindowTexture;
            nUPtopTexture.ValueChanged          += LoadTopTexture;
            nUProofTexture.ValueChanged         += LoadRoofTexture;
            nUPgableTexture.ValueChanged        += LoadGableTexture;
            nUPfaceTexture.ValueChanged         += LoadFaceTexture;
            cmdCancel.Click += CancelCommand;
            cmdOK.Click     += OKCommand;
        }

        // Local geometry state – identical to original
        private float texIndexBottomX, texIndexBottomZ;
        private float texIndexWindowX, texIndexWindowZ, texIndexWindowY;
        private float texIndexTopX,    texIndexTopZ;
        private float texIndexRoofX,   texIndexRoofY,   texIndexRoofZ;
        private float texIndexGableY,  texIndexGableZ;
        private float texIndexFaceX,   texIndexFaceY;
        private float sizX, sizZ;
        private float sizBottomY, sizWindowY, sizTopY, sizRoofY;
        private int   sides;

        private void RebuildBuilding(object sender, EventArgs e)
        {
            Grid        = (float)nUPGrid.Value;
            sizX        = (float)nUPsizeX.Value;
            sizZ        = (float)nUPsizeZ.Value;
            if (moduleOBJECTS.BuildingType == 260)
            {
                sizTopX = (float)nUPsizeTopX.Value;
                sizTopZ = (float)nUPsizeTopZ.Value;
            }
            else
            {
                sizTopX = (float)nUPsizeX.Value;
                sizTopZ = (float)nUPsizeZ.Value;
            }
            nUPWX.Value = nUPsizeX.Value; nUPWZ.Value = nUPsizeZ.Value;
            nUPRX.Value = nUPsizeX.Value; nUPRZ.Value = nUPsizeZ.Value;
            sizBottomY       = (float)nUPsizeBottomY.Value;
            sizWindowY       = (float)nUPsizeWindowY.Value;
            sizTopY          = (float)nUPsizeTopY.Value;
            sizRoofY         = (float)nUPsizeRoofY.Value;
            texIndexBottomX  = (float)nUPtextureIndexBottomX.Value;
            texIndexBottomZ  = (float)nUPtextureIndexBottomZ.Value;
            texIndexWindowX  = (float)nUPtextureIndexWindowX.Value;
            texIndexWindowY  = (float)nUPtextureIndexWindowY.Value;
            texIndexWindowZ  = (float)nUPtextureIndexWindowZ.Value;
            texIndexTopX     = (float)nUPtextureIndexTopX.Value;
            texIndexTopZ     = (float)nUPtextureIndexTopZ.Value;
            texIndexRoofX    = (float)nUPtextureIndexRoofX.Value;
            texIndexRoofY    = (float)nUPtextureIndexRoofY.Value;
            texIndexRoofZ    = (float)nUPtextureIndexRoofZ.Value;
            texIndexGableY   = (float)nUPtextureIndexGableY.Value;
            texIndexGableZ   = (float)nUPtextureIndexGableZ.Value;
            texIndexFaceX    = (float)nUPtextureIndexFaceX.Value;
            texIndexFaceY    = (float)nUPtextureIndexFaceY.Value;
            sides            = (int)nUPbuildingSides.Value;
            ResetDevice();
        }

        // ── CreateVertexBuffer ───────────────────────────────────────────
        // Identical logic to original. Only difference: SharpDX DataStream
        // uses stream.Write(array) instead of stream.WriteRange(array).
        private void CreateVertexBuffer()
        {
            int N;
            VertexPT[] v = new VertexPT[301];
            int i = 0;
            float sX0, sX1, y0, y1, sZ0, sZ1, tX, tY, tZ, gY, gZ, fX, fY;
            float t0 = 0f, t1 = 1f, tb = 0f, tw = 0f;
            if (nUPbottomTexture.Value > 85m) tb = 0.5f;
            if (nUPwindowTexture.Value > 84m) tw = 0.5f;
            float rX, rZ;

            y0 = -(sizBottomY + sizWindowY + sizTopY) / 2.0f;

            if (moduleOBJECTS.BuildingType == 261) // multi-sided
            {
                rX = sizX / 2f; rZ = sizZ / 2f;
                float pi1 = (float)(moduleMAIN.PI / sides);
                float pi2 = pi1 * 2f;

                y1 = y0 + sizBottomY; tX = texIndexBottomX;
                if (sizBottomY > 0f)
                {
                    for (N = 1; N <= sides; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N-1)*pi2 - pi1));
                        sX1 = (float)(rX * Math.Cos( N   *pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N-1)*pi2 - pi1));
                        sZ1 = (float)(rZ * Math.Sin( N   *pi2 - pi1));
                        v[i+0] = VPT(sX0,y0,sZ0, t0,t0); v[i+1] = VPT(sX0,y1,sZ0, t0,t1);
                        v[i+2] = VPT(sX1,y1,sZ1, tX,t1); v[i+3] = VPT(sX1,y0,sZ1, tX,t0);
                        i += 4;
                    }
                }
                y0 = y1; y1 = y0 + sizWindowY; tX = texIndexWindowX; tY = texIndexWindowY;
                if (sizWindowY > 0f)
                {
                    for (N = 1; N <= sides; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N-1)*pi2 - pi1)); sX1 = (float)(rX * Math.Cos(N*pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N-1)*pi2 - pi1)); sZ1 = (float)(rZ * Math.Sin(N*pi2 - pi1));
                        v[i+0] = VPT(sX0,y0,sZ0, t0,t0); v[i+1] = VPT(sX0,y1,sZ0, t0,tY);
                        v[i+2] = VPT(sX1,y1,sZ1, tX,tY); v[i+3] = VPT(sX1,y0,sZ1, tX,t0);
                        i += 4;
                    }
                }
                y0 = y1; y1 = y0 + sizTopY; tX = texIndexTopX;
                if (sizTopY > 0f)
                {
                    for (N = 1; N <= sides; N++)
                    {
                        sX0 = (float)(rX * Math.Cos((N-1)*pi2 - pi1)); sX1 = (float)(rX * Math.Cos(N*pi2 - pi1));
                        sZ0 = (float)(rZ * Math.Sin((N-1)*pi2 - pi1)); sZ1 = (float)(rZ * Math.Sin(N*pi2 - pi1));
                        v[i+0] = VPT(sX0,y0,sZ0, t0,t0); v[i+1] = VPT(sX0,y1,sZ0, t0,t1);
                        v[i+2] = VPT(sX1,y1,sZ1, tX,t1); v[i+3] = VPT(sX1,y0,sZ1, tX,t0);
                        i += 4;
                    }
                }
                y0 = y1; y1 = y0 + sizRoofY; tX = texIndexRoofX; tZ = texIndexRoofZ;
                for (N = 1; N <= sides; N++)
                {
                    sX0 = (float)(rX * Math.Cos((N-1)*pi2 - pi1)); sX1 = (float)(rX * Math.Cos(N*pi2 - pi1));
                    sZ0 = (float)(rZ * Math.Sin((N-1)*pi2 - pi1)); sZ1 = (float)(rZ * Math.Sin(N*pi2 - pi1));
                    v[i+0] = VPT(sX0,y0,sZ0, t0,t0); v[i+1] = VPT(0f,y1,0f, tX/2f,tZ); v[i+2] = VPT(sX1,y0,sZ1, tX,t0);
                    i += 3;
                }
            }
            else // rectangular / pyramidal – identical to original
            {
                sX0 = sizX/2f; sX1 = sizX/2f; sZ0 = sizZ/2f; sZ1 = sizZ/2f;

                y1 = y0 + sizBottomY; tX = texIndexBottomX; tZ = texIndexBottomZ;
                if (sizBottomY > 0f)
                {
                    v[i+0]=VPT(-sX0,y0,-sZ0,t0,t0); v[i+1]=VPT(-sX1,y1,-sZ1,t0,t1); v[i+2]=VPT(+sX1,y1,-sZ1,tX,t1); v[i+3]=VPT(+sX0,y0,-sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,-sZ0,tb,t0); v[i+1]=VPT(+sX1,y1,-sZ1,tb,t1); v[i+2]=VPT(+sX1,y1,+sZ1,tZ,t1); v[i+3]=VPT(+sX0,y0,+sZ0,tZ,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(+sX1,y1,+sZ1,t0,t1); v[i+2]=VPT(-sX1,y1,+sZ1,tX,t1); v[i+3]=VPT(-sX0,y0,+sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(-sX0,y0,+sZ0,tb,t0); v[i+1]=VPT(-sX1,y1,+sZ1,tb,t1); v[i+2]=VPT(-sX1,y1,-sZ1,tZ,t1); v[i+3]=VPT(-sX0,y0,-sZ0,tZ,t0); i+=4;
                }
                y0 = y1; y1 = y0 + sizWindowY; tX = texIndexWindowX; tZ = texIndexWindowZ; tY = texIndexWindowY;
                if (sizWindowY > 0f)
                {
                    v[i+0]=VPT(-sX0,y0,-sZ0,tw,t0); v[i+1]=VPT(-sX1,y1,-sZ1,tw,tY); v[i+2]=VPT(+sX1,y1,-sZ1,tX,tY); v[i+3]=VPT(+sX0,y0,-sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,-sZ0,t0,t0); v[i+1]=VPT(+sX1,y1,-sZ1,t0,tY); v[i+2]=VPT(+sX1,y1,+sZ1,tZ,tY); v[i+3]=VPT(+sX0,y0,+sZ0,tZ,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(+sX1,y1,+sZ1,t0,tY); v[i+2]=VPT(-sX1,y1,+sZ1,tX,tY); v[i+3]=VPT(-sX0,y0,+sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(-sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(-sX1,y1,+sZ1,t0,tY); v[i+2]=VPT(-sX1,y1,-sZ1,tZ,tY); v[i+3]=VPT(-sX0,y0,-sZ0,tZ,t0); i+=4;
                }
                sX1 = sizTopX/2f; sZ1 = sizTopZ/2f;
                y0 = y1; y1 = y0 + sizTopY; tX = texIndexTopX; tZ = texIndexTopZ;
                if (sizTopY > 0f)
                {
                    v[i+0]=VPT(-sX0,y0,-sZ0,t0,t0); v[i+1]=VPT(-sX1,y1,-sZ1,t0,t1); v[i+2]=VPT(+sX1,y1,-sZ1,tX,t1); v[i+3]=VPT(+sX0,y0,-sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,-sZ0,t0,t0); v[i+1]=VPT(+sX1,y1,-sZ1,t0,t1); v[i+2]=VPT(+sX1,y1,+sZ1,tZ,t1); v[i+3]=VPT(+sX0,y0,+sZ0,tZ,t0); i+=4;
                    v[i+0]=VPT(+sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(+sX1,y1,+sZ1,t0,t1); v[i+2]=VPT(-sX1,y1,+sZ1,tX,t1); v[i+3]=VPT(-sX0,y0,+sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(-sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(-sX1,y1,+sZ1,t0,t1); v[i+2]=VPT(-sX1,y1,-sZ1,tZ,t1); v[i+3]=VPT(-sX0,y0,-sZ0,tZ,t0); i+=4;
                }
                sX0 = sizTopX/2f; sZ0 = sizTopZ/2f;
                if (moduleOBJECTS.BuildingType == 256 || moduleOBJECTS.BuildingType == 260)
                {
                    tX = texIndexRoofX; tZ = texIndexRoofZ;
                    v[i+0]=VPT(-sX0,y1,+sZ0,t0,tZ); v[i+1]=VPT(+sX0,y1,+sZ0,tX,tZ); v[i+2]=VPT(+sX0,y1,-sZ0,tX,t0); v[i+3]=VPT(-sX0,y1,-sZ0,t0,t0); i+=4;
                }
                if (moduleOBJECTS.BuildingType == 257)
                {
                    tX = texIndexRoofX; tZ = texIndexRoofZ; tY = texIndexRoofY;
                    v[i+0]=VPT(-sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(0f,y1+sizRoofY,0f,tX/2f,tY); v[i+2]=VPT(+sX0,y1,-sZ0,tX,t0); i+=3;
                    v[i+0]=VPT(+sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(0f,y1+sizRoofY,0f,tZ/2f,tY); v[i+2]=VPT(+sX0,y1,+sZ0,tZ,t0); i+=3;
                    v[i+0]=VPT(+sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(0f,y1+sizRoofY,0f,tX/2f,tY); v[i+2]=VPT(-sX0,y1,+sZ0,tX,t0); i+=3;
                    v[i+0]=VPT(-sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(0f,y1+sizRoofY,0f,tZ/2f,tY); v[i+2]=VPT(-sX0,y1,-sZ0,tZ,t0); i+=3;
                }
                if (moduleOBJECTS.BuildingType == 258)
                {
                    float yr = y1 + sizRoofY; tX = texIndexRoofX; tZ = texIndexRoofZ; gY = texIndexGableY; gZ = texIndexGableZ;
                    v[i+0]=VPT(-sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(-sX0,yr,0f,t0,tZ); v[i+2]=VPT(+sX0,yr,0f,tX,tZ); v[i+3]=VPT(+sX0,y1,-sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(+sX0,yr,0f,t0,tZ); v[i+2]=VPT(-sX0,yr,0f,tX,tZ); v[i+3]=VPT(-sX0,y1,+sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(+sX0,yr, 0f,gZ/2f,gY); v[i+2]=VPT(+sX0,y1,+sZ0,gZ,t0); i+=3;
                    v[i+0]=VPT(-sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(-sX0,yr, 0f,gZ/2f,gY); v[i+2]=VPT(-sX0,y1,-sZ0,gZ,t0); i+=3;
                }
                if (moduleOBJECTS.BuildingType == 259)
                {
                    float yr = y1 + sizRoofY; tX = texIndexRoofX; tZ = texIndexRoofZ;
                    gY = texIndexGableY; gZ = texIndexGableZ; fX = texIndexFaceX; fY = texIndexFaceY;
                    v[i+0]=VPT(-sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(-sX0,yr,-sZ0,t0,fY); v[i+2]=VPT(+sX0,yr,-sZ0,fX,fY); v[i+3]=VPT(+sX0,y1,-sZ0,fX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(+sX0,yr,-sZ0,t0,tZ); v[i+2]=VPT(-sX0,yr,-sZ0,tX,tZ); v[i+3]=VPT(-sX0,y1,+sZ0,tX,t0); i+=4;
                    v[i+0]=VPT(+sX0,y1,-sZ0,t0,t0); v[i+1]=VPT(+sX0,yr,-sZ0,t0,gY); v[i+2]=VPT(+sX0,y1,+sZ0,gZ,t0); i+=3;
                    v[i+0]=VPT(-sX0,y1,+sZ0,t0,t0); v[i+1]=VPT(-sX0,yr,-sZ0,gZ,gY); v[i+2]=VPT(-sX0,y1,-sZ0,gZ,t0); i+=3;
                }
            }

            // base
            sX0 = sizX/2f; sZ0 = sizZ/2f;
            y0  = -(sizBottomY + sizWindowY + sizTopY) / 2.0f;
            v[i+0]=VPT(-sX0,y0,+sZ0,t0,t0); v[i+1]=VPT(-sX0,y0,-sZ0,t0,t1);
            v[i+2]=VPT(+sX0,y0,-sZ0,t1,t1); v[i+3]=VPT(+sX0,y0,+sZ0,t1,t0); i+=4;

            Array.Resize(ref v, i);
            int sizeVector = Marshal.SizeOf(typeof(VertexPT)); // 20 bytes

            // SharpDX VertexBuffer: same constructor as SlimDX
            vertexBuffer = new VertexBuffer(
                renderDevice,
                sizeVector * i,
                Usage.WriteOnly,
                VertexFormat.Position | VertexFormat.Texture2,
                Pool.Managed);

            // SharpDX DataStream: Lock returns DataStream, write with Write()
            using (var stream = vertexBuffer.Lock(0, 0, LockFlags.None))
            {
                foreach (var vert in v) stream.Write(vert);
                vertexBuffer.Unlock();
            }

            // Grid lines (VertexPC) – identical to original
            var v0 = new VertexPC[44];
            int j = -1;
            GDIColor C = GDIColor.White;
            sX0 = -6*Grid; sZ0 = -5*Grid; float sZ1g = 5f*Grid;
            for (N = 1; N <= 11; N++)
            {
                j++; sX0 += Grid;
                v0[j] = VPC(sX0, y0, sZ0, C); j++;
                v0[j] = VPC(sX0, y0, sZ1g, C);
            }
            sX0 = -5*Grid; float sX1g = 5f*Grid; sZ0 = -6*Grid;
            for (N = 1; N <= 11; N++)
            {
                j++; sZ0 += Grid;
                v0[j] = VPC(sX0, y0, sZ0, C); j++;
                v0[j] = VPC(sX1g, y0, sZ0, C);
            }
            v0[10].Color = GDIColor.Red.ToArgb();
            v0[11].Color = GDIColor.Red.ToArgb();
            v0[32].Color = GDIColor.Green.ToArgb();
            v0[33].Color = GDIColor.Green.ToArgb();

            int sizeVector0 = Marshal.SizeOf(typeof(VertexPC));
            vertexBuffer0 = new VertexBuffer(
                renderDevice,
                sizeVector0 * 44,
                Usage.WriteOnly,
                VertexFormat.Position | VertexFormat.Diffuse,
                Pool.Managed);
            using (var stream0 = vertexBuffer0.Lock(0, 0, LockFlags.None))
            {
                foreach (var vert in v0) stream0.Write(vert);
                vertexBuffer0.Unlock();
            }
        }

        private VertexPT VPT(float x, float y, float z, float u, float v)
            => new VertexPT { Position = new Vector3(x,y,z), Texture = new Vector2(u,v) };

        private VertexPC VPC(float x, float y, float z, GDIColor c)
            => new VertexPC { Position = new Vector3(x,y,z), Color = c.ToArgb() };

        // ── Render – identical to original ──────────────────────────────
        private void Render()
        {
            int N;
            if (pause) return;

            var skyBlue = System.Drawing.Color.SkyBlue;
            renderDevice.Clear(ClearFlags.Target | ClearFlags.ZBuffer, new DXColor(skyBlue.B, skyBlue.G, skyBlue.R, skyBlue.A), 1.0f, 0);

            renderDevice.BeginScene();

            modelMatrix = Matrix.Scaling(modelScale, modelScale, modelScale);
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.RotationX((float)(modelAngleX * (Math.PI/180d))));
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.RotationY((float)(modelAngleY * (Math.PI/180d))));
            modelMatrix = Matrix.Multiply(modelMatrix, Matrix.Translation(modelPanX, modelPanY, 0f));

            renderDevice.SetTransform(TransformState.World, modelMatrix);
            renderDevice.SetStreamSource(0, vertexBuffer, 0, 20);
            renderDevice.VertexFormat = VertexFormat.Position | VertexFormat.Texture2;

            int i = 0;
            if (moduleOBJECTS.BuildingType == 261) // multi-sided
            {
                if (sizBottomY > 0f)
                {
                    renderDevice.SetTexture(0, textureB);
                    for (N = 1; N <= sides; N++) { renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4; }
                }
                if (sizWindowY > 0f)
                {
                    renderDevice.SetTexture(0, textureW);
                    for (N = 1; N <= sides; N++) { renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4; }
                }
                if (sizTopY > 0f)
                {
                    renderDevice.SetTexture(0, textureT);
                    for (N = 1; N <= sides; N++) { renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4; }
                }
                renderDevice.SetTexture(0, textureR);
                for (N = 1; N <= sides; N++) { renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 1); i+=3; }
            }
            else
            {
                if (sizBottomY > 0f)
                {
                    renderDevice.SetTexture(0, textureB);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+0,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+4,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+8,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+12, 2);
                    i += 16;
                }
                if (sizWindowY > 0f)
                {
                    renderDevice.SetTexture(0, textureW);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+0,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+4,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+8,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+12, 2);
                    i += 16;
                }
                if (sizTopY > 0f)
                {
                    renderDevice.SetTexture(0, textureT);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+0,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+4,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+8,  2);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i+12, 2);
                    i += 16;
                }
                if (moduleOBJECTS.BuildingType == 256 || moduleOBJECTS.BuildingType == 260)
                {
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;
                }
                if (moduleOBJECTS.BuildingType == 257)
                {
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 4); i+=12;
                }
                if (moduleOBJECTS.BuildingType == 258)
                {
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;
                    renderDevice.SetTexture(0, textureG);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 1); i+=3;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 1); i+=3;
                }
                if (moduleOBJECTS.BuildingType == 259)
                {
                    renderDevice.SetTexture(0, textureF);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;
                    renderDevice.SetTexture(0, textureR);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;
                    renderDevice.SetTexture(0, textureG);
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 1); i+=3;
                    renderDevice.DrawPrimitives(PrimitiveType.TriangleList, i, 1); i+=3;
                }
            }

            // base
            renderDevice.SetTexture(0, texture0);
            renderDevice.DrawPrimitives(PrimitiveType.TriangleFan, i, 2); i+=4;

            // grid lines
            renderDevice.SetStreamSource(0, vertexBuffer0, 0, 16);
            renderDevice.VertexFormat = VertexFormat.Position | VertexFormat.Diffuse;
            renderDevice.SetTexture(0, null);
            renderDevice.SetTextureStageState(0, TextureStage.ColorOperation, 4);
            renderDevice.DrawPrimitives(PrimitiveType.LineList, 0, 22);

            if (FullScreen)
            {
                var darkBlue = System.Drawing.Color.DarkBlue;
                fntOut.DrawText(null, helpInfo, 5, 5, new DXColor(darkBlue.B, darkBlue.G, darkBlue.R, darkBlue.A));
            }

            renderDevice.EndScene();
            renderDevice.Present();
        }

        private void SetupMatrices()
        {
            modelScale = moduleOBJECTS.sizeX;
            if (moduleOBJECTS.sizeZ > modelScale) modelScale = moduleOBJECTS.sizeZ;
            modelScale = 5.0f / modelScale;
            renderDevice.SetTransform(TransformState.World,
                Matrix.Scaling(modelScale, modelScale, modelScale));
            renderDevice.SetTransform(TransformState.View,
                Matrix.LookAtLH(new Vector3(0f, 0f, -10f), Vector3.Zero, new Vector3(0f, 1f, 0f)));
            renderDevice.SetTransform(TransformState.Projection,
                Matrix.PerspectiveFovLH((float)(Math.PI / 4d),
                    (float)imgGenB.Width / imgGenB.Height, 1f, 100f));
        }

        // ── Textures ─────────────────────────────────────────────────────
        private string texFolder = Application.StartupPath + @"\Tools\GenB\";
        private Texture textureB, textureW, textureT, textureR, textureF, textureG, texture0;

        // SharpDX Texture.FromFile – identical signature to SlimDX
        private Texture SafeLoadTex(string primary, string fallback)
        {
            try   { return Texture.FromFile(renderDevice, primary); }
            catch { return Texture.FromFile(renderDevice, fallback); }
        }

        private void LoadTextures()
        {
            texture0 = Texture.FromFile(renderDevice, texFolder + "base00.jpg");
            textureB = SafeLoadTex(texFolder + "bottom" + nUPbottomTexture.Value.ToString().Trim() + ".jpg", texFolder + "bottom00.jpg");
            textureW = SafeLoadTex(texFolder + "window" + nUPwindowTexture.Value.ToString().Trim() + ".jpg", texFolder + "window00.jpg");
            textureT = SafeLoadTex(texFolder + "top"    + nUPtopTexture.Value.ToString().Trim()    + ".jpg", texFolder + "top00.jpg");
            textureR = SafeLoadTex(texFolder + "roof"   + nUProofTexture.Value.ToString().Trim()   + ".jpg", texFolder + "roof00.jpg");
            int T = (int)nUPfaceTexture.Value;
            textureF = SafeLoadTex(T >= 1000 ? texFolder + "window" + (T-1000) + ".jpg" : texFolder + "face" + T + ".jpg", texFolder + "face00.jpg");
            T = (int)nUPgableTexture.Value;
            textureG = SafeLoadTex(T >= 1000 ? texFolder + "window" + (T-1000) + ".jpg" : texFolder + "gable" + T + ".jpg", texFolder + "gable00.jpg");
        }

        private void LoadBottomTexture(object sender, EventArgs e) { textureB?.Dispose(); textureB = SafeLoadTex(texFolder+"bottom"+nUPbottomTexture.Value.ToString().Trim()+".jpg", texFolder+"bottom00.jpg"); RebuildBuilding(sender,e); }
        private void LoadWindowTexture(object sender, EventArgs e) { textureW?.Dispose(); textureW = SafeLoadTex(texFolder+"window"+nUPwindowTexture.Value.ToString().Trim()+".jpg", texFolder+"window00.jpg"); RebuildBuilding(sender,e); }
        private void LoadTopTexture   (object sender, EventArgs e) { textureT?.Dispose(); textureT = SafeLoadTex(texFolder+"top"+nUPtopTexture.Value.ToString().Trim()+".jpg",       texFolder+"top00.jpg");    RebuildBuilding(sender,e); }
        private void LoadRoofTexture  (object sender, EventArgs e) { textureR?.Dispose(); textureR = SafeLoadTex(texFolder+"roof"+nUProofTexture.Value.ToString().Trim()+".jpg",     texFolder+"roof00.jpg");   RebuildBuilding(sender,e); }
        private void LoadFaceTexture  (object sender, EventArgs e) { int T=(int)nUPfaceTexture.Value;  textureF?.Dispose(); textureF = SafeLoadTex(T>=1000?texFolder+"window"+(T-1000)+".jpg":texFolder+"face"+T+".jpg",  texFolder+"face00.jpg");  RebuildBuilding(sender,e); }
        private void LoadGableTexture (object sender, EventArgs e) { int T=(int)nUPgableTexture.Value; textureG?.Dispose(); textureG = SafeLoadTex(T>=1000?texFolder+"window"+(T-1000)+".jpg":texFolder+"gable"+T+".jpg", texFolder+"gable00.jpg"); RebuildBuilding(sender,e); }

        // ── Mouse / scroll – identical to original ────────────────────────
        private int   PanX, PanY, MouseX, MouseY;
        private float AngleX, AngleY;
        private bool  modelMove = false, modelPan = false;
        private System.Drawing.Point ImgLoc = new System.Drawing.Point(323, 238);
        private System.Drawing.Size  ImgSiz = new System.Drawing.Size(286, 252);

        private void ImgGenB_MouseDown(object sender, MouseEventArgs e)
        {
            int Button = (int)e.Button / 0x100000;
            if (Button == 1) { MouseX=e.X; MouseY=e.Y; AngleX=modelAngleX; AngleY=modelAngleY; modelMove=true; }
            else if (Button == 4) { MouseX=e.X; MouseY=e.Y; PanX=(int)modelPanX; PanY=(int)modelPanY; modelPan=true; }
            else if (Button == 2)
            {
                if (FullScreen) { imgGenB.Location = ImgLoc; imgGenB.Size = ImgSiz; }
                else
                {
                    imgGenB.Location = new System.Drawing.Point(0, 0);
                    imgGenB.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);
                }
                FullScreen = !FullScreen;
                Application.DoEvents();

                // Reset device with new backbuffer size matching imgGenB
                var pp = new PresentParameters
                {
                    MultiSampleType = MultisampleType.None,
                    MultiSampleQuality = 0,
                    SwapEffect = SwapEffect.Discard,
                    DeviceWindowHandle = imgGenB.Handle,
                    BackBufferWidth = imgGenB.Width,
                    BackBufferHeight = imgGenB.Height,
                    BackBufferFormat = Format.Unknown,
                    BackBufferCount = 1,
                    Windowed = true,
                    EnableAutoDepthStencil = true,
                    AutoDepthStencilFormat = Format.D16,
                    PresentationInterval = PresentInterval.Immediate,
                };

                vertexBuffer?.Dispose(); vertexBuffer = null;
                vertexBuffer0?.Dispose(); vertexBuffer0 = null;
                fntOut?.Dispose(); fntOut = null;

                renderDevice.Reset(pp);

                ResetDevice();
                LoadTextures();
                SetupMatrices();

                fntOut = new SharpDX.Direct3D9.Font(renderDevice, new FontDescription
                {
                    Height = 16,
                    Width = 0,
                    Weight = FontWeight.Regular,
                    MipLevels = 1,
                    Italic = false,
                    CharacterSet = FontCharacterSet.Default,
                    OutputPrecision = FontPrecision.Default,
                    Quality = FontQuality.Default,
                    PitchAndFamily = FontPitchAndFamily.Default | FontPitchAndFamily.DontCare,
                    FaceName = "Arial"
                });
            }
        }

        private void ImgGenB_MouseHover(object sender, EventArgs e) => imgGenB.Focus();

        private void ImgGenB_MouseMove(object sender, MouseEventArgs e)
        {
            if (modelMove) { modelAngleY = AngleY + (MouseX-e.X)*2f; modelAngleX = AngleX - (e.Y-MouseY)*2f; }
            if (modelPan)
            {
                modelPanY = PanY + (MouseY-e.Y)/30f; if (modelPanY>3f) modelPanY=3f; if (modelPanY<-3) modelPanY=-3;
                modelPanX = PanX + (e.X-MouseX)/30f; if (modelPanX>3f) modelPanX=3f; if (modelPanX<-3) modelPanX=-3;
            }
        }

        private void ImgGenB_MouseUp   (object sender, MouseEventArgs e) { modelMove=false; modelPan=false; }
        private void ImgGenB_MouseWheel(object sender, MouseEventArgs e)
        { modelScale = e.Delta > 0 ? modelScale*1.5f : modelScale/1.5f; }

        private void CmdCancel_MouseHover(object sender, EventArgs e) => cmdCancel.Focus();

        // ── RadioButton handlers – identical to original ──────────────────
        private void OptGbFlat_CheckedChanged      (object s, EventArgs e) { if (optGbFlat.Checked)       { moduleOBJECTS.BuildingType=256; SetBuildingType(); } }
        private void OptGbPeaked_CheckedChanged    (object s, EventArgs e) { if (optGbPeaked.Checked)     { moduleOBJECTS.BuildingType=257; SetBuildingType(); } }
        private void OptGbRidge_CheckedChanged     (object s, EventArgs e) { if (optGbRidge.Checked)      { moduleOBJECTS.BuildingType=258; SetBuildingType(); } }
        private void OptGbSlant_CheckedChanged     (object s, EventArgs e) { if (optGbSlant.Checked)      { moduleOBJECTS.BuildingType=259; SetBuildingType(); } }
        private void OptGbPyramidal_CheckedChanged (object s, EventArgs e) { if (optGbPyramidal.Checked)  { moduleOBJECTS.BuildingType=260; SetBuildingType(); } }
        private void OptGbMultiSided_CheckedChanged(object s, EventArgs e) { if (optGbMultiSided.Checked) { moduleOBJECTS.BuildingType=261; SetBuildingType(); } }
    }
}