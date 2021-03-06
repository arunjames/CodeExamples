﻿using Insight.Cqrs.Commands;
using System;

namespace Domain.Commands
{
    public class CreatePartCommand : Command
    {
        public string PartNumber { get; private set; }
        public string PartDescription { get; private set; }
        public int UnitOfMeasure { get; private set; }
        public int SalesLeadTime { get; private set; }

        public CreatePartCommand(Guid aggregateId, string partNumber, string partDescription, int unitOfMeasure, int salesLeadTime)
            : base(aggregateId)
        {
            SalesLeadTime = salesLeadTime;
            UnitOfMeasure = unitOfMeasure;
            PartDescription = partDescription;
            PartNumber = partNumber;
        }
    }
}
