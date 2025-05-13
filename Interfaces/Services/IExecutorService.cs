﻿using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IExecutorService
    {
        List<ExecutorDTO> GetAllExecutors();
        ExecutorDTO GetExecutor(int Id);
    }
}
