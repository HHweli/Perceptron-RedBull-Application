using System;

namespace Perceptron_RedBull_Application.ML.CustomType
{
    public class BoundingBox
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Prediction
    {
        public float probability { get; set; }

        public string tagId { get; set; }

        public string tagName { get; set; }

        public BoundingBox boundingBox { get; set; }
    }

    class ResponsePrediction
    {
        public string id { get; set; }
        public string project { get; set; }
        public string iteration { get; set; }
        public DateTime created { get; set; }
        public Prediction[] predictions { get; set; }
    }
}
