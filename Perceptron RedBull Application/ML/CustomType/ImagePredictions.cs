using Microsoft.ML.Data;

namespace Perceptron_RedBull_Application.ML.CustomType
{
    public class ImagePredictions
    {
        [ColumnName("model_outputs0")]
        public float[] PredictedLabels { get; set; }
    }
}
