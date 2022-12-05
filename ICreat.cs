using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lead.Tool.Interface
{
    public interface ICreat
    {
        string Name { get; }
        Image Icon { get; }
        ITool GetInstance(string Name, string ConfigPath);
    }
}
