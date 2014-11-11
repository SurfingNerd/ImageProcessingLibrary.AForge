using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{
    public class ContrastModificationActivity : AForgeActivity
    {
        // Summary:
        //     Contrast adjusting factor, [-127, 127].
        //
        // Remarks:
        //     Factor which is used to adjust contrast. Factor values greater than 0 increase
        //     contrast making light areas lighter and dark areas darker. Factor values
        //     less than 0 decrease contrast - decreasing variety of contrast.
        //     Default value is set to 10.
        public int Factor { get; set; }

        protected override global::AForge.Imaging.Filters.IInPlaceFilter GetFilter(ActivityContext context)
        {
            return new global::AForge.Imaging.Filters.ContrastCorrection(Factor);
        }
    }
}
