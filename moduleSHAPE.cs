using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBuilderXX
{
    // This module was written on October 2017 to replace the old one.
    // Now it uses 64-bit ArcShapeFileNetDLLx64.dll
    // in November 2017 it uses no external DLL

    static class moduleSHAPE
    {
        internal static string[] FieldNames;
        internal static int NoOfFields;
        internal static bool IsZ;
        internal static string ShapeLineGuid;
        internal static string ShapeLineName;
        internal static double ShapeLineAltitude;
        internal static double ShapeLineWidth;
        internal static Color ShapeLineColor;
        internal static int ShapeLineGuidField;
        internal static int ShapeLineNameField;
        internal static int ShapeLineAltitudeField;
        internal static int ShapeLineWidthField;
        internal static int ShapeLineColorField;
        internal static string ShapePolyGuid;
        internal static string ShapePolyName;
        internal static double ShapePolyAltitude;
        internal static Color ShapePolyColor;
        internal static int ShapePolyGuidField;
        internal static int ShapePolyNameField;
        internal static int ShapePolyAltitudeField;
        internal static int ShapePolyColorField;
        internal static bool ShapeLineCancel = false;
        internal static bool ShapePolyCancel = false;
        internal static bool AddToCells;

        // these are used by appending FWX lines
        // will be changed to whatever is set when
        // we close the Properties page of a line
        internal static byte DefaultNoOfLanes = 2;
        internal static string DefaultTrafficDir = "F";

        // used by classDBFWriter
        private const byte shp_CHARACTER = 67;   // C
        private const byte shp_NUMERIC = 78;     // N
        private const byte shp_FLOAT = 70;    // F

        internal static void AppendSHPFile(string filename)
        {
            SHPReader SHP = new SHPReader();
            int shpType;
            int NoOfItems = 0;
            double xMin, xMax, yMin, yMax;
            bool IsValid = false;
            bool IsLine = false;
            IsZ = false;

            try
            {
                // open shape file
                SHP.GetInfo(filename);

                // get shape info
                shpType = SHP.shpType;
                NoOfItems = (int)SHP.recordCount;
                xMin = SHP.xMin;
                xMax = SHP.xMax;
                yMin = SHP.yMin;
                yMax = SHP.yMax;
                SHP.Close();

                // ShpPolyLine
                if (shpType == 3)     // line with Z
                {
                    IsValid = true;
                    IsZ = false;
                    IsLine = true;
                }

                // ShpPolygon
                if (shpType == 5)     // polygon without Z
                {
                    IsValid = true;
                    IsZ = false;
                    IsLine = false;
                }

                // ShpPolyLineZ 
                if (shpType == 13)    // line with Z
                {
                    IsValid = true;
                    IsZ = true;
                    IsLine = true;
                }

                // ShpPolygonZ
                if (shpType == 15)    // poly with Z
                {
                    IsValid = true;
                    IsZ = true;
                    IsLine = false;
                }

                if (xMin < -180)
                    IsValid = false;
                if (xMax > 180d)
                    IsValid = false;
                if (yMin < -90)
                    IsValid = false;
                if (yMax > 90d)
                    IsValid = false;
                if (!IsValid)
                {
                    throw new Exception();
                }

                if (IsLine)
                {
                    AppendSHPLines(filename, NoOfItems, IsZ);
                }
                else
                {
                    AppendSHPPolys(filename, NoOfItems, IsZ);
                }

                moduleMAIN.LonDispCenter = (xMin + xMax) / 2d;
                moduleMAIN.LatDispCenter = (yMin + yMax) / 2d;
                moduleMAIN.ViewON = true;
                moduleMAIN.Zoom = 8;
                moduleMAIN.ResetZoom();
                moduleMAIN.SetDispCenter(0, 0);
                moduleMAIN.Dirty = true;
                moduleMAIN.RebuildDisplay();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not append this Shapefile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void AppendSHPLines(string filename, int NoOfItems, bool IsZ)
        {
            moduleLINES.GLine[] myLines;
            double[] myWidths;
            double[] myAltitudes;
            string A;
            int recCount;
            int N, NV, K;
            DBFReader.FieldType[] FieldTypes;

            // open the dbase file
            DBFReader DBF = new DBFReader();
            if (!DBF.FileReader(filename))
            {
                MessageBox.Show("SBuilderXX can not read the database Shapefile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            recCount = DBF.RecordCount;
            NoOfFields = DBF.FieldCount;
            if (recCount != NoOfItems)
            {
                MessageBox.Show("The number of records in database is different from the number of shapes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FieldNames = new string[NoOfFields];
            FieldTypes = new DBFReader.FieldType[NoOfFields];
            int TypeField = -1;  // added because of Luis Feliz - type for traffic lines was lost!
                                 // If there is a field with name = "Type" then the type of each line
                                 // is taken from the records of this field. TypeField < 0 means that the
                                 // type is obtained from the Guid

            // these are to catch the case of FWX lines
            bool IsLanes = false;
            bool IsDirT = false;
            int LanesField = default(int);
            int DirTField = default(int);
            byte[] myLanes = new byte[2];
            string[] myDirT = new string[2];
            int loopTo = NoOfFields - 1;
            for (N = 0; N <= loopTo; N++)
            {
                FieldTypes[N] = DBF.get_FieldInfo(N).Type;
                FieldNames[N] = DBF.get_FieldInfo(N).Name;
                if (FieldNames[N] == "Type")
                    TypeField = N;
                if (FieldNames[N] == "NumberOfLa")
                {
                    IsLanes = true;
                    LanesField = N;
                }

                if (FieldNames[N] == "TrafficDir")
                {
                    IsDirT = true;
                    DirTField = N;
                }
            }

            if (IsLanes | IsDirT)
                ShapeLineGuid = "{54B91ED8-BC02-41B7-8C3B-2B8449FF85EC}";
            My.MyProject.Forms.FrmSHPLine.ShowDialog();
            // *********************

            if (ShapeLineCancel)
            {
                DBF.Close();
                return;
            }

            if (ShapeLineNameField > 0)
            {
                if (FieldTypes[ShapeLineNameField - 1] != DBFReader.FieldType.FTString)
                {
                    A = "Field " + FieldNames[ShapeLineNameField - 1] + " is not a string and will be ignored!";
                    ShapeLineNameField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapeLineGuidField > 0)
            {
                if (FieldTypes[ShapeLineGuidField - 1] != DBFReader.FieldType.FTString)
                {
                    A = "Field " + FieldNames[ShapeLineGuidField - 1] + " is not a string and will be ignored!";
                    ShapeLineGuidField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapeLineWidthField > 0)
            {
                if (FieldTypes[ShapeLineWidthField - 1] != DBFReader.FieldType.FTDouble)
                {
                    A = "Field " + FieldNames[ShapeLineWidthField - 1] + " is not a double precision number and will be ignored!";
                    ShapeLineWidthField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (IsZ)
            {
                if (ShapeLineAltitudeField > 1)
                {
                    if (FieldTypes[ShapeLineAltitudeField - 2] != DBFReader.FieldType.FTDouble)
                    {
                        A = "Field " + FieldNames[ShapeLineAltitudeField - 2] + " is not a double precision number and will be ignored!";
                        ShapeLineAltitudeField = 0;
                        MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (ShapeLineAltitudeField > 0)
            {
                if (FieldTypes[ShapeLineAltitudeField - 1] != DBFReader.FieldType.FTDouble)
                {
                    A = "Field " + FieldNames[ShapeLineAltitudeField - 1] + " is not a double precision number and will be ignored!";
                    ShapeLineAltitudeField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapeLineAltitudeField > 1)
            {
                if (FieldTypes[ShapeLineAltitudeField - 2] != DBFReader.FieldType.FTDouble)
                {
                    A = "Field " + FieldNames[ShapeLineAltitudeField - 2] + " is not a double precision number and will be ignored!";
                    ShapeLineAltitudeField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapeLineColorField > 0)
            {
                if (FieldTypes[ShapeLineColorField - 1] != DBFReader.FieldType.FTInteger)
                {
                    A = "Field " + FieldNames[ShapeLineColorField - 1] + " is not an integer number and will be ignored!";
                    ShapeLineColorField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            myLines = new moduleLINES.GLine[NoOfItems];
            myWidths = new double[NoOfItems];
            myAltitudes = new double[NoOfItems];
            if (IsLanes)
                myLanes = new byte[NoOfItems];
            if (IsDirT)
                myDirT = new string[NoOfItems];
            int loopTo1 = NoOfItems - 1;
            for (N = 0; N <= loopTo1; N++)
            {
                if (ShapeLineNameField == 0)
                {
                    myLines[N].Name = ShapeLineName;
                }
                else
                {
                    myLines[N].Name = DBF.Attribute(N, ShapeLineNameField - 1);
                }

                if (ShapeLineGuidField == 0)
                {
                    myLines[N].Guid = ShapeLineGuid;
                }
                else
                {
                    A = DBF.Attribute(N, ShapeLineGuidField - 1);
                    if (!string.IsNullOrEmpty(A))
                    {
                        myLines[N].Guid = A;
                    }
                    else
                    {
                        myLines[N].Guid = ShapeLineGuid;
                    }
                }

                if (IsLanes)
                {
                    A = DBF.Attribute(N, LanesField);
                    if (!string.IsNullOrEmpty(A))
                        myLanes[N] = Convert.ToByte(A);
                    else
                        myLanes[N] = DefaultNoOfLanes;
                }

                if (IsDirT)
                {
                    A = DBF.Attribute(N, DirTField);
                    if (!string.IsNullOrEmpty(A))
                        myDirT[N] = A;
                    else
                        myDirT[N] = DefaultTrafficDir;
                }

                if (TypeField >= 0)
                {
                    myLines[N].Type = DBF.Attribute(N, TypeField);
                    if (string.IsNullOrEmpty(myLines[N].Type))
                    {
                        myLines[N].Type = GetLineTypeFromGuid(myLines[N].Guid);
                    }
                }
                else if (!IsLanes & !IsDirT)
                {
                    myLines[N].Type = GetLineTypeFromGuid(myLines[N].Guid);
                }
                else  // form the type here without looking to Guid
                {
                    A = "FWX";
                    if (IsLanes)
                        A = A + myLanes[N];
                    else
                        A = A + DefaultNoOfLanes;
                    if (IsDirT)
                        A = A + myDirT[N];
                    else
                        A = A + DefaultTrafficDir;
                    myLines[N].Type = A;
                }

                if (ShapeLineColorField == 0)
                {
                    myLines[N].Color = ShapeLineColor;
                }
                else
                {
                    A = DBF.Attribute(N, ShapeLineColorField - 1);
                    if (!string.IsNullOrEmpty(A))
                    {
                        myLines[N].Color = Color.FromArgb(Convert.ToInt32(A));
                    }
                    else
                    {
                        myLines[N].Color = ShapeLineColor;
                    }
                }

                if (ShapeLineWidthField == 0)
                {
                    myWidths[N] = ShapeLineWidth;
                }
                else
                {
                    A = DBF.Attribute(N, ShapeLineWidthField - 1);
                    if (!string.IsNullOrEmpty(A))
                    {
                        myWidths[N] = Convert.ToDouble(A);
                    }
                    else
                    {
                        myWidths[N] = ShapeLineWidth;
                    }
                }

                if (IsZ)
                {
                    if (ShapeLineAltitudeField == 0)
                    {
                        myAltitudes[N] = ShapeLineAltitude;
                    }
                    else if (ShapeLineAltitudeField > 1)
                    {
                        A = DBF.Attribute(N, ShapeLineAltitudeField - 2);
                        if (!string.IsNullOrEmpty(A))
                        {
                            myAltitudes[N] = Convert.ToDouble(A);
                        }
                        else
                        {
                            myAltitudes[N] = ShapeLineAltitude;
                        }
                    }
                }
                else if (ShapeLineAltitudeField == 0)
                {
                    myAltitudes[N] = ShapeLineAltitude;
                }
                else if (ShapeLineAltitudeField > 0)
                {
                    A = DBF.Attribute(N, ShapeLineAltitudeField - 1);
                    if (!string.IsNullOrEmpty(A))
                    {
                        myAltitudes[N] = Convert.ToDouble(A);
                    }
                    else
                    {
                        myAltitudes[N] = ShapeLineAltitude;
                    }
                }
            }

            DBF.Close();
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                // open shape file
                SHPReader SHP = new SHPReader();
                SHP.FileReader(filename);
                int loopTo2 = NoOfItems;
                for (N = 1; N <= loopTo2; N++)
                {
                    SHP.MoveTo(N);  // set the current record
                    NV = SHP.NumPoints;
                    myLines[N - 1].NoOfPoints = NV;
                    myLines[N - 1].GLPoints = new modulePOINTS.GLPoint[NV + 1];
                    int loopTo3 = NV;
                    for (K = 1; K <= loopTo3; K++)
                    {
                        myLines[N - 1].GLPoints[K].lon = SHP.get_Points(K).X;
                        myLines[N - 1].GLPoints[K].lat = SHP.get_Points(K).Y;
                        if (IsZ & ShapeLineAltitudeField == 1)
                        {
                            myLines[N - 1].GLPoints[K].alt = SHP.get_Points(K).Z;
                        }
                        else
                        {
                            myLines[N - 1].GLPoints[K].alt = myAltitudes[N - 1];
                        }

                        myLines[N - 1].GLPoints[K].wid = myWidths[N - 1];
                    }
                }

                // close the shape file
                SHP.Close();
                Array.Resize(ref moduleLINES.Lines, moduleLINES.NoOfLines + NoOfItems + 1);
                int loopTo4 = NoOfItems;
                for (N = 1; N <= loopTo4; N++)
                {
                    moduleLINES.Lines[moduleLINES.NoOfLines + N] = myLines[N - 1];
                    moduleLINES.AddLatLonToLine(moduleLINES.NoOfLines + N);
                }

                moduleLINES.NoOfLines = moduleLINES.NoOfLines + NoOfItems;
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Append " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
        }

        private static string GetLineTypeFromGuid(string guid)
        {
            string GetLineTypeFromGuidRet = default;
            GetLineTypeFromGuidRet = "";
            int K;
            int loopTo = moduleLINES.NoOfLineTypes;
            for (K = 1; K <= loopTo; K++)
            {
                if ((moduleLINES.LineTypes[K].Guid ?? "") == (guid ?? ""))
                {
                    GetLineTypeFromGuidRet = moduleLINES.LineTypes[K].Type;
                    if (GetLineTypeFromGuidRet == "FWX")
                    {
                        GetLineTypeFromGuidRet = GetLineTypeFromGuidRet + DefaultNoOfLanes.ToString() + DefaultTrafficDir;
                    }

                    break;
                }
            }

            return GetLineTypeFromGuidRet;
        }

        private static void AppendSHPPolys(string filename, int NoOfItems, bool IsZ)
        {
            double[] myAltitudes;
            Color[] myColors;
            string[] myNames;
            string[] myGuids;
            string[] myTypes;
            string A;
            int recCount;
            int N, N1, N2, NV, K, J, JK = default, I, M, NP;
            DBFReader.FieldType[] FieldTypes;

            // open the dbase file
            DBFReader DBF = new DBFReader();
            if (!DBF.FileReader(filename))
            {
                MessageBox.Show("SBuilderXX can not read the database Shapefile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            recCount = DBF.RecordCount;
            NoOfFields = DBF.FieldCount;
            if (recCount != NoOfItems)
            {
                MessageBox.Show("The number of records in database is different from the number of shapes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FieldNames = new string[NoOfFields];
            FieldTypes = new DBFReader.FieldType[NoOfFields];
            int TypeField = -1;  // added because of Luis Feliz - type for traffic lines was lost!
            int loopTo = NoOfFields - 1;
            for (N = 0; N <= loopTo; N++)
            {
                FieldTypes[N] = DBF.get_FieldInfo(N).Type;
                FieldNames[N] = DBF.get_FieldInfo(N).Name;
                if (FieldNames[N] == "Type")
                    TypeField = N;
            }

            My.MyProject.Forms.FrmSHPPoly.ShowDialog();
            // *********************

            if (ShapePolyCancel)
            {
                DBF.Close();
                return;
            }

            if (ShapePolyNameField > 0)
            {
                if (FieldTypes[ShapePolyNameField - 1] != DBFReader.FieldType.FTString)
                {
                    A = "Field \"" + FieldNames[ShapePolyNameField - 1] + "\" is not a string and will be ignored!";
                    ShapePolyNameField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapePolyGuidField > 0)
            {
                if (FieldTypes[ShapePolyGuidField - 1] != DBFReader.FieldType.FTString)
                {
                    A = "Field \"" + FieldNames[ShapePolyGuidField - 1] + "\" is not a string and will be ignored!";
                    ShapePolyGuidField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (IsZ)   // after scott
            {
                if (ShapePolyAltitudeField > 1)
                {
                    if (FieldTypes[ShapePolyAltitudeField - 2] != DBFReader.FieldType.FTDouble)
                    {
                        A = "Field \"" + FieldNames[ShapePolyAltitudeField - 2] + "\" is not a double precision number and will be ignored!";
                        ShapePolyAltitudeField = 0;
                        MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (ShapePolyAltitudeField > 0)
            {
                if (FieldTypes[ShapePolyAltitudeField - 1] != DBFReader.FieldType.FTDouble)
                {
                    A = "Field \"" + FieldNames[ShapePolyAltitudeField - 1] + "\" is not a double precision number and will be ignored!";
                    ShapePolyAltitudeField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (ShapePolyColorField > 0)
            {
                if (FieldTypes[ShapePolyColorField - 1] != DBFReader.FieldType.FTInteger)
                {
                    A = "Field \"" + FieldNames[ShapePolyColorField - 1] + "\" is not a integer number and will be ignored!";
                    ShapePolyColorField = 0;
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            myAltitudes = new double[NoOfItems];
            myColors = new Color[NoOfItems];
            myNames = new string[NoOfItems];
            myGuids = new string[NoOfItems];
            myTypes = new string[NoOfItems];
            int loopTo1 = NoOfItems - 1;
            for (N = 0; N <= loopTo1; N++)
            {
                if (ShapePolyNameField == 0)
                {
                    myNames[N] = ShapePolyName;
                }
                else
                {
                    myNames[N] = DBF.Attribute(N, ShapePolyNameField - 1);
                }

                if (ShapePolyGuidField == 0)
                {
                    myGuids[N] = ShapePolyGuid;
                }
                else
                {
                    myGuids[N] = DBF.Attribute(N, ShapePolyGuidField - 1);
                    if (string.IsNullOrEmpty(myGuids[N]))
                    {
                        myGuids[N] = ShapePolyGuid;
                    }
                }

                if (TypeField >= 0)
                {
                    myTypes[N] = DBF.Attribute(N, TypeField);
                    if (string.IsNullOrEmpty(myTypes[N]))
                    {
                        myTypes[N] = GetPolyTypeFromGuid(myGuids[N]);
                    }
                }
                else
                {
                    myTypes[N] = GetPolyTypeFromGuid(myGuids[N]);
                }

                if (ShapePolyColorField == 0)
                {
                    myColors[N] = ShapePolyColor;
                }
                else
                {
                    A = DBF.Attribute(N, ShapePolyColorField - 1);
                    if (!string.IsNullOrEmpty(A))  // '''
                    {
                        myColors[N] = Color.FromArgb(Convert.ToInt32(A));
                    }
                    else
                    {
                        myColors[N] = ShapePolyColor;
                    }
                }

                if (IsZ)     // after scott
                {
                    if (ShapePolyAltitudeField == 0)
                    {
                        myAltitudes[N] = ShapePolyAltitude;
                    }
                    else if (ShapePolyAltitudeField > 1)
                    {
                        A = DBF.Attribute(N, ShapePolyAltitudeField - 2);
                        if (!string.IsNullOrEmpty(A))
                        {
                            myAltitudes[N] = Convert.ToDouble(A);
                        }
                        else
                        {
                            myAltitudes[N] = ShapePolyAltitude;
                        }
                    }
                }
                else if (ShapePolyAltitudeField == 0)
                {
                    myAltitudes[N] = ShapePolyAltitude;
                }
                else if (ShapePolyAltitudeField > 0)
                {
                    A = DBF.Attribute(N, ShapePolyAltitudeField - 1);
                    if (!string.IsNullOrEmpty(A))
                    {
                        myAltitudes[N] = Convert.ToDouble(A);
                    }
                    else
                    {
                        myAltitudes[N] = ShapePolyAltitude;
                    }
                }
            }

            // close the dbase
            DBF.Close();
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                // open shape file
                SHPReader SHP = new SHPReader();
                SHP.FileReader(filename);

                // K is to count number of polygons
                K = modulePOLYS.NoOfPolys;
                Array.Resize(ref modulePOLYS.Polys, K + 100 + 1);   // allow 100 polygons to be added!
                int[] P;  // to store the index of the starting vertice of the part
                int loopTo2 = NoOfItems;
                for (N = 1; N <= loopTo2; N++)     // NoOfItems taken from the DBF file also means parent polys!
                {
                    SHP.MoveTo(N);  // set the current record
                    NV = SHP.NumPoints;
                    NP = SHP.NumParts;
                    P = new int[NP];
                    if (NP > 1)
                    {
                        int loopTo3 = NP;
                        for (J = 1; J <= loopTo3; J++)
                            P[J - 1] = SHP.get_Begins(J);
                    }

                    int loopTo4 = NP;
                    for (J = 1; J <= loopTo4; J++)
                    {
                        K = K + 1;
                        modulePOLYS.Polys[K].Name = myNames[N - 1];
                        modulePOLYS.Polys[K].Color = myColors[N - 1];
                        modulePOLYS.Polys[K].Guid = myGuids[N - 1];
                        modulePOLYS.Polys[K].Type = myTypes[N - 1];
                        if (NP == 1)
                        {
                            modulePOLYS.Polys[K].Childs = new int[1];
                            modulePOLYS.Polys[K].NoOfChilds = 0;
                            N1 = 1;
                            N2 = NV - 1;
                        }
                        else if (J == 1)   // first is a father
                        {
                            modulePOLYS.Polys[K].Childs = new int[NP];
                            modulePOLYS.Polys[K].NoOfChilds = NP - 1;
                            int loopTo5 = NP - 1;
                            for (I = 1; I <= loopTo5; I++)
                                modulePOLYS.Polys[K].Childs[I] = K + I;
                            // N1 = 1
                            // N2 = P(1) - 2
                            // to correct the triangle anomalities 
                            N1 = 1;
                            N2 = P[1] - 1;
                            JK = K;
                        }
                        else if (J == NP)  // the last child
                        {
                            modulePOLYS.Polys[K].Childs = new int[1];
                            modulePOLYS.Polys[K].NoOfChilds = -JK;
                            // N1 = P(J - 1)
                            // N2 = NV - 1
                            // to correct the triangle anomalities 
                            N1 = P[J - 1] + 1;
                            N2 = NV - 1;
                        }
                        else // others childs if more than one
                        {
                            modulePOLYS.Polys[K].Childs = new int[1];
                            modulePOLYS.Polys[K].NoOfChilds = -JK;
                            // N1 = P(J - 1)
                            // N2 = P(J) - 2
                            // to correct the triangle anomalities 
                            N1 = P[J - 1] + 1;
                            N2 = P[J] - 1;
                        }

                        modulePOLYS.Polys[K].GPoints = new modulePOINTS.GPoint[N2 - N1 + 1 + 1];
                        modulePOLYS.Polys[K].NoOfPoints = N2 - N1 + 1;
                        int loopTo6 = N2;
                        for (I = N1; I <= loopTo6; I++)
                        {
                            M = I - N1 + 1;
                            modulePOLYS.Polys[K].GPoints[M].lon = SHP.get_Points(I).X;
                            modulePOLYS.Polys[K].GPoints[M].lat = SHP.get_Points(I).Y;
                            if (IsZ & ShapePolyAltitudeField == 1)
                            {
                                modulePOLYS.Polys[K].GPoints[M].alt = SHP.get_Points(I).Z;
                            }
                            else
                            {
                                modulePOLYS.Polys[K].GPoints[M].alt = myAltitudes[N - 1];
                            }
                        }

                        modulePOLYS.AddLatLonToPoly(K);
                        if (K == modulePOLYS.NoOfPolys + 100)
                        {
                            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 1000 + 1);
                        }

                        if (K == modulePOLYS.NoOfPolys + 1000)
                        {
                            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 10000 + 1);
                        }

                        if (K == modulePOLYS.NoOfPolys + 10000)
                        {
                            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 100000 + 1);
                        }

                        if (K == modulePOLYS.NoOfPolys + 100000)
                        {
                            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 1000000 + 1);
                        }
                    }
                }

                // close the shape file
                SHP.Close();

                // K is total and final number of polys
                Array.Resize(ref modulePOLYS.Polys, K + 1);
                modulePOLYS.NoOfPolys = K;
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Append " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
        }

        private static string GetPolyTypeFromGuid(string guid)
        {
            string GetPolyTypeFromGuidRet = default;
            GetPolyTypeFromGuidRet = "";
            int K;
            int loopTo = modulePOLYS.NoOfPolyTypes;
            for (K = 1; K <= loopTo; K++)
            {
                if ((modulePOLYS.PolyTypes[K].Guid ?? "") == (guid ?? ""))
                {
                    GetPolyTypeFromGuidRet = modulePOLYS.PolyTypes[K].Type;
                    break;
                }
            }

            return GetPolyTypeFromGuidRet;
        }

        internal static void ExportSHPLines(string filename)
        {
            int N;
            DBFWriter DBF = new DBFWriter();
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                if (!DBF.FileWriter(filename, moduleLINES.NoOfLines))
                    return;

                // add the fields
                if (!DBF.CreateField("Name", shp_CHARACTER, 20, 0))
                    return;
                if (!DBF.CreateField("Type", shp_CHARACTER, 50, 0))
                    return;
                if (!DBF.CreateField("Color", shp_NUMERIC, 11, 0))
                    return;
                if (!DBF.CreateField("Guid", shp_CHARACTER, 38, 0))
                    return;

                // append the fields
                if (!DBF.AppendFields())
                    return;

                // populate the fields
                int loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    DBF.AddRecord(N, 1, moduleLINES.Lines[N].Name);
                    DBF.AddRecord(N, 2, moduleLINES.Lines[N].Type);
                    DBF.AddRecord(N, 3, moduleLINES.Lines[N].Color.ToArgb().ToString());
                    DBF.AddRecord(N, 4, moduleLINES.Lines[N].Guid);
                }

                // close the DB file
                DBF.Close();

                // now create the SHP and the SHX files
                CreateShpAndShxFilesFromLines(filename, "ALL");
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Export " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
        }

        internal static void ExportSHPPolys(string filename)
        {
            int N, K;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                // to be used by SHX creation and DBFile creation
                int nRecords = NumberOfRecordsInPolys();
                DBFWriter DBF = new DBFWriter();
                if (!DBF.FileWriter(filename, nRecords))
                    return;

                // add the fields
                if (!DBF.CreateField("Name", shp_CHARACTER, 20, 0))
                    return;
                if (!DBF.CreateField("Type", shp_CHARACTER, 50, 0))
                    return;
                if (!DBF.CreateField("Color", shp_NUMERIC, 11, 0))
                    return;
                if (!DBF.CreateField("Guid", shp_CHARACTER, 38, 0))
                    return;

                // append the fields
                if (!DBF.AppendFields())
                    return;

                // populate the fields
                K = 0;
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                    {
                        K = K + 1;
                        DBF.AddRecord(K, 1, modulePOLYS.Polys[N].Name);
                        DBF.AddRecord(K, 2, modulePOLYS.Polys[N].Type);
                        DBF.AddRecord(K, 3, modulePOLYS.Polys[N].Color.ToArgb().ToString());
                        DBF.AddRecord(K, 4, modulePOLYS.Polys[N].Guid);
                    }
                }

                // close the DB file
                DBF.Close();

                // now create the SHP and the SHX files
                CreateShpAndShxFilesFromPolys(filename, "ALL");
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Export " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
        }

        private static bool CreateShpAndShxFilesFromPolys(string filename, string type)
        {
            bool CreateShpAndShxFilesFromPolysRet = default;

            // type can be ALL (used when exporting shape files) or
            // EXX XXX LCP HPX HGX FLX  (when creating shape files for shp2vec)

            CreateShpAndShxFilesFromPolysRet = false;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                int N, M, J, K, REC, np;
                double Xmin, Xmax;
                double Ymin, Ymax;
                double Zmin, Zmax;
                double X, Y, Z;
                double XXmin, XXmax;
                double YYmin, YYmax;
                double ZZmin, ZZmax;
                int nParts, nPoints;
                int recLen = 0;
                int ptrBegin = 0;
                int ptrMid = 0;
                int ptrEnd = 0;
                int nRecords;
                if (type == "ALL")
                {
                    nRecords = NumberOfRecordsInPolys();
                }
                else
                {
                    nRecords = NumberOfRecordsInSelectedPolys(type);
                }

                int[] RecOffset;
                RecOffset = new int[nRecords + 1];
                int[] RecLenght;
                RecLenght = new int[nRecords + 1];
                int ShapeType = 15;   // polygonZ
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(BigEndian(9994));   // write fixed initial number
                bw.Seek(96, SeekOrigin.Current);
                REC = 0;
                XXmin = 180d;
                XXmax = -180;
                YYmin = 90d;
                YYmax = -90;
                ZZmin = 100000d;
                ZZmax = -100000;
                int[] P;   // point to the 1st index of a part in the sequence of points
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                    {
                        if (type == "ALL" | (type ?? "") == ((modulePOLYS.Polys[N].Type.Length >= 3) ? modulePOLYS.Polys[N].Type.Substring(0, 3) : ""))
                        {
                            // new record 
                            REC = REC + 1;
                            ptrBegin = (int)fs.Position;
                            RecOffset[REC] = (int)(ptrBegin / 2d);
                            nParts = modulePOLYS.Polys[N].NoOfChilds + 1;   // the childs plus the parent
                            P = new int[nParts + 1];
                            P[1] = 0;     // always zero!
                                          // find nPoints for the record and build P()
                            nPoints = modulePOLYS.Polys[N].NoOfPoints + 1;
                            int loopTo1 = nParts;
                            for (M = 2; M <= loopTo1; M++)
                            {
                                P[M] = nPoints;
                                np = modulePOLYS.Polys[modulePOLYS.Polys[N].Childs[M - 1]].NoOfPoints + 1;
                                nPoints = nPoints + np;
                            }
                            // advance 4 + 4 + 4 + 4 x 8 = 44 ( recNum recLen ShapeType and box )
                            // plus 4 + 4 (nParts nPoints) + nParts * 4 (for P() array )
                            // total = 52 + 4 * nParts
                            bw.Seek(52 + 4 * nParts, SeekOrigin.Current);
                            // the XXXXXXXXXXXXXXXX and YYYYYYYYYYYYYYYYYYYY
                            Xmin = 180d;
                            Xmax = -180;
                            Ymin = 90d;
                            Ymax = -90;
                            int loopTo2 = modulePOLYS.Polys[N].NoOfPoints;
                            for (J = 1; J <= loopTo2; J++)
                            {
                                X = modulePOLYS.Polys[N].GPoints[J].lon;
                                if (X > Xmax)
                                    Xmax = X;
                                if (X < Xmin)
                                    Xmin = X;
                                bw.Write(X);
                                Y = modulePOLYS.Polys[N].GPoints[J].lat;
                                if (Y > Ymax)
                                    Ymax = Y;
                                if (Y < Ymin)
                                    Ymin = Y;
                                bw.Write(Y);
                            }

                            X = modulePOLYS.Polys[N].GPoints[1].lon;
                            bw.Write(X);
                            Y = modulePOLYS.Polys[N].GPoints[1].lat;
                            bw.Write(Y);
                            int loopTo3 = nParts;
                            for (M = 2; M <= loopTo3; M++)
                            {
                                K = modulePOLYS.Polys[N].Childs[M - 1];
                                int loopTo4 = modulePOLYS.Polys[K].NoOfPoints;
                                for (J = 1; J <= loopTo4; J++)
                                {
                                    X = modulePOLYS.Polys[K].GPoints[J].lon;
                                    if (X > Xmax)
                                        Xmax = X;
                                    if (X < Xmin)
                                        Xmin = X;
                                    bw.Write(X);
                                    Y = modulePOLYS.Polys[K].GPoints[J].lat;
                                    if (Y > Ymax)
                                        Ymax = Y;
                                    if (Y < Ymin)
                                        Ymin = Y;
                                    bw.Write(Y);
                                }

                                X = modulePOLYS.Polys[K].GPoints[1].lon;
                                bw.Write(X);
                                Y = modulePOLYS.Polys[K].GPoints[1].lat;
                                bw.Write(Y);
                            }
                            // now the ZZZZZZZZZZZZZZZZZ
                            ptrMid = (int)fs.Position;          // need to return here!
                            bw.Seek(16, SeekOrigin.Current);     // leave space for Zmin & Zmax
                            Zmin = 100000d;
                            Zmax = -100000;
                            int loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
                            for (J = 1; J <= loopTo5; J++)
                            {
                                Z = modulePOLYS.Polys[N].GPoints[J].alt;
                                if (Z > Zmax)
                                    Zmax = Z;
                                if (Z < Zmin)
                                    Zmin = Z;
                                bw.Write(Z);
                            }

                            Z = modulePOLYS.Polys[N].GPoints[1].alt;
                            bw.Write(Z);
                            int loopTo6 = nParts;
                            for (M = 2; M <= loopTo6; M++)
                            {
                                K = modulePOLYS.Polys[N].Childs[M - 1];
                                int loopTo7 = modulePOLYS.Polys[K].NoOfPoints;
                                for (J = 1; J <= loopTo7; J++)
                                {
                                    Z = modulePOLYS.Polys[K].GPoints[J].alt;
                                    if (Z > Zmax)
                                        Zmax = Z;
                                    if (Z < Zmin)
                                        Zmin = Z;
                                    bw.Write(Z);
                                }

                                Z = modulePOLYS.Polys[K].GPoints[1].alt;
                                bw.Write(Z);
                            }

                            if (Xmin < XXmin)
                                XXmin = Xmin;
                            if (Ymin < YYmin)
                                YYmin = Ymin;
                            if (Zmin < ZZmin)
                                ZZmin = Zmin;
                            if (Xmax > XXmax)
                                XXmax = Xmax;
                            if (Ymax > YYmax)
                                YYmax = Ymax;
                            if (Zmax > ZZmax)
                                ZZmax = Zmax;
                            bw.Seek((nPoints + 1) * 8, SeekOrigin.Current);     // advance Mmin Mmax and nPoints M points
                            bw.Write(0d);    // go back 8 and write a double = O to terminate
                            ptrEnd = (int)fs.Position;
                            recLen = (int)((ptrEnd - ptrBegin) / 2d);    // get the record lenght
                            recLen = recLen - 4; // contents lenght of record is less by 8 bytes
                            RecLenght[REC] = recLen;
                            // go back and fill the record header
                            bw.Seek(ptrBegin, SeekOrigin.Begin);
                            bw.Write(BigEndian(REC));
                            bw.Write(BigEndian(recLen));
                            bw.Write(ShapeType);
                            bw.Write(Xmin);
                            bw.Write(Ymin);
                            bw.Write(Xmax);
                            bw.Write(Ymax);
                            bw.Write(nParts);
                            bw.Write(nPoints);    // total number of points
                            bw.Write(P[1]);       // the index for the first point of the first part 
                            int loopTo8 = nParts;
                            for (M = 2; M <= loopTo8; M++)
                                bw.Write(P[M]);   // the index for the first point of part M
                                                  // do not forget to fill Zmin & Zmax
                            bw.Seek(ptrMid, SeekOrigin.Begin);
                            bw.Write(Zmin);
                            bw.Write(Zmax);
                            // and reposition the pointer for next record
                            bw.Seek(ptrEnd, SeekOrigin.Begin);
                        }
                    }
                }

                recLen = (int)fs.Length;    // recLen is free
                recLen = (int)(recLen / 2d);
                // now complete  header
                bw.Seek(24, SeekOrigin.Begin);
                bw.Write(BigEndian(recLen));
                bw.Write(1000);       // version
                bw.Write(ShapeType);   // shape type
                bw.Write(XXmin);
                bw.Write(YYmin);
                bw.Write(XXmax);
                bw.Write(YYmax);
                bw.Write(ZZmin);
                bw.Write(ZZmax);
                bw.Write(0d);     // Mmin
                bw.Write(0d);     // Mmax
                bw.Close();
                fs.Close();

                // now create the SHX file!
                string SHXFile = Path.ChangeExtension(filename, ".SHX");
                if (File.Exists(SHXFile))
                    File.Delete(SHXFile);
                fs = new FileStream(SHXFile, FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(BigEndian(9994));   // write fixed initial number
                bw.Seek(20, SeekOrigin.Current);
                bw.Write(BigEndian(50 + nRecords * 4)); // lenght here
                bw.Write(1000);       // version
                bw.Write(ShapeType);   // shape type
                bw.Write(XXmin);
                bw.Write(YYmin);
                bw.Write(XXmax);
                bw.Write(YYmax);
                bw.Write(ZZmin);
                bw.Write(ZZmax);
                bw.Write(0d);     // Mmin
                bw.Write(0d);     // Mmax
                                  // bw.Seek(16, SeekOrigin.Current)  ' skip Mmin and Mmax
                int loopTo9 = nRecords;
                for (N = 1; N <= loopTo9; N++)
                {
                    bw.Write(BigEndian(RecOffset[N]));
                    bw.Write(BigEndian(RecLenght[N]));
                }

                bw.Close();
                fs.Close();
                CreateShpAndShxFilesFromPolysRet = true;
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Export " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
            return CreateShpAndShxFilesFromPolysRet;
        }

        private static bool CreateShpAndShxFilesFromLines(string filename, string type)
        {
            bool CreateShpAndShxFilesFromLinesRet = default;

            // type can be ALL for exporting shape files or 
            // STX FWX RDX HLX RRX UTX for shp2vec

            CreateShpAndShxFilesFromLinesRet = false;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                int N, J, REC;
                double Xmin, Xmax;
                double Ymin, Ymax;
                double Zmin, Zmax;
                double X, Y, Z;
                double XXmin, XXmax;
                double YYmin, YYmax;
                double ZZmin, ZZmax;
                int nPoints;
                int recLen = 0;
                int ptrBegin = 0;
                int ptrMid = 0;
                int ptrEnd = 0;
                int nRecords;
                if (type == "ALL")
                {
                    nRecords = moduleLINES.NoOfLines;
                }
                else
                {
                    nRecords = NumberOfRecordsInSelectedLines(type);
                }

                // these are for the SHX file
                int[] RecOffset;
                RecOffset = new int[nRecords + 1];
                int[] RecLenght;
                RecLenght = new int[nRecords + 1];
                int ShapeType = 13;   // polylineZ
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(BigEndian(9994));   // write fixed initial number
                bw.Seek(96, SeekOrigin.Current);
                XXmin = 180d;
                XXmax = -180;
                YYmin = 90d;
                YYmax = -90;
                ZZmin = 100000d;
                ZZmax = -100000;
                REC = 0;
                int loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    if (type == "ALL" | (type ?? "") == ((moduleLINES.Lines[N].Type.Length >= 3) ? moduleLINES.Lines[N].Type.Substring(0, 3) : ""))
                    {
                        // new record 
                        REC = REC + 1;
                        ptrBegin = (int)fs.Position;
                        RecOffset[REC] = (int)(ptrBegin / 2d);
                        nPoints = moduleLINES.Lines[N].NoOfPoints;
                        // advance 4 + 4 + 4 + 4 x 8 = 44 ( recNum recLen ShapeType and box )
                        // plus 4 + 4 (nParts nPoints) + 4  for P(1) ; P(1)=0 
                        // total = 52 + 4 
                        bw.Seek(56, SeekOrigin.Current);
                        // the XXXXXXXXXXXXXXXX and YYYYYYYYYYYYYYYYYYYY
                        Xmin = 180d;
                        Xmax = -180;
                        Ymin = 90d;
                        Ymax = -90;
                        int loopTo1 = nPoints;
                        for (J = 1; J <= loopTo1; J++)
                        {
                            X = moduleLINES.Lines[N].GLPoints[J].lon;
                            if (X > Xmax)
                                Xmax = X;
                            if (X < Xmin)
                                Xmin = X;
                            bw.Write(X);
                            Y = moduleLINES.Lines[N].GLPoints[J].lat;
                            if (Y > Ymax)
                                Ymax = Y;
                            if (Y < Ymin)
                                Ymin = Y;
                            bw.Write(Y);
                        }
                        // now the ZZZZZZZZZZZZZZZZZ
                        ptrMid = (int)fs.Position;          // need to return here!
                        bw.Seek(16, SeekOrigin.Current);     // leave space for Zmin & Zmax
                        Zmin = 100000d;
                        Zmax = -100000;
                        int loopTo2 = nPoints;
                        for (J = 1; J <= loopTo2; J++)
                        {
                            Z = moduleLINES.Lines[N].GLPoints[J].alt;
                            if (Z > Zmax)
                                Zmax = Z;
                            if (Z < Zmin)
                                Zmin = Z;
                            bw.Write(Z);
                        }

                        if (Xmin < XXmin)
                            XXmin = Xmin;
                        if (Ymin < YYmin)
                            YYmin = Ymin;
                        if (Zmin < ZZmin)
                            ZZmin = Zmin;
                        if (Xmax > XXmax)
                            XXmax = Xmax;
                        if (Ymax > YYmax)
                            YYmax = Ymax;
                        if (Zmax > ZZmax)
                            ZZmax = Zmax;
                        bw.Seek((nPoints + 1) * 8, SeekOrigin.Current);     // advance Mmin Mmax and nPoints M points
                        bw.Write(0d);    // go back 8 and write a double = O to terminate
                        ptrEnd = (int)fs.Position;
                        recLen = (int)((ptrEnd - ptrBegin) / 2d);    // get the record lenght
                        recLen = recLen - 4; // contents lenght of record is less by 8 bytes
                        RecLenght[REC] = recLen;
                        // go back and fill the record header
                        bw.Seek(ptrBegin, SeekOrigin.Begin);
                        bw.Write(BigEndian(REC));
                        bw.Write(BigEndian(recLen));
                        bw.Write(ShapeType);
                        bw.Write(Xmin);
                        bw.Write(Ymin);
                        bw.Write(Xmax);
                        bw.Write(Ymax);
                        bw.Write(1);         // 1 part !
                        bw.Write(nPoints);    // total number of points
                        bw.Write(0);         // the index for the first point of the first part P(1)=0
                                             // do not forget to fill Zmin & Zmax
                        bw.Seek(ptrMid, SeekOrigin.Begin);
                        bw.Write(Zmin);
                        bw.Write(Zmax);
                        // and reposition the pointer for next record
                        bw.Seek(ptrEnd, SeekOrigin.Begin);
                    }
                }

                recLen = (int)fs.Length;    // recLen is free
                recLen = (int)(recLen / 2d);
                // now complete  header
                bw.Seek(24, SeekOrigin.Begin);
                bw.Write(BigEndian(recLen));
                bw.Write(1000);       // version
                bw.Write(ShapeType);   // shape type
                bw.Write(XXmin);
                bw.Write(YYmin);
                bw.Write(XXmax);
                bw.Write(YYmax);
                bw.Write(ZZmin);
                bw.Write(ZZmax);
                bw.Write(0d);
                bw.Write(0d);
                bw.Close();
                fs.Close();

                // now create the SHX file!
                string SHXFile = Path.ChangeExtension(filename, ".SHX");
                if (File.Exists(SHXFile))
                    File.Delete(SHXFile);
                fs = new FileStream(SHXFile, FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(BigEndian(9994));   // write fixed initial number
                bw.Seek(20, SeekOrigin.Current);
                bw.Write(BigEndian(50 + nRecords * 4)); // lenght here
                bw.Write(1000);       // version
                bw.Write(ShapeType);   // shape type
                bw.Write(XXmin);
                bw.Write(YYmin);
                bw.Write(XXmax);
                bw.Write(YYmax);
                bw.Write(ZZmin);
                bw.Write(ZZmax);
                bw.Write(0d);     // Mmin
                bw.Write(0d);     // Mmax
                                  // bw.Seek(16, SeekOrigin.Current)  ' skip Mmin and Mmax
                int loopTo3 = nRecords;
                for (N = 1; N <= loopTo3; N++)
                {
                    bw.Write(BigEndian(RecOffset[N]));
                    bw.Write(BigEndian(RecLenght[N]));
                }

                bw.Close();
                fs.Close();
                CreateShpAndShxFilesFromLinesRet = true;
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderXX can not Export " + filename + " !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
            return CreateShpAndShxFilesFromLinesRet;
        }

        private static int BigEndian(int n)
        {
            int BigEndianRet = default;

            // returns the big endian representation of a Int32 number
            byte BB;
            byte[] B = BitConverter.GetBytes(n);
            BB = B[0];
            B[0] = B[3];
            B[3] = BB;
            BB = B[1];
            B[1] = B[2];
            B[2] = BB;
            BigEndianRet = BitConverter.ToInt32(B, 0);
            return BigEndianRet;
        }

        private static int NumberOfRecordsInSelectedLines(string type)
        {
            int NumberOfRecordsInSelectedLinesRet = default;
            int N;
            NumberOfRecordsInSelectedLinesRet = 0;
            int loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleLINES.Lines[N].Selected)
                {
                    if (((moduleLINES.Lines[N].Type.Length >= 3) ? moduleLINES.Lines[N].Type.Substring(0, 3) : "") == (type ?? ""))
                    {
                        NumberOfRecordsInSelectedLinesRet = NumberOfRecordsInSelectedLinesRet + 1;
                    }
                }
            }

            return NumberOfRecordsInSelectedLinesRet;
        }

        private static int NumberOfRecordsInPolys()
        {
            int NumberOfRecordsInPolysRet = default;
            int N;
            NumberOfRecordsInPolysRet = 0;
            int loopTo = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                {
                    NumberOfRecordsInPolysRet = NumberOfRecordsInPolysRet + 1;
                }
            }

            return NumberOfRecordsInPolysRet;
        }

        private static int NumberOfRecordsInSelectedPolys(string type)
        {
            int NumberOfRecordsInSelectedPolysRet = default;
            int N;
            NumberOfRecordsInSelectedPolysRet = 0;
            int loopTo = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (modulePOLYS.Polys[N].Selected)
                {
                    if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                    {
                        if (((modulePOLYS.Polys[N].Type.Length >= 3) ? modulePOLYS.Polys[N].Type.Substring(0, 3) : "") == (type ?? ""))
                        {
                            NumberOfRecordsInSelectedPolysRet = NumberOfRecordsInSelectedPolysRet + 1;
                        }
                    }
                }
            }

            return NumberOfRecordsInSelectedPolysRet;
        }

        internal static void MakeSHPPolys(string filename, string type)
        {
            int N, K;
            string Uiid, UiidTrail;
            string thisType;

            // slopes
            double SY = 0d;
            double SX = 0d;

            // to be used by SHX creation and DBFile creation
            int nRecords = NumberOfRecordsInSelectedPolys(type);
            DBFWriter DBF = new DBFWriter();
            if (!DBF.FileWriter(filename, nRecords))
                return;

            // add the fields

            // add fields
            if (!DBF.CreateField("Uuid", shp_CHARACTER, 38, 0))
                return;
            if (type != "HGX")
            {
                if (!DBF.CreateField("Guid", shp_CHARACTER, 38, 0))
                    return;
            }

            if (type == "HPX")
            {
                if (!DBF.CreateField("SlopeX", shp_FLOAT, 13, 3))
                    return;
                if (!DBF.CreateField("SlopeY", shp_FLOAT, 13, 3))
                    return;
            }

            // append the fields
            if (!DBF.AppendFields())
                return;

            // UiidTrail = "-0000-0000-0000-000000000000}"
            Guid myGuid;
            myGuid = Guid.NewGuid();
            string GS = myGuid.ToString("B");
            UiidTrail = GS.Substring(GS.Length - 29).ToUpper();

            // populate the fields
            K = 0;
            int loopTo = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (modulePOLYS.Polys[N].Selected)
                {
                    if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                    {
                        thisType = modulePOLYS.Polys[N].Type.Length >= 3 ? modulePOLYS.Polys[N].Type.Substring(0, 3) : "";
                        if ((thisType ?? "") == (type ?? "") | thisType == "XXX" & type == "EXX")
                        {
                            K = K + 1;
                            Uiid = K.ToString("{00000000") + UiidTrail;
                            DBF.AddRecord(K, 1, Uiid);
                            if (type != "HGX")
                            {
                                DBF.AddRecord(K, 2, modulePOLYS.Polys[N].Guid);
                            }

                            if (type == "HPX")
                            {
                                if (moduleMAIN.MakeSlopeXY)
                                {
                                    GetHPXSlopes(N, ref SX, ref SY);
                                }

                                DBF.AddRecord(K, 3, SX.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
                                DBF.AddRecord(K, 4, SY.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
                            }
                        }
                    }
                }
            }

            // close the DB file
            DBF.Close();

            // now create the SHP and the SHX files
            CreateShpAndShxFilesFromPolys(filename, type);   // only some polys will be exported as shp and shx
        }

        private static void GetHPXSlopes(int N, ref double SX, ref double SY)
        {
            bool Flag;
            int K;
            double X;
            Flag = true;
            X = modulePOLYS.Polys[N].GPoints[1].alt;
            int loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 2; K <= loopTo; K++)
            {
                if (X != modulePOLYS.Polys[N].GPoints[K].alt)
                {
                    Flag = false;
                    break;
                }
            }

            if (Flag)
            {
                SX = 0d;
                SY = 0d;
                return;
            }

            int NP, J;
            int N1, N2, N3 = default;
            double X1, X2, DX, DY, D;
            NP = modulePOLYS.Polys[N].NoOfPoints;
            N1 = 1;
            N2 = 1;
            X1 = modulePOLYS.Polys[N].GPoints[1].lon;
            X2 = modulePOLYS.Polys[N].GPoints[1].lon;
            int loopTo1 = NP;
            for (J = 1; J <= loopTo1; J++)
            {
                if (modulePOLYS.Polys[N].GPoints[J].lon < X1)
                {
                    N1 = J;
                    X1 = modulePOLYS.Polys[N].GPoints[J].lon;
                }

                if (modulePOLYS.Polys[N].GPoints[J].lon > X2)
                {
                    N2 = J;
                    X2 = modulePOLYS.Polys[N].GPoints[J].lon;
                }
            }

            X1 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[N2].lon;
            X1 = X1 * X1;
            X2 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[N2].lat;
            X2 = X2 * X2;
            D = Math.Sqrt(X1 + X2);
            int loopTo2 = NP;
            for (K = 1; K <= loopTo2; K++)
            {
                if (K != N1 & K != N2)
                {
                    X1 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[K].lat;
                    X2 = X2 * X2;
                    DX = Math.Sqrt(X1 + X2);
                    X1 = modulePOLYS.Polys[N].GPoints[N2].lon - modulePOLYS.Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = modulePOLYS.Polys[N].GPoints[N2].lat - modulePOLYS.Polys[N].GPoints[K].lat;
                    X2 = X2 * X2;
                    DY = Math.Sqrt(X1 + X2);
                    DX = DX + DY;
                    if (DX > D)
                    {
                        D = DX;
                        N3 = K;
                    }
                }
            }

            double z00, z01, z02;
            double x00, x01, x02;
            double y00, y01, y02;
            double a1, a2;
            x01 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[N2].lon;
            x02 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[N3].lon;
            y01 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[N2].lat;
            y02 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[N3].lat;
            z01 = modulePOLYS.Polys[N].GPoints[N1].alt - modulePOLYS.Polys[N].GPoints[N2].alt;
            z02 = modulePOLYS.Polys[N].GPoints[N1].alt - modulePOLYS.Polys[N].GPoints[N3].alt;
            if (y01 == 0d)
            {
                if (x01 == 0d)
                {
                    SX = 0d;
                }
                else
                {
                    SX = z01 / x01;
                }
            }
            else
            {
                a1 = y02 / y01;
                z00 = z01 * a1 - z02;
                x00 = x01 * a1 - x02;
                SX = z00 / x00;
            }

            if (x01 == 0d)
            {
                if (y01 == 0d)
                {
                    SY = 0d;
                }
                else
                {
                    SY = z01 / y01;
                }
            }
            else
            {
                a2 = x02 / x01;
                z00 = z01 * a2 - z02;
                y00 = y01 * a2 - y02;
                SY = z00 / y00;
            }
        }

        internal static void MakeSHPLines(string filename, string type)
        {
            string Uiid, UiidTrail;
            byte Lanes;    // the SDK says it it is a UInt8
            string DirT;
            int N, K;

            // to be used by SHX creation and DBFile creation
            int nRecords = NumberOfRecordsInSelectedLines(type);
            DBFWriter DBF = new DBFWriter();

            // If Not DBF.FileWriter(filename, NoOfLines) Then Exit Sub
            if (!DBF.FileWriter(filename, nRecords))
                return;

            // add the fields
            if (!DBF.CreateField("Uuid", shp_CHARACTER, 38, 0))
                return;
            if (type != "FWX")        // create Guid except for FWX  November 25 2017
            {
                if (!DBF.CreateField("Guid", shp_CHARACTER, 38, 0))
                    return;
            }

            if (type == "FWX")
            {
                // by Dick on November 24, 2017
                // If Not DBF.CreateField("NumberOfLanes", shp_NUMERIC, 1, 0) Then Exit Sub
                // If Not DBF.CreateField("TrafficDirection", shp_CHARACTER, 1, 0) Then Exit Sub
                if (!DBF.CreateField("NumberOfLa", shp_NUMERIC, 1, 0))
                    return;
                if (!DBF.CreateField("TrafficDir", shp_CHARACTER, 1, 0))
                    return;
            }

            // append the fields
            if (!DBF.AppendFields())
                return;

            // UiidTrail = "-0000-0000-0000-000000000000}"
            Guid myGuid;
            myGuid = Guid.NewGuid();
            string GS = myGuid.ToString("B");
            UiidTrail = GS.Substring(GS.Length - 29).ToUpper();

            // populate the fields
            K = 1;
            int loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleLINES.Lines[N].Selected)
                {
                    if (((moduleLINES.Lines[N].Type.Length >= 3) ? moduleLINES.Lines[N].Type.Substring(0, 3) : "") == (type ?? ""))
                    {
                        Uiid = K.ToString("{00000000") + UiidTrail;
                        DBF.AddRecord(K, 1, Uiid);
                        // DBF.AddRecord(K, 2, Lines(N).Guid)
                        if (type != "FWX")
                        {
                            DBF.AddRecord(K, 2, moduleLINES.Lines[N].Guid);
                        }

                        if (type == "FWX")
                        {
                            // Lanes = CByte(Mid(Lines(N).Type, 4, 1))   ' change from Cint() to CByte() in November 2017
                            // DirT = Mid(Lines(N).Type, 5, 1)
                            // DBF.AddRecord(K, 3, Lanes)
                            // DBF.AddRecord(K, 4, DirT)
                            // after Dick proposal on November 24/25 2017
                            // If Mid(Lines(N).Type, 4, 1) = "" Then Lanes = 2 Else Lanes = CByte(Mid(Lines(N).Type, 4, 1))   ' change from Cint() to CByte() in November 2017
                            // If Mid(Lines(N).Type, 5, 1) = "" Then DirT = "F" Else DirT = Mid(Lines(N).Type, 5, 1)
                            // then changed by Luis
                            if (moduleLINES.Lines[N].Type.Length < 4)
                                Lanes = DefaultNoOfLanes;
                            else
                                Lanes = Convert.ToByte(moduleLINES.Lines[N].Type.Substring(3, 1));   // change from Cint() to CByte() in November 2017
                            if (moduleLINES.Lines[N].Type.Length < 5)
                                DirT = DefaultTrafficDir;
                            else
                                DirT = moduleLINES.Lines[N].Type.Substring(4, 1);
                            DBF.AddRecord(K, 2, Lanes.ToString());
                            DBF.AddRecord(K, 3, DirT);
                        }

                        K = K + 1;
                    }
                }
            }

            // close the DB file
            DBF.Close();

            // now create the SHP and the SHX files
            CreateShpAndShxFilesFromLines(filename, type);   // only selected lines will be exported as shp and shx
        }
    }
}