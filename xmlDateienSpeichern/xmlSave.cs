using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace xmlDateienSpeichern
{
    class xmlSave
    {
        public static void SaveData(Object obj, string filename )
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter txtwr = new StreamWriter(filename);
            sr.Serialize(txtwr, obj);
            txtwr.Close();
        }
      
    }
}
