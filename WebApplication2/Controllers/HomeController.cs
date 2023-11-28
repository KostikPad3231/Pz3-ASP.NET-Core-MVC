using System.Buffers.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using WebApplication1;
using Image = WebApplication2.Models.Image;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet("/api/lastPredictions")]
    public IActionResult LastImages()
    {
        List<string> images = new List<string>();
        DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine("wwwroot", "images"));
        List<FileInfo> files = directoryInfo.GetFiles().OrderByDescending(f => f.CreationTime).Take(10).ToList();
        List<string> base64Files = new List<string>();
        foreach (var file in files)
        {
            using (FileStream fileStream = file.OpenRead())
            {
                byte[] imageBytes = new byte[fileStream.Length];
                fileStream.Read(imageBytes, 0, (int)fileStream.Length);

                string base64String = Convert.ToBase64String(imageBytes);

                base64Files.Add(base64String);
            }
        }

        ViewBag.Images = base64Files;
        return PartialView("LastImages");
    }

    [Consumes("application/json")]
    [HttpPost("/api/uploadImage")]
    public IActionResult UploadImage([FromBody] Image image)
    {
        string imageData = image.imageData;
        byte[] imageAsBytes = Convert.FromBase64String(imageData);
        using (MemoryStream ms = new MemoryStream(imageAsBytes))
        {
            using (Bitmap originalBitmap = new Bitmap(ms))
            {
                var destRect = new Rectangle(0, 0, 28, 28);
                using (Bitmap newImage = new Bitmap(28, 28))
                {
                    newImage.SetResolution(originalBitmap.HorizontalResolution, originalBitmap.VerticalResolution);

                    using (var g = Graphics.FromImage(newImage))
                    {
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.Clear(Color.White);

                        g.DrawImage(originalBitmap, destRect, 0, 0, originalBitmap.Width, originalBitmap.Height,GraphicsUnit.Pixel);

                        Color pixelColor;
                        var sampleData = new MLModel1.ModelInput();
                        Type modelType = typeof(MLModel1.ModelInput);
                        int x, y;
                        for (x = 0; x < newImage.Width; x++)
                        {
                            for (y = 0; y < newImage.Height; y++)
                            {
                                pixelColor = newImage.GetPixel(y, x);
                                int greyValue = 255 - (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                                newImage.SetPixel(y, x, Color.FromArgb(pixelColor.A, greyValue, greyValue, greyValue));
                                var pixelProperty = modelType.GetProperty($"Col{x * newImage.Width + y + 1}");
                                pixelProperty!.SetValue(sampleData, greyValue);
                            }
                        }
                        
                        newImage.Save(Path.Combine("wwwroot", "images", $"{DateTime.UtcNow.ToString("yyyyMMdd_hhmmss")}.png"));

                        var result = MLModel1.Predict(sampleData);
                        return Ok(new { message = result.PredictedLabel });
                    }
                }
            }
        }
    }
}