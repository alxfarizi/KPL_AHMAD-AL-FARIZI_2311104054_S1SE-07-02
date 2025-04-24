using System;
using Microsoft.AspNetCore.Mvc;

namespace MahasiswaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Fariz", Nim = "1302000001" },
            new Mahasiswa { Nama = "Kafka", Nim = "1302000002" },
            new Mahasiswa { Nama = "Farhan", Nim = "1302000003" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return mahasiswas;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id >= 0 && id < mahasiswas.Count)
            {
                return mahasiswas[id];
            }
            return NotFound();
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }
 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < mahasiswas.Count)
            {
                mahasiswas.RemoveAt(id);
            }
        }
    }

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}