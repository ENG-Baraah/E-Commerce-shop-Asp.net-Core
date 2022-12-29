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
using System.IO;
using Ecommerceclothes.Utility;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerceclothes.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]

    [Area("Admin")]
    
    public class MensController: Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public MensViewModel MensVM { get; set; }


        public MensController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            MensVM = new MensViewModel()
            {
                ProductTypes = _db.ProductTypes.ToList(),
                SpecialTags = _db.SpecialTags.ToList(),
                Mens = new Models.Mens()
            };

        }


        public async Task<IActionResult> Index()
        {
            var Mens = _db.Mens.Include(m => m.ProductTypes).Include(m => m.SpecialTags);
            return View(await Mens.ToListAsync());
        }

        //Get : Products Create
        public IActionResult Create()
        {
            return View(MensVM);
        }

        //Post : Products Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(MensVM);
            }

            _db.Mens.Add(MensVM.Mens);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var productsFromDb = _db.Mens.Find(MensVM.Mens.Id);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, MensVM.Mens.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + MensVM.Mens.Id + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + MensVM.Mens.Id + ".png");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + MensVM.Mens.Id + ".png";
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

            MensVM.Mens = await _db.Mens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (MensVM.Mens == null)
            {
                return NotFound();
            }

            return View(MensVM);
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

                var productFromDb = _db.Mens.Where(m => m.Id == MensVM.Mens.Id).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(productFromDb.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, MensVM.Mens.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, MensVM.Mens.Id + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, MensVM.Mens.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    MensVM.Mens.Image = @"\" + SD.ImageFolder + @"\" + MensVM.Mens.Id + extension_new;
                }

                if (MensVM.Mens.Image != null)
                {
                    productFromDb.Image = MensVM.Mens.Image;
                }

                productFromDb.Name = MensVM.Mens.Name;
                productFromDb.Price = MensVM.Mens.Price;
                productFromDb.Available = MensVM.Mens.Available;
                productFromDb.ProductTypeId = MensVM.Mens.ProductTypeId;
                productFromDb.SpecialTagsID = MensVM.Mens.SpecialTagsID;
                productFromDb.ShadeColor = MensVM.Mens.ShadeColor;
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(MensVM);
        }


        //GET : Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MensVM.Mens = await _db.Mens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (MensVM.Mens == null)
            {
                return NotFound();
            }

            return View(MensVM);
        }

        //GET : Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MensVM.Mens = await _db.Mens.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if (MensVM.Mens == null)
            {
                return NotFound();
            }

            return View(MensVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            Mens Mens = await _db.Mens.FindAsync(id);

            if (Mens == null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(Mens.Image);

                if (System.IO.File.Exists(Path.Combine(uploads, Mens.Id + extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, Mens.Id + extension));
                }
                _db.Mens.Remove(Mens);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }

    }
}
