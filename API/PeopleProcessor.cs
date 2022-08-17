using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class PeopleProcessor
    {
        public async Task<People> LoadPeopleFromApi(int peopleId)
        {
            string url = "";

            if (peopleId > 0)
            {
                url = $"https://swapi.dev/api/people/{ peopleId }";
            }
            else
            {
                throw new Exception("Invalid input");
            }

            using (HttpResponseMessage apiResponse = await ApiConnectionHelper.ApiConnection.GetAsync(url))
            {
                if (apiResponse.IsSuccessStatusCode)
                {
                    People retrivedPeople = await apiResponse.Content.ReadAsAsync<People>();
                    
                    return retrivedPeople;
                }
                else
                {
                    throw new Exception(apiResponse.ReasonPhrase);
                }
            }
        }

        

    }
}
