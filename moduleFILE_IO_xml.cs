// ============================================================
// EXTENSION TO moduleFILE_IO
// Adds SaveFileXml() and OpenFileXml() as drop-in replacements
// for SaveFile() / OpenFile(), using XDocument (System.Xml.Linq).
//
// Target framework : .NET 4.8
// No third-party dependencies — System.Xml.Linq is part of .NET 4.8.
//
// HOW TO USE
// ----------
//  1. Add this file to the SBuilderXX project.
//  2. Mark the existing moduleFILE_IO class declaration "partial":
//         static partial class moduleFILE_IO { ... }
//  3. Call SaveFileXml(filename) / OpenFileXml(filename) instead of
//     SaveFile / OpenFile.
//  4. Detect format at load time if you need backward compatibility:
//
//         string first = File.ReadLines(f).FirstOrDefault() ?? "";
//         if (first.TrimStart().StartsWith("<"))
//             moduleFILE_IO.OpenFileXml(f);
//         else
//             moduleFILE_IO.OpenFile(f);   // legacy binary
// ============================================================

using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SBuilderXX
{
    static partial class moduleFILE_IO
    {
        private const string XmlFormatVersion = "SBXX_XML_100";
        private static readonly CultureInfo IC = CultureInfo.InvariantCulture;


        // ==================================================================
        //  S A V E
        // ==================================================================

        internal static void SaveFileXml(string filename)
        {
            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement("SBuilderProject",
                    new XAttribute("version", XmlFormatVersion),

                    BuildHeader(),
                    BuildMaps(),
                    BuildLines(),
                    BuildPolys(),
                    BuildLandClasses(),
                    BuildWaterClasses(),
                    BuildExcludes(),
                    BuildObjects(),
                    BuildLWCIs()
                )
            );

            doc.Save(filename);
        }

        // ---- section builders --------------------------------------------

        private static XElement BuildHeader()
        {
            return new XElement("Header",
                Xe("Name", moduleMAIN.ProjectName),
                Xe("BGLFolder", moduleMAIN.BGLProjectFolder),
                Xe("Zoom", moduleMAIN.Zoom),
                Xe("LatCenter", moduleMAIN.LatDispCenter),
                Xe("LonCenter", moduleMAIN.LonDispCenter),
                Xe("QMIDLevel", moduleMAIN.QMIDLevel)
            );
        }

        private static XElement BuildMaps()
        {
            var maps = new XElement("Maps", new XAttribute("count", moduleMAPS.NoOfMaps));
            for (int n = 1; n <= moduleMAPS.NoOfMaps; n++)
            {
                maps.Add(new XElement("Map",
                    Xe("Name", moduleMAPS.Maps[n].Name),
                    Xe("BMPSu", moduleMAPS.Maps[n].BMPSu),
                    Xe("BMPSp", moduleMAPS.Maps[n].BMPSp),
                    Xe("BMPFa", moduleMAPS.Maps[n].BMPFa),
                    Xe("BMPWi", moduleMAPS.Maps[n].BMPWi),
                    Xe("BMPHw", moduleMAPS.Maps[n].BMPHw),
                    Xe("BMPLm", moduleMAPS.Maps[n].BMPLm),
                    Xe("Cols", moduleMAPS.Maps[n].COLS),
                    Xe("Rows", moduleMAPS.Maps[n].ROWS),
                    Xe("NLat", moduleMAPS.Maps[n].NLAT),
                    Xe("SLat", moduleMAPS.Maps[n].SLAT),
                    Xe("ELon", moduleMAPS.Maps[n].ELON),
                    Xe("WLon", moduleMAPS.Maps[n].WLON)
                ));
            }
            return maps;
        }

        private static XElement BuildLines()
        {
            var lines = new XElement("Lines", new XAttribute("count", moduleLINES.NoOfLines));
            for (int n = 1; n <= moduleLINES.NoOfLines; n++)
            {
                var line = new XElement("Line",
                    new XAttribute("name", moduleLINES.Lines[n].Name),
                    new XAttribute("type", moduleLINES.Lines[n].Type),
                    new XAttribute("guid", moduleLINES.Lines[n].Guid),
                    new XAttribute("color", ArgbFromColor(moduleLINES.Lines[n].Color))
                );
                for (int m = 1; m <= moduleLINES.Lines[n].NoOfPoints; m++)
                {
                    line.Add(new XElement("Point",
                        new XAttribute("lat", F(moduleLINES.Lines[n].GLPoints[m].lat)),
                        new XAttribute("lon", F(moduleLINES.Lines[n].GLPoints[m].lon)),
                        new XAttribute("alt", F(moduleLINES.Lines[n].GLPoints[m].alt)),
                        new XAttribute("wid", F(moduleLINES.Lines[n].GLPoints[m].wid))
                    ));
                }
                lines.Add(line);
            }
            return lines;
        }

        private static XElement BuildPolys()
        {
            var polys = new XElement("Polys", new XAttribute("count", modulePOLYS.NoOfPolys));
            for (int n = 1; n <= modulePOLYS.NoOfPolys; n++)
            {
                var poly = new XElement("Poly",
                    new XAttribute("name", modulePOLYS.Polys[n].Name),
                    new XAttribute("type", modulePOLYS.Polys[n].Type),
                    new XAttribute("guid", modulePOLYS.Polys[n].Guid),
                    new XAttribute("color", ArgbFromColor(modulePOLYS.Polys[n].Color))
                );
                // child poly references
                if (modulePOLYS.Polys[n].NoOfChilds > 0)
                {
                    var childs = new XElement("Childs");
                    for (int m = 1; m <= modulePOLYS.Polys[n].NoOfChilds; m++)
                        childs.Add(new XElement("Child",
                            new XAttribute("ref", modulePOLYS.Polys[n].Childs[m])));
                    poly.Add(childs);
                }
                // points
                for (int m = 1; m <= modulePOLYS.Polys[n].NoOfPoints; m++)
                {
                    poly.Add(new XElement("Point",
                        new XAttribute("lat", F(modulePOLYS.Polys[n].GPoints[m].lat)),
                        new XAttribute("lon", F(modulePOLYS.Polys[n].GPoints[m].lon)),
                        new XAttribute("alt", F(modulePOLYS.Polys[n].GPoints[m].alt))
                    ));
                }
                polys.Add(poly);
            }
            return polys;
        }

        private static XElement BuildLandClasses()
        {
            var root = new XElement("LandClasses", new XAttribute("count", moduleCLASSES.NoOfLLXYs));
            if (moduleCLASSES.NoOfLLXYs <= 0) return root;

            for (int k = 0; k <= 63; k++)
            {
                for (int j = 0; j <= 95; j++)
                {
                    if (moduleCLASSES.LL_XY[j, k].NoOfLWs <= 0) continue;

                    int p = moduleCLASSES.LL_XY[j, k].Pointer;
                    var cell = new XElement("Cell",
                        new XAttribute("u", j),
                        new XAttribute("v", k)
                    );
                    for (int r = 0; r <= 256; r++)
                        for (int c = 0; c <= 256; c++)
                        {
                            byte val = moduleCLASSES.LLands[c, r, p];
                            if (val > 0 && val != 254)
                                cell.Add(new XElement("E",
                                    new XAttribute("c", c),
                                    new XAttribute("r", r),
                                    new XAttribute("i", moduleCLASSES.LC[val].Index)));
                        }
                    root.Add(cell);
                }
            }
            return root;
        }

        private static XElement BuildWaterClasses()
        {
            var root = new XElement("WaterClasses", new XAttribute("count", moduleCLASSES.NoOfWWXYs));
            if (moduleCLASSES.NoOfWWXYs <= 0) return root;

            for (int k = 0; k <= 63; k++)
            {
                for (int j = 0; j <= 95; j++)
                {
                    if (moduleCLASSES.WW_XY[j, k].NoOfLWs <= 0) continue;

                    int p = moduleCLASSES.WW_XY[j, k].Pointer;
                    var cell = new XElement("Cell",
                        new XAttribute("u", j),
                        new XAttribute("v", k)
                    );
                    for (int r = 0; r <= 256; r++)
                        for (int c = 0; c <= 256; c++)
                        {
                            byte val = moduleCLASSES.WWaters[c, r, p];
                            if (val > 0 && val != 254)
                                cell.Add(new XElement("E",
                                    new XAttribute("c", c),
                                    new XAttribute("r", r),
                                    new XAttribute("i", moduleCLASSES.WC[val].Index)));
                        }
                    root.Add(cell);
                }
            }
            return root;
        }

        private static XElement BuildExcludes()
        {
            var excl = new XElement("Excludes", new XAttribute("count", moduleEXCLUDES.NoOfExcludes));
            for (int n = 1; n <= moduleEXCLUDES.NoOfExcludes; n++)
            {
                excl.Add(new XElement("Exclude",
                    new XAttribute("flag", moduleEXCLUDES.Excludes[n].Flag),
                    new XAttribute("nlat", F(moduleEXCLUDES.Excludes[n].NLAT)),
                    new XAttribute("slat", F(moduleEXCLUDES.Excludes[n].SLAT)),
                    new XAttribute("elon", F(moduleEXCLUDES.Excludes[n].ELON)),
                    new XAttribute("wlon", F(moduleEXCLUDES.Excludes[n].WLON))
                ));
            }
            return excl;
        }

        private static XElement BuildObjects()
        {
            var objs = new XElement("Objects", new XAttribute("count", moduleOBJECTS.NoOfObjects));
            for (int n = 1; n <= moduleOBJECTS.NoOfObjects; n++)
            {
                objs.Add(new XElement("Object",
                    new XAttribute("type", moduleOBJECTS.Objects[n].Type),
                    new XAttribute("description", moduleOBJECTS.Objects[n].Description),
                    new XAttribute("width", F(moduleOBJECTS.Objects[n].Width)),
                    new XAttribute("length", F(moduleOBJECTS.Objects[n].Length)),
                    new XAttribute("heading", F(moduleOBJECTS.Objects[n].Heading)),
                    new XAttribute("pitch", F(moduleOBJECTS.Objects[n].Pitch)),
                    new XAttribute("bank", F(moduleOBJECTS.Objects[n].Bank)),
                    new XAttribute("biasX", F(moduleOBJECTS.Objects[n].BiasX)),
                    new XAttribute("biasY", F(moduleOBJECTS.Objects[n].BiasY)),
                    new XAttribute("biasZ", F(moduleOBJECTS.Objects[n].BiasZ)),
                    new XAttribute("lat", F(moduleOBJECTS.Objects[n].lat)),
                    new XAttribute("lon", F(moduleOBJECTS.Objects[n].lon)),
                    new XAttribute("altitude", F(moduleOBJECTS.Objects[n].Altitude)),
                    new XAttribute("agl", moduleOBJECTS.Objects[n].AGL),
                    new XAttribute("complexity", moduleOBJECTS.Objects[n].Complexity)
                ));
            }
            return objs;
        }

        private static XElement BuildLWCIs()
        {
            var lwcis = new XElement("LWCIs", new XAttribute("count", moduleCLASSES.NoOfLWCIs));
            for (int n = 1; n <= moduleCLASSES.NoOfLWCIs; n++)
            {
                lwcis.Add(new XElement("LWCI",
                    new XAttribute("color", ArgbFromColor(moduleCLASSES.LWCIs[n].Color)),
                    new XAttribute("text", moduleCLASSES.LWCIs[n].Text)
                ));
            }
            return lwcis;
        }


        // ==================================================================
        //  L O A D
        // ==================================================================

        internal static void OpenFileXml(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("This file was not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                XDocument doc = XDocument.Load(filename);
                XElement root = doc.Root;

                if (root == null || root.Name != "SBuilderProject")
                    throw new InvalidDataException("Not a valid SBuilderXX XML project file.");

                string ver = (string)root.Attribute("version") ?? "";
                if (!ver.StartsWith("SBXX_XML_"))
                    throw new InvalidDataException("Unrecognised file version: " + ver);

                SetFileBackUp(filename);

                // ---- header -----------------------------------------------
                XElement hdr = root.Element("Header");
                moduleMAIN.ProjectName = Xs(hdr, "Name");
                moduleMAIN.BGLProjectFolder = Xs(hdr, "BGLFolder");
                if (!string.IsNullOrEmpty(moduleMAIN.BGLProjectFolder))
                    moduleMAIN.CheckFolders();
                moduleMAIN.Zoom = Xi(hdr, "Zoom");
                moduleMAIN.LatDispCenter = Xd(hdr, "LatCenter");
                moduleMAIN.LonDispCenter = Xd(hdr, "LonCenter");
                moduleMAIN.QMIDLevel = Xi(hdr, "QMIDLevel");

                // ---- maps -------------------------------------------------
                XElement mapsEl = root.Element("Maps");
                int noMaps = XiAttr(mapsEl, "count");
                moduleMAPS.NoOfMaps = noMaps;
                if (noMaps > 0)
                {
                    moduleMAPS.Maps = new moduleMAPS.Map[noMaps + 1];
                    int n = 1;
                    foreach (XElement m in mapsEl.Elements("Map"))
                    {
                        moduleMAPS.Maps[n].Name = Xs(m, "Name");
                        moduleMAPS.Maps[n].BMPSu = Xs(m, "BMPSu");
                        moduleMAPS.Maps[n].BMPSp = Xs(m, "BMPSp");
                        moduleMAPS.Maps[n].BMPFa = Xs(m, "BMPFa");
                        moduleMAPS.Maps[n].BMPWi = Xs(m, "BMPWi");
                        moduleMAPS.Maps[n].BMPHw = Xs(m, "BMPHw");
                        moduleMAPS.Maps[n].BMPLm = Xs(m, "BMPLm");
                        moduleMAPS.Maps[n].COLS = Xi(m, "Cols");
                        moduleMAPS.Maps[n].ROWS = Xi(m, "Rows");
                        moduleMAPS.Maps[n].NLAT = Xd(m, "NLat");
                        moduleMAPS.Maps[n].SLAT = Xd(m, "SLat");
                        moduleMAPS.Maps[n].ELON = Xd(m, "ELon");
                        moduleMAPS.Maps[n].WLON = Xd(m, "WLon");
                        n++;
                    }
                }

                // ---- lines ------------------------------------------------
                XElement linesEl = root.Element("Lines");
                int noLines = XiAttr(linesEl, "count");
                moduleLINES.NoOfLines = noLines;
                if (noLines > 0)
                {
                    moduleLINES.Lines = new moduleLINES.GLine[noLines + 1];
                    int n = 1;
                    foreach (XElement le in linesEl.Elements("Line"))
                    {
                        moduleLINES.Lines[n].Name = XsAttr(le, "name");
                        moduleLINES.Lines[n].Type = XsAttr(le, "type");
                        moduleLINES.Lines[n].Guid = XsAttr(le, "guid");
                        moduleLINES.Lines[n].Color = ColorFromArgb(XsAttr(le, "color"));

                        XElement[] pts = le.Elements("Point").ToArray();
                        int nPts = pts.Length;
                        moduleLINES.Lines[n].NoOfPoints = nPts;
                        moduleLINES.Lines[n].Name = string.IsNullOrEmpty(moduleLINES.Lines[n].Name)
                            ? nPts + "_Pts_Line" : moduleLINES.Lines[n].Name;

                        moduleLINES.Lines[n].GLPoints = new modulePOINTS.GLPoint[nPts + 1];
                        double nlat = -90, slat = 90, elon = -180, wlon = 180;

                        for (int m = 0; m < nPts; m++)
                        {
                            double lat = XdAttr(pts[m], "lat");
                            double lon = XdAttr(pts[m], "lon");
                            moduleLINES.Lines[n].GLPoints[m + 1].lat = lat;
                            moduleLINES.Lines[n].GLPoints[m + 1].lon = lon;
                            moduleLINES.Lines[n].GLPoints[m + 1].alt = XdAttr(pts[m], "alt");
                            moduleLINES.Lines[n].GLPoints[m + 1].wid = XdAttr(pts[m], "wid");
                            if (lat < slat) slat = lat;
                            if (lat > nlat) nlat = lat;
                            if (lon > elon) elon = lon;
                            if (lon < wlon) wlon = lon;
                        }
                        moduleLINES.Lines[n].NLAT = nlat;
                        moduleLINES.Lines[n].SLAT = slat;
                        moduleLINES.Lines[n].ELON = elon;
                        moduleLINES.Lines[n].WLON = wlon;
                        n++;
                    }
                }

                // ---- polys ------------------------------------------------
                XElement polysEl = root.Element("Polys");
                int noPolys = XiAttr(polysEl, "count");
                modulePOLYS.NoOfPolys = noPolys;
                if (noPolys > 0)
                {
                    modulePOLYS.Polys = new modulePOLYS.GPoly[noPolys + 1];
                    int n = 1;
                    foreach (XElement pe in polysEl.Elements("Poly"))
                    {
                        modulePOLYS.Polys[n].Name = XsAttr(pe, "name");
                        modulePOLYS.Polys[n].Type = XsAttr(pe, "type");
                        modulePOLYS.Polys[n].Guid = XsAttr(pe, "guid");
                        modulePOLYS.Polys[n].Color = ColorFromArgb(XsAttr(pe, "color"));

                        // childs
                        XElement childsEl = pe.Element("Childs");
                        if (childsEl != null)
                        {
                            XElement[] crefs = childsEl.Elements("Child").ToArray();
                            modulePOLYS.Polys[n].NoOfChilds = crefs.Length;
                            modulePOLYS.Polys[n].Childs = new int[crefs.Length + 1];
                            for (int m = 0; m < crefs.Length; m++)
                                modulePOLYS.Polys[n].Childs[m + 1] = XiAttr(crefs[m], "ref");
                        }
                        else
                        {
                            modulePOLYS.Polys[n].NoOfChilds = 0;
                            modulePOLYS.Polys[n].Childs = new int[1];
                        }

                        // points
                        XElement[] pts = pe.Elements("Point").ToArray();
                        int nPts = pts.Length;
                        modulePOLYS.Polys[n].NoOfPoints = nPts;
                        modulePOLYS.Polys[n].Name = string.IsNullOrEmpty(modulePOLYS.Polys[n].Name)
                            ? nPts + "_Pts_Polygon" : modulePOLYS.Polys[n].Name;

                        modulePOLYS.Polys[n].GPoints = new modulePOINTS.GPoint[nPts + 1];
                        double nlat = -90, slat = 90, elon = -180, wlon = 180;

                        for (int m = 0; m < nPts; m++)
                        {
                            double lat = XdAttr(pts[m], "lat");
                            double lon = XdAttr(pts[m], "lon");
                            modulePOLYS.Polys[n].GPoints[m + 1].lat = lat;
                            modulePOLYS.Polys[n].GPoints[m + 1].lon = lon;
                            modulePOLYS.Polys[n].GPoints[m + 1].alt = XdAttr(pts[m], "alt");
                            if (lat < slat) slat = lat;
                            if (lat > nlat) nlat = lat;
                            if (lon > elon) elon = lon;
                            if (lon < wlon) wlon = lon;
                        }
                        modulePOLYS.Polys[n].NLAT = nlat;
                        modulePOLYS.Polys[n].SLAT = slat;
                        modulePOLYS.Polys[n].ELON = elon;
                        modulePOLYS.Polys[n].WLON = wlon;
                        n++;
                    }
                }

                // ---- land classes -----------------------------------------
                XElement lcEl = root.Element("LandClasses");
                int noLLXYs = XiAttr(lcEl, "count");
                moduleCLASSES.NoOfLLXYs = noLLXYs;
                if (noLLXYs > 0)
                {
                    int totalLands = 0;
                    moduleCLASSES.LLands = new byte[257, 257, noLLXYs];
                    int p = 0;
                    foreach (XElement cell in lcEl.Elements("Cell"))
                    {
                        int j = XiAttr(cell, "u");
                        int k = XiAttr(cell, "v");
                        moduleCLASSES.LL_XY[j, k].Pointer = p;

                        int cellCount = 0;
                        foreach (XElement e in cell.Elements("E"))
                        {
                            int c = XiAttr(e, "c");
                            int r = XiAttr(e, "r");
                            int idx = XiAttr(e, "i");
                            moduleCLASSES.LLands[c, r, p] = moduleCLASSES.ILC[idx];
                            cellCount++;
                            totalLands++;
                        }
                        moduleCLASSES.LL_XY[j, k].NoOfLWs = cellCount;
                        p++;
                    }
                    moduleCLASSES.NoOfLands = totalLands;
                }

                // ---- water classes ----------------------------------------
                XElement wcEl = root.Element("WaterClasses");
                int noWWXYs = XiAttr(wcEl, "count");
                moduleCLASSES.NoOfWWXYs = noWWXYs;
                if (noWWXYs > 0)
                {
                    int totalWaters = 0;
                    moduleCLASSES.WWaters = new byte[257, 257, noWWXYs];
                    int p = 0;
                    foreach (XElement cell in wcEl.Elements("Cell"))
                    {
                        int j = XiAttr(cell, "u");
                        int k = XiAttr(cell, "v");
                        moduleCLASSES.WW_XY[j, k].Pointer = p;

                        int cellCount = 0;
                        foreach (XElement e in cell.Elements("E"))
                        {
                            int c = XiAttr(e, "c");
                            int r = XiAttr(e, "r");
                            int idx = XiAttr(e, "i");
                            moduleCLASSES.WWaters[c, r, p] = moduleCLASSES.IWC[idx];
                            cellCount++;
                            totalWaters++;
                        }
                        moduleCLASSES.WW_XY[j, k].NoOfLWs = cellCount;
                        p++;
                    }
                    moduleCLASSES.NoOfWaters = totalWaters;
                }

                // ---- excludes ---------------------------------------------
                XElement exclEl = root.Element("Excludes");
                int noExcludes = XiAttr(exclEl, "count");
                moduleEXCLUDES.NoOfExcludes = noExcludes;
                if (noExcludes > 0)
                {
                    moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[noExcludes + 1];
                    int n = 1;
                    foreach (XElement e in exclEl.Elements("Exclude"))
                    {
                        moduleEXCLUDES.Excludes[n].Flag = XiAttr(e, "flag");
                        moduleEXCLUDES.Excludes[n].NLAT = XdAttr(e, "nlat");
                        moduleEXCLUDES.Excludes[n].SLAT = XdAttr(e, "slat");
                        moduleEXCLUDES.Excludes[n].ELON = XdAttr(e, "elon");
                        moduleEXCLUDES.Excludes[n].WLON = XdAttr(e, "wlon");
                        n++;
                    }
                }

                // ---- objects ----------------------------------------------
                XElement objsEl = root.Element("Objects");
                int noObjects = XiAttr(objsEl, "count");
                moduleOBJECTS.NoOfObjects = noObjects;
                if (noObjects > 0)
                {
                    moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[noObjects + 1];
                    int n = 1;
                    foreach (XElement e in objsEl.Elements("Object"))
                    {
                        moduleOBJECTS.Objects[n].Type = XiAttr(e, "type");
                        moduleOBJECTS.Objects[n].Description = XsAttr(e, "description");
                        moduleOBJECTS.Objects[n].Width = XfAttr(e, "width");
                        moduleOBJECTS.Objects[n].Length = XfAttr(e, "length");
                        moduleOBJECTS.Objects[n].Heading = XfAttr(e, "heading");
                        moduleOBJECTS.Objects[n].Pitch = XfAttr(e, "pitch");
                        moduleOBJECTS.Objects[n].Bank = XfAttr(e, "bank");
                        moduleOBJECTS.Objects[n].BiasX = XfAttr(e, "biasX");
                        moduleOBJECTS.Objects[n].BiasY = XfAttr(e, "biasY");
                        moduleOBJECTS.Objects[n].BiasZ = XfAttr(e, "biasZ");
                        moduleOBJECTS.Objects[n].lat = XdAttr(e, "lat");
                        moduleOBJECTS.Objects[n].lon = XdAttr(e, "lon");
                        moduleOBJECTS.Objects[n].Altitude = XdAttr(e, "altitude");
                        moduleOBJECTS.Objects[n].AGL = XiAttr(e, "agl");
                        moduleOBJECTS.Objects[n].Complexity = XiAttr(e, "complexity");
                        moduleOBJECTS.AddLatLonToObjects(n);
                        n++;
                    }
                }

                // ---- LWCIs ------------------------------------------------
                XElement lwcisEl = root.Element("LWCIs");
                int noLWCIs = XiAttr(lwcisEl, "count");
                moduleCLASSES.NoOfLWCIs = noLWCIs;
                if (noLWCIs > 0)
                {
                    moduleCLASSES.LWCIs = new moduleCLASSES.LWCIndex[noLWCIs + 1];
                    int n = 1;
                    foreach (XElement e in lwcisEl.Elements("LWCI"))
                    {
                        moduleCLASSES.LWCIs[n].Text = XsAttr(e, "text");
                        moduleCLASSES.LWCIs[n].Color = ColorFromArgb(XsAttr(e, "color"));
                        n++;
                    }
                    SetLWCIs();
                }

                UpdateFileMenu(filename);
            }
            catch (Exception ex)
            {
                moduleMAPS.NoOfMaps = 0;
                moduleCLASSES.NoOfLands = 0;
                moduleLINES.NoOfLines = 0;
                modulePOLYS.NoOfPolys = 0;
                moduleCLASSES.NoOfWaters = 0;
                moduleOBJECTS.NoOfObjects = 0;
                moduleEXCLUDES.NoOfExcludes = 0;
                moduleCLASSES.NoOfLWCIs = 0;
                moduleCLASSES.NoOfLLXYs = 0;
                moduleCLASSES.NoOfWWXYs = 0;

                MessageBox.Show("Error loading XML project file:\n" + ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // ==================================================================
        //  X M L   M I N I - H E L P E R S
        //  Short names keep the builder code above readable.
        // ==================================================================

        // --- child element read (element value) ---
        private static string Xs(XElement el, string name)
            => (string)el?.Element(name) ?? string.Empty;

        private static int Xi(XElement el, string name)
        {
            int v;
            return int.TryParse((string)el?.Element(name), NumberStyles.Integer, IC, out v) ? v : 0;
        }

        private static double Xd(XElement el, string name)
        {
            double v;
            return double.TryParse((string)el?.Element(name), NumberStyles.Float, IC, out v) ? v : 0.0;
        }

        // --- attribute read ---
        private static string XsAttr(XElement el, string name)
            => (string)el?.Attribute(name) ?? string.Empty;

        private static int XiAttr(XElement el, string name)
        {
            int v;
            return int.TryParse((string)el?.Attribute(name), NumberStyles.Integer, IC, out v) ? v : 0;
        }

        private static double XdAttr(XElement el, string name)
        {
            double v;
            return double.TryParse((string)el?.Attribute(name), NumberStyles.Float, IC, out v) ? v : 0.0;
        }

        private static float XfAttr(XElement el, string name)
        {
            float v;
            return float.TryParse((string)el?.Attribute(name), NumberStyles.Float, IC, out v) ? v : 0f;
        }

        // --- write helper: child element with invariant-culture value ---
        private static XElement Xe(string name, string value)
            => new XElement(name, value ?? string.Empty);

        private static XElement Xe(string name, int value)
            => new XElement(name, value.ToString(IC));

        private static XElement Xe(string name, double value)
            => new XElement(name, value.ToString("R", IC));

        // --- float-to-string with full round-trip precision ---
        private static string F(double v) => v.ToString("R", IC);
        private static string F(float v) => v.ToString("R", IC);
    }
}
