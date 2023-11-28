// using Microsoft.ML;
// using WebApplication2.Models;
//
// namespace WebApplication2;
//
// public class TrainedModel
// {
//     private MLContext mlContext = new MLContext();
//     private PredictionEngine<Digit, IrisPrediction> predEngine;
//     public TrainedModel() {
//         DataViewSchema modelSchema;
//         var model = mlContext.Model.Load("model", out modelSchema);
//         predEngine = mlContext.Model.CreatePredictionEngine<Digit, IrisPrediction>(model);
//     }
//     public string Predict(Digit digit)
//     {
//         var prediction = predEngine.Predict(digit);
//         return prediction.PredictedLabel;
//     }
// }