using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITServiceService
    {
        List<Type_of_serviceDTO> GetAllTServices();
        Type_of_serviceDTO GetTService(int motoId);
        void CreateTService(Type_of_serviceDTO p);
        void UpdateTService(Type_of_serviceDTO p);
        void DeleteTService(int id);
    }
}
