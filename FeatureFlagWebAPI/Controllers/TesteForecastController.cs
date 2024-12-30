using C3i.GerenciadorFeatureFlags;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFlagWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase
{
    private readonly AppSettingsFeatureFlagProvider _providerFeatureFlag;

    public TesteController(AppSettingsFeatureFlagProvider providerFeatureFlag)
    {
        _providerFeatureFlag = providerFeatureFlag;
    }

    [HttpGet("ativa")]
    public IActionResult TesteFuncionalidadeAtiva()
    {
        
        if (_providerFeatureFlag.IsFeatureEnabled("FuncionalidadeAtiva"))
        {
            return Ok("A funcionalidade ativa está disponível!");
        }
        return NotFound("A funcionalidade ativa está desabilitada.");
    }

    [HttpGet("inativa")]
    public IActionResult TesteFuncionalidadeInativa()
    {
        if (_providerFeatureFlag.IsFeatureEnabled("FuncionalidadeInativa"))
        {
            return Ok("A funcionalidade inativa está disponível!");
        }
        return NotFound("A funcionalidade inativa está desabilitada.");
    }
}