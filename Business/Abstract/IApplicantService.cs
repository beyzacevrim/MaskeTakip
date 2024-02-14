using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        // metodların imzalarını içerir.
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
        
    }
}
