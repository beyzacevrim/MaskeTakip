using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //class çıplak bırakma! her zaman bunu düşünmelisin!
    public class PttManager : ISupplierServise
    {

        private IApplicantService _applicantService;

        //Constructer
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if(_applicantService.CheckPerson(person))// personManager veya foreignerManager yerine _applicantService kullandık 
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }

    
    }
}
