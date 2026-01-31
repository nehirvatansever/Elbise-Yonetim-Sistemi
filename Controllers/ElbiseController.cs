using Microsoft.AspNetCore.Mvc;

public class ElbiseController : Controller
{

  static List<Elbise> elbiseList = new List<Elbise>()
        {
            new Elbise(){Id=1, Renk="Kırmızı", Fiyat=100, Model="Slim Fit", Beden="S"},
            new Elbise(){Id=2, Renk="Mavi", Fiyat=150, Model="Regular Fit", Beden="M"},
            new Elbise(){Id=3, Renk="Siyah", Fiyat=200, Model="Oversize", Beden="L"},
            new Elbise(){Id=4, Renk="Beyaz", Fiyat=250, Model="Classic Fit", Beden="XL"},
        };

    public IActionResult List(string? filter)
    {
        List<Elbise> filteredList = elbiseList;

        if (!string.IsNullOrEmpty(filter))
        {
            filteredList = filter.ToLower() switch
            {
                "ucuz" => elbiseList.Where(e => e.Fiyat < 150).ToList(),
                "orta" => elbiseList.Where(e => e.Fiyat >= 150 && e.Fiyat <= 200).ToList(),
                "pahali" => elbiseList.Where(e => e.Fiyat > 200).ToList(),
                "kirmizi" => elbiseList.Where(e => e.Renk.ToLower() == "kırmızı").ToList(),
                "mavi" => elbiseList.Where(e => e.Renk.ToLower() == "mavi").ToList(),
                "siyah" => elbiseList.Where(e => e.Renk.ToLower() == "siyah").ToList(),
                "beyaz" => elbiseList.Where(e => e.Renk.ToLower() == "beyaz").ToList(),
                "s" => elbiseList.Where(e => e.Beden.ToUpper() == "S").ToList(),
                "m" => elbiseList.Where(e => e.Beden.ToUpper() == "M").ToList(),
                "l" => elbiseList.Where(e => e.Beden.ToUpper() == "L").ToList(),
                "xl" => elbiseList.Where(e => e.Beden.ToUpper() == "XL").ToList(),
                _ => elbiseList
            };
        }

        ViewBag.CurrentFilter = filter;
        return View(filteredList);
    }


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Elbise elbise)
    {
        elbiseList.Add(elbise);
        return RedirectToAction("List");
        
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var elbise = elbiseList.FirstOrDefault(e => e.Id == id);
        if (elbise == null)
        {
            return RedirectToAction("List");
        }
        return View(elbise);
    }

    [HttpPost]
    public IActionResult Edit(Elbise elbise)
    {
        var mevcutElbise = elbiseList.FirstOrDefault(e => e.Id == elbise.Id);
        if (mevcutElbise != null)
        {
            mevcutElbise.Renk = elbise.Renk;
            mevcutElbise.Fiyat = elbise.Fiyat;
            mevcutElbise.Model = elbise.Model;
            mevcutElbise.Beden = elbise.Beden;
        }
        return RedirectToAction("List");
    }

 

    public IActionResult Delete(int id)
    {
        var elibse =  elbiseList.FirstOrDefault(elibse => elibse.Id == id);
        if(elibse != null)
        {
            elbiseList.Remove(elibse);
        }
        return RedirectToAction("List");
    }

}