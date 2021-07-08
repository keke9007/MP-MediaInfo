using System;
using System.IO;
using System.Net.Http;
using Flurl.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://hzlh.oss-cn-hangzhou.aliyuncs.com/InCloud/2021-07-01/e8de87aa-a212-430e-8b64-da686ef3fb35/%E9%A2%86%E5%AF%BC%E4%BA%BA%E4%BC%9A%E8%AE%AE%E6%AD%A3%E5%BC%8F063004%286%29_preview.mp4";
            //url = "E:\\1.mp4";
            //var a = new MediaInfo.MediaInfoWrapper(url);
            var b = new MediaInfo.MediaInfoWrapper(File.OpenRead("E://1.png"));
            var c= new MediaInfo.MediaInfoWrapper("https://hzlh.oss-cn-hangzhou.aliyuncs.com/InCloud/2021-07-07/fb1ac28e-cb21-43fd-9505-312ab3cfb82b/%E4%B8%9A%E5%8A%A1%E7%B3%BB%E7%BB%9F%E5%B7%A6%E4%B8%8A%E8%A7%92%E5%9B%BE%E6%A0%87%281%29.png");
            //var response = "https://hzlh.oss-cn-hangzhou.aliyuncs.com/InCloud/2021-07-07/fb1ac28e-cb21-43fd-9505-312ab3cfb82b/%E4%B8%9A%E5%8A%A1%E7%B3%BB%E7%BB%9F%E5%B7%A6%E4%B8%8A%E8%A7%92%E5%9B%BE%E6%A0%87%281%29.png".GetAsync(completionOption: HttpCompletionOption.ResponseContentRead).Result;
            //var stream = response.GetStreamAsync().Result;
            //var headers = response.ResponseMessage.Headers;
            //System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
            //int width = image.Width;
            //int height = image.Height;
            //stream.Dispose();
            //image.Dispose();
        }
    }
}
