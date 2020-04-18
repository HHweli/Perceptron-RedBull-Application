using Microsoft.ML.Transforms.Image;
using System.Drawing;

namespace Perceptron_RedBull_Application.ML.CustomType
{
    public struct ImageSettings
    {
        public const int imageHeight = 416;
        public const int imageWidth = 416;
    }

    public class ImageInput
    {
        [ImageType(ImageSettings.imageHeight, ImageSettings.imageWidth)]
        public Bitmap Image { get; set; }
    }
}
