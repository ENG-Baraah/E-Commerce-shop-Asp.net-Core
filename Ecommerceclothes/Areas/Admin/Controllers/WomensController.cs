using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerceclothes.Data;
using Ecommerceclothes.Models;
using Microsoft.AspNetCore.Hosting.Internal;
using Ecommerceclothes.Models.ViewModel;
using Ecommerceclothes.Utility;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerceclothes.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]

    [Area("Admin")]
    public class WomensController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public WomensViewModel WomensVM { get; set; }


        public WomensController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            WomensVM = new WomensViewModel()
            {
                ProductTypes = _db.ProductTypes.ToList(),
                SpecialTags = _db.SpecialTags.ToList(),
                Womens = new Models.Womens()
            };

        }


        public async Task<IActionResult> Index()
        {
            var Womens = _db.Womens.Include(m => m.ProductTypes).Include(m => m.SpecialTags);
            return View(await Womens.ToListAsync());
        }

        //Get : Products Create
        public IActionResult Create()
        {
            return View(WomensVM);
        }

        //Post : Products Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(WomensVM);
            }

            _db.Womens.Add(WomensVM.Womens);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var productsFromDb = _db.Products.Find(WomensVM.Womens.Id);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, WomensVM.Womens.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + WomensVM.Womens.Id + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + WomensVM.Womens.Id + ".png");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + WomensVM.Womens.Id + ".png";
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }



        //GET : Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WomensVM.Womens = await _db.Womens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (WomensVM.Womens == null)
            {
                return NotFound();
            }

            return View(WomensVM);
        }


        //Post : Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var productFromDb = _db.Womens.Where(m => m.Id == WomensVM.Womens.Id).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(productFromDb.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, WomensVM.Womens.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, WomensVM.Womens.Id + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, WomensVM.Womens.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    WomensVM.Womens.Image = @"\" + SD.ImageFolder + @"\" + WomensVM.Womens.Id + extension_new;
                }

                if (WomensVM.Womens.Image != null)
                {
                    productFromDb.Image = WomensVM.Womens.Image;
                }

                productFromDb.Name = WomensVM.Womens.Name;
                productFromDb.Price = WomensVM.Womens.Price;
                productFromDb.Available = WomensVM.Womens.Available;
                productFromDb.ProductTypeId = WomensVM.Womens.ProductTypeId;
                productFromDb.SpecialTagsID = WomensVM.Womens.SpecialTagsID;
                productFromDb.ShadeColor = WomensVM.Womens.ShadeColor;
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(WomensVM);
        }


        //GET : Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WomensVM.Womens = await _db.Womens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (WomensVM.Womens == null)
            {
                return NotFound();
            }

            return View(WomensVM);
        }

        //GET : Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WomensVM.Womens = await _db.Womens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (WomensVM.Womens == null)
            {
                return NotFound();
            }

            return View(WomensVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            Womens Womens = await _db.Womens.FindAsync(id);

            if (Womens == null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(Womens.Image);

                if (System.IO.File.Exists(Path.Combine(uploads, Womens.Id + extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, Womens.Id + extension));
                }
                _db.Womens.Remove(Womens);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }

    }
}
