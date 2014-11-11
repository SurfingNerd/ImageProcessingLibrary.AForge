using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{
    public class ColorDistanceFilterActivity : AForgeActivity
    {
        public int MaxDistance { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
            ColorFiltering filtering = new ColorFiltering(
                new global::AForge.IntRange(R-MaxDistance, R+MaxDistance),
                new global::AForge.IntRange(G-MaxDistance, G+MaxDistance),
                new global::AForge.IntRange(B-MaxDistance, B+MaxDistance)
                );

            return filtering;
        }
    }
}
