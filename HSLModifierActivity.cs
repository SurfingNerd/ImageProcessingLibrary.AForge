using AForge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{
    public class HSLModifierActivity : AForgeActivity
    {
        protected override global::AForge.Imaging.Filters.IInPlaceFilter GetFilter(ActivityContext context)
        {
            global::AForge.Imaging.Filters.HSLLinear l = new global::AForge.Imaging.Filters.HSLLinear();
            
            IntRange hue = new IntRange(100,200);
            Range sat= new Range(0.5f,0.75f);
            Range lum = new Range(0.5f,0.75f);
            var filter = new global::AForge.Imaging.Filters.HSLFiltering(hue, sat, lum);
            return filter;
        }
    }
}
