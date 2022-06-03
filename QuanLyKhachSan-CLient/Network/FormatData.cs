using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.Network
{
    public class FormatData
    {

        #region make singleton
        private static FormatData instance;
        public static FormatData Instance
        {
            get
            {
                if (instance == null) instance = new FormatData(); return instance;
            }
            private set { instance = value; }
        }

        private FormatData() { }
        #endregion



        /// <summary>
        /// Convert Object to Byte[]
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        /// <summary>
        /// Convert Byte[] to Object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            try
            {
                MemoryStream ms = new MemoryStream(theByteArray);
                BinaryFormatter bf1 = new BinaryFormatter();
                ms.Position = 0;
                return bf1.Deserialize(ms);
            }
            catch
            {
                return null;
            }
        }

    }
}
