using AForge.Imaging;
using ImageProcessingLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.AForge
{
    public class AforgeImageTypeConverter : IImageTypeConverter
    {
        public bool CanConvert(object instance, Type targetType)
        {
            return instance is Bitmap && targetType == typeof(UnmanagedImage);
        }

        public object Convert(object instance, Type targetType)
        {
            return global::AForge.Imaging.UnmanagedImage.FromManagedImage((Bitmap)instance);
        }
    }

    public class AforgeImageTypeBackConverter : IImageTypeConverter
    {
        public bool CanConvert(object instance, Type targetType)
        {
            return instance is UnmanagedImage && targetType == typeof(Bitmap);
        }

        public object Convert(object instance, Type targetType)
        {
            UnmanagedImage unmanagedImageinstance = instance as UnmanagedImage;
            return unmanagedImageinstance.ToManagedImage();
        }
    }
}
