using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetLibrary.Interfaces
{
    public interface IAppUser
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }

        public int? Age { get; set; }

        public string? City { get; set; }
                
    }
}
