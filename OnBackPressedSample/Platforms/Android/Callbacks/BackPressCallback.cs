using AndroidX.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBackPressedSample.Platforms.Android.Callbacks
{
    public class BackPressCallback : OnBackPressedCallback
    {
        public BackPressCallback() : base(true)
        {
        }

        public override void HandleOnBackPressed()
        {
            Console.WriteLine("I triggered!");
        }
    }
}
