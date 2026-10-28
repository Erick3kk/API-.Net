using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApi.Controllers;

[ApiController]
[Route("api/v1/medical-records")]
[Authorize]
public class MedicalRecordsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllRecords()
    {
        return Ok(new { message = "Retornando todos os prontuários do MongoDB." });
    }

    [HttpGet("{id}")]
    public IActionResult GetRecordById(string id)
    {
        return Ok(new { message = $"Retornando o prontuário {id} do MongoDB." });
    }

    [HttpPost]
    public IActionResult CreateRecord([FromBody] object record)
    {
        return Created("", new { message = "Prontuário criado com sucesso no MongoDB." });
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecord(string id, [FromBody] object record)
    {
        return Ok(new { message = $"Prontuário {id} atualizado/versionado com sucesso." });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRecord(string id)
    {
        return Ok(new { message = $"Prontuário {id} inativado/removido com sucesso (Soft Delete recomendado)." });
    }
}
