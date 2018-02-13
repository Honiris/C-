using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Brainfuck
{
    class JSONElement
    {
        public enum JSONType
        {
            DIC,
            LIST,
            STR,
            NB,
            BOOL,
            NULL
        }
        
        private JSONType type;
        
        public bool bool_value;
        public int int_value;
        public string string_value;
        public List<JSONElement> data;
        public List<string> key;

        public JSONElement(JSONType type)
        {
            this.type = type;
            if (type == JSONType.LIST || type == JSONType.DIC)
                this.data = new List<JSONElement>();
            if (type == JSONType.DIC)
                this.key = new List<string>();
        }

        public JSONType Type
        {
            get { return this.type; }
        }
        
    }

    static class JSON
    {

        public static JSONElement.JSONType GetJsonType(char c)
        {
            if (c == 'n')
                return JSONElement.JSONType.NULL;
            if (c == 't' || c == 'f')
                return JSONElement.JSONType.BOOL;
            if ((int) c >= 48 && (int) c <= 57)
                return JSONElement.JSONType.NB;
            if (c == '{')
                return JSONElement.JSONType.DIC;
            if (c == '[')
                return JSONElement.JSONType.LIST;
            if (c == (char) 34)
                return JSONElement.JSONType.STR;
            return JSONElement.JSONType.NULL;
        }

        public static string ParseString(string json, ref int index)
        {
            int a = index + 1;
            int b = a;

            if (json[a] == (char) 34)
                return "";
            
            while (json[b] != (char) 34 && json[b - 1] != (char) 92)
                b++;
                
            return json.Substring(a, b - 1);
        }


        public static int ParseInt(string json, ref int index)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static bool ParseBool(string json, ref int index)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void EatBlank(string json, ref int index)
        {
            while ((int) json[index] <= 32)
                index++;
        }
        
        public static JSONElement ParseJSONString(string json, ref int index)
        {
            // TODO
            throw new NotImplementedException();
        }
        
        public static JSONElement ParseJSONFile(string file)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void PrintJSON(JSONElement el)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static JSONElement SearchJSON(JSONElement element, string key)
        {
            // TODO
            throw new NotImplementedException();
            return null;
        }
    }   
}