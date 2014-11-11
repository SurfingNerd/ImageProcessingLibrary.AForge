
//The Code in this file is generated, any changes are deleted the next time the code gets generated.
//You are able to store your changes if you edit the T4 Template.

using global::AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using global::AForge.Imaging;

namespace ImageProcessingLibrary.AForge.Filters
{

// Searching Assembly for Reflection: AForge.Imaging
//Scanning Path for dll AForge.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AForge\Filters\AForge.Imaging.dll
//Scanning Path for dll AForge.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AForge\AForge.Imaging.dll
//Scanning Path for dll AForge.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AForge\bin\AForge.Imaging.dll
//Scanning Path for dll AForge.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AForge\bin\Debug\AForge.Imaging.dll
//AForge.Imaging found: C:\DEV\Vision\ImageProcessingLibrary.AForge\bin\Debug\AForge.Imaging.dll
//Added to Dll lookup Dir: C:\DEV\Vision\ImageProcessingLibrary.AForge\bin\Debug


	public class ConservativeSmoothingInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 KernelSize { get;set;}

		public ConservativeSmoothingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ConservativeSmoothing();
		  this.KernelSize = tmp.KernelSize;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ConservativeSmoothing();
			result.KernelSize = this.KernelSize;
		   return result;
        }


	}
		

	public class RotateChannelsInPlaceActivity : AForgeActivity
	{
		
		public RotateChannelsInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.RotateChannels();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.RotateChannels();
					   return result;
        }


	}
		

	public class GammaCorrectionInPlaceActivity : AForgeActivity
	{
		public global::System.Double Gamma { get;set;}

		public GammaCorrectionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GammaCorrection();
		  this.Gamma = tmp.Gamma;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GammaCorrection();
			result.Gamma = this.Gamma;
		   return result;
        }


	}
		

	public class BrightnessCorrectionInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 AdjustValue { get;set;}

		public BrightnessCorrectionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BrightnessCorrection();
		  this.AdjustValue = tmp.AdjustValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BrightnessCorrection();
			result.AdjustValue = this.AdjustValue;
		   return result;
        }


	}
		

	public class StuckiDitheringInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public StuckiDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.StuckiDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.StuckiDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class BinaryErosion3x3InPlaceActivity : AForgeActivity
	{
		
		public BinaryErosion3x3InPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BinaryErosion3x3();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BinaryErosion3x3();
					   return result;
        }


	}
		

	public class ThresholdInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 ThresholdValue { get;set;}

		public ThresholdInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Threshold();
		  this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Threshold();
			result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class AddInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public AddInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Add();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Add();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class PointedMeanFloodFillInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Color Tolerance { get;set;}
public global::AForge.IntPoint StartingPoint { get;set;}

		public PointedMeanFloodFillInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.PointedMeanFloodFill();
		  this.Tolerance = tmp.Tolerance;
this.StartingPoint = tmp.StartingPoint;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.PointedMeanFloodFill();
			result.Tolerance = this.Tolerance;
result.StartingPoint = this.StartingPoint;
		   return result;
        }


	}
		

	public class ColorFilteringInPlaceActivity : AForgeActivity
	{
		public global::AForge.IntRange Red { get;set;}
public global::AForge.IntRange Green { get;set;}
public global::AForge.IntRange Blue { get;set;}
public global::AForge.Imaging.RGB FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}

		public ColorFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ColorFiltering();
		  this.Red = tmp.Red;
this.Green = tmp.Green;
this.Blue = tmp.Blue;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ColorFiltering();
			result.Red = this.Red;
result.Green = this.Green;
result.Blue = this.Blue;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
		   return result;
        }


	}
		

	public class SimpleSkeletonizationInPlaceActivity : AForgeActivity
	{
		public global::System.Byte Background { get;set;}
public global::System.Byte Foreground { get;set;}

		public SimpleSkeletonizationInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SimpleSkeletonization();
		  this.Background = tmp.Background;
this.Foreground = tmp.Foreground;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SimpleSkeletonization();
			result.Background = this.Background;
result.Foreground = this.Foreground;
		   return result;
        }


	}
		

	public class MorphInPlaceActivity : AForgeActivity
	{
		public global::System.Double SourcePercent { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MorphInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Morph();
		  this.SourcePercent = tmp.SourcePercent;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Morph();
			result.SourcePercent = this.SourcePercent;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class SaturationCorrectionInPlaceActivity : AForgeActivity
	{
		public global::System.Single AdjustValue { get;set;}

		public SaturationCorrectionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SaturationCorrection();
		  this.AdjustValue = tmp.AdjustValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SaturationCorrection();
			result.AdjustValue = this.AdjustValue;
		   return result;
        }


	}
		

	public class BradleyLocalThresholdingInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 WindowSize { get;set;}
public global::System.Single PixelBrightnessDifferenceLimit { get;set;}

		public BradleyLocalThresholdingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BradleyLocalThresholding();
		  this.WindowSize = tmp.WindowSize;
this.PixelBrightnessDifferenceLimit = tmp.PixelBrightnessDifferenceLimit;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BradleyLocalThresholding();
			result.WindowSize = this.WindowSize;
result.PixelBrightnessDifferenceLimit = this.PixelBrightnessDifferenceLimit;
		   return result;
        }


	}
		

	public class MedianInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 Size { get;set;}

		public MedianInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Median();
		  this.Size = tmp.Size;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Median();
			result.Size = this.Size;
		   return result;
        }


	}
		

	public class TopHatInPlaceActivity : AForgeActivity
	{
		
		public TopHatInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.TopHat();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.TopHat();
					   return result;
        }


	}
		

	public class DifferenceEdgeDetectorInPlaceActivity : AForgeActivity
	{
		
		public DifferenceEdgeDetectorInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.DifferenceEdgeDetector();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.DifferenceEdgeDetector();
					   return result;
        }


	}
		

	public class MeanInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public MeanInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Mean();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Mean();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class LevelsLinearInPlaceActivity : AForgeActivity
	{
		public global::AForge.IntRange InRed { get;set;}
public global::AForge.IntRange InGreen { get;set;}
public global::AForge.IntRange InBlue { get;set;}
public global::AForge.IntRange InGray { get;set;}
public global::AForge.IntRange Input { get;set;}
public global::AForge.IntRange OutRed { get;set;}
public global::AForge.IntRange OutGreen { get;set;}
public global::AForge.IntRange OutBlue { get;set;}
public global::AForge.IntRange OutGray { get;set;}
public global::AForge.IntRange Output { get;set;}

		public LevelsLinearInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.LevelsLinear();
		  this.InRed = tmp.InRed;
this.InGreen = tmp.InGreen;
this.InBlue = tmp.InBlue;
this.InGray = tmp.InGray;
this.OutRed = tmp.OutRed;
this.OutGreen = tmp.OutGreen;
this.OutBlue = tmp.OutBlue;
this.OutGray = tmp.OutGray;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.LevelsLinear();
			result.InRed = this.InRed;
result.InGreen = this.InGreen;
result.InBlue = this.InBlue;
result.InGray = this.InGray;
result.Input = this.Input;
result.OutRed = this.OutRed;
result.OutGreen = this.OutGreen;
result.OutBlue = this.OutBlue;
result.OutGray = this.OutGray;
result.Output = this.Output;
		   return result;
        }


	}
		

	public class SISThresholdInPlaceActivity : AForgeActivity
	{
		
		public SISThresholdInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SISThreshold();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SISThreshold();
					   return result;
        }


	}
		

	public class DifferenceInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public DifferenceInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Difference();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Difference();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class HSLLinearInPlaceActivity : AForgeActivity
	{
		public global::AForge.Range InLuminance { get;set;}
public global::AForge.Range OutLuminance { get;set;}
public global::AForge.Range InSaturation { get;set;}
public global::AForge.Range OutSaturation { get;set;}

		public HSLLinearInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HSLLinear();
		  this.InLuminance = tmp.InLuminance;
this.OutLuminance = tmp.OutLuminance;
this.InSaturation = tmp.InSaturation;
this.OutSaturation = tmp.OutSaturation;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HSLLinear();
			result.InLuminance = this.InLuminance;
result.OutLuminance = this.OutLuminance;
result.InSaturation = this.InSaturation;
result.OutSaturation = this.OutSaturation;
		   return result;
        }


	}
		

	public class BlurInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public BlurInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Blur();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Blur();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class SimplePosterizationInPlaceActivity : AForgeActivity
	{
		public global::System.Byte PosterizationInterval { get;set;}
public global::AForge.Imaging.Filters.SimplePosterization.PosterizationFillingType FillingType { get;set;}

		public SimplePosterizationInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SimplePosterization();
		  this.PosterizationInterval = tmp.PosterizationInterval;
this.FillingType = tmp.FillingType;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SimplePosterization();
			result.PosterizationInterval = this.PosterizationInterval;
result.FillingType = this.FillingType;
		   return result;
        }


	}
		

	public class JarvisJudiceNinkeDitheringInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public JarvisJudiceNinkeDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.JarvisJudiceNinkeDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.JarvisJudiceNinkeDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class AdaptiveSmoothingInPlaceActivity : AForgeActivity
	{
		public global::System.Double Factor { get;set;}

		public AdaptiveSmoothingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.AdaptiveSmoothing();
		  this.Factor = tmp.Factor;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.AdaptiveSmoothing();
			result.Factor = this.Factor;
		   return result;
        }


	}
		

	public class BlobsFilteringInPlaceActivity : AForgeActivity
	{
		public global::System.Boolean CoupledSizeFiltering { get;set;}
public global::System.Int32 MinWidth { get;set;}
public global::System.Int32 MinHeight { get;set;}
public global::System.Int32 MaxWidth { get;set;}
public global::System.Int32 MaxHeight { get;set;}
public global::AForge.Imaging.IBlobsFilter BlobsFilter { get;set;}

		public BlobsFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BlobsFiltering();
		  this.CoupledSizeFiltering = tmp.CoupledSizeFiltering;
this.MinWidth = tmp.MinWidth;
this.MinHeight = tmp.MinHeight;
this.MaxWidth = tmp.MaxWidth;
this.MaxHeight = tmp.MaxHeight;
this.BlobsFilter = tmp.BlobsFilter;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BlobsFiltering();
			result.CoupledSizeFiltering = this.CoupledSizeFiltering;
result.MinWidth = this.MinWidth;
result.MinHeight = this.MinHeight;
result.MaxWidth = this.MaxWidth;
result.MaxHeight = this.MaxHeight;
result.BlobsFilter = this.BlobsFilter;
		   return result;
        }


	}
		

	public class HomogenityEdgeDetectorInPlaceActivity : AForgeActivity
	{
		
		public HomogenityEdgeDetectorInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HomogenityEdgeDetector();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HomogenityEdgeDetector();
					   return result;
        }


	}
		

	public class GaussianSharpenInPlaceActivity : AForgeActivity
	{
		public global::System.Double Sigma { get;set;}
public global::System.Int32 Size { get;set;}
public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public GaussianSharpenInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GaussianSharpen();
		  this.Sigma = tmp.Sigma;
this.Size = tmp.Size;
this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GaussianSharpen();
			result.Sigma = this.Sigma;
result.Size = this.Size;
result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class MergeInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MergeInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Merge();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Merge();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class PointedColorFloodFillInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Color Tolerance { get;set;}
public global::System.Drawing.Color FillColor { get;set;}
public global::AForge.IntPoint StartingPoint { get;set;}

		public PointedColorFloodFillInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.PointedColorFloodFill();
		  this.Tolerance = tmp.Tolerance;
this.FillColor = tmp.FillColor;
this.StartingPoint = tmp.StartingPoint;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.PointedColorFloodFill();
			result.Tolerance = this.Tolerance;
result.FillColor = this.FillColor;
result.StartingPoint = this.StartingPoint;
		   return result;
        }


	}
		

	public class Erosion3x3InPlaceActivity : AForgeActivity
	{
		
		public Erosion3x3InPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Erosion3x3();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Erosion3x3();
					   return result;
        }


	}
		

	public class FlatFieldCorrectionInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap BackgoundImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedBackgoundImage { get;set;}

		public FlatFieldCorrectionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FlatFieldCorrection();
		  this.BackgoundImage = tmp.BackgoundImage;
