using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{

    /// <summary>
    /// Aforge Activity that creates a image from a source image.
    /// </summary>
    public abstract class AForgeCreateTransformationActivity : ICreateImageActivity, ISingleImageActivity
    {
        public string OutputImageName
        {
            get;
            set;
        }

        public void Execute(ActivityContext context)
        {
            global::AForge.Imaging.Filters.IFilter filter
                = GetFilter(context);

            var result = filter.Apply(context.Get<UnmanagedImage>(ImageName));
            context.Set(OutputImageName, result); 
            //filter.Apply(conte
        }

        protected abstract global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context);

        public string ImageName
        {
            get;
            set;
        }
    }
}
