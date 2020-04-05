﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron_RedBull_Application.ML.Const
{
    public class ML_Path
    {
        public static string TRAIN_DATA_SET = Path.Combine(Environment.CurrentDirectory, "ML", "Data_Set_Train");
        public static string TEST_DATA_SET = Path.Combine(Environment.CurrentDirectory, "ML", "Data_Set_Test");
    }
}
