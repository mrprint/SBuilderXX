using System;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmFind
    {
        public FrmFind()
        {
            InitializeComponent();
            _cmdAll.Name = "cmdAll";
            _cmdCancel.Name = "cmdCancel";
            _cmdNext.Name = "cmdNext";
        }

        private int LineInd;
        private int PolyInd;
        private double LatFind;
        private double LonFind;
        public string Search;

        private void CmdAll_Click(object eventSender, EventArgs eventArgs)
        {
            Search = Strings.Trim(Strings.UCase(txtName.Text));
            if (ckLines.Checked)
            {
                if (FindLines(1) == 0)
                {
                    Interaction.MsgBox("No Line found !");
                    return;
                }
            }

            if (ckLTypes.Checked)
            {
                if (FindLTypes(1) == 0)
                {
                    Interaction.MsgBox("No Line found !");
                    return;
                }
            }

            if (ckPolys.Checked)
            {
                if (FindPolys(1) == 0)
                {
                    Interaction.MsgBox("No Polygon found !");
                    return;
                }
            }

            if (ckPTypes.Checked)
            {
                if (FindPTypes(1) == 0)
                {
                    Interaction.MsgBox("No Polygon found !");
                    return;
                }
            }

            Interaction.Beep();
            moduleMAIN.LonDispCenter = LonFind;
            moduleMAIN.LatDispCenter = LatFind;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdNext_Click(object eventSender, EventArgs eventArgs)
        {
            Search = Strings.Trim(Strings.UCase(txtName.Text));
            if (ckLines.Checked)
            {
                if (FindLines(0) == 0)
                {
                    Interaction.MsgBox("Line not found !");
                    return;
                }
            }

            if (ckLTypes.Checked)
            {
                if (FindLTypes(0) == 0)
                {
                    Interaction.MsgBox("Line not found !");
                    return;
                }
            }

            if (ckPolys.Checked)
            {
                if (FindPolys(0) == 0)
                {
                    Interaction.MsgBox("Polygon not found !");
                    return;
                }
            }

            if (ckPTypes.Checked)
            {
                if (FindPTypes(0) == 0)
                {
                    Interaction.MsgBox("Polygon not found !");
                    return;
                }
            }

            Interaction.Beep();
            moduleMAIN.LonDispCenter = LonFind;
            moduleMAIN.LatDispCenter = LatFind;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        private void FrmFind_Load(object eventSender, EventArgs eventArgs)
        {
            txtName.Text = Search;
            LineInd = 0;
            PolyInd = 0;
        }

        private int FindLines(int All)
        {
            int FindLinesRet = default;
            int N;
            bool Flag;

            try
            {
                FindLinesRet = 0;
                if (All == 1)
                    LineInd = 0;
                LineInd = LineInd + 1;
                if (LineInd == moduleLINES.NoOfLines)
                    LineInd = 1;
                var loopTo = moduleLINES.NoOfLines;
                for (N = LineInd; N <= loopTo; N++)
                {
                    if (string.IsNullOrEmpty(Search))
                    {
                        Flag = false;
                        if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                            Flag = true;
                    }
                    else
                    {
                        Flag = Strings.InStr(1, Strings.UCase(moduleLINES.Lines[N].Name), Search) > 0;
                    }

                    if (Flag)
                    {
                        FindLinesRet = N;
                        LineInd = N;
                        LatFind = (moduleLINES.Lines[N].NLAT + moduleLINES.Lines[N].SLAT) / 2d;
                        LonFind = (moduleLINES.Lines[N].ELON + moduleLINES.Lines[N].WLON) / 2d;
                        moduleLINES.Lines[N].Selected = true;
                        moduleLINES.NoOfLinesSelected = moduleLINES.NoOfLinesSelected + 1;
                        if (All == 0)
                            return FindLinesRet;
                    }
                }

                if (All == 1)
                    return FindLinesRet;
                var loopTo1 = LineInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (string.IsNullOrEmpty(Search))
                    {
                        Flag = false;
                        if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                            Flag = true;
                    }
                    else
                    {
                        Flag = Strings.InStr(1, Strings.UCase(moduleLINES.Lines[N].Name), Search) > 0;
                    }

                    if (Flag)
                    {
                        FindLinesRet = N;
                        LineInd = N;
                        LatFind = (moduleLINES.Lines[N].NLAT + moduleLINES.Lines[N].SLAT) / 2d;
                        LonFind = (moduleLINES.Lines[N].ELON + moduleLINES.Lines[N].WLON) / 2d;
                        moduleLINES.Lines[N].Selected = true;
                        moduleLINES.NoOfLinesSelected = moduleLINES.NoOfLinesSelected + 1;
                        return FindLinesRet;
                    }
                }
            }
            catch(Exception exc)
            {
            }
            return FindLinesRet;
        }

        private int FindLTypes(int All)
        {
            int FindLTypesRet = default;
            int N;

            try
            {
                FindLTypesRet = 0;
                if (All == 1)
                    LineInd = 0;
                LineInd = LineInd + 1;
                if (LineInd == moduleLINES.NoOfLines)
                    LineInd = 1;
                var loopTo = moduleLINES.NoOfLines;
                for (N = LineInd; N <= loopTo; N++)
                {
                    if (Strings.InStr(1, Strings.UCase(moduleLINES.Lines[N].Guid), Search) > 0)
                    {
                        FindLTypesRet = N;
                        LineInd = N;
                        LatFind = (moduleLINES.Lines[N].NLAT + moduleLINES.Lines[N].SLAT) / 2d;
                        LonFind = (moduleLINES.Lines[N].ELON + moduleLINES.Lines[N].WLON) / 2d;
                        moduleLINES.Lines[N].Selected = true;
                        moduleLINES.NoOfLinesSelected = moduleLINES.NoOfLinesSelected + 1;
                        if (All == 0)
                            return FindLTypesRet;
                    }
                }

                if (All == 1)
                    return FindLTypesRet;
                var loopTo1 = LineInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (Strings.InStr(1, Strings.UCase(moduleLINES.Lines[N].Guid), Search) > 0)
                    {
                        FindLTypesRet = N;
                        LineInd = N;
                        LatFind = (moduleLINES.Lines[N].NLAT + moduleLINES.Lines[N].SLAT) / 2d;
                        LonFind = (moduleLINES.Lines[N].ELON + moduleLINES.Lines[N].WLON) / 2d;
                        moduleLINES.Lines[N].Selected = true;
                        moduleLINES.NoOfLinesSelected = moduleLINES.NoOfLinesSelected + 1;
                        return FindLTypesRet;
                    }
                }
            }
            catch (Exception exc)
            {
            }
            return FindLTypesRet;
        }

        private int FindPolys(int All)
        {
            int FindPolysRet = default;
            int N;
            bool Flag;

            try
            {
                FindPolysRet = 0;
                if (All == 1)
                    PolyInd = 0;
                PolyInd = PolyInd + 1;
                if (PolyInd == modulePOLYS.NoOfPolys)
                    PolyInd = 1;
                var loopTo = modulePOLYS.NoOfPolys;
                for (N = PolyInd; N <= loopTo; N++)
                {
                    if (string.IsNullOrEmpty(Search))
                    {
                        Flag = false;
                        if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                            Flag = true;
                    }
                    else
                    {
                        Flag = Strings.InStr(1, Strings.UCase(modulePOLYS.Polys[N].Name), Search) > 0;
                    }

                    if (Flag)
                    {
                        FindPolysRet = N;
                        PolyInd = N;
                        LatFind = (modulePOLYS.Polys[N].NLAT + modulePOLYS.Polys[N].SLAT) / 2d;
                        LonFind = (modulePOLYS.Polys[N].ELON + modulePOLYS.Polys[N].WLON) / 2d;
                        modulePOLYS.Polys[N].Selected = true;
                        modulePOLYS.NoOfPolysSelected = modulePOLYS.NoOfPolysSelected + 1;
                        if (All == 0)
                            return FindPolysRet;
                    }
                }

                if (All == 1)
                    return FindPolysRet;
                var loopTo1 = PolyInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (string.IsNullOrEmpty(Search))
                    {
                        Flag = false;
                        if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                            Flag = true;
                    }
                    else
                    {
                        Flag = Strings.InStr(1, Strings.UCase(modulePOLYS.Polys[N].Name), Search) > 0;
                    }

                    if (Flag)
                    {
                        FindPolysRet = N;
                        PolyInd = N;
                        LatFind = (modulePOLYS.Polys[N].NLAT + modulePOLYS.Polys[N].SLAT) / 2d;
                        LonFind = (modulePOLYS.Polys[N].ELON + modulePOLYS.Polys[N].WLON) / 2d;
                        modulePOLYS.Polys[N].Selected = true;
                        modulePOLYS.NoOfPolysSelected = modulePOLYS.NoOfPolysSelected + 1;
                        return FindPolysRet;
                    }
                }
            }
            catch (Exception exc)
            {
            }
            return FindPolysRet;
        }

        private int FindPTypes(int All)
        {
            int FindPTypesRet = default;
            int N;

            try
            {
                FindPTypesRet = 0;
                if (All == 1)
                    PolyInd = 0;
                PolyInd = PolyInd + 1;
                if (PolyInd == modulePOLYS.NoOfPolys)
                    PolyInd = 1;
                var loopTo = modulePOLYS.NoOfPolys;
                for (N = PolyInd; N <= loopTo; N++)
                {
                    if (Strings.InStr(1, Strings.UCase(modulePOLYS.Polys[N].Guid), Search) > 0)
                    {
                        FindPTypesRet = N;
                        PolyInd = N;
                        LatFind = (modulePOLYS.Polys[N].NLAT + modulePOLYS.Polys[N].SLAT) / 2d;
                        LonFind = (modulePOLYS.Polys[N].ELON + modulePOLYS.Polys[N].WLON) / 2d;
                        modulePOLYS.Polys[N].Selected = true;
                        modulePOLYS.NoOfPolysSelected = modulePOLYS.NoOfPolysSelected + 1;
                        if (All == 0)
                            return FindPTypesRet;
                    }
                }

                if (All == 1)
                    return FindPTypesRet;
                var loopTo1 = PolyInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (Strings.InStr(1, Strings.UCase(modulePOLYS.Polys[N].Guid), Search) > 0)
                    {
                        FindPTypesRet = N;
                        PolyInd = N;
                        LatFind = (modulePOLYS.Polys[N].NLAT + modulePOLYS.Polys[N].SLAT) / 2d;
                        LonFind = (modulePOLYS.Polys[N].ELON + modulePOLYS.Polys[N].WLON) / 2d;
                        modulePOLYS.Polys[N].Selected = true;
                        modulePOLYS.NoOfPolysSelected = modulePOLYS.NoOfPolysSelected + 1;
                        return FindPTypesRet;
                    }
                }
            }
            catch (Exception exc)
            {
            }
            return FindPTypesRet;
        }
    }
}