using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorRenderModes.Components.Base
{
    public class ComponentBase
    {
        public IJSRuntime JSRuntime { get; set; }
    }
}