this.UnmanagedBackgoundImage = tmp.UnmanagedBackgoundImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FlatFieldCorrection();
			result.BackgoundImage = this.BackgoundImage;
result.UnmanagedBackgoundImage = this.UnmanagedBackgoundImage;
		   return result;
        }


	}
		

	public class HSLFilteringInPlaceActivity : AForgeActivity
	{
		public global::AForge.IntRange Hue { get;set;}
public global::AForge.Range Saturation { get;set;}
public global::AForge.Range Luminance { get;set;}
public global::AForge.Imaging.HSL FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}
public global::System.Boolean UpdateHue { get;set;}
public global::System.Boolean UpdateSaturation { get;set;}
public global::System.Boolean UpdateLuminance { get;set;}

		public HSLFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HSLFiltering();
		  this.Hue = tmp.Hue;
this.Saturation = tmp.Saturation;
this.Luminance = tmp.Luminance;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;
this.UpdateHue = tmp.UpdateHue;
this.UpdateSaturation = tmp.UpdateSaturation;
this.UpdateLuminance = tmp.UpdateLuminance;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HSLFiltering();
			result.Hue = this.Hue;
result.Saturation = this.Saturation;
result.Luminance = this.Luminance;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
result.UpdateHue = this.UpdateHue;
result.UpdateSaturation = this.UpdateSaturation;
result.UpdateLuminance = this.UpdateLuminance;
		   return result;
        }


	}
		

	public class GaussianBlurInPlaceActivity : AForgeActivity
	{
		public global::System.Double Sigma { get;set;}
public global::System.Int32 Size { get;set;}
public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public GaussianBlurInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GaussianBlur();
		  this.Sigma = tmp.Sigma;
this.Size = tmp.Size;
this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GaussianBlur();
			result.Sigma = this.Sigma;
result.Size = this.Size;
result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class EdgesInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public EdgesInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Edges();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Edges();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class OtsuThresholdInPlaceActivity : AForgeActivity
	{
		
		public OtsuThresholdInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OtsuThreshold();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OtsuThreshold();
					   return result;
        }


	}
		

	public class IterativeThresholdInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 MinimumError { get;set;}
