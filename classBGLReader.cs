using System;
using System.IO;

namespace SBuilderX
{
    public class BGLReader
    {
        public struct MDL
        {
            public string Guid;
            public string Name;
            public float W;
            public float L;
            public int Type;
        }

        private MDL[] MDLsValue;

        public MDL[] MDLs => MDLsValue;

        private int NoOfMDLsValue;

        public int NoOfMDLs => NoOfMDLsValue;

        private int TypeValue;

        public int Type => TypeValue;

        public bool read(BinaryReader reader)
        {
            bool readRet = default;
            int NoOfSPs;  // number of section pointers
            int NoOfSubSPs;  // number of sub section pointers
            int NoOfRs; // number of records
            int N, J, K;
            uint SOffset; // section offset from begin of stream
            uint SubSOffset; // sub section offset from begin of stream
            uint mdlOffset; // mdl record offset from begin of section
            uint SType;
            long SPos;  // pointer to store section position
            long RecPos;  // pointer to store record position
            byte[] B;
            Guid G;
            readRet = false;
            NoOfMDLsValue = 0;
            MDLReader mdl = new MDLReader();
            MDL myMDL;
            try
            {
                if (reader.ReadUInt16() != 513)
                    return readRet; // bgl ide
                if (reader.ReadUInt16() != 6546)
                    return readRet; // version number
                reader.ReadBytes(16);  // skip 16 bytes
                NoOfSPs = (int)reader.ReadUInt32();
                reader.ReadBytes(32);  // skip 132 bytes
                int loopTo = NoOfSPs;
                for (N = 1; N <= loopTo; N++) // read all section pointers
                {
                    SType = reader.ReadUInt32();
                    reader.ReadBytes(4);  // skip 4 bytes
                    NoOfSubSPs = (int)reader.ReadUInt32();
                    SOffset = reader.ReadUInt32();
                    reader.ReadBytes(4);  // skip 4 bytes - size of header
                    if (SType == 43L)  // section type = 2b (mdl)
                    {
                        reader.BaseStream.Position = SOffset; // point to begin of section
                        int loopTo1 = NoOfSubSPs;
                        for (J = 1; J <= loopTo1; J++)    // read all section headers
                        {
                            reader.ReadBytes(4);  // skip ID - 4 bytes
                            NoOfRs = (int)reader.ReadUInt32();
                            SubSOffset = reader.ReadUInt32();
                            reader.ReadBytes(4);  // skip size - 4 bytes
                            SPos = reader.BaseStream.Position;
                            reader.BaseStream.Position = SubSOffset;
                            MDLsValue = new MDL[NoOfRs + 1];
                            int loopTo2 = NoOfRs;
                            for (K = 1; K <= loopTo2; K++)  // read all records
                            {
                                B = reader.ReadBytes(16);
                                mdlOffset = reader.ReadUInt32();
                                reader.ReadBytes(4); // skip size
                                RecPos = reader.BaseStream.Position;
                                reader.BaseStream.Position = SPos + mdlOffset;
                                if (mdl.Read(reader))
                                {
                                    TypeValue = mdl.Type;
                                    myMDL.Type = TypeValue;
                                    NoOfMDLsValue = NoOfMDLsValue + 1;
                                    if (TypeValue == 1) // for FS9
                                    {
                                        G = new Guid(B);
                                        myMDL.Guid = G.ToString("N");
                                        myMDL.Name = "_#" + NoOfMDLsValue.ToString();
                                    }
                                    else // it is fsx
                                    {
                                        myMDL.Guid = mdl.Guid;  // ignore the guid in BGL and use the one in the mdl
                                        myMDL.Name = mdl.Name;
                                    }

                                    myMDL.W = mdl.Width;
                                    myMDL.L = mdl.Lenght;
                                    MDLsValue.SetValue(myMDL, NoOfMDLsValue);
                                }

                                reader.BaseStream.Position = RecPos;
                            }

                            reader.BaseStream.Position = SPos;
                        }
                    }
                }

                readRet = true;
            }
            catch (Exception)
            {
            }

            return readRet;
        }
    }
}