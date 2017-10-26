using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    //NEVER DO THIS!!!
    //This only for demonstration/Academic purposes
    public class Repositoty
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }

        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);

        }

    }
}
//IEnumerable --> percorre todos os elementos da Lista
