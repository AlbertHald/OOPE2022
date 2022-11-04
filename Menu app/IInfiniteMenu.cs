using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_app
{
    interface IInfiniteMenu
    {
        string Title { get; set; }
        void Spawn();
    }
}
