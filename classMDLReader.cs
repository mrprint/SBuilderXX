using System;
using System.IO;

namespace SBuilderX
{
    public class MDLReader
    {
        private int TypeValue;

        public int Type => TypeValue;

        private string GuidValue;

        public string Guid => GuidValue;

        private string NameValue;

        public string Name => NameValue;

        private MDLBBox BBoxValue;

        public MDLBBox BBox => BBoxValue;

        public struct MDLBBox
        {
            public float Xmin;
            public float Xmax;
            public float Ymin;
            public float Ymax;
            public float Zmin;
            public float Zmax;
        }

        public float Width => (float)Math.Round(BBoxValue.Xmax - BBoxValue.Xmin, 2);

        public float Lenght
        {
            get
            {
                double X = BBoxValue.Zmax - BBoxValue.Zmin;
                return (float)Math.Round(X, 2);
            }
        }

        public bool Read(BinaryReader reader)
        {
            bool ReadRet = default;
            ReadRet = false;
            bool GuidOK = false;
            bool NameOK = false;
            bool BoxOK = false;
            int N;
            string R;
            byte[] B;
            B = new byte[17];
            NameValue = "";
            try
            {
                if (new string(reader.ReadChars(4)) != "RIFF")
                    return ReadRet;
                reader.ReadBytes(4);
                R = new string(reader.ReadChars(4));
                if (R == "MDLX")
                {
                    TypeValue = 2;
                }
                else if (R == "MDL9")
                {
                    TypeValue = 1;
                }
                else
                {
                    return ReadRet;
                }

                R = new string(reader.ReadChars(4));
                if (R != "MDLH")
                    return ReadRet;
                N = (int)reader.ReadUInt32();
                reader.ReadBytes(N);
                do
                {
                    R = new string(reader.ReadChars(4));
                    if (R == "MDLG")  // only happens in FSX
                    {
                        reader.ReadBytes(4);
                        B = reader.ReadBytes(16);
                        Guid G = new Guid(B);
                        GuidValue = G.ToString("B");
                        GuidOK = true;
                    }
                    else if (R == "MDLN") // only happens in FSX
                    {
                        N = (int)reader.ReadUInt32();
                        NameValue = new string(reader.ReadChars(N));
                        NameValue = NameValue.Substring(0, N - 1);
                        NameOK = true;
                    }
                    else if (R == "BBOX")
                    {
                        N = (int)reader.ReadUInt32();
                        BBoxValue.Xmin = reader.ReadSingle();
                        BBoxValue.Ymin = reader.ReadSingle();
                        BBoxValue.Zmin = reader.ReadSingle();
                        BBoxValue.Xmax = reader.ReadSingle();
                        BBoxValue.Ymax = reader.ReadSingle();
                        BBoxValue.Zmax = reader.ReadSingle();
                        reader.ReadBytes(N - 24);
                        BoxOK = true;
                        if (TypeValue == 1)
                            break;
                    }
                    else
                    {
                        N = (int)reader.ReadUInt32();
                        reader.ReadBytes(N);
                    }

                    if (GuidOK & NameOK & BoxOK)
                        break;
                }
                while (true);
                ReadRet = true;
            }
            catch (Exception)
            {
            }

            return ReadRet;
        }
    }
}