public global::System.Int32 ThresholdValue { get;set;}

		public IterativeThresholdInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.IterativeThreshold();
		  this.MinimumError = tmp.MinimumError;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.IterativeThreshold();
			result.MinimumError = this.MinimumError;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class IntersectInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public IntersectInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Intersect();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Intersect();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class FillHolesInPlaceActivity : AForgeActivity
	{
		public global::System.Boolean CoupledSizeFiltering { get;set;}
public global::System.Int32 MaxHoleWidth { get;set;}
public global::System.Int32 MaxHoleHeight { get;set;}

		public FillHolesInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FillHoles();
		  this.CoupledSizeFiltering = tmp.CoupledSizeFiltering;
this.MaxHoleWidth = tmp.MaxHoleWidth;
this.MaxHoleHeight = tmp.MaxHoleHeight;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FillHoles();
			result.CoupledSizeFiltering = this.CoupledSizeFiltering;
result.MaxHoleWidth = this.MaxHoleWidth;
result.MaxHoleHeight = this.MaxHoleHeight;
		   return result;
        }


	}
		

	public class ThresholdWithCarryInPlaceActivity : AForgeActivity
	{
		public global::System.Byte ThresholdValue { get;set;}

		public ThresholdWithCarryInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ThresholdWithCarry();
		  this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ThresholdWithCarry();
			result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class JitterInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 Radius { get;set;}

		public JitterInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Jitter();
		  this.Radius = tmp.Radius;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Jitter();
			result.Radius = this.Radius;
		   return result;
        }


	}
		

	public class HistogramEqualizationInPlaceActivity : AForgeActivity
	{
		
		public HistogramEqualizationInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HistogramEqualization();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HistogramEqualization();
					   return result;
        }


	}
		

	public class FloydSteinbergDitheringInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public FloydSteinbergDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FloydSteinbergDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FloydSteinbergDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class YCbCrLinearInPlaceActivity : AForgeActivity
	{
		public global::AForge.Range InY { get;set;}
public global::AForge.Range InCb { get;set;}
public global::AForge.Range InCr { get;set;}
public global::AForge.Range OutY { get;set;}
public global::AForge.Range OutCb { get;set;}
public global::AForge.Range OutCr { get;set;}

		public YCbCrLinearInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.YCbCrLinear();
		  this.InY = tmp.InY;
this.InCb = tmp.InCb;
this.InCr = tmp.InCr;
this.OutY = tmp.OutY;
this.OutCb = tmp.OutCb;
this.OutCr = tmp.OutCr;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.YCbCrLinear();
			result.InY = this.InY;
result.InCb = this.InCb;
result.InCr = this.InCr;
result.OutY = this.OutY;
result.OutCb = this.OutCb;
result.OutCr = this.OutCr;
		   return result;
        }


	}
		

	public class OilPaintingInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 BrushSize { get;set;}

		public OilPaintingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OilPainting();
		  this.BrushSize = tmp.BrushSize;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OilPainting();
			result.BrushSize = this.BrushSize;
		   return result;
        }


	}
		

	public class BinaryDilatation3x3InPlaceActivity : AForgeActivity
	{
		
		public BinaryDilatation3x3InPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BinaryDilatation3x3();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BinaryDilatation3x3();
					   return result;
        }


	}
		

	public class SobelEdgeDetectorInPlaceActivity : AForgeActivity
	{
		public global::System.Boolean ScaleIntensity { get;set;}

		public SobelEdgeDetectorInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SobelEdgeDetector();
		  this.ScaleIntensity = tmp.ScaleIntensity;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SobelEdgeDetector();
			result.ScaleIntensity = this.ScaleIntensity;
		   return result;
        }


	}
		

	public class SharpenInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public SharpenInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Sharpen();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Sharpen();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class SepiaInPlaceActivity : AForgeActivity
	{
		
		public SepiaInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Sepia();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Sepia();
					   return result;
        }


	}
		

	public class InvertInPlaceActivity : AForgeActivity
	{
		
		public InvertInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Invert();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Invert();
					   return result;
        }


	}
		

	public class EuclideanColorFilteringInPlaceActivity : AForgeActivity
	{
		public global::System.Int16 Radius { get;set;}
public global::AForge.Imaging.RGB CenterColor { get;set;}
public global::AForge.Imaging.RGB FillColor { get;set;}
public global::System.Boolean FillOutside { get;set;}

		public EuclideanColorFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.EuclideanColorFiltering();
		  this.Radius = tmp.Radius;
this.CenterColor = tmp.CenterColor;
this.FillColor = tmp.FillColor;
this.FillOutside = tmp.FillOutside;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.EuclideanColorFiltering();
			result.Radius = this.Radius;
result.CenterColor = this.CenterColor;
result.FillColor = this.FillColor;
result.FillOutside = this.FillOutside;
		   return result;
        }


	}
		

	public class BackwardQuadrilateralTransformationInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap SourceImage { get;set;}
public global::AForge.Imaging.UnmanagedImage SourceUnmanagedImage { get;set;}
public global::System.Collections.Generic.List<global::AForge.IntPoint> DestinationQuadrilateral { get;set;}
public global::System.Boolean UseInterpolation { get;set;}

		public BackwardQuadrilateralTransformationInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BackwardQuadrilateralTransformation();
		  this.SourceImage = tmp.SourceImage;
this.SourceUnmanagedImage = tmp.SourceUnmanagedImage;
this.DestinationQuadrilateral = tmp.DestinationQuadrilateral;
this.UseInterpolation = tmp.UseInterpolation;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BackwardQuadrilateralTransformation();
			result.SourceImage = this.SourceImage;
result.SourceUnmanagedImage = this.SourceUnmanagedImage;
result.DestinationQuadrilateral = this.DestinationQuadrilateral;
result.UseInterpolation = this.UseInterpolation;
		   return result;
        }


	}
		

	public class HorizontalRunLengthSmoothingInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 MaxGapSize { get;set;}
public global::System.Boolean ProcessGapsWithImageBorders { get;set;}

		public HorizontalRunLengthSmoothingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HorizontalRunLengthSmoothing();
		  this.MaxGapSize = tmp.MaxGapSize;
this.ProcessGapsWithImageBorders = tmp.ProcessGapsWithImageBorders;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HorizontalRunLengthSmoothing();
			result.MaxGapSize = this.MaxGapSize;
result.ProcessGapsWithImageBorders = this.ProcessGapsWithImageBorders;
		   return result;
        }


	}
		

	public class Dilatation3x3InPlaceActivity : AForgeActivity
	{
		
		public Dilatation3x3InPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Dilatation3x3();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Dilatation3x3();
					   return result;
        }


	}
		

	public class YCbCrFilteringInPlaceActivity : AForgeActivity
	{
		public global::AForge.Range Y { get;set;}
public global::AForge.Range Cb { get;set;}
public global::AForge.Range Cr { get;set;}
public global::AForge.Imaging.YCbCr FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}
public global::System.Boolean UpdateY { get;set;}
public global::System.Boolean UpdateCb { get;set;}
public global::System.Boolean UpdateCr { get;set;}

		public YCbCrFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.YCbCrFiltering();
		  this.Y = tmp.Y;
this.Cb = tmp.Cb;
this.Cr = tmp.Cr;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;
this.UpdateY = tmp.UpdateY;
this.UpdateCb = tmp.UpdateCb;
this.UpdateCr = tmp.UpdateCr;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.YCbCrFiltering();
			result.Y = this.Y;
result.Cb = this.Cb;
result.Cr = this.Cr;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
result.UpdateY = this.UpdateY;
result.UpdateCb = this.UpdateCb;
result.UpdateCr = this.UpdateCr;
		   return result;
        }


	}
		

	public class BilateralSmoothingInPlaceActivity : AForgeActivity
	{
		public global::System.Boolean LimitKernelSize { get;set;}
public global::System.Boolean EnableParallelProcessing { get;set;}
public global::System.Int32 KernelSize { get;set;}
public global::System.Double SpatialFactor { get;set;}
public global::System.Double SpatialPower { get;set;}
public global::System.Double ColorFactor { get;set;}
public global::System.Double ColorPower { get;set;}

		public BilateralSmoothingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BilateralSmoothing();
		  this.LimitKernelSize = tmp.LimitKernelSize;
this.EnableParallelProcessing = tmp.EnableParallelProcessing;
this.KernelSize = tmp.KernelSize;
this.SpatialFactor = tmp.SpatialFactor;
this.SpatialPower = tmp.SpatialPower;
this.ColorFactor = tmp.ColorFactor;
this.ColorPower = tmp.ColorPower;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BilateralSmoothing();
			result.LimitKernelSize = this.LimitKernelSize;
result.EnableParallelProcessing = this.EnableParallelProcessing;
result.KernelSize = this.KernelSize;
result.SpatialFactor = this.SpatialFactor;
result.SpatialPower = this.SpatialPower;
result.ColorFactor = this.ColorFactor;
result.ColorPower = this.ColorPower;
		   return result;
        }


	}
		

	public class OpeningInPlaceActivity : AForgeActivity
	{
		
		public OpeningInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Opening();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Opening();
					   return result;
        }


	}
		

	public class DilatationInPlaceActivity : AForgeActivity
	{
		
		public DilatationInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Dilatation();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Dilatation();
					   return result;
        }


	}
		

	public class ContrastCorrectionInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 Factor { get;set;}

		public ContrastCorrectionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ContrastCorrection();
		  this.Factor = tmp.Factor;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ContrastCorrection();
			result.Factor = this.Factor;
		   return result;
        }


	}
		

	public class VerticalRunLengthSmoothingInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 MaxGapSize { get;set;}
public global::System.Boolean ProcessGapsWithImageBorders { get;set;}

		public VerticalRunLengthSmoothingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.VerticalRunLengthSmoothing();
		  this.MaxGapSize = tmp.MaxGapSize;
this.ProcessGapsWithImageBorders = tmp.ProcessGapsWithImageBorders;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.VerticalRunLengthSmoothing();
			result.MaxGapSize = this.MaxGapSize;
