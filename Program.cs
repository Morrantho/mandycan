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
	        				Util.mkdir(appDir+"/Views/Shared");
	        				Util.mkdir(appDir+"/Views/"+args[1]);
	        				Util.mkdir(appDir+"/Models");
	        				Util.mkdir(appDir+"/wwwroot/css");
	        				Util.mkdir(appDir+"/wwwroot/js");
	        				Util.write(appDir+"/wwwroot/css/style.css","");
	        				Util.write(appDir+"/wwwroot/js/main.js","");

	        				string program = Util.read(templates+"/program.txt").Replace("Template",args[1]);
	        				string startup = Util.read(templates+"/startup.txt").Replace("Template",args[1]);
	        				string csproj  = Util.read(templates+"/csproj.txt");

	        				string layout = Util.read(templates+"/layout.txt").Replace("Template",args[1]);
	        				string viewimports = Util.read(templates+"/viewimports.txt").Replace("Template",args[1]);
	        				string viewstart = Util.read(templates+"/viewstart.txt");

	        				string controller = Util.read(templates+"/controller.txt").Replace("Template",args[1]);
	        				string view       = Util.read(templates+"/view.txt").Replace("Template",args[1]);

	        				// Startup:
	        				Util.write(appDir+"/Startup.cs",startup);
	        				Util.write(appDir+"/Program.cs",program);
	        				Util.write(appDir+"/"+args[1]+".csproj",csproj);

	        				// Controller:
	        				Util.write(appDir+"/Controllers/"+args[1]+".cs",controller);

	        				// Views:
	        				Util.write(appDir+"/Views/Shared/_Layout.cshtml",layout);
	        				Util.write(appDir+"/Views/_ViewImports.cshtml",viewimports);
	        				Util.write(appDir+"/Views/_ViewStart.cshtml",viewstart);
	        				Util.write(appDir+"/Views/"+args[1]+"/Index.cshtml",view);
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
