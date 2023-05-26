﻿using System.Runtime.CompilerServices;
namespace ASP_111.Services
{
    public class DateTimeService
    {
        //public DateTime GetNow() => DateTime.Now;
        private readonly IDateService _dateService;
        private readonly TimeService _timeService;

        public DateTimeService(IDateService dateService, TimeService timeService)
        {
            _dateService = dateService;
            _timeService = timeService;
        }
        public DateTime GetNow() => _dateService.GetDate() + _timeService.GetTime().ToTimeSpan();
    }
}