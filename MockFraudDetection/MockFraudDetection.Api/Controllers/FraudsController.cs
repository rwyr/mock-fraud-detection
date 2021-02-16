using Microsoft.AspNetCore.Mvc;
using MockFraudDetection.Api.Dto;
using System;

namespace MockFraudDetection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FraudsController : ControllerBase
    {
        [Route("detect")]
        public ActionResult<DetecionResult> DetectFraud(TransactionDetails transactionDetails)
        {
            var indicator = DateTime.UtcNow.Ticks % 2;
            var isFraud = indicator == 1;
            var result = new DetecionResult(transactionDetails.Id, isFraud);
            return Ok(result);
        }
    }
}
