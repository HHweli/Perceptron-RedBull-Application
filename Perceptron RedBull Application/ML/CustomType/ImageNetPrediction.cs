using Microsoft.ML.Data;

namespace Perceptron_RedBull_Application.ML.CustomType
{
    public class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}
