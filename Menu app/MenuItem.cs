using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_app
{  
   
    internal class MenuItem:IMenuItem
    {
        public MenuItem(string title, string content)
        {
            Content = content;
            Title = title;
        }
        public string Content { get; set; }
        public string Title { get; set; }

        public void Select()
        {
            
        }
        public void Start()
        {

        }
    }
}
