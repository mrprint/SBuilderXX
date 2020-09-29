using System;
using System.IO;
using System.Windows.Forms;

namespace SBuilderX.My
{

    // The following events are availble for MyApplication:
    // 
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    internal partial class MyApplication
    {
        private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
        {
            string nl = Environment.NewLine;
            string errorMessage = e.Exception.Message + nl + nl;
            // errorMessage += e.Exception.ToString & vbCrLf & vbCrLf
            errorMessage += "This was an unexpected error that can lead to unpredictable results. If " + nl;
            errorMessage += "you press NO SBuilderX will shut down. If you press YES you can continue " + nl;
            errorMessage += "to work at your own risk. Do you want to continue?";
            string errorFile;
            if (MessageBox.Show(errorMessage, "SBuilderX - Globally Exception:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.ExitApplication = false;
            }
            else
            {
                e.ExitApplication = true;
                if (string.IsNullOrEmpty(moduleMAIN.WorkFile))
                {
                    errorFile = moduleMAIN.AppPath + @"\Tools\Work\PROJECT_ERR.SBP";
                }
                else
                {
                    errorFile = Path.GetDirectoryName(moduleMAIN.WorkFile);
                    errorFile = errorFile + @"\" + Path.GetFileNameWithoutExtension(moduleMAIN.WorkFile) + "_ERR.SBP";
                }

                moduleFILE_IO.SaveFile(errorFile);
            }

            errorMessage = "Error Report created by SBuilderX on " + DateTime.Now.ToString() + nl + nl;
            errorMessage += e.Exception.Message + nl + nl;
            errorMessage += e.Exception.ToString() + nl + nl;
            errorMessage += "Name=" + moduleMAIN.ProjectName.ToString() + nl;
            errorMessage += "NoOfMaps=" + moduleMAPS.NoOfMaps.ToString() + nl;
            errorMessage += "NoOfLands=" + moduleCLASSES.NoOfLands.ToString() + nl;
            errorMessage += "NoOfLines=" + moduleLINES.NoOfLines.ToString() + nl;
            errorMessage += "NoOfPolys=" + modulePOLYS.NoOfPolys.ToString() + nl;
            errorMessage += "NoOfWaters=" + moduleCLASSES.NoOfWaters.ToString() + nl;
            errorMessage += "NoOfObjects=" + moduleOBJECTS.NoOfObjects.ToString() + nl;
            errorMessage += "NoOfExcludes=" + moduleEXCLUDES.NoOfExcludes.ToString() + nl;
            errorMessage += "NoOfLWCIs=" + moduleCLASSES.NoOfLWCIs.ToString() + nl;
            errorMessage += "BGLProjectFolder=" + moduleMAIN.BGLProjectFolder.ToString() + nl;
            errorMessage += "LatDispCenter=" + moduleMAIN.LatDispCenter.ToString() + nl;
            errorMessage += "LonDispCenter=" + moduleMAIN.LonDispCenter.ToString() + nl;
            errorMessage += "Zoom=" + moduleMAIN.Zoom.ToString() + nl;
            errorMessage += "PolyON=" + modulePOLYS.PolyON.ToString() + nl;
            errorMessage += "PolyVIEW=" + modulePOLYS.PolyVIEW.ToString() + nl;
            errorMessage += "LineON=" + moduleLINES.LineON.ToString() + nl;
            errorMessage += "LineVIEW=" + moduleLINES.LineVIEW.ToString() + nl;
            errorMessage += "MapVIEW=" + moduleMAPS.MapVIEW.ToString() + nl;
            errorMessage += "TilesToCome=" + moduleTILES.TilesToCome.ToString() + nl;
            errorMessage += "NoOfServerTypes=" + moduleTILES.NoOfServerTypes.ToString() + nl;
            errorMessage += "TileVIEW=" + moduleTILES.TileVIEW.ToString() + nl;
            errorMessage += "ActiveTileFolder=" + moduleTILES.ActiveTileFolder.ToString() + nl;
            errorMessage += "WaterVIEW=" + moduleCLASSES.WaterVIEW.ToString() + nl;
            errorMessage += "WaterON=" + moduleCLASSES.WaterON.ToString() + nl;
            errorMessage += "LandVIEW=" + moduleCLASSES.LandVIEW.ToString() + nl;
            errorMessage += "LandON=" + moduleCLASSES.LandON.ToString() + nl;
            errorMessage += "ObjectON=" + moduleOBJECTS.ObjectON.ToString() + nl;
            errorMessage += "ObjectVIEW=" + moduleOBJECTS.ObjectVIEW.ToString() + nl;
            errorMessage += "NoOfRwy12Categories=" + moduleOBJECTS.NoOfRwy12Categories.ToString() + nl;
            errorMessage += "NoOfLibCategories=" + moduleOBJECTS.NoOfLibCategories.ToString() + nl;
            errorMessage += "LibObjectsIsOn=" + moduleOBJECTS.LibObjectsIsOn.ToString() + nl;
            errorMessage += "NoOfGenBObjects=" + moduleOBJECTS.NoOfGenBObjects.ToString() + nl;
            errorMessage += "NoOfMacroCategories=" + moduleMACROS.NoOfMacroCategories.ToString() + nl;
            errorMessage += "MacroAPIIsOn=" + moduleMACROS.MacroAPIIsOn.ToString() + nl;
            errorMessage += "MacroASDIsOn=" + moduleMACROS.MacroASDIsOn.ToString() + nl;
            errorMessage += "MakeOnMany=" + moduleMAIN.MakeOnMany.ToString() + nl;
            errorMessage += "AllVIEW=" + moduleMAIN.AllVIEW.ToString() + nl;
            errorMessage += "ViewON=" + moduleMAIN.ViewON.ToString() + nl;
            errorMessage += "AircraftVIEW=" + moduleMAIN.AircraftVIEW.ToString() + nl;
            errorMessage += "PointerON=" + moduleMAIN.PointerON.ToString() + nl;
            errorMessage += "ZoomON=" + moduleMAIN.ZoomON.ToString() + nl;
            errorMessage += "PanON=" + moduleMAIN.PanON.ToString() + nl;
            errorMessage += "SelectON=" + moduleMAIN.SelectON.ToString() + nl;
            errorMessage += "MoveON=" + moduleMAIN.MoveON.ToString() + nl;
            errorMessage += "FirstMOVE=" + moduleMAIN.FirstMOVE.ToString() + nl;
            errorMessage += "InsertON=" + moduleMAIN.InsertON.ToString() + nl;
            errorMessage += "DeleteON=" + moduleMAIN.DeleteON.ToString() + nl;
            errorMessage += "AskDelete=" + moduleMAIN.AskDelete.ToString() + nl;
            errorMessage += "Dirty=" + moduleMAIN.Dirty.ToString() + nl;
            errorMessage += "DecimalDegrees=" + moduleMAIN.DecimalDegrees.ToString() + nl;
            errorMessage += "LatDispNorth=" + moduleMAIN.LatDispNorth.ToString() + nl;
            errorMessage += "LatDispSouth=" + moduleMAIN.LatDispSouth.ToString() + nl;
            errorMessage += "LonDispWest=" + moduleMAIN.LonDispWest.ToString() + nl;
            errorMessage += "LonDispEast=" + moduleMAIN.LonDispEast.ToString() + nl;
            errorFile = moduleMAIN.AppPath + @"\Tools\Work\ERROR_REPORT.TXT";
            MyProject.Computer.FileSystem.WriteAllText(errorFile, errorMessage, false);
        }
    }
}