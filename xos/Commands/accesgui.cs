using Cosmos.Core_Plugs.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xos.Commands;

namespace xos.Commands
{
    public class accesgui : Command
    {
        public accesgui(string name) : base(name) { }

        public override string execute(string[] args){
            Commands.GUI.Initialize(Kernel.ScreenWidth, Kernel.ScreenHeight); 
            GUI.Draw();
            Console.Write("Interface graphique en cours de téléchargement ...") ;
            return "Version 1.0";
 
        }
    }
}
