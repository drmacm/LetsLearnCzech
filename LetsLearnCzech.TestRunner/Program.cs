using LetsLearnCzech.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            UserBll userBll = new UserBll();
            userBll.AddUser("Mladen");
        }
    }
}
