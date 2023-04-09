using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UserCreationDto
    {
        public string UserName { get; }

        public UserCreationDto(string userName)
        {
            UserName = userName;
        }
    }
}
