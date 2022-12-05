using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lead.Tool.Interface
{
    public enum IToolState
    {
        ToolMin = 0,
        ToolInit,
        ToolRunning,
        ToolTerminate
    }
    public interface ITool
    {
        IToolState State { get; }
        Control ConfigUI { get; }
        Control DebugUI { get; }
        void Init();
        void Start();
        void Terminate();
    }
}
