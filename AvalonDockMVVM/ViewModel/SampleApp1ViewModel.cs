﻿using AvalonDockMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockMVVM.ViewModel
{
    public class SampleApp1ViewModel : DockWindowViewModel
    {
        public string BingText { get; set; } = "Binding SampleApp1 ABC";
    }
}
