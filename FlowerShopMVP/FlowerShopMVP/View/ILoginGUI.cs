using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVP.View
{
    public interface ILoginGUI : IGUI
    {
        string GetUsername();
        string GetPassword();
    }
}
