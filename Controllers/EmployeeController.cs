using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDbyAjaxinASP.NETCoreMVC.Models;
using static CRUDbyAjaxinASP.NETCoreMVC.Helper;

namespace CRUDbyAjaxinASP.NETCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly dbcontext _context;

        public EmployeeController(dbcontext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.employee.ToListAsync());
        }

        

        // GET: Employee/AddOrEdit
        // GET: Employee/AddOrEdit/id
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new employeemodel());
            else
            {

                var employeemodel = await _context.employee.FindAsync(id);
                if (employeemodel == null)
                {
                    return NotFound();
                }
                return View(employeemodel);
            }
        }

       
        // GET: Employee/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeemodel = await _context.employee.FindAsync(id);
            if (employeemodel == null)
            {
                return NotFound();
            }
            return View(employeemodel);
        }

        // POST: Employee/AddOrEdit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("id,name,age,salary,moblie,Date")] employeemodel employeemodel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    employeemodel.Date = DateTime.Now;
                    _context.Add(employeemodel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(employeemodel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!employeemodelExists(employeemodel.id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                
                return Json(new {isValid=true,html=Helper.RenderRazorViewToString(this, "_ViewAll", _context.employee.ToList()) });
            }
            return Json(new { isValid = false, html =Helper.RenderRazorViewToString(this, "AddOrEdit", employeemodel) });
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeemodel = await _context.employee
                .FirstOrDefaultAsync(m => m.id == id);
            if (employeemodel == null)
            {
                return NotFound();
            }

            return View(employeemodel);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeemodel = await _context.employee.FindAsync(id);
            _context.employee.Remove(employeemodel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.employee.ToList()) });
        }

        private bool employeemodelExists(int id)
        {
            return _context.employee.Any(e => e.id == id);
        }
    }
}
