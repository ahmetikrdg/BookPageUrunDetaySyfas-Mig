using bookpage.business.Abstract;
using bookpage.entity;
using bookpage.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bookpage.webui.Controllers
{
    public class BookController:Controller
    {
        private IProductServices _productServices;
        public BookController(IProductServices productServices)
        {
            this._productServices=productServices;
        }
        public IActionResult List()
        {
            var productsViewModel = new ProductListViewModel
            {
               Products = _productServices.GetAll()
            };

            return View(productsViewModel);
        }

        public IActionResult Details(int? id)
        {
            if(id==null)//eğer id yoksa hata sayfası ver
            {
                return NotFound();
            }
            Product product=_productServices.GetById((int)id);//

            if(product==null)//eğer product yoksa hata sayfası
            {
                return NotFound();
            }
            return View(product);//buldunduysa bulduğu product bilgisini sayfaya mdel olarak gönderelim şimdi details cshtml düzenleyelim
        }

        public IActionResult Read(int? id)
        {
            if(id==null)//eğer id yoksa hata sayfası ver
            {
                return NotFound();
            }
            Product product=_productServices.GetById((int)id);//

            if(product==null)//eğer product yoksa hata sayfası
            {
                return NotFound();
            }
            return View(product);//buldunduysa bulduğu product bilgisini sayfaya mdel olarak gönderelim ve readcshtml'de bilgiler gözüksün
        }



    }
}