using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    static class moduleMACROS
    {
        internal struct MacroObject
        {
            public string File; // file name
            public string Name;
        }

        internal struct MacroCategory
        {
            public string Name;
            public int NOB;
            public MacroObject[] MacroObjects;
        }

        internal static MacroCategory[] MacroCategories;
        internal static int NoOfMacroCategories;
        internal static string MacroBitmap;
        internal static float MacroLength;
        internal static float MacroWidth;
        internal static float MacroScale;
        internal static int MacroRange;
        internal static float MacroRotation;
        internal static float MacroElevation;
        internal static int MacroDensity;
        internal static float MacroVisibility;
        internal static float MacroV2Value;
        internal static string MacroP6Name;
        internal static string MacroP7Name;
        internal static string MacroP8Name;
        internal static string MacroP9Name;
        internal static string MacroPAName;
        internal static string MacroPBName;
        internal static string MacroPCName;
        internal static string MacroPDName;
        internal static string MacroP6Value;
        internal static string MacroP7Value;
        internal static string MacroP8Value;
        internal static string MacroP9Value;
        internal static string MacroPAValue;
        internal static string MacroPBValue;
        internal static string MacroPCValue;
        internal static string MacroPDValue;
        internal static string MacroID;
        internal static string MacroString;
        internal static string MacroAPIPath;
        internal static string MacroASDPath;
        internal static bool MacroAPIIsOn;
        internal static bool MacroASDIsOn;

        internal static void ShowAPI(int C, int M)
        {
            string B, A, FileName;
            int J, N;
            FileName = MacroCategories[C].MacroObjects[M].File;
            FileName = MacroAPIPath + @"\" + FileName;
            MacroBitmap = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.bmp";
            MacroLength = 50f;
            MacroWidth = 50f;
            MacroScale = 1f;
            MacroRange = 30;

            try
            {
                FileSystem.FileOpen(2, FileName, OpenMode.Input);
                for (N = 1; N <= 6; N++)
                {
                    A = FileSystem.LineInput(2);
                    A = A.Trim();
                    B = A.Substring(0, 10);
                    if (B == ";DEFAULTSC")
                    {
                        A = A.Substring(14);
                        A = A.Replace(",", ".");
                        MacroScale = Convert.ToSingle(A);
                    }

                    if (B == ";DEFAULTRA")
                    {
                        J = A.IndexOf(" ", 14);
                        if (J == -1)
                        {
                            MacroRange = (int)(Convert.ToSingle(A.Substring(14)) / 1000f);
                        }
                        else
                        {
                            MacroRange = (int)(Convert.ToSingle(A.Substring(14, J - 14)) / 1000f);
                        }
                    }

                    if (B == ";MACRODESC")
                    {
                        A = A.Substring(11);
                        J = A.IndexOf(" by ");
                        if (J == -1)
                            continue;
                        B = A.Substring(J + 4);
                        A = A.Substring(0, J);
                        J = A.LastIndexOf(" ");
                        if (J == -1)
                            continue;
                        MacroWidth = Convert.ToSingle(A.Substring(J + 1));
                        J = B.IndexOf(" ");
                        if (J == -1)
                            continue;
                        MacroLength = Convert.ToSingle(B.Substring(0, J));
                    }
                }

                FileSystem.FileClose();
                N = FileName.Length;
                FileName = FileName.Substring(0, N - 3);
                A = FileName + "bmp";
                moduleMAIN.ImageFileNameTrue = A;   // added in 313
                if (File.Exists(A))
                {
                    MacroBitmap = A;
                    return;
                }
                else
                {
                    A = FileName + "jpg";
                    moduleMAIN.ImageFileNameTrue = A;
                    if (File.Exists(A))
                    {
                        MacroBitmap = A;
                        return;
                    }
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Error on Show API routine!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FileSystem.FileClose();
            }
        }

        internal static void ShowASD(int C, int M)
        {
            string B, A, Name, FileName;
            int J, N;
            FileName = MacroCategories[C].MacroObjects[M].File;
            FileName = MacroASDPath + @"\" + FileName;
            MacroBitmap = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\na.bmp";
            MacroLength = 50f;
            MacroWidth = 50f;
            MacroScale = 1f;
            MacroRange = 30;
            MacroRotation = 0f;
            MacroElevation = 0f;
            MacroDensity = 2;
            MacroVisibility = 0f;
            MacroP6Name = "";
            MacroP7Name = "";
            MacroP8Name = "";
            MacroP9Name = "";
            MacroPAName = "";
            MacroPBName = "";
            MacroPCName = "";
            MacroPDName = "";

            try
            {
                FileSystem.FileOpen(2, FileName, OpenMode.Input);
                A = FileSystem.LineInput(2);
                B = "";
                do
                {
                    A = FileSystem.LineInput(2);
                    N = A.IndexOf(@"\");
                    if (N > -1)
                        B = B + A.Substring(1, N - 1) + ",";
                    if (N == -1)
                    {
                        B = B + A.Substring(1) + ",";
                        break;
                    }
                }
                while (true);
                FileSystem.FileClose();
                B = B.Replace(", ", ",");
                B = B.Replace(" ,", ",");
                B = B.Replace(",,", ",");
                B = B.Replace(",,", ",");
                MacroString = B.Replace("= ", "=");
                Name = GetMacroValue("Name");
                A = GetMacroValue("Type");
                A = GetMacroValue("Latitude");
                A = GetMacroValue("Longitude");
                A = GetMacroValue("Autoscale");
                A = GetMacroValue("autoscale");
                A = GetMacroValue("FixedLength");
                if (!string.IsNullOrEmpty(A))
                    MacroLength = Convert.ToSingle(A);
                A = GetMacroValue("FixedWidth");
                if (!string.IsNullOrEmpty(A))
                    MacroWidth = Convert.ToSingle(A);
                A = GetMacroValue("Length");
                if (!string.IsNullOrEmpty(A))
                    MacroLength = Convert.ToSingle(A);
                A = GetMacroValue("Width");
                if (!string.IsNullOrEmpty(A))
                    MacroWidth = Convert.ToSingle(A);
                A = GetMacroValue("Range");
                if (!string.IsNullOrEmpty(A))
                    MacroRange = Convert.ToInt32(A);
                A = GetMacroValue("Scale");
                if (!string.IsNullOrEmpty(A))
                    MacroScale = Convert.ToSingle(A);
                A = GetMacroValue("Rotation");
                if (!string.IsNullOrEmpty(A))
                    MacroRotation = Convert.ToSingle(A);
                A = GetMacroValue("Elevation");
                if (!string.IsNullOrEmpty(A))
                    MacroElevation = Convert.ToSingle(A);
                A = GetMacroValue("Visibility");
                if (!string.IsNullOrEmpty(A))
                    MacroVisibility = Convert.ToSingle(A);
                A = GetMacroValue("Density");
                if (!string.IsNullOrEmpty(A))
                    MacroDensity = Convert.ToInt32(A);
                A = GetMacroValue("Bitmap");
                if (!string.IsNullOrEmpty(A))
                {
                    A = MacroASDPath + @"\" + A;
                    if (File.Exists(A))
                    {
                        moduleMAIN.ImageFileNameTrue = A;
                        MacroBitmap = A;
                    }
                    else
                    {
                        moduleMAIN.ImageFileNameTrue = MacroASDPath + @"\" + Name + ".jpg";
                    }
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroP6Name = A;
                    MacroP6Value = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroP7Name = A;
                    MacroP7Value = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroP8Name = A;
                    MacroP8Value = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroP9Name = A;
                    MacroP9Value = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroPAName = A;
                    MacroPAValue = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroPBName = A;
                    MacroPBValue = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroPCName = A;
                    MacroPCValue = GetMacroValue(A);
                }
                else
                {
                    return;
                }

                if (MacroString.Length < 2)
                    return;
                A = GetMacroParameter();
                if (!string.IsNullOrEmpty(A))
                {
                    MacroPDName = A;
                    MacroPDValue = GetMacroValue(A);
                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Error on Show ASD routine!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal static void AnalyseASDMacro(int N)
        {
            string A = "";
            int M1, M2;
            MacroP6Name = "";
            MacroP7Name = "";
            MacroP8Name = "";
            MacroP9Name = "";
            MacroPAName = "";
            MacroPBName = "";
            MacroPCName = "";
            MacroPDName = "";

            // If N = 0 Then A = RGNPointType1
            if (N > 0)
                A = moduleOBJECTS.Objects[N].Description;
            M1 = 0;
            M2 = A.IndexOf("|", M1);
            MacroID = A.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = A.IndexOf("|", M1);
            MacroString = A.Substring(M1, M2 - M1);
            moduleOBJECTS.ObjComment = A.Substring(M2 + 1);
            A = GetMacroValue("Range");
            if (!string.IsNullOrEmpty(A))
                MacroRange = Convert.ToInt32(A);
            A = GetMacroValue("Scale");
            if (!string.IsNullOrEmpty(A))
                MacroScale = Convert.ToSingle(A);
            A = GetMacroValue("V1");
            if (!string.IsNullOrEmpty(A))
                MacroVisibility = Convert.ToSingle(A);
            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroP6Name = A;
                MacroP6Value = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroP7Name = A;
                MacroP7Value = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroP8Name = A;
                MacroP8Value = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroP9Name = A;
                MacroP9Value = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroPAName = A;
                MacroPAValue = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroPBName = A;
                MacroPBValue = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroPCName = A;
                MacroPCValue = GetMacroValue(A);
            }
            else
            {
                return;
            }

            if (MacroString.Length < 3)
                return;
            A = GetMacroParameter();
            if (!string.IsNullOrEmpty(A))
            {
                MacroPDName = A;
                MacroPDValue = GetMacroValue(A);
            }
            else
            {
                return;
            }
        }

        internal static void SetMacroObjects()
        {
            string A, File;
            CheckAPIMacro();
            CheckASDMacro();
            if (MacroAPIIsOn == false & MacroASDIsOn == false)
                return;
            NoOfMacroCategories = 0;
            MacroCategories = new MacroCategory[2];

            // dot net - does Dir work?
            if (MacroAPIIsOn)
            {
                File = MacroAPIPath + @"\*.api";
                A = FileSystem.Dir(File);
                do
                {
                    if (string.IsNullOrEmpty(A))
                        break;
                    AddMacroAPIFile(A);
                    A = FileSystem.Dir();
                }
                while (true);
            }

            if (MacroASDIsOn)
            {
                File = MacroASDPath + @"\*.scm";
                A = FileSystem.Dir(File);
                do
                {
                    if (string.IsNullOrEmpty(A))
                        break;
                    AddMacroASDFile(A);
                    A = FileSystem.Dir();
                }
                while (true);
            }
        }

        private static void AddMacroAPIFile(string File)
        {
            string B, A, FileName;
            int M = default, C = default, J, N;
            FileName = MacroAPIPath + @"\" + File;
            FileSystem.FileOpen(2, FileName, OpenMode.Input);

            // line number 1
            A = FileSystem.LineInput(2);
            A = A.Replace("\t", "").Trim();
            B = A.Substring(0, 9);
            if (B == ";CATEGORY")
            {
                B = A.Substring(10).Trim();
            }
            else
            {
                B = "API - General";
            }

            AddCatMacro(ref C, ref M, B); // by ref
            MacroCategories[C].MacroObjects[M].File = File.ToUpper();
            MacroCategories[C].MacroObjects[M].Name = File.ToUpper();
            for (N = 1; N <= 5; N++)
            {
                A = A.Trim();
                B = A.Substring(0, 10);
                if (B == ";MACRODESC")
                {
                    A = A.Substring(11).Trim();
                    J = A.IndexOf(" by ");
                    if (J != -1)
                    {
                        A = A.Substring(0, J);
                        J = A.LastIndexOf(" ");
                        if (J == -1)
                            break;
                        A = A.Substring(0, J);
                    }

                    if (!string.IsNullOrEmpty(A))
                        MacroCategories[C].MacroObjects[M].Name = A;
                }

                A = FileSystem.LineInput(2);
            }

            FileSystem.FileClose();
        }

        private static void AddCatMacro(ref int Cat, ref int Macro, string Name)
        {
            int N;
            bool NewCat;
            if (NoOfMacroCategories == 0)
            {
                Cat = 1;
                Macro = 1;
                NoOfMacroCategories = 1;
                MacroCategories[1].NOB = 1;
                MacroCategories[1].Name = Name;
                MacroCategories[1].MacroObjects = new MacroObject[2];
                return;
            }

            NewCat = true;
            var loopTo = NoOfMacroCategories;
            for (N = 1; N <= loopTo; N++)
            {
                if ((MacroCategories[N].Name ?? "") == (Name ?? ""))
                {
                    NewCat = false;
                    break;
                }
            }

            if (NewCat)
            {
                NoOfMacroCategories = NoOfMacroCategories + 1;
                Array.Resize(ref MacroCategories, NoOfMacroCategories + 1);
                MacroCategories[NoOfMacroCategories].Name = Name;
                MacroCategories[NoOfMacroCategories].NOB = 1;
                MacroCategories[NoOfMacroCategories].MacroObjects = new MacroObject[2];
                Cat = NoOfMacroCategories;
                Macro = 1;
            }
            else
            {
                Cat = N;
                Macro = MacroCategories[N].NOB + 1;
                MacroCategories[N].NOB = Macro;
                Array.Resize(ref MacroCategories[N].MacroObjects, Macro + 1);
            }
        }

        private static void AddMacroASDFile(string File)
        {
            string B, A, FileName;
            int N1, N2;
            int C = default, M = default;

            try
            {
                FileName = MacroASDPath + @"\" + File;
                FileSystem.FileOpen(2, FileName, OpenMode.Input);

                // line number 1
                A = FileSystem.LineInput(2);
                A = A.Trim();
                if (A != ";ASDesign Compatible Macro")
                    throw new Exception();
                A = FileSystem.LineInput(2);
                A = A + ",";
                A = A.Replace(@"\", ",");
                A = A.Replace(",,", ",");
                A = A.Replace(" ,", ",");
                N1 = A.IndexOf("Type=");
                if (N1 == -1)
                    throw new Exception();
                N2 = A.IndexOf(",", N1);
                B = A.Substring(N1 + 5, N2 - N1 - 4);
                if (B == "Misc.")
                {
                    B = "ASD - General";
                }

                B = B.Trim();
                AddCatMacro(ref C, ref M, B); // by ref
                MacroCategories[C].MacroObjects[M].File = File.ToUpper();
                MacroCategories[C].MacroObjects[M].Name = File.ToUpper();
                N1 = A.IndexOf("Name=");
                if (N1 == -1)
                    throw new Exception();
                N2 = A.IndexOf(",", N1);
                MacroCategories[C].MacroObjects[M].Name = A.Substring(N1 + 5, N2 - N1 - 4);
                FileSystem.FileClose();
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
            }
        }

        private static void CheckAPIMacro()
        {
            MacroAPIIsOn = false;
            if (!string.IsNullOrEmpty(FileSystem.Dir(MacroAPIPath + @"\*.api")))
                MacroAPIIsOn = true;
        }

        private static void CheckASDMacro()
        {
            MacroASDIsOn = false;
            if (!string.IsNullOrEmpty(FileSystem.Dir(MacroASDPath + @"\*.scm")))
                MacroASDIsOn = true;
        }

        internal static void AnalyseAPIMacro(int N)
        {
            string A = "";
            int M1, M2;

            // If N = 0 Then A = RGNPointType1
            if (N > 0)
                A = moduleOBJECTS.Objects[N].Description;
            M1 = 0;
            M2 = A.IndexOf("|", M1);
            MacroID = A.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = A.IndexOf("|", M1);
            MacroString = A.Substring(M1, M2 - M1);
            moduleOBJECTS.ObjComment = A.Substring(M2 + 1);
            A = GetMacroValue("Range");
            if (!string.IsNullOrEmpty(A))
                MacroRange = Convert.ToInt32(A);
            A = GetMacroValue("Scale");
            if (!string.IsNullOrEmpty(A))
                MacroScale = Convert.ToSingle(A);
            A = GetMacroValue("P6");
            if (!string.IsNullOrEmpty(A))
                MacroP6Value = A;
            A = GetMacroValue("P7");
            if (!string.IsNullOrEmpty(A))
                MacroP7Value = A;
            A = GetMacroValue("P8");
            if (!string.IsNullOrEmpty(A))
                MacroP8Value = A;
            A = GetMacroValue("P9");
            if (!string.IsNullOrEmpty(A))
                MacroP9Value = A;
            A = GetMacroValue("V1");
            if (!string.IsNullOrEmpty(A))
                MacroVisibility = Convert.ToSingle(A);
            A = GetMacroValue("V2");
            if (!string.IsNullOrEmpty(A))
                MacroV2Value = Convert.ToSingle(A);
        }

        internal static string GetMacroValue(string str1)
        {
            string GetMacroValueRet = default;
            string A;
            int J, N, J1, K;
            GetMacroValueRet = "";
            N = str1.Length;
            J1 = MacroString.IndexOf(str1);
            if (J1 == -1)
                return GetMacroValueRet;
            GetMacroValueRet = "0";
            K = MacroString.IndexOf(",", J1);
            J = J1 + N + 1;
            if (K <= J)
            {
                A = MacroString.Substring(J1, K - J1 + 1);
                MacroString = MacroString.Replace(A, "");
                return GetMacroValueRet;
            }

            GetMacroValueRet = MacroString.Substring(J, K - J);
            A = MacroString.Substring(J1, K - J1 + 1);
            MacroString = MacroString.Replace(A, "");
            return GetMacroValueRet;
        }

        internal static string GetMacroParameter()
        {
            string GetMacroParameterRet = default;
            int J, N;
            GetMacroParameterRet = "";
            N = MacroString.IndexOf("=");
            J = MacroString.IndexOf(",");
            if (N < J && N != -1)
                J = N;
            if (J == -1)
                return GetMacroParameterRet;
            GetMacroParameterRet = MacroString.Substring(0, J);
            return GetMacroParameterRet;
        }
    }
}