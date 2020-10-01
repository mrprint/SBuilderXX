using System;
using System.Media;
using System.Windows.Forms;
//using Microsoft.VisualBasic;

namespace SBuilderXX
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
            Search = txtName.Text.ToUpper().Trim();
            if (ckLines.Checked)
            {
                if (FindLines(1) == 0)
                {
                    MessageBox.Show("No Line found !");
                    return;
                }
            }

            if (ckLTypes.Checked)
            {
                if (FindLTypes(1) == 0)
                {
                    MessageBox.Show("No Line found !");
                    return;
                }
            }

            if (ckPolys.Checked)
            {
                if (FindPolys(1) == 0)
                {
                    MessageBox.Show("No Polygon found !");
                    return;
                }
            }

            if (ckPTypes.Checked)
            {
                if (FindPTypes(1) == 0)
                {
                    MessageBox.Show("No Polygon found !");
                    return;
                }
            }

            SystemSounds.Beep.Play();
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
            Search = txtName.Text.ToUpper().Trim();
            if (ckLines.Checked)
            {
                if (FindLines(0) == 0)
                {
                    MessageBox.Show("Line not found !");
                    return;
                }
            }

            if (ckLTypes.Checked)
            {
                if (FindLTypes(0) == 0)
                {
                    MessageBox.Show("Line not found !");
                    return;
                }
            }

            if (ckPolys.Checked)
            {
                if (FindPolys(0) == 0)
                {
                    MessageBox.Show("Polygon not found !");
                    return;
                }
            }

            if (ckPTypes.Checked)
            {
                if (FindPTypes(0) == 0)
                {
                    MessageBox.Show("Polygon not found !");
                    return;
                }
            }

            SystemSounds.Beep.Play();
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
                int loopTo = moduleLINES.NoOfLines;
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
                        Flag = moduleLINES.Lines[N].Name.ToUpper().IndexOf(Search, 0) != -1;
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
                int loopTo1 = LineInd;
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
                        Flag = moduleLINES.Lines[N].Name.ToUpper().IndexOf(Search, 0) != -1;
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
            catch (Exception)
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
                int loopTo = moduleLINES.NoOfLines;
                for (N = LineInd; N <= loopTo; N++)
                {
                    if (moduleLINES.Lines[N].Guid.ToUpper().IndexOf(Search, 0) != -1)
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
                int loopTo1 = LineInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (moduleLINES.Lines[N].Guid.ToUpper().IndexOf(Search, 0) != -1)
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
            catch (Exception)
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
                int loopTo = modulePOLYS.NoOfPolys;
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
                        Flag = modulePOLYS.Polys[N].Name.ToUpper().IndexOf(Search, 0) != -1;
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
                int loopTo1 = PolyInd;
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
                        Flag = modulePOLYS.Polys[N].Name.ToUpper().IndexOf(Search, 0) != -1;
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
            catch (Exception)
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
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = PolyInd; N <= loopTo; N++)
                {
                    if (modulePOLYS.Polys[N].Guid.ToUpper().IndexOf(Search, 0) != -1)
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
                int loopTo1 = PolyInd;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (modulePOLYS.Polys[N].Guid.ToUpper().IndexOf(Search, 0) != -1)
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
            catch (Exception)
            {
            }
            return FindPTypesRet;
        }
    }
}