using System;
using System.IO;
using System.Text;

namespace mandycan{
    class Program{
		public static string pwd;

        static void Main(string[] args){
        	pwd = Util.pwd();
        	string templates = pwd+"/templates";

        	if(args.Length > 0){
	        	switch(args[0]){
	        		case "new":
	        			if(args.Length > 1){
	        				args[1] = Util.upperFirst(args[1]);
	        				string appDir = pwd+"/"+args[1];
	        				Util.mkdir(appDir);
	        				Util.mkdir(appDir+"/Controllers");
	        				Util.mkdir(appDir+"/Views");
	        				Util.mkdir(appDir+"/Models");
	        				Util.mkdir(appDir+"/wwwroot/css");
	        				Util.mkdir(appDir+"/wwwroot/js");
	        				Util.write(appDir+"/wwwroot/css/style.css","");
	        				Util.write(appDir+"/wwwroot/js/main.css","");

	        				string program = Util.read(templates+"/program.txt").Replace("Template",args[1]);
	        				string startup = Util.read(templates+"/startup.txt").Replace("Template",args[1]);
	        				string csproj  = Util.read(templates+"/csproj.txt");

	        				Util.write(appDir+"/Startup.cs",startup);
	        				Util.write(appDir+"/Program.cs",program);
	        				Util.write(appDir+"/"+args[1]+".csproj",csproj);
	        			}
	        			break;
	        		case "mvc":
	        			if(args.Length > 1){

	        			}
	        			break;
	        	}
        	}
        }
    }
}
