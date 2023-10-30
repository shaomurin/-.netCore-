
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

[ApiController]
//127.0.0.1:xxxx/api/game   Gamecontroller去掉[controller] 访问 game 不管大小写
[Route(template: "api/[controller]/[action]")]
public class Gamecontroller
{
    //127.0.0.1:xxxx/api/jinliu 不分大小写
    [HttpGet]
    public   Data Jinliu(string name, string camp, string mingtu)
    {
        //业务逻辑。。。

        var data = new Data();

        data.Name = "name";
        data.Cmap = "camp";
        data.MingTu = "mingtu";
        data.Gender = "女";
        data.Property = "冰";
        data.Limit = true;

        return data;
    }


    [HttpGet]
    public Data Pame( )

    {
        //业务逻辑。。。

        var data = new Data();

        data.Name = "派蒙";
        data.Cmap = "op";
        data.MingTu = "毁灭";
        data.Gender = "女";
        data.Property = "冰";
        data.Limit = true;

        return data;
    }
}

    
    

       
    
    
