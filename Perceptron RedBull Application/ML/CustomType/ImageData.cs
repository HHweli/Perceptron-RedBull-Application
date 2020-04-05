using Microsoft.ML.Data;

namespace Perceptron_RedBull_Application.ML.CustomType
{
    public class ImageData
    {
        [LoadColumn(0)]
        public string ImagePath { get; set; }

        [LoadColumn(1)]
        public string Label { get; set; }
    }
}