result.ProcessGapsWithImageBorders = this.ProcessGapsWithImageBorders;
		   return result;
        }


	}
		

	public class SaltAndPepperNoiseInPlaceActivity : AForgeActivity
	{
		public global::System.Double NoiseAmount { get;set;}

		public SaltAndPepperNoiseInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SaltAndPepperNoise();
		  this.NoiseAmount = tmp.NoiseAmount;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SaltAndPepperNoise();
			result.NoiseAmount = this.NoiseAmount;
		   return result;
        }


	}
		

	public class AdditiveNoiseInPlaceActivity : AForgeActivity
	{
		public global::AForge.Math.Random.IRandomNumberGenerator Generator { get;set;}

		public AdditiveNoiseInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.AdditiveNoise();
		  this.Generator = tmp.Generator;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.AdditiveNoise();
			result.Generator = this.Generator;
		   return result;
        }


	}
		

	public class ClosingInPlaceActivity : AForgeActivity
	{
		
		public ClosingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Closing();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Closing();
					   return result;
        }


	}
		

	public class HueModifierInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 Hue { get;set;}

		public HueModifierInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HueModifier();
		  this.Hue = tmp.Hue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HueModifier();
			result.Hue = this.Hue;
		   return result;
        }


	}
		

	public class ColorRemappingInPlaceActivity : AForgeActivity
	{
		public global::System.Byte[] RedMap { get;set;}
public global::System.Byte[] GreenMap { get;set;}
public global::System.Byte[] BlueMap { get;set;}
public global::System.Byte[] GrayMap { get;set;}

		public ColorRemappingInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ColorRemapping();
		  this.RedMap = tmp.RedMap;
this.GreenMap = tmp.GreenMap;
this.BlueMap = tmp.BlueMap;
this.GrayMap = tmp.GrayMap;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ColorRemapping();
			result.RedMap = this.RedMap;
result.GreenMap = this.GreenMap;
result.BlueMap = this.BlueMap;
result.GrayMap = this.GrayMap;
		   return result;
        }


	}
		

	public class OrderedDitheringInPlaceActivity : AForgeActivity
	{
		
		public OrderedDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OrderedDithering();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OrderedDithering();
					   return result;
        }


	}
		

	public class BayerDitheringInPlaceActivity : AForgeActivity
	{
		
		public BayerDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BayerDithering();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BayerDithering();
					   return result;
        }


	}
		

	public class ErosionInPlaceActivity : AForgeActivity
	{
		
		public ErosionInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Erosion();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Erosion();
					   return result;
        }


	}
		

	public class BottomHatInPlaceActivity : AForgeActivity
	{
		
		public BottomHatInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BottomHat();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BottomHat();
					   return result;
        }


	}
		

	public class ContrastStretchInPlaceActivity : AForgeActivity
	{
		
		public ContrastStretchInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ContrastStretch();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ContrastStretch();
					   return result;
        }


	}
		

	public class ChannelFilteringInPlaceActivity : AForgeActivity
	{
		public global::AForge.IntRange Red { get;set;}
public global::System.Byte FillRed { get;set;}
public global::AForge.IntRange Green { get;set;}
public global::System.Byte FillGreen { get;set;}
public global::AForge.IntRange Blue { get;set;}
public global::System.Byte FillBlue { get;set;}
public global::System.Boolean RedFillOutsideRange { get;set;}
public global::System.Boolean GreenFillOutsideRange { get;set;}
public global::System.Boolean BlueFillOutsideRange { get;set;}

		public ChannelFilteringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ChannelFiltering();
		  this.Red = tmp.Red;
this.FillRed = tmp.FillRed;
this.Green = tmp.Green;
this.FillGreen = tmp.FillGreen;
this.Blue = tmp.Blue;
this.FillBlue = tmp.FillBlue;
this.RedFillOutsideRange = tmp.RedFillOutsideRange;
this.GreenFillOutsideRange = tmp.GreenFillOutsideRange;
this.BlueFillOutsideRange = tmp.BlueFillOutsideRange;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ChannelFiltering();
			result.Red = this.Red;
result.FillRed = this.FillRed;
result.Green = this.Green;
result.FillGreen = this.FillGreen;
result.Blue = this.Blue;
result.FillBlue = this.FillBlue;
result.RedFillOutsideRange = this.RedFillOutsideRange;
result.GreenFillOutsideRange = this.GreenFillOutsideRange;
result.BlueFillOutsideRange = this.BlueFillOutsideRange;
		   return result;
        }


	}
		

	public class MoveTowardsInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 StepSize { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MoveTowardsInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.MoveTowards();
		  this.StepSize = tmp.StepSize;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.MoveTowards();
			result.StepSize = this.StepSize;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class PixellateInPlaceActivity : AForgeActivity
	{
		public global::System.Int32 PixelWidth { get;set;}
public global::System.Int32 PixelHeight { get;set;}
public global::System.Int32 PixelSize { get;set;}

		public PixellateInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Pixellate();
		  this.PixelWidth = tmp.PixelWidth;
this.PixelHeight = tmp.PixelHeight;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Pixellate();
			result.PixelWidth = this.PixelWidth;
result.PixelHeight = this.PixelHeight;
result.PixelSize = this.PixelSize;
		   return result;
        }


	}
		

	public class CannyEdgeDetectorInPlaceActivity : AForgeActivity
	{
		public global::System.Byte LowThreshold { get;set;}
public global::System.Byte HighThreshold { get;set;}
public global::System.Double GaussianSigma { get;set;}
public global::System.Int32 GaussianSize { get;set;}

		public CannyEdgeDetectorInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.CannyEdgeDetector();
		  this.LowThreshold = tmp.LowThreshold;
this.HighThreshold = tmp.HighThreshold;
this.GaussianSigma = tmp.GaussianSigma;
this.GaussianSize = tmp.GaussianSize;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.CannyEdgeDetector();
			result.LowThreshold = this.LowThreshold;
result.HighThreshold = this.HighThreshold;
result.GaussianSigma = this.GaussianSigma;
result.GaussianSize = this.GaussianSize;
		   return result;
        }


	}
		

	public class LevelsLinear16bppInPlaceActivity : AForgeActivity
	{
		public global::AForge.IntRange InRed { get;set;}
public global::AForge.IntRange InGreen { get;set;}
public global::AForge.IntRange InBlue { get;set;}
public global::AForge.IntRange InGray { get;set;}
public global::AForge.IntRange Input { get;set;}
public global::AForge.IntRange OutRed { get;set;}
public global::AForge.IntRange OutGreen { get;set;}
public global::AForge.IntRange OutBlue { get;set;}
public global::AForge.IntRange OutGray { get;set;}
public global::AForge.IntRange Output { get;set;}

		public LevelsLinear16bppInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.LevelsLinear16bpp();
		  this.InRed = tmp.InRed;
this.InGreen = tmp.InGreen;
this.InBlue = tmp.InBlue;
this.InGray = tmp.InGray;
this.OutRed = tmp.OutRed;
this.OutGreen = tmp.OutGreen;
this.OutBlue = tmp.OutBlue;
this.OutGray = tmp.OutGray;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.LevelsLinear16bpp();
			result.InRed = this.InRed;
result.InGreen = this.InGreen;
result.InBlue = this.InBlue;
result.InGray = this.InGray;
result.Input = this.Input;
result.OutRed = this.OutRed;
result.OutGreen = this.OutGreen;
result.OutBlue = this.OutBlue;
result.OutGray = this.OutGray;
result.Output = this.Output;
		   return result;
        }


	}
		

	public class SierraDitheringInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public SierraDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SierraDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SierraDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class BurkesDitheringInPlaceActivity : AForgeActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public BurkesDitheringInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BurkesDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BurkesDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
		

	public class SubtractInPlaceActivity : AForgeActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public SubtractInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Subtract();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Subtract();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		

	public class StereoAnaglyphInPlaceActivity : AForgeActivity
	{
		public global::AForge.Imaging.Filters.StereoAnaglyph.Algorithm AnaglyphAlgorithm { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public StereoAnaglyphInPlaceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.StereoAnaglyph();
		  this.AnaglyphAlgorithm = tmp.AnaglyphAlgorithm;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.StereoAnaglyph();
			result.AnaglyphAlgorithm = this.AnaglyphAlgorithm;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
		 
			public class AdaptiveSmoothingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double Factor { get;set;}

		public AdaptiveSmoothingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.AdaptiveSmoothing();
		  this.Factor = tmp.Factor;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.AdaptiveSmoothing();
			result.Factor = this.Factor;
		   return result;
        }


	}
			
			 
			public class AddActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public AddActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Add();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Add();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class AdditiveNoiseActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.Math.Random.IRandomNumberGenerator Generator { get;set;}

		public AdditiveNoiseActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.AdditiveNoise();
		  this.Generator = tmp.Generator;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.AdditiveNoise();
			result.Generator = this.Generator;
		   return result;
        }


	}
			
			 
			public class BackwardQuadrilateralTransformationActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap SourceImage { get;set;}
