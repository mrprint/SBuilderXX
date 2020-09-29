using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    public class DBFReader
    {
        public enum FieldType
        {
            FTString,
            FTInteger,
            FTDouble,
            FTLogical,
            FTInvalid
        }

        public struct Field
        {
            public string Name;
            public FieldType Type;
            public int Lenght;
            public int DecCount;
        }

        private Field[] Fields = new Field[129];
        private int NoOfRecords;

        public int RecordCount
        {
            get
            {
                return NoOfRecords;
            }
        }

        private int NoOfFields;

        public int FieldCount
        {
            get
            {
                return NoOfFields;
            }
        }

        public Field get_FieldInfo(int N)
        {
            return Fields[N];
        }

        private byte[,] BB;           // each records is a row
        private int[] SF = new int[129];      // points to the start of the field in a record
        private bool[] GR;         // if true it is a GoodRecord (not deleted flag)

        public string Attribute(int R, int F)
        {
            string AttributeRet = default;
            AttributeRet = "";
            if (R >= RecordCount)
                return AttributeRet;
            if (F >= FieldCount)
                return AttributeRet;
            if (!GR[R])
                return AttributeRet;
            byte B;
            int N, J, K;
            J = SF[F];
            K = J + Fields[F].Lenght - 1;
            var loopTo = K;
            for (N = J; N <= loopTo; N++)
            {
                B = BB[R, N];
                if (B != 32)
                {
                    AttributeRet = AttributeRet + Convert.ToChar(B);
                }
            }

            return AttributeRet;
        }

        public bool FileReader(string filename)
        {
            bool FileReaderRet = default;
            FileReaderRet = false;
            string myFile = Path.ChangeExtension(filename, ".dbf");
            var fs = new FileStream(myFile, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(fs);
            int LenHeader, LenRecord;
            byte B;
            string S;
            int C, R;
            C = 0; // to count the size of the header
            try
            {
                if (reader.ReadByte() != 3)
                    return FileReaderRet;
                reader.ReadBytes(3);
                NoOfRecords = (int)reader.ReadUInt32();
                GR = new bool[NoOfRecords];
                LenHeader = reader.ReadUInt16();
                LenRecord = reader.ReadUInt16();
                reader.ReadBytes(20);
                NoOfFields = 0;
                SF[NoOfFields] = 1;
                C = 32; // 32 bytes read
                do
                {
                    B = reader.ReadByte();
                    C = C + 1;
                    if (B == 13)
                        break;
                    S = Conversions.ToString(Convert.ToChar(B)) + reader.ReadChars(10);
                    Fields[NoOfFields].Name = Strings.Left(S, Strings.InStr(S, Constants.vbNullChar) - 1);
                    S = Conversions.ToString(reader.ReadChar());
                    if (S == "C")
                    {
                        Fields[NoOfFields].Type = FieldType.FTString;
                    }
                    else if (S == "N")
                    {
                        Fields[NoOfFields].Type = FieldType.FTInteger;
                    }
                    // ElseIf S = "O" Then
                    else if (S == "F")       // was O and I changed to F in November 2017! Needs testing!
                    {
                        Fields[NoOfFields].Type = FieldType.FTDouble;
                    }
                    else if (S == "L")
                    {
                        Fields[NoOfFields].Type = FieldType.FTLogical;
                    }
                    else
                    {
                        Fields[NoOfFields].Type = FieldType.FTInvalid;
                    }

                    reader.ReadBytes(4);
                    B = reader.ReadByte();
                    Fields[NoOfFields].Lenght = B;
                    SF[NoOfFields + 1] = B + SF[NoOfFields];
                    Fields[NoOfFields].DecCount = reader.ReadByte();
                    reader.ReadBytes(14);
                    NoOfFields = NoOfFields + 1;
                    C = C + 31;
                }
                while (true);
                // check if there is something before the records
                // and if so advance the pointer
                if (LenHeader - C > 0)
                {
                    reader.ReadBytes(LenHeader - C);
                }

                Array.Resize(ref Fields, NoOfFields);
                Array.Resize(ref SF, NoOfFields);
                BB = new byte[RecordCount, LenRecord];
                var loopTo = RecordCount - 1;
                for (R = 0; R <= loopTo; R++)
                {
                    var loopTo1 = LenRecord - 1;
                    for (C = 0; C <= loopTo1; C++)
                        BB[R, C] = reader.ReadByte();
                    if (BB[R, 0] == 32)
                    {
                        GR[R] = true;
                    }
                    else
                    {
                        GR[R] = false;
                    }
                }

                FileReaderRet = true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex);
            }

            // should I reaaly comment the following? October 2017
            // reader.Close()
            fs.Close();
            return FileReaderRet;
        }

        public void Close()
        {
            BB = new byte[1, 1];
            SF = new int[1];
            Fields = new Field[1];
            GR = new bool[1];
        }
    }
}