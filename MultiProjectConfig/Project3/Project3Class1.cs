using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Project3Class1
    {

        public Project3Class1()
        {
            MySetting1 = Project3Settings1.Default.Project3Setting1;

            MySetting2 = Project3Settings1.Default.Project3Setting2;
        }


        public string MySetting1 { get; set; }

        public string MySetting2 { get; set; }
    }
}