public global::AForge.Imaging.UnmanagedImage SourceUnmanagedImage { get;set;}
public global::System.Collections.Generic.List<global::AForge.IntPoint> DestinationQuadrilateral { get;set;}
public global::System.Boolean UseInterpolation { get;set;}

		public BackwardQuadrilateralTransformationActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BackwardQuadrilateralTransformation();
		  this.SourceImage = tmp.SourceImage;
this.SourceUnmanagedImage = tmp.SourceUnmanagedImage;
this.DestinationQuadrilateral = tmp.DestinationQuadrilateral;
this.UseInterpolation = tmp.UseInterpolation;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BackwardQuadrilateralTransformation();
			result.SourceImage = this.SourceImage;
result.SourceUnmanagedImage = this.SourceUnmanagedImage;
result.DestinationQuadrilateral = this.DestinationQuadrilateral;
result.UseInterpolation = this.UseInterpolation;
		   return result;
        }


	}
			
			 
			public class BayerDitheringActivity : AForgeCreateTransformationActivity
	{
		
		public BayerDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BayerDithering();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BayerDithering();
					   return result;
        }


	}
			
			 
			public class BilateralSmoothingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Boolean LimitKernelSize { get;set;}
public global::System.Boolean EnableParallelProcessing { get;set;}
public global::System.Int32 KernelSize { get;set;}
public global::System.Double SpatialFactor { get;set;}
public global::System.Double SpatialPower { get;set;}
public global::System.Double ColorFactor { get;set;}
public global::System.Double ColorPower { get;set;}

		public BilateralSmoothingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BilateralSmoothing();
		  this.LimitKernelSize = tmp.LimitKernelSize;
this.EnableParallelProcessing = tmp.EnableParallelProcessing;
this.KernelSize = tmp.KernelSize;
this.SpatialFactor = tmp.SpatialFactor;
this.SpatialPower = tmp.SpatialPower;
this.ColorFactor = tmp.ColorFactor;
this.ColorPower = tmp.ColorPower;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BilateralSmoothing();
			result.LimitKernelSize = this.LimitKernelSize;
result.EnableParallelProcessing = this.EnableParallelProcessing;
result.KernelSize = this.KernelSize;
result.SpatialFactor = this.SpatialFactor;
result.SpatialPower = this.SpatialPower;
result.ColorFactor = this.ColorFactor;
result.ColorPower = this.ColorPower;
		   return result;
        }


	}
			
			 
			public class BinaryDilatation3x3Activity : AForgeCreateTransformationActivity
	{
		
		public BinaryDilatation3x3Activity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BinaryDilatation3x3();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BinaryDilatation3x3();
					   return result;
        }


	}
			
			 
			public class BinaryErosion3x3Activity : AForgeCreateTransformationActivity
	{
		
		public BinaryErosion3x3Activity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BinaryErosion3x3();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BinaryErosion3x3();
					   return result;
        }


	}
			
			 
			public class BlobsFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Boolean CoupledSizeFiltering { get;set;}
public global::System.Int32 MinWidth { get;set;}
public global::System.Int32 MinHeight { get;set;}
public global::System.Int32 MaxWidth { get;set;}
public global::System.Int32 MaxHeight { get;set;}
public global::AForge.Imaging.IBlobsFilter BlobsFilter { get;set;}

		public BlobsFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BlobsFiltering();
		  this.CoupledSizeFiltering = tmp.CoupledSizeFiltering;
this.MinWidth = tmp.MinWidth;
this.MinHeight = tmp.MinHeight;
this.MaxWidth = tmp.MaxWidth;
this.MaxHeight = tmp.MaxHeight;
this.BlobsFilter = tmp.BlobsFilter;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BlobsFiltering();
			result.CoupledSizeFiltering = this.CoupledSizeFiltering;
result.MinWidth = this.MinWidth;
result.MinHeight = this.MinHeight;
result.MaxWidth = this.MaxWidth;
result.MaxHeight = this.MaxHeight;
result.BlobsFilter = this.BlobsFilter;
		   return result;
        }


	}
			
			 
			public class BlurActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public BlurActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Blur();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Blur();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class BottomHatActivity : AForgeCreateTransformationActivity
	{
		
		public BottomHatActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BottomHat();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BottomHat();
					   return result;
        }


	}
			
			 
			public class BradleyLocalThresholdingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 WindowSize { get;set;}
public global::System.Single PixelBrightnessDifferenceLimit { get;set;}

		public BradleyLocalThresholdingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BradleyLocalThresholding();
		  this.WindowSize = tmp.WindowSize;
this.PixelBrightnessDifferenceLimit = tmp.PixelBrightnessDifferenceLimit;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BradleyLocalThresholding();
			result.WindowSize = this.WindowSize;
result.PixelBrightnessDifferenceLimit = this.PixelBrightnessDifferenceLimit;
		   return result;
        }


	}
			
			 
			public class BrightnessCorrectionActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 AdjustValue { get;set;}

		public BrightnessCorrectionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BrightnessCorrection();
		  this.AdjustValue = tmp.AdjustValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BrightnessCorrection();
			result.AdjustValue = this.AdjustValue;
		   return result;
        }


	}
			
			 
			public class BurkesDitheringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public BurkesDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.BurkesDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.BurkesDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class CannyEdgeDetectorActivity : AForgeCreateTransformationActivity
	{
		public global::System.Byte LowThreshold { get;set;}
public global::System.Byte HighThreshold { get;set;}
public global::System.Double GaussianSigma { get;set;}
public global::System.Int32 GaussianSize { get;set;}

		public CannyEdgeDetectorActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.CannyEdgeDetector();
		  this.LowThreshold = tmp.LowThreshold;
this.HighThreshold = tmp.HighThreshold;
this.GaussianSigma = tmp.GaussianSigma;
this.GaussianSize = tmp.GaussianSize;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.CannyEdgeDetector();
			result.LowThreshold = this.LowThreshold;
result.HighThreshold = this.HighThreshold;
result.GaussianSigma = this.GaussianSigma;
result.GaussianSize = this.GaussianSize;
		   return result;
        }


	}
			
			 
			public class ChannelFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.IntRange Red { get;set;}
public global::System.Byte FillRed { get;set;}
public global::AForge.IntRange Green { get;set;}
public global::System.Byte FillGreen { get;set;}
public global::AForge.IntRange Blue { get;set;}
public global::System.Byte FillBlue { get;set;}
public global::System.Boolean RedFillOutsideRange { get;set;}
public global::System.Boolean GreenFillOutsideRange { get;set;}
public global::System.Boolean BlueFillOutsideRange { get;set;}

		public ChannelFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ChannelFiltering();
		  this.Red = tmp.Red;
this.FillRed = tmp.FillRed;
this.Green = tmp.Green;
this.FillGreen = tmp.FillGreen;
this.Blue = tmp.Blue;
this.FillBlue = tmp.FillBlue;
this.RedFillOutsideRange = tmp.RedFillOutsideRange;
this.GreenFillOutsideRange = tmp.GreenFillOutsideRange;
this.BlueFillOutsideRange = tmp.BlueFillOutsideRange;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ChannelFiltering();
			result.Red = this.Red;
