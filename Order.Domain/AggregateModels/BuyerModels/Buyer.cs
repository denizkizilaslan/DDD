﻿using Order.Domain.SeedWork;
using System;

namespace Order.Domain.AggregateModels.BuyerModels
{
    public class Buyer : BaseEntity
    {
        public string UserName { get;private set; }

        public Buyer(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
