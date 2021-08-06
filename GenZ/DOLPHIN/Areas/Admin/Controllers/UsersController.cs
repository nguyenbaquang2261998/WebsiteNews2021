//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using DOLPHIN.Model;
//using DOLPHIN.DTO;
//using AutoMapper;
//using DOLPHIN.Repository.UnitOfWorks.Interfaces;

//namespace DOLPHIN.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class UsersController : Controller
//    {
//        private readonly ApplicationDBContext _context;
//        private readonly IMapper mapper;
//        private readonly IUserUnitOfWork unitOfWork;

//        public UsersController(ApplicationDBContext context, IMapper mapper, IUserUnitOfWork unitOfWork)
//        {
//            _context = context;
//            this.mapper = mapper;
//            this.unitOfWork = unitOfWork;
//        }

//        // GET: Admin/Users
//        public IActionResult Index()
//        {
//            var listUsers = _context.Users;
//            return View(listUsers.ToList());
//        }

//        // GET: Admin/Users/Details/5
//        public IActionResult Details(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var users = _context.Users.FirstOrDefault(m => m.Id == id);
//            if (users == null)
//            {
//                return NotFound();
//            }

//            return View(users);
//        }

//        // GET: Admin/Users/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Users/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        public async Task<IActionResult> Create(UsersDto usersDto)
//        {
//            if (ModelState.IsValid)
//            {
//                usersDto.Id = Guid.NewGuid();
//                usersDto.JoinDate = DateTime.Now;
//                usersDto.Status = 0;
//                await this.unitOfWork.UserRepository.Add(this.mapper.Map < ToTrinh > (usersDto));
//                await this.unitOfWork.Commit();
//                return Redirect("/Admin/Users");
//            }
//            return View(usersDto);
//        }

//        // GET: Admin/Users/Edit/5
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var users = await _context.Users.FindAsync(id);
//            if (users == null)
//            {
//                return NotFound();
//            }
//            return View(users);
//        }

//        // POST: Admin/Users/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserName,Password,Email,FullName,JoinDate,Status")] ToTrinh users)
//        {
//            if (id != users.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(users);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!UsersExists(users.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(users);
//        }

//        // GET: Admin/Users/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var users = await _context.Users
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (users == null)
//            {
//                return NotFound();
//            }

//            return View(users);
//        }

//        // POST: Admin/Users/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            var users = await _context.Users.FindAsync(id);
//            _context.Users.Remove(users);
//            await _context.SaveChangesAsync();
//            return Redirect("/Admin/Users/Index");
//        }

//        private bool UsersExists(Guid id)
//        {
//            return _context.Users.Any(e => e.Id == id);
//        }
//    }
//}