result.FillRed = this.FillRed;
result.Green = this.Green;
result.FillGreen = this.FillGreen;
result.Blue = this.Blue;
result.FillBlue = this.FillBlue;
result.RedFillOutsideRange = this.RedFillOutsideRange;
result.GreenFillOutsideRange = this.GreenFillOutsideRange;
result.BlueFillOutsideRange = this.BlueFillOutsideRange;
		   return result;
        }


	}
			
			 
			public class ClosingActivity : AForgeCreateTransformationActivity
	{
		
		public ClosingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Closing();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Closing();
					   return result;
        }


	}
			
			 
			public class ColorFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.IntRange Red { get;set;}
public global::AForge.IntRange Green { get;set;}
public global::AForge.IntRange Blue { get;set;}
public global::AForge.Imaging.RGB FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}

		public ColorFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ColorFiltering();
		  this.Red = tmp.Red;
this.Green = tmp.Green;
this.Blue = tmp.Blue;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ColorFiltering();
			result.Red = this.Red;
result.Green = this.Green;
result.Blue = this.Blue;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
		   return result;
        }


	}
			
			 
			public class ColorRemappingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Byte[] RedMap { get;set;}
public global::System.Byte[] GreenMap { get;set;}
public global::System.Byte[] BlueMap { get;set;}
public global::System.Byte[] GrayMap { get;set;}

		public ColorRemappingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ColorRemapping();
		  this.RedMap = tmp.RedMap;
this.GreenMap = tmp.GreenMap;
this.BlueMap = tmp.BlueMap;
this.GrayMap = tmp.GrayMap;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ColorRemapping();
			result.RedMap = this.RedMap;
result.GreenMap = this.GreenMap;
result.BlueMap = this.BlueMap;
result.GrayMap = this.GrayMap;
		   return result;
        }


	}
			
			 
			public class ConservativeSmoothingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 KernelSize { get;set;}

		public ConservativeSmoothingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ConservativeSmoothing();
		  this.KernelSize = tmp.KernelSize;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ConservativeSmoothing();
			result.KernelSize = this.KernelSize;
		   return result;
        }


	}
			
			 
			public class ContrastCorrectionActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 Factor { get;set;}

		public ContrastCorrectionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ContrastCorrection();
		  this.Factor = tmp.Factor;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ContrastCorrection();
			result.Factor = this.Factor;
		   return result;
        }


	}
			
			 
			public class ContrastStretchActivity : AForgeCreateTransformationActivity
	{
		
		public ContrastStretchActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ContrastStretch();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ContrastStretch();
					   return result;
        }


	}
			
			 
			public class DifferenceActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public DifferenceActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Difference();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Difference();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class DifferenceEdgeDetectorActivity : AForgeCreateTransformationActivity
	{
		
		public DifferenceEdgeDetectorActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.DifferenceEdgeDetector();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.DifferenceEdgeDetector();
					   return result;
        }


	}
			
			 
			public class DilatationActivity : AForgeCreateTransformationActivity
	{
		
		public DilatationActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Dilatation();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Dilatation();
					   return result;
        }


	}
			
			 
			public class Dilatation3x3Activity : AForgeCreateTransformationActivity
	{
		
		public Dilatation3x3Activity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Dilatation3x3();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Dilatation3x3();
					   return result;
        }


	}
			
			 
			public class EdgesActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public EdgesActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Edges();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Edges();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class ErosionActivity : AForgeCreateTransformationActivity
	{
		
		public ErosionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Erosion();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Erosion();
					   return result;
        }


	}
			
			 
			public class Erosion3x3Activity : AForgeCreateTransformationActivity
	{
		
		public Erosion3x3Activity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Erosion3x3();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Erosion3x3();
					   return result;
        }


	}
			
			 
			public class EuclideanColorFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int16 Radius { get;set;}
public global::AForge.Imaging.RGB CenterColor { get;set;}
public global::AForge.Imaging.RGB FillColor { get;set;}
public global::System.Boolean FillOutside { get;set;}

		public EuclideanColorFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.EuclideanColorFiltering();
		  this.Radius = tmp.Radius;
this.CenterColor = tmp.CenterColor;
this.FillColor = tmp.FillColor;
this.FillOutside = tmp.FillOutside;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.EuclideanColorFiltering();
			result.Radius = this.Radius;
result.CenterColor = this.CenterColor;
result.FillColor = this.FillColor;
result.FillOutside = this.FillOutside;
		   return result;
        }


	}
			
			 
			public class FillHolesActivity : AForgeCreateTransformationActivity
	{
		public global::System.Boolean CoupledSizeFiltering { get;set;}
public global::System.Int32 MaxHoleWidth { get;set;}
public global::System.Int32 MaxHoleHeight { get;set;}

		public FillHolesActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FillHoles();
		  this.CoupledSizeFiltering = tmp.CoupledSizeFiltering;
this.MaxHoleWidth = tmp.MaxHoleWidth;
this.MaxHoleHeight = tmp.MaxHoleHeight;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FillHoles();
			result.CoupledSizeFiltering = this.CoupledSizeFiltering;
result.MaxHoleWidth = this.MaxHoleWidth;
result.MaxHoleHeight = this.MaxHoleHeight;
		   return result;
        }


	}
			
			 
			public class FlatFieldCorrectionActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap BackgoundImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedBackgoundImage { get;set;}

		public FlatFieldCorrectionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FlatFieldCorrection();
		  this.BackgoundImage = tmp.BackgoundImage;
this.UnmanagedBackgoundImage = tmp.UnmanagedBackgoundImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FlatFieldCorrection();
			result.BackgoundImage = this.BackgoundImage;
result.UnmanagedBackgoundImage = this.UnmanagedBackgoundImage;
		   return result;
        }


	}
			
			 
			public class FloydSteinbergDitheringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public FloydSteinbergDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.FloydSteinbergDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.FloydSteinbergDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class GammaCorrectionActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double Gamma { get;set;}

		public GammaCorrectionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GammaCorrection();
		  this.Gamma = tmp.Gamma;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GammaCorrection();
			result.Gamma = this.Gamma;
		   return result;
        }


	}
			
			 
			public class GaussianBlurActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double Sigma { get;set;}
public global::System.Int32 Size { get;set;}
public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public GaussianBlurActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GaussianBlur();
		  this.Sigma = tmp.Sigma;
this.Size = tmp.Size;
this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GaussianBlur();
			result.Sigma = this.Sigma;
result.Size = this.Size;
result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class GaussianSharpenActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double Sigma { get;set;}
public global::System.Int32 Size { get;set;}
public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public GaussianSharpenActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.GaussianSharpen();
		  this.Sigma = tmp.Sigma;
this.Size = tmp.Size;
this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.GaussianSharpen();
			result.Sigma = this.Sigma;
result.Size = this.Size;
result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class HistogramEqualizationActivity : AForgeCreateTransformationActivity
	{
		
		public HistogramEqualizationActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HistogramEqualization();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HistogramEqualization();
					   return result;
        }


	}
			
			 
			public class HomogenityEdgeDetectorActivity : AForgeCreateTransformationActivity
	{
		
		public HomogenityEdgeDetectorActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HomogenityEdgeDetector();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HomogenityEdgeDetector();
					   return result;
        }


	}
			
			 
			public class HorizontalRunLengthSmoothingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 MaxGapSize { get;set;}
public global::System.Boolean ProcessGapsWithImageBorders { get;set;}

		public HorizontalRunLengthSmoothingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HorizontalRunLengthSmoothing();
		  this.MaxGapSize = tmp.MaxGapSize;
this.ProcessGapsWithImageBorders = tmp.ProcessGapsWithImageBorders;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HorizontalRunLengthSmoothing();
			result.MaxGapSize = this.MaxGapSize;
result.ProcessGapsWithImageBorders = this.ProcessGapsWithImageBorders;
		   return result;
        }


	}
			
			 
			public class HSLFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.IntRange Hue { get;set;}
public global::AForge.Range Saturation { get;set;}
public global::AForge.Range Luminance { get;set;}
public global::AForge.Imaging.HSL FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}
public global::System.Boolean UpdateHue { get;set;}
public global::System.Boolean UpdateSaturation { get;set;}
public global::System.Boolean UpdateLuminance { get;set;}

		public HSLFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HSLFiltering();
		  this.Hue = tmp.Hue;
this.Saturation = tmp.Saturation;
this.Luminance = tmp.Luminance;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;
this.UpdateHue = tmp.UpdateHue;
this.UpdateSaturation = tmp.UpdateSaturation;
this.UpdateLuminance = tmp.UpdateLuminance;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HSLFiltering();
			result.Hue = this.Hue;
