using _21_InterfaceAbstractDemo.Abstract;
using _21_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace _21_InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (Convert.ToInt64(customer.NationalityID),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
