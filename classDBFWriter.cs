using System;
using System.IO;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    public class DBFWriter
    {
        private short nFields = 0;
        private bool fileIsOpened = false;
        private bool headerDone = false;
        private short nBytesInRecord;
        private int NoOfRecords = 0;
        private short NoOfBytesInHeader;
        private FileStream fs;
        private BinaryWriter bw;
        private const byte shp_CHARACTER = 67;   // C
        private const byte shp_NUMERIC = 78;     // N
        private const byte shp_FLOAT = 70;    // F

        public struct Field
        {
            public string Name;
            public byte Type;
            public byte Lenght;
            public byte DecCount;
        }

        private Field[] Fields = new Field[129];
        private int[] FieldStart = new int[129];      // points to the start of the field in a record

        public bool FileWriter(string filename, int nRecords)
        {
            bool FileWriterRet = default;

            try
            {
                FileWriterRet = false;
                headerDone = false;
                fileIsOpened = false;
                nBytesInRecord = 0;
                NoOfRecords = 0;
                string DBFile = Path.ChangeExtension(filename, ".DBF");
                if (File.Exists(DBFile))
                    File.Delete(DBFile);
                fs = new FileStream(DBFile, FileMode.Create);
                bw = new BinaryWriter(fs);
                var today = DateAndTime.Now;
                bw.Write((byte)3);
                bw.Write((byte)(today.Year - 1900));
                bw.Write((byte)today.Month);
                bw.Write((byte)today.Day);
                bw.Write(nRecords);           // byte 4 - 7

                // accounts for the leading space on each record note that
                // FieldStart(2) = FieldStart(1) + Fields(1).Lenght and so on ...
                FieldStart[1] = 1;
                NoOfRecords = nRecords;
                FileWriterRet = true;
                fileIsOpened = true;
                return FileWriterRet;
            }
            catch (Exception e)
            {
                Interaction.MsgBox("Could not create database file!", MsgBoxStyle.Exclamation);
                fileIsOpened = false;
                bw.Close();
                fs.Close();
                return FileWriterRet;
            }
        }

        public bool CreateField(string name, byte type, byte len, byte dec)
        {
            bool CreateFieldRet = false;
            int N;

            try
            {
                if (!fileIsOpened)
                    return CreateFieldRet;
                if (headerDone)
                    return CreateFieldRet;
                if (type != shp_CHARACTER)
                {
                    if (type != shp_FLOAT)
                    {
                        if (type != shp_NUMERIC)
                            return CreateFieldRet;
                    }
                }

                // validate arguments
                if (type == shp_CHARACTER)
                    dec = 0;
                if (len == 0)
                    return CreateFieldRet;
                if (len - dec < 1)
                    return CreateFieldRet;

                // now start the writing
                int ptr = (nFields + 1) * 32;
                name = Strings.Trim(name);           // remove any trailing or leading spaces
                N = name.Length;
                if (N > 11)
                {
                    name = Strings.Left(name, 11);
                    N = 11;
                }

                bw.Seek(ptr, SeekOrigin.Begin);
                byte[] b;      // binary.writer(string) also rights the len of string :-(
                b = System.Text.Encoding.UTF8.GetBytes(name);   // so transform string into array of bytes
                bw.Write(b);
                bw.Seek(11 - N, SeekOrigin.Current);
                bw.Write(type);            // byte 11
                bw.Seek(4, SeekOrigin.Current);
                bw.Write(len);             // byte 16
                bw.Write(dec);             // byte 17
                nFields = (short)(nFields + 1);            // array Fields(0) and StartField(0) is ignored!
                Fields[nFields].Name = name;
                Fields[nFields].Type = type;
                Fields[nFields].Lenght = len;
                Fields[nFields].DecCount = dec;
                FieldStart[nFields + 1] = FieldStart[nFields] + len;
                nBytesInRecord = (short)(nBytesInRecord + len);
                CreateFieldRet = true;
            }
            catch (Exception e)
            {
                Interaction.MsgBox("Could not create database field: " + name + "!", MsgBoxStyle.Exclamation);
                CreateFieldRet = false;
            }
            return CreateFieldRet;
        }

        public bool AppendFields()
        {
            bool AppendFieldsRet = default;
            AppendFieldsRet = false;
            headerDone = false;
            if (nFields == 0)
                return AppendFieldsRet;
            nBytesInRecord = (short)(nBytesInRecord + 1);      // there is a leading space on each record!
            try
            {
                // point to bytes 8-9 
                bw.Seek(8, SeekOrigin.Begin);
                // calculate number of bytes in header
                NoOfBytesInHeader = (short)(32 * (nFields + 1) + 1);   // add one for the terminator 13
                bw.Write(NoOfBytesInHeader);
                bw.Write(nBytesInRecord);
                bw.Seek(NoOfBytesInHeader - 1, SeekOrigin.Begin);
                bw.Write((byte)13);  // add the terminator for the header
                                     // fill the table with spaces
                string mySpaces = Strings.Space(NoOfRecords * nBytesInRecord);
                byte[] b;      // binary.writer(string) also rights the len of string :-(
                b = System.Text.Encoding.UTF8.GetBytes(mySpaces);   // so transform string into array of bytes
                bw.Write(b);
                bw.Write((byte)26);    // 26 is 1A the terminator for the file
                Array.Resize(ref FieldStart, nFields + 1);  // it will eliminate the last field as (field + 1) will not appear
                Array.Resize(ref Fields, nFields + 1);
                AppendFieldsRet = true;
                headerDone = true;
                return AppendFieldsRet;
            }
            catch (Exception e)
            {
                Interaction.MsgBox("Could not append database fields!", MsgBoxStyle.Exclamation);
                AppendFieldsRet = false;
                headerDone = false;
                return AppendFieldsRet;
            }
        }

        public bool AddRecord(int record, int field, string value)
        {
            bool AddRecordRet = default;

            // when calling and for numeric or floating types 
            // value should be passed as a string! No conversion made here!

            AddRecordRet = false;

            try
            {
                byte[] b;   // to strip the lenght at the start of the string
                if (!headerDone)
                    return AddRecordRet;
                if (field > nFields)
                    return AddRecordRet;
                int myLen = Fields[field].Lenght;
                int ptr = NoOfBytesInHeader + nBytesInRecord * (record - 1) + FieldStart[field];
                bw.Seek(ptr, SeekOrigin.Begin);
                value = Strings.Trim(value);
                value = Strings.Left(value, myLen);   // just to make sure the string can go to the allocated space
                b = System.Text.Encoding.UTF8.GetBytes(value);   // transform string into array of bytes
                bw.Write(b);
                AddRecordRet = true;
            }
            catch (Exception e)
            {
            }
            return AddRecordRet;
        }

        public void Close()
        {
            bw.Close();
            fs.Close();
        }
    }
}