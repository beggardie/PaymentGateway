﻿using System;
using CO.PaymentGateway.Business.Core.Enums;

namespace CO.PaymentGateway.Business.Core.UseCases.PaymentProcess.Commands
{
    public class PaymentProcessResponse
    {
        public int PaymentProcessId { get; set; }

        public Guid ContextId { get; set; }

        public PaymentStatus PaymentAcceptanceStatus { get; set; }
    }
}