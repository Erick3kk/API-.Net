using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApi.Controllers;

[ApiController]
[Route("api/v1/telemetry/events")]
public class TelemetryController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllTelemetryData()
    {
        return Ok(new { message = "Retornando todos os dados de telemetria." });
    }

    [HttpGet("{id}")]
    public IActionResult GetTelemetryDataById(string id)
    {
        return Ok(new { message = $"Retornando dados de telemetria {id}." });
    }

    [HttpPost]
    public IActionResult IngestTelemetryData([FromBody] object telemetryData)
    {
        return Accepted(new { message = "Dados de telemetria recebidos e na fila de ingestão." });
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTelemetryData(string id, [FromBody] object telemetryData)
    {
        return Ok(new { message = $"Dados de telemetria {id} atualizados com sucesso." });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTelemetryData(string id)
    {
        return Ok(new { message = $"Dados de telemetria {id} removidos com sucesso." });
    }
}
