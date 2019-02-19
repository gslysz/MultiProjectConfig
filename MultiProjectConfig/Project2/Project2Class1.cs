using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Project2Class1
    {

        public Project2Class1()
        {
            MySetting1 = Project2Settings1.Default.Project2Setting1;
            MySetting2 = Project2Settings1.Default.Project2Setting2;
        }

        public string MySetting1 { get; set; }

        public string MySetting2 { get; set; }



    }


    
   
}

