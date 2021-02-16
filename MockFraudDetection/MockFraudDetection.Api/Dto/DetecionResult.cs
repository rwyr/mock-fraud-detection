using System;

namespace MockFraudDetection.Api.Dto
{
    public record DetecionResult(Guid Id, bool IsFraud);
}