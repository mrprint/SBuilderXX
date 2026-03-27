// =============================================================
// TestState.cs
// In-process stubs for every static module field that
// SaveFileXml / OpenFileXml touch.
//
// Framework-agnostic — no NUnit or MSTest attributes here.
// Used by all three test classes.
// =============================================================

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBuilderXX;
using System.Drawing;
using System.IO;

namespace SBuilderXX.Tests
{
    internal static class TestState
    {
        internal static void Reset()
        {
            // ---- Test environment setup ----------------------------
            // Point the app at a temp folder so CheckFolders() and
            // ini file access don't fail outside the install directory.
            string testDir = Path.Combine(Path.GetTempPath(), "sbxx_test_app");
            Directory.CreateDirectory(testDir);
            moduleMAIN.AppPath = testDir;
            moduleMAIN.AppIni = Path.Combine(testDir, "SBuilderXX.ini");
            if (!File.Exists(moduleMAIN.AppIni))
                File.WriteAllText(moduleMAIN.AppIni, "");

            // ---- moduleMAIN ----------------------------------------
            moduleMAIN.ProjectName = string.Empty;
            moduleMAIN.BGLProjectFolder = string.Empty;
            moduleMAIN.Zoom = 0;
            moduleMAIN.LatDispCenter = 0.0;
            moduleMAIN.LonDispCenter = 0.0;
            moduleMAIN.QMIDLevel = 0;

            // ---- moduleMAPS ----------------------------------------
            moduleMAPS.NoOfMaps = 0;
            moduleMAPS.Maps = null;

            // ---- moduleLINES ---------------------------------------
            moduleLINES.NoOfLines = 0;
            moduleLINES.Lines = null;

            // ---- modulePOLYS ---------------------------------------
            modulePOLYS.NoOfPolys = 0;
            modulePOLYS.Polys = null;

            // ---- moduleCLASSES -------------------------------------
            moduleCLASSES.NoOfLands = 0;
            moduleCLASSES.NoOfWaters = 0;
            moduleCLASSES.NoOfLLXYs = 0;
            moduleCLASSES.NoOfWWXYs = 0;
            moduleCLASSES.LLands = null;
            moduleCLASSES.WWaters = null;
            moduleCLASSES.NoOfLWCIs = 0;
            moduleCLASSES.LWCIs = null;

            for (int j = 0; j <= 95; j++)
                for (int k = 0; k <= 63; k++)
                {
                    moduleCLASSES.LL_XY[j, k].NoOfLWs = 0;
                    moduleCLASSES.LL_XY[j, k].Pointer = 0;
                    moduleCLASSES.WW_XY[j, k].NoOfLWs = 0;
                    moduleCLASSES.WW_XY[j, k].Pointer = 0;
                }

            // Reinitialise LC/WC lookup tables every Reset so the
            // class-round-trip tests always have a clean identity mapping.
            InitClassLookups();

            // ---- moduleOBJECTS -------------------------------------
            moduleOBJECTS.NoOfObjects = 0;
            moduleOBJECTS.Objects = null;

            // ---- moduleEXCLUDES ------------------------------------
            moduleEXCLUDES.NoOfExcludes = 0;
            moduleEXCLUDES.Excludes = null;
        }

        // ----------------------------------------------------------
        // Initialise LC / WC lookup tables with an identity mapping.
        //
        // Production code loads these from disk (tools\LC.txt etc).
        // In tests we use a simple identity: ILC[i] == i, LC[i].Index == i.
        // This means a round-trip write→read of any index value comes
        // back unchanged, which is all the land/water class tests need.
        // ----------------------------------------------------------
        private static void InitClassLookups()
        {
            const int max = 255;   // byte max; arrays are size 256

            // LC (land classes) — LWClass[] with an Index field
            moduleCLASSES.LC = new moduleCLASSES.LWClass[max + 1];
            moduleCLASSES.ILC = new byte[max + 1];
            moduleCLASSES.NoOfLCs = max;

            // WC (water classes) — same struct type
            moduleCLASSES.WC = new moduleCLASSES.LWClass[max + 1];
            moduleCLASSES.IWC = new byte[max + 1];
            moduleCLASSES.NoOfWCs = max;

            for (int i = 0; i <= max; i++)
            {
                // Identity mapping: index value == byte value.
                // ILC[i] is the byte stored in LLands for class index i.
                // LC[b].Index is the class index recovered from byte b.
                moduleCLASSES.ILC[i] = (byte)i;
                moduleCLASSES.LC[i].Index = (byte)i;

                moduleCLASSES.IWC[i] = (byte)i;
                moduleCLASSES.WC[i].Index = (byte)i;
            }
        }

        // ----------------------------------------------------------
        // Convenience factory methods so test setup is one-liners.
        // ----------------------------------------------------------

        internal static moduleLINES.GLine MakeLine(
            string name, string type, string guid, int colorArgb,
            params (double lat, double lon, double alt, double wid)[] points)
        {
            var line = new moduleLINES.GLine
            {
                Name = name,
                Type = type,
                Guid = guid,
                Color = Color.FromArgb(colorArgb),
                NoOfPoints = points.Length,
                GLPoints = new modulePOINTS.GLPoint[points.Length + 1]
            };
            double nlat = -90, slat = 90, elon = -180, wlon = 180;
            for (int i = 0; i < points.Length; i++)
            {
                line.GLPoints[i + 1].lat = points[i].lat;
                line.GLPoints[i + 1].lon = points[i].lon;
                line.GLPoints[i + 1].alt = points[i].alt;
                line.GLPoints[i + 1].wid = points[i].wid;
                if (points[i].lat < slat) slat = points[i].lat;
                if (points[i].lat > nlat) nlat = points[i].lat;
                if (points[i].lon > elon) elon = points[i].lon;
                if (points[i].lon < wlon) wlon = points[i].lon;
            }
            line.NLAT = nlat; line.SLAT = slat;
            line.ELON = elon; line.WLON = wlon;
            return line;
        }

        internal static modulePOLYS.GPoly MakePoly(
            string name, string type, string guid, int colorArgb,
            params (double lat, double lon, double alt)[] points)
        {
            var poly = new modulePOLYS.GPoly
            {
                Name = name,
                Type = type,
                Guid = guid,
                Color = Color.FromArgb(colorArgb),
                NoOfChilds = 0,
                Childs = new int[1],
                NoOfPoints = points.Length,
                GPoints = new modulePOINTS.GPoint[points.Length + 1]
            };
            double nlat = -90, slat = 90, elon = -180, wlon = 180;
            for (int i = 0; i < points.Length; i++)
            {
                poly.GPoints[i + 1].lat = points[i].lat;
                poly.GPoints[i + 1].lon = points[i].lon;
                poly.GPoints[i + 1].alt = points[i].alt;
                if (points[i].lat < slat) slat = points[i].lat;
                if (points[i].lat > nlat) nlat = points[i].lat;
                if (points[i].lon > elon) elon = points[i].lon;
                if (points[i].lon < wlon) wlon = points[i].lon;
            }
            poly.NLAT = nlat; poly.SLAT = slat;
            poly.ELON = elon; poly.WLON = wlon;
            return poly;
        }

        // ----------------------------------------------------------
        // MSTest has no Assert.DoesNotThrow — this helper fills the gap.
        // ----------------------------------------------------------
        internal static void AssertDoesNotThrow(System.Action action, string message = null)
        {
            try
            {
                action();
            }
            catch (System.Exception ex)
            {
                throw new AssertFailedException(
                    (message ?? "Expected no exception")
                    + " but got: " + ex.GetType().Name + ": " + ex.Message);
            }
        }
    }
}