using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

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
                    A = Strings.Trim(A);
                    B = Strings.Mid(A, 1, 10);
                    if (B == ";DEFAULTSC")
                    {
                        A = Strings.Mid(A, 15);
                        A = Strings.Replace(A, ",", ".");
                        MacroScale = Conversions.ToSingle(A);
                    }

                    if (B == ";DEFAULTRA")
                    {
                        J = Strings.InStr(15, A, " ");
                        if (J == 0)
                        {
                            MacroRange = (int)Conversion.Int(Conversions.ToSingle(Strings.Mid(A, 15)) / 1000f);
                        }
                        else
                        {
                            MacroRange = (int)Conversion.Int(Conversions.ToSingle(Strings.Mid(A, 15, J - 15)) / 1000f);
                        }
                    }

                    if (B == ";MACRODESC")
                    {
                        A = Strings.Mid(A, 12);
                        J = Strings.InStr(1, A, " by ");
                        if (J == 0)
                            goto next_N;
                        B = Strings.Mid(A, J + 4);
                        A = Strings.Mid(A, 1, J - 1);
                        J = Strings.InStrRev(A, " ");
                        if (J == 0)
                            goto next_N;
                        MacroWidth = Conversions.ToSingle(Strings.Mid(A, J + 1));
                        J = Strings.InStr(B, " ");
                        if (J == 0)
                            goto next_N;
                        MacroLength = Conversions.ToSingle(Strings.Mid(B, 1, J - 1));
                    }

                next_N:
                    ;
                }

                FileSystem.FileClose();
                N = Strings.Len(FileName);
                FileName = Strings.Mid(FileName, 1, N - 3);
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
            catch (Exception exc)
            {
                Interaction.MsgBox("Error on Show API routine!", MsgBoxStyle.Exclamation);
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
                    N = Strings.InStr(1, A, @"\");
                    if (N > 0)
                        B = B + Strings.Mid(A, 2, N - 2) + ",";
                    if (N == 0)
                    {
                        B = B + Strings.Mid(A, 2) + ",";
                        break;
                    }
                }
                while (true);
                FileSystem.FileClose();
                B = Strings.Replace(B, ", ", ",");
                B = Strings.Replace(B, " ,", ",");
                B = Strings.Replace(B, ",,", ",");
                B = Strings.Replace(B, ",,", ",");
                MacroString = Strings.Replace(B, "= ", "=");
                Name = GetMacroValue("Name");
                A = GetMacroValue("Type");
                A = GetMacroValue("Latitude");
                A = GetMacroValue("Longitude");
                A = GetMacroValue("Autoscale");
                A = GetMacroValue("autoscale");
                A = GetMacroValue("FixedLength");
                if (!string.IsNullOrEmpty(A))
                    MacroLength = Conversions.ToSingle(A);
                A = GetMacroValue("FixedWidth");
                if (!string.IsNullOrEmpty(A))
                    MacroWidth = Conversions.ToSingle(A);
                A = GetMacroValue("Length");
                if (!string.IsNullOrEmpty(A))
                    MacroLength = Conversions.ToSingle(A);
                A = GetMacroValue("Width");
                if (!string.IsNullOrEmpty(A))
                    MacroWidth = Conversions.ToSingle(A);
                A = GetMacroValue("Range");
                if (!string.IsNullOrEmpty(A))
                    MacroRange = Conversions.ToInteger(A);
                A = GetMacroValue("Scale");
                if (!string.IsNullOrEmpty(A))
                    MacroScale = Conversions.ToSingle(A);
                A = GetMacroValue("Rotation");
                if (!string.IsNullOrEmpty(A))
                    MacroRotation = Conversions.ToSingle(A);
                A = GetMacroValue("Elevation");
                if (!string.IsNullOrEmpty(A))
                    MacroElevation = Conversions.ToSingle(A);
                A = GetMacroValue("Visibility");
                if (!string.IsNullOrEmpty(A))
                    MacroVisibility = Conversions.ToSingle(A);
                A = GetMacroValue("Density");
                if (!string.IsNullOrEmpty(A))
                    MacroDensity = Conversions.ToInteger(A);
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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

                if (Strings.Len(MacroString) < 2)
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
            catch (Exception exc)
            {
                FileSystem.FileClose();
                Interaction.MsgBox("Error on Show ASD routine!", MsgBoxStyle.Exclamation);
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
            M1 = 1;
            M2 = Strings.InStr(M1, A, "|");
            MacroID = Strings.Mid(A, M1, M2 - M1);
            M1 = M2 + 1;
            M2 = Strings.InStr(M1, A, "|");
            MacroString = Strings.Mid(A, M1, M2 - M1);
            moduleOBJECTS.ObjComment = Strings.Mid(A, M2 + 1);
            A = GetMacroValue("Range");
            if (!string.IsNullOrEmpty(A))
                MacroRange = Conversions.ToInteger(A);
            A = GetMacroValue("Scale");
            if (!string.IsNullOrEmpty(A))
                MacroScale = Conversions.ToSingle(A);
            A = GetMacroValue("V1");
            if (!string.IsNullOrEmpty(A))
                MacroVisibility = Conversions.ToSingle(A);
            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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

            if (Strings.Len(MacroString) < 3)
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
            A = Strings.Replace(A, Conversions.ToString('\t'), "");
            A = Strings.Trim(A);
            B = Strings.Mid(A, 1, 9);
            if (B == ";CATEGORY")
            {
                B = Strings.Trim(Strings.Mid(A, 11));
            }
            else
            {
                B = "API - General";
            }

            AddCatMacro(ref C, ref M, B); // by ref
            MacroCategories[C].MacroObjects[M].File = Strings.UCase(File);
            MacroCategories[C].MacroObjects[M].Name = Strings.UCase(File);
            for (N = 1; N <= 5; N++)
            {
                A = Strings.Trim(A);
                B = Strings.Mid(A, 1, 10);
                if (B == ";MACRODESC")
                {
                    A = Strings.Trim(Strings.Mid(A, 12));
                    J = Strings.InStr(1, A, " by ");
                    if (J > 0)
                    {
                        A = Strings.Mid(A, 1, J - 1);
                        J = Strings.InStrRev(A, " ");
                        if (J == 0)
                            break;
                        A = Strings.Mid(A, 1, J - 1);
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
                A = Strings.Trim(A);
                if (A != ";ASDesign Compatible Macro")
                    throw new Exception();
                A = FileSystem.LineInput(2);
                A = A + ",";
                A = Strings.Replace(A, @"\", ",");
                A = Strings.Replace(A, ",,", ",");
                A = Strings.Replace(A, " ,", ",");
                N1 = Strings.InStr(1, A, "Type=");
                if (N1 == 0)
                    throw new Exception();
                N2 = Strings.InStr(N1, A, ",");
                B = Strings.Mid(A, N1 + 5, N2 - N1 - 5);
                if (B == "Misc.")
                {
                    B = "ASD - General";
                }

                B = Strings.Trim(B);
                AddCatMacro(ref C, ref M, B); // by ref
                MacroCategories[C].MacroObjects[M].File = Strings.UCase(File);
                MacroCategories[C].MacroObjects[M].Name = Strings.UCase(File);
                N1 = Strings.InStr(1, A, "Name=");
                if (N1 == 0)
                    throw new Exception();
                N2 = Strings.InStr(N1, A, ",");
                MacroCategories[C].MacroObjects[M].Name = Strings.Mid(A, N1 + 5, N2 - N1 - 5);
                FileSystem.FileClose();
                return;
            }
            catch (Exception exc)
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
            M1 = 1;
            M2 = Strings.InStr(M1, A, "|");
            MacroID = Strings.Mid(A, M1, M2 - M1);
            M1 = M2 + 1;
            M2 = Strings.InStr(M1, A, "|");
            MacroString = Strings.Mid(A, M1, M2 - M1);
            moduleOBJECTS.ObjComment = Strings.Mid(A, M2 + 1);
            A = GetMacroValue("Range");
            if (!string.IsNullOrEmpty(A))
                MacroRange = Conversions.ToInteger(A);
            A = GetMacroValue("Scale");
            if (!string.IsNullOrEmpty(A))
                MacroScale = Conversions.ToSingle(A);
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
                MacroVisibility = Conversions.ToSingle(A);
            A = GetMacroValue("V2");
            if (!string.IsNullOrEmpty(A))
                MacroV2Value = Conversions.ToSingle(A);
        }

        internal static string GetMacroValue(string str1)
        {
            string GetMacroValueRet = default;
            string A;
            int J, N, J1, K;
            GetMacroValueRet = "";
            N = Strings.Len(str1);
            J1 = Strings.InStr(1, MacroString, str1);
            if (J1 == 0)
                return GetMacroValueRet;
            GetMacroValueRet = "0";
            K = Strings.InStr(J1, MacroString, ",");
            J = J1 + N + 1;
            if (K <= J)
            {
                A = Strings.Mid(MacroString, J1, K - J1 + 1);
                MacroString = Strings.Replace(MacroString, A, "");
                return GetMacroValueRet;
            }

            GetMacroValueRet = Strings.Mid(MacroString, J, K - J);
            A = Strings.Mid(MacroString, J1, K - J1 + 1);
            MacroString = Strings.Replace(MacroString, A, "");
            return GetMacroValueRet;
        }

        internal static string GetMacroParameter()
        {
            string GetMacroParameterRet = default;
            int J, N;
            GetMacroParameterRet = "";
            N = Strings.InStr(1, MacroString, "=");
            J = Strings.InStr(1, MacroString, ",");
            if (N < J & N > 0)
                J = N;
            if (J == 0)
                return GetMacroParameterRet;
            GetMacroParameterRet = Strings.Mid(MacroString, 1, J - 1);
            return GetMacroParameterRet;
        }
    }
}