
using ImageSharp;
using ImageSharp.Formats;
using ImageSharp.PixelFormats;
using System;
using System.IO;

namespace dotItUp.shared {
    public class DotImage{
        // private Image image = null;
        public bool loadImage(string imagePath) {
            Image<Rgba32> image = null;
            // using (FileStream fileStream =
            // File.OpenRead(imagePath))
            // {
            //     Image newImage = new Image(400, 400);
                
            //     Color[] pixels = newImage.Pixels;
                
            //     for(int i = 0; i < pixels.Length; i++)
            //     {
            //         pixels[i].R = 0xff;
            //     }
                
            //     newImage.SetPixels(400, 400, pixels);
            //     newImage.SaveAsJpeg(fileStream);
            // }
            Console.Write("bamm");
            using (FileStream fileStream = File.OpenRead(imagePath)) {
                Console.Write(fileStream);
                
                image = Image.Load(fileStream);
            }
            return true;
        }
    }
}