result.Saturation = this.Saturation;
result.Luminance = this.Luminance;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
result.UpdateHue = this.UpdateHue;
result.UpdateSaturation = this.UpdateSaturation;
result.UpdateLuminance = this.UpdateLuminance;
		   return result;
        }


	}
			
			 
			public class HSLLinearActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.Range InLuminance { get;set;}
public global::AForge.Range OutLuminance { get;set;}
public global::AForge.Range InSaturation { get;set;}
public global::AForge.Range OutSaturation { get;set;}

		public HSLLinearActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HSLLinear();
		  this.InLuminance = tmp.InLuminance;
this.OutLuminance = tmp.OutLuminance;
this.InSaturation = tmp.InSaturation;
this.OutSaturation = tmp.OutSaturation;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HSLLinear();
			result.InLuminance = this.InLuminance;
result.OutLuminance = this.OutLuminance;
result.InSaturation = this.InSaturation;
result.OutSaturation = this.OutSaturation;
		   return result;
        }


	}
			
			 
			public class HueModifierActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 Hue { get;set;}

		public HueModifierActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.HueModifier();
		  this.Hue = tmp.Hue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.HueModifier();
			result.Hue = this.Hue;
		   return result;
        }


	}
			
			 
			public class IntersectActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public IntersectActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Intersect();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Intersect();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class InvertActivity : AForgeCreateTransformationActivity
	{
		
		public InvertActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Invert();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Invert();
					   return result;
        }


	}
			
			 
			public class IterativeThresholdActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 MinimumError { get;set;}
public global::System.Int32 ThresholdValue { get;set;}

		public IterativeThresholdActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.IterativeThreshold();
		  this.MinimumError = tmp.MinimumError;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.IterativeThreshold();
			result.MinimumError = this.MinimumError;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class JarvisJudiceNinkeDitheringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public JarvisJudiceNinkeDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.JarvisJudiceNinkeDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.JarvisJudiceNinkeDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class JitterActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 Radius { get;set;}

		public JitterActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Jitter();
		  this.Radius = tmp.Radius;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Jitter();
			result.Radius = this.Radius;
		   return result;
        }


	}
			
			 
			public class LevelsLinearActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.IntRange InRed { get;set;}
public global::AForge.IntRange InGreen { get;set;}
public global::AForge.IntRange InBlue { get;set;}
public global::AForge.IntRange InGray { get;set;}
public global::AForge.IntRange Input { get;set;}
public global::AForge.IntRange OutRed { get;set;}
public global::AForge.IntRange OutGreen { get;set;}
public global::AForge.IntRange OutBlue { get;set;}
public global::AForge.IntRange OutGray { get;set;}
public global::AForge.IntRange Output { get;set;}

		public LevelsLinearActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.LevelsLinear();
		  this.InRed = tmp.InRed;
this.InGreen = tmp.InGreen;
this.InBlue = tmp.InBlue;
this.InGray = tmp.InGray;
this.OutRed = tmp.OutRed;
this.OutGreen = tmp.OutGreen;
this.OutBlue = tmp.OutBlue;
this.OutGray = tmp.OutGray;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.LevelsLinear();
			result.InRed = this.InRed;
result.InGreen = this.InGreen;
result.InBlue = this.InBlue;
result.InGray = this.InGray;
result.Input = this.Input;
result.OutRed = this.OutRed;
result.OutGreen = this.OutGreen;
result.OutBlue = this.OutBlue;
result.OutGray = this.OutGray;
result.Output = this.Output;
		   return result;
        }


	}
			
			 
			public class LevelsLinear16bppActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.IntRange InRed { get;set;}
public global::AForge.IntRange InGreen { get;set;}
public global::AForge.IntRange InBlue { get;set;}
public global::AForge.IntRange InGray { get;set;}
public global::AForge.IntRange Input { get;set;}
public global::AForge.IntRange OutRed { get;set;}
public global::AForge.IntRange OutGreen { get;set;}
public global::AForge.IntRange OutBlue { get;set;}
public global::AForge.IntRange OutGray { get;set;}
public global::AForge.IntRange Output { get;set;}

		public LevelsLinear16bppActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.LevelsLinear16bpp();
		  this.InRed = tmp.InRed;
this.InGreen = tmp.InGreen;
this.InBlue = tmp.InBlue;
this.InGray = tmp.InGray;
this.OutRed = tmp.OutRed;
this.OutGreen = tmp.OutGreen;
this.OutBlue = tmp.OutBlue;
this.OutGray = tmp.OutGray;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.LevelsLinear16bpp();
			result.InRed = this.InRed;
result.InGreen = this.InGreen;
result.InBlue = this.InBlue;
result.InGray = this.InGray;
result.Input = this.Input;
result.OutRed = this.OutRed;
result.OutGreen = this.OutGreen;
result.OutBlue = this.OutBlue;
result.OutGray = this.OutGray;
result.Output = this.Output;
		   return result;
        }


	}
			
			 
			public class MeanActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public MeanActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Mean();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Mean();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class MedianActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 Size { get;set;}

		public MedianActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Median();
		  this.Size = tmp.Size;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Median();
			result.Size = this.Size;
		   return result;
        }


	}
			
			 
			public class MergeActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MergeActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Merge();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Merge();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class MorphActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double SourcePercent { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MorphActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Morph();
		  this.SourcePercent = tmp.SourcePercent;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Morph();
			result.SourcePercent = this.SourcePercent;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class MoveTowardsActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 StepSize { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public MoveTowardsActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.MoveTowards();
		  this.StepSize = tmp.StepSize;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.MoveTowards();
			result.StepSize = this.StepSize;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class OilPaintingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 BrushSize { get;set;}

		public OilPaintingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OilPainting();
		  this.BrushSize = tmp.BrushSize;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OilPainting();
			result.BrushSize = this.BrushSize;
		   return result;
        }


	}
			
			 
			public class OpeningActivity : AForgeCreateTransformationActivity
	{
		
		public OpeningActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Opening();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Opening();
					   return result;
        }


	}
			
			 
			public class OrderedDitheringActivity : AForgeCreateTransformationActivity
	{
		
		public OrderedDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OrderedDithering();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OrderedDithering();
					   return result;
        }


	}
			
			 
			public class OtsuThresholdActivity : AForgeCreateTransformationActivity
	{
		
		public OtsuThresholdActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.OtsuThreshold();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.OtsuThreshold();
					   return result;
        }


	}
			
			 
			public class PixellateActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 PixelWidth { get;set;}
public global::System.Int32 PixelHeight { get;set;}
public global::System.Int32 PixelSize { get;set;}

		public PixellateActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Pixellate();
		  this.PixelWidth = tmp.PixelWidth;
this.PixelHeight = tmp.PixelHeight;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Pixellate();
			result.PixelWidth = this.PixelWidth;
result.PixelHeight = this.PixelHeight;
result.PixelSize = this.PixelSize;
		   return result;
        }


	}
			
			 
			public class PointedColorFloodFillActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Color Tolerance { get;set;}
public global::System.Drawing.Color FillColor { get;set;}
public global::AForge.IntPoint StartingPoint { get;set;}

		public PointedColorFloodFillActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.PointedColorFloodFill();
		  this.Tolerance = tmp.Tolerance;
this.FillColor = tmp.FillColor;
this.StartingPoint = tmp.StartingPoint;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.PointedColorFloodFill();
			result.Tolerance = this.Tolerance;
result.FillColor = this.FillColor;
result.StartingPoint = this.StartingPoint;
		   return result;
        }


	}
			
			 
			public class PointedMeanFloodFillActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Color Tolerance { get;set;}
public global::AForge.IntPoint StartingPoint { get;set;}

		public PointedMeanFloodFillActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.PointedMeanFloodFill();
		  this.Tolerance = tmp.Tolerance;
this.StartingPoint = tmp.StartingPoint;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.PointedMeanFloodFill();
			result.Tolerance = this.Tolerance;
