using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    // Sektörde PersonService olarak da kullanılır
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            //mernis kontrolü yapılacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            //return client.TCKimlikNoDogrulaAsync(
            //    new TCKimlikNoDogrulaRequest
            //    (new TCKimlikNoDogrulaRequestBody(123, "BEYZA", "ÇEVRİM", 2003)))
            //    .Result.Body.TCKimlikNoDogrulaResult;

    //        return client.TCKimlikNoDogrulaAsync(
    //            new TCKimlikNoDogrulaRequest(
    //                new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateOfBirthYear)))
    //.Result.Body.TCKimlikNoDogrulaResult;

            return client.TCKimlikNoDogrulaAsync(
            person.NationalIdentity,
            person.FirstName.ToUpper(),
            person.LastName.ToUpper(),
            person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
