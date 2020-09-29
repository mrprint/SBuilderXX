using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    static class moduleEDIT
    {
        internal static bool BackUpON; // general switch
        internal static bool SkipBackUp;
        private static int BackUpPointer;
        private static int BackUpUndos;
        private static int BackUpRedos;
        internal static bool PasteON;
        private static moduleLINES.GLine ClipLine;  // kind of clipboard
        private static modulePOLYS.GPoly ClipPoly;
        private static moduleOBJECTS.Objecto ClipObject;
        private static MemoryStream mem1;
        private static MemoryStream mem2;
        private static MemoryStream mem3;
        private static MemoryStream mem4;
        private static MemoryStream mem5;

        internal static void BackUpInit()
        {
            BackUpPointer = 0;
            BackUpUndos = 0;
            BackUpRedos = 0;
            mem1 = new MemoryStream();
            mem2 = new MemoryStream();
            mem3 = new MemoryStream();
            mem4 = new MemoryStream();
            mem5 = new MemoryStream();
            My.MyProject.Forms.FrmStart.UndoMenuItem.Enabled = false;
            My.MyProject.Forms.FrmStart.UndoToolStripButton.Enabled = false;
        }

        internal static void BackUpFinit()
        {
            if (mem1 is object)
                mem1.Dispose();
            if (mem1 is object)
                mem2.Dispose();
            if (mem1 is object)
                mem3.Dispose();
            if (mem1 is object)
                mem4.Dispose();
            if (mem1 is object)
                mem5.Dispose();
            My.MyProject.Forms.FrmStart.UndoMenuItem.Enabled = false;
            My.MyProject.Forms.FrmStart.RedoMenuItem.Enabled = false;

            // added the following in October 2017
            My.MyProject.Forms.FrmStart.UndoToolStripButton.Enabled = false;
            My.MyProject.Forms.FrmStart.RedoToolStripButton.Enabled = false;
        }

        internal static void BackUp()
        {
            if (!BackUpON)
                return;
            if (BackUpUndos < 5)
                BackUpUndos = BackUpUndos + 1;
            BackUpRedos = 0;
            BackUpPointer = BackUpPointer + 1;
            if (BackUpPointer == 6)
                BackUpPointer = 1;
            Store(BackUpPointer);
            My.MyProject.Forms.FrmStart.UndoMenuItem.Enabled = true;
            My.MyProject.Forms.FrmStart.UndoToolStripButton.Enabled = true;
            My.MyProject.Forms.FrmStart.RedoMenuItem.Enabled = false;
            My.MyProject.Forms.FrmStart.RedoToolStripButton.Enabled = false;
        }

        internal static void Undo()
        {
            if (BackUpUndos > 0)
                BackUpUndos = BackUpUndos - 1;
            if (BackUpRedos < 5)
                BackUpRedos = BackUpRedos + 1;
            if (BackUpPointer == 5)
            {
                Store(1);
            }
            else
            {
                Store(BackUpPointer + 1);
            }

            Restore(BackUpPointer);
            BackUpPointer = BackUpPointer - 1;
            if (BackUpPointer == 0)
                BackUpPointer = 5;
            if (BackUpUndos < 2)
            {
                My.MyProject.Forms.FrmStart.UndoMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.UndoToolStripButton.Enabled = false;
            }

            My.MyProject.Forms.FrmStart.RedoMenuItem.Enabled = true;
            My.MyProject.Forms.FrmStart.RedoToolStripButton.Enabled = true;
        }

        internal static void Redo()
        {
            if (BackUpRedos > 0)
                BackUpRedos = BackUpRedos - 1;
            if (BackUpUndos < 5)
                BackUpUndos = BackUpUndos + 1;
            if (BackUpPointer == 4)
            {
                Restore(1);
            }
            else if (BackUpPointer == 5)
            {
                Restore(2);
            }
            else
            {
                Restore(BackUpPointer + 2);
            }

            BackUpPointer = BackUpPointer + 1;
            if (BackUpPointer == 6)
                BackUpPointer = 1;
            if (BackUpRedos == 0)
            {
                My.MyProject.Forms.FrmStart.RedoMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.RedoToolStripButton.Enabled = false;
            }

            My.MyProject.Forms.FrmStart.UndoMenuItem.Enabled = true;
            My.MyProject.Forms.FrmStart.UndoToolStripButton.Enabled = true;
        }

        private static void Store(int N)
        {
            if (N == 1)
                StoreMem(ref mem1);
            if (N == 2)
                StoreMem(ref mem2);
            if (N == 3)
                StoreMem(ref mem3);
            if (N == 4)
                StoreMem(ref mem4);
            if (N == 5)
                StoreMem(ref mem5);
        }

        private static void StoreMem(ref MemoryStream sfile)
        {
            var BFormatter = new BinaryFormatter();
            sfile.Position = 0L;
            BFormatter.Serialize(sfile, moduleMAPS.NoOfMaps);
            BFormatter.Serialize(sfile, moduleCLASSES.NoOfLands);
            BFormatter.Serialize(sfile, moduleLINES.NoOfLines);
            BFormatter.Serialize(sfile, modulePOLYS.NoOfPolys);
            BFormatter.Serialize(sfile, moduleCLASSES.NoOfWaters);
            BFormatter.Serialize(sfile, moduleOBJECTS.NoOfObjects);
            BFormatter.Serialize(sfile, moduleEXCLUDES.NoOfExcludes);
            BFormatter.Serialize(sfile, moduleCLASSES.NoOfLWCIs);
            BFormatter.Serialize(sfile, moduleMAIN.SomeSelected);
            BFormatter.Serialize(sfile, moduleMAIN.NoOfPointsSelected);
            if (moduleMAPS.NoOfMaps > 0)
            {
                BFormatter.Serialize(sfile, moduleMAPS.Maps);
                BFormatter.Serialize(sfile, moduleMAPS.NoOfMapsSelected);
            }

            if (moduleCLASSES.NoOfLands > 0)
            {
                BFormatter.Serialize(sfile, moduleCLASSES.NoOfLLXYs);
                BFormatter.Serialize(sfile, moduleCLASSES.LL_XY);
                BFormatter.Serialize(sfile, moduleCLASSES.LLands);
                BFormatter.Serialize(sfile, moduleCLASSES.NoOfLandsSelected);
            }

            if (moduleLINES.NoOfLines > 0)
            {
                BFormatter.Serialize(sfile, moduleLINES.Lines);
                BFormatter.Serialize(sfile, moduleLINES.NoOfLinesSelected);
            }

            if (modulePOLYS.NoOfPolys > 0)
            {
                BFormatter.Serialize(sfile, modulePOLYS.Polys);
                BFormatter.Serialize(sfile, modulePOLYS.NoOfPolysSelected);
            }

            if (moduleCLASSES.NoOfWaters > 0)
            {
                BFormatter.Serialize(sfile, moduleCLASSES.NoOfWWXYs);
                BFormatter.Serialize(sfile, moduleCLASSES.WW_XY);
                BFormatter.Serialize(sfile, moduleCLASSES.WWaters);
                BFormatter.Serialize(sfile, moduleCLASSES.NoOfWatersSelected);
            }

            if (moduleOBJECTS.NoOfObjects > 0)
            {
                BFormatter.Serialize(sfile, moduleOBJECTS.Objects);
                BFormatter.Serialize(sfile, moduleOBJECTS.NoOfObjectsSelected);
            }

            if (moduleEXCLUDES.NoOfExcludes > 0)
            {
                BFormatter.Serialize(sfile, moduleEXCLUDES.Excludes);
                BFormatter.Serialize(sfile, moduleEXCLUDES.NoOfExcludesSelected);
            }

            if (moduleCLASSES.NoOfLWCIs > 0)
                BFormatter.Serialize(sfile, moduleCLASSES.LWCIs);
        }

        private static void Restore(int N)
        {
            if (N == 1)
                RestoreMem(ref mem1);
            if (N == 2)
                RestoreMem(ref mem2);
            if (N == 3)
                RestoreMem(ref mem3);
            if (N == 4)
                RestoreMem(ref mem4);
            if (N == 5)
                RestoreMem(ref mem5);
        }

        private static void RestoreMem(ref MemoryStream ofile)
        {
            var BFormatter = new BinaryFormatter();
            ofile.Position = 0L;
            moduleMAPS.NoOfMaps = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleCLASSES.NoOfLands = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleLINES.NoOfLines = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            modulePOLYS.NoOfPolys = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleCLASSES.NoOfWaters = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleOBJECTS.NoOfObjects = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleEXCLUDES.NoOfExcludes = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleCLASSES.NoOfLWCIs = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            moduleMAIN.SomeSelected = Conversions.ToBoolean(BFormatter.Deserialize(ofile));
            moduleMAIN.NoOfPointsSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            if (moduleMAPS.NoOfMaps > 0)
            {
                moduleMAPS.Maps = (moduleMAPS.Map[])BFormatter.Deserialize(ofile);
                moduleMAPS.NoOfMapsSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleCLASSES.NoOfLands > 0)
            {
                moduleCLASSES.NoOfLLXYs = Conversions.ToInteger(BFormatter.Deserialize(ofile));
                moduleCLASSES.LL_XY = (moduleCLASSES.LWXY[,])BFormatter.Deserialize(ofile);
                moduleCLASSES.LLands = (byte[,,])BFormatter.Deserialize(ofile);
                moduleCLASSES.NoOfLandsSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleLINES.NoOfLines > 0)
            {
                moduleLINES.Lines = (moduleLINES.GLine[])BFormatter.Deserialize(ofile);
                moduleLINES.NoOfLinesSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (modulePOLYS.NoOfPolys > 0)
            {
                modulePOLYS.Polys = (modulePOLYS.GPoly[])BFormatter.Deserialize(ofile);
                modulePOLYS.NoOfPolysSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleCLASSES.NoOfWaters > 0)
            {
                moduleCLASSES.NoOfWWXYs = Conversions.ToInteger(BFormatter.Deserialize(ofile));
                moduleCLASSES.WW_XY = (moduleCLASSES.LWXY[,])BFormatter.Deserialize(ofile);
                moduleCLASSES.WWaters = (byte[,,])BFormatter.Deserialize(ofile);
                moduleCLASSES.NoOfWatersSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleOBJECTS.NoOfObjects > 0)
            {
                moduleOBJECTS.Objects = (moduleOBJECTS.Objecto[])BFormatter.Deserialize(ofile);
                moduleOBJECTS.NoOfObjectsSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleEXCLUDES.NoOfExcludes > 0)
            {
                moduleEXCLUDES.Excludes = (moduleEXCLUDES.Exclude[])BFormatter.Deserialize(ofile);
                moduleEXCLUDES.NoOfExcludesSelected = Conversions.ToInteger(BFormatter.Deserialize(ofile));
            }

            if (moduleCLASSES.NoOfLWCIs > 0)
                moduleCLASSES.LWCIs = (moduleCLASSES.LWCIndex[])BFormatter.Deserialize(ofile);
        }

        internal static void EditCut()
        {
            int N;
            bool GetIt;
            if (moduleLINES.LineON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleLINES.Lines[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleLINES.NoOfLines + 1)
                        return;
                }

                GetClipFromLine(N - 1);
                moduleLINES.DeleteLine(N - 1);
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
                My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                moduleMAIN.RebuildDisplay();
            }
            else if (modulePOLYS.PolyON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (modulePOLYS.Polys[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > modulePOLYS.NoOfPolys + 1)
                        return;
                }

                GetClipFromPoly(N - 1);
                modulePOLYS.DeletePoly(N - 1);
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
                My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                moduleMAIN.RebuildDisplay();
            }
            else if (moduleOBJECTS.ObjectON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleOBJECTS.Objects[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleOBJECTS.NoOfObjects + 1)
                        return;
                }

                ClipObject = moduleOBJECTS.Objects[N - 1];
                moduleOBJECTS.DeleteThisObject(N - 1);
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
                My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                moduleMAIN.RebuildDisplay();
            }
        }

        internal static void EditCopy()
        {
            int N;
            bool GetIt;
            if (moduleLINES.LineON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleLINES.Lines[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleLINES.NoOfLines + 1)
                        return;
                }

                GetClipFromLine(N - 1);
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
            }
            else if (modulePOLYS.PolyON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (modulePOLYS.Polys[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > modulePOLYS.NoOfPolys + 1)
                        return;
                }

                GetClipFromPoly(N - 1);
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
            }
            else if (moduleOBJECTS.ObjectON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleOBJECTS.Objects[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleOBJECTS.NoOfObjects + 1)
                        return;
                }

                ClipObject = moduleOBJECTS.Objects[N - 1];
                My.MyProject.Forms.FrmStart.PasteMenuItem.Enabled = true;
            }
        }

        internal static void EditPasteXY(int X, ref int Y)
        {
            double DX, DY;
            int N;
            DX = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            DY = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            if (BackUpON)
                BackUp();
            if (moduleLINES.LineON)
            {
                bool argFlag = false;
                moduleLINES.SelectAllLines(ref argFlag);
                moduleLINES.NoOfLines = moduleLINES.NoOfLines + 1;
                Array.Resize(ref moduleLINES.Lines, moduleLINES.NoOfLines + 1);
                GetLineFromClip(moduleLINES.NoOfLines);
                DX = DX - moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[1].lon;
                DY = moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[1].lat - DY;
                var loopTo = moduleLINES.Lines[moduleLINES.NoOfLines].NoOfPoints;
                for (N = 1; N <= loopTo; N++)
                {
                    moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[N].lat = moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[N].lat - DY;
                    moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[N].lon = moduleLINES.Lines[moduleLINES.NoOfLines].GLPoints[N].lon + DX;
                }

                moduleLINES.AddLatLonToLine(moduleLINES.NoOfLines);
                moduleLINES.Lines[moduleLINES.NoOfLines].Selected = true;
            }
            else if (modulePOLYS.PolyON)
            {
                bool argFlag1 = false;
                modulePOLYS.SelectAllPolys(ref argFlag1);
                modulePOLYS.NoOfPolys = modulePOLYS.NoOfPolys + 1;
                Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 1);
                GetPolyFromClip(modulePOLYS.NoOfPolys);
                DX = DX - modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[1].lon;
                DY = modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[1].lat - DY;
                var loopTo1 = modulePOLYS.Polys[modulePOLYS.NoOfPolys].NoOfPoints;
                for (N = 1; N <= loopTo1; N++)
                {
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[N].lat = modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[N].lat - DY;
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[N].lon = modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[N].lon + DX;
                }

                modulePOLYS.AddLatLonToPoly(modulePOLYS.NoOfPolys);
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].Selected = true;
            }
            else if (moduleOBJECTS.ObjectON)
            {
                bool argFlag2 = false;
                moduleOBJECTS.SelectAllObjects(ref argFlag2);
                moduleOBJECTS.NoOfObjects = moduleOBJECTS.NoOfObjects + 1;
                Array.Resize(ref moduleOBJECTS.Objects, moduleOBJECTS.NoOfObjects + 1);
                moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects] = ClipObject;
                DX = DX - moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lon;
                DY = moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lat - DY;
                moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lon = moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lon + DX;
                moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lat = moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].lat - DY;
                moduleOBJECTS.AddLatLonToObjects(moduleOBJECTS.NoOfObjects);
                moduleOBJECTS.Objects[moduleOBJECTS.NoOfObjects].Selected = true;
            }

            moduleMAIN.RebuildDisplay();
        }

        private static void GetLineFromClip(int N)
        {
            int K;
            moduleLINES.Lines[N].Name = ClipLine.Name;
            moduleLINES.Lines[N].Type = ClipLine.Type;
            moduleLINES.Lines[N].Guid = ClipLine.Guid;
            moduleLINES.Lines[N].Color = ClipLine.Color;
            moduleLINES.Lines[N].Selected = ClipLine.Selected;
            moduleLINES.Lines[N].NoOfPoints = ClipLine.NoOfPoints;
            moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[ClipLine.NoOfPoints + 1];
            var loopTo = ClipLine.NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                moduleLINES.Lines[N].GLPoints[K] = ClipLine.GLPoints[K];
        }

        private static void GetClipFromLine(int N)
        {
            int K;
            ClipLine.Name = moduleLINES.Lines[N].Name;
            ClipLine.Type = moduleLINES.Lines[N].Type;
            ClipLine.Guid = moduleLINES.Lines[N].Guid;
            ClipLine.Color = moduleLINES.Lines[N].Color;
            ClipLine.Selected = moduleLINES.Lines[N].Selected;
            ClipLine.NoOfPoints = moduleLINES.Lines[N].NoOfPoints;
            ClipLine.GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
            var loopTo = moduleLINES.Lines[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                ClipLine.GLPoints[K] = moduleLINES.Lines[N].GLPoints[K];
        }

        private static void GetPolyFromClip(int N)
        {

            // no childs - lost when copied 
            int K;
            modulePOLYS.Polys[N].Name = ClipPoly.Name;
            modulePOLYS.Polys[N].Type = ClipPoly.Type;
            modulePOLYS.Polys[N].Guid = ClipPoly.Guid;
            modulePOLYS.Polys[N].Color = ClipPoly.Color;
            modulePOLYS.Polys[N].Selected = ClipPoly.Selected;
            modulePOLYS.Polys[N].NoOfChilds = 0;
            modulePOLYS.Polys[N].NoOfPoints = ClipPoly.NoOfPoints;
            modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[ClipPoly.NoOfPoints + 1];
            var loopTo = ClipPoly.NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                modulePOLYS.Polys[N].GPoints[K] = ClipPoly.GPoints[K];
        }

        private static void GetClipFromPoly(int N)
        {
            int K;
            ClipPoly.Name = modulePOLYS.Polys[N].Name;
            ClipPoly.Type = modulePOLYS.Polys[N].Type;
            ClipPoly.Guid = modulePOLYS.Polys[N].Guid;
            ClipPoly.Color = modulePOLYS.Polys[N].Color;
            ClipPoly.Selected = modulePOLYS.Polys[N].Selected;
            ClipPoly.NoOfChilds = 0;
            ClipPoly.NoOfPoints = modulePOLYS.Polys[N].NoOfPoints;
            ClipPoly.GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
            var loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                ClipPoly.GPoints[K] = modulePOLYS.Polys[N].GPoints[K];
        }

        internal static void EditDelete()
        {
            int N;
            bool GetIt;
            float X;
            BackUp();
            if (moduleLINES.LineON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleLINES.Lines[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleLINES.NoOfLines + 1)
                        return;
                }

                X = (float)Interaction.MsgBox("Delete this Line ?", (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Question + (int)MsgBoxStyle.DefaultButton2), moduleMAIN.AppTitle);
                if (X == (float)MsgBoxResult.Yes)
                {
                    moduleLINES.DeleteLine(N - 1);
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }
            else if (modulePOLYS.PolyON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (modulePOLYS.Polys[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > modulePOLYS.NoOfPolys + 1)
                        return;
                }

                X = (float)Interaction.MsgBox("Delete this Poly ?", (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Question + (int)MsgBoxStyle.DefaultButton2), moduleMAIN.AppTitle);
                if (X == (float)MsgBoxResult.Yes)
                {
                    modulePOLYS.DeletePoly(N - 1);
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }
            else if (moduleOBJECTS.ObjectON)
            {
                N = 1;
                GetIt = false;
                while (!GetIt)
                {
                    if (moduleOBJECTS.Objects[N].Selected)
                        GetIt = true;
                    N = N + 1;
                    if (N > moduleOBJECTS.NoOfObjects + 1)
                        return;
                }

                X = (float)Interaction.MsgBox("Delete this object ?", (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Question + (int)MsgBoxStyle.DefaultButton2), moduleMAIN.AppTitle);
                if (X == (float)MsgBoxResult.Yes)
                {
                    moduleOBJECTS.DeleteThisObject(N - 1);
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }
        }
    }
}