result.StartingPoint = this.StartingPoint;
		   return result;
        }


	}
			
			 
			public class RotateChannelsActivity : AForgeCreateTransformationActivity
	{
		
		public RotateChannelsActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.RotateChannels();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.RotateChannels();
					   return result;
        }


	}
			
			 
			public class SaltAndPepperNoiseActivity : AForgeCreateTransformationActivity
	{
		public global::System.Double NoiseAmount { get;set;}

		public SaltAndPepperNoiseActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SaltAndPepperNoise();
		  this.NoiseAmount = tmp.NoiseAmount;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SaltAndPepperNoise();
			result.NoiseAmount = this.NoiseAmount;
		   return result;
        }


	}
			
			 
			public class SaturationCorrectionActivity : AForgeCreateTransformationActivity
	{
		public global::System.Single AdjustValue { get;set;}

		public SaturationCorrectionActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SaturationCorrection();
		  this.AdjustValue = tmp.AdjustValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SaturationCorrection();
			result.AdjustValue = this.AdjustValue;
		   return result;
        }


	}
			
			 
			public class SepiaActivity : AForgeCreateTransformationActivity
	{
		
		public SepiaActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Sepia();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Sepia();
					   return result;
        }


	}
			
			 
			public class SharpenActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public SharpenActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Sharpen();
		  this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Sharpen();
			result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
			
			 
			public class SierraDitheringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public SierraDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SierraDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SierraDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class SimplePosterizationActivity : AForgeCreateTransformationActivity
	{
		public global::System.Byte PosterizationInterval { get;set;}
public global::AForge.Imaging.Filters.SimplePosterization.PosterizationFillingType FillingType { get;set;}

		public SimplePosterizationActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SimplePosterization();
		  this.PosterizationInterval = tmp.PosterizationInterval;
this.FillingType = tmp.FillingType;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SimplePosterization();
			result.PosterizationInterval = this.PosterizationInterval;
result.FillingType = this.FillingType;
		   return result;
        }


	}
			
			 
			public class SimpleSkeletonizationActivity : AForgeCreateTransformationActivity
	{
		public global::System.Byte Background { get;set;}
public global::System.Byte Foreground { get;set;}

		public SimpleSkeletonizationActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SimpleSkeletonization();
		  this.Background = tmp.Background;
this.Foreground = tmp.Foreground;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SimpleSkeletonization();
			result.Background = this.Background;
result.Foreground = this.Foreground;
		   return result;
        }


	}
			
			 
			public class SISThresholdActivity : AForgeCreateTransformationActivity
	{
		
		public SISThresholdActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SISThreshold();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SISThreshold();
					   return result;
        }


	}
			
			 
			public class SobelEdgeDetectorActivity : AForgeCreateTransformationActivity
	{
		public global::System.Boolean ScaleIntensity { get;set;}

		public SobelEdgeDetectorActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.SobelEdgeDetector();
		  this.ScaleIntensity = tmp.ScaleIntensity;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.SobelEdgeDetector();
			result.ScaleIntensity = this.ScaleIntensity;
		   return result;
        }


	}
			
			 
			public class StereoAnaglyphActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.Imaging.Filters.StereoAnaglyph.Algorithm AnaglyphAlgorithm { get;set;}
public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public StereoAnaglyphActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.StereoAnaglyph();
		  this.AnaglyphAlgorithm = tmp.AnaglyphAlgorithm;
this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.StereoAnaglyph();
			result.AnaglyphAlgorithm = this.AnaglyphAlgorithm;
result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class StuckiDitheringActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32[][] Coefficients { get;set;}
public global::System.Byte ThresholdValue { get;set;}

		public StuckiDitheringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.StuckiDithering();
		  this.Coefficients = tmp.Coefficients;
this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.StuckiDithering();
			result.Coefficients = this.Coefficients;
result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class SubtractActivity : AForgeCreateTransformationActivity
	{
		public global::System.Drawing.Bitmap OverlayImage { get;set;}
public global::AForge.Imaging.UnmanagedImage UnmanagedOverlayImage { get;set;}

		public SubtractActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Subtract();
		  this.OverlayImage = tmp.OverlayImage;
this.UnmanagedOverlayImage = tmp.UnmanagedOverlayImage;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Subtract();
			result.OverlayImage = this.OverlayImage;
result.UnmanagedOverlayImage = this.UnmanagedOverlayImage;
		   return result;
        }


	}
			
			 
			public class ThresholdActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 ThresholdValue { get;set;}

		public ThresholdActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.Threshold();
		  this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.Threshold();
			result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class ThresholdWithCarryActivity : AForgeCreateTransformationActivity
	{
		public global::System.Byte ThresholdValue { get;set;}

		public ThresholdWithCarryActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.ThresholdWithCarry();
		  this.ThresholdValue = tmp.ThresholdValue;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.ThresholdWithCarry();
			result.ThresholdValue = this.ThresholdValue;
		   return result;
        }


	}
			
			 
			public class TopHatActivity : AForgeCreateTransformationActivity
	{
		
		public TopHatActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.TopHat();
		  
		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.TopHat();
					   return result;
        }


	}
			
			 
			public class VerticalRunLengthSmoothingActivity : AForgeCreateTransformationActivity
	{
		public global::System.Int32 MaxGapSize { get;set;}
public global::System.Boolean ProcessGapsWithImageBorders { get;set;}

		public VerticalRunLengthSmoothingActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.VerticalRunLengthSmoothing();
		  this.MaxGapSize = tmp.MaxGapSize;
this.ProcessGapsWithImageBorders = tmp.ProcessGapsWithImageBorders;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.VerticalRunLengthSmoothing();
			result.MaxGapSize = this.MaxGapSize;
result.ProcessGapsWithImageBorders = this.ProcessGapsWithImageBorders;
		   return result;
        }


	}
			
			 
			public class YCbCrFilteringActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.Range Y { get;set;}
public global::AForge.Range Cb { get;set;}
public global::AForge.Range Cr { get;set;}
public global::AForge.Imaging.YCbCr FillColor { get;set;}
public global::System.Boolean FillOutsideRange { get;set;}
public global::System.Boolean UpdateY { get;set;}
public global::System.Boolean UpdateCb { get;set;}
public global::System.Boolean UpdateCr { get;set;}

		public YCbCrFilteringActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.YCbCrFiltering();
		  this.Y = tmp.Y;
this.Cb = tmp.Cb;
this.Cr = tmp.Cr;
this.FillColor = tmp.FillColor;
this.FillOutsideRange = tmp.FillOutsideRange;
this.UpdateY = tmp.UpdateY;
this.UpdateCb = tmp.UpdateCb;
this.UpdateCr = tmp.UpdateCr;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.YCbCrFiltering();
			result.Y = this.Y;
result.Cb = this.Cb;
result.Cr = this.Cr;
result.FillColor = this.FillColor;
result.FillOutsideRange = this.FillOutsideRange;
result.UpdateY = this.UpdateY;
result.UpdateCb = this.UpdateCb;
result.UpdateCr = this.UpdateCr;
		   return result;
        }


	}
			
			 
			public class YCbCrLinearActivity : AForgeCreateTransformationActivity
	{
		public global::AForge.Range InY { get;set;}
public global::AForge.Range InCb { get;set;}
public global::AForge.Range InCr { get;set;}
public global::AForge.Range OutY { get;set;}
public global::AForge.Range OutCb { get;set;}
public global::AForge.Range OutCr { get;set;}

		public YCbCrLinearActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::AForge.Imaging.Filters.YCbCrLinear();
		  this.InY = tmp.InY;
this.InCb = tmp.InCb;
this.InCr = tmp.InCr;
this.OutY = tmp.OutY;
this.OutCb = tmp.OutCb;
this.OutCr = tmp.OutCr;

		}

		protected override global::AForge.Imaging.Filters.IFilter GetFilter(ActivityContext context)
        {
			var result = new global::AForge.Imaging.Filters.YCbCrLinear();
			result.InY = this.InY;
result.InCb = this.InCb;
result.InCr = this.InCr;
result.OutY = this.OutY;
result.OutCb = this.OutCb;
result.OutCr = this.OutCr;
		   return result;
        }


	}
			
			}
//Loaded from C:\DEV\Vision\ImageProcessingLibrary.AForge\bin\Debug
