using App03.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using System.IO;

namespace App03.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyForm(string usertext, int num)
        {
            if (string.IsNullOrEmpty(usertext)) { usertext = "No data is available"; }
            if(num<=0) { num = 1; }

            ViewBag.Usertext = usertext;
            ViewBag.Num = num;

            return View(); 
        }
        public IActionResult FileData()
        {
            return View();
        }
        public IActionResult ShowFileData()
        {
            string rootfolder = @"C:\";
            string[] filelist = System.IO.Directory.GetFiles(rootfolder);

            List<FileDetail> fdlist=new List<FileDetail>(); 
            for (int i = 0; i < filelist.Length; i++) {

                FileDetail d = new FileDetail()
                {

                    Id = i + 1,
                    FileName = @System.IO.Path.GetFileNameWithoutExtension(filelist[i]),
                    Extension = @System.IO.Path.GetExtension(filelist[i]),
                    FullPath = @filelist[i]
                };
                fdlist.Add(d);
            }
            return View(fdlist);
        }
    }
}
 