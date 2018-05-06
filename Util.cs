using System;
using System.IO;
using System.Text;

namespace mandycan{
	class Util{
		public static string pwd(){
			return Directory.GetCurrentDirectory();
		}

		public static void mkdir(string dir){
			Directory.CreateDirectory(dir);
		}

		public static string read(string file){
			return File.ReadAllText(file);
		}

		public static void write(string file,string contents){
			File.AppendAllText(file,contents);
		}

		public static string upperFirst(string s){
			return char.ToUpper(s[0])+s.Substring(1);
		}
	}
}