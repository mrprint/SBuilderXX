using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FSUIPC;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    internal partial class FrmObjectsP
    {
        public FrmObjectsP()
        {
            InitializeComponent();
            _cmdOrder.Name = "cmdOrder";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
            _SSTab1.Name = "SSTab1";
            _optGenB.Name = "optGenB";
            _optMDL.Name = "optMDL";
            _cmdOption.Name = "cmdOption";
            _optRwy12.Name = "optRwy12";
            _optMacro.Name = "optMacro";
            _optBeacon.Name = "optBeacon";
            _optWindsock.Name = "optWindsock";
            _optEffect.Name = "optEffect";
            _optTaxiwaySign.Name = "optTaxiwaySign";
            _optLib.Name = "optLib";
            _cmdPosFs.Name = "cmdPosFs";
            _txtLibName.Name = "txtLibName";
            _txtLibWidth.Name = "txtLibWidth";
            _txtLibLength.Name = "txtLibLength";
            _cmdUpDefault.Name = "cmdUpDefault";
            _txtLibScale.Name = "txtLibScale";
            _imgLib.Name = "imgLib";
            _EnlargePopUpMenuItem.Name = "EnlargePopUpMenuItem";
            _DeletePopUpMenuItem.Name = "DeletePopUpMenuItem";
            _FromFilePopUpMenuItem.Name = "FromFilePopUpMenuItem";
            _CapturePopUpMenuItem.Name = "CapturePopUpMenuItem";
            _PurgePopUPMenuItem.Name = "PurgePopUPMenuItem";
            _lstLib.Name = "lstLib";
            _cmbLibCat.Name = "cmbLibCat";
            _cmdGBDelete.Name = "cmdGBDelete";
            _cmdGbStore.Name = "cmdGbStore";
            _cmdGbLoad.Name = "cmdGbLoad";
            _lstGenB.Name = "lstGenB";
            _cmdGbDetail.Name = "cmdGbDetail";
            _imgGenB.Name = "imgGenB";
            _imgMacro.Name = "imgMacro";
            _frMacro.Name = "frMacro";
            _cmbMacroCat.Name = "cmbMacroCat";
            _lstMacro.Name = "lstMacro";
            _frMacro1.Name = "frMacro1";
            _cmdExpand.Name = "cmdExpand";
            _cmdMacroEdit.Name = "cmdMacroEdit";
            _lstRwy12.Name = "lstRwy12";
            _frRwy12.Name = "frRwy12";
            _cmbRwy12Cat.Name = "cmbRwy12Cat";
            _imgRwy12.Name = "imgRwy12";
            _frMDL.Name = "frMDL";
            _cmdMDL.Name = "cmdMDL";
            _frBeaconType.Name = "frBeaconType";
            _frBeaconBase.Name = "frBeaconBase";
            _frWindsock.Name = "frWindsock";
            _txtWindsockLength.Name = "txtWindsockLength";
            _txtWindsockHeight.Name = "txtWindsockHeight";
            _frEffect.Name = "frEffect";
            _frTaxiway.Name = "frTaxiway";
            _cmdTaxiwayHelp.Name = "cmdTaxiwayHelp";
        }



        // Dim LatAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H560)
        // Dim LonAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H568)

        // Dim AltAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H568)
        // Dim PitchAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H568)
        // Dim BankAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H568)
        // Dim HeadingAircraft As Offset(Of Long) = New FSUIPC.Offset(Of Long)(&H568)

        private string Mode; // One or Many or RGN
        private bool IsReady; // to sign that combox can start!
        private bool IsInit = true; // to sign that opt controls should do nothing
                                    // Private ListObj1 As Integer
                                    // Private ListObj2 As Integer

        private void CmbLibCat_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int K;
            string a, LibCat;
            if (!IsReady)
                return;

            // first remove all listings
            lstLib.Items.Clear();

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                lstLib.Items.Add(g.Name);
            if (moduleOBJECTS.LibCategories[K].Objs.Count == 0)
            {
                txtLibWidth.Text = "";
                txtLibLength.Text = "";
                txtLibScale.Text = "";
                txtLibName.Text = "";
                cmdUpDefault.Enabled = false;
                txtLibID.Text = "";
                txtComment.Text = "";
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
                imgLib.Image = Image.FromFile(a);
                moduleMAIN.ImageFileName = a;
                return;
            }

            LibCat = moduleOBJECTS.LibCategories[K].Name;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[0];
            lstLib.SelectedIndex = 0;
            txtLibID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            cmdUpDefault.Enabled = false;

            // after 205
            txtComment.Text = myLibObj.Name;
            moduleOBJECTS.ObjLibType = myLibObj.Type;
            if (moduleOBJECTS.ObjLibType == 0)
            {
                labelFS.Text = "Old FS8 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 1)
            {
                labelFS.Text = "Old FS9 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 2)
            {
                labelFS.Text = "New FSX Library Object";
            }

            cmdUpDefault.Enabled = false;
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgLib.Image = System.Drawing.Image.FromFile(a)
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void CmbMacroCat_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            if (!IsReady)
                return;

            // first remove all listings
            N = lstMacro.Items.Count;
            for (K = N; K >= 1; K -= 1)
                lstMacro.Items.RemoveAt(K - 1);

            // get the category index
            K = cmbMacroCat.SelectedIndex + 1;
            var loopTo = moduleMACROS.MacroCategories[K].NOB;
            for (N = 1; N <= loopTo; N++)
                lstMacro.Items.Add(moduleMACROS.MacroCategories[K].MacroObjects[N].Name);
            lstMacro.SelectedIndex = 0;
            ShowMacro(K, 1);
            moduleMACROS.MacroID = moduleMACROS.MacroCategories[K].MacroObjects[1].File;
            IsReady = true;
        }

        private void CmbRwy12Cat_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            string a;
            if (!IsReady)
                return;

            // first remove all listings
            N = lstRwy12.Items.Count;
            for (K = N; K >= 1; K -= 1)
                lstRwy12.Items.RemoveAt(K - 1);

            // get the category index
            K = cmbRwy12Cat.SelectedIndex + 1;
            var loopTo = moduleOBJECTS.Rwy12Categories[K].NOB;
            for (N = 1; N <= loopTo; N++)
                lstRwy12.Items.Add(moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].Name);
            lstRwy12.SelectedIndex = 0;
            txtRwy12ID.Text = moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[1].ID;
            txtRwy12Width.Text = 100.ToString();
            txtRwy12Length.Text = 100.ToString();
            txtRwy12Scale.Text = 1.ToString();
            a = moduleOBJECTS.Rwy12Path + @"\img\" + moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[1].Texture;
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgRwy12.Image = System.Drawing.Image.FromFile(a)
            imgRwy12.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdExpand_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.frmExtraMacro.ShowDialog();
        }

        private void CmdMacroEdit_Click(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            string a, b;

            // On Error Resume Next

            N = lstMacro.SelectedIndex + 1;
            K = cmbMacroCat.SelectedIndex + 1;
            b = moduleMACROS.MacroCategories[K].MacroObjects[N].File;
            a = Strings.Right(b, 3);
            if (a == "API")
                a = moduleMACROS.MacroAPIPath + @"\";
            if (a == "SCM")
                a = moduleMACROS.MacroASDPath + @"\";
            FileSystem.ChDir(a);
            b = a + b;
            a = "notepad.exe " + b;
            N = moduleMAIN.ExecCmd(a);
        }

        private void SetObjectProperties(int N)
        {
            string Macro;

            try
            {
                // insert here checking of values

                moduleOBJECTS.Objects[N].Width = 10f;
                moduleOBJECTS.Objects[N].Length = 10f;
                moduleOBJECTS.Objects[N].Heading = Conversions.ToSingle(txtHeading.Text);
                moduleOBJECTS.Objects[N].Pitch = Conversions.ToSingle(txtPitch.Text);
                moduleOBJECTS.Objects[N].Bank = Conversions.ToSingle(txtBank.Text);
                moduleOBJECTS.Objects[N].BiasX = Conversions.ToSingle(txtBiasX.Text);
                moduleOBJECTS.Objects[N].BiasY = Conversions.ToSingle(txtBiasY.Text);
                moduleOBJECTS.Objects[N].BiasZ = Conversions.ToSingle(txtBiasZ.Text);
                moduleOBJECTS.Objects[N].Altitude = Conversions.ToSingle(txtAltitude.Text);
                moduleOBJECTS.Objects[N].AGL = (int)ckAGL.CheckState;
                if (opVSparse.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 0;
                if (opSparse.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 1;
                if (opNormal.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 2;
                if (opDense.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 3;
                if (opVDense.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 4;
                if (opEDense.Checked)
                    moduleOBJECTS.Objects[N].Complexity = 5;
                if (optLib.Checked)
                {
                    if (moduleOBJECTS.ObjLibType == 0)
                    {
                        moduleOBJECTS.Objects[N].Type = 1;
                    }
                    else if (moduleOBJECTS.ObjLibType == 1)
                    {
                        moduleOBJECTS.Objects[N].Type = 2;
                    }
                    else if (moduleOBJECTS.ObjLibType == 2)
                    {
                        moduleOBJECTS.Objects[N].Type = 0;
                    }

                    moduleOBJECTS.ObjLibID = txtLibID.Text;
                    moduleOBJECTS.ObjLibScale = Conversions.ToSingle(txtLibScale.Text);
                    moduleOBJECTS.ObjLibV1 = Conversions.ToSingle(txtV1.Text);
                    moduleOBJECTS.ObjLibV2 = Conversions.ToSingle(txtV2.Text);
                    moduleOBJECTS.Objects[N].Width = Conversions.ToSingle(txtLibWidth.Text);
                    moduleOBJECTS.Objects[N].Length = Conversions.ToSingle(txtLibLength.Text);
                }

                if (optRwy12.Checked)
                {
                    moduleOBJECTS.Objects[N].Type = 3;
                    moduleOBJECTS.ObjLibID = txtRwy12ID.Text;
                    moduleOBJECTS.ObjLibScale = Conversions.ToSingle(txtRwy12Scale.Text);
                    moduleOBJECTS.Objects[N].Width = Conversions.ToSingle(txtRwy12Width.Text);
                    moduleOBJECTS.Objects[N].Length = Conversions.ToSingle(txtRwy12Length.Text);
                }

                Macro = "";
                if (optMacro.Checked)
                {
                    if (Strings.Right(moduleMACROS.MacroID, 3) == "API")
                        Macro = "API";
                    if (Strings.Right(moduleMACROS.MacroID, 3) == "SCM")
                        Macro = "ASD";
                }

                if (Macro == "API")
                {
                    moduleOBJECTS.Objects[N].Type = 4;
                    moduleOBJECTS.Objects[N].Width = Conversions.ToSingle(txtMacroWidth.Text);
                    moduleOBJECTS.Objects[N].Length = Conversions.ToSingle(txtMacroLength.Text);
                    moduleMACROS.MacroScale = Conversions.ToSingle(txtMacroScale.Text);
                    moduleMACROS.MacroRange = Conversions.ToInteger(txtMacroRange.Text);
                    moduleMACROS.MacroVisibility = Conversions.ToSingle(txtV1.Text);
                    moduleMACROS.MacroV2Value = Conversions.ToSingle(txtV2.Text);
                    moduleMACROS.MacroP6Value = txtP6.Text;
                    moduleMACROS.MacroP7Value = txtP7.Text;
                    moduleMACROS.MacroP8Value = txtP8.Text;
                    moduleMACROS.MacroP9Value = txtP9.Text;
                }

                if (Macro == "ASD")
                {
                    moduleOBJECTS.Objects[N].Type = 5;
                    moduleOBJECTS.Objects[N].Width = Conversions.ToSingle(txtMacroWidth.Text);
                    moduleOBJECTS.Objects[N].Length = Conversions.ToSingle(txtMacroLength.Text);
                    moduleMACROS.MacroScale = Conversions.ToSingle(txtMacroScale.Text);
                    moduleMACROS.MacroRange = Conversions.ToInteger(txtMacroRange.Text);
                    moduleMACROS.MacroVisibility = Conversions.ToSingle(txtV1.Text);
                    moduleMACROS.MacroP6Value = txtP6.Text;
                    moduleMACROS.MacroP7Value = txtP7.Text;
                    moduleMACROS.MacroP8Value = txtP8.Text;
                    if (lbP9.Visible)
                        moduleMACROS.MacroP9Value = txtP9.Text;
                }

                if (optTaxiwaySign.Checked)
                {
                    moduleOBJECTS.Objects[N].Type = 8;
                    moduleOBJECTS.ObjTaxSize = Conversions.ToInteger(combTaxiwaySize.Text);
                    moduleOBJECTS.ObjTaxJust = combTaxiwayJustification.Text;
                    moduleOBJECTS.ObjTaxLabel = txtTaxiwayText.Text;
                }

                if (optEffect.Checked)
                {
                    moduleOBJECTS.Objects[N].Type = 16;
                    moduleOBJECTS.ObjEffName = txtEffectName.Text;
                    moduleOBJECTS.ObjEffParameters = txtEffectParameters.Text;
                }

                if (optBeacon.Checked)
                {
                    moduleOBJECTS.Objects[N].Type = 32;
                    moduleOBJECTS.ObjBeaCivil = 0;
                    moduleOBJECTS.ObjBeaMil = 0;
                    moduleOBJECTS.ObjBeaAirport = 0;
                    moduleOBJECTS.ObjBeaHeliport = 0;
                    moduleOBJECTS.ObjBeaSeaBase = 0;
                    if (optBeaconCivilian.Checked)
                        moduleOBJECTS.ObjBeaCivil = 1;
                    if (optBeaconMil.Checked)
                        moduleOBJECTS.ObjBeaMil = 1;
                    if (optBeaconAirport.Checked)
                        moduleOBJECTS.ObjBeaAirport = 1;
                    if (optBeaconSeaBase.Checked)
                        moduleOBJECTS.ObjBeaSeaBase = 1;
                    if (optBeaconHeliport.Checked)
                        moduleOBJECTS.ObjBeaHeliport = 1;
                }

                if (optWindsock.Checked)
                {
                    moduleOBJECTS.Objects[N].Type = 64;
                    moduleOBJECTS.ObjWinLight = 0;
                    if ((int)ckWindsockLight.CheckState == 1)
                        moduleOBJECTS.ObjWinLight = 1;
                    moduleOBJECTS.ObjWinLength = Conversions.ToSingle(txtWindsockLength.Text);
                    moduleOBJECTS.ObjWinHeight = Conversions.ToSingle(txtWindsockHeight.Text);
                    moduleOBJECTS.ObjWindPoleColor = ColorTranslator.ToOle(txtWindsockHeight.BackColor);
                    moduleOBJECTS.ObjWindSockColor = ColorTranslator.ToOle(txtWindsockLength.BackColor);
                }

                if (optMDL.Checked)
                {
                    moduleOBJECTS.Objects[N].Width = Conversions.ToSingle(txtMDLWidth.Text);
                    moduleOBJECTS.Objects[N].Length = Conversions.ToSingle(txtMDLLength.Text);
                    moduleOBJECTS.ObjMDLFile = txtMDLFile.Text;
                    moduleOBJECTS.ObjMDLGuid = labelMDLguid.Text;
                    moduleOBJECTS.ObjMDLScale = (float)Conversion.Val(txtMDLscale.Text);
                    moduleOBJECTS.ObjMDLName = labelMDLName.Text;
                    if (Strings.Mid(moduleOBJECTS.ObjMDLGuid, 1, 1) == "{")
                    {
                        moduleOBJECTS.Objects[N].Type = 128;  // FSX type
                    }
                    else
                    {
                        moduleOBJECTS.Objects[N].Type = 129;
                    }  // FS9 type
                }

                if (optGenB.Checked)
                {
                    moduleOBJECTS.Objects[N].Width = (float)nUPsizeX.Value;
                    moduleOBJECTS.Objects[N].Length = (float)nUPsizeZ.Value;
                    if (optGbFlat.Checked)
                        moduleOBJECTS.Objects[N].Type = 256;
                    if (optGbPeaked.Checked)
                        moduleOBJECTS.Objects[N].Type = 257;
                    if (optGbRidge.Checked)
                        moduleOBJECTS.Objects[N].Type = 258;
                    if (optGbSlant.Checked)
                        moduleOBJECTS.Objects[N].Type = 259;
                    if (optGbPyramidal.Checked)
                        moduleOBJECTS.Objects[N].Type = 260;
                    if (optGbMultiSided.Checked)
                        moduleOBJECTS.Objects[N].Type = 261;
                    moduleOBJECTS.scale_gb = (float)nUPscale.Value;
                }

                return;
            }
            catch (Exception exc)
            {
                Interaction.MsgBox("Could not set object properties!", MsgBoxStyle.Exclamation);
            }
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (optLib.Checked)
            {
                if (lstLib.SelectedIndex == -1)
                {
                    Close();   // unknow so do nothing
                    return;
                }
            }

            int N;
            moduleMAIN.Dirty = true;
            if (Mode == "One")
            {
                N = modulePOPUP.POPIndex;
                if (N > moduleOBJECTS.NoOfObjects)
                {
                    Array.Resize(ref moduleOBJECTS.Objects, N + 1);
                    moduleOBJECTS.NoOfObjects = moduleOBJECTS.NoOfObjects + 1;
                    // added October 2017
                    moduleEDIT.BackUp();
                }

                SetObjectProperties(N);
                // IniObjType = Objects(N).Type
                moduleOBJECTS.Objects[N].lat = moduleMAIN.Str2Lat(txtLat.Text);
                moduleOBJECTS.Objects[N].lon = moduleMAIN.Str2Lon(txtLon.Text);
                moduleOBJECTS.ObjComment = txtComment.Text;
                moduleOBJECTS.ObjComment = Strings.Replace(moduleOBJECTS.ObjComment, " ", "_");
                moduleOBJECTS.Objects[N].Description = moduleOBJECTS.MakeDescription(N);
                moduleOBJECTS.AddLatLonToObjects(N);
            }
            // ElseIf Mode = "RGN" Then 
            // SetRGNProperties()
            // RGNPointType1 = MakeRGNPointType1
            // RGNPointType2 = MakeRGNPointType2
            else if (Mode == "Many")
            {
                var loopTo = moduleOBJECTS.NoOfObjects;
                for (N = 1; N <= loopTo; N++)
                {
                    if (moduleOBJECTS.Objects[N].Selected)
                    {
                        // ObjComment = GetObjectName(N)
                        moduleOBJECTS.ObjComment = txtComment.Text;
                        SetObjectProperties(N);
                        moduleOBJECTS.Objects[N].Description = moduleOBJECTS.MakeDescription(N);
                        moduleOBJECTS.AddLatLonToObjects(N);
                    }
                }
            }

            moduleMAIN.RebuildDisplay();

            // should I realy comment the following? October 2017
            // Close()
            Dispose();
        }

        private void CmdOption_Click(object eventSender, EventArgs eventArgs)
        {
            if (optLib.Checked)
                SSTab1.SelectedIndex = 1;
            if (optGenB.Checked)
                SSTab1.SelectedIndex = 2;
            if (optMacro.Checked)
                SSTab1.SelectedIndex = 3;
            if (optRwy12.Checked)
                SSTab1.SelectedIndex = 4;
            if (optBeacon.Checked)
                SSTab1.SelectedIndex = 5;
            if (optTaxiwaySign.Checked)
                SSTab1.SelectedIndex = 5;
            if (optEffect.Checked)
                SSTab1.SelectedIndex = 5;
            if (optWindsock.Checked)
                SSTab1.SelectedIndex = 5;
            if (optMDL.Checked)
                SSTab1.SelectedIndex = 5;
        }

        private void CmdOrder_Click(object eventSender, EventArgs eventArgs)
        {
            if (moduleOBJECTS.NoOfObjects < 2)
            {
                Interaction.MsgBox("At least 2 objects must exist!", MsgBoxStyle.Information);
                return;
            }

            moduleOBJECTS.ObjOrder = false;
            My.MyProject.Forms.FrmOrder.ShowDialog();
            if (moduleOBJECTS.ObjOrder)
                Dispose();
        }

        private void CmdPosFs_Click(object eventSender, EventArgs eventArgs)
        {
            float Bank, Altitude, Pitch, Heading;
            double Lat, Lon;
            try
            {
                if (moduleMAIN.AircraftVIEW)   // this on May 25 2009
                {
                    FSUIPCConnection.Close();
                    My.MyProject.Forms.FrmStart.UpdateAircraft(0);
                    My.MyProject.Forms.FrmStart.ShowAircraftMenuItem.Checked = false;
                    moduleMAIN.AircraftVIEW = false;
                }

                FSUIPCConnection.Open();
                FSUIPCConnection.Process();
                Lat = My.MyProject.Forms.FrmStart.LatAircraft.Value;
                Lat = Lat * 90.0d / (10001750.0d * 65536.0d * 65536.0d);
                Lon = My.MyProject.Forms.FrmStart.LonAircraft.Value;
                Lon = Lon * 360.0d / (65536.0d * 65536.0d * 65536.0d * 65536.0d);
                Altitude = My.MyProject.Forms.FrmStart.Alt1Aircraft.Value;
                Altitude = Altitude + My.MyProject.Forms.FrmStart.Alt2Aircraft.Value / (65536.0f * 65536.0f);
                Altitude = (float)(Altitude - moduleMAIN.AircraftAltitudeOffset);
                Bank = My.MyProject.Forms.FrmStart.BankAircraft.Value * 360.0f / (65536.0f * 65536.0f);
                Pitch = My.MyProject.Forms.FrmStart.PitchAircraft.Value * 360.0f / (65536.0f * 65536.0f);
                Heading = My.MyProject.Forms.FrmStart.HeadingAircraft.Value * 360.0f / (65536.0f * 65536.0f);
                if (Heading < 0f)
                    Heading = Heading + 360f;
                FSUIPCConnection.Close();
            }
            catch (Exception ex)
            {
                FSUIPCConnection.Close();
                Interaction.MsgBox("Error communicating with FSUIPC!", MsgBoxStyle.Information);
                return;
            }

            txtLon.Text = moduleMAIN.Lon2Str(Lon);
            txtLat.Text = moduleMAIN.Lat2Str(Lat);
            txtAltitude.Text = Strings.Format(Altitude, "0.000");
            txtBank.Text = Strings.Format(Bank, "0.000");
            txtPitch.Text = Strings.Format(Pitch, "0.000");
            txtHeading.Text = Strings.Format(Heading, "0.000");
        }

        private void CmdTaxiwayHelp_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FrmTaxSign.ShowDialog();
        }

        public void ShowForAllSelected()
        {
            Mode = "Many";
            lbComment.Enabled = false;
            txtComment.Enabled = false;
            cmdOrder.Enabled = false;
            txtLat.Enabled = false;
            txtLon.Enabled = false;
            Label1.Enabled = false;
            Label2.Enabled = false;
            cmdPosFs.Enabled = false;

            // optLib_CheckedChanged(optLib, New System.EventArgs())

            if (!moduleOBJECTS.LibObjectsIsOn)
                optLib.Enabled = false;
            if (!moduleOBJECTS.Rwy12IsOn)
                optRwy12.Enabled = false;
            if (moduleMACROS.MacroAPIIsOn == false & moduleMACROS.MacroASDIsOn == false)
                optMacro.Enabled = false;
            if (moduleOBJECTS.LibObjectsIsOn)
                FillLibList();
            if (moduleOBJECTS.Rwy12IsOn)
                FillRwy12List();
            if (moduleMACROS.MacroAPIIsOn)
                FillMacroList();
        }

        public void ShowObjectProperties(int N)
        {
            int K;
            string a;
            IsReady = false;
            Mode = "One";
            SSTab1.SelectedIndex = 0;
            // cmdOrder.Enabled = True

            if (N > moduleOBJECTS.NoOfObjects)
            {
                cmdOrder.Enabled = false;
            }

            if (!moduleOBJECTS.LibObjectsIsOn)
                optLib.Enabled = false;
            if (!moduleOBJECTS.Rwy12IsOn)
                optRwy12.Enabled = false;
            if (moduleMACROS.MacroAPIIsOn == false & moduleMACROS.MacroASDIsOn == false)
                optMacro.Enabled = false;
            DisableAllTypes();
            if (N > moduleOBJECTS.NoOfObjects)   // is a new object place with mouse
            {
                if (moduleOBJECTS.ObjMYes)
                {
                    txtHeading.Text = moduleOBJECTS.ObjMHead.ToString();
                    moduleOBJECTS.ObjMYes = false;
                }

                txtLat.Text = moduleMAIN.Lat2Str(moduleOBJECTS.LatObj);
                txtLon.Text = moduleMAIN.Lon2Str(moduleOBJECTS.LonObj);
                if (moduleOBJECTS.LibObjectsIsOn)
                {
                    optLib.Checked = true;
                    SetEnableLib(true);
                    FillLibList();
                    SSTab1.SelectedIndex = 1;
                }
                else
                {
                    optLib.Checked = false;
                    SSTab1.SelectedIndex = 0;
                }
            }
            // ShowIniObject()


            else  // it is an existing object >> show the properties 
            {
                optLib.Checked = false;
                optMacro.Checked = false;
                optRwy12.Checked = false;
                optTaxiwaySign.Checked = false;
                optEffect.Checked = false;
                optBeacon.Checked = false;
                optWindsock.Checked = false;
                optMDL.Checked = false;
                optGenB.Checked = false;
                if (moduleOBJECTS.Objects[N].Type == 0)
                {
                    optLib.Checked = true;
                    SetEnableLib(true);
                    a = moduleOBJECTS.Objects[N].Description;
                    K = Strings.InStr(1, a, "|");
                    moduleOBJECTS.ObjLibID = Strings.Mid(a, 1, K - 1);
                    FillLibList();
                    moduleOBJECTS.ObjLibType = 2;
                    moduleOBJECTS.AnalyseLibObject(N);
                    txtLibID.Text = moduleOBJECTS.ObjLibID;
                    txtLibScale.Text = moduleOBJECTS.ObjLibScale.ToString();
                    txtLibWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                    txtLibLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                    // cmdUpDefault.Enabled = True
                    txtV1.Text = "0";
                    txtV2.Text = "0";
                    SSTab1.SelectedIndex = 1;
                }

                if (moduleOBJECTS.Objects[N].Type == 1)
                {
                    optLib.Checked = true;
                    SetEnableLib(true);
                    a = moduleOBJECTS.Objects[N].Description;
                    K = Strings.InStr(1, a, "|");
                    moduleOBJECTS.ObjLibID = Strings.Mid(a, 1, K - 1);
                    FillLibList();
                    moduleOBJECTS.ObjLibType = 0;
                    moduleOBJECTS.AnalyseLibObject(N);
                    txtLibID.Text = moduleOBJECTS.ObjLibID;
                    txtLibScale.Text = moduleOBJECTS.ObjLibScale.ToString();
                    txtLibWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                    txtLibLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                    // cmdUpDefault.Enabled = True
                    txtV1.Text = moduleOBJECTS.ObjLibV1.ToString();
                    txtV2.Text = moduleOBJECTS.ObjLibV2.ToString();
                    SSTab1.SelectedIndex = 1;
                }

                if (moduleOBJECTS.Objects[N].Type == 2)
                {
                    optLib.Checked = true;
                    SetEnableLib(true);
                    a = moduleOBJECTS.Objects[N].Description;
                    K = Strings.InStr(1, a, "|");
                    moduleOBJECTS.ObjLibID = Strings.Mid(a, 1, K - 1);
                    FillLibList();
                    moduleOBJECTS.ObjLibType = 1;
                    moduleOBJECTS.AnalyseLibObject(N);
                    txtLibID.Text = moduleOBJECTS.ObjLibID;
                    txtLibScale.Text = moduleOBJECTS.ObjLibScale.ToString();
                    txtLibWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                    txtLibLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                    // cmdUpDefault.Enabled = True
                    txtV1.Text = "0";
                    txtV2.Text = "0";
                    SSTab1.SelectedIndex = 1;
                }

                if (moduleOBJECTS.Objects[N].Type == 3)
                {
                    if (moduleOBJECTS.Rwy12IsOn)
                    {
                        optRwy12.Checked = true;
                        SetEnableRwy12(true);
                        a = moduleOBJECTS.Objects[N].Description;
                        K = Strings.InStr(1, a, "|");
                        moduleOBJECTS.ObjLibID = Strings.Mid(a, 1, K - 1);
                        FillRwy12List();
                        moduleOBJECTS.ObjLibType = 1;
                        moduleOBJECTS.AnalyseLibObject(N);
                        txtRwy12ID.Text = moduleOBJECTS.ObjLibID;
                        txtRwy12Scale.Text = moduleOBJECTS.ObjLibScale.ToString();
                        txtRwy12Width.Text = moduleOBJECTS.Objects[N].Width.ToString();
                        txtRwy12Length.Text = moduleOBJECTS.Objects[N].Length.ToString();
                        SSTab1.SelectedIndex = 4;
                    }
                    else
                    {
                        Interaction.MsgBox("You can not edit this object as a Rwy12 object!", MsgBoxStyle.Exclamation);
                        optLib.Checked = true;
                        SetEnableLib(true);
                        a = moduleOBJECTS.Objects[N].Description;
                        K = Strings.InStr(1, a, "|");
                        moduleOBJECTS.ObjLibID = Strings.Mid(a, 1, K - 1);
                        FillLibList();
                        moduleOBJECTS.ObjLibType = 1;
                        moduleOBJECTS.AnalyseLibObject(N);
                        txtLibID.Text = moduleOBJECTS.ObjLibID;
                        txtLibScale.Text = moduleOBJECTS.ObjLibScale.ToString();
                        txtLibWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                        txtLibLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                        // cmdUpDefault.Enabled = True
                        SSTab1.SelectedIndex = 1;
                    }
                }

                if (moduleOBJECTS.Objects[N].Type == 4)
                {
                    if (moduleMACROS.MacroAPIIsOn)
                    {
                        optMacro.Checked = true;
                        SetEnableMacro(true);
                        a = moduleOBJECTS.Objects[N].Description;
                        K = Strings.InStr(1, a, "|");
                        moduleMACROS.MacroID = Strings.Mid(a, 1, K - 1);
                        FillMacroList(); // uses MacroID
                        moduleMACROS.AnalyseAPIMacro(N);
                        txtMacroScale.Text = moduleMACROS.MacroScale.ToString();
                        txtMacroRange.Text = moduleMACROS.MacroRange.ToString();
                        txtMacroWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                        txtMacroLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                        txtV1.Text = moduleMACROS.MacroVisibility.ToString();
                        txtV2.Text = moduleMACROS.MacroV2Value.ToString();
                        txtP6.Text = moduleMACROS.MacroP6Value;
                        txtP7.Text = moduleMACROS.MacroP7Value;
                        txtP8.Text = moduleMACROS.MacroP8Value;
                        txtP9.Text = moduleMACROS.MacroP9Value;
                        SSTab1.SelectedIndex = 3;
                    }
                    else
                    {
                        Interaction.MsgBox("You can not edit this object as an API macro!", MsgBoxStyle.Exclamation);
                    }
                }

                if (moduleOBJECTS.Objects[N].Type == 5)
                {
                    if (moduleMACROS.MacroASDIsOn)
                    {
                        optMacro.Checked = true;
                        SetEnableMacro(true);
                        a = moduleOBJECTS.Objects[N].Description;
                        K = Strings.InStr(1, a, "|");
                        moduleMACROS.MacroID = Strings.Mid(a, 1, K - 1);
                        FillMacroList(); // uses MacroID
                        moduleMACROS.AnalyseASDMacro(N);
                        txtMacroScale.Text = moduleMACROS.MacroScale.ToString();
                        txtMacroRange.Text = moduleMACROS.MacroRange.ToString();
                        txtMacroWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                        txtMacroLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                        txtV1.Text = moduleMACROS.MacroVisibility.ToString();
                        txtP6.Text = moduleMACROS.MacroP6Value;
                        txtP7.Text = moduleMACROS.MacroP7Value;
                        txtP8.Text = moduleMACROS.MacroP8Value;
                        txtP9.Text = moduleMACROS.MacroP9Value;
                        SSTab1.SelectedIndex = 3;
                    }
                    else
                    {
                        Interaction.MsgBox("You can not edit this object as an ASD macro!", MsgBoxStyle.Exclamation);
                    }
                }

                if (moduleOBJECTS.Objects[N].Type == 8)
                {
                    optTaxiwaySign.Checked = true;
                    SetEnableTaxiway(true);
                    moduleOBJECTS.AnalyseTaxiwayObject(N);
                    txtTaxiwayText.Text = moduleOBJECTS.ObjTaxLabel;
                    combTaxiwaySize.Text = moduleOBJECTS.ObjTaxSize.ToString();
                    combTaxiwayJustification.Text = moduleOBJECTS.ObjTaxJust;
                    SSTab1.SelectedIndex = 5;
                }

                if (moduleOBJECTS.Objects[N].Type == 16)
                {
                    optEffect.Checked = true;
                    SetEnableEffect(true);
                    moduleOBJECTS.AnalyseEffectObject(N);
                    txtEffectName.Text = moduleOBJECTS.ObjEffName;
                    txtEffectParameters.Text = moduleOBJECTS.ObjEffParameters;
                    SSTab1.SelectedIndex = 5;
                }

                if (moduleOBJECTS.Objects[N].Type == 32)
                {
                    optBeacon.Checked = true;
                    SetEnableBeacon(true);
                    moduleOBJECTS.AnalyseBeaconObject(N);
                    optBeaconCivilian.Checked = false;
                    optBeaconMil.Checked = false;
                    optBeaconAirport.Checked = false;
                    optBeaconSeaBase.Checked = false;
                    optBeaconHeliport.Checked = false;
                    if (moduleOBJECTS.ObjBeaCivil == 1)
                        optBeaconCivilian.Checked = true;
                    if (moduleOBJECTS.ObjBeaMil == 1)
                        optBeaconMil.Checked = true;
                    if (moduleOBJECTS.ObjBeaAirport == 1)
                        optBeaconAirport.Checked = true;
                    if (moduleOBJECTS.ObjBeaSeaBase == 1)
                        optBeaconSeaBase.Checked = true;
                    if (moduleOBJECTS.ObjBeaHeliport == 1)
                        optBeaconHeliport.Checked = true;
                    SSTab1.SelectedIndex = 5;
                }

                if (moduleOBJECTS.Objects[N].Type == 64)
                {
                    optWindsock.Checked = true;
                    SetEnableWindSock(true);
                    moduleOBJECTS.AnalyseWindsockObject(N);
                    ckWindsockLight.CheckState = (CheckState)moduleOBJECTS.ObjWinLight;
                    txtWindsockHeight.Text = moduleOBJECTS.ObjWinHeight.ToString();
                    txtWindsockLength.Text = moduleOBJECTS.ObjWinLength.ToString();
                    txtWindsockHeight.BackColor = ColorTranslator.FromOle(moduleOBJECTS.ObjWindPoleColor);
                    txtWindsockLength.BackColor = ColorTranslator.FromOle(moduleOBJECTS.ObjWindSockColor);
                    txtWindsockHeight.ForeColor = moduleMAIN.InvertColor(txtWindsockHeight.BackColor);
                    txtWindsockLength.ForeColor = moduleMAIN.InvertColor(txtWindsockLength.BackColor);
                    SSTab1.SelectedIndex = 5;
                }

                if (moduleOBJECTS.Objects[N].Type == 128 | moduleOBJECTS.Objects[N].Type == 129)
                {
                    optMDL.Checked = true;
                    SetEnableMDL(true);
                    moduleOBJECTS.AnalyseMDLObject(N);
                    txtMDLWidth.Text = moduleOBJECTS.Objects[N].Width.ToString();
                    txtMDLLength.Text = moduleOBJECTS.Objects[N].Length.ToString();
                    txtMDLFile.Text = moduleOBJECTS.ObjMDLFile;
                    labelMDLName.Text = moduleOBJECTS.ObjMDLName;
                    labelMDLguid.Text = moduleOBJECTS.ObjMDLGuid;
                    txtMDLscale.Text = moduleOBJECTS.ObjMDLScale.ToString();
                    SSTab1.SelectedIndex = 5;
                }

                if (moduleOBJECTS.Objects[N].Type > 255)
                {
                    optGenB.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 256)
                        optGbFlat.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 257)
                        optGbPeaked.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 258)
                        optGbRidge.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 259)
                        optGbSlant.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 260)
                        optGbPyramidal.Checked = true;
                    if (moduleOBJECTS.Objects[N].Type == 261)
                        optGbMultiSided.Checked = true;
                    SetEnableGenB(true);
                    FillGenBList();
                    moduleOBJECTS.AnalyseGenBObject(N);
                    moduleOBJECTS.sizeX = moduleOBJECTS.Objects[N].Width;
                    moduleOBJECTS.sizeZ = moduleOBJECTS.Objects[N].Length;
                    nUPsizeX.Value = (decimal)moduleOBJECTS.sizeX;
                    nUPsizeZ.Value = (decimal)moduleOBJECTS.sizeZ;
                    nUPscale.Value = (decimal)moduleOBJECTS.scale_gb;
                    SSTab1.SelectedIndex = 2;
                }

                txtLat.Text = moduleMAIN.Lat2Str(moduleOBJECTS.Objects[N].lat);
                txtLon.Text = moduleMAIN.Lon2Str(moduleOBJECTS.Objects[N].lon);
                txtHeading.Text = moduleOBJECTS.Objects[N].Heading.ToString();
                txtPitch.Text = moduleOBJECTS.Objects[N].Pitch.ToString();
                txtBank.Text = moduleOBJECTS.Objects[N].Bank.ToString();
                txtBiasX.Text = moduleOBJECTS.Objects[N].BiasX.ToString();
                txtBiasY.Text = moduleOBJECTS.Objects[N].BiasY.ToString();
                txtBiasZ.Text = moduleOBJECTS.Objects[N].BiasZ.ToString();
                txtAltitude.Text = moduleOBJECTS.Objects[N].Altitude.ToString();
                if (moduleOBJECTS.Objects[N].Complexity == 0)
                    opVSparse.Checked = true;
                if (moduleOBJECTS.Objects[N].Complexity == 1)
                    opSparse.Checked = true;
                if (moduleOBJECTS.Objects[N].Complexity == 2)
                    opNormal.Checked = true;
                if (moduleOBJECTS.Objects[N].Complexity == 3)
                    opDense.Checked = true;
                if (moduleOBJECTS.Objects[N].Complexity == 4)
                    opVDense.Checked = true;
                if (moduleOBJECTS.Objects[N].Complexity == 5)
                    opEDense.Checked = true;
                ckAGL.CheckState = (CheckState)moduleOBJECTS.Objects[N].AGL;
                txtComment.Text = moduleOBJECTS.ObjComment;
            }

            IsInit = false;
            IsReady = true;
        }

        private void DisableAllTypes()
        {
            SetEnableBeacon(false);
            SetEnableTaxiway(false);
            SetEnableEffect(false);
            SetEnableLib(false);
            SetEnableWindSock(false);
            SetEnableMacro(false);
            SetEnableRwy12(false);
            SetEnableMDL(false);
            SetEnableGenB(false);
        }

        private void SetEnableRwy12(bool Flag)
        {

            // frRwy12.Enabled = Flag

            txtRwy12Width.Enabled = Flag;
            txtRwy12Length.Enabled = Flag;
            txtRwy12Scale.Enabled = Flag;
            LabelRwy12Length.Enabled = Flag;
            LabelRwy12Width.Enabled = Flag;
            LabelRwy12Scale.Enabled = Flag;
            labelRwy12Mouse.Enabled = Flag;
            LabelRwy121.Enabled = Flag;
            LabelRwy12Cat.Enabled = Flag;
            cmbRwy12Cat.Enabled = Flag;
            imgRwy12.Visible = Flag;
            lstRwy12.Enabled = Flag;
            txtRwy12ID.Enabled = Flag;
        }

        private void SetEnableMacro(bool Flag)
        {

            // frMacro.Enabled = Flag
            // frMacro1.Enabled = Flag

            lbP6.Enabled = Flag;
            lbP7.Enabled = Flag;
            lbP8.Enabled = Flag;
            lbP9.Enabled = Flag;
            txtP6.Enabled = Flag;
            txtP7.Enabled = Flag;
            txtP8.Enabled = Flag;
            txtP9.Enabled = Flag;
            txtMacroWidth.Enabled = Flag;
            txtMacroLength.Enabled = Flag;
            txtMacroRange.Enabled = Flag;
            txtMacroScale.Enabled = Flag;
            LabelMacroLength.Enabled = Flag;
            LabelMacroWidth.Enabled = Flag;
            LabelMacroScale.Enabled = Flag;
            LabelMacroRange.Enabled = Flag;
            LabelMacro1.Enabled = Flag;
            labelMacroMouse.Enabled = Flag;
            LabelMacroCat.Enabled = Flag;
            cmbMacroCat.Enabled = Flag;
            imgMacro.Visible = Flag;
            lstMacro.Enabled = Flag;
            cmdExpand.Visible = false;
            cmdMacroEdit.Enabled = Flag;
        }

        private void SetEnableBeacon(bool Flag)
        {

            // frBeaconType.Enabled = Flag
            // frBeaconBase.Enabled = Flag
            optBeaconCivilian.Enabled = Flag;
            optBeaconMil.Enabled = Flag;
            optBeaconAirport.Enabled = Flag;
            optBeaconHeliport.Enabled = Flag;
            optBeaconSeaBase.Enabled = Flag;
        }

        private void SetEnableWindSock(bool Flag)
        {

            // frWindsock.Enabled = Flag
            txtWindsockLength.Enabled = Flag;
            txtWindsockHeight.Enabled = Flag;
            ckWindsockLight.Enabled = Flag;
            LabelWin1.Enabled = Flag;
            LabelWin2.Enabled = Flag;
            LabelWin3.Enabled = Flag;
        }

        private void SetEnableTaxiway(bool Flag)
        {

            // frTaxiway.Enabled = Flag
            txtTaxiwayText.Enabled = Flag;
            combTaxiwaySize.Enabled = Flag;
            combTaxiwayJustification.Enabled = Flag;
            LabelTax1.Enabled = Flag;
            LabelTax2.Enabled = Flag;
            LabelTax3.Enabled = Flag;
            cmdTaxiwayHelp.Enabled = Flag;
        }

        private void SetEnableEffect(bool Flag)
        {

            // frEffect.Enabled = Flag
            txtEffectName.Enabled = Flag;
            txtEffectParameters.Enabled = Flag;
            LabelEffect1.Enabled = Flag;
            LabelEffect2.Enabled = Flag;
        }

        private void SetEnableMDL(bool Flag)
        {

            // frMDL.Enabled = Flag

            txtMDLWidth.Enabled = Flag;
            txtMDLLength.Enabled = Flag;
            txtMDLFile.Enabled = Flag;
            LabelMDL1.Enabled = Flag;
            LabelMDL2.Enabled = Flag;
            LabelMDL3.Enabled = Flag;
            labelMDLguid.Enabled = Flag;
            labelMDLName.Enabled = Flag;
            cmdMDL.Enabled = Flag;
        }

        private void SetEnableGenB(bool Flag)
        {
            frGenB.Enabled = Flag;
            // frGenBTextures.Enabled = Flag

            nUPsizeX.Enabled = Flag;
            nUPsizeZ.Enabled = Flag;
            nUPscale.Enabled = Flag;
            lbgb1.Enabled = Flag;
            lbgb2.Enabled = Flag;
            lbgb3.Enabled = Flag;
            cmdGbLoad.Enabled = Flag;
            cmdGbStore.Enabled = Flag;
            cmdGBDelete.Enabled = Flag;
            // cmdGBFind.Enabled = Flag
            cmdGbDetail.Enabled = Flag;
            lstGenB.Enabled = Flag;
            imgGenB.Visible = Flag;
            Label14.Enabled = Flag;
            Label15.Enabled = Flag;
        }

        private void SetEnableLib(bool Flag)
        {
            frLib.Enabled = Flag;
            txtLibWidth.Enabled = Flag;
            txtLibLength.Enabled = Flag;
            txtLibScale.Enabled = Flag;
            txtLibName.Enabled = Flag;
            LabelLib1.Enabled = Flag;
            labelLib2.Enabled = Flag;
            LabelLib3.Enabled = Flag;
            LabelLibName.Enabled = Flag;
            labelLibMouse.Enabled = Flag;
            labelFS.Enabled = Flag;

            // cmdUpDefault.Enabled = Flag
            LabelCat.Enabled = Flag;
            cmbLibCat.Enabled = Flag;
            imgLib.Visible = Flag;
            lstLib.Enabled = Flag;
            txtLibID.Enabled = Flag;
        }

        private void LstLib_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            string a, LibCat;
            if (!IsReady)
                return;

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            N = lstLib.SelectedIndex;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[N];
            txtLibID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            cmdUpDefault.Enabled = false;
            moduleOBJECTS.ObjLibType = myLibObj.Type;

            // after 205
            txtComment.Text = myLibObj.Name;
            if (moduleOBJECTS.ObjLibType == 0)
            {
                labelFS.Text = "Old FS8 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 1)
            {
                labelFS.Text = "Old FS9 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 2)
            {
                labelFS.Text = "New FSX Library Object";
            }

            // cmdUpDefault.Enabled = False


            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgLib.Image = System.Drawing.Image.FromFile(a)
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void LstMacro_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            if (!IsReady)
                return;

            // On Error Resume Next

            N = lstMacro.SelectedIndex + 1;
            K = cmbMacroCat.SelectedIndex + 1;
            ShowMacro(K, N);
            moduleMACROS.MacroID = moduleMACROS.MacroCategories[K].MacroObjects[N].File;
            IsReady = true;
        }

        private void LstRwy12_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!IsReady)
                return;
            int N, K;
            string a;
            N = lstRwy12.SelectedIndex + 1;
            K = cmbRwy12Cat.SelectedIndex + 1;
            txtRwy12ID.Text = moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].ID;

            // after 205
            txtComment.Text = moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].Name;
            a = moduleOBJECTS.Rwy12Path + @"\img\" + moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].Texture;
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgRwy12.Image = System.Drawing.Image.FromFile(a)
            imgRwy12.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
            IsReady = true;
        }

        private void OptMacro_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                if (moduleMACROS.MacroAPIIsOn == false & moduleMACROS.MacroASDIsOn == false)
                    return;
                SetEnableMacro(true);
                moduleMACROS.MacroID = "";
                FillMacroList();
                SSTab1.SelectedIndex = 3;
            }
        }

        private void OptEffect_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableEffect(true);
                SSTab1.SelectedIndex = 5;
                // after 205
                txtComment.Text = "Effect object";
            }
        }

        private void OptLib_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableLib(true);
                moduleOBJECTS.ObjLibID = "";
                FillLibList();
                SSTab1.SelectedIndex = 1;
            }
        }

        private void OptRwy12_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                if (!moduleOBJECTS.Rwy12IsOn)
                    return;
                SetEnableRwy12(true);
                moduleOBJECTS.ObjLibID = "";
                FillRwy12List();
                SSTab1.SelectedIndex = 4;
            }
        }

        private void OptBeacon_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableBeacon(true);
                SSTab1.SelectedIndex = 5;
                txtComment.Text = "Beacon object";
            }
        }

        private void OptTaxiwaySign_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableTaxiway(true);
                SSTab1.SelectedIndex = 5;
                // after 205
                txtComment.Text = "Taxiway Sign";
            }
        }

        private void OptWindSock_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableWindSock(true);
                SSTab1.SelectedIndex = 5;
                // after 205
                txtComment.Text = "WindSock object";
            }
        }

        private void OptMDL_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableMDL(true);
                SSTab1.SelectedIndex = 5;
                // after 205
                txtComment.Text = "MDL Model object";
            }
        }

        private void OptGenB_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(eventSender.GetType().GetField("Checked")))
            {
                if (IsInit)
                    return;
                DisableAllTypes();
                SetEnableGenB(true);
                FillGenBList();
                SSTab1.SelectedIndex = 2;
                // after 205
                txtComment.Text = "Generic_Building_Object";
            }
        }

        private void TxtWindsockHeight_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            moduleMAIN.ARGBColor = txtWindsockHeight.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                txtWindsockHeight.BackColor = moduleMAIN.ARGBColor;
            }

            txtWindsockHeight.ForeColor = moduleMAIN.InvertColor(moduleMAIN.ARGBColor);
        }

        private void TxtWindsockLength_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            moduleMAIN.ARGBColor = txtWindsockLength.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                txtWindsockLength.BackColor = moduleMAIN.ARGBColor;
            }

            txtWindsockLength.ForeColor = moduleMAIN.InvertColor(moduleMAIN.ARGBColor);
        }

        private void FillLibList()
        {

            // uses the ObjLibID and fills the category, the member list and
            // selects the object
            // if ObjLibID is nothing or not found then uses 1st obj in 1st cat

            int N = default, K;
            string a;
            string LibCat = "";
            moduleOBJECTS.LibObject g;
            moduleOBJECTS.LibObject myLibObj = default;
            if (moduleOBJECTS.NoOfLibCategories == 0)
                return;
            IsReady = false;

            // first remove
            lstLib.Items.Clear();
            cmbLibCat.Items.Clear();
            var loopTo = moduleOBJECTS.NoOfLibCategories;
            for (K = 1; K <= loopTo; K++)
                cmbLibCat.Items.Add(moduleOBJECTS.LibCategories[K].Name);
            bool Found = false;
            if (moduleOBJECTS.ObjLibID is null)
            {
                // Debug.Print("ObjLibID Is Nothing")
                myLibObj = moduleOBJECTS.LibCategories[1].Objs[0];
                moduleOBJECTS.ObjLibID = moduleOBJECTS.LibCategories[1].Objs[0].ID;
                Found = true;  // it is a new object not an unknown one!
                N = 0;
                K = 1;
            }
            else
            {
                var loopTo1 = moduleOBJECTS.NoOfLibCategories;
                for (K = 1; K <= loopTo1; K++)
                {
                    N = 0;
                    foreach (var currentG in moduleOBJECTS.LibCategories[K].Objs)
                    {
                        g = currentG;
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(g.ID, moduleOBJECTS.ObjLibID, false)))
                        {
                            myLibObj = g;
                            Found = true;
                            break;
                        }

                        N = N + 1;
                    }

                    if (Found)
                        break;
                }
            }

            if (!Found)
            {
                // Debug.Print("ObjLibID Not Found")
                myLibObj = moduleOBJECTS.LibCategories[1].Objs[0];
                N = 0;
                K = 1;
            }

            // select category
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            cmbLibCat.SelectedIndex = K - 1;

            // fill objects and set selected
            foreach (var currentG1 in moduleOBJECTS.LibCategories[K].Objs)
            {
                g = currentG1;
                lstLib.Items.Add(g.Name);
            }

            // txtLibID.Text = myLibObj.ID   ' changed when unknown was introduced
            txtLibID.Text = moduleOBJECTS.ObjLibID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            cmdUpDefault.Enabled = false;

            // after 205
            txtComment.Text = myLibObj.Name;
            moduleOBJECTS.ObjLibType = myLibObj.Type;
            if (moduleOBJECTS.ObjLibType == 0)
            {
                labelFS.Text = "Old FS8 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 1)
            {
                labelFS.Text = "Old FS9 Library Object";
            }
            else if (moduleOBJECTS.ObjLibType == 2)
            {
                labelFS.Text = "New FSX Library Object";
            }

            if (!Found)
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\unknown.jpg";
            }
            else
            {
                lstLib.SelectedIndex = N;
                a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
                moduleMAIN.ImageFileNameTrue = a;
                if (!File.Exists(a))
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
                }
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
            IsReady = true;
        }

        private void FillRwy12List()
        {

            // uses the ObjLibID and fills the category, the member list and
            // selects the object
            // if ObjLibID not found then uses the first one in objects.txt

            int K, N, J;
            string a;
            bool Flag;

            // first remove

            IsReady = false;

            // first remove all categories
            N = cmbRwy12Cat.Items.Count;
            for (K = N; K >= 1; K -= 1)
                cmbRwy12Cat.Items.RemoveAt(K - 1);

            // first remove all objects
            N = lstRwy12.Items.Count;
            for (K = N; K >= 1; K -= 1)
                lstRwy12.Items.RemoveAt(K - 1);
            var loopTo = moduleOBJECTS.NoOfRwy12Categories;
            for (K = 1; K <= loopTo; K++)
                cmbRwy12Cat.Items.Add(moduleOBJECTS.Rwy12Categories[K].Name);
            Flag = true;
            var loopTo1 = moduleOBJECTS.NoOfRwy12Categories;
            for (K = 1; K <= loopTo1; K++)
            {
                var loopTo2 = moduleOBJECTS.Rwy12Categories[K].NOB;
                for (N = 1; N <= loopTo2; N++)
                {
                    if ((moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].ID ?? "") == (moduleOBJECTS.ObjLibID ?? ""))
                    {
                        Flag = false;
                        goto HERE;
                    }
                }
            }

        HERE:
            ;
            if (Flag)
            {
                K = 1;
                N = 1;
            }

            cmbRwy12Cat.SelectedIndex = K - 1;
            var loopTo3 = moduleOBJECTS.Rwy12Categories[K].NOB;
            for (J = 1; J <= loopTo3; J++)
                lstRwy12.Items.Add(moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[J].Name);
            lstRwy12.SelectedIndex = N - 1;
            txtRwy12ID.Text = moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].ID;
            txtRwy12Width.Text = 100.ToString();
            txtRwy12Length.Text = 100.ToString();
            txtRwy12Scale.Text = 1.ToString();
            a = moduleOBJECTS.Rwy12Path + @"\img\" + moduleOBJECTS.Rwy12Categories[K].Rwy12Objects[N].Texture;
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgRwy12.Image = System.Drawing.Image.FromFile(a)
            imgRwy12.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
            IsReady = true;
        }

        private void FillMacroList()
        {

            // uses the MacroID and fills the category, the member list and
            // selects the object
            // if MacroID not found then uses the first one in objects.txt

            int K, N, J;
            bool Flag;
            // first remove

            IsReady = false;

            // first remove all categories
            N = cmbMacroCat.Items.Count;
            for (K = N; K >= 1; K -= 1)
                cmbMacroCat.Items.RemoveAt(K - 1);

            // first remove all objects
            N = lstMacro.Items.Count;
            for (K = N; K >= 1; K -= 1)
                lstMacro.Items.RemoveAt(K - 1);
            var loopTo = moduleMACROS.NoOfMacroCategories;
            for (K = 1; K <= loopTo; K++)
                cmbMacroCat.Items.Add(moduleMACROS.MacroCategories[K].Name);
            Flag = true;
            var loopTo1 = moduleMACROS.NoOfMacroCategories;
            for (K = 1; K <= loopTo1; K++)
            {
                var loopTo2 = moduleMACROS.MacroCategories[K].NOB;
                for (N = 1; N <= loopTo2; N++)
                {
                    if ((moduleMACROS.MacroCategories[K].MacroObjects[N].File ?? "") == (moduleMACROS.MacroID ?? ""))
                    {
                        Flag = false;
                        goto HERE;
                    }
                }
            }

        HERE:
            ;
            if (Flag)
            {
                K = 1;
                N = 1;
            }

            cmbMacroCat.SelectedIndex = K - 1;
            var loopTo3 = moduleMACROS.MacroCategories[K].NOB;
            for (J = 1; J <= loopTo3; J++)
                lstMacro.Items.Add(moduleMACROS.MacroCategories[K].MacroObjects[J].Name);
            lstMacro.SelectedIndex = N - 1;
            ShowMacro(K, N);
            moduleMACROS.MacroID = moduleMACROS.MacroCategories[K].MacroObjects[N].File;
            IsReady = true;
        }

        private void ShowMacro(int C, int M)
        {
            string a;
            a = Strings.Right(moduleMACROS.MacroCategories[C].MacroObjects[M].File, 3);

            // after 205
            txtComment.Text = moduleMACROS.MacroCategories[C].MacroObjects[M].Name;
            lbP6.Visible = false;
            lbP7.Visible = false;
            lbP8.Visible = false;
            lbP9.Visible = false;
            txtP6.Visible = false;
            txtP7.Visible = false;
            txtP8.Visible = false;
            txtP9.Visible = false;
            cmdExpand.Visible = false;
            if (a == "API")
            {
                LabelMacro1.Text = "API Macro Object";
                moduleMACROS.ShowAPI(C, M);
                txtMacroScale.Text = moduleMACROS.MacroScale.ToString();
                txtMacroRange.Text = moduleMACROS.MacroRange.ToString();
                txtMacroWidth.Text = moduleMACROS.MacroWidth.ToString();
                txtMacroLength.Text = moduleMACROS.MacroLength.ToString();
                var fs = new FileStream(moduleMACROS.MacroBitmap, FileMode.Open, FileAccess.Read);
                imgMacro.Image = Image.FromFile(moduleMACROS.MacroBitmap);
                imgMacro.Image = Image.FromStream(fs);
                fs.Close();
                moduleMAIN.ImageFileName = moduleMACROS.MacroBitmap;
                lbP6.Visible = true;
                lbP7.Visible = true;
                lbP8.Visible = true;
                lbP9.Visible = true;
                txtP6.Visible = true;
                txtP7.Visible = true;
                txtP8.Visible = true;
                txtP9.Visible = true;
                lbP6.Text = "Parameter 6";
                lbP7.Text = "Parameter 7";
                lbP8.Text = "Parameter 8";
                lbP9.Text = "Parameter 9";
                txtP6.Text = "0";
                txtP7.Text = "0";
                txtP8.Text = "0";
                txtP9.Text = "0";
            }

            if (a == "SCM")
            {
                LabelMacro1.Text = "ASD Macro Object";
                moduleMACROS.ShowASD(C, M);
                txtMacroScale.Text = moduleMACROS.MacroScale.ToString();
                txtMacroRange.Text = moduleMACROS.MacroRange.ToString();
                txtMacroWidth.Text = moduleMACROS.MacroWidth.ToString();
                txtMacroLength.Text = moduleMACROS.MacroLength.ToString();
                var fs = new FileStream(moduleMACROS.MacroBitmap, FileMode.Open, FileAccess.Read);
                imgMacro.Image = Image.FromFile(moduleMACROS.MacroBitmap);
                imgMacro.Image = Image.FromStream(fs);
                fs.Close();
                moduleMAIN.ImageFileName = moduleMACROS.MacroBitmap;
                if (moduleMACROS.MacroRotation != 0f)
                {
                    txtHeading.Text = moduleMACROS.MacroRotation.ToString();
                }

                txtAltitude.Text = moduleMACROS.MacroElevation.ToString();
                if (moduleMACROS.MacroElevation == 0f)
                {
                    ckAGL.CheckState = CheckState.Checked;
                }
                else
                {
                    ckAGL.CheckState = CheckState.Unchecked;
                }

                if (moduleMACROS.MacroDensity == 0)
                    opVSparse.Checked = true;
                if (moduleMACROS.MacroDensity == 1)
                    opSparse.Checked = true;
                if (moduleMACROS.MacroDensity == 2)
                    opNormal.Checked = true;
                if (moduleMACROS.MacroDensity == 3)
                    opDense.Checked = true;
                if (moduleMACROS.MacroDensity == 4)
                    opVDense.Checked = true;
                txtV1.Text = moduleMACROS.MacroVisibility.ToString();
                if (!string.IsNullOrEmpty(moduleMACROS.MacroP6Name))
                {
                    lbP6.Visible = true;
                    txtP6.Visible = true;
                    lbP6.Text = moduleMACROS.MacroP6Name;
                    txtP6.Text = moduleMACROS.MacroP6Value;
                    lbP6.Text = moduleMACROS.MacroP6Name;
                    txtP6.Text = moduleMACROS.MacroP6Value;
                }

                if (!string.IsNullOrEmpty(moduleMACROS.MacroP7Name))
                {
                    lbP7.Visible = true;
                    txtP7.Visible = true;
                    lbP7.Text = moduleMACROS.MacroP7Name;
                    txtP7.Text = moduleMACROS.MacroP7Value;
                    lbP7.Text = moduleMACROS.MacroP7Name;
                    txtP7.Text = moduleMACROS.MacroP7Value;
                }

                if (!string.IsNullOrEmpty(moduleMACROS.MacroP8Name))
                {
                    lbP8.Visible = true;
                    txtP8.Visible = true;
                    lbP8.Text = moduleMACROS.MacroP8Name;
                    txtP8.Text = moduleMACROS.MacroP8Value;
                    lbP8.Text = moduleMACROS.MacroP8Name;
                    txtP8.Text = moduleMACROS.MacroP8Value;
                }

                if (string.IsNullOrEmpty(moduleMACROS.MacroP9Name))
                {
                    return;
                }
                else if (string.IsNullOrEmpty(moduleMACROS.MacroPAName))
                {
                    lbP9.Visible = true;
                    txtP9.Visible = true;
                    lbP9.Text = moduleMACROS.MacroP9Name;
                    txtP9.Text = moduleMACROS.MacroP9Value;
                    lbP9.Text = moduleMACROS.MacroP9Name;
                    txtP9.Text = moduleMACROS.MacroP9Value;
                }
                else
                {
                    cmdExpand.Visible = true;
                }
            }
        }

        private void CmdMDL_Click(object sender, EventArgs e)
        {
            string A, B, mdlFile;
            string MDLDir = moduleMAIN.AppPath + @"\Mdls";
            A = "Object Model file (*.MDL)|*.mdl";
            B = "SBuilderX: Select Object Model file";
            A = moduleFILE_IO.FileNameToOpen(A, B, "MDL");
            if (string.IsNullOrEmpty(A))
            {
                return;
            }

            mdlFile = Path.GetFileName(A);
            B = MDLDir + @"\" + mdlFile;
            if ((Path.GetDirectoryName(A) ?? "") != (MDLDir ?? ""))
            {
                File.Copy(A, B);
            }

            var fs = new FileStream(B, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(fs);
            var mdl = new MDLReader();
            if (mdl.Read(reader))
            {
                txtMDLFile.Text = mdlFile;
                txtMDLWidth.Text = mdl.Width.ToString();
                txtMDLLength.Text = mdl.Lenght.ToString();
                if (mdl.Type == 1)  // it is FS9
                {
                    var G = Guid.NewGuid(); // create one!
                    labelMDLName.Text = Path.GetFileNameWithoutExtension(mdlFile);
                    labelMDLguid.Text = G.ToString("N");   // present the guid in FS9 format
                }
                else  // it is FSX
                {
                    labelMDLName.Text = mdl.Name;
                    labelMDLguid.Text = mdl.Guid;
                }
            }
            else
            {
                Interaction.MsgBox("Not a valid MDL");
            }

            // should I realy comment the following? October 2017
            // reader.Close()
            fs.Dispose();
        }

        private void FrmDL_Click(object sender, EventArgs e)
        {
            // mdl
            optMDL.Checked = true;
        }

        private void FrTaxiway_Click(object sender, EventArgs e)
        {
            // taxiwaysign
            optTaxiwaySign.Checked = true;
        }

        // Private Sub _SSTab1_TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSTab1_TabPage4.Click
        // 'rwy12
        // If Rwy12IsOn = False Then Exit Sub
        // optRwy12.Checked = True
        // End Sub

        private void FrRwy12_Click(object sender, EventArgs e)
        {
            // rwy12
            if (moduleOBJECTS.Rwy12IsOn == false)
                return;
            optRwy12.Checked = true;
        }
        // Private Sub _SSTab1_TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSTab1_TabPage3.Click
        // 'macro
        // optMacro.Checked = True
        // End Sub

        private void Frmacro_Click(object sender, EventArgs e)
        {
            // macro
            if (moduleMACROS.MacroAPIIsOn == false & moduleMACROS.MacroASDIsOn == false)
                return;
            optMacro.Checked = true;
        }

        private void Frmacro1_Click(object sender, EventArgs e)
        {
            // macro
            if (moduleMACROS.MacroAPIIsOn == false & moduleMACROS.MacroASDIsOn == false)
                return;
            optMacro.Checked = true;
        }

        // Private Sub _SSTab1_TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSTab1_TabPage1.Click
        // 'lib
        // If LibObjectsIsOn = False Then Exit Sub
        // optLib.Checked = True
        // End Sub

        // Private Sub _SSTab1_TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SSTab1_TabPage2.Click
        // 'genBuild

        // optGenB.Checked = True
        // End Sub

        private void FrWindsock_Click(object sender, EventArgs e)
        {
            // windsock
            optWindsock.Checked = true;
        }

        private void FrBeaconBase_Click(object sender, EventArgs e)
        {
            // beacon
            optBeacon.Checked = true;
        }

        private void FrBeaconType_Click(object sender, EventArgs e)
        {
            // beacon
            optBeacon.Checked = true;
        }

        private void FrEffect_Click(object sender, EventArgs e)
        {
            // effect
            optEffect.Checked = true;
        }

        private void TxtLibName_TextChanged(object sender, EventArgs e)
        {
            cmdUpDefault.Enabled = true;
        }

        private void TxtLibLength_TextChanged(object sender, EventArgs e)
        {
            cmdUpDefault.Enabled = true;
        }

        private void TxtLibWidth_TextChanged(object sender, EventArgs e)
        {
            cmdUpDefault.Enabled = true;
        }

        private void TxtLibScale_TextChanged(object sender, EventArgs e)
        {
            cmdUpDefault.Enabled = true;
        }

        private void CmdUpDefault_Click(object sender, EventArgs e)
        {
            var myObj = new moduleOBJECTS.LibObject();
            int K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
                return;
            int N = lstLib.SelectedIndex;
            if (N < 0)
                return;
            myObj.ID = moduleOBJECTS.LibCategories[K].Objs[N].ID;
            myObj.Name = txtLibName.Text;
            myObj.Type = moduleOBJECTS.LibCategories[K].Objs[N].Type;
            myObj.Width = (float)Conversion.Val(txtLibWidth.Text);
            myObj.Length = (float)Conversion.Val(txtLibLength.Text);
            myObj.Scaling = (float)Conversion.Val(txtLibScale.Text);
            moduleOBJECTS.LibCategories[K].Objs[N] = myObj;
            lstLib.Items.Clear();
            moduleOBJECTS.LibObject g;
            foreach (var currentG in moduleOBJECTS.LibCategories[K].Objs)
            {
                g = currentG;
                lstLib.Items.Add(g.Name);
            }

            lstLib.SelectedIndex = N;
            string A;
            FileStream stream;
            StreamWriter fileWriter;
            stream = new FileStream(moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[K].Name + ".txt", FileMode.Create);
            fileWriter = new StreamWriter(stream);
            fileWriter.WriteLine("[" + moduleOBJECTS.LibCategories[K].Name + "]");
            foreach (var currentG1 in moduleOBJECTS.LibCategories[K].Objs)
            {
                g = currentG1;
                A = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(g.ID, " "), g.Type), " "), g.Width), " "), g.Length), " "), g.Scaling), " "), g.Name));
                fileWriter.WriteLine(A);
            }

            // should I realy comment the following? October 2017
            // fileWriter.Close()
            stream.Close();
            cmdUpDefault.Enabled = false;
        }

        private void CapturePopUPMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.FrmStart.Hide();
            if (My.MyProject.Forms.frmSCREEN.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (optLib.Checked)
                    {
                        imgLib.Image = My.MyProject.Forms.frmSCREEN.MyCapture;
                        imgLib.Image.Save(moduleMAIN.ImageFileNameTrue, ImageFormat.Jpeg);  // saves the screen shot
                    }

                    if (optMacro.Checked)
                    {
                        imgMacro.Image = My.MyProject.Forms.frmSCREEN.MyCapture;
                        imgMacro.Image.Save(moduleMAIN.ImageFileNameTrue, ImageFormat.Jpeg);  // saves the screen shot
                    }

                    if (optRwy12.Checked)
                    {
                        imgRwy12.Image = My.MyProject.Forms.frmSCREEN.MyCapture;
                        imgRwy12.Image.Save(moduleMAIN.ImageFileNameTrue, ImageFormat.Jpeg);  // saves the screen shot
                    }

                    if (optGenB.Checked)
                    {
                        imgGenB.Image = My.MyProject.Forms.frmSCREEN.MyCapture;
                        imgGenB.Image.Save(moduleMAIN.ImageFileNameTrue, ImageFormat.Jpeg);  // saves the screen shot
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Could not save the image!", MsgBoxStyle.Information);
                }
            }

            My.MyProject.Forms.frmSCREEN.Dispose();
            Show();
            My.MyProject.Forms.FrmStart.Show();
        }

        private void ImgRwy12_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            int N = Strings.InStrRev(moduleMAIN.ImageFileName, @"\");
            string A = Strings.UCase(Strings.Mid(moduleMAIN.ImageFileName, N + 1));
            if (Button == 1)
            {
                if (A != "NA.JPG")
                    My.MyProject.Forms.FrmImage.ShowDialog();
            }
            else if (Button == 2)
            {
                if (A == "NA.JPG")
                {
                    EnlargePopUpMenuItem.Visible = false;
                    DeletePopUpMenuItem.Visible = false;
                }
                else
                {
                    EnlargePopUpMenuItem.Visible = true;
                    DeletePopUpMenuItem.Visible = true;
                }
                // frmImage.ShowDialog()
                TitlePopUpMenuItem.Text = "RWY12 THUMBNAIL";
                PurgePopUPMenuItem.Visible = false;
            }
        }

        private void ImgMacro_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            int N = Strings.InStrRev(moduleMAIN.ImageFileName, @"\");
            string A = Strings.UCase(Strings.Mid(moduleMAIN.ImageFileName, N + 1));
            if (Button == 1)
            {
                if (A != "NA.JPG")
                    My.MyProject.Forms.FrmImage.ShowDialog();
            }
            else if (Button == 2)
            {
                if (A == "NA.JPG")
                {
                    EnlargePopUpMenuItem.Visible = false;
                    DeletePopUpMenuItem.Visible = false;
                }
                else
                {
                    EnlargePopUpMenuItem.Visible = true;
                    DeletePopUpMenuItem.Visible = true;
                }
                // frmImage.ShowDialog()
                TitlePopUpMenuItem.Text = "MACRO THUMBNAIL";
                PurgePopUPMenuItem.Visible = false;
            }
        }

        private void ImgLib_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            int N = Strings.InStrRev(moduleMAIN.ImageFileName, @"\");
            string A = Strings.UCase(Strings.Mid(moduleMAIN.ImageFileName, N + 1));
            if (A == "UNKNOWN.JPG")
            {
                ShowPopUpMenu(false);
                return;
            }

            ShowPopUpMenu(true);
            if (Button == 1)
            {
                if (A != "NA.JPG")
                    My.MyProject.Forms.FrmImage.ShowDialog();
            }
            else if (Button == 2)
            {
                if (A == "NA.JPG")
                {
                    EnlargePopUpMenuItem.Visible = false;
                    DeletePopUpMenuItem.Visible = false;
                }
                else
                {
                    EnlargePopUpMenuItem.Visible = true;
                    DeletePopUpMenuItem.Visible = true;
                }
                // frmImage.ShowDialog()
                TitlePopUpMenuItem.Text = "LIB OBJECT THUMBNAIL";
                PurgePopUPMenuItem.Visible = true;
            }
        }

        private void ShowPopUpMenu(bool flag)
        {
            EnlargePopUpMenuItem.Visible = flag;
            DeletePopUpMenuItem.Visible = flag;
            PurgePopUPMenuItem.Visible = flag;
            TitlePopUpMenuItem.Visible = flag;
            CapturePopUpMenuItem.Visible = flag;
            FromFilePopUpMenuItem.Visible = flag;
            ToolStripSeparator1.Visible = flag;
        }

        private void EnlargePopUpMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmImage.ShowDialog();
        }

        private void DeletePopUpMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string na = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
                if (optLib.Checked)
                {
                    imgLib.Image = Image.FromFile(na);
                }

                if (optMacro.Checked)
                {
                    imgMacro.Image = Image.FromFile(na);
                }

                if (optRwy12.Checked)
                {
                    imgRwy12.Image = Image.FromFile(na);
                }

                if (optGenB.Checked)
                {
                    imgGenB.Image = Image.FromFile(na);
                }

                moduleMAIN.ImageFileName = na;
                File.Delete(moduleMAIN.ImageFileNameTrue);
            }
            catch (Exception ex)
            {
                string a = "Could not delete the file:" + Constants.vbCrLf;
                a = a + moduleMAIN.ImageFileNameTrue;
                Interaction.MsgBox(a, MsgBoxStyle.Information);
            }
        }

        private void FromFilePopUpMenuItem_Click(object sender, EventArgs e)
        {
            string a, b, FileName;
            FileName = "";
            try
            {
                a = "JPEG Files (*.JPG)|*.JPG";
                b = "SBuilderX - Find a JPEG Thumbnail";
                FileName = moduleFILE_IO.FileNameToOpen(a, b, "");
                if (string.IsNullOrEmpty(FileName))
                    return;
                if (My.MyProject.Computer.FileSystem.FileExists(FileName))
                {
                    if (optLib.Checked)
                    {
                        imgLib.Image = Image.FromFile(FileName);
                    }

                    if (optMacro.Checked)
                    {
                        imgMacro.Image = Image.FromFile(FileName);
                    }

                    if (optRwy12.Checked)
                    {
                        imgRwy12.Image = Image.FromFile(FileName);
                    }

                    if (optGenB.Checked)
                    {
                        imgGenB.Image = Image.FromFile(FileName);
                    }

                    My.MyProject.Computer.FileSystem.CopyFile(FileName, moduleMAIN.ImageFileNameTrue);
                    moduleMAIN.ImageFileName = FileName;
                    moduleMAIN.ImageFileNameTrue = FileName;
                }
            }
            catch (Exception ex)
            {
                a = "The file can not be used as a thumbnail" + Constants.vbCrLf;
                Interaction.MsgBox(a, MsgBoxStyle.Information);
            }
        }

        private void PurgePopUPMenuItem_Click(object sender, EventArgs e)
        {
            string A = "Do you want to delete unused Thumbnail Jpegs" + Constants.vbCrLf;
            A = A + "found in the directory for this category of objects ?";
            if (Interaction.MsgBox(A, MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
            {
                return;
            }

            int K;
            string fileName = "";
            string foundFile = "";
            var FilesToCheck = new List<string>();
            if (optLib.Checked)
            {
                // get the category index
                K = cmbLibCat.SelectedIndex + 1;
                foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                    FilesToCheck.Add(g.ID);
                foreach (var currentFoundFile in My.MyProject.Computer.FileSystem.GetFiles(moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[K].Name))
                {
                    foundFile = currentFoundFile;
                    fileName = Path.GetFileNameWithoutExtension(foundFile);
                    if (!FilesToCheck.Contains(fileName))
                    {
                        if (Path.GetExtension(foundFile).ToUpper() == ".JPG")
                        {
                            My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
                        }
                    }
                }
            }

            if (optGenB.Checked)
            {
                foreach (var currentFoundFile1 in My.MyProject.Computer.FileSystem.GetFiles(moduleMAIN.AppPath + @"\GenBuildings"))
                {
                    foundFile = currentFoundFile1;
                    fileName = Path.GetFileNameWithoutExtension(foundFile);
                    if (!lstGenB.Items.Contains(fileName))
                    {
                        if (Path.GetExtension(foundFile).ToUpper() == ".JPG")
                        {
                            My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
                        }
                    }
                }
            }
        }

        private void CmdGbDetail_Click(object sender, EventArgs e)
        {
            if (optGbFlat.Checked)
                moduleOBJECTS.BuildingType = 256;
            if (optGbPeaked.Checked)
                moduleOBJECTS.BuildingType = 257;
            if (optGbRidge.Checked)
                moduleOBJECTS.BuildingType = 258;
            if (optGbSlant.Checked)
                moduleOBJECTS.BuildingType = 259;
            if (optGbPyramidal.Checked)
                moduleOBJECTS.BuildingType = 260;
            if (optGbMultiSided.Checked)
                moduleOBJECTS.BuildingType = 261;
            moduleOBJECTS.sizeX = (float)nUPsizeX.Value;
            moduleOBJECTS.sizeZ = (float)nUPsizeZ.Value;
            moduleOBJECTS.scale_gb = (float)nUPscale.Value;
            My.MyProject.Forms.FrmGBuilding.ShowDialog();
        }

        private void FillGenBList()
        {
            if (moduleOBJECTS.NoOfGenBObjects < 1)
                return;
            IsReady = false;
            nUPsizeX.Value = (decimal)moduleOBJECTS.sizeX;
            nUPsizeZ.Value = (decimal)moduleOBJECTS.sizeZ;
            nUPscale.Value = (decimal)moduleOBJECTS.scale_gb;
            // nUPbottomTexture.Value = bottomTexture
            // nUPwindowTexture.Value = windowTexture
            // nUPtopTexture.Value = topTexture
            // nUProofTexture.Value = roofTexture

            lstGenB.Items.Clear();
            int K;
            var loopTo = moduleOBJECTS.NoOfGenBObjects;
            for (K = 1; K <= loopTo; K++)
                lstGenB.Items.Add(moduleOBJECTS.GenBObjects[K].name);
            IsReady = true;
            if (moduleOBJECTS.NoOfGenBObjects > 0)
                lstGenB.SelectedIndex = 0;
        }

        private void CmdGbStore_Click(object sender, EventArgs e)
        {
            IsReady = false;
            var type = default(int);
            if (optGbFlat.Checked)
                type = 256;
            if (optGbPeaked.Checked)
                type = 257;
            if (optGbRidge.Checked)
                type = 258;
            if (optGbSlant.Checked)
                type = 259;
            if (optGbPyramidal.Checked)
                type = 260;
            if (optGbMultiSided.Checked)
                type = 261;
            string width = Strings.Trim(Conversion.Str(nUPsizeX.Value));
            string lenght = Strings.Trim(Conversion.Str(nUPsizeZ.Value));
            string scale = Strings.Trim(Conversion.Str(nUPscale.Value));

            // bottomTexture = nUPbottomTexture.Value
            // roofTexture = nUProofTexture.Value
            // topTexture = nUPtopTexture.Value
            // windowTexture = nUPwindowTexture.Value

            string textures = moduleOBJECTS.MakeGBTextures();
            string indexes = moduleOBJECTS.MakeGBIndexes(type);
            string name = txtComment.Text;
            name = Strings.Replace(name, " ", "_");
            if (string.IsNullOrEmpty(name))
                name = "Generic_Building_No_Name";
            string myLine = type.ToString() + " " + width + " " + lenght + " " + scale + " " + textures + " " + indexes + " " + name + Constants.vbCrLf;
            moduleOBJECTS.NoOfGenBObjects = moduleOBJECTS.NoOfGenBObjects + 1;
            Array.Resize(ref moduleOBJECTS.GenBObjects, moduleOBJECTS.NoOfGenBObjects + 1);
            int K = lstGenB.SelectedIndex + 1;
            if (K == 0)
            {
                K = K + 1; // in case there none in the list
            }

            int N;
            var loopTo = K + 1;
            for (N = moduleOBJECTS.NoOfGenBObjects; N >= loopTo; N -= 1)
                moduleOBJECTS.GenBObjects[N] = moduleOBJECTS.GenBObjects[N - 1];
            moduleOBJECTS.GenBObjects[K].type = type;
            moduleOBJECTS.GenBObjects[K].sizeX = (float)Conversion.Val(width);
            moduleOBJECTS.GenBObjects[K].sizeZ = (float)Conversion.Val(lenght);
            moduleOBJECTS.GenBObjects[K].scale = (float)Conversion.Val(scale);
            moduleOBJECTS.GenBObjects[K].textures = textures;
            moduleOBJECTS.GenBObjects[K].indexes = indexes;
            moduleOBJECTS.GenBObjects[K].name = name;
            lstGenB.Items.Clear();
            var loopTo1 = moduleOBJECTS.NoOfGenBObjects;
            for (N = 1; N <= loopTo1; N++)
                lstGenB.Items.Add(moduleOBJECTS.GenBObjects[N].name);
            if (moduleOBJECTS.NoOfGenBObjects > 0)
                lstGenB.SelectedIndex = K - 1;
            string newText = "";
            N = 0;
            string myFile = moduleMAIN.AppPath + @"\GenBuildings\GenBuildings.txt";
            var stream = new FileStream(myFile, FileMode.Open);
            var fileReader = new StreamReader(stream);
            string line = "";
            while (!fileReader.EndOfStream)
            {
                line = fileReader.ReadLine();
                N = N + 1;
                if (N == K)
                    newText = newText + myLine;
                newText = newText + line + Constants.vbCrLf;
            }

            // should I realy comment the following? October 2017
            // fileReader.Close()
            stream.Close();
            if (N == 0)
                newText = myLine; // in case the file was empty
            My.MyProject.Computer.FileSystem.WriteAllText(myFile, newText, false);
            IsReady = true;
        }

        private void CmdGBDelete_Click(object sender, EventArgs e)
        {
            if (moduleOBJECTS.NoOfGenBObjects == 0)
                return;
            IsReady = false;
            int K = lstGenB.SelectedIndex + 1;
            int N;
            var loopTo = moduleOBJECTS.NoOfGenBObjects;
            for (N = K + 1; N <= loopTo; N++)
                moduleOBJECTS.GenBObjects[N - 1] = moduleOBJECTS.GenBObjects[N];
            moduleOBJECTS.NoOfGenBObjects = moduleOBJECTS.NoOfGenBObjects - 1;
            // ReDim Preserve GenBObjects(NoOfGenBObjects)

            lstGenB.Items.Clear();
            var loopTo1 = moduleOBJECTS.NoOfGenBObjects;
            for (N = 1; N <= loopTo1; N++)
                lstGenB.Items.Add(moduleOBJECTS.GenBObjects[N].name);
            if (K > moduleOBJECTS.NoOfGenBObjects)
            {
                if (moduleOBJECTS.NoOfGenBObjects > 0)
                    lstGenB.SelectedIndex = K - 2;
            }
            else if (moduleOBJECTS.NoOfGenBObjects > 0)
                lstGenB.SelectedIndex = K - 1;
            string newText = "";
            N = 0;
            string myFile = moduleMAIN.AppPath + @"\GenBuildings\GenBuildings.txt";
            var stream = new FileStream(myFile, FileMode.Open);
            var fileReader = new StreamReader(stream);
            string line = "";
            while (!fileReader.EndOfStream)
            {
                line = fileReader.ReadLine();
                N = N + 1;
                if (!(N == K))
                {
                    newText = newText + line + Constants.vbCrLf;
                }
            }

            // should I realy comment the following? October 2017
            // fileReader.Close()
            stream.Close();
            My.MyProject.Computer.FileSystem.WriteAllText(myFile, newText, false);
            IsReady = true;
        }

        private void CmdGbLoad_Click(object sender, EventArgs e)
        {
            if (moduleOBJECTS.NoOfGenBObjects == 0)
                return;
            int K = lstGenB.SelectedIndex + 1;
            int type = moduleOBJECTS.GenBObjects[K].type;
            moduleOBJECTS.sizeX = moduleOBJECTS.GenBObjects[K].sizeX;
            moduleOBJECTS.sizeZ = moduleOBJECTS.GenBObjects[K].sizeZ;
            moduleOBJECTS.scale_gb = moduleOBJECTS.GenBObjects[K].scale;
            string textures = moduleOBJECTS.GenBObjects[K].textures;
            string indexes = moduleOBJECTS.GenBObjects[K].indexes;
            string name = moduleOBJECTS.GenBObjects[K].name;
            moduleOBJECTS.Objects[0].Type = type;
            moduleOBJECTS.Objects[0].Description = Strings.Trim(Conversion.Str(moduleOBJECTS.scale_gb)) + "|" + textures + "|" + indexes + "|" + name;
            moduleOBJECTS.AnalyseGenBObject(0);
            moduleOBJECTS.ObjComment = name;
            txtComment.Text = name;
            nUPsizeX.Value = (decimal)moduleOBJECTS.sizeX;
            nUPsizeZ.Value = (decimal)moduleOBJECTS.sizeZ;
            nUPscale.Value = (decimal)moduleOBJECTS.scale_gb;
            // nUPbottomTexture.Value = bottomTexture
            // nUPwindowTexture.Value = windowTexture
            // nUPtopTexture.Value = topTexture
            // nUProofTexture.Value = roofTexture

            if (type == 256)
                optGbFlat.Checked = true;
            if (type == 257)
                optGbPeaked.Checked = true;
            if (type == 258)
                optGbRidge.Checked = true;
            if (type == 259)
                optGbSlant.Checked = true;
            if (type == 260)
                optGbPyramidal.Checked = true;
            if (type == 261)
                optGbMultiSided.Checked = true;
        }

        private void LstGenB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsReady)
                return;
            int K = lstGenB.SelectedIndex + 1;
            string a = moduleMAIN.AppPath + @"\GenBuildings\" + moduleOBJECTS.GenBObjects[K].name + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            // imgGenB.Image = System.Drawing.Image.FromFile(a)
            imgGenB.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void ImgGenB_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            int N = Strings.InStrRev(moduleMAIN.ImageFileName, @"\");
            string A = Strings.UCase(Strings.Mid(moduleMAIN.ImageFileName, N + 1));
            if (Button == 1)
            {
                if (A != "NA.JPG")
                    My.MyProject.Forms.FrmImage.ShowDialog();
            }
            else if (Button == 2)
            {
                if (A == "NA.JPG")
                {
                    EnlargePopUpMenuItem.Visible = false;
                    DeletePopUpMenuItem.Visible = false;
                }
                else
                {
                    EnlargePopUpMenuItem.Visible = true;
                    DeletePopUpMenuItem.Visible = true;
                }
                // frmImage.ShowDialog()
                TitlePopUpMenuItem.Text = "GEN BUILDING THUMBNAIL";
                PurgePopUPMenuItem.Visible = true;
            }
        }


        // Private Sub CmdGBFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        // Dim A As String = CStr(bottomTexture) & "|"
        // A = A & CStr(roofTexture) & "|"
        // A = A & CStr(topTexture) & "|"
        // A = A & CStr(windowTexture)

        // Dim type As Integer

        // If optGbFlat.Checked Then type = 256
        // If optGbPeaked.Checked Then type = 257
        // If optGbRidge.Checked Then type = 258
        // If optGbSlant.Checked Then type = 259
        // If optGbPyramidal.Checked Then type = 260
        // If optGbMultiSided.Checked Then type = 261

        // Dim N As Integer
        // For N = 1 To NoOfGenBObjects
        // If type = GenBObjects(N).type Then
        // If A = GenBObjects(N).textures Then
        // lstGenB.SelectedIndex = N - 1
        // Exit Sub
        // End If
        // End If
        // Next N

        // A = "No Pre-Stored Generic Building with the " & vbCrLf
        // A = A & "shown type and textures is available!"
        // MsgBox(A, MsgBoxStyle.Information)

        // End Sub

        private void SSTab1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // June,8, 2014, to show tab pages filled when we
            // click on the tab

            int N = SSTab1.SelectedIndex;
            if (N == 1)
            {
                if (moduleOBJECTS.LibObjectsIsOn == false)
                    return;
                optLib.Checked = true;
            }

            if (N == 2)
            {
                optGenB.Checked = true;
            }

            if (N == 3)
            {
                optMacro.Checked = true;
            }

            if (N == 4)
            {
                if (moduleOBJECTS.Rwy12IsOn == false)
                    return;
                optRwy12.Checked = true;
            }
        }
    }
}