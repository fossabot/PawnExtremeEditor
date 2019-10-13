using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnEE
{
    public static class EventHandler
    {
        public static bool treeViewClick
        {
            get;set;
        }

        public static string treeViewClickFilePath
        {
            get;set;
        }

        public static string workspaceFilePath
        {
            get;set;
        }

        public static string treeViewGetFileName
        {
            get;set;
        }
    }
}
