using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using QLBansach.Models;

public class SachController : ApiControllerAttribute
{
    SachCla[] sach = new SachCla[]

    {
        new SachCla
            {
                Id= 1,
                Title="Tôi thấy hoa vàng trên cỏ xanh",
                AuthorName="Pham Nguyen",
                Price=1,
                Content="truyện kể về tuổi thơ..."
            },
            new SachCla
            {
                Id= 2,
                Title="Pro ASP.NET MVC5",
                AuthorName="Administrator",
                Price=3.5M,
                Content="the ASP.MVC 5 Framework is the latest evolution of Microshoft's ASP.NET web platform"
            }
    };
public IHttpActionResult GetSach(int id)
{
    var sach = sach.FirstOrDeFault((p) => p.Id == id);
    if (sach == null)
    {
        return NotFound();
    }
    { 
    return Ok(Sach);
    }
}