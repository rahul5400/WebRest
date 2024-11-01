using System.Collections;
using Microsoft.AspNetCore.Mvc;
using WebRestEF.EF.Models;

namespace WebRest.Controllers
{
    public interface iController<T>
    {
        Task<IActionResult> Delete(string id);
        Task<ActionResult<IEnumerable<T>>> Get();
        Task<ActionResult<T>> Get(string id);
        Task<IActionResult> Put(string id, T _item);
        Task<ActionResult<T>> Post(T _item);
        
    }
}