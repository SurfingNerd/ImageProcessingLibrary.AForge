using global::AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{
    public abstract class AForgeActivity : IActivity, ISingleImageActivity
    {
        public string ImageName { get; set; }
        
        public void Execute(ActivityContext context)
        {
            var filter = GetFilter(context);
            RuntimeImage image = context.Get(ImageName);
            filter.ApplyInPlace(image.GetBitmap());
        }


        protected abstract IInPlaceFilter GetFilter(ActivityContext context);
    }



   
}
