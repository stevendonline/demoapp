﻿using System;
using MediatR;

namespace Demoapp.SharedKernel
{

    public abstract class BaseDomainEvent : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}