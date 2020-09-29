using System;
using System.IO;

namespace SBuilderX
{
    public class SHPReader
    {

        // Private pointer As Integer      ' to pointer to shape file

        private int pointerXY;
        private int pointerZ;
        private int _shpLen;      // total number of bytes of the shape file
        private byte[] buffer;        // array of bytes to hold the contents of the SHP file
        private byte[] shxbuffer;     // array of bytes to hold the contents of the SHX file
        private int[] RecInd;     // RecInd(n) holds the pointer to the nth Record in the SHP file
        private int[] _Begins;    // _Begins(n) = pointer to the first point of nth part
        private Double_XYZ[] _Points;

        public struct Double_XYZ
        {
            public double X;
            public double Y;
            public double Z;
        }

        public Double_XYZ get_Points(int N)
        {
            return _Points[N];
        }

        private int _NumPoints;

        public int NumPoints => _NumPoints;

        private int _NumParts;

        public int NumParts => _NumParts;

        public int get_Begins(int N)
        {
            return _Begins[N];
        }

        private int _shpType;

        public int shpType => _shpType;

        private double _xMin;

        public double xMin => _xMin;

        private double _xMax;

        public double xMax => _xMax;

        private double _yMin;

        public double yMin => _yMin;

        private double _yMax;

        public double yMax => _yMax;

        private int _recordCount;

        public double recordCount => _recordCount;

        public bool FileReader(string filename)
        {
            bool FileReaderRet = default;
            FileReaderRet = false;

            try
            {
                int N, M;
                buffer = My.MyProject.Computer.FileSystem.ReadAllBytes(filename);
                N = BigEndian(BitConverter.ToInt32(buffer, 0));
                if (N != 9994)
                    return FileReaderRet;
                _shpLen = BigEndian(BitConverter.ToInt32(buffer, 24));
                _shpType = BitConverter.ToInt32(buffer, 32);
                _xMin = BitConverter.ToDouble(buffer, 36);
                _yMin = BitConverter.ToDouble(buffer, 44);
                _xMax = BitConverter.ToDouble(buffer, 52);
                _yMax = BitConverter.ToDouble(buffer, 60);

                // now go to the SHX file 
                string shxfile = Path.ChangeExtension(filename, ".shx");
                shxbuffer = My.MyProject.Computer.FileSystem.ReadAllBytes(shxfile);
                N = shxbuffer.Length - 100;    // total number of bytes - the 100 from the header
                _recordCount = (int)(N / 8d);
                RecInd = new int[_recordCount + 1];
                int loopTo = _recordCount;
                for (N = 1; N <= loopTo; N++)
                {
                    M = 100 + (N - 1) * 8;
                    M = BitConverter.ToInt32(shxbuffer, M);
                    RecInd[N] = 2 * BigEndian(M);
                }

                FileReaderRet = true;
            }
            catch (Exception)
            {
            }
            return FileReaderRet;
        }

        public bool GetInfo(string filename)
        {
            bool GetInfoRet = default;
            GetInfoRet = false;

            try
            {
                int N, M;

                // read first 100 bytes of SHP file
                byte[] header = new byte[101];
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                fs.Read(header, 0, 100);
                fs.Close();
                N = BigEndian(BitConverter.ToInt32(header, 0));
                if (N != 9994)
                    return GetInfoRet;
                _shpLen = BigEndian(BitConverter.ToInt32(header, 24));
                _shpType = BitConverter.ToInt32(header, 32);
                _xMin = BitConverter.ToDouble(header, 36);
                _yMin = BitConverter.ToDouble(header, 44);
                _xMax = BitConverter.ToDouble(header, 52);
                _yMax = BitConverter.ToDouble(header, 60);

                // now go to the SHX file 
                string shxfile = Path.ChangeExtension(filename, ".shx");
                shxbuffer = My.MyProject.Computer.FileSystem.ReadAllBytes(shxfile);
                N = shxbuffer.Length - 100;    // total number of bytes - the 100 from the header
                _recordCount = (int)(N / 8d);
                RecInd = new int[_recordCount + 1];
                int loopTo = _recordCount;
                for (N = 1; N <= loopTo; N++)
                {
                    M = 100 + (N - 1) * 8;
                    M = BitConverter.ToInt32(shxbuffer, M);
                    RecInd[N] = 2 * BigEndian(M);
                }

                GetInfoRet = true;
            }
            catch (Exception)
            {
            }
            return GetInfoRet;
        }

        public void MoveTo(int N)
        {
            int pointer;
            int P;
            pointer = RecInd[N] + 44;       // 36 plus 8 from the record header
            _NumParts = BitConverter.ToInt32(buffer, pointer);
            pointer = pointer + 4;
            _NumPoints = BitConverter.ToInt32(buffer, pointer);
            _Begins = new int[_NumParts + 1];
            _Points = new Double_XYZ[_NumPoints + 1];
            int loopTo = _NumParts;
            for (P = 1; P <= loopTo; P++)
            {
                pointer = pointer + 4;
                _Begins[P] = BitConverter.ToInt32(buffer, pointer);
            }

            // leaves the pointer for the first point
            pointerXY = pointer + 4;
            pointerZ = pointerXY + (_NumPoints + 1) * 16;
            if (_shpType == 3 | shpType == 5)
            {
                int loopTo1 = _NumPoints;
                for (P = 1; P <= loopTo1; P++)
                {
                    _Points[P].X = BitConverter.ToDouble(buffer, pointerXY);
                    _Points[P].Y = BitConverter.ToDouble(buffer, pointerXY + 8);
                    pointerXY = pointerXY + 16;
                }
            }
            else
            {
                int loopTo2 = _NumPoints;
                for (P = 1; P <= loopTo2; P++)
                {
                    _Points[P].X = BitConverter.ToDouble(buffer, pointerXY);
                    _Points[P].Y = BitConverter.ToDouble(buffer, pointerXY + 8);
                    _Points[P].Z = BitConverter.ToDouble(buffer, pointerZ);
                    pointerXY = pointerXY + 16;
                    pointerZ = pointerZ + 8;
                }
            }
        }

        private int BigEndian(int n)
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

        public void Close()
        {

            // does nothing
            buffer = new byte[1];
        }
    }
}