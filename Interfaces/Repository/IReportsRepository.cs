﻿using Interfaces.DTO;
using System.Collections.Generic;

namespace Repository
{

    public interface IReportsRepository 
    {
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        List<SQLzapros> ExecuteSP(int month, int year);
        List<ReportData> MotosOfType(int manufId);
    }

}
