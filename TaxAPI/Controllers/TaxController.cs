using Microsoft.AspNetCore.Mvc;
using TaxAPI.Entities;

namespace TaxAPI.Controllers;

[ApiController]
[Route("")]
public class TaxController : ControllerBase {
    private double interestRate { get; set; }

    public TaxController(IConfiguration configuration) {
        this.interestRate = configuration.GetValue<double>("interestRate");
    }

    [HttpGet("interestRate")]
    public Tax GetInterestRate() {
        return new Tax(this.interestRate);
    }
}
