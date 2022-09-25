using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreMVCLayout.Models;
using System.Collections;

namespace ASPNetCoreMVCLayout.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // GET: Home
    // การใช้คีย์ลัดในการ comment
    // Ctrl+k, Ctrl+c
    // เอา comment ออก
    // Ctrl+k, Ctrl+u

    public IActionResult Index(int id)
    // public string Index(int id)
    {
        //return "id:"+ id.ToString();
        // return "id:" + $"{id}"; // Template string in C# 10

        // การส่ง (pass) ตัวแปรไปแสดงผลที่ View
        // เราสามารถทำได้ 3 คำสั่งด้วยกัน

        // 1. ผ่าน ViewBag.name
        // ViewBag.id = id;

        // 2. ผ่าน ViewData["name"]
       //  ViewData["id"] = id;

        // 3. ผ่าน TempData["name"]
        TempData["id"] = id;

        return View();
    }

    // https://localhost:7175/Home/About
    //public string About()
    //{
    //    return "About Page";
    //}

    public IActionResult About()
    {
        var userDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        ViewData["mytime"] = userDate;

        // ส่งข้อมูลแบบ List
        ArrayList Colors = new ArrayList();
        Colors.Add("Red");
        Colors.Add("Green");
        Colors.Add("Blue");
        Colors.Add("Yellow");

        ViewData["myColor"] = Colors;

        return View();
    }

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    public IActionResult Service()
    {
        return View();
    }

    public IActionResult Portfolio()
    {
        return View();
    }

    public IActionResult Team()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
