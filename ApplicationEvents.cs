using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            string errorMessage = e.Exception.Message + Constants.vbCrLf + Constants.vbCrLf;
            // errorMessage += e.Exception.ToString & vbCrLf & vbCrLf
            errorMessage += "This was an unexpected error that can lead to unpredictable results. If " + Constants.vbCrLf;
            errorMessage += "you press NO SBuilderX will shut down. If you press YES you can continue " + Constants.vbCrLf;
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

            errorMessage = "Error Report created by SBuilderX on " + DateAndTime.Now.ToString() + Constants.vbCrLf + Constants.vbCrLf;
            errorMessage += e.Exception.Message + Constants.vbCrLf + Constants.vbCrLf;
            errorMessage += e.Exception.ToString() + Constants.vbCrLf + Constants.vbCrLf;
            errorMessage += "Name=" + moduleMAIN.ProjectName.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfMaps=" + moduleMAPS.NoOfMaps.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfLands=" + moduleCLASSES.NoOfLands.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfLines=" + moduleLINES.NoOfLines.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfPolys=" + modulePOLYS.NoOfPolys.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfWaters=" + moduleCLASSES.NoOfWaters.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfObjects=" + moduleOBJECTS.NoOfObjects.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfExcludes=" + moduleEXCLUDES.NoOfExcludes.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfLWCIs=" + moduleCLASSES.NoOfLWCIs.ToString() + Constants.vbCrLf;
            errorMessage += "BGLProjectFolder=" + moduleMAIN.BGLProjectFolder.ToString() + Constants.vbCrLf;
            errorMessage += "LatDispCenter=" + moduleMAIN.LatDispCenter.ToString() + Constants.vbCrLf;
            errorMessage += "LonDispCenter=" + moduleMAIN.LonDispCenter.ToString() + Constants.vbCrLf;
            errorMessage += "Zoom=" + moduleMAIN.Zoom.ToString() + Constants.vbCrLf;
            errorMessage += "PolyON=" + modulePOLYS.PolyON.ToString() + Constants.vbCrLf;
            errorMessage += "PolyVIEW=" + modulePOLYS.PolyVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "LineON=" + moduleLINES.LineON.ToString() + Constants.vbCrLf;
            errorMessage += "LineVIEW=" + moduleLINES.LineVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "MapVIEW=" + moduleMAPS.MapVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "TilesToCome=" + moduleTILES.TilesToCome.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfServerTypes=" + moduleTILES.NoOfServerTypes.ToString() + Constants.vbCrLf;
            errorMessage += "TileVIEW=" + moduleTILES.TileVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "ActiveTileFolder=" + moduleTILES.ActiveTileFolder.ToString() + Constants.vbCrLf;
            errorMessage += "WaterVIEW=" + moduleCLASSES.WaterVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "WaterON=" + moduleCLASSES.WaterON.ToString() + Constants.vbCrLf;
            errorMessage += "LandVIEW=" + moduleCLASSES.LandVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "LandON=" + moduleCLASSES.LandON.ToString() + Constants.vbCrLf;
            errorMessage += "ObjectON=" + moduleOBJECTS.ObjectON.ToString() + Constants.vbCrLf;
            errorMessage += "ObjectVIEW=" + moduleOBJECTS.ObjectVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfRwy12Categories=" + moduleOBJECTS.NoOfRwy12Categories.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfLibCategories=" + moduleOBJECTS.NoOfLibCategories.ToString() + Constants.vbCrLf;
            errorMessage += "LibObjectsIsOn=" + moduleOBJECTS.LibObjectsIsOn.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfGenBObjects=" + moduleOBJECTS.NoOfGenBObjects.ToString() + Constants.vbCrLf;
            errorMessage += "NoOfMacroCategories=" + moduleMACROS.NoOfMacroCategories.ToString() + Constants.vbCrLf;
            errorMessage += "MacroAPIIsOn=" + moduleMACROS.MacroAPIIsOn.ToString() + Constants.vbCrLf;
            errorMessage += "MacroASDIsOn=" + moduleMACROS.MacroASDIsOn.ToString() + Constants.vbCrLf;
            errorMessage += "MakeOnMany=" + moduleMAIN.MakeOnMany.ToString() + Constants.vbCrLf;
            errorMessage += "AllVIEW=" + moduleMAIN.AllVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "ViewON=" + moduleMAIN.ViewON.ToString() + Constants.vbCrLf;
            errorMessage += "AircraftVIEW=" + moduleMAIN.AircraftVIEW.ToString() + Constants.vbCrLf;
            errorMessage += "PointerON=" + moduleMAIN.PointerON.ToString() + Constants.vbCrLf;
            errorMessage += "ZoomON=" + moduleMAIN.ZoomON.ToString() + Constants.vbCrLf;
            errorMessage += "PanON=" + moduleMAIN.PanON.ToString() + Constants.vbCrLf;
            errorMessage += "SelectON=" + moduleMAIN.SelectON.ToString() + Constants.vbCrLf;
            errorMessage += "MoveON=" + moduleMAIN.MoveON.ToString() + Constants.vbCrLf;
            errorMessage += "FirstMOVE=" + moduleMAIN.FirstMOVE.ToString() + Constants.vbCrLf;
            errorMessage += "InsertON=" + moduleMAIN.InsertON.ToString() + Constants.vbCrLf;
            errorMessage += "DeleteON=" + moduleMAIN.DeleteON.ToString() + Constants.vbCrLf;
            errorMessage += "AskDelete=" + moduleMAIN.AskDelete.ToString() + Constants.vbCrLf;
            errorMessage += "Dirty=" + moduleMAIN.Dirty.ToString() + Constants.vbCrLf;
            errorMessage += "DecimalDegrees=" + moduleMAIN.DecimalDegrees.ToString() + Constants.vbCrLf;
            errorMessage += "LatDispNorth=" + moduleMAIN.LatDispNorth.ToString() + Constants.vbCrLf;
            errorMessage += "LatDispSouth=" + moduleMAIN.LatDispSouth.ToString() + Constants.vbCrLf;
            errorMessage += "LonDispWest=" + moduleMAIN.LonDispWest.ToString() + Constants.vbCrLf;
            errorMessage += "LonDispEast=" + moduleMAIN.LonDispEast.ToString() + Constants.vbCrLf;
            errorFile = moduleMAIN.AppPath + @"\Tools\Work\ERROR_REPORT.TXT";
            MyProject.Computer.FileSystem.WriteAllText(errorFile, errorMessage, false);
        }
    }
}