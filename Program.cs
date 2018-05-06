using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

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
	        				string[] folders = {appDir,appDir+"/Controllers",appDir+"/Views/Shared",appDir+"/Views/"+args[1],appDir+"/Models",appDir+"/wwwroot/css",appDir+"/wwwroot/js"};
	        				for(int i=0;i<folders.Length;i++) Util.mkdir(folders[i]);
	        				Util.write(appDir+"/wwwroot/css/style.css","");
	        				Util.write(appDir+"/wwwroot/js/main.js","");
	        				Dictionary<string,string> files = new Dictionary<string,string>(){
	        					{"startup.txt",appDir+"/Startup.cs"},
	        					{"program.txt",appDir+"/Program.cs"},
	        					{"csproj.txt",appDir+"/"+args[1]+".csproj"},
	        					{"layout.txt",appDir+"/Views/Shared/_Layout.cshtml"},
	        					{"viewimports.txt",appDir+"/Views/_ViewImports.cshtml"},
	        					{"viewstart.txt",appDir+"/Views/_ViewStart.cshtml"},
	        					{"controller.txt",appDir+"/Controllers/"+args[1]+".cs"},
	        					{"view.txt",appDir+"/Views/"+args[1]+"/Index.cshtml"}
	        				};

	        				foreach(var file in files){
	        					string contents = Util.read(templates+"/"+file.Key).Replace("Template",args[1]);
	        					Util.write(file.Value,contents);
	        				}
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
