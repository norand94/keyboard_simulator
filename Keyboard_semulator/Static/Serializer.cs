﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Keyboard_semulator
{
    class Serializer
    {
        public static string FILE_USERS = "file_users";

        public static bool writeObject(string path, object obj)
        {
            try {
                FileStream FS = new FileStream(path, FileMode.Create);
                new BinaryFormatter().Serialize(FS, obj);
                FS.Close();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public static object readObject(string path)
        {
            try
            {
                FileStream FS = new FileStream(path, FileMode.Open);
                object obj = new BinaryFormatter().Deserialize(FS);
                FS.Close();
                return obj;
            }
            catch { return null; }
        }
    }